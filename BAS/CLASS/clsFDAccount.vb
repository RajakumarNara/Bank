Public Class clsFDAccount
    Inherits clsPerson

#Region "Variables"

    Private _strMemberNo As String
    Private _strSBNo As String
    Private _strSchemeTypeCheck As String
    Private _intOldFDAdditionDetailID As Integer
    Private _strFDNo As String
    Private _chrAccountType As Char
    Private _IntSchemeType As Integer
    Private _IntScheme As String
    Private _TotalInterestPaid As Double
    Private _TotalInterestProvision As Double
    Private _chrOpMode As Char
    Private _chrIntMode As Char
    Private _datFDDate As Date
    Private _dblFDAmount As Double
    Private _dblFDROI As Double
    Private _dblSeniorCROI As Double
    Private _dblReductionIterest As Double
    Private _intFDYears As Integer
    Private _intFDMonths As Integer
    Private _intFDDays As Integer
    Private _dblIntAmount As Double
    Private _dblMatAmount As Double
    Private _datMatDate As Date
    Private _strReceiptNo As String
    Private _dblBondNo As Double
    Private _lngVoucherNo As Long
    Private _strIntroName As String
    Private _dblIntPaid As Double
    Private _strRemarks As String
    Private _chrStatus As Char
    Private _dblTrnsferAmt As Double
    Private _chrTrnsferAmt As Char
    Private _chrPostingPeriod As Char
    Private _strTransferAccNo As String
    Private _dtSBdetailsTable As DataTable
    Private _dtRenewalFDTable As DataTable
    Private _dtFDSchemeTbl As DataTable
    Private _dtPrematureROITbl As DataTable
    Private _intFDDetailID As Integer
    Private _intFDAdditionalDetailID As Integer

    Private _dtInterest As DataTable
    Private _dtFDTable As DataTable
    Private _dtfdDet As DataTable
    Private _dtPaidIntTable As DataTable
    'FD Renewal Varibles

    Private _dtFDDetails As DataTable
    Private _strNewFdNo As String

    'FD Master Settings

    Private _intFromPeriod As Integer
    Private _intToPeriod As Integer
    Private _strSchemeName As String
    Private _strPostingPeriod As String
    Private _intSchemeCode As Integer
    Private _chrCalType As Char
    Private _chrFDType As Char
    Private _dtFDMasterTbl As DataTable
    Private _dtFDMasterDetailTbl As DataTable

    'FD Duplicate 
    Private _datFDDuplicateDate As Date
    Private _dblFDDuplicateFee As Double

    Private _dtRef As DataTable

    'Loan Details
    Private _dtFDLoanDet As DataTable

    'Premature Variable
    Private _dblIntPayable As Double
    Private _dblIntDiff As Double
    Private _dblFDAmtPaid As Double

    'IntPayment Variables
    Private _datIntPosting As DataTable

    Private _chrCorrection As Char
    Private _chrCType As Char
    Private _dblCAmount As Double
    Private _dblMatAmountCheck As Double
    Private _dblFDAmountCheck As Double
#End Region

