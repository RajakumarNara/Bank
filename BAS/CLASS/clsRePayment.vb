

Public Class clsRePayment

#Region "Variables"

    Private _strloanNo As String
    Private _dtPayment As DataTable
    Private _datPaidDate As Date
    Private _intAmount As Double
    Private _intPrincipleAmt As Double
    Private _datFromDate As Date
    Private _datToDate As Date
    Private _intCredit As Double
    Private _intDebit As Double
    Private _strRemarks As String
    Private _intChallanNo As Integer
    Private _dtMaxInstNo As DataTable
    Private _intInstNo As Integer
    Private _intNOI As Integer
    Private _intInterest As Double
    Private _intPenelIntrest As Double
    Private _intIntrestPaid As Double
    Private _intVoucher As Integer
    Private _intOthers As Double
    Private _dtMaxAmount As DataTable
    Private _dtGetPayment As DataTable
    Private _intBalance As Double
    Private _intReferenceNo As Integer
    Private _dtDisb As DataTable
    Private _dtLoanType As DataTable
    Private _dtPenelInterest As DataTable
    Private _dtReceiptNo As DataTable
    Private _dtlastInstDate As Date

    Private _intSecDeposit As Double
    Private _dblReceivable As Double
    Private _dblIntCOver As Double
    Private _dblIntPreCOver As Double

#End Region

#Region "Properties"

    Public Property LoanNo() As String
        Get
            Return _strloanNo
        End Get
        Set(ByVal Value As String)
            _strloanNo = Value
        End Set
    End Property

    Public Property PaymentTable() As DataTable
        Get
            Return _dtPayment
        End Get
        Set(ByVal Value As DataTable)
            _dtPayment = Value
        End Set
    End Property

    Public Property GetPaymentTable() As DataTable
        Get
            Return _dtGetPayment
        End Get
        Set(ByVal Value As DataTable)
            _dtGetPayment = Value
        End Set
    End Property

    Public Property Amount() As Double
        Get
            Return _intAmount
        End Get
        Set(ByVal Value As Double)
            _intAmount = Value
        End Set
    End Property

    Public Property PrincipleAmt() As Double
        Get
            Return _intPrincipleAmt
        End Get
        Set(ByVal Value As Double)
            _intPrincipleAmt = Value
        End Set
    End Property
    Public Property Credit() As Double
        Get
            Return _intCredit
        End Get
        Set(ByVal Value As Double)
            _intCredit = Value
        End Set
    End Property
    Public Property Debit() As Double
        Get
            Return _intDebit
        End Get
        Set(ByVal Value As Double)
            _intDebit = Value
        End Set
    End Property

    Public Property Remarks() As String
        Get
            Return _strRemarks
        End Get
        Set(ByVal Value As String)
            _strRemarks = Value
        End Set
    End Property

    Public Property PaidDate() As Date
        Get
            Return _datPaidDate
        End Get
        Set(ByVal Value As Date)
            _datPaidDate = Value
        End Set
    End Property
    Public Property LastInstDate() As Date
        Get
            Return _dtlastInstDate
        End Get
        Set(ByVal Value As Date)
            _dtlastInstDate = Value
        End Set
    End Property
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

    Public Property ChallanNo() As Integer
        Get
            Return _intChallanNo
        End Get
        Set(ByVal Value As Integer)
            _intChallanNo = Value
        End Set
    End Property

    Public Property MaxInstNoTable() As DataTable
        Get
            Return _dtMaxInstNo
        End Get
        Set(ByVal Value As DataTable)
            _dtMaxInstNo = Value
        End Set
    End Property

    Public Property MaxAmountTable() As DataTable
        Get
            Return _dtMaxAmount
        End Get
        Set(ByVal Value As DataTable)
            _dtMaxAmount = Value
        End Set
    End Property

    Public Property InstNo() As Integer
        Get
            Return _intInstNo
        End Get
        Set(ByVal Value As Integer)
            _intInstNo = Value
        End Set
    End Property
    Public Property NOI() As Integer
        Get
            Return _intNOI
        End Get
        Set(ByVal Value As Integer)
            _intNOI = Value
        End Set
    End Property

    Public Property Intrest() As Double
        Get
            Return _intInterest
        End Get
        Set(ByVal Value As Double)
            _intInterest = Value
        End Set
    End Property

    Public Property IntrestPaid() As Double
        Get
            Return _intIntrestPaid
        End Get
        Set(ByVal Value As Double)
            _intIntrestPaid = Value
        End Set
    End Property

    Public Property PenelIntrest() As Double
        Get
            Return _intPenelIntrest
        End Get
        Set(ByVal Value As Double)
            _intPenelIntrest = Value
        End Set
    End Property

    Public Property VoucherNo() As Integer
        Get
            Return _intVoucher
        End Get
        Set(ByVal Value As Integer)
            _intVoucher = Value
        End Set
    End Property

    Public Property Others() As Double
        Get
            Return _intOthers
        End Get
        Set(ByVal Value As Double)
            _intOthers = Value
        End Set
    End Property

    Public Property Balance() As Double
        Get
            Return _intBalance
        End Get
        Set(ByVal Value As Double)
            _intBalance = Value
        End Set
    End Property

    Public Property ReferenceNo() As Integer
        Get
            Return _intReferenceNo
        End Get
        Set(ByVal Value As Integer)
            _intReferenceNo = Value
        End Set
    End Property

    Public Property disbtable() As DataTable
        Get
            Return _dtDisb
        End Get
        Set(ByVal Value As DataTable)
            _dtDisb = Value
        End Set
    End Property

    Public Property LoanTypetable() As DataTable
        Get
            Return _dtLoanType
        End Get
        Set(ByVal Value As DataTable)
            _dtLoanType = Value
        End Set
    End Property

    Public Property PenelInteresttable() As DataTable
        Get
            Return _dtPenelInterest
        End Get
        Set(ByVal Value As DataTable)
            _dtPenelInterest = Value
        End Set
    End Property

    Public Property ReceiptNoTable() As DataTable
        Get
            Return _dtReceiptNo
        End Get
        Set(ByVal Value As DataTable)
            _dtReceiptNo = Value
        End Set
    End Property

    Public Property SecurityDeposit() As Double
        Get
            Return _intSecDeposit
        End Get
        Set(ByVal Value As Double)
            _intSecDeposit = Value
        End Set
    End Property

    Public Property IntReceivable() As Double
        Get
            Return _dblReceivable
        End Get
        Set(ByVal Value As Double)
            _dblReceivable = Value
        End Set
    End Property
    Public Property IntCOver() As Double
        Get
            Return _dblIntCOver
        End Get
        Set(ByVal Value As Double)
            _dblIntCOver = Value
        End Set
    End Property
    Public Property IntPreCOver() As Double
        Get
            Return _dblIntPreCOver
        End Get
        Set(ByVal Value As Double)
            _dblIntPreCOver = Value
        End Set
    End Property




