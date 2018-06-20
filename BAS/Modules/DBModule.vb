Module DBModule

#Region " Form Global Variables"
    Public strODBCConnectionString As String = "DSN=CooperativeBank"
    'Public strODBCConnectionString As String = "DSN=Coop"
    Public strSQL As String
#End Region

#Region "Functions"

    Public Function fnExecuteNonQuery(ByVal strSQL As String) As Boolean

        'general function to execute any query against database (data manipulation queries)
        'INSERT, DELETE, UPDATE queries can be executed with this function
        'strSQL     ----- represents the query to be executed

        Dim objConn As New Odbc.OdbcConnection(strODBCConnectionString)
        Dim objCmd As New Odbc.OdbcCommand(strSQL, objConn)


        Try
            objConn.Open()
            objCmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Database Error")
            Return False
        Finally
            objConn.Close()
        End Try
    End Function

    Public Function fnExecuteNonQuery(ByVal strSQLCollection As Collections.Specialized.StringCollection) As Boolean

        ''general function to execute any query against database (data manipulation queries)
        ''INSERT, DELETE, UPDATE queries can be executed with this function
        ''strSQLCollection     ----- represents collection of queries to be executed

        Dim SQL As String
        Dim objTransaction As Odbc.OdbcTransaction
        Dim objConn As New Odbc.OdbcConnection(strODBCConnectionString)
        Dim objCmd As New Odbc.OdbcCommand(SQL, objConn)

        Try
            objConn.Open()
            objTransaction = objConn.BeginTransaction
            objCmd.Transaction = objTransaction
            For Each SQL In strSQLCollection
                objCmd.CommandText = SQL
                objCmd.ExecuteNonQuery()
            Next
            objTransaction.Commit()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Database Error")
            objTransaction.Rollback()
            Return False
        Finally
            objConn.Close()
            objCmd.Dispose()
        End Try

    End Function

    Public Function fnExecuteQuery(ByVal strSQL As String, ByVal intReturnType As Integer) As Object

        'function used to execute any data retrieval queries against database
        'strSQL    ----- represents the query to be executed
        'intReturnType    ----- represents the return type required 
        'intReturnType = 1    ----dataset
        'intReturnType = 2    ----datatable

        Dim objConn As New Odbc.OdbcConnection(strODBCConnectionString)
        Dim objDA As New Odbc.OdbcDataAdapter(strSQL, objConn)
        Dim objDT As New Data.DataTable
        Dim objDS As New Data.DataSet
        Try
            objConn.Open()
            If intReturnType = 1 Then
                objDA.Fill(objDS)
                Return objDS
            ElseIf intReturnType = 2 Then
                objDA.Fill(objDT)

                Return objDT

            End If
            Return Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Database Error")
            Return Nothing
        Finally
            objConn.Close()
        End Try

    End Function

#End Region

#Region "Transaction Methods"

    Public Function fnExecuteNonQuery(ByVal strSQL As String, ByVal objTrans As IDbTransaction) As Boolean

        'general function to execute any query against database (data manipulation queries)
        'INSERT, DELETE, UPDATE queries can be executed with this function
        'strSQL     ----- represents the query to be executed

        Dim objCmd As New Odbc.OdbcCommand(strSQL, objTrans.Connection, objTrans)
        Try
            objCmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Database Error")
            objTrans.Rollback()
            Throw ex
        Finally
            objCmd.Dispose()
        End Try
    End Function
    Public Function fnExecuteNonQuery(ByVal strSQL As String, ByVal objConn As IDbConnection) As Boolean

        Dim objCmd As New Odbc.OdbcCommand(strSQL, objConn)
        Try
            objCmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Database Error")
            Return False
        Finally
            objCmd.Dispose()
        End Try
    End Function

    Public Function fnExecuteQuery(ByVal strSQL As String, ByVal intReturnType As Integer, ByVal objConn As Odbc.OdbcConnection) As Object

        'function used to execute any data retrieval queries against database
        'strSQL    ----- represents the query to be executed
        'intReturnType    ----- represents the return type required 
        'intReturnType = 1    ----dataset
        'intReturnType = 2    ----datatable

        Dim objDA As New Odbc.OdbcDataAdapter(strSQL, objConn)
        Dim objDT As New Data.DataTable
        Dim objDS As New Data.DataSet
        Try
            If intReturnType = 1 Then
                objDA.Fill(objDS)
                Return objDS
            ElseIf intReturnType = 2 Then
                objDA.Fill(objDT)
                Return objDT
            End If
            Return Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Database Error")
            Return Nothing
        Finally
            objDA.Dispose()
        End Try

    End Function

    Public Function fnGetTransaction() As IDbTransaction
        Try
            Dim objConn As New Odbc.OdbcConnection(strODBCConnectionString)
            objConn.Open()
            Return objConn.BeginTransaction()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Database Error")
            Return Nothing
        End Try
    End Function

    Public Function fnGetConnection() As IDbConnection
        Try
            Dim objConn As New Odbc.OdbcConnection(strODBCConnectionString)
            objConn.Open()
            Return objConn
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Database Error")
            Return Nothing
        End Try
    End Function

#End Region

End Module
