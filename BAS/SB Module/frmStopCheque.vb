Imports System.IO

Public Class frmStopCheque
    Inherits System.Windows.Forms.Form

#Region "form Global Variables"
    Dim objSavingsBank As New clsSavingsBank
    Dim dblAvalAmount As Double
    Dim dblBookAmount As Double
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
    Friend WithEvents txtSBChequeNo As BankControls.NumericControl
    Friend WithEvents txtRefNo As BankControls.NumericControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpWithdrawldate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBookNo As BankControls.TextControl
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents txtAccNo As BankControls.TextControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As BankControls.TextControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents btnWithDraw As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents btnVerifyPhotoSign As BankControls.NewButton
    Friend WithEvents chkSB As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblAvalBal As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblBookBal As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmStopCheque))
        Me.txtSBChequeNo = New BankControls.NumericControl
        Me.txtRefNo = New BankControls.NumericControl
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpWithdrawldate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBookNo = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtAmount = New BankControls.NumericControl
        Me.txtAccNo = New BankControls.TextControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNarration = New BankControls.TextControl
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.btnWithDraw = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.btnVerifyPhotoSign = New BankControls.NewButton
        Me.chkSB = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblAvalBal = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblBookBal = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtSBChequeNo
        '
        Me.txtSBChequeNo.AfterDecimal = 0
        Me.txtSBChequeNo.BeforeDecimal = 7
        Me.txtSBChequeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSBChequeNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSBChequeNo.Location = New System.Drawing.Point(136, 8)
        Me.txtSBChequeNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSBChequeNo.MaxValue = 0
        Me.txtSBChequeNo.MinValue = 0
        Me.txtSBChequeNo.Name = "txtSBChequeNo"
        Me.txtSBChequeNo.Size = New System.Drawing.Size(152, 23)
        Me.txtSBChequeNo.TabIndex = 126
        Me.txtSBChequeNo.Text = ""
        '
        'txtRefNo
        '
        Me.txtRefNo.AfterDecimal = 0
        Me.txtRefNo.BeforeDecimal = 7
        Me.txtRefNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRefNo.Location = New System.Drawing.Point(136, 168)
        Me.txtRefNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRefNo.MaxValue = 0
        Me.txtRefNo.MinValue = 0
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(152, 23)
        Me.txtRefNo.TabIndex = 131
        Me.txtRefNo.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(352, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 19)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = " Date :"
        '
        'dtpWithdrawldate
        '
        Me.dtpWithdrawldate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpWithdrawldate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpWithdrawldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpWithdrawldate.Location = New System.Drawing.Point(448, 8)
        Me.dtpWithdrawldate.Name = "dtpWithdrawldate"
        Me.dtpWithdrawldate.Size = New System.Drawing.Size(152, 23)
        Me.dtpWithdrawldate.TabIndex = 132
        Me.dtpWithdrawldate.Value = New Date(2007, 10, 15, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(352, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "Book No. :"
        '
        'txtBookNo
        '
        Me.txtBookNo.AlphaNumeric = False
        Me.txtBookNo.BackColor = System.Drawing.Color.White
        Me.txtBookNo.BlankSpace = False
        Me.txtBookNo.Enabled = False
        Me.txtBookNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBookNo.Location = New System.Drawing.Point(448, 40)
        Me.txtBookNo.LostFocusColour = System.Drawing.Color.White
        Me.txtBookNo.Mandatory = False
        Me.txtBookNo.Name = "txtBookNo"
        Me.txtBookNo.Size = New System.Drawing.Size(152, 23)
        Me.txtBookNo.SpecialChar = False
        Me.txtBookNo.TabIndex = 134
        Me.txtBookNo.TabStop = False
        Me.txtBookNo.Text = ""
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Enabled = False
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(120, Byte), CType(128, Byte), CType(171, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(296, 40)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 129
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 19)
        Me.Label10.TabIndex = 144
        Me.Label10.Text = "Cheque No. :"
        '
        'txtAmount
        '
        Me.txtAmount.AfterDecimal = 0
        Me.txtAmount.BeforeDecimal = 7
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmount.Location = New System.Drawing.Point(136, 136)
        Me.txtAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAmount.MaxValue = 0
        Me.txtAmount.MinValue = 0
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(152, 23)
        Me.txtAmount.TabIndex = 130
        Me.txtAmount.Text = ""
        '
        'txtAccNo
        '
        Me.txtAccNo.AlphaNumeric = True
        Me.txtAccNo.BackColor = System.Drawing.Color.White
        Me.txtAccNo.BlankSpace = False
        Me.txtAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccNo.Location = New System.Drawing.Point(136, 40)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.White
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.ReadOnly = True
        Me.txtAccNo.Size = New System.Drawing.Size(152, 23)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 128
        Me.txtAccNo.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 19)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "Reference No. :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 19)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Remarks :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 19)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "Bank Charges :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 19)
        Me.Label5.TabIndex = 140
        Me.Label5.Text = "Account No. :"
        '
        'txtNarration
        '
        Me.txtNarration.AlphaNumeric = True
        Me.txtNarration.BlankSpace = True
        Me.txtNarration.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNarration.Location = New System.Drawing.Point(136, 200)
        Me.txtNarration.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNarration.Mandatory = False
        Me.txtNarration.MaxLength = 50
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarration.Size = New System.Drawing.Size(384, 40)
        Me.txtNarration.SpecialChar = True
        Me.txtNarration.TabIndex = 135
        Me.txtNarration.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 19)
        Me.Label7.TabIndex = 139
        Me.Label7.Text = "Name :"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.AutoSize = False
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(136, 72)
        Me.txtName.LostFocusColour = System.Drawing.Color.White
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 35
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(152, 20)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 133
        Me.txtName.Text = ""
        '
        'btnWithDraw
        '
        Me.btnWithDraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithDraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWithDraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithDraw.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnWithDraw.Location = New System.Drawing.Point(288, 248)
        Me.btnWithDraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnWithDraw.Name = "btnWithDraw"
        Me.btnWithDraw.Size = New System.Drawing.Size(128, 40)
        Me.btnWithDraw.TabIndex = 137
        Me.btnWithDraw.Text = "&Stop Cheque"
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(440, 248)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(128, 40)
        Me.btnCancel.TabIndex = 138
        Me.btnCancel.Text = "&Cancel"
        '
        'btnVerifyPhotoSign
        '
        Me.btnVerifyPhotoSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerifyPhotoSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVerifyPhotoSign.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerifyPhotoSign.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnVerifyPhotoSign.Location = New System.Drawing.Point(136, 248)
        Me.btnVerifyPhotoSign.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnVerifyPhotoSign.Name = "btnVerifyPhotoSign"
        Me.btnVerifyPhotoSign.Size = New System.Drawing.Size(128, 40)
        Me.btnVerifyPhotoSign.TabIndex = 136
        Me.btnVerifyPhotoSign.Text = "&Verify Signature"
        '
        'chkSB
        '
        Me.chkSB.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.chkSB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSB.Location = New System.Drawing.Point(136, 104)
        Me.chkSB.Name = "chkSB"
        Me.chkSB.Size = New System.Drawing.Size(192, 24)
        Me.chkSB.TabIndex = 148
        Me.chkSB.Text = "use SB Account Balance"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(352, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 19)
        Me.Label9.TabIndex = 152
        Me.Label9.Text = "Available Balance :"
        '
        'lblAvalBal
        '
        Me.lblAvalBal.AutoSize = True
        Me.lblAvalBal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvalBal.Location = New System.Drawing.Point(496, 80)
        Me.lblAvalBal.Name = "lblAvalBal"
        Me.lblAvalBal.Size = New System.Drawing.Size(27, 19)
        Me.lblAvalBal.TabIndex = 151
        Me.lblAvalBal.Text = "0.0"
        Me.lblAvalBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(352, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 19)
        Me.Label11.TabIndex = 150
        Me.Label11.Text = "Book Balance :"
        '
        'lblBookBal
        '
        Me.lblBookBal.AutoSize = True
        Me.lblBookBal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookBal.Location = New System.Drawing.Point(496, 112)
        Me.lblBookBal.Name = "lblBookBal"
        Me.lblBookBal.Size = New System.Drawing.Size(27, 19)
        Me.lblBookBal.TabIndex = 149
        Me.lblBookBal.Text = "0.0"
        Me.lblBookBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmStopCheque
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(642, 303)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblAvalBal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblBookBal)
        Me.Controls.Add(Me.chkSB)
        Me.Controls.Add(Me.txtSBChequeNo)
        Me.Controls.Add(Me.txtRefNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpWithdrawldate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBookNo)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtAccNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNarration)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnWithDraw)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnVerifyPhotoSign)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStopCheque"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stop Cheque"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmStopCheque
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmStopCheque
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmStopCheque
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmStopCheque)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Functions"

    'Function fnGenerateVoucher() As Boolean

    '    Dim lngVoucherNo As Long
    '    Dim lngSlNo As Long
    '    Dim strNarration As String

    '    lngVoucherNo = fnVoucherGetNewVNo(dtpWithdrawldate.Value)
    '    lngSlNo = fnVoucherGetNewSlNo()

    '    strNarration = "Cheque stopped By " & txtName.Text & " Cheque No " & txtSBChequeNo.Text & " Narration:  " & txtNarration.Text

    '    'Transaction Entery
    '    Dim strsql As String = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
    '    strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpWithdrawldate.Value, "yyyy-MM-dd") & "','" & strNarration & "','0','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtAmount.Text) & "','" & Trim(txtRefNo.Text) & "','" & lngVoucherNo & "','Cheque','" & Trim(txtSBChequeNo.Text) & "' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
    '    fnExecuteNonQuery(strsql)

    '    strsql = "Insert into sbChequeDeposittbl(AccountNo,BankName,BranchName,Chequedate,ChequeNo,Depositdate,ChequeAmount,ClearanceDate,BankCharges,ChequeStatus,VoucherNo,Narration) Values( '" & txtAccNo.Text & "',' ','','" & Format(dtpWithdrawldate.Value, "yyyy-MM-dd") & "','" & txtSBChequeNo.Text & "','" & Format(dtpWithdrawldate.Value, "yyyy-MM-dd") & "','" & Val(txtAmount.Text) & "','" & Format(dtpWithdrawldate.Value, "yyyy-MM-dd") & "','0.00','Cleared','" & Val(txtRefNo.Text) & "','" & txtNarration.Text & "')"
    '    fnExecuteNonQuery(strsql)

    '    'voucher details
    '    fnVoucherEnterMain(lngVoucherNo, 1, txtAccNo.Text, txtRefNo.Text, dtpWithdrawldate.Value, txtAmount.Text, "Cheque Withdraw By Account " & txtAccNo.Text, lngSlNo, "Y")

    '    'Credit accounts
    '    fnVoucherEnterSub(lngVoucherNo, 1, "", dtpWithdrawldate.Value, "Cheque Withdraw By Account " & txtAccNo.Text, "To", 1, 0, Val(txtAmount.Text), 1, "Y")

    '    'Debit accounts 
    '    fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpWithdrawldate.Value, "Cheque Withdraw By Account " & txtAccNo.Text, "By", 10, Val(txtAmount.Text), 0, 2, "Y")
    '    Return True


    'End Function

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpWithdrawldate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        Dim strNarration As String = "Stop Pay By " & txtAccNo.Text & "on Cheque no " & Trim(txtSBChequeNo.Text) & " Narration:" & txtNarration.Text

        'Transaction Entry
        Dim strsql1 = "insert into sbchequeleaftbl(Book_SNo,ChequeNo,Status,Remarks,Charges) values('" & Trim(txtBookNo.Text) & "','" & Trim(txtSBChequeNo.Text) & "','Stopped','" & Trim(txtNarration.Text) & "','" & txtAmount.Text & "')"
        fnExecuteNonQuery(strsql1, objTrans)

        If Val(txtAmount.Text) <> 0 Then

            If chkSB.Checked = True Then

                Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
                strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpWithdrawldate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtAmount.Text) & "','" & Trim(txtRefNo.Text) & "','" & lngVoucherNo & "','Cheque','" & txtSBChequeNo.Text & "' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
                fnExecuteNonQuery(strsql, objTrans)

                'voucher details
                fnVoucherEnterMain(lngVoucherNo, 7, txtAccNo.Text, txtRefNo.Text, dtpWithdrawldate.Value, txtAmount.Text, "Stop Pay Charges (" & Trim(txtSBChequeNo.Text) & ")  By " & txtAccNo.Text, lngSlNo, "Y", objTrans)

                'Credit accounts
                fnVoucherEnterSub(lngVoucherNo, 7, "", dtpWithdrawldate.Value, "Stop pay by account " & txtAccNo.Text & " on ChequeNo" & txtSBChequeNo.Text & " " & txtAccNo.Text, "To", 13, 0, Val(txtAmount.Text), 1, "Y", objTrans)

                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 7, txtAccNo.Text, dtpWithdrawldate.Value, "Stop pay by account " & txtAccNo.Text & " on ChequeNo " & txtSBChequeNo.Text & "  " & txtAccNo.Text, "By", 10, Val(txtAmount.Text), 0, 2, "Y", objTrans)
            Else
                'voucher details
                fnVoucherEnterMain(lngVoucherNo, 2, txtAccNo.Text, txtRefNo.Text, dtpWithdrawldate.Value, txtAmount.Text, "Stop Pay Charges (" & Trim(txtSBChequeNo.Text) & ")  By " & txtAccNo.Text, lngSlNo, "Y", objTrans)

                'Credit accounts
                fnVoucherEnterSub(lngVoucherNo, 2, "", dtpWithdrawldate.Value, "Stop pay by account " & txtAccNo.Text & " on ChequeNo" & txtSBChequeNo.Text & " " & txtAccNo.Text, "To", 13, 0, Val(txtAmount.Text), 1, "Y", objTrans)

                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 2, txtAccNo.Text, dtpWithdrawldate.Value, "Stop pay by account " & txtAccNo.Text & " on ChequeNo " & txtSBChequeNo.Text & "  " & txtAccNo.Text, "By", 1, Val(txtAmount.Text), 0, 2, "Y", objTrans)

            End If
        End If
        Return True
    End Function
    Function fnCheckBalance() As Boolean
        'If lblAvalBal.Text - Val(txtAmount.Text) < 0 Then
        If chkSB.Checked = True Then
            If objSavingsBank.fnGetSBAccountDetails(txtAccNo.Text) Then
                If objSavingsBank.SBAccTable.Rows(0).Item("AvailBalance") < Val(txtAmount.Text) Then
                    MsgBox("Low balance,can not use SB Account for bank Charges", MsgBoxStyle.Exclamation, "SB Module")
                    txtAmount.Focus()
                    Return False
                Else
                    Return True
                End If
            End If
        Else
            Return True
        End If

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
        ElseIf Trim(txtAmount.Text) = String.Empty Then
            MsgBox("Enter amount", MsgBoxStyle.Information)
            txtAmount.Focus()
            Return False
        ElseIf Trim(txtRefNo.Text) = String.Empty Then
            MsgBox("Enter reference number", MsgBoxStyle.Information)
            txtRefNo.Focus()
            Return False
        ElseIf Trim(txtName.Text) = String.Empty Then
            MsgBox("Enter name", MsgBoxStyle.Information)
            txtName.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Function fnSetData() As Boolean
        objSavingsBank.SBNo = Trim(txtAccNo.Text)
        objSavingsBank.ChequeNo = txtSBChequeNo.Text
        objSavingsBank.ChequeDepositDate = dtpWithdrawldate.Value
        objSavingsBank.ChequeAmount = txtAmount.Text
        objSavingsBank.Remarks = txtNarration.Text
        Return True
    End Function

    Function fnGetCheqkExistance()
        If objSavingsBank.fnGetCheckDet(Trim(txtSBChequeNo.Text), Trim(txtAccNo.Text)) Then
            Return True
        Else
            MsgBox("Cheque no " & Trim(txtSBChequeNo.Text) & " Dosent Belong to Account " & Trim(txtAccNo.Text))
            Return False
        End If
    End Function

