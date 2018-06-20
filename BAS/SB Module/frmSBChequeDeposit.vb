Public Class frmSBChequeDeposit
    Inherits System.Windows.Forms.Form

#Region "Form Global Functions"
    Dim objSavingsBank As New clsSavingsBank
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents txtBankName As BankControls.TextControl
    Friend WithEvents dtpChequeDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDepositdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtChequeAmount As BankControls.NumericControl
    Friend WithEvents txtRemarks As BankControls.TextControl
    Friend WithEvents txtBranchName As BankControls.TextControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents txtAccountNo As BankControls.TextControl
    Friend WithEvents txtChequeNo As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSBChequeDeposit))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtBankName = New BankControls.TextControl
        Me.txtBranchName = New BankControls.TextControl
        Me.dtpChequeDate = New System.Windows.Forms.DateTimePicker
        Me.dtpDepositdate = New System.Windows.Forms.DateTimePicker
        Me.txtChequeAmount = New BankControls.NumericControl
        Me.txtRemarks = New BankControls.TextControl
        Me.btnAdd = New BankControls.NewButton
        Me.btnOk = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.btnSearch = New BankControls.NewButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.txtAccountNo = New BankControls.TextControl
        Me.txtChequeNo = New BankControls.NumericControl
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(304, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 19)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Bank Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(304, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 19)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Branch Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 19)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Cheque Date :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 19)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Cheque No. :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 19)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Account No. :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 19)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Deposit Date :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 19)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Cheque Amount :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 19)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Remarks :"
        '
        'txtBankName
        '
        Me.txtBankName.AlphaNumeric = True
        Me.txtBankName.BlankSpace = True
        Me.txtBankName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBankName.Location = New System.Drawing.Point(416, 56)
        Me.txtBankName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBankName.Mandatory = False
        Me.txtBankName.MaxLength = 30
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(200, 23)
        Me.txtBankName.SpecialChar = True
        Me.txtBankName.TabIndex = 7
        Me.txtBankName.Text = ""
        '
        'txtBranchName
        '
        Me.txtBranchName.AlphaNumeric = True
        Me.txtBranchName.BlankSpace = True
        Me.txtBranchName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBranchName.Location = New System.Drawing.Point(416, 88)
        Me.txtBranchName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBranchName.Mandatory = False
        Me.txtBranchName.MaxLength = 30
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Size = New System.Drawing.Size(200, 23)
        Me.txtBranchName.SpecialChar = True
        Me.txtBranchName.TabIndex = 8
        Me.txtBranchName.Text = ""
        '
        'dtpChequeDate
        '
        Me.dtpChequeDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpChequeDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpChequeDate.Location = New System.Drawing.Point(416, 120)
        Me.dtpChequeDate.MaxDate = New Date(9998, 11, 17, 0, 0, 0, 0)
        Me.dtpChequeDate.Name = "dtpChequeDate"
        Me.dtpChequeDate.Size = New System.Drawing.Size(144, 23)
        Me.dtpChequeDate.TabIndex = 9
        Me.dtpChequeDate.Value = New Date(2007, 10, 12, 0, 0, 0, 0)
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
        Me.dtpDepositdate.TabIndex = 3
        Me.dtpDepositdate.Value = New Date(2007, 10, 12, 0, 0, 0, 0)
        '
        'txtChequeAmount
        '
        Me.txtChequeAmount.AfterDecimal = 2
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
        Me.txtChequeAmount.TabIndex = 4
        Me.txtChequeAmount.Text = ""
        Me.txtChequeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.txtRemarks.MaxLength = 100
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(472, 64)
        Me.txtRemarks.SpecialChar = True
        Me.txtRemarks.TabIndex = 5
        Me.txtRemarks.Text = ""
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(128, 232)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(96, 40)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "&Refresh"
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
        Me.btnOk.Location = New System.Drawing.Point(400, 232)
        Me.btnOk.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(96, 40)
        Me.btnOk.TabIndex = 10
        Me.btnOk.Text = "&Save"
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
        Me.btnCancel.Location = New System.Drawing.Point(504, 232)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "&Cancel"
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
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(304, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 19)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = " Name :"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(416, 19)
        Me.txtName.LostFocusColour = System.Drawing.Color.White
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 35
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(200, 23)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 6
        Me.txtName.TabStop = False
        Me.txtName.Text = ""
        '
        'txtAccountNo
        '
        Me.txtAccountNo.AlphaNumeric = True
        Me.txtAccountNo.BlankSpace = True
        Me.txtAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccountNo.Location = New System.Drawing.Point(136, 24)
        Me.txtAccountNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAccountNo.Mandatory = False
        Me.txtAccountNo.MaxLength = 10
        Me.txtAccountNo.Name = "txtAccountNo"
        Me.txtAccountNo.Size = New System.Drawing.Size(136, 23)
        Me.txtAccountNo.SpecialChar = False
        Me.txtAccountNo.TabIndex = 1
        Me.txtAccountNo.Text = ""
        '
        'txtChequeNo
        '
        Me.txtChequeNo.AfterDecimal = 0
        Me.txtChequeNo.BeforeDecimal = 7
        Me.txtChequeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtChequeNo.Location = New System.Drawing.Point(136, 56)
        Me.txtChequeNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtChequeNo.MaxLength = 10
        Me.txtChequeNo.MaxValue = 0
        Me.txtChequeNo.MinValue = 0
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.Size = New System.Drawing.Size(136, 23)
        Me.txtChequeNo.TabIndex = 2
        Me.txtChequeNo.Text = ""
        Me.txtChequeNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmSBChequeDeposit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(630, 283)
        Me.Controls.Add(Me.txtChequeNo)
        Me.Controls.Add(Me.txtAccountNo)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtChequeAmount)
        Me.Controls.Add(Me.dtpChequeDate)
        Me.Controls.Add(Me.txtBankName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtBranchName)
        Me.Controls.Add(Me.dtpDepositdate)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSBChequeDeposit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SB Cheque Deposit"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmSBChequeDeposit
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmSBChequeDeposit
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmSBChequeDeposit
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmSBChequeDeposit)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Global Variables"
    Public objAccountNo As String
