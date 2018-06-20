Imports System.IO
Public Class frmSBChequeStopPay
    Inherits System.Windows.Forms.Form

#Region "form Global Variables"
    Dim objSBAccount As New clsSavingsBank
    Dim dblAmount As Double
    Dim dblBookAmount As Double
    Dim dblAvalAmount As Double
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAccNo As BankControls.TextControl
    Friend WithEvents txtNarration As BankControls.TextControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBookNo As BankControls.TextControl
    Friend WithEvents btnStopPay As BankControls.NewButton
    Friend WithEvents dtpChequeDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtChequeAmount As BankControls.NumericControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBankCharges As BankControls.NumericControl
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtRefNo As BankControls.NumericControl
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblAvalBal As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblBookBal As System.Windows.Forms.Label
    Friend WithEvents btnBounce As BankControls.NewButton
    Friend WithEvents txtSBChequeNo As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtChequeAmount = New BankControls.NumericControl
        Me.btnStopPay = New BankControls.NewButton
        Me.txtAccNo = New BankControls.TextControl
        Me.dtpChequeDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNarration = New BankControls.TextControl
        Me.btnCancel = New BankControls.NewButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBookNo = New BankControls.TextControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtBankCharges = New BankControls.NumericControl
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtRefNo = New BankControls.NumericControl
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblAvalBal = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblBookBal = New System.Windows.Forms.Label
        Me.btnBounce = New BankControls.NewButton
        Me.txtSBChequeNo = New BankControls.NumericControl
        Me.SuspendLayout()
        '
        'txtChequeAmount
        '
        Me.txtChequeAmount.AfterDecimal = 0
        Me.txtChequeAmount.BackColor = System.Drawing.Color.White
        Me.txtChequeAmount.BeforeDecimal = 7
        Me.txtChequeAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtChequeAmount.Location = New System.Drawing.Point(120, 80)
        Me.txtChequeAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtChequeAmount.MaxValue = 0
        Me.txtChequeAmount.MinValue = 0
        Me.txtChequeAmount.Name = "txtChequeAmount"
        Me.txtChequeAmount.ReadOnly = True
        Me.txtChequeAmount.Size = New System.Drawing.Size(152, 23)
        Me.txtChequeAmount.TabIndex = 2
        Me.txtChequeAmount.TabStop = False
        Me.txtChequeAmount.Text = ""
        '
        'btnStopPay
        '
        Me.btnStopPay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStopPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStopPay.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopPay.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnStopPay.Location = New System.Drawing.Point(304, 208)
        Me.btnStopPay.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnStopPay.Name = "btnStopPay"
        Me.btnStopPay.Size = New System.Drawing.Size(112, 40)
        Me.btnStopPay.TabIndex = 10
        Me.btnStopPay.Text = "&Stop Pay"
        '
        'txtAccNo
        '
        Me.txtAccNo.AlphaNumeric = False
        Me.txtAccNo.BackColor = System.Drawing.Color.White
        Me.txtAccNo.BlankSpace = False
        Me.txtAccNo.Enabled = False
        Me.txtAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccNo.Location = New System.Drawing.Point(120, 48)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.White
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.MaxLength = 10
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.ReadOnly = True
        Me.txtAccNo.Size = New System.Drawing.Size(152, 23)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 1
        Me.txtAccNo.TabStop = False
        Me.txtAccNo.Text = ""
        '
        'dtpChequeDate
        '
        Me.dtpChequeDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpChequeDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpChequeDate.Location = New System.Drawing.Point(392, 16)
        Me.dtpChequeDate.Name = "dtpChequeDate"
        Me.dtpChequeDate.Size = New System.Drawing.Size(144, 23)
        Me.dtpChequeDate.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(296, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 19)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(296, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 19)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Remarks :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Amount :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 19)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Account No. :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNarration
        '
        Me.txtNarration.AlphaNumeric = True
        Me.txtNarration.BlankSpace = True
        Me.txtNarration.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNarration.Location = New System.Drawing.Point(392, 136)
        Me.txtNarration.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNarration.Mandatory = False
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarration.Size = New System.Drawing.Size(184, 48)
        Me.txtNarration.SpecialChar = False
        Me.txtNarration.TabIndex = 8
        Me.txtNarration.Text = ""
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(432, 208)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 40)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "&Cancel"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(296, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 19)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Name :"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.AutoSize = False
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BlankSpace = True
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(392, 48)
        Me.txtName.LostFocusColour = System.Drawing.Color.White
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 35
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(200, 20)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 7
        Me.txtName.TabStop = False
        Me.txtName.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 19)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Cheque No. :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Book No. :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBookNo
        '
        Me.txtBookNo.AlphaNumeric = True
        Me.txtBookNo.BackColor = System.Drawing.Color.White
        Me.txtBookNo.BlankSpace = True
        Me.txtBookNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBookNo.Location = New System.Drawing.Point(120, 112)
        Me.txtBookNo.LostFocusColour = System.Drawing.Color.White
        Me.txtBookNo.Mandatory = False
        Me.txtBookNo.Name = "txtBookNo"
        Me.txtBookNo.ReadOnly = True
        Me.txtBookNo.Size = New System.Drawing.Size(152, 23)
        Me.txtBookNo.SpecialChar = False
        Me.txtBookNo.TabIndex = 3
        Me.txtBookNo.TabStop = False
        Me.txtBookNo.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 19)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Bank Charges :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBankCharges
        '
        Me.txtBankCharges.AfterDecimal = 0
        Me.txtBankCharges.BeforeDecimal = 7
        Me.txtBankCharges.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankCharges.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBankCharges.Location = New System.Drawing.Point(120, 144)
        Me.txtBankCharges.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBankCharges.MaxValue = 0
        Me.txtBankCharges.MinValue = 0
        Me.txtBankCharges.Name = "txtBankCharges"
        Me.txtBankCharges.Size = New System.Drawing.Size(152, 23)
        Me.txtBankCharges.TabIndex = 4
        Me.txtBankCharges.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 19)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Reference No. :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRefNo
        '
        Me.txtRefNo.AfterDecimal = 2
        Me.txtRefNo.BeforeDecimal = 7
        Me.txtRefNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRefNo.Location = New System.Drawing.Point(120, 176)
        Me.txtRefNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRefNo.MaxValue = 0
        Me.txtRefNo.MinValue = 0
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(152, 23)
        Me.txtRefNo.TabIndex = 5
        Me.txtRefNo.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(296, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 19)
        Me.Label13.TabIndex = 124
        Me.Label13.Text = "AvailableBalance :"
        '
        'lblAvalBal
        '
        Me.lblAvalBal.AutoSize = True
        Me.lblAvalBal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvalBal.Location = New System.Drawing.Point(424, 80)
        Me.lblAvalBal.Name = "lblAvalBal"
        Me.lblAvalBal.Size = New System.Drawing.Size(27, 19)
        Me.lblAvalBal.TabIndex = 123
        Me.lblAvalBal.Text = "0.0"
        Me.lblAvalBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(296, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 19)
        Me.Label14.TabIndex = 122
        Me.Label14.Text = "BookBalance :"
        '
        'lblBookBal
        '
        Me.lblBookBal.AutoSize = True
        Me.lblBookBal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookBal.Location = New System.Drawing.Point(424, 104)
        Me.lblBookBal.Name = "lblBookBal"
        Me.lblBookBal.Size = New System.Drawing.Size(27, 19)
        Me.lblBookBal.TabIndex = 121
        Me.lblBookBal.Text = "0.0"
        Me.lblBookBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBounce
        '
        Me.btnBounce.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnBounce.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBounce.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBounce.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBounce.ForeColor = System.Drawing.Color.Black
        Me.btnBounce.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnBounce.Location = New System.Drawing.Point(184, 208)
        Me.btnBounce.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnBounce.Name = "btnBounce"
        Me.btnBounce.Size = New System.Drawing.Size(96, 40)
        Me.btnBounce.TabIndex = 9
        Me.btnBounce.Text = "B&ounce"
        '
        'txtSBChequeNo
        '
        Me.txtSBChequeNo.AfterDecimal = 0
        Me.txtSBChequeNo.BackColor = System.Drawing.Color.White
        Me.txtSBChequeNo.BeforeDecimal = 10
        Me.txtSBChequeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSBChequeNo.GotFocusColour = System.Drawing.Color.White
        Me.txtSBChequeNo.Location = New System.Drawing.Point(120, 16)
        Me.txtSBChequeNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSBChequeNo.MaxLength = 10
        Me.txtSBChequeNo.MaxValue = 0
        Me.txtSBChequeNo.MinValue = 0
        Me.txtSBChequeNo.Name = "txtSBChequeNo"
        Me.txtSBChequeNo.ReadOnly = True
        Me.txtSBChequeNo.Size = New System.Drawing.Size(152, 23)
        Me.txtSBChequeNo.TabIndex = 0
        Me.txtSBChequeNo.TabStop = False
        Me.txtSBChequeNo.Text = ""
        '
        'frmSBChequeStopPay
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(606, 259)
        Me.Controls.Add(Me.txtSBChequeNo)
        Me.Controls.Add(Me.btnBounce)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblAvalBal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblBookBal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBankCharges)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtRefNo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtChequeAmount)
        Me.Controls.Add(Me.txtAccNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNarration)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBookNo)
        Me.Controls.Add(Me.btnStopPay)
        Me.Controls.Add(Me.dtpChequeDate)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSBChequeStopPay"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Savings Bank Cheque Stop Pay"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmSBChequeStopPay
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmSBChequeStopPay
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmSBChequeStopPay
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmSBChequeStopPay)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Functions"

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpChequeDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        Dim strNarration As String = "Stop Pay By " & txtAccNo.Text & "on Cheque no " & Trim(txtSBChequeNo.Text) & " Narration:" & txtNarration.Text

        'Transaction Entry
        objSBAccount.fnUpdateStatus(lngVoucherNo, strNarration, objTrans)

        Dim strsql2 = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
        strsql2 = strsql2 & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpChequeDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','0','0','" & Trim(txtChequeAmount.Text) & "',sum(Deposit)-sum(withdraw),'" & Trim(txtRefNo.Text) & "','" & lngVoucherNo & "','Cheque','" & Trim(txtSBChequeNo.Text) & "' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
        fnExecuteNonQuery(strsql2, objTrans)

        If Val(txtBankCharges.Text) <> 0 Then
            Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
            strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpChequeDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtBankCharges.Text) & "','0','" & Trim(txtChequeAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtBankCharges.Text) & "','" & Trim(txtRefNo.Text) & "','" & lngVoucherNo & "','Cheque','" & txtSBChequeNo.Text & "' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
            fnExecuteNonQuery(strsql, objTrans)

            'voucher details
            fnVoucherEnterMain(lngVoucherNo, 2, txtAccNo.Text, txtRefNo.Text, dtpChequeDate.Value, txtBankCharges.Text, "Stop Pay Charges (" & Trim(txtSBChequeNo.Text) & ")  By " & txtAccNo.Text, lngSlNo, "Y", objTrans)

            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 2, "", dtpChequeDate.Value, "Stop Pay By Account " & txtAccNo.Text & " on ChequeNo" & txtSBChequeNo.Text & " " & txtAccNo.Text, "To", 13, 0, Val(txtBankCharges.Text), 1, "Y", objTrans)

            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpChequeDate.Value, "Stop Pay By Account " & txtAccNo.Text & " on ChequeNo " & txtSBChequeNo.Text & "  " & txtAccNo.Text, "By", 10, Val(txtBankCharges.Text), 0, 2, "Y", objTrans)

        End If

        Return True
    End Function

    Function fnGenerateVoucherB(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpChequeDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        Dim strNarration As String = "Bounced By " & txtAccNo.Text & "on Cheque NUmber " & Trim(txtSBChequeNo.Text) & " Narration:" & txtNarration.Text

        'Transaction Entry
        objSBAccount.fnUpdateStatus(lngVoucherNo, strNarration, objTrans)

        Dim strsql2 = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
        strsql2 = strsql2 & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpChequeDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','0','0','" & Trim(txtChequeAmount.Text) & "',sum(Deposit)-sum(withdraw),'" & Trim(txtRefNo.Text) & "','" & lngVoucherNo & "','Cheque','" & Trim(txtSBChequeNo.Text) & "' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
        fnExecuteNonQuery(strsql2, objTrans)

        If Val(txtBankCharges.Text) <> 0 Then
            Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
            strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpChequeDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtBankCharges.Text) & "','0','" & Trim(txtChequeAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtBankCharges.Text) & "','" & Trim(txtRefNo.Text) & "','" & lngVoucherNo & "','Cheque','" & txtSBChequeNo.Text & "' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
            fnExecuteNonQuery(strsql, objTrans)

            'voucher details
            fnVoucherEnterMain(lngVoucherNo, 2, txtAccNo.Text, txtRefNo.Text, dtpChequeDate.Value, txtBankCharges.Text, "Bounce Charges (" & Trim(txtSBChequeNo.Text) & ")  By " & txtAccNo.Text, lngSlNo, "Y", objTrans)

            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 2, "", dtpChequeDate.Value, "Bounce by account " & txtAccNo.Text & " on ChequeNo" & txtSBChequeNo.Text & " " & txtAccNo.Text, "To", 13, 0, Val(txtBankCharges.Text), 1, "Y", objTrans)

            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpChequeDate.Value, "Stop pay by account " & txtAccNo.Text & " on ChequeNo " & txtSBChequeNo.Text & "  " & txtAccNo.Text, "By", 10, Val(txtBankCharges.Text), 0, 2, "Y", objTrans)
        End If

        Return True
    End Function

    Function fnTransaction() As Boolean
        Dim strsql1 = "insert into sbchequeleaftbl(Book_SNo,ChequeNo,Amount,Status,Remarks,Charges) values('" & Trim(txtBookNo.Text) & "','" & Trim(txtSBChequeNo.Text) & "','" & Trim(txtChequeAmount.Text) & "','Stopped','" & Trim(txtNarration.Text) & "','" & txtBankCharges.Text & "')"
        fnExecuteNonQuery(strsql1)
    End Function
    Function fnCheck() As Boolean
        If Trim(txtSBChequeNo.Text) = String.Empty Then
            MsgBox("Enter chequeno", MsgBoxStyle.Information)
            txtAccNo.Focus()
            Return False
        ElseIf Trim(txtAccNo.Text) = String.Empty Then
            MsgBox("Enter acoountno", MsgBoxStyle.Information)
            txtAccNo.Focus()
            Return False
        ElseIf Trim(txtBankCharges.Text) = String.Empty Then
            MsgBox("Enter amount", MsgBoxStyle.Information)
            txtBankCharges.Focus()
            Return False
        ElseIf Trim(txtRefNo.Text) = String.Empty Then
            MsgBox("Enter reference number", MsgBoxStyle.Information)
            txtRefNo.Focus()
            Return False

            'ElseIf Val(lblPostBal.Text) < 0 Then
            '    MsgBox("Enter Valid Amount", MsgBoxStyle.Information)
            '    txtBankCharges.Focus()
            '    Return False
        Else
            Return True
        End If
    End Function

    Public Function fnSetData()

        objSBAccount.SBNo = txtAccNo.Text
        objSBAccount.chequeClearanceDate = dtpChequeDate.Value
        objSBAccount.Remarks = txtNarration.Text
        objSBAccount.ChequeAmount = txtChequeAmount.Text
        objSBAccount.BankCharges = txtBankCharges.Text
        'objSBAccount.AmtRemittedBank = txtBankCharges.Text
        objSBAccount.ChequeNo = txtSBChequeNo.Text

    End Function

