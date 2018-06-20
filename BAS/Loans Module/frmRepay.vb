Imports System.Math

Public Class frmRepay
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
    Friend WithEvents lvPaidDet As System.Windows.Forms.ListView
    Friend WithEvents dtpPayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents rtpRemarks As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtChalanNo As BankControls.NumericControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtReferenceNo As BankControls.NumericControl
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbLoanType As System.Windows.Forms.ComboBox
    Friend WithEvents NewButton1 As BankControls.NewButton
    Friend WithEvents txtReceiptnO As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lvPaidDet = New System.Windows.Forms.ListView
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.rtpRemarks = New System.Windows.Forms.RichTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtChalanNo = New BankControls.NumericControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtReferenceNo = New BankControls.NumericControl
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.btnCancel = New BankControls.NewButton
        Me.btnOk = New BankControls.NewButton
        Me.dtpPayDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnClose = New BankControls.NewButton
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbLoanType = New System.Windows.Forms.ComboBox
        Me.NewButton1 = New BankControls.NewButton
        Me.txtReceiptnO = New BankControls.NumericControl
        Me.SuspendLayout()
        '
        'lvPaidDet
        '
        Me.lvPaidDet.CheckBoxes = True
        Me.lvPaidDet.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18})
        Me.lvPaidDet.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.lvPaidDet.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(64, Byte))
        Me.lvPaidDet.FullRowSelect = True
        Me.lvPaidDet.GridLines = True
        Me.lvPaidDet.Location = New System.Drawing.Point(16, 80)
        Me.lvPaidDet.MultiSelect = False
        Me.lvPaidDet.Name = "lvPaidDet"
        Me.lvPaidDet.Size = New System.Drawing.Size(592, 272)
        Me.lvPaidDet.TabIndex = 4
        Me.lvPaidDet.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "SlNo."
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Loan No."
        Me.ColumnHeader15.Width = 100
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Name"
        Me.ColumnHeader16.Width = 200
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Sanc Amt."
        Me.ColumnHeader17.Width = 100
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Balance"
        Me.ColumnHeader18.Width = 100
        '
        'rtpRemarks
        '
        Me.rtpRemarks.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.rtpRemarks.Location = New System.Drawing.Point(80, 360)
        Me.rtpRemarks.MaxLength = 100
        Me.rtpRemarks.Name = "rtpRemarks"
        Me.rtpRemarks.Size = New System.Drawing.Size(224, 80)
        Me.rtpRemarks.TabIndex = 5
        Me.rtpRemarks.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 360)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 18)
        Me.Label8.TabIndex = 659
        Me.Label8.Text = "Remarks"
        '
        'txtChalanNo
        '
        Me.txtChalanNo.AfterDecimal = 0
        Me.txtChalanNo.BeforeDecimal = 10
        Me.txtChalanNo.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtChalanNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtChalanNo.Location = New System.Drawing.Point(456, 432)
        Me.txtChalanNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtChalanNo.MaxLength = 10
        Me.txtChalanNo.MaxValue = 9999999999999
        Me.txtChalanNo.MinValue = 0
        Me.txtChalanNo.Name = "txtChalanNo"
        Me.txtChalanNo.Size = New System.Drawing.Size(152, 23)
        Me.txtChalanNo.TabIndex = 8
        Me.txtChalanNo.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(336, 434)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 19)
        Me.Label4.TabIndex = 658
        Me.Label4.Text = "Challan No. :"
        '
        'txtReferenceNo
        '
        Me.txtReferenceNo.AfterDecimal = 0
        Me.txtReferenceNo.BeforeDecimal = 10
        Me.txtReferenceNo.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtReferenceNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReferenceNo.Location = New System.Drawing.Point(456, 368)
        Me.txtReferenceNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReferenceNo.MaxValue = 9999999999999
        Me.txtReferenceNo.MinValue = 0
        Me.txtReferenceNo.Name = "txtReferenceNo"
        Me.txtReferenceNo.Size = New System.Drawing.Size(152, 23)
        Me.txtReferenceNo.TabIndex = 6
        Me.txtReferenceNo.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(336, 370)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 19)
        Me.Label9.TabIndex = 654
        Me.Label9.Text = "Reference No. :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label16.Location = New System.Drawing.Point(336, 402)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 19)
        Me.Label16.TabIndex = 656
        Me.Label16.Text = "Receipt No. :"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(239, Byte), CType(238, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(328, 496)
        Me.btnCancel.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 40)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "&Reset"
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.SystemColors.Control
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(239, Byte), CType(238, Byte))
        Me.btnOk.Location = New System.Drawing.Point(424, 496)
        Me.btnOk.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(88, 40)
        Me.btnOk.TabIndex = 10
        Me.btnOk.Text = "&Save"
        '
        'dtpPayDate
        '
        Me.dtpPayDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpPayDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpPayDate.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.dtpPayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPayDate.Location = New System.Drawing.Point(456, 16)
        Me.dtpPayDate.Name = "dtpPayDate"
        Me.dtpPayDate.Size = New System.Drawing.Size(152, 23)
        Me.dtpPayDate.TabIndex = 2
        Me.dtpPayDate.Value = New Date(2008, 10, 13, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(400, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 19)
        Me.Label3.TabIndex = 631
        Me.Label3.Text = "Date"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnClose.Location = New System.Drawing.Point(520, 496)
        Me.btnClose.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 40)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "&Close"
        '
        'CheckBox1
        '
        Me.CheckBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(24, 48)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(88, 24)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Select all"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 462)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(592, 24)
        Me.ProgressBar1.TabIndex = 661
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 663
        Me.Label5.Text = "Loan Type :"
        '
        'cmbLoanType
        '
        Me.cmbLoanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoanType.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.cmbLoanType.ForeColor = System.Drawing.Color.Black
        Me.cmbLoanType.ItemHeight = 16
        Me.cmbLoanType.Items.AddRange(New Object() {"All", "Jewel loan", "Vehicle loan", "Surety loan", "Hand loan", "Colleteral hand loan", "Loans on term deposit"})
        Me.cmbLoanType.Location = New System.Drawing.Point(112, 15)
        Me.cmbLoanType.Name = "cmbLoanType"
        Me.cmbLoanType.Size = New System.Drawing.Size(176, 24)
        Me.cmbLoanType.TabIndex = 0
        '
        'NewButton1
        '
        Me.NewButton1.BackColor = System.Drawing.SystemColors.Control
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.NewButton1.ForeColor = System.Drawing.Color.Black
        Me.NewButton1.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(239, Byte), CType(238, Byte))
        Me.NewButton1.Location = New System.Drawing.Point(296, 11)
        Me.NewButton1.LostFocusColour = System.Drawing.SystemColors.Control
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(56, 32)
        Me.NewButton1.TabIndex = 1
        Me.NewButton1.Text = "&Load"
        '
        'txtReceiptnO
        '
        Me.txtReceiptnO.AfterDecimal = 0
        Me.txtReceiptnO.BeforeDecimal = 10
        Me.txtReceiptnO.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtReceiptnO.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptnO.Location = New System.Drawing.Point(456, 400)
        Me.txtReceiptnO.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReceiptnO.MaxValue = 9999999999999
        Me.txtReceiptnO.MinValue = 0
        Me.txtReceiptnO.Name = "txtReceiptnO"
        Me.txtReceiptnO.Size = New System.Drawing.Size(152, 23)
        Me.txtReceiptnO.TabIndex = 7
        Me.txtReceiptnO.Text = ""
        '
        'frmRepay
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(624, 543)
        Me.Controls.Add(Me.txtReceiptnO)
        Me.Controls.Add(Me.NewButton1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbLoanType)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lvPaidDet)
        Me.Controls.Add(Me.dtpPayDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.rtpRemarks)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtReferenceNo)
        Me.Controls.Add(Me.txtChalanNo)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRepay"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monthly Interest"
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Golble Variables"

    Dim objclsRepayment As New clsRePayment
    Dim objclsDisb As New clsDisbursment
    Dim intMaxAmt As Integer
    Dim intSancAmt As Integer
    Dim intcalInterest As Double
    Dim intDueDate As Integer
    Dim intInterestDiff As Integer
    Dim decROI As Double
    Dim intCalPenel As Integer
    Dim lstvItems As ListViewItem
    Dim intAmount As Integer
    Dim intTotalInterest As Integer
    Dim intTotalPenal As Integer

    Dim lngVoucher As Long

    Dim datFromDate As Date
    Dim datToDate As Date
    Dim dblBalance As Double

    Dim datLoanDate As Date
    Dim datLoanInst As Date
    Dim intNOD As Integer
    Dim intNODPenal As Integer

    Dim dblIntReceivable As Double
    Dim dblCoverAmount As Double
    Dim dvLoanList As DataView
    Dim dblFinalInterest As Double
    Dim strLoanNo As String