#End Region

#Region "Sub Routines"

    Sub sbLoadDetails()
        If Trim(objAccountNo <> String.Empty) Then
            sbclear()
            If objSavingsBank.fnGetSBAccountDetails(Trim(objAccountNo)) Then
                If objSavingsBank.SBAccTable.Rows(0).Item("AccStatus") = "A" Then
                    txtAccountNo.Text = objSavingsBank.SBAccTable.Rows(0).Item("AccountNo")
                    txtName.Text = objSavingsBank.SBAccTable.Rows(0).Item("Name")
                Else
                    MsgBox("Account is already closed", MsgBoxStyle.Exclamation, "SB Module")
                    txtAccountNo.Focus()
                    txtAccountNo.SelectAll()
                End If
            Else
                MsgBox("AccountNo doesn't exist please see account list", MsgBoxStyle.Exclamation)
                txtAccountNo.Focus()
                txtAccountNo.SelectAll()
            End If
        End If
    End Sub

    Sub sbclear()
        txtBankName.ResetText()
        txtBranchName.ResetText()
        txtRemarks.ResetText()
        txtChequeAmount.ResetText()
        txtChequeNo.ResetText()
        txtAccountNo.ResetText()
        txtName.ResetText()
    End Sub

#End Region

#Region "Functions"

    Function fnCheck() As Boolean
        If Trim(txtAccountNo.Text) = String.Empty Then
            MsgBox("Enter accountNo", MsgBoxStyle.Information)
            txtAccountNo.Focus()
            Return False
        ElseIf Trim(txtChequeNo.Text) = String.Empty Then
            MsgBox("Enter chequeno", MsgBoxStyle.Information)
            txtChequeNo.Focus()
            Return False
        ElseIf Trim(txtChequeAmount.Text) = String.Empty Then
            MsgBox("Enter cheque amount", MsgBoxStyle.Information)
            txtChequeAmount.Focus()
            Return False
        ElseIf Trim(txtBankName.Text) = String.Empty Then
            MsgBox("Enter bank name", MsgBoxStyle.Information)
            txtBankName.Focus()
            Return False
        ElseIf Trim(txtBranchName.Text) = String.Empty Then
            MsgBox("Enter branch name", MsgBoxStyle.Information)
            txtBranchName.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Function fnSBTransaction(ByVal objTrnas As IDbTransaction) As Boolean

        Try
            Dim strNarration As String = "Cheque deposited " & "Cheque No " & txtChequeNo.Text & " Narration:" & txtRemarks.Text
            'Transaction Entry

            Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,RefNo,VoucherNo,type,chequeno) "
            strsql = strsql & " select '" & Trim(txtAccountNo.Text) & "','" & Format(dtpDepositdate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','0','" & Trim(txtChequeAmount.Text) & "','0',sum(Deposit)-sum(withdraw),'0','0','Cheque','" & Trim(txtChequeNo.Text) & "' from sbtransactiontbl where accountno='" & Trim(txtAccountNo.Text) & "' group by Accountno"
            fnExecuteNonQuery(strsql, objTrnas)

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try


    End Function

    Function fnSetData() As Boolean
        objSavingsBank.SBNo = Trim(txtAccountNo.Text)
        objSavingsBank.BankName = txtBankName.Text
        objSavingsBank.BranchName = txtBranchName.Text
        objSavingsBank.ChequeDate = dtpChequeDate.Value
        objSavingsBank.ChequeNo = txtChequeNo.Text
        objSavingsBank.ChequeDepositDate = dtpDepositdate.Value
        objSavingsBank.ChequeAmount = txtChequeAmount.Text
        objSavingsBank.ChequeStatus = "Pending"
        objSavingsBank.Remarks = txtRemarks.Text
        Return True
    End Function

#End Region

#Region "Events"

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim objSBAccSearch As New frmSBAccSearch
        objSBAccSearch.strSBAccountNo = String.Empty
        objSBAccSearch.ShowDialog(Me)
        If objSBAccSearch.strSBAccountNo <> String.Empty Then
            txtAccountNo.Text = objSBAccSearch.strSBAccountNo
            objAccountNo = txtAccountNo.Text
            sbLoadDetails()
        End If
        objSBAccSearch.Dispose()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnSetData() Then
                    If objSavingsBank.fnGetDepositedCheque(Trim(txtChequeNo.Text)) Or objSavingsBank.fnCheckChequeLeafNo(Trim(txtChequeNo.Text)) Then
                        MsgBox("Cheque number is already present in DataBase", MsgBoxStyle.Information)
                    Else

                        If fnSBTransaction(objTrans) Then
                            If objSavingsBank.fnAddDepositedCheque(objTrans) = True Then
                                fnLogEntry(pbUserId, "Cheque deposited by " & txtAccountNo.Text & " Amount " & Val(txtChequeAmount.Text), Date.Now, "Cheque Deposit", objTrans)
                                objTrans.Commit()
                                If MsgBox("Cheque deposited sucessfully, do you want another transactoin", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                    btnAdd_Click(sender, e)
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

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        sbclear()
        txtAccountNo.Text = ""
        txtName.ResetText()
        txtAccountNo.Focus()
    End Sub

    Private Sub frmSBChequeDeposit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpChequeDate.Value = Date.Now
        dtpDepositdate.Value = Date.Now
        If Trim(objAccountNo) <> "" Then
            sbLoadDetails()
        End If
    End Sub

    'Auto Compleation Form

    'Private Sub ComboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    cmbAccountNo.DroppedDown = True
    '    AutoComplete(cmbAccountNo, e)
    'End Sub

    'Public Sub AutoComplete(ByRef cb As ComboBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    Dim strFindStr As String

    '    If e.KeyChar = Chr(8) Then 'Backspace
    '        If cb.SelectionStart <= 1 Then
    '            cb.Text = ""
    '            Exit Sub
    '        End If
    '        If cb.SelectionLength = 0 Then
    '            strFindStr = cb.Text.Substring(0, cb.Text.Length - 1)
    '        Else
    '            strFindStr = cb.Text.Substring(0, cb.SelectionStart - 1)
    '        End If
    '    Else
    '        If cb.SelectionLength = 0 Then
    '            strFindStr = cb.Text & e.KeyChar
    '        Else
    '            strFindStr = cb.Text.Substring(0, cb.SelectionStart) & e.KeyChar
    '        End If
    '    End If

    '    Dim intIdx As Integer = -1

    '    ' Search the string in the Combo Box List.
    '    intIdx = cb.FindString(strFindStr)

    '    If intIdx <> -1 Then ' String found in the List.
    '        'cb.SelectedText = ""
    '        cb.SelectedIndex = intIdx
    '        cb.SelectionStart = strFindStr.Length
    '        cb.SelectionLength = cb.Text.Length
    '        e.Handled = True
    '    Else
    '        e.Handled = False
    '    End If
    'End Sub

    'Private Sub ComboBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Trim(cmbAccountNo.Text <> String.Empty) Then
    '        'If cmbAccountNo.SelectedIndex <> -1 Then
    '        objAccountNo = cmbAccountNo.Text
    '        sbLoadDetails()
    '    End If
    'End Sub

    'Private Sub cmbAccountNo_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    cmbAccountNo.Text = ""
    'End Sub

    'Sub LoadAccount()
    '    Dim objDT As DataTable
    '    If objSavingsBank.fnGetSBAccountTable Then
    '        objDT = objSavingsBank.SBAccTable
    '        cmbAccountNo.DataSource = objSavingsBank.SBAccTable
    '        cmbAccountNo.DisplayMember = "AccountNo"
    '        cmbAccountNo.ValueMember = "AccountNo"
    '        cmbAccountNo.SelectedIndex = -1
    '    End If

    'End Sub

    Public Sub AutoLoad()
        Select Case txtAccountNo.Text.Length
            Case "1"
                txtAccountNo.Text = "SB0000" & txtAccountNo.Text
            Case "2"
                txtAccountNo.Text = "SB000" & txtAccountNo.Text
            Case "3"
                txtAccountNo.Text = "SB00" & txtAccountNo.Text
            Case "4"
                txtAccountNo.Text = "SB0" & txtAccountNo.Text
            Case "5"
                txtAccountNo.Text = "SB" & txtAccountNo.Text
        End Select
    End Sub


#End Region

    Private Sub txtAccountNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccountNo.Leave
        If Trim(txtAccountNo.Text <> String.Empty) Then
            AutoLoad()
            objAccountNo = txtAccountNo.Text
            sbLoadDetails()
        End If
    End Sub

End Class
