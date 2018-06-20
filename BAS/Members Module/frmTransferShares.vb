Public Class frmTransferShares
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpTransfer As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFromAccNo As BankControls.TextControl
    Friend WithEvents txtNoOfShares As BankControls.NumericControl
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents txtFromName As BankControls.TextControl
    Friend WithEvents txtBalance As BankControls.NumericControl
    Friend WithEvents txtToName As BankControls.TextControl
    Friend WithEvents txtToAccNo As BankControls.TextControl
    Friend WithEvents rdbDeath As System.Windows.Forms.RadioButton
    Friend WithEvents rdbOther As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMisuse As System.Windows.Forms.RadioButton
    Friend WithEvents txtReason As BankControls.TextControl
    Friend WithEvents btnTransfer As BankControls.NewButton
    Friend WithEvents btnExit As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents btnFromMember As BankControls.NewButton
    Friend WithEvents btnToMember As BankControls.NewButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtToNoOfShares As BankControls.NumericControl
    Friend WithEvents lblReason As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTransferShares))
        Me.dtpTransfer = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtFromAccNo = New BankControls.TextControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtNoOfShares = New BankControls.NumericControl
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnFromMember = New BankControls.NewButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAmount = New BankControls.NumericControl
        Me.txtFromName = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtToNoOfShares = New BankControls.NumericControl
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtBalance = New BankControls.NumericControl
        Me.btnToMember = New BankControls.NewButton
        Me.txtToName = New BankControls.TextControl
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtToAccNo = New BankControls.TextControl
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtReason = New BankControls.TextControl
        Me.lblReason = New System.Windows.Forms.Label
        Me.rdbDeath = New System.Windows.Forms.RadioButton
        Me.rdbOther = New System.Windows.Forms.RadioButton
        Me.rdbMisuse = New System.Windows.Forms.RadioButton
        Me.btnTransfer = New BankControls.NewButton
        Me.btnExit = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpTransfer
        '
        Me.dtpTransfer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.dtpTransfer.CustomFormat = "dd - MMM - yyyy"
        Me.dtpTransfer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTransfer.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTransfer.Location = New System.Drawing.Point(136, 16)
        Me.dtpTransfer.MaxDate = New Date(9998, 9, 3, 0, 0, 0, 0)
        Me.dtpTransfer.Name = "dtpTransfer"
        Me.dtpTransfer.Size = New System.Drawing.Size(152, 23)
        Me.dtpTransfer.TabIndex = 1
        Me.dtpTransfer.Value = New Date(2007, 9, 12, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(64, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 19)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Date : "
        '
        'txtFromAccNo
        '
        Me.txtFromAccNo.AlphaNumeric = True
        Me.txtFromAccNo.BackColor = System.Drawing.Color.White
        Me.txtFromAccNo.BlankSpace = False
        Me.txtFromAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFromAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFromAccNo.Location = New System.Drawing.Point(128, 32)
        Me.txtFromAccNo.LostFocusColour = System.Drawing.Color.White
        Me.txtFromAccNo.Mandatory = False
        Me.txtFromAccNo.MaxLength = 10
        Me.txtFromAccNo.Name = "txtFromAccNo"
        Me.txtFromAccNo.ReadOnly = True
        Me.txtFromAccNo.Size = New System.Drawing.Size(152, 23)
        Me.txtFromAccNo.SpecialChar = False
        Me.txtFromAccNo.TabIndex = 2
        Me.txtFromAccNo.TabStop = False
        Me.txtFromAccNo.Text = "MB"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 19)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Member No. :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 112)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(114, 19)
        Me.Label25.TabIndex = 73
        Me.Label25.Text = "No. Of Shares : "
        '
        'txtNoOfShares
        '
        Me.txtNoOfShares.AfterDecimal = 0
        Me.txtNoOfShares.BeforeDecimal = 12
        Me.txtNoOfShares.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfShares.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNoOfShares.Location = New System.Drawing.Point(128, 112)
        Me.txtNoOfShares.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNoOfShares.MaxValue = 999999999999
        Me.txtNoOfShares.MinValue = 0
        Me.txtNoOfShares.Name = "txtNoOfShares"
        Me.txtNoOfShares.Size = New System.Drawing.Size(152, 23)
        Me.txtNoOfShares.TabIndex = 5
        Me.txtNoOfShares.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.btnFromMember)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNoOfShares)
        Me.GroupBox1.Controls.Add(Me.txtFromAccNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.txtFromName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 192)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transfering Member Details"
        '
        'btnFromMember
        '
        Me.btnFromMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFromMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFromMember.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFromMember.ForeColor = System.Drawing.Color.Black
        Me.btnFromMember.GotFocusColour = System.Drawing.Color.Beige
        Me.btnFromMember.Image = CType(resources.GetObject("btnFromMember.Image"), System.Drawing.Image)
        Me.btnFromMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFromMember.Location = New System.Drawing.Point(288, 32)
        Me.btnFromMember.LostFocusColour = System.Drawing.Color.FromArgb(CType(221, Byte), CType(221, Byte), CType(174, Byte))
        Me.btnFromMember.Name = "btnFromMember"
        Me.btnFromMember.Size = New System.Drawing.Size(24, 24)
        Me.btnFromMember.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Amount : "
        '
        'txtAmount
        '
        Me.txtAmount.AfterDecimal = 0
        Me.txtAmount.BeforeDecimal = 12
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmount.Location = New System.Drawing.Point(128, 152)
        Me.txtAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAmount.MaxValue = 0
        Me.txtAmount.MinValue = 0
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(152, 23)
        Me.txtAmount.TabIndex = 6
        Me.txtAmount.Text = ""
        '
        'txtFromName
        '
        Me.txtFromName.AlphaNumeric = True
        Me.txtFromName.BackColor = System.Drawing.Color.White
        Me.txtFromName.BlankSpace = False
        Me.txtFromName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFromName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFromName.Location = New System.Drawing.Point(128, 72)
        Me.txtFromName.LostFocusColour = System.Drawing.Color.White
        Me.txtFromName.Mandatory = False
        Me.txtFromName.MaxLength = 10
        Me.txtFromName.Multiline = True
        Me.txtFromName.Name = "txtFromName"
        Me.txtFromName.Size = New System.Drawing.Size(152, 20)
        Me.txtFromName.SpecialChar = False
        Me.txtFromName.TabIndex = 4
        Me.txtFromName.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 19)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Name : "
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtToNoOfShares)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtBalance)
        Me.GroupBox2.Controls.Add(Me.btnToMember)
        Me.GroupBox2.Controls.Add(Me.txtToName)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtToAccNo)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(360, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 192)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transfer To Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 19)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "No. Of Shares : "
        '
        'txtToNoOfShares
        '
        Me.txtToNoOfShares.AfterDecimal = 0
        Me.txtToNoOfShares.BeforeDecimal = 12
        Me.txtToNoOfShares.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToNoOfShares.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtToNoOfShares.Location = New System.Drawing.Point(136, 112)
        Me.txtToNoOfShares.LostFocusColour = System.Drawing.Color.Empty
        Me.txtToNoOfShares.MaxValue = 0
        Me.txtToNoOfShares.MinValue = 0
        Me.txtToNoOfShares.Name = "txtToNoOfShares"
        Me.txtToNoOfShares.Size = New System.Drawing.Size(152, 23)
        Me.txtToNoOfShares.TabIndex = 9
        Me.txtToNoOfShares.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 19)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Balance : "
        '
        'txtBalance
        '
        Me.txtBalance.AfterDecimal = 0
        Me.txtBalance.BeforeDecimal = 12
        Me.txtBalance.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBalance.Location = New System.Drawing.Point(136, 152)
        Me.txtBalance.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBalance.MaxValue = 0
        Me.txtBalance.MinValue = 0
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(152, 23)
        Me.txtBalance.TabIndex = 10
        Me.txtBalance.Text = ""
        '
        'btnToMember
        '
        Me.btnToMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnToMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnToMember.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToMember.ForeColor = System.Drawing.Color.Black
        Me.btnToMember.GotFocusColour = System.Drawing.Color.Beige
        Me.btnToMember.Image = CType(resources.GetObject("btnToMember.Image"), System.Drawing.Image)
        Me.btnToMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnToMember.Location = New System.Drawing.Point(296, 32)
        Me.btnToMember.LostFocusColour = System.Drawing.Color.FromArgb(CType(221, Byte), CType(221, Byte), CType(174, Byte))
        Me.btnToMember.Name = "btnToMember"
        Me.btnToMember.Size = New System.Drawing.Size(24, 24)
        Me.btnToMember.TabIndex = 7
        '
        'txtToName
        '
        Me.txtToName.AlphaNumeric = True
        Me.txtToName.BackColor = System.Drawing.Color.White
        Me.txtToName.BlankSpace = False
        Me.txtToName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtToName.Location = New System.Drawing.Point(136, 72)
        Me.txtToName.LostFocusColour = System.Drawing.Color.White
        Me.txtToName.Mandatory = False
        Me.txtToName.MaxLength = 10
        Me.txtToName.Multiline = True
        Me.txtToName.Name = "txtToName"
        Me.txtToName.Size = New System.Drawing.Size(148, 20)
        Me.txtToName.SpecialChar = False
        Me.txtToName.TabIndex = 8
        Me.txtToName.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 19)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "Name : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 19)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Member No. :"
        '
        'txtToAccNo
        '
        Me.txtToAccNo.AlphaNumeric = True
        Me.txtToAccNo.BackColor = System.Drawing.Color.White
        Me.txtToAccNo.BlankSpace = False
        Me.txtToAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtToAccNo.Location = New System.Drawing.Point(136, 32)
        Me.txtToAccNo.LostFocusColour = System.Drawing.Color.White
        Me.txtToAccNo.Mandatory = False
        Me.txtToAccNo.MaxLength = 10
        Me.txtToAccNo.Name = "txtToAccNo"
        Me.txtToAccNo.ReadOnly = True
        Me.txtToAccNo.Size = New System.Drawing.Size(152, 23)
        Me.txtToAccNo.SpecialChar = False
        Me.txtToAccNo.TabIndex = 7
        Me.txtToAccNo.TabStop = False
        Me.txtToAccNo.Text = "MB"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.txtReason)
        Me.GroupBox3.Controls.Add(Me.lblReason)
        Me.GroupBox3.Controls.Add(Me.rdbDeath)
        Me.GroupBox3.Controls.Add(Me.rdbOther)
        Me.GroupBox3.Controls.Add(Me.rdbMisuse)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(40, 264)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(648, 168)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Reason For Transfer Of Shares"
        '
        'txtReason
        '
        Me.txtReason.AlphaNumeric = True
        Me.txtReason.AutoSize = False
        Me.txtReason.BlankSpace = False
        Me.txtReason.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReason.Location = New System.Drawing.Point(432, 56)
        Me.txtReason.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReason.Mandatory = False
        Me.txtReason.MaxLength = 255
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReason.Size = New System.Drawing.Size(208, 68)
        Me.txtReason.SpecialChar = True
        Me.txtReason.TabIndex = 4
        Me.txtReason.Text = ""
        '
        'lblReason
        '
        Me.lblReason.AutoSize = True
        Me.lblReason.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReason.Location = New System.Drawing.Point(352, 64)
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(72, 19)
        Me.lblReason.TabIndex = 85
        Me.lblReason.Text = "Reasons :"
        '
        'rdbDeath
        '
        Me.rdbDeath.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbDeath.Location = New System.Drawing.Point(16, 32)
        Me.rdbDeath.Name = "rdbDeath"
        Me.rdbDeath.Size = New System.Drawing.Size(360, 24)
        Me.rdbDeath.TabIndex = 6
        Me.rdbDeath.Text = "Transfer Shares Due To Death Of Account Holder"
        '
        'rdbOther
        '
        Me.rdbOther.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbOther.Location = New System.Drawing.Point(16, 72)
        Me.rdbOther.Name = "rdbOther"
        Me.rdbOther.Size = New System.Drawing.Size(320, 24)
        Me.rdbOther.TabIndex = 7
        Me.rdbOther.Text = "Transfer Of Shares Due To  Other Reasons"
        '
        'rdbMisuse
        '
        Me.rdbMisuse.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMisuse.Location = New System.Drawing.Point(16, 112)
        Me.rdbMisuse.Name = "rdbMisuse"
        Me.rdbMisuse.Size = New System.Drawing.Size(328, 24)
        Me.rdbMisuse.TabIndex = 8
        Me.rdbMisuse.Text = "Transfer Of Shares Due To Misuse Of Shares"
        '
        'btnTransfer
        '
        Me.btnTransfer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnTransfer.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransfer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfer.ForeColor = System.Drawing.Color.Black
        Me.btnTransfer.GotFocusColour = System.Drawing.Color.Beige
        Me.btnTransfer.Image = CType(resources.GetObject("btnTransfer.Image"), System.Drawing.Image)
        Me.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransfer.Location = New System.Drawing.Point(464, 448)
        Me.btnTransfer.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(112, 40)
        Me.btnTransfer.TabIndex = 9
        Me.btnTransfer.Text = "&Transfer"
        Me.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.GotFocusColour = System.Drawing.Color.Beige
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(576, 448)
        Me.btnExit.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 40)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "&Close"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancel.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.Beige
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(32, 448)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "&Reset"
        '
        'frmTransferShares
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(706, 503)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtpTransfer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCancel)
        Me.Font = New System.Drawing.Font("Symbol", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransferShares"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Share Transfer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmTransferShares
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmTransferShares
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmTransferShares
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmTransferShares)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Varibales"

    Dim objClsShares As New clsShares
    Dim intAmtPerShare As Integer

