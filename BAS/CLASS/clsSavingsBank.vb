Public Class clsSavingsBank
    Inherits clsPerson

#Region "Variables"

    Private _strSBNo As String
    Private _strMemberNo As String
    Private _strCustomerID As String
    'person Number Comes from clsperson
    Private _datAccDate As Date
    Private _dblAccBal As Double
    Private _chrAccType As Char
    Private _chrOpMode As Char
    Private _strIntroSBNo As String
    Private _chrAccStatus As Char
    Private _strRemarks As String
    Private _chrPhotoID As Char
    Private _chrAddrID As Char
    Private _strReciptNo As String


    'Private _datOpenDate As Date
    'Private _strReceiptNo As String
    'Private _datClosingDate As Date
    'Private _chrIDCard As Char

    Private _dtSBTransDetailTable As DataTable
    Private _dtSBdetailsTable As DataTable
    Private _dtChequedetailsTable As DataTable
    Private _dtSBMasterTable As DataTable
    Private _datAccountDetails As DataTable

    'Cheque Book Details

    Private _strBookNo As String
    Private _lngStartNo As Long
    Private _lngEndNo As Long
    Private _datChkBookDate As Date
    Private _chrChkstatus As Char
    Private _dtSBCheckBookTable As DataTable


    'Cheque Deposit Details

    Private _strBankName As String
    Private _strBranchName As String
    Private _strChequeNo As String
    Private _datChequeDate As Date
    Private _datChequeDepositDate As Date
    Private _datChequeClearanceDate As Date
    Private _dblChequeAmount As Double
    Private _dblBankCharges As Double
    Private _strChequeStatus As String
    Private _StrChequeRefNo As String
    Private _dblClearedAmt As Double
    Private _strRemittedBankName As String
    Private _dtChqTranDet As DataTable

    'SB Closure
    Private _datIntDet As DataTable

    'Interest Calculation
    Private _dblIntAmt As Double
    Private _datFromPeriod As Date
    Private _datToPeriod As Date
    Private _ChrStatus As Char


    'SB Cheque Stop Pay

    Private _dtChqStopPayDt As DataTable

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
    Public Property AccountDetails() As DataTable
        Get
            Return _datAccountDetails
        End Get
        Set(ByVal Value As DataTable)
            _datAccountDetails = Value
        End Set
    End Property
    'Public Property CustomerID() As String
    '    Get
    '        Return _strCustomerID
    '    End Get
    '    Set(ByVal Value As String)
    '        _strCustomerID = Value
    '    End Set
    'End Property

    Public Property SBNo() As String
        Get
            Return _strSBNo
        End Get
        Set(ByVal Value As String)
            _strSBNo = Value
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

    Public Property AccBal() As Double
        Get
            Return _dblAccBal
        End Get
        Set(ByVal Value As Double)
            _dblAccBal = Value
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
    Public Property SBAccTable() As DataTable
        Get
            Return _dtSBdetailsTable
        End Get
        Set(ByVal Value As DataTable)
            _dtSBdetailsTable = Value
        End Set
    End Property

    Public Property SBMasterTable() As DataTable
        Get
            Return _dtSBMasterTable
        End Get
        Set(ByVal Value As DataTable)
            _dtSBMasterTable = Value
        End Set
    End Property

    'SbChequebook
    Public Property BookNo() As String
        Get
            Return _strBookNo
        End Get
        Set(ByVal Value As String)
            _strBookNo = Value
        End Set
    End Property

    Public Property ChkStartNo() As Long
        Get
            Return _lngStartNo
        End Get
        Set(ByVal Value As Long)
            _lngStartNo = Value
        End Set
    End Property

    Public Property ChkEndNo() As Long
        Get
            Return _lngEndNo
        End Get
        Set(ByVal Value As Long)
            _lngEndNo = Value
        End Set
    End Property

    Public Property ChkBookDate() As Date
        Get
            Return _datChkBookDate
        End Get
        Set(ByVal Value As Date)
            _datChkBookDate = Value
        End Set
    End Property

    Public Property ChkStatus() As Char
        Get
            Return _chrChkstatus
        End Get
        Set(ByVal Value As Char)
            _chrChkstatus = Value
        End Set
    End Property

    Public Property SBCheckBookBookTable() As DataTable
        Get
            Return _dtSBCheckBookTable
        End Get
        Set(ByVal Value As DataTable)
            _dtSBCheckBookTable = Value
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

    Public Property BankName() As String
        Get
            Return _strBankName
        End Get
        Set(ByVal Value As String)
            _strBankName = Value
        End Set
    End Property

    Public Property BranchName() As String
        Get
            Return _strBranchName
        End Get
        Set(ByVal Value As String)
            _strBranchName = Value
        End Set
    End Property

    Public Property ChequeNo() As String
        Get
            Return _strChequeNo
        End Get
        Set(ByVal Value As String)
            _strChequeNo = Value
        End Set
    End Property

    Public Property ChequeDate() As Date
        Get
            Return _datChequeDate
        End Get
        Set(ByVal Value As Date)
            _datChequeDate = Value
        End Set
    End Property
    Public Property ChequeAmount() As Double
        Get
            Return _dblChequeAmount
        End Get
        Set(ByVal Value As Double)
            _dblChequeAmount = Value
        End Set
    End Property

    Public Property ChequeDepositDate() As Date
        Get
            Return _datChequeDepositDate
        End Get
        Set(ByVal Value As Date)
            _datChequeDepositDate = Value
        End Set
    End Property

    Public Property chequeClearanceDate() As Date
        Get
            Return _datChequeClearanceDate
        End Get
        Set(ByVal Value As Date)
            _datChequeClearanceDate = Value
        End Set
    End Property

    Public Property BankCharges() As Double
        Get
            Return _dblBankCharges
        End Get
        Set(ByVal Value As Double)
            _dblBankCharges = Value
        End Set
    End Property

    Public Property ChequeStatus() As String
        Get
            Return _strChequeStatus
        End Get
        Set(ByVal Value As String)
            _strChequeStatus = Value
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

    Public Property ChequeRefNo() As String
        Get
            Return _StrChequeRefNo
        End Get
        Set(ByVal Value As String)
            _StrChequeRefNo = Value
        End Set
    End Property

    Public Property ChequeClearedAmt() As Double
        Get
            Return _dblClearedAmt
        End Get
        Set(ByVal Value As Double)
            _dblClearedAmt = Value
        End Set
    End Property

    'Public Property OpenDate() As Date
    '    Get
    '        Return _datOpenDate
    '    End Get
    '    Set(ByVal Value As Date)
    '        _datOpenDate = Value
    '    End Set
    'End Property

    'Public Property NoOfShares() As Integer
    '    Get
    '        Return _intNoOfShares
    '    End Get
    '    Set(ByVal Value As Integer)
    '        _intNoOfShares = Value
    '    End Set
    'End Property

    'Public Property ShareAmount() As Double
    '    Get
    '        Return _dblShareAmount
    '    End Get
    '    Set(ByVal Value As Double)
    '        _dblShareAmount = Value
    '    End Set
    'End Property

    'Public Property ReceiptNo() As String
    '    Get
    '        Return _strReceiptNo
    '    End Get
    '    Set(ByVal Value As String)
    '        _strReceiptNo = Value
    '    End Set
    'End Property

    'Public Property ClosingDate() As Date
    '    Get
    '        Return _datClosingDate
    '    End Get
    '    Set(ByVal Value As Date)
    '        _datClosingDate = Value
    '    End Set
    'End Property

    Public Property InterestDettable() As DataTable
        Get
            Return _datIntDet
        End Get
        Set(ByVal Value As DataTable)
            _datIntDet = Value
        End Set
    End Property

    Public Property IntAmt() As Double
        Get
            Return _dblIntAmt
        End Get
        Set(ByVal Value As Double)
            _dblIntAmt = Value
        End Set
    End Property

    Public Property FromPeriod() As Date
        Get
            Return _datFromPeriod
        End Get
        Set(ByVal Value As Date)
            _datFromPeriod = Value
        End Set
    End Property

    Public Property ToPeriod() As Date
        Get
            Return _datToPeriod
        End Get
        Set(ByVal Value As Date)
            _datToPeriod = Value
        End Set
    End Property

    Public Property Status() As Char
        Get
            Return _ChrStatus
        End Get
        Set(ByVal Value As Char)
            _ChrStatus = Value
        End Set
    End Property

    Public Property AmtRemittedBank() As String
        Get
            Return _strRemittedBankName
        End Get
        Set(ByVal Value As String)
            _strRemittedBankName = Value
        End Set
    End Property

    Public Property ChqTranDetTable() As DataTable
        Get
            Return _dtChqTranDet
        End Get
        Set(ByVal Value As DataTable)
            _dtChqTranDet = Value
        End Set
    End Property

    Public Property ChqStopDet() As DataTable
        Get
            Return _dtChqStopPayDt
        End Get
        Set(ByVal Value As DataTable)
            _dtChqStopPayDt = Value
        End Set
    End Property

