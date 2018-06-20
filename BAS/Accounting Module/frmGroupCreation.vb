Public Class frmGroupCreation
    Inherits System.Windows.Forms.Form

#Region "Form Global Variables"
    Dim objGroups As New clsGroups
    Dim objDT As DataTable
    Dim dvGroups As DataView
    Dim boolUpdate As Boolean = True
#End Region

#Region "Windows Form Designer generated code "

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
    Friend WithEvents lblAccountNo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtGroupName As BankControls.TextControl
    Friend WithEvents cmbNature As System.Windows.Forms.ComboBox
    Friend WithEvents txtGroupNo As BankControls.TextControl
    Friend WithEvents cmbParent As System.Windows.Forms.ComboBox
    Friend WithEvents rdbYes As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNo As System.Windows.Forms.RadioButton
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvLedgers As System.Windows.Forms.ListView
    Friend WithEvents lvGroups As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnUp As NewButton.NewButton
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnDown As NewButton.NewButton
    Friend WithEvents txtOrderNo As TextControl.TextControl
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lvSubGroups As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGroupCreation))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lvSubGroups = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtOrderNo = New TextControl.TextControl()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtGroupName = New BankControls.TextControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbNature = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGroupNo = New BankControls.TextControl()
        Me.cmbParent = New System.Windows.Forms.ComboBox()
        Me.rdbYes = New System.Windows.Forms.RadioButton()
        Me.rdbNo = New System.Windows.Forms.RadioButton()
        Me.lblAccountNo = New System.Windows.Forms.Label()
        Me.btnClose = New BankControls.NewButton()
        Me.btnOk = New BankControls.NewButton()
        Me.btnAdd = New BankControls.NewButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lvLedgers = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDown = New NewButton.NewButton()
        Me.btnUp = New NewButton.NewButton()
        Me.lvGroups = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnOk)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Location = New System.Drawing.Point(376, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 616)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.lvSubGroups)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox4.Location = New System.Drawing.Point(8, 344)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(304, 264)
        Me.GroupBox4.TabIndex = 80
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sub Groups"
        Me.GroupBox4.Visible = False
        '
        'lvSubGroups
        '
        Me.lvSubGroups.BackColor = System.Drawing.Color.White
        Me.lvSubGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvSubGroups.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvSubGroups.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSubGroups.GridLines = True
        Me.lvSubGroups.Location = New System.Drawing.Point(8, 24)
        Me.lvSubGroups.Name = "lvSubGroups"
        Me.lvSubGroups.Size = New System.Drawing.Size(288, 232)
        Me.lvSubGroups.TabIndex = 79
        Me.lvSubGroups.UseCompatibleStateImageBehavior = False
        Me.lvSubGroups.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "No."
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Name"
        Me.ColumnHeader4.Width = 228
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
        Me.Label21.Location = New System.Drawing.Point(88, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(129, 23)
        Me.Label21.TabIndex = 77
        Me.Label21.Text = "Group Master"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtOrderNo)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtGroupName)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cmbNature)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtGroupNo)
        Me.GroupBox3.Controls.Add(Me.cmbParent)
        Me.GroupBox3.Controls.Add(Me.rdbYes)
        Me.GroupBox3.Controls.Add(Me.rdbNo)
        Me.GroupBox3.Controls.Add(Me.lblAccountNo)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(600, 224)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'txtOrderNo
        '
        Me.txtOrderNo.AlphaNumeric = False
        Me.txtOrderNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtOrderNo.BlankSpace = False
        Me.txtOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrderNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderNo.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtOrderNo.Location = New System.Drawing.Point(416, 24)
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
        Me.Label8.Size = New System.Drawing.Size(88, 24)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Order No. :"
        '
        'txtGroupName
        '
        Me.txtGroupName.AlphaNumeric = True
        Me.txtGroupName.BackColor = System.Drawing.Color.White
        Me.txtGroupName.BlankSpace = True
        Me.txtGroupName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtGroupName.Location = New System.Drawing.Point(176, 64)
        Me.txtGroupName.LostFocusColour = System.Drawing.Color.White
        Me.txtGroupName.Mandatory = False
        Me.txtGroupName.MaxLength = 30
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.Size = New System.Drawing.Size(232, 23)
        Me.txtGroupName.SpecialChar = True
        Me.txtGroupName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(64, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 16)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Group Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(64, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Nature :"
        '
        'cmbNature
        '
        Me.cmbNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNature.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNature.Items.AddRange(New Object() {"Asset", "Liability", "Income", "Expenditure", "Capital"})
        Me.cmbNature.Location = New System.Drawing.Point(176, 144)
        Me.cmbNature.Name = "cmbNature"
        Me.cmbNature.Size = New System.Drawing.Size(112, 24)
        Me.cmbNature.TabIndex = 5
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
        Me.Label2.Location = New System.Drawing.Point(64, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Parent Group :"
        '
        'txtGroupNo
        '
        Me.txtGroupNo.AlphaNumeric = False
        Me.txtGroupNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtGroupNo.BlankSpace = False
        Me.txtGroupNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupNo.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtGroupNo.Location = New System.Drawing.Point(176, 24)
        Me.txtGroupNo.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtGroupNo.Mandatory = False
        Me.txtGroupNo.Name = "txtGroupNo"
        Me.txtGroupNo.ReadOnly = True
        Me.txtGroupNo.Size = New System.Drawing.Size(104, 23)
        Me.txtGroupNo.SpecialChar = False
        Me.txtGroupNo.TabIndex = 0
        Me.txtGroupNo.TabStop = False
        '
        'cmbParent
        '
        Me.cmbParent.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbParent.Location = New System.Drawing.Point(176, 104)
        Me.cmbParent.Name = "cmbParent"
        Me.cmbParent.Size = New System.Drawing.Size(232, 24)
        Me.cmbParent.TabIndex = 4
        '
        'rdbYes
        '
        Me.rdbYes.Checked = True
        Me.rdbYes.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbYes.Location = New System.Drawing.Point(184, 184)
        Me.rdbYes.Name = "rdbYes"
        Me.rdbYes.Size = New System.Drawing.Size(58, 21)
        Me.rdbYes.TabIndex = 6
        Me.rdbYes.TabStop = True
        Me.rdbYes.Text = "Yes"
        '
        'rdbNo
        '
        Me.rdbNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbNo.Location = New System.Drawing.Point(248, 184)
        Me.rdbNo.Name = "rdbNo"
        Me.rdbNo.Size = New System.Drawing.Size(56, 21)
        Me.rdbNo.TabIndex = 7
        Me.rdbNo.Text = "No"
        '
        'lblAccountNo
        '
        Me.lblAccountNo.AutoSize = True
        Me.lblAccountNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lblAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountNo.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblAccountNo.Location = New System.Drawing.Point(64, 27)
        Me.lblAccountNo.Name = "lblAccountNo"
        Me.lblAccountNo.Size = New System.Drawing.Size(84, 16)
        Me.lblAccountNo.TabIndex = 71
        Me.lblAccountNo.Text = "Group No. :"
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
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lvLedgers)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox5.Location = New System.Drawing.Point(320, 344)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(288, 264)
        Me.GroupBox5.TabIndex = 80
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Ledgers"
        Me.GroupBox5.Visible = False
        '
        'lvLedgers
        '
        Me.lvLedgers.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lvLedgers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvLedgers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvLedgers.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLedgers.GridLines = True
        Me.lvLedgers.Location = New System.Drawing.Point(8, 24)
        Me.lvLedgers.Name = "lvLedgers"
        Me.lvLedgers.Size = New System.Drawing.Size(264, 232)
        Me.lvLedgers.TabIndex = 79
        Me.lvLedgers.UseCompatibleStateImageBehavior = False
        Me.lvLedgers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "No."
        Me.ColumnHeader5.Width = 57
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Name"
        Me.ColumnHeader6.Width = 184
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDown)
        Me.GroupBox2.Controls.Add(Me.btnUp)
        Me.GroupBox2.Controls.Add(Me.lvGroups)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 616)
        Me.GroupBox2.TabIndex = 7
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
        Me.btnDown.TabIndex = 17
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
        Me.btnUp.TabIndex = 16
        '
        'lvGroups
        '
        Me.lvGroups.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lvGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvGroups.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader7})
        Me.lvGroups.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvGroups.FullRowSelect = True
        Me.lvGroups.GridLines = True
        Me.lvGroups.HideSelection = False
        Me.lvGroups.Location = New System.Drawing.Point(3, 8)
        Me.lvGroups.MultiSelect = False
        Me.lvGroups.Name = "lvGroups"
        Me.lvGroups.Size = New System.Drawing.Size(309, 597)
        Me.lvGroups.TabIndex = 3
        Me.lvGroups.UseCompatibleStateImageBehavior = False
        Me.lvGroups.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sl No."
        Me.ColumnHeader1.Width = 58
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 222
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Group No."
        Me.ColumnHeader7.Width = 0
        '
        'frmGroupCreation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1018, 631)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmGroupCreation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Group Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmGroupCreation
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmGroupCreation
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmGroupCreation
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmGroupCreation)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Sub Routines and Functions"

    Sub sbClear()
        txtGroupNo.ResetText()
        txtOrderNo.ResetText()
        txtGroupName.ResetText()
        cmbParent.SelectedIndex = -1
        cmbNature.SelectedIndex = -1
        rdbYes.Checked = True
        txtGroupName.Focus()
        boolUpdate = True
    End Sub

    Function fnCheck() As Boolean
        If boolUpdate = False And pbUserId <> "admin" Then
            MsgBox("You can not update this group details" & Chr(13) & "because it is restricted for the user by the admin", MsgBoxStyle.Exclamation, Me.Text)
            Return False
        ElseIf txtGroupNo.Text = "" Then
            MsgBox("Enter group No.", MsgBoxStyle.Exclamation, Me.Text)
            Return False
        ElseIf Trim(txtGroupName.Text) = "" Then
            MsgBox("Enter group name", MsgBoxStyle.Exclamation, Me.Text)
            txtGroupName.Focus()
            Return False
        ElseIf cmbNature.SelectedIndex = -1 Then
            MsgBox("Select nature of group", MsgBoxStyle.Exclamation, Me.Text)
            cmbNature.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Function fnSetData() As Boolean

        objGroups.GroupNo = txtGroupNo.Text
        objGroups.OrderNo = txtOrderNo.Text
        objGroups.GroupName = txtGroupName.Text
        objGroups.ParentNo = cmbParent.SelectedValue
        If cmbNature.SelectedItem = "Asset" Then
            objGroups.Nature = "A"
        ElseIf cmbNature.SelectedItem = "Liability" Then
            objGroups.Nature = "L"
        ElseIf cmbNature.SelectedItem = "Income" Then
            objGroups.Nature = "I"
        ElseIf cmbNature.SelectedItem = "Expenditure" Then
            objGroups.Nature = "E"
        End If
        objGroups.RestrictUser = IIf(rdbYes.Checked = True, "Y", "N")
        Return True

    End Function

    Function fnSaveData() As Boolean

        If objGroups.fnCheckGroup(txtGroupNo.Text) Then
            If objGroups.fnUpdateGroup Then
                fnLogEntry(pbUserId, "Group updated" & txtGroupName.Text, Date.Now, "Accounting")
                MsgBox("Group updated successfully ", MsgBoxStyle.Information, Me.Text)
                Return True
            Else
                MsgBox("Group updation failed, because of internal error", MsgBoxStyle.Exclamation, Me.Text)
                Return False
            End If
        Else
            If objGroups.fnAddGroup Then
                fnLogEntry(pbUserId, "New group Created " & txtGroupName.Text, Date.Now, "Accounting")
                MsgBox("Group added successfully", MsgBoxStyle.Information, Me.Text)
                Return True
            Else
                MsgBox("Group addition failed, because of internal error", MsgBoxStyle.Exclamation, Me.Text)
                Return False
            End If
        End If

    End Function

    Sub sbLoadGroups()

        Dim intCounter As Integer = 0
        Dim lvItem As ListViewItem

        lvGroups.Items.Clear()
        If objGroups.fnGetGroupsListLoad Then
            dvGroups = New DataView(objGroups.GroupsTable)
            While intCounter < dvGroups.Count
                lvItem = lvGroups.Items.Add(dvGroups.Item(intCounter).Item("OrderNo"))
                lvItem.SubItems.Add(dvGroups.Item(intCounter).Item("Name"))
                lvItem.SubItems.Add(dvGroups.Item(intCounter).Item("GroupNo"))
                intCounter += 1
            End While
            dvGroups.Sort = "OrderNo"
        End If

    End Sub

