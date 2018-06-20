Public Class clsLoanDet

#Region "Varaibles"

    Private _strsearchText As String
    Private _strSearchBy As String
    Private _tblLoanDet As DataTable
    Private _dtLoanDefaulters As DataTable
    Private _StrLoanType As String
    Private _dtLoanList As DataTable

#End Region

#Region "Properties"

    Public Property SearchText() As String
        Get
            Return _strsearchText
        End Get
        Set(ByVal Value As String)
            _strsearchText = Value
        End Set
    End Property

    Public Property SearchBy() As String
        Get
            Return _strSearchBy
        End Get
        Set(ByVal Value As String)
            _strSearchBy = Value
        End Set
    End Property

    Public Property LoanTable() As DataTable
        Get
            Return _tblLoanDet
        End Get
        Set(ByVal Value As DataTable)
            _tblLoanDet = Value
        End Set
    End Property

    Public Property LoanDefaulters() As DataTable
        Get
            Return _dtLoanDefaulters
        End Get
        Set(ByVal Value As DataTable)
            _dtLoanDefaulters = Value
        End Set
    End Property

    Public Property LoanType() As String
        Get
            Return _StrLoanType
        End Get
        Set(ByVal Value As String)
            _StrLoanType = Value
        End Set
    End Property

    Public Property LoanListTable() As DataTable
        Get
            Return _dtLoanList
        End Get
        Set(ByVal Value As DataTable)
            _dtLoanList = Value
        End Set
    End Property

#End Region

#Region "Functions"

    Public Function fnGetData(ByVal strlno As String) As Boolean

        strSQL = "select l.LoanNo,l.MemberNo,l.SancAmount,l.DueDate,l.ROI,p.Name FROM loandetailstbl l, persontbl p where l.personNo =p.PersonNo and loanno like '" & strlno & "%'"

        _tblLoanDet = fnExecuteQuery(strSQL, 2)

        If _tblLoanDet.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function fnGetDefaulters() As Boolean

        strSQL = "Select a.*, b.* from loanDetailstbl a, Persontbl b where a.personno = b.personno and a.duedate <  '" & Format(Date.Today, "yyyy-MM-dd") & "'  and a.balance <> '0'"

        _dtLoanDefaulters = fnExecuteQuery(strSQL, 2)

        If _dtLoanDefaulters.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function fnGetLaonDetails()

        strSQL = " select L.LoanNo,L.SancDate,L.SancAmount,L.InstPrinciple,L.Balance,L.LastPaidDate,sum(LR.Debit)as Debit,sum(LR.Credit)+sum(LR.InterestPaid)as Credit "
        strSQL &= "from loanrepaymenttbl LR inner join loandetailstbl L on L.LoanNo=LR.LoanNo "
        strSQL &= "where L.Status='Active' and L.LoanNo not like 'JL%' group by L.LoanNo "
        _dtLoanDefaulters = fnExecuteQuery(strSQL, 2)

        If _dtLoanDefaulters.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnInsertDefaulters(ByVal strLoanNo As String, ByVal intDurMonth As Integer, ByVal dblDueAmount As Double) As Boolean
        strSQL = "insert loandefaulterstbl values('" & strLoanNo & "','" & intDurMonth & "','" & dblDueAmount & "')"
        Return fnExecuteNonQuery(strSQL)
    End Function

    Public Function fnGetDefaultersList() As Boolean
        'strSQL = "select p.Name,L.LoanNo,L.SancDate,L.SancAmount,L.InstPrinciple,L.Balance,p.MobileNo,L.LastPaidDate,LR.DueMonth,LR.DueAmount from loandefaulterstbl LR "
        'strSQL &= "inner join loandetailstbl L on L.LoanNo=LR.LoanNo "
        'strSQL &= "inner join persontbl p on L.PersonNo=p.PersonNo "

        strSQL = "select * from defaulterlist"
        _dtLoanDefaulters = fnExecuteQuery(strSQL, 2)

        If _dtLoanDefaulters.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnDeleteDefaulters()
        strSQL = "delete from loandefaulterstbl"
        fnExecuteNonQuery(strSQL)
    End Function

    Public Function fnGetLoanDet(ByVal strLoanType As String) As Boolean

        strSQL = "select a.LoanNo,b.NAME,B.phoneNo,a.SancAmount,a.SancDate,a.DueDate,a.Balance,a.LastPaidDate,a.status FROM loanDetailstbl a, Persontbl b where a.personNo = b.PERSONnO and a.loanno like '" & strLoanType & "%'"""

        fnExecuteQuery(strSQL, 2)


    End Function

    Public Function fnLoanList() As Boolean

        strSQL = "Select a.*,b.* from loandetailstbl a, persontbl b where a.PersonNo = b.PersonNo"

        _dtLoanList = fnExecuteQuery(strSQL, 2)

        If _dtLoanList.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function fnLoanList(ByVal LoanNo As String) As Boolean

        ' strSQL = "Select a.*,b.* from loandetailstbl a, persontbl b where a.PersonNo = b.PersonNo and a.LoanNo like '" & LoanNo & "%'"
        strSQL = "select P.Name,L.LoanNo,L.SancAmount,L.DisbAmount,L.Balance,L.SancDate,L.LastPaidDate,L.Status,L.DueDate,L.SancNo,L.ROI,L.NOI,L.InstPrinciple,L.RepayMode,L.SecurityDeposit,L.IntReceivable from loandetailstbl L, persontbl P where P.PersonNo = L.PersonNo and L.LoanNo like '" & LoanNo & "%'"

        _dtLoanList = fnExecuteQuery(strSQL, 2)

        If _dtLoanList.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function


    Public Function fnGetLoanList() As Boolean

        strSQL = "Select a.*,b.* from loandetailstbl a, persontbl b where a.PersonNo = b.PersonNo and a.Status= 'Active' and a.Balance <> '0'"

        _dtLoanList = fnExecuteQuery(strSQL, 2)

        If _dtLoanList.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function
    Public Function fnGetLoanDetail(ByVal strLoanNo As String) As Boolean

        strSQL = "SELECT P.*, v.* FROM Loandetailstbl v, PersonTbl P WHERE P.PersonNo=v.PersonNo  and v.LoanNo='" & strLoanNo & "' "

        _dtLoanList = fnExecuteQuery(strSQL, 2)

        If _dtLoanList.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function fnLoanNumbers(ByVal SqlType As String) As Boolean

        If SqlType = "loan" Then
            strSQL = "Select * from loandetailstbl"
        Else
            strSQL = "Select * from oddetailstbl"
        End If


        _dtLoanList = fnExecuteQuery(strSQL, 2)

        If _dtLoanList.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function


#End Region

End Class