#End Region

#Region "EVENTS"
    Private Sub frmSBWithdraw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpChequeDate.Value = Date.Now
        If Trim(txtAccNo.Text <> String.Empty) Then
            sbLoadDetails()
        End If
    End Sub
    Private Sub btnWithDraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopPay.Click
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                fnSetData()
                If objSBAccount.fnGetDepositedCheque(txtSBChequeNo.Text) Then
                    If Not objSBAccount.fnCheckChequeLeafNo(Trim(txtSBChequeNo.Text)) Then
                        If MsgBox("SB accountNo :" & txtAccNo.Text & " " & Chr(13) & " StopPay Amount :" & txtChequeAmount.Text & " " & Chr(13) & " Cheque No : " & txtSBChequeNo.Text) = MsgBoxResult.OK Then
                            objSBAccount.ChequeStatus = "Stop Pay"

                            fnGenerateVoucher(objTrans)
                            fnLogEntry(pbUserId, "Cheque stop pay by " & txtAccNo.Text & " Amount " & Val(txtBankCharges.Text), Date.Now, "Cheque Stop Pay", objTrans)
                            objTrans.Commit()
                            Me.Close()
                        End If
                    Else
                        MsgBox("Sorry! cheque is already " & objSBAccount.SBCheckBookBookTable.Rows(0).Item("Stauts"), MsgBoxStyle.Critical)
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

