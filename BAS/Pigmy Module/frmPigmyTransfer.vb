''Imports System.IO

Public Class frmPigmyTransfer
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPGName As BankControls.TextControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As BankControls.TextControl
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPGAccNo As BankControls.TextControl
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents txtRefNo As BankControls.NumericControl
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents dtpDepositDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents btnDeposit As BankControls.NewButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblBNND As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbAGNo As MTGCComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAGName As BankControls.TextControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPigmyTransfer))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPGName = New BankControls.TextControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNarration = New BankControls.TextControl
        Me.txtAmount = New BankControls.NumericControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPGAccNo = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.txtRefNo = New BankControls.NumericControl
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblBalance = New System.Windows.Forms.Label
        Me.dtpDepositDate = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnCancel = New BankControls.NewButton
        Me.btnDeposit = New BankControls.NewButton
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblBNND = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbAGNo = New MTGCComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtAGName = New BankControls.TextControl
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtPGName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNarration)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPGAccNo)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtRefNo)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 240)
        Me.GroupBox1.TabIndex = 108
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Holder Details"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 18)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Reference No. :"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Name :"
        '
        'txtPGName
        '
        Me.txtPGName.AlphaNumeric = False
        Me.txtPGName.AutoSize = False
        Me.txtPGName.BlankSpace = False
        Me.txtPGName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPGName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPGName.Location = New System.Drawing.Point(128, 64)
        Me.txtPGName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPGName.Mandatory = False
        Me.txtPGName.Name = "txtPGName"
        Me.txtPGName.Size = New System.Drawing.Size(168, 20)
        Me.txtPGName.SpecialChar = False
        Me.txtPGName.TabIndex = 32
        Me.txtPGName.Text = ""
        '
        'Label3
        '
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Narration :"
        '
        'txtNarration
        '
        Me.txtNarration.AlphaNumeric = True
        Me.txtNarration.BlankSpace = True
        Me.txtNarration.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNarration.Location = New System.Drawing.Point(128, 160)
        Me.txtNarration.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNarration.Mandatory = False
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarration.Size = New System.Drawing.Size(200, 64)
        Me.txtNarration.SpecialChar = False
        Me.txtNarration.TabIndex = 5
        Me.txtNarration.Text = ""
        '
        'txtAmount
        '
        Me.txtAmount.AfterDecimal = 2
        Me.txtAmount.BeforeDecimal = 7
        Me.txtAmount.Enabled = False
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmount.Location = New System.Drawing.Point(128, 96)
        Me.txtAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAmount.MaxValue = 0
        Me.txtAmount.MinValue = 0
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(168, 23)
        Me.txtAmount.TabIndex = 3
        Me.txtAmount.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "BNNC :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "AccountNo. :"
        '
        'txtPGAccNo
        '
        Me.txtPGAccNo.AlphaNumeric = True
        Me.txtPGAccNo.BlankSpace = False
        Me.txtPGAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPGAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPGAccNo.Location = New System.Drawing.Point(128, 32)
        Me.txtPGAccNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPGAccNo.Mandatory = False
        Me.txtPGAccNo.MaxLength = 10
        Me.txtPGAccNo.Name = "txtPGAccNo"
        Me.txtPGAccNo.Size = New System.Drawing.Size(120, 23)
        Me.txtPGAccNo.SpecialChar = False
        Me.txtPGAccNo.TabIndex = 1
        Me.txtPGAccNo.Text = "BNN"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.Beige
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(256, 32)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'txtRefNo
        '
        Me.txtRefNo.AfterDecimal = 2
        Me.txtRefNo.BeforeDecimal = 7
        Me.txtRefNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRefNo.Location = New System.Drawing.Point(128, 128)
        Me.txtRefNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRefNo.MaxValue = 0
        Me.txtRefNo.MinValue = 0
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(168, 23)
        Me.txtRefNo.TabIndex = 4
        Me.txtRefNo.Text = ""
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(375, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 24)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = "BNNC :"
        '
        'lblBalance
        '
        Me.lblBalance.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(439, 48)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(112, 24)
        Me.lblBalance.TabIndex = 111
        '
        'dtpDepositDate
        '
        Me.dtpDepositDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDepositDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDepositDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDepositDate.Location = New System.Drawing.Point(439, 16)
        Me.dtpDepositDate.Name = "dtpDepositDate"
        Me.dtpDepositDate.Size = New System.Drawing.Size(121, 23)
        Me.dtpDepositDate.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(375, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 19)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "Date :"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.GotFocusColour = System.Drawing.Color.Beige
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(536, 208)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 40)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "&Cancel"
        '
        'btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposit.GotFocusColour = System.Drawing.Color.Beige
        Me.btnDeposit.Image = CType(resources.GetObject("btnDeposit.Image"), System.Drawing.Image)
        Me.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeposit.Location = New System.Drawing.Point(408, 208)
        Me.btnDeposit.LostFocusColour = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(104, 40)
        Me.btnDeposit.TabIndex = 9
        Me.btnDeposit.Text = "&Deposit"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(376, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 24)
        Me.Label10.TabIndex = 114
        Me.Label10.Text = "BNND :"
        '
        'lblBNND
        '
        Me.lblBNND.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBNND.Location = New System.Drawing.Point(440, 88)
        Me.lblBNND.Name = "lblBNND"
        Me.lblBNND.Size = New System.Drawing.Size(112, 24)
        Me.lblBNND.TabIndex = 113
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbAGNo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtAGName)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(376, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 96)
        Me.GroupBox2.TabIndex = 115
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Agent Details"
        '
        'cmbAGNo
        '
        Me.cmbAGNo.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.cmbAGNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbAGNo.ColumnNum = 2
        Me.cmbAGNo.ColumnWidth = "200;50"
        Me.cmbAGNo.DisplayMember = "Text"
        Me.cmbAGNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbAGNo.DropDownArrowBackColor = System.Drawing.Color.FromArgb(CType(136, Byte), CType(169, Byte), CType(223, Byte))
        Me.cmbAGNo.DropDownBackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(210, Byte), CType(238, Byte))
        Me.cmbAGNo.DropDownForeColor = System.Drawing.Color.Black
        Me.cmbAGNo.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
        Me.cmbAGNo.DropDownWidth = 270
        Me.cmbAGNo.Enabled = False
        Me.cmbAGNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAGNo.GridLineColor = System.Drawing.Color.LightGray
        Me.cmbAGNo.GridLineHorizontal = False
        Me.cmbAGNo.GridLineVertical = False
        Me.cmbAGNo.HighlightBorderColor = System.Drawing.Color.Blue
        Me.cmbAGNo.HighlightBorderOnMouseEvents = True
        Me.cmbAGNo.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cmbAGNo.Location = New System.Drawing.Point(112, 24)
        Me.cmbAGNo.ManagingFastMouseMoving = True
        Me.cmbAGNo.ManagingFastMouseMovingInterval = 30
        Me.cmbAGNo.Name = "cmbAGNo"
        Me.cmbAGNo.NormalBorderColor = System.Drawing.Color.Black
        Me.cmbAGNo.Size = New System.Drawing.Size(160, 24)
        Me.cmbAGNo.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 19)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Name"
        '
        'txtAGName
        '
        Me.txtAGName.AlphaNumeric = False
        Me.txtAGName.AutoSize = False
        Me.txtAGName.BlankSpace = False
        Me.txtAGName.Enabled = False
        Me.txtAGName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAGName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAGName.Location = New System.Drawing.Point(112, 56)
        Me.txtAGName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAGName.Mandatory = False
        Me.txtAGName.Name = "txtAGName"
        Me.txtAGName.Size = New System.Drawing.Size(160, 20)
        Me.txtAGName.SpecialChar = False
        Me.txtAGName.TabIndex = 8
        Me.txtAGName.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 19)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = " AccountNo"
        '
        'frmPigmyTransfer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(666, 266)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblBNND)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.dtpDepositDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDeposit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPigmyTransfer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BNN Deposit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Varaibles"

    Dim objAgent As New clsPigmyAccount
    Public strAccNo As String
    Public strName As String
    Dim objPGAccount As New clsPigmyAccount

