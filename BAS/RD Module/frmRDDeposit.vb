Imports System.IO

Public Class frmRDDeposit
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As BankControls.TextControl
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents btnDeposit As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents dtpDepositDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRefNo As BankControls.NumericControl
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents txtRDAccNo As BankControls.TextControl
    Friend WithEvents txtRDName As BankControls.TextControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOthers As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRDDeposit))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtOthers = New BankControls.NumericControl
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtRDName = New BankControls.TextControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNarration = New BankControls.TextControl
        Me.txtAmount = New BankControls.NumericControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtRDAccNo = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.txtRefNo = New BankControls.NumericControl
        Me.btnDeposit = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.dtpDepositDate = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblBalance = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtOthers)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtRDName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNarration)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtRDAccNo)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtRefNo)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 160)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Holder Details"
        '
        'txtOthers
        '
        Me.txtOthers.AfterDecimal = 0
        Me.txtOthers.BeforeDecimal = 7
        Me.txtOthers.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOthers.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOthers.Location = New System.Drawing.Point(128, 128)
        Me.txtOthers.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOthers.MaxLength = 7
        Me.txtOthers.MaxValue = 0
        Me.txtOthers.MinValue = 0
        Me.txtOthers.Name = "txtOthers"
        Me.txtOthers.Size = New System.Drawing.Size(168, 23)
        Me.txtOthers.TabIndex = 6
        Me.txtOthers.Text = ""
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 18)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Other Charges :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(304, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 18)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Reference No. : "
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 18)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Name :"
        '
        'txtRDName
        '
        Me.txtRDName.AlphaNumeric = False
        Me.txtRDName.AutoSize = False
        Me.txtRDName.BlankSpace = False
        Me.txtRDName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRDName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRDName.Location = New System.Drawing.Point(128, 64)
        Me.txtRDName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRDName.Mandatory = False
        Me.txtRDName.Name = "txtRDName"
        Me.txtRDName.ReadOnly = True
        Me.txtRDName.Size = New System.Drawing.Size(168, 20)
        Me.txtRDName.SpecialChar = False
        Me.txtRDName.TabIndex = 3
        Me.txtRDName.TabStop = False
        Me.txtRDName.Text = ""
        '
        'Label3
        '
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Narration : "
        '
        'txtNarration
        '
        Me.txtNarration.AlphaNumeric = True
        Me.txtNarration.BlankSpace = True
        Me.txtNarration.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNarration.Location = New System.Drawing.Point(432, 64)
        Me.txtNarration.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNarration.Mandatory = False
        Me.txtNarration.MaxLength = 100
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarration.Size = New System.Drawing.Size(200, 64)
        Me.txtNarration.SpecialChar = False
        Me.txtNarration.TabIndex = 8
        Me.txtNarration.Text = ""
        '
        'txtAmount
        '
        Me.txtAmount.AfterDecimal = 0
        Me.txtAmount.BeforeDecimal = 7
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmount.Location = New System.Drawing.Point(128, 96)
        Me.txtAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAmount.MaxLength = 7
        Me.txtAmount.MaxValue = 0
        Me.txtAmount.MinValue = 0
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(168, 23)
        Me.txtAmount.TabIndex = 5
        Me.txtAmount.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Amount :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "AccountNo. :  "
        '
        'txtRDAccNo
        '
        Me.txtRDAccNo.AlphaNumeric = True
        Me.txtRDAccNo.BlankSpace = False
        Me.txtRDAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRDAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRDAccNo.Location = New System.Drawing.Point(128, 32)
        Me.txtRDAccNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRDAccNo.Mandatory = False
        Me.txtRDAccNo.MaxLength = 7
        Me.txtRDAccNo.Name = "txtRDAccNo"
        Me.txtRDAccNo.ReadOnly = True
        Me.txtRDAccNo.Size = New System.Drawing.Size(120, 23)
        Me.txtRDAccNo.SpecialChar = False
        Me.txtRDAccNo.TabIndex = 3
        Me.txtRDAccNo.TabStop = False
        Me.txtRDAccNo.Text = "RD"
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
        Me.btnSearch.TabIndex = 4
        '
        'txtRefNo
        '
        Me.txtRefNo.AfterDecimal = 0
        Me.txtRefNo.BeforeDecimal = 7
        Me.txtRefNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRefNo.Location = New System.Drawing.Point(432, 32)
        Me.txtRefNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRefNo.MaxLength = 7
        Me.txtRefNo.MaxValue = 0
        Me.txtRefNo.MinValue = 0
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(200, 23)
        Me.txtRefNo.TabIndex = 7
        Me.txtRefNo.Text = ""
        '
        'btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposit.GotFocusColour = System.Drawing.Color.Beige
        Me.btnDeposit.Location = New System.Drawing.Point(416, 208)
        Me.btnDeposit.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(104, 40)
        Me.btnDeposit.TabIndex = 9
        Me.btnDeposit.Text = "&Deposit"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.GotFocusColour = System.Drawing.Color.Beige
        Me.btnCancel.Location = New System.Drawing.Point(544, 208)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 40)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "&Close"
        '
        'dtpDepositDate
        '
        Me.dtpDepositDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDepositDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDepositDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDepositDate.Location = New System.Drawing.Point(96, 8)
        Me.dtpDepositDate.Name = "dtpDepositDate"
        Me.dtpDepositDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpDepositDate.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(40, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 19)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Date :"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(320, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 24)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "Balance :"
        '
        'lblBalance
        '
        Me.lblBalance.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(448, 8)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(128, 24)
        Me.lblBalance.TabIndex = 103
        '
        'frmRDDeposit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(682, 255)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.dtpDepositDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRDDeposit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RD Deposit"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Varaibles"

    Public strAccNo As String
    Public strName As String
    Dim objRDAccount As New clsRDAccount
    Dim objclsRDAccount As New clsRDAccount
    Dim tblRdDetails As DataTable

