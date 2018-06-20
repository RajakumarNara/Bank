Public Class clsUsers

#Region "Variables"
    Private _strUserID As String
    Private _strPassword As String
    Public _strTypeOfUser As String
    Private _dtUserTable As DataTable
#End Region

#Region "Properties"

    Public Property UserID() As String
        Get
            Return _strUserID
        End Get
        Set(ByVal Value As String)
            _strUserID = Value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return _strPassword
        End Get
        Set(ByVal Value As String)
            _strPassword = Value
        End Set
    End Property
    Public Property TypeOfUser() As String
        Get
            Return _strTypeOfUser
        End Get
        Set(ByVal Value As String)
            _strTypeOfUser = Value
        End Set
    End Property

    Public Property UserTable() As DataTable
        Get
            Return _dtUserTable
        End Get
        Set(ByVal Value As DataTable)
            _dtUserTable = Value
        End Set
    End Property

#End Region

#Region "Functions"

    Public Function fnCheckUserID() As Boolean

        strSQL = "SELECT * FROM UserTbl WHERE UserID='" & _strUserID & "'"

        _dtUserTable = fnExecuteQuery(strSQL, 2)

        If _dtUserTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnCheckPassword(ByVal UserID As String, ByVal Password As String) As Boolean

        strSQL = "SELECT Password FROM UserTbl WHERE UserID='" & UserID & "'"

        _dtUserTable = fnExecuteQuery(strSQL, 2)

        If _dtUserTable.Rows.Count > 0 Then
            If Trim(_dtUserTable.Rows(0).Item("Password")) = Trim(Password) Then
                Return True
            End If
        End If
        Return False

    End Function

    Public Function fnSetAccessPermission(ByVal UserID As String) As Boolean

        strSQL = "SELECT a.SavingsBank,a.Shares,a.Deposit,a.Loan FROM UserTbl u,accesspermissiontbl a  WHERE u.UserID='" & UserID & "' And  u.TypeOfUser=a.TypeOfUser"

        _dtUserTable = fnExecuteQuery(strSQL, 2)
        If _dtUserTable.Rows.Count > 0 Then
            Return True
        End If

    End Function

    Function fnSubModule(ByVal userid As String, ByVal frm As String) As DataTable
        Dim objconn As New Odbc.OdbcConnection(strODBCConnectionString)
        Dim strsql As String = "select SubModule  from RoleTbl R ,UserTbl U where R.roleid=U.roleid and U.UserID='" & userid & "'and R.Module='" & frm & "'"
        Dim objDa As New Odbc.OdbcDataAdapter
        Dim objCmd As New Odbc.OdbcCommand(strsql, objconn)
        Dim objds As New DataSet
        objDa.SelectCommand = objCmd
        objDa.Fill(objds)
        Return objds.Tables(0)
    End Function

    Function fnMainModule(ByVal userid As String) As Boolean
        Dim strsql As String = "select  MM.Module ,MM.ModuleControlID  from MainmoduleTbl MM,RoleTbl R ,UserTbl U where R.roleid=U.roleid and U.UserID='" & userid & "'and R.SubModule='0'and MM.ModuleNo=R.Module"
        _dtUserTable = fnExecuteQuery(strsql, 2)
        If _dtUserTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnAddUser(ByVal rolelid As Integer) As Boolean

        strSQL = "INSERT INTO UserTbl VALUES('" & _strUserID & "','" & _strPassword & "','" & rolelid & "','" & _strTypeOfUser & "')"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnUpdateUser() As Boolean

        ' strSQL = "UPDATE UserTbl SET Password='" & _strPassword & "',TypeOfUser='" & _strTypeOfUser & "' WHERE UserID='" & _strUserID & "'"
        strSQL = "UPDATE UserTbl SET Password='" & _strPassword & "' WHERE UserID='" & _strUserID & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetUsersList() As Boolean

        strSQL = "SELECT * FROM UserTbl ORDER BY UserID"

        _dtUserTable = fnExecuteQuery(strSQL, 2)

        If _dtUserTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fuCheckRole() As Boolean
        strSQL = "SELECT * from UserTbl where RoleID='" & _strTypeOfUser & "'"

        _dtUserTable = fnExecuteQuery(strSQL, 2)

        If _dtUserTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function fnGetNewRoleNo() As Integer

        strSQL = "SELECT max(RoleID) as MaxNo FROM usertbl "

        _dtUserTable = fnExecuteQuery(strSQL, 2)

        If IsDBNull(_dtUserTable.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return _dtUserTable.Rows(0).Item("MaxNo") + 1
        End If

    End Function

#End Region

End Class
