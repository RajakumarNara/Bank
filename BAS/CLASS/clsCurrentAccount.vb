Public Class clsCurrentAccount
    Inherits clsOrganizationDetail

#Region "Variable"
    Private _strCurAccouontNo As String
    'it comes in OrgDetail  Private _intOrganizationNO As Integer
    Private _datAccDate As Date
    Private _strCustomerID As String
    Private _dblAccBal As Double
    Private _dblODAmount As Double
    Private _chrAccStatus As Char
    Private _chrAccType As Char
    Private _chrOpMOde As Char
    Private _datClosingDate As Date
    Private _intMandatSignatory As String
    Private _intFirstAuxSign As String
    Private _intSecondAuxSign As String
    Private _strRemarks As String
    Private _strReciptNo As String
    Private _chrAddrId As Char
    Private _chrPhotoId As Char
    Private _chrOdFacility As Char
    Private _chrOrgannization As Char
    Private _chrIndividual As Char
    Private _chrCAType As Char
    Private _strMemberNo As String

    Private _dtCATransDetailTable As DataTable
    Private _dtChequedetailsTable As DataTable
    Private _dtCAdetailsTable As DataTable
    Private _dtCAInfo As DataTable
    Private _dtCAMaster As DataTable
    Private _datAccountDetails As DataTable
    Private _dtMaxDate As DataTable
    Private _dtMaxNextDate As DataTable

    ' CA chequebook detail

    Private _strBookNo As String
    Private _lngStartNo As Long
    Private _lngEndNo As Long
    Private _datChkBookDate As Date
    Private _chrChkstatus As Char
    Private _dtCACheckBookTable As DataTable

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
    Private _dtAccountNos As DataTable
    Private _dtCrtBalance As DataTable

    'CA Closure
    Private _datIntDet As DataTable

    'Interest Calculation
    Private _dblIntAmt As Double
    Private _datFromPeriod As Date
    Private _datToPeriod As Date

    'CA Cheque Stop Pay

    Private _dtChqStopPayDt As DataTable


#End Region

