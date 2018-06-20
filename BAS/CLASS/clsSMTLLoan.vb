Public Class clsSMTLLoan
    Inherits clsPerson
#Region "Variables"

    Private _strAccountNo As String
    Private _PersonNo As Long
    Private _strFDNo As String
    Private _strSBNo As String
    Private _strMemberNo As String

    'person Number Comes from clsperson

    Private _datSMTLLoanData As Date
    Private _dtSMTLLoan As DataTable
    Private _dtSMTLLoanDet As DataTable
    Private _dtSMTLLoanCust As DataTable

    Private _chrSMTLagainst As Char
    Private _intSMTLLimit As Double
    Private _intEstAmount As Double
    Private _intBalance As Double
    Private _dblROI As Double
    Private _chrAccStatus As Char
    Private _dtpAppDate As Date
    Private _intIntAmount As Double
    Private _intIntAmttobePay As Double
    Private _intIntAmtPaid As Double
    Private _strReciptNo As String
    Private _StrRemarks As String
    Private _strChequeNo As String

    Private _strWitnessPerson1 As String
    Private _strWitnessPerson2 As String
    Private _strWitnessAddress1 As String
    Private _strWitnessAddress2 As String

    Private _dblRemaningAmt As Double
    Private _datLastTar As Date
    Private _dtSMTLDet As DataTable

    Private _dtFDDetails As DataTable
    Private _dtNSCDetails As DataTable
    Private _dblFDAmt As Double


    '''''''''''''''''''''''''''''''''''
    'Asset Details
    Private _datDueDate As Date
    Private _strSubsidy As String
    Private _intDisbAmt As Double

    Private _strLoanNo As String
    Private _dblMonthlyIncome As Double
    Private _intExpectedAmount As Integer
    Private _intSanctionedAmount As Integer
    Private _intInstPrinciple As Integer
    Private _strModeOfPayment As String
    Private _strInstallment As String
    Private _strStatus As String
    Private _datLastPaid As Date
    Private _IntPostingDt As Date

    Private _intNOI As Integer

    Private _strReason As String
    Private _strLFNo As String
    Private _strRCTNo As String
    Private _chrConditions1 As Char
    Private _chrConditions2 As Char
    Private _chrConditions3 As Char
    Private _chrConditions4 As Char
    Private _chrConditions5 As Char

#End Region
#Region "Properties"
    Public Property IntPostingDt() As Date
        Get
            Return _IntPostingDt
        End Get
        Set(ByVal Value As Date)
            _IntPostingDt = Value
        End Set
    End Property

    Public Property AccountNo() As String
        Get
            Return _strAccountNo
        End Get
        Set(ByVal Value As String)
            _strAccountNo = Value
        End Set
    End Property

    Public Property MemberNo() As String
        Get
            Return _strMemberNo
        End Get
        Set(ByVal Value As String)
            _strMemberNo = Value
        End Set
    End Property

    Public Property SBNo() As String
        Get
            Return _strSBNo
        End Get
        Set(ByVal Value As String)
            _strSBNo = Value
        End Set
    End Property

    'Public Property Remarks() As String
    '    Get
    '        Return _StrRemarks
    '    End Get
    '    Set(ByVal Value As String)
    '        _StrRemarks = Value
    '    End Set
    'End Property

    Public Property ReciptNo() As String
        Get
            Return _strReciptNo
        End Get
        Set(ByVal Value As String)
            _strReciptNo = Value
        End Set
    End Property
    Public Property ChequeNumber() As String
        Get
            Return _strChequeNo
        End Get
        Set(ByVal Value As String)
            _strChequeNo = Value
        End Set
    End Property

    Public Property SMTLLimit() As Double
        Get
            Return _intSMTLLimit
        End Get
        Set(ByVal Value As Double)
            _intSMTLLimit = Value
        End Set
    End Property
    Public Property EstAmount() As Double
        Get
            Return _intEstAmount
        End Get
        Set(ByVal Value As Double)
            _intEstAmount = Value
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
    Public Property DisbAmt() As Integer
        Get
            Return _intDisbAmt
        End Get
        Set(ByVal Value As Integer)
            _intDisbAmt = Value
        End Set
    End Property

    Public Property RIO() As Double
        Get
            Return _dblROI
        End Get
        Set(ByVal Value As Double)
            _dblROI = Value
        End Set
    End Property

    Public Property AccAtatus() As Char
        Get
            Return _chrAccStatus
        End Get
        Set(ByVal Value As Char)
            _chrAccStatus = Value
        End Set
    End Property

    Public Property SMTLAgainst() As Char
        Get
            Return _chrSMTLagainst
        End Get
        Set(ByVal Value As Char)
            _chrSMTLagainst = Value
        End Set
    End Property

    Public Property AppDate() As Date
        Get
            Return _dtpAppDate
        End Get
        Set(ByVal Value As Date)
            _dtpAppDate = Value
        End Set
    End Property

    Public Property IntrestAmount() As Double
        Get
            Return _intIntAmount
        End Get
        Set(ByVal Value As Double)
            _intIntAmount = Value
        End Set
    End Property

    Public Property IntAmtTobePaid() As Double
        Get
            Return _intIntAmttobePay
        End Get
        Set(ByVal Value As Double)
            _intIntAmttobePay = Value
        End Set
    End Property
    Public Property IntAmtPaid() As Double
        Get
            Return _intIntAmtPaid
        End Get
        Set(ByVal Value As Double)
            _intIntAmtPaid = Value
        End Set
    End Property

    Public Property LastTransaction() As Date
        Get
            Return _datLastTar
        End Get
        Set(ByVal Value As Date)
            _datLastTar = Value
        End Set
    End Property

    Public Property WitnessPerson1() As String
        Get
            Return _strWitnessPerson1
        End Get
        Set(ByVal Value As String)
            _strWitnessPerson1 = Value
        End Set
    End Property

    Public Property WitnessPerson2() As String
        Get
            Return _strWitnessPerson2
        End Get
        Set(ByVal Value As String)
            _strWitnessPerson2 = Value
        End Set
    End Property

    Public Property WitnessPersonAddress1() As String
        Get
            Return _strWitnessAddress1
        End Get
        Set(ByVal Value As String)
            _strWitnessAddress1 = Value
        End Set
    End Property

    Public Property WitnessPersonAddress2() As String
        Get
            Return _strWitnessAddress2
        End Get
        Set(ByVal Value As String)
            _strWitnessAddress2 = Value
        End Set
    End Property

    Public Property OverDraftLoanDate() As Date
        Get
            Return _datSMTLLoanData
        End Get
        Set(ByVal Value As Date)
            _datSMTLLoanData = Value
        End Set
    End Property
    Public Property SMTLLoan() As DataTable
        Get
            Return _dtSMTLLoan
        End Get
        Set(ByVal Value As DataTable)
            _dtSMTLLoan = Value
        End Set
    End Property

    Public Property SMTLLoanDettable() As DataTable
        Get
            Return _dtSMTLLoanDet
        End Get
        Set(ByVal Value As DataTable)
            _dtSMTLLoanDet = Value
        End Set
    End Property
    Public Function fnGetNSCSecurityDetails(ByVal strLoanNo As String) As Boolean

        strSQL = "select S.* from securitydetailstbl S , smtldetailstbl SMTL where S.LoanNo = SMTL.AccountNo and SMTL.AccountNo = '" & strLoanNo & "' and S.DepositType='NSC'"

        _dtNSCDetails = fnExecuteQuery(strSQL, 2)

        If _dtNSCDetails.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetFDSecurityDetails(ByVal strLoanNo As String) As Boolean

        strSQL = "select S.* from securitydetailstbl S , smtldetailstbl SMTL where S.LoanNo = SMTL.AccountNo and SMTL.AccountNo = '" & strLoanNo & "' and S.DepositType='FD'"

        _dtFDDetails = fnExecuteQuery(strSQL, 2)

        If _dtFDDetails.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Property OverDraftLoanCusttable() As DataTable
        Get
            Return _dtSMTLLoanCust
        End Get
        Set(ByVal Value As DataTable)
            _dtSMTLLoanCust = Value
        End Set
    End Property

    Public Property SMTLDetailstable() As DataTable
        Get
            Return _dtSMTLDet
        End Get
        Set(ByVal Value As DataTable)
            _dtSMTLDet = Value
        End Set
    End Property
    Public Property NSCDetailsTable() As DataTable
        Get
            Return _dtNSCDetails
        End Get
        Set(ByVal Value As DataTable)
            _dtNSCDetails = Value
        End Set
    End Property

    ''''''''''''''''''''''''''''''''''''''''''''''

    Public Property LoanNo() As String
        Get
            Return _strLoanNo
        End Get
        Set(ByVal Value As String)
            _strLoanNo = Value
        End Set
    End Property
    Public Property DemandReason() As String
        Get
            Return _strReason
        End Get
        Set(ByVal Value As String)
            _strReason = Value
        End Set
    End Property
    Public Property MonthlyIncome() As Double
        Get
            Return _dblMonthlyIncome
        End Get
        Set(ByVal Value As Double)
            _dblMonthlyIncome = Value
        End Set
    End Property
    Public Property ExpectedAmount() As Integer
        Get
            Return _intExpectedAmount
        End Get
        Set(ByVal Value As Integer)
            _intExpectedAmount = Value
        End Set
    End Property

    Public Property Sanctioned() As Integer
        Get
            Return _intSanctionedAmount
        End Get
        Set(ByVal Value As Integer)
            _intSanctionedAmount = Value
        End Set
    End Property

    Public Property LastPaidDate() As Date
        Get
            Return _datLastPaid
        End Get
        Set(ByVal Value As Date)
            _datLastPaid = Value
        End Set
    End Property

    Public Property DueDate() As Date
        Get
            Return _datDueDate
        End Get
        Set(ByVal Value As Date)
            _datDueDate = Value
        End Set
    End Property

    Public Property Subsidy() As String
        Get
            Return _strSubsidy
        End Get
        Set(ByVal Value As String)
            _strSubsidy = Value
        End Set
    End Property

    Public Property RemaningAmount() As Double
        Get
            Return _dblRemaningAmt
        End Get
        Set(ByVal Value As Double)
            _dblRemaningAmt = Value
        End Set
    End Property

    Public Property Installments() As String
        Get
            Return _strInstallment
        End Get
        Set(ByVal Value As String)
            _strInstallment = Value
        End Set
    End Property

    Public Property ModeOfPayment() As String
        Get
            Return _strModeOfPayment
        End Get
        Set(ByVal Value As String)
            _strModeOfPayment = Value
        End Set
    End Property

    Public Property InstPrinciple() As Integer
        Get
            Return _intInstPrinciple
        End Get
        Set(ByVal Value As Integer)
            _intInstPrinciple = Value
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


    Public Property LFNo() As String
        Get
            Return _strLFNo
        End Get
        Set(ByVal Value As String)
            _strLFNo = Value
        End Set
    End Property

    Public Property DepRCTNo() As String
        Get
            Return _strRCTNo
        End Get
        Set(ByVal Value As String)
            _strRCTNo = Value
        End Set
    End Property

    Public Property Conditons1() As Char
        Get
            Return _chrConditions1
        End Get
        Set(ByVal Value As Char)
            _chrConditions1 = Value
        End Set
    End Property

    Public Property Conditons2() As Char
        Get
            Return _chrConditions2
        End Get
        Set(ByVal Value As Char)
            _chrConditions2 = Value
        End Set
    End Property

    Public Property Conditons3() As Char
        Get
            Return _chrConditions3
        End Get
        Set(ByVal Value As Char)
            _chrConditions3 = Value
        End Set
    End Property


    Public Property FDDetailstable() As DataTable
        Get
            Return _dtFDDetails
        End Get
        Set(ByVal Value As DataTable)
            _dtFDDetails = Value
        End Set
    End Property

    Public Property FDNo() As String
        Get
            Return _strFDNo
        End Get
        Set(ByVal Value As String)
            _strFDNo = Value
        End Set
    End Property

    Public Property FDAmt() As Double
        Get
            Return _dblFDAmt
        End Get
        Set(ByVal Value As Double)
            _dblFDAmt = Value
        End Set
    End Property

