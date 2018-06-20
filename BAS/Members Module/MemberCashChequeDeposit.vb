Public Class MemberCashChequeDeposit
#Region "Form Global Variables"

    Dim objMember As New clsMember
    Public strAccNo As String
    Public strName As String
    Dim lngPersonNo As Long = 0
    Dim lngVoucherNo As Long
    Dim lstvItems As ListViewItem
    Dim lngVoucher As Long
    Dim DueAmount As Integer
#End Region

    Private Sub MemberCashChequeDeposit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpDepositdate.Value = Date.Now
        txtMemberNo.Text = strAccNo
        txtName.Text = strName
    End Sub


    Private Sub btnMemberSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMemberSearch.Click
        Dim objMemberSearch As New frmMemberSearch
        objMemberSearch.strMemberNo = ""
        objMemberSearch.ShowDialog(Me)
        If objMemberSearch.strMemberNo <> "" Then
            txtMemberNo.Text = objMemberSearch.strMemberNo
            sbLoadMember()
            fnAddDataList()
        End If
        objMemberSearch.Dispose()
    End Sub
    Sub sbLoadMember()
        Dim objDT As DataTable
        Dim intCount As Integer = 0
        Dim intDeposit As Integer = 0
        Dim intDraw As Integer = 0
        Dim intTotalDeposit As Integer = 0
        Try
            'MemberClear()
            '-start --Retriving the share deposit amount
            If objMember.fnGetMemberTransaction(txtMemberNo.Text) Then
                objDT = objMember.MemberTable
                While intCount < objDT.Rows.Count
                    lstvItems = (lvMemDepositDetails.Items.Add(Format(objDT.Rows(intCount).Item("TrDate"), "yyyy-MM-dd")))
                    'lstvItems.SubItems.Add(Format(objDT.Rows(intCount).Item("Date"), "yyyy-MM-dd"))
                    intDeposit += Convert.ToInt32(objDT.Rows(intCount).Item("Deposit"))
                    intDraw += Convert.ToInt32(objDT.Rows(intCount).Item("Withdraw"))

                    intCount += 1
                End While
            End If
            '-end --Retriving the share deposit amount
            intTotalDeposit = intDeposit - intDraw
            If objMember.fnGetMemberDetails(txtMemberNo.Text) Then
                objDT = objMember.MemberTable
                'txtMemberNo.Text = objDT.Rows(0).Item("MemberNo")
                txtName.Text = objDT.Rows(0).Item("Name")
                'txtBalanceAmount.Text = Convert.ToInt32(objDT.Rows(0).Item("CallsInArrier")) - intTotalDeposit
                txtBalanceAmount.Text = Convert.ToInt32(objDT.Rows(0).Item("ShareAmount")) - intTotalDeposit
                DueAmount = Val(txtBalanceAmount.Text)
                '' txtBalanceAmount.Text = DueAmount - Val(txtPaidAmount.Text)
            End If
           



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)

        End Try
    End Sub
    Sub MemberClear()
        'txtMemberNo.ResetText()
        'txtName.ResetText()
        txtBalanceAmount.ResetText()
        txtPaidAmount.ResetText()
        txtChequeNo.ResetText()
        txtBankName.ResetText()
        txtBranchName.ResetText()
        txtReferenceNo.ResetText()
        txtRemarks.ResetText()
        ''lvMemDepositDetails.Clear()
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnSetData() Then
                    If objMember.fnCheckMember = True Then
                        objTrans = fnGetTransaction()

                        Dim lngVoucherNo As Long
                        Dim lngSlNo As Long
                        Dim strLoan As String
                        Dim dblRemPrinciple As Double
                        Dim intLedgerNo As Integer = 0
                        Dim intInterestLedgerNo As Integer = 0
                        Dim intSDLedgerNo As Integer = 0
                        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositdate.Value)
                        objMember.VoucherNo = lngVoucherNo
                        lngSlNo = fnVoucherGetNewSlNo()
                        lngVoucher = lngVoucherNo
                        Dim strNarration As String = txtRemarks.Text

                        'Dim strSQL = "INSERT INTO membertransaction(AccountNo,TrDate)"
                        'strSQL = strSQL & "Values ('" & Trim(txtMemberNo.Text) & "','" & Format(dtpDepositdate.Value, "yyyy-MM-dd") & "')"
                        'fnExecuteNonQuery(strSQL, objTrans)
                        objMember.fnInsertToMemberTransactionTbl(objTrans)
                        'voucher details
                        fnVoucherEnterMain(lngVoucherNo, 2, txtMemberNo.Text, txtReferenceNo.Text, dtpDepositdate.Value, Val(txtPaidAmount.Text), "Deposit By " & txtMemberNo.Text, lngSlNo, "Y")
                        'Credit Interest on Loan
                        fnVoucherEnterSub(lngVoucherNo, 2, txtMemberNo.Text, dtpDepositdate.Value, "Deposited by " & txtMemberNo.Text, "By", 1, Val(txtPaidAmount.Text), 0, 2, "Y")
                        'Debit The Interest Recivable of Particular loan
                        'fnVoucherEnterSub(lngVoucherNo, 2, txtMemberNo.Text, dtpDepositdate.Value, "Deposited by " & txtMemberNo.Text, "To", 176, 0, Val(txtPaidAmount.Text), 2, "Y")
                        fnVoucherEnterSub(lngVoucherNo, 2, txtMemberNo.Text, dtpDepositdate.Value, "Deposited by " & txtMemberNo.Text, "To", 184, 0, Val(txtPaidAmount.Text), 2, "Y")
                        objTrans.Commit()
                        MsgBox("Amount Paid Sccessfully", MsgBoxStyle.Information, "Member Deposit Module")
                        MemberClear()
                        fnAddDataList()
                        sbLoadMember()
                    End If
                End If
            End If
        Catch ex As Exception
            objTrans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        Finally
            objTrans.Dispose()
        End Try
    End Sub
    Public Function fnAddDataList() As Boolean
        Dim objDT As DataTable
        Dim intCount As Integer = 0
        lvMemDepositDetails.Items.Clear()
        If objMember.fnGetMemberTransaction(txtMemberNo.Text) Then
            objDT = objMember.MemberTable
            While intCount < objDT.Rows.Count
                lstvItems = (lvMemDepositDetails.Items.Add(Format(objDT.Rows(intCount).Item("TrDate"), "yyyy-MM-dd")))
                'lstvItems.SubItems.Add(Format(objDT.Rows(intCount).Item("Date"), "yyyy-MM-dd"))
                lstvItems.SubItems.Add(objDT.Rows(intCount).Item("Deposit"))
                lstvItems.SubItems.Add(objDT.Rows(intCount).Item("Withdraw"))
                lstvItems.SubItems.Add(objDT.Rows(intCount).Item("Balance"))
                lstvItems.SubItems.Add(objDT.Rows(intCount).Item("Narration"))
                lstvItems.SubItems.Add(objDT.Rows(intCount).Item("ChequeNo"))
                lstvItems.SubItems.Add(objDT.Rows(intCount).Item("BankName"))
                lstvItems.SubItems.Add(objDT.Rows(intCount).Item("BranchName"))
                lstvItems.SubItems.Add(objDT.Rows(intCount).Item("RefNo"))
                lstvItems.SubItems.Add(objDT.Rows(intCount).Item("TrDate"))
                lstvItems.SubItems.Add(objDT.Rows(intCount).Item("VoucherNo"))
                intCount += 1
            End While
        End If
    End Function


    Function fnCheck() As Boolean
        If txtMemberNo.Text = "" Then
            MsgBox("Enter member no ", MsgBoxStyle.Exclamation)
            txtMemberNo.Focus()
            Return False
        ElseIf txtBalanceAmount.Text = "" Then
            MsgBox("Enter Balance amount ", MsgBoxStyle.Exclamation)
            txtBalanceAmount.Focus()
            Return False
        ElseIf Val(txtPaidAmount.Text) <= 0 Then
            MsgBox("Enter paid amount and it should be greater than zero", MsgBoxStyle.Exclamation)
            txtPaidAmount.Focus()
            Return False
        ElseIf Val(txtPaidAmount.Text) > DueAmount Then
            MsgBox("Paid amount greater than ", MsgBoxStyle.Exclamation)
            txtPaidAmount.Focus()
            Return False
        ElseIf txtName.Text = "" Then
            MsgBox("Enter name ", MsgBoxStyle.Exclamation)
            txtName.Focus()
            Return False
        ElseIf txtReferenceNo.Text = "" Then
            MsgBox("Enter Reference number ", MsgBoxStyle.Exclamation)
            txtReferenceNo.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Function fnSetData() As Boolean

        If txtMemberNo.Text <> "" Then
            objMember.MemberNo = txtMemberNo.Text
            lngVoucherNo = fnVoucherGetNewVNo(dtpDepositdate.Value)
            objMember.ShareDate = dtpDepositdate.Value
            objMember.Name = txtName.Text
            objMember.BalanceAmount = Val(txtBalanceAmount.Text)
            objMember.AmountPaid = Val(txtPaidAmount.Text)
            objMember.ChequeNo = txtChequeNo.Text
            objMember.RefNo = txtReferenceNo.Text
            objMember.BankName = txtBankName.Text
            objMember.BranchName = txtBranchName.Text
            objMember.Remarks = txtRemarks.Text
            Return True
        Else
            Return False
        End If
    End Function
    'To SAVE data to table, ADD or UPDATE data
    Function fnSaveData(ByVal objTrans As IDbTransaction) As Boolean

        'Check for Member Existance
        If objMember.fnCheckMember = True Then
            objTrans = fnGetTransaction()

            Dim lngVoucherNo As Long
            Dim lngSlNo As Long
            Dim strLoan As String
            Dim dblRemPrinciple As Double
            Dim intLedgerNo As Integer = 0
            Dim intInterestLedgerNo As Integer = 0
            Dim intSDLedgerNo As Integer = 0
            lngVoucherNo = fnVoucherGetNewVNo(dtpDepositdate.Value)
            objMember.VoucherNo = lngVoucherNo
            lngSlNo = fnVoucherGetNewSlNo()
            lngVoucher = lngVoucherNo
            Dim strNarration As String = txtRemarks.Text
            objMember.fnInsertToMemberTransactionTbl(objTrans)
            'voucher details
            fnVoucherEnterMain(lngVoucherNo, 2, txtMemberNo.Text, txtReferenceNo.Text, dtpDepositdate.Value, Val(txtPaidAmount.Text), "Deposit By " & txtMemberNo.Text, lngSlNo, "Y")
            'Credit Interest on Loan
            fnVoucherEnterSub(lngVoucherNo, 2, txtMemberNo.Text, dtpDepositdate.Value, "Deposited by " & txtMemberNo.Text, "By", 1, Val(txtPaidAmount.Text), 0, 2, "Y")
            'Debit The Interest Recivable of Particular loan
            fnVoucherEnterSub(lngVoucherNo, 2, txtMemberNo.Text, dtpDepositdate.Value, "Deposited by " & txtMemberNo.Text, "To", 140, 0, Val(txtPaidAmount.Text), 2, "Y")

        End If

    End Function

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtMemberNo.ResetText()
        txtName.ResetText()
        txtUpdateAmount.ResetText()
        txtVoucherNo.ResetText()
        txtVoucherDate.ResetText()
        MemberClear()
    End Sub

    Private Sub txtPaidAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaidAmount.TextChanged
        If Val(txtPaidAmount.Text) <= DueAmount Then
            txtBalanceAmount.Text = DueAmount - Val(txtPaidAmount.Text)
        Else
            MsgBox("Paid amount is more than the due amount", MsgBoxStyle.OkOnly)
        End If
    End Sub



    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Dim objTrans As IDbTransaction = fnGetTransaction()
        objMember.MemberNo = txtMemberNo.Text
        If fnDeleteCheck() Then
            objMember.UpdateAmount = Convert.ToDecimal(txtUpdateAmount.Text)
            objMember.VoucherNo1 = Convert.ToInt32(txtVoucherNo.Text)
            objMember.VoucherDate = Convert.ToDateTime(txtVoucherDate.Text)
            If objMember.fnUpdateMemberOnDelete(objTrans) Then
                'If objMember.fnDeleteMemberTransaction(objTrans) Then
                MsgBox("Record deleted Sucessfully", MsgBoxStyle.OkOnly)
                objTrans.Commit()
                txtUpdateAmount.ResetText()
                txtVoucherNo.ResetText()
                txtVoucherDate.ResetText()
            Else
                MsgBox("Record deletion failed", MsgBoxStyle.OkOnly)
            End If
            'End If
        End If
    End Sub


    Private Sub lvMemDepositDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvMemDepositDetails.Click
        txtVoucherDate.Text = lvMemDepositDetails.SelectedItems(0).SubItems(0).Text
        txtVoucherNo.Text = lvMemDepositDetails.SelectedItems(0).SubItems(10).Text
        txtUpdateAmount.Text = Convert.ToDecimal(lvMemDepositDetails.SelectedItems(0).SubItems(3).Text) - Convert.ToDecimal(lvMemDepositDetails.SelectedItems(0).SubItems(1).Text) + Convert.ToDecimal(txtBalanceAmount.Text)
    End Sub

    Function fnDeleteCheck() As Boolean
        If txtMemberNo.Text = "" Then
            MsgBox("Enter member no ", MsgBoxStyle.Exclamation)
            txtMemberNo.Focus()
            Return False
        ElseIf txtUpdateAmount.Text = "" Then
            MsgBox("Please select a Record From List ", MsgBoxStyle.Exclamation)
            txtBalanceAmount.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub txtBalanceAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBalanceAmount.TextChanged
        ' txtBalanceAmount.Text = DueAmount - Val(txtPaidAmount.Text)
    End Sub

    Private Sub lvMemDepositDetails_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvMemDepositDetails.SelectedIndexChanged

    End Sub
End Class