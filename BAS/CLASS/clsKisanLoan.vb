Public Class clsKisanLoan
    Inherits clsPerson

#Region "Variables"

    Private _strKLNo As String
    Private _strMemberNo As String
    'person Number Comes from clsperson
    Private _datAccDate As Date
    Private _strSBNo As String
    Private _dblAccBal As Double
    Private _chrAccType As Char
    Private _chrOpMode As Char
    Private _strIntroSBNo As String
    Private _chrAccStatus As Char
    Private _strRemarks As String
    Private _chrPhotoID As Char
    Private _chrAddrID As Char
    Private _strReciptNo As String
    Private _intShares As Integer
    Private _intDepositAmount As Integer
    Private _intInstallment As Integer
    Private _intfertilizer As Integer
    Private _datduedate As Date
    Private _StrStatus As String
    Private _strInstallmentType As String

    Private _dtKisanLoandetailsTable As DataTable
    Private _dtKLdetailsTable As DataTable
    Private _dtKLdetailsTable1 As DataTable
    Private _dtChequedetailsTable As DataTable

    Private _strtype As String
    Private _strloantype As String
    Private _intLastReceiptNo As Integer
    Private _datReceiptDate As Date
    Private _strReason As String
    Private _dtKisanProposedDet As DataTable
    Private _dtCheckKL As DataTable
    Private _DtCropProposedDet As DataTable

    Private _intExpAmount As Integer
    Private _intSancAmount As Integer
    Private _intDisbAmount As Integer
    Private _datApplDate As Date
    Private _datSancDate As Date
    Private _dblROI As Double
    Private _intNOI As Integer
    Private _strRepayMode As String
    Private _strPurpose As String
    Private _intBalance As Integer

    Private _dtKisanLoanLandDec As DataTable
    Private _dtKisanLoanLandDet As DataTable
    Private _dtKisanLoanProposedCropdet As DataTable
    Private _intAmount As Integer
    Private _intActullAmount As Integer
    Private _dtKisanLoan As DataTable

    Private _strWitnessPerson1 As String
    Private _StrWitnessPerson2 As String
    Private _StrAddress1 As String
    Private _StrAddress2 As String

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

    Public Property KLNo() As String
        Get
            Return _strKLNo
        End Get
        Set(ByVal Value As String)
            _strKLNo = Value
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

    Public Property type() As String
        Get
            Return _strtype
        End Get
        Set(ByVal Value As String)
            _strtype = Value
        End Set
    End Property

    Public Property Loantype() As String
        Get
            Return _strloantype
        End Get
        Set(ByVal Value As String)
            _strloantype = Value
        End Set
    End Property

    Public Property Reason() As String
        Get
            Return _strReason
        End Get
        Set(ByVal Value As String)
            _strReason = Value
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

    Public Property LastReceiptNo() As Integer
        Get
            Return _intLastReceiptNo
        End Get
        Set(ByVal Value As Integer)
            _intLastReceiptNo = Value
        End Set
    End Property

    Public Property LastReceiptDate() As Date
        Get
            Return _datReceiptDate
        End Get
        Set(ByVal Value As Date)
            _datReceiptDate = Value
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

    Public Property InstallmentType() As String
        Get
            Return _strInstallmentType
        End Get
        Set(ByVal Value As String)
            _strInstallmentType = Value
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

    Public Property Status() As String
        Get
            Return _StrStatus
        End Get
        Set(ByVal Value As String)
            _StrStatus = Value
        End Set
    End Property

    Public Property KLDetailsTable() As DataTable
        Get
            Return _dtKLdetailsTable
        End Get
        Set(ByVal Value As DataTable)
            _dtKLdetailsTable = Value
        End Set
    End Property

    Public Property KisanProposedDetTable() As DataTable
        Get
            Return _dtKisanProposedDet
        End Get
        Set(ByVal Value As DataTable)
            _dtKisanProposedDet = Value
        End Set
    End Property

    Public Property KLAccLoanDetTable() As DataTable
        Get
            Return _dtKLdetailsTable1
        End Get
        Set(ByVal Value As DataTable)
            _dtKLdetailsTable1 = Value
        End Set
    End Property

    Public Property CheckKLLoanDetTable() As DataTable
        Get
            Return _dtCheckKL
        End Get
        Set(ByVal Value As DataTable)
            _dtCheckKL = Value
        End Set
    End Property


    'SbChequebook
    Public Property Shares() As Integer
        Get
            Return _intShares
        End Get
        Set(ByVal Value As Integer)
            _intShares = Value
        End Set
    End Property

    Public Property FertilizerAmount() As Integer
        Get
            Return _intfertilizer
        End Get
        Set(ByVal Value As Integer)
            _intfertilizer = Value
        End Set
    End Property


    Public Property Installments() As Integer
        Get
            Return _intInstallment
        End Get
        Set(ByVal Value As Integer)
            _intInstallment = Value
        End Set
    End Property

    Public Property DepositAmount() As Integer
        Get
            Return _intDepositAmount
        End Get
        Set(ByVal Value As Integer)
            _intDepositAmount = Value
        End Set
    End Property

    Public Property DueDate() As Date
        Get
            Return _datduedate
        End Get
        Set(ByVal Value As Date)
            _datduedate = Value
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

    Public Property KisanLoanDetailsTable() As DataTable
        Get
            Return _dtKisanLoandetailsTable
        End Get
        Set(ByVal Value As DataTable)
            _dtKisanLoandetailsTable = Value
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

    Public Property KisanProposedCropDetails() As DataTable
        Get
            Return _DtCropProposedDet
        End Get
        Set(ByVal Value As DataTable)
            _DtCropProposedDet = Value
        End Set
    End Property

    Public Property ExpAmount() As Integer
        Get
            Return _intExpAmount
        End Get
        Set(ByVal Value As Integer)
            _intExpAmount = Value
        End Set
    End Property

    Public Property SancAmount() As Integer
        Get
            Return _intSancAmount
        End Get
        Set(ByVal Value As Integer)
            _intSancAmount = Value
        End Set
    End Property

    Public Property DisbAmount() As Integer
        Get
            Return _intDisbAmount
        End Get
        Set(ByVal Value As Integer)
            _intDisbAmount = Value
        End Set
    End Property

    Public Property ApplDate() As Date
        Get
            Return _datApplDate
        End Get
        Set(ByVal Value As Date)
            _datApplDate = Value
        End Set
    End Property

    Public Property SancDate() As Date
        Get
            Return _datSancDate
        End Get
        Set(ByVal Value As Date)
            _datSancDate = Value
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

    Public Property NOI() As Integer
        Get
            Return _intNOI
        End Get
        Set(ByVal Value As Integer)
            _intNOI = Value
        End Set
    End Property

    Public Property RepayMode() As String
        Get
            Return _strRepayMode
        End Get
        Set(ByVal Value As String)
            _strRepayMode = Value
        End Set
    End Property

    Public Property Purpose() As String
        Get
            Return _strPurpose
        End Get
        Set(ByVal Value As String)
            _strPurpose = Value
        End Set
    End Property

    Public Property Balance() As Integer
        Get
            Return _intBalance
        End Get
        Set(ByVal Value As Integer)
            _intBalance = Value
        End Set
    End Property

    Public Property ActuallAmount() As Integer
        Get
            Return _intActullAmount
        End Get
        Set(ByVal Value As Integer)
            _intActullAmount = Value
        End Set
    End Property

    Public Property KisanLoanLandDectbl() As DataTable
        Get
            Return _dtKisanLoanLandDec
        End Get
        Set(ByVal Value As DataTable)
            _dtKisanLoanLandDec = Value
        End Set
    End Property

    Public Property KisanLoanProposedLandDettbl() As DataTable
        Get
            Return _dtKisanLoanLandDet
        End Get
        Set(ByVal Value As DataTable)
            _dtKisanLoanLandDet = Value
        End Set
    End Property

    Public Property KisanLoanProposedCropDettbl() As DataTable
        Get
            Return _dtKisanLoanProposedCropdet
        End Get
        Set(ByVal Value As DataTable)
            _dtKisanLoanProposedCropdet = Value
        End Set
    End Property

    Public Property KLCustTable() As DataTable
        Get
            Return _dtKisanLoan
        End Get
        Set(ByVal Value As DataTable)
            _dtKisanLoan = Value
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
            Return _StrWitnessPerson2
        End Get
        Set(ByVal Value As String)
            _StrWitnessPerson2 = Value
        End Set
    End Property

    Public Property Address1() As String
        Get
            Return _StrAddress1
        End Get
        Set(ByVal Value As String)
            _StrAddress2 = Value
        End Set
    End Property

    Public Property Address2() As String
        Get
            Return _StrAddress2
        End Get
        Set(ByVal Value As String)
            _StrAddress2 = Value
        End Set
    End Property