#End Region

#Region "Function"

#Region "OverDraft Functions"

    Public Function fnAddSMTLLAccount(ByVal objTrans As IDbTransaction) As Boolean

        If fnCheckPerson() Then

            If fnUpdatePerson() Then

                If fnInsertSMTLAccount(objTrans) Then

                    Return fnInsertSecurityDetailsInfo(objTrans)

                End If

            End If

        Else

            If fnAddPerson() Then

                If fnInsertSMTLAccount(objTrans) Then

                    Return fnInsertSecurityDetailsInfo(objTrans)

                Else

                    fnDeletePerson(objTrans)

                    fnDeleteLoanDet(AccountNo, objTrans)


                End If

            End If

        End If


    End Function
#End Region

    Public Function fnInsertSMTLAccount(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "insert into smtldetailstbl(AccountNo,PersonNo,CustomerID,SMTLAgainst,AccDate,SMTLLimit,EstimatedAmt,Balance,IntAmount,FDNo,AccStatus,ROI,LastPaidDate,Remarks,ReceiptNo,IntPostingStatus,InterestReceivable,IsPayWithIn15Day)"
        strSQL = strSQL & " values('" & _strAccountNo & "','" & PersonNo & "','" & _strMemberNo & "','" & _chrSMTLagainst & "','" & Format(_dtpAppDate, "yyyy-MM-dd") & "','" & _intSMTLLimit & "','" & _intEstAmount & "','" & _intBalance & "','" & _intIntAmount & "','" & _strFDNo & "','"
        strSQL = strSQL & _chrAccStatus & "','" & _dblROI & "','" & Format(_datLastTar, "yyyy-MM-dd") & "',' " & _StrRemarks & "','" & _strReciptNo & "',' 0 ','0','0')"
        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function
    Public Function fnUpdateLoanDetails(ByVal strLoanNo As String, ByVal objTrans As IDbTransaction) As Boolean


        If fnUpdatePerson() Then
            strSQL = "UPDATE smtldetailstbl SET CustomerID = '" & _strMemberNo & "',personNo = '" & PersonNo & "', SMTLLimit='" & _intSMTLLimit & "', ROI='" & _dblROI & "', Remarks = '" & _StrRemarks & "' WHERE  AccountNo='" & strLoanNo & "'"

            Return fnExecuteNonQuery(strSQL, objTrans)
        Else
            Return False
        End If



    End Function
    Public Function fnChekSMTLAccount(ByVal strAccountNo As String) As Boolean

        strSQL = "select * from smtldetailstbl where AccountNo = '" & strAccountNo & "'"

        _dtSMTLLoan = fnExecuteQuery(strSQL, 2)

        If _dtSMTLLoan.Rows.Count > 0 Then

            Return True
        Else
            Return False

        End If
    End Function
    Public Function fnGetSMTLLoanCust() As Boolean

        strSQL = "select P.*, S.* FROM smtldetailstbl S, PersonTbl P WHERE P.PersonNo=S.PersonNo " 'and loanNo like 'SMTL%'"

        _dtSMTLLoanCust = fnExecuteQuery(strSQL, 2)

        If _dtSMTLLoanCust.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fnGetSMTLTransaction(ByVal strLoanNo As String) As Boolean

        'strSQL = "Select * from odtransactiontbl where AccountNo = '" & strLoanNo & "'"
        strSQL = " Select Trdate,Deposit,Withdraw,PostBal,IntAmount,ChequeNo,IntTobePaid,IntPaid,VoucherNo,substring_index(Narration,':',-1) as Narration from smtltransactiontbl  where AccountNo = '" & strLoanNo & "'"
        _dtSMTLDet = fnExecuteQuery(strSQL, 2)

        If _dtSMTLDet.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function
    Public Function fnAddSMTLAccount(ByVal objTrans As IDbTransaction) As Boolean

        If fnCheckPerson() Then

            If fnUpdatePerson() Then

                If fnInsertSMTLAccount(objTrans) Then

                    Return fnInsertSecurityDetailsInfo(objTrans)

                End If

            End If

        Else

            If fnAddPerson() Then

                If fnInsertSMTLAccount(objTrans) Then

                    Return fnInsertSecurityDetailsInfo(objTrans)

                Else

                    fnDeletePerson(objTrans)

                    fnDeleteLoanDet(AccountNo, objTrans)


                End If

            End If

        End If


    End Function
    Public Function fnDeleteLoanDet(ByVal strAccountNo As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "delete from smtldetailstbl where AccountNo = '" & strAccountNo & "'"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function
    Public Function fnGetLoanDetails(ByVal strLoanNo As String) As Boolean

        strSQL = "SELECT v.*,p.* FROM smtldetailstbl v,persontbl p WHERE v.personno=p.personno and  v.AccountNo='" & strLoanNo & "' "

        _dtSMTLLoanDet = fnExecuteQuery(strSQL, 2)

        If _dtSMTLLoanDet.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function fnInsertSecurityDetailsInfo(ByVal objTrans As IDbTransaction) As Boolean

        Dim intCount As Integer
        Dim dr As DataRow

        ' If _dtFDDetails.Rows.Count > 0 Then
        For Each dr In _dtFDDetails.Rows
            strSQL = "Insert into securitydetailstbl (LoanNo,DepositType,DepositTypeNo,NameOfDepositor,DepositDate,DepositAmt,MatDate,MatAmt) "
            strSQL = strSQL & " values ('" & dr(0) & "','" & dr(1) & "','" & dr(2) & "','" & dr(3) & "','" & dr(4) & "','" & dr(5) & "','" & dr(6) & "','" & dr(7) & "')"
            fnExecuteNonQuery(strSQL, objTrans)
        Next

        ' End If
        'For Each dr In _dtNSCDetails.Rows
        '    strSQL = "Insert into securitydetailstbl (LoanNo,DepositType,DepositTypeNo,NameOfDepositor,DepositDate,DepositAmt,MatDate,MatAmt) "
        '    strSQL = strSQL & " values ('" & dr(0) & "','" & dr(1) & "','" & dr(2) & "','" & dr(3) & "','" & dr(4) & "','" & dr(5) & "','" & dr(6) & "','" & dr(7) & "')"
        '    fnExecuteNonQuery(strSQL)
        'Next
        Return True

    End Function
    Public Function fnUpDateAddInt(ByVal strLoanNo As String, ByVal DepositAmt As Double) As Boolean

        strSQL = "update smtldetailstbl set  lastpaiddate = '" & Format(_datLastTar, "yyyy-MM-dd") & "', intamount = intamount + '" & _intIntAmount & "',InterestReceivable=InterestReceivable - '" & DepositAmt & "',IntPostingStatus='0' where AccountNo = '" & _strAccountNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function
    Public Function fnUpDateAddIntWithIn15Day(ByVal strLoanNo As String, ByVal DepositAmt As Double) As Boolean

        strSQL = "update smtldetailstbl set  lastpaiddate = '" & Format(_datLastTar, "yyyy-MM-dd") & "',IntPostingStatus='0',IsPayWithIn15Day='1' where AccountNo = '" & _strAccountNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function
    Public Function fnUpDateAddInt(ByVal strLoanNo As String) As Boolean

        strSQL = "update smtldetailstbl set  lastpaiddate = '" & Format(_datLastTar, "yyyy-MM-dd") & "', intamount = intamount + '" & _intIntAmount & "',IntPostingStatus='0' where AccountNo = '" & _strAccountNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnUpDateAddIntWithIntPostingSatusOne(ByVal strLoanNo As String, ByVal DepositAmt As Double) As Boolean

        strSQL = "update smtldetailstbl set  lastpaiddate = '" & Format(_datLastTar, "yyyy-MM-dd") & "', intamount = intamount + '" & _intIntAmount & "',IntPostingStatus='1',InterestReceivable=InterestReceivable - '" & DepositAmt & "' where AccountNo = '" & _strAccountNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function
    Public Function fnUpDateAddIntWithIntPostingSatusOne(ByVal strLoanNo As String) As Boolean

        strSQL = "update smtldetailstbl set  lastpaiddate = '" & Format(_datLastTar, "yyyy-MM-dd") & "', intamount = intamount + '" & _intIntAmount & "',IntPostingStatus='1' where AccountNo = '" & _strAccountNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Function fnSMTLtransactionEnter(ByVal strAccountNo As String, ByVal dtTransDate As Date, ByVal strNarration As String, ByVal dblDeposit As Double, ByVal dblWithdraw As Double, ByVal dblPostBal As Double, ByVal dblIntAmount As Double, ByVal dblintToboPaid As Double, ByVal dblIntPaid As Double, ByVal strRefNo As String, ByVal lngvoucherNo As Long, ByVal strType As String, ByVal strchequeNo As String) As Boolean
        strSQL = "Insert into smtltransactiontbl(AccountNo,Trdate,Narration,Deposit,Withdraw,PostBal,IntAmount,IntTobePaid,IntPaid,Refno,VoucherNo,Type,ChequeNo)"
        strSQL = strSQL & " Values( '" & strAccountNo & "','" & Format(dtTransDate, "yyyy-MM-dd") & "','" & strNarration & "','" & dblDeposit & "','" & dblWithdraw & "','" & dblPostBal & "','" & dblIntAmount & "','" & dblintToboPaid & "','" & dblIntPaid & "','" & strRefNo & "','" & lngvoucherNo & "','" & strType & "','" & strchequeNo & "')"
        fnExecuteNonQuery(strSQL)
    End Function
    Public Function fnUpdateInterest(ByVal strLoanNo As String, ByVal IntReceivable As Double) As Boolean

        strSQL = "update smtldetailstbl set  lastpaiddate = '" & Format(_datLastTar, "yyyy-MM-dd") & "', intamount = '0',IntPostingStatus='1',InterestReceivable=InterestReceivable + '" & IntReceivable & "' where AccountNo = '" & _strAccountNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function
    Public Function fnGetSMTLData() As Boolean

        strSQL = "SELECT P.Name,SMTL.* FROM SMTLdetailstbl SMTL,persontbl P where P.PersonNo = SMTL.PersonNo "
        _dtSMTLLoan = fnExecuteQuery(strSQL, 2)
        If _dtSMTLLoan.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region
End Class
