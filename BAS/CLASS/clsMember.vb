Public Class clsMember
    Inherits clsPerson

#Region "Variables"

    Private _strMemberNo As String
    Private _strSBNo As String
    Private _datApplDate As Date
    Private _chrType As String
    Private _datOpenDate As Date
    Private _intNoOfShares As Integer
    Private _dblShareAmount As Double
    Private _dblEntryFee As Double
    Private _dblBuildingFee As Double
    Private _dblAmountPaid As Double
    Private _strRefNo As String
    Private _datClosingDate As Date
    Private _chrIDCard As Char
    Private _strStatus As String
    Private _strRemarks As String
    Private _dblSalary As Double
    Private _dblOtherIncome As Double
    Private _strIntroMBNo1 As String
    Private _strIntroMBNo2 As String
    Private _strApplicantOtherSugestions As String
    Private _strOtherEducationSociety As String
    Private _dblBalanceAmount As Double
    Private _lngVoucherNo As Long
    Private _datShareDate As Date
    Private _dblShareFee As Double
    Private _dblApplicationFee As Double
    Private _dtSharesTable As DataTable
    Private _strChequeNo As String
    Private _dtMemberTable As DataTable
    Private _strBankName As String
    Private _strBranchName As String
    'Private _dtmemberNo As DataTable


    'Close Membership

    Private _dtCloseMemDet As DataTable
    Private _ClosingDate As Date

#End Region
    Public UpdateAmount As Decimal
    Public VoucherNo1 As Integer
    Public VoucherDate As Date

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

    Public Property ApplDate() As Date
        Get
            Return _datApplDate
        End Get
        Set(ByVal Value As Date)
            _datApplDate = Value
        End Set
    End Property

    Public Property Type() As String
        Get
            Return _chrType
        End Get
        Set(ByVal Value As String)
            _chrType = Value
        End Set
    End Property

    Public Property OpenDate() As Date
        Get
            Return _datOpenDate
        End Get
        Set(ByVal Value As Date)
            _datOpenDate = Value
            _datShareDate = Value
        End Set
    End Property

    Public Property NoOfShares() As Integer
        Get
            Return _intNoOfShares
        End Get
        Set(ByVal Value As Integer)
            _intNoOfShares = Value
        End Set
    End Property

    Public Property ShareAmount() As Double
        Get
            Return _dblShareAmount
        End Get
        Set(ByVal Value As Double)
            _dblShareAmount = Value
        End Set
    End Property
    Public Property AmountPaid() As Double
        Get
            Return _dblAmountPaid
        End Get
        Set(ByVal Value As Double)
            _dblAmountPaid = Value
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
    Public Property ChequeNo() As String
        Get
            Return _strChequeNo
        End Get
        Set(ByVal Value As String)
            _strChequeNo = Value
        End Set
    End Property

    Public Property ClosingDate() As Date
        Get
            Return _datClosingDate
        End Get
        Set(ByVal Value As Date)
            _datClosingDate = Value
        End Set
    End Property

    Public Property IDCard() As Char
        Get
            Return _chrIDCard
        End Get
        Set(ByVal Value As Char)
            _chrIDCard = Value
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

    Public Property Remarks() As String
        Get
            Return _strRemarks
        End Get
        Set(ByVal Value As String)
            _strRemarks = Value
        End Set
    End Property
    Public Property Salary() As Double
        Get
            Return _dblSalary
        End Get
        Set(ByVal Value As Double)
            _dblSalary = Value
        End Set
    End Property
    Public Property OtherIncome() As Double
        Get
            Return _dblOtherIncome
        End Get
        Set(ByVal Value As Double)
            _dblOtherIncome = Value
        End Set
    End Property
    Public Property IntroMBNo1() As String
        Get
            Return _strIntroMBNo1
        End Get
        Set(ByVal Value As String)
            _strIntroMBNo1 = Value
        End Set
    End Property
    Public Property IntroMBNo2() As String
        Get
            Return _strIntroMBNo2
        End Get
        Set(ByVal Value As String)
            _strIntroMBNo2 = Value
        End Set
    End Property
    Public Property ApplicantOtherSugestions() As String
        Get
            Return _strApplicantOtherSugestions
        End Get
        Set(ByVal Value As String)
            _strApplicantOtherSugestions = Value
        End Set
    End Property
    Public Property OtherEducationSociety() As String
        Get
            Return _strOtherEducationSociety
        End Get
        Set(ByVal Value As String)
            _strOtherEducationSociety = Value
        End Set
    End Property


    Public Property ShareFee() As Double
        Get
            Return _dblShareFee
        End Get
        Set(ByVal Value As Double)
            _dblShareFee = Value
        End Set
    End Property
    Public Property ApplicationFee() As Double
        Get
            Return _dblApplicationFee
        End Get
        Set(ByVal Value As Double)
            _dblApplicationFee = Value
        End Set
    End Property
    Public Property BuildingFee() As Double
        Get
            Return _dblBuildingFee
        End Get
        Set(ByVal Value As Double)
            _dblBuildingFee = Value
        End Set
    End Property
    Public Property BalanceAmount() As Double
        Get
            Return _dblBalanceAmount
        End Get
        Set(ByVal Value As Double)
            _dblBalanceAmount = Value
        End Set
    End Property
    Public Property EntryFee() As Double
        Get
            Return _dblEntryFee
        End Get
        Set(ByVal Value As Double)
            _dblEntryFee = Value
        End Set
    End Property

    Public Property ShareDate() As Date
        Get
            Return _datShareDate
        End Get
        Set(ByVal Value As Date)
            _datShareDate = Value
        End Set
    End Property


    Public Property VoucherNo() As Long
        Get
            Return _lngVoucherNo
        End Get
        Set(ByVal Value As Long)
            _lngVoucherNo = Value
        End Set
    End Property


    Public Property SharesTable() As DataTable
        Get
            Return _dtSharesTable
        End Get
        Set(ByVal Value As DataTable)
            _dtSharesTable = Value
        End Set
    End Property

    Public Property MemberTable() As DataTable
        Get
            Return _dtMemberTable
        End Get
        Set(ByVal Value As DataTable)
            _dtMemberTable = Value
        End Set
    End Property


    Public Property CloseMemberDet() As DataTable
        Get
            Return _dtCloseMemDet
        End Get
        Set(ByVal Value As DataTable)
            _dtCloseMemDet = Value
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