#End Region

#Region "Events"

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmGroupCreation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sbLoadGroups()
        btnAdd_Click(sender, e)
    End Sub

    Private Sub lvGroups_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvGroups.SelectedIndexChanged
        If lvGroups.SelectedItems.Count > 0 Then
            Dim drGroup As DataRow
            Dim nature As String
            ' Dim objDataTable As DataTable
            drGroup = dvGroups.Table.Select("OrderNo=" & lvGroups.SelectedItems(0).SubItems(0).Text)(0)
            txtGroupNo.Text = drGroup.Item("GroupNo")
            txtGroupName.Text = drGroup.Item("Name")
            cmbParent.SelectedValue = drGroup.Item("ParentNo")
            txtOrderNo.Text = drGroup.Item("OrderNo")
            nature = drGroup.Item("Nature")
            Select Case nature
                Case "A" : cmbNature.SelectedItem = "Asset"
                Case "L" : cmbNature.SelectedItem = "Liability"
                Case "I" : cmbNature.SelectedItem = "Income"
                Case "E" : cmbNature.SelectedItem = "Expenditure"
            End Select
            nature = drGroup.Item("RestrictUser")
            Select Case nature
                Case "Y" : rdbYes.Checked = True
                    boolUpdate = False
                Case "N" : rdbNo.Checked = True
                    boolUpdate = True
            End Select
        End If

    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        sbClear()
        txtGroupNo.Text = objGroups.fnGetNewGroupNo
        txtOrderNo.Text = objGroups.fnGetNewOrderNo
    End Sub

    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If fnCheck() = True Then
            If fnSetData() Then
                If fnSaveData() Then
                    sbLoadGroups()
                    btnAdd_Click(sender, e)
                End If
            End If
        End If
    End Sub

    Private Sub cmbParent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbParent.SelectedIndexChanged

        Dim drGroup As DataRow

        If cmbParent.SelectedIndex = 0 Then
            cmbNature.Enabled = True
            Exit Sub
        End If

        drGroup = dvGroups.Table.Select("GroupNo=" & cmbParent.SelectedValue)(0)

        Select Case drGroup.Item("Nature")
            Case "A" : cmbNature.SelectedItem = "Asset"
            Case "L" : cmbNature.SelectedItem = "Liability"
            Case "I" : cmbNature.SelectedItem = "Income"
            Case "E" : cmbNature.SelectedItem = "Expenditure"
        End Select

        If drGroup.Item("Nature") <> "P" Then
            cmbNature.Enabled = False
        Else
            cmbNature.Enabled = True
        End If

    End Sub

