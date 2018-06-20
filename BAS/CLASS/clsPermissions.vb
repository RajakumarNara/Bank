Public Class clsPermissions

#Region "Variables"

    Dim _strRole As String
    Dim _strRoleID As String
    Dim _strModule As String
    Dim _strModuleID As String
    Dim _strSubModule As String
    Dim _strSubModuleID As String
    Dim _StrStatus As String
    Dim _strMainStatus As String
    Dim _stredit As String
    Dim _strDel As String
    Dim _strView As String
    Dim _dtPermissionTable As DataTable
    Dim _dtPTable As DataTable

#End Region

#Region "Properties"

    Public Property Role() As String
        Get
            Return _strRole
        End Get
        Set(ByVal Value As String)
            _strRole = Value
        End Set
    End Property
    Public Property RoleID() As String
        Get
            Return _strRoleID
        End Get
        Set(ByVal Value As String)
            _strRoleID = Value
        End Set
    End Property
    Public Property ModuleName() As String
        Get
            Return _strModule
        End Get
        Set(ByVal Value As String)
            _strModule = Value
        End Set
    End Property
    Public Property ModuleID() As String
        Get
            Return _strModuleID
        End Get
        Set(ByVal Value As String)
            _strModuleID = Value
        End Set
    End Property
    Public Property SubModule() As String
        Get
            Return _strSubModule
        End Get
        Set(ByVal Value As String)
            _strSubModule = Value
        End Set
    End Property
    Public Property SubModuleID() As String
        Get
            Return _strSubModuleID
        End Get
        Set(ByVal Value As String)
            _strSubModuleID = Value
        End Set
    End Property
    Public Property Status() As String
        Get
            Return _StrStatus
        End Get
        Set(ByVal Value As String)
            _StrStatus = Value
        End Set
    End Property
    '.....Actually we have MainModule table attributes in clsModule but we havent used that because tis is the 
    ' only option we use for MainModuletable so we have included MainStatus in this cls file to do operation 
    'This is for updataing the status of MainModule table for selected Main module items in the list.......
    Public Property MainStatus() As String
        Get
            Return _strMainStatus
        End Get
        Set(ByVal Value As String)
            _strMainStatus = Value
        End Set
    End Property
    Public Property Edit() As String
        Get
            Return _stredit
        End Get
        Set(ByVal Value As String)
            _stredit = Value
        End Set
    End Property
    Public Property Delete() As String
        Get
            Return _strDel
        End Get
        Set(ByVal Value As String)
            _strDel = Value
        End Set
    End Property
    Public Property View() As String
        Get
            Return _strView
        End Get
        Set(ByVal Value As String)
            _strView = Value
        End Set
    End Property
    Public Property PermissionTable() As DataTable
        Get
            Return _dtPermissionTable
        End Get
        Set(ByVal Value As DataTable)
            _dtPermissionTable = Value
        End Set
    End Property
    Public Property PTable() As DataTable
        Get
            Return _dtPTable
        End Get
        Set(ByVal Value As DataTable)
            _dtPTable = Value
        End Set
    End Property

#End Region

#Region "Function"

    Public Function fnGetRol() As Boolean
        Dim strSql As String
        Dim objDR As Odbc.OdbcDataReader
        Dim strConn As New Odbc.OdbcConnection(strODBCConnectionString)
        strSql = "select * from RoleTbl where RoleId='" & Role & "'"
        Try
            strConn.Open()
            Dim objCmd As New Odbc.OdbcCommand(strSql, strConn)
            objDR = objCmd.ExecuteReader()
            objDR.Read()
            If objDR.HasRows = True Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            strConn.Close()
        End Try
    End Function

    Public Function fnGetRole() As Boolean
        Dim strSql As String

        strSql = "Select RoleID,RoleName from UserTbl"

        _dtPermissionTable = fnExecuteQuery(strSql, 2)

        If _dtPermissionTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetModuleData() As Boolean
        Dim strSql As String

        strSql = "Select * from  MainModuleTbl"

        _dtPermissionTable = fnExecuteQuery(strSql, 2)

        If _dtPermissionTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetMod() As Boolean
        Dim strSql As String
        strSql = "Select roleid,Module from roletbl "
        _dtPTable = fnExecuteQuery(strSql, 2)
        If _dtPTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    ''.....Actually we have MainModule table attributes in clsModule but we havent used that because tis is the 
    '' only option we use for MainModuletable so we have included MainStatus in this cls file to do operation 
    ''This is for updataing the status of MainModule table for selected Main module items in the list.......

    'Public Function fnSaveStatus() As Boolean
    '    strSQL = "UPDATE MainModuletbl SET MainStatus='" & MainStatus & " ' WHERE Module='" & ModuleName & "'"
    '    If fnExecuteNonQuery(strSQL) Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function
    Public Function fnUpdate() As Boolean

        strSQL = "DELETE from roletbl where RoleID='" & RoleID & "' AND Module='" & ModuleID & "'"
        If fnExecuteNonQuery(strSQL) Then
            fnSave()
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnSave() As Boolean

        Dim int As Integer = PermissionTable.Rows.Count
        For Each drRow As DataRow In PermissionTable.Rows
            strSQL = "insert into RoleTbl values ('" & RoleID & "','" & ModuleID & "','" & drRow("SubmoduleID") & "','" & drRow("Status") & "')"
            fnExecuteNonQuery(strSQL)
        Next
        Return True

    End Function

    Public Function fnUserCheck() As Boolean
        Dim objConn As New Odbc.OdbcConnection(strODBCConnectionString)
        Dim strSql As String
        Try
            strSql = "Select * from roleTbl where RoleId='" & Role & "'"
            objConn.Open()
            Dim objCmd As New Odbc.OdbcCommand(strSql, objConn)
            Dim objDr As Odbc.OdbcDataReader
            objDr = objCmd.ExecuteReader
            If objDr.Read = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            objConn.Close()
        End Try
    End Function
    Public Function fnInsert() As Boolean

        strSQL = "insert into RoleTbl values ('" & Role & "','" & ModuleName & "','" & Status & "','" & Edit & "','" & Delete & "','" & View & "')"

        If fnExecuteNonQuery(strSQL) Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnDelete() As Boolean


        strSQL = "DELETE from roletbl where RoleID='" & Role & "'"

        If fnExecuteNonQuery(strSQL) Then
            Return True
        Else
            Return False
        End If


    End Function
#End Region

End Class