#Region "Properties"
    Public Property TotalInterestProvision() As Double
        Get
            Return _TotalInterestProvision
        End Get
        Set(ByVal Value As Double)
            _TotalInterestProvision = Value
        End Set
    End Property
    Public Property TotalInterestPaid() As Double
        Get
            Return _TotalInterestPaid
        End Get
        Set(ByVal Value As Double)
            _TotalInterestPaid = Value
        End Set
    End Property
    Public Property FDAmountCheck() As Double
        Get
            Return _dblFDAmountCheck
        End Get
        Set(ByVal Value As Double)
            _dblFDAmountCheck = Value
        End Set
    End Property
    Public Property MatAmountCheck() As Double
        Get
            Return _dblMatAmountCheck
        End Get
        Set(ByVal Value As Double)
            _dblMatAmountCheck = Value
        End Set
    End Property

    Public Property PaidIntTable() As DataTable
        Get
            Return _dtPaidIntTable
        End Get
        Set(ByVal Value As DataTable)
            _dtPaidIntTable = Value
        End Set
    End Property

    Public Property RenewalFDTable() As DataTable
        Get
            Return _dtRenewalFDTable
        End Get
        Set(ByVal Value As DataTable)
            _dtRenewalFDTable = Value
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

    Public Property SchemeTypeCheck() As String
        Get
            Return _strSchemeTypeCheck
        End Get
        Set(ByVal Value As String)
            _strSchemeTypeCheck = Value
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

    Public Property AccountType() As Char
        Get
            Return _chrAccountType
        End Get
        Set(ByVal Value As Char)
            _chrAccountType = Value
        End Set
    End Property
    Public Property SchemeType() As Integer
        Get
            Return _IntSchemeType
        End Get
        Set(ByVal Value As Integer)
            _IntSchemeType = Value
        End Set
    End Property
    Public Property Scheme() As String
        Get
            Return _IntScheme
        End Get
        Set(ByVal Value As String)
            _IntScheme = Value
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

    Public Property FDType() As Char
        Get
            Return _chrFDType
        End Get
        Set(ByVal Value As Char)
            _chrFDType = Value
        End Set
    End Property

    Public Property IntMode() As Char
        Get
            Return _chrIntMode
        End Get
        Set(ByVal Value As Char)
            _chrIntMode = Value
        End Set
    End Property

    Public Property FDDate() As Date
        Get
            Return _datFDDate
        End Get
        Set(ByVal Value As Date)
            _datFDDate = Value
        End Set
    End Property



    Public Property TransferAmount() As Double
        Get
            Return _dblTrnsferAmt
        End Get
        Set(ByVal Value As Double)
            _dblTrnsferAmt = Value
        End Set
    End Property

    Public Property ChTransferAmount() As Char
        Get
            Return _chrTrnsferAmt
        End Get
        Set(ByVal Value As Char)
            _chrTrnsferAmt = Value
        End Set
    End Property
    Public Property chPostingPeriod() As Char
        Get
            Return _chrPostingPeriod
        End Get
        Set(ByVal Value As Char)
            _chrPostingPeriod = Value
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

    Public Property FDROI() As Double
        Get
            Return _dblFDROI
        End Get
        Set(ByVal Value As Double)
            _dblFDROI = Value
        End Set
    End Property

    Public Property FDYears() As Integer
        Get
            Return _intFDYears
        End Get
        Set(ByVal Value As Integer)
            _intFDYears = Value
        End Set
    End Property

    Public Property FDMonths() As Integer
        Get
            Return _intFDMonths
        End Get
        Set(ByVal Value As Integer)
            _intFDMonths = Value
        End Set
    End Property

    Public Property FDDays() As Integer
        Get
            Return _intFDDays
        End Get
        Set(ByVal Value As Integer)
            _intFDDays = Value
        End Set
    End Property

    Public Property IntAmount() As Double
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

    Public Property MatDate() As Date
        Get
            Return _datMatDate
        End Get
        Set(ByVal Value As Date)
            _datMatDate = Value
        End Set
    End Property

    Public Property ReceiptNo() As String
        Get
            Return _strReceiptNo
        End Get
        Set(ByVal Value As String)
            _strReceiptNo = Value
        End Set
    End Property

    Public Property BondNo() As Double
        Get
            Return _dblBondNo
        End Get
        Set(ByVal Value As Double)
            _dblBondNo = Value
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

    Public Property IntroName() As String
        Get
            Return _strIntroName
        End Get
        Set(ByVal Value As String)
            _strIntroName = Value
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

    'Public Property Remarks() As String
    '    Get
    '        Return _strRemarks
    '    End Get
    '    Set(ByVal Value As String)
    '        _strRemarks = Value
    '    End Set
    'End Property
    Public Property TransferAccNo() As String
        Get
            Return _strTransferAccNo
        End Get
        Set(ByVal Value As String)
            _strTransferAccNo = Value
        End Set
    End Property

    Public Property Status() As Char
        Get
            Return _chrStatus
        End Get
        Set(ByVal Value As Char)
            _chrStatus = Value
        End Set
    End Property

    Public Property FDDetailID() As Integer
        Get
            Return _intFDDetailID
        End Get
        Set(ByVal Value As Integer)
            _intFDDetailID = Value
        End Set
    End Property

    Public Property FDAdditionalDetailID() As Integer
        Get
            Return _intOldFDAdditionDetailID
        End Get
        Set(ByVal Value As Integer)
            _intOldFDAdditionDetailID = Value
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

    Public Property PrematureROITbl() As DataTable
        Get
            Return _dtPrematureROITbl
        End Get
        Set(ByVal Value As DataTable)
            _dtPrematureROITbl = Value
        End Set
    End Property
    Public Property FDSchemeTbl() As DataTable
        Get
            Return _dtFDSchemeTbl
        End Get
        Set(ByVal Value As DataTable)
            _dtFDSchemeTbl = Value
        End Set
    End Property

    Public Property FDTable() As DataTable
        Get
            Return _dtFDTable
        End Get
        Set(ByVal Value As DataTable)
            _dtFDTable = Value
        End Set
    End Property

    Public Property FDDetTable() As DataTable
        Get
            Return _dtfdDet
        End Get
        Set(ByVal Value As DataTable)
            _dtfdDet = Value
        End Set
    End Property

    Public Property SBdetailsTable() As DataTable
        Get
            Return _dtSBdetailsTable
        End Get
        Set(ByVal Value As DataTable)
            _dtSBdetailsTable = Value
        End Set
    End Property
    Public Property FDDetailstbl() As DataTable
        Get
            Return _dtFDDetails
        End Get
        Set(ByVal Value As DataTable)
            _dtFDDetails = Value
        End Set
    End Property

    Public Property NewFDNo() As String
        Get
            Return _strNewFdNo
        End Get
        Set(ByVal Value As String)
            _strNewFdNo = Value
        End Set
    End Property

    'FD Master Settings

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

    Public Property FDAdditionDetailID() As Integer
        Get
            Return _intOldFDAdditionDetailID
        End Get
        Set(ByVal Value As Integer)
            _intOldFDAdditionDetailID = Value
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

    Public Property FDMasterDetailTbl() As DataTable
        Get
            Return _dtFDMasterDetailTbl
        End Get
        Set(ByVal Value As DataTable)
            _dtFDMasterDetailTbl = Value
        End Set
    End Property
    Public Property FdMasterTbl() As DataTable
        Get
            Return _dtFDMasterTbl
        End Get
        Set(ByVal Value As DataTable)
            _dtFDMasterTbl = Value
        End Set
    End Property

    'FD Duplicate Property

    Public Property FDDuplicateDate() As Date
        Get
            Return _datFDDuplicateDate
        End Get
        Set(ByVal Value As Date)
            _datFDDuplicateDate = Value
        End Set
    End Property

    Public Property FDDuplicateFee() As Double
        Get
            Return _dblFDDuplicateFee
        End Get
        Set(ByVal Value As Double)
            _dblFDDuplicateFee = Value
        End Set
    End Property

    Public Property FDAmount() As Double
        Get
            Return _dblFDAmount
        End Get
        Set(ByVal Value As Double)
            _dblFDAmount = Value
        End Set
    End Property

    Public Property RefTable() As DataTable
        Get
            Return _dtRef
        End Get
        Set(ByVal Value As DataTable)
            _dtRef = Value
        End Set
    End Property

    Public Property FDLoanDet() As DataTable
        Get
            Return _dtFDLoanDet
        End Get
        Set(ByVal Value As DataTable)
            _dtFDLoanDet = Value
        End Set
    End Property

    Public Property FDIntPayable() As Double
        Get
            Return _dblIntPayable
        End Get
        Set(ByVal Value As Double)
            _dblIntPayable = Value
        End Set
    End Property

    Public Property FdIntDiff() As Double
        Get
            Return _dblIntDiff
        End Get
        Set(ByVal Value As Double)
            _dblIntDiff = Value
        End Set
    End Property

    Public Property FDAmtPaid() As Double
        Get
            Return _dblFDAmtPaid
        End Get
        Set(ByVal Value As Double)
            _dblFDAmtPaid = Value
        End Set
    End Property

    Public Property dtIntPost() As DataTable
        Get
            Return _datIntPosting
        End Get
        Set(ByVal Value As DataTable)
            _datIntPosting = Value
        End Set
    End Property

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

#End Region

