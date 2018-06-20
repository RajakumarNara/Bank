
Public Class clsRDAccount
    Inherits clsPerson

#Region "Variables"

    Private _strRDNo As String
    Private _strMemberNo As String

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
    Private _dtRDdetailsTable As DataTable
    Private _dtInterest As DataTable
    Private _dtAccountNos As DataTable
    Private _dtCrtBalance As DataTable
    Private _dtSBROI As DataTable
    ' For RD Transaction
    Dim objTempDt As DataTable
    Dim AutoIncreRefNo As Decimal

    Private _strRDName As String
    Private _StrReference As String
    Private _intAmount As Integer
    Private _strNarration As String
    Private _datTranDate As Date
    Private _intRDYears As Integer
    Private _intRDMonths As Integer
    Private _intRDDays As Integer
    Private _datMatutityDate As Date
    Private _dblROI As Double
    Private _chrMode As Char
    Private _dblBalance As Double
    Private _strAccType As String
    Private _strOpMode As String
    Private _strIntroName As String
    Private _intReceiptNo As Integer
    Private _intVouncherNo As Integer
    Private _dblIntPaid As Integer
    Private _dblIntAmount As Double
    Private _dblMatAmount As Double
    Private _dblRDAmount As Double
    Private _StrLoanStatus As String
    Private _chrType As Char
    Private _intSchemeCode As Integer
    Private _chrRDType As Char
    Private _strEducation As String
    Private _chrCorrection As Char
    Private _chrCType As Char
    Private _dblCAmount As Double
    Private _dblProvisionAmount As Double
    Private _dtCheckRdAccount As DataTable
    Private _dtRDCustTable As DataTable
    Private _dtRDDetails As DataTable
    Private _dtIntroTable As DataTable

    'RD Transaction Details

    Private _intDepAmount As Integer
    Private _strDepNarration As String
    Private _strCustomerNo As String
    Private _dtCheckRef As DataTable
    Private _dtRDList As DataTable

    Private _dtDeposit As DataTable
    Private _dtWithDraw As DataTable
    Private _dtBalance As DataTable

    'Minium Period Settings
    Private _intMinPeriod As Integer
    Private _intMinDays As Integer
    Private _dtMinPeriod As DataTable

    Private _dtGetrdDet As DataTable
    Private _dtCheckROI As DataTable

    'Interest Posting
    Private _dtInterestPost As DataTable
    Private _intPeriod As Integer
    Private _dtROI As DataTable

    'RD Master Settings

    Private _intFromPeriod As Integer
    Private _intToPeriod As Integer
    Private _strSchemeName As String
    Private _strPostingPeriod As String
    Private _chrCalType As Char
    'Private _chrRDType As Char
    Private _dtRDMasterTbl As DataTable
    Private _dtRDMasterDetailTbl As DataTable
    Private _dblSeniorCROI As Double
    Private _dblReductionIterest As Double

    'Private _dtRDMasterDetailTbl As DataTable

    Private _datIntPosting As DataTable

#End Region

