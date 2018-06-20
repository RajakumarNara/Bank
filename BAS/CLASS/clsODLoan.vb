
Public Class clsODLoanDetails
    Inherits clsPerson

#Region "Variables"

    Private _strAccountNo As String
    Private _PersonNo As Long
    Private _strFDNo As String
    Private _strSBNo As String
    Private _strMemberNo As String

    'person Number Comes from clsperson

    Private _datODLoanData As Date
    Private _dtODLoan As DataTable
    Private _dtODLoanDet As DataTable
    Private _dtODLoanCust As DataTable

    Private _chrODagainst As Char
    Private _intODLimit As Double
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
    Private _dtODLDet As DataTable

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

    Public Property ODLimit() As Double
        Get
            Return _intODLimit
        End Get
        Set(ByVal Value As Double)
            _intODLimit = Value
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

    Public Property ODAgainst() As Char
        Get
            Return _chrODagainst
        End Get
        Set(ByVal Value As Char)
            _chrODagainst = Value
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
            Return _datODLoanData
        End Get
        Set(ByVal Value As Date)
            _datODLoanData = Value
        End Set
    End Property
    Public Property ODLoan() As DataTable
        Get
            Return _dtODLoan
        End Get
        Set(ByVal Value As DataTable)
            _dtODLoan = Value
        End Set
    End Property

    Public Property ODLoanDettable() As DataTable
        Get
            Return _dtODLoanDet
        End Get
        Set(ByVal Value As DataTable)
            _dtODLoanDet = Value
        End Set
    End Property

    Public Property OverDraftLoanCusttable() As DataTable
        Get
            Return _dtODLoanCust
        End Get
        Set(ByVal Value As DataTable)
            _dtODLoanCust = Value
        End Set
    End Property

    Public Property ODLDetailstable() As DataTable
        Get
            Return _dtODLDet
        End Get
        Set(ByVal Value As DataTable)
            _dtODLDet = Value
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

    Public Function fnAddODLAccount(ByVal objTrans As IDbTransaction) As Boolean

        If fnCheckPerson() Then

            If fnUpdatePerson() Then

                If fnInsertODLAccount(objTrans) Then

                    Return fnInsertSecurityDetailsInfo(objTrans)

                End If

            End If

        Else

            If fnAddPerson() Then

                If fnInsertODLAccount(objTrans) Then

                    Return fnInsertSecurityDetailsInfo(objTrans)

                Else

                    fnDeletePerson(objTrans)

                    fnDeleteLoanDet(AccountNo, objTrans)


                End If

            End If

        End If


    End Function

    Public Function fnInsertODLAccount(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "insert into oddetailstbl(AccountNo,PersonNo,CustomerID,ODAgainst,AccDate,OdLimit,EstimatedAmt,Balance,IntAmount,FDNo,AccStatus,ROI,LastPaidDate,Remarks,ReceiptNo,IntPostingStatus,InterestReceivable)"
        strSQL = strSQL & " values('" & _strAccountNo & "','" & PersonNo & "','" & _strMemberNo & "','" & _chrODagainst & "','" & Format(_dtpAppDate, "yyyy-MM-dd") & "','" & _intODLimit & "','" & _intEstAmount & "','" & _intBalance & "','" & _intIntAmount & "','" & _strFDNo & "','"
        strSQL = strSQL & _chrAccStatus & "','" & _dblROI & "','" & Format(_datLastTar, "yyyy-MM-dd") & "',' " & _StrRemarks & "','" & _strReciptNo & "','" & 0 & "','0')"
        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnChekODLAccount(ByVal strAccountNo As String) As Boolean

        strSQL = "select * from oddetailstbl where AccountNo = '" & strAccountNo & "'"

        _dtODLoan = fnExecuteQuery(strSQL, 2)

        If _dtODLoan.Rows.Count > 0 Then

            Return True
        Else
            Return False

        End If
    End Function
    Public Function fnCheckSMTLAccount(ByVal strAccountNo As String) As Boolean

        strSQL = "select * from smtldetailstbl where AccountNo = '" & strAccountNo & "'"

        _dtODLoan = fnExecuteQuery(strSQL, 2)

        If _dtODLoan.Rows.Count > 0 Then

            Return True
        Else
            Return False

        End If
    End Function
    Public Function fnGetODData() As Boolean

        strSQL = "SELECT P.Name,OD.* FROM oddetailstbl OD,persontbl P where P.PersonNo = OD.PersonNo "
        _dtODLoan = fnExecuteQuery(strSQL, 2)
        If _dtODLoan.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnDeleteLoanDet(ByVal strAccountNo As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "delete from oddetailstbl where AccountNo = '" & strAccountNo & "'"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function


    Public Function fnUpdateLoanDetails(ByVal strLoanNo As String, ByVal objTrans As IDbTransaction) As Boolean


        If fnUpdatePerson() Then
            strSQL = "UPDATE oddetailstbl SET CustomerID = '" & _strMemberNo & "',personNo = '" & PersonNo & "', OdLimit='" & _intODLimit & "', ROI='" & _dblROI & "', Remarks = '" & _StrRemarks & "' WHERE  AccountNo='" & strLoanNo & "'"

            Return fnExecuteNonQuery(strSQL, objTrans)
        Else
            Return False
        End If



    End Function

    Public Function fnGetLoanDetails(ByVal strLoanNo As String) As Boolean

        strSQL = "SELECT P.*, v.* FROM oddetailstbl v, PersonTbl P WHERE P.PersonNo=v.PersonNo  and v.AccountNo='" & strLoanNo & "' "

        _dtODLoanDet = fnExecuteQuery(strSQL, 2)

        If _dtODLoanDet.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function fnGetODLoanCust() As Boolean

        strSQL = "select P.*, S.* FROM oddetailstbl S, PersonTbl P WHERE P.PersonNo=S.PersonNo " 'and loanNo like 'OD%'"

        _dtODLoanCust = fnExecuteQuery(strSQL, 2)

        If _dtODLoanCust.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fnUpDateAddInt(ByVal strLoanNo As String, ByVal IntReceivable As Double) As Boolean

        strSQL = "update oddetailstbl set  lastpaiddate = '" & Format(_datLastTar, "yyyy-MM-dd") & "', intamount = intamount + '" & _intIntAmount & "',IntPostingStatus='0',InterestReceivable=InterestReceivable - '" & IntReceivable & "' where AccountNo = '" & _strAccountNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function
    Public Function fnUpDateAddInt(ByVal strLoanNo As String) As Boolean

        strSQL = "update oddetailstbl set  lastpaiddate = '" & Format(_datLastTar, "yyyy-MM-dd") & "', intamount = intamount + '" & _intIntAmount & "',IntPostingStatus='0' where AccountNo = '" & _strAccountNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function
    Public Function fnUpDateAddIntWithIntPostStatusOne(ByVal strLoanNo As String, ByVal IntReceivable As Double) As Boolean

        strSQL = "update oddetailstbl set  lastpaiddate = '" & Format(_datLastTar, "yyyy-MM-dd") & "', intamount = intamount + '" & _intIntAmount & "',IntPostingStatus='1' ,InterestReceivable=InterestReceivable - '" & IntReceivable & "' where AccountNo = '" & _strAccountNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function
    Public Function fnUpDateAddIntWithIntPostStatusOne(ByVal strLoanNo As String) As Boolean

        strSQL = "update oddetailstbl set  lastpaiddate = '" & Format(_datLastTar, "yyyy-MM-dd") & "', intamount = intamount + '" & _intIntAmount & "',IntPostingStatus='1' where AccountNo = '" & _strAccountNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function
    Public Function fnUpdateInterest(ByVal strLoanNo As String, ByVal IntReceivable As Double) As Boolean

        strSQL = "update oddetailstbl set  lastpaiddate = '" & Format(_datLastTar, "yyyy-MM-dd") & "', intamount = '0',IntPostingStatus='1',InterestReceivable=InterestReceivable + '" & IntReceivable & "'  where AccountNo = '" & _strAccountNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetODTransaction(ByVal strLoanNo As String) As Boolean

        'strSQL = "Select * from odtransactiontbl where AccountNo = '" & strLoanNo & "'"
        strSQL = " Select Trdate,Deposit,Withdraw,PostBal,IntAmount,ChequeNo,IntTobePaid,IntPaid,VoucherNo,substring_index(Narration,':',-1) as Narration from odtransactiontbl  where AccountNo = '" & strLoanNo & "'"
        _dtODLDet = fnExecuteQuery(strSQL, 2)

        If _dtODLDet.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    'Public Function fnGetLoanFDDetails(ByVal FDNO As String) As Boolean

    '    strSQL = "SELECT P.*, M.* FROM fddetailstbl M, PersonTbl P WHERE P.PersonNo=M.PersonNo AND M.FDNo='" & FDNO & "'"

    '    _dtFDDetails = fnExecuteQuery(strSQL, 2)

    '    If _dtFDDetails.Rows.Count > 0 Then

    '        Return True

    '    Else

    '        Return False

    '    End If


    'End Function

    Public Function fnUpdateFDDetails(ByVal strFDNo As String) As Boolean

        strSQL = "Update fddetailstbl set LoanStatus = 'Open' where fdno = '" & strFDNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnUpdateFDClose(ByVal strfdno As String) As Boolean

        strSQL = "Update fddetailstbl set LoanStatus = 'Close' where FDno = '" & strfdno & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Function fnODtransactionEnter(ByVal strAccountNo As String, ByVal dtTransDate As Date, ByVal strNarration As String, ByVal dblDeposit As Double, ByVal dblWithdraw As Double, ByVal dblPostBal As Double, ByVal dblIntAmount As Double, ByVal dblintToboPaid As Double, ByVal dblIntPaid As Double, ByVal strRefNo As String, ByVal lngvoucherNo As Long, ByVal strType As String, ByVal strchequeNo As String) As Boolean
        strSQL = "Insert into odtransactiontbl(AccountNo,Trdate,Narration,Deposit,Withdraw,PostBal,IntAmount,IntTobePaid,IntPaid,Refno,VoucherNo,Type,ChequeNo)"
        strSQL = strSQL & " Values( '" & strAccountNo & "','" & Format(dtTransDate, "yyyy-MM-dd") & "','" & strNarration & "','" & dblDeposit & "','" & dblWithdraw & "','" & dblPostBal & "','" & dblIntAmount & "','" & dblintToboPaid & "','" & dblIntPaid & "','" & strRefNo & "','" & lngvoucherNo & "','" & strType & "','" & strchequeNo & "')"
        fnExecuteNonQuery(strSQL)
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

    Public Function fnDeleteSecuretyDetail(ByVal _strLoanNo As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Delete from securitydetailstbl where LoanNo = '" & _strLoanNo & "'"
        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function


    Public Function fnGetFDSecurityDetails(ByVal strLoanNo As String) As Boolean

        strSQL = "select S.* from securitydetailstbl S , oddetailstbl OD where S.LoanNo = OD.AccountNo and OD.AccountNo = '" & strLoanNo & "' and S.DepositType='FD'"

        _dtFDDetails = fnExecuteQuery(strSQL, 2)

        If _dtFDDetails.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetNSCSecurityDetails(ByVal strLoanNo As String) As Boolean

        strSQL = "select S.* from securitydetailstbl S , oddetailstbl OD where S.LoanNo = OD.AccountNo and OD.AccountNo = '" & strLoanNo & "' and S.DepositType='NSC'"

        _dtNSCDetails = fnExecuteQuery(strSQL, 2)

        If _dtNSCDetails.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


#End Region

#End Region

End Class