#End Region

#Region "Functions"

    Public Function fnClearData() As Boolean

        txtChalanNo.Text = ""
        rtpRemarks.Text = ""
        txtReceiptnO.ResetText()
        txtReferenceNo.ResetText()
        txtReceiptnO.ResetText()

        dblIntReceivable = 0
        intMaxAmt = 0
        intSancAmt = 0
        intcalInterest = 0
        intInterestDiff = 0
        decROI = 0
        intCalPenel = 0
        intAmount = 0
        intTotalInterest = 0
        intTotalPenal = 0
        lngVoucher = 0
        intNOD = 0
        intNODPenal = 0
        lvPaidDet.Items.Clear()
        ProgressBar1.Value = 0

        Return True

    End Function


    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        'Loan Repayment With Securety Deposit Dr to repay Loan 

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        Dim strLoan As String
        Dim dblRemPrinciple As Double
        Dim intLedgerNo As Integer = 0

        lngVoucherNo = fnVoucherGetNewVNo(dtpPayDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()
        lngVoucher = lngVoucherNo

        objclsRepayment.fnAddData(lngVoucher, objTrans)

        Dim strNarration As String = "Monthly loan interest by " & strLoanNo & "  narration:" & rtpRemarks.Text

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, strLoanNo, txtReferenceNo.Text, dtpPayDate.Value, Val(dblFinalInterest), "Debited by " & strLoanNo, lngSlNo, "Y", objTrans)

        strLoan = Mid(strLoanNo, 1, 2)
        Select Case strLoan
            Case "JL"
                intLedgerNo = "15"
            Case "LM"
                intLedgerNo = "16"
            Case "HL"
                intLedgerNo = "17"
            Case "SL"
                intLedgerNo = "18"
            Case "CH"
                intLedgerNo = "19"
            Case "LT"
                intLedgerNo = "20"
            Case "SD"
                intLedgerNo = "43"
        End Select

        'Credit Interest on Loan
        fnVoucherEnterSub(lngVoucherNo, 2, strLoanNo, dtpPayDate.Value, "Interest to be paid by account " & strLoanNo, "To", 59, 0, Val(dblFinalInterest), 2, "Y", objTrans)

        'Loan Account /Debit
        fnVoucherEnterSub(lngVoucherNo, 2, strLoanNo, dtpPayDate.Value, "Interest debited to account " & strLoanNo, "By", intLedgerNo, Val(dblFinalInterest), 0, 3, "Y", objTrans)

        Return True

    End Function

    Public Function fnSetData() As Boolean
        Dim strTemp As String
        Dim datTemp As Date
        Dim strLoan As String

        objclsRepayment.LoanNo = strLoanNo
        objclsRepayment.Remarks = rtpRemarks.Text
        objclsRepayment.ChallanNo = txtChalanNo.Text

        objclsRepayment.VoucherNo = 0
        objclsRepayment.Others = 0
        objclsRepayment.Debit = Val(dblFinalInterest)
        objclsRepayment.Credit = 0
        objclsRepayment.IntrestPaid = 0

        objclsRepayment.Intrest = Val(dblFinalInterest)
        objclsRepayment.PenelIntrest = 0
        objclsRepayment.IntCOver = 0

        objclsRepayment.FromDate = Format(datFromDate, "yyyy-MM-dd")
        objclsRepayment.ToDate = Format(datToDate, "yyyy-MM-dd")
        objclsRepayment.PaidDate = Format(dtpPayDate.Value, "yyyy-MM-dd")
        objclsRepayment.LastInstDate = datToDate

        objclsRepayment.Amount = Val(dblFinalInterest)

        'Interest Receivable
        objclsRepayment.IntReceivable = Val(dblIntReceivable) + Val(dblFinalInterest)

        If txtReferenceNo.Text = "" Then
            objclsRepayment.ReferenceNo = 0
        Else
            objclsRepayment.ReferenceNo = txtReferenceNo.Text
        End If

        If objclsRepayment.fnMaxNo(strLoanNo) Then
            objclsRepayment.InstNo = objclsRepayment.MaxInstNoTable.Rows(0).Item("InstNo") + 1
        End If

        If fnSetBalance() Then

        End If

        Return True
    End Function

    Public Function fnSetBalance() As Boolean

        '   '   ' *********** fucntion to calculate the balance amount 
        '   '   ' *********** cond to check the weather pervious balance is paid
        If objclsRepayment.fnMaxNo(strLoanNo) Then
            If objclsRepayment.MaxInstNoTable.Rows(0).Item("PaidAmount") = 0 Then
                objclsRepayment.Balance = objclsRepayment.PaymentTable.Rows(0).Item("Balance") - objclsRepayment.Credit + objclsRepayment.Debit
            Else
                objclsRepayment.Balance = objclsRepayment.PaymentTable.Rows(0).Item("Balance") - (objclsRepayment.Credit - objclsRepayment.Debit)
            End If
        End If
        Return True

    End Function

    Public Function fncalculate() As Boolean
        Dim intCOunter As Integer = 1
        Dim datNextDate As Date = datLoanDate
        Dim intNOD As Integer
        intcalInterest = 0
        intCalPenel = 0

        Dim strLoan As String
        Dim datTemp As Date
        Dim str As String = objclsRepayment.PaymentTable.Rows(0).Item("Type")

        strLoan = Mid(strLoanNo, 1, 2)

        If strLoan = "SD" Then
            intcalInterest = 0
        Else

            intInterestDiff = DateDiff(DateInterval.Month, datFromDate, datToDate)
            While intInterestDiff >= intCOunter
                datNextDate = DateAdd(DateInterval.Month, 2, datLoanDate)
                datNextDate = datNextDate.AddDays(-(datNextDate.Day))
                If datNextDate > datToDate Then
                    datNextDate = datToDate
                End If
                intNOD = DateDiff(DateInterval.Day, datLoanDate, datNextDate)
                intcalInterest += Math.Round((((dblBalance + intcalInterest + intCalPenel) * intNOD * decROI) / 365), 2)
                datLoanDate = datNextDate
                intCOunter += 1
            End While
            intNOD = DateDiff(DateInterval.Day, datNextDate, datToDate)
            If intNOD > 0 Then
                intcalInterest += Math.Round((((dblBalance + intcalInterest + intCalPenel) * intNOD * decROI) / 365), 2)
            End If

        End If

    End Function

    Public Function fnCheck() As Boolean
        Dim strLoan As String
        If cmbLoanType.SelectedIndex = -1 Then
            MsgBox("Please select loan type", MsgBoxStyle.Information)
            cmbLoanType.Focus()
            Return False
        ElseIf rtpRemarks.Text = "" Then
            MsgBox("Emter remarks", MsgBoxStyle.Exclamation)
            rtpRemarks.Focus()
            Return False
        ElseIf txtReferenceNo.Text = String.Empty Then
            MsgBox("Enter reference number", MsgBoxStyle.Exclamation)
            txtReferenceNo.Focus()
            Return False
        ElseIf txtReceiptnO.Text = String.Empty Then
            MsgBox("Enter receipt number", MsgBoxStyle.Exclamation)
            txtReceiptnO.Focus()
            Return False
        ElseIf txtChalanNo.Text = "" Then
            MsgBox("Enter challan no", MsgBoxStyle.Exclamation)
            txtChalanNo.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    'Working Correctly loan intrest calculation without month end 31st Day calculation

    Public Function fnCalcInterest() As Boolean
        Dim strLoan As String

        Dim intDate3 As Integer
        Dim intDate4 As Integer
        Dim intCount As Integer = 0
        Dim intCalInterest1 As Integer = 0
        Dim intCalInterest2 As Integer = 0
        Dim dvDisb As DataView
        Dim dblTempAmount As Double

        'For SB Transfer
        dblBalance = 0
        intcalInterest = 0
        intCalPenel = 0
        intTotalInterest = 0
        intTotalPenal = 0

        If objclsRepayment.fnGetData(strLoanNo) Then

        End If

        objclsRepayment.fnGetPaidDet(strLoanNo)

        '   '   '**To check weather it is first repayment of loan
        '   '   'If it is first repayment then second condition is checked weather the disbursment of the loan is
        '   '   'done once or many times.If it is done 2 times then the cal in If part is executed else
        '   '   'if cal in corresponding else part will get executed.
        '   '   'Same for payment of loan if the payment of loan is second time then disbursment is not checked.direct
        '   '   'direct corresponding else part gets executed.

        objclsDisb.fnCheckDis(strLoanNo)

        dblIntReceivable = objclsRepayment.PaymentTable.Rows(0).Item("IntReceivable")
        decROI = objclsRepayment.PaymentTable.Rows(0).Item("ROI")

        If objclsRepayment.fnGetDisb(strLoanNo) Then
            dvDisb = New DataView(objclsRepayment.disbtable, "", "", DataViewRowState.OriginalRows)
            dvDisb.RowFilter = "DisbUsability='N'"
            If dvDisb.Count > 0 Then
                While intCount < dvDisb.Count
                    datLoanDate = DateAdd(DateInterval.Day, -1, dvDisb.Item(intCount).Item("DisbDate"))
                    datFromDate = dvDisb.Item(intCount).Item("DisbDate")

                    datToDate = dtpPayDate.Value

                    dblBalance = dvDisb.Item(intCount).Item("Amount")
                    dblTempAmount += dblBalance
                    fncalculate()
                    intTotalInterest += intcalInterest
                    intTotalPenal += intCalPenel
                    intCount += 1
                End While
                dvDisb.RowFilter = "DisbUsability='Y'"
                If dvDisb.Count > 0 Then
                    datLoanDate = objclsRepayment.PaymentTable.Rows(0).Item("LastInstDate")
                    datFromDate = DateAdd(DateInterval.Day, 1, objclsRepayment.PaymentTable.Rows(0).Item("LastInstDate"))
                    dblBalance = objclsRepayment.PaymentTable.Rows(0).Item("Balance") - dblTempAmount
                    datToDate = dtpPayDate.Value
                    fncalculate()
                    intTotalInterest += intcalInterest
                    intTotalPenal += intCalPenel
                End If
            Else
                datLoanDate = objclsRepayment.PaymentTable.Rows(0).Item("LastInstDate")
                datFromDate = DateAdd(DateInterval.Day, 1, objclsRepayment.PaymentTable.Rows(0).Item("LastInstDate"))
                datToDate = dtpPayDate.Value
                dblBalance = objclsRepayment.PaymentTable.Rows(0).Item("Balance")
                fncalculate()
                intTotalInterest += intcalInterest
                intTotalPenal += intCalPenel
            End If

            dblFinalInterest = Math.Round(intTotalInterest) + dblCoverAmount

        End If

        Return True

    End Function

    Public Function fnCheckReceiptNo() As Boolean

        If objclsRepayment.fnCheckReceiptNo(txtReceiptnO.Text) Then

            MsgBox("Receipt no, already exist", MsgBoxStyle.Information)

            Return False
        Else
            Return True

        End If

    End Function

    Public Function fnAddDataList() As Boolean

        Dim intCount As Integer
        While intCount < dvLoanList.Count
            lstvItems = (lvPaidDet.Items.Add(intCount + 1))
            lstvItems.SubItems.Add(dvLoanList.Item(intCount).Item("LoanNo"))
            lstvItems.SubItems.Add(dvLoanList.Item(intCount).Item("Name"))
            lstvItems.SubItems.Add(Format(dvLoanList.Item(intCount).Item("SancAmount"), "0,00.00"))
            lstvItems.SubItems.Add(Format(dvLoanList.Item(intCount).Item("Balance"), "0,00.00"))
            intCount += 1

        End While

    End Function

    Public Function fnCheckAmount() As Boolean

        If objclsRepayment.fnMaxAmount(strLoanNo) Then
            intMaxAmt = objclsRepayment.MaxAmountTable.Rows(0).Item("Amount")
            If intMaxAmt = 0 Then
                Return False
            Else
                Return True
            End If
        End If
    End Function

    Public Function fnSaveData(ByVal objTrans As IDbTransaction) As Boolean
        Dim dvDisb As DataView
        Dim intCount As Integer = 0


        If objclsRepayment.fnUpdataLoanDate(strLoanNo, objTrans) Then

            fnGenerateVoucher(objTrans)

            fnLogEntry(pbUserId, "Loan monthly interest by " & strLoanNo & " Amount " & dblFinalInterest, Date.Now, "Transaction interest", objTrans)

            If objclsRepayment.fnGetDisb(strLoanNo) Then
                dvDisb = New DataView(objclsRepayment.disbtable, "", "", DataViewRowState.OriginalRows)
                dvDisb.RowFilter = "DisbUsability='N'"
                If dvDisb.Count > 0 Then
                    While intCount < dvDisb.Count
                        objclsDisb.fnUpdateDisbStatus(strLoanNo, dvDisb.Item(intCount).Item("SlNo"), objTrans)
                        intCount += 1
                    End While
                End If
            End If
            fnGetStatus()

            Return True
        End If

    End Function


    Public Function fnReportGeneration() As Boolean

        Dim objReportViewer As New frmReportViewer
        objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/ReceiptKan.rpt"
        objReportViewer.CrystalReportViewer1.SelectionFormula = "{receiptmaintbl.ReceiptNo}='" & txtReceiptnO.Text & "' and {ReceiptMainTbl.ReceiptDate}=#" & Format(dtpPayDate.Value, "MM-dd-yyyy") & "#"
        objReportViewer.ShowDialog()
        objReportViewer.Dispose()

    End Function

    Public Function fnGetStatus() As Boolean

        If objclsRepayment.fnGetROI(strLoanNo) Then

            If objclsRepayment.LoanTypetable.Rows(0).Item("SancAmount") = objclsRepayment.LoanTypetable.Rows(0).Item("DisbAmount") Then

                If objclsRepayment.LoanTypetable.Rows(0).Item("Balance") = 0 Then

                    If objclsRepayment.fnUpdateStatus(strLoanNo) Then

                    End If
                End If
            End If
        End If
    End Function

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmRePayement_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dtpPayDate.Value = Date.Now.Date
      
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        Dim intCount As Integer
        Dim objTrans As IDbTransaction
        ProgressBar1.Value = 0
        If fnCheck() Then
            If lvPaidDet.CheckedItems.Count > 0 Then
                Try
                    ProgressBar1.Maximum = lvPaidDet.Items.Count
                    objTrans = fnGetTransaction()
                    For Each lvitem As ListViewItem In lvPaidDet.Items
                        If lvitem.Checked = True Then
                            strLoanNo = lvitem.SubItems(1).Text
                            If fnCheckAmount() Then
                                If fnCalcInterest() Then
                                    If Val(dblFinalInterest) <> 0 Then
                                        If fnSetData() Then
                                            If fnSaveData(objTrans) Then
                                                ProgressBar1.Value += 1
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    Next
                    objTrans.Commit()
                    MsgBox("Amount paid sccessfully", MsgBoxStyle.Information, "Re-Payment Module")
                    fnClearData()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                Finally
                    objTrans.Dispose()
                End Try
            Else
                MsgBox("No items is selected from the list")
                lvPaidDet.Focus()
            End If
        End If

    End Sub

    Private Sub btnReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim objReportViewer As New frmReportViewer
        objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/CrystalReport1.rpt"
        objReportViewer.ShowDialog()
        objReportViewer.Dispose()

    End Sub