#End Region


#Region "Functions"


#Region "Member Related Functions"

    Public Function fnAddMember(ByVal objTrans As IDbTransaction) As Boolean

        If fnCheckPerson() Then
            If fnUpdatePerson(objTrans) Then
                If fnInsertMember(objTrans) Then
                    Return fnRemitShares(objTrans)
                End If
            End If
        Else
            If fnAddPerson(objTrans) Then
                If fnInsertMember(objTrans) Then
                    Return fnRemitShares(objTrans)
                Else
                    fnDeletePerson(objTrans)
                End If
            End If
        End If

        Return False

    End Function

#Region "Without transaction"

    Public Overloads Function fnRemitShares() As Boolean

        strSQL = "INSERT INTO SharesTbl VALUES('" & _strMemberNo & "','" & Format(_datShareDate, "yyyy-MM-dd") & "','" & _intNoOfShares & "','" & _dblShareAmount & "','" & _dblShareFee & "','" & _strRefNo & "','Remit','" & _lngVoucherNo & "')"

        If fnExecuteNonQuery(strSQL) Then
            strSQL = "UPDATE MemberTbl SET NoOfShares=NoOfShares+" & _intNoOfShares & ", ShareAmount=ShareAmount+" & _dblShareAmount & " ,ShareFee=ShareFee+" & _dblShareFee & " WHERE MemberNo='" & _strMemberNo & "'"

            Return fnExecuteNonQuery(strSQL)
        End If

    End Function