#End Region

#Region "Functions"

    Public Function fnSetData() As Boolean

        objClsShares.FromTransferMember = txtFromAccNo.Text
        objClsShares.ToTransferMember = txtToAccNo.Text
        objClsShares.NoOfShares = txtNoOfShares.Text
        objClsShares.TransferAmt = txtAmount.Text
        objClsShares.TransferDate = Format(dtpTransfer.Value, "yyyy-MM-dd")

        If rdbDeath.Checked = True Then
            objClsShares.ReasonForTransfer = "Transfer Shares Due To Death Of Account Holder"
        ElseIf rdbMisuse.Checked = True Then
            objClsShares.ReasonForTransfer = "Transfer Of Shares Due To Misuse Of Shares"
        ElseIf rdbOther.Checked = True Then
            objClsShares.ReasonForTransfer = txtReason.Text
        End If

        Return True

    End Function

    Public Function fnCheckShares() As Boolean

        If objClsShares.fnGetMemberDet(txtFromAccNo.Text) Then
            If objClsShares.TransferTable.Rows(0).Item("NoOfShares") < Val(txtNoOfShares.Text) Then
                MsgBox("Number of shares is more than actual shares", MsgBoxStyle.Critical, "Shares Module")
                txtNoOfShares.Focus()
                Return False
            ElseIf objClsShares.TransferTable.Rows(0).Item("Status") = "Closed" Then
                MsgBox("Cannot transfer amount, account is closed", MsgBoxStyle.Exclamation, "Shares Module")
                Return False
            Else
                Return True
            End If
        End If

    End Function

    Public Function fnClear() As Boolean

        txtFromAccNo.Text = "MB"
        txtToAccNo.Text = "MB"
        txtAmount.ResetText()
        txtNoOfShares.Text = String.Empty
        txtToName.Text = String.Empty
        txtFromName.Text = String.Empty
        txtBalance.Text = String.Empty
        txtToNoOfShares.Text = String.Empty
        txtReason.Text = String.Empty
        Return True

    End Function

    Public Function fnCheck() As Boolean

        
        If txtFromAccNo.Text = "MB" Then
            MsgBox("Please enter the memberno to transfer", MsgBoxStyle.Information, "Shares Module")
            txtFromAccNo.Focus()
            Return False
        ElseIf txtToAccNo.Text = "MB" Then
            MsgBox("Please enter the memberno to transfer", MsgBoxStyle.Information, "Shares Module")
            txtToAccNo.Focus()
            Return False
        ElseIf txtAmount.Text = String.Empty Then
            MsgBox("Please enter the amount to transfer ", MsgBoxStyle.Information, "Shares Module")
            txtAmount.Focus()
            Return False
        ElseIf txtNoOfShares.Text = String.Empty Then
            MsgBox("Please enter no of shares to transfer", MsgBoxStyle.Information, "Shares Module")
            txtNoOfShares.Focus()
            Return False
        ElseIf txtNoOfShares.Text < 0 Then
            MsgBox("No shares to transfer", MsgBoxStyle.Exclamation, "Shares Module")
            txtNoOfShares.Focus()
            Return False
        ElseIf txtFromAccNo.Text = txtToAccNo.Text Then
            MsgBox("Shares cannot be transferd,FROM and TO account no are same", MsgBoxStyle.Exclamation, " Shares Module")
            txtToAccNo.Focus()
            Return False
        ElseIf Val(txtNoOfShares.Text) = 0 Then
            MsgBox("Please check number of shares", MsgBoxStyle.Exclamation, "Shares Module")
            txtNoOfShares.Focus()
            Return False
        Else
            Return True

        End If

    End Function

    Public Function fnLoadFromTransferMember() As Boolean

        If objClsShares.fnGetMemberDet(txtFromAccNo.Text) Then

            txtFromName.Text = objClsShares.TransferTable.Rows(0).Item("Name")
            txtNoOfShares.Text = objClsShares.TransferTable.Rows(0).Item("NoOfShares")
            txtAmount.Text = objClsShares.TransferTable.Rows(0).Item("ShareAmount")

            Return True
        End If

    End Function

    Public Function fnLoadToTransferMember() As Boolean

        If objClsShares.fnGetMemberDet(txtToAccNo.Text) Then
            txtToName.Text = objClsShares.TransferTable.Rows(0).Item("Name")
            txtToNoOfShares.Text = objClsShares.TransferTable.Rows(0).Item("NoOfShares")
            txtBalance.Text = objClsShares.TransferTable.Rows(0).Item("ShareAmount")
            Return True
        End If

    End Function
    ''''''''''''''''''''''''
    Public Function fnAmtPerShare() As Boolean

        If objClsShares.fnCheckConfig Then

            intAmtPerShare = objClsShares.ConfigTbl.Rows(0).Item("AmountPerShare")

            Return True

        End If

    End Function

