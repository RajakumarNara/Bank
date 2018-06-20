Imports System.Math
Imports System.Drawing.Drawing2D

Public Class frmCACashTransaction
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
    Friend WithEvents btnTransfer As BankControls.NewButton
    Friend WithEvents btnVerifyPhotoSign As BankControls.NewButton
    Friend WithEvents btnWithDraw As BankControls.NewButton
    Friend WithEvents btnDeposit As BankControls.NewButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtToAccountNo As BankControls.TextControl
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnToSearch As BankControls.NewButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdTransfer As System.Windows.Forms.RadioButton
    Friend WithEvents rdWithdraw As System.Windows.Forms.RadioButton
    Friend WithEvents rdDeposit As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAvalBal As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblBookBal As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As BankControls.TextControl
    Friend WithEvents dtpDepositDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblODLimit As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblInterst As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtRefno As BankControls.NumericControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents txtAccNo As BankControls.TextControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents NewButton1 As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCACashTransaction))
        Me.btnTransfer = New BankControls.NewButton
        Me.btnVerifyPhotoSign = New BankControls.NewButton
        Me.btnWithDraw = New BankControls.NewButton
        Me.btnDeposit = New BankControls.NewButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblInterst = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblODLimit = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtToAccountNo = New BankControls.TextControl
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnToSearch = New BankControls.NewButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdTransfer = New System.Windows.Forms.RadioButton
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
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNarration = New BankControls.TextControl
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.dtpDepositDate = New System.Windows.Forms.DateTimePicker
        Me.btnCancel = New BankControls.NewButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.NewButton1 = New BankControls.NewButton
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTransfer
        '
        Me.btnTransfer.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransfer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfer.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnTransfer.Location = New System.Drawing.Point(192, 392)
        Me.btnTransfer.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(128, 40)
        Me.btnTransfer.TabIndex = 102
        Me.btnTransfer.Text = "&Transfer"
        Me.btnTransfer.Visible = False
        '
        'btnVerifyPhotoSign
        '
        Me.btnVerifyPhotoSign.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnVerifyPhotoSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerifyPhotoSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVerifyPhotoSign.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerifyPhotoSign.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnVerifyPhotoSign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerifyPhotoSign.Location = New System.Drawing.Point(64, 392)
        Me.btnVerifyPhotoSign.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnVerifyPhotoSign.Name = "btnVerifyPhotoSign"
        Me.btnVerifyPhotoSign.Size = New System.Drawing.Size(120, 40)
        Me.btnVerifyPhotoSign.TabIndex = 103
        Me.btnVerifyPhotoSign.Text = "&Verify Signature"
        Me.btnVerifyPhotoSign.Visible = False
        '
        'btnWithDraw
        '
        Me.btnWithDraw.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnWithDraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithDraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWithDraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithDraw.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnWithDraw.Location = New System.Drawing.Point(192, 392)
        Me.btnWithDraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnWithDraw.Name = "btnWithDraw"
        Me.btnWithDraw.Size = New System.Drawing.Size(128, 40)
        Me.btnWithDraw.TabIndex = 104
        Me.btnWithDraw.Text = "&Withdraw"
        Me.btnWithDraw.Visible = False
        '
        'btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposit.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnDeposit.Image = CType(resources.GetObject("btnDeposit.Image"), System.Drawing.Image)
        Me.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeposit.Location = New System.Drawing.Point(192, 392)
        Me.btnDeposit.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(128, 40)
        Me.btnDeposit.TabIndex = 101
        Me.btnDeposit.Text = "&Deposit"
        Me.btnDeposit.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.cmbType)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.lblInterst)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lblODLimit)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtToAccountNo)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.btnToSearch)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtRefno)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblAvalBal)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblBookBal)
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Controls.Add(Me.txtAccNo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtNarration)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.dtpDepositDate)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(8, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 320)
        Me.Panel1.TabIndex = 100
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(328, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 19)
        Me.Label13.TabIndex = 132
        Me.Label13.Text = "Search By :"
        Me.Label13.Visible = False
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Items.AddRange(New Object() {"Current Account", "Savings Bank"})
        Me.cmbType.Location = New System.Drawing.Point(432, 24)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(160, 24)
        Me.cmbType.TabIndex = 131
        Me.cmbType.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(312, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 19)
        Me.Label12.TabIndex = 130
        Me.Label12.Text = "Intrest :"
        '
        'lblInterst
        '
        Me.lblInterst.AutoSize = True
        Me.lblInterst.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.lblInterst.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterst.Location = New System.Drawing.Point(440, 200)
        Me.lblInterst.Name = "lblInterst"
        Me.lblInterst.Size = New System.Drawing.Size(29, 19)
        Me.lblInterst.TabIndex = 129
        Me.lblInterst.Text = "0.0"
        Me.lblInterst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(312, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 19)
        Me.Label11.TabIndex = 128
        Me.Label11.Text = "OverDraw Limit :"
        '
        'lblODLimit
        '
        Me.lblODLimit.AutoSize = True
        Me.lblODLimit.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.lblODLimit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblODLimit.Location = New System.Drawing.Point(440, 176)
        Me.lblODLimit.Name = "lblODLimit"
        Me.lblODLimit.Size = New System.Drawing.Size(29, 19)
        Me.lblODLimit.TabIndex = 127
        Me.lblODLimit.Text = "0.0"
        Me.lblODLimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 19)
        Me.Label10.TabIndex = 126
        Me.Label10.Text = "From Account No. :"
        Me.Label10.Visible = False
        '
        'txtToAccountNo
        '
        Me.txtToAccountNo.AlphaNumeric = True
        Me.txtToAccountNo.BackColor = System.Drawing.Color.White
        Me.txtToAccountNo.BlankSpace = True
        Me.txtToAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToAccountNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtToAccountNo.Location = New System.Drawing.Point(432, 64)
        Me.txtToAccountNo.LostFocusColour = System.Drawing.Color.White
        Me.txtToAccountNo.Mandatory = False
        Me.txtToAccountNo.MaxLength = 7
        Me.txtToAccountNo.Name = "txtToAccountNo"
        Me.txtToAccountNo.Size = New System.Drawing.Size(128, 23)
        Me.txtToAccountNo.SpecialChar = False
        Me.txtToAccountNo.TabIndex = 5
        Me.txtToAccountNo.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(312, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 19)
        Me.Label9.TabIndex = 125
        Me.Label9.Text = "To Account No. :"
        '
        'btnToSearch
        '
        Me.btnToSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnToSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnToSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToSearch.ForeColor = System.Drawing.Color.Black
        Me.btnToSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(120, Byte), CType(128, Byte), CType(171, Byte))
        Me.btnToSearch.Image = CType(resources.GetObject("btnToSearch.Image"), System.Drawing.Image)
        Me.btnToSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnToSearch.Location = New System.Drawing.Point(568, 64)
        Me.btnToSearch.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnToSearch.Name = "btnToSearch"
        Me.btnToSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnToSearch.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdTransfer)
        Me.GroupBox1.Controls.Add(Me.rdWithdraw)
        Me.GroupBox1.Controls.Add(Me.rdDeposit)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 48)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'rdTransfer
        '
        Me.rdTransfer.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.rdTransfer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdTransfer.Location = New System.Drawing.Point(200, 16)
        Me.rdTransfer.Name = "rdTransfer"
        Me.rdTransfer.TabIndex = 3
        Me.rdTransfer.TabStop = True
        Me.rdTransfer.Text = "Transfer"
        '
        'rdWithdraw
        '
        Me.rdWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.rdWithdraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdWithdraw.Location = New System.Drawing.Point(104, 16)
        Me.rdWithdraw.Name = "rdWithdraw"
        Me.rdWithdraw.Size = New System.Drawing.Size(88, 24)
        Me.rdWithdraw.TabIndex = 2
        Me.rdWithdraw.TabStop = True
        Me.rdWithdraw.Text = "Withdraw"
        '
        'rdDeposit
        '
        Me.rdDeposit.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.rdDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdDeposit.Location = New System.Drawing.Point(8, 16)
        Me.rdDeposit.Name = "rdDeposit"
        Me.rdDeposit.Size = New System.Drawing.Size(80, 24)
        Me.rdDeposit.TabIndex = 1
        Me.rdDeposit.TabStop = True
        Me.rdDeposit.Text = "Deposit"
        '
        'txtRefno
        '
        Me.txtRefno.AfterDecimal = 0
        Me.txtRefno.BeforeDecimal = 7
        Me.txtRefno.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefno.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRefno.Location = New System.Drawing.Point(144, 197)
        Me.txtRefno.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRefno.MaxValue = 0
        Me.txtRefno.MinValue = 0
        Me.txtRefno.Name = "txtRefno"
        Me.txtRefno.Size = New System.Drawing.Size(160, 23)
        Me.txtRefno.TabIndex = 7
        Me.txtRefno.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 19)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "Reference No. :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(312, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 19)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "AvailableBalance :"
        '
        'lblAvalBal
        '
        Me.lblAvalBal.AutoSize = True
        Me.lblAvalBal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvalBal.Location = New System.Drawing.Point(440, 128)
        Me.lblAvalBal.Name = "lblAvalBal"
        Me.lblAvalBal.Size = New System.Drawing.Size(29, 19)
        Me.lblAvalBal.TabIndex = 119
        Me.lblAvalBal.Text = "0.0"
        Me.lblAvalBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(312, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 19)
        Me.Label8.TabIndex = 118
        Me.Label8.Text = "BookBalance :"
        '
        'lblBookBal
        '
        Me.lblBookBal.AutoSize = True
        Me.lblBookBal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookBal.Location = New System.Drawing.Point(440, 152)
        Me.lblBookBal.Name = "lblBookBal"
        Me.lblBookBal.Size = New System.Drawing.Size(29, 19)
        Me.lblBookBal.TabIndex = 117
        Me.lblBookBal.Text = "0.0"
        Me.lblBookBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAmount
        '
        Me.txtAmount.AfterDecimal = 2
        Me.txtAmount.BackColor = System.Drawing.Color.White
        Me.txtAmount.BeforeDecimal = 7
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmount.Location = New System.Drawing.Point(144, 164)
        Me.txtAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAmount.MaxValue = 0
        Me.txtAmount.MinValue = 0
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(160, 23)
        Me.txtAmount.TabIndex = 6
        Me.txtAmount.Text = ""
        '
        'txtAccNo
        '
        Me.txtAccNo.AlphaNumeric = True
        Me.txtAccNo.BackColor = System.Drawing.Color.White
        Me.txtAccNo.BlankSpace = True
        Me.txtAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccNo.Location = New System.Drawing.Point(144, 64)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.White
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.MaxLength = 7
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.Size = New System.Drawing.Size(128, 23)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 2
        Me.txtAccNo.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 19)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Narration :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 19)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Amount : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 19)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Account No"
        '
        'txtNarration
        '
        Me.txtNarration.AlphaNumeric = True
        Me.txtNarration.BlankSpace = True
        Me.txtNarration.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNarration.Location = New System.Drawing.Point(144, 232)
        Me.txtNarration.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNarration.Mandatory = False
        Me.txtNarration.MaxLength = 100
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarration.Size = New System.Drawing.Size(440, 72)
        Me.txtNarration.SpecialChar = False
        Me.txtNarration.TabIndex = 8
        Me.txtNarration.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 19)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "Name :"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.AutoSize = False
        Me.txtName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(144, 97)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(416, 24)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 4
        Me.txtName.TabStop = False
        Me.txtName.Text = ""
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(120, Byte), CType(128, Byte), CType(171, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(280, 64)
        Me.btnSearch.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 3
        '
        'dtpDepositDate
        '
        Me.dtpDepositDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDepositDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDepositDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDepositDate.Location = New System.Drawing.Point(144, 131)
        Me.dtpDepositDate.Name = "dtpDepositDate"
        Me.dtpDepositDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpDepositDate.TabIndex = 5
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(464, 392)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(128, 40)
        Me.btnCancel.TabIndex = 106
        Me.btnCancel.Text = "&Cancel"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 107
        Me.PictureBox1.TabStop = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline)
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(72, 24)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(305, 25)
        Me.Label32.TabIndex = 106
        Me.Label32.Text = "Current Account Cash Transaction"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NewButton1
        '
        Me.NewButton1.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.NewButton1.Location = New System.Drawing.Point(328, 392)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(128, 40)
        Me.NewButton1.TabIndex = 105
        Me.NewButton1.Text = "&Reset"
        '
        'frmCACashTransaction
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(618, 447)
        Me.Controls.Add(Me.NewButton1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.btnVerifyPhotoSign)
        Me.Controls.Add(Me.btnWithDraw)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCACashTransaction"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Current Account Cash Transaction"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Form Global Variables"
    Dim objCurrentAccount As New clsCurrentAccount
    Dim dblAvalAmount As Double
    Dim dblBookAmount As Double
    Dim dblOverDrawLimit As Double
    Dim ToolTip1 As New ToolTip
    Dim dblCalIntrest As Double
    Dim ROI As Double
    Dim dblInterest1 As Double
    Dim dblInterest2 As Double
    Dim objLedger As New clsLedger