#Region "Functions"


    Public Function fnAddFDAccount(ByVal objTrans As IDbTransaction) As Boolean
        GetMaxFDDetailID()
        GetMaxFDAdditionalDetailID()

        If fnCheckPerson() Then
            If fnUpdatePerson(objTrans) Then
                If fnInsertFD(objTrans) Then
                    If fnInsertAdditionalDetail(objTrans) Then
                        fnAddInterestTable(objTrans)
                        Return True
                    End If
                End If
            End If
        Else
            If fnAddPerson() Then
                If fnInsertFD(objTrans) Then
                    If fnInsertAdditionalDetail(objTrans) Then
                        fnAddInterestTable(objTrans)
                        Return True
                    End If
                Else
                    fnDeletePerson(objTrans)
                End If
            End If
        End If

        Return False

    End Function
    Public Function fnAddDoubleThriableLakshadipathiAccount(ByVal objTrans As IDbTransaction) As Boolean
        GetMaxFDDetailID()
        GetMaxFDAdditionalDetailID()

        If fnCheckPerson() Then
            If fnUpdatePerson(objTrans) Then
                If fnInsertFD(objTrans) Then
                    If fnInsertDoubleThriableLakpathiDetail(objTrans) Then
                        fnAddDoubleTripleLakshadipatiInterestTable(objTrans)
                        Return True
                    End If
                End If
            End If
        Else
            If fnAddPerson() Then
                If fnInsertFD(objTrans) Then
                    If fnInsertDoubleThriableLakpathiDetail(objTrans) Then
                        fnAddDoubleTripleLakshadipatiInterestTable(objTrans)
                        Return True
                    End If
                Else
                    fnDeletePerson(objTrans)
                End If
            End If
        End If

        Return False

    End Function

    Private Function fnInsertFD(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "INSERT INTO FDDetailsTbl(FDDetailID,FDNo,CustomerID,PersonNo,FDAdditionalDetailID,AccType,OpMode,"
        strSQL = strSQL & "IntroName,ReceiptNo,Remarks,Status,LoanStatus)"
        strSQL = strSQL & "VALUES('" & _intFDDetailID & "','" & _strFDNo & "','" & CustomerID & "','" & PersonNo & "','" & _intFDAdditionalDetailID & "','"
        strSQL = strSQL & _chrAccountType & "','" & _chrOpMode & "','"
        strSQL = strSQL & _strIntroName & "','" & _strReceiptNo & "','" & _strRemarks & "','" & _chrStatus & "',' ')"
        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Private Function fnInsertAdditionalDetail(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "INSERT INTO FDAdditionalDetailsTbl(FDAdditionalDetailID,AccountNo,TransferedAmt,PostingPeriod,FDscheme,FDDate,"
        strSQL = strSQL & "FDAmount,Years,Months,Days,FDROI,MatDate,IntMode,BondNo,VoucherNo,IntAmount,MatAmount,IntPaid,Status,Correction,CType,CAmount,TransferAccountNo)"
        strSQL = strSQL & "VALUES('" & _intFDAdditionalDetailID & "','" & _strSBNo & "','" & _chrTrnsferAmt & "','"
        strSQL = strSQL & _chrPostingPeriod & "','" & _intSchemeCode & "','" & Format(_datFDDate, "yyyy-MM-dd") & "','" & _dblFDAmount & "','" & _intFDYears & "','" & _intFDMonths & "','"
        strSQL = strSQL & _intFDDays & "','" & _dblFDROI & "','" & Format(_datMatDate, "yyyy-MM-dd") & "','" & _chrIntMode & "','" & _dblBondNo & "','"
        strSQL = strSQL & _lngVoucherNo & "','" & _dblIntAmount & "','" & _dblMatAmount & "','" & _dblIntPaid & "','" & _chrStatus & "','" & _chrCorrection & "','" & _chrCType & "','" & _dblCAmount & "','" & _strTransferAccNo & "')"
        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function
    Private Function fnInsertDoubleThriableLakpathiDetail(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "INSERT INTO FDAdditionalDetailsTbl(FDAdditionalDetailID,AccountNo,TransferedAmt,PostingPeriod,FDscheme,FDDate,"
        strSQL = strSQL & "FDAmount,Years,Months,Days,MatDate,IntMode,BondNo,VoucherNo,IntAmount,MatAmount,IntPaid,Status,Correction,CType,CAmount,TransferAccountNo)"
        strSQL = strSQL & "VALUES('" & _intFDAdditionalDetailID & "','" & _strSBNo & "','" & _chrTrnsferAmt & "','"
        strSQL = strSQL & _chrPostingPeriod & "','" & _intSchemeCode & "','" & Format(_datFDDate, "yyyy-MM-dd") & "','" & _dblFDAmount & "','" & _intFDYears & "','" & _intFDMonths & "','"
        strSQL = strSQL & _intFDDays & "','" & Format(_datMatDate, "yyyy-MM-dd") & "','" & _chrIntMode & "','" & _dblBondNo & "','"
        strSQL = strSQL & _lngVoucherNo & "','" & _dblIntAmount & "','" & _dblMatAmount & "','" & _dblIntPaid & "','" & _chrStatus & "','" & _chrCorrection & "','" & _chrCType & "','" & _dblCAmount & "','" & _strTransferAccNo & "')"
        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Private Sub GetMaxFDDetailID()
        strSQL = "SELECT ifnull(max(FDDetailID),0)+1 as MaxNo FROM FDDetailsTbl"
        _dtFDDetails = fnExecuteQuery(strSQL, 2)
        FDDetailID = _dtFDDetails.Rows(0).Item("MaxNo")
    End Sub

    Private Sub GetMaxFDAdditionalDetailID()
        strSQL = "SELECT ifnull(max(FDAdditionalDetailID),0)+1 as MaxNo FROM fdadditionaldetailstbl "
        _dtFDDetails = fnExecuteQuery(strSQL, 2)
        _intFDAdditionalDetailID = _dtFDDetails.Rows(0).Item("MaxNo")
        ' FDAdditionalDetailID = _dtFDDetails.Rows(0).Item("MaxNo")
    End Sub

    Public Function fnCheckFDAccount(ByVal FDNo As String) As Boolean

        Dim objDT As DataTable

        strSQL = "SELECT * FROM FDDetailsTbl WHERE FDNo='" & FDNo & "'"

        _dtFDDetails = fnExecuteQuery(strSQL, 2)

        If _dtFDDetails.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnUpdateFDAccount(ByVal objTrans As IDbTransaction) As Boolean

        If fnUpdatePerson(objTrans) Then

            ' strSQL = "UPDATE FDDetailsTbl SET AccountNo='" & _strSBNo & "',Remarks='" & _strRemarks & "' WHERE FDNo='" & _strFDNo & "'"
            strSQL = "UPDATE FDDetailsTbl SET Remarks='" & _strRemarks & "' WHERE FDNo='" & _strFDNo & "'"

            Return fnExecuteNonQuery(strSQL, objTrans)



        Else

            Return False

        End If

    End Function

    Private Function fnAddInterestTable(ByVal objTrans As IDbTransaction) As Boolean

        Dim intCounter As Integer = 0
        If _chrFDType = "C" Then
            While intCounter < _dtInterest.Rows.Count

                strSQL = "INSERT INTO FDCumulativeIntTbl(FDAdditionalDetailID,FDNo,SlNo,IntAmount,IntDate,CumuAmount,Status) "
                strSQL = strSQL & "VALUES('" & _intFDAdditionalDetailID & "','" & _strFDNo & "','" & _dtInterest.Rows(intCounter).Item("SlNo") & "','"
                strSQL = strSQL & _dtInterest.Rows(intCounter).Item("IntAmount") & "','"
                strSQL = strSQL & Format(CDate(_dtInterest.Rows(intCounter).Item("IntDate")), "yyyy-MM-dd") & "','"
                strSQL = strSQL & _dtInterest.Rows(intCounter).Item("TotalAmount") & "','Due')"

                fnExecuteNonQuery(strSQL, objTrans)

                intCounter += 1
            End While
        Else
            While intCounter < _dtInterest.Rows.Count

                strSQL = "INSERT INTO FDIntPaymentsTbl(FDAdditionalDetailID,FDNo,SlNo,IntAmount,IntDate,Status) "
                strSQL = strSQL & "VALUES('" & _intFDAdditionalDetailID & "','" & _strFDNo & "','" & _dtInterest.Rows(intCounter).Item("SlNo") & "','"
                strSQL = strSQL & _dtInterest.Rows(intCounter).Item("IntAmount") & "','"
                strSQL = strSQL & Format(CDate(_dtInterest.Rows(intCounter).Item("IntDate")), "yyyy-MM-dd") & "','Due')"

                fnExecuteNonQuery(strSQL, objTrans)

                intCounter += 1

            End While
        End If
        Return True

    End Function

    Private Function fnAddDoubleTripleLakshadipatiInterestTable(ByVal objTrans As IDbTransaction) As Boolean

        Dim intCounter As Integer = 0
        While intCounter < _dtInterest.Rows.Count

            strSQL = "INSERT INTO FDCumulativeIntTbl(FDAdditionalDetailID,FDNo,SlNo,IntAmount,IntDate,CumuAmount,Status) "
            strSQL = strSQL & "VALUES('" & _intFDAdditionalDetailID & "','" & _strFDNo & "','" & _dtInterest.Rows(intCounter).Item("SlNo") & "','"
            strSQL = strSQL & _dtInterest.Rows(intCounter).Item("IntAmount") & "','"
            strSQL = strSQL & Format(CDate(_dtInterest.Rows(intCounter).Item("IntDate")), "yyyy-MM-dd") & "','"
            strSQL = strSQL & _dtInterest.Rows(intCounter).Item("TotalAmount") & "','Due')"

            fnExecuteNonQuery(strSQL, objTrans)

            intCounter += 1
        End While
        Return True
    End Function
    Private Function fnAddRenewalInterestTable(ByVal objTrans As IDbTransaction) As Boolean

        Dim intCounter As Integer = 0
        If _chrFDType = "C" Then
            While intCounter < _dtInterest.Rows.Count

                strSQL = "INSERT INTO FDCumulativeIntTbl(FDAdditionalDetailID,FDNo,SlNo,IntAmount,IntDate,CumuAmount,Status,Renewal) "
                strSQL = strSQL & "VALUES('" & _intFDAdditionalDetailID & "','" & _strFDNo & "','" & _dtInterest.Rows(intCounter).Item("SlNo") & "','"
                strSQL = strSQL & _dtInterest.Rows(intCounter).Item("IntAmount") & "','"
                strSQL = strSQL & Format(CDate(_dtInterest.Rows(intCounter).Item("IntDate")), "yyyy-MM-dd") & "','"
                strSQL = strSQL & _dtInterest.Rows(intCounter).Item("TotalAmount") & "','Due','Renewal')"

                fnExecuteNonQuery(strSQL, objTrans)

                intCounter += 1
            End While
        Else
            While intCounter < _dtInterest.Rows.Count

                strSQL = "INSERT INTO FDIntPaymentsTbl(FDAdditionalDetailID,FDNo,SlNo,IntAmount,IntDate,Status,Renewal) "
                strSQL = strSQL & "VALUES('" & _intFDAdditionalDetailID & "','" & _strFDNo & "','" & _dtInterest.Rows(intCounter).Item("SlNo") & "','"
                strSQL = strSQL & _dtInterest.Rows(intCounter).Item("IntAmount") & "','"
                strSQL = strSQL & Format(CDate(_dtInterest.Rows(intCounter).Item("IntDate")), "yyyy-MM-dd") & "','Due','Renewal')"

                fnExecuteNonQuery(strSQL, objTrans)

                intCounter += 1

            End While
        End If
        Return True

    End Function
    Public Function fnGetFDsTable() As Boolean

        strSQL = "SELECT FD.*, P.* FROM FDDetailsTbl FD, PersonTbl P WHERE FD.PersonNo=P.PersonNo and fd.status = 'A'"

        _dtFDTable = fnExecuteQuery(strSQL, 2)

        If _dtFDTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetFDsTable(ByVal strType As String) As Boolean

        strSQL = "SELECT FD.*, P.* FROM FDDetailsTbl FD, PersonTbl P,fdadditionaldetailstbl fda WHERE FD.PersonNo=P.PersonNo and fd.status = 'A' and fda.fdadditionaldetailid=FD.fdadditionaldetailid and fda.FDROI is not null and FDNo like '" & strType & "%' "

        _dtFDTable = fnExecuteQuery(strSQL, 2)

        If _dtFDTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetDoubleTripleLakpathi(ByVal strType As String) As Boolean

        strSQL = "SELECT FD.*, P.* FROM FDDetailsTbl FD, PersonTbl P,fdadditionaldetailstbl fda WHERE FD.PersonNo=P.PersonNo and fda.fdadditionaldetailid=FD.fdadditionaldetailid and fda.FDROI is null and fd.status = 'A' and FDNo like '" & strType & "%' "
        _dtFDTable = fnExecuteQuery(strSQL, 2)

        If _dtFDTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetFDDoubleTripleLakpathi(ByVal strType As String) As Boolean

        strSQL = "SELECT FD.*, P.* FROM FDDetailsTbl FD, PersonTbl P,fdadditionaldetailstbl fda WHERE FD.PersonNo=P.PersonNo and fda.fdadditionaldetailid=FD.fdadditionaldetailid and fd.status = 'A' and FDNo like '" & strType & "%' "
        _dtFDTable = fnExecuteQuery(strSQL, 2)

        If _dtFDTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetNewFDNo(ByVal str As String) As String

        strSQL = "SELECT max(FDNo) as MaxNo FROM fddetailstbl where FDNo like '" & str & "%'"

        _dtSBdetailsTable = fnExecuteQuery(strSQL, 2)

        If IsDBNull(_dtSBdetailsTable.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return _dtSBdetailsTable.Rows(0).Item("MaxNo")
        End If

    End Function

    Public Function fnGetFDList(ByVal strType As String) As Boolean

        'strSQL = "SELECT FD.*, P.* FROM FDDetailsTbl FD, PersonTbl P WHERE FD.PersonNo=P.PersonNo and FDNo like '" & strType & "%' "
        strSQL = "SELECT P.Name, FD.*,FDA.* FROM FDDetailsTbl FD,PersonTbl P,fdadditionaldetailstbl FDA WHERE FD.PersonNo=P.PersonNo  AND FD.FDAdditionalDetailID=FDA.FDAdditionalDetailID AND FD.FDNo like '" & strType & "%'"
        _dtFDTable = fnExecuteQuery(strSQL, 2)

        If _dtFDTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnGetFDDetails(ByVal strFDNo As String) As Boolean

        'strSQL = "SELECT  P.*, FD.*,S.* FROM FDDetailsTbl FD, PersonTbl P,FDSchemeTbl S WHERE FD.PersonNo=P.PersonNo AND FD.FDNo='" & strFDNo & "'and FD.FDScheme=S.SchemeCode"
        strSQL = "SELECT P.*, FD.*,S.*,FDA.* FROM FDDetailsTbl FD,PersonTbl P,FDSchemeTbl S,fdadditionaldetailstbl FDA WHERE FD.PersonNo=P.PersonNo AND FD.FDNo='" & strFDNo & "' AND FD.FDAdditionalDetailID=FDA.FDAdditionalDetailID AND FDA.FDScheme=S.SchemeCode"
        _dtFDTable = fnExecuteQuery(strSQL, 2)
       
        If _dtFDTable.Rows.Count > 0 Then
                 If _dtFDTable.Rows(0).Item("schemeType") = "C" Then
                ' strSQL = "SELECT FDC.* FROM FDCumulativeIntTbl  FDC ,FDDetailsTbl FD WHERE FDC.FDNo=FD.FDNo and FD.FDNo='" & strFDNo & "'  ORDER BY FDAdditionalDetailID ASC" 'DESC"

                strSQL = "SELECT FDC.* FROM FDCumulativeIntTbl  FDC ,FDDetailsTbl FD WHERE FD.FDNo='" & strFDNo & "'AND FD.FDAdditionalDetailID=FDC.FDAdditionalDetailID  ORDER BY SlNo ASC" 'DESC"

                _dtInterest = fnExecuteQuery(strSQL, 2)

            ElseIf _dtFDTable.Rows(0).Item("schemeType") = "N" Then
                ' strSQL = "SELECT FDP.* FROM FDIntPaymentsTbl FDP ,FDDetailsTbl FD WHERE FDP.FDNo=FD.FDNo and FDP.FDNo='" & strFDNo & "'  ORDER BY FDAdditionalDetailID ASC" ' DESC"

                strSQL = "SELECT FDP.* FROM FDIntPaymentsTbl FDP ,FDDetailsTbl FD WHERE FD.FDNo='" & strFDNo & "' AND FD.FDAdditionalDetailID=FDP.FDAdditionalDetailID  ORDER BY SlNo ASC" ' DESC"

                _dtInterest = fnExecuteQuery(strSQL, 2)

            End If
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetDoubleThriableLakshadipathiDetails(ByVal strFDNo As String) As Boolean

        'strSQL = "SELECT  P.*, FD.*,S.* FROM FDDetailsTbl FD, PersonTbl P,FDSchemeTbl S WHERE FD.PersonNo=P.PersonNo AND FD.FDNo='" & strFDNo & "'and FD.FDScheme=S.SchemeCode"
           strSQL = "SELECT P.*, FD.*,FDA.* FROM FDDetailsTbl FD,PersonTbl P,fdadditionaldetailstbl FDA WHERE FD.PersonNo=P.PersonNo AND FD.FDNo='" & strFDNo & "' AND FD.FDAdditionalDetailID=FDA.FDAdditionalDetailID "
        _dtFDTable = fnExecuteQuery(strSQL, 2)
        If _dtFDTable.Rows.Count > 0 Then
            strSQL = "SELECT FDC.* FROM FDCumulativeIntTbl  FDC ,FDDetailsTbl FD WHERE FD.FDNo='" & strFDNo & "'AND FD.FDAdditionalDetailID=FDC.FDAdditionalDetailID  ORDER BY SlNo ASC" 'DESC"

            _dtInterest = fnExecuteQuery(strSQL, 2)

            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnUpdateDueStatus(ByVal strFDNo As String, ByVal lngVoucherNo As Long, ByVal ReceiptNo As String, ByVal colDate As Date) As Boolean

        Dim dtRow As DataRow
        Dim intCounter As Integer = 0
        Dim strSQLCollection As New Collections.Specialized.StringCollection



        'strSQL = "SELECT  P.*, FD.*,S.* FROM FDDetailsTbl FD, PersonTbl P,FDSchemeTbl S WHERE FD.PersonNo=P.PersonNo AND FD.FDNo='" & strFDNo & "'and FD.FDScheme=S.SchemeCode"
        strSQL = "SELECT P.*, FD.*,S.*,FDA.* FROM FDDetailsTbl FD,PersonTbl P,FDSchemeTbl S,fdadditionaldetailstbl FDA WHERE FD.PersonNo=P.PersonNo AND FD.FDNo='" & strFDNo & "' AND FD.FDAdditionalDetailID=FDA.FDAdditionalDetailID AND FDA.FDScheme=S.SchemeCode"
        _dtFDTable = fnExecuteQuery(strSQL, 2)

        If _dtFDTable.Rows.Count > 0 Then
            If _dtFDTable.Rows(0).Item("schemeType") = "C" Then

                strSQL = "SELECT * FROM FDCumulativeIntTbl WHERE FDNo='" & strFDNo & "'and  status='Due' ORDER BY SlNo ASC"
                _dtInterest = fnExecuteQuery(strSQL, 2)
                For Each dtRow In _dtInterest.Rows
                    strSQL = "Update FDCumulativeIntTbl set VoucherNo ='" & lngVoucherNo & "',status='Paid',RefNo = '" & ReceiptNo & "',CollectDate='" & Format(colDate, "yyyy-MM-dd") & "'  where Fdno='" & strFDNo & "'"
                    strSQLCollection.Add(strSQL)
                    intCounter += 1
                Next
                fnExecuteNonQuery(strSQLCollection)

            ElseIf _dtFDTable.Rows(0).Item("schemeType") = "N" Then
                strSQL = "SELECT * FROM FDIntPaymentsTbl WHERE FDNo='" & strFDNo & "' and  status='Due' ORDER BY SlNo ASC"
                _dtInterest = fnExecuteQuery(strSQL, 2)
                For Each dtRow In _dtInterest.Rows
                    strSQL = "Update fdintpaymentstbl set status='Paid',CollectDate='" & Format(colDate, "yyyy-MM-dd") & "',VoucherNo ='" & lngVoucherNo & "',RefNo = '" & ReceiptNo & "'  where Fdno='" & strFDNo & "'"
                    strSQLCollection.Add(strSQL)
                    intCounter += 1
                Next
                fnExecuteNonQuery(strSQLCollection)
            End If

            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnCloseFDAccount(ByVal strAccNo As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Update fdDetailstbl set Status = 'C' where FDNo = '" & strAccNo & "'"
        Return fnExecuteNonQuery(strSQL, objTrans)

        strSQL = "Update fdadditionaldetailstbl set Status = 'C' Where FDAdditionalDetailID in(select FDAdditionalDetailID from fddetailstbl where FDNo = '" & strAccNo & "') "
        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnGetFDDet(ByVal strAccNo As String) As Boolean

        strSQL = "select * from fdDetailstbl FD ,fdadditionaldetailstbl FDA where FD.FDNo= '" & strAccNo & "' and FD.FDAdditionalDetailID=FDA.FDAdditionalDetailID"

        _dtfdDet = fnExecuteQuery(strSQL, 2)

        If _dtfdDet.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetFDRenewalDet(ByVal strAccNo As String) As Boolean

        'strSQL = "select fd.*,p.* from fdDetailstbl fd, Persontbl p where fd.PersonNo = P.PersonNo and fd.FDNo = '" & strAccNo & "'"
        strSQL = "SELECT P.*, FD.*,S.*,FDA.* FROM FDDetailsTbl FD,PersonTbl P,FDSchemeTbl S,fdadditionaldetailstbl FDA WHERE FD.PersonNo=P.PersonNo AND FD.FDNo='" & strAccNo & "' AND FD.FDAdditionalDetailID=FDA.FDAdditionalDetailID AND FDA.FDScheme=S.SchemeCode"

        _dtFDDetails = fnExecuteQuery(strSQL, 2)

        If _dtFDDetails.Rows.Count > 0 Then

            Return True
        Else
            strSQL = "SELECT P.*, FD.*,FDA.* FROM FDDetailsTbl FD,PersonTbl P,fdadditionaldetailstbl FDA WHERE FD.PersonNo=P.PersonNo AND FD.FDNo='" & strAccNo & "' AND FD.FDAdditionalDetailID=FDA.FDAdditionalDetailID"
            _dtFDDetails = fnExecuteQuery(strSQL, 2)
            If _dtFDDetails.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Public Function fnUpdateMaturity(ByVal strFDNo As String, ByVal objTrans As IDbTransaction) As Boolean
        ''Query for  update a fdinteresttbl and fdcumulativetbl to Renewal column to close
        Dim TypeOfFD As Boolean
        strSQL = "update fdintpaymentstbl set Renewal = 'close' where FDAdditionalDetailID in(select FDAdditionalDetailID from fddetailstbl where FDNo = '" & strFDNo & "') "
        TypeOfFD = fnExecuteNonQuery(strSQL)
        If TypeOfFD = False Then
            strSQL = "update fdcumulativeinttbl set Renewal = 'close' where FDAdditionalDetailID in(select FDAdditionalDetailID from fddetailstbl where FDNo = '" & strFDNo & "') "
            TypeOfFD = fnExecuteNonQuery(strSQL)
        End If

        ''Query for update a fdadditional detail table
        strSQL = "Update fdadditionaldetailstbl set Status = 'C' Where FDAdditionalDetailID in(select FDAdditionalDetailID from fddetailstbl where FDNo = '" & strFDNo & "') "
        TypeOfFD = fnExecuteNonQuery(strSQL, objTrans)

        GetMaxFDAdditionalDetailID()

        If fnInsertAdditionalDetail(objTrans) Then
            If fnUpdateFDdetail(objTrans) Then
                fnAddRenewalInterestTable(objTrans)
                Return True
            End If
        End If

        Return False

    End Function

    Public Function fnUpdateFDdetail(ByVal objTrans As IDbTransaction)
        'Dim a As Boolean
        strSQL = "update fddetailstbl set FDAdditionalDetailID='" & _intFDAdditionalDetailID & "',Status='A'where FDDetailID='" & _intFDDetailID & "' and FDNo='" & _strFDNo & "'"
        Return fnExecuteNonQuery(strSQL, objTrans)
        'a = fnExecuteNonQuery(strSQL, objTrans)
    End Function

    Public Function fnFdRenewal(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Insert into fdrenewaltbl(oldFDNo,NewFDNo,RenewalDate,ReceiptNo,OldFDAdditionalDetailID) values ('" & _strFDNo & "','" & _strNewFdNo & "','" & Format(_datFDDate, "yyyy-MM-dd") & "','" & _strReceiptNo & "','" & _intOldFDAdditionDetailID & "')"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnApplyIntrSet(ByVal objTrans As IDbTransaction) As Boolean

        Dim drRow As DataRow

        For Each drRow In _dtFDMasterTbl.Rows

            strSQL = "Insert fdmasterintsettings values('" & drRow(0) & "','" & drRow(1) & "','" & drRow(2) & "','" & drRow(3) & "')"

            fnExecuteNonQuery(strSQL, objTrans)

        Next

        Return True

    End Function

    Public Function fnCheckScheme() As Boolean

        strSQL = "select * from fdschemetbl where SchemeCode='" & SchemeCode & "'"

        _dtFDMasterDetailTbl = fnExecuteQuery(strSQL, 2)

        If _dtFDMasterDetailTbl.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnCheckFDScheme(ByVal strFDNo As String) As Boolean

        'strSQL = "select FD.FDscheme,S.SchemeName,S.SchemeType from fddetailstbl FD,fdschemetbl S where FD.FDscheme=S.SchemeCode and FD.FDNo='" & strFDNo & "' "
        strSQL = "SELECT FD.*,S.*,FDA.* FROM FDDetailsTbl FD,FDSchemeTbl S,fdadditionaldetailstbl FDA WHERE FD.FDNo='" & strFDNo & "' AND FD.FDAdditionalDetailID=FDA.FDAdditionalDetailID AND FDA.FDScheme=S.SchemeCode"


        _dtFDMasterDetailTbl = fnExecuteQuery(strSQL, 2)

        If _dtFDMasterDetailTbl.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

#Region "FD MasterSetting"

    Public Function fnAddNewScheme(ByVal objTrans As IDbTransaction) As Boolean
        strSQL = "Insert into fdSchemeTbl(SchemeCode,SchemeName,SchemeType,CalType,IntPostingPrd,SCROI,ReductionInt,Active) values('" & _intSchemeCode & "','" & _strSchemeName & "','" & _chrFDType & "','" & _chrCalType & "','" & _strPostingPeriod & "','" & _dblSeniorCROI & "','" & _dblReductionIterest & "','" & _chrStatus & "')"
        Return fnExecuteNonQuery(strSQL, objTrans)
    End Function

    Public Function fnUpdateScheme(ByVal objTrans As IDbTransaction) As Boolean
        strSQL = " Update  fdschemetbl set SchemeName='" & _strSchemeName & "',SchemeType='" & _chrFDType & "',CalType='" & _chrCalType & "',IntPostingPrd='" & _strPostingPeriod & "',SCROI='" & _dblSeniorCROI & "',ReductionInt='" & _dblReductionIterest & "',Active='" & _chrStatus & "' where SchemeCode='" & _intSchemeCode & "'"
        Return fnExecuteNonQuery(strSQL, objTrans)
    End Function

    Public Function fnGetScheme() As Boolean

        strSQL = "Select * from fdschemetbl "
        _dtFDMasterTbl = fnExecuteQuery(strSQL, 2)

        If _dtFDMasterTbl.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnDeleteIntrSettings(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Delete from fdmasterintsettings where SchemeCode='" & SchemeCode & "'"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnDeleteScheme() As Boolean

        strSQL = "Delete from fdschemetbl where SchemeCode='" & SchemeCode & "' "
        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetMasterSetting() As Boolean

        strSQL = "select * from fdmasterintsettings where SchemeCode='" & SchemeCode & "'"

        _dtFDMasterTbl = fnExecuteQuery(strSQL, 2)

        If _dtFDMasterTbl.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetSchemeCode(ByVal fdNo As String) As Boolean

        strSQL = "select fd.FDScheme,fd.IntMode,fd.FDAmount from fdadditionaldetailstbl fd,fddetailstbl f where fd.FDAdditionalDetailID=f.FDAdditionalDetailID and f.FDNo='" & fdNo & "'"

        _dtFDSchemeTbl = fnExecuteQuery(strSQL, 2)

        If _dtFDSchemeTbl.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetROI(ByVal Period As String) As Boolean

        strSQL = "SELECT ROI FROM fdmasterintsettings WHERE FromPeriod  <= '" & Period & "' and ToPeriod  >= '" & Period & "' and  SchemeCode='" & SchemeCode & "'"

        _dtFDMasterTbl = fnExecuteQuery(strSQL, 2)

        If _dtFDMasterTbl.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetSBAccount(ByVal fdno As String) As Boolean

        strSQL = "SELECT fad.AccountNo FROM fdadditionaldetailstbl fad,fddetailstbl fd WHERE fad.FDAdditionalDetailID=fd.FDAdditionalDetailID and fd.FDNo='" & fdno & "'"
        SBdetailsTable = fnExecuteQuery(strSQL, 2)

        If SBdetailsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetPrematureROI(ByVal Period As String, ByVal SchemeCode As String) As Boolean

        strSQL = "SELECT fm.ROI FROM fdmasterintsettings fm WHERE fm.FromPeriod  <= '" & Period & "' and fm.ToPeriod  >= '" & Period & "' and  fm.SchemeCode='" & SchemeCode & "'"

        PrematureROITbl = fnExecuteQuery(strSQL, 2)

        If PrematureROITbl.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetPaidInt(ByVal fdNo As String) As Boolean

        strSQL = "SELECT sum(Amount) as paidAmount  FROM fdintpostingstbl WHERE FDNo='" & fdNo & "'"

        PaidIntTable = fnExecuteQuery(strSQL, 2)

        If PaidIntTable.Rows(0).Item("paidAmount").ToString() <> "" Then
            Return True
        Else
            Return False
        End If

    End Function

#End Region



    Public Function fnDuplicateFD(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Insert into fdduplicatetbl(FDNo,Date,Fee,ReceiptNo) values ('" & _strFDNo & "','" & Format(_datFDDuplicateDate, "yyyy-MM-dd") & "','" & _dblFDDuplicateFee & "','" & _strReceiptNo & "')"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnCheckFDRefNo(ByVal strRefNo As String) As Boolean

        strSQL = "select * from fdDetailstbl where ReceiptNo = '" & strRefNo & "'"

        _dtRef = fnExecuteQuery(strSQL, 2)

        If _dtRef.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetLoanDet(ByVal strFDNo As String) As Boolean

        strSQL = "select * from loanDetailstbl where FDNo = '" & strFDNo & "'"

        _dtFDLoanDet = fnExecuteQuery(strSQL, 2)

        If _dtFDLoanDet.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function getRenewalFDDetails() As Boolean
        Dim IsExist As Boolean
        strSQL = "select FDD.*,FDAD.* from fdadditionaldetailstbl FDAD,fddetailstbl FDD where FDD.FDNo = '" & _strFDNo & "'  and FDAD.FDAdditionalDetailID='" & _intFDAdditionalDetailID & "'"

        _dtRenewalFDTable = fnExecuteQuery(strSQL, 2)

        If _dtRenewalFDTable.Rows.Count > 0 Then
            strSQL = "select * from fdintpaymentstbl where FDAdditionalDetailID='" & _intFDAdditionalDetailID & "'"
            _dtInterest = fnExecuteQuery(strSQL, 2)
            If _dtInterest.Rows.Count > 0 Then
                Return True
            Else
                strSQL = "select * from fdcumulativeinttbl where FDAdditionalDetailID='" & _intFDAdditionalDetailID & "'"
                _dtInterest = fnExecuteQuery(strSQL, 2)
                If _dtInterest.Rows.Count > 0 Then
                    Return True
                End If
            End If
        Else
            Return False
        End If
    End Function


    Public Function fnUpdateStatus(ByVal strAccNo As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Update fdDetailstbl set status = 'C' where FDNo = '" & strAccNo & "'"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnPreMatureAcc(ByVal lngVoucherNo As Long, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Insert into fdforeclosuretbl(fdNo,Date,IntPaid,ROI,IntPayable,IntDiff,AmountPaid,RefNo,VoucherNo,Remarks)values ('" & _strFDNo & "','" & Format(_datFDDate, "yyyy-MM-dd") & "','" & _dblIntPaid & "','" & _dblFDROI & "','" & _dblIntPayable & "','" & _dblIntDiff & "','" & _dblFDAmtPaid & "','" & _strReceiptNo & "','" & lngVoucherNo & "','" & _strRemarks & "')"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnFDReceiptNo(ByVal strFDType As String, ByVal strRefNo As String) As Boolean

        If strFDType = "C" Then
            strSQL = "select * from fdcumulativeinttbl where RefNo = '" & strRefNo & "'"
            _datIntPosting = fnExecuteQuery(strSQL, 2)
            If _datIntPosting.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Else
            strSQL = "select * from fdintpaymentstbl where RefNo = '" & strRefNo & "'"
            _datIntPosting = fnExecuteQuery(strSQL, 2)
            If _datIntPosting.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        End If

    End Function

    Public Function fnGetNewFDNo() As String

        strSQL = "SELECT max(FDNo) as MaxNo FROM FDDetailsTbl "

        _dtFDTable = fnExecuteQuery(strSQL, 2)

        If IsDBNull(_dtFDTable.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return _dtFDTable.Rows(0).Item("MaxNo")
        End If

    End Function

    Public Function fnGetInterestDet(ByVal strFDNo As String) As Boolean

        'strSQL = "select sum(IntAmount) as Amount ,Status from fdcumulativeinttbl where FDNo='" & strFDNo & "' group by Status "

        strSQL = "select sum(FDC.IntAmount) as Amount ,FDC.Status from fdcumulativeinttbl FDC,FDDetailsTbl FD where FD.FDNo='" & strFDNo & "' and FDC.FDAdditionalDetailID=FD.FDAdditionalDetailID group by Status "
        _datIntPosting = fnExecuteQuery(strSQL, 2)
        If _datIntPosting.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function getRenewalFDs() As Boolean

        'strSQL = "select sum(IntAmount) as Amount ,Status from fdcumulativeinttbl where FDNo='" & strFDNo & "' group by Status "

        strSQL = "select OldFDNo,RenewalDate,OldFDAdditionalDetailID from fdrenewaltbl "
        _dtRenewalFDTable = fnExecuteQuery(strSQL, 2)
        If _dtRenewalFDTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetNonInterestDet(ByVal strFDNo As String) As Boolean

        'strSQL = "select sum(IntAmount) as Amount ,Status from fdintpaymentstbl where FDNo='" & strFDNo & "' group by Status "

        strSQL = "select sum(FDP.IntAmount) as Amount ,FDP.Status from fdintpaymentstbl FDP,FDDetailsTbl FD where FD.FDNo='" & strFDNo & "' and FDP.FDAdditionalDetailID=FD.FDAdditionalDetailID group by Status "
        _datIntPosting = fnExecuteQuery(strSQL, 2)
        If _datIntPosting.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnGetProvision(ByVal dtpDate As Date, ByVal strType As String) As Boolean
        'strSQL = "SELECT FD.FDNo,P.Name,FDA.FDDate,FDA.FDAmount,FDC.IntAmount,FDC.IntDate,FDC.CumuAmount,FDA.TransferAccountNo, FD.FDAdditionalDetailID,FDC.Status FROM fddetailstbl FD INNER JOIN fdadditionaldetailstbl FDA ON FDA.FDAdditionalDetailID=FD.FDAdditionalDetailID INNER JOIN  fdcumulativeinttbl FDC ON FD.FDAdditionalDetailID=FDC.FDAdditionalDetailID INNER JOIN persontbl P ON P.PersonNo=FD.PersonNo WHERE FD.Status='A' AND  FDC.Status='Due' AND  FDC.IntDate='" & Format(dtpDate, "yyyy-MM-dd") & "' OR FDC.Status='Provision' AND FD.FDNo like '" & strType & "%'  "
        strSQL = "SELECT FD.FDNo,P.Name,FDA.FDDate,FDA.FDAmount,FDC.IntAmount,FDC.IntDate,FDA.TransferAccountNo, FD.FDAdditionalDetailID,FDC.Status,S.SchemeType  FROM fddetailstbl FD INNER JOIN fdadditionaldetailstbl FDA ON FDA.FDAdditionalDetailID=FD.FDAdditionalDetailID INNER JOIN  fdcumulativeinttbl FDC ON FD.FDAdditionalDetailID=FDC.FDAdditionalDetailID INNER JOIN persontbl P ON P.PersonNo=FD.PersonNo INNER JOIN fdschemetbl S ON S.SchemeCode=FDA.FDscheme WHERE FD.Status='A' AND  FDC.Status='Due' AND  FDC.IntDate='" & Format(dtpDate, "yyyy-MM-dd") & "'  AND FD.FDNo like '" & strType & "%'  "
        strSQL = strSQL & " UNION SELECT FD.FDNo,P.Name,FDA.FDDate,FDA.FDAmount,FDC.IntAmount,FDC.IntDate,FDA.TransferAccountNo,FD.FDAdditionalDetailID, FDC.Status,S.SchemeType  FROM fddetailstbl FD INNER JOIN fdadditionaldetailstbl FDA ON FDA.FDAdditionalDetailID=FD.FDAdditionalDetailID INNER JOIN  fdintpaymentstbl FDC ON FD.FDAdditionalDetailID=FDC.FDAdditionalDetailID INNER JOIN persontbl P ON P.PersonNo=FD.PersonNo INNER JOIN fdschemetbl S ON S.SchemeCode=FDA.FDscheme  WHERE FD.Status='A' AND  FDC.Status='Due'  AND  FDC.IntDate='" & Format(dtpDate, "yyyy-MM-dd") & "'  AND FD.FDNo like '" & strType & "%' "

        _datIntPosting = fnExecuteQuery(strSQL, 2)
        If _datIntPosting.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnGetPayment(ByVal dtpDate As Date, ByVal strType As String) As Boolean
        strSQL = "SELECT FD.FDNo,P.Name,FDA.FDDate,FDA.FDAmount,FDC.IntAmount,FDC.IntDate,FD.FDAdditionalDetailID,FDA.TransferAccountNo, FDC.Status,S.SchemeType FROM fddetailstbl FD INNER JOIN fdadditionaldetailstbl FDA ON FDA.FDAdditionalDetailID=FD.FDAdditionalDetailID INNER JOIN  fdintpaymentstbl FDC ON FD.FDAdditionalDetailID=FDC.FDAdditionalDetailID INNER JOIN persontbl P ON P.PersonNo=FD.PersonNo INNER JOIN fdschemetbl S ON S.SchemeCode=FDA.FDscheme WHERE FD.Status='A' AND  FDC.IntDate='" & Format(dtpDate, "yyyy-MM-dd") & "' AND FDC.Status='Provision' AND FD.FDNo like '" & strType & "%' "
        _datIntPosting = fnExecuteQuery(strSQL, 2)
        If _datIntPosting.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


#Region "Deleting Content"

    Public Function fnDeleteData(ByVal strFDNo As String) As Boolean

        strSQL = "SELECT VoucherNo,VDate FROM  fasvouchersubtbl where LedgerNo='14' and AccountNo='" & strFDNo & "'"
        strSQL &= "UNION SELECT VoucherNo,VDate FROM  fasvouchersubtbl where LedgerNo='27' and AccountNo='" & strFDNo & "'"
        _dtFDTable = fnExecuteQuery(strSQL, 2)
        If _dtFDTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnDeleteFD(ByVal strFDNo As String) As Boolean

        strSQL = "DELETE from fddetailstbl where FDNo='" & strFDNo & "'"
        Return fnExecuteNonQuery(strSQL)

    End Function

    Function fnDeleteMain(ByVal strVouchreNo As Integer, ByVal dtpVDate As Date) As Boolean

        strSQL = "DELETE  from fasvouchermaintbl where VoucherNo='" & strVouchreNo & "' and VDate='" & Format(dtpVDate, "yyyy-MM-dd") & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function


    Function fnDeleteSub(ByVal strVouchreNo As Integer, ByVal dtpVDate As Date) As Boolean

        strSQL = "DELETE  from fasvouchersubtbl where VoucherNo='" & strVouchreNo & "' and VDate='" & Format(dtpVDate, "yyyy-MM-dd") & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function


#End Region


#End Region

End Class