#End Region

#Region "Functions"

    Public Function fnCheck() As Boolean

        If txtPGAccNo.Text = String.Empty Then
            MsgBox("Please select the agent ID", MsgBoxStyle.Information)
            txtPGAccNo.Focus()
            Return False
        ElseIf txtPGName.Text = String.Empty Then
            MsgBox("Please enter the agents name", MsgBoxStyle.Information)
            txtPGName.Focus()
            Return False
        ElseIf txtAmount.Text = String.Empty Then
            MsgBox("Please enter the amount to deposit", MsgBoxStyle.Information)
            txtAmount.Focus()
            Return False
        ElseIf Val(txtAmount.Text) = 0 Then
            MsgBox("BNNC amount is zero no transaction can be done", MsgBoxStyle.Information)
            txtAmount.Focus()
            Return False
        ElseIf txtPGAccNo.Text = String.Empty Then
            MsgBox("Please select the agents account no", MsgBoxStyle.Information)
            cmbAGNo.Focus()
            Return False
        ElseIf txtPGName.Text = String.Empty Then
            MsgBox("Please enter the agents name", MsgBoxStyle.Information)
            cmbAGNo.Focus()
            Return False
        ElseIf txtRefNo.Text = String.Empty Then
            MsgBox("Reference no cannot be blank", MsgBoxStyle.Exclamation)
            txtRefNo.Focus()
        Else
            Return True

        End If

    End Function

    Public Function fnCheckRefNo() As Boolean

        If objAgent.fnCheckRefNo(txtRefNo.Text) Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnSetData() As Boolean

        objAgent.AgnetNo = cmbAGNo.SelectedItem.col1
        objAgent.Amount = txtAmount.Text
        objAgent.Reference = txtRefNo.Text
        objAgent.TransDate = dtpDepositDate.Value
        objAgent.PGNo = txtPGAccNo.Text
        objAgent.Narration = txtNarration.Text
        objAgent.PGName = txtPGName.Text

        Return True

    End Function

    Public Function fnClear()

        ' txtAGName.Text = ""
        txtAmount.Text = ""
        txtRefNo.Text = ""
        'txtPGAccNo.Text = "BNN"
        txtNarration.Text = ""
        ' txtPGName.Text = ""

    End Function

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entery
        objPGAccount.frnPGCollectionWithdraw(Trim(txtPGAccNo.Text), dtpDepositDate.Value, "BNND by account  " & txtPGAccNo.Text, 0, Trim(txtAmount.Text), Trim(txtAmount.Text), txtRefNo.Text, lngVoucherNo, "Cash", 0, cmbAGNo.SelectedItem.col1, objTrans)


        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtPGAccNo.Text, txtRefNo.Text, dtpDepositDate.Value, txtAmount.Text, "BNND by account " & txtPGAccNo.Text, lngSlNo, "Y", objTrans)

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 2, txtPGAccNo.Text, dtpDepositDate.Value, "BNND by account " & txtPGAccNo.Text, "To", 123, 0, Val(txtAmount.Text), 1, "Y", objTrans)

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 2, txtPGAccNo.Text, dtpDepositDate.Value, "BNND by account " & txtPGAccNo.Text, "By", 28, Val(txtAmount.Text), 0, 2, "Y", objTrans)

        Return True

    End Function

    Public Function fnGetBalance()

        If objPGAccount.fnGetBalance(txtPGAccNo.Text) Then

            lblBalance.Text = objPGAccount.PimgyBalancetable.Rows(0).Item("AvailCollection")
            lblBNND.Text = objPGAccount.PimgyBalancetable.Rows(0).Item("AvailDeposit")
            txtAmount.Text = objPGAccount.PimgyBalancetable.Rows(0).Item("AvailCollection")
            cmbAGNo.Text = objPGAccount.PimgyBalancetable.Rows(0).Item("AgentNo")
        End If

    End Function

