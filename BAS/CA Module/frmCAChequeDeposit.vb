Public Class frmCAChequeDeposit
    Inherits System.Windows.Forms.Form

#Region "Form Global Functions"
    Dim objCurrentAccount As New clsCurrentAccount
#End Region

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
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents txtChequeAmount As BankControls.NumericControl
    Friend WithEvents dtpChequeDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBankName As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBranchName As BankControls.TextControl
    Friend WithEvents txtChequeNo As BankControls.TextControl
    Friend WithEvents dtpDepositdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRemarks As BankControls.TextControl
    Friend WithEvents txtAccNo As BankControls.TextControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCAChequeDeposit))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSearch = New BankControls.NewButton
        Me.btnAdd = New BankControls.NewButton
        Me.btnOk = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.txtChequeAmount = New BankControls.NumericControl
        Me.dtpChequeDate = New System.Windows.Forms.DateTimePicker
        Me.txtBankName = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtBranchName = New BankControls.TextControl
        Me.txtChequeNo = New BankControls.TextControl
        Me.dtpDepositdate = New System.Windows.Forms.DateTimePicker
        Me.txtRemarks = New BankControls.TextControl
        Me.txtAccNo = New BankControls.TextControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.btnOk)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.txtChequeAmount)
        Me.GroupBox1.Controls.Add(Me.dtpChequeDate)
        Me.GroupBox1.Controls.Add(Me.txtBankName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtBranchName)
        Me.GroupBox1.Controls.Add(Me.txtChequeNo)
        Me.GroupBox1.Controls.Add(Me.dtpDepositdate)
        Me.GroupBox1.Controls.Add(Me.txtRemarks)
        Me.GroupBox1.Controls.Add(Me.txtAccNo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 280)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(120, Byte), CType(128, Byte), CType(171, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(280, 24)
        Me.btnSearch.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(128, 224)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 40)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "&Add "
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(376, 224)
        Me.btnOk.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(96, 40)
        Me.btnOk.TabIndex = 11
        Me.btnOk.Text = "O&k"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(480, 224)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "&Cancel"
        '
        'txtChequeAmount
        '
        Me.txtChequeAmount.AfterDecimal = 0
        Me.txtChequeAmount.BeforeDecimal = 8
        Me.txtChequeAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtChequeAmount.Location = New System.Drawing.Point(136, 120)
        Me.txtChequeAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtChequeAmount.MaxLength = 10
        Me.txtChequeAmount.MaxValue = 0
        Me.txtChequeAmount.MinValue = 0
        Me.txtChequeAmount.Name = "txtChequeAmount"
        Me.txtChequeAmount.Size = New System.Drawing.Size(136, 23)
        Me.txtChequeAmount.TabIndex = 8
        Me.txtChequeAmount.Text = ""
        Me.txtChequeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpChequeDate
        '
        Me.dtpChequeDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpChequeDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpChequeDate.Location = New System.Drawing.Point(424, 120)
        Me.dtpChequeDate.MaxDate = New Date(9998, 11, 17, 0, 0, 0, 0)
        Me.dtpChequeDate.Name = "dtpChequeDate"
        Me.dtpChequeDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpChequeDate.TabIndex = 9
        Me.dtpChequeDate.Value = New Date(2008, 2, 13, 0, 0, 0, 0)
        '
        'txtBankName
        '
        Me.txtBankName.AlphaNumeric = True
        Me.txtBankName.BlankSpace = True
        Me.txtBankName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBankName.Location = New System.Drawing.Point(424, 56)
        Me.txtBankName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBankName.Mandatory = False
        Me.txtBankName.MaxLength = 35
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(200, 23)
        Me.txtBankName.SpecialChar = False
        Me.txtBankName.TabIndex = 5
        Me.txtBankName.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(312, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 19)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Bank Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(312, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 19)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Branch Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(312, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 19)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "Cheque Date :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 19)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "Cheque No :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 19)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "Account No :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 19)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "Deposit Date :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 19)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Cheque Amount :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(56, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 19)
        Me.Label10.TabIndex = 118
        Me.Label10.Text = "Remarks:"
        '
        'txtBranchName
        '
        Me.txtBranchName.AlphaNumeric = True
        Me.txtBranchName.BlankSpace = True
        Me.txtBranchName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBranchName.Location = New System.Drawing.Point(424, 88)
        Me.txtBranchName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBranchName.Mandatory = False
        Me.txtBranchName.MaxLength = 35
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Size = New System.Drawing.Size(200, 23)
        Me.txtBranchName.SpecialChar = False
        Me.txtBranchName.TabIndex = 7
        Me.txtBranchName.Text = ""
        '
        'txtChequeNo
        '
        Me.txtChequeNo.AlphaNumeric = True
        Me.txtChequeNo.BlankSpace = False
        Me.txtChequeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtChequeNo.Location = New System.Drawing.Point(136, 56)
        Me.txtChequeNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtChequeNo.Mandatory = False
        Me.txtChequeNo.MaxLength = 10
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.Size = New System.Drawing.Size(136, 23)
        Me.txtChequeNo.SpecialChar = False
        Me.txtChequeNo.TabIndex = 4
        Me.txtChequeNo.Text = ""
        '
        'dtpDepositdate
        '
        Me.dtpDepositdate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDepositdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDepositdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDepositdate.Location = New System.Drawing.Point(136, 88)
        Me.dtpDepositdate.MaxDate = New Date(9998, 11, 17, 0, 0, 0, 0)
        Me.dtpDepositdate.Name = "dtpDepositdate"
        Me.dtpDepositdate.Size = New System.Drawing.Size(136, 23)
        Me.dtpDepositdate.TabIndex = 6
        Me.dtpDepositdate.Value = New Date(2008, 2, 13, 0, 0, 0, 0)
        '
        'txtRemarks
        '
        Me.txtRemarks.AlphaNumeric = True
        Me.txtRemarks.BlankSpace = True
        Me.txtRemarks.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemarks.Location = New System.Drawing.Point(136, 152)
        Me.txtRemarks.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRemarks.Mandatory = False
        Me.txtRemarks.MaxLength = 200
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(464, 64)
        Me.txtRemarks.SpecialChar = False
        Me.txtRemarks.TabIndex = 10
        Me.txtRemarks.Text = ""
        '
        'txtAccNo
        '
        Me.txtAccNo.AlphaNumeric = True
        Me.txtAccNo.BlankSpace = False
        Me.txtAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccNo.Location = New System.Drawing.Point(136, 24)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.MaxLength = 10
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.Size = New System.Drawing.Size(136, 23)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 1
        Me.txtAccNo.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(312, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 19)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = " Name :"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.ControlLightLight
        Me.txtName.Location = New System.Drawing.Point(424, 24)
        Me.txtName.LostFocusColour = System.Drawing.Color.White
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 35
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(200, 23)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 3
        Me.txtName.Text = ""
        '
        'frmCAChequeDeposit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(658, 287)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCAChequeDeposit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Current Account Cheque  Deposit"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmCAChequeDeposit
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmCAChequeDeposit
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmCAChequeDeposit
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmCAChequeDeposit)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Global Variables"
    Dim dblBalence As Double
    Dim dblAccountno As String
    Dim status As String
