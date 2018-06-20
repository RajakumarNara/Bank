Public Class frmTransferVoucher


#Region "Variables"

    Dim objClsMember As New clsMember
    Dim objLedger As New clsLedger

#End Region


#Region "Functions"

    Public Function fnLoadData() As Boolean
        Try
            If objClsMember.fnLoadCloseMember(txtMemberNo.Text) Then
                objClsMember.MemberNo = txtMemberNo.Text
                txtName.Text = objClsMember.CloseMemberDet.Rows(0).Item("Name")


            End If
            If Cmb_VoucherType.SelectedItem = "Cash" Then
                Cmd_BankList.Visible = False
                Lbl_BankName.Visible = False
            Else
                Cmd_BankList.Visible = True
                Lbl_BankName.Visible = True

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try

    End Function

    Public Function fnClearData()

        'txtSBNo.Text = String.Empty
        'txtMemberNo.Text = String.Empty
        'txtNoOfShares.Text = String.Empty
        'txtShareAmount.Text = String.Empty
        'txtName.Text = String.Empty
        'txtMemberNo.Text = String.Empty
        'cmbAccountType.SelectedIndex = -1
        'cmbStatus.SelectedIndex = -1
        'txtReceiptNo.Text = String.Empty
        txtMemberNo.Text = "MB"
        Cmb_VoucherType.SelectedIndex = -1


        txtAmount.ResetText()
        txtRefno.ResetText()
        txtNarration.ResetText()
        'dtpDepositDate.Focus()
        'txtChequeNo.ResetText()
        'AutoIncreRefNo = 0

    End Function

    Public Function fnValidate() As Boolean

        '    'If objClsMember.fnCheckMember() = False Then
        '    '    MsgBox("Please Check The Account No", MsgBoxStyle.Exclamation, "Member Module")
        '    '    txtMemberNo.Focus()
        '    '    Return False
        '    If txtMemberNo.Text = "MB" Then
        '        MsgBox("Please check the account no", MsgBoxStyle.Exclamation, "Member Module")
        '        txtMemberNo.Focus()
        '        Return False
        '    ElseIf cmbStatus.SelectedItem <> "Active" Then
        '        MsgBox("Membership already closed", MsgBoxStyle.Exclamation, "Member Module")
        '        txtMemberNo.Focus()
        '        Return False
        '    ElseIf Val(txtReceiptNo.Text) = 0 Then
        '        MsgBox("Enter receipt number", MsgBoxStyle.Exclamation, "Member Module")
        '        txtReceiptNo.Focus()
        '        Return False
        '    Else
        '        Return True
        '    End If

        If Cmb_VoucherType.SelectedIndex = -1 Then
            MsgBox("Select Voucher type", MsgBoxStyle.Information)
            Cmb_VoucherType.Focus()
            Return False

        ElseIf txtAmount.Text = "" Then
            MsgBox("Enter amount ", MsgBoxStyle.Information)
            txtAmount.Focus()
            Return False
        ElseIf txtNarration.Text = "" Then
            MsgBox("EnterNarration", MsgBoxStyle.Information)
            txtNarration.Focus()
            Return False
        ElseIf txtRefno.Text = "" Then
            MsgBox("Enter reference number", MsgBoxStyle.Information)
            txtRefno.Focus()
            Return False

        End If

    End Function



#End Region
#Region "Events"

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim ObjMemberSearch As New frmMemberSearch
        ObjMemberSearch.ShowDialog(Me)
        txtMemberNo.Text = ObjMemberSearch.strMemberNo
        If ObjMemberSearch.strMemberNo = "" Then
            txtMemberNo.Text = "MB"
            btnShow.Focus()
        Else
            fnLoadData()
        End If
    End Sub
#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub Cmb_VoucherType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_VoucherType.SelectedIndexChanged
       If Cmb_VoucherType.SelectedItem = "Bank" Then
            Cmd_BankList.Visible = True
            Lbl_BankName.Visible = True
            Cmd_BankList.Focus()
        Else
            Cmb_VoucherType.SelectedItem = "Cash"
            Cmd_BankList.Visible = False
            Lbl_BankName.Visible = False
        End If
    End Sub

    

    Private Sub Txt_PaymentAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_PaymentAmount.TextChanged
        Txt_PaymentAmount.Text = txtAmount.Text
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
      
    End Sub
End Class