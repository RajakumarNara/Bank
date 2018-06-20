
Public Class clsLoanInterest

#Region "Varaibles"

    Private _strLoanType As String
    Private _lngROI As Double
    Private _lngPI As Double
    Private _datApplFromDate As Date
    Private _datApplToDate As Date
    Private _chrGoldLoan As Char
    Private _chrVehicleLoan As Char
    Private _chrHandLoan As Char
    Private _chrSuretyLoan As Char
    Private _chrOverDraft As Char
    Private _chrColHandLoan As Char
    Private _chrLoansOnDeposit As Char
    Private _chrDailyRecoveryLaon As Char
    Private _dtLoanInt As DataTable

    Private _intSlNo As Integer
    Private _chrKisanLoan As Char
    Private _chrDemandLoan As Char
    Private _chrHomeLoan As Char
    Private _chrMediumLoan As Char
    Private _dtLoanMaster As DataTable


#End Region

#Region "Properties"

    Public Property LoanType() As String
        Get
            Return _strLoanType
        End Get
        Set(ByVal Value As String)
            _strLoanType = Value
        End Set
    End Property

    Public Property SlNo() As String
        Get
            Return _intSlNo
        End Get
        Set(ByVal Value As String)
            _intSlNo = Value
        End Set
    End Property


    Public Property ROI() As Double
        Get
            Return _lngROI
        End Get
        Set(ByVal Value As Double)
            _lngROI = Value
        End Set
    End Property

    Public Property PI() As Double
        Get
            Return _lngPI
        End Get
        Set(ByVal Value As Double)
            _lngPI = Value
        End Set
    End Property

    Public Property ApplFromDate() As Date
        Get
            Return _datApplFromDate
        End Get
        Set(ByVal Value As Date)
            _datApplFromDate = Value
        End Set
    End Property

    Public Property ApplToDate() As Date
        Get
            Return _datApplToDate
        End Get
        Set(ByVal Value As Date)
            _datApplToDate = Value
        End Set
    End Property

    Public Property GoldLoan() As Char
        Get
            Return _chrGoldLoan
        End Get
        Set(ByVal Value As Char)
            _chrGoldLoan = Value
        End Set
    End Property

    Public Property VehicleLoan() As Char
        Get
            Return _chrVehicleLoan
        End Get
        Set(ByVal Value As Char)
            _chrVehicleLoan = Value
        End Set
    End Property


    Public Property OverDraftLoan() As Char
        Get
            Return _chrOverDraft
        End Get
        Set(ByVal Value As Char)
            _chrOverDraft = Value
        End Set
    End Property
    Public Property ColleteralHandLoan() As Char
        Get
            Return _chrColHandLoan
        End Get
        Set(ByVal Value As Char)
            _chrColHandLoan = Value
        End Set
    End Property
    Public Property LoansOnDeposit() As Char
        Get
            Return _chrLoansOnDeposit
        End Get
        Set(ByVal Value As Char)
            _chrLoansOnDeposit = Value
        End Set
    End Property

    Public Property HandLoan() As Char
        Get
            Return _chrHandLoan
        End Get
        Set(ByVal Value As Char)
            _chrHandLoan = Value
        End Set
    End Property
    Public Property SuretyLoan() As Char
        Get
            Return _chrSuretyLoan
        End Get
        Set(ByVal Value As Char)
            _chrSuretyLoan = Value
        End Set
    End Property

    Public Property DailyRecoveryLoan() As Char
        Get
            Return _chrDailyRecoveryLaon
        End Get
        Set(ByVal Value As Char)
            _chrDailyRecoveryLaon = Value
        End Set
    End Property



    Public Property MediumLoan() As Char
        Get
            Return _chrMediumLoan
        End Get
        Set(ByVal Value As Char)
            _chrMediumLoan = Value
        End Set
    End Property

    Public Property HomeLoan() As Char
        Get
            Return _chrHomeLoan
        End Get
        Set(ByVal Value As Char)
            _chrHomeLoan = Value
        End Set
    End Property

    Public Property KisanLoan() As Char
        Get
            Return _chrKisanLoan
        End Get
        Set(ByVal Value As Char)
            _chrKisanLoan = Value
        End Set
    End Property

    Public Property DemandLoan() As Char
        Get
            Return _chrDemandLoan
        End Get
        Set(ByVal Value As Char)
            _chrDemandLoan = Value
        End Set
    End Property

    Public Property LoanInteresttable() As DataTable
        Get
            Return _dtLoanInt
        End Get
        Set(ByVal Value As DataTable)
            _dtLoanInt = Value
        End Set
    End Property

    Public Property LoanMasterTable() As DataTable
        Get
            Return _dtLoanMaster
        End Get
        Set(ByVal Value As DataTable)
            _dtLoanMaster = Value
        End Set
    End Property


