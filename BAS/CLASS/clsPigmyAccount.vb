
Public Class clsPigmyAccount
    Inherits clsPerson

#Region "Variables"

    Private _strPGNo As String
    Private _strMemberNo As String
    'person Number Comes from clsperson
    Private _datAccDate As Date
    Private _dblAccBal As Double
    Private _dblMatAmount As Double
    Private _chrAccType As Char
    Private _chrOpMode As Char
    Private _strIntroSBNo As String
    Private _chrAccStatus As Char
    Private _strRemarks As String
    Private _chrPhotoID As Char
    Private _chrAddrID As Char
    Private _strReciptNo As String
    Private _intYY As Integer
    Private _intMM As Integer
    Private _intDD As Integer
    Private _datMaturityDate As Date
    Private _dblROI As Double
    Private _dblOtherCharge As Double
    Private _datIntPosting As DataTable

    Private _dtSBTransDetailTable As DataTable
    Private _dtPGdetailsTable As DataTable
    Private _dtChequedetailsTable As DataTable


    ' For Pigmy Transaction
    Private _strPGName As String
    Private _StrReference As String
    Private _intAmount As Integer
    Private _strAGNO As String
    Private _strNarration As String
    Private _datTranDate As Date
    Private _dblIntAmount As Double

    Private _dtCheckRef As DataTable
    Private _dtPigmy As DataTable
    Private _dtPigmyList As DataTable
    Private _dtPigmyBalance As DataTable

    'PigmyTransaction
    Private _dtDepPigmyTransaction As DataTable
    Private _dtWitPigmyTransaction As DataTable
    Private _dtGetMaxLastPaidDate As DataTable
    Private _dtPGADetails As DataTable
    Private _dtAgentDetails As DataTable
    'PigmyMasterPeriod
    Private _intPeriod As Integer
    Private _dtMinPeriod As DataTable
    Private _datClosingDate As Date
    Private _dtGetInterest As DataTable
    Private _dtGetClosingBalance As DataTable


#End Region

