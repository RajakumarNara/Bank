Public Class clsModule

#Region "Variables"
    Dim _strModule As String
    Dim _strModuleNo As String
    Dim _dtModTable As DataTable
    Dim _strStatus As String
#End Region

#Region "Properties"
    Public Property moduleNo() As String
        Get
            Return _strModuleNo
        End Get
        Set(ByVal Value As String)
            _strModuleNo = Value
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
    Public Property Status() As String
        Get
            Return _strStatus
        End Get
        Set(ByVal Value As String)
            _strStatus = Value
        End Set
    End Property

    Public Property ModuleTable() As DataTable
        Get
            Return _dtModTable
        End Get
        Set(ByVal Value As DataTable)
            _dtModTable = Value
        End Set
    End Property
#End Region

#Region "function"

    Public Function fnGetModule() As Boolean
        Dim strSql As String
        Dim objDR As Odbc.OdbcDataReader
        Dim strConn As New Odbc.OdbcConnection(strODBCConnectionString)
        strSql = "select * from ModuleTbl where Module='" & ModuleName & "'"
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
    Public Function fnGetData() As Boolean

        strSQL = "Select * from  MainModuleTbl order by ModuleNo ASC"

        _dtModTable = fnExecuteQuery(strSQL, 2)
        If _dtModTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetData2(ByVal x As String) As Boolean

        strSQL = "Select * from  ModuleTbl where ModuleNo='" & x & "'"

        _dtModTable = fnExecuteQuery(strSQL, 2)
        If _dtModTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetData1() As Boolean

        strSQL = "Select distinct(RoleId) from  roletbl"
        _dtModTable = fnExecuteQuery(strSQL, 2)
        If _dtModTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnSaveData() As Boolean

        strSQL = "insert into ModuleTbl values ('" & moduleNo & "','" & ModuleName & "','" & Status & "')"

        If fnExecuteNonQuery(strSQL) Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetMax() As String
        Dim strSql As String
        Dim objConn As New Odbc.OdbcConnection(strODBCConnectionString)
        Dim objDR As Odbc.OdbcDataReader
        Try
            strSql = "Select Max(ModuleNo) as code from ModuleTbl "
            objConn.Open()
            Dim objCMD As New Odbc.OdbcCommand(strSql, objConn)
            objDR = objCMD.ExecuteReader
            If objDR.HasRows Then
                fnGetMax = Val(objDR("code"))
            Else
                fnGetMax = Nothing
            End If
            objDR.Close()
            objConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            fnGetMax = Nothing
        End Try
    End Function
    Public Function fndelete() As Boolean

        strSQL = "Delete * from ModuleTbl where Module='" & ModuleName & "'"

        If fnExecuteNonQuery(strSQL) Then
            Return True
        Else
            Return False
        End If

    End Function

#End Region

End Class
