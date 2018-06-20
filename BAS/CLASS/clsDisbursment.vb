
Public Class clsDisbursment

#Region "Variables"

    Private _strLoanNo As String
    Private _strRefNo As String
    Private _intAmount As Integer
    Private _intBalanceAmt As Integer
    Private _intSecDeposit As Integer
    Private _intintrest As Integer
    Private _intSlno As Integer
    Private _intRepaySlno As Integer
    Private _strBankDet As String
    Private _strVoucherNo As Double
    Private _datDisbDate As Date
    Private _datToDate As Date
    Private _dtDisburament As DataTable
    Private _dtAmt As New DataTable
    Private _intRemAmount As Integer
    Private _dtRemAmt As New DataTable
    Private _dtMaxSlNo As New DataTable
    Private _dtDisbAmount As DataTable
    Private _strRemarks As String
    Private _dtNoOfDisb As DataTable
    Private _dblBuildingFund As Double

    Private _dtMaxInstNo As DataTable
    Private _intProcCharges As Integer
    Private _intDocFee As Integer
    Private _intOtherCharges As Integer

#End Region

#Region "Property"
    Public Property MaxInstNoTable() As DataTable
        Get
            Return _dtMaxInstNo
        End Get
        Set(ByVal Value As DataTable)
            _dtMaxInstNo = Value
        End Set
    End Property

    Public Property loanNo() As String
        Get
            Return _strLoanNo
        End Get
        Set(ByVal Value As String)
            _strLoanNo = Value
        End Set
    End Property

    Public Property RefNo() As String
        Get
            Return _strRefNo
        End Get
        Set(ByVal Value As String)
            _strRefNo = Value
        End Set
    End Property

    Public Property BankDetails() As String
        Get
            Return _strBankDet
        End Get
        Set(ByVal Value As String)
            _strBankDet = Value
        End Set
    End Property

    Public Property VoucherNO() As Double
        Get
            Return _strVoucherNo
        End Get
        Set(ByVal Value As Double)
            _strVoucherNo = Value
        End Set
    End Property

    Public Property DisAmount() As Integer
        Get
            Return _intAmount
        End Get
        Set(ByVal Value As Integer)
            _intAmount = Value
        End Set
    End Property

    Public Property BalanceAmt() As Integer
        Get
            Return _intBalanceAmt
        End Get
        Set(ByVal Value As Integer)
            _intBalanceAmt = Value
        End Set
    End Property

    Public Property RemAmount() As Integer
        Get
            Return _intRemAmount
        End Get
        Set(ByVal Value As Integer)
            _intRemAmount = Value
        End Set
    End Property

    Public Property DisSlNo() As Integer
        Get
            Return _intSlno
        End Get
        Set(ByVal Value As Integer)
            _intSlno = Value
        End Set
    End Property
    Public Property RepaySlNo() As Integer
        Get
            Return _intRepaySlno
        End Get
        Set(ByVal Value As Integer)
            _intRepaySlno = Value
        End Set
    End Property


    Public Property DisDate() As Date
        Get
            Return _datDisbDate
        End Get
        Set(ByVal Value As Date)
            _datDisbDate = Value
        End Set
    End Property

    Public Property TODate() As Date
        Get
            Return _datToDate
        End Get
        Set(ByVal Value As Date)
            _datToDate = Value
        End Set
    End Property

    Public Property datDisbTable() As DataTable
        Get
            Return _dtDisburament
        End Get
        Set(ByVal Value As DataTable)
            _dtDisburament = Value
        End Set
    End Property

    Public Property DisbAmtTable() As DataTable
        Get
            Return _dtAmt
        End Get
        Set(ByVal Value As DataTable)
            _dtAmt = Value
        End Set
    End Property

    Public Property RemAmtTable() As DataTable
        Get
            Return _dtRemAmt
        End Get
        Set(ByVal Value As DataTable)
            _dtRemAmt = Value
        End Set
    End Property

    Public Property datDisbAmt() As DataTable
        Get
            Return _dtDisbAmount
        End Get
        Set(ByVal Value As DataTable)
            _dtDisbAmount = Value
        End Set
    End Property

    Public Property datMaxSlnoAmt() As DataTable
        Get
            Return _dtMaxSlNo
        End Get
        Set(ByVal Value As DataTable)
            _dtMaxSlNo = Value
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

    Public Property datNoOfDisb() As DataTable
        Get
            Return _dtNoOfDisb
        End Get
        Set(ByVal Value As DataTable)
            _dtNoOfDisb = Value
        End Set
    End Property

    Public Property SecurityDeposit() As Integer
        Get
            Return _intSecDeposit
        End Get
        Set(ByVal Value As Integer)
            _intSecDeposit = Value
        End Set
    End Property
    Public Property intrestAmount() As Integer
        Get
            Return _intintrest
        End Get
        Set(ByVal Value As Integer)
            _intintrest = Value
        End Set
    End Property
    Public Property BuildingFund() As Double
        Get
            Return _dblBuildingFund
        End Get
        Set(ByVal Value As Double)
            _dblBuildingFund = Value
        End Set
    End Property

    Public Property DocFee() As Integer
        Get
            Return _intDocFee
        End Get
        Set(ByVal Value As Integer)
            _intDocFee = Value
        End Set
    End Property

    Public Property ProcessingCharge() As Integer
        Get
            Return _intProcCharges
        End Get
        Set(ByVal Value As Integer)
            _intProcCharges = Value
        End Set
    End Property

    Public Property OtherCharge() As Integer
        Get
            Return _intOtherCharges
        End Get
        Set(ByVal Value As Integer)
            _intOtherCharges = Value
        End Set
    End Property