#End Region

    Private Function fnInsertMember(ByVal objTrans As IDbTransaction) As Boolean

        'strSQL = "INSERT INTO MemberTbl(MemberNo,PersonNo,CustomerID,ApplDate,Type,OpenDate,NoOfShares,ShareAmount,EntryFee,ShareFee,BuildingFee,ReceiptNo,IDCard,Status,Remarks,Salary,OtherIncome,IntroNo)"
        'strSQL = strSQL & " VALUES('" & _strMemberNo & "','" & PersonNo & "','" & CustomerID & "','" & Format(_datApplDate, "yyyy-MM-dd") & "','" & _
        ' _chrType & "','" & Format(_datOpenDate, "yyyy-MM-dd") & "',0,0,'" & _dblEntryFee & "','" & _dblShareFee & "','" & _dblBuildingFee & "','" & _
        ' _strRefNo & "','" & _chrIDCard & "','" & _strStatus & "','" & _strRemarks & "','" & _dblSalary & "','" & _dblOtherIncome & "','" & _strIntroMBNo1 & "')"

        strSQL = "INSERT INTO MemberTbl(MemberNo,PersonNo,ApplDate,Type,OpenDate,NoOfShares,ShareAmount,EntryFee,ShareFee,BuildingFee,ReceiptNo,IDCard,Status,Remarks,Salary,OtherIncome,IntroNo1,IntroNo2,ApplicantOtherSugestions,MemToOtherEduSociety,ApplicationFee,CallsInArrier)"
        strSQL = strSQL & " VALUES('" & _strMemberNo & "','" & PersonNo & "','" & Format(_datApplDate, "yyyy-MM-dd") & "','" & _
         _chrType & "','" & Format(_datOpenDate, "yyyy-MM-dd") & "',0,0,'" & _dblEntryFee & "','" & _dblShareFee & "','" & _dblBuildingFee & "','" & _
         _strRefNo & "','" & _chrIDCard & "','" & _strStatus & "','" & _strRemarks & "','" & _dblSalary & "','" & _dblOtherIncome & "','" & _strIntroMBNo1 & "','" & _strIntroMBNo2 & "','" & _strApplicantOtherSugestions & "','" & _strOtherEducationSociety & "','" & _dblApplicationFee & "','" & _dblBalanceAmount & "')" '& _dblShareAmount & "')"
        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function


    Public Function fnCheckMember() As Boolean

        strSQL = "SELECT * FROM MemberTbl WHERE MemberNo='" & _strMemberNo & "'"

        _dtMemberTable = fnExecuteQuery(strSQL, 2)

        If _dtMemberTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetMembersTable() As Boolean

        strSQL = "SELECT M.*, P.* FROM MemberTbl M, PersonTbl P WHERE M.PersonNo=P.PersonNo AND M.STATUS = 'Active'"

        _dtMemberTable = fnExecuteQuery(strSQL, 2)

        If _dtMemberTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetMembersTableForPrintingAll() As Boolean

        strSQL = "SELECT M.memberno, P.name FROM MemberTbl M, PersonTbl P WHERE M.PersonNo=P.PersonNo"

        _dtMemberTable = fnExecuteQuery(strSQL, 2)

        If _dtMemberTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnFetchMemberTable() As Boolean
        strSQL = "SELECT * MemberTbl"

        _dtMemberTable = fnExecuteQuery(strSQL, 2)

        If _dtMemberTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnGetMembersTableForEmailAll() As Boolean

        strSQL = "select m.memberno,p.name,p.emailid from membertbl m,persontbl p where p.personno=m.personno and  p.emailid REGEXP '[-a-z0-9~!$%^&*_=+}{\\\'?]+(\\.[-a-z0-9~!$%^&*_=+}{\\\'?]+)*@([a-z0-9_][-a-z0-9_]*(\\.[-a-z0-9_]+)*\\.(aero|arpa|biz|com|coop|edu|gov|info|int|mil|museum|name|net|org|pro|travel|mobi|[a-z][a-z])|([0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}))(:[0-9]{1,5})?'"

        _dtMemberTable = fnExecuteQuery(strSQL, 2)

        If _dtMemberTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetMembersTableForEmailActive() As Boolean
        strSQL = "select m.memberno,p.name,p.emailid from membertbl m,persontbl p where p.personno=m.personno and   M.STATUS = 'Active' and  p.emailid REGEXP '[-a-z0-9~!$%^&*_=+}{\\\'?]+(\\.[-a-z0-9~!$%^&*_=+}{\\\'?]+)*@([a-z0-9_][-a-z0-9_]*(\\.[-a-z0-9_]+)*\\.(aero|arpa|biz|com|coop|edu|gov|info|int|mil|museum|name|net|org|pro|travel|mobi|[a-z][a-z])|([0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}))(:[0-9]{1,5})?'"
        _dtMemberTable = fnExecuteQuery(strSQL, 2)

        If _dtMemberTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetMembersTableForEmailInActive() As Boolean
        strSQL = "select m.memberno,p.name,p.emailid from membertbl m,persontbl p where p.personno=m.personno and   M.STATUS = 'Close' and  p.emailid REGEXP '[-a-z0-9~!$%^&*_=+}{\\\'?]+(\\.[-a-z0-9~!$%^&*_=+}{\\\'?]+)*@([a-z0-9_][-a-z0-9_]*(\\.[-a-z0-9_]+)*\\.(aero|arpa|biz|com|coop|edu|gov|info|int|mil|museum|name|net|org|pro|travel|mobi|[a-z][a-z])|([0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}))(:[0-9]{1,5})?'"
        _dtMemberTable = fnExecuteQuery(strSQL, 2)

        If _dtMemberTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetMembersTableForPrintingActive() As Boolean

        strSQL = "SELECT M.memberno, P.name FROM MemberTbl M, PersonTbl P WHERE M.PersonNo=P.PersonNo AND M.STATUS = 'Active'"

        _dtMemberTable = fnExecuteQuery(strSQL, 2)

        If _dtMemberTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetMembersTableForPrintingInActive() As Boolean

        strSQL = "SELECT M.memberno, P.name FROM MemberTbl M, PersonTbl P WHERE M.PersonNo=P.PersonNo AND M.STATUS = 'Close'"

        _dtMemberTable = fnExecuteQuery(strSQL, 2)

        If _dtMemberTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetMemberDetails(ByVal MemberNo As String) As Boolean

        strSQL = "SELECT P.*, M.* from membertbl M,persontbl P  WHERE M.MemberNo = '" & MemberNo & "' and P.PersonNo=M.PersonNo "

        _dtMemberTable = fnExecuteQuery(strSQL, 2)

        If _dtMemberTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetMemberTransaction(ByVal MemberNo As String) As Boolean

        strSQL = "SELECT  M.* from membertransaction M WHERE M.AccountNo = '" & MemberNo & "'"

        _dtMemberTable = fnExecuteQuery(strSQL, 2)

        If _dtMemberTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnLoadCloseMember(ByVal strMemberNo As String) As Boolean

        strSQL = "SELECT P.Name,M.MemberNo,M.Appldate,M.OpenDate,M.NoOfShares,M.Sbno,M.Type,M.ShareAmount,M.Status FROM PERSONTBL P, MEMBERTBL M WHERE P.PERSONNO= M.PERSONNO and M.MemberNo = '" & strMemberNo & "'"

        _dtCloseMemDet = fnExecuteQuery(strSQL, 2)

        If _dtCloseMemDet.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnCloseMembera(ByVal strMemberNo As String, ByVal datClosingDate As Date, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Update Membertbl set Status = 'Closed', ClosingDate = '" & Format(datClosingDate, "yyyy-MM-dd") & "',ShareAmount = '0', NoOfShares = '0' where MemberNo = '" & strMemberNo & "'"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnUpdateMember(ByVal objTrans As IDbTransaction) As Boolean

        If fnUpdatePerson(objTrans) Then

            strSQL = "UPDATE MemberTbl SET IDCard='" & _chrIDCard & "', Remarks='" & _strRemarks & "',Status='" & _strStatus & "',IntroNo1='" & _strIntroMBNo1 & "',IntroNo2='" & _strIntroMBNo2 & "'  WHERE MemberNo='" & _strMemberNo & "'"

            Return fnExecuteNonQuery(strSQL, objTrans)

        Else
            Return False
        End If
    End Function

    Public Function fnGetMember() As Boolean

        strSQL = "SELECT M.MemberNo,P.Name FROM membertbl M, PersonTbl P WHERE M.PersonNo=P.PersonNo and M.Status = 'Active'"

        _dtMemberTable = fnExecuteQuery(strSQL, 2)

        If _dtMemberTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function



    Public Function fnGetNewMembershipNo() As String

        strSQL = "SELECT max(MemberNo) as MaxNo FROM MemberTbl "

        _dtMemberTable = fnExecuteQuery(strSQL, 2)

        If IsDBNull(_dtMemberTable.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return _dtMemberTable.Rows(0).Item("MaxNo")
        End If

    End Function

#End Region


#Region "Shares Related Functions"

    Public Function fnGetShareTransaction(ByVal MemberNo As String) As Boolean

        strSQL = "SELECT * FROM SharesTbl WHERE MemberNo='" & MemberNo & "' ORDER BY ShareDate ASC"

        _dtSharesTable = fnExecuteQuery(strSQL, 2)

        If _dtSharesTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Overloads Function fnRemitShares(ByVal objTrans As IDbTransaction) As Boolean
         strSQL = "INSERT INTO SharesTbl VALUES('" & _strMemberNo & "','" & Format(_datShareDate, "yyyy-MM-dd") & "','" & _intNoOfShares & "','" & _dblShareAmount & "','" & _dblShareFee & "','" & _strRefNo & "','Remit','" & _lngVoucherNo & "')"
        If fnExecuteNonQuery(strSQL) Then
            Dim Deposit As Decimal = _dblAmountPaid - _dblShareFee - _dblEntryFee - _dblApplicationFee - _dblBuildingFee
            Dim bal As String = "Balance Amount"
            strSQL = "INSERT INTO membertransaction VALUES('" & _strMemberNo & "','" & Format(_datShareDate, "yyyy-MM-dd") & "','" & bal & "','" & Deposit & "','0','" & Deposit & "','" & _strRefNo & "','" & _lngVoucherNo & "','2','" & _strChequeNo & "','" & _strBankName & "','" & _strBranchName & "')"
            fnExecuteNonQuery(strSQL, objTrans)

            strSQL = "UPDATE MemberTbl SET NoOfShares=NoOfShares+" & _intNoOfShares & ", ShareAmount=ShareAmount+" & _dblShareAmount & " ,ShareFee=ShareFee+" & _dblShareFee & " WHERE MemberNo='" & _strMemberNo & "'"
            Return fnExecuteNonQuery(strSQL, objTrans)
        End If

    End Function
    Public Function fnInsertToMemberTransactionTbl(ByVal objTrans As IDbTransaction) As Boolean
        Dim Deposit As Decimal = _dblAmountPaid - _dblShareFee - _dblEntryFee - _dblApplicationFee - _dblBuildingFee
        Dim strSQL = "INSERT INTO membertransaction(AccountNo,TrDate,Narration,Deposit,Withdraw,Balance,RefNo,VoucherNo,Type,ChequeNo,BankName,BranchName)"
        strSQL = strSQL & "(select'" & _strMemberNo & "','" & Format(_datShareDate, "yyyy-MM-dd") & "','" & _strRemarks & "','" & Deposit & "','0',sum(Deposit)-sum(Withdraw) + '" & Deposit & "','" & _strRefNo & "','" & _lngVoucherNo & "','2','" & _strChequeNo & "','" & _strBankName & "','" & _strBranchName & "' from membertransaction where AccountNo='" & _strMemberNo & "' group by AccountNo)"

        'Dim strSQL = "INSERT INTO membertransaction(AccountNo,TrDate,Deposit,Withdraw,Balance)"
        'strSQL = strSQL & "select ('" & _strMemberNo & "','" & Format(_datShareDate, "yyyy-MM-dd") & "','" & Deposit & "','0','sum(Deposit)-sum(Withdraw)+ " & Deposit & "' from membertransaction where AccountNo='" & _strMemberNo & "' group by AccountNo)"

        Return fnExecuteNonQuery(strSQL, objTrans)
    End Function

    Public Function fnRefundShares(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "INSERT INTO SharesTbl VALUES('" & _strMemberNo & "','" & Format(_datShareDate, "yyyy-MM-dd") & "','" & _intNoOfShares & "','" & _dblShareAmount & "','" & _dblShareFee & "','" & _strRefNo & "','Refund','" & _lngVoucherNo & "')"

        If fnExecuteNonQuery(strSQL, objTrans) Then
            strSQL = "UPDATE MemberTbl SET NoOfShares=NoOfShares-" & _intNoOfShares & ", ShareAmount=ShareAmount-" & _dblShareAmount & " WHERE MemberNo='" & _strMemberNo & "'"

            Return fnExecuteNonQuery(strSQL, objTrans)
        End If

    End Function

    Public Function fnGetShareConfig() As Boolean
        strSQL = "SELECT * FROM SharesconfigTbl where ShareType='" & _chrType & "'"

        _dtSharesTable = fnExecuteQuery(strSQL, 2)
        If _dtSharesTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fnDeleteMemberLabelPrint() As Boolean
        strSQL = "Delete from MemberLabelPrint"
        If fnExecuteNonQuery(strSQL) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnInsertMemberLabelPrint(ByVal memberno) As Boolean

        strSQL = "insert into MemberLabelPrint select m.Memberno ,p.name,p.presaddress,concat_ws(',', p.phoneno , p.mobileno )as phoneno from membertbl m ,persontbl p where m.personno=p.personno and m.MemberNo='" & memberno & "'"

        _dtMemberTable = fnExecuteQuery(strSQL, 2)

        If _dtMemberTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnUpdateMemberOnDelete(ByVal objTrans As IDbTransaction) As Boolean
        strSQL = "Update membertbl set CallsInArrier='" & UpdateAmount & "' where MemberNo='" & MemberNo & "'"
        If fnExecuteNonQuery(strSQL, objTrans) Then
            strSQL = "Delete from membertransaction where VoucherNo='" & VoucherNo1 & "' and TrDate='" & Format(VoucherDate, "yyyy-MM-dd") & "'"
            Return fnExecuteNonQuery(strSQL, objTrans)
        End If
    End Function

    Public Function fnDeleteMemberTransaction(ByVal objTrans As IDbTransaction) As Boolean
        strSQL = "Delete from membertransaction where VoucherNo='" & VoucherNo1 & "' and TrDate='" & VoucherDate & "'"
        Return fnExecuteNonQuery(strSQL, objTrans)
    End Function

#End Region


#End Region

End Class
