
Public Class clsDemandLoanDetails
    Inherits clsPerson

#Region "Variables"

    Private _strLoanNo As String
    Private _PersonNo As Long
    Private _strSBNo As String
    Private _strMemberNo As String

    'person Number Comes from clsperson
    Private _datMediumLoanData As Date
    Private _strReciptNo As String
    Private _dtDemandLoan As DataTable
    Private _dtDemandLoanDet As DataTable
    Private _dtDemandLoanCust As DataTable

    Private _intExpectedAmount As Integer
    Private _intSanctionedAmount As Integer
    Private _dblROI As Double
    Private _strInstallment As String
    Private _strModeOfPayment As String
    Private _strReason As String
    Private _strWitnessPerson1 As String
    Private _strWitnessPerson2 As String
    Private _strWitnessAddress1 As String
    Private _strWitnessAddress2 As String
    Private _intInstPrinciple As Integer
    Private _datDueDate As Date
    Private _strSubsidy As String
    Private _intBalance As Integer
    Private _intNOI As Integer
    Private _strStatus As String
    Private _intDisbAmt As Integer
    Private _StrRemarks As String
    Private _datLastPaid As Date

    'Asset Details

    Private _dblRemaningAmt As Double
    Private _strMortagageDet As String
    Private _StrOffice As String
    Private _StrDesignation As String
    Private _StrRepaymentDet As String
    Private _strAssetDetails As String
    Private _chrPersonalIdentification As Char
    Private _dtDLDet As DataTable

#End Region

#Region "Properties"

    Public Property LoanNo() As String
        Get
            Return _strLoanNo
        End Get
        Set(ByVal Value As String)
            _strLoanNo = Value
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
    '        Return _strRemarks
    '    End Get
    '    Set(ByVal Value As String)
    '        _strRemarks = Value
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

    Public Property DemandLoanTable() As DataTable
        Get
            Return _dtDemandLoan
        End Get
        Set(ByVal Value As DataTable)
            _dtDemandLoan = Value
        End Set
    End Property

    Public Property DemandExpectedAmount() As Integer
        Get
            Return _intExpectedAmount
        End Get
        Set(ByVal Value As Integer)
            _intExpectedAmount = Value
        End Set
    End Property

    Public Property DemandSanctioned() As Integer
        Get
            Return _intSanctionedAmount
        End Get
        Set(ByVal Value As Integer)
            _intSanctionedAmount = Value
        End Set
    End Property

    Public Property DemandROI() As Double
        Get
            Return _dblROI
        End Get
        Set(ByVal Value As Double)
            _dblROI = Value
        End Set
    End Property

    Public Property DemandDisbAmt() As Integer
        Get
            Return _intDisbAmt
        End Get
        Set(ByVal Value As Integer)
            _intDisbAmt = Value
        End Set
    End Property

    Public Property DemandInstallments() As String
        Get
            Return _strInstallment
        End Get
        Set(ByVal Value As String)
            _strInstallment = Value
        End Set
    End Property

    Public Property DemandModeOfPayment() As String
        Get
            Return _strModeOfPayment
        End Get
        Set(ByVal Value As String)
            _strModeOfPayment = Value
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

    Public Property DemandWitnessPerson1() As String
        Get
            Return _strWitnessPerson1
        End Get
        Set(ByVal Value As String)
            _strWitnessPerson1 = Value
        End Set
    End Property

    Public Property DemandWitnessPerson2() As String
        Get
            Return _strWitnessPerson2
        End Get
        Set(ByVal Value As String)
            _strWitnessPerson2 = Value
        End Set
    End Property

    Public Property DemandWitnessPersonAddress1() As String
        Get
            Return _strWitnessAddress1
        End Get
        Set(ByVal Value As String)
            _strWitnessAddress1 = Value
        End Set
    End Property

    Public Property DemandWitnessPersonAddress2() As String
        Get
            Return _strWitnessAddress2
        End Get
        Set(ByVal Value As String)
            _strWitnessAddress2 = Value
        End Set
    End Property

    Public Property DemandLoanDate() As Date
        Get
            Return _datMediumLoanData
        End Get
        Set(ByVal Value As Date)
            _datMediumLoanData = Value
        End Set
    End Property


    Public Property DemandLoanDueDate() As Date
        Get
            Return _datDueDate
        End Get
        Set(ByVal Value As Date)
            _datDueDate = Value
        End Set
    End Property

    Public Property DemandLoanInstPrinciple() As Integer
        Get
            Return _intInstPrinciple
        End Get
        Set(ByVal Value As Integer)
            _intInstPrinciple = Value
        End Set
    End Property

    Public Property DemandLoanAmtBalance() As Integer
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

    Public Property MediumLoanSubsidy() As String
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

    Public Property DemandLoanLastPaidDate() As Date
        Get
            Return _datLastPaid
        End Get
        Set(ByVal Value As Date)
            _datLastPaid = Value
        End Set
    End Property

    Public Property DemandLoanDettable() As DataTable
        Get
            Return _dtDemandLoanDet
        End Get
        Set(ByVal Value As DataTable)
            _dtDemandLoanDet = Value
        End Set
    End Property

    Public Property DemandLoanCusttable() As DataTable
        Get
            Return _dtDemandLoanCust
        End Get
        Set(ByVal Value As DataTable)
            _dtDemandLoanCust = Value
        End Set
    End Property

    Public Property DLDetailstable() As DataTable
        Get
            Return _dtDLDet
        End Get
        Set(ByVal Value As DataTable)
            _dtDLDet = Value
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

    Public Property MortagageDet() As String
        Get
            Return _strMortagageDet
        End Get
        Set(ByVal Value As String)
            _strMortagageDet = Value
        End Set
    End Property

    Public Property OfficeName() As String
        Get
            Return _StrOffice
        End Get
        Set(ByVal Value As String)
            _StrOffice = Value
        End Set
    End Property

    Public Property Designation() As String
        Get
            Return _StrDesignation
        End Get
        Set(ByVal Value As String)
            _StrDesignation = Value
        End Set
    End Property

    Public Property RePaymentDetails() As String
        Get
            Return _StrRepaymentDet
        End Get
        Set(ByVal Value As String)
            _StrRepaymentDet = Value
        End Set
    End Property

    Public Property AssetDetails() As String
        Get
            Return _strAssetDetails
        End Get
        Set(ByVal Value As String)
            _strAssetDetails = Value
        End Set
    End Property

    Public Property PersonalIdentification() As Char
        Get
            Return _chrPersonalIdentification
        End Get
        Set(ByVal Value As Char)
            _chrPersonalIdentification = Value
        End Set
    End Property


