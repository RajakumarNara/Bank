Public Class clsAccessPermission
#Region "Variables"
    Private _bolSavingsBank As String
    Private _bolShares As String
    Private _bolDeposit As String
    Private _bolLoan As String
    Private _dtAccessPermission As DataTable
    Private _strTypeOfUser As String

#End Region


#Region "properties"
    Public Property SavingsBank() As String
        Get
            Return _bolSavingsBank
        End Get
        Set(ByVal Value As String)
            _bolSavingsBank = Value
        End Set
    End Property

    Public Property TypeOFUser() As String
        Get
            Return _strTypeOfUser
        End Get
        Set(ByVal Value As String)
            _strTypeOfUser = Value
        End Set
    End Property
    Public Property shares() As String
        Get
            Return _bolShares
        End Get
        Set(ByVal Value As String)
            _bolShares = Value
        End Set
    End Property

    Public Property Deposits() As String
        Get
            Return _bolDeposit
        End Get
        Set(ByVal Value As String)
            _bolDeposit = Value
        End Set
    End Property

    Public Property Loans() As String
        Get
            Return _bolLoan
        End Get
        Set(ByVal Value As String)
            _bolLoan = Value
        End Set
    End Property


    Public Property AccPermissionTable() As DataTable
        Get
            Return _dtAccessPermission
        End Get
        Set(ByVal Value As DataTable)
            _dtAccessPermission = Value
        End Set
    End Property
#End Region

#Region "function"
    Public Function fnGetAccessPermission() As Boolean

        strSQL = "SELECT * FROM AccessPermissionTbl "

        _dtAccessPermission = fnExecuteQuery(strSQL, 2)

        If _dtAccessPermission.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    'Public Function fnUpdatePermission() As Boolean
    '    strSQL = "UPDATE AccesspermissionTbl SET SavingsBank='" & _bolSavingsBank & "', Shares='" & _bolShares & _
    '    "', Deposit='" & _bolDeposit & "', Loan='" & _bolLoan & "',  WHERE TypeOfUser='" & _strTypeOfUser & "'"
    '    fnExecuteNonQuery(strSQL)
    'End Function


   
    Public Function fnAddPermission() As Boolean
        strSQL = "INSERT INTO AccesspermissionTbl(TypeOfUser,SavingsBank,Shares,Deposit, Loan) VALUES('" & _
        _strTypeOfUser & "','" & _bolSavingsBank & "','" & _bolShares & "','" & _bolDeposit & "','" & _bolLoan & "')"
        If fnExecuteNonQuery(strSQL) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnLoadPermission(ByVal strTypeOfUser As String) As Boolean
        strSQL = "SELECT * FROM AccessPermissionTbl WHERE TypeOfUser = '" & strTypeOfUser & "'"
        _dtAccessPermission = fnExecuteQuery(strSQL, 2)
        If _dtAccessPermission.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnDeletePermission(ByVal strTypeOfUser As String) As Boolean
        strSQL = "DELETE  FROM AccessPermission WHERE TypeOfUser='" & strTypeOfUser & "'"
        Return fnExecuteNonQuery(strSQL)
    End Function

#End Region
End Class
