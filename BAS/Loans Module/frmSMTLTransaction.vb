'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared
Public Class frmSMTLTransaction
    Inherits System.Windows.Forms.Form
    Private Shared m_FormDefInstance As frmSMTLTransaction
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblInterestReceivable As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents chkCA As System.Windows.Forms.CheckBox
    Friend WithEvents chkSB As System.Windows.Forms.CheckBox
    Friend WithEvents txtTransFund As BankControls.NumericControl
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTrAccountNo As BankControls.TextControl
    Friend WithEvents BtnAccSearch As BankControls.NewButton
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtAmountByCash As BankControls.NumericControl
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkFundTransfer As System.Windows.Forms.CheckBox
    Friend WithEvents chkByCash As System.Windows.Forms.CheckBox
    Friend WithEvents gbInterestTransfer As System.Windows.Forms.GroupBox
    Friend WithEvents rdExcessAmtTrToIR As System.Windows.Forms.RadioButton
    Friend WithEvents rdTrToIol As System.Windows.Forms.RadioButton
    Friend WithEvents rdTrToIr As System.Windows.Forms.RadioButton
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As frmSMTLTransaction
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmSMTLTransaction
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmSMTLTransaction)
            m_FormDefInstance = Value
        End Set
    End Property

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdWithdraw As System.Windows.Forms.RadioButton
    Friend WithEvents rdDeposit As System.Windows.Forms.RadioButton
    Friend WithEvents txtRefno As BankControls.NumericControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAvalBal As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblBookBal As System.Windows.Forms.Label
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents txtAccNo As BankControls.TextControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As BankControls.TextControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents dtpDepositDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents btnCalInterest As BankControls.NewButton
    Friend WithEvents lvPaidDet As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtpLastPaidDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtInterest As BankControls.NumericControl
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtROI As BankControls.NumericControl
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblIntAmount As System.Windows.Forms.Label
    Friend WithEvents btnIntPosting As BankControls.NewButton
    Friend WithEvents rdIntPosing As System.Windows.Forms.RadioButton
    Friend WithEvents btnDeposit As BankControls.NewButton
    Friend WithEvents btnWithDraw As BankControls.NewButton
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtChequeNo As BankControls.TextControl
    Friend WithEvents btnPrint As BankControls.NewButton
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSMTLTransaction))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.gbInterestTransfer = New System.Windows.Forms.GroupBox
        Me.rdExcessAmtTrToIR = New System.Windows.Forms.RadioButton
        Me.rdTrToIol = New System.Windows.Forms.RadioButton
        Me.rdTrToIr = New System.Windows.Forms.RadioButton
        Me.chkByCash = New System.Windows.Forms.CheckBox
        Me.chkFundTransfer = New System.Windows.Forms.CheckBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtTrAccountNo = New BankControls.TextControl
        Me.Label35 = New System.Windows.Forms.Label
        Me.BtnAccSearch = New BankControls.NewButton
        Me.chkCA = New System.Windows.Forms.CheckBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.chkSB = New System.Windows.Forms.CheckBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.txtTransFund = New BankControls.NumericControl
        Me.Label37 = New System.Windows.Forms.Label
        Me.txtAmountByCash = New BankControls.NumericControl
        Me.lblInterestReceivable = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtChequeNo = New BankControls.TextControl
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtROI = New BankControls.NumericControl
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblIntAmount = New System.Windows.Forms.Label
        Me.txtInterest = New BankControls.NumericControl
        Me.Label10 = New System.Windows.Forms.Label
        Me.dtpLastPaidDate = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnCalInterest = New BankControls.NewButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdIntPosing = New System.Windows.Forms.RadioButton
        Me.rdWithdraw = New System.Windows.Forms.RadioButton
        Me.rdDeposit = New System.Windows.Forms.RadioButton
        Me.txtRefno = New BankControls.NumericControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblAvalBal = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblBookBal = New System.Windows.Forms.Label
        Me.txtAmount = New BankControls.NumericControl
        Me.txtAccNo = New BankControls.TextControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNarration = New BankControls.TextControl
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpDepositDate = New System.Windows.Forms.DateTimePicker
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.btnCancel = New BankControls.NewButton
        Me.lvPaidDet = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.btnIntPosting = New BankControls.NewButton
        Me.btnDeposit = New BankControls.NewButton
        Me.btnWithDraw = New BankControls.NewButton
        Me.btnPrint = New BankControls.NewButton
        Me.Panel1.SuspendLayout()
        Me.gbInterestTransfer.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.gbInterestTransfer)
        Me.Panel1.Controls.Add(Me.chkByCash)
        Me.Panel1.Controls.Add(Me.chkFundTransfer)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.txtAmountByCash)
        Me.Panel1.Controls.Add(Me.lblInterestReceivable)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtChequeNo)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtROI)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lblIntAmount)
        Me.Panel1.Controls.Add(Me.txtInterest)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.dtpLastPaidDate)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.btnCalInterest)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtRefno)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblAvalBal)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblBookBal)
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Controls.Add(Me.txtAccNo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtNarration)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dtpDepositDate)
        Me.Panel1.Location = New System.Drawing.Point(16, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(980, 326)
        Me.Panel1.TabIndex = 0
        '
        'gbInterestTransfer
        '
        Me.gbInterestTransfer.Controls.Add(Me.rdExcessAmtTrToIR)
        Me.gbInterestTransfer.Controls.Add(Me.rdTrToIol)
        Me.gbInterestTransfer.Controls.Add(Me.rdTrToIr)
        Me.gbInterestTransfer.Location = New System.Drawing.Point(322, 0)
        Me.gbInterestTransfer.Name = "gbInterestTransfer"
        Me.gbInterestTransfer.Size = New System.Drawing.Size(370, 48)
        Me.gbInterestTransfer.TabIndex = 649
        Me.gbInterestTransfer.TabStop = False
        Me.gbInterestTransfer.Visible = False
        '
        'rdExcessAmtTrToIR
        '
        Me.rdExcessAmtTrToIR.BackColor = System.Drawing.Color.LightYellow
        Me.rdExcessAmtTrToIR.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.rdExcessAmtTrToIR.Location = New System.Drawing.Point(192, 12)
        Me.rdExcessAmtTrToIR.Name = "rdExcessAmtTrToIR"
        Me.rdExcessAmtTrToIR.Size = New System.Drawing.Size(166, 24)
        Me.rdExcessAmtTrToIR.TabIndex = 3
        Me.rdExcessAmtTrToIR.TabStop = True
        Me.rdExcessAmtTrToIR.Text = "Excess Amt Tr To IR"
        Me.rdExcessAmtTrToIR.UseVisualStyleBackColor = False
        '
        'rdTrToIol
        '
        Me.rdTrToIol.BackColor = System.Drawing.Color.LightYellow
        Me.rdTrToIol.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.rdTrToIol.Location = New System.Drawing.Point(8, 12)
        Me.rdTrToIol.Name = "rdTrToIol"
        Me.rdTrToIol.Size = New System.Drawing.Size(88, 24)
        Me.rdTrToIol.TabIndex = 1
        Me.rdTrToIol.TabStop = True
        Me.rdTrToIol.Text = "Tr to IOL"
        Me.rdTrToIol.UseVisualStyleBackColor = False
        '
        'rdTrToIr
        '
        Me.rdTrToIr.BackColor = System.Drawing.Color.LightYellow
        Me.rdTrToIr.Checked = True
        Me.rdTrToIr.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.rdTrToIr.Location = New System.Drawing.Point(104, 12)
        Me.rdTrToIr.Name = "rdTrToIr"
        Me.rdTrToIr.Size = New System.Drawing.Size(80, 24)
        Me.rdTrToIr.TabIndex = 2
        Me.rdTrToIr.TabStop = True
        Me.rdTrToIr.Text = "Tr to IR"
        Me.rdTrToIr.UseVisualStyleBackColor = False
        '
        'chkByCash
        '
        Me.chkByCash.BackColor = System.Drawing.Color.LightYellow
        Me.chkByCash.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkByCash.Location = New System.Drawing.Point(698, 205)
        Me.chkByCash.Name = "chkByCash"
        Me.chkByCash.Size = New System.Drawing.Size(79, 24)
        Me.chkByCash.TabIndex = 648
        Me.chkByCash.Text = "By Cash"
        Me.chkByCash.UseVisualStyleBackColor = False
        Me.chkByCash.Visible = False
        '
        'chkFundTransfer
        '
        Me.chkFundTransfer.BackColor = System.Drawing.Color.LightYellow
        Me.chkFundTransfer.Enabled = False
        Me.chkFundTransfer.Font = New System.Drawing.Font("Georgia", 9.0!)
        Me.chkFundTransfer.Location = New System.Drawing.Point(698, 24)
        Me.chkFundTransfer.Name = "chkFundTransfer"
        Me.chkFundTransfer.Size = New System.Drawing.Size(112, 16)
        Me.chkFundTransfer.TabIndex = 643
        Me.chkFundTransfer.Text = "Fund Transfer"
        Me.chkFundTransfer.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(695, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(280, 154)
        Me.Panel3.TabIndex = 644
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTrAccountNo)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.BtnAccSearch)
        Me.GroupBox2.Controls.Add(Me.chkCA)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.chkSB)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.txtTransFund)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 138)
        Me.GroupBox2.TabIndex = 647
        Me.GroupBox2.TabStop = False
        '
        'txtTrAccountNo
        '
        Me.txtTrAccountNo.AlphaNumeric = True
        Me.txtTrAccountNo.BackColor = System.Drawing.Color.White
        Me.txtTrAccountNo.BlankSpace = False
        Me.txtTrAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrAccountNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtTrAccountNo.Location = New System.Drawing.Point(106, 45)
        Me.txtTrAccountNo.LostFocusColour = System.Drawing.Color.White
        Me.txtTrAccountNo.Mandatory = False
        Me.txtTrAccountNo.MaxLength = 10
        Me.txtTrAccountNo.Name = "txtTrAccountNo"
        Me.txtTrAccountNo.ReadOnly = True
        Me.txtTrAccountNo.Size = New System.Drawing.Size(128, 23)
        Me.txtTrAccountNo.SpecialChar = False
        Me.txtTrAccountNo.TabIndex = 9
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(20, 49)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(82, 14)
        Me.Label35.TabIndex = 66
        Me.Label35.Text = "Account No:"
        '
        'BtnAccSearch
        '
        Me.BtnAccSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAccSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAccSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAccSearch.ForeColor = System.Drawing.Color.Black
        Me.BtnAccSearch.GotFocusColour = System.Drawing.Color.LightYellow
        Me.BtnAccSearch.Image = CType(resources.GetObject("BtnAccSearch.Image"), System.Drawing.Image)
        Me.BtnAccSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAccSearch.Location = New System.Drawing.Point(242, 45)
        Me.BtnAccSearch.LostFocusColour = System.Drawing.Color.LightYellow
        Me.BtnAccSearch.Name = "BtnAccSearch"
        Me.BtnAccSearch.Size = New System.Drawing.Size(24, 24)
        Me.BtnAccSearch.TabIndex = 8
        '
        'chkCA
        '
        Me.chkCA.BackColor = System.Drawing.Color.LightYellow
        Me.chkCA.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCA.Location = New System.Drawing.Point(106, 21)
        Me.chkCA.Name = "chkCA"
        Me.chkCA.Size = New System.Drawing.Size(48, 24)
        Me.chkCA.TabIndex = 7
        Me.chkCA.Text = "CA"
        Me.chkCA.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(106, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 16)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "0.0"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label14.Visible = False
        '
        'chkSB
        '
        Me.chkSB.BackColor = System.Drawing.Color.LightYellow
        Me.chkSB.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSB.Location = New System.Drawing.Point(10, 21)
        Me.chkSB.Name = "chkSB"
        Me.chkSB.Size = New System.Drawing.Size(48, 24)
        Me.chkSB.TabIndex = 6
        Me.chkSB.Text = "SB"
        Me.chkSB.UseVisualStyleBackColor = False
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(6, 77)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(96, 16)
        Me.Label36.TabIndex = 122
        Me.Label36.Text = "AvailBalance:"
        Me.Label36.Visible = False
        '
        'txtTransFund
        '
        Me.txtTransFund.AfterDecimal = 2
        Me.txtTransFund.BeforeDecimal = 8
        Me.txtTransFund.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransFund.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtTransFund.Location = New System.Drawing.Point(106, 101)
        Me.txtTransFund.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtTransFund.MaxLength = 10
        Me.txtTransFund.MaxValue = 0
        Me.txtTransFund.MinValue = 0
        Me.txtTransFund.Name = "txtTransFund"
        Me.txtTransFund.ReadOnly = True
        Me.txtTransFund.Size = New System.Drawing.Size(128, 22)
        Me.txtTransFund.TabIndex = 10
        Me.txtTransFund.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTransFund.Visible = False
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(42, 104)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(60, 14)
        Me.Label37.TabIndex = 124
        Me.Label37.Text = "Amount:"
        Me.Label37.Visible = False
        '
        'txtAmountByCash
        '
        Me.txtAmountByCash.AfterDecimal = 0
        Me.txtAmountByCash.BackColor = System.Drawing.Color.White
        Me.txtAmountByCash.BeforeDecimal = 7
        Me.txtAmountByCash.Enabled = False
        Me.txtAmountByCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountByCash.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmountByCash.Location = New System.Drawing.Point(784, 205)
        Me.txtAmountByCash.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAmountByCash.MaxValue = 0
        Me.txtAmountByCash.MinValue = 0
        Me.txtAmountByCash.Name = "txtAmountByCash"
        Me.txtAmountByCash.Size = New System.Drawing.Size(126, 22)
        Me.txtAmountByCash.TabIndex = 645
        Me.txtAmountByCash.Visible = False
        '
        'lblInterestReceivable
        '
        Me.lblInterestReceivable.AutoSize = True
        Me.lblInterestReceivable.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblInterestReceivable.Location = New System.Drawing.Point(493, 158)
        Me.lblInterestReceivable.Name = "lblInterestReceivable"
        Me.lblInterestReceivable.Size = New System.Drawing.Size(31, 16)
        Me.lblInterestReceivable.TabIndex = 642
        Me.lblInterestReceivable.Text = "0.0"
        Me.lblInterestReceivable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(353, 158)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 16)
        Me.Label13.TabIndex = 641
        Me.Label13.Text = "Interest Receivable"
        '
        'txtChequeNo
        '
        Me.txtChequeNo.AlphaNumeric = True
        Me.txtChequeNo.BlankSpace = False
        Me.txtChequeNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtChequeNo.Location = New System.Drawing.Point(127, 122)
        Me.txtChequeNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtChequeNo.Mandatory = False
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.Size = New System.Drawing.Size(160, 22)
        Me.txtChequeNo.SpecialChar = False
        Me.txtChequeNo.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label12.Location = New System.Drawing.Point(37, 125)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 16)
        Me.Label12.TabIndex = 640
        Me.Label12.Text = "Cheque No."
        '
        'txtROI
        '
        Me.txtROI.AfterDecimal = 2
        Me.txtROI.BackColor = System.Drawing.SystemColors.Window
        Me.txtROI.BeforeDecimal = 8
        Me.txtROI.Enabled = False
        Me.txtROI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.GotFocusColour = System.Drawing.Color.Empty
        Me.txtROI.Location = New System.Drawing.Point(488, 125)
        Me.txtROI.LostFocusColour = System.Drawing.Color.Empty
        Me.txtROI.MaxLength = 10
        Me.txtROI.MaxValue = 0
        Me.txtROI.MinValue = 0
        Me.txtROI.Name = "txtROI"
        Me.txtROI.Size = New System.Drawing.Size(184, 22)
        Me.txtROI.TabIndex = 12
        Me.txtROI.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label15.Location = New System.Drawing.Point(401, 125)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 16)
        Me.Label15.TabIndex = 638
        Me.Label15.Text = "Actuall ROI"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(389, 239)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 16)
        Me.Label11.TabIndex = 636
        Me.Label11.Text = "Total Interest"
        '
        'lblIntAmount
        '
        Me.lblIntAmount.AutoSize = True
        Me.lblIntAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblIntAmount.Location = New System.Drawing.Point(493, 239)
        Me.lblIntAmount.Name = "lblIntAmount"
        Me.lblIntAmount.Size = New System.Drawing.Size(31, 16)
        Me.lblIntAmount.TabIndex = 635
        Me.lblIntAmount.Text = "0.0"
        Me.lblIntAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtInterest
        '
        Me.txtInterest.AfterDecimal = 2
        Me.txtInterest.BackColor = System.Drawing.SystemColors.Window
        Me.txtInterest.BeforeDecimal = 8
        Me.txtInterest.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtInterest.GotFocusColour = System.Drawing.SystemColors.Window
        Me.txtInterest.Location = New System.Drawing.Point(127, 158)
        Me.txtInterest.LostFocusColour = System.Drawing.Color.White
        Me.txtInterest.MaxLength = 10
        Me.txtInterest.MaxValue = 0
        Me.txtInterest.MinValue = 0
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(160, 23)
        Me.txtInterest.TabIndex = 5
        Me.txtInterest.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(60, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 16)
        Me.Label10.TabIndex = 634
        Me.Label10.Text = "Interest"
        '
        'dtpLastPaidDate
        '
        Me.dtpLastPaidDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpLastPaidDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpLastPaidDate.Enabled = False
        Me.dtpLastPaidDate.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.dtpLastPaidDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLastPaidDate.Location = New System.Drawing.Point(488, 58)
        Me.dtpLastPaidDate.Name = "dtpLastPaidDate"
        Me.dtpLastPaidDate.Size = New System.Drawing.Size(144, 23)
        Me.dtpLastPaidDate.TabIndex = 10
        Me.dtpLastPaidDate.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(378, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 16)
        Me.Label9.TabIndex = 632
        Me.Label9.Text = "Last Paid Date"
        '
        'btnCalInterest
        '
        Me.btnCalInterest.BackColor = System.Drawing.Color.LightYellow
        Me.btnCalInterest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalInterest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalInterest.ForeColor = System.Drawing.Color.Black
        Me.btnCalInterest.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnCalInterest.Location = New System.Drawing.Point(294, 158)
        Me.btnCalInterest.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnCalInterest.Name = "btnCalInterest"
        Me.btnCalInterest.Size = New System.Drawing.Size(40, 24)
        Me.btnCalInterest.TabIndex = 6
        Me.btnCalInterest.Text = "Cal Interest"
        Me.btnCalInterest.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdIntPosing)
        Me.GroupBox1.Controls.Add(Me.rdWithdraw)
        Me.GroupBox1.Controls.Add(Me.rdDeposit)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 48)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'rdIntPosing
        '
        Me.rdIntPosing.BackColor = System.Drawing.Color.LightYellow
        Me.rdIntPosing.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.rdIntPosing.Location = New System.Drawing.Point(192, 12)
        Me.rdIntPosing.Name = "rdIntPosing"
        Me.rdIntPosing.Size = New System.Drawing.Size(104, 24)
        Me.rdIntPosing.TabIndex = 3
        Me.rdIntPosing.TabStop = True
        Me.rdIntPosing.Text = "Int Posting"
        Me.rdIntPosing.UseVisualStyleBackColor = False
        '
        'rdWithdraw
        '
        Me.rdWithdraw.BackColor = System.Drawing.Color.LightYellow
        Me.rdWithdraw.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.rdWithdraw.Location = New System.Drawing.Point(8, 12)
        Me.rdWithdraw.Name = "rdWithdraw"
        Me.rdWithdraw.Size = New System.Drawing.Size(88, 24)
        Me.rdWithdraw.TabIndex = 1
        Me.rdWithdraw.TabStop = True
        Me.rdWithdraw.Text = "Withdraw"
        Me.rdWithdraw.UseVisualStyleBackColor = False
        '
        'rdDeposit
        '
        Me.rdDeposit.BackColor = System.Drawing.Color.LightYellow
        Me.rdDeposit.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.rdDeposit.Location = New System.Drawing.Point(104, 12)
        Me.rdDeposit.Name = "rdDeposit"
        Me.rdDeposit.Size = New System.Drawing.Size(80, 24)
        Me.rdDeposit.TabIndex = 2
        Me.rdDeposit.TabStop = True
        Me.rdDeposit.Text = "Deposit"
        Me.rdDeposit.UseVisualStyleBackColor = False
        '
        'txtRefno
        '
        Me.txtRefno.AfterDecimal = 2
        Me.txtRefno.BeforeDecimal = 7
        Me.txtRefno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefno.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRefno.Location = New System.Drawing.Point(127, 231)
        Me.txtRefno.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRefno.MaxValue = 0
        Me.txtRefno.MinValue = 0
        Me.txtRefno.Name = "txtRefno"
        Me.txtRefno.Size = New System.Drawing.Size(160, 22)
        Me.txtRefno.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(25, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "Reference No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(426, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Balance"
        '
        'lblAvalBal
        '
        Me.lblAvalBal.AutoSize = True
        Me.lblAvalBal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblAvalBal.Location = New System.Drawing.Point(493, 215)
        Me.lblAvalBal.Name = "lblAvalBal"
        Me.lblAvalBal.Size = New System.Drawing.Size(31, 16)
        Me.lblAvalBal.TabIndex = 119
        Me.lblAvalBal.Text = "0.0"
        Me.lblAvalBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(403, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 16)
        Me.Label8.TabIndex = 118
        Me.Label8.Text = "SMTL Limit"
        '
        'lblBookBal
        '
        Me.lblBookBal.AutoSize = True
        Me.lblBookBal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblBookBal.Location = New System.Drawing.Point(493, 187)
        Me.lblBookBal.Name = "lblBookBal"
        Me.lblBookBal.Size = New System.Drawing.Size(31, 16)
        Me.lblBookBal.TabIndex = 117
        Me.lblBookBal.Text = "0.0"
        Me.lblBookBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAmount
        '
        Me.txtAmount.AfterDecimal = 0
        Me.txtAmount.BackColor = System.Drawing.Color.White
        Me.txtAmount.BeforeDecimal = 7
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmount.Location = New System.Drawing.Point(127, 194)
        Me.txtAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAmount.MaxValue = 0
        Me.txtAmount.MinValue = 0
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(160, 22)
        Me.txtAmount.TabIndex = 7
        '
        'txtAccNo
        '
        Me.txtAccNo.AlphaNumeric = True
        Me.txtAccNo.BackColor = System.Drawing.Color.White
        Me.txtAccNo.BlankSpace = False
        Me.txtAccNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccNo.Location = New System.Drawing.Point(127, 56)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.White
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.Size = New System.Drawing.Size(128, 22)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(53, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Narration"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(24, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Total Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(36, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Account No"
        '
        'txtNarration
        '
        Me.txtNarration.AlphaNumeric = True
        Me.txtNarration.BlankSpace = True
        Me.txtNarration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtNarration.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNarration.Location = New System.Drawing.Point(127, 267)
        Me.txtNarration.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNarration.Mandatory = False
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarration.Size = New System.Drawing.Size(838, 50)
        Me.txtNarration.SpecialChar = False
        Me.txtNarration.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(438, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 16)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "Name"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.BlankSpace = False
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(488, 94)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(184, 22)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 11
        Me.txtName.TabStop = False
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
        Me.btnSearch.Location = New System.Drawing.Point(264, 56)
        Me.btnSearch.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(85, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Date"
        '
        'dtpDepositDate
        '
        Me.dtpDepositDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDepositDate.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.dtpDepositDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDepositDate.Location = New System.Drawing.Point(127, 88)
        Me.dtpDepositDate.Name = "dtpDepositDate"
        Me.dtpDepositDate.Size = New System.Drawing.Size(144, 23)
        Me.dtpDepositDate.TabIndex = 4
        Me.dtpDepositDate.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightYellow
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 117
        Me.PictureBox1.TabStop = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.LightYellow
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(71, 10)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(169, 23)
        Me.Label32.TabIndex = 116
        Me.Label32.Text = "SMTL Transaction"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightYellow
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(866, 385)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(128, 40)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lvPaidDet
        '
        Me.lvPaidDet.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader2, Me.ColumnHeader10, Me.ColumnHeader7})
        Me.lvPaidDet.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.lvPaidDet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lvPaidDet.FullRowSelect = True
        Me.lvPaidDet.GridLines = True
        Me.lvPaidDet.Location = New System.Drawing.Point(17, 431)
        Me.lvPaidDet.MultiSelect = False
        Me.lvPaidDet.Name = "lvPaidDet"
        Me.lvPaidDet.Size = New System.Drawing.Size(979, 205)
        Me.lvPaidDet.TabIndex = 119
        Me.lvPaidDet.UseCompatibleStateImageBehavior = False
        Me.lvPaidDet.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Paid Date"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ChequeNo"
        Me.ColumnHeader8.Width = 90
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Narration"
        Me.ColumnHeader9.Width = 171
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Credit"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 77
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Debit"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 78
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Balance"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "IntrestRaised"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "IntrestTobePaid"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "IntrestPaid"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Voucher No"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 75
        '
        'btnIntPosting
        '
        Me.btnIntPosting.BackColor = System.Drawing.Color.LightYellow
        Me.btnIntPosting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIntPosting.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIntPosting.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.btnIntPosting.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnIntPosting.Location = New System.Drawing.Point(689, 385)
        Me.btnIntPosting.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnIntPosting.Name = "btnIntPosting"
        Me.btnIntPosting.Size = New System.Drawing.Size(128, 40)
        Me.btnIntPosting.TabIndex = 13
        Me.btnIntPosting.Text = " &Interest Posting"
        Me.btnIntPosting.UseVisualStyleBackColor = False
        Me.btnIntPosting.Visible = False
        '
        'btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.Color.LightYellow
        Me.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeposit.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.btnDeposit.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnDeposit.Image = CType(resources.GetObject("btnDeposit.Image"), System.Drawing.Image)
        Me.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeposit.Location = New System.Drawing.Point(689, 385)
        Me.btnDeposit.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(128, 40)
        Me.btnDeposit.TabIndex = 13
        Me.btnDeposit.Text = "&Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = False
        Me.btnDeposit.Visible = False
        '
        'btnWithDraw
        '
        Me.btnWithDraw.BackColor = System.Drawing.Color.LightYellow
        Me.btnWithDraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithDraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWithDraw.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithDraw.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnWithDraw.Location = New System.Drawing.Point(689, 385)
        Me.btnWithDraw.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnWithDraw.Name = "btnWithDraw"
        Me.btnWithDraw.Size = New System.Drawing.Size(128, 40)
        Me.btnWithDraw.TabIndex = 13
        Me.btnWithDraw.Text = "&Withdraw"
        Me.btnWithDraw.UseVisualStyleBackColor = False
        Me.btnWithDraw.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(17, 385)
        Me.btnPrint.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(120, 40)
        Me.btnPrint.TabIndex = 120
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.Visible = False
        '
        'frmSMTLTransaction
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1010, 645)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.btnWithDraw)
        Me.Controls.Add(Me.btnIntPosting)
        Me.Controls.Add(Me.lvPaidDet)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.btnCancel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSMTLTransaction"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMTL Transaction"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbInterestTransfer.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region " Form Global Variables"
    Dim datSMTLCreation As Date
    Dim objSMTLLoan As New clsSMTLLoan
    Dim dblBookAmount As Double
    Dim dblAvalAmount As Double
    Dim dblIntAmount As Double
    Dim ToolTip1 As New ToolTip
    Dim Counter As Integer = 0
    Dim objTempDt As New DataTable
    Dim datToDate As Date
    Dim datFromDate As Date
    Dim IntPostingStatus As String
    Dim CountCalCount As Integer = 0
    Dim objCurrentAccount As New clsCurrentAccount
    Dim dblOverDrawLimit As Double
    Dim objSavingsBank As New clsSavingsBank
    Dim objFrmRePayment As New FrmRePayement
