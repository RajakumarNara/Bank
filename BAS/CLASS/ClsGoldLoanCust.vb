
Public Class ClsGoldLoanCust

#Region "Variables"
    Private _search As String
    Private _type As String
    Private _dtKisanLoan As DataTable

#End Region

#Region "Properties"
    Public Property searchBy() As String
        Get
            Return _search
        End Get
        Set(ByVal Value As String)
            _search = Value
        End Set
    End Property

    Public Property type() As String
        Get
            Return _type
        End Get
        Set(ByVal Value As String)
            _type = Value
        End Set
    End Property

    Public Property KisanLoantable() As DataTable
        Get
            Return _dtKisanLoan

        End Get
        Set(ByVal Value As DataTable)
            _dtKisanLoan = Value
        End Set
    End Property


#End Region

#Region "Function"

    Public Function fnGetGoldLoanCust() As Boolean

        strSQL = "select P.*, S.* FROM loandetailstbl S, PersonTbl P WHERE P.PersonNo=S.PersonNo and loanno like 'JL%'"

        _dtKisanLoan = fnExecuteQuery(strSQL, 2)

        If _dtKisanLoan.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

End Class
