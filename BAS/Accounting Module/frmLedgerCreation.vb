Public Class frmLedgerCreation
    Inherits System.Windows.Forms.Form

    Dim objLedgers As New clsLedger
    Dim objDT As DataTable
    Dim dvLedgers As DataView
    Dim boolUpdate As Boolean = True

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
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdbYes As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNo As System.Windows.Forms.RadioButton
    Friend WithEvents lblAccountNo As System.Windows.Forms.Label
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents txtLedgerName As BankControls.TextControl
    Friend WithEvents txtLedgerNo As BankControls.TextControl
    Friend WithEvents cmbGroup As System.Windows.Forms.ComboBox
    Friend WithEvents lvLedgers As System.Windows.Forms.ListView
    Friend WithEvents btnUp As NewButton.NewButton
    Friend WithEvents btnDown As NewButton.NewButton
    Friend WithEvents txtOrderNo As TextControl.TextControl
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbBalanceType As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLedgerCreation))
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDown = New NewButton.NewButton()
        Me.btnUp = New NewButton.NewButton()
        Me.lvLedgers = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbBalanceType = New System.Windows.Forms.ComboBox()
        Me.txtOrderNo = New TextControl.TextControl()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLedgerName = New BankControls.TextControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLedgerNo = New BankControls.TextControl()
        Me.cmbGroup = New System.Windows.Forms.ComboBox()
        Me.rdbYes = New System.Windows.Forms.RadioButton()
        Me.rdbNo = New System.Windows.Forms.RadioButton()
        Me.lblAccountNo = New System.Windows.Forms.Label()
        Me.btnClose = New BankControls.NewButton()
        Me.btnOk = New BankControls.NewButton()
        Me.btnAdd = New BankControls.NewButton()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sl No."
        Me.ColumnHeader1.Width = 45
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDown)
        Me.GroupBox2.Controls.Add(Me.btnUp)
        Me.GroupBox2.Controls.Add(Me.lvLedgers)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 616)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'btnDown
        '
        Me.btnDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDown.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.GotFocusColour = System.Drawing.Color.Empty
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(320, 304)
        Me.btnDown.LostFocusColour = System.Drawing.Color.Empty
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(24, 40)
        Me.btnDown.TabIndex = 18
        '
        'btnUp
        '
        Me.btnUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUp.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.GotFocusColour = System.Drawing.Color.Empty
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.Location = New System.Drawing.Point(320, 248)
        Me.btnUp.LostFocusColour = System.Drawing.Color.Empty
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(24, 40)
        Me.btnUp.TabIndex = 17
        '
        'lvLedgers
        '
        Me.lvLedgers.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lvLedgers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvLedgers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvLedgers.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLedgers.FullRowSelect = True
        Me.lvLedgers.GridLines = True
        Me.lvLedgers.HideSelection = False
        Me.lvLedgers.Location = New System.Drawing.Point(3, 16)
        Me.lvLedgers.MultiSelect = False
        Me.lvLedgers.Name = "lvLedgers"
        Me.lvLedgers.Size = New System.Drawing.Size(314, 597)
        Me.lvLedgers.TabIndex = 0
        Me.lvLedgers.UseCompatibleStateImageBehavior = False
        Me.lvLedgers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 245
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Ledger No."
        Me.ColumnHeader3.Width = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnOk)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(376, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 616)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 78
        Me.PictureBox1.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Green
        Me.Label21.Location = New System.Drawing.Point(72, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(133, 23)
        Me.Label21.TabIndex = 77
        Me.Label21.Text = "Ledger Master"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cmbBalanceType)
        Me.GroupBox3.Controls.Add(Me.txtOrderNo)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtLedgerName)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtLedgerNo)
        Me.GroupBox3.Controls.Add(Me.cmbGroup)
        Me.GroupBox3.Controls.Add(Me.rdbYes)
        Me.GroupBox3.Controls.Add(Me.rdbNo)
        Me.GroupBox3.Controls.Add(Me.lblAccountNo)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(600, 224)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(64, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 16)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Balance Type :"
        '
        'cmbBalanceType
        '
        Me.cmbBalanceType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBalanceType.Items.AddRange(New Object() {"Credit Balance", "Debit Balance"})
        Me.cmbBalanceType.Location = New System.Drawing.Point(168, 144)
        Me.cmbBalanceType.Name = "cmbBalanceType"
        Me.cmbBalanceType.Size = New System.Drawing.Size(144, 24)
        Me.cmbBalanceType.TabIndex = 5
        '
        'txtOrderNo
        '
        Me.txtOrderNo.AlphaNumeric = False
        Me.txtOrderNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtOrderNo.BlankSpace = False
        Me.txtOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrderNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderNo.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtOrderNo.Location = New System.Drawing.Point(400, 24)
        Me.txtOrderNo.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtOrderNo.Mandatory = False
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.ReadOnly = True
        Me.txtOrderNo.Size = New System.Drawing.Size(96, 23)
        Me.txtOrderNo.SpecialChar = False
        Me.txtOrderNo.TabIndex = 2
        Me.txtOrderNo.TabStop = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label8.Location = New System.Drawing.Point(320, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 24)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Order No. :"
        '
        'txtLedgerName
        '
        Me.txtLedgerName.AlphaNumeric = True
        Me.txtLedgerName.BackColor = System.Drawing.Color.White
        Me.txtLedgerName.BlankSpace = True
        Me.txtLedgerName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLedgerName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtLedgerName.Location = New System.Drawing.Point(168, 64)
        Me.txtLedgerName.LostFocusColour = System.Drawing.Color.White
        Me.txtLedgerName.Mandatory = False
        Me.txtLedgerName.MaxLength = 50
        Me.txtLedgerName.Name = "txtLedgerName"
        Me.txtLedgerName.Size = New System.Drawing.Size(232, 23)
        Me.txtLedgerName.SpecialChar = True
        Me.txtLedgerName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(64, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Ledger Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(64, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Restrict User :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(64, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Group :"
        '
        'txtLedgerNo
        '
        Me.txtLedgerNo.AlphaNumeric = False
        Me.txtLedgerNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtLedgerNo.BlankSpace = False
        Me.txtLedgerNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLedgerNo.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtLedgerNo.Location = New System.Drawing.Point(168, 24)
        Me.txtLedgerNo.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtLedgerNo.Mandatory = False
        Me.txtLedgerNo.Name = "txtLedgerNo"
        Me.txtLedgerNo.ReadOnly = True
        Me.txtLedgerNo.Size = New System.Drawing.Size(104, 23)
        Me.txtLedgerNo.SpecialChar = False
        Me.txtLedgerNo.TabIndex = 0
        Me.txtLedgerNo.TabStop = False
        '
        'cmbGroup
        '
        Me.cmbGroup.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroup.Location = New System.Drawing.Point(168, 104)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Size = New System.Drawing.Size(232, 24)
        Me.cmbGroup.TabIndex = 4
        '
        'rdbYes
        '
        Me.rdbYes.Checked = True
        Me.rdbYes.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbYes.Location = New System.Drawing.Point(176, 184)
        Me.rdbYes.Name = "rdbYes"
        Me.rdbYes.Size = New System.Drawing.Size(58, 25)
        Me.rdbYes.TabIndex = 6
        Me.rdbYes.TabStop = True
        Me.rdbYes.Text = "Yes"
        '
        'rdbNo
        '
        Me.rdbNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbNo.Location = New System.Drawing.Point(240, 184)
        Me.rdbNo.Name = "rdbNo"
        Me.rdbNo.Size = New System.Drawing.Size(61, 25)
        Me.rdbNo.TabIndex = 7
        Me.rdbNo.Text = "No"
        '
        'lblAccountNo
        '
        Me.lblAccountNo.AutoSize = True
        Me.lblAccountNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lblAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountNo.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblAccountNo.Location = New System.Drawing.Point(64, 24)
        Me.lblAccountNo.Name = "lblAccountNo"
        Me.lblAccountNo.Size = New System.Drawing.Size(90, 16)
        Me.lblAccountNo.TabIndex = 71
        Me.lblAccountNo.Text = "Ledger No. :"
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(448, 288)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "&Close"
        '
        'btnOk
        '
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(344, 288)
        Me.btnOk.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(104, 40)
        Me.btnOk.TabIndex = 8
        Me.btnOk.Text = "&Save"
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(48, 288)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 40)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "&Reset"
        '
        'frmLedgerCreation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1002, 631)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmLedgerCreation"
        Me.ShowInTaskbar = False
        Me.Text = "Ledger Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmLedgerCreation
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmLedgerCreation
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmLedgerCreation
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmLedgerCreation)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Sub Routines and Functions"


    Sub sbClear()
        txtLedgerNo.ResetText()
        txtLedgerName.ResetText()
        cmbGroup.SelectedIndex = -1
        cmbBalanceType.SelectedIndex = -1
        rdbYes.Checked = True
        txtLedgerName.Focus()
        boolUpdate = True
    End Sub


    Function fnCheck() As Boolean
        If boolUpdate = False And pbUserId <> "admin" Then
            MsgBox("You can not update this ledger details," & Chr(13) & "because it is restricted for the user by the admin", MsgBoxStyle.Exclamation, Me.Text)
            Return False
        ElseIf txtLedgerNo.Text = "" Then
            MsgBox("Enter ledger no.", MsgBoxStyle.Exclamation, Me.Text)
            Return False
        ElseIf Trim(txtLedgerName.Text) = "" Then
            MsgBox("Enter ledger name", MsgBoxStyle.Exclamation, Me.Text)
            txtLedgerName.Focus()
            Return False
        ElseIf cmbGroup.SelectedIndex = -1 Then
            MsgBox("Select group ", MsgBoxStyle.Exclamation, Me.Text)
            cmbGroup.Focus()
            Return False
        ElseIf cmbBalanceType.SelectedIndex = -1 Then
            MsgBox("Select Balance Type ", MsgBoxStyle.Exclamation, Me.Text)
            cmbBalanceType.Focus()
            Return False
        Else
            Return True
        End If
    End Function


    Function fnSetData() As Boolean
        objLedgers.OrderNo = txtOrderNo.Text
        objLedgers.LedgerNo = txtLedgerNo.Text
        objLedgers.Name = txtLedgerName.Text
        objLedgers.GroupNo = cmbGroup.SelectedValue
        objLedgers.RestrictUser = IIf(rdbYes.Checked = True, "Y", "N")
        If cmbBalanceType.SelectedItem = "Credit Balance" Then
            objLedgers.BalanceType = "Cr"
        ElseIf cmbBalanceType.SelectedItem = "Debit Balance" Then
            objLedgers.BalanceType = "Dr"
        End If
        Return True



    End Function


    Function fnSaveData() As Boolean

        If objLedgers.fnCheckLedger(txtLedgerNo.Text) Then
            If objLedgers.fnUpdateLedger Then
                fnLogEntry(pbUserId, "Ledger updated" & txtLedgerName.Text, Date.Now, "Accounting")
                MsgBox("Ledger details updated successfully", MsgBoxStyle.Information, Me.Text)
                Return True
            Else
                MsgBox("Ledger details updation failed, because of internal error", MsgBoxStyle.Exclamation, Me.Text)
                Return False
            End If
        Else
            If objLedgers.fnAddLedger Then
                fnLogEntry(pbUserId, "Ledger added" & txtLedgerName.Text, Date.Now, "Accounting")
                MsgBox("New ledger details added successfully", MsgBoxStyle.Information, Me.Text)
                Return True
            Else
                MsgBox("New ledger details addition failed, because of internal error", MsgBoxStyle.Exclamation, Me.Text)
                Return False
            End If
        End If

    End Function


    Sub sbLoadLedgers()

        Dim intCounter As Integer = 0
        Dim lvItem As ListViewItem
        lvLedgers.Items.Clear()
        If objLedgers.fnGetLedgerList Then
            dvLedgers = New DataView(objLedgers.LedgerTable)
            While intCounter < dvLedgers.Count
                Dim temp1 As Integer = dvLedgers.Item(intCounter).Item("OrderNo")
                lvItem = lvLedgers.Items.Add(temp1)
                lvItem.SubItems.Add(dvLedgers.Item(intCounter).Item("Name"))
                Dim temp As Integer = dvLedgers.Item(intCounter).Item("LedgerNo")
                lvItem.SubItems.Add(temp)
                intCounter += 1
            End While
        End If
    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmLedgerCreation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objGroups As New clsGroups
        Dim dvGroups As DataView
        If objGroups.fnGetGroupsListLoad Then
            dvGroups = New DataView(objGroups.GroupsTable, "GroupNo<>0", "Name", DataViewRowState.OriginalRows)
            cmbGroup.DataSource = dvGroups
            cmbGroup.DisplayMember = "Name"
            cmbGroup.ValueMember = "GroupNo"
        End If
        sbLoadLedgers()
        btnAdd_Click(sender, e)
    End Sub

    Private Sub lvLedgers_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLedgers.SelectedIndexChanged

        If lvLedgers.SelectedItems.Count > 0 Then

            Dim objDataTable As DataTable
            If objLedgers.fnCheckLedger(lvLedgers.SelectedItems(0).SubItems(2).Text) Then
                sbClear()
                objDataTable = objLedgers.LedgerTable
                txtLedgerName.Text = objDataTable.Rows(0).Item("Name")
                txtLedgerNo.Text = objDataTable.Rows(0).Item("LedgerNo")
                txtOrderNo.Text = objDataTable.Rows(0).Item("OrderNO")
                cmbGroup.SelectedValue = objDataTable.Rows(0).Item("GroupNo")
                If objDataTable.Rows(0).Item("RestrictUser") = "Y" Then
                    rdbYes.Checked = True
                Else
                    rdbNo.Checked = True
                End If

                If objDataTable.Rows(0).Item("BalanceType") = "Cr" Then
                    cmbBalanceType.SelectedItem = "Credit Balance"
                ElseIf objDataTable.Rows(0).Item("BalanceType") = "Dr" Then
                    cmbBalanceType.SelectedItem = "Debit Balance"
                End If

        End If
            lvLedgers.Focus()
        End If

    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        sbClear()
        txtLedgerNo.Text = objLedgers.fnGetNewLedgerNo
        txtOrderNo.Text = objLedgers.fnGetNewOrderNo
    End Sub

    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If fnCheck() = True Then
            If fnSetData() Then
                If fnSaveData() Then
                    sbLoadLedgers()
                    btnAdd_Click(sender, e)
                End If
            End If
        End If
    End Sub

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        If lvLedgers.SelectedItems.Count > 0 Then
            If lvLedgers.SelectedItems(0).Index <> 0 Then
                Dim lvItem1 As ListViewItem
                Dim lvItem2 As ListViewItem
                Dim strTemp As String
                Dim intIndex As Integer = 0
                intIndex = lvLedgers.SelectedItems(0).Index     'index of selected item
                lvItem1 = lvLedgers.SelectedItems(0)            'selected item
                lvItem2 = lvLedgers.Items(intIndex - 1)         'above item
                strTemp = lvItem2.SubItems(0).Text          'above items order no
                lvItem2.SubItems(0).Text = lvItem1.SubItems(0).Text
                lvItem1.SubItems(0).Text = strTemp
                lvLedgers.Items(intIndex - 1).Remove()
                lvLedgers.SelectedItems(0).Remove()
                lvLedgers.Items.Insert(intIndex - 1, lvItem1)
                lvLedgers.Items.Insert(intIndex, lvItem2)
                objLedgers.LedgerNo = lvLedgers.Items(intIndex).SubItems(2).Text
                objLedgers.OrderNo = lvLedgers.Items(intIndex).SubItems(0).Text
                objLedgers.fnUpdateOrder()
                objLedgers.LedgerNo = lvLedgers.Items(intIndex - 1).SubItems(2).Text
                objLedgers.OrderNo = lvLedgers.Items(intIndex - 1).SubItems(0).Text
                objLedgers.fnUpdateOrder()
                lvLedgers.Items(intIndex - 1).Selected = True
                lvLedgers_SelectedIndexChanged(sender, e)
                lvLedgers.Focus()
            End If
        End If
    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        If lvLedgers.SelectedItems.Count > 0 Then
            If lvLedgers.SelectedItems(0).Index <> lvLedgers.Items.Count - 1 Then
                Dim lvItem1 As ListViewItem
                Dim lvItem2 As ListViewItem
                Dim strTemp As String
                Dim intIndex As Integer = 0
                intIndex = lvLedgers.SelectedItems(0).Index
                lvItem1 = lvLedgers.SelectedItems(0)
                lvItem2 = lvLedgers.Items(intIndex + 1)
                strTemp = lvItem2.SubItems(0).Text
                lvItem2.SubItems(0).Text = lvItem1.SubItems(0).Text
                lvItem1.SubItems(0).Text = strTemp
                lvLedgers.Items(intIndex + 1).Remove()
                lvLedgers.Items.Insert(intIndex, lvItem2)
                objLedgers.LedgerNo = lvLedgers.Items(intIndex).SubItems(2).Text
                objLedgers.OrderNo = lvLedgers.Items(intIndex).SubItems(0).Text
                objLedgers.fnUpdateOrder()
                objLedgers.LedgerNo = lvLedgers.Items(intIndex + 1).SubItems(2).Text
                objLedgers.OrderNo = lvLedgers.Items(intIndex + 1).SubItems(0).Text
                objLedgers.fnUpdateOrder()
                lvLedgers.Items(intIndex + 1).Selected = True
                lvLedgers_SelectedIndexChanged(sender, e)
                lvLedgers.Focus()
            End If
        End If
    End Sub
End Class
