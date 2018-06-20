Public Class frmBankCharges
    Inherits System.Windows.Forms.Form
#Region "Variables"

    'Dim objCtrl(10) As IntSettingsCtrl
    'Dim dtIntrSettings As DataTable
    ' Dim objFDAcc As New clsFDAccount
    Dim objBankCharges As New clsBankCharges
    Dim dvOccupation As New DataView

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmBankCharges
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmBankCharges
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmBankCharges
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmBankCharges)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

    Private Sub frmBankCharges_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fnLoadData()
    End Sub
    Function fnLoadData() As Boolean
        Dim VarComparision As String
        If objBankCharges.fnGetBankCharges = True Then
            dvOccupation = New DataView(objBankCharges.BankChargeTable)

            Dim intCounter As Integer = 0
            Dim lvItem As ListViewItem
            lvBankCharges.Items.Clear()

            While intCounter < dvOccupation.Count
                lvItem = lvBankCharges.Items.Add(dvOccupation.Item(intCounter).Item(0))
                lvItem.SubItems.Add(dvOccupation.Item(intCounter).Item(1))
                VarComparision = dvOccupation.Item(intCounter).Item(2)
                Select Case VarComparision
                    Case "<"
                        lvItem.SubItems.Add("Less than")
                    Case "="
                        lvItem.SubItems.Add("Equal to")
                    Case "<="
                        lvItem.SubItems.Add("Less than or equal to")
                    Case ">"
                        lvItem.SubItems.Add("Greater than")
                    Case ">="
                        lvItem.SubItems.Add("Greater than or equal to")
                End Select
                'lvItem.SubItems.Add(dvOccupation.Item(intCounter).Item(2))
                lvItem.SubItems.Add(dvOccupation.Item(intCounter).Item(3))
                lvItem.SubItems.Add(dvOccupation.Item(intCounter).Item(4))
                intCounter = intCounter + 1
            End While
            If lvBankCharges.Items.Count > 0 Then
                lvBankCharges.Items(0).Selected = True
            End If
        End If
    End Function
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Clear()
    End Sub
    Sub Clear()
        txtAmount.ResetText()
        txtCharges.ResetText()
        cmbParticulars.SelectedIndex = -1
        cmbComparision.SelectedIndex = -1
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnSetData() Then
                    If fnSaveData(objTrans) Then
                        objTrans.Commit()
                        fnLoadData()
                        btnAdd_Click(sender, e)
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try
    End Sub
    Function fnSaveData(ByVal objTrans As IDbTransaction) As Boolean

        'Check for Member Existance
        If Trim(txtSchemeCode.Text) = String.Empty Then

            'ADD new Member  (ADD Mode)
            If objBankCharges.fnInsertBankCharges(objTrans) = True Then
                'objTrans.Commit()
                'fnGenerateVoucher()
                'Log Entry
                fnLogEntry(pbUserId, "New Bank Charges created " & txtSchemeCode.Text, Date.Now, "New LoanBankCharge", objTrans)

                MessageBox.Show("Bank Charge for Loan created successfully.", "Bank Charge Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)

                'Clear()
                Return True
            Else
                MessageBox.Show("Bank Charge for Loan creation failed, because of internal error.", "Bank Charge Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            End If
        Else

            'update details (edit mode)x.
            objBankCharges.SchemeCode = Convert.ToInt32(txtSchemeCode.Text)
            objBankCharges.Particular = cmbParticulars.Text
            objBankCharges.Amount = Convert.ToDouble(txtAmount.Text)
            objBankCharges.Charges = Convert.ToDouble(txtCharges.Text)
            If objBankCharges.fnUpdateLoanDetails(objTrans) = True Then
                'objTrans.Commit()
                fnLogEntry(pbUserId, "Bank Charges updated" & cmbParticulars.SelectedText, Date.Now, "Update Bank Charges", objTrans)
                MessageBox.Show("Bank Charges updated successfully.", "Bank Charge Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                ' Clear()
                'fnLoadData()
                Return True

            Else
                MessageBox.Show("Bank Charges updation failed, because of internal error.", "Bank Charge Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If
        End If

    End Function


    Function fnSetData() As Boolean
        Dim MathOperator As String
        objBankCharges.Particular = cmbParticulars.Text
        MathOperator = cmbComparision.Text
        Select Case MathOperator
            Case "Equal to"
                objBankCharges.Comparision = "="
            Case "Less than"
                objBankCharges.Comparision = "<"
            Case "Less than or equal to "
                objBankCharges.Comparision = "<="
            Case "Greater than"
                objBankCharges.Comparision = ">"
            Case "Greater than or equal to"
                objBankCharges.Comparision = ">="
        End Select
        objBankCharges.Amount = txtAmount.Text
        objBankCharges.Charges = txtCharges.Text
        Return True

    End Function

    Function fnCheck() As Boolean
        If Trim(cmbParticulars.Text) = String.Empty Then
            MsgBox("Select particulars", MsgBoxStyle.Exclamation)
            cmbParticulars.Focus()
            Return False
        ElseIf Trim(cmbComparision.Text) = String.Empty Then
            MsgBox("Select Comparision", MsgBoxStyle.Exclamation)
            cmbComparision.Focus()
            Return False
        ElseIf Trim(txtAmount.Text) = String.Empty Then
            MsgBox("Enter amount ", MsgBoxStyle.Exclamation)
            txtAmount.Focus()
            Return False
        ElseIf Trim(txtCharges.Text) = String.Empty Then
            MsgBox("Enter chargers", MsgBoxStyle.Exclamation)
            txtCharges.Focus()
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub lvBankCharges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvBankCharges.Click
        If lvBankCharges.SelectedIndices.Count > 0 Then
            Clear()
            txtSchemeCode.Text = lvBankCharges.SelectedItems(0).SubItems(0).Text
            cmbParticulars.Text = lvBankCharges.SelectedItems(0).SubItems(1).Text
            txtAmount.Text = lvBankCharges.SelectedItems(0).SubItems(2).Text
            txtCharges.Text = lvBankCharges.SelectedItems(0).SubItems(3).Text
        End If

    End Sub
End Class