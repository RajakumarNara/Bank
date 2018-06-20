
Imports System.IO
Public Class frmCAChequeStopPay
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
    Friend WithEvents txtBankCharges As BankControls.NumericControl
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtRefNo As BankControls.NumericControl
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtChequeAmount As BankControls.NumericControl
    Friend WithEvents txtAccNo As BankControls.TextControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As BankControls.TextControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBookNo As BankControls.TextControl
    Friend WithEvents btnStopPay As BankControls.NewButton
    Friend WithEvents dtpChequeDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblAvalBal As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblBookBal As System.Windows.Forms.Label
    Friend WithEvents btnBounce As BankControls.NewButton
    Friend WithEvents txtSBChequeNo As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCAChequeStopPay))
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtBankCharges = New BankControls.NumericControl
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtRefNo = New BankControls.NumericControl
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtChequeAmount = New BankControls.NumericControl
        Me.txtAccNo = New BankControls.TextControl
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNarration = New BankControls.TextControl
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBookNo = New BankControls.TextControl
        Me.btnStopPay = New BankControls.NewButton
        Me.dtpChequeDate = New System.Windows.Forms.DateTimePicker
        Me.btnCancel = New BankControls.NewButton
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblAvalBal = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblBookBal = New System.Windows.Forms.Label
        Me.btnBounce = New BankControls.NewButton
        Me.txtSBChequeNo = New BankControls.NumericControl
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 19)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Bank Charges"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBankCharges
        '
        Me.txtBankCharges.AfterDecimal = 0
        Me.txtBankCharges.BeforeDecimal = 7
        Me.txtBankCharges.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankCharges.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBankCharges.Location = New System.Drawing.Point(128, 144)
        Me.txtBankCharges.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBankCharges.MaxValue = 0
        Me.txtBankCharges.MinValue = 0
        Me.txtBankCharges.Name = "txtBankCharges"
        Me.txtBankCharges.Size = New System.Drawing.Size(152, 23)
        Me.txtBankCharges.TabIndex = 7
        Me.txtBankCharges.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.TabIndex = 127
        Me.Label9.Text = "Reference No."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRefNo
        '
        Me.txtRefNo.AfterDecimal = 0
        Me.txtRefNo.BeforeDecimal = 7
        Me.txtRefNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRefNo.Location = New System.Drawing.Point(128, 176)
        Me.txtRefNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRefNo.MaxValue = 0
        Me.txtRefNo.MinValue = 0
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(152, 23)
        Me.txtRefNo.TabIndex = 8
        Me.txtRefNo.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 19)
        Me.Label10.TabIndex = 124
        Me.Label10.Text = "Cheque No."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtChequeAmount
        '
        Me.txtChequeAmount.AfterDecimal = 0
        Me.txtChequeAmount.BackColor = System.Drawing.Color.White
        Me.txtChequeAmount.BeforeDecimal = 7
        Me.txtChequeAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeAmount.GotFocusColour = System.Drawing.Color.White
        Me.txtChequeAmount.Location = New System.Drawing.Point(128, 80)
        Me.txtChequeAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtChequeAmount.MaxValue = 0
        Me.txtChequeAmount.MinValue = 0
        Me.txtChequeAmount.Name = "txtChequeAmount"
        Me.txtChequeAmount.ReadOnly = True
        Me.txtChequeAmount.Size = New System.Drawing.Size(152, 23)
        Me.txtChequeAmount.TabIndex = 5
        Me.txtChequeAmount.TabStop = False
        Me.txtChequeAmount.Text = ""
        '
        'txtAccNo
        '
        Me.txtAccNo.AlphaNumeric = False
        Me.txtAccNo.BackColor = System.Drawing.Color.White
        Me.txtAccNo.BlankSpace = False
        Me.txtAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccNo.Location = New System.Drawing.Point(128, 48)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.White
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.MaxLength = 10
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.ReadOnly = True
        Me.txtAccNo.Size = New System.Drawing.Size(152, 23)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 3
        Me.txtAccNo.TabStop = False
        Me.txtAccNo.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(296, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 19)
        Me.Label6.TabIndex = 120
        Me.Label6.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(296, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 19)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Remarks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 19)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Amount"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 19)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "Account No."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNarration
        '
        Me.txtNarration.AlphaNumeric = True
        Me.txtNarration.BlankSpace = True
        Me.txtNarration.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNarration.Location = New System.Drawing.Point(372, 152)
        Me.txtNarration.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNarration.Mandatory = False
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarration.Size = New System.Drawing.Size(220, 56)
        Me.txtNarration.SpecialChar = False
        Me.txtNarration.TabIndex = 9
        Me.txtNarration.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(296, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 19)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "Name"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.AutoSize = False
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(372, 46)
        Me.txtName.LostFocusColour = System.Drawing.Color.White
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 35
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(200, 20)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 4
        Me.txtName.TabStop = False
        Me.txtName.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 19)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Book No."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBookNo
        '
        Me.txtBookNo.AlphaNumeric = False
        Me.txtBookNo.BackColor = System.Drawing.Color.White
        Me.txtBookNo.BlankSpace = False
        Me.txtBookNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookNo.GotFocusColour = System.Drawing.Color.White
        Me.txtBookNo.Location = New System.Drawing.Point(128, 112)
        Me.txtBookNo.LostFocusColour = System.Drawing.Color.White
        Me.txtBookNo.Mandatory = False
        Me.txtBookNo.Name = "txtBookNo"
        Me.txtBookNo.ReadOnly = True
        Me.txtBookNo.Size = New System.Drawing.Size(152, 23)
        Me.txtBookNo.SpecialChar = False
        Me.txtBookNo.TabIndex = 6
        Me.txtBookNo.TabStop = False
        Me.txtBookNo.Text = ""
        '
        'btnStopPay
        '
        Me.btnStopPay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStopPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStopPay.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopPay.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnStopPay.Location = New System.Drawing.Point(264, 224)
        Me.btnStopPay.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnStopPay.Name = "btnStopPay"
        Me.btnStopPay.Size = New System.Drawing.Size(112, 40)
        Me.btnStopPay.TabIndex = 11
        Me.btnStopPay.Text = "&Stop Pay"
        '
        'dtpChequeDate
        '
        Me.dtpChequeDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpChequeDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpChequeDate.Location = New System.Drawing.Point(372, 14)
        Me.dtpChequeDate.Name = "dtpChequeDate"
        Me.dtpChequeDate.Size = New System.Drawing.Size(132, 23)
        Me.dtpChequeDate.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(404, 224)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(108, 40)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "&Cancel"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(296, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 19)
        Me.Label13.TabIndex = 132
        Me.Label13.Text = "AvailableBalance"
        '
        'lblAvalBal
        '
        Me.lblAvalBal.AutoSize = True
        Me.lblAvalBal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvalBal.Location = New System.Drawing.Point(432, 80)
        Me.lblAvalBal.Name = "lblAvalBal"
        Me.lblAvalBal.Size = New System.Drawing.Size(27, 19)
        Me.lblAvalBal.TabIndex = 131
        Me.lblAvalBal.Text = "0.0"
        Me.lblAvalBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(296, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 19)
        Me.Label14.TabIndex = 130
        Me.Label14.Text = "BookBalance"
        '
        'lblBookBal
        '
        Me.lblBookBal.AutoSize = True
        Me.lblBookBal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookBal.Location = New System.Drawing.Point(432, 112)
        Me.lblBookBal.Name = "lblBookBal"
        Me.lblBookBal.Size = New System.Drawing.Size(27, 19)
        Me.lblBookBal.TabIndex = 129
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
        Me.btnBounce.Location = New System.Drawing.Point(152, 224)
        Me.btnBounce.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnBounce.Name = "btnBounce"
        Me.btnBounce.Size = New System.Drawing.Size(96, 40)
        Me.btnBounce.TabIndex = 10
        Me.btnBounce.Text = "B&ounce"
        '
        'txtSBChequeNo
        '
        Me.txtSBChequeNo.AfterDecimal = 0
        Me.txtSBChequeNo.BackColor = System.Drawing.Color.White
        Me.txtSBChequeNo.BeforeDecimal = 10
        Me.txtSBChequeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSBChequeNo.GotFocusColour = System.Drawing.Color.White
        Me.txtSBChequeNo.Location = New System.Drawing.Point(128, 16)
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
        'frmCAChequeStopPay
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(622, 269)
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
        Me.Name = "frmCAChequeStopPay"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CA Cheque StopPay"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "form Global Variables"
    Dim objCAccount As New clsCurrentAccount
    '; Dim dblAmount As Double
    Dim dblBookAmount As Double
    Dim dblAvalAmount As Double
