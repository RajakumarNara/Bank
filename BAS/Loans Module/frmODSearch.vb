Public Class frmODSearch
    Inherits System.Windows.Forms.Form

#Region "Varaibles"
    Dim objclsODDetails As New clsODLoanDetails
    Dim dvODLoan As DataView
    Dim strFilter As String = "Name like '%'"
    Public strODLoan As String
#End Region
    Private Sub frmODSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbType.SelectedIndex = 0
        If objclsODDetails.fnGetODLoanCust = True Then
            dvODLoan = New DataView(objclsODDetails.OverDraftLoanCusttable, strFilter, "Name", DataViewRowState.OriginalRows)
            fnGetODLoan()
        End If
    End Sub

#Region "Function"

    Public Function fnGetODLoan() As Boolean
        Dim intCount As Integer = 0
        Dim lstvOD As ListViewItem
        If Not dvODLoan Is Nothing Then
            dvODLoan.RowFilter = strFilter
            lvODLoan.Items.Clear()
            lblMessage.Text = "There are " & dvODLoan.Count & " records found for your search"
            While intCount < dvODLoan.Count
                lstvOD = lvODLoan.Items.Add(dvODLoan.Item(intCount).Item("AccountNo"))
                lstvOD.SubItems.Add(dvODLoan.Item(intCount).Item("Name"))
                intCount += 1
            End While
        End If
    End Function

#End Region

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
         If cmbType.SelectedItem = "Name" Then
            strFilter = "Name like '" & txtSearch.Text & "%'"
            fnGetODLoan()
        ElseIf cmbType.SelectedItem = "AccountNo" Then
            strFilter = "LoanNo like '" & txtSearch.Text & "%'"
            fnGetODLoan()
        End If
    End Sub
End Class