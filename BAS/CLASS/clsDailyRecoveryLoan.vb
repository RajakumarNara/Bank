Public Class clsDailyRecoveryLoan
    Inherits clsPerson

#Region "Variables"

    Private _PersonNo As Long
    Private _strFDNo As String
    Private _strSBNo As String
    Private _strMemberNo As String

    'person Number Comes from clsperson

    Private _datDRLoanData As Date
    Private _dtDRLoan As DataTable
    Private _dtDRLoanDet As DataTable
    Private _dtDRLoanCust As DataTable

    Private _intBalance As Double
    Private _dblROI As Double
    Private _strAccStatus As String
    Private _dtpAppDate As Date
    Private _intIntAmount As Double
    Private _strReciptNo As String
    Private _StrRemarks As String
    Private _chrLoanType As Char

    Private _strWitnessPerson1 As String
    Private _strWitnessPerson2 As String
    Private _strWitnessAddress1 As String
    Private _strWitnessAddress2 As String

    'Asset Details
    Private _datDueDate As Date
    Private _strSubsidy As String
    Private _intDisbAmt As Double
    Private _dtpSancDate As Date
    Private _lngSancNo As String
    Private _strMobileNo2 As String

    Private _strLoanNo As String
    Private _dblMonthlyIncome As Double
    Private _dblRemaningAmt As Double
    Private _intExpectedAmount As Integer
    Private _intSanctionedAmount As Integer
    Private _intInstPrinciple As Integer
    Private _strModeOfPayment As String
    Private _strInstallment As String
    Private _strStatus As String
    Private _datLastPaid As Date
    Private _intNOI As Integer

    Private _strReason As String
    Private _chrConditions1 As Char
    Private _chrConditions2 As Char
    Private _chrConditions3 As Char
    Private _chrConditions4 As Char
    Private _chrConditions5 As Char

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

    'Public Property Remarks() As String
    '    Get
    '        Return _StrRemarks
    '    End Get
    '    Set(ByVal Value As String)
    '        _StrRemarks = Value
    '    End Set
    'End Property
    Public Property LoanType() As Char
        Get
            Return _chrLoanType
        End Get
        Set(ByVal Value As Char)
            _chrLoanType = Value
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
    Public Property Balance() As Double
        Get
            Return _intBalance
        End Get
        Set(ByVal Value As Double)
            _intBalance = Value
        End Set
    End Property
    Public Property DisbAmt() As Integer
        Get
            Return _intDisbAmt
        End Get
        Set(ByVal Value As Integer)
            _intDisbAmt = Value
        End Set
    End Property

    Public Property SancDate() As Date
        Get
            Return _dtpSancDate
        End Get
        Set(ByVal Value As Date)
            _dtpSancDate = Value
        End Set
    End Property

    Public Property sancNo() As String
        Get
            Return _lngSancNo
        End Get
        Set(ByVal Value As String)
            _lngSancNo = Value
        End Set
    End Property

    Public Property MobileNo2() As String
        Get
            Return _strMobileNo2
        End Get
        Set(ByVal Value As String)
            _strMobileNo2 = Value
        End Set
    End Property

    Public Property RIO() As Double
        Get
            Return _dblROI
        End Get
        Set(ByVal Value As Double)
            _dblROI = Value
        End Set
    End Property

    Public Property AccAtatus() As String
        Get
            Return _strAccStatus
        End Get
        Set(ByVal Value As String)
            _strAccStatus = Value
        End Set
    End Property
    Public Property AppDate() As Date
        Get
            Return _dtpAppDate
        End Get
        Set(ByVal Value As Date)
            _dtpAppDate = Value
        End Set
    End Property

    Public Property IntrestAmount() As Double
        Get
            Return _intIntAmount
        End Get
        Set(ByVal Value As Double)
            _intIntAmount = Value
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
            Return _strWitnessPerson2
        End Get
        Set(ByVal Value As String)
            _strWitnessPerson2 = Value
        End Set
    End Property

    Public Property WitnessPersonAddress1() As String
        Get
            Return _strWitnessAddress1
        End Get
        Set(ByVal Value As String)
            _strWitnessAddress1 = Value
        End Set
    End Property

    Public Property WitnessPersonAddress2() As String
        Get
            Return _strWitnessAddress2
        End Get
        Set(ByVal Value As String)
            _strWitnessAddress2 = Value
        End Set
    End Property
    Public Property DRLoanCusttable() As DataTable
        Get
            Return _dtDRLoanCust
        End Get
        Set(ByVal Value As DataTable)
            _dtDRLoanCust = Value
        End Set
    End Property
    Public Property DRLoanTable() As DataTable
        Get
            Return _dtDRLoan
        End Get
        Set(ByVal Value As DataTable)
            _dtDRLoan = Value
        End Set
    End Property

    Public Property DRLDetailstable() As DataTable
        Get
            Return _dtDRLoanDet
        End Get
        Set(ByVal Value As DataTable)
            _dtDRLoanDet = Value
        End Set
    End Property


    ''''''''''''''''''''''''''''''''''''''''''''''

    Public Property LoanNo() As String
        Get
            Return _strLoanNo
        End Get
        Set(ByVal Value As String)
            _strLoanNo = Value
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
    Public Property MonthlyIncome() As Double
        Get
            Return _dblMonthlyIncome
        End Get
        Set(ByVal Value As Double)
            _dblMonthlyIncome = Value
        End Set
    End Property
    Public Property ExpectedAmount() As Integer
        Get
            Return _intExpectedAmount
        End Get
        Set(ByVal Value As Integer)
            _intExpectedAmount = Value
        End Set
    End Property

    Public Property Sanctioned() As Integer
        Get
            Return _intSanctionedAmount
        End Get
        Set(ByVal Value As Integer)
            _intSanctionedAmount = Value
        End Set
    End Property

    Public Property LastPaidDate() As Date
        Get
            Return _datLastPaid
        End Get
        Set(ByVal Value As Date)
            _datLastPaid = Value
        End Set
    End Property

    Public Property DueDate() As Date
        Get
            Return _datDueDate
        End Get
        Set(ByVal Value As Date)
            _datDueDate = Value
        End Set
    End Property

    Public Property Subsidy() As String
        Get
            Return _strSubsidy
        End Get
        Set(ByVal Value As String)
            _strSubsidy = Value
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

    Public Property Installments() As String
        Get
            Return _strInstallment
        End Get
        Set(ByVal Value As String)
            _strInstallment = Value
        End Set
    End Property

    Public Property ModeOfPayment() As String
        Get
            Return _strModeOfPayment
        End Get
        Set(ByVal Value As String)
            _strModeOfPayment = Value
        End Set
    End Property

    Public Property InstPrinciple() As Integer
        Get
            Return _intInstPrinciple
        End Get
        Set(ByVal Value As Integer)
            _intInstPrinciple = Value
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
    Public Property Conditons1() As Char
        Get
            Return _chrConditions1
        End Get
        Set(ByVal Value As Char)
            _chrConditions1 = Value
        End Set
    End Property

    Public Property Conditons2() As Char
        Get
            Return _chrConditions2
        End Get
        Set(ByVal Value As Char)
            _chrConditions2 = Value
        End Set
    End Property

    Public Property Conditons3() As Char
        Get
            Return _chrConditions3
        End Get
        Set(ByVal Value As Char)
            _chrConditions3 = Value
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

#End Region

#Region " DailyRecovery Loan"



    Public Function fnAddODLAccount(ByVal objTrans As IDbTransaction) As Boolean

        If fnCheckPerson() Then

            If fnUpdatePerson(objTrans) Then

                If fnInsertDRLAccount(objTrans) Then

                    Return fnInsertDRLoanDet(objTrans)

                End If

            End If

        Else

            If fnAddPerson() Then

                If fnInsertDRLAccount(objTrans) Then

                    If fnInsertDRLoanDet(objTrans) Then

                        Return True

                    Else

                        fnDeletePerson(objTrans)

                        fnDeleteLoanDet(LoanNo, objTrans)

                        fnDeleteDRLDetails(LoanNo, objTrans)

                    End If

                End If

            End If

        End If

    End Function

    Public Function fnInsertDRLAccount(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "insert into loanDetailstbl(LoanNo,PersonNo,CustomerID,SBNo,LoanType,ExpAmount,SancAmount,DisbAmount,ApplDate,SancDate,DueDate,SancNo,ROI,NOI,InstPrinciple,RepayMode,Purpose,Type,Balance,LastPaidDate,Remarks,Status,FDNo,ReceiptNo)"
        strSQL = strSQL & " values('" & _strLoanNo & "','" & PersonNo & "','" & _strMemberNo & "','" & _strSBNo & "','" & _chrLoanType & "','" & _intExpectedAmount & "','" & _intSanctionedAmount & "','" & _intDisbAmt & "','" & Format(_dtpAppDate, "yyyy-MM-dd") & "','" & Format(_dtpSancDate, "yyyy-MM-dd") & "','" & Format(_datDueDate, "yyyy-MM-dd") & "','" & _lngSancNo & "','" & _dblROI & "','" & _intNOI & "','"
        strSQL = strSQL & _intInstPrinciple & "','" & _strModeOfPayment & "','" & _strReason & "','" & _strInstallment & "','" & _intBalance & "','" & Format(_datLastPaid, "yyyy-MM-dd") & "','" & _StrRemarks & "','" & _strAccStatus & "','" & _strFDNo & "','" & _strReciptNo & "')"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnChekDRLAccount(ByVal strLoanNo As String) As Boolean

        strSQL = "select * from loanDetailstbl where loanNo = '" & strLoanNo & "'"

        _dtDRLoan = fnExecuteQuery(strSQL, 2)

        If _dtDRLoan.Rows.Count > 0 Then

            Return True
        Else
            Return False

        End If
    End Function

    Public Function fnDeleteLoanDet(ByVal strLoanNo As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "delete from loandetailstbl where loanno = '" & strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnUpdateLoanDetails(ByVal strLoanNo As String) As Boolean

        strSQL = "UPDATE loandetailsTbl SET CustomerID = '" & _strMemberNo & "',personNo = '" & PersonNo & "', sbno = '" & _strSBNo & "',LoanType='" & _chrLoanType & "', expAmount='" & _intExpectedAmount & "', sancamount='" & _intSanctionedAmount & "',ApplDate = '" & Format(_dtpAppDate, "yyyy-MM-dd") & "',SancDate='" & Format(_dtpSancDate, "yyyy-MM-dd") & "',DueDate = '" & Format(_datDueDate, "yyyy-MM-dd") & "',SancNo='" & _lngSancNo & "', RepayMode  ='" & _strModeOfPayment & "', ROI='" & _dblROI & "', NOI = '" & _intNOI & "',InstPrinciple = '" & _intInstPrinciple & "',Purpose ='" & _strReason & "', Remarks = '" & _StrRemarks & "' WHERE  LoanNo='" & strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetLoanDetails(ByVal strLoanNo As String) As Boolean

        strSQL = "SELECT P.*, v.* FROM Loandetailstbl v, PersonTbl P WHERE P.PersonNo=v.PersonNo  and v.LoanNo='" & strLoanNo & "' "

        _dtDRLoanDet = fnExecuteQuery(strSQL, 2)

        If _dtDRLoanDet.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function fnGetDRLoanCust() As Boolean

        strSQL = "select P.*, S.* FROM loandetailstbl S, PersonTbl P WHERE P.PersonNo=S.PersonNo and loanNo like 'SD%'"

        _dtDRLoanCust = fnExecuteQuery(strSQL, 2)

        If _dtDRLoanCust.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function fnInsertDRLoanDet(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Insert into dailyrecoveryloantbl (LoanNo,MonthlyIncome,MobileNo2,Conditions1,Conditions2,Conditions3) values ('" & _strLoanNo & "','" & _dblMonthlyIncome & "','" & _strMobileNo2 & "','" & _chrConditions1 & "','" & _chrConditions2 & "','" & _chrConditions3 & "')"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnDeleteDRLDetails(ByVal strLoanNo As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Delete from dailyrecoveryloantbl where LoanNo = '" & strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnUpDateDRLDet(ByVal strLoanNo As String) As Boolean
        If fnUpdatePerson() Then
            strSQL = "update dailyrecoveryloantbl set MonthlyIncome='" & _dblMonthlyIncome & "',MobileNo2='" & _strMobileNo2 & "',Conditions1 = '" & _chrConditions1 & "',Conditions2 = '" & _chrConditions2 & "',Conditions3 = '" & _chrConditions3 & "' where loanno = '" & strLoanNo & "'"
            Return fnExecuteNonQuery(strSQL)
        Else
            Return False

        End If

    End Function

    Public Function fnGetDRLoanDet(ByVal strLoanNo As String) As Boolean

        strSQL = "Select * from dailyrecoveryloantbl where loanno = '" & strLoanNo & "'"

        _dtDRLoanDet = fnExecuteQuery(strSQL, 2)

        If _dtDRLoanDet.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

#End Region

End Class