#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmCAChequeStopPay
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmCAChequeStopPay
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmCAChequeStopPay
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmCAChequeStopPay)
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

        Dim strNarration As String = "Stop Pay By " & txtAccNo.Text & " on Cheque no " & Trim(txtSBChequeNo.Text) & " Narration:" & txtNarration.Text
        'Transaction Entry
        'Dim strsql1 = "insert into cachequeleaftbl(Book_SNo,ChequeNo,Amount,Status,Remarks,Charges) values('" & Trim(txtBookNo.Text) & "','" & Trim(txtSBChequeNo.Text) & "','" & Trim(txtChequeAmount.Text) & "','Stopped','" & Trim(txtNarration.Text) & "','" & txtBankCharges.Text & "')"
        'fnExecuteNonQuery(strsql1)

        objCAccount.fnUpdateStatus(lngVoucherNo, strNarration, objTrans)

        Dim strsql2 = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,VoucherNo,type,chequeno) "
        strsql2 = strsql2 & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpChequeDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','0','0','" & Trim(txtChequeAmount.Text) & "',sum(Deposit)-sum(withdraw),'0','" & Trim(txtRefNo.Text) & "','" & lngVoucherNo & "','Cheque','" & Trim(txtSBChequeNo.Text) & "' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
        fnExecuteNonQuery(strsql2, objTrans)


        If Val(txtBankCharges.Text) <> 0 Then

            Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,VoucherNo,type,chequeno) "
            strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpChequeDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtBankCharges.Text) & "','0','" & Trim(txtChequeAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtBankCharges.Text) & "','0','" & Trim(txtRefNo.Text) & "','" & lngVoucherNo & "','Cheque','" & Trim(txtSBChequeNo.Text) & "' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
            fnExecuteNonQuery(strsql, objTrans)

            'voucher details
            fnVoucherEnterMain(lngVoucherNo, 2, txtAccNo.Text, txtRefNo.Text, dtpChequeDate.Value, txtBankCharges.Text, "Stop pay charges (" & Trim(txtSBChequeNo.Text) & ")  By " & txtAccNo.Text, lngSlNo, "Y", objTrans)
            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 2, "", dtpChequeDate.Value, "Stop pay by account " & txtAccNo.Text & " on ChequeNo" & txtSBChequeNo.Text & " " & txtAccNo.Text, "To", 13, 0, Val(txtBankCharges.Text), 1, "Y", objTrans)

            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpChequeDate.Value, "Stop pay by account " & txtAccNo.Text & " on ChequeNo " & txtSBChequeNo.Text & "  " & txtAccNo.Text, "By", 11, Val(txtBankCharges.Text), 0, 2, "Y", objTrans)

        End If
        Return True

    End Function

    Function fnGenerateVoucherB(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpChequeDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        Dim strNarration As String = "Bounced By " & txtAccNo.Text & "on Cheque Number " & Trim(txtSBChequeNo.Text) & " Narration:" & txtNarration.Text

        'Transaction Entry
        'Dim strsql1 = "insert into cachequeleaftbl(Book_SNo,ChequeNo,Amount,Status,Remarks,Charges) values('" & Trim(txtBookNo.Text) & "','" & Trim(txtSBChequeNo.Text) & "','" & Trim(txtChequeAmount.Text) & "','Bounced','" & Trim(txtNarration.Text) & "','" & txtBankCharges.Text & "')"
        'fnExecuteNonQuery(strsql1)

        objCAccount.fnUpdateStatus(lngVoucherNo, strNarration, objTrans)

        Dim strsql2 = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,VoucherNo,type,chequeno) "
        strsql2 = strsql2 & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpChequeDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','0','0','" & Trim(txtChequeAmount.Text) & "',sum(Deposit)-sum(withdraw),'0','" & Trim(txtRefNo.Text) & "','" & lngVoucherNo & "','Cheque','" & Trim(txtSBChequeNo.Text) & "' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
        fnExecuteNonQuery(strsql2, objTrans)

        If Val(txtBankCharges.Text) <> 0 Then

            Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,VoucherNo,type,chequeno) "
            strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpChequeDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtBankCharges.Text) & "','0','" & Trim(txtChequeAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtBankCharges.Text) & "','0','" & Trim(txtRefNo.Text) & "','" & lngVoucherNo & "','Cheque','" & Trim(txtSBChequeNo.Text) & "' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
            fnExecuteNonQuery(strsql, objTrans)

            'voucher details
            fnVoucherEnterMain(lngVoucherNo, 2, txtAccNo.Text, txtRefNo.Text, dtpChequeDate.Value, txtBankCharges.Text, "Cheque bounce charges (" & Trim(txtSBChequeNo.Text) & ")  By " & txtAccNo.Text, lngSlNo, "Y", objTrans)

            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 2, "", dtpChequeDate.Value, "Cheque bounce by account " & txtAccNo.Text & " on chequeNo" & txtSBChequeNo.Text & " " & txtAccNo.Text, "To", 13, 0, Val(txtBankCharges.Text), 1, "Y", objTrans)

            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpChequeDate.Value, "Cheque bounce by account " & txtAccNo.Text & " on chequeNo " & txtSBChequeNo.Text & "  " & txtAccNo.Text, "By", 11, Val(txtBankCharges.Text), 0, 2, "Y", objTrans)

        End If

        Return True
    End Function

    Function fnCheck() As Boolean
        If Trim(txtSBChequeNo.Text) = String.Empty Then
            MsgBox("Enter chequeno", MsgBoxStyle.Information)
            txtSBChequeNo.Focus()
            Return False
        ElseIf Trim(txtAccNo.Text) = String.Empty Then
            MsgBox("Enter acoountno", MsgBoxStyle.Information)
            txtAccNo.Focus()
            Return False
        ElseIf Trim(txtBankCharges.Text) = String.Empty Then
            MsgBox("Enter bank charges", MsgBoxStyle.Information)
            txtBankCharges.Focus()
            Return False
        ElseIf Trim(txtRefNo.Text) = String.Empty Then
            MsgBox("Enter reference number", MsgBoxStyle.Information)
            txtRefNo.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Public Function fnSetData()
        objCAccount.CurAccountNo = txtAccNo.Text
        objCAccount.chequeClearanceDate = dtpChequeDate.Value
        objCAccount.Remarks = txtNarration.Text
        objCAccount.ChequeClearedAmt = txtChequeAmount.Text
        objCAccount.BankCharges = txtBankCharges.Text
        objCAccount.AmtRemittedBank = txtBankCharges.Text
        objCAccount.ChequeNo = txtSBChequeNo.Text
    End Function