#Region "Properties"

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
            Return _strPGNo
        End Get
        Set(ByVal Value As String)
            _strPGNo = Value
        End Set
    End Property

    Public Property AccDate() As Date
        Get
            Return _datAccDate
        End Get
        Set(ByVal Value As Date)
            _datAccDate = Value
        End Set
    End Property

    Public Property AccCollectionBal() As Double
        Get
            Return _dblAccBal
        End Get
        Set(ByVal Value As Double)
            _dblAccBal = Value
        End Set
    End Property

    Public Property AccDepositBal() As Double
        Get
            Return _dblAccBal
        End Get
        Set(ByVal Value As Double)
            _dblAccBal = Value
        End Set
    End Property

    Public Property MatAmount() As Double
        Get
            Return _dblMatAmount
        End Get
        Set(ByVal Value As Double)
            _dblMatAmount = Value
        End Set
    End Property
    Public Property OtherCharge() As Double
        Get
            Return _dblOtherCharge
        End Get
        Set(ByVal Value As Double)
            _dblOtherCharge = Value
        End Set
    End Property

    Public Property AccType() As Char
        Get
            Return _chrAccType
        End Get
        Set(ByVal Value As Char)
            _chrAccType = Value
        End Set
    End Property

    Public Property OpMode() As Char
        Get
            Return _chrOpMode
        End Get
        Set(ByVal Value As Char)
            _chrOpMode = Value
        End Set
    End Property

    Public Property IntroSBNo() As String
        Get
            Return _strIntroSBNo
        End Get
        Set(ByVal Value As String)
            _strIntroSBNo = Value
        End Set
    End Property

    Public Property AccStatus() As Char
        Get
            Return _chrAccStatus
        End Get
        Set(ByVal Value As Char)
            _chrAccStatus = Value
        End Set
    End Property

    'Public Property Remarks() As String
    '    Get
    '        Return _strRemarks
    '    End Get
    '    Set(ByVal Value As String)
    '        _strRemarks = Value
    '    End Set
    'End Property

    Public Property PhotoID() As Char
        Get
            Return _chrPhotoID
        End Get
        Set(ByVal Value As Char)
            _chrPhotoID = Value
        End Set
    End Property

    Public Property AddrID() As Char
        Get
            Return _chrAddrID
        End Get
        Set(ByVal Value As Char)
            _chrAddrID = Value
        End Set
    End Property

    Public Property ReciptNo() As String
        Get
            Return _strReciptNo
        End Get
        Set(ByVal Value As String)
            _strReciptNo = Value
        End Set
    End Property

    Public Property PGAccTable() As DataTable
        Get
            Return _dtPGdetailsTable
        End Get
        Set(ByVal Value As DataTable)
            _dtPGdetailsTable = Value
        End Set
    End Property

    Public Property GetClosingBalance() As DataTable
        Get
            Return _dtGetClosingBalance
        End Get
        Set(ByVal Value As DataTable)
            _dtGetClosingBalance = Value
        End Set
    End Property
    Public Property SBTransDetailTable() As DataTable
        Get
            Return _dtSBTransDetailTable
        End Get
        Set(ByVal Value As DataTable)
            _dtSBTransDetailTable = Value
        End Set
    End Property

    Public Property DepositPeriod() As Integer
        Get
            Return _intPeriod
        End Get
        Set(ByVal Value As Integer)
            _intPeriod = Value
        End Set
    End Property


    Public Property ChequedetailsTable() As DataTable
        Get
            Return _dtChequedetailsTable
        End Get
        Set(ByVal Value As DataTable)
            _dtChequedetailsTable = Value
        End Set
    End Property

    '''''Property For Pigmy Transaction

    Public Property PGName() As String
        Get
            Return _strPGName
        End Get
        Set(ByVal Value As String)
            _strPGName = Value
        End Set
    End Property

    Public Property AgnetNo() As String
        Get
            Return _strAGNO
        End Get
        Set(ByVal Value As String)
            _strAGNO = Value
        End Set
    End Property

    Public Property PGNo() As String
        Get
            Return _strPGNo
        End Get
        Set(ByVal Value As String)
            _strPGNo = Value
        End Set
    End Property

    Public Property Amount() As String
        Get
            Return _intAmount
        End Get
        Set(ByVal Value As String)
            _intAmount = Value
        End Set
    End Property

    Public Property Narration() As String
        Get
            Return _strNarration
        End Get
        Set(ByVal Value As String)
            _strNarration = Value
        End Set
    End Property

    Public Property intAmount() As Double
        Get
            Return _dblIntAmount
        End Get
        Set(ByVal Value As Double)
            _dblIntAmount = Value
        End Set
    End Property
    Public Property Reference() As String
        Get
            Return _StrReference
        End Get
        Set(ByVal Value As String)
            _StrReference = Value
        End Set
    End Property

    Public Property TransDate() As Date
        Get
            Return _datTranDate
        End Get
        Set(ByVal Value As Date)
            _datTranDate = Value
        End Set
    End Property

    Public Property AgentId() As String
        Get
            Return _strAGNO
        End Get
        Set(ByVal Value As String)
            _strAGNO = Value
        End Set
    End Property

    Public Property CheckAgentTable() As DataTable
        Get
            Return _dtCheckRef
        End Get
        Set(ByVal Value As DataTable)
            _dtCheckRef = Value
        End Set
    End Property

    Public Property PigmyAccTable() As DataTable
        Get
            Return _dtPigmy
        End Get
        Set(ByVal Value As DataTable)
            _dtPigmy = Value
        End Set
    End Property

    Public Property PigmyListTable() As DataTable
        Get
            Return _dtPigmyList
        End Get
        Set(ByVal Value As DataTable)
            _dtPigmyList = Value
        End Set
    End Property

    Public Property PigmyDepTransTable() As DataTable
        Get
            Return _dtDepPigmyTransaction
        End Get
        Set(ByVal Value As DataTable)
            _dtDepPigmyTransaction = Value
        End Set
    End Property

    Public Property PigmyWithTransTable() As DataTable
        Get
            Return _dtWitPigmyTransaction
        End Get
        Set(ByVal Value As DataTable)
            _dtWitPigmyTransaction = Value
        End Set
    End Property

    Public Property MinPeriod() As Integer
        Get
            Return _intPeriod
        End Get
        Set(ByVal Value As Integer)
            _intPeriod = Value
        End Set
    End Property

    Public Property MinPeriodtable() As DataTable
        Get
            Return _dtMinPeriod
        End Get
        Set(ByVal Value As DataTable)
            _dtMinPeriod = Value
        End Set
    End Property

    Public Property PimgyBalancetable() As DataTable
        Get
            Return _dtPigmyBalance
        End Get
        Set(ByVal Value As DataTable)
            _dtPigmyBalance = Value
        End Set
    End Property

    Public Property PeriodYY() As Integer
        Get
            Return _intYY
        End Get
        Set(ByVal Value As Integer)
            _intYY = Value
        End Set
    End Property

    Public Property PeriodMM() As Integer
        Get
            Return _intMM
        End Get
        Set(ByVal Value As Integer)
            _intMM = Value
        End Set
    End Property

    Public Property PeriodDD() As Integer
        Get
            Return _intDD
        End Get
        Set(ByVal Value As Integer)
            _intDD = Value
        End Set
    End Property

    Public Property MaturityDate() As Date
        Get
            Return _datMaturityDate
        End Get
        Set(ByVal Value As Date)
            _datMaturityDate = Value
        End Set
    End Property

    Public Property ROI() As Double
        Get
            Return _dblROI
        End Get
        Set(ByVal Value As Double)
            _dblROI = Value
        End Set
    End Property

    Public Property datClosingDate() As Date
        Get
            Return _datClosingDate
        End Get
        Set(ByVal Value As Date)
            _datClosingDate = Value
        End Set
    End Property

    Public Property GetInteresetPost() As DataTable
        Get
            Return _dtGetInterest
        End Get
        Set(ByVal Value As DataTable)
            _dtGetInterest = Value
        End Set
    End Property

    Public Property GetMaxLastPaidTable() As DataTable
        Get
            Return _dtGetMaxLastPaidDate
        End Get
        Set(ByVal Value As DataTable)
            _dtGetMaxLastPaidDate = Value
        End Set
    End Property

#End Region

#Region "Functions"

    Public Function fnAddPGAccount(ByVal objTrans As IDbTransaction) As Boolean

        If fnCheckPerson() Then
            If fnUpdatePerson(objTrans) Then
                Return fnInsertPGAccount(objTrans)
            End If
        Else
            If fnAddPerson(objTrans) Then
                If fnInsertPGAccount(objTrans) Then
                    Return True
                Else
                    fnDeletePerson(objTrans)
                End If
            End If
        End If

        Return False

    End Function

    Private Function fnInsertPGAccount(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "INSERT INTO pigmyaccounttbl(PigmyAccNo,CustomerID,PigmyPersonNo,AccDate,AvailCollection,AvailDeposit,AccType,OpMode,AgentNo,AccStatus,Remarks,Photo_ID,Address_Id,ReceiptNo,ROI,Years,Months,Days,MaturityDate)"
        strSQL = strSQL & " VALUES('" & _strPGNo & "','" & _strMemberNo & "','" & PersonNo & "','" & Format(_datAccDate, "yyyy-MM-dd") & "',0.00,0.00,'" & _chrAccType & "','" & _chrOpMode & "','" & _strAGNO & "','" & _chrAccStatus & "','" & _strRemarks & "','" & _chrPhotoID & "','" & _chrAddrID & "','" & _strReciptNo & "','" & _dblROI & "','" & _intYY & "','" & _intMM & "','" & _intDD & "','" & Format(_datMaturityDate, "yyyy-MM-dd") & "')"
        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnCheckPGAccount(ByVal strPGNo As String) As Boolean

        strSQL = "SELECT * FROM pigmyaccounttbl WHERE PigmyAccNo='" & strPGNo & "'"

        _dtPGdetailsTable = fnExecuteQuery(strSQL, 2)

        strSQL = "SELECT TrDate,DDeposit,max(DPostBalance) as MonthEndBal FROM pigmytransactiontbl WHERE AccountNo='" & strPGNo & "' and DDeposit<>'0.00' group by trdate "

        _dtGetClosingBalance = fnExecuteQuery(strSQL, 2)

        If _dtPGdetailsTable.Rows.Count > 0 And _dtGetClosingBalance.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnGetPGAccountTable() As Boolean

        strSQL = "SELECT S.AccountNo,P.Name FROM sbDetailsTbl S, PersonTbl P WHERE S.PersonNo=P.PersonNo"

        _dtPGdetailsTable = fnExecuteQuery(strSQL, 2)

        If _dtPGdetailsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetPGAccountDetails(ByVal strPGNo As String) As Boolean

        strSQL = "SELECT P.*, S.* FROM pigmyaccounttbl S, PersonTbl P WHERE P.PersonNo=S.PigmyPersonNo AND S.PigmyAccNo='" & strPGNo & "'"

        _dtPGdetailsTable = fnExecuteQuery(strSQL, 2)

        If _dtPGdetailsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetPGAccountList() As Boolean

        strSQL = "SELECT P.*, S.* FROM pigmyaccounttbl S, PersonTbl P WHERE P.PersonNo=S.PigmyPersonNo and S.AccStatus <>'C'"

        _dtPGdetailsTable = fnExecuteQuery(strSQL, 2)

        If _dtPGdetailsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnUpdateSBAccount(ByVal objTrans As IDbTransaction) As Boolean

        If fnUpdatePerson(objTrans) Then

            strSQL = "UPDATE pigmyaccounttbl SET AccType='" & _chrAccType & "',opmode='" & _chrOpMode & "',Accstatus ='" & _chrAccStatus & "' , Remarks='" & _strRemarks & "',Photo_Id ='" & _chrPhotoID & "' ,Address_Id='" & _chrAddrID & "' WHERE PigmyAccNo='" & _strPGNo & "'"

            Return fnExecuteNonQuery(strSQL, objTrans)

        Else
            Return False
        End If
    End Function

    Function fnPGtransactionEnter(ByVal strAccountNo As String, ByVal dtTransDate As Date, ByVal strNarration As String, ByVal dblDeposit As Double, ByVal dblWithdraw As Double, ByVal dblPostBal As Double, ByVal strRefNo As String, ByVal lngvoucherNo As Long, ByVal strType As String, ByVal strchequeNo As String, ByVal strAgentName As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Insert into pigmytransactiontbl(AccountNo,Trdate,Narration,Deposit,Withdraw,PostBalance,DDeposit,DWithDraw,DPostBalance,Refno,VoucherNo,Type,Cheque,AgentID)"
        strSQL = strSQL & " select'" & strAccountNo & "','" & Format(dtTransDate, "yyyy-MM-dd") & "','" & strNarration & "','" & dblDeposit & "','" & dblWithdraw & "',ifnull(sum(Deposit)-sum(withdraw),0)+'" & dblDeposit & "',0.00,0.00,ifnull(sum(DDeposit)-sum(Dwithdraw),0),'" & strRefNo & "','" & lngvoucherNo & "','" & strType & "','" & strchequeNo & "','" & strAgentName & "'from pigmytransactiontbl where Accountno='" & strAccountNo & "' group by Accountno"

        fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Function frnPGCollectionWithdraw(ByVal strAccountNo As String, ByVal dtTransDate As Date, ByVal strNarration As String, ByVal dblDeposit As Double, ByVal dblWithdraw As Double, ByVal dblPostBal As Double, ByVal strRefNo As String, ByVal lngvoucherNo As Long, ByVal strType As String, ByVal strchequeNo As String, ByVal strAgentName As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Insert into pigmytransactiontbl(AccountNo,Trdate,Narration,Deposit,Withdraw,PostBalance,DDeposit,DWithDraw,DPostBalance,Refno,VoucherNo,Type,Cheque,AgentID)"
        strSQL = strSQL & " select'" & strAccountNo & "','" & Format(dtTransDate, "yyyy-MM-dd") & "','" & strNarration & "','" & dblDeposit & "','" & dblWithdraw & "',ifnull(sum(Deposit)-sum(withdraw),0)-'" & dblWithdraw & "','" & dblWithdraw & "',0.00,ifnull(sum(DDeposit)-sum(Dwithdraw),0)+'" & dblWithdraw & "','" & strRefNo & "','" & lngvoucherNo & "','" & strType & "','" & strchequeNo & "','" & strAgentName & "'from pigmytransactiontbl where Accountno='" & strAccountNo & "' group by Accountno"

        fnExecuteNonQuery(strSQL, objTrans)

    End Function


    Function frnPGDepositDeposit(ByVal strAccountNo As String, ByVal dtTransDate As Date, ByVal strNarration As String, ByVal dblDeposit As Double, ByVal dblWithdraw As Double, ByVal dblPostBal As Double, ByVal strRefNo As String, ByVal lngvoucherNo As Long, ByVal strType As String, ByVal strchequeNo As String, ByVal strAgentName As String) As Boolean

        strSQL = "Insert into pigmytransactiontbl(AccountNo,Trdate,Narration,Deposit,Withdraw,PostBalance,DDeposit,DWithDraw,DPostBalance,Refno,VoucherNo,Type,Cheque,AgentID)"
        strSQL = strSQL & " select'" & strAccountNo & "','" & Format(dtTransDate, "yyyy-MM-dd") & "','" & strNarration & "','" & dblDeposit & "','" & dblWithdraw & "',ifnull(sum(Deposit)-sum(withdraw),0)+'" & dblDeposit & "',0.00,0.00,ifnull(sum(DDeposit)-sum(Dwithdraw),0),'" & strRefNo & "','" & lngvoucherNo & "','" & strType & "','" & strchequeNo & "','" & strAgentName & "'from pigmytransactiontbl where Accountno='" & strAccountNo & "' group by Accountno"

        fnExecuteNonQuery(strSQL)

    End Function

    Function frnPGDepositWithdraw(ByVal strAccountNo As String, ByVal dtTransDate As Date, ByVal strNarration As String, ByVal dblDeposit As Double, ByVal dblWithdraw As Double, ByVal dblPostBal As Double, ByVal strRefNo As String, ByVal lngvoucherNo As Long, ByVal strType As String, ByVal strchequeNo As String, ByVal strAgentName As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Insert into pigmytransactiontbl(AccountNo,Trdate,Narration,Deposit,Withdraw,PostBalance,DDeposit,DWithDraw,DPostBalance,Refno,VoucherNo,Type,Cheque,AgentID)"
        strSQL = strSQL & " select'" & strAccountNo & "','" & Format(dtTransDate, "yyyy-MM-dd") & "','" & strNarration & "',0.00,0.00,ifnull(sum(Deposit)-sum(withdraw),0),0.00,'" & dblWithdraw & "',ifnull(sum(DDeposit)-sum(Dwithdraw),0)-'" & dblWithdraw & "','" & strRefNo & "','" & lngvoucherNo & "','" & strType & "','" & strchequeNo & "','" & strAgentName & "'from pigmytransactiontbl where Accountno='" & strAccountNo & "' group by Accountno"

        fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Function fnGetTransaction(ByVal strAccountNo As String)

        strSQL = "SELECT AccountNo,YEAR(Trdate)AS TYear , MONTH(TrDate) AS TMonth,SUM(deposit) AS Amount FROM pigmytransactiontbl WHERE AccountNo='" & strAccountNo & "' GROUP BY  YEAR(Trdate) , MONTH(TrDate)"
        _dtDepPigmyTransaction = fnExecuteQuery(strSQL, 2)
        If _dtDepPigmyTransaction.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnInsertData() As Boolean

        strSQL = "Insert into pigmytransactiontbl(AccountNo,TrDate,Narration,Deposit,WithDraw,RefNo,VoucherNo,Type,Cheque,AgentID)"
        strSQL = strSQL & "values('" & _strPGNo & "','" & Format(_datTranDate, "yyyy-MM-dd") & "','" & _strNarration & "','" & _intAmount & "',0.0,'" & _StrReference & "',"
        strSQL = strSQL & "0, 'Cash',0,'" & _strAGNO & "')"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnWithDrawlData(ByVal lngVoucherNo As Long, ByVal strNarration As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Insert into pigmytransactiontbl(AccountNo,TrDate,Narration,Deposit,WithDraw,PostBalance,RefNo,VoucherNo,Type,Cheque,AgentID)"
        strSQL = strSQL & "select'" & _strPGNo & "','" & Format(_datTranDate, "yyyy-MM-dd") & "','" & strNarration & "',0.0,'" & _intAmount & "',sum(Deposit)-sum(withdraw)-'" & _intAmount & "','" & _StrReference & "','" & lngVoucherNo & "', 'Cash',0,'" & _strAGNO & "' from pigmytransactiontbl where AccountNo='" & _strPGNo & "' group by AccountNo"
        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnCheckRefNo(ByVal strRefNo As String) As Boolean

        strSQL = "select * from pigmytransactiontbl where RefNo = '" & strRefNo & "'"

        _dtCheckRef = fnExecuteQuery(strSQL, 2)

        If _dtCheckRef.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetData(ByVal _strPigmyNo As String) As Boolean

        strSQL = "select * from pigmyaccounttbl where PigmyAccNo = '" & _strPigmyNo & "'"

        _dtPigmy = fnExecuteQuery(strSQL, 2)

        If _dtPigmy.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetPigmyAcc() As Boolean

        strSQL = "select * from persontbl p ,pigmyAccounttbl a where a.pigmypersonno = P.personno and a.AccStatus='A'"

        _dtPigmyList = fnExecuteQuery(strSQL, 2)

        If _dtPigmyList.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetDepTransDet(ByVal _strAccNo As String) As Boolean

        strSQL = "select P.Name, t.trdate, t.Deposit, t.WithDraw,t.Postbalance,t.DDeposit, t.DWithDraw,t.DPostbalance from PigmyTransactiontbl t, Persontbl p , pigmyAccounttbl a where t.AccountNo = a.pigmyAccNo and a.PigmyPersonNo = p.PersonNo and t.AccountNo = '" & _strAccNo & "'"

        _dtDepPigmyTransaction = fnExecuteQuery(strSQL, 2)

        If _dtDepPigmyTransaction.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetWitTransDet(ByVal _strAccNo As String) As Boolean

        strSQL = "select P.Name, t.trdate,t.WithDraw,t.Postbalance from PigmyTransactiontbl t, Persontbl p , pigmyAccounttbl a where t.AccountNo = a.pigmyAccNo and a.PigmyPersonNo = p.PersonNo and t.AccountNo = '" & _strAccNo & "'"

        _dtWitPigmyTransaction = fnExecuteQuery(strSQL, 2)

        If _dtWitPigmyTransaction.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnUpdatePeriod() As Boolean

        strSQL = "update pigmyperiodtbl set MinPeriod = '" & _intPeriod & "',BankCharges='" & _dblOtherCharge & "',ROI='" & _dblROI & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetMinPeriod() As Boolean

        strSQL = "select * from pigmyperiodtbl"

        _dtMinPeriod = fnExecuteQuery(strSQL, 2)

        If _dtMinPeriod.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnInsertMinPeriod() As Boolean

        strSQL = "INSERT INTO pigmyperiodtbl(SlNo,MinPeriod,BankCharges,ROI) VALUES('1','" & _intPeriod & "','" & _dblOtherCharge & "','" & _dblROI & "')"
        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetBalance(ByVal strAccNo As String) As Boolean

        strSQL = "Select * from pigmyaccounttbl where PigmyAccNo = '" & strAccNo & "'"

        _dtPigmyBalance = fnExecuteQuery(strSQL, 2)

        If _dtPigmyBalance.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnCloseAccount(ByVal strAccNo As String) As Boolean

        strSQL = "Update pigmyaccounttbl set AccStatus = 'C',ClosingDate = '" & Format(_datClosingDate, "yyyy-MM-dd") & "' where PigmyAccNo = '" & strAccNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetInterestDet(ByVal strAccNo As String) As Boolean

        strSQL = "select dt.Balance,dt.ROI,tr.trDate from pigmyaccounttbl dt, pigmytransactiontbl tr where dt.pigmyaccNo = tr.AccountNo and tr.trDate = ( select max(trdate) from pigmytransactiontbl where AccountNo = '" & strAccNo & "')"

        Return fnExecuteQuery(strSQL, 2)

        If _dtGetInterest.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetLastPaidDet(ByVal strAccNo As String) As Boolean

        strSQL = "select  withDraw,TrDate from pigmyTransactiontbl where TrDate = (select max(trDate) from PigmyTransactiontbl where AccountNo = '" & strAccNo & "')"

        _dtGetMaxLastPaidDate = fnExecuteQuery(strSQL, 2)

        If _dtGetMaxLastPaidDate.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnUpdateStatus(ByVal strAccNo As String, ByVal lngVoucherNo As Long, ByVal objTrans As IDbTransaction)

        strSQL = "update pigmyaccounttbl set AccStatus = 'C',ClosingDate = '" & Format(_datTranDate, "yyyy-MM-dd") & "',intPaid = '" & _dblIntAmount & "',intAmount = '" & _dblIntAmount & "',MatAmount = '" & _dblMatAmount & "',VoucherNo = '" & lngVoucherNo & "' where PigmyAccNo = '" & strAccNo & "'"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function
    Public Function fnGetNewPGANo() As String

        strSQL = "SELECT max(PigmyAccNo) as MaxNo FROM pigmyaccounttbl "

        _dtPGADetails = fnExecuteQuery(strSQL, 2)

        If IsDBNull(_dtPGADetails.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return _dtPGADetails.Rows(0).Item("MaxNo")
        End If

    End Function
    Public Function fnGetAgentNo() As String

        strSQL = "SELECT max(AgentID) as MaxNo FROM pigmyagenttbl "

        _dtAgentDetails = fnExecuteQuery(strSQL, 2)

        If IsDBNull(_dtAgentDetails.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return _dtAgentDetails.Rows(0).Item("MaxNo")
        End If

    End Function


    Public Function fnGetPigmyDayDetails() As Boolean
        strSQL = "select RDNo, Balance from pigmyaccounttbl"
        _datIntPosting = fnExecuteQuery(strSQL, 2)
        If _datIntPosting.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

End Class