#End Region

#Region "Functions"

    Public Function fnCheckROI(ByVal LSNo As Integer) As Boolean

        strSQL = "SELECT * FROM loantypetbl Where LoanSLNo='" & LSNo & "' "
        _dtLoanInt = fnExecuteQuery(strSQL, 2)
        If _dtLoanInt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnInsertLoan(ByVal LSNo As Integer) As Boolean
        strSQL = "INSERT INTO loantypetbl (LoanSLNo,LoanType,PI,ApplicableFrom,applicableTo) VALUES('" & LSNo & "','" & LoanType & "', '" & _lngPI & "','" & Format(_datApplFromDate, "yyyy-MM-dd") & "', '" & Format(_datApplToDate, "yyyy-MM-dd") & "') " '
        Return fnExecuteNonQuery(strSQL)
    End Function

    Public Function fnUpdateLoan(ByVal LSNo As Integer) As Boolean
        strSQL = "UPDATE loantypetbl set PI = '" & _lngPI & "',ApplicableFrom = '" & Format(_datApplFromDate, "yyyy-MM-dd") & "', applicableTo = '" & Format(_datApplToDate, "yyyy-MM-dd") & "' where loanSLno = '" & LSNo & "'"
        Return fnExecuteNonQuery(strSQL)
    End Function

    Public Function fnInsertROI(ByVal LSNo As Integer, ByVal objTrans As IDbTransaction) As Boolean
        Dim drRow As DataRow
        For Each drRow In _dtLoanMaster.Rows
            strSQL = "Insert loaninteresttbl values('" & LSNo & "','" & drRow(0) & "','" & drRow(1) & "','" & drRow(2) & "'"
            fnExecuteNonQuery(strSQL, objTrans)
        Next
        Return True
    End Function

    Public Function fnDeleteIntrSettings(ByVal LSNo As Integer) As Boolean
        strSQL = "Delete from loaninteresttbl where LoanSLNo='" & LSNo & "'"
        Return fnExecuteNonQuery(strSQL)
    End Function

    Public Function fnUpdateGoldROI(ByVal objTrans As IDbTransaction) As Boolean
        strSQL = "UPDATE loaninteresttbl set ROI = '" & _lngROI & "', PI = '" & _lngPI & "',ApplicableFrom = '" & Format(_datApplFromDate, "yyyy-MM-dd") & "', applicableTo = '" & Format(_datApplToDate, "yyyy-MM-dd") & "' where loanSLno = 1 "
        Return fnExecuteNonQuery(strSQL, objTrans)
    End Function
    Public Function fnUpdateVehicleROI(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "UPDATE loaninteresttbl set ROI = '" & _lngROI & "', PI = '" & _lngPI & "',ApplicableFrom = '" & Format(_datApplFromDate, "yyyy-MM-dd") & "', applicableTo = '" & Format(_datApplToDate, "yyyy-MM-dd") & "' where loanSLno = 2 "

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function
    Public Function fnUpdateOverDraftROI(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "UPDATE loaninteresttbl set ROI = '" & _lngROI & "', PI = '" & _lngPI & "',ApplicableFrom = '" & Format(_datApplFromDate, "yyyy-MM-dd") & "', applicableTo = '" & Format(_datApplToDate, "yyyy-MM-dd") & "' where loanSLno = 7 "

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function
    Public Function fnUpdateSuretyROI(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "UPDATE loaninteresttbl set ROI = '" & _lngROI & "', PI = '" & _lngPI & "',ApplicableFrom = '" & Format(_datApplFromDate, "yyyy-MM-dd") & "', applicableTo = '" & Format(_datApplToDate, "yyyy-MM-dd") & "' where loanSLno = 3"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function
    Public Function fnUpdateHandROI(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "UPDATE loaninteresttbl set ROI = '" & _lngROI & "', PI = '" & _lngPI & "',ApplicableFrom = '" & Format(_datApplFromDate, "yyyy-MM-dd") & "', applicableTo = '" & Format(_datApplToDate, "yyyy-MM-dd") & "' where loanSLno = 4"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function
    Public Function fnUpdateColleteralHandLoanROI(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "UPDATE loaninteresttbl set ROI = '" & _lngROI & "', PI = '" & _lngPI & "',ApplicableFrom = '" & Format(_datApplFromDate, "yyyy-MM-dd") & "', applicableTo = '" & Format(_datApplToDate, "yyyy-MM-dd") & "' where loanSLno = 5"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function
    Public Function fnUpdateLoansOnDepositROI() As Boolean

        strSQL = "UPDATE loaninteresttbl set ROI = '" & _lngROI & "', PI = '" & _lngPI & "',ApplicableFrom = '" & Format(_datApplFromDate, "yyyy-MM-dd") & "', applicableTo = '" & Format(_datApplToDate, "yyyy-MM-dd") & "' where loanSLno = 6"

        Return fnExecuteNonQuery(strSQL)

    End Function
    Public Function fnUpdateDailyRecoveryLoanROI(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "UPDATE loaninteresttbl set ROI = '" & _lngROI & "', PI = '" & _lngPI & "',ApplicableFrom = '" & Format(_datApplFromDate, "yyyy-MM-dd") & "', applicableTo = '" & Format(_datApplToDate, "yyyy-MM-dd") & "' where loanSLno = 8"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function


    'Public Function fnGetData() As Boolean

    '    strSQL = "Select * from loantypetbl order by LoanSLNo  "

    '    LoanInteresttable = fnExecuteQuery(strSQL, 2)

    '    If LoanInteresttable.Rows.Count > 0 Then

    '        Return True
    '    Else
    '        Return False

    '    End If
    'End Function
    Public Function fnGetROI(ByVal LSNo As Integer) As Boolean
        strSQL = "select * from loaninteresttbl where LoanSLNo='" & LSNo & "'"
        _dtLoanInt = fnExecuteQuery(strSQL, 2)
        If _dtLoanInt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region


#Region "Dummy"

    Public Function fnCheckROI() As Boolean

        strSQL = "SELECT * FROM loantypetbl Where LoanSLNo='" & _intSlNo & "' "
        _dtLoanInt = fnExecuteQuery(strSQL, 2)
        If _dtLoanInt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnInsertLoan(ByVal objTrans As IDbTransaction) As Boolean
        strSQL = "INSERT INTO loantypetbl (LoanSLNo,LoanType,PI,ApplicableFrom,applicableTo) VALUES('" & _intSlNo & "','" & LoanType & "', '" & _lngPI & "','" & Format(_datApplFromDate, "yyyy-MM-dd") & "', '" & Format(_datApplToDate, "yyyy-MM-dd") & "') " '
        Return fnExecuteNonQuery(strSQL, objTrans)
    End Function

    Public Function fnUpdateLoan(ByVal objTrans As IDbTransaction) As Boolean
        strSQL = "UPDATE loantypetbl set PI = '" & _lngPI & "',ApplicableFrom = '" & Format(_datApplFromDate, "yyyy-MM-dd") & "', applicableTo = '" & Format(_datApplToDate, "yyyy-MM-dd") & "' where loanSLno = '" & _intSlNo & "'"
        Return fnExecuteNonQuery(strSQL, objTrans)
    End Function

    Public Function fnInsertROI(ByVal objTrans As IDbTransaction) As Boolean
        Dim drRow As DataRow
        For Each drRow In _dtLoanMaster.Rows
            strSQL = "Insert loaninteresttbl values('" & drRow(0) & "','" & drRow(1) & "','" & drRow(2) & "','" & drRow(3) & "')"
            fnExecuteNonQuery(strSQL, objTrans)
        Next
        Return True
    End Function

    Public Function fnDeleteIntrSettings(ByVal objTrans As IDbTransaction) As Boolean
        strSQL = "Delete from loaninteresttbl where LoanSLNo='" & _intSlNo & "'"
        Return fnExecuteNonQuery(strSQL, objTrans)
    End Function


    Public Function fnGetData() As Boolean

        strSQL = "Select * from loantypetbl order by LoanSLNo  "

        LoanInteresttable = fnExecuteQuery(strSQL, 2)

        If LoanInteresttable.Rows.Count > 0 Then

            Return True
        Else
            Return False

        End If
    End Function
    Public Function fnGetROI() As Boolean
        strSQL = "select * from loaninteresttbl where LoanSLNo='" & _intSlNo & "'"
        _dtLoanInt = fnExecuteQuery(strSQL, 2)
        If _dtLoanInt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


#End Region

End Class