#End Region

#Region "Events"

    Private Sub btnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransfer.Click
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnSetData() Then
                    If fnCheckShares() Then
                        If objClsShares.fnTransferShares(objTrans) Then
                            fnLogEntry(pbUserId, "Shares transferd By" & txtFromAccNo.Text, Date.Now, "Member Module", objTrans)
                            objTrans.Commit()
                            MsgBox("Shares transferd successfully From '" & txtFromAccNo.Text & "' To '" & txtToAccNo.Text & "'", MsgBoxStyle.Information, "Shares Module")
                            fnClear()
                        Else
                            MsgBox("Shares cannot be transfered from '" & txtFromAccNo.Text & "' To '" & txtToAccNo.Text & "'Due To Internal Error", MsgBoxStyle.Critical, " Shares Module")
                            fnClear()
                        End If
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

    Private Sub btnFromMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFromMember.Click

        Dim objMemberSearch As New frmMemberSearch
        objMemberSearch.strMemberNo = ""
        objMemberSearch.ShowDialog(Me)
        If objMemberSearch.strMemberNo <> "" Then
            txtFromAccNo.Text = objMemberSearch.strMemberNo
            fnLoadFromTransferMember()
        Else
            txtFromAccNo.Text = "MB"
            btnFromMember.Focus()
        End If

        objMemberSearch.Dispose()
    End Sub

    Private Sub frmTransferShares_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpTransfer.Value = Date.Now
        txtReason.Visible = False
        lblReason.Visible = False
        fnAmtPerShare()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnToMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToMember.Click

        Dim objMemberSearch As New frmMemberSearch
        objMemberSearch.strMemberNo = ""
        objMemberSearch.ShowDialog(Me)
        If objMemberSearch.strMemberNo <> "" Then
            txtToAccNo.Text = objMemberSearch.strMemberNo
            fnLoadToTransferMember()
        Else
            txtToAccNo.Text = "MB"
            btnToMember.Focus()
        End If
        objMemberSearch.Dispose()

    End Sub

    Private Sub rdbOther_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbOther.CheckedChanged

        If rdbOther.Checked = True Then
            txtReason.Visible = True
            lblReason.Visible = True
        Else
            txtReason.Visible = False
            lblReason.Visible = False
        End If

    End Sub

    Private Sub txtNoOfShares_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoOfShares.TextChanged

        txtAmount.Text = Val(txtNoOfShares.Text) * intAmtPerShare

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        fnClear()

    End Sub

    Private Sub txtFromAccNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFromAccNo.Leave
        If txtFromAccNo.Text <> "MB" Then
            fnLoadFromTransferMember()
        End If
    End Sub

    Private Sub txtToAccNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtToAccNo.Leave
        If txtToAccNo.Text <> "MB" Then
            fnLoadToTransferMember()
        End If
    End Sub

#End Region

End Class
