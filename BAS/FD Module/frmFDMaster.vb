Public Class frmFDMaster
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BalloonToolTip1 As CustomTooltip.BalloonToolTip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lvscheme As System.Windows.Forms.ListView
    Friend WithEvents SlNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents SchemeName As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbFDType As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSchemeName As BankControls.TextControl
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbMonthly As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDay As System.Windows.Forms.RadioButton
    Friend WithEvents grpFDType As System.Windows.Forms.GroupBox
    Friend WithEvents rdbCumulative As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNonCumulative As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents pnlIntSettings As System.Windows.Forms.Panel
    Friend WithEvents btnSave As BankControls.NewButton
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents txtSchemeCode As BankControls.NumericControl
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents txtSROI As BankControls.NumericControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRPercent As BankControls.NumericControl
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdbYes As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFDMaster))
        Me.Label4 = New System.Windows.Forms.Label
        Me.BalloonToolTip1 = New CustomTooltip.BalloonToolTip
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnClose = New BankControls.NewButton
        Me.btnAdd = New BankControls.NewButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lvscheme = New System.Windows.Forms.ListView
        Me.SlNo = New System.Windows.Forms.ColumnHeader
        Me.SchemeName = New System.Windows.Forms.ColumnHeader
        Me.btnSave = New BankControls.NewButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rdbNo = New System.Windows.Forms.RadioButton
        Me.rdbYes = New System.Windows.Forms.RadioButton
        Me.txtRPercent = New BankControls.NumericControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSROI = New BankControls.NumericControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSchemeCode = New BankControls.NumericControl
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmbFDType = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSchemeName = New BankControls.TextControl
        Me.Label41 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdbMonthly = New System.Windows.Forms.RadioButton
        Me.rdbDay = New System.Windows.Forms.RadioButton
        Me.grpFDType = New System.Windows.Forms.GroupBox
        Me.rdbCumulative = New System.Windows.Forms.RadioButton
        Me.rdbNonCumulative = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.pnlIntSettings = New System.Windows.Forms.Panel
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpFDType.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BalloonToolTip1.SetBalloonText(Me.Label4, Nothing)
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(40, 536)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(376, 24)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "*NOTE:- To Be Modified In Presence Of Manager Only"
        '
        'BalloonToolTip1
        '
        Me.BalloonToolTip1.BackColor = System.Drawing.SystemColors.Info
        Me.BalloonToolTip1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BalloonToolTip1.Title = ""
        '
        'GroupBox2
        '
        Me.BalloonToolTip1.SetBalloonText(Me.GroupBox2, Nothing)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(984, 608)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.btnClose, Nothing)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(664, 568)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 32)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnAdd, Nothing)
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(440, 568)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 32)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "&Reset"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.PictureBox1, Nothing)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 142
        Me.PictureBox1.TabStop = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label32, Nothing)
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(80, 32)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(211, 23)
        Me.Label32.TabIndex = 141
        Me.Label32.Text = " Deposit Master Setting"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.BalloonToolTip1.SetBalloonText(Me.GroupBox3, Nothing)
        Me.GroupBox3.Controls.Add(Me.lvscheme)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 80)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(491, 453)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        '
        'lvscheme
        '
        Me.BalloonToolTip1.SetBalloonText(Me.lvscheme, Nothing)
        Me.lvscheme.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SlNo, Me.SchemeName})
        Me.lvscheme.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvscheme.FullRowSelect = True
        Me.lvscheme.GridLines = True
        Me.lvscheme.Location = New System.Drawing.Point(6, 13)
        Me.lvscheme.MultiSelect = False
        Me.lvscheme.Name = "lvscheme"
        Me.lvscheme.Size = New System.Drawing.Size(479, 434)
        Me.lvscheme.TabIndex = 15
        Me.lvscheme.UseCompatibleStateImageBehavior = False
        Me.lvscheme.View = System.Windows.Forms.View.Details
        '
        'SlNo
        '
        Me.SlNo.Text = "SlNo"
        Me.SlNo.Width = 57
        '
        'SchemeName
        '
        Me.SchemeName.Text = "Scheme Name"
        Me.SchemeName.Width = 400
        '
        'btnSave
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnSave, Nothing)
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(536, 568)
        Me.btnSave.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 32)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "&Save Scheme"
        '
        'GroupBox4
        '
        Me.BalloonToolTip1.SetBalloonText(Me.GroupBox4, Nothing)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.txtRPercent)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtSROI)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtSchemeCode)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.cmbFDType)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtSchemeName)
        Me.GroupBox4.Controls.Add(Me.Label41)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.grpFDType)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.pnlIntSettings)
        Me.GroupBox4.Location = New System.Drawing.Point(505, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(470, 552)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        Me.BalloonToolTip1.SetBalloonText(Me.GroupBox5, Nothing)
        Me.GroupBox5.Controls.Add(Me.rdbNo)
        Me.GroupBox5.Controls.Add(Me.rdbYes)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(40, 264)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(336, 48)
        Me.GroupBox5.TabIndex = 154
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Active"
        '
        'rdbNo
        '
        Me.BalloonToolTip1.SetBalloonText(Me.rdbNo, Nothing)
        Me.rdbNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbNo.ForeColor = System.Drawing.Color.Black
        Me.rdbNo.Location = New System.Drawing.Point(104, 24)
        Me.rdbNo.Name = "rdbNo"
        Me.rdbNo.Size = New System.Drawing.Size(48, 16)
        Me.rdbNo.TabIndex = 0
        Me.rdbNo.Text = "No"
        '
        'rdbYes
        '
        Me.BalloonToolTip1.SetBalloonText(Me.rdbYes, Nothing)
        Me.rdbYes.Checked = True
        Me.rdbYes.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbYes.ForeColor = System.Drawing.Color.Black
        Me.rdbYes.Location = New System.Drawing.Point(32, 24)
        Me.rdbYes.Name = "rdbYes"
        Me.rdbYes.Size = New System.Drawing.Size(56, 16)
        Me.rdbYes.TabIndex = 1
        Me.rdbYes.TabStop = True
        Me.rdbYes.Text = "Yes"
        '
        'txtRPercent
        '
        Me.txtRPercent.AfterDecimal = 2
        Me.BalloonToolTip1.SetBalloonText(Me.txtRPercent, Nothing)
        Me.txtRPercent.BeforeDecimal = 2
        Me.txtRPercent.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRPercent.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRPercent.Location = New System.Drawing.Point(232, 240)
        Me.txtRPercent.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtRPercent.MaxLength = 10
        Me.txtRPercent.MaxValue = 0
        Me.txtRPercent.MinValue = 0
        Me.txtRPercent.Name = "txtRPercent"
        Me.txtRPercent.Size = New System.Drawing.Size(128, 23)
        Me.txtRPercent.TabIndex = 9
        Me.txtRPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label2, Nothing)
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 16)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "Reduction Percent :"
        '
        'txtSROI
        '
        Me.txtSROI.AfterDecimal = 2
        Me.BalloonToolTip1.SetBalloonText(Me.txtSROI, Nothing)
        Me.txtSROI.BeforeDecimal = 2
        Me.txtSROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSROI.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSROI.Location = New System.Drawing.Point(232, 208)
        Me.txtSROI.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtSROI.MaxLength = 10
        Me.txtSROI.MaxValue = 0
        Me.txtSROI.MinValue = 0
        Me.txtSROI.Name = "txtSROI"
        Me.txtSROI.Size = New System.Drawing.Size(128, 23)
        Me.txtSROI.TabIndex = 8
        Me.txtSROI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BalloonToolTip1.SetBalloonText(Me.Label1, Nothing)
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 151
        Me.Label1.Text = "senior citizen :"
        '
        'txtSchemeCode
        '
        Me.txtSchemeCode.AfterDecimal = 0
        Me.BalloonToolTip1.SetBalloonText(Me.txtSchemeCode, Nothing)
        Me.txtSchemeCode.BeforeDecimal = 4
        Me.txtSchemeCode.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchemeCode.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSchemeCode.Location = New System.Drawing.Point(152, 16)
        Me.txtSchemeCode.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtSchemeCode.MaxLength = 10
        Me.txtSchemeCode.MaxValue = 0
        Me.txtSchemeCode.MinValue = 0
        Me.txtSchemeCode.Name = "txtSchemeCode"
        Me.txtSchemeCode.Size = New System.Drawing.Size(72, 23)
        Me.txtSchemeCode.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label15, Nothing)
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(40, 176)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(185, 16)
        Me.Label15.TabIndex = 150
        Me.Label15.Text = "Intrest calculation Period :"
        '
        'cmbFDType
        '
        Me.BalloonToolTip1.SetBalloonText(Me.cmbFDType, Nothing)
        Me.cmbFDType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFDType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFDType.ForeColor = System.Drawing.Color.Black
        Me.cmbFDType.Items.AddRange(New Object() {"", "Monthly", "Quarterly", "Half-Yearly", "Yearly"})
        Me.cmbFDType.Location = New System.Drawing.Point(232, 176)
        Me.cmbFDType.Name = "cmbFDType"
        Me.cmbFDType.Size = New System.Drawing.Size(128, 24)
        Me.cmbFDType.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label5, Nothing)
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 16)
        Me.Label5.TabIndex = 148
        Me.Label5.Text = "Scheme Code :"
        '
        'txtSchemeName
        '
        Me.txtSchemeName.AlphaNumeric = False
        Me.BalloonToolTip1.SetBalloonText(Me.txtSchemeName, Nothing)
        Me.txtSchemeName.BlankSpace = True
        Me.txtSchemeName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchemeName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSchemeName.Location = New System.Drawing.Point(152, 48)
        Me.txtSchemeName.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtSchemeName.Mandatory = False
        Me.txtSchemeName.MaxLength = 50
        Me.txtSchemeName.Name = "txtSchemeName"
        Me.txtSchemeName.Size = New System.Drawing.Size(216, 22)
        Me.txtSchemeName.SpecialChar = True
        Me.txtSchemeName.TabIndex = 4
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label41, Nothing)
        Me.Label41.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(40, 48)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(112, 16)
        Me.Label41.TabIndex = 147
        Me.Label41.Text = "Scheme Name :"
        '
        'GroupBox1
        '
        Me.BalloonToolTip1.SetBalloonText(Me.GroupBox1, Nothing)
        Me.GroupBox1.Controls.Add(Me.rdbMonthly)
        Me.GroupBox1.Controls.Add(Me.rdbDay)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(40, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 48)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculation Type"
        '
        'rdbMonthly
        '
        Me.BalloonToolTip1.SetBalloonText(Me.rdbMonthly, Nothing)
        Me.rdbMonthly.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMonthly.ForeColor = System.Drawing.Color.Black
        Me.rdbMonthly.Location = New System.Drawing.Point(176, 24)
        Me.rdbMonthly.Name = "rdbMonthly"
        Me.rdbMonthly.Size = New System.Drawing.Size(104, 16)
        Me.rdbMonthly.TabIndex = 0
        Me.rdbMonthly.Text = "Month Wise"
        '
        'rdbDay
        '
        Me.BalloonToolTip1.SetBalloonText(Me.rdbDay, Nothing)
        Me.rdbDay.Checked = True
        Me.rdbDay.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbDay.ForeColor = System.Drawing.Color.Black
        Me.rdbDay.Location = New System.Drawing.Point(32, 24)
        Me.rdbDay.Name = "rdbDay"
        Me.rdbDay.Size = New System.Drawing.Size(80, 16)
        Me.rdbDay.TabIndex = 1
        Me.rdbDay.TabStop = True
        Me.rdbDay.Text = "Day Wise"
        '
        'grpFDType
        '
        Me.BalloonToolTip1.SetBalloonText(Me.grpFDType, Nothing)
        Me.grpFDType.Controls.Add(Me.rdbCumulative)
        Me.grpFDType.Controls.Add(Me.rdbNonCumulative)
        Me.grpFDType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFDType.ForeColor = System.Drawing.Color.Black
        Me.grpFDType.Location = New System.Drawing.Point(40, 72)
        Me.grpFDType.Name = "grpFDType"
        Me.grpFDType.Size = New System.Drawing.Size(328, 48)
        Me.grpFDType.TabIndex = 5
        Me.grpFDType.TabStop = False
        Me.grpFDType.Text = "Deposit Type"
        '
        'rdbCumulative
        '
        Me.BalloonToolTip1.SetBalloonText(Me.rdbCumulative, Nothing)
        Me.rdbCumulative.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCumulative.ForeColor = System.Drawing.Color.Black
        Me.rdbCumulative.Location = New System.Drawing.Point(176, 24)
        Me.rdbCumulative.Name = "rdbCumulative"
        Me.rdbCumulative.Size = New System.Drawing.Size(104, 16)
        Me.rdbCumulative.TabIndex = 0
        Me.rdbCumulative.Text = "Cumulative"
        '
        'rdbNonCumulative
        '
        Me.BalloonToolTip1.SetBalloonText(Me.rdbNonCumulative, Nothing)
        Me.rdbNonCumulative.Checked = True
        Me.rdbNonCumulative.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbNonCumulative.ForeColor = System.Drawing.Color.Black
        Me.rdbNonCumulative.Location = New System.Drawing.Point(32, 24)
        Me.rdbNonCumulative.Name = "rdbNonCumulative"
        Me.rdbNonCumulative.Size = New System.Drawing.Size(144, 16)
        Me.rdbNonCumulative.TabIndex = 1
        Me.rdbNonCumulative.TabStop = True
        Me.rdbNonCumulative.Text = "Non-Cumulative"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BalloonToolTip1.SetBalloonText(Me.Label6, Nothing)
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(47, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 141
        Me.Label6.Text = "From Period"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BalloonToolTip1.SetBalloonText(Me.Label7, Nothing)
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(175, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 139
        Me.Label7.Text = "To Period"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BalloonToolTip1.SetBalloonText(Me.Label8, Nothing)
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(279, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 16)
        Me.Label8.TabIndex = 140
        Me.Label8.Text = "Rate Of Interest"
        '
        'pnlIntSettings
        '
        Me.pnlIntSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlIntSettings.AutoScroll = True
        Me.BalloonToolTip1.SetBalloonText(Me.pnlIntSettings, Nothing)
        Me.pnlIntSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlIntSettings.Location = New System.Drawing.Point(39, 336)
        Me.pnlIntSettings.Name = "pnlIntSettings"
        Me.pnlIntSettings.Size = New System.Drawing.Size(368, 208)
        Me.pnlIntSettings.TabIndex = 10
        '
        'frmFDMaster
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1018, 631)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFDMaster"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Deposit Master Settings"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.grpFDType.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmFDMaster
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmFDMaster
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmFDMaster
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmFDMaster)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Variables"

    Dim objCtrl(10) As IntSettingsCtrl
    Dim dtIntrSettings As DataTable
    Dim objFDAcc As New clsFDAccount