#End Region

#Region "Function"

    Public Function fnAddDLAccount(ByVal objTrans As IDbTransaction) As Boolean

        If fnCheckPerson() Then

            If fnUpdatePerson() Then

                If fnInsertDLAccount() Then

                    Return fnInsertDemandLoanDet()

                End If

            End If

        Else

            If fnAddPerson() Then

                If fnInsertDLAccount() Then

                    If fnInsertDemandLoanDet() Then

                        Return True

                    Else

                        fnDeletePerson(objTrans)

                        fnDeleteLoanDet(LoanNo)

                        fnDeleteDLDetails(LoanNo)

                    End If

                End If

            End If

        End If

    End Function

    Public Function fnInsertDLAccount() As Boolean

        strSQL = "insert into loanDetailstbl(LoanNo,PersonNo,MemberNo,SBNo,ExpAmount,SancAmount,DisbAmount,ApplDate,SancDate,DueDate,ROI,NOI,InstPrinciple,RepayMode,Purpose,Type,Balance,LastPaidDate,Remarks,Status,ReceiptNo)"
        strSQL = strSQL & " values('" & _strLoanNo & "','" & PersonNo & "','" & _strMemberNo & "','" & _strSBNo & "','" & _intExpectedAmount & "','" & _intSanctionedAmount & "','" & _intDisbAmt & "','" & Format(_datMediumLoanData, "yyyy-MM-dd") & "','" & Format(_datMediumLoanData, "yyyy-MM-dd") & "','" & Format(_datDueDate, "yyyy-MM-dd") & "','" & _dblROI & "','" & _intNOI & "','"
        strSQL = strSQL & _intInstPrinciple & "','" & _strModeOfPayment & "','" & _strReason & "','" & _strInstallment & "','" & _intBalance & "','" & Format(_datLastPaid, "yyyy-MM-dd") & "','" & _StrRemarks & "','" & _strStatus & "','" & _strReciptNo & "')"

        Return fnExecuteNonQuery(strSQL)

    End Function



    Public Function fnChekDLAccount(ByVal strLoanNo As String) As Boolean

        strSQL = "select * from loanDetailstbl where loanNo = '" & strLoanNo & "'"

        _dtDemandLoan = fnExecuteQuery(strSQL, 2)

        If _dtDemandLoan.Rows.Count > 0 Then

            Return True
        Else
            Return False

        End If
    End Function


    Public Function fnDeleteLoanDet(ByVal strLoanNo As String) As Boolean

        strSQL = "delete from loandetailstbl where loanno = '" & strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnUpdateLoanDetails(ByVal strLoanNo As String) As Boolean

        strSQL = "UPDATE loandetailsTbl SET memberNo = '" & _strMemberNo & "',personNo = '" & PersonNo & "', sbno = '" & _strSBNo & "', expAmount='" & _intExpectedAmount & "', sancamount='" & _intSanctionedAmount & "',ApplDate = '" & Format(_datMediumLoanData, "yyyy-MM-dd") & "',DueDate = '" & Format(_datDueDate, "yyyy-MM-dd") & "', RepayMode  ='" & _strModeOfPayment & "', ROI='" & _dblROI & "', NOI = '" & _intNOI & "',InstPrinciple = '" & _intInstPrinciple & "',Purpose ='" & _strReason & "',Type = '" & _strInstallment & "', Remarks = '" & _StrRemarks & "' WHERE  LoanNo='" & strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetLoanDetails(ByVal strLoanNo As String) As Boolean

        strSQL = "SELECT P.*, v.* FROM Loandetailstbl v, PersonTbl P WHERE P.PersonNo=v.PersonNo  and v.LoanNo='" & strLoanNo & "' "

        _dtDemandLoanDet = fnExecuteQuery(strSQL, 2)

        If _dtDemandLoanDet.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function fnGetDemandLoanCust() As Boolean

        strSQL = "select P.*, S.* FROM loandetailstbl S, PersonTbl P WHERE P.PersonNo=S.PersonNo and loanNo like 'DL%'"

        _dtDemandLoanCust = fnExecuteQuery(strSQL, 2)

        If _dtDemandLoanCust.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function fnInsertDemandLoanDet() As Boolean

        strSQL = "Insert into DemandLoanDettbl (LoanNo,AssetDetails,TypeOfRepayment,PersonalIdentification,OfficeName,Designation,WitnessPerson1,Address1,WitnessPerson2, Address2,Installment) values ('" & _strLoanNo & "','" & _strAssetDetails & "','" & _StrRepaymentDet & "','" & _chrPersonalIdentification & "','" & _StrOffice & "','" & _StrDesignation & "','" & _strWitnessPerson1 & "','" & _strWitnessAddress1 & "','" & _strWitnessPerson2 & "','" & _strWitnessAddress2 & "','" & _strInstallment & "')"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnDeleteDLDetails(ByVal strLoanNo As String) As Boolean

        strSQL = "Delete from DemandLoanDettbl where LoanNo = '" & strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnUpDateDLDet(ByVal strLoanNo As String) As Boolean

        strSQL = "update demandloandettbl set AssetDetails = '" & _strAssetDetails & "',TypeOfRepayment = '" & _StrRepaymentDet & "',PersonalIdentification = '" & _chrPersonalIdentification & "',OfficeName = '" & _StrOffice & "',Designation = '" & _StrDesignation & "',WitnessPerson1 = '" & _strWitnessPerson1 & "',Address1 = '" & _strWitnessAddress1 & "',WitnessPerson2 = '" & _strWitnessPerson2 & "',Address2 = '" & _strWitnessAddress2 & "',Installment = '" & _strInstallment & "' where loanno = '" & strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetDemandLoanDet(ByVal strLoanNo As String) As Boolean

        strSQL = "Select * from demandloandettbl where loanno = '" & strLoanNo & "'"

        _dtDLDet = fnExecuteQuery(strSQL, 2)

        If _dtDLDet.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

#End Region

End Class
