Public Class frmShareConfiguration
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lvShareDetail As System.Windows.Forms.ListView
    Friend WithEvents SlNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ShareType As System.Windows.Forms.ColumnHeader
    Friend WithEvents ShareAmount As System.Windows.Forms.ColumnHeader
    Friend WithEvents BuildingFund As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmbShareType As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnConfig As BankControls.NewButton
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents txtAmtPerShare As BankControls.NumericControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtShareEntryFee As BankControls.NumericControl
    Friend WithEvents txtShareFee As BankControls.NumericControl
    Friend WithEvents txtBuildingFund As BankControls.NumericControl
    Friend WithEvents txtBF As BankControls.NumericControl
    Friend WithEvents txtSEF As BankControls.NumericControl
    Friend WithEvents txtSF As BankControls.NumericControl
    Friend WithEvents ShareFee As System.Windows.Forms.ColumnHeader
    Friend WithEvents ShareEntryFee As System.Windows.Forms.ColumnHeader
    Friend WithEvents ApplicationFee As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblShareFee As System.Windows.Forms.Label
    Friend WithEvents lblShareEntryFee As System.Windows.Forms.Label
    Friend WithEvents lblBuildingFund As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdSFFixed As System.Windows.Forms.RadioButton
    Friend WithEvents rdSFVariable As System.Windows.Forms.RadioButton
    Friend WithEvents rdSEFFixed As System.Windows.Forms.RadioButton
    Friend WithEvents rdSEFVariable As System.Windows.Forms.RadioButton
    Friend WithEvents rdBFFixed As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdAFFixed As System.Windows.Forms.RadioButton
    Friend WithEvents rdAFVariable As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtApplicationFee As BankControls.NumericControl
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAF As BankControls.NumericControl
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents rdBFVariable As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShareConfiguration))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rdAFFixed = New System.Windows.Forms.RadioButton()
        Me.rdAFVariable = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdBFFixed = New System.Windows.Forms.RadioButton()
        Me.rdBFVariable = New System.Windows.Forms.RadioButton()
        Me.txtApplicationFee = New BankControls.NumericControl()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdSEFFixed = New System.Windows.Forms.RadioButton()
        Me.rdSEFVariable = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdSFFixed = New System.Windows.Forms.RadioButton()
        Me.rdSFVariable = New System.Windows.Forms.RadioButton()
        Me.txtAF = New BankControls.NumericControl()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBuildingFund = New BankControls.NumericControl()
        Me.lblBuildingFund = New System.Windows.Forms.Label()
        Me.txtBF = New BankControls.NumericControl()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtShareEntryFee = New BankControls.NumericControl()
        Me.lblShareEntryFee = New System.Windows.Forms.Label()
        Me.txtSEF = New BankControls.NumericControl()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtShareFee = New BankControls.NumericControl()
        Me.lblShareFee = New System.Windows.Forms.Label()
        Me.txtSF = New BankControls.NumericControl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lvShareDetail = New System.Windows.Forms.ListView()
        Me.SlNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ShareType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ShareAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ShareFee = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ShareEntryFee = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ApplicationFee = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BuildingFund = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbShareType = New System.Windows.Forms.ComboBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.btnConfig = New BankControls.NewButton()
        Me.btnClose = New BankControls.NewButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txtAmtPerShare = New BankControls.NumericControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(225, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(360, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Master Form To Change Shares  Settings "
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.txtApplicationFee)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtAF)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtBuildingFund)
        Me.Panel1.Controls.Add(Me.lblBuildingFund)
        Me.Panel1.Controls.Add(Me.txtBF)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtShareEntryFee)
        Me.Panel1.Controls.Add(Me.lblShareEntryFee)
        Me.Panel1.Controls.Add(Me.txtSEF)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtShareFee)
        Me.Panel1.Controls.Add(Me.lblShareFee)
        Me.Panel1.Controls.Add(Me.txtSF)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lvShareDetail)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.cmbShareType)
        Me.Panel1.Controls.Add(Me.dtpDate)
        Me.Panel1.Controls.Add(Me.btnConfig)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label55)
        Me.Panel1.Controls.Add(Me.txtAmtPerShare)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(845, 432)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.rdAFFixed)
        Me.GroupBox4.Controls.Add(Me.rdAFVariable)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(604, 72)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(152, 40)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        '
        'rdAFFixed
        '
        Me.rdAFFixed.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdAFFixed.Location = New System.Drawing.Point(8, 8)
        Me.rdAFFixed.Name = "rdAFFixed"
        Me.rdAFFixed.Size = New System.Drawing.Size(56, 24)
        Me.rdAFFixed.TabIndex = 0
        Me.rdAFFixed.TabStop = True
        Me.rdAFFixed.Text = "Fixed"
        '
        'rdAFVariable
        '
        Me.rdAFVariable.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdAFVariable.Location = New System.Drawing.Point(72, 8)
        Me.rdAFVariable.Name = "rdAFVariable"
        Me.rdAFVariable.Size = New System.Drawing.Size(80, 24)
        Me.rdAFVariable.TabIndex = 1
        Me.rdAFVariable.TabStop = True
        Me.rdAFVariable.Text = "Variable"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(732, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Rs"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.rdBFFixed)
        Me.GroupBox3.Controls.Add(Me.rdBFVariable)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(604, 142)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(152, 40)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        '
        'rdBFFixed
        '
        Me.rdBFFixed.Font = New System.Drawing.Font("Georgia", 9.0!)
        Me.rdBFFixed.Location = New System.Drawing.Point(8, 8)
        Me.rdBFFixed.Name = "rdBFFixed"
        Me.rdBFFixed.Size = New System.Drawing.Size(56, 24)
        Me.rdBFFixed.TabIndex = 0
        Me.rdBFFixed.TabStop = True
        Me.rdBFFixed.Text = "Fixed"
        '
        'rdBFVariable
        '
        Me.rdBFVariable.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdBFVariable.Location = New System.Drawing.Point(72, 8)
        Me.rdBFVariable.Name = "rdBFVariable"
        Me.rdBFVariable.Size = New System.Drawing.Size(80, 24)
        Me.rdBFVariable.TabIndex = 1
        Me.rdBFVariable.TabStop = True
        Me.rdBFVariable.Text = "Variable"
        '
        'txtApplicationFee
        '
        Me.txtApplicationFee.AfterDecimal = 0
        Me.txtApplicationFee.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtApplicationFee.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtApplicationFee.BeforeDecimal = 4
        Me.txtApplicationFee.Enabled = False
        Me.txtApplicationFee.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApplicationFee.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtApplicationFee.Location = New System.Drawing.Point(604, 113)
        Me.txtApplicationFee.LostFocusColour = System.Drawing.Color.Empty
        Me.txtApplicationFee.MaxLength = 5
        Me.txtApplicationFee.MaxValue = 99999999.0R
        Me.txtApplicationFee.MinValue = 0.0R
        Me.txtApplicationFee.Name = "txtApplicationFee"
        Me.txtApplicationFee.Size = New System.Drawing.Size(120, 23)
        Me.txtApplicationFee.TabIndex = 23
        Me.txtApplicationFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rdSEFFixed)
        Me.GroupBox2.Controls.Add(Me.rdSEFVariable)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(155, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 40)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'rdSEFFixed
        '
        Me.rdSEFFixed.Font = New System.Drawing.Font("Georgia", 9.0!)
        Me.rdSEFFixed.Location = New System.Drawing.Point(8, 8)
        Me.rdSEFFixed.Name = "rdSEFFixed"
        Me.rdSEFFixed.Size = New System.Drawing.Size(56, 24)
        Me.rdSEFFixed.TabIndex = 0
        Me.rdSEFFixed.TabStop = True
        Me.rdSEFFixed.Text = "Fixed"
        '
        'rdSEFVariable
        '
        Me.rdSEFVariable.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdSEFVariable.Location = New System.Drawing.Point(72, 8)
        Me.rdSEFVariable.Name = "rdSEFVariable"
        Me.rdSEFVariable.Size = New System.Drawing.Size(80, 24)
        Me.rdSEFVariable.TabIndex = 1
        Me.rdSEFVariable.TabStop = True
        Me.rdSEFVariable.Text = "Variable"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(811, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "%"
        Me.Label8.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdSFFixed)
        Me.GroupBox1.Controls.Add(Me.rdSFVariable)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(155, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 40)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'rdSFFixed
        '
        Me.rdSFFixed.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdSFFixed.Location = New System.Drawing.Point(8, 8)
        Me.rdSFFixed.Name = "rdSFFixed"
        Me.rdSFFixed.Size = New System.Drawing.Size(56, 24)
        Me.rdSFFixed.TabIndex = 0
        Me.rdSFFixed.TabStop = True
        Me.rdSFFixed.Text = "Fixed"
        '
        'rdSFVariable
        '
        Me.rdSFVariable.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdSFVariable.Location = New System.Drawing.Point(72, 8)
        Me.rdSFVariable.Name = "rdSFVariable"
        Me.rdSFVariable.Size = New System.Drawing.Size(80, 24)
        Me.rdSFVariable.TabIndex = 1
        Me.rdSFVariable.TabStop = True
        Me.rdSFVariable.Text = "Variable"
        '
        'txtAF
        '
        Me.txtAF.AfterDecimal = 0
        Me.txtAF.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAF.BeforeDecimal = 2
        Me.txtAF.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAF.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAF.Location = New System.Drawing.Point(759, 80)
        Me.txtAF.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAF.MaxLength = 5
        Me.txtAF.MaxValue = 99999999.0R
        Me.txtAF.MinValue = 0.0R
        Me.txtAF.Name = "txtAF"
        Me.txtAF.Size = New System.Drawing.Size(48, 23)
        Me.txtAF.TabIndex = 21
        Me.txtAF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAF.Visible = False
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(732, 183)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 16)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Rs"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(478, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 16)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Application Fee :"
        '
        'txtBuildingFund
        '
        Me.txtBuildingFund.AfterDecimal = 0
        Me.txtBuildingFund.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBuildingFund.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtBuildingFund.BeforeDecimal = 4
        Me.txtBuildingFund.Enabled = False
        Me.txtBuildingFund.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuildingFund.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBuildingFund.Location = New System.Drawing.Point(604, 183)
        Me.txtBuildingFund.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBuildingFund.MaxLength = 5
        Me.txtBuildingFund.MaxValue = 99999999.0R
        Me.txtBuildingFund.MinValue = 0.0R
        Me.txtBuildingFund.Name = "txtBuildingFund"
        Me.txtBuildingFund.Size = New System.Drawing.Size(120, 23)
        Me.txtBuildingFund.TabIndex = 29
        Me.txtBuildingFund.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBuildingFund
        '
        Me.lblBuildingFund.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBuildingFund.AutoSize = True
        Me.lblBuildingFund.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuildingFund.Location = New System.Drawing.Point(813, 154)
        Me.lblBuildingFund.Name = "lblBuildingFund"
        Me.lblBuildingFund.Size = New System.Drawing.Size(21, 16)
        Me.lblBuildingFund.TabIndex = 28
        Me.lblBuildingFund.Text = "%"
        Me.lblBuildingFund.Visible = False
        '
        'txtBF
        '
        Me.txtBF.AfterDecimal = 0
        Me.txtBF.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBF.BeforeDecimal = 2
        Me.txtBF.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBF.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBF.Location = New System.Drawing.Point(760, 151)
        Me.txtBF.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBF.MaxLength = 5
        Me.txtBF.MaxValue = 99999999.0R
        Me.txtBF.MinValue = 0.0R
        Me.txtBF.Name = "txtBF"
        Me.txtBF.Size = New System.Drawing.Size(48, 23)
        Me.txtBF.TabIndex = 27
        Me.txtBF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBF.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(478, 155)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 16)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Building Fund :"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(283, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Rs"
        '
        'txtShareEntryFee
        '
        Me.txtShareEntryFee.AfterDecimal = 0
        Me.txtShareEntryFee.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtShareEntryFee.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtShareEntryFee.BeforeDecimal = 4
        Me.txtShareEntryFee.Enabled = False
        Me.txtShareEntryFee.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShareEntryFee.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtShareEntryFee.Location = New System.Drawing.Point(155, 177)
        Me.txtShareEntryFee.LostFocusColour = System.Drawing.Color.Empty
        Me.txtShareEntryFee.MaxLength = 5
        Me.txtShareEntryFee.MaxValue = 99999999.0R
        Me.txtShareEntryFee.MinValue = 0.0R
        Me.txtShareEntryFee.Name = "txtShareEntryFee"
        Me.txtShareEntryFee.Size = New System.Drawing.Size(120, 23)
        Me.txtShareEntryFee.TabIndex = 17
        Me.txtShareEntryFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblShareEntryFee
        '
        Me.lblShareEntryFee.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblShareEntryFee.AutoSize = True
        Me.lblShareEntryFee.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShareEntryFee.Location = New System.Drawing.Point(364, 147)
        Me.lblShareEntryFee.Name = "lblShareEntryFee"
        Me.lblShareEntryFee.Size = New System.Drawing.Size(21, 16)
        Me.lblShareEntryFee.TabIndex = 16
        Me.lblShareEntryFee.Text = "%"
        Me.lblShareEntryFee.Visible = False
        '
        'txtSEF
        '
        Me.txtSEF.AfterDecimal = 0
        Me.txtSEF.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSEF.BeforeDecimal = 2
        Me.txtSEF.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSEF.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSEF.Location = New System.Drawing.Point(311, 145)
        Me.txtSEF.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSEF.MaxLength = 5
        Me.txtSEF.MaxValue = 99999999.0R
        Me.txtSEF.MinValue = 0.0R
        Me.txtSEF.Name = "txtSEF"
        Me.txtSEF.Size = New System.Drawing.Size(48, 23)
        Me.txtSEF.TabIndex = 15
        Me.txtSEF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSEF.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Share Entry Fee :"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(283, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Rs"
        '
        'txtShareFee
        '
        Me.txtShareFee.AfterDecimal = 0
        Me.txtShareFee.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtShareFee.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtShareFee.BeforeDecimal = 4
        Me.txtShareFee.Enabled = False
        Me.txtShareFee.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShareFee.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtShareFee.Location = New System.Drawing.Point(155, 113)
        Me.txtShareFee.LostFocusColour = System.Drawing.Color.Empty
        Me.txtShareFee.MaxLength = 5
        Me.txtShareFee.MaxValue = 99999999.0R
        Me.txtShareFee.MinValue = 0.0R
        Me.txtShareFee.Name = "txtShareFee"
        Me.txtShareFee.Size = New System.Drawing.Size(120, 23)
        Me.txtShareFee.TabIndex = 11
        Me.txtShareFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblShareFee
        '
        Me.lblShareFee.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblShareFee.AutoSize = True
        Me.lblShareFee.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShareFee.Location = New System.Drawing.Point(364, 83)
        Me.lblShareFee.Name = "lblShareFee"
        Me.lblShareFee.Size = New System.Drawing.Size(21, 16)
        Me.lblShareFee.TabIndex = 10
        Me.lblShareFee.Text = "%"
        Me.lblShareFee.Visible = False
        '
        'txtSF
        '
        Me.txtSF.AfterDecimal = 0
        Me.txtSF.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSF.BeforeDecimal = 2
        Me.txtSF.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSF.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSF.Location = New System.Drawing.Point(311, 80)
        Me.txtSF.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSF.MaxLength = 5
        Me.txtSF.MaxValue = 99999999.0R
        Me.txtSF.MinValue = 0.0R
        Me.txtSF.Name = "txtSF"
        Me.txtSF.Size = New System.Drawing.Size(48, 23)
        Me.txtSF.TabIndex = 9
        Me.txtSF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSF.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Share Fee :"
        '
        'lvShareDetail
        '
        Me.lvShareDetail.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SlNo, Me.ShareType, Me.ShareAmount, Me.ShareFee, Me.ShareEntryFee, Me.ApplicationFee, Me.BuildingFund, Me.SDate})
        Me.lvShareDetail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvShareDetail.FullRowSelect = True
        Me.lvShareDetail.GridLines = True
        Me.lvShareDetail.Location = New System.Drawing.Point(8, 272)
        Me.lvShareDetail.Name = "lvShareDetail"
        Me.lvShareDetail.Size = New System.Drawing.Size(824, 144)
        Me.lvShareDetail.TabIndex = 33
        Me.lvShareDetail.UseCompatibleStateImageBehavior = False
        Me.lvShareDetail.View = System.Windows.Forms.View.Details
        '
        'SlNo
        '
        Me.SlNo.Text = "SlNo."
        Me.SlNo.Width = 44
        '
        'ShareType
        '
        Me.ShareType.Text = "ShareType"
        Me.ShareType.Width = 88
        '
        'ShareAmount
        '
        Me.ShareAmount.Text = "ShareAmount"
        Me.ShareAmount.Width = 102
        '
        'ShareFee
        '
        Me.ShareFee.Text = "ShareFee"
        Me.ShareFee.Width = 80
        '
        'ShareEntryFee
        '
        Me.ShareEntryFee.Text = "ShareEntryFee"
        Me.ShareEntryFee.Width = 103
        '
        'ApplicationFee
        '
        Me.ApplicationFee.Text = "Application Fee"
        Me.ApplicationFee.Width = 96
        '
        'BuildingFund
        '
        Me.BuildingFund.Text = "Building Fund"
        Me.BuildingFund.Width = 92
        '
        'SDate
        '
        Me.SDate.Text = "Date"
        Me.SDate.Width = 90
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Share Type : "
        '
        'cmbShareType
        '
        Me.cmbShareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbShareType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbShareType.Items.AddRange(New Object() {"Share Capital A", "Share Capital B", "Souharda Risk Fund"})
        Me.cmbShareType.Location = New System.Drawing.Point(155, 13)
        Me.cmbShareType.Name = "cmbShareType"
        Me.cmbShareType.Size = New System.Drawing.Size(168, 24)
        Me.cmbShareType.TabIndex = 1
        '
        'dtpDate
        '
        Me.dtpDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.dtpDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(545, 16)
        Me.dtpDate.MaxDate = New Date(9998, 10, 5, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpDate.TabIndex = 3
        Me.dtpDate.Value = New Date(2007, 9, 13, 0, 0, 0, 0)
        '
        'btnConfig
        '
        Me.btnConfig.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConfig.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfig.ForeColor = System.Drawing.Color.Black
        Me.btnConfig.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnConfig.Image = CType(resources.GetObject("btnConfig.Image"), System.Drawing.Image)
        Me.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfig.Location = New System.Drawing.Point(590, 226)
        Me.btnConfig.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(104, 40)
        Me.btnConfig.TabIndex = 31
        Me.btnConfig.Text = "C&onfig"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(696, 224)
        Me.btnClose.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 32
        Me.btnClose.Text = "&Close"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(278, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Rs"
        '
        'Label55
        '
        Me.Label55.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label55.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(8, 50)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(144, 17)
        Me.Label55.TabIndex = 4
        Me.Label55.Text = "Amount Per Share :  "
        '
        'txtAmtPerShare
        '
        Me.txtAmtPerShare.AfterDecimal = 0
        Me.txtAmtPerShare.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAmtPerShare.BeforeDecimal = 6
        Me.txtAmtPerShare.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmtPerShare.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmtPerShare.Location = New System.Drawing.Point(155, 47)
        Me.txtAmtPerShare.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAmtPerShare.MaxLength = 5
        Me.txtAmtPerShare.MaxValue = 99999999.0R
        Me.txtAmtPerShare.MinValue = 0.0R
        Me.txtAmtPerShare.Name = "txtAmtPerShare"
        Me.txtAmtPerShare.Size = New System.Drawing.Size(120, 23)
        Me.txtAmtPerShare.TabIndex = 5
        Me.txtAmtPerShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(478, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date :"
        '
        'frmShareConfiguration
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(869, 503)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmShareConfiguration"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Share Configuration"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmShareConfiguration
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmShareConfiguration
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmShareConfiguration
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmShareConfiguration)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Variables"

    Dim objShare As New clsShares

#End Region

#Region "Functions"

    Public Function fnSetData() As Boolean

        objShare.ShareConfigDate = dtpDate.Value
        If txtAmtPerShare.Text = "" Then
            objShare.AmountPerShare = 0
        Else
            objShare.AmountPerShare = txtAmtPerShare.Text
        End If
        If txtShareFee.Text = "" Then
            objShare.ShareFee = 0
        Else
            objShare.ShareFee = txtShareFee.Text
        End If

        If txtShareEntryFee.Text = "" Then
            objShare.ShareEntryFee = 0
        Else
            objShare.ShareEntryFee = txtShareEntryFee.Text
        End If

        If txtApplicationFee.Text = "" Then
            objShare.ApplicationFee = 0
        Else
            objShare.ApplicationFee = txtApplicationFee.Text
        End If

        If txtBuildingFund.Text = "" Then
            objShare.BuildingFund = 0
        Else
            objShare.BuildingFund = txtBuildingFund.Text
        End If

        If cmbShareType.SelectedItem = "Share Capital A" Then
            objShare.Type = "SCA"
        ElseIf cmbShareType.SelectedItem = "Share Capital B" Then
            objShare.Type = "SCB"
        Else
            objShare.Type = "SRF"
        End If
        Return True

    End Function

    Public Function fnCheck() As Boolean
        If txtShareFee.Text = "" Then
            MsgBox("Enter share fee", MsgBoxStyle.Information, "Master Setting Module")
            txtShareFee.Focus()
            Return False
        ElseIf txtShareEntryFee.Text = "" Then
            MsgBox("Enter share entry fee", MsgBoxStyle.Exclamation)
            txtShareEntryFee.Focus()
            Return False
        ElseIf txtAmtPerShare.Text = "" Then
            MsgBox("Enter share amount", MsgBoxStyle.Exclamation)
            txtAmtPerShare.Focus()
            Return False
        ElseIf txtBuildingFund.Text = "" Then
            MsgBox("Enter building fund", MsgBoxStyle.Exclamation)
            txtBuildingFund.Focus()
            Return False
        Else
            Return True
        End If

    End Function

    Sub Clear()
        cmbShareType.SelectedIndex = 0
        txtShareEntryFee.Text = ""
        txtShareFee.Text = ""
        txtAmtPerShare.Text = ""
        txtBuildingFund.Text = ""
        txtBF.Text = ""
        txtSEF.Text = ""
        txtSF.Text = ""
        txtApplicationFee.Text = ""
        txtBF.Visible = False
        lblBuildingFund.Visible = False
        txtBuildingFund.Enabled = False
        txtApplicationFee.Enabled = False
        txtSEF.Visible = False
        lblShareEntryFee.Visible = False
        txtShareEntryFee.Enabled = False
        txtSF.Visible = False
        lblShareFee.Visible = False
        txtShareFee.Enabled = False
        rdBFFixed.Checked = False
        rdBFVariable.Checked = False
        rdSEFFixed.Checked = False
        rdSEFVariable.Checked = False
        rdSFFixed.Checked = False
        rdSFVariable.Checked = False

    End Sub

    Public Function fnLoadConfig() As Boolean
        If objShare.fnGetConfig Then
            Dim intCount As Integer = 0
            Dim slNo As Integer = 1
            lvShareDetail.Items.Clear()
            While intCount < objShare.ConfigTbl.Rows.Count
                Dim lvItem As New ListViewItem

                lvItem = lvShareDetail.Items.Add(slNo)
                lvItem.SubItems.Add(objShare.ConfigTbl.Rows(intCount).Item("ShareType"))
                lvItem.SubItems.Add(objShare.ConfigTbl.Rows(intCount).Item("AmountPerShare"))
                lvItem.SubItems.Add(objShare.ConfigTbl.Rows(intCount).Item("ShareFee"))
                lvItem.SubItems.Add(objShare.ConfigTbl.Rows(intCount).Item("ShareEntryFee"))
                lvItem.SubItems.Add(objShare.ConfigTbl.Rows(intCount).Item("ApplicationFee"))
                lvItem.SubItems.Add(objShare.ConfigTbl.Rows(intCount).Item("BuildingFund"))
                lvItem.SubItems.Add(Format(objShare.ConfigTbl.Rows(intCount).Item("Date"), "dd-MMM-yyyy"))

                slNo += 1
                intCount += 1
            End While
        End If
    End Function

#End Region

#Region "Events"

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub btnConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfig.Click

        Try
            If fnSetData() Then
                If objShare.fnCheckConfig Then
                    If objShare.fnUpdateShareConfig Then
                        MsgBox("Amount updated successfully", MsgBoxStyle.Information, "Shares Configuration")
                    End If
                Else
                    If objShare.fnInsertShareConfig Then
                        MsgBox("Amount configured successfully", MsgBoxStyle.Information, "Shares Configuration")
                    End If

                End If
            End If
            Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub frmShareConfiguration_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpDate.Value = Date.Now.Date
        fnLoadConfig()
    End Sub

    Public Sub frmShareConfiguration_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        fnLoadConfig()
    End Sub

    Private Sub lvShareDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If lvShareDetail.SelectedItems.Count > 0 Then
            txtAmtPerShare.Text = lvShareDetail.SelectedItems(0).SubItems("2").Text
            If lvShareDetail.SelectedItems(0).SubItems("1").Text = "SCA" Then
                cmbShareType.SelectedItem = "Share Capital A"
            ElseIf lvShareDetail.SelectedItems(0).SubItems("1").Text = "SCB" Then
                cmbShareType.SelectedItem = "Share Capital B"
            Else
                cmbShareType.SelectedItem = "Souharda Risk Fund"
            End If
            dtpDate.Value = lvShareDetail.SelectedItems(0).SubItems("3").Text
        End If
    End Sub

    Private Sub rdBFFixed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdBFFixed.CheckedChanged
        If rdBFFixed.Checked = True Then
            txtBuildingFund.Enabled = True
            ' txtBuildingFund.Focus()
        Else
            txtBuildingFund.Enabled = False
        End If
    End Sub

    Private Sub rdBFVariable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdBFVariable.CheckedChanged
        If rdBFVariable.Checked = True Then
            txtBF.Visible = True
            lblBuildingFund.Visible = True
            ' txtBF.Focus()
        Else
            txtBF.Visible = False
            lblBuildingFund.Visible = False
        End If
    End Sub

    Private Sub txtBF_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBF.TextChanged
        If txtBF.Text <> "" Then
            txtBuildingFund.Text = (Val(txtAmtPerShare.Text) * Val(txtBF.Text)) / 100
        Else
            txtBuildingFund.Text = ""
        End If
    End Sub

    Private Sub rdSEFFixed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdSEFFixed.CheckedChanged
        If rdSEFFixed.Checked = True Then
            txtShareEntryFee.Enabled = True
            ' txtShareEntryFee.Focus()
        Else
            txtShareEntryFee.Enabled = False
        End If
    End Sub

    Private Sub rdSEFVariable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdSEFVariable.CheckedChanged
        If rdSEFVariable.Checked = True Then
            txtSEF.Visible = True
            lblShareEntryFee.Visible = True
            ' txtSEF.Focus()
        Else
            txtSEF.Visible = False
            lblShareEntryFee.Visible = False
        End If

    End Sub

    Private Sub txtSEF_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSEF.TextChanged
        If txtSEF.Text <> "" Then
            txtShareEntryFee.Text = (Val(txtAmtPerShare.Text) * Val(txtSEF.Text)) / 100
        Else
            txtShareEntryFee.Text = ""
        End If

    End Sub

    Private Sub rdSFFixed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdSFFixed.CheckedChanged
        If rdSFFixed.Checked = True Then
            txtShareFee.Enabled = True
            ' txtShareFee.Focus()
        Else
            txtShareFee.Enabled = False
        End If
    End Sub

    Private Sub rdSFVariable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdSFVariable.CheckedChanged
        If rdSFVariable.Checked = True Then
            txtSF.Visible = True
            lblShareFee.Visible = True
            ' txtSF.Focus()
        Else
            txtSF.Visible = False
            lblShareFee.Visible = False
        End If
    End Sub

    Private Sub txtSF_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSF.TextChanged
        If txtSF.Text <> "" Then
            txtShareFee.Text = (Val(txtAmtPerShare.Text) * Val(txtSF.Text)) / 100
        Else
            txtShareFee.Text = ""
        End If
    End Sub

    Private Sub lvShareDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvShareDetail.DoubleClick
        If lvShareDetail.SelectedItems.Count > 0 Then

            If lvShareDetail.SelectedItems(0).SubItems(1).Text = "SCA" Then
                cmbShareType.SelectedItem = "Share Capital A"
            ElseIf lvShareDetail.SelectedItems(0).SubItems(1).Text = "SCB" Then
                cmbShareType.SelectedItem = "Share Capital B"
            Else
                cmbShareType.SelectedItem = "Souharda Risk Fund"
            End If
            txtAmtPerShare.Text = lvShareDetail.SelectedItems(0).SubItems(2).Text
            txtShareFee.Text = lvShareDetail.SelectedItems(0).SubItems(3).Text
            txtShareEntryFee.Text = lvShareDetail.SelectedItems(0).SubItems(4).Text
            txtApplicationFee.Text = lvShareDetail.SelectedItems(0).SubItems(5).Text
            txtBuildingFund.Text = lvShareDetail.SelectedItems(0).SubItems(6).Text
        End If
    End Sub

#End Region


  

    Private Sub rdAFFixed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdAFFixed.CheckedChanged
        If rdAFFixed.Checked = True Then
            txtApplicationFee.Enabled = True
            txtApplicationFee.Focus()
        Else
            txtApplicationFee.Enabled = False
        End If
    End Sub

    Private Sub rdAFVariable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdAFVariable.CheckedChanged
        If rdAFVariable.Checked = True Then
            txtAF.Visible = True
            'lblBuildingFund.Visible = True
            txtAF.Focus()
        Else
            txtAF.Visible = False
            'lblBuildingFund.Visible = False
        End If
    End Sub

    Private Sub txtAF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAF.TextChanged
        If txtAF.Text <> "" Then
            txtApplicationFee.Text = (Val(txtAmtPerShare.Text) * Val(txtAF.Text)) / 100
        Else
            txtApplicationFee.Text = ""
        End If
    End Sub
End Class
