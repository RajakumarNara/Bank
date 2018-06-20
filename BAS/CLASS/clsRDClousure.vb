Public Class clsRDClousure

#Region "Variables"

    Private _StrRDNo As String
    Private _datRDDetails As DataTable
    Private _datClosingDate As Date
    Private _tblRDTransaction As DataTable
#End Region

#Region "Properties"

    Public Property RDNo() As String
        Get
            Return _StrRDNo
        End Get
        Set(ByVal Value As String)
            _StrRDNo = Value
        End Set
    End Property
    Public Property RDTransaction() As DataTable
        Get
            Return _tblRDTransaction
        End Get
        Set(ByVal Value As DataTable)
            _tblRDTransaction = Value
        End Set
    End Property

    Public Property RDDetailstable() As DataTable
        Get
            Return _datRDDetails
        End Get
        Set(ByVal Value As DataTable)
            _datRDDetails = Value
        End Set
    End Property

    Public Property datClosingDate() As Date
        Get
            Return _datClosingDate
        End Get
        Set(ByVal Value As Date)
            _datClosingDate = Value
        End Set
    End Property

#End Region

#Region "Function"

    Public Function fnGetRdDetails(ByVal strRDNo As String) As Boolean
        strSQL = "Select * from rdtransactiontbl where AccountNo = '" & strRDNo & "'"
        _tblRDTransaction = fnExecuteQuery(strSQL, 2)

        strSQL = "Select * from rddetailstbl where RDNo = '" & strRDNo & "'"
        _datRDDetails = fnExecuteQuery(strSQL, 2)

        If _datRDDetails.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnCloseAccount(ByVal strRDNo As String) As Boolean

        strSQL = "Update rddetailstbl set status = 'C',ClosingDate = '" & Format(_datClosingDate, "yyyy-MM-dd") & "' Where RDNO = '" & strRDNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

#End Region

End Class
