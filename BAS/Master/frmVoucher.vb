Public Class frmVoucher
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents btnDeposit As BankControls.NewButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblInterst As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblODLimit As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtToAccountNo As BankControls.TextControl
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnToSearch As BankControls.NewButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdTransfer As System.Windows.Forms.RadioButton
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
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextControl1 As BankControls.TextControl
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmVoucher))
        Me.btnTransfer = New BankControls.NewButton
        Me.btnVerifyPhotoSign = New BankControls.NewButton
        Me.btnWithDraw = New BankControls.NewButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.btnCancel = New BankControls.NewButton
        Me.btnDeposit = New BankControls.NewButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.TextControl1 = New BankControls.TextControl
        Me.Label14 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
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
        Me.btnTransfer.Location = New System.Drawing.Point(480, 528)
        Me.btnTransfer.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(128, 40)
        Me.btnTransfer.TabIndex = 110
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
        Me.btnVerifyPhotoSign.Location = New System.Drawing.Point(336, 528)
        Me.btnVerifyPhotoSign.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnVerifyPhotoSign.Name = "btnVerifyPhotoSign"
        Me.btnVerifyPhotoSign.Size = New System.Drawing.Size(120, 40)
        Me.btnVerifyPhotoSign.TabIndex = 111
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
        Me.btnWithDraw.Location = New System.Drawing.Point(480, 528)
        Me.btnWithDraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnWithDraw.Name = "btnWithDraw"
        Me.btnWithDraw.Size = New System.Drawing.Size(128, 40)
        Me.btnWithDraw.TabIndex = 112
        Me.btnWithDraw.Text = "&Withdraw"
        Me.btnWithDraw.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 115
        Me.PictureBox1.TabStop = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(72, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(305, 25)
        Me.Label32.TabIndex = 114
        Me.Label32.Text = "Current Account Cash Transaction"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnCancel.Location = New System.Drawing.Point(632, 528)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(128, 40)
        Me.btnCancel.TabIndex = 113
        Me.btnCancel.Text = "&Cancel"
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
        Me.btnDeposit.Location = New System.Drawing.Point(480, 528)
        Me.btnDeposit.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(128, 40)
        Me.btnDeposit.TabIndex = 109
        Me.btnDeposit.Text = "&Deposit"
        Me.btnDeposit.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.TextControl1)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.ComboBox1)
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
        Me.Panel1.Location = New System.Drawing.Point(8, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 456)
        Me.Panel1.TabIndex = 108
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 296)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 19)
        Me.Label16.TabIndex = 144
        Me.Label16.Text = "Intrest"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(144, 296)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(27, 19)
        Me.Label17.TabIndex = 143
        Me.Label17.Text = "0.0"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 264)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(110, 19)
        Me.Label18.TabIndex = 142
        Me.Label18.Text = "OverDraw Limit"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(144, 264)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(27, 19)
        Me.Label19.TabIndex = 141
        Me.Label19.Text = "0.0"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 200)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(118, 19)
        Me.Label20.TabIndex = 140
        Me.Label20.Text = "AvailableBalance"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(144, 200)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(27, 19)
        Me.Label21.TabIndex = 139
        Me.Label21.Text = "0.0"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(16, 232)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(91, 19)
        Me.Label22.TabIndex = 138
        Me.Label22.Text = "BookBalance"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(144, 232)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(27, 19)
        Me.Label23.TabIndex = 137
        Me.Label23.Text = "0.0"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(360, 168)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 19)
        Me.Label15.TabIndex = 136
        Me.Label15.Text = "Name"
        '
        'TextControl1
        '
        Me.TextControl1.AlphaNumeric = False
        Me.TextControl1.AutoSize = False
        Me.TextControl1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextControl1.BlankSpace = False
        Me.TextControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextControl1.GotFocusColour = System.Drawing.SystemColors.Info
        Me.TextControl1.Location = New System.Drawing.Point(480, 168)
        Me.TextControl1.LostFocusColour = System.Drawing.Color.Empty
        Me.TextControl1.Mandatory = False
        Me.TextControl1.Name = "TextControl1"
        Me.TextControl1.ReadOnly = True
        Me.TextControl1.Size = New System.Drawing.Size(160, 24)
        Me.TextControl1.SpecialChar = False
        Me.TextControl1.TabIndex = 135
        Me.TextControl1.TabStop = False
        Me.TextControl1.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(148, 19)
        Me.Label14.TabIndex = 134
        Me.Label14.Text = "Transaction Through "
        Me.Label14.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Items.AddRange(New Object() {"Cheque", "Cash"})
        Me.ComboBox1.Location = New System.Drawing.Point(192, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 133
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 19)
        Me.Label13.TabIndex = 132
        Me.Label13.Text = "Account Type  "
        Me.Label13.Visible = False
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Items.AddRange(New Object() {"Current Account", "Savings Bank"})
        Me.cmbType.Location = New System.Drawing.Point(192, 8)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(160, 24)
        Me.cmbType.TabIndex = 131
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(360, 296)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 19)
        Me.Label12.TabIndex = 130
        Me.Label12.Text = "Intrest"
        '
        'lblInterst
        '
        Me.lblInterst.AutoSize = True
        Me.lblInterst.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.lblInterst.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterst.Location = New System.Drawing.Point(488, 296)
        Me.lblInterst.Name = "lblInterst"
        Me.lblInterst.Size = New System.Drawing.Size(27, 19)
        Me.lblInterst.TabIndex = 129
        Me.lblInterst.Text = "0.0"
        Me.lblInterst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(360, 264)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 19)
        Me.Label11.TabIndex = 128
        Me.Label11.Text = "OverDraw Limit"
        '
        'lblODLimit
        '
        Me.lblODLimit.AutoSize = True
        Me.lblODLimit.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.lblODLimit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblODLimit.Location = New System.Drawing.Point(488, 264)
        Me.lblODLimit.Name = "lblODLimit"
        Me.lblODLimit.Size = New System.Drawing.Size(27, 19)
        Me.lblODLimit.TabIndex = 127
        Me.lblODLimit.Text = "0.0"
        Me.lblODLimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 19)
        Me.Label10.TabIndex = 126
        Me.Label10.Text = "From Account No"
        Me.Label10.Visible = False
        '
        'txtToAccountNo
        '
        Me.txtToAccountNo.AlphaNumeric = True
        Me.txtToAccountNo.BackColor = System.Drawing.Color.White
        Me.txtToAccountNo.BlankSpace = False
        Me.txtToAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToAccountNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtToAccountNo.Location = New System.Drawing.Point(480, 136)
        Me.txtToAccountNo.LostFocusColour = System.Drawing.Color.White
        Me.txtToAccountNo.Mandatory = False
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
        Me.Label9.Location = New System.Drawing.Point(360, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 19)
        Me.Label9.TabIndex = 125
        Me.Label9.Text = "To Account No"
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
        Me.btnToSearch.Location = New System.Drawing.Point(616, 136)
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
        Me.GroupBox1.Location = New System.Drawing.Point(16, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 48)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'rdTransfer
        '
        Me.rdTransfer.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.rdTransfer.Font = New System.Drawing.Font("Georgia", 9.75!)
        Me.rdTransfer.Location = New System.Drawing.Point(240, 12)
        Me.rdTransfer.Name = "rdTransfer"
        Me.rdTransfer.Size = New System.Drawing.Size(88, 24)
        Me.rdTransfer.TabIndex = 3
        Me.rdTransfer.TabStop = True
        Me.rdTransfer.Text = "Transfer"
        Me.rdTransfer.Visible = False
        '
        'rdWithdraw
        '
        Me.rdWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.rdWithdraw.Font = New System.Drawing.Font("Georgia", 9.75!)
        Me.rdWithdraw.Location = New System.Drawing.Point(128, 12)
        Me.rdWithdraw.Name = "rdWithdraw"
        Me.rdWithdraw.Size = New System.Drawing.Size(88, 24)
        Me.rdWithdraw.TabIndex = 2
        Me.rdWithdraw.TabStop = True
        Me.rdWithdraw.Text = "Withdraw"
        '
        'rdDeposit
        '
        Me.rdDeposit.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.rdDeposit.Font = New System.Drawing.Font("Georgia", 9.75!)
        Me.rdDeposit.Location = New System.Drawing.Point(24, 12)
        Me.rdDeposit.Name = "rdDeposit"
        Me.rdDeposit.Size = New System.Drawing.Size(72, 24)
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
        Me.txtRefno.Location = New System.Drawing.Point(480, 328)
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
        Me.Label4.Location = New System.Drawing.Point(360, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 19)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "Reference No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(360, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 19)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "AvailableBalance"
        '
        'lblAvalBal
        '
        Me.lblAvalBal.AutoSize = True
        Me.lblAvalBal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvalBal.Location = New System.Drawing.Point(488, 200)
        Me.lblAvalBal.Name = "lblAvalBal"
        Me.lblAvalBal.Size = New System.Drawing.Size(27, 19)
        Me.lblAvalBal.TabIndex = 119
        Me.lblAvalBal.Text = "0.0"
        Me.lblAvalBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(360, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 19)
        Me.Label8.TabIndex = 118
        Me.Label8.Text = "BookBalance"
        '
        'lblBookBal
        '
        Me.lblBookBal.AutoSize = True
        Me.lblBookBal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookBal.Location = New System.Drawing.Point(488, 232)
        Me.lblBookBal.Name = "lblBookBal"
        Me.lblBookBal.Size = New System.Drawing.Size(27, 19)
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
        Me.txtAmount.Location = New System.Drawing.Point(136, 328)
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
        Me.txtAccNo.BlankSpace = False
        Me.txtAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccNo.Location = New System.Drawing.Point(152, 136)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.White
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.MaxLength = 10
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.Size = New System.Drawing.Size(128, 23)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 3
        Me.txtAccNo.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(384, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 19)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 19)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Narration"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 19)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 136)
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
        Me.txtNarration.Location = New System.Drawing.Point(136, 368)
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
        Me.Label7.Location = New System.Drawing.Point(16, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 19)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "Name"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.AutoSize = False
        Me.txtName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtName.BlankSpace = False
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(152, 168)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(160, 24)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 5
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
        Me.btnSearch.Location = New System.Drawing.Point(288, 136)
        Me.btnSearch.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'dtpDepositDate
        '
        Me.dtpDepositDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDepositDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDepositDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDepositDate.Location = New System.Drawing.Point(480, 88)
        Me.dtpDepositDate.Name = "dtpDepositDate"
        Me.dtpDepositDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpDepositDate.TabIndex = 4
        '
        'frmVoucher
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.ClientSize = New System.Drawing.Size(920, 621)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.btnVerifyPhotoSign)
        Me.Controls.Add(Me.btnWithDraw)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVoucher"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmVoucher"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnVerifyPhotoSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerifyPhotoSign.Click

    End Sub

    Private Sub btnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransfer.Click

    End Sub
End Class