#End Region

#Region "Functions"

    Public Function fnGetData(ByVal _StrLoanNo As String) As Boolean

        strSQL = "select a.* from loandetailstbl a where a.loanNo = '" & _StrLoanNo & "'"
        _dtPayment = fnExecuteQuery(strSQL, 2)
        If _dtPayment.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnAddData(ByVal lngVoucherNo As Long, ByVal objTrans As IDbTransaction) As Boolean
        strSQL = "Insert into loanRePaymenttbl(LoanNo,InstNo,RepayDate,FromDate,ToDate,Debit,Credit,InterestRaised,Interestpaid,PenelInterest,Others,Remarks,Balance,ChallanNo,VoucherNo,ReferenceNo,IntReceivable,IntCOver)"
        strSQL = strSQL & " values('" & _strloanNo & "','" & _intInstNo & "','" & Format(_datPaidDate, "yyyy-MM-dd") & "','" & Format(_datFromDate, "yyyy-MM-dd") & "','" & Format(_datToDate, "yyyy-MM-dd") & "','" & _intDebit & "','" & _intCredit & "','" & _intInterest & "','" & _intIntrestPaid & "','" & _intPenelIntrest & "','" & _intOthers & "','" & _strRemarks & "','" & _intBalance & "','" & _intChallanNo & "','" & lngVoucherNo & "','" & _intReferenceNo & "','" & _dblReceivable & "','" & _dblIntCOver & "')"
        Return fnExecuteNonQuery(strSQL, objTrans)
    End Function
    Public Function fnAddData(ByVal lngVoucherNo As Long) As Boolean
        strSQL = "Insert into loanRePaymenttbl(LoanNo,InstNo,RepayDate,FromDate,ToDate,Debit,Credit,InterestRaised,Interestpaid,PenelInterest,Others,Remarks,Balance,ChallanNo,VoucherNo,ReferenceNo,IntReceivable,IntCOver)"
        strSQL = strSQL & " values('" & _strloanNo & "','" & _intInstNo & "','" & Format(_datPaidDate, "yyyy-MM-dd") & "','" & Format(_datFromDate, "yyyy-MM-dd") & "','" & Format(_datToDate, "yyyy-MM-dd") & "','" & _intDebit & "','" & _intCredit & "','" & _intInterest & "','" & _intIntrestPaid & "','" & _intPenelIntrest & "','" & _intOthers & "','" & _strRemarks & "','" & _intBalance & "','" & _intChallanNo & "','" & lngVoucherNo & "','" & _intReferenceNo & "','" & _dblReceivable & "','" & _dblIntCOver & "')"
        Return fnExecuteNonQuery(strSQL)
    End Function

    Public Function fnMaxNo(ByVal _strloanNo As String) As Boolean
        'strSQL = "select ifnull(max(instNo),0) as InstNo,ifnull(sum(Principle),0) as Principle from loanrepaymenttbl where loanNo = '" & _strloanNo & "'"
        '  strSQL = "select ifnull(max(instNo),0) as InstNo,ifnull(sum(Credit)-sum(Debit),0) as Principle ,ifnull(sum(Debit),0)as Amount  from loanrepaymenttbl where loanNo = '" & _strloanNo & "'"
        strSQL = "select ifnull(max(instNo),0) as InstNo, ifnull(sum(Debit),0)as LoanAmount,ifnull(sum(credit),0) as PaidAmount,ifnull(sum(Debit)-sum(Credit),0) as Balance from loanrepaymenttbl where loanNo = '" & _strloanNo & "'"
        _dtMaxInstNo = fnExecuteQuery(strSQL, 2)
        Return True
    End Function

    Public Function fnMaxAmount(ByVal _strLoanNo As String) As Boolean
        strSQL = " select ifnull(sum(amount),0) as amount from  loandisbtbl  where loanNo= '" & _strLoanNo & "'"
        _dtMaxAmount = fnExecuteQuery(strSQL, 2)
        Return True
    End Function

    Public Function fnGetPaidDet(ByVal _StrloanNo As String) As Boolean
        strSQL = "select a.* from loanrepaymenttbl a where a.loanno = '" & _StrloanNo & "'"
        _dtGetPayment = fnExecuteQuery(strSQL, 2)
        Return True
    End Function

    Public Function fnUpdataLoanDate(ByVal _strloanNo As String, ByVal objTrans As IDbTransaction) As Boolean
        strSQL = "update loandetailstbl set lastpaiddate = '" & Format(PaidDate, "yyyy-MM-dd") & "',LastInstDate='" & Format(_dtlastInstDate, "yyyy-MM-dd") & "', balance = balance +'" & _intAmount & "',SecurityDeposit='" & _intSecDeposit & "',IntReceivable='" & _dblReceivable & "',IntCOver='" & _dblIntCOver & "' + '" & _dblIntPreCOver & "' where loanno = '" & _strloanNo & "'"
        Return fnExecuteNonQuery(strSQL, objTrans)
    End Function

    Public Function fnUpdataLoanDate(ByVal _strloanNo As String) As Boolean
        strSQL = "update loandetailstbl set lastpaiddate = '" & Format(PaidDate, "yyyy-MM-dd") & "',LastInstDate='" & Format(_dtlastInstDate, "yyyy-MM-dd") & "', balance = balance +'" & _intAmount & "',SecurityDeposit='" & _intSecDeposit & "',IntReceivable='" & _dblReceivable & "',IntCOver='" & _dblIntCOver & "' + '" & _dblIntPreCOver & "' where loanno = '" & _strloanNo & "'"
        Return fnExecuteNonQuery(strSQL)
    End Function

    Public Function fnGetDisb(ByVal strLoanNo As String) As Boolean

        strSQL = "select * from loandisbtbl where loanno = '" & strLoanNo & "'"

        _dtDisb = fnExecuteQuery(strSQL, 2)

        If _dtDisb.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnUpdateVouncherNo(ByVal lngVouncherNo As String, ByVal strLoanNo As String) As Boolean

        'strSQL = "Update loanRepaymenttbl set voucherNo = '" & lngVouncherNo & "' where loanno = '" & strLoanNo & "' and InstNo = Max(InstNo)"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetROI(ByVal strLoanNo As String) As Boolean

        Dim strLoanType As String

        'If Mid(strLoanNo, 1, 2) = "GL" Then
        '    strLoanType = "GoldLoan"

        'ElseIf Mid(strLoanNo, 1, 2) = "VL" Then
        '    strLoanType = "VehicleLoan"

        'ElseIf Mid(strLoanNo, 1, 2) = "ML" Then
        '    strLoanType = "MediumLoan"

        'ElseIf Mid(strLoanNo, 1, 2) = "HL" Then
        '    strLoanType = "HomeLoan"

        'ElseIf Mid(strLoanNo, 1, 2) = "KL" Then
        '    strLoanType = "KisanLoan"

        'ElseIf Mid(strLoanNo, 1, 2) = "DL" Then
        '    strLoanType = "DemandLoan"

        'End If

        strSQL = "select * from loandetailstbl where LoanNo = '" & strLoanNo & "'"

        LoanTypetable = fnExecuteQuery(strSQL, 2)

        If LoanTypetable.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function fnGetPenelInterest(ByVal strLoanNo As String) As Boolean

        Dim strLoanType As String

        If Mid(strLoanNo, 1, 2) = "JL" Then
            strLoanType = "Jewel Loan"

        ElseIf Mid(strLoanNo, 1, 2) = "LM" Then
            strLoanType = "Vehicle Loan"

        ElseIf Mid(strLoanNo, 1, 2) = "SL" Then
            strLoanType = "Surety Loan"

        ElseIf Mid(strLoanNo, 1, 2) = "HL" Then
            strLoanType = "Hand Loan"

        ElseIf Mid(strLoanNo, 1, 2) = "CH" Then
            strLoanType = "Colleteral Hand Loan"

        ElseIf Mid(strLoanNo, 1, 2) = "LT" Then
            strLoanType = "Loans On Term Deposit"

        ElseIf Mid(strLoanNo, 1, 2) = "SD" Then
            strLoanType = "Souharda Daily Recovery Laon"

        End If

        strSQL = "Select * from loantypetbl where loanType = '" & strLoanType & "'"

        PenelInteresttable = fnExecuteQuery(strSQL, 2)

        If PenelInteresttable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If


    End Function

    Public Function fnUpdateStatus(ByVal strLoanNo As String) As Boolean

        strSQL = "update loanDetailstbl set status = 'Closed' where loanNo = '" & strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnCheckReceiptNo(ByVal strReceiptNo As String) As Boolean

        strSQL = "Select * from receiptmaintbl where ReceiptNo = '" & strReceiptNo & "'"

        ReceiptNoTable = fnExecuteQuery(strSQL, 2)

        If ReceiptNoTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fngetLoneeName(ByVal strLoaneNo As String) As Boolean

        strSQL = "SELECT  P.Name,L.* from loanDetailstbl L,PersonTbl P  where L.PersonNo=P.PersonNo AND  L.loanNo='" & strLoaneNo & "'"
        _dtPayment = fnExecuteQuery(strSQL, 2)

        If _dtPayment.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetActiveLoanAccount(ByVal strType As String) As Boolean
        strSQL = "select L.LoanNo,L.PersonNo,P.Name,L.ROI,L.SancAmount,L.Balance,L.LastPaidDate,L.LastInstDate,L.IntReceivable,L.IntCOver from loandetailstbl L inner join persontbl P on P.PersonNo=L.PersonNo where L.Status='Active' and  L.LoanNo like '" & strType & "%'"
        _dtLoanType = fnExecuteQuery(strSQL, 2)
        If _dtLoanType.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region



End Class