#Region " propertyes"
    Public Property CurAccountNo() As String
        Get
            Return _strCurAccouontNo
        End Get
        Set(ByVal Value As String)
            _strCurAccouontNo = Value
        End Set
    End Property
    Public Property memberNo() As String
        Get
            Return _strMemberNo
        End Get
        Set(ByVal Value As String)
            _strMemberNo = Value
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
    Public Property CrtBalance() As DataTable
        Get
            Return _dtCrtBalance
        End Get
        Set(ByVal Value As DataTable)
            _dtCrtBalance = Value
        End Set
    End Property
    Public Property Accdate() As Date
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
    Public Property ODAMount() As Double
        Get
            Return _dblODAmount
        End Get
        Set(ByVal Value As Double)
            _dblODAmount = Value
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
            Return _chrOpMOde
        End Get
        Set(ByVal Value As Char)
            _chrOpMOde = Value
        End Set
    End Property

    Public Property CAType() As Char
        Get
            Return _chrCAType
        End Get
        Set(ByVal Value As Char)
            _chrCAType = Value
        End Set
    End Property
    Public Property ChkIndividual() As Char
        Get
            Return _chrIndividual
        End Get
        Set(ByVal Value As Char)
            _chrIndividual = Value
        End Set
    End Property
    Public Property ManDtaSignature() As String
        Get
            Return _intMandatSignatory
        End Get
        Set(ByVal Value As String)
            _intMandatSignatory = Value
        End Set
    End Property
    Public Property FirstAuxSignature() As String
        Get
            Return _intFirstAuxSign
        End Get
        Set(ByVal Value As String)
            _intFirstAuxSign = Value
        End Set
    End Property
    Public Property SecodAuxSignature() As String
        Get
            Return _intSecondAuxSign
        End Get
        Set(ByVal Value As String)
            _intSecondAuxSign = Value
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

    Public Property Receipts() As String
        Get
            Return _strReciptNo
        End Get
        Set(ByVal Value As String)
            _strReciptNo = Value
        End Set
    End Property
    Public Property AddressID() As Char
        Get
            Return _chrAddrId
        End Get
        Set(ByVal Value As Char)
            _chrAddrId = Value
        End Set
    End Property
    Public Property PhotoID() As Char
        Get
            Return _chrPhotoId
        End Get
        Set(ByVal Value As Char)
            _chrPhotoId = Value
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
    Public Property ODFacility() As Char
        Get
            Return _chrOdFacility
        End Get
        Set(ByVal Value As Char)
            _chrOdFacility = Value
        End Set
    End Property

    Public Property CAAccTable() As DataTable
        Get
            Return _dtCAdetailsTable
        End Get
        Set(ByVal Value As DataTable)
            _dtCAdetailsTable = Value
        End Set
    End Property
    Public Property MaxDate() As DataTable
        Get
            Return _dtMaxDate
        End Get
        Set(ByVal Value As DataTable)
            _dtMaxDate = Value
        End Set
    End Property
    Public Property MaxNextDate() As DataTable
        Get
            Return _dtMaxNextDate
        End Get
        Set(ByVal Value As DataTable)
            _dtMaxNextDate = Value
        End Set
    End Property
    Public Property CAInfoTable() As DataTable
        Get
            Return _dtCAInfo
        End Get
        Set(ByVal Value As DataTable)
            _dtCAInfo = Value
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

    Public Property CACheckBookBookTable() As DataTable
        Get
            Return _dtCACheckBookTable
        End Get
        Set(ByVal Value As DataTable)
            _dtCACheckBookTable = Value
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
    Public Property CATransDetailTable() As DataTable
        Get
            Return _dtCATransDetailTable
        End Get
        Set(ByVal Value As DataTable)
            _dtCATransDetailTable = Value
        End Set
    End Property
    Public Property CAMasterTable() As DataTable
        Get
            Return _dtCAMaster
        End Get
        Set(ByVal Value As DataTable)
            _dtCAMaster = Value
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

    Public Property InterestDettable() As DataTable
        Get
            Return _datIntDet
        End Get
        Set(ByVal Value As DataTable)
            _datIntDet = Value
        End Set
    End Property

    Public Property AccountNos() As DataTable
        Get
            Return _dtAccountNos
        End Get
        Set(ByVal Value As DataTable)
            _dtAccountNos = Value
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