#End Region

#Region "Sub Routines"

    Sub sbLoadDetails()
        If Trim(txtAccNo.Text <> String.Empty) Then
            If objCurrentAccount.fnGetCAccountDetails(Trim(txtAccNo.Text)) Then
                txtAccNo.Text = objCurrentAccount.CAAccTable.Rows(0).Item("CAccountNo")
                txtName.Text = objCurrentAccount.CAAccTable.Rows(0).Item("Name")
                txtAccNo.ReadOnly = True
                txtName.ReadOnly = True
            Else
                MsgBox("accountno doesn't exist please see account list", MsgBoxStyle.Exclamation)
                txtAccNo.Focus()
                txtAccNo.SelectAll()
            End If
        End If
    End Sub

    Sub sbclear()
        txtBankName.ResetText()
        txtBranchName.ResetText()
        txtRemarks.ResetText()
        txtChequeAmount.ResetText()
        txtChequeNo.ResetText()
        txtAccNo.ReadOnly = False
        txtName.ReadOnly = False
    End Sub

#End Region

#Region "Functions"

    Function fnCheck() As Boolean
        If Trim(txtAccNo.Text) = String.Empty Then
            MsgBox("Enter accountno", MsgBoxStyle.Exclamation)
            txtAccNo.Focus()
            Return False
        ElseIf Trim(txtChequeNo.Text) = String.Empty Then
            MsgBox("Enter chequeno", MsgBoxStyle.Exclamation)
            txtChequeNo.Focus()
            Return False
        ElseIf Trim(txtBankName.Text) = String.Empty Then
            MsgBox("Enter bank name", MsgBoxStyle.Exclamation)
            txtBankName.Focus()
            Return False
        ElseIf Trim(txtChequeAmount.Text) = String.Empty Then
            MsgBox("Enter cheque amount", MsgBoxStyle.Exclamation)
            txtChequeAmount.Focus()
            Return False
        Else
            Return True
        End If
    End Function
    Function fnSBTransaction(ByVal objTrans As IDbTransaction) As Boolean

        Dim strNarration As String = "Cheque Deposited By " & txtAccNo.Text & " Narration:" & txtRemarks.Text

        'Transaction Entry
        Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,VoucherNo,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDepositdate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','0','" & Trim(txtChequeAmount.Text) & "','0',sum(Deposit)-sum(withdraw),'0','0','0','Cheque','" & Trim(txtChequeNo.Text) & "' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
        fnExecuteNonQuery(strsql, objTrans)

        Return True
    End Function

    Function fnSetData() As Boolean
        objCurrentAccount.BankName = txtBankName.Text
        objCurrentAccount.BranchName = txtBranchName.Text
        objCurrentAccount.ChequeDate = dtpChequeDate.Value
        objCurrentAccount.ChequeNo = txtChequeNo.Text
        objCurrentAccount.ChequeDepositDate = dtpDepositdate.Value

        objCurrentAccount.CurAccountNo = txtAccNo.Text
        objCurrentAccount.ChequeAmount = txtChequeAmount.Text
        objCurrentAccount.ChequeStatus = "Pending"
        objCurrentAccount.Remarks = txtRemarks.Text

        Return True
    End Function

