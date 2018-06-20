Module Logs


    Function fnLogEntry(ByVal UserID As String, ByVal Description As String, ByVal DateTime As Date, ByVal Type As String) As Boolean

        strSQL = "INSERT into LogDetailsTbl(UserID,Description,DateTime,Type) values('" & UserID & "','" & Description & "','" & Format(DateTime, "yyyy-MM-dd hh:mm:ss ") & "','" & Type & "')"

        Return fnExecuteNonQuery(strSQL)

    End Function
    Function fnLogEntry(ByVal UserID As String, ByVal Description As String, ByVal DateTime As Date, ByVal Type As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "INSERT into LogDetailsTbl(UserID,Description,DateTime,Type) values('" & UserID & "','" & Description & "','" & Format(DateTime, "yyyy-MM-dd hh:mm:ss ") & "','" & Type & "')"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function


    Function fnLogGetLogs() As DataTable

        strSQL = "SELECT * FROM LogDetailsTbl ORDER BY LogNo DESC"

        Return fnExecuteQuery(strSQL, 2)

    End Function

    Function fnLogGetLogs(ByVal UserID As String) As DataTable

        strSQL = "SELECT * FROM LogDetailsTbl WHERE UserID='" & UserID & "' ORDER BY LogNo DESC"

        Return fnExecuteQuery(strSQL, 2)

    End Function


    Function fnLogDeleteLog(ByVal LogNo As Long) As Boolean

        strSQL = "DELETE FROM LogDetailsTbl WHERE LogNo=" & LogNo

        Return fnExecuteNonQuery(strSQL)

    End Function

End Module
