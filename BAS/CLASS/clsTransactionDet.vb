

Public Class clsTransactionDet

#Region "Variables"

    Dim _dtDisb As DataTable
    Dim _dtRepay As DataTable

#End Region

#Region "Properties"

    Public Property disbTable() As DataTable
        Get
            Return _dtDisb
        End Get
        Set(ByVal Value As DataTable)
            _dtDisb = Value
        End Set
    End Property

    Public Property RepayTable() As DataTable
        Get
            Return _dtRepay
        End Get
        Set(ByVal Value As DataTable)
            _dtRepay = Value
        End Set
    End Property

#End Region

#Region "Functions"

    Public Function fnGetDisbDet(ByVal strLoanNo As String) As Boolean

        strSQL = "select a.loanno,a.disbdate,a.amount,a.RemAmount FROM loandisbtbl A where A.loanno = '" & strLoanNo & "'"

        _dtDisb = fnExecuteQuery(strSQL, 2)

        If _dtDisb.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function fnGetRepayDet(ByVal strLoanNo As String)

        strSQL = "select RepayDate,Credit,PenelInterest,Balance,InterestPaid from loanrepaymenttbl where loanno = '" & strLoanNo & "'"

        _dtRepay = fnExecuteQuery(strSQL, 2)

        If _dtRepay.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If
    End Function



#End Region

End Class