#End Region

    Private Sub frmCAChequeDeposit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpChequeDate.Value = Date.Now
        dtpDepositdate.Value = Date.Now
        If Trim(txtAccNo.Text) <> "" Then
            sbLoadDetails()
        End If
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim objTrans As IDbTransaction
        objTrans = fnGetTransaction()
        Try
            If fnCheck() Then
                If fnSetData() Then
                    If objCurrentAccount.fnGetDepositedCheque(Trim(txtChequeNo.Text)) Or objCurrentAccount.fnCheckChequeLeafNo(Trim(txtChequeNo.Text)) Then
                        MsgBox("Cheque number is already present in database", MsgBoxStyle.Information)
                        txtChequeNo.Focus()
                    Else

                        If fnSBTransaction(objTrans) Then
                            If objCurrentAccount.fnAddDepositedCheque(objTrans) = True Then
                                fnLogEntry(pbUserId, "Cheque deposited by " & txtAccNo.Text & " Amount " & txtChequeAmount.Text, Date.Now, "Cheque deposited", objTrans)
                                objTrans.Commit()
                                If MsgBox("Cheque deposited sucessfully, do you want deposit another cheque ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                    sbclear()
                                    txtChequeNo.Focus()
                                Else
                                    Me.Close()
                                End If
                            Else
                                MsgBox("Cheque deposition failed due to internal error", MsgBoxStyle.Exclamation)
                            End If
                        Else
                            MsgBox("Cheque deposition failed due to internal error", MsgBoxStyle.Exclamation)
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim objCAccSearch As New frmCAccSearch
        objCAccSearch.strCAccountNo = String.Empty
        objCAccSearch.ShowDialog(Me)
        If objCAccSearch.strCAccountNo <> String.Empty Then
            txtAccNo.Text = objCAccSearch.strCAccountNo
            txtName.Text = objCAccSearch.strCAccountName
            txtAccNo.ReadOnly = True
            txtName.ReadOnly = True
        End If
        objCAccSearch.Dispose()
    End Sub

    Private Sub txtAccNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccNo.LostFocus
        AutoLoad()
        If txtAccNo.Text <> "" Then
            objCurrentAccount.fnGetCAccountDetails(txtAccNo.Text)
            txtName.Text = objCurrentAccount.CAAccTable.Rows(0).Item("Name")
        End If
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
End Class
