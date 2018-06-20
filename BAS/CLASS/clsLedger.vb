Public Class clsLedger

#Region "Variables"
    Private _intLedgerNo As Integer
    Private _strName As String
    Private _intGroupNo As Integer
    Private _chrRestrictUser As Char
    Private _intOrderNo As Integer
    Private _strBalanceType As String

    Private _dtLedgerTable As DataTable

    Private _dtVoucherTable As DataTable
    Private _dtOpeningBalanceCash As DataTable
    Private _dtClosingBalanceCash As DataTable
    Private _dtClosingBalanceBank As DataTable
    Private _dtClosingBalanceBank1 As DataTable
    Private _dtOpeningBalanceBank As DataTable
    Private _dtOpeningBalanceBank1 As DataTable

#End Region

#Region "Properties"

    Public Property LedgerNo() As Integer
        Get
            Return _intLedgerNo
        End Get
        Set(ByVal Value As Integer)
            _intLedgerNo = Value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return _strName
        End Get
        Set(ByVal Value As String)
            _strName = Value
        End Set
    End Property

    Public Property GroupNo() As Integer
        Get
            Return _intGroupNo
        End Get
        Set(ByVal Value As Integer)
            _intGroupNo = Value
        End Set
    End Property
    Public Property OrderNo() As Integer
        Get
            Return _intOrderNo
        End Get
        Set(ByVal Value As Integer)
            _intOrderNo = Value
        End Set
    End Property

    Public Property RestrictUser() As Char
        Get
            Return _chrRestrictUser
        End Get
        Set(ByVal Value As Char)
            _chrRestrictUser = Value
        End Set
    End Property

    Public Property BalanceType() As String
        Get
            Return _strBalanceType
        End Get
        Set(ByVal Value As String)
            _strBalanceType = Value
        End Set
    End Property

    Public Property LedgerTable() As DataTable
        Get
            Return _dtLedgerTable
        End Get
        Set(ByVal Value As DataTable)
            _dtLedgerTable = Value
        End Set
    End Property

    Public Property VoucherTable() As DataTable
        Get
            Return _dtVoucherTable
        End Get
        Set(ByVal Value As DataTable)
            _dtVoucherTable = Value
        End Set
    End Property

    Public Property dtOpeningBalanceCash() As DataTable
        Get
            Return _dtOpeningBalanceCash
        End Get
        Set(ByVal Value As DataTable)
            _dtOpeningBalanceCash = Value
        End Set
    End Property
    Public Property dtOpeningBalanceBank() As DataTable
        Get
            Return _dtOpeningBalanceBank
        End Get
        Set(ByVal Value As DataTable)
            _dtOpeningBalanceBank = Value
        End Set
    End Property

    Public Property dtOpeningBalanceBank1() As DataTable
        Get
            Return _dtOpeningBalanceBank1
        End Get
        Set(ByVal Value As DataTable)
            _dtOpeningBalanceBank1 = Value
        End Set
    End Property

    Public Property dtClosingBalanceCash() As DataTable
        Get
            Return _dtClosingBalanceCash
        End Get
        Set(ByVal Value As DataTable)
            _dtClosingBalanceCash = Value
        End Set
    End Property


    Public Property dtClosingBalanceBank() As DataTable
        Get
            Return _dtClosingBalanceBank
        End Get
        Set(ByVal Value As DataTable)
            _dtClosingBalanceBank = Value
        End Set
    End Property

    Public Property dtClosingBalanceBank1() As DataTable
        Get
            Return _dtClosingBalanceBank1
        End Get
        Set(ByVal Value As DataTable)
            _dtClosingBalanceBank1 = Value
        End Set
    End Property
#End Region