#End Region


#Region "Functions And SubRoutines"

    Public Sub sbClear()
        txtAmount.ResetText()
        txtNarration.ResetText()
        txtRefno.ResetText()
        txtName.ResetText()
        txtAccNo.ResetText()
        lblAvalBal.Text = "0.0"
        lblBookBal.Text = "0.0"
        lblODLimit.Text = "0.0"
        lblInterst.Text = "0.0"
        txtAccNo.Focus()
    End Sub

    Function fnCheck() As Boolean
        If Trim(txtAccNo.Text) = String.Empty Then
            MsgBox("Enter account no.", MsgBoxStyle.Exclamation)
            txtAccNo.Focus()
            Return False
        ElseIf Trim(txtAmount.Text) = String.Empty Then
            MsgBox("Enter amount", MsgBoxStyle.Exclamation)
            txtAmount.Focus()
            Return False
        ElseIf Trim(txtRefno.Text) = String.Empty Then
            MsgBox("Enter reference no.", MsgBoxStyle.Exclamation)
            txtRefno.Focus()
            Return False
        Else
            Return True
        End If
    End Function
    Function fnSetdata() As Boolean
        objCurrentAccount.CurAccountNo = txtAccNo.Text
        objCurrentAccount.Accdate = dtpDepositDate.Value
        Return True
    End Function

    Sub caloaddetails()
        If Trim(txtAccNo.Text) <> String.Empty Then
            If objCurrentAccount.fnGetCAccountDetails(Trim(txtAccNo.Text)) Then
                If objCurrentAccount.CAAccTable.Rows(0).Item("AccStatus") = "A" Then
                    txtAccNo.Text = objCurrentAccount.CAAccTable.Rows(0).Item("CAccountNo")
                    txtName.Text = objCurrentAccount.CAAccTable.Rows(0).Item("Name")
                    dblAvalAmount = objCurrentAccount.CAAccTable.Rows(0).Item("AvailBalance")
                    lblAvalBal.Text = Format(dblAvalAmount, "0,00.00")
                    ToolTip1.SetToolTip(lblAvalBal, GetFigures(dblAvalAmount))
                    dblBookAmount = objCurrentAccount.CAAccTable.Rows(0).Item("BookBalance")
                    lblBookBal.Text = Format(dblBookAmount, "0,00.00")
                    dblOverDrawLimit = objCurrentAccount.CAAccTable.Rows(0).Item("ODLimit")
                    lblODLimit.Text = Format(dblOverDrawLimit, "0,00.00")
                    lblInterst.Text = objCurrentAccount.CAAccTable.Rows(0).Item("IntAmount")
                Else
                    MsgBox("This account no." & Trim(txtAccNo.Text) & " is already closed")
                    txtAccNo.Focus()
                    sbClear()
                End If
            Else
                MsgBox("Account no. does not exist!", MsgBoxStyle.Exclamation, Me.Text)
                txtAccNo.Focus()
                sbClear()
                txtAccNo.SelectAll()
            End If
        End If
    End Sub

    Function fnGenerateVoucherD(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entery
        Dim strNarration As String = "Cash deposit by " & txtAccNo.Text & "  Narration:" & txtNarration.Text
        Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtAmount.Text) & "','" & dblInterest1 & "','" & Trim(txtRefno.Text) & "','" & lngVoucherNo & "','Cash','0' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
        fnExecuteNonQuery(strsql, objTrans)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtAccNo.Text, txtRefno.Text, dtpDepositDate.Value, txtAmount.Text, "Deposit by" & txtAccNo.Text, lngSlNo, "Y", objTrans)

        If Val(dblAvalAmount) < 0 Then
            Dim dblTempBalance As Double = Val(dblAvalAmount) + Val(txtAmount.Text)

            If dblTempBalance < 0 Then

                'Credit accounts 
                fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpDepositDate.Value, "Cash deposit by " & txtAccNo.Text, "To", 12, 0, Val(txtAmount.Text), 1, "Y", objTrans)

                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpDepositDate.Value, "Cash deposit by " & txtAccNo.Text, "By", 1, Val(txtAmount.Text), 0, 2, "Y", objTrans)
            Else

                If dblTempBalance <> 0 Then
                    'Credit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpDepositDate.Value, "Cash deposit by " & txtAccNo.Text, "To", 11, 0, Abs(dblTempBalance), 1, "Y", objTrans)
                End If

                'Credit accounts 
                fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpDepositDate.Value, "Cash deposit by " & txtAccNo.Text, "To", 12, 0, Abs(dblAvalAmount), 2, "Y", objTrans)

                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpDepositDate.Value, "Cash deposit by " & txtAccNo.Text, "By", 1, Val(txtAmount.Text), 0, 3, "Y", objTrans)
            End If
        Else
            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpDepositDate.Value, "Cash deposit by " & txtAccNo.Text, "To", 11, 0, Val(txtAmount.Text), 1, "Y", objTrans)

            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpDepositDate.Value, "Cash deposit by " & txtAccNo.Text, "By", 1, Val(txtAmount.Text), 0, 2, "Y", objTrans)
        End If

        Return True

    End Function

    Function fnGenerateVoucherW(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entry
        Dim strNarration As String = "Cash withdraw by " & txtAccNo.Text & " Narration:" & txtNarration.Text
        Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtAmount.Text) & "','" & dblInterest1 & "','" & Trim(txtRefno.Text) & "','" & lngVoucherNo & "','Cash','0' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
        fnExecuteNonQuery(strsql, objTrans)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 1, txtAccNo.Text, txtRefno.Text, dtpDepositDate.Value, txtAmount.Text, "Cash withdraw by " & txtAccNo.Text, lngSlNo, "Y", objTrans)

        If dblAvalAmount <= 0 Then
            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDepositDate.Value, "Cash withdraw by " & txtAccNo.Text, "To", 1, 0, Val(txtAmount.Text), 1, "Y", objTrans)
            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpDepositDate.Value, "Cash withdraw by " & txtAccNo.Text, "By", 12, Val(txtAmount.Text), 0, 2, "Y", objTrans)
        Else
            Dim dblTempBalance As Double = Val(dblAvalAmount) - Val(txtAmount.Text)
            If dblTempBalance < 0 Then
                'Credit accounts
                fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDepositDate.Value, "Cash withdraw by " & txtAccNo.Text, "To", 1, 0, Val(txtAmount.Text), 1, "Y", objTrans)

                'Debit accounts
                fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpDepositDate.Value, "Cash withdraw by " & txtAccNo.Text, "By", 11, Abs(dblAvalAmount), 0, 2, "Y", objTrans)

                ' If dblTempBalance <> 0 Then
                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpDepositDate.Value, "Cash withdraw by " & txtAccNo.Text, "By", 12, Abs(dblTempBalance), 0, 3, "Y", objTrans)
                'End If
            Else
                'Credit accounts
                fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDepositDate.Value, "Cash withdraw by " & txtAccNo.Text, "To", 1, 0, Val(txtAmount.Text), 1, "Y", objTrans)
                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpDepositDate.Value, "Cash withdraw by " & txtAccNo.Text, "By", 11, Val(txtAmount.Text), 0, 2, "Y", objTrans)
            End If
        End If
        Return True
    End Function

    Function fnGenerateVoucherT(ByVal objTrans As IDbTransaction) As Boolean

        Dim dblAmount As Double

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entery

        Dim strNarration As String = "Transfer by " & txtAccNo.Text & "  Narration:" & txtNarration.Text
        ' objSavingsBank.fnUpdateStatus(lngVoucherNo, strNarration)

        Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtAmount.Text) & "','" & dblInterest1 & "','" & Trim(txtRefno.Text) & "','" & lngVoucherNo & "','Transfer','0' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
        fnExecuteNonQuery(strsql, objTrans)

        ' Dim strAccountNo As String = objSavingsBank.SBCheckBookBookTable.Rows(0).Item("AccountNo")
        Dim strsql1 = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
        strsql1 = strsql1 & " select '" & Trim(txtToAccountNo.Text) & "','" & Format(dtpDepositDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtAmount.Text) & "','" & dblInterest2 & "','" & Trim(txtRefno.Text) & "','" & lngVoucherNo & "','Transfer','0' from catransactiontbl where caccountno='" & Trim(txtToAccountNo.Text) & "' group by CAccountno"
        fnExecuteNonQuery(strsql1, objTrans)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 7, txtAccNo.Text, txtRefno.Text, dtpDepositDate.Value, txtAmount.Text, "Transfer by" & txtAccNo.Text, lngSlNo, "Y", objTrans)


        If dblAvalAmount <= 0 Then
            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 7, txtAccNo.Text, dtpDepositDate.Value, "Transfered to " & txtAccNo.Text, "By", 12, Val(txtAmount.Text), 0, 1, "Y", objTrans)
        Else
            Dim dblTempBalance As Double = Val(dblAvalAmount) - Val(txtAmount.Text)
            If dblTempBalance < 0 Then
                'Debit accounts
                fnVoucherEnterSub(lngVoucherNo, 7, txtAccNo.Text, dtpDepositDate.Value, "Transfered to " & txtToAccountNo.Text, "By", 11, Abs(dblAvalAmount), 0, 1, "Y", objTrans)

                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 7, txtAccNo.Text, dtpDepositDate.Value, "Transfered to " & txtToAccountNo.Text, "By", 12, Abs(dblTempBalance), 0, 2, "Y", objTrans)
            Else
                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 7, txtAccNo.Text, dtpDepositDate.Value, "Transfered to " & txtToAccountNo.Text, "By", 11, Val(txtAmount.Text), 0, 1, "Y", objTrans)
            End If
        End If


        If objCurrentAccount.fnGetCAccountDetails(Trim(txtToAccountNo.Text)) Then
            dblAmount = objCurrentAccount.CAAccTable.Rows(0).Item("AvailBalance")

            If Val(dblAmount) < 0 Then
                Dim dblTempBalance As Double = Val(dblAmount) + Val(txtAmount.Text)

                If dblTempBalance < 0 Then
                    'Credit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 7, txtToAccountNo.Text, dtpDepositDate.Value, "Recived from " & txtAccNo.Text, "to", 12, 0, Val(txtAmount.Text), 2, "Y", objTrans)
                Else
                    If dblTempBalance <> 0 Then
                        'Credit accounts 
                        fnVoucherEnterSub(lngVoucherNo, 7, txtToAccountNo.Text, dtpDepositDate.Value, "Recived from " & txtAccNo.Text, "To", 11, 0, Abs(dblTempBalance), 2, "Y", objTrans)
                    End If
                    'Credit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 7, txtToAccountNo.Text, dtpDepositDate.Value, "Recived from " & txtAccNo.Text, "To", 12, 0, Abs(dblAvalAmount), 2, "Y", objTrans)
                End If
            Else
                'Credit accounts
                fnVoucherEnterSub(lngVoucherNo, 7, txtToAccountNo.Text, dtpDepositDate.Value, "Recived from " & txtAccNo.Text, "To", 11, 0, Val(txtAmount.Text), 2, "Y", objTrans)
            End If

        End If

        Return True

    End Function


