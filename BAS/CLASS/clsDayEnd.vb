Public Class clsDayEnd


#Region "Variables"

    Dim _strYYYYMMDD As Date
    Dim _chrStatus As Char
    Dim _dtStDate As DataTable


#End Region

    Public Property YYYYMMDD() As Date
        Get
            Return _strYYYYMMDD
        End Get
        Set(ByVal Value As Date)
            _strYYYYMMDD = Value
        End Set
    End Property

    Public Property Status() As Char
        Get
            Return _chrStatus
        End Get
        Set(ByVal Value As Char)
            _chrStatus = Value
        End Set
    End Property

    Public Property DtStDate() As DataTable
        Get
            Return _dtStDate
        End Get
        Set(ByVal Value As DataTable)
            _dtStDate = Value
        End Set
    End Property


#Region "Function"

    Function fnInsert() As Boolean
        strSQL = "INSERT into DayEndtbl values('" & Format(YYYYMMDD, "YYYY-MM-dd") & "','" & Status & "')"
        Return fnExecuteNonQuery(strSQL)
    End Function

    Function fnUpdate() As Boolean
        strSQL = "UPDATE DayEndtbl set Status='C' where Status='P'"
        If fnExecuteNonQuery(strSQL) Then
            strSQL = "UPDATE DayEndtbl set Status='P' where Status='A'"
            Return fnExecuteNonQuery(strSQL)
        Else
            Return False
        End If
    End Function

    Function fnGetStartDate() As Boolean
        strSQL = "SELECT * FROM DayEndtbl where Status='A' "
        _dtStDate = fnExecuteQuery(strSQL, 2)
        If _dtStDate.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region
End Class