#End Region

#Region "SubRoutine And Functions"

    Public Sub sbClear()
        txtAmount.ResetText()
        txtNarration.ResetText()
        txtRefno.ResetText()
        txtName.ResetText()
        txtInterest.ResetText()
        txtChequeNo.ResetText()
        chkByCash.Checked = False
        txtAmountByCash.ResetText()
        chkFundTransfer.Checked = False
    End Sub

    Function fnCheck() As Boolean
        If Trim(txtAccNo.Text) = String.Empty Then
            MsgBox("Enter accountno", MsgBoxStyle.Exclamation)
            txtAccNo.Focus()
            Return False
        ElseIf Trim(txtRefno.Text) = String.Empty Then
            MsgBox("Enter reference number", MsgBoxStyle.Exclamation)
            txtRefno.Focus()
            Return False
        ElseIf Trim(txtInterest.Text) = String.Empty Then
            MsgBox("Calculate interest", MsgBoxStyle.Exclamation)
            btnCalInterest.Focus()
            Return False
        ElseIf CountCalCount = 0 Then
            MsgBox("Click the cal button", MsgBoxStyle.Exclamation)
            btnCalInterest.Focus()
            Return False
        ElseIf txtTrAccountNo.Text <> String.Empty And chkSB.Checked = True Then
            If fnCheckBalance() Then
                Return True
            Else
                Return False
            End If

        Else
            Return True
        End If
    End Function
    Function fnSetData() As Boolean
        If objSMTLLoan.fnGetLoanDetails(Trim(txtAccNo.Text)) Then
            datSMTLCreation = objSMTLLoan.SMTLLoanDettable.Rows(0).Item("AccDate")
        Else
            MsgBox("Account no does not exist!", MsgBoxStyle.Exclamation, Me.Text)
            txtAccNo.Focus()
            txtAccNo.SelectAll()
        End If
        objSMTLLoan.IntrestAmount = Val(txtInterest.Text)
        objSMTLLoan.IntAmtTobePaid = Val(dblIntAmount) + Val(txtInterest.Text)
        objSMTLLoan.ReciptNo = Val(txtRefno.Text)
        objSMTLLoan.AppDate = dtpDepositDate.Value
        objSMTLLoan.AccountNo = txtAccNo.Text
        objSMTLLoan.LastTransaction = dtpDepositDate.Value
        objSMTLLoan.ChequeNumber = txtChequeNo.Text
        Return True
    End Function

    Function fnAddDataList() As Boolean
        Dim lvitem As ListViewItem
        Dim objDT As New DataTable
        Dim intcount As Integer = 0
        lvPaidDet.Items.Clear()
        If objSMTLLoan.fnGetSMTLTransaction(txtAccNo.Text) Then
            objDT = objSMTLLoan.SMTLDetailstable()
            While intcount < objDT.Rows.Count
                lvitem = lvPaidDet.Items.Add(Format(objDT.Rows(intcount).Item("Trdate"), "yyyy-MM-dd"))
                lvitem.SubItems.Add(objDT.Rows(intcount).Item("ChequeNo"))
                lvitem.SubItems.Add(objDT.Rows(intcount).Item("Narration"))
                lvitem.SubItems.Add(objDT.Rows(intcount).Item("Deposit"))
                lvitem.SubItems.Add(objDT.Rows(intcount).Item("Withdraw"))
                lvitem.SubItems.Add(objDT.Rows(intcount).Item("PostBal"))
                lvitem.SubItems.Add(objDT.Rows(intcount).Item("IntAmount"))
                lvitem.SubItems.Add(objDT.Rows(intcount).Item("IntTobePaid"))
                lvitem.SubItems.Add(objDT.Rows(intcount).Item("IntPaid"))
                lvitem.SubItems.Add(objDT.Rows(intcount).Item("VoucherNo"))
                intcount += 1
            End While
        End If
    End Function

    Function fnCheckAmount() As Boolean
        If rdWithdraw.Checked = True Then
            If Val(dblAvalAmount) + Val(txtAmount.Text) > Val(dblBookAmount) Then
                MsgBox("WithDrawal amount is exceeding limit amount please enter valid amount", MsgBoxStyle.Exclamation)
                txtAmount.Focus()
                Return False
            Else
                Return True
            End If
        ElseIf rdDeposit.Checked = True Then
            If Val(txtAmount.Text) > Val(dblAvalAmount) Then
                MsgBox("Deposit amount is greater than balance amount please enter valid amount", MsgBoxStyle.Exclamation)
                txtAmount.Focus()
                Return False
            Else
                Return True
            End If
        End If
    End Function


    Sub Smtlloaddetails()
        If Trim(txtAccNo.Text) <> String.Empty Then
            If objSMTLLoan.fnGetLoanDetails(Trim(txtAccNo.Text)) Then
                txtName.Text = objSMTLLoan.SMTLLoanDettable.Rows(0).Item("Name")
                dblBookAmount = objSMTLLoan.SMTLLoanDettable.Rows(0).Item("SMTLLimit")
                lblBookBal.Text = Format(dblBookAmount, "0,00.00")
                dblAvalAmount = objSMTLLoan.SMTLLoanDettable.Rows(0).Item("Balance")
                lblAvalBal.Text = Format(dblAvalAmount, "0,00.00")
                ToolTip1.SetToolTip(lblBookBal, GetFigures(dblBookAmount))
                txtROI.Text = (objSMTLLoan.SMTLLoanDettable.Rows(0).Item("ROI") * 100)
                dblIntAmount = objSMTLLoan.SMTLLoanDettable.Rows(0).Item("IntAmount")
                lblIntAmount.Text = Format(dblIntAmount, "0,00.00")
                dtpLastPaidDate.Value = objSMTLLoan.SMTLLoanDettable.Rows(0).Item("LastPaidDate")
                IntPostingStatus = objSMTLLoan.SMTLLoanDettable.Rows(0).Item("IntPostingStatus")
                lblInterestReceivable.Text = objSMTLLoan.SMTLLoanDettable.Rows(0).Item("InterestReceivable")
                datSMTLCreation = objSMTLLoan.SMTLLoanDettable.Rows(0).Item("AccDate")

            Else
                MsgBox("Account no does not exist!", MsgBoxStyle.Exclamation, Me.Text)
                txtAccNo.Focus()
                txtAccNo.SelectAll()
            End If
        End If
    End Sub
    Sub caloaddetails()
        If Trim(txtTrAccountNo.Text) <> String.Empty Then
            If objCurrentAccount.fnGetCAccountDetails(Trim(txtTrAccountNo.Text)) Then
                dblAvalAmount = objCurrentAccount.CAAccTable.Rows(0).Item("AvailBalance")
                Label14.Text = Format(dblAvalAmount, "0,00.00")
                dblOverDrawLimit = objCurrentAccount.CAAccTable.Rows(0).Item("ODLimit")
            Else
                MsgBox("Account No does not Exist!", MsgBoxStyle.Exclamation, Me.Text)
                txtTrAccountNo.Focus()
                txtTrAccountNo.SelectAll()
            End If
        End If
    End Sub
    Sub sbloaddetails()
        If Trim(txtTrAccountNo.Text) <> String.Empty Then
            If objSavingsBank.fnGetSBAccountDetails(Trim(txtTrAccountNo.Text)) Then
                dblAvalAmount = objSavingsBank.SBAccTable.Rows(0).Item("AvailBalance")
                Label14.Text = Format(dblAvalAmount, "0,00.00")
            Else
                MsgBox("Account No does not Exist!", MsgBoxStyle.Exclamation, Me.Text)
                txtTrAccountNo.Focus()
                txtTrAccountNo.SelectAll()
            End If
        End If
    End Sub

    Function fnGenerateVoucherD(ByVal objTrans As IDbTransaction, ByVal DepositAmt As Double) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entry
        Dim strNarration As String = "Deposit by " & txtAccNo.Text & "  narration:" & txtNarration.Text

        Dim strsql = "insert into SMTLtransactiontbl (accountno,trdate,narration,deposit,withdraw,postbal,IntAmount,IntTobePaid,IntPaid,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Val(txtAmount.Text) & "','0',sum(Withdraw)-sum(Deposit)-'" & Val(txtAmount.Text) & "','" & Val(txtInterest.Text) & "','" & Val(txtInterest.Text) + Val(dblIntAmount) & "',0,'" & Val(txtRefno.Text) & "','" & lngVoucherNo & "','Cash','" & txtChequeNo.Text & "' from SMTLtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
        fnExecuteNonQuery(strsql, objTrans)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtAccNo.Text, txtRefno.Text, dtpDepositDate.Value, Val(txtAmount.Text), "Deposit by" & txtAccNo.Text, lngSlNo, "Y", objTrans)
        'Credit accounts
        ''fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpDepositDate.Value, "Deposit by SMTL account " & txtAccNo.Text, "To", 160, 0, Val(txtAmount.Text), 1, "Y", objTrans)
        ' ''Debit accounts 
        ''fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpDepositDate.Value, "Deposit by SMTL account " & txtAccNo.Text, "By", 59, Val(txtAmount.Text), 0, 2, "Y", objTrans)

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpDepositDate.Value, "Deposit by SMTL account " & txtAccNo.Text, "To", 153, 0, Val(txtAmount.Text), 1, "Y", objTrans)
        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpDepositDate.Value, "Deposit by SMTL account " & txtAccNo.Text, "By", 1, Val(txtAmount.Text), 0, 2, "Y", objTrans)
        Return True

    End Function
    Function fnGenerateVoucherWithIntReceivableDebitD(ByVal objTrans As IDbTransaction, ByVal DepositAmt As Double) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entry
        Dim strNarration As String = "Deposit by " & txtAccNo.Text & "  narration:" & txtNarration.Text

        Dim strsql = "insert into SMTLtransactiontbl (accountno,trdate,narration,deposit,withdraw,postbal,IntAmount,IntTobePaid,IntPaid,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Val(txtAmount.Text) & "','0',sum(Withdraw)-sum(Deposit)-'" & Val(txtAmount.Text) & "','" & Val(txtInterest.Text) & "','" & Val(txtInterest.Text) + Val(dblIntAmount) & "',0,'" & Val(txtRefno.Text) & "','" & lngVoucherNo & "','Cash','" & txtChequeNo.Text & "' from SMTLtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
        fnExecuteNonQuery(strsql, objTrans)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtAccNo.Text, txtRefno.Text, dtpDepositDate.Value, Val(txtAmount.Text), "Deposit by" & txtAccNo.Text, lngSlNo, "Y", objTrans)
        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpDepositDate.Value, "Deposit by SMTL account " & txtAccNo.Text, "To", 160, 0, Val(DepositAmt), 1, "Y", objTrans)

        fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpDepositDate.Value, "Deposit by SMTL account " & txtAccNo.Text, "by", 59, Val(DepositAmt), 0, 1, "Y", objTrans)

        fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpDepositDate.Value, "Deposit by SMTL account " & txtAccNo.Text, "To", 153, 0, Val(txtAmount.Text), 1, "Y", objTrans)

        'by cash
        If chkByCash.Checked = True Then
            fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpDepositDate.Value, "Deposit by SMTL account " & txtAccNo.Text, "By", 1, Val(txtAmountByCash.Text), 0, 2, "Y", objTrans)
        End If

        strNarration = "Withdraw by SMTL account "
        'Debit  accounts
        If chkCA.Checked = True Then
            objFrmRePayment.fnCAInterest()
            Dim strsql1 = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
            strsql1 = strsql1 & " select '" & Trim(txtTrAccountNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtTransFund.Text) & "','0','" & Trim(txtTransFund.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtTransFund.Text) & "','" & objFrmRePayment.dblCalIntrest & "','" & Trim(txtRefno.Text) & "','" & lngVoucherNo & "','Cash','0' from catransactiontbl where caccountno='" & Trim(txtTrAccountNo.Text) & "' group by CAccountno"
            fnExecuteNonQuery(strsql1)

            fnVoucherEnterSub(lngVoucherNo, 7, txtTrAccountNo.Text, dtpDepositDate.Value, "Deposit by SMTL account " & txtAccNo.Text, "By", 11, Val(txtTransFund.Text), 0, 1, "Y", objTrans)
        End If
        'Debit accounts 
        If chkSB.Checked = True Then
            'Transaction Entry
            Dim strsql1 = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
            strsql1 = strsql1 & " select '" & Trim(txtTrAccountNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtTransFund.Text) & "','0','" & Trim(txtTransFund.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtTransFund.Text) & "','" & Trim(txtRefno.Text) & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtTrAccountNo.Text) & "' group by Accountno"
            fnExecuteNonQuery(strsql1)
            fnVoucherEnterSub(lngVoucherNo, 7, txtTrAccountNo.Text, dtpDepositDate.Value, "Deposit by SMTL account " & txtAccNo.Text, "By", 10, Val(txtTransFund.Text), 0, 2, "Y", objTrans)
        End If
        Return True

    End Function
    Function fnGenerateVoucherD(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entery
        Dim strNarration As String = "Deposit by " & txtAccNo.Text & "  narration:" & txtNarration.Text

        Dim strsql = "insert into SMTLtransactiontbl (accountno,trdate,narration,deposit,withdraw,postbal,IntAmount,IntTobePaid,IntPaid,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Val(txtAmount.Text) & "','0',sum(Withdraw)-sum(Deposit)-'" & Val(txtAmount.Text) & "','" & Val(txtInterest.Text) & "','" & Val(txtInterest.Text) + Val(dblIntAmount) & "',0,'" & Val(txtRefno.Text) & "','" & lngVoucherNo & "','Cash','" & txtChequeNo.Text & "' from SMTLtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
        fnExecuteNonQuery(strsql, objTrans)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtAccNo.Text, txtRefno.Text, dtpDepositDate.Value, Val(txtAmount.Text), "Deposit by" & txtAccNo.Text, lngSlNo, "Y", objTrans)
        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpDepositDate.Value, "Deposit by SMTL account " & txtAccNo.Text, "To", 153, 0, Val(txtAmount.Text), 1, "Y", objTrans)
        'Debit accounts 
        If chkByCash.Checked = True Then
            fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpDepositDate.Value, "Deposit by SMTL account " & txtAccNo.Text, "By", 1, Val(txtAmountByCash.Text), 0, 2, "Y", objTrans)
        End If

        strNarration = "Withdraw by SMTL account "
        'Debit  accounts
        If chkCA.Checked = True Then
            objFrmRePayment.fnCAInterest()
            Dim strsql1 = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
            strsql1 = strsql1 & " select '" & Trim(txtTrAccountNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtTransFund.Text) & "','0','" & Trim(txtTransFund.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtTransFund.Text) & "','" & objFrmRePayment.dblCalIntrest & "','" & Trim(txtRefno.Text) & "','" & lngVoucherNo & "','Cash','0' from catransactiontbl where caccountno='" & Trim(txtTrAccountNo.Text) & "' group by CAccountno"
            fnExecuteNonQuery(strsql1)

            fnVoucherEnterSub(lngVoucherNo, 7, txtTrAccountNo.Text, dtpDepositDate.Value, "Deposit by SMTL account " & txtAccNo.Text, "By", 11, Val(txtTransFund.Text), 0, 1, "Y", objTrans)
        End If
        'Debit accounts 
        If chkSB.Checked = True Then
            'Transaction Entry
            Dim strsql1 = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
            strsql1 = strsql1 & " select '" & Trim(txtTrAccountNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Val(txtTransFund.Text) & "','0','" & Trim(txtTransFund.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtTransFund.Text) & "','" & Trim(txtRefno.Text) & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtTrAccountNo.Text) & "' group by Accountno"
            fnExecuteNonQuery(strsql1)
            fnVoucherEnterSub(lngVoucherNo, 7, txtTrAccountNo.Text, dtpDepositDate.Value, "Deposit by SMTL account " & txtAccNo.Text, "By", 10, Val(txtTransFund.Text), 0, 2, "Y", objTrans)
        End If
        Return True

    End Function
    ''if the customer repays the amount 100000 and the interest raised amount is 50000:following code
    Function fnGenerateVoucherDWithIn15Day_DrAmtGreaterThanInt(ByVal objTrans As IDbTransaction, ByVal CalInterestWithIn15Day As Double) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        Dim DepositWithIn15Day As Double = Val(txtAmount.Text) - CalInterestWithIn15Day
        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()
        'Transaction Entery
        Dim strNarration As String = "Deposit within 15 day by " & txtAccNo.Text & "  narration:" & txtNarration.Text
        Dim strsql = "insert into SMTLtransactiontbl (accountno,trdate,narration,deposit,withdraw,postbal,IntAmount,IntTobePaid,IntPaid,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & DepositWithIn15Day & "','0',sum(Withdraw)-sum(Deposit)-'" & DepositWithIn15Day & "','0','0',0,'" & Val(txtRefno.Text) & "','" & lngVoucherNo & "','Cash','" & txtChequeNo.Text & "' from SMTLtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
        fnExecuteNonQuery(strsql, objTrans)
        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtAccNo.Text, txtRefno.Text, dtpDepositDate.Value, Val(txtAmount.Text), "Deposit by" & txtAccNo.Text, lngSlNo, "Y", objTrans)
        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpDepositDate.Value, "Deposit within 15 day by SMTL account " & txtAccNo.Text, "To", 153, 0, Val(txtAmount.Text) - CalInterestWithIn15Day, 1, "Y", objTrans)
        fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpDepositDate.Value, "Deposit within 15 day by SMTL account " & txtAccNo.Text, "To", 160, 0, CalInterestWithIn15Day, 1, "Y", objTrans)
        'Debit accounts 
        If chkByCash.Checked = True Then
            fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpDepositDate.Value, "Deposit by SMTL account " & txtAccNo.Text, "By", 1, Val(txtAmountByCash.Text), 0, 2, "Y", objTrans)
        End If

        strNarration = "Withdraw by SMTL account "
        'Debit  accounts
        If chkCA.Checked = True Then
            objFrmRePayment.fnCAInterest()
            Dim strsql1 = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
            strsql1 = strsql1 & " select '" & Trim(txtTrAccountNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtTransFund.Text) & "','0','" & Trim(txtTransFund.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtTransFund.Text) & "','" & objFrmRePayment.dblCalIntrest & "','" & Trim(txtRefno.Text) & "','" & lngVoucherNo & "','Cash','0' from catransactiontbl where caccountno='" & Trim(txtTrAccountNo.Text) & "' group by CAccountno"
            fnExecuteNonQuery(strsql1)

            fnVoucherEnterSub(lngVoucherNo, 7, txtTrAccountNo.Text, dtpDepositDate.Value, "Deposit by SMTL account " & txtAccNo.Text, "By", 11, Val(txtTransFund.Text), 0, 1, "Y", objTrans)
        End If
        'Debit accounts 
        If chkSB.Checked = True Then
            'Transaction Entry
            Dim strsql1 = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
            strsql1 = strsql1 & " select '" & Trim(txtTrAccountNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtTransFund.Text) & "','0','" & Trim(txtTransFund.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtTransFund.Text) & "','" & Trim(txtRefno.Text) & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtTrAccountNo.Text) & "' group by Accountno"
            fnExecuteNonQuery(strsql1)
            fnVoucherEnterSub(lngVoucherNo, 7, txtTrAccountNo.Text, dtpDepositDate.Value, "Deposit by SMTL account " & txtAccNo.Text, "By", 10, Val(txtTransFund.Text), 0, 2, "Y", objTrans)
        End If
        ''fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpDepositDate.Value, "Deposit within 15 day by SMTL account " & txtAccNo.Text, "By", 1, Val(txtAmount.Text), 0, 2, "Y", objTrans)
        ''Credit(accounts)

        'Debit accounts 
        'fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpDepositDate.Value, "Deposit by SMTL account " & txtAccNo.Text, "By", 1, Val(txtAmount.Text), 0, 2, "Y", objTrans)
        Return True

    End Function
    'if the customer repays the amount 50000 within 15 days and the interest raised for 15 days is 100000:following code
    Function fnGenerateVoucherDWithIn15Day_DrAmtLesserThanInt(ByVal objTrans As IDbTransaction, ByVal CalInterestWithIn15Day As Double) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()
        'Transaction Entery
        Dim strNarration As String = "Deposit within 15 day by " & txtAccNo.Text & "  narration:" & txtNarration.Text
        Dim strsql = "insert into SMTLtransactiontbl (accountno,trdate,narration,deposit,withdraw,postbal,IntAmount,IntTobePaid,IntPaid,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Val(txtAmount.Text) & "','0',sum(Withdraw)-sum(Deposit)-'" & Val(txtAmount.Text) & "','" & Val(txtInterest.Text) & "','" & Val(txtInterest.Text) + Val(dblIntAmount) & "',0,'" & Val(txtRefno.Text) & "','" & lngVoucherNo & "','Cash','" & txtChequeNo.Text & "' from SMTLtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
        fnExecuteNonQuery(strsql, objTrans)
        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtAccNo.Text, txtRefno.Text, dtpDepositDate.Value, Val(txtAmount.Text), "Deposit by" & txtAccNo.Text, lngSlNo, "Y", objTrans)
        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpDepositDate.Value, "Deposit within 15 day by SMTL account " & txtAccNo.Text, "To", 153, 0, CalInterestWithIn15Day - Val(txtAmount.Text), 1, "Y", objTrans)
        'Debit accounts 

        ''Credit(accounts)
        fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpDepositDate.Value, "Deposit within 15 day by SMTL account " & txtAccNo.Text, "To", 160, 0, Val(txtAmount.Text), 1, "Y", objTrans)
        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpDepositDate.Value, "Deposit by SMTL account " & txtAccNo.Text, "To", 59, CalInterestWithIn15Day - Val(txtAmount.Text), 0, 2, "Y", objTrans)
        If chkByCash.Checked = True Then
            fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpDepositDate.Value, "Deposit by SMTL account " & txtAccNo.Text, "By", 1, Val(txtAmountByCash.Text), 0, 2, "Y", objTrans)
        End If

        strNarration = "Withdraw by SMTL account "
        'Debit  accounts
        If chkCA.Checked = True Then
            objFrmRePayment.fnCAInterest()
            Dim strsql1 = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
            strsql1 = strsql1 & " select '" & Trim(txtTrAccountNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtTransFund.Text) & "','0','" & Trim(txtTransFund.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtTransFund.Text) & "','" & objFrmRePayment.dblCalIntrest & "','" & Trim(txtRefno.Text) & "','" & lngVoucherNo & "','Cash','0' from catransactiontbl where caccountno='" & Trim(txtTrAccountNo.Text) & "' group by CAccountno"
            fnExecuteNonQuery(strsql1)

            fnVoucherEnterSub(lngVoucherNo, 7, txtTrAccountNo.Text, dtpDepositDate.Value, "Deposit by SMTL account " & txtAccNo.Text, "By", 11, Val(txtTransFund.Text), 0, 1, "Y", objTrans)
        End If
        'Debit accounts 
        If chkSB.Checked = True Then
            'Transaction Entry
            Dim strsql1 = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
            strsql1 = strsql1 & " select '" & Trim(txtTrAccountNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtTransFund.Text) & "','0','" & Trim(txtTransFund.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtTransFund.Text) & "','" & Trim(txtRefno.Text) & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtTrAccountNo.Text) & "' group by Accountno"
            fnExecuteNonQuery(strsql1)
            fnVoucherEnterSub(lngVoucherNo, 7, txtTrAccountNo.Text, dtpDepositDate.Value, "Deposit by SMTL account " & txtAccNo.Text, "By", 10, Val(txtTransFund.Text), 0, 2, "Y", objTrans)
        End If
        '''fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpDepositDate.Value, "Deposit within 15 day by SMTL account " & txtAccNo.Text, "By", 1, Val(txtAmount.Text), 0, 2, "Y", objTrans)
        Return True

    End Function
    Function fnGenerateVoucherW() As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        Dim strNarration As String = "Withdrawal by " & txtAccNo.Text & " Narration:" & txtNarration.Text

        'Transaction Entry
        If objSMTLLoan.fnGetSMTLTransaction(txtAccNo.Text) Then
            Dim strsql = "insert into SMTLtransactiontbl (accountno,trdate,narration,deposit,withdraw,postbal,IntAmount,IntTobePaid,IntPaid,refno,voucherno,type,chequeno) "
            strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Val(txtAmount.Text) & "',sum(withdraw)-sum(Deposit)+'" & Val(txtAmount.Text) & "','" & Val(txtInterest.Text) & "','" & Val(txtInterest.Text) + Val(dblIntAmount) & "',0,'" & Trim(txtRefno.Text) & "','" & lngVoucherNo & "','Cash','" & txtChequeNo.Text & "' from SMTLtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
            fnExecuteNonQuery(strsql)
        Else
            objSMTLLoan.fnSMTLtransactionEnter(Trim(txtAccNo.Text), dtpDepositDate.Value, "Withdrawal by " & txtAccNo.Text, 0, Val(txtAmount.Text), Val(txtAmount.Text), Trim(txtInterest.Text), Trim(txtInterest.Text), 0, txtRefno.Text, lngVoucherNo, "Cash", txtChequeNo.Text)
        End If

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 1, txtAccNo.Text, txtRefno.Text, dtpDepositDate.Value, Val(txtAmount.Text), "Withdraw by " & txtAccNo.Text, lngSlNo, "Y")
        'Credit accounts
         If chkSB.Checked = True Then
            Dim strsql1 = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
            strsql1 = strsql1 & " select '" & Trim(txtTrAccountNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Val(txtAmount.Text) & "','" & Trim(txtRefno.Text) & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtTrAccountNo.Text) & "' group by Accountno"
            fnExecuteNonQuery(strsql1)
            fnVoucherEnterSub(lngVoucherNo, 7, txtTrAccountNo.Text, dtpDepositDate.Value, "Withdraw by SMTL account " & txtAccNo.Text, "By", 10, 0, Val(txtAmount.Text), 2, "Y")
        End If
        If chkCA.Checked = True Then
            objFrmRePayment.fnCAInterest()
            Dim strsql1 = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
            strsql1 = strsql1 & " select '" & Trim(txtTrAccountNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Val(txtAmount.Text) & "','0','" & Trim(txtRefno.Text) & "','" & lngVoucherNo & "','Cash','0' from catransactiontbl where caccountno='" & Trim(txtTrAccountNo.Text) & "' group by caccountno"
            fnExecuteNonQuery(strsql1)

            fnVoucherEnterSub(lngVoucherNo, 7, txtTrAccountNo.Text, dtpDepositDate.Value, "Withdraw by SMTL account " & txtAccNo.Text, "By", 11, 0, Val(txtAmount.Text), 1, "Y")
        End If
        If chkSB.Checked = False And chkCA.Checked = False Then
            fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDepositDate.Value, "Withdraw by SMTL account " & txtAccNo.Text, "To", 1, 0, Val(txtAmount.Text), 1, "Y")
        End If
        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpDepositDate.Value, "Withdraw by SMTL account " & txtAccNo.Text, "By", 153, Val(txtAmount.Text), 0, 2, "Y")

        Return True

    End Function

    Function fnGenerateVoucherInt() As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        Dim InterestAmt As Double = Convert.ToDouble(txtAmount.Text)
        Dim SmtlLimit As Double = Convert.ToDouble(lblBookBal.Text)
        Dim AvailableBalance = Convert.ToDouble(lblAvalBal.Text)
        Dim PresentBalance As Double
        Dim RemainingInterest As Double
        Dim IOL As Double

        PresentBalance = AvailableBalance + InterestAmt

        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()


        Dim strNarration As String = "Interest posting by " & txtAccNo.Text & " Narration:" & txtNarration.Text

        'Transaction Entry
        Dim strsql = "insert into SMTLtransactiontbl (accountno,trdate,narration,deposit,withdraw,postbal,IntAmount,IntTobePaid,IntPaid,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Val(txtAmount.Text) & "',sum(withdraw)-sum(Deposit)+'" & Val(txtAmount.Text) & "','" & Val(txtInterest.Text) & "','" & Val(txtInterest.Text) + Val(dblIntAmount) & "','" & Val(txtInterest.Text) + Val(dblIntAmount) & "','" & Trim(txtRefno.Text) & "','" & lngVoucherNo & "','Cash','0' from SMTLtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
        fnExecuteNonQuery(strsql)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 1, txtAccNo.Text, txtRefno.Text, dtpDepositDate.Value, Val(txtInterest.Text) + Val(dblIntAmount), "Interest posting by " & txtAccNo.Text, lngSlNo, "Y")
        'Credit accounts
        ''Interest amount transfer to Interest Receivables
        If rdTrToIr.Checked = True Then
            fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDepositDate.Value, "Interest posting by account " & txtAccNo.Text, "To", 59, 0, Val(txtAmount.Text), 1, "Y")
        End If
        ''Interest amount transfer to Interest on SMTL
        If rdTrToIol.Checked = True Then
            fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDepositDate.Value, "Interest posting by account " & txtAccNo.Text, "To", 160, 0, Val(txtAmount.Text), 1, "Y")
        End If
        ''Interest amount that exceeds the Smtl limit is transfered to Interest Receivables and Interest amount With in Smtl limit is transfered to Interest on SMTL
        If rdExcessAmtTrToIR.Checked = True Then
            If PresentBalance > SmtlLimit Then
                RemainingInterest = PresentBalance - SmtlLimit
                IOL = InterestAmt - RemainingInterest
                fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDepositDate.Value, "Interest posting by account " & txtAccNo.Text, "To", 160, 0, IOL, 1, "Y")
                fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDepositDate.Value, "Interest posting by account " & txtAccNo.Text, "To", 59, 0, RemainingInterest, 1, "Y")
            End If
            
        End If
        ''fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDepositDate.Value, "Interest posting by account " & txtAccNo.Text, "To", 59, 0, Val(txtAmount.Text), 1, "Y")
        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpDepositDate.Value, "Interest posting by account " & txtAccNo.Text, "By", 153, Val(txtAmount.Text), 0, 2, "Y")

        'Credit accounts
        'fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpDepositDate.Value, "Interest posting by account " & txtAccNo.Text, "To", 160, 0, Val(txtInterest.Text), 3, "Y")
        'Debit accounts 
        'fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpDepositDate.Value, "Interest posting by account " & txtAccNo.Text, "By", 1, Val(txtInterest.Text) + Val(dblIntAmount), 0, 4, "Y")

        Return True

    End Function


    Function fnCalcInterest() As Boolean
        Dim intcalInterest As Double = 0
        Dim intInterestDiff As Integer

        If Val(lblAvalBal.Text) > 0 Then
            If (IntPostingStatus = 1 And (rdWithdraw.Checked = True Or rdDeposit.Checked = True)) Then
                datFromDate = DateAdd(DateInterval.Day, 1, dtpLastPaidDate.Value)
                datToDate = dtpDepositDate.Value
            ElseIf (IntPostingStatus = 0 And (rdWithdraw.Checked = True Or rdDeposit.Checked = True)) Then
                datFromDate = dtpLastPaidDate.Value
                datToDate = dtpDepositDate.Value
            ElseIf (IntPostingStatus = 0 And (rdIntPosing.Checked = True)) Then
                datFromDate = DateAdd(DateInterval.Day, -1, dtpLastPaidDate.Value)
                datToDate = dtpDepositDate.Value
            ElseIf (IntPostingStatus = 1 And (rdIntPosing.Checked = True)) Then
                datFromDate = dtpLastPaidDate.Value
                datToDate = dtpDepositDate.Value
            End If
            If datFromDate <= dtpDepositDate.Value Then
                intInterestDiff = DateDiff(DateInterval.Day, datFromDate, dtpDepositDate.Value) 'Previous code
            Else
                intInterestDiff = 0
            End If
            intcalInterest = Math.Round(((Trim(lblAvalBal.Text) * intInterestDiff * (txtROI.Text / 100)) / 365)) 'Previous code
            txtInterest.Text = intcalInterest
        Else
            txtInterest.Text = 0
        End If
        CountCalCount = CountCalCount + 1
        If rdIntPosing.Checked = True Then
            txtAmount.Text = intcalInterest + Val(dblIntAmount)
        End If
    End Function

#End Region


#Region "Events"

    Private Sub rdDeposit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdDeposit.CheckedChanged
        If rdDeposit.Checked = True Then
            btnDeposit.Visible = True
            btnWithDraw.Visible = False
            btnIntPosting.Visible = False
            Label2.Text = "Amount"
            txtAmount.Text = ""
            txtAmount.ReadOnly = True
            chkByCash.Visible = True
            txtAmountByCash.Visible = True
            chkFundTransfer.Enabled = True
            rdTrToIol.Checked = False
            rdExcessAmtTrToIR.Checked = False
            rdTrToIr.Checked = False
            gbInterestTransfer.Visible = False
        Else
            btnDeposit.Visible = False
            txtAmount.ReadOnly = False
            chkByCash.Visible = False
            txtAmountByCash.Visible = False
            chkFundTransfer.Checked = False

        End If

    
    End Sub

    Private Sub rdWithdraw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdWithdraw.CheckedChanged
        If rdWithdraw.Checked = True Then
            btnDeposit.Visible = False
            btnWithDraw.Visible = True
            btnIntPosting.Visible = False
            Label2.Text = "Amount"
            txtAmount.ReadOnly = False
            txtAmount.Text = ""
            chkFundTransfer.Enabled = True
            rdTrToIol.Checked = False
            rdExcessAmtTrToIR.Checked = False
            rdTrToIr.Checked = False
            gbInterestTransfer.Visible = False
        Else
            txtAmount.ReadOnly = False
            chkFundTransfer.Checked = False

        End If

    End Sub
    Private Sub rdIntPosing_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdIntPosing.CheckedChanged
        If rdIntPosing.Checked = True Then
            btnDeposit.Visible = False
            btnWithDraw.Visible = False
            btnIntPosting.Visible = True
            rdTrToIr.Checked = True
            Label2.Text = "Total Interest"
            ' txtAmount.ReadOnly = True
            txtAmount.Text = Val(dblIntAmount) + Val(txtInterest.Text)
            chkFundTransfer.Enabled = False
            gbInterestTransfer.Visible = True
        Else
            chkFundTransfer.Enabled = True
            chkFundTransfer.Checked = False
            rdTrToIol.Checked = False
            rdExcessAmtTrToIR.Checked = False
            rdTrToIr.Checked = False

        End If
      
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim objSBAccSearch As New frmSMTLLoanCust
        objSBAccSearch.strSMTLLoan = String.Empty
        objSBAccSearch.ShowDialog(Me)
        If objSBAccSearch.strSMTLLoan <> String.Empty Then
            txtAccNo.Text = objSBAccSearch.strSMTLLoan
            Smtlloaddetails()
            fnAddDataList()
        End If
        objSBAccSearch.Dispose()
    End Sub
    Private Function fnCheckBalance() As Boolean
        ''Check available balance in account
        If objSavingsBank.fnGetSBAccountDetails(Trim(txtTrAccountNo.Text)) Then
            If objSavingsBank.SBAccTable.Rows(0).Item("AvailBalance") < Val(txtTransFund.Text) Then
                MsgBox("Low balance in the account,please check account", MsgBoxStyle.Exclamation, Me.Text)
                Return False
            ElseIf objSavingsBank.fnGetMasterSetting() Then
                If objSavingsBank.SBMasterTable.Rows(0).Item("SBminAmount") > (objSavingsBank.SBAccTable.Rows(0).Item("AvailBalance") - Val(txtTransFund.Text)) Then
                    'If MsgBox("Available Balance Is Less Than Minimum Amount For account holder,Still Do You Want To continue transaction? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Issue") = MsgBoxResult.Yes Then
                    MsgBox("Available balance is less than minimum amount for account holder", MsgBoxStyle.Exclamation, Me.Text)
                    Return False
                Else
                    Return True
                End If
            Else
                Return True
            End If
        End If
    End Function

    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        Dim DepositAmt As Double = 0
        Dim NOD As Integer
        Dim intcalInterest As Double = 0
        Dim remainingAmount As Double = 0
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnSetData() Then
                    ''15 Days interest calculation start
                    NOD = DateDiff(DateInterval.Day, datSMTLCreation.Date, dtpDepositDate.Value)
                    If NOD <= 15 Then
                        ''Code to check if he paid interest once for available balance within 15 day. If he paid once, then he 
                        ''come second time within 15 day for deposit at that time we donot take interest for available balance. 
                        If objSMTLLoan.fnGetLoanDetails(Trim(txtAccNo.Text)) Then
                            If objSMTLLoan.SMTLLoanDettable.Rows(0).Item("IsPayWithIn15Day") Then
                                GoTo NotCal15DayInt
                            Else
                                GoTo Calculate15DayInterest

                            End If
                        Else
                            MsgBox("Account number does not exist!", MsgBoxStyle.Exclamation, Me.Text)
                            txtAccNo.Focus()
                            txtAccNo.SelectAll()
                        End If
Calculate15DayInterest: If MsgBox("In SMTL, if customer paid amount before 15 days, then we take atleast 15 day interest", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                            intcalInterest = Math.Round(((Trim(lblAvalBal.Text) * 15 * (txtROI.Text / 100)) / 365)) ''Previous code
                            DepositAmt = Val(txtAmount.Text)
                            If Val(lblInterestReceivable.Text) <> 0 Then
                                ''15 Days interest calculation end
                                '''Its is zero because within 15 day Interest Posting is not happen.
                            Else  ''If interest receivable is equal to zero then
                                If DepositAmt > intcalInterest Then
                                    If IntPostingStatus = 1 And (dtpLastPaidDate.Value = dtpDepositDate.Value) Then
                                        'If objSMTLLoan.fnUpDateAddIntWithIntPostingSatusOne(txtAccNo.Text, DepositAmt) Then
                                        '    fnGenerateVoucherD(objTrans)
                                        '    fnLogEntry(pbUserId, "Deposit by " & txtAccNo.Text & " Amount " & Val(txtAmount.Text), Date.Now, "Transaction deposit", objTrans)
                                        '    objTrans.Commit()
                                        '    If MsgBox("Transaction completed sucessfully" & Chr(13) & " Do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                        '        sbClear()
                                        '        Smtlloaddetails()
                                        '        fnAddDataList()
                                        '    Else
                                        '        Me.Close()
                                        '    End If
                                        'End If
                                    Else
                                        If objSMTLLoan.fnUpDateAddIntWithIn15Day(txtAccNo.Text, DepositAmt) Then
                                            fnGenerateVoucherDWithIn15Day_DrAmtGreaterThanInt(objTrans, intcalInterest)
                                            fnLogEntry(pbUserId, "Deposit by " & txtAccNo.Text & " Amount " & Val(txtAmount.Text), Date.Now, "Transaction deposit", objTrans)
                                            objTrans.Commit()
                                            CountCalCount = 0
                                            If MsgBox("Transaction completed sucessfully" & Chr(13) & " Do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                                sbClear()
                                                Smtlloaddetails()
                                                fnAddDataList()
                                            Else
                                                Me.Close()
                                            End If
                                        End If
                                    End If
                                Else
                                    ''If deposit amount is lesser than interest amount than not decrease in availbal and also Interest receivable(IR) amount put for remaining amount. 
                                    If IntPostingStatus = 1 And (dtpLastPaidDate.Value = dtpDepositDate.Value) Then
                                        'If objSMTLLoan.fnUpDateAddIntWithIntPostingSatusOne(txtAccNo.Text, DepositAmt) Then
                                        '    fnGenerateVoucherD(objTrans)
                                        '    fnLogEntry(pbUserId, "Deposit by " & txtAccNo.Text & " Amount " & Val(txtAmount.Text), Date.Now, "Transaction deposit", objTrans)
                                        '    objTrans.Commit()
                                        '    If MsgBox("Transaction completed sucessfully" & Chr(13) & " Do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                        '        sbClear()
                                        '        sbloaddetails()
                                        '        fnAddDataList()
                                        '    Else
                                        '        Me.Close()
                                        '    End If
                                        'End If
                                    Else
                                        If objSMTLLoan.fnUpDateAddInt(txtAccNo.Text, DepositAmt) Then
                                            fnGenerateVoucherDWithIn15Day_DrAmtLesserThanInt(objTrans, intcalInterest)
                                            fnLogEntry(pbUserId, "Deposit by " & txtAccNo.Text & " Amount " & Val(txtAmount.Text), Date.Now, "Transaction deposit", objTrans)
                                            objTrans.Commit()
                                            CountCalCount = 0
                                            If MsgBox("Transaction completed sucessfully" & Chr(13) & " Do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                                sbClear()
                                                Smtlloaddetails()
                                                fnAddDataList()
                                            Else
                                                Me.Close()
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        Else
                            MsgBox("No transaction happen, as per rules should take 15 day interest so click on Yes", MsgBoxStyle.Information)

                        End If
                    Else
                        ''If deposit date above 15 days from the date of creation
NotCal15DayInt:         If MsgBox(" SMTL No:  " & txtAccNo.Text & " " & Chr(13) & " Deposit Amount:  " & txtAmount.Text & " " & Chr(13) & " Type:  Cash") = MsgBoxResult.Ok Then
                            ''If Interest Receivable is not zero or greater then zero
                            If Val(lblInterestReceivable.Text) <> 0 Then
                                If Val(txtAmount.Text) > Val(lblInterestReceivable.Text) Then
                                    DepositAmt = Val(lblInterestReceivable.Text)
                                Else
                                    DepositAmt = Val(txtAmount.Text)
                                End If
                                If IntPostingStatus = 1 And (dtpLastPaidDate.Value = dtpDepositDate.Value) Then ''Status maintain for days interst calculation
                                    If objSMTLLoan.fnUpDateAddIntWithIntPostingSatusOne(txtAccNo.Text, DepositAmt) Then
                                        fnGenerateVoucherWithIntReceivableDebitD(objTrans, DepositAmt)
                                        fnLogEntry(pbUserId, "Deposit by " & txtAccNo.Text & " Amount " & Val(txtAmount.Text), Date.Now, "Transaction deposit", objTrans)
                                        objTrans.Commit()
                                        CountCalCount = 0
                                        If MsgBox("Transaction completed sucessfully" & Chr(13) & " Do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                            sbClear()
                                            Smtlloaddetails()
                                            fnAddDataList()
                                        Else
                                            Me.Close()
                                        End If
                                    End If
                                Else
                                    If objSMTLLoan.fnUpDateAddInt(txtAccNo.Text, DepositAmt) Then
                                        fnGenerateVoucherWithIntReceivableDebitD(objTrans, DepositAmt)
                                        fnLogEntry(pbUserId, "Deposit by " & txtAccNo.Text & " Amount " & Val(txtAmount.Text), Date.Now, "Transaction deposit", objTrans)
                                        objTrans.Commit()
                                        CountCalCount = 0
                                        If MsgBox("Transaction completed sucessfully" & Chr(13) & " Do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                            sbClear()
                                            Smtlloaddetails()
                                            fnAddDataList()
                                        Else
                                            Me.Close()
                                        End If
                                    End If
                                End If
                            Else
                                ''If Interest Receivable is zero
                                If IntPostingStatus = 1 And (dtpLastPaidDate.Value = dtpDepositDate.Value) Then
                                    If objSMTLLoan.fnUpDateAddIntWithIntPostingSatusOne(txtAccNo.Text, DepositAmt) Then
                                        fnGenerateVoucherD(objTrans)
                                        fnLogEntry(pbUserId, "Deposit by " & txtAccNo.Text & " Amount " & Val(txtAmount.Text), Date.Now, "Transaction deposit", objTrans)
                                        objTrans.Commit()
                                        CountCalCount = 0
                                        If MsgBox("Transaction completed sucessfully" & Chr(13) & " Do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                            sbClear()
                                            Smtlloaddetails()
                                            fnAddDataList()
                                        Else
                                            Me.Close()
                                        End If
                                    End If
                                Else
                                    If objSMTLLoan.fnUpDateAddInt(txtAccNo.Text, DepositAmt) Then
                                        fnGenerateVoucherD(objTrans)
                                        fnLogEntry(pbUserId, "Deposit by " & txtAccNo.Text & " Amount " & Val(txtAmount.Text), Date.Now, "Transaction deposit", objTrans)
                                        objTrans.Commit()
                                        CountCalCount = 0
                                        If MsgBox("Transaction completed sucessfully" & Chr(13) & " Do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                            sbClear()
                                            Smtlloaddetails()
                                            fnAddDataList()
                                        Else
                                            Me.Close()
                                        End If
                                    End If
                                End If
                            End If

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


    Private Sub btnWithDraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithDraw.Click
        If fnCheck() Then
            If fnSetData() Then
                If MsgBox("SMTL accountno  :  " & txtAccNo.Text & " " & Chr(13) & " WithDraw amount  :  " & txtAmount.Text & " " & Chr(13) & " Type  :  cash", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    If IntPostingStatus = 1 And dtpDepositDate.Value = dtpLastPaidDate.Value Then
                        If objSMTLLoan.fnUpDateAddIntWithIntPostingSatusOne(txtAccNo.Text) Then
                            fnGenerateVoucherW()
                            fnLogEntry(pbUserId, "Withdraw by " & txtAccNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction withdraw")
                            CountCalCount = 0
                            If MsgBox("Transaction completed sucessfully" & Chr(13) & " Do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                sbClear()
                                Smtlloaddetails()
                                fnAddDataList()
                            Else
                                Me.Close()
                            End If
                        End If
                    Else
                        If objSMTLLoan.fnUpDateAddInt(txtAccNo.Text) Then
                            fnGenerateVoucherW()
                            fnLogEntry(pbUserId, "Withdraw by " & txtAccNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction withdraw")
                            CountCalCount = 0
                            If MsgBox("Transaction completed sucessfully" & Chr(13) & " Do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                sbClear()
                                Smtlloaddetails()
                                fnAddDataList()
                            Else
                                Me.Close()
                            End If
                        End If
                    End If

                End If

            End If
        End If

    End Sub

    Private Sub frmCashTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dtpDepositDate.Value = Date.Now.Date
        'dtpDepositDate.MaxDate = Date.Now.Date
        If Trim(txtAccNo.Text <> String.Empty) Then
            Smtlloaddetails()
            fnAddDataList()
        End If

    End Sub

#End Region

    Private Sub txtAccNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccNo.Leave
        If Trim(txtAccNo.Text <> String.Empty) Then
            Smtlloaddetails()
        End If
    End Sub

    Private Sub btnVerifyPhotoSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ObjPhotoSign As New frmSBSignPhoto
        ObjPhotoSign.txtAccno.Text = Me.txtAccNo.Text
        ObjPhotoSign.txtName.Text = Me.txtName.Text
        ObjPhotoSign.ShowDialog(Me)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnCalInterest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalInterest.Click
        If fnCalcInterest() Then
        End If
    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntPosting.Click
        If Val(txtAmount.Text) <> 0.0 Then
            If fnCheck() Then
                If fnSetData() Then
                    If MsgBox("SMTL accountno  :  " & txtAccNo.Text & " " & Chr(13) & " Intrest amount  :  " & txtAmount.Text & " " & Chr(13) & " Type  :  Cash", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                        If objSMTLLoan.fnUpdateInterest(txtAccNo.Text, txtAmount.Text) Then
                            fnGenerateVoucherInt()
                            CountCalCount = 0
                            If MsgBox("Transaction completed sucessfully" & Chr(13) & " do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                sbClear()
                                Smtlloaddetails()
                                fnAddDataList()
                            Else
                                Me.Close()
                            End If
                        End If
                    End If

                End If
            End If
        Else
            MsgBox("Intrest cannot be posted because interest amount is zero", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtInterest_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInterest.TextChanged
        If rdIntPosing.Checked = True Then
            txtAmount.Text = Val(txtInterest.Text) + Val(dblIntAmount)
        End If
    End Sub
    'Dim objReportViewer As New frmReportViewer

    'Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
    '    Dim cryRpt As New ReportDocument
    '    cryRpt.Load(Application.StartupPath & "/Reports/SMTLStatement.rpt")
    '    '-----functionality for Parameter passing---myDiscrete
    '    Dim myDiscrete As New ParameterDiscreteValue
    '    myDiscrete.Value = Convert.ToString(txtAccNo.Text)
    '    cryRpt.SetParameterValue("AccountNo", myDiscrete)
    '    objReportViewer.Show()
    '    objReportViewer.CrystalReportViewer1.ReportSource = cryRpt
    'End Sub


    Private Sub chkFundTransfer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFundTransfer.CheckedChanged
        If chkFundTransfer.Checked = True Then
            Panel3.Enabled = True
            Label36.Visible = True
            Label14.Visible = True
            Label37.Visible = True
            txtTransFund.Visible = True

        ElseIf chkFundTransfer.Checked = False Then
            Panel3.Enabled = False
            txtTransFund.ResetText()
            lblAvalBal.Text = 0.0
            chkCA.Checked = False
            chkSB.Checked = False
            txtTrAccountNo.ResetText()
            Label36.Visible = False
            Label14.Visible = False
            Label37.Visible = False
            txtTransFund.Visible = False
        End If

        If rdWithdraw.Checked = True And chkFundTransfer.Checked = True Then
            txtTransFund.ResetText()
            txtTransFund.Visible = False
            Label37.Visible = False
            Label36.Visible = False
            Label14.Visible = False
            ''ElseIf rdWithdraw.Checked = False And chkFundTransfer.Checked = True Then
            ''    txtTransFund.ResetText()
            ''    txtTransFund.Visible = False
            ''    Label37.Visible = False
            ''    Label36.Visible = False
            ''    Label14.Visible = False
        End If
    End Sub

    Private Sub txtTransFund_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTransFund.TextChanged

        txtAmount.Text = Val(txtTransFund.Text) + Val(txtAmountByCash.Text)

    End Sub


    Private Sub BtnAccSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAccSearch.Click
        AccountNoSearch()

        ' ''If chkSB.Checked = True Then
        ' ''    Dim objSBAccSearch As New frmSBAccSearch
        ' ''    objSBAccSearch.strSBAccountNo = String.Empty
        ' ''    objSBAccSearch.ShowDialog(Me)
        ' ''    If objSBAccSearch.strSBAccountNo <> String.Empty Then
        ' ''        txtTrAccountNo.Text = objSBAccSearch.strSBAccountNo
        ' ''        sbloaddetails()
        ' ''        objSBAccSearch.Dispose()
        ' ''    End If
        ' ''ElseIf chkCA.Checked = True Then
        ' ''    Dim objCAccountSearch As New frmCAccSearch
        ' ''    objCAccountSearch.strCAccountNo = String.Empty
        ' ''    objCAccountSearch.ShowDialog(Me)
        ' ''    If objCAccountSearch.strCAccountNo <> String.Empty Then
        ' ''        txtTrAccountNo.Text = objCAccountSearch.strCAccountNo
        ' ''        caloaddetails()
        ' ''        objCAccountSearch.Dispose()
        ' ''    End If
        ' ''Else
        ' ''    MsgBox("Select Account Type")
        ' ''End If
    End Sub

    Private Sub chkCA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCA.CheckedChanged
        If chkCA.Checked = True Then
            chkSB.Checked = False
            AccountNoSearch()
            '' lblAType.Text = "Amt From CA:"
        Else
            txtTrAccountNo.ResetText()
            txtTransFund.ResetText()
        End If
    End Sub

    Private Sub chkSB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSB.CheckedChanged
        If chkSB.Checked = True Then
            chkCA.Checked = False
            AccountNoSearch()
            ''lblAType.Text = "Amt From SB:"
        Else
            txtTrAccountNo.ResetText()
            txtTransFund.ResetText()
        End If
    End Sub


    Private Sub txtAmountByCash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmountByCash.TextChanged
        txtAmount.Text = Val(txtTransFund.Text) + Val(txtAmountByCash.Text)
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    
    Private Sub chkByCash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkByCash.CheckedChanged
        If chkByCash.Checked = True Then
            txtAmountByCash.Enabled = True
        Else
            txtAmountByCash.Enabled = False
            txtAmountByCash.ResetText()
        End If

    End Sub

    Private Sub txtTrAccountNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTrAccountNo.TextChanged
        If txtTrAccountNo.Text = String.Empty Then
            txtTransFund.ReadOnly = True
        Else
            txtTransFund.ReadOnly = False
        End If
    End Sub

    Private Function AccountNoSearch()
        If chkSB.Checked = True Then
            Dim objSBAccSearch As New frmSBAccSearch
            objSBAccSearch.strSBAccountNo = String.Empty
            objSBAccSearch.ShowDialog(Me)
            If objSBAccSearch.strSBAccountNo <> String.Empty Then
                txtTrAccountNo.Text = objSBAccSearch.strSBAccountNo
                sbloaddetails()
                objSBAccSearch.Dispose()
            End If
        ElseIf chkCA.Checked = True Then
            Dim objCAccountSearch As New frmCAccSearch
            objCAccountSearch.strCAccountNo = String.Empty
            objCAccountSearch.ShowDialog(Me)
            If objCAccountSearch.strCAccountNo <> String.Empty Then
                txtTrAccountNo.Text = objCAccountSearch.strCAccountNo
                caloaddetails()
                objCAccountSearch.Dispose()
            End If
        Else
            MsgBox("Select Account Type")
        End If
    End Function
End Class