#End Region

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        If lvGroups.SelectedItems.Count > 0 Then
            If lvGroups.SelectedItems(0).Index <> 0 Then
                Dim lvItem1 As ListViewItem
                Dim lvItem2 As ListViewItem
                Dim strTemp As String
                Dim intIndex As Integer = 0
                intIndex = lvGroups.SelectedItems(0).Index     'index of selected item
                lvItem1 = lvGroups.SelectedItems(0)            'selected item
                lvItem2 = lvGroups.Items(intIndex - 1)         'above item
                strTemp = lvItem2.SubItems(0).Text          'above items order no
                lvItem2.SubItems(0).Text = lvItem1.SubItems(0).Text
                lvItem1.SubItems(0).Text = strTemp
                lvGroups.Items(intIndex - 1).Remove()
                lvGroups.SelectedItems(0).Remove()
                lvGroups.Items.Insert(intIndex - 1, lvItem1)
                lvGroups.Items.Insert(intIndex, lvItem2)
                objGroups.GroupNo = lvGroups.Items(intIndex).SubItems(2).Text
                objGroups.OrderNo = lvGroups.Items(intIndex).SubItems(0).Text
                objGroups.fnUpdateOrder()
                objGroups.GroupNo = lvGroups.Items(intIndex - 1).SubItems(2).Text
                objGroups.OrderNo = lvGroups.Items(intIndex - 1).SubItems(0).Text
                objGroups.fnUpdateOrder()
                lvGroups.Items(intIndex - 1).Selected = True
                lvGroups_SelectedIndexChanged(sender, e)
                lvGroups.Focus()
            End If
        End If
    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        If lvGroups.SelectedItems.Count > 0 Then
            If lvGroups.SelectedItems(0).Index <> lvGroups.Items.Count - 1 Then
                Dim lvItem1 As ListViewItem
                Dim lvItem2 As ListViewItem
                Dim strTemp As String
                Dim intIndex As Integer = 0
                intIndex = lvGroups.SelectedItems(0).Index
                lvItem1 = lvGroups.SelectedItems(0)
                lvItem2 = lvGroups.Items(intIndex + 1)
                strTemp = lvItem2.SubItems(0).Text
                lvItem2.SubItems(0).Text = lvItem1.SubItems(0).Text
                lvItem1.SubItems(0).Text = strTemp
                lvGroups.Items(intIndex + 1).Remove()
                lvGroups.Items.Insert(intIndex, lvItem2)
                objGroups.GroupNo = lvGroups.Items(intIndex).SubItems(2).Text
                objGroups.OrderNo = lvGroups.Items(intIndex).SubItems(0).Text
                objGroups.fnUpdateOrder()
                objGroups.GroupNo = lvGroups.Items(intIndex + 1).SubItems(2).Text
                objGroups.OrderNo = lvGroups.Items(intIndex + 1).SubItems(0).Text
                objGroups.fnUpdateOrder()
                lvGroups.Items(intIndex + 1).Selected = True
                lvGroups_SelectedIndexChanged(sender, e)
                lvGroups.Focus()
            End If
        End If
    End Sub

End Class