#End Region

#Region "Functions"

    Public Function fnAddSBAccount(ByVal objTrans As IDbTransaction) As Boolean

        If fnCheckPerson() Then
            If fnUpdatePerson(objTrans) Then
                Return fnInsertSBAccount(objTrans)
            End If
        Else
            If fnAddPerson(objTrans) Then
                If fnInsertSBAccount(objTrans) Then
                    Return True
                Else
                    fnDeletePerson(objTrans)
                End If
            End If
        End If
        Return False
    End Function

    Private Function fnInsertSBAccount(ByVal objTrans As IDbTransaction) As Boolean
        strSQL = "INSERT INTO sbDetailsTbl(AccountNo,CustomerID,PersonNo,AccDate,AccType,OpMode,IntroNo,AccStatus,Remarks,Photo_Id,Address_Id,ReciptNo)"
        strSQL = strSQL & " VALUES('" & _strSBNo & "','" & _strCustomerID & "','" & PersonNo & "','" & Format(_datAccDate, "yyyy-MM-dd") & "','" & _chrAccType & "','" & _chrOpMode & "','" & _strIntroSBNo & "','" & _chrAccStatus & "','" & _strRemarks & "','" & _chrPhotoID & "','" & _chrAddrID & "','" & _strReciptNo & "')"
        Return fnExecuteNonQuery(strSQL, objTrans)
    End Function

    Public Function fnCheckSBAccount(ByVal strSBNo As String) As Boolean
        strSQL = "SELECT * FROM sbdetailstbl WHERE AccountNo='" & strSBNo & "'"

        _dtSBdetailsTable = fnExecuteQuery(strSQL, 2)

        If _dtSBdetailsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnGetSBAccountTable() As Boolean
        strSQL = "SELECT S.AccountNo,P.Name FROM sbDetailsTbl S, PersonTbl P WHERE S.PersonNo=P.PersonNo and S.AccStatus = 'A'"

        _dtSBdetailsTable = fnExecuteQuery(strSQL, 2)

        If _dtSBdetailsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnGetSBAccountDetails(ByVal strSBNo As String) As Boolean
        strSQL = "SELECT P.*, S.* FROM sbdetailstbl S, PersonTbl P WHERE P.PersonNo=S.PersonNo AND S.AccountNo='" & strSBNo & "'"

        _dtSBdetailsTable = fnExecuteQuery(strSQL, 2)

        If _dtSBdetailsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnGetSBAccountList() As Boolean
        strSQL = "SELECT P.*, S.* FROM sbdetailstbl S, PersonTbl P WHERE P.PersonNo=S.PersonNo"
        _dtSBdetailsTable = fnExecuteQuery(strSQL, 2)
        If _dtSBdetailsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnCloseSBAccount(ByVal datCloseDate As Date, ByVal strAccNo As String) As Boolean
        strSQL = "update sbdetailstbl set ClosingDate = '" & Format(datCloseDate, "yyyy-MM-dd") & "', AccStatus = 'C' where AccountNo = '" & strAccNo & "'"
        Return fnExecuteNonQuery(strSQL)
    End Function

    Public Function fnUpdateSBAccount(ByVal objTrans As IDbTransaction) As Boolean
        If fnUpdatePerson(objTrans) Then
            strSQL = "UPDATE SbdetailsTbl SET CustomerID='" & _strCustomerID & "',AccType='" & _chrAccType & "',opmode='" & _chrOpMode & "',Accstatus ='" & _chrAccStatus & "' , Remarks='" & _strRemarks & "',Photo_Id ='" & _chrPhotoID & "' ,Address_Id='" & _chrAddrID & "',ReciptNo='" & _strReciptNo & "'  WHERE AccountNo='" & _strSBNo & "'"
            Return fnExecuteNonQuery(strSQL, objTrans)
        Else
            Return False
        End If
    End Function

    Public Function fnSBInsertCheckBookDetails(ByVal objTrans As IDbTransaction) As Boolean
        Dim intCounter As Integer = _lngStartNo
        strSQL = "INSERT INTO sbchequebookmastertbl(AccountNo,Book_SNo,IssuedDate,ReciptNo,StartNo,EndNo,Status)"
        strSQL = strSQL & " VALUES('" & _strSBNo & "','" & _strBookNo & "','" & Format(_datChkBookDate, "yyyy-MM-dd") & "','" & _strReciptNo & "','" & _lngStartNo & "','" & _lngEndNo & "','P')"
        fnExecuteNonQuery(strSQL, objTrans)
        Return True
    End Function

    Public Function fnGetSBCheckBookDetails() As Boolean

        strSQL = "SELECT AccountNo,Book_SNo,IssuedDate,ReciptNo,StartNo,EndNo,Status FROM sbchequebookmastertbl WHERE AccountNo='" & _strSBNo & "'ORDER BY IssuedDate DESC  "
        _dtSBCheckBookTable = fnExecuteQuery(strSQL, 2)
        If _dtSBCheckBookTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnChequeleafInsertion() As Boolean
        strSQL = " INSERT INTO sbchequeleaftbl(Book_SNo,chequeNo,Amount,Status,Remarks,Charges)"
        strSQL = strSQL & "VALUE('" & _strBookNo & " ','" & _strChequeNo & "','" & _dblChequeAmount & "','" & _strChequeStatus & "','" & _strRemarks & "','" & _dblBankCharges & "')"
        fnExecuteNonQuery(strSQL)
        Return True
    End Function

    Public Function fnCheckChequeLeafNo(ByVal lngChequeNo As Long) As Boolean
        strSQL = "select * from sbchequeleaftbl where ChequeNo ='" & lngChequeNo & "'"

        _dtSBCheckBookTable = fnExecuteQuery(strSQL, 2)
        If _dtSBCheckBookTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnGetChecks(ByVal lngChequeNo As Long) As Boolean
        strSQL = "SELECT P.Name,P.PersonNo,c.* FROM sbchequebookmastertbl C INNER JOIN sbdetailstbl SB ON SB.AccountNo=C.AccountNo INNER JOIN Persontbl P ON P.PersonNo=SB.PersonNo where '" & lngChequeNo & "' >=C.StartNo and '" & lngChequeNo & "' <=C.EndNo "
        _dtSBCheckBookTable = fnExecuteQuery(strSQL, 2)
        If _dtSBCheckBookTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fnGetCheckDet(ByVal lngChequeNo As Long, ByVal AccountNo As String) As Boolean
        strSQL = "select * from sbchequebookmastertbl where " & lngChequeNo & " >=StartNo and " & lngChequeNo & " <=EndNo AND AccountNo='" & AccountNo & "'"
        _dtSBCheckBookTable = fnExecuteQuery(strSQL, 2)
        If _dtSBCheckBookTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    '...........
    'Included new function to get balence detail from cheque number

    'Public Function fnGetBalence(ByVal lngChequeNo As Long) As Boolean

    '    strSQL = "SELECT S.Balance,S.AccountNo  from  sbDetailsTbl S,sbchequebookmasterTbl C where " & lngChequeNo & " >=C.StartNo and " & lngChequeNo & " <=C.EndNo and C.AccountNo=S.AccountNo"
    '    _dtSBCheckBookTable = fnExecuteQuery(strSQL, 2)
    '    If _dtSBCheckBookTable.Rows.Count > 0 Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function
    Function fnSBCheckChequeBook(ByVal strbookNo As String) As Boolean
        Dim dtTable As New DataTable
        strSQL = "select Book_SNo from sbchequebookmastertbl where Book_SNo='" & strbookNo & "'"
        dtTable = fnExecuteQuery(strSQL, 2)
        If dtTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Overloads Function fnSbtransactionEnter(ByVal strAccountNo As String, ByVal dtTransDate As Date, ByVal strNarration As String, ByVal dblDeposit As Double, ByVal dblWithdraw As Double, ByVal dblBookDeposit As Double, ByVal dblBookWithdraw As Double, ByVal dblPostBal As Double, ByVal strRefNo As String, ByVal lngvoucherNo As Long, ByVal strType As String, ByVal strchequeNo As String, ByVal objTrans As IDbTransaction) As Boolean
        strSQL = "Insert into sbTransactionTbl(AccountNo,Trdate,Narration,Deposit,Withdraw,BookDeposit,BookWithdraw,PostBal,Refno,VoucherNo,Type,ChequeNo)"
        strSQL = strSQL & " Values( '" & strAccountNo & "','" & Format(dtTransDate, "yyyy-MM-dd") & "','" & strNarration & "','" & dblDeposit & "','" & dblWithdraw & "','" & dblBookDeposit & "','" & dblBookWithdraw & "','" & dblPostBal & "','" & strRefNo & "','" & lngvoucherNo & "','" & strType & "','" & strchequeNo & "')"
        fnExecuteNonQuery(strSQL, objTrans)
    End Function
    Overloads Function fnSbtransactionEnter(ByVal strAccountNo As String, ByVal dtTransDate As Date, ByVal strNarration As String, ByVal dblDeposit As Double, ByVal dblWithdraw As Double, ByVal dblBookDeposit As Double, ByVal dblBookWithdraw As Double, ByVal dblPostBal As Double, ByVal strRefNo As String, ByVal lngvoucherNo As Long, ByVal strType As String, ByVal strchequeNo As String) As Boolean
        strSQL = "Insert into sbTransactionTbl(AccountNo,Trdate,Narration,Deposit,Withdraw,BookDeposit,BookWithdraw,PostBal,Refno,VoucherNo,Type,ChequeNo)"
        strSQL = strSQL & " Values( '" & strAccountNo & "','" & Format(dtTransDate, "yyyy-MM-dd") & "','" & strNarration & "','" & dblDeposit & "','" & dblWithdraw & "','" & dblBookDeposit & "','" & dblBookWithdraw & "','" & dblPostBal & "','" & strRefNo & "','" & lngvoucherNo & "','" & strType & "','" & strchequeNo & "')"
        fnExecuteNonQuery(strSQL)
    End Function
    Function fnGetTransactionDetails(ByVal datFrom As Date, ByVal datTo As Date) As Boolean
        strSQL = "select * from sbtransactiontbl where Accountno='" & _strSBNo & "' and Trdate Between '" & Format(datFrom, "yyyy-MM-dd") & "' and '" & Format(datTo, "yyyy-MM-dd") & "'"
        _dtSBTransDetailTable = fnExecuteQuery(strSQL, 2)
        Return True
    End Function
    Function fnGetTransactionDetailsForPassBook(ByVal strAccountNo As String, ByVal LastPrDt As DateTime) As DataTable
        Dim DateNow As DateTime
        Dim hour As Integer = System.DateTime.Now.Hour
        Dim min As Integer = System.DateTime.Now.Minute
        Dim sec As Integer = System.DateTime.Now.Second
        Dim year As Integer = System.DateTime.Now.Year
        Dim month As Integer = System.DateTime.Now.Month
        Dim day As Integer = System.DateTime.Now.Day
        DateNow = System.DateTime.Now.ToString("yyyy-MM-dd")
        Dim DateTimeNow As String = year & "-" & month & "-" & day & " " & hour & ":" & min & ":" & sec
        DateNow = Convert.ToDateTime(DateTimeNow)
        strSQL = "select * from passbooksbtransactions where Accountno='" & strAccountNo & "' and Trdate Between '" & Format(LastPrDt, "yyyy-MM-dd hh:mm:ss") & "' and '" & DateTimeNow & "' and PrintStatus is null "
        _dtSBTransDetailTable = fnExecuteQuery(strSQL, 2)
        Return _dtSBTransDetailTable
    End Function
    Function fnInsertNullToLastPrintDate(ByVal strAccountNo As String, ByVal LastPrDt As Date, ByVal SlNoOld As Integer) As Boolean
        Dim LstPrDt As String = "0000-00-00"
        Dim hour As String = LastPrDt.Hour
        Dim min As String = LastPrDt.Minute
        Dim sec As String = LastPrDt.Second
        Dim year As String = LastPrDt.Year
        Dim month As Integer = LastPrDt.Month
        Dim day As Integer = LastPrDt.Day
        Dim DateTimeNow As String = year & "-" & month & "-" & day & " " & hour & ":" & min & ":" & sec
        strSQL = "update passbooksbtransactions set LastPrintDate='" & LstPrDt & "',PassBookLineNo='0' where Accountno='" & strAccountNo & "' and LastPrintDate='" & DateTimeNow & "' and SlNo='" & SlNoOld & "' "
        fnExecuteNonQuery(strSQL)
        'fnExecuteQuery(strSQL, 2)
        Return True
    End Function
    Function fnUpdateStatusToOne(ByVal slNo As Integer) As Boolean
        strSQL = "update passbooksbtransactions set PrintStatus='1' where SlNo='" & slNo & "' "
        fnExecuteNonQuery(strSQL)
        Return True
    End Function
    Function fnGetLastPrintDate(ByVal strAccountNo As String) As DataTable
        strSQL = "select LastPrintDate,PassBookLineNo,SlNo from passbooksbtransactions where Accountno='" & strAccountNo & "' and LastPrintDate != '0'"
        _dtSBTransDetailTable = fnExecuteQuery(strSQL, 2)
        Return _dtSBTransDetailTable
    End Function
    '..........................
    'chainges made from fnAddDepositedCheque to fnAddDepositedChequeClear for updating cheque clearence

    Function fnAddDepositedChequeClear() As Boolean
        strSQL = "Insert into sbChequeDeposittbl(AccountNo,BankName,BranchName,Chequedate,ChequeNo,Depositdate,ChequeAmount,ClearanceDate,BankCharges,ChequeStatus,Remarks)"
        strSQL = strSQL & " Values( '" & _strSBNo & "','" & _strBankName & "','" & _strBranchName & "','" & Format(_datChequeDate, "yyyy-MM-dd") & "','" & _strChequeNo & "','" & Format(_datChequeDepositDate, "yyyy-MM-dd") & "','" & _dblChequeAmount & "','" & Format(_datChequeDepositDate, "yyyy-MM-dd") & "','" & _dblBankCharges & "','" & _strChequeStatus & "','" & _strRemarks & "')"
        If fnExecuteNonQuery(strSQL) Then
            Return True
        Else
            Return False
        End If
    End Function
    Function fnUpdateSBTransactionTbl(ByVal sbLastPrintDate As DateTime, ByVal sbAccountNo As String, ByVal slNo As Integer) As Boolean
        strSQL = "update passbooksbtransactions set LastPrintDate='" & sbLastPrintDate & "',PassBookLineNo='1' where TrDate='" & sbLastPrintDate & "' and AccountNo='" & sbAccountNo & "' and SlNo='" & slNo & "'"
        If fnExecuteNonQuery(strSQL) Then
            Return True
        Else
            Return False
        End If
    End Function
    Function fnUpdateSBTransactionTbl(ByVal sbLastPrintDate As DateTime, ByVal sbPassBookNo As Integer, ByVal sbAccountNo As String, ByVal slNo As Integer) As Boolean
        Dim hour As String = sbLastPrintDate.Hour
        Dim min As String = sbLastPrintDate.Minute
        Dim sec As String = sbLastPrintDate.Second
        Dim year As String = sbLastPrintDate.Year
        Dim month As Integer = sbLastPrintDate.Month
        Dim day As Integer = sbLastPrintDate.Day
        Dim DateTimeNow As String = year & "-" & month & "-" & day & " " & hour & ":" & min & ":" & sec
        strSQL = "update passbooksbtransactions set LastPrintDate='" & DateTimeNow & "',PassBookLineNo='" & sbPassBookNo & "' where TrDate='" & DateTimeNow & "' and AccountNo='" & sbAccountNo & "'and SlNo='" & slNo & "'"
        If fnExecuteNonQuery(strSQL) Then
            Return True
        Else
            Return False
        End If
    End Function
    Function fnAddDepositedCheque(ByVal objTrans As IDbTransaction) As Boolean
        strSQL = "Insert into sbChequeDeposittbl(AccountNo,BankName,BranchName,Chequedate,ChequeNo,Depositdate,ChequeAmount,BankCharges,ChequeStatus,Narration)"
        strSQL = strSQL & " Values( '" & _strSBNo & "','" & _strBankName & "','" & _strBranchName & "','" & Format(_datChequeDate, "yyyy-MM-dd") & "','" & _strChequeNo & "','" & Format(_datChequeDepositDate, "yyyy-MM-dd") & "','" & _dblChequeAmount & "','" & _dblBankCharges & "','" & _strChequeStatus & "','" & _strRemarks & "')"
        If fnExecuteNonQuery(strSQL, objTrans) Then
            Return True
        Else
            Return False
        End If
    End Function
    Function fnAddClearingCheque() As Boolean
        strSQL = "Insert into sbChequeDeposittbl(AccountNo,BankName,BranchName,Chequedate,ChequeNo,Depositdate,ChequeAmount,ClearanceDate,BankCharges,ChequeStatus,VoucherNo,Narration)"
        strSQL = strSQL & " Values( '" & _strSBNo & "','" & _strBankName & "','" & _strBranchName & "','" & Format(_datChequeDate, "yyyy-MM-dd") & "','" & _strChequeNo & "','" & Format(_datChequeDate, "yyyy-MM-dd") & "','" & Format(_datChequeDepositDate, "yyyy-MM-dd") & "','" & _dblChequeAmount & "','" & Format(_datChequeDate, "yyyy-MM-dd") & "','" & _dblBankCharges & "','" & _strChequeStatus & "','" & 1 & "','" & _strRemarks & "')"
        If fnExecuteNonQuery(strSQL) Then
            Return True
        Else
            Return False
        End If
    End Function


    Overloads Function fnGetDepositedCheque() As Boolean

        strSQL = "select * from sbChequeDeposittbl order by slNo desc"

        _dtChequedetailsTable = fnExecuteQuery(strSQL, 2)

        If _dtChequedetailsTable.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function
    Overloads Function fnGetDepositedCheque(ByVal ChequeNo As Integer) As Boolean
        strSQL = "SELECT * from sbChequeDeposittbl where ChequeNo='" & ChequeNo & "'"
        _dtChequedetailsTable = fnExecuteQuery(strSQL, 2)

        If _dtChequedetailsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Overloads Function fnGetDepositedCheque(ByVal ChequeNo As Integer, ByVal SBnum As String) As Boolean
        strSQL = "SELECT * from sbChequeDeposittbl where ChequeNo='" & ChequeNo & "'"
        _dtChequedetailsTable = fnExecuteQuery(strSQL, 2)

        If _dtChequedetailsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Function fnGetMaxSBChequeNo() As Long

        strSQL = "Select SBStartingChequeNo from mastersettingstbl"

        Return IIf(IsDBNull(fnExecuteQuery(strSQL, 2).Rows(0).Item(0)) = True, 0, fnExecuteQuery(strSQL, 2).Rows(0).Item(0))

    End Function

    Function fnGetAmountPerCheque() As Long
        strSQL = "Select SBAmountPerCheque from mastersettingstbl"

        Return IIf(IsDBNull(fnExecuteQuery(strSQL, 2).Rows(0).Item(0)) = True, 0, fnExecuteQuery(strSQL, 2).Rows(0).Item(0))

    End Function

    Function fnGetMasterSetting() As Boolean
        strSQL = "SELECT * FROM mastersettingstbl"
        _dtSBMasterTable = fnExecuteQuery(strSQL, 2)
        If _dtSBMasterTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Function fnChkBookstatus(ByVal strAccNo As String) As Boolean

        strSQL = "select * from sbChequebookmastertbl where AccountNo='" & strAccNo & "' and chkStatus='P'"
        fnChkBookstatus = IIf(fnExecuteQuery(strSQL, 2).Rows.count > 0 = True, True, False)

    End Function

    Function fnUpdateCheckStatusUpdate(ByVal strChequeNo As String) As Boolean

        strSQL = "Update sbChequebookmastrtbl set chkStatus ='C' where ChequeNo='" & strChequeNo & "'"

        fnExecuteNonQuery(strSQL)
    End Function

    Function fnChkBookstatusUpdate(ByVal strAccNo As String) As Boolean

        strSQL = "Update sbChequebookmastertbl Set chkStatus='C' where AccountNo='" & strAccNo & "'"

        fnExecuteNonQuery(strSQL)

        Return True

    End Function

    Public Function fnGetSBDetTable(ByVal strAccNo As String) As Boolean

        strSQL = "SELECT * FROM sbDetailstbl s, Persontbl t where S.PersonNo = t.PersonNo and S.AccountNo = '" & strAccNo & "'"

        _dtSBdetailsTable = fnExecuteQuery(strSQL, 2)

        If _dtSBdetailsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnUpdateStatus(ByVal lngVouncherNo As Long, ByVal strNarration As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "update sbchequedeposittbl set ChequeStatus = '" & _strChequeStatus & "',ClearanceDate = '" & Format(_datChequeClearanceDate, "yyyy-MM-dd") & "',VoucherNo = '" & lngVouncherNo & "',Narration = '" & strNarration & "'  where ChequeNo = '" & _strChequeNo & "' and AccountNo = '" & _strSBNo & "'"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnChequeBounceStatus(ByVal lngVouncherNo As Long, ByVal strNarration As String) As Boolean

        strSQL = "update sbchequedeposittbl set ChequeStatus = 'Bounce',ClearanceDate = '" & Format(_datChequeClearanceDate, "yyyy-MM-dd") & "',Remarks = '" & _strRemarks & "',VoucherNo = '" & lngVouncherNo & "',ClearedAmount = '" & _dblClearedAmt & "',Narration = '" & strNarration & "',RemmittedBankCharges = '" & _dblBankCharges & "',RemmittedBankName = '" & _strRemittedBankName & "' where ChequeNo = '" & _strChequeNo & "' and AccountNo = '" & _strSBNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetCheqTranDet(ByVal strAccNo As String) As Boolean

        strSQL = "select Tr.*,Sb.* from sbtransactiontbl Tr,sbchequedeposittbl Sb where Tr.AccountNo = Sb.AccountNo and sb.AccountNo = '" & strAccNo & "' and Type = 'Cheque'"

        _dtChqTranDet = fnExecuteQuery(strSQL, 2)

        If _dtChqTranDet.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetChqDateTran(ByVal datFrom As Date, ByVal datTo As Date, ByVal strAccNo As String) As Boolean

        strSQL = "select Tr.*,Sb.* from sbtransactiontbl Tr,sbchequedeposittbl Sb where Tr.AccountNo = Sb.AccountNo and sb.AccountNo = '" & strAccNo & "' and Type = 'Cheque' and  Trdate between '" & Format(datFrom, "yyyy-MM-dd") & "' and '" & Format(datTo, "yyyy-MM-dd") & "'"

        _dtChqTranDet = fnExecuteQuery(strSQL, 2)


    End Function

    Public Function fnSbChqStopPayDet() As Boolean

        strSQL = "SELECT distinct sbChqLeaf.*,sbCheqDep.* from sbChequeleaftbl sbchqLeaf, sbChequeDeposittbl sbCheqDep,sbtransactiontbl SbTran where sbChqLeaf.ChequeNo = sbCheqDep.ChequeNo and sbChqLeaf.Status = 'Stopped'"
        _dtChqStopPayDt = fnExecuteQuery(strSQL, 2)

        If _dtChqStopPayDt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function



    Public Function fnGetNewSBNo() As String

        strSQL = "SELECT max(AccountNo) as MaxNo FROM sbDetailstbl "

        _dtSBdetailsTable = fnExecuteQuery(strSQL, 2)

        If IsDBNull(_dtSBdetailsTable.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return _dtSBdetailsTable.Rows(0).Item("MaxNo")
        End If

    End Function
    Public Function fnGetSBDetal(ByVal MemberNo As String) As Boolean
        strSQL = "SELECT P.*, S.* FROM sbdetailstbl S, PersonTbl P WHERE P.PersonNo=S.PersonNo AND S.CustomerID='" & MemberNo & "'"
        _dtSBdetailsTable = fnExecuteQuery(strSQL, 2)

        If _dtSBdetailsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If


    End Function
    Public Function fnGetSBNO(ByVal CustomerID As String) As DataTable
        strSQL = "SELECT P.*, S.* FROM sbdetailstbl S, PersonTbl P WHERE P.PersonNo=S.PersonNo AND S.CustomerID='" & CustomerID & "'"
        _dtSBdetailsTable = fnExecuteQuery(strSQL, 2)

        If _dtSBdetailsTable.Rows.Count > 0 Then
            Return _dtSBdetailsTable

        End If


    End Function
    Public Function fnGetDayDetails() As Boolean
        strSQL = "select AccountNo, AvailBalance from sbdetailstbl"
        _datAccountDetails = fnExecuteQuery(strSQL, 2)
        If _datAccountDetails.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fnInsertDetails(ByVal AccountNo As String, ByVal Balance As Double, ByVal Today As Date) As Boolean
        strSQL = " insert into cadayendtbl(AccountNo,Date,ClosingBalance)values('" & AccountNo & "','" & Format(Today, "yyyy-MM-dd") & "','" & Balance & "') "
        If (fnExecuteNonQuery(strSQL)) Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnInsertSBDetails(ByVal AccountNo As String, ByVal Balance As Double, ByVal Today As Date, ByVal objTrans As IDbTransaction) As Boolean
        strSQL = " insert into dayendtbl(AccountNo,Date,ClosingBalance)values('" & AccountNo & "','" & Format(Today, "yyyy-MM-dd") & "','" & Balance & "') "
        If (fnExecuteNonQuery(strSQL, objTrans)) Then
            Return True
        Else
            Return False
        End If

    End Function
    Function fnGetTransactionDetailsForPassBookReprint(ByVal strAccountNo As String, ByVal DTPFrom As Date, ByVal DTPTo As Date) As DataTable
        Dim DateNow As Date
        DateNow = System.DateTime.Now.ToString()
        strSQL = "select * from sbtransactiontbl where Accountno='" & strAccountNo & "' and Trdate Between '" & Format(DTPFrom, "yyyy-MM-dd") & "' and '" & Format(DTPTo, "yyyy-MM-dd") & "' "
        _dtSBTransDetailTable = fnExecuteQuery(strSQL, 2)
        Return _dtSBTransDetailTable
    End Function
    Public Function fnGetSBTransaction(ByVal strAccNo As String) As DataTable

        strSQL = "SELECT * from PassBookSBTransactions where ACCOUNTNO = '" & strAccNo & "'"

        _dtSBTransDetailTable = fnExecuteQuery(strSQL, 2)
        Return _dtSBTransDetailTable
    End Function
    Public Function fnSetFirstTimeLastPrintDate(ByVal AcctNo As String, ByVal FirstTrdate As Date) As Boolean

        strSQL = "update PassBookSBTransactions set PassBookLineNo='0', LastPrintDate='" & Format(FirstTrdate, "yyyy-MM-dd") & "' where TRDATE = '" & Format(FirstTrdate, "yyyy-MM-dd") & "' and AccountNo='" & AcctNo & "'"
        Return fnExecuteNonQuery(strSQL)

    End Function
    Public Function fnNullInsertToPassBook()
        strSQL = " INSERT INTO SBPassBook(TEMP) VALUES('0') "
        fnExecuteQuery(strSQL, 2)
    End Function
    Public Function fnInsertToPassBookValue(ByVal AccountNo As String, ByVal TrDate As Date, ByVal NARRATION As String, ByVal ChequeNo As String, ByVal deposit As Decimal, ByVal withdraw As Decimal, ByVal PostBalance As Decimal)
        strSQL = "INSERT INTO SBPassBook(TRDATE,NARRATION,ChequeNo,DEPOSIT,WITHDRAW,postBALANCE)"
        strSQL = strSQL & " Values( '" & Format(TrDate, "yyyy-MM-dd") & "','" & NARRATION & "','" & ChequeNo & "','" & deposit & "','" & withdraw & "','" & PostBalance & "')"
        fnExecuteQuery(strSQL, 2)
    End Function

#End Region

#Region "SB Interest Calculation"

    Function SBinterestCalculation(ByVal strAccountNo As String) As Boolean

        strSQL = "select Accdate from sbdetails where Account sbinterestlogtbl"

    End Function

    Function fnGetInterest() As Boolean

        strSQL = "select * from mastersettingstbl"

        _datIntDet = fnExecuteQuery(strSQL, 2)

        If _datIntDet.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnPostInterest(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Insert into sbinterestlogtbl (AccountNo,IntFrom,IntTo,InterestAmount,Status) values ( '" & SBNo & "','" & Format(_datFromPeriod, "yyyy-MM-dd") & "','" & Format(_datToPeriod, "yyyy-MM-dd") & "','" & _dblIntAmt & "','" & _ChrStatus & "')"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnUpdateInterest(ByVal intSlNo As Integer, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "UPDATE sbinterestlogtbl set Status='" & _ChrStatus & "'  where SlNo='" & intSlNo & "'"
        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnDelIntSet() As Boolean

        strSQL = "Delete from sbinterestlogtbl"

        Return fnExecuteNonQuery(strSQL)
    End Function

    Public Function fnGetIntrestDet() As Boolean

        strSQL = "select SBInt.AccountNo,p.Name,SB.AvailBalance,SBInt.InterestAmount,SBInt.slNo from sbdetailstbl SB,persontbl p,sbinterestlogtbl SBInt where SBint.AccountNo=SB.AccountNo and SB.PersonNo=p.PersonNo and SBInt.Status='D'"
        _datIntDet = fnExecuteQuery(strSQL, 2)
        If _datIntDet.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetInterest(ByVal AccNo As String) As Boolean
        strSQL = "SELECT InterestAmount from sbinterestlogtbl where AccountNo='" & AccNo & "'"
        _datIntDet = fnExecuteQuery(strSQL, 2)
        If _datIntDet.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnDelIntSet(ByVal AccountNo As String) As Boolean
        strSQL = "Delete from sbinterestlogtbl where AccountNo='" & AccountNo & "'"
        Return fnExecuteNonQuery(strSQL)
    End Function

#End Region

#Region "TempUpdation"


    Public Function fnUpdadeTemp() As Boolean

        strSQL = "select * from sbupdate where RefNo is null"
        _dtSBMasterTable = fnExecuteQuery(strSQL, 2)
        If _dtSBMasterTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


#End Region

End Class