#End Region

#Region "Sub Routines"

    Sub sbLoadDetails()
        Try
            If objSBAccount.fnGetSBAccountDetails(Trim(txtAccNo.Text)) = True Then
                txtAccNo.Text = objSBAccount.SBAccTable.Rows(0).Item("AccountNo")
                txtName.Text = objSBAccount.SBAccTable.Rows(0).Item("Name")
                dblBookAmount = objSBAccount.SBAccTable.Rows(0).Item("BookBalance")
                lblBookBal.Text = Format(dblBookAmount, "0,00.00")
                dblAvalAmount = objSBAccount.SBAccTable.Rows(0).Item("AvailBalance")
                lblAvalBal.Text = Format(dblAvalAmount, "0,00.00")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub sbClear()
        txtSBChequeNo.ResetText()
        txtAccNo.ResetText()
        txtName.ResetText()
        txtBankCharges.ResetText()
        txtNarration.ResetText()
        txtBankCharges.ResetText()
    End Sub



#End Region


    Private Sub btnBounce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBounce.Click
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                fnSetData()
                If objSBAccount.fnGetDepositedCheque(txtSBChequeNo.Text) Then
                    If Not objSBAccount.fnCheckChequeLeafNo(Trim(txtSBChequeNo.Text)) Then
                        If MsgBox("SB accountno :" & txtAccNo.Text & " " & Chr(13) & " Bounce Amount :" & txtChequeAmount.Text & " " & Chr(13) & " Cheque No : " & txtSBChequeNo.Text) = MsgBoxResult.OK Then
                            objSBAccount.ChequeStatus = "Bounce"

                            fnGenerateVoucherB(objTrans)
                            fnLogEntry(pbUserId, "Cheque bounce by " & txtAccNo.Text & " Amount " & Val(txtBankCharges.Text), Date.Now, "Cheque Bounce", objTrans)
                            objTrans.Commit()
                            Me.Close()
                        End If
                    Else
                        MsgBox("Sorry! cheque is already withdrawn ", MsgBoxStyle.Critical)
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try

    End Sub
End Class