#Region "Navigation"

    Private Sub lvPaidDet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvPaidDet.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub rtpRemarks_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtAmount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtChalanNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtInterest_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtLoanNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtOthers_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtPenelInterest_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtPrinciple_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtPrincipleAmount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtReferenceNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        fnClearData()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            If lvPaidDet.Items.Count > 0 Then
                For Each lvItems As ListViewItem In lvPaidDet.Items
                    lvItems.Checked = True
                Next
            End If
        Else
            If lvPaidDet.Items.Count > 0 Then
                For Each lvItems As ListViewItem In lvPaidDet.Items
                    lvItems.Checked = False
                Next
            End If
        End If

       

    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click

        If cmbLoanType.SelectedIndex = -1 Then
            MsgBox("Please select loan type", MsgBoxStyle.Information)
            cmbLoanType.Focus()
            Return
        End If

        lvPaidDet.Items.Clear()

        Dim str As String = cmbLoanType.SelectedItem
        Dim strType As String
        Select Case str
            Case "Jewel loan"
                strType = "JL"
            Case "Vehicle loan"
                strType = "LMV"
            Case "Surety loan"
                strType = "SL"
            Case "Hand loan"
                strType = "HL"
            Case "Colleteral hand loan"
                strType = "CHL"
            Case "Loans on term deposit"
                strType = "LTD"
            Case "All"
                strType = ""
        End Select

        If objclsRepayment.fnGetActiveLoanAccount(strType) Then
            dvLoanList = New DataView(objclsRepayment.LoanTypetable)
            fnAddDataList()
        End If


    End Sub
End Class