#End Region


#Region "Functions"


    Public Function fnAddKLAccount(ByVal objTrans As IDbTransaction) As Boolean

        If fnCheckPerson() Then
            If fnUpdatePerson(objTrans) Then
                If fnInsertKisanLoanAccount(objTrans) Then
                    If fnInsertKLAccount(objTrans) Then
                        If fnInserKisanLandDet(objTrans) Then
                            If fnInsertProposedCropDet(objTrans) Then
                                If fnInsertDecKisanLand(objTrans) Then
                                    Return True
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Else
            If fnAddPerson(objTrans) Then
                If fnInsertKisanLoanAccount(objTrans) Then
                    If fnInsertKLAccount(objTrans) Then
                        If fnInserKisanLandDet(objTrans) Then
                            If fnInsertProposedCropDet(objTrans) Then
                                If fnInsertDecKisanLand(objTrans) Then
                                    Return True
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                fnDeletePerson(objTrans)
            End If
        End If
        Return False

    End Function


    Private Function fnInsertKLAccount(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "INSERT INTO KisanLoantbl(KisanLoanNo,MemberNo,PersonNo,ShareNo,DepositAmount,Type,LastReceiptNo,ReceiptDate,Reason,InstallmentType,ActuallAmount,WitnessPerson1,Address1,WitnessPerson2,Address2)"
        strSQL = strSQL & " VALUES('" & _strKLNo & "','" & _strMemberNo & "','" & PersonNo & "','" & _intShares & "','" & _intDepositAmount & "','" & _strtype & "','" & _intLastReceiptNo & "','" & Format(_datReceiptDate, "yyyy-MM-dd") & "','" & _strReason & "','" & _strInstallmentType & "','" & _intActullAmount & "','" & _strWitnessPerson1 & "','" & _StrAddress1 & "','" & _StrWitnessPerson2 & "','" & _StrAddress2 & "')"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnInserKisanLandDet(ByVal objTrans As IDbTransaction) As Boolean
        Dim drproposed As DataRow
        Dim dr As DataRow

        For Each dr In _dtKisanProposedDet.Rows

            strSQL = "Insert into kisanloanlanddettbl(KisanLoanNo,proposedHobli,ProposedServaeNo,ProposedType,ProposedArea)"
            strSQL = strSQL & "values ('" & dr(0) & "','" & dr(1) & "','" & dr(2) & "','" & dr(3) & "','" & dr(4) & "')"

            fnExecuteNonQuery(strSQL, objTrans)

        Next

        'For Each drproposed In _dtKisanProposedDet.Rows

        '    strSQL = "insert into  kisanloanlanddettbl(proposedHobli, ProposedServaeNo,ProposedType,ProposedArea) values ('" & drproposed(1) & "','" & drproposed(2) & "','" & drproposed(3) & "', '" & drproposed(4) & "') where KisanLoanNo = '" & drproposed(0) & "'"

        '    fnExecuteNonQuery(strSQL)

        'Next

        Return True
    End Function

    Public Function fnInsertProposedCropDet(ByVal objTrans As IDbTransaction) As Boolean

        Dim dr As DataRow

        For Each dr In KisanProposedCropDetails.Rows

            strSQL = "Insert into kisanproposedcropdettbl(LoanNo,ServaeNo,Area,CropDetails,EstimatedAmount,ExpectedAmount,Remarks,WetLandDetails)"
            strSQL = strSQL & "values ('" & dr(0) & "','" & dr(1) & "','" & dr(2) & "','" & dr(3) & "','" & dr(4) & "','" & dr(5) & "','" & dr(6) & "','" & dr(7) & "')"

            fnExecuteNonQuery(strSQL, objTrans)

        Next

        Return True
    End Function

    Public Function fnInsertDecKisanLand(ByVal objTrans As IDbTransaction) As Boolean

        Dim drDec As DataRow
        For Each drDec In _dtKLdetailsTable1.Rows
            strSQL = "insert into KisanLoanLandDeclaredtbl(KisanLoanNo,DecHobli,DecServaeNo,DecType,DecArea)"
            strSQL = strSQL & "values('" & drDec(0) & "','" & drDec(1) & "','" & drDec(2) & "','" & drDec(3) & "','" & drDec(4) & "')"
            fnExecuteNonQuery(strSQL, objTrans)
        Next
        Return True
    End Function


    Public Function fnCheckKLAccount(ByVal strKLNo As String) As Boolean

        strSQL = "SELECT * FROM kisanLoantbl WHERE KisanLoanNo='" & strKLNo & "'"

        _dtCheckKL = fnExecuteQuery(strSQL, 2)

        If _dtCheckKL.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnGetSBAccountTable() As Boolean

        ''''strSQL = "SELECT S.AccountNo,P.Name FROM sbDetailsTbl S, PersonTbl P WHERE S.PersonNo=P.PersonNo"

        ''''_dtSBdetailsTable = fnExecuteQuery(strSQL, 2)

        ''''If _dtSBdetailsTable.Rows.Count > 0 Then
        ''''    Return True
        ''''Else
        ''''    Return False
        ''''End If

    End Function


    Public Function fnGetKLAccountDetails(ByVal strKLNo As String) As Boolean

        strSQL = "SELECT P.*, g.*, a.* FROM Loandetailstbl g, PersonTbl P, kisanloantbl a  WHERE P.PersonNo=g.PersonNo  and g.LoanNo= '" & strKLNo & "' AND  g.loanno = a.KisanLoanno"

        _dtKisanLoandetailsTable = fnExecuteQuery(strSQL, 2)

        If _dtKisanLoandetailsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnGetSBAccountList() As Boolean

        ''''strSQL = "SELECT P.*, S.* FROM sbdetailstbl S, PersonTbl P WHERE P.PersonNo=S.PersonNo"

        ''''_dtSBdetailsTable = fnExecuteQuery(strSQL, 2)

        ''''If _dtSBdetailsTable.Rows.Count > 0 Then
        ''''    Return True
        ''''Else
        ''''    Return False
        ''''End If

    End Function


    Public Function fnCloseSBAccount() As Boolean


    End Function


    Public Function fnUpdateKLAccount(ByVal _strKLNo As String) As Boolean

        If fnUpdatePerson() Then

            strSQL = "UPDATE KisanLoantbl SET memberNo='" & _strMemberNo & "', PersonNo='" & PersonNo & "',ShareNo ='" & _intShares & "' , DepositAmount='" & DepositAmount & "', type ='" & _strloantype & "' , LastReceiptNo='" & _intLastReceiptNo & "',ReceiptDate = '" & Format(_datReceiptDate, "yyyy-MM-dd") & "',Reason = '" & _strPurpose & "', InstallmentType = '" & _strInstallmentType & "',WitnessPerson1 = '" & _strWitnessPerson1 & "',Address1 = '" & _StrAddress1 & "',WitnessPerson2 = '" & _StrWitnessPerson2 & "',Address2 = '" & _StrAddress2 & "'  WHERE KisanLoanNo='" & _strKLNo & "'"

            Return fnExecuteNonQuery(strSQL)

        Else
            Return False
        End If
    End Function

    Public Function fnDeleteKLDecDet(ByVal _strKLNo As String) As Boolean

        Dim drDec As DataRow

        For Each drDec In _dtKLdetailsTable1.Rows
            strSQL = "Delete from kisanloanlanddeclaredtbl where KisanLoanNo = '" & _strKLNo & "'"
            fnExecuteNonQuery(strSQL)
        Next

        Return True

    End Function

    Public Function fnDeleteKLPropDet(ByVal _strKLNo As String) As Boolean

        Dim dr As DataRow

        For Each dr In _dtKisanProposedDet.Rows

            strSQL = "Delete from kisanloanlanddettbl where KisanLoanNo = '" & _strKLNo & "'"
            fnExecuteNonQuery(strSQL)

        Next

        Return True

    End Function

    Public Function fnDeleteKLProposedCropDet(ByVal strKLNo As String) As Boolean

        Dim drProposed As DataRow

        For Each drProposed In _dtKisanLoanProposedCropdet.Rows
            strSQL = "Delete from kisanproposedcropdettbl where LoanNo = '" & strKLNo & "'"
            fnExecuteNonQuery(strSQL)

        Next

        Return True

    End Function

    Public Function fnSBInsertCheckBookDetails() As Boolean
        ''''Dim intCounter As Integer = _intStartNo

        ''''For intCounter = _intStartNo To _intEndno - 1

        ''''    'strSQL = "INSERT INTO sbchequebooktbl(AccountNo,BookNo,ChequeNo,IssueDate,chkStatus)"
        ''''    'strSQL = strSQL & " VALUES('" & _strSBNo & "','" & _strBookNo & "','" & intCounter & "','" & Format(_datChkBookDate, "yyyy-MM-dd") & "','" & _chrChkstatus & "')"

        ''''    fnExecuteNonQuery(strSQL)
        ''''Next

        ''''Return True

    End Function


    Public Function fnGetSBCheckBookDetails() As Boolean

        'strSQL = "SELECT S.AccountNo,P.Name FROM sbDetailsTbl S, PersonTbl P WHERE S.PersonNo=P.PersonNo"
        'strSQL = "SELECT AccountNo,BookNo,Issuedate,ChequeNo as StartNo,Max(ChequeNo) as EndNo,chkStatus FROM sbchequebooktbl WHERE AccountNo='" & _strSBNo & "' and chkstatus='P' Group by bookno"


        ''''_dtSBCheckBookTable = fnExecuteQuery(strSQL, 2)

        ''''If _dtSBCheckBookTable.Rows.Count > 0 Then
        ''''    Return True
        ''''Else
        ''''    Return False
        ''''End If

    End Function


    Public Function fnGetChecks(ByVal strChequeNo As String) As Boolean

        'strSQL = "SELECT S.AccountNo,P.Name FROM sbDetailsTbl S, PersonTbl P WHERE S.PersonNo=P.PersonNo"
        ''''strSQL = "select cb.accountno,cb.chequeno,P.Name,P.Photo,P.Signature,sb.Balance from sbchequebooktbl cb,sbdetailstbl sb,persontbl P where cb.accountno=sb.accountno and sb.personno=p.personno and cb.chequeNo='" & strChequeNo & "' and cb.chkStatus='P'"

        ''''_dtSBCheckBookTable = fnExecuteQuery(strSQL, 2)

        ''''If _dtSBCheckBookTable.Rows.Count > 0 Then
        ''''    Return True
        ''''Else
        ''''    Return False
        ''''End If

    End Function


    Function fnSBCheckChequeBook(ByVal strAccountNo As String, ByVal strbookName As String, ByVal intStrartNo As Integer) As Boolean

        Dim dtTable As New DataTable

        strSQL = "select * from sbchequebooktbl where ChequeNo='" & intStrartNo & "'"

        dtTable = fnExecuteQuery(strSQL, 2)

        If dtTable.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If
    End Function


    Function fnSbtransactionEnter(ByVal strAccountNo As String, ByVal dtTransDate As Date, ByVal strNarration As String, ByVal dblDeposit As Double, ByVal dblWithdraw As Double, ByVal dblPostBal As Double, ByVal strRefNo As String, ByVal lngvoucherNo As Long, ByVal strType As String, ByVal strchequeNo As String) As Boolean

        strSQL = "Insert into sbTransactionTbl(AccountNo,Trdate,Narration,Deposit,Withdraw,PostBal,Refno,VoucherNo,Type,ChequeNo)"
        strSQL = strSQL & " Values( '" & strAccountNo & "','" & Format(dtTransDate, "yyyy-MM-dd") & "','" & strNarration & "','" & dblDeposit & "','" & dblWithdraw & "','" & dblPostBal & "','" & strRefNo & "','" & lngvoucherNo & "','" & strType & "','" & strchequeNo & "')"

        fnExecuteNonQuery(strSQL)

    End Function


    Function fnGetTransactionDetails() As Boolean

        'strSQL = "select * from sbtransactiontbl where Accountno='" & _strSBNo & "'"

        ''''_dtSBTransDetailTable = fnExecuteQuery(strSQL, 2)

        Return True
    End Function


    Function fnAddDepositedCheque() As Boolean

        'strSQL = "Insert into sbChequeDeposittbl(AccountNo,BankName,BranchName,Chequedate,ChequeNo,Depositdate,ChequeAmount,BankCharges,ChequeStatus,Remarks)"
        'strSQL = strSQL & " Values( '" & _strSBNo & "','" & _strBankName & "','" & _strBranchName & "','" & Format(_datChequeDate, "yyyy-MM-dd") & "','" & _strChequeNo & "','" & Format(_datChequeDepositDate, "yyyy-MM-dd") & "','" & _dblChequeAmount & "','" & _dblBankCharges & "','" & _strChequeStatus & "','" & _strRemarks & "')"

        If fnExecuteNonQuery(strSQL) Then

            Return True

        Else
            Return False

        End If
    End Function


    Function fnGetDepositedCheque() As Boolean

        strSQL = "select * from sbChequeDeposittbl"

        _dtChequedetailsTable = fnExecuteQuery(strSQL, 2)

        If _dtChequedetailsTable.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function


    Function fnGetMaxSBChequeNo() As Long

        strSQL = "Select Max(ChequeNo) from sbchequebooktbl"

        Return IIf(IsDBNull(fnExecuteQuery(strSQL, 2).Rows(0).Item(0)) = True, 0, fnExecuteQuery(strSQL, 2).Rows(0).Item(0))

    End Function


    Function fnChkBookstatus(ByVal strAccNo As String) As Boolean

        strSQL = "select * from sbChequebooktbl where AccountNo='" & strAccNo & "' and chkStatus='P'"
        fnChkBookstatus = IIf(fnExecuteQuery(strSQL, 2).Rows.count > 0 = True, True, False)

    End Function


    Function fnUpdateCheckStatusUpdate(ByVal strChequeNo As String) As Boolean

        strSQL = "Update sbChequebooktbl set chkStatus ='C' where ChequeNo='" & strChequeNo & "'"

        fnExecuteNonQuery(strSQL)
    End Function

    Function fnChkBookstatusUpdate(ByVal strAccNo As String) As Boolean

        strSQL = "Update sbChequebooktbl Set chkStatus='C' where AccountNo='" & strAccNo & "'"

        fnExecuteNonQuery(strSQL)

        Return True

    End Function

    Private Function fnInsertKisanLoanAccount(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Insert into loanDetailstbl(LoanNo,PersonNo,MemberNo,SBNo,ExpAmount,SancAmount,DisbAmount,ApplDate,SancDate,DueDate,ROI,NOI,InstPrinciple,RepayMode,Purpose,Balance,LastPaidDate,Remarks,status,ReceiptNo)"
        strSQL = strSQL & " values('" & _strKLNo & "','" & PersonNo & "','" & _strMemberNo & "','" & _strSBNo & "','" & _intExpAmount & "','" & _intSancAmount & "','" & _intDisbAmount & "','" & Format(_datApplDate, "yyyy-MM-dd") & "','" & Format(_datApplDate, "yyyy-MM-dd") & "','" & Format(_datduedate, "yyyy-MM-dd") & "','" & _dblROI & "','" & _intNOI & "','0','" & _strRepayMode & "','" & _strPurpose & "','" & _intBalance & "','" & Format(_datApplDate, "yyyy-MM-dd") & "','" & _strRemarks & "','" & _StrStatus & "','" & _intLastReceiptNo & "')"
        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnGetLandDecDet(ByVal strLoanNo As String) As Boolean

        strSQL = "Select * from kisanloanlanddeclaredtbl where KisanLoanNo = '" & strLoanNo & "'"

        _dtKisanLoanLandDec = fnExecuteQuery(strSQL, 2)

        If _dtKisanLoanLandDec.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetProposedLandDet(ByVal strLoanNo As String) As Boolean

        strSQL = "select * from kisanloanlanddettbl where KisanloanNo = '" & strLoanNo & "'"

        _dtKisanLoanLandDet = fnExecuteQuery(strSQL, 2)

        If _dtKisanLoanLandDet.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetProposedCropDet(ByVal strLoanNo As String) As Boolean

        strSQL = "select * from kisanproposedcropdettbl where LoanNo = '" & strLoanNo & "'"

        _dtKisanLoanProposedCropdet = fnExecuteQuery(strSQL, 2)

        If _dtKisanLoanProposedCropdet.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnUpdateKLoanAccount(ByVal strKLno As String) As Boolean

        If fnUpdatePerson() Then

            strSQL = "UPDATE loandetailsTbl SET memberNo = '" & _strMemberNo & "',personNo = '" & PersonNo & "', sbno = '" & _strSBNo & "', expAmount='" & _intExpAmount & "', sancamount='" & _intSancAmount & "',ApplDate = '" & Format(_datApplDate, "yyyy-MM-dd") & "',DueDate = '" & Format(_datduedate, "yyyy-MM-dd") & "', RepayMode  ='" & _strRepayMode & "' , ROI='" & _dblROI & "',NOI = '" & _intNOI & "',InstPrinciple = '0',Purpose ='" & _strPurpose & "', Remarks = '" & _strRemarks & "'   WHERE  LoanNo='" & strKLno & "'"

            Return fnExecuteNonQuery(strSQL)

        Else
            Return False
        End If

    End Function

    Public Function fnGetKisanLoanCust() As Boolean

        strSQL = "select P.*, S.* FROM loandetailstbl S, PersonTbl P WHERE P.PersonNo=S.PersonNo and loanno like 'KL%'"
        _dtKisanLoan = fnExecuteQuery(strSQL, 2)

        If _dtKisanLoan.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

End Class