#End Region

#Region "Procedure"

    Sub sbGetAgents()

        Dim objClsAgets As New clsPigmyAgent
        Dim dtAgents As DataTable
        If objClsAgets.fnGetAgents() Then

            dtAgents = objClsAgets.getAgentsTable
            cmbAGNo.Items.Clear()
            cmbAGNo.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
            cmbAGNo.SourceDataString = New String(1) {"AgentID", "AgentName"}
            cmbAGNo.SourceDataTable = dtAgents

        End If

    End Sub

    Sub sbLoadData()

        'If objAgent.fnGetData(txtPGAccNo.Text) Then
        'txtPGName.Text = objAgent.PigmyAccTable.Rows(0).Item("   


        'End If

    End Sub

#End Region

#Region "Events"

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        '''''Dim objfrmPigmyCust As New frmPGCust
        '''''objfrmPigmyCust.strPGNo = ""
        '''''objfrmPigmyCust.ShowDialog(Me)
        '''''If objfrmPigmyCust.strPGNo <> "" Then
        '''''    txtPGAccNo.Text = objfrmPigmyCust.strPGNo
        '''''    txtPGName.Text = objfrmPigmyCust.strPGName
        '''''    ''''' sbLoadFD()
        '''''    txtPGAccNo.Focus()

        '''''End If
        '''''objfrmPigmyCust.Dispose()

        Dim objPGAccCust As New frmPGCust
        objPGAccCust.strPGNo = String.Empty
        objPGAccCust.ShowDialog(Me)
        If objPGAccCust.strPGNo <> String.Empty Then
            txtPGAccNo.Text = objPGAccCust.strPGNo
            txtPGName.Text = objPGAccCust.strPGName
            ''sbLoadRDAccDetails()
            fnGetBalance()
        End If

        objPGAccCust.Dispose()

    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objfrmAgents As New frmAGAccSearch
        objfrmAgents.ShowDialog()
    End Sub

    Private Sub frmPigmyDeposit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpDepositDate.Value = Date.Now
        txtPGAccNo.Text = strAccNo
        txtPGName.Text = strName
        sbGetAgents()
        fnGetBalance()
    End Sub

    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        Dim objTrans As IDbTransaction

        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnCheckRefNo() = False Then
                    If fnSetData() Then
                        'If objAgent.fnInsertData Then
                        fnGenerateVoucher(objTrans)
                        fnLogEntry(pbUserId, "Deposit by " & txtPGAccNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction deposit", objTrans)
                        objTrans.Commit()
                        If MsgBox("Transaction completed successfully,do u want to do more transaction", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            fnClear()
                            fnGetBalance()
                        Else
                            Me.Close()
                        End If
                    Else
                        MsgBox("Transaction cannot be completed,due to internal error", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Reference no already exist,please try other reference no", MsgBoxStyle.Exclamation)
                    txtRefNo.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try

    End Sub

#End Region

    Private Sub cmbAGNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAGNo.SelectedIndexChanged

        txtAGName.Text = cmbAGNo.SelectedItem.col2

    End Sub

    Private Sub txtPGAccNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPGAccNo.TextChanged

        If txtPGAccNo.Text.StartsWith("BNN") = False Then
            txtPGAccNo.Undo()
            txtPGAccNo.ClearUndo()
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub


End Class
