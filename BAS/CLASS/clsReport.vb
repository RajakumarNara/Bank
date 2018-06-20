Module clsReport

#Region "Variables"

    Private _datFromDate As Date
    Private _datToDate As Date
    Private _tblRptTable As DataTable

#End Region

#Region "Property"

    Public Property FromDate() As Date
        Get
            Return _datFromDate
        End Get
        Set(ByVal Value As Date)
            _datFromDate = Value
        End Set
    End Property

    Public Property ToDate() As Date
        Get
            Return _datToDate
        End Get
        Set(ByVal Value As Date)
            _datToDate = Value
        End Set
    End Property

    Public Property RptTable() As DataTable
        Get
            Return _tblRptTable
        End Get
        Set(ByVal Value As DataTable)
            _tblRptTable = Value
        End Set
    End Property

#End Region

#Region "Function"

    Public Function fnInsertDate() As Boolean

        strSQL = "INSERT INTO rptdatetbl(FromDate,ToDate)VALUES('" & Format(_datFromDate, "yyyy-MM-dd") & "','" & Format(_datToDate, "yyyy-MM-dd") & "')"
        Return fnExecuteNonQuery(strSQL)

    End Function
    Public Function fnNullInsertToPassBook() As Boolean

        'strSQL = "INSERT INTO sbpassbook(AccountNo,TrDate,Narration,ChequeNo,Deposit,Withdraw,PostBalance)VALUES('0',0,'0','0','0','0','0')"
        strSQL = "INSERT INTO sbpassbook(temp)VALUES(0)"
        Return fnExecuteNonQuery(strSQL)

    End Function
    Public Function fnInsertToPassBookValue(ByVal sbAccountNo As String, ByVal sbTrDate As Date, ByVal sbNarration As String, ByVal sbChequeNo As String, ByVal sbDeposit As Decimal, ByVal sbWithdraw As Decimal, ByVal sbPostBalance As Decimal) As Boolean

        strSQL = "INSERT INTO sbpassbook(AccountNo,TrDate,Narration,ChequeNo,Deposit,Withdraw,PostBalance)VALUES('" & sbAccountNo & "','" & Format(sbTrDate, "yyyy-MM-dd") & "','" & sbNarration & "','" & sbChequeNo & "','" & sbDeposit & "','" & sbWithdraw & "','" & sbPostBalance & "')"
        Return fnExecuteNonQuery(strSQL)

    End Function


    Public Function fnDeleteDate() As Boolean

        strSQL = "DELETE FROM rptdatetbl"
        Return fnExecuteNonQuery(strSQL)

    End Function
    Public Function fnDeletePassBookContents() As Boolean

        strSQL = "DELETE FROM sbpassbook"
        Return fnExecuteNonQuery(strSQL)

    End Function
    Public Function fnDeletePassBookReprintContents() As Boolean

        strSQL = "DELETE FROM sbpassbookreprint"
        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetTransactionDetailsForPassBookReprint(ByVal strAccountNo As String, ByVal DTPFrom As DateTime, ByVal DTPTo As DateTime) As DataTable
        Dim hour As String = DTPTo.Hour
        Dim min As String = DTPTo.Minute
        Dim sec As String = DTPTo.Second
        Dim year As String = DTPTo.Year
        Dim month As Integer = DTPTo.Month
        Dim day As Integer = DTPTo.Day
        Dim DateTimeTo As String = year & "-" & month & "-" & day & " " & hour & ":" & min & ":" & sec
        strSQL = "select * from passbooksbtransactions where AccountNo='" & strAccountNo & "' and TrDate >= '" & Format(DTPFrom, "yyyy-MM-dd") & "' and TrDate <= '" & DateTimeTo & "' order by  TrDate"
        Return fnExecuteQuery(strSQL, 2)
    End Function

#End Region

End Module