#End Region

#Region "Function"

    Public Function fnCheck() As Boolean
        If txtSchemeName.Text = String.Empty Then
            MsgBox("Enter scheme name", MsgBoxStyle.Information)
            txtSchemeName.Focus()
            Return False
        ElseIf cmbFDType.SelectedIndex = 0 Then
            MsgBox("Select any intrest posting period", MsgBoxStyle.Information)
            cmbFDType.Focus()
            Return False
        ElseIf txtSROI.Text = String.Empty Then
            MsgBox("Enter interest for senior citizen", MsgBoxStyle.Information)
            txtSROI.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Sub Clear()
        txtSchemeName.ResetText()
        txtSchemeCode.ResetText()

        cmbFDType.SelectedIndex = 0
        txtSROI.ResetText()
        txtRPercent.ResetText()
        rdbYes.Checked = True

        Dim objIntrSet As DataTable
        Dim intCount As Integer

        While intCount < pnlIntSettings.Controls.Count
            objCtrl(intCount).txtFrom.Text = ""
            objCtrl(intCount).txtTo.Text = ""
            objCtrl(intCount).txtROI.Text = ""
            intCount += 1
        End While

    End Sub

    Sub fnLoadData()
        If objFDAcc.fnGetScheme Then
            Dim dtScheme As DataTable = objFDAcc.FdMasterTbl
            Dim lvItem As ListViewItem
            Dim intCount As Integer
            lvscheme.Items.Clear()
            While intCount < dtScheme.Rows.Count
                lvItem = lvscheme.Items.Add(dtScheme.Rows(intCount).Item(0))
                lvItem.SubItems.Add(dtScheme.Rows(intCount).Item(1))
                intCount += 1
            End While
            If lvscheme.Items.Count > 0 Then
                lvscheme.Items(0).Selected = True
            End If
        End If
    End Sub

    Public Function fnLoadIntrCtrl()

        Dim intCount As Integer
        Dim ctrlHt As Integer

        While intCount < 10
            objCtrl(intCount) = New IntSettingsCtrl
            ctrlHt = (objCtrl(intCount).Height)
            objCtrl(intCount).Top = ctrlHt * intCount
            pnlIntSettings.Controls.Add(objCtrl(intCount))
            intCount += 1
        End While

    End Function

    Public Function fnApplyMasterSet() As Boolean

        Dim dtROI As IntSettingsCtrl
        Dim intCount As Integer
        Dim drRow As DataRow
        dtIntrSettings = New DataTable
        dtIntrSettings.Columns.Add("SchemeCode")
        dtIntrSettings.Columns.Add("FromPeriod")
        dtIntrSettings.Columns.Add("ToPeriod")
        dtIntrSettings.Columns.Add("ROI")


        objFDAcc.SchemeName = txtSchemeName.Text
        objFDAcc.SchemeCode = txtSchemeCode.Text
        objFDAcc.SenoirCROI = txtSROI.Text
        objFDAcc.ReductionInterest = txtRPercent.Text

        objFDAcc.calcualtionType = IIf(rdbMonthly.Checked = True, "M", "D")
        objFDAcc.FDType = IIf(rdbCumulative.Checked = True, "C", "N")
        objFDAcc.PostingPeriod = cmbFDType.SelectedItem
        objFDAcc.Status = IIf(rdbYes.Checked = True, "Y", "N")

        While intCount < pnlIntSettings.Controls.Count
            drRow = dtIntrSettings.NewRow
            dtROI = pnlIntSettings.Controls(intCount)
            drRow(0) = txtSchemeCode.Text
            If dtROI.txtFrom.Text <> "" Then
                drRow(1) = dtROI.txtFrom.Text
                drRow(2) = dtROI.txtTo.Text
                drRow(3) = dtROI.txtROI.Text
                dtIntrSettings.Rows.Add(drRow)
            End If
            intCount += 1
        End While
        objFDAcc.FdMasterTbl = dtIntrSettings

        Return True

    End Function

    Public Function fnSaveSettings(ByVal objTrans As IDbTransaction) As Boolean

        If objFDAcc.fnCheckScheme Then
            If objFDAcc.fnUpdateScheme(objTrans) Then
                If objFDAcc.fnDeleteIntrSettings(objTrans) Then
                    If objFDAcc.fnApplyIntrSet(objTrans) Then
                        fnLogEntry(pbUserId, "FD scheme updated " & txtSchemeName.Text, Date.Now, "New Deposit", objTrans)
                        MsgBox("  FD scheme updated successfully", MsgBoxStyle.Information, "Deposit Module")
                        Return True
                    Else
                        MsgBox("  FD scheme updation failed", MsgBoxStyle.Information, "Deposit Module")
                        Return False
                    End If
                End If
            End If
        Else
            If objFDAcc.fnAddNewScheme(objTrans) Then
                If objFDAcc.fnApplyIntrSet(objTrans) Then
                    fnLogEntry(pbUserId, "New FD scheme created " & txtSchemeName.Text, Date.Now, "New Deposit", objTrans)
                    MsgBox(" New FD scheme added successfully", MsgBoxStyle.Information, " FD Module")
                    Return True
                Else
                    MsgBox(" New FD scheme addition failed", MsgBoxStyle.Information, " FD Module")
                    Return False
                End If
            End If

        End If
    End Function

    Public Function fnLoadSettings() As Boolean
        Dim objIntrSet As DataTable
        Dim intCount As Integer

        If objFDAcc.fnGetMasterSetting Then
            objIntrSet = objFDAcc.FdMasterTbl

            While intCount < objIntrSet.Rows.Count
                objCtrl(intCount).txtFrom.Text = objIntrSet.Rows(intCount).Item("FromPeriod")
                objCtrl(intCount).txtTo.Text = objIntrSet.Rows(intCount).Item("ToPeriod")
                objCtrl(intCount).txtROI.Text = objIntrSet.Rows(intCount).Item("ROI")
                intCount += 1
            End While
        End If
    End Function