#End Region

#Region "Sub Routines"

    Sub sbLoadDetails()
        If objCAccount.fnGetCAccountDetails(Trim(txtAccNo.Text)) = True Then
            txtAccNo.Text = objCAccount.CAAccTable.Rows(0).Item("CAccountNo")
            txtName.Text = objCAccount.CAAccTable.Rows(0).Item("Name")
            dblBookAmount = objCAccount.CAAccTable.Rows(0).Item("BookBalance")
            lblBookBal.Text = Format(dblBookAmount, "0,00.00")
            dblAvalAmount = objCAccount.CAAccTable.Rows(0).Item("AvailBalance")
            lblAvalBal.Text = Format(dblAvalAmount, "0,00.00")

        End If
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

#Region "EVENTS"

    Private Sub btnWithDraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopPay.Click

        Dim objTrans As IDbTransaction
        objTrans = fnGetTransaction()

        Try
            If fnCheck() Then
                If objCAccount.fnGetDepositedCheque(txtSBChequeNo.Text) Then
                    ' If Not objCAccount.fnCheckChequeLeafNo(Trim(txtSBChequeNo.Text)) Then
                    If MsgBox("CA accountno :" & txtAccNo.Text & " " & Chr(13) & " Stoppay amount :" & txtChequeAmount.Text & " " & Chr(13) & " Cheque No : " & txtSBChequeNo.Text) = MsgBoxResult.OK Then
                        fnSetData()
                        objCAccount.ChequeStatus = "Stop pay"

                        fnGenerateVoucher(objTrans)
                        fnLogEntry(pbUserId, "Cheque stop pay by " & txtAccNo.Text & " Amount " & txtChequeAmount.Text, Date.Now, "Cheque Stop pay", objTrans)
                        objTrans.Commit()
                        Me.Close()
                    End If
                    ' Else
                    '  MsgBox("Sorry! Cheque Is already " & objCAccount.CACheckBookBookTable.Rows(0).Item("Status"), MsgBoxStyle.Critical)
                    ' End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try
     
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

