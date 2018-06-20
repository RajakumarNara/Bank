Public Class clsSavingsBank1
    Inherits clsPerson

#Region "Variables"

    Private _PersonNo As Long
    Private _strSBNo As String
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
    Private _chrLoanType As Char


    'Private _datOpenDate As Date
    'Private _strReceiptNo As String
    'Private _datClosingDate As Date
    'Private _chrIDCard As Char

    Private _dtSBTransDetailTable As DataTable
    Private _dtSBdetailsTable As DataTable
    Private _dtChequedetailsTable As DataTable


    'Cheque Book Details

    Private _strBookNo As String
    Private _intStartNo As Integer
    Private _intEndno As Integer
    Private _datChkBookDate As Date
    Private _chrChkstatus As Char
    Private _dtSBCheckBookTable As DataTable
    Private _dtGoldLoan As DataTable
    Private _dtGoldItemDetails As DataTable



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
    Private _dtGoldDetailsTable As DataTable
    Private _intExpectedAmount As Integer
    Private _intSanctionedAmount As Integer
    Private _dblROI As Double
    Private _strInstallment As String
    Private _intInstAmount As Integer
    Private _strModeOfPayment As String
    Private _strReason As String
    Private _strWitnessPerson1 As String
    Private _strWitnessPerson2 As String
    Private _strWitnessAddress1 As String
    Private _strWitnessAddress2 As String
    Private _strGoldNo As String
    Private _datGoldDate As Date
    Private _datGoldLoanCust As DataTable
    Private _intInstPrinciple As Integer
    Private _datDueDate As Date
    Private _strSubsidy As String
    Private _intBalance As Integer
    Private _intNOI As Integer
    Private _strStatus As String
    Private _intDisbAmt As Integer
    Private _intGoldAmt As Integer
    Private _datLastPaid As Date
    Private _dtLoanType As DataTable
    Private _datlastInstDate As Date

    Private _datSancDate As Date
    Private _strMobileNo2 As String
    Private _dblSancNo As String


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

    'SbChequebook
    Public Property BookNo() As String
        Get
            Return _strBookNo
        End Get
        Set(ByVal Value As String)
            _strBookNo = Value
        End Set
    End Property
    Public Property ChkStartNo() As Integer
        Get
            Return _intStartNo
        End Get
        Set(ByVal Value As Integer)
            _intStartNo = Value
        End Set
    End Property

    Public Property GoldAmt() As Integer
        Get
            Return _intGoldAmt
        End Get
        Set(ByVal Value As Integer)
            _intGoldAmt = Value
        End Set
    End Property

    Public Property ChkEndNo() As Integer
        Get
            Return _intEndno
        End Get
        Set(ByVal Value As Integer)
            _intEndno = Value
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

    Public Property GoldLoanItemDetTable() As DataTable
        Get
            Return _dtGoldItemDetails
        End Get
        Set(ByVal Value As DataTable)
            _dtGoldDetailsTable = Value
        End Set
    End Property

    Public Property GoldDetailsTable() As DataTable
        Get
            Return _dtGoldDetailsTable
        End Get
        Set(ByVal Value As DataTable)
            _dtGoldDetailsTable = Value
        End Set
    End Property

    Public Property GoldLoanTable() As DataTable
        Get
            Return _dtGoldLoan
        End Get
        Set(ByVal Value As DataTable)
            _dtGoldLoan = Value
        End Set
    End Property

    Public Property GoldNo() As String
        Get
            Return _strGoldNo
        End Get
        Set(ByVal Value As String)
            _strGoldNo = Value
        End Set
    End Property

    Public Property GoldExpectedAmount() As Integer
        Get
            Return _intExpectedAmount
        End Get
        Set(ByVal Value As Integer)
            _intExpectedAmount = Value
        End Set
    End Property

    Public Property GoldSanctioned() As Integer
        Get
            Return _intSanctionedAmount
        End Get
        Set(ByVal Value As Integer)
            _intSanctionedAmount = Value
        End Set
    End Property

    Public Property GoldROI() As Double
        Get
            Return _dblROI
        End Get
        Set(ByVal Value As Double)
            _dblROI = Value
        End Set
    End Property

    Public Property GoldDisbAmt() As Integer
        Get
            Return _intDisbAmt
        End Get
        Set(ByVal Value As Integer)
            _intDisbAmt = Value
        End Set
    End Property

    Public Property GoldInstallments() As String
        Get
            Return _strInstallment
        End Get
        Set(ByVal Value As String)
            _strInstallment = Value
        End Set
    End Property
    Public Property GoldInstalmentAmount() As String
        Get
            Return _intInstAmount
        End Get
        Set(ByVal Value As String)
            _intInstAmount = Value
        End Set
    End Property

    Public Property GoldModeOfPayment() As String
        Get
            Return _strModeOfPayment
        End Get
        Set(ByVal Value As String)
            _strModeOfPayment = Value
        End Set
    End Property

    Public Property GoldReason() As String
        Get
            Return _strReason
        End Get
        Set(ByVal Value As String)
            _strReason = Value
        End Set
    End Property

    Public Property GoldWitnessPerson1() As String
        Get
            Return _strWitnessPerson1
        End Get
        Set(ByVal Value As String)
            _strWitnessPerson1 = Value
        End Set
    End Property

    Public Property GoldWitnessPerson2() As String
        Get
            Return _strWitnessPerson2
        End Get
        Set(ByVal Value As String)
            _strWitnessPerson2 = Value
        End Set
    End Property

    Public Property GoldWitnessPersonAddress1() As String
        Get
            Return _strWitnessAddress1
        End Get
        Set(ByVal Value As String)
            _strWitnessAddress1 = Value
        End Set
    End Property

    Public Property GoldWitnessPersonAddress2() As String
        Get
            Return _strWitnessAddress2
        End Get
        Set(ByVal Value As String)
            _strWitnessAddress2 = Value
        End Set
    End Property

    Public Property GoldDate() As Date
        Get
            Return _datGoldDate
        End Get
        Set(ByVal Value As Date)
            _datGoldDate = Value
        End Set
    End Property


    Public Property GoldDueDate() As Date
        Get
            Return _datDueDate
        End Get
        Set(ByVal Value As Date)
            _datDueDate = Value
        End Set
    End Property

    Public Property GoldSancDate() As Date
        Get
            Return _datSancDate
        End Get
        Set(ByVal Value As Date)
            _datSancDate = Value
        End Set
    End Property

    Public Property GoldSancNo() As String
        Get
            Return _dblSancNo
        End Get
        Set(ByVal Value As String)
            _dblSancNo = Value
        End Set
    End Property

    Public Property GoldMobileNo2() As String
        Get
            Return _strMobileNo2
        End Get
        Set(ByVal Value As String)
            _strMobileNo2 = Value
        End Set
    End Property

    Public Property LoanType() As Char
        Get
            Return _chrLoanType
        End Get
        Set(ByVal Value As Char)
            _chrLoanType = Value
        End Set
    End Property

    Public Property GoldInstPrinciple() As Integer
        Get
            Return _intInstPrinciple
        End Get
        Set(ByVal Value As Integer)
            _intInstPrinciple = Value
        End Set
    End Property

    Public Property GoldAmtBalance() As Integer
        Get
            Return _intBalance
        End Get
        Set(ByVal Value As Integer)
            _intBalance = Value
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

    Public Property GoldSubsidy() As String
        Get
            Return _strSubsidy
        End Get
        Set(ByVal Value As String)
            _strSubsidy = Value
        End Set
    End Property

    Public Property Status() As String
        Get
            Return _strStatus
        End Get
        Set(ByVal Value As String)
            _strStatus = Value
        End Set
    End Property

    Public Property GoldLastPaidDate() As Date
        Get
            Return _datLastPaid
        End Get
        Set(ByVal Value As Date)
            _datLastPaid = Value
        End Set
    End Property
    Public Property GoldLastInstDate() As Date
        Get
            Return _datlastInstDate
        End Get
        Set(ByVal Value As Date)
            _datlastInstDate = Value
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

    Public Property Loantypetable() As DataTable
        Get
            Return _dtLoanType
        End Get
        Set(ByVal Value As DataTable)
            _dtLoanType = Value
        End Set
    End Property

