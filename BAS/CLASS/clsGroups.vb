Public Class clsGroups

#Region "Variables"
    Private _intGroupNo As Integer
    Private _strGroupName As String
    Private _intOrderNo As Integer
    Private _intParentNo As Integer
    Private _chrNature As Char
    Private _chrRestrictUser As Char

    Private _dtGroupsTable As DataTable

#End Region

#Region "Properties"

    Public Property GroupNo() As Integer
        Get
            Return _intGroupNo
        End Get
        Set(ByVal Value As Integer)
            _intGroupNo = Value
        End Set
    End Property

    Public Property GroupName() As String
        Get
            Return _strGroupName
        End Get
        Set(ByVal Value As String)
            _strGroupName = Value
        End Set
    End Property
    Public Property OrderNo() As Integer
        Get
            Return _intOrderNo
        End Get
        Set(ByVal Value As Integer)
            _intOrderNo = Value
        End Set
    End Property

    Public Property ParentNo() As Integer
        Get
            Return _intParentNo
        End Get
        Set(ByVal Value As Integer)
            _intParentNo = Value
        End Set
    End Property

    Public Property Nature() As Char
        Get
            Return _chrNature
        End Get
        Set(ByVal Value As Char)
            _chrNature = Value
        End Set
    End Property

    Public Property RestrictUser() As Char
        Get
            Return _chrRestrictUser
        End Get
        Set(ByVal Value As Char)
            _chrRestrictUser = Value
        End Set
    End Property

    Public Property GroupsTable() As DataTable
        Get
            Return _dtGroupsTable
        End Get
        Set(ByVal Value As DataTable)
            _dtGroupsTable = Value
        End Set
    End Property

#End Region

#Region "Functions"


    Public Function fnAddGroup() As Boolean

        strSQL = "INSERT INTO FASGroupTbl(GroupNo, Name, ParentNo, Nature,OrderNo, RestrictUser)"
        strSQL &= "VALUES('" & _intGroupNo & "','" & _strGroupName & "','" & _intParentNo & "','" & _chrNature & "','" & _intOrderNo & "','" & _chrRestrictUser & "')"

        Return fnExecuteNonQuery(strSQL)

    End Function
    Public Function fnGetGroupsListLoad() As Boolean

        strSQL = "SELECT * FROM FASGroupTbl ORDER BY OrderNo"

        _dtGroupsTable = fnExecuteQuery(strSQL, 2)

        If _dtGroupsTable.Rows.Count > 0 Then

            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetGroupsList() As Boolean

        'strSQL = "SELECT * FROM FASGroupTbl ORDER BY OrderNo"

        strSQL = "SELECT * FROM  fasgrouptbl WHERE GroupNo<>0  AND Nature IN ('A','L') ORDER BY OrderNo"

        _dtGroupsTable = fnExecuteQuery(strSQL, 2)

        If _dtGroupsTable.Rows.Count > 0 Then

            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetIEGroupsList() As Boolean

        strSQL = "SELECT * FROM FASGroupTbl ORDER BY OrderNo"

        _dtGroupsTable = fnExecuteQuery(strSQL, 2)

        If _dtGroupsTable.Rows.Count > 0 Then

            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnGetRPGroupsList() As Boolean

        strSQL = "SELECT * FROM FaReciptPaymenttbl ORDER BY RPGroupNo ASC"

        _dtGroupsTable = fnExecuteQuery(strSQL, 2)

        If _dtGroupsTable.Rows.Count > 0 Then

            Return True
        Else
            Return False
        End If

    End Function



    Public Function fnUpdateGroup() As Boolean

        strSQL = "UPDATE FASGroupTbl SET Name='" & _strGroupName & "', ParentNo='" & _intParentNo & "', Nature='" & _chrNature & "',OrderNo='" & _intOrderNo & "', RestrictUser='" & _chrRestrictUser & "' WHERE GroupNo='" & _intGroupNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function



    Public Function fnGetNewGroupNo() As Integer

        strSQL = "SELECT max(GroupNo) as MaxNo FROM FASGroupTbl "

        _dtGroupsTable = fnExecuteQuery(strSQL, 2)

        If IsDBNull(_dtGroupsTable.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return _dtGroupsTable.Rows(0).Item("MaxNo") + 1
        End If

    End Function
    Public Function fnGetNewOrderNo() As Integer
        strSQL = "SELECT max(OrderNo) as MaxNo FROM FASGroupTbl "

        _dtGroupsTable = fnExecuteQuery(strSQL, 2)

        If IsDBNull(_dtGroupsTable.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return _dtGroupsTable.Rows(0).Item("MaxNo") + 1
        End If
    End Function



    Public Function fnCheckGroup(ByVal GroupNo As Integer) As Boolean

        strSQL = "SELECT * FROM FASGroupTbl WHERE GroupNo='" & GroupNo & "'"

        _dtGroupsTable = fnExecuteQuery(strSQL, 2)

        If _dtGroupsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetSubGroups(ByVal GroupNo As Integer) As Boolean

        strSQL = "SELECT * FROM FASGroupTbl WHERE ParentNo='" & GroupNo & "'"

        _dtGroupsTable = fnExecuteQuery(strSQL, 2)

        If _dtGroupsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If


    End Function

    Public Function fnUpdateOrder() As Boolean
        strSQL = "UPDATE fasgrouptbl set "
        strSQL = strSQL & "OrderNo='" & OrderNo & "' where "
        strSQL = strSQL & "GroupNo='" & GroupNo & "'"
        Return fnExecuteNonQuery(strSQL)
    End Function

#End Region

End Class