#End Region


#Region "Functions"


    Public Function fnInsertDisb(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Insert into loandisbtbl(loanNo,SlNo,DisbDate,Amount,RefNo,RemAmount,BankDetails,Remarks,VoucherNo,DisbUsability) "
        strSQL = strSQL & " Values ('" & _strLoanNo & "','" & _intSlno & "','" & Format(_datDisbDate, "yyyy-MM-dd") & "','" & _intAmount & "','" & _strRefNo & "','" & _intRemAmount & "','" & _strBankDet & "','" & _strRemarks & "','" & _strVoucherNo & "','N')"
        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnGetDisbAmount(ByVal _StrLoanNo As String) As Boolean

        'strSQL = "select P.*,ifnull(S.Expamount,0) as Expamount,s.sancamount as sancamount,ifnull(s.disbamount,0) as disbamount from loandisbtbl p , loandetailstbl s where p.loanno = s.loanNo and p.loanNo= '" & _StrLoanNo & "'"
        strSQL = "select ifnull(S.Expamount,0) as Expamount,s.sancamount as sancamount,ifnull(s.disbamount,0) as disbamount from  loandetailstbl s where s.loanNo= '" & _StrLoanNo & "'"

        _dtDisburament = fnExecuteQuery(strSQL, 2)

        If _dtDisburament.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If


    End Function
    Public Function fnGetDisb(ByVal _StrLoanNo As String) As Boolean

        strSQL = "select P.*,ifnull(S.Expamount,0) as Expamount,s.sancamount as sancamount,ifnull(s.disbamount,0) as disbamount from loandisbtbl p , loandetailstbl s where p.loanno = s.loanNo and p.loanNo= '" & _StrLoanNo & "'"
        'strSQL = "select ifnull(S.Expamount,0) as Expamount,s.sancamount as sancamount,ifnull(s.disbamount,0) as disbamount from  loandetailstbl s where s.loanNo= '" & _StrLoanNo & "'"

        _dtDisburament = fnExecuteQuery(strSQL, 2)

        If _dtDisburament.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If


    End Function

    Public Function fnCheckDis(ByVal _strLoanNo As String) As Boolean

        strSQL = "select ifnull((sancamount),0) as sancamount, ifnull((DisbAmount),0) as DisbAmount,DueDate ,SBNo from loandetailstbl where loanno = '" & _strLoanNo & "'"

        _dtDisbAmount = fnExecuteQuery(strSQL, 2)

        Return True

    End Function



    Public Function fnCheckAmt() As Boolean

        'strSQL = "select disbamount, sancamount from loandetailstbl where loanno = '" & _strLoanNo & "'"
        strSQL = "SELECT ifnull(SUM(AMOUNT),0)as total FROM LOANdISBTBL WHERE LOANNO = '" & _strLoanNo & "'"

        _dtAmt = fnExecuteQuery(strSQL, 2)

        Return True

    End Function


    Public Function fnGetRemaningAmt(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "update loandisbtbl set remamount = '" & _intRemAmount & "' where loanno = '" & _strLoanNo & "' and slno = '" & _intSlno & "'"

        fnExecuteNonQuery(strSQL, objTrans)

        Return True

    End Function

    Public Function fnUpdateDisbStatus(ByVal strLoanNo As String, ByVal SlNo As Integer, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "update loandisbtbl set DisbUsability = 'Y' where loanno = '" & strLoanNo & "' and slno = '" & SlNo & "'"

        fnExecuteNonQuery(strSQL, objTrans)

        Return True

    End Function
    Public Function fnUpdateDisbStatus(ByVal strLoanNo As String, ByVal SlNo As Integer) As Boolean

        strSQL = "update loandisbtbl set DisbUsability = 'Y' where loanno = '" & strLoanNo & "' and slno = '" & SlNo & "'"

        fnExecuteNonQuery(strSQL)

        Return True

    End Function

    Public Function fnGetMaxSlno(ByVal _StrloanNo As String) As Boolean

        '   '   ' function to get the max of slno which has to be unique

        strSQL = "select ifnull(max(slno),0) as slno from loandisbtbl where loanno = '" & _StrloanNo & "'"

        _dtMaxSlNo = fnExecuteQuery(strSQL, 2)

        Return True
    End Function

    Public Function fnUpdataLastPaid() As Boolean

        strSQL = "update loandetailstbl set lastpaiddate = '" & Format(_datDisbDate, "yyyy-MM-dd") & "' WHERE loanno = '" & _strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function
    Public Function fnUpdataeSecurityDeposit(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "update loandetailstbl set lastpaiddate = '" & Format(_datDisbDate, "yyyy-MM-dd") & "',LastInstDate='" & Format(_datDisbDate, "yyyy-MM-dd") & "',SecurityDeposit='" & _intSecDeposit & "',DocFee='" & _intDocFee & "',ProcCharges='" & _intProcCharges & "',OtherCharges='" & _intOtherCharges & "',BuildingFund='" & _dblBuildingFund & "' WHERE loanno = '" & _strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnUpdateVouncherNo(ByVal lngVouncherNo As String, ByVal strLoanNo As String, ByVal objTrans As IDbTransaction) As Boolean

        'strSQL = "Update loandisbtbl set voucherNo = '" & lngVouncherNo & "' where loanno = '" & strLoanNo & "'"

        'strSQL = "update loandisbtbl set remamount = '" & _intRemAmount & "' where loanno = '" & _strLoanNo & "' and slno = '" & _intSlno & "'"

        strSQL = "Insert into loandisbtbl(loanNo,SlNo,DisbDate,Amount,RefNo,RemAmount,BankDetails,Remarks,VoucherNo,DisbUsability) "
        strSQL = strSQL & " Values ('" & _strLoanNo & "','" & _intSlno & "','" & Format(_datDisbDate, "yyyy-MM-dd") & "','" & _intAmount & "','" & _strRefNo & "','" & _intRemAmount & "','" & _strBankDet & "','" & _strRemarks & "','" & _strVoucherNo & "','N')"


        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function


    Public Function fnCheckNoOfDisb(ByVal strLoanNo As String) As Boolean

        strSQL = "select ifnull(max(slno),0) as slno from loandisbtbl where loanno = '" & strLoanNo & "'"

        datNoOfDisb = fnExecuteQuery(strSQL, 2)

        If datNoOfDisb.Rows.Count > 0 Then

            Return True
        Else
            Return False
        End If

        Return True

    End Function


    Public Function fnAddData(ByVal lngVoucherNo As Long, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Insert into loanRePaymenttbl(LoanNo,InstNo,RepayDate,FromDate,ToDate,Debit,Credit,InterestRaised,Interestpaid,PenelInterest,Others,Remarks,Balance,ChallanNo,VoucherNo,ReferenceNo,IntReceivable,IntCOver)"
        strSQL = strSQL & " values('" & _strLoanNo & "','" & _intRepaySlno & "','" & Format(_datDisbDate, "yyyy-MM-dd") & "','" & Format(_datDisbDate, "yyyy-MM-dd") & "','" & Format(_datToDate, "yyyy-MM-dd") & "','" & _intAmount & "','0','" & _intintrest & "','" & _intintrest & "','0','" & _intOtherCharges & "','" & _strRemarks & "','" & _intBalanceAmt & "','" & _strRefNo + 1 & "','" & lngVoucherNo & "','" & _strRefNo & "','0','0')"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function
    Public Function fnMaxNo(ByVal _strloanNo As String) As Boolean

        strSQL = "select ifnull(max(instNo),0) as InstNo,ifnull(sum(Credit)-sum(Debit),0) as Principle ,ifnull(sum(Debit),0)as Amount  from loanrepaymenttbl where loanNo = '" & _strloanNo & "'"

        _dtMaxInstNo = fnExecuteQuery(strSQL, 2)

        Return True

    End Function


#End Region

End Class