#End Region

#Region "Functions"

    Public Function fnCheck() As Boolean
        objclsRDAccount.fnGetDetails(txtRDAccNo.Text)
        tblRdDetails = objclsRDAccount.GetRDDetailstbl
        '''Dim tempdate As String = Format(tblRdDetails.Rows(0).Item("RDMaturityDate"), "dd-MMM-yyyy").ToString()
        If txtRDAccNo.Text = "RD" And txtRDAccNo.Text = "" Then
            MsgBox("Please enter account number", MsgBoxStyle.Information)
            btnSearch.Focus()
            Return False
        ElseIf txtRDName.Text = String.Empty Then
            MsgBox("Please enter the name", MsgBoxStyle.Information)
            btnSearch.Focus()
            Return False
        ElseIf txtAmount.Text = String.Empty Then
            MsgBox("Please enter the amount to deposit", MsgBoxStyle.Information)
            txtAmount.Focus()
            Return False
        ElseIf txtRefNo.Text = String.Empty Then
            MsgBox("Reference no cannot be blank", MsgBoxStyle.Exclamation)
            txtRefNo.Focus()
            Return False
        ElseIf (dtpDepositDate.Text > Format(tblRdDetails.Rows(0).Item("RDMaturityDate"), "dd-MMM-yyyy")).ToString Then
            MsgBox("Deposit date Exceeds Maturity date", MsgBoxStyle.Information)
            dtpDepositDate.Focus()
            Return False
        Else
            Return True

        End If

    End Function

    Public Function fnCheckRefNo() As Boolean

        If objRDAccount.fnCheckRefNo(txtRefNo.Text) Then
            MsgBox("Reference no already exist,try another RefNo ", MsgBoxStyle.Information)
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnSetData() As Boolean

        objRDAccount.Amount = txtAmount.Text
        objRDAccount.Reference = txtRefNo.Text
        objRDAccount.TransDate = dtpDepositDate.Value
        objRDAccount.RDNo = txtRDAccNo.Text
        objRDAccount.Narration = txtNarration.Text

        Return True

    End Function

    Public Function fnClear()

        txtAmount.Text = ""
        txtRefNo.Text = ""
        'txtRDAccNo.Text = "RD"
        txtNarration.Text = ""
        'txtRDName.Text = ""
        btnSearch.Enabled = True
        'lblBalance.Text = "0.00"
        txtOthers.ResetText()
        fnGetBalance()

    End Function

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngvoucherno As Long
        Dim lngslno As Long

        lngvoucherno = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngslno = fnVoucherGetNewSlNo()

        'transaction entery
        objRDAccount.fnInsertTransaction(lngvoucherno, objTrans)


        If Val(txtOthers.Text) <> 0 Then

            'voucher details
            fnVoucherEnterMain(lngvoucherno, 2, txtRDAccNo.Text, txtRefNo.Text, dtpDepositDate.Value, Val(txtAmount.Text) + Val(txtOthers.Text), "Deposit by" & txtRDAccNo.Text, lngslno, "y", objTrans)

            'credit accounts
            fnVoucherEnterSub(lngvoucherno, 2, txtRDAccNo.Text, dtpDepositDate.Value, "Deposit by RD account " & txtRDAccNo.Text, "To", 29, 0, Val(txtAmount.Text), 1, "y", objTrans)

            'credit accounts
            fnVoucherEnterSub(lngvoucherno, 2, txtRDAccNo.Text, dtpDepositDate.Value, "Misc charges paid by account " & txtRDAccNo.Text, "To", 13, 0, Val(txtOthers.Text), 2, "Y", objTrans)

            'debit accounts 
            fnVoucherEnterSub(lngvoucherno, 2, " ", dtpDepositDate.Value, "Deposit by RD account " & txtRDAccNo.Text, "By", 1, Val(txtAmount.Text) + Val(txtOthers.Text), 0, 3, "y", objTrans)

        Else

            'voucher details
            fnVoucherEnterMain(lngvoucherno, 2, txtRDAccNo.Text, txtRefNo.Text, dtpDepositDate.Value, txtAmount.Text, "Deposit by" & txtRDAccNo.Text, lngslno, "y", objTrans)

            'credit accounts
            fnVoucherEnterSub(lngvoucherno, 2, txtRDAccNo.Text, dtpDepositDate.Value, "Deposit by RD account " & txtRDAccNo.Text, "To", 29, 0, Val(txtAmount.Text), 1, "y", objTrans)

            'debit accounts 
            fnVoucherEnterSub(lngvoucherno, 2, " ", dtpDepositDate.Value, "Deposit by RD account " & txtRDAccNo.Text, "By", 1, Val(txtAmount.Text), 0, 2, "y", objTrans)

        End If

        Return True

    End Function

    Public Function fnGetBalance()

        If objRDAccount.fnGetBalance(txtRDAccNo.Text) Then
            lblBalance.Text = objRDAccount.Balance.Rows(0).Item("Balance")
        End If

    End Function

#End Region

#Region "Procedure"

#End Region

#Region "Events"

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim objfrmRDCust As New frmRDCust
        objfrmRDCust.strRDNo = ""
        objfrmRDCust.ShowDialog(Me)
        If objfrmRDCust.strRDNo <> "" Then
            txtRDAccNo.Text = objfrmRDCust.strRDNo
            txtRDName.Text = objfrmRDCust.strRDName
            fnGetBalance()
        End If
        objfrmRDCust.Dispose()

    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim objfrmAgents As New frmAGAccSearch
        objfrmAgents.ShowDialog()

    End Sub

    Private Sub frmPigmyDeposit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtRDAccNo.Text = strAccNo
        dtpDepositDate.Value = Date.Now
        dtpDepositDate.MaxDate = Date.Now
        If txtRDAccNo.Text <> "RD" And txtRDAccNo.Text <> "" Then
            txtRDAccNo.Text = strAccNo
            txtRDName.Text = strName
            fnGetBalance()
        End If
    End Sub

    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnCheckRefNo() = False Then
                    If fnSetData() Then
                        fnGenerateVoucher(objTrans)
                        fnLogEntry(pbUserId, "Deposit by " & txtRDAccNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction Deposit", objTrans)
                        objTrans.Commit()
                        If MsgBox("Transaction completed successfully,do u want to do more transaction", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            fnClear()
                            dtpDepositDate.Focus()
                        Else
                            Me.Close()
                        End If
                    Else
                        MsgBox("Transaction cannot be completed,due to internal error", MsgBoxStyle.Critical, "RD Module")
                    End If
                Else
                    MsgBox("Reference no already exist,please try other reference no", MsgBoxStyle.Exclamation, "RD Module")
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

    Private Sub txtPGAccNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRDAccNo.TextChanged

        If txtRDAccNo.Text.StartsWith("RD") = False Then
            txtRDAccNo.Undo()
            txtRDAccNo.ClearUndo()
        End If

    End Sub

End Class