#Region "function"

    Public Function fnCheckCAccount(ByVal strCANo As String) As Boolean

        strSQL = "SELECT * FROM CADetailTbl WHERE CAccountNo='" & strCANo & "'"

        _dtCAdetailsTable = fnExecuteQuery(strSQL, 2)

        If _dtCAdetailsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetCA() As Boolean

        strSQL = "SELECT * FROM  CADetailTbl WHERE AccStatus='A'"

        _dtCAdetailsTable = fnExecuteQuery(strSQL, 2)

        If _dtCAdetailsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnAddCAccount(ByVal objTrans As IDbTransaction) As Boolean

        If CAType = "O" Then
            If fnCheckOrganization() Then
                If fnUpdateOrganization(objTrans) Then
                    Return fnInsertCAccount(objTrans)
                End If
            Else
                If fnAddOrganization(objTrans) Then
                    If fnInsertCAccount(objTrans) Then
                        Return True
                    Else
                        fnDeleteOrganization()
                    End If
                End If
            End If
        ElseIf CAType = "I" Then

            If fnCheckPerson() Then
                If fnUpdatePerson() Then
                    Return fnInsertCAccount(objTrans)
                End If
            Else
                If fnAddPerson() Then
                    If fnInsertCAccount(objTrans) Then
                        Return True
                    Else
                        fnDeletePerson(objTrans)
                    End If
                End If
            End If
            Return False
        End If
    End Function
    Private Function fnInsertCAccount(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "INSERT INTO CADetailTbl(CAccountNo,CAType,OrgNo,CustomerID,PersonNo,AccDate,IntAmount,AccType,OpMode,AccStatus,Remarks,Address_Id,Photo_Id,ODFacility,ReciptNo,ODLimit,LastPaidDate)"
        strSQL = strSQL & " VALUES('" & _strCurAccouontNo & "','" & _chrCAType & "','" & OrganizationNo & "','" & _strCustomerID & "','" & PersonNo & "','" & Format(_datAccDate, "yyyy-MM-dd") & "','0','" & _chrAccType & "','" & _chrOpMOde & "','" & _chrAccStatus & "','" & _strRemarks & "','" & _chrAddrId & "','" & _chrPhotoId & "','" & _chrOdFacility & "','" & _strReciptNo & "','" & _dblODAmount & "','" & Format(_datAccDate, "yyyy-MM-dd") & "')"
        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function
    Public Function fnUpdateCAccount(ByVal objTrans As IDbTransaction) As Boolean

        If fnUpdateOrganization(objTrans) Then

            strSQL = "UPDATE CAdetailTbl SET AccType='" & _chrAccType & "',opmode='" & _chrOpMOde & "',Accstatus ='" & _chrAccStatus & "' , Remarks='" & _strRemarks & "',Address_Id='" & _chrAddrId & "',Photo_Id='" & _chrPhotoId & "',ODFacility='" & _chrOdFacility & "',ODLimit='" & _dblODAmount & "'  WHERE CAccountNo='" & _strCurAccouontNo & "'"

            Return fnExecuteNonQuery(strSQL, objTrans)

        Else
            Return False
        End If
    End Function

    Public Function fnGetCAType(ByVal strCANo As String) As Boolean

        strSQL = "Select CAType FROM cadetailtbl WHERE CAccountNo='" & strCANo & "'"

        _dtCAdetailsTable = fnExecuteQuery(strSQL, 2)

        If _dtCAdetailsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnGetIndCAccountDetails(ByVal strCANo As String) As Boolean

        strSQL = "SELECT P.*, C.* FROM cadetailtbl C, Persontbl P WHERE P.PersonNo=C.PersonNo AND C.CAccountNo='" & strCANo & "'"

        _dtCAInfo = fnExecuteQuery(strSQL, 2)

        If _dtCAInfo.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetOrgCAccountDetails(ByVal strCANo As String) As Boolean

        strSQL = "SELECT O.*, C.* FROM cadetailtbl C, OrganizationTbl O WHERE O.OrganizationNo=C.OrgNo AND C.CAccountNo='" & strCANo & "'"

        _dtCAInfo = fnExecuteQuery(strSQL, 2)

        If _dtCAInfo.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnUpdateLastPaid(ByVal CAccountNo As String) As Boolean

        strSQL = "UPDATE cadetailtbl set IntAmount = IntAmount +'" & _dblIntAmt & "',LastPaidDate='" & Format(_datAccDate, "yyyy-MM-dd") & "'where CAccountNo='" & CAccountNo & "'"
        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnUpdateIntrest(ByVal CAccountNo As String) As Boolean

        strSQL = "UPDATE cadetailtbl set IntAmount = '0',LastPaidDate='" & Format(_datAccDate, "yyyy-MM-dd") & "'where CAccountNo='" & CAccountNo & "'"
        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetCAccountDetails(ByVal strCANo As String) As Boolean

        strSQL = " SELECT C.*,P.Name  as Name FROM caDetailTbl C,PersonTbl P WHERE P.PersonNo=C.PersonNo and C.CAccountNo='" & strCANo & "'"
        strSQL = strSQL & "UNION "
        strSQL = strSQL & "SELECT C.*,O.Name as Name FROM caDetailTbl C, OrganizationTbl O WHERE C.OrgNo=O.OrganizationNo and C.CAccountNo='" & strCANo & "' "

        _dtCAdetailsTable = fnExecuteQuery(strSQL, 2)

        If _dtCAdetailsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetCAccountlist() As Boolean
        'strSQL = "SELECT O.*, C.* FROM cadetailtbl C, OrganizationTbl O WHERE O.OrganizationNo=C.OrgNo"

        '_dtCAdetailsTable = fnExecuteQuery(strSQL, 2)

        'If _dtCAdetailsTable.Rows.Count > 0 Then
        '    Return True
        'Else
        '    Return False

        strSQL = " SELECT C.*,P.Name  as Name FROM caDetailTbl C,PersonTbl P WHERE P.PersonNo=C.PersonNo "
        strSQL = strSQL & "UNION "
        strSQL = strSQL & "SELECT C.*,O.Name as Name FROM caDetailTbl C, OrganizationTbl O WHERE C.OrgNo=O.OrganizationNo "

        _dtCAdetailsTable = fnExecuteQuery(strSQL, 2)

        If _dtCAdetailsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetCAccountTable() As Boolean

        strSQL = " SELECT C.CAccountNo,P.Name  as Name FROM caDetailTbl C,PersonTbl P WHERE P.PersonNo=C.PersonNo and C.AccStatus = 'A'"
        strSQL = strSQL & "UNION "
        strSQL = strSQL & "SELECT C.CAccountNo,O.Name as Name FROM caDetailTbl C, OrganizationTbl O WHERE C.OrgNo=O.OrganizationNo and C.AccStatus = 'A'"

        _dtCAdetailsTable = fnExecuteQuery(strSQL, 2)

        If _dtCAdetailsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Overloads Function fnCAtransactionEnter(ByVal strAccountNo As String, ByVal dtTransDate As Date, ByVal strNarration As String, ByVal dblDeposit As Double, ByVal dblWithdraw As Double, ByVal dblBDeposit As Double, ByVal dblBWithdraw As Double, ByVal dblPostBal As Double, ByVal strRefNo As String, ByVal lngvoucherNo As Long, ByVal strType As String, ByVal strchequeNo As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Insert into caTransactiontbl(CAccountNo,TrDate,Narration,Deposit,Withdraw,BDeposit,BWithdraw,PostBal,Interest,Refno,VoucherNo,Type,ChequeNo)"
        strSQL = strSQL & " Values( '" & strAccountNo & "','" & Format(dtTransDate, "yyyy-MM-dd") & "','" & strNarration & "','" & dblDeposit & "','" & dblWithdraw & "','" & dblBDeposit & "','" & dblBWithdraw & "','" & dblPostBal & "','0','" & strRefNo & "','" & lngvoucherNo & "','" & strType & "','" & strchequeNo & "')"

        fnExecuteNonQuery(strSQL, objTrans)

    End Function
    Public Overloads Function fnCAtransactionEnter(ByVal strAccountNo As String, ByVal dtTransDate As Date, ByVal strNarration As String, ByVal dblDeposit As Double, ByVal dblWithdraw As Double, ByVal dblBDeposit As Double, ByVal dblBWithdraw As Double, ByVal dblPostBal As Double, ByVal strRefNo As String, ByVal lngvoucherNo As Long, ByVal strType As String, ByVal strchequeNo As String) As Boolean

        strSQL = "Insert into caTransactiontbl(CAccountNo,TrDate,Narration,Deposit,Withdraw,BDeposit,BWithdraw,PostBal,Interest,Refno,VoucherNo,Type,ChequeNo)"
        strSQL = strSQL & " Values( '" & strAccountNo & "','" & Format(dtTransDate, "yyyy-MM-dd") & "','" & strNarration & "','" & dblDeposit & "','" & dblWithdraw & "','" & dblBDeposit & "','" & dblBWithdraw & "','" & dblPostBal & "','0','" & strRefNo & "','" & lngvoucherNo & "','" & strType & "','" & strchequeNo & "')"

        fnExecuteNonQuery(strSQL)

    End Function

    '...........
    'Included new function to get balence detail from cheque number

    Public Function fnGetBalence(ByVal lngChequeNo As Long) As Boolean
        'strSQL = "SELECT S.AccountNo,P.Name FROM sbDetailsTbl S, PersonTbl P WHERE S.PersonNo=P.PersonNo"
        ' strSQL = "select cb.accountno,cb.chequeno,P.Name,P.Photo,P.Signature,sb.Balance from sbchequebooktbl cb,sbdetailstbl sb,persontbl P where cb.accountno=sb.accountno and sb.personno=p.personno and cb.chequeNo='" & strChequeNo & "' and cb.chkStatus='P'"

        strSQL = "SELECT S.Balance,S.CAccountNo  from  caDetailTbl S,cachequebookmasterTbl C where " & lngChequeNo & " >=C.StartNo and " & lngChequeNo & " <=C.EndNo and C.CAccountNo=S.CAccountNo"

        _dtCACheckBookTable = fnExecuteQuery(strSQL, 2)

        If _dtCACheckBookTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Function fnAddDepositedCheque(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Insert into caChequeDeposittbl(CAccountNo,BankName,BranchName,Chequedate,ChequeNo,Depositdate,ChequeAmount,BankCharges,ChequeStatus,Narration)"
        strSQL = strSQL & " Values( '" & _strCurAccouontNo & "','" & _strBankName & "','" & _strBranchName & "','" & Format(_datChequeDate, "yyyy-MM-dd") & "','" & _strChequeNo & "','" & Format(_datChequeDepositDate, "yyyy-MM-dd") & "','" & _dblChequeAmount & "','" & _dblBankCharges & "','" & _strChequeStatus & "','" & _strRemarks & "')"

        If fnExecuteNonQuery(strSQL, objTrans) Then

            Return True

        Else
            Return False

        End If
    End Function

    Function fnAddDepositedChequeClear() As Boolean

        strSQL = "Insert into caChequeDeposittbl(CAccountNo,BankName,BranchName,Chequedate,ChequeNo,Depositdate,ChequeAmount,ClearanceDate,BankCharges,ChequeStatus,Remarks)"
        strSQL = strSQL & " Values( '" & _strCurAccouontNo & "','" & _strBankName & "','" & _strBranchName & "','" & Format(_datChequeDate, "yyyy-MM-dd") & "','" & _strChequeNo & "','" & Format(_datChequeDepositDate, "yyyy-MM-dd") & "','" & _dblChequeAmount & "','" & Format(_datChequeDepositDate, "yyyy-MM-dd") & "','" & _dblBankCharges & "','" & _strChequeStatus & "','" & _strRemarks & "')"

        If fnExecuteNonQuery(strSQL) Then

            Return True

        Else
            Return False

        End If
    End Function

    Function fnGetMaxCAChequeNo() As Boolean
        'Long

        strSQL = "Select CAStartingChequeNo,CALastCBNo from camastersettingstbl"
        _dtCACheckBookTable = fnExecuteQuery(strSQL, 2)
        If _dtCACheckBookTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

        '        Return IIf(IsDBNull(fnExecuteQuery(strSQL, 2).Rows(0).Item(0)) = True, 0, fnExecuteQuery(strSQL, 2).Rows(0).Item(0))

    End Function

    Function fnGetCAMasterData() As Boolean
        Dim strSQL As String = "SELECT * from camastersettingstbl"
        _dtCAMaster = fnExecuteQuery(strSQL, 2)
        If _dtCAMaster.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Function fnCACheckChequeBook(ByVal strbookNo As String) As Boolean

        Dim dtTable As New DataTable

        strSQL = "select Book_SNo from cachequebookmastertbl where Book_SNo='" & strbookNo & "'"

        dtTable = fnExecuteQuery(strSQL, 2)

        If dtTable.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function


    Public Function fnCAInsertCheckBookDetails() As Boolean

        Dim intCounter As Integer = _lngStartNo
        strSQL = "INSERT INTO cachequebookmastertbl(CAccountNo,Book_SNo,IssuedDate,RefNo,StartNo,EndNo,Status)"
        strSQL = strSQL & " VALUES('" & _strCurAccouontNo & "','" & _strBookNo & "','" & Format(_datChkBookDate, "yyyy-MM-dd") & "','" & _strReciptNo & "','" & _lngStartNo & "','" & _lngEndNo & "','P')"
        fnExecuteNonQuery(strSQL)
        Return True

    End Function

    Public Function fnGetCheckDet(ByVal lngChequeNo As Long, ByVal AccountNo As String) As Boolean

        strSQL = "select * from cachequebookmastertbl where " & lngChequeNo & " >=StartNo and " & lngChequeNo & " <=EndNo AND CAccountNo='" & AccountNo & "'"
        _dtCACheckBookTable = fnExecuteQuery(strSQL, 2)
        If _dtCACheckBookTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetCACheckBookDetails() As Boolean
        strSQL = "SELECT CAccountNo,Book_SNo,IssuedDate,RefNo,StartNo,EndNo,Status FROM cachequebookmastertbl WHERE CAccountNo='" & _strCurAccouontNo & "'"
        _dtCACheckBookTable = fnExecuteQuery(strSQL, 2)
        If _dtCACheckBookTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Function fnGetTransactionDetails(ByVal datFrom As Date, ByVal datTo As Date) As Boolean
        strSQL = "select * from catransactiontbl where CAccountno='" & _strCurAccouontNo & "' and Trdate Between '" & Format(datFrom, "yyyy-MM-dd") & "' and '" & Format(datTo, "yyyy-MM-dd") & "'"
        _dtCATransDetailTable = fnExecuteQuery(strSQL, 2)
        Return True
    End Function

    Public Function fnGetCheqTranDet(ByVal strAccNo As String) As Boolean

        strSQL = "select Tr.*,Sb.* from catransactiontbl Tr,cachequedeposittbl Sb where Tr.CAccountNo = Sb.CAccountNo and sb.CAccountNo = '" & strAccNo & "' and Type = 'Cheque'"

        _dtChqTranDet = fnExecuteQuery(strSQL, 2)

        If _dtChqTranDet.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetChqDateTran(ByVal datFrom As Date, ByVal datTo As Date, ByVal strAccNo As String) As Boolean

        strSQL = "select Tr.*,Sb.* from catransactiontbl Tr,cachequedeposittbl Sb where Tr.CAccountNo = Sb.CAccountNo and sb.CAccountNo = '" & strAccNo & "' and Type = 'Cheque' and  Trdate between '" & Format(datFrom, "yyyy-MM-dd") & "' and '" & Format(datTo, "yyyy-MM-dd") & "'"

        _dtChqTranDet = fnExecuteQuery(strSQL, 2)

    End Function


    Public Function fnGetDepositedCheque() As Boolean

        strSQL = "select * from cachequedeposittbl order by slNo desc "
        _dtChequedetailsTable = fnExecuteQuery(strSQL, 2)
        If _dtChequedetailsTable.Rows.Count > 0 Then

            Return True
        Else
            Return False
        End If
    End Function
    Public Function fnGetDepositedCheque(ByVal lngChequeNo As String) As Boolean
        strSQL = "select * from cachequedeposittbl where ChequeNo='" & lngChequeNo & "'"
        _dtChequedetailsTable = fnExecuteQuery(strSQL, 2)
        If _dtChequedetailsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnGetCheques(ByVal lngChequeNo As Long) As Boolean
        strSQL = "Select * from cachequebookmastertbl Where " & lngChequeNo & " >= startNo AND " & lngChequeNo & " <= EndNo "
        _dtCACheckBookTable = fnExecuteQuery(strSQL, 2)
        If _dtCACheckBookTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnCheckChequeLeafNo(ByVal lngChequeNo As Long) As Boolean

        strSQL = "select * from cachequeleaftbl where ChequeNo ='" & lngChequeNo & "'"
        _dtCACheckBookTable = fnExecuteQuery(strSQL, 2)
        If _dtCACheckBookTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnUpdateStatus(ByVal lngVouncherNo As Long, ByVal strNarration As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "update cachequedeposittbl set ChequeStatus = '" & _strChequeStatus & "',ClearanceDate = '" & Format(_datChequeClearanceDate, "yyyy-MM-dd") & "',VoucherNo = '" & lngVouncherNo & "',Narration = '" & strNarration & "' where ChequeNo = '" & _strChequeNo & "' and CAccountNo = '" & _strCurAccouontNo & "'"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnGetChecks(ByVal lngChequeNo As Long) As Boolean

        strSQL = "select * from cachequebookmastertbl where " & lngChequeNo & " >=StartNo and " & lngChequeNo & " <=EndNo"

        _dtCACheckBookTable = fnExecuteQuery(strSQL, 2)

        If _dtCACheckBookTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnCaChqStopPayDet() As Boolean

        strSQL = "SELECT caChqLeaf.*,caCheqDep.*,caTran.* from caChequeleaftbl cachqLeaf, caChequeDeposittbl caCheqDep,catransaction caTran where caChqLeaf.ChequeNo = caCheqDep.ChequeNo and caChqLeaf.ChequeNo = caTran.ChequeNo and caChqLeaf.Status = 'Stopped'"

        _dtChqStopPayDt = fnExecuteQuery(strSQL, 2)

        If _dtChqStopPayDt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnGetNewCANo() As String

        strSQL = "SELECT max(CAccountNo) as MaxNo FROM cadetailtbl "

        _dtCAdetailsTable = fnExecuteQuery(strSQL, 2)

        If IsDBNull(_dtCAdetailsTable.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return _dtCAdetailsTable.Rows(0).Item("MaxNo")
        End If

    End Function
    Public Function fnGetDayDetails() As Boolean
        strSQL = "select CAccountNo, AvailBalance from cadetailtbl"
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
    Public Function fnInsertCADetails(ByVal AccountNo As String, ByVal Balance As Double, ByVal Today As Date, ByVal objTrans As IDbTransaction) As Boolean
        strSQL = " insert into dayendtbl(AccountNo,Date,ClosingBalance)values('" & AccountNo & "','" & Format(Today, "yyyy-MM-dd") & "','" & Balance & "') "
        If (fnExecuteNonQuery(strSQL, objTrans)) Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetAccountNos() As Boolean
        strSQL = "select CAccountNo,AvailBalance from cadetailtbl"
        _dtAccountNos = fnExecuteQuery(strSQL, 2)
        If _dtAccountNos.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fnGetCrtBalance(ByVal AccountNo As String) As Boolean
        strSQL = " select ClosingBalance from cadayendtbl where AccountNo='" & AccountNo & "'"
        _dtCrtBalance = fnExecuteQuery(strSQL, 2)
        If _dtCrtBalance.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fnUpdateInterest(ByVal AccountNo As String, ByVal TrDate As Date) As Boolean

        strSQL = "update cadetailstbl set  LastPaidDate = '" & Format(TrDate, "yyyy-MM-dd") & "', IntAmount = '0' where CAccountNo = '" & AccountNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function
    Public Function fnGetMaxDate(ByVal PresentDate As Date) As Boolean
        strSQL = " select * from dayendtbl where Date='" & Format(PresentDate, "yyyy-MM-dd") & "'"
        _dtMaxDate = fnExecuteQuery(strSQL, 2)
        If _dtMaxDate.Rows.Count > 0 Then

            Return True
        Else
            Return False

        End If
    End Function
    Function fnEnterDate(ByVal PresentDate As Date, ByVal NextDate As Date, ByVal objTrans As IDbTransaction) As Boolean
        strSQL = " insert into datetbl(PresentDate,NextDate)values('" & Format(PresentDate, "yyyy-MM-dd") & "','" & Format(NextDate, "yyyy-MM-dd") & "')"
        If (fnExecuteNonQuery(strSQL, objTrans)) Then
            Return True
        Else
            Return False
        End If
    End Function
    Function fnGetDates() As Boolean
        strSQL = " select max(NextDate)as NextDate from datetbl"
        _dtMaxNextDate = fnExecuteQuery(strSQL, 2)
        If _dtMaxNextDate.Rows.Count > 0 Then
            Return True
        Else
            Return False

        End If
    End Function
    Function fnDateEntry() As Boolean
        strSQL = " select * from datetbl"
        _dtMaxNextDate = fnExecuteQuery(strSQL, 2)
        If _dtMaxNextDate.Rows.Count > 0 Then
            Return True
        Else
            Return False

        End If

    End Function
#End Region

End Class