#End Region

#Region "Events"

    Private Sub frmFDMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fnLoadIntrCtrl()
        fnLoadData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim objTrans As IDbTransaction
        If MsgBox("Are you sure, do you want to change scheme settings", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " FD Module") = MsgBoxResult.Yes Then
            Try
                objTrans = fnGetTransaction()
                If fnCheck() Then
                    If fnApplyMasterSet() Then
                        If fnSaveSettings(objTrans) Then
                            objTrans.Commit()
                            fnLoadData()
                            btnadd_Click(sender, e)
                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Finally
                objTrans.Dispose()
            End Try

        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Clear()
    End Sub

    Private Sub lvscheme_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvscheme.Click
        If lvscheme.SelectedIndices.Count > 0 Then
            Clear()
            objFDAcc.SchemeCode = lvscheme.SelectedItems(0).SubItems(0).Text
            If objFDAcc.fnCheckScheme() Then
                txtSchemeCode.Text = objFDAcc.FDMasterDetailTbl.Rows(0).Item(0)
                txtSchemeName.Text = objFDAcc.FDMasterDetailTbl.Rows(0).Item(1)

                txtSROI.Text = objFDAcc.FDMasterDetailTbl.Rows(0).Item(5)
                txtRPercent.Text = objFDAcc.FDMasterDetailTbl.Rows(0).Item(6)
                If objFDAcc.FDMasterDetailTbl.Rows(0).Item(7) = "Y" Then
                    rdbYes.Checked = True
                Else
                    rdbNo.Checked = True
                End If

                If objFDAcc.FDMasterDetailTbl.Rows(0).Item(2) = "C" Then
                    rdbCumulative.Checked = True
                Else
                    rdbNonCumulative.Checked = True
                End If

                If objFDAcc.FDMasterDetailTbl.Rows(0).Item(3) = "D" Then
                    rdbDay.Checked = True
                Else
                    rdbMonthly.Checked = False
                End If

                Select Case objFDAcc.FDMasterDetailTbl.Rows(0).Item(4)
                    Case "Monthly"
                        cmbFDType.SelectedItem = "Monthly"
                    Case "Quarterly"
                        cmbFDType.SelectedItem = "Quarterly"
                    Case "Half-Yearly"
                        cmbFDType.SelectedItem = "Half-Yearly"
                    Case "Yearly"
                        cmbFDType.SelectedItem = "Yearly"
                End Select
            End If
            fnLoadSettings()
        End If
    End Sub

#End Region



    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub
End Class