#Region "Functions"

    Public Function fnAddLedger() As Boolean

        strSQL = "INSERT INTO FASLedgerTbl(LedgerNo, Name,OrderNo,GroupNo,BalanceType, RestrictUser)"
        strSQL &= "VALUES('" & _intLedgerNo & "','" & _strName & "','" & _intOrderNo & "','" & _intGroupNo & "','" & _strBalanceType & "','" & _chrRestrictUser & "')"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnUpdateLedger() As Boolean

        strSQL = "UPDATE FASLedgerTbl SET Name='" & _strName & "',OrderNo='" & _intOrderNo & "', GroupNo='" & _intGroupNo & "',BalanceType='" & _strBalanceType & "', RestrictUser='" & _chrRestrictUser & "' WHERE LedgerNo='" & _intLedgerNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetNewLedgerNo() As Integer

        strSQL = "SELECT max(LedgerNo) as MaxNo FROM FASLedgerTbl "

        _dtLedgerTable = fnExecuteQuery(strSQL, 2)

        If IsDBNull(_dtLedgerTable.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return _dtLedgerTable.Rows(0).Item("MaxNo") + 1
        End If

    End Function

    Public Function fnGetNewOrderNo() As Integer
        strSQL = "SELECT max(OrderNo) as MaxNo FROM FASLedgerTbl "

        _dtLedgerTable = fnExecuteQuery(strSQL, 2)

        If IsDBNull(_dtLedgerTable.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return _dtLedgerTable.Rows(0).Item("MaxNo") + 1
        End If
    End Function

    Public Function fnCheckLedger(ByVal LedgerNo As Integer) As Boolean

        strSQL = "SELECT * FROM FASLedgerTbl WHERE LedgerNo='" & LedgerNo & "'"

        _dtLedgerTable = fnExecuteQuery(strSQL, 2)

        If _dtLedgerTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    'to get list of transactions for a particular Ledger - to show ledger transactions
    Overloads Function fnGetTransactions(ByVal LedgerNo As Integer) As Boolean

        strSQL = "SELECT sub.VoucherNo, sub.VDate, main.RefNo, sub.AccountNo, sub.Narration, sub.Credit, sub.Debit FROM FASVoucherMainTbl main, FASVoucherSubTbl sub  WHERE sub.VoucherNo=main.VoucherNo and sub.VDate=main.VDate and sub.LedgerNo='" & LedgerNo & "' ORDER BY sub.Vdate DESC,sub.VoucherNo DESC,sub.VoucherNo DESC"
        _dtLedgerTable = fnExecuteQuery(strSQL, 2)

        If _dtLedgerTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Overloads Function fnGetTransactions(ByVal LedgerNo As Integer, ByVal StartDate As Date, ByVal EndDate As Date) As Boolean

        strSQL = "SELECT sub.VoucherNo, sub.VDate, main.RefNo, sub.AccountNo, sub.Narration, sub.Credit, sub.Debit  FROM FASVoucherMainTbl main, FASVoucherSubTbl sub WHERE sub.VoucherNo=main.VoucherNo and sub.VDate=main.VDate and sub.LedgerNo='" & LedgerNo & "'and main.Vdate BETWEEN '" & Format(StartDate, "yyyy-MM-dd") & "' and '" & Format(EndDate, "yyyy-MM-dd") & "' ORDER BY sub.Vdate DESC, sub.VoucherNo DESC"
        _dtLedgerTable = fnExecuteQuery(strSQL, 2)

        If _dtLedgerTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    
    'to get all ledger list - to show ledger list in ledger master
    Public Function fnGetLedgerList() As Boolean

        strSQL = "SELECT * FROM FASLedgerTbl ORDER BY Name"

        _dtLedgerTable = fnExecuteQuery(strSQL, 2)

        If _dtLedgerTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetBranchLedgerList() As Boolean

        strSQL = "SELECT * FROM FASLedgerTbl where GroupNo='11' or GroupNo='12' ORDER BY Name"

        _dtLedgerTable = fnExecuteQuery(strSQL, 2)

        If _dtLedgerTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetLedgerList123() As Boolean

        strSQL = "select G.Name,G.Nature,G.GroupNo,L.LedgerNo,L.Name as LName from fasgrouptbl G inner join fasledgertbl L on G.GroupNo=L.GroupNo "
        _dtLedgerTable = fnExecuteQuery(strSQL, 2)

        If _dtLedgerTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetLedgerListExcCash() As Boolean

        strSQL = "SELECT * FROM FASLedgerTbl where  LedgerNo <> '2' ORDER BY OrderNo ASC"

        _dtLedgerTable = fnExecuteQuery(strSQL, 2)

        If _dtLedgerTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

   

    End Function
    Public Function fnGetBankLedger() As Boolean
        strSQL = "SELECT l.LedgerNo,l.Name FROM FASLedgerTbl l inner join fasgrouptbl g on l.GroupNo = g.GroupNo where  g.GroupNo = '10' ORDER BY l.Name ASC"
        _dtLedgerTable = fnExecuteQuery(strSQL, 2)
        If _dtLedgerTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    

    Public Function fnGetCBalanceWRTLedger(ByVal LedgerNo As Integer) As Boolean

        strSQL = "SELECT ifnull(sum(Debit)- sum(Credit),0) AS Balance FROM(FASVoucherSubTbl) WHERE LedgerNo='" & LedgerNo & "'"
        _dtLedgerTable = fnExecuteQuery(strSQL, 2)

        If _dtLedgerTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetLedgerListExcept() As Boolean

        strSQL = "select * from fasledgertbl where  LedgerNo not in (2,3,4,5,6,7,8,9,10,11,12,21,22,23,"
        strSQL &= " 24,25,26,27,28,29,30,31,32,35,36,37,38,39,40,41,42,43,44,46,47,48,49,50,51,53,54,55,56,57,58) order by Name"

        _dtLedgerTable = fnExecuteQuery(strSQL, 2)

        If _dtLedgerTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetLedgers(ByVal GroupNo As Integer) As Boolean

        strSQL = "SELECT * FROM FASLedgerTbl WHERE GroupNo='" & GroupNo & "' ORDER BY Name ASC"

        _dtLedgerTable = fnExecuteQuery(strSQL, 2)

        If _dtLedgerTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetLedgers() As Boolean

        strSQL = "SELECT * FROM FASLedgerTbl WHERE GroupNo='" & _intGroupNo & "' ORDER BY Name ASC"

        _dtLedgerTable = fnExecuteQuery(strSQL, 2)

        If _dtLedgerTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetLedgerDetails(ByVal LedgerNo As Integer) As Boolean

        strSQL = "SELECT * FROM FASLedgerTbl WHERE LedgerNo='" & LedgerNo & "'"

        _dtLedgerTable = fnExecuteQuery(strSQL, 2)

        If _dtLedgerTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnUpdateLedgerBalances() As Boolean

        Dim dtROW As DataRow
        Dim intCounter As Integer = 0
        Dim strSQLCollection As New Collections.Specialized.StringCollection

        If fnGetLedgerList() Then
            For Each dtROW In _dtLedgerTable.Rows

                If dtROW("LedgerNo") <> 2 Then     'profit and loss account 

                    strSQL = "UPDATE FASLedgerTbl SET CurrentBalance = (SELECT ifnull(sum(Debit)- sum(Credit),0) FROM FASVoucherSubTbl WHERE LedgerNo='" & dtROW("LedgerNo") & "') WHERE LedgerNo='" & dtROW("LedgerNo") & "'"
                    strSQLCollection.Add(strSQL)

                    intCounter += 1

                End If
            Next
            fnExecuteNonQuery(strSQLCollection)
        End If

        Return True

    End Function

    Public Function fnUpdateLedgerBalances(ByVal StartDate As Date, ByVal EndDate As Date) As Boolean

        Dim dtROW As DataRow
        Dim intCounter As Integer = 0
        Dim strSQLCollection As New Collections.Specialized.StringCollection

        If fnGetLedgerList123() Then
            For Each dtROW In _dtLedgerTable.Rows

                If dtROW("LedgerNo") <> 2 Then     'profit and loss account 
                    'If dtROW("Nature") <> "I" And dtROW("Nature") <> "E" Then

                    '    strSQL = "UPDATE FASLedgerTbl SET CurrentBalance = 	(SELECT ifnull(sum(Debit)- sum(Credit),0) FROM(FASVoucherSubTbl) WHERE LedgerNo='" & dtROW("LedgerNo") & "' and Vdate BETWEEN '" & Format(StartDate, "yyyy-MM-dd") & "' and '" & Format(EndDate, "yyyy-MM-dd") & "') WHERE LedgerNo='" & dtROW("LedgerNo") & "'"
                    '    strSQLCollection.Add(strSQL)

                    '    intCounter += 1
                    'Else

                    strSQL = "UPDATE FASLedgerTbl SET CurrentBalance =(SELECT ifnull(sum(Debit)- sum(Credit),0) FROM(FASVoucherSubTbl) WHERE LedgerNo='" & dtROW("LedgerNo") & "' and VDate <='" & Format(EndDate, "yyyy-MM-dd") & "') WHERE LedgerNo='" & dtROW("LedgerNo") & "'"
                    strSQLCollection.Add(strSQL)

                    intCounter += 1
                    'End If
                End If
            Next
            fnExecuteNonQuery(strSQLCollection)
        End If

        Return True

    End Function

    Public Function fnUpdateInterestPayable(ByVal TillDate As Date) As Boolean

        strSQL = "UPDATE fasledgertbl SET CurrentBalance=(SELECT ifNull(SUM(C.intAmount),0) +"
        strSQL &= " (SELECT ifnull(SUM(NC.IntAmount) ,0)"
        strSQL &= " FROM fdintpaymentstbl NC,fddetailstbl FD"
        strSQL &= " WHERE FD.FDNo=NC.FDNo AND FD.Status='A' AND NC.intDate <='2009-10-22' AND  NC.Status='Due') +"
        strSQL &= " (SELECT ifnull(SUM(RDC.IntAmount) ,0)"
        strSQL &= " FROM rdcumulativeinttbl RDC,rddetailstbl RD"
        strSQL &= " WHERE RD.RDNo=RDC.RDNo AND RD.Status='A' AND RDC.intDate <='2009-10-22')+"
        strSQL &= "(SELECT ifnull(SUM(RDNC.IntAmount) ,0)"
        strSQL &= " FROM rdnoncumulativetbl RDNC,rddetailstbl RD"
        strSQL &= " WHERE RD.RDNo=RDNC.RDNo AND RD.Status='A' AND RDNC.intDate <='2009-10-22') AS TotalIntPayable"
        strSQL &= " FROM fdcumulativeinttbl C,fddetailstbl FD"
        strSQL &= " WHERE FD.FDNo=C.FDNo AND FD.Status='A' AND C.intDate <='2009-10-22' AND  C.Status='Due')WHERE LedgerNo='14'"
        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetIncomeExpenditure(ByVal StartDate As Date, ByVal EndDate As Date) As Boolean
        strSQL = "select (ifnull(sum(V.debit)-sum(V.credit),0)) as Income,"
        strSQL &= "(Select ifnull(sum(V.debit) - sum(V.credit),0)from fasgrouptbl G inner join fasledgertbl L"
        strSQL &= " on G.GroupNo=L.GroupNo inner join fasvouchersubtbl V on L.LedgerNo=V.LedgerNo  where G.Nature='E' and "
        ' strSQL &= "Vdate BETWEEN '" & Format(StartDate, "yyyy-MM-dd") & "' and '" & Format(EndDate, "yyyy-MM-dd") & "' "
        strSQL &= "Vdate <= '" & Format(EndDate, "yyyy-MM-dd") & "' "
        strSQL &= ")as Expenditure from fasgrouptbl G inner join fasledgertbl L on G.GroupNo=L.GroupNo inner join fasvouchersubtbl V "
        ' strSQL &= " on L.LedgerNo=V.LedgerNo where G.Nature='I' and Vdate BETWEEN '" & Format(StartDate, "yyyy-MM-dd") & "' and '" & Format(EndDate, "yyyy-MM-dd") & "'"
        strSQL &= " on L.LedgerNo=V.LedgerNo where G.Nature='I' and Vdate <= '" & Format(EndDate, "yyyy-MM-dd") & "'"
        _dtVoucherTable = fnExecuteQuery(strSQL, 2)
        If _dtVoucherTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    'Public Function fnGetPreviousIncomeExpenditure(ByVal StartDate As Date, ByVal EndDate As Date) As Boolean
    '    strSQL = "select ABS((ifnull(sum(V.debit)-sum(V.credit),0)))- "
    '    strSQL &= "(Select ABS(ifnull(sum(V.debit) - sum(V.credit),0)) from fasgrouptbl G inner join fasledgertbl L"
    '    strSQL &= " on G.GroupNo=L.GroupNo inner join fasvouchersubtbl V on L.LedgerNo=V.LedgerNo  where G.Nature='E' and "
    '    strSQL &= "Vdate BETWEEN '" & Format(StartDate, "yyyy-MM-dd") & "' and '" & Format(EndDate, "yyyy-MM-dd") & "' "
    '    strSQL &= ")as ProfitAndLoss from fasgrouptbl G inner join fasledgertbl L on G.GroupNo=L.GroupNo inner join fasvouchersubtbl V "
    '    strSQL &= " on L.LedgerNo=V.LedgerNo where G.Nature='I' and Vdate BETWEEN '" & Format(StartDate, "yyyy-MM-dd") & "' and '" & Format(EndDate, "yyyy-MM-dd") & "'"
    '    _dtVoucherTable = fnExecuteQuery(strSQL, 2)
    '    If _dtVoucherTable.Rows.Count > 0 Then
    '        Return True
    '    Else
    '        Return False
    '    End If

    'End Function

    Public Function fnGetPreviousIncomeExpenditure(ByVal StartDate As Date, ByVal EndDate As Date) As Boolean
        strSQL = "select ABS((ifnull(sum(V.debit)-sum(V.credit),0)))- "
        strSQL &= "(Select ABS(ifnull(sum(V.debit) - sum(V.credit),0)) from fasgrouptbl G inner join fasledgertbl L"
        strSQL &= " on G.GroupNo=L.GroupNo inner join fasvouchersubtbl V on L.LedgerNo=V.LedgerNo  where G.Nature='E' and "
        strSQL &= " Vdate BETWEEN '" & Format(StartDate, "yyyy-MM-dd") & "' and '" & Format(EndDate, "yyyy-MM-dd") & "'"
        strSQL &= ")as ProfitAndLoss from fasgrouptbl G inner join fasledgertbl L on G.GroupNo=L.GroupNo inner join fasvouchersubtbl V "
        strSQL &= " on L.LedgerNo=V.LedgerNo where G.Nature='I' and Vdate BETWEEN '" & Format(StartDate, "yyyy-MM-dd") & "' and '" & Format(EndDate, "yyyy-MM-dd") & "'"
        _dtVoucherTable = fnExecuteQuery(strSQL, 2)
        If _dtVoucherTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetPresent(ByVal StartDate As Date, ByVal EndDate As Date)

        strSQL = "SELECT ifnull(sum(Debit)- sum(Credit),0) as Balance FROM(FASVoucherSubTbl) WHERE LedgerNo='131' AND Vdate BETWEEN '" & Format(StartDate, "yyyy-MM-dd") & "' and '" & Format(EndDate, "yyyy-MM-dd") & "'"
        _dtLedgerTable = fnExecuteQuery(strSQL, 2)
        If _dtLedgerTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnInsertPandL(ByVal PandL As Double) As Boolean
        strSQL = "UPDATE FASLedgerTbl SET CurrentBalance = '" & PandL & "' where LedgerNo='2'"
        If fnExecuteNonQuery(strSQL) Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnUpdateReciptPayment(ByVal StartDate As Date, ByVal EndDate As Date) As Boolean
        Dim dtROW As DataRow
        Dim intCounter As Integer = 0
        Dim strSQLCollection As New Collections.Specialized.StringCollection
        If fnGetLedgerList() Then                                           '''''''Receipt........2............debit
            For Each dtROW In _dtLedgerTable.Rows                           '''''''Payment........1............credit    
                If dtROW("LedgerNo") <> 2 Then
                    strSQL = "UPDATE fasledgertbl SET Receipt=(select ifnull(sum(VS.Debit)- sum(VS.Credit),0)FROM FASVoucherSubTbl VS,fasvouchertypetbl VT WHERE VS.TypeNo=VT.TypeNo and VS.LedgerNo='" & dtROW("LedgerNo") & "'and VT.TypeNo='2' and Vdate BETWEEN '" & Format(StartDate, "yyyy-MM-dd") & "' and '" & Format(EndDate, "yyyy-MM-dd") & "'), "
                    strSQL = strSQL & "payment=(select ifnull(sum(VS.Debit)- sum(VS.Credit),0) FROM FASVoucherSubTbl VS,fasvouchertypetbl VT WHERE VS.TypeNo=VT.TypeNo and VS.LedgerNo='" & dtROW("LedgerNo") & "' and VT.TypeNo='1' and Vdate BETWEEN '" & Format(StartDate, "yyyy-MM-dd") & "' and '" & Format(EndDate, "yyyy-MM-dd") & "') where ledgerNo='" & dtROW("LedgerNo") & "'"
                    strSQLCollection.Add(strSQL)
                    intCounter += 1
                End If
            Next
            fnExecuteNonQuery(strSQLCollection)
        End If
        Return True
    End Function
    Public Function fnGetvoucherSub() As Boolean
        strSQL = "SELECT m.Amount,s.* FROM fasvouchermaintbl m,fasvouchersubtbl s where m.VoucherNo=s.VoucherNo and m.VDate=s.VDate"

        _dtVoucherTable = fnExecuteQuery(strSQL, 2)

        If _dtVoucherTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnUpdateOrder() As Boolean
        strSQL = "UPDATE fasledgertbl set "
        strSQL = strSQL & "OrderNo='" & OrderNo & "' where "
        strSQL = strSQL & "LedgerNo='" & LedgerNo & "'"
        Return fnExecuteNonQuery(strSQL)
    End Function

    Public Function fnGetLedgerGroupdetails(ByVal LedgerNo As Integer) As Boolean

        strSQL = "SELECT Grp.Nature,Led.* from FasGroupTbl Grp,FasLedgerTbl Led WHERE Grp.GroupNo=Led.GroupNo and Led.LedgerNo='" & LedgerNo & "'"
        _dtLedgerTable = fnExecuteQuery(strSQL, 2)
        If _dtLedgerTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnGetBranchBalance(ByVal LedgerNo As Integer, ByVal dtDate As Date)

        strSQL = "select sum(Credit) ,sum(Debit),sum(Debit)-sum(Credit)as Balance  from fasvouchersubtbl where LedgerNo='" & LedgerNo & "' and VDate <='" & Format(dtDate, "yyyy-MM-dd") & "'"
        _dtLedgerTable = fnExecuteQuery(strSQL, 2)
        If _dtLedgerTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetOpeningBalanceCash(ByVal FromDate As Date) As Boolean
        strSQL = "SELECT (ifnull(sum(debit)-sum(credit),0)) as 'Opening Balance' from fasvouchersubtbl where ledgerno in(1) and  vdate<'" & Format(FromDate, "yyyy-MM-dd") & "'"

        _dtOpeningBalanceCash = fnExecuteQuery(strSQL, 2)

        If _dtOpeningBalanceCash.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fnGetOpeningBalanceBank(ByVal FromDate As Date) As Boolean
        strSQL = "SELECT (ifnull(sum(debit)-sum(credit),0)) as 'Opening Balance' from fasvouchersubtbl where ledgerno in(177,178) and vdate<'" & Format(FromDate, "yyyy-MM-dd") & "'"

        _dtOpeningBalanceBank = fnExecuteQuery(strSQL, 2)

        If _dtOpeningBalanceBank.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnGetOpeningBalanceBank(ByVal FromDate As Date, ByVal ToDate As Date, ByVal LedgerNo As Integer) As Boolean
        'today taking of sum of debit
        'strSQL = "SELECT (ifnull(sum(debit),0)) as 'Opening Balance',(select name from fasledgertbl where ledgerno= '" & LedgerNo & "') as Name from fasvouchersubtbl where ledgerno = '" & LedgerNo & "' and vdate<'" & Format(FromDate, "yyyy-MM-dd") & "'"
        'strSQL = "SELECT (ifnull(sum(debit)-sum(credit),0)) as 'Opening Balance',(select name from fasledgertbl where ledgerno= '" & LedgerNo & "') as Name from fasvouchersubtbl where ledgerno = '" & LedgerNo & "' and vdate<'" & Format(FromDate, "yyyy-MM-dd") & "'"
        strSQL = "SELECT (ifnull(sum(debit),0)) as 'Opening Balance',(select name from fasledgertbl where ledgerno= '" & LedgerNo & "') as Name from fasvouchersubtbl where ledgerno = '" & LedgerNo & "' and vdate <='" & Format(ToDate, "yyyy-MM-dd") & "'  and vdate >= '" & Format(FromDate, "yyyy-MM-dd") & "'"
        'strSQL = "SELECT (ifnull(sum(debit)-sum(credit),0)) as 'Opening Balance',(select name from fasledgertbl where ledgerno= '" & LedgerNo & "') as Name from fasvouchersubtbl where ledgerno = '" & LedgerNo & "' and vdate <'" & Format(ToDate, "yyyy-MM-dd") & "'  and vdate > '" & Format(FromDate, "yyyy-MM-dd") & "'"

        _dtOpeningBalanceBank1 = fnExecuteQuery(strSQL, 2)

        If _dtOpeningBalanceBank1.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function



    Public Function fnGetClosingBalanceCash(ByVal ToDate As Date) As Boolean
        strSQL = "SELECT (ifnull(sum(debit)-sum(credit),0)) as 'Closing Balance' from fasvouchersubtbl where ledgerno in(1) and vdate<='" & Format(ToDate, "yyyy-MM-dd") & "'"

        _dtClosingBalanceCash = fnExecuteQuery(strSQL, 2)

        If _dtClosingBalanceCash.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fnGetClosingBalanceBank(ByVal ToDate As Date) As Boolean
        strSQL = "SELECT (ifnull(sum(debit)-sum(credit),0)) as 'Closing Balance' from fasvouchersubtbl where ledgerno in(177,178) and  vdate<='" & Format(ToDate, "yyyy-MM-dd") & "'"

        _dtClosingBalanceBank = fnExecuteQuery(strSQL, 2)

        If _dtClosingBalanceBank.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fnGetClosingBalanceBank(ByVal FromDate As Date, ByVal ToDate As Date, ByVal LedgerNo As Integer) As Boolean
        strSQL = "SELECT (ifnull(sum(debit)-sum(credit) - 0,0)) as 'Closing Balance',(select name from fasledgertbl where ledgerno= '" & LedgerNo & "') as Name from fasvouchersubtbl where ledgerno = '" & LedgerNo & "' and vdate<='" & Format(ToDate, "yyyy-MM-dd") & "'"

        _dtClosingBalanceBank1 = fnExecuteQuery(strSQL, 2)

        If _dtClosingBalanceBank1.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function





    Public Function fnUpdateOpeningAndClosingBalance(ByVal OpeningBalanceCash As Decimal, ByVal ClosingBalanceCash As Decimal, ByVal OpeningBalanceBank As Decimal, ByVal ClosingBalanceBank As Decimal) As Boolean
        strSQL = "Update rpOpenClosetbl set OpeningBalanceCash ='" & OpeningBalanceCash & "',OpeningBalanceBank='" & OpeningBalanceBank & "',ClosingBalanceCash='" & ClosingBalanceCash & "',ClosingBalanceBank='" & ClosingBalanceBank & "'"
        Return fnExecuteNonQuery(strSQL)
    End Function
#Region "FOR TYPE OF MEMBERS REPORT"

    Public Function fnUpdateMembers(ByVal EndDate As Date) As Boolean
        Dim dtROW As DataRow
        Dim intCounter As Integer = 0
        Dim strSQLCollection As New Collections.Specialized.StringCollection

        If fnGetMonthEnd1(EndDate) Then
            For Each dtROW In _dtLedgerTable.Rows
                strSQL = "UPDATE MembersmonthendTbl SET MEndMemberCount=('" & dtROW("MCloseMemberCount") & "'-'" & dtROW("MNewMemberCount") & "'+'" & dtROW("MBeginingCount") & " '),MEndAmt=('" & dtROW("MCloseMemberAmt") & "'-'" & dtROW("MNewMemberAmt") & "'+'" & dtROW("MBeginingAmt") & " ') where MTypeNo='" & dtROW("MTypeNo") & "' and  MEndDate='" & Format(EndDate, "yyyy-MM-dd") & "' "
                strSQLCollection.Add(strSQL)
                intCounter += 1
            Next
            fnExecuteNonQuery(strSQLCollection)
        End If
        Return True
    End Function
    Public Function fnGetMonthEnd1(ByVal EndDate As Date) As Boolean
        strSQL = "SELECT * FROM MembersmonthendTbl WHERE MEndDate='" & Format(EndDate, "yyyy-MM-dd") & "'"
        _dtLedgerTable = fnExecuteQuery(strSQL, 2)
        If _dtLedgerTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

#Region "FOR DEPOSITOR MONTHEND REPORT"

    Public Function fnInsertdeposits(ByVal StartDate As Date, ByVal EndDate As Date) As Boolean
        Dim dtROW As DataRow
        Dim intCounter As Integer = 0
        Dim strSQLCollection As New Collections.Specialized.StringCollection
        Dim NowDate As Date = Date.Now.Date
        If fnGetLedgers() Then
            For Each dtROW In _dtLedgerTable.Rows
                strSQL = "insert into depositsmonthendtbl(DepLEdgerNo,MBeginingAmt,AcceptedAmt,RepayedAmt,MEndDate) "

                strSQL = strSQL & " values('" & dtROW("LedgerNo") & "',"
                strSQL &= "(SELECT ifnull(sum(Debit)- sum(Credit),0)  FROM(FASVoucherSubTbl)"
                strSQL &= "	where Vdate  not between '" & Format(StartDate, "yyyy-MM-dd") & "' and '" & Format(EndDate, "yyyy-MM-dd") & "' and LedgerNo='" & dtROW("LedgerNo") & "'),"
                strSQL &= "(select ifnull(sum(Credit),0) from(fasvouchersubtbl)"
                strSQL &= "	where  Vdate between '" & Format(StartDate, "yyyy-MM-dd") & "' and '" & Format(EndDate, "yyyy-MM-dd") & "' and LedgerNo='" & dtROW("LedgerNo") & "' and  TypeNo='2'),"
                strSQL &= "(select ifnull(sum(Debit),0) from(fasvouchersubtbl)"
                strSQL &= " where  Vdate between '" & Format(StartDate, "yyyy-MM-dd") & "' and '" & Format(EndDate, "yyyy-MM-dd") & "' and LedgerNo='" & dtROW("LedgerNo") & "' and  TypeNo='1'),'" & Format(EndDate, "yyyy-MM-dd") & "')"

                strSQLCollection.Add(strSQL)
                intCounter += 1
            Next
            fnExecuteNonQuery(strSQLCollection)
        End If
        Return True
    End Function

    Public Function fnUpdateDeposits(ByVal EndDate As Date) As Boolean
        Dim dtROW As DataRow
        Dim intCounter As Integer = 0
        Dim strSQLCollection As New Collections.Specialized.StringCollection

        If fnGetMonthEnd(EndDate) Then
            For Each dtROW In _dtLedgerTable.Rows
                strSQL = "UPDATE DepositsmonthendTbl SET MEndingAmount=('" & dtROW("RepayedAmt") & "'-'" & dtROW("AcceptedAmt") & "'+'" & dtROW("MBeginingAmt") & " ') where DepLedgerNo='" & dtROW("DepLedgerNo") & "' and  MEndDate='" & Format(EndDate, "yyyy-MM-dd") & "' "
                strSQLCollection.Add(strSQL)
                intCounter += 1
            Next
            fnExecuteNonQuery(strSQLCollection)
        End If
        Return True
    End Function

    Public Function fnGetMonthEnd(ByVal EndDate As Date) As Boolean
        strSQL = "SELECT  D.*,L.Name FROM DepositsmonthendTbl D,FasledgerTbl L WHERE MEndDate='" & Format(EndDate, "yyyy-MM-dd") & "' and LedgerNo=DepLedgerNo"
        _dtLedgerTable = fnExecuteQuery(strSQL, 2)
        If _dtLedgerTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

#End Region

End Class