#End Region

    Private Sub txtAccNo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNo.Leave
        If Trim(txtAccNo.Text <> String.Empty) Then
            AutoLoad()
            caloaddetails()
        End If
    End Sub

    Private Sub rdDeposit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdDeposit.CheckedChanged
        btnDeposit.Visible = True
        btnTransfer.Visible = False
        btnWithDraw.Visible = False
        btnVerifyPhotoSign.Visible = False
        txtToAccountNo.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        btnToSearch.Visible = False
        Panel1.BackColor = Panel1.BackColor.PaleGreen()
    End Sub

    Private Sub rdWithdraw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdWithdraw.CheckedChanged
        btnDeposit.Visible = False
        btnTransfer.Visible = False
        btnWithDraw.Visible = True
        btnVerifyPhotoSign.Visible = True
        txtToAccountNo.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        btnToSearch.Visible = False
        Panel1.BackColor = Panel1.BackColor.Pink()
    End Sub

    Private Sub rdTransfer_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdTransfer.CheckedChanged
        btnDeposit.Visible = False
        btnTransfer.Visible = True
        btnWithDraw.Visible = False
        btnVerifyPhotoSign.Visible = False
        txtToAccountNo.Visible = True
        txtToAccountNo.ResetText()
        Label9.Visible = True
        Label10.Visible = True
        btnToSearch.Visible = True
        Panel1.BackColor = Panel1.BackColor.PowderBlue()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim objCAccSearch As New frmCAccSearch
        objCAccSearch.strCAccountNo = String.Empty
        objCAccSearch.ShowDialog(Me)
        If objCAccSearch.strCAccountNo <> String.Empty Then
            txtAccNo.Text = objCAccSearch.strCAccountNo
            caloaddetails()
        End If
        objCAccSearch.Dispose()
    End Sub

    Private Sub btnToSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToSearch.Click
        Dim objCAccSearch As New frmCAccSearch
        objCAccSearch.strCAccountNo = String.Empty
        objCAccSearch.ShowDialog(Me)
        If objCAccSearch.strCAccountNo <> String.Empty Then
            txtToAccountNo.Text = objCAccSearch.strCAccountNo
        End If
        objCAccSearch.Dispose()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnVerifyPhotoSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerifyPhotoSign.Click
        If txtAccNo.Text <> String.Empty Then
            Dim ObjPhotoSign As New frmCASignPhoto
            ObjPhotoSign.txtAccno.Text = Me.txtAccNo.Text
            ObjPhotoSign.txtName.Text = Me.txtName.Text
            ObjPhotoSign.txtAccno.ReadOnly = True
            ObjPhotoSign.txtName.ReadOnly = True
            ObjPhotoSign.btnSearch.Enabled = False
            ObjPhotoSign.ShowDialog(Me)
        Else
            MsgBox("Enter Accouont Number", MsgBoxStyle.Exclamation)
            txtAccNo.Focus()
        End If
    End Sub

    Private Sub frmCACashTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpDepositDate.Value = Date.Now.Date
        If objCurrentAccount.fnGetCAMasterData Then
            ROI = objCurrentAccount.CAMasterTable.Rows(0).Item("CAROI")
        Else
            ROI = 0
        End If
        If Trim(txtAccNo.Text <> String.Empty) Then
            caloaddetails()
        End If
    End Sub

    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click

        Dim objTrans As IDbTransaction
        objTrans = fnGetTransaction()

        Try
            If fnCheck() Then
                If MsgBox("Current accountno  :  " & txtAccNo.Text & " " & Chr(13) & " Deposit Amount  :  " & txtAmount.Text & " " & Chr(13) & " Type :  Cash") = MsgBoxResult.OK Then
                    If fnSetdata() Then
                        fnGenerateVoucherD(objTrans)
                        fnLogEntry(pbUserId, "Cash deposit by account" & txtAccNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction Deposit", objTrans)
                        objTrans.Commit()
                        If MsgBox("Transaction completed sucessfully" & Chr(13) & " Do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                            sbClear()
                            caloaddetails()
                        Else
                            Me.Close()
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
                MsgBox("Insufficient fund,please chesk the cash", MsgBoxStyle.Exclamation, Me.Text)
                Return False
            End If
        End If
    End Function

    Private Sub btnWithDraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithDraw.Click

        Dim objTrans As IDbTransaction
        objTrans = fnGetTransaction()



        Try
            If fnCheck() Then
                If rdWithdraw.Checked = True Then
                    'If fnCheckFund() Then
                    If fnCheakBalance() Then
                        If MsgBox("Current accountno  :  " & txtAccNo.Text & " " & Chr(13) & " WithDraw Amount  :  " & txtAmount.Text & " " & Chr(13) & " Type  :  Cash", MsgBoxStyle.OKCancel) = MsgBoxResult.OK Then
                            If fnSetdata() Then
                                fnGenerateVoucherW(objTrans)
                                fnLogEntry(pbUserId, "Cash withdraw by account " & txtAccNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction Withdraw", objTrans)
                                objTrans.Commit()
                                If MsgBox("Transaction completed sucessfully" & Chr(13) & " Do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                    sbClear()
                                    caloaddetails()
                                Else
                                    Me.Close()
                                End If
                            End If
                        End If
                        'End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            objTrans.Dispose()
        End Try


    End Sub


    Private Sub btnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransfer.Click

        Dim objTrans As IDbTransaction
        objTrans = fnGetTransaction()

        Try

            If fnCheck() Then
                If rdTransfer.Checked = True Then
                    If txtToAccountNo.Text = "" Then
                        MsgBox("Enter toaccount number ", MsgBoxStyle.Exclamation)
                        txtToAccountNo.Focus()
                    ElseIf Trim(txtAccNo.Text) = Trim(txtToAccountNo.Text) Then
                        MsgBox("From and to account no. sould not be same", MsgBoxStyle.Information)
                        txtToAccountNo.Focus()
                    Else
                        If fnCheakBalance() Then
                            If MsgBox("Current accountno  :  " & txtAccNo.Text & " " & Chr(13) & " Transfer Amount  :  " & txtAmount.Text & " " & Chr(13) & " Type  :  Transfer", MsgBoxStyle.OKCancel) = MsgBoxResult.OK Then
                                If fnSetdata() Then
                                    fnGenerateVoucherT(objTrans)
                                    fnLogEntry(pbUserId, "Transfer by " & txtAccNo.Text & " amount " & txtAmount.Text, Date.Now, "Transaction Transfer", objTrans)
                                    objTrans.Commit()
                                    If MsgBox("Transaction completed sucessfully" & Chr(13) & " ,Do tou want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                                        sbClear()
                                        caloaddetails()
                                    Else
                                        Me.Close()
                                    End If
                                End If
                            End If
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

    Public Sub AutoLoad()
        Select Case txtAccNo.Text.Length
            Case "1"
                txtAccNo.Text = "CA0000" & txtAccNo.Text
            Case "2"
                txtAccNo.Text = "CA000" & txtAccNo.Text
            Case "3"
                txtAccNo.Text = "CA00" & txtAccNo.Text
            Case "4"
                txtAccNo.Text = "CA0" & txtAccNo.Text
            Case "5"
                txtAccNo.Text = "CA" & txtAccNo.Text
        End Select
    End Sub
    Public Sub AutoLoadTo()
        Select Case txtToAccountNo.Text.Length
            Case "1"
                txtToAccountNo.Text = "CA0000" & txtToAccountNo.Text
            Case "2"
                txtToAccountNo.Text = "CA000" & txtToAccountNo.Text
            Case "3"
                txtToAccountNo.Text = "CA00" & txtToAccountNo.Text
            Case "4"
                txtToAccountNo.Text = "CA0" & txtToAccountNo.Text
            Case "5"
                txtToAccountNo.Text = "CA" & txtToAccountNo.Text
        End Select
    End Sub

    Private Sub txtToAccountNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtToAccountNo.Leave
        If txtToAccountNo.Text <> String.Empty Then
            AutoLoadTo()
            If objCurrentAccount.fnGetCAccountDetails(Trim(txtToAccountNo.Text)) Then
                If objCurrentAccount.CAAccTable.Rows(0).Item("AccStatus") = "C" Then
                    MsgBox("Account number " & Trim(txtToAccountNo.Text) & " is Closed")
                    txtToAccountNo.ResetText()
                    txtToAccountNo.Focus()
                End If
            Else
                MsgBox("To account number does not exist!", MsgBoxStyle.Exclamation, Me.Text)
                txtToAccountNo.ResetText()
                txtToAccountNo.Focus()
            End If
        End If
    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click
        sbClear()
    End Sub
End Class
