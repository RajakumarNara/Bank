Public Class clsAccount


#Region "Variables"
    Dim _dtTransactions As DataTable

#End Region

#Region "Properties"

    Public Property TransactionTable() As DataTable
        Get
            Return _dtTransactions
        End Get
        Set(ByVal Value As DataTable)
            _dtTransactions = Value
        End Set
    End Property

#End Region

#Region "Functions"

    'to get transaction details for the given Account Number
    Public Function fnGetTransactions(ByVal strAccountNo As String) As Boolean

        strSQL = "SELECT Voucher.* , VType.Name as Type FROM FASVoucherMainTbl Voucher, FASVoucherTypeTbl VType WHERE Voucher.TypeNo=VType.TypeNo and Voucher.AccountNo='" & strAccountNo & "' ORDER BY Voucher.SlNo ASC"

        _dtTransactions = fnExecuteQuery(strSQL, 2)

        If _dtTransactions.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

#End Region

End Class
