Module Anil

#Region "Global Variables"
    Public strODBCConnectionString As String = "DNS=Bank"
    Public strSQL As String
#End Region

    Public Overloads Function fnExecuteNonQuery(ByVal strSQL As String) As Boolean
        Dim objConn As New Odbc.OdbcConnection(strODBCConnectionString)
        Dim objCOmmancd As New Odbc.OdbcCommand(strSQL, objConn)
        Try
            objConn.Open()
            objCOmmancd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Database Error")
            Return False
        Finally
            objConn.Close()
        End Try
    End Function

    Public Overloads Function fnExecuteQuery(ByVal strSQL As String, ByVal intReturnType As Integer) As Object


    End Function


End Module


