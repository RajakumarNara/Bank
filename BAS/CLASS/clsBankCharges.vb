Public Class clsBankCharges
    Inherits clsPerson
    Private _paticulars As String
    Private _comparision As String
    Private _amount As Double
    Private _charges As Double
    Private _SchemeCode As Integer
    Private _dtBankChargeTable As DataTable
    Private _dtBuildingFundTable As DataTable
    Private _dtDocTable As DataTable
    Private _dtLoanProcessingTable As DataTable
    Private _dtSecuredDepositTable As DataTable

#Region "Properties"
    Public Property BuildingFundTable() As DataTable
        Get
            Return _dtBuildingFundTable
        End Get
        Set(ByVal Value As DataTable)
            _dtBuildingFundTable = Value
        End Set
    End Property
    Public Property DocTable() As DataTable
        Get
            Return _dtDocTable
        End Get
        Set(ByVal Value As DataTable)
            _dtDocTable = Value
        End Set
    End Property
    Public Property LoanProcessingTable() As DataTable
        Get
            Return _dtLoanProcessingTable
        End Get
        Set(ByVal Value As DataTable)
            _dtLoanProcessingTable = Value
        End Set
    End Property
    Public Property SecuredDepositTable() As DataTable
        Get
            Return _dtSecuredDepositTable
        End Get
        Set(ByVal Value As DataTable)
            _dtSecuredDepositTable = Value
        End Set
    End Property
    Public Property Particular() As String
        Get
            Return _paticulars
        End Get
        Set(ByVal Value As String)
            _paticulars = Value
        End Set
    End Property
    Public Property Comparision() As String
        Get
            Return _comparision
        End Get
        Set(ByVal Value As String)
            _comparision = Value
        End Set
    End Property
    Public Property SchemeCode() As Integer
        Get
            Return _SchemeCode
        End Get
        Set(ByVal Value As Integer)
            _SchemeCode = Value
        End Set
    End Property


    Public Property Amount() As String
        Get
            Return _amount
        End Get
        Set(ByVal Value As String)
            _amount = Value
        End Set
    End Property
    Public Property Charges() As String
        Get
            Return _charges
        End Get
        Set(ByVal Value As String)
            _charges = Value
        End Set
    End Property
    Public Property BankChargeTable() As DataTable
        Get
            Return _dtBankChargeTable
        End Get
        Set(ByVal Value As DataTable)
            _dtBankChargeTable = Value
        End Set
    End Property
#End Region
#Region "SMTL Functions"
    
    Public Function fnCheckBankCharges(ByVal strSchemeCode As String) As Boolean
        strSQL = "select * from loanbankchargessettings where SchemeCode = '" & strSchemeCode & "'"
        _dtBankChargeTable = fnExecuteQuery(strSQL, 2)
        If _dtBankChargeTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnInsertBankCharges(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "insert into loanbankchargessettings(Particular,Comparision,Amount,Charges)"
        strSQL = strSQL & " values('" & _paticulars & "','" & _comparision & "','" & _amount & "','" & _charges & "')"
        Return fnExecuteNonQuery(strSQL, objTrans)
    End Function

    Public Function fnUpdateLoanDetails(ByVal objTrans As IDbTransaction) As Boolean
        strSQL = "UPDATE loanbankchargessettings SET Particular = '" & _paticulars & "',Amount = '" & _amount & "', Charges='" & _charges & "' where SchemeCode='" & _SchemeCode & "'"
        Return fnExecuteNonQuery(strSQL, objTrans)
    End Function

    Public Function fnGetBankCharges() As Boolean

        strSQL = "SELECT * from loanbankchargessettings order by Particular"

        _dtBankChargeTable = fnExecuteQuery(strSQL, 2)

        If _dtBankChargeTable.Rows.Count > 0 Then
            Return True
        End If

        Return False

    End Function
    Public Function fnGetBuildingFund() As Boolean

        strSQL = "SELECT * from loanbankchargessettings where Particular='Building fund' order by Amount"

        _dtBuildingFundTable = fnExecuteQuery(strSQL, 2)

        If _dtBuildingFundTable.Rows.Count > 0 Then
            Return True
        End If

        Return False

    End Function
    Public Function fnDocTable() As Boolean

        strSQL = "SELECT * from loanbankchargessettings where Particular='Document' order by Amount"

        _dtDocTable = fnExecuteQuery(strSQL, 2)

        If _dtDocTable.Rows.Count > 0 Then
            Return True
        End If

        Return False

    End Function
    Public Function fnLoanProcessing() As Boolean

        strSQL = "SELECT * from loanbankchargessettings where Particular='Loan processing' order by Amount"

        _dtLoanProcessingTable = fnExecuteQuery(strSQL, 2)

        If _dtLoanProcessingTable.Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function fnSecuredDeposit() As Boolean

        strSQL = "SELECT * from loanbankchargessettings where Particular='Loan processing' order by Amount"

        _dtSecuredDepositTable = fnExecuteQuery(strSQL, 2)

        If _dtSecuredDepositTable.Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function
#End Region
End Class