#End Region

#Region "Functions"


    Public Function fnAddGLAccount(ByVal objTrans As IDbTransaction) As Boolean

        If fnCheckPerson() Then
            If fnUpdatePerson(objTrans) Then
                If fnInsertGLAccount(objTrans) Then
                    If fnInsertWitnessDet(objTrans) Then
                        Return fnInsertGlDetailsAccount(objTrans)
                    End If
                End If
            End If
        Else
            If fnAddPerson() Then
                If fnInsertGLAccount(objTrans) Then
                    If fnInsertWitnessDet(objTrans) Then
                        If fnInsertGlDetailsAccount(objTrans) = True Then
                            Return True
                        Else
                            fnDeletePerson(objTrans)

                        End If
                    End If
                End If
            End If
        End If
    End Function


    Private Function fnInsertGLAccount(ByVal objTrans As IDbTransaction) As Boolean

        'strSQL = "INSERT INTO goldloandetailstbl(GoldLoanNo,MemberNo,PersonNo,ExpectedAmount,SanctionedAmount,ROI,InstallmentType,ModeOfPayment,Reason,WitnessPerson1,Address1,WitnessPerson2,Address2,Date,Remarks)"
        'strSQL = strSQL & " VALUES('" & _strGoldNo & "','" & _strMemberNo & "','" & _lngPersonNo & "','" & _intExpectedAmount & "','" & _intSanctionedAmount & "','" & _intROI & "','" & _strInstallment & "','" & _strModeOfPayment & "','" & _strReason & "','" & _strWitnessPerson1 & "','" & _strWitnessAddress1 & "','" & _strWitnessPerson2 & "','" & _strWitnessAddress2 & "', '" & Format(_datGoldDate, "yyyy-MM-dd") & "','" & _strRemarks & "')"
        ''MsgBox(strSQL)+
        'fnExecuteNonQuery(strSQL)

        strSQL = "Insert into loanDetailstbl(LoanNo,PersonNo,CustomerID,SBNo,LoanType,ExpAmount,SancAmount,DisbAmount,ApplDate,SancDate,DueDate,SancNo,ROI,NOI,InstPrinciple,RepayMode,Purpose,Type,Balance,LastPaidDate,LastInstDate,Remarks,status,ReceiptNo)"
        strSQL = strSQL & " values('" & _strGoldNo & "','" & PersonNo & "','" & _strMemberNo & "','" & _strSBNo & "','" & _chrLoanType & "','" & _intExpectedAmount & "','" & _intSanctionedAmount & "','" & _intDisbAmt & "','" & Format(_datGoldDate, "yyyy-MM-dd") & "','" & Format(_datSancDate, "yyyy-MM-dd") & "','" & Format(_datDueDate, "yyyy-MM-dd") & "','" & _dblSancNo & "','" & _dblROI & "','" & _intNOI & "','" & _intInstPrinciple & "','" & _strModeOfPayment & "','" & _strReason & "','" & _strInstallment & "','" & _intBalance & "','" & Format(_datLastPaid, "yyyy-MM-dd") & "','" & Format(_datlastInstDate, "yyyy-MM-dd") & "','" & _strRemarks & "','" & _strStatus & "','" & _strReciptNo & "')"
        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Private Function fnInsertWitnessDet(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Insert into goldloandetailstbl (GoldLoanNo,MemberNo,PersonNo,GoldAmount,InstallmentType,MobileNo2)"
        strSQL = strSQL & " values('" & _strGoldNo & "','" & _strMemberNo & "','" & PersonNo & "','" & _intGoldAmt & "','" & _strInstallment & "','" & _strMobileNo2 & "')"
        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnInsertGlDetailsAccount(ByVal objTrans As IDbTransaction) As Boolean

        Dim intCount As Integer
        Dim dr As DataRow

        For Each dr In _dtGoldDetailsTable.Rows
            strSQL = "Insert into GoldDetailstbl (GoldLoanNo,GoldType,Weight,NetWeight,Purity,TotalWeight) "
            strSQL = strSQL & " values ('" & dr(0) & "','" & dr(1) & "','" & dr(2) & "','" & dr(3) & "','" & dr(4) & "','" & dr(5) & "')"
            fnExecuteNonQuery(strSQL, objTrans)
        Next
        Return True

    End Function

    Private Function fnGetGoldLoanCust() As Boolean

        strSQL = "select * from "

    End Function

    Public Function fnCheckGoldAccount(ByVal strGLNo As String) As Boolean

        strSQL = "SELECT * FROM loandetailstbl WHERE LoanNo='" & strGLNo & "'"

        _dtSBdetailsTable = fnExecuteQuery(strSQL, 2)

        If _dtSBdetailsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnGetSBAccountTable() As Boolean

        strSQL = "SELECT S.AccountNo,P.Name FROM sbDetailsTbl S, PersonTbl P WHERE S.PersonNo=P.PersonNo"

        _dtSBdetailsTable = fnExecuteQuery(strSQL, 2)

        If _dtSBdetailsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnGetGLAccountDetails(ByVal strGLNo As String) As Boolean

        strSQL = "SELECT P.*, g.*, a.* FROM Loandetailstbl g, PersonTbl P, goldloandetailstbl a  WHERE P.PersonNo=g.PersonNo  and g.LoanNo='" & strGLNo & "' AND  g.loanno = a.goldloanno"

        _dtGoldLoan = fnExecuteQuery(strSQL, 2)

        If _dtGoldLoan.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetGoldDetails(ByVal strGLNo As String) As Boolean

        strSQL = "select d.* from golddetailstbl d , goldloandetailstbl g where d.goldloanNo = g.goldLoanNo and g.GoldLoanNo = '" & strGLNo & "'"

        _dtGoldItemDetails = fnExecuteQuery(strSQL, 2)

        If _dtGoldItemDetails.Rows.Count > 0 Then
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


    Public Function fnCloseSBAccount() As Boolean


    End Function


    Public Function fnUpdateSBAccount() As Boolean

        If fnUpdatePerson() Then

            strSQL = "UPDATE SbdetailsTbl SET AccType='" & _chrAccType & "',opmode='" & _chrOpMode & "',Accstatus ='" & _chrAccStatus & "' , Remarks='" & _strRemarks & "',Photo_Id ='" & _chrPhotoID & "' ,Address_Id='" & _chrAddrID & "'  WHERE AccountNo='" & _strSBNo & "'"

            Return fnExecuteNonQuery(strSQL)

        Else
            Return False
        End If
    End Function


    Public Function fnUpdateGLAccount(ByVal strGLno As String, ByVal objTrans As IDbTransaction) As Boolean

        If fnUpdatePerson() Then

            strSQL = "UPDATE loandetailsTbl SET CustomerID = '" & _strMemberNo & "',personNo = '" & PersonNo & "', sbno = '" & _strSBNo & "',LoanType='" & _chrLoanType & "', expAmount='" & _intExpectedAmount & "', sancamount='" & _intSanctionedAmount & "',ApplDate = '" & Format(_datGoldDate, "yyyy-MM-dd") & "',SancDate='" & Format(_datSancDate, "yyyy-MM-dd") & "',DueDate = '" & Format(_datDueDate, "yyyy-MM-dd") & "',SancNo='" & _dblSancNo & "'  , ROI='" & _dblROI & "',NOI = '" & _intNOI & "',InstPrinciple = '" & _intInstPrinciple & "',RepayMode  ='" & _strModeOfPayment & "',Purpose ='" & _strReason & "', Type='" & _strInstallment & "',Remarks = '" & _strRemarks & "'   WHERE  LoanNo='" & strGLno & "'"

            Return fnExecuteNonQuery(strSQL, objTrans)

        Else
            Return False
        End If
    End Function

    Public Function fnUpdateGLWitnessDet(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = " update goldloanDetailstbl set personNo = '" & PersonNo & "', GoldAmount = '" & _intGoldAmt & "',InstallmentType = '" & _strInstallment & "',MobileNo2='" & _strMobileNo2 & "' where goldloanNo = '" & _strGoldNo & "'"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function


    Public Function fnDeleteGLItemsAccount(ByVal strGLno As String, ByVal objTrans As IDbTransaction) As Boolean
        Dim dr As DataRow

        For Each dr In _dtGoldDetailsTable.Rows
            strSQL = "delete  from golddetailstbl wHERE  GoldLoanNo='" & strGLno & "'"
            fnExecuteNonQuery(strSQL, objTrans)
        Next
        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnSBInsertCheckBookDetails() As Boolean
        Dim intCounter As Integer = _intStartNo

        For intCounter = _intStartNo To _intEndno - 1

            strSQL = "INSERT INTO sbchequebooktbl(AccountNo,BookNo,ChequeNo,IssueDate,chkStatus)"
            strSQL = strSQL & " VALUES('" & _strSBNo & "','" & _strBookNo & "','" & intCounter & "','" & Format(_datChkBookDate, "yyyy-MM-dd") & "','" & _chrChkstatus & "')"

            fnExecuteNonQuery(strSQL)
        Next

        Return True

    End Function


    Public Function fnGetSBCheckBookDetails() As Boolean

        'strSQL = "SELECT S.AccountNo,P.Name FROM sbDetailsTbl S, PersonTbl P WHERE S.PersonNo=P.PersonNo"
        strSQL = "SELECT AccountNo,BookNo,Issuedate,ChequeNo as StartNo,Max(ChequeNo) as EndNo,chkStatus FROM sbchequebooktbl WHERE AccountNo='" & _strSBNo & "' and chkstatus='P' Group by bookno"


        _dtSBCheckBookTable = fnExecuteQuery(strSQL, 2)

        If _dtSBCheckBookTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnGetChecks(ByVal strChequeNo As String) As Boolean

        'strSQL = "SELECT S.AccountNo,P.Name FROM sbDetailsTbl S, PersonTbl P WHERE S.PersonNo=P.PersonNo"
        strSQL = "select cb.accountno,cb.chequeno,P.Name,P.Photo,P.Signature,sb.Balance from sbchequebooktbl cb,sbdetailstbl sb,persontbl P where cb.accountno=sb.accountno and sb.personno=p.personno and cb.chequeNo='" & strChequeNo & "' and cb.chkStatus='P'"

        _dtSBCheckBookTable = fnExecuteQuery(strSQL, 2)

        If _dtSBCheckBookTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

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

        strSQL = "select * from sbtransactiontbl where Accountno='" & _strSBNo & "'"

        _dtSBTransDetailTable = fnExecuteQuery(strSQL, 2)

        Return True
    End Function


    Function fnAddDepositedCheque() As Boolean

        strSQL = "Insert into sbChequeDeposittbl(AccountNo,BankName,BranchName,Chequedate,ChequeNo,Depositdate,ChequeAmount,BankCharges,ChequeStatus,Remarks)"
        strSQL = strSQL & " Values( '" & _strSBNo & "','" & _strBankName & "','" & _strBranchName & "','" & Format(_datChequeDate, "yyyy-MM-dd") & "','" & _strChequeNo & "','" & Format(_datChequeDepositDate, "yyyy-MM-dd") & "','" & _dblChequeAmount & "','" & _dblBankCharges & "','" & _strChequeStatus & "','" & _strRemarks & "')"

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

    
   
    Public Function fnGetNewLoanNo(ByVal str As String) As String

        strSQL = " SELECT max(LoanNo) as MaxNo FROM loandetailstbl where LoanNo like '" & str & "%' "

        _dtSBdetailsTable = fnExecuteQuery(strSQL, 2)

        If IsDBNull(_dtSBdetailsTable.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return _dtSBdetailsTable.Rows(0).Item("MaxNo")
        End If

    End Function

    Public Function fnGetNewODNo(ByVal str As String) As String

        strSQL = " SELECT max(AccountNo) as MaxNo FROM oddetailstbl where AccountNo like '" & str & "%' "

        _dtSBdetailsTable = fnExecuteQuery(strSQL, 2)

        If IsDBNull(_dtSBdetailsTable.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return _dtSBdetailsTable.Rows(0).Item("MaxNo")
        End If

    End Function
    Public Function fnGetNewSMTLNo(ByVal str As String) As String

        strSQL = " SELECT max(AccountNo) as MaxNo FROM smtldetailstbl where AccountNo like '" & str & "%' "

        _dtSBdetailsTable = fnExecuteQuery(strSQL, 2)

        If IsDBNull(_dtSBdetailsTable.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return _dtSBdetailsTable.Rows(0).Item("MaxNo")
        End If

    End Function


    Public Function fnGetROI(ByVal strLoan As String, ByVal dblSancAmount As Double) As Boolean

        Dim strLno As String
        Dim strLoanType As String

        strLno = Mid(strLoan, 1, 2)

        Select Case strLno

            Case "JL"
                strLoanType = "Jewel Loan"

            Case "LM"
                strLoanType = "Vehicle Loan"

            Case "LT"
                strLoanType = "Loans On Term Deposit"

            Case "CH"
                strLoanType = "Colleteral Hand Loan"

            Case "HL"
                strLoanType = "Hand Loan"

            Case "SL"
                strLoanType = "Surety Loan"

            Case "OD"
                strLoanType = "Over Draft"

            Case "SD"
                strLoanType = "Souharda Daily Recovery Laon"

            Case "CB"
                strLoanType = "Clearing Bill Purchase"

        End Select

        'strSQL = "select * from loanInteresttbl where LoanType = '" & strLoanType & "'"
        strSQL = " select LT.PI ,LI.ROI from loanInteresttbl LI ,loantypetbl LT where   LI.fromAmt <='" & dblSancAmount & "' and LI.ToAmt >='" & dblSancAmount & "'and LT.LoanSlNo=LI.LoanSlNo and LT.LoanType='" & strLoanType & "'"

        Loantypetable = fnExecuteQuery(strSQL, 2)

        If Loantypetable.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

#End Region

End Class