#End Region

    Private Sub frmCAChequeStopPay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Trim(txtAccNo.Text <> String.Empty) Then
            sbLoadDetails()
        End If
    End Sub

    Private Sub btnBounce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBounce.Click

        Dim objTrans As IDbTransaction
        objTrans = fnGetTransaction()
        Try
            If fnCheck() Then
                If objCAccount.fnGetDepositedCheque(txtSBChequeNo.Text) Then
                    'If Not objCAccount.fnCheckChequeLeafNo(Trim(txtSBChequeNo.Text)) Then
                    If MsgBox("CA accountno :" & txtAccNo.Text & " " & Chr(13) & " Bounce amount :" & txtChequeAmount.Text & " " & Chr(13) & " Cheque No : " & txtSBChequeNo.Text) = MsgBoxResult.OK Then
                        fnSetData()
                        objCAccount.ChequeStatus = "Bounce"

                        fnGenerateVoucherB(objTrans)
                        fnLogEntry(pbUserId, "Cheque bounce by " & txtAccNo.Text & " Amount " & txtChequeAmount.Text, Date.Now, "Cheque Bounce", objTrans)
                        objTrans.Commit()
                        Me.Close()
                    End If
                    'Else
                    '    MsgBox("Sorry! Cheque Is already " & objCAccount.CACheckBookBookTable.Rows(0).Item("Status"), MsgBoxStyle.Critical)
                End If
            End If
            'End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try

      
    End Sub
End Class