#Region "Properties"

    Public Property dtIntPost() As DataTable
        Get
            Return _datIntPosting
        End Get
        Set(ByVal Value As DataTable)
            _datIntPosting = Value
        End Set
    End Property


    Public Property CustomerNo() As String
        Get
            Return _strCustomerNo
        End Get
        Set(ByVal Value As String)
            _strCustomerNo = Value
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

    Public Property ProvisionAmount() As Double
        Get
            Return _dblProvisionAmount
        End Get
        Set(ByVal Value As Double)
            _dblProvisionAmount = Value
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

    'Public Property RDType() As Char
    '    Get
    '        Return _chrAccType
    '    End Get
    '    Set(ByVal Value As Char)
    '        _chrAccType = Value
    '    End Set
    'End Property

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

    '''''Property For Pigmy Transaction

    Public Property RDNo() As String
        Get
            Return _strRDNo
        End Get
        Set(ByVal Value As String)
            _strRDNo = Value
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

    Public Property RDYears() As Integer
        Get
            Return _intRDYears
        End Get
        Set(ByVal Value As Integer)
            _intRDYears = Value
        End Set
    End Property

    Public Property RDMonths() As Integer
        Get
            Return _intRDMonths
        End Get
        Set(ByVal Value As Integer)
            _intRDMonths = Value
        End Set
    End Property

    Public Property RDDays() As Integer
        Get
            Return _intRDDays
        End Get
        Set(ByVal Value As Integer)
            _intRDDays = Value
        End Set
    End Property

    Public Property RDMaturityDate() As Date
        Get
            Return _datMatutityDate
        End Get
        Set(ByVal Value As Date)
            _datMatutityDate = Value
        End Set
    End Property

    Public Property RDRoi() As Double
        Get
            Return _dblROI
        End Get
        Set(ByVal Value As Double)
            _dblROI = Value
        End Set
    End Property

    Public Property chrMode() As Char
        Get
            Return _chrMode
        End Get
        Set(ByVal Value As Char)
            _chrMode = Value
        End Set
    End Property

    Public Property RDBalance() As Double
        Get
            Return _dblBalance
        End Get
        Set(ByVal Value As Double)
            _dblBalance = Value
        End Set
    End Property
    Public Property RDOpmode() As Char
        Get
            Return _chrOpMode
        End Get
        Set(ByVal Value As Char)
            _chrOpMode = Value
        End Set
    End Property

    Public Property IntroName() As String
        Get
            Return _strIntroName
        End Get
        Set(ByVal Value As String)
            _strIntroName = Value
        End Set
    End Property

    Public Property ReceiptNo() As Integer
        Get
            Return _intReceiptNo
        End Get
        Set(ByVal Value As Integer)
            _intReceiptNo = Value
        End Set
    End Property

    Public Property VoucherNo() As Integer
        Get
            Return _intVouncherNo
        End Get
        Set(ByVal Value As Integer)
            _intVouncherNo = Value
        End Set
    End Property

    Public Property IntPaid() As Double
        Get
            Return _dblIntPaid
        End Get
        Set(ByVal Value As Double)
            _dblIntPaid = Value
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

    Public Property MatAmount() As Double
        Get
            Return _dblMatAmount
        End Get
        Set(ByVal Value As Double)
            _dblMatAmount = Value
        End Set
    End Property
    Public Property RDAmount() As Double
        Get
            Return _dblRDAmount
        End Get
        Set(ByVal Value As Double)
            _dblRDAmount = Value
        End Set
    End Property
    'Public Property SchemeCode() As Integer
    '    Get
    '        Return _intSchemeCode
    '    End Get
    '    Set(ByVal Value As Integer)
    '        _intSchemeCode = Value
    '    End Set
    'End Property

    Public Property Correction() As Char
        Get
            Return _chrCorrection
        End Get
        Set(ByVal Value As Char)
            _chrCorrection = Value
        End Set
    End Property

    Public Property CorrectioType() As Char
        Get
            Return _chrCType
        End Get
        Set(ByVal Value As Char)
            _chrCType = Value
        End Set
    End Property

    Public Property CAmount() As Double
        Get
            Return _dblCAmount
        End Get
        Set(ByVal Value As Double)
            _dblCAmount = Value
        End Set
    End Property


    Public Property LoanStatus() As Char
        Get
            Return _StrLoanStatus
        End Get
        Set(ByVal Value As Char)
            _StrLoanStatus = Value
        End Set
    End Property

    Public Property InterestTable() As DataTable
        Get
            Return _dtInterest
        End Get
        Set(ByVal Value As DataTable)
            _dtInterest = Value
        End Set
    End Property

    Public Property CheckRDTable() As DataTable
        Get
            Return _dtCheckRdAccount
        End Get
        Set(ByVal Value As DataTable)
            _dtCheckRdAccount = Value
        End Set
    End Property
    Public Property CrtBalance() As DataTable
        Get
            Return _dtCrtBalance
        End Get
        Set(ByVal Value As DataTable)
            _dtCrtBalance = Value
        End Set
    End Property

    Public Property RdCustTable() As DataTable
        Get
            Return _dtRDCustTable
        End Get
        Set(ByVal Value As DataTable)
            _dtRDCustTable = Value
        End Set
    End Property

    Public Property RDDetails() As DataTable
        Get
            Return _dtRDDetails
        End Get
        Set(ByVal Value As DataTable)
            _dtRDDetails = Value
        End Set
    End Property

    Public Property IntroTable() As DataTable
        Get
            Return _dtIntroTable
        End Get
        Set(ByVal Value As DataTable)
            _dtIntroTable = Value
        End Set
    End Property

    Public Property CheckRDRef() As DataTable
        Get
            Return _dtCheckRef
        End Get
        Set(ByVal Value As DataTable)
            _dtCheckRef = Value
        End Set
    End Property

    Public Property RDListTable() As DataTable
        Get
            Return _dtRDList
        End Get
        Set(ByVal Value As DataTable)
            _dtRDList = Value
        End Set
    End Property

    Public Property DepositTable() As DataTable
        Get
            Return _dtDeposit
        End Get
        Set(ByVal Value As DataTable)
            _dtDeposit = Value
        End Set
    End Property

    Public Property WithDrawTable() As DataTable
        Get
            Return _dtWithDraw
        End Get
        Set(ByVal Value As DataTable)
            _dtWithDraw = Value
        End Set
    End Property

    Public Property Balance() As DataTable
        Get
            Return _dtBalance
        End Get
        Set(ByVal Value As DataTable)
            _dtBalance = Value
        End Set
    End Property

    'Minium Period Variables

    Public Property MinPeriod() As Integer
        Get
            Return _intMinPeriod
        End Get
        Set(ByVal Value As Integer)
            _intMinPeriod = Value
        End Set
    End Property

    Public Property MinPeriodTable() As DataTable
        Get
            Return _dtMinPeriod
        End Get
        Set(ByVal Value As DataTable)
            _dtMinPeriod = Value
        End Set
    End Property

    Public Property MinDays() As Integer
        Get
            Return _intMinDays
        End Get
        Set(ByVal Value As Integer)
            _intMinDays = Value
        End Set
    End Property

    Public Property GetRDDetailstbl() As DataTable
        Get
            Return _dtGetrdDet
        End Get
        Set(ByVal Value As DataTable)
            _dtGetrdDet = Value
        End Set
    End Property

    Public Property CheckROITable() As DataTable
        Get
            Return _dtCheckROI
        End Get
        Set(ByVal Value As DataTable)
            _dtCheckROI = Value
        End Set
    End Property

    Public Property InterestPosttbl() As DataTable
        Get
            Return _dtInterestPost
        End Get
        Set(ByVal Value As DataTable)
            _dtInterestPost = Value
        End Set
    End Property

    Public Property AccountNostbl() As DataTable
        Get
            Return _dtAccountNos
        End Get
        Set(ByVal Value As DataTable)
            _dtAccountNos = Value
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

    Public Property ROITable() As DataTable
        Get
            Return _dtROI
        End Get
        Set(ByVal Value As DataTable)
            _dtROI = Value
        End Set
    End Property

    'Public Property RDMasterTbl() As DataTable
    '    Get
    '        Return _dtRDMasterDetailTbl
    '    End Get
    '    Set(ByVal Value As DataTable)
    '        _dtRDMasterDetailTbl = Value
    '    End Set
    'End Property

    'RD Master Interest

    Public Property FromPeriod() As Integer
        Get
            Return _intFromPeriod
        End Get
        Set(ByVal Value As Integer)
            _intFromPeriod = Value
        End Set
    End Property

    Public Property ToPeriod() As Integer
        Get
            Return _intToPeriod
        End Get
        Set(ByVal Value As Integer)
            _intToPeriod = Value
        End Set
    End Property
    Public Property SchemeCode() As Integer
        Get
            Return _intSchemeCode
        End Get
        Set(ByVal Value As Integer)
            _intSchemeCode = Value
        End Set
    End Property
    Public Property SchemeName() As String
        Get
            Return _strSchemeName
        End Get
        Set(ByVal Value As String)
            _strSchemeName = Value
        End Set
    End Property

    Public Property PostingPeriod() As String
        Get
            Return _strPostingPeriod
        End Get
        Set(ByVal Value As String)
            _strPostingPeriod = Value
        End Set
    End Property

    Public Property calcualtionType() As Char
        Get
            Return _chrCalType
        End Get
        Set(ByVal Value As Char)
            _chrCalType = Value
        End Set
    End Property

    Public Property RDMasterDetailTbl() As DataTable
        Get
            Return _dtRDMasterDetailTbl
        End Get
        Set(ByVal Value As DataTable)
            _dtRDMasterDetailTbl = Value
        End Set
    End Property

    Public Property RdMasterTbl() As DataTable
        Get
            Return _dtRDMasterTbl
        End Get
        Set(ByVal Value As DataTable)
            _dtRDMasterTbl = Value
        End Set
    End Property
    Public Property SBMasterTbl() As DataTable
        Get
            Return _dtSBROI
        End Get
        Set(ByVal Value As DataTable)
            _dtSBROI = Value
        End Set
    End Property
    Public Property SenoirCROI() As Double
        Get
            Return _dblSeniorCROI
        End Get
        Set(ByVal Value As Double)
            _dblSeniorCROI = Value
        End Set
    End Property
    Public Property ReductionInterest() As Double
        Get
            Return _dblReductionIterest
        End Get
        Set(ByVal Value As Double)
            _dblReductionIterest = Value
        End Set
    End Property
    Public Property RDType() As Char
        Get
            Return _chrRDType
        End Get
        Set(ByVal Value As Char)
            _chrRDType = Value
        End Set
    End Property

    Public Property RDAccTable() As DataTable
        Get
            Return _dtRDdetailsTable
        End Get
        Set(ByVal Value As DataTable)
            _dtRDdetailsTable = Value
        End Set
    End Property
#End Region

#Region "Functions"

    Public Function fnAddRDAccount(ByVal objTrans As IDbTransaction) As Boolean

        If fnCheckPerson() Then
            If fnUpdatePerson(objTrans) Then
                If fnInsertRDAccount(objTrans) Then
                    Return fnAddInterestTable(objTrans)
                End If
            End If
        Else
            If fnAddPerson(objTrans) Then
                If fnInsertRDAccount(objTrans) Then
                    Return fnAddInterestTable(objTrans)
                Else
                    fnDeletePerson(objTrans)
                End If
            End If
        End If

        Return False

    End Function


    Private Function fnInsertRDAccount(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Insert into rddetailstbl(RDNo,CustomerId,PersonNo,RDDate,Years,Months,Days,RDMaturityDate,RDRoi,opMode,IntroNo,Balance,Acctype,ReceiptNo,VoucherNo,RDAmount,IntAmount,MatAmount,RDScheme,Remarks,Status,Correction,CType,CAmount,IntroName)"
        strSQL = strSQL & "values('" & _strRDNo & "','" & _strCustomerNo & "','" & PersonNo & "','" & Format(_datAccDate, "yyyy-MM-dd") & "','" & _intRDYears & "','" & _intRDMonths & "','" & _intRDDays & "','" & Format(_datMatutityDate, "yyyy-MM-dd") & "','" & _dblROI & "','" & _chrOpMode & "',"
        strSQL = strSQL & "'" & _strIntroName & "' ,0,'" & _chrAccType & "','" & _intReceiptNo & "','" & _intVouncherNo & "','" & _dblRDAmount & "','" & _dblIntAmount & "','" & _dblMatAmount & "','" & _intSchemeCode & "','" & _strRemarks & "','" & _chrAccStatus & "','" & _chrCorrection & "','" & _chrCType & "','" & _dblCAmount & "','" & _strIntroName & "')"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Private Function fnAddInterestTable(ByVal objTrans As IDbTransaction) As Boolean

        Dim intCounter As Integer = 0
        If _chrRDType = "C" Then
            While intCounter < _dtInterest.Rows.Count

                strSQL = "INSERT INTO rdcumulativeinttbl(RDNo,SlNo,IntAmount,IntDate,CumuAmount,Status) "
                strSQL = strSQL & "VALUES('" & _strRDNo & "','" & _dtInterest.Rows(intCounter).Item("SlNo") & "','"
                strSQL = strSQL & _dtInterest.Rows(intCounter).Item("IntAmount") & "','"
                strSQL = strSQL & Format(CDate(_dtInterest.Rows(intCounter).Item("IntDate")), "yyyy-MM-dd") & "','"
                strSQL = strSQL & _dtInterest.Rows(intCounter).Item("TotalAmount") & "','Due')"

                fnExecuteNonQuery(strSQL, objTrans)

                intCounter += 1
            End While
        Else
            While intCounter < _dtInterest.Rows.Count

                strSQL = "INSERT INTO rdnoncumulativetbl(RDNo,SlNo,IntAmount,IntDate,Status) "
                strSQL = strSQL & "VALUES('" & _strRDNo & "','" & _dtInterest.Rows(intCounter).Item("SlNo") & "','"
                strSQL = strSQL & _dtInterest.Rows(intCounter).Item("IntAmount") & "','"
                strSQL = strSQL & Format(CDate(_dtInterest.Rows(intCounter).Item("IntDate")), "yyyy-MM-dd") & "','Due')"

                fnExecuteNonQuery(strSQL)

                intCounter += 1

            End While
        End If
        Return True

    End Function

    Public Function fnCheckRDAccount(ByVal strRDNo As String) As Boolean

        strSQL = "select * from rdDetailstbl where RDNo = '" & strRDNo & "'"

        _dtCheckRdAccount = fnExecuteQuery(strSQL, 2)

        If _dtCheckRdAccount.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnCheckRefNo(ByVal strRefNo As String) As Boolean

        strSQL = "Select * from RdTransactiontbl where RefNo = '" & strRefNo & "'"

        _dtCheckRdAccount = fnExecuteQuery(strSQL, 2)

        If _dtCheckRdAccount.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetRDAccountDetails(ByVal strRDNo As String) As Boolean

        strSQL = "select R.*,P.*,S.* from Rddetailstbl R, persontbl p ,rdschemetbl S where R.PersonNo = p.PersonNo and R.RDNo = '" & strRDNo & "'and R.RDScheme=S.SchemeCode   "

        _dtRDDetails = fnExecuteQuery(strSQL, 2)

        If _dtRDDetails.Rows.Count > 0 Then
            If _dtRDDetails.Rows(0).Item("schemeType") = "C" Then

                strSQL = "SELECT * FROM rdcumulativeinttbl WHERE RDNo='" & strRDNo & "' ORDER BY SlNo ASC" 'DESC"

                _dtInterest = fnExecuteQuery(strSQL, 2)

            ElseIf _dtRDDetails.Rows(0).Item("schemeType") = "N" Then

                strSQL = "SELECT * FROM rdnoncumulativetbl WHERE RDNo='" & strRDNo & "' ORDER BY SlNo ASC" ' DESC"

                _dtInterest = fnExecuteQuery(strSQL, 2)

            End If
            Return True
        Else
            Return False
        End If

        'If _dtRDDetails.Rows.Count > 0 Then
        '    Return True
        'Else
        '    Return False
        'End If

    End Function


    Public Function fnCheckRDScheme(ByVal strFDNo As String) As Boolean

        strSQL = "select RD.RDScheme,S.SchemeName,S.SchemeType from rddetailstbl RD,rdschemetbl S where RD.RDScheme=S.SchemeCode and RD.RDNo='" & strFDNo & "' "

        _dtRDMasterDetailTbl = fnExecuteQuery(strSQL, 2)
        If _dtRDMasterDetailTbl.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnGetInterestDet(ByVal strRDNo As String) As Boolean

        strSQL = "select sum(IntAmount) as ProvisionAmount ,Status from rdcumulativeinttbl where RDNo='" & strRDNo & "' and status='Provision' group by Status "

        _datIntPosting = fnExecuteQuery(strSQL, 2)
        If _datIntPosting.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetNonInterestDet(ByVal strRDNo As String) As Boolean

        strSQL = "select sum(IntAmount) as Amount ,Status from rdnoncumulativetbl where RDNo='" & strRDNo & "' group by Status "

        _datIntPosting = fnExecuteQuery(strSQL, 2)
        If _datIntPosting.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnGetRDAccountList() As Boolean

        strSQL = "select R.*,P.* from Rddetailstbl R, persontbl p where R.PersonNo = p.PersonNo and r.status = 'A'"

        _dtRDCustTable = fnExecuteQuery(strSQL, 2)

        If _dtRDCustTable.Rows.Count > 0 Then

            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnUpdateRDAccount(ByVal strRDNo As String) As Boolean

        strSQL = "update rddetailstbl set opMode = '" & _chrOpMode & "',IntroNo = '" & _strIntroName & "',Remarks = '" & _strRemarks & "', status = '" & _chrAccStatus & "', Photo_ID = '', Address_ID = '', AccType = '" & _chrAccType & "' where RDNo = '" & strRDNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function


    Public Function fnGetIntroName() As Boolean

        strSQL = "SELECT S.AccountNo,P.Name FROM sbDetailsTbl S, PersonTbl P WHERE S.PersonNo=P.PersonNo"

        _dtIntroTable = fnExecuteQuery(strSQL, 2)

        If _dtIntroTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnInsertTransaction(ByVal lngVersionNo As String, ByVal objTrans As IDbTransaction) As Decimal
        ''Auto increment num as a Ref number
        Dim strsql3 = "select max(RefNo) as RefNo from rdtransactiontbl"
        objTempDt = fnExecuteQuery(strsql3, 2)
        AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1


        strSQL = "Insert into RDTransactiontbl(AccountNo,TrDate,Narration,Deposit,WithDraw,PostBalance,RefNo,VoucherNo,Type,Cheque)"
        'strSQL = strSQL & "values('" & _strRDNo & "', '" & Format(_datTranDate, "yyyy-MM-dd") & "','" & _strNarration & "','" & _intAmount & "',0,0,'" & _StrReference & "','" & lngVersionNo & "','Cash',0)"
        strSQL = strSQL & " select '" & _strRDNo & "','" & Format(_datTranDate, "yyyy-MM-dd") & "','" & _strNarration & "','" & _intAmount & "','0',ifnull(sum(Deposit)-sum(withdraw),0)+'" & _intAmount & "','" & AutoIncreRefNo & "','" & lngVersionNo & "','Cash','0' from RDTransactiontbl where accountno='" & _strRDNo & "' group by Accountno"
        fnExecuteNonQuery(strSQL, objTrans)
        Return AutoIncreRefNo
    End Function

    Public Function fnRDTransaction(ByVal AccNo As String, ByVal dtpTranDate As Date, ByVal strNarration As String, ByVal intDeposit As Integer, ByVal intWithDraw As Integer, ByVal intPostBalance As Integer, ByVal strRefNo As Integer, ByVal lngVersionNo As Long, ByVal strType As String, ByVal strCheque As String, ByVal objTrans As IDbTransaction)

        strSQL = "Insert into RDTransactiontbl(AccountNo,TrDate,Narration,Deposit,WithDraw,PostBalance,RefNo,VoucherNo,Type,Cheque)"
        strSQL = strSQL & "values('" & AccNo & "', '" & Format(dtpTranDate, "yyyy-MM-dd") & "','" & strNarration & "','" & intDeposit & "',0,'" & intDeposit & "','" & strRefNo & "','" & lngVersionNo & "','Cash',0)"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnGetBalance(ByVal strRDNo As String) As Boolean

        strSQL = "select * from rddetailstbl where RdNo = '" & strRDNo & "'"
        _dtBalance = fnExecuteQuery(strSQL, 2)
        Return True

    End Function

    Public Function fnWithDrawl(ByVal lngVoucherNo As Integer, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Insert into RdTransactiontbl( AccountNo,TrDate,Narration,Deposit,WithDraw,PostBalance,RefNo,VoucherNo,Type,Cheque)"
        ' strSQL = strSQL & "values('" & _strRDNo & "','" & Format(_datTranDate, "yyyy-MM-dd") & "','" & _strNarration & "',0,'" & _intAmount & "',0,'" & _StrReference & "','" & lngVoucherNo & "','Cash',0)"
        strSQL = strSQL & " select '" & _strRDNo & "','" & Format(_datTranDate, "yyyy-MM-dd") & "','" & _strNarration & "','0','" & _intAmount & "',sum(Deposit)-sum(withdraw)-'" & _intAmount & "','" & _StrReference & "','" & lngVoucherNo & "','Cash','0' from RDTransactiontbl where accountno='" & _strRDNo & "' group by Accountno"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnGetRDList() As Boolean

        strSQL = "select R.RDNO,R.RDDATE,R.RDMaturityDate,R.RDROI,R.Remarks,R.Balance,R.Status,p.Name from rddetailstbl r, Persontbl p where r.PersonNo = P.PersonNo "
        _dtRDList = fnExecuteQuery(strSQL, 2)

        If _dtRDList.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetDepTrans(ByVal strRDNo As String) As Boolean

        strSQL = "select AccountNo,TrDate,Narration,Deposit,PostBalance from rdTransactiontbl where AccountNo = '" & strRDNo & "'"

        _dtDeposit = fnExecuteQuery(strSQL, 2)

        If _dtDeposit.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetWithTrans(ByVal strRDNo As String) As Boolean

        strSQL = "select AccountNo,TrDate,Narration,WithDraw,PostBalance from rdTransactiontbl where AccountNo = '" & strRDNo & "'"

        _dtWithDraw = fnExecuteQuery(strSQL, 2)

        If _dtWithDraw.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnUpdateMinPeriod() As Boolean

        strSQL = "update RdMinPeriodtbl set MinMonth = '" & _intMinPeriod & "',MinDays = '" & _intMinDays & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function
    Public Function fnInsertMinPeriod() As Boolean

        strSQL = "insert into RdMinPeriodtbl(SlNo,MinDays,MinMonth) values (1,'" & _intMinDays & "','" & _intMinPeriod & "')"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetMinPeriod() As Boolean

        strSQL = "Select MinMonth,MinDays from rdMinPeriodtbl where SlNo = '1'"

        _dtMinPeriod = fnExecuteQuery(strSQL, 2)

        If _dtMinPeriod.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetDetails(ByVal strAccNo As String) As Boolean

        strSQL = "select * from rdDetailstbl where RDNo = '" & strAccNo & "'"

        _dtGetrdDet = fnExecuteQuery(strSQL, 2)

        If _dtGetrdDet.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnCheckPeriod(ByVal strAccNo As String) As Boolean

        strSQL = "select * from rdminperiodtbl"

        _dtCheckROI = fnExecuteQuery(strSQL, 2)

        If _dtCheckROI.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnIntestPost(ByVal strAccNo As String) As Boolean

        strSQL = "select trdate,(select sum(WithDraw) from rdTransactiontbl where AccountNo = '" & strAccNo & "') as WithDraw FROM rdTransactiontbl where AccountNo = '" & strAccNo & "'"

        _dtInterestPost = fnExecuteQuery(strSQL, 2)

        If _dtInterestPost.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnUpdateStatus(ByVal strAccNo As String, ByVal lngVoucherNo As Long, ByVal objTrans As IDbTransaction)

        strSQL = "update rdDetailstbl set status = 'C',ClosingDate = '" & Format(_datTranDate, "yyyy-MM-dd") & "',intPaid = '" & _dblIntPaid & "',intAmount = '" & _dblIntAmount & "',MatAmount = '" & _dblMatAmount & "',VoucherNo = '" & lngVoucherNo & "' where RDNo = '" & strAccNo & "'"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnGetROI() As Boolean

        strSQL = "select RateOfInterest from RdMasterSettingstbl where '" & _intPeriod & "' between fromPeriod and ToPeriod"

        _dtROI = fnExecuteQuery(strSQL, 2)
        If _dtROI.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If



    End Function
    Public Function fnGetSB_ROI() As Boolean

        strSQL = "select SBRoi from mastersettingstbl "

        _dtSBROI = fnExecuteQuery(strSQL, 2)
        If _dtSBROI.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If



    End Function


    Public Function fnGetNewRDNo() As String

        strSQL = "SELECT max(RDNo) as MaxNo FROM Rddetailstbl "

        _dtRDDetails = fnExecuteQuery(strSQL, 2)

        If IsDBNull(_dtRDDetails.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return _dtRDDetails.Rows(0).Item("MaxNo")
        End If

    End Function


#End Region

    Public Function fnCheckScheme() As Boolean

        strSQL = "select * from rdschemetbl where SchemeCode='" & SchemeCode & "'"

        _dtRDMasterDetailTbl = fnExecuteQuery(strSQL, 2)

        If _dtRDMasterDetailTbl.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnUpdateScheme(ByVal objTrans As IDbTransaction) As Boolean
        strSQL = " Update  rdschemetbl set SchemeName='" & _strSchemeName & "',SchemeType='" & _chrRDType & "',CalType='" & _chrCalType & "',IntPostingPrd='" & _strPostingPeriod & "',SCROI='" & _dblSeniorCROI & "',ReductionInt='" & _dblReductionIterest & "',MinDays='" & _intMinDays & "',MinMonth='" & _intMinPeriod & "' where SchemeCode='" & _intSchemeCode & "'"
        Return fnExecuteNonQuery(strSQL, objTrans)
    End Function

    Public Function fnDeleteIntrSettings(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Delete from RDmasterintsettings where SchemeCode='" & SchemeCode & "'"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function



    Public Function fnAddNewScheme(ByVal objTrans As IDbTransaction) As Boolean
        strSQL = "Insert into rdschemetbl(SchemeCode,SchemeName,SchemeType,CalType,IntPostingPrd,SCROI,ReductionInt,MinDays,MinMonth) values('" & _intSchemeCode & "','" & _strSchemeName & "','" & _chrRDType & "','" & _chrCalType & "','" & _strPostingPeriod & "','" & _dblSeniorCROI & "','" & _dblReductionIterest & "','" & _intMinDays & "','" & _intMinPeriod & "')"
        Return fnExecuteNonQuery(strSQL, objTrans)
    End Function


    Public Function fnApplyIntrSet(ByVal objTrans As IDbTransaction) As Boolean

        Dim drRow As DataRow

        For Each drRow In _dtRDMasterTbl.Rows

            strSQL = "Insert rdmasterintsettings values('" & drRow(0) & "','" & drRow(1) & "','" & drRow(2) & "','" & drRow(3) & "')"

            fnExecuteNonQuery(strSQL, objTrans)

        Next

        Return True

    End Function

    Public Function fnGetScheme() As Boolean

        strSQL = "Select * from rdschemetbl"
        _dtRDMasterTbl = fnExecuteQuery(strSQL, 2)

        If _dtRDMasterTbl.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetMasterSetting() As Boolean

        strSQL = "select * from rdmasterintsettings where SchemeCode='" & SchemeCode & "'"

        _dtRDMasterTbl = fnExecuteQuery(strSQL, 2)

        If _dtRDMasterTbl.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetROI(ByVal Period As String) As Boolean

        strSQL = "SELECT ROI FROM rdmasterintsettings WHERE FromPeriod  <= '" & Period & "' and ToPeriod  >= '" & Period & "' and  SchemeCode='" & SchemeCode & "'"

        _dtRDMasterTbl = fnExecuteQuery(strSQL, 2)

        If _dtRDMasterTbl.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetCumulativeProvision(ByVal dtpDate As Date) As Boolean
        strSQL = "SELECT RD.RDNo,P.Name,RD.RDDate,RD.RDAmount,RDC.IntAmount,RDC.IntDate,RDC.CumuAmount, RDC.Status FROM rddetailstbl RD INNER JOIN  rdcumulativeinttbl RDC ON RD.RDNo=RDC.RDNo INNER JOIN persontbl P ON P.PersonNo=RD.PersonNo WHERE RD.Status='A' AND  RDC.Status='Due' AND RDC.IntDate='" & Format(dtpDate, "yyyy-MM-dd") & "' "
        _datIntPosting = fnExecuteQuery(strSQL, 2)
        If _datIntPosting.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fnGetDayDetails() As Boolean
        strSQL = "select RDNo, Balance from rddetailstbl"
        _datIntPosting = fnExecuteQuery(strSQL, 2)
        If _datIntPosting.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fnInsertDetails(ByVal AccountNo As String, ByVal Balance As Double, ByVal Today As Date) As Boolean
        strSQL = " insert into rddayendtbl(AccountNo,Date,ClosingBalance)values('" & AccountNo & "','" & Format(Today, "yyyy-MM-dd") & "','" & Balance & "') "
        If (fnExecuteNonQuery(strSQL)) Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnInsertODDetails(ByVal AccountNo As String, ByVal Balance As Double, ByVal Today As Date, ByVal objTrans As IDbTransaction) As Boolean
        strSQL = " insert into dayendtbl(AccountNo,Date,ClosingBalance)values('" & AccountNo & "','" & Format(Today, "yyyy-MM-dd") & "','" & Balance & "') "
        If (fnExecuteNonQuery(strSQL, objTrans)) Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetCrtBalance(ByVal AccountNo As String) As Boolean
        strSQL = " select ClosingBalance from oddayendtbl where AccountNo='" & AccountNo & "'"
        _dtCrtBalance = fnExecuteQuery(strSQL, 2)
        If _dtCrtBalance.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fnGetAccountNos() As Boolean
        strSQL = "select AccountNo,Balance from oddetailstbl"
        _dtAccountNos = fnExecuteQuery(strSQL, 2)
        If _dtAccountNos.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fnUpdateInterest(ByVal AccountNo As String, ByVal TrDate As Date) As Boolean

        strSQL = "update oddetailstbl set  lastpaiddate = '" & Format(TrDate, "yyyy-MM-dd") & "', intamount = '0' where AccountNo = '" & AccountNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function
    'Public Function fnGetRDAccountDetails(ByVal strRDNo As String) As Boolean
    '    strSQL = "SELECT P.*, R.* FROM rddetailstbl R, PersonTbl P WHERE P.PersonNo=R.PersonNo AND R.AccountNo='" & strRDNo & "'"

    '    _dtRDdetailsTable = fnExecuteQuery(strSQL, 2)

    '    If _dtRDdetailsTable.Rows.Count > 0 Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function
End Class