#End Region

#Region " EVENTS"

    Private Sub txtSBChequeNo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSBChequeNo.Leave
        If Trim(txtSBChequeNo.Text) <> "" Then
            If objSavingsBank.fnGetChecks(Trim(txtSBChequeNo.Text)) = True Then
                txtAccNo.Text = objSavingsBank.SBCheckBookBookTable.Rows(0).Item("AccountNo")
                txtBookNo.Text = objSavingsBank.SBCheckBookBookTable.Rows(0).Item("Book_SNo")
                txtName.Text = objSavingsBank.SBCheckBookBookTable.Rows(0).Item("Name")
                sbLoadDetails()
            Else
                MsgBox("Sorry! cheque is from other bank ", MsgBoxStyle.Critical)
                txtSBChequeNo.Focus()
                txtSBChequeNo.SelectAll()
            End If
        End If
    End Sub

    Private Sub btnVerifyPhotoSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerifyPhotoSign.Click
        If txtAccNo.Text <> String.Empty Then
            Dim ObjPhotoSign As New frmSBSignPhoto
            ObjPhotoSign.txtAccno.Text = Me.txtAccNo.Text
            ObjPhotoSign.txtName.Text = Me.txtName.Text
            ObjPhotoSign.ShowDialog(Me)
        Else
            MsgBox("Enter account number", MsgBoxStyle.Information, "SB Module")
            txtAccNo.Focus()
        End If
    End Sub
    Private Function fnCheckStopChequeStatus() As Boolean
        If objSavingsBank.fnCheckChequeLeafNo(txtSBChequeNo.Text) Then
            If objSavingsBank.SBCheckBookBookTable.Rows(0).Item("Status") = "Stopped" Then
                MsgBox("Sorry! cheque is alreadt stopped", MsgBoxStyle.Critical)
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function

    Private Function fnCheckChequeStatus() As Boolean
        If objSavingsBank.fnGetDepositedCheque(txtSBChequeNo.Text) Then
            MsgBox("Sorry! cheque is already exist" & objSavingsBank.ChequedetailsTable.Rows(0).Item("ChequeStatus"), MsgBoxStyle.Critical)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnWithDraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithDraw.Click

        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnGetCheqkExistance() Then
                    If fnCheckStopChequeStatus() Then
                        If fnCheckChequeStatus() Then
                            If fnSetData() Then
                                If fnCheckBalance() Then
                                    If MsgBox("SB accountno :" & txtAccNo.Text & " " & Chr(13) & " WithDraw Amount :" & txtAmount.Text & " " & Chr(13) & " Cheque No : " & txtSBChequeNo.Text) = MsgBoxResult.OK Then

                                        fnGenerateVoucher(objTrans)
                                        fnLogEntry(pbUserId, "Cheque stop by " & txtAccNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction stop cheque", objTrans)
                                        objTrans.Commit()
                                        If MsgBox("Transaction completed sucessfully do you want make another transaction", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                                            sbClear()
                                            sbLoadDetails()
                                        Else
                                            Me.Close()
                                        End If
                                    End If
                                End If
                            End If
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
        Dim objSBAccSearch As New frmSBAccSearch
        objSBAccSearch.strSBAccountNo = String.Empty
        objSBAccSearch.ShowDialog(Me)
        If objSBAccSearch.strSBAccountNo <> String.Empty Then
            txtAccNo.Text = objSBAccSearch.strSBAccountNo
            sbLoadDetails()
        End If
        objSBAccSearch.Dispose()
    End Sub

#End Region

#Region "Sub Routines"

    Sub sbLoadDetails()
        Try
            If objSavingsBank.fnGetSBAccountDetails(Trim(txtAccNo.Text)) = True Then
                txtAccNo.Text = objSavingsBank.SBAccTable.Rows(0).Item("AccountNo")
                dblBookAmount = objSavingsBank.SBAccTable.Rows(0).Item("BookBalance")
                lblBookBal.Text = Format(dblBookAmount, "0,00.00")
                dblAvalAmount = objSavingsBank.SBAccTable.Rows(0).Item("AvailBalance")
                lblAvalBal.Text = Format(dblAvalAmount, "0,00.00")
            Else
                MsgBox("Account number does not exist!", MsgBoxStyle.Exclamation, Me.Text)
                txtAccNo.Focus()
                sbClear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub sbClear()
        txtSBChequeNo.ResetText()
        txtAccNo.ResetText()
        txtName.ResetText()
        txtAmount.ResetText()
        txtNarration.ResetText()
        txtRefNo.ResetText()
        txtBookNo.ResetText()
        lblAvalBal.Text = 0.0
        lblBookBal.Text = 0.0
    End Sub
#End Region

    Private Sub frmSBChequeWithdraw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpWithdrawldate.Value = Date.Now
        If txtAccNo.Text <> "" Then
            sbLoadDetails()
        End If
    End Sub

End Class
