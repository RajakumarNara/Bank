
Public Class clsHomeLoanDet
    Inherits clsPerson

#Region "Variables"

    Private _strLoanNo As String
    Private _PersonNo As Long
    Private _strSBNo As String
    Private _strMemberNo As String

    'person Number Comes from clsperson
    Private _datHomeLoanDate As Date
    Private _datAccDate As Date
    Private _dblAccBal As Double
    Private _chrAccType As Char

    Private _strRemarks As String
    Private _chrPhotoID As Char
    Private _chrAddrID As Char
    Private _strReciptNo As String

    Private _dtHomeLoan As DataTable
    Private _dtHomeItemDetails As DataTable
    Private _dtHomeLoanDet As DataTable
    Private _dtHomeCust As DataTable

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
    Private _datLastPaid As Date
    Private _intDisbAmt As Integer
    Private _dtHomeOtherLoanDet As DataTable
    Private _dtHomeAssetDet As DataTable

    'Asset Details
    Private _strBankName As String
    Private _dblRemaningAmt As Double
    Private _strMortagageDet As String
    Private _strActionOnBorrower As String

    'OtherLoanDet 
    Private _strAddress As String
    Private _intServae As Integer
    Private _dblTotalArea As Double
    Private _strType As String
    Private _strIfMortagageDetails As String
    Private _strOthers As String
    Private _DtHomeAssetsDet As DataTable
    Private _DtHomeOtherDet As DataTable

    'HomeLoanDet
    Private _strDesignation As String
    Private _strOfficeName As String
    Private _intNoOfService As Integer
    Private _intMeasurment As Integer
    Private _intNorthSide As Integer
    Private _intSouthSide As Integer
    Private _intEastSide As Integer
    Private _intWestSide As Integer
    Private _chrHeariditoryAsset As Char
    Private _strAssetHistory As String
    Private _StrAssetDetail1 As String
    Private _StrAssetDetail2 As String
    Private _chrJointFamily As Char
    Private _strLOwner As String
    Private _chrGTree As Char
    Private _intActullAmt As Integer
    Private _intAsPerSubRegAmt As Integer
    Private _intPalikaeAmt As Integer
    Private _strITDetails As String
    Private _strAssetCourtDetails As String
    Private _chrAllDocProduced As Char
    Private _strImmovablePropertDet As String
    Private _chrSalariedPerson As Char
    Private _chrBusinessPerson As Char
    Private _intSSalary As Integer
    Private _intSRent As Integer
    Private _intSOtherIncome As Integer
    Private _intSTotalIncome As Integer
    Private _intSTotalSavings As Integer
    Private _intBSalary As Integer
    Private _intBRent As Integer
    Private _intBOtherIncome As Integer
    Private _intBTotalIncome As Integer
    Private _intBTotalSavings As Integer
    Private _intNoOfDependents As Integer
    Private _strNSC As String
    Private _StrShares As String
    Private _strJeevanPolicy As String
    Private _chrAsBorowwer As Char
    Private _chrAsSurety As Char
    Private _strAsBTypeOfLoan1 As String
    Private _intAsBAmount1 As Integer
    Private _strAsBTypeOfLoan2 As String
    Private _intAsBAmount2 As Integer
    Private _strAsSPerson1 As String
    Private _strAsSLoanType1 As String
    Private _intAsSAmount1 As Integer
    Private _strAsSPerson2 As String
    Private _strAsSLoanType2 As String
    Private _intAsSAmount2 As Integer
    Private _strAsSPerson3 As String
    Private _strAsSLoanType3 As String
    Private _intAsSAmount3 As Integer
    Private _strOtherParticulars As String


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

    'Public Property Remarks() As String
    '    Get
    '        Return _strRemarks
    '    End Get
    '    Set(ByVal Value As String)
    '        _strRemarks = Value
    '    End Set
    'End Property

    Public Property immovablePropertyDet() As String
        Get
            Return _strImmovablePropertDet
        End Get
        Set(ByVal Value As String)
            _strImmovablePropertDet = Value
        End Set
    End Property

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

    Public Property HomeLoanTable() As DataTable
        Get
            Return _dtHomeLoan
        End Get
        Set(ByVal Value As DataTable)
            _dtHomeLoan = Value
        End Set
    End Property

    Public Property HomeExpectedAmount() As Integer
        Get
            Return _intExpectedAmount
        End Get
        Set(ByVal Value As Integer)
            _intExpectedAmount = Value
        End Set
    End Property

    Public Property HomeSanctioned() As Integer
        Get
            Return _intSanctionedAmount
        End Get
        Set(ByVal Value As Integer)
            _intSanctionedAmount = Value
        End Set
    End Property

    Public Property HomeROI() As Double
        Get
            Return _dblROI
        End Get
        Set(ByVal Value As Double)
            _dblROI = Value
        End Set
    End Property

    Public Property NoOfService() As Integer
        Get
            Return _intNoOfService
        End Get
        Set(ByVal Value As Integer)
            _intNoOfService = Value
        End Set
    End Property

    Public Property HomeDisbAmt() As Integer
        Get
            Return _intDisbAmt
        End Get
        Set(ByVal Value As Integer)
            _intDisbAmt = Value
        End Set
    End Property

    Public Property HomeInstallments() As String
        Get
            Return _strInstallment
        End Get
        Set(ByVal Value As String)
            _strInstallment = Value
        End Set
    End Property

    Public Property HomeModeOfPayment() As String
        Get
            Return _strModeOfPayment
        End Get
        Set(ByVal Value As String)
            _strModeOfPayment = Value
        End Set
    End Property

    Public Property HomeloanReason() As String
        Get
            Return _strReason
        End Get
        Set(ByVal Value As String)
            _strReason = Value
        End Set
    End Property

    Public Property HomeWitnessPerson1() As String
        Get
            Return _strWitnessPerson1
        End Get
        Set(ByVal Value As String)
            _strWitnessPerson1 = Value
        End Set
    End Property

    Public Property HomeWitnessPerson2() As String
        Get
            Return _strWitnessPerson2
        End Get
        Set(ByVal Value As String)
            _strWitnessPerson2 = Value
        End Set
    End Property

    Public Property HomeWitnessPersonAddress1() As String
        Get
            Return _strWitnessAddress1
        End Get
        Set(ByVal Value As String)
            _strWitnessAddress1 = Value
        End Set
    End Property

    Public Property HomeWitnessPersonAddress2() As String
        Get
            Return _strWitnessAddress2
        End Get
        Set(ByVal Value As String)
            _strWitnessAddress2 = Value
        End Set
    End Property

    Public Property HomeLoanDate() As Date
        Get
            Return _datHomeLoanDate
        End Get
        Set(ByVal Value As Date)
            _datHomeLoanDate = Value
        End Set
    End Property


    Public Property HomeLoanDueDate() As Date
        Get
            Return _datDueDate
        End Get
        Set(ByVal Value As Date)
            _datDueDate = Value
        End Set
    End Property

    Public Property HomeLoanInstPrinciple() As Integer
        Get
            Return _intInstPrinciple
        End Get
        Set(ByVal Value As Integer)
            _intInstPrinciple = Value
        End Set
    End Property

    Public Property HomeLoanAmtBalance() As Integer
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

    Public Property HomeLoanSubsidy() As String
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

    Public Property HomeLoanLastPaidDate() As Date
        Get
            Return _datLastPaid
        End Get
        Set(ByVal Value As Date)
            _datLastPaid = Value
        End Set
    End Property

    Public Property HomeLoanDettable() As DataTable
        Get
            Return _dtHomeLoanDet
        End Get
        Set(ByVal Value As DataTable)
            _dtHomeLoanDet = Value
        End Set
    End Property

    Public Property HomeLoanCusttable() As DataTable
        Get
            Return _dtHomeCust
        End Get
        Set(ByVal Value As DataTable)
            _dtHomeCust = Value
        End Set
    End Property

    Public Property HomeBankName() As String
        Get
            Return _strBankName
        End Get
        Set(ByVal Value As String)
            _strBankName = Value
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

    Public Property ActionOnBorrower() As String
        Get
            Return _strActionOnBorrower
        End Get
        Set(ByVal Value As String)
            _strActionOnBorrower = Value
        End Set
    End Property

    Public Property AssetAddress() As String
        Get
            Return _strAddress
        End Get
        Set(ByVal Value As String)
            _strAddress = Value
        End Set
    End Property

    Public Property ServaeNo() As Integer
        Get
            Return _intServae
        End Get
        Set(ByVal Value As Integer)
            _intServae = Value
        End Set
    End Property

    Public Property type() As String
        Get
            Return _strType
        End Get
        Set(ByVal Value As String)
            _strType = Value
        End Set
    End Property

    Public Property TotalArea() As Double
        Get
            Return _dblTotalArea
        End Get
        Set(ByVal Value As Double)
            _dblTotalArea = Value
        End Set
    End Property

    Public Property IfMortagageDet() As String
        Get
            Return _strIfMortagageDetails
        End Get
        Set(ByVal Value As String)
            _strIfMortagageDetails = Value
        End Set
    End Property

    Public Property HomeOtherLoanDet() As DataTable
        Get
            Return _dtHomeOtherLoanDet
        End Get
        Set(ByVal Value As DataTable)
            _dtHomeOtherLoanDet = Value
        End Set
    End Property

    Public Property HomeAssetDet() As DataTable
        Get
            Return _dtHomeAssetDet
        End Get
        Set(ByVal Value As DataTable)
            _dtHomeAssetDet = Value
        End Set
    End Property

    Public Property HomeLoanAssetsTable() As DataTable
        Get
            Return _DtHomeAssetsDet
        End Get
        Set(ByVal Value As DataTable)
            _DtHomeAssetsDet = Value
        End Set
    End Property

    Public Property HomeLoanOtherTable() As DataTable
        Get
            Return _DtHomeOtherDet
        End Get
        Set(ByVal Value As DataTable)
            _DtHomeOtherDet = Value
        End Set
    End Property

    Public Property TotalLandMeasurement() As Integer
        Get
            Return _intMeasurment
        End Get
        Set(ByVal Value As Integer)
            _intMeasurment = Value
        End Set
    End Property

    Public Property NorthSide() As Integer
        Get
            Return _intNorthSide
        End Get
        Set(ByVal Value As Integer)
            _intNorthSide = Value
        End Set
    End Property

    Public Property SouthSide() As Integer
        Get
            Return _intSouthSide
        End Get
        Set(ByVal Value As Integer)
            _intSouthSide = Value
        End Set
    End Property

    Public Property EastSide() As Integer
        Get
            Return _intEastSide
        End Get
        Set(ByVal Value As Integer)
            _intEastSide = Value
        End Set
    End Property

    Public Property WestSide() As Integer
        Get
            Return _intWestSide
        End Get
        Set(ByVal Value As Integer)
            _intWestSide = Value
        End Set
    End Property

    Public Property HaeriditoryAsset() As Char
        Get
            Return _chrHeariditoryAsset
        End Get
        Set(ByVal Value As Char)
            _chrHeariditoryAsset = Value
        End Set
    End Property

    Public Property JointFamily() As Char
        Get
            Return _chrJointFamily
        End Get
        Set(ByVal Value As Char)
            _chrJointFamily = Value
        End Set
    End Property

    Public Property AssetDetails1() As String
        Get
            Return _StrAssetDetail1
        End Get
        Set(ByVal Value As String)
            _StrAssetDetail1 = Value
        End Set
    End Property

    Public Property AssetDetails2() As String
        Get
            Return _StrAssetDetail2
        End Get
        Set(ByVal Value As String)
            _StrAssetDetail2 = Value
        End Set
    End Property

    Public Property AssetHistory() As String
        Get
            Return _strAssetHistory
        End Get
        Set(ByVal Value As String)
            _strAssetHistory = Value
        End Set
    End Property

    Public Property AssetByLady() As String
        Get
            Return _strLOwner
        End Get
        Set(ByVal Value As String)
            _strLOwner = Value
        End Set
    End Property

    Public Property GTree() As Char
        Get
            Return _chrGTree
        End Get
        Set(ByVal Value As Char)
            _chrGTree = Value
        End Set
    End Property

    Public Property ActuallAmount() As Integer
        Get
            Return _intActullAmt
        End Get
        Set(ByVal Value As Integer)
            _intActullAmt = Value
        End Set
    End Property

    Public Property AsPerSubRegAmount() As Integer
        Get
            Return _intAsPerSubRegAmt
        End Get
        Set(ByVal Value As Integer)
            _intAsPerSubRegAmt = Value
        End Set
    End Property

    Public Property AsPerPalikaeAmount() As Integer
        Get
            Return _intPalikaeAmt
        End Get
        Set(ByVal Value As Integer)
            _intPalikaeAmt = Value
        End Set
    End Property

    Public Property ITDetails() As String
        Get
            Return _strITDetails
        End Get
        Set(ByVal Value As String)
            _strITDetails = Value
        End Set
    End Property

    Public Property CourtDetails() As String
        Get
            Return _strAssetCourtDetails
        End Get
        Set(ByVal Value As String)
            _strAssetCourtDetails = Value
        End Set
    End Property

    Public Property AllDocProduced() As Char
        Get
            Return _chrAllDocProduced
        End Get
        Set(ByVal Value As Char)
            _chrAllDocProduced = Value
        End Set
    End Property


    Public Property SalariedPerson() As Char
        Get
            Return _chrSalariedPerson
        End Get
        Set(ByVal Value As Char)
            _chrSalariedPerson = Value
        End Set
    End Property

    Public Property BusinessPerson() As Char
        Get
            Return _chrBusinessPerson
        End Get
        Set(ByVal Value As Char)
            _chrBusinessPerson = Value
        End Set
    End Property

    Public Property SSalary() As Integer
        Get
            Return _intSSalary
        End Get
        Set(ByVal Value As Integer)
            _intSSalary = Value
        End Set
    End Property

    Public Property SRent() As Integer
        Get
            Return _intSRent
        End Get
        Set(ByVal Value As Integer)
            _intSRent = Value
        End Set
    End Property

    Public Property SOtherIncome() As Integer
        Get
            Return _intSOtherIncome
        End Get
        Set(ByVal Value As Integer)
            _intSOtherIncome = Value
        End Set
    End Property

    Public Property STotalIncome() As Integer
        Get
            Return _intSTotalIncome
        End Get
        Set(ByVal Value As Integer)
            _intSTotalIncome = Value
        End Set
    End Property

    Public Property STotalSavings() As Integer
        Get
            Return _intSTotalSavings
        End Get
        Set(ByVal Value As Integer)
            _intSTotalSavings = Value
        End Set
    End Property

    Public Property BMonthlyIncome() As Integer
        Get
            Return _intBSalary
        End Get
        Set(ByVal Value As Integer)
            _intBSalary = Value
        End Set
    End Property

    Public Property BRent() As Integer
        Get
            Return _intBRent
        End Get
        Set(ByVal Value As Integer)
            _intBRent = Value
        End Set
    End Property

    Public Property BotherIncome() As Integer
        Get
            Return _intBOtherIncome
        End Get
        Set(ByVal Value As Integer)
            _intBOtherIncome = Value
        End Set
    End Property

    Public Property BTotalIncome() As Integer
        Get
            Return _intBTotalIncome
        End Get
        Set(ByVal Value As Integer)
            _intBTotalIncome = Value
        End Set
    End Property

    Public Property BTotalSavings() As Integer
        Get
            Return _intBTotalSavings
        End Get
        Set(ByVal Value As Integer)
            _intBTotalSavings = Value
        End Set
    End Property

    Public Property BorrowedLoanType1() As String
        Get
            Return _strAsBTypeOfLoan1
        End Get
        Set(ByVal Value As String)
            _strAsBTypeOfLoan1 = Value
        End Set
    End Property

    Public Property BorrowedLoanType2() As String
        Get
            Return _strAsBTypeOfLoan2
        End Get
        Set(ByVal Value As String)
            _strAsBTypeOfLoan2 = Value
        End Set
    End Property

    Public Property BorrowedAmount1() As Integer
        Get
            Return _intAsBAmount1
        End Get
        Set(ByVal Value As Integer)
            _intAsBAmount1 = Value
        End Set
    End Property

    Public Property borrowedAmount2() As Integer
        Get
            Return _intAsBAmount2
        End Get
        Set(ByVal Value As Integer)
            _intAsBAmount2 = Value
        End Set
    End Property

    Public Property AsSurety() As Char
        Get
            Return _chrAsSurety
        End Get
        Set(ByVal Value As Char)
            _chrAsSurety = Value
        End Set
    End Property

    Public Property AsBorowwer() As Char
        Get
            Return _chrAsBorowwer
        End Get
        Set(ByVal Value As Char)
            _chrAsBorowwer = Value
        End Set
    End Property


    Public Property AsSuretyPerson1() As String
        Get
            Return _strAsSPerson1
        End Get
        Set(ByVal Value As String)
            _strAsSPerson1 = Value
        End Set
    End Property

    Public Property AsSuretyPerson2() As String
        Get
            Return _strAsSPerson2
        End Get
        Set(ByVal Value As String)
            _strAsSPerson2 = Value
        End Set
    End Property

    Public Property AsSuretyLoanType1() As String
        Get
            Return _strAsSLoanType1
        End Get
        Set(ByVal Value As String)
            _strAsSLoanType1 = Value
        End Set
    End Property

    Public Property AsAsuretyLoanType2() As String
        Get
            Return _strAsSLoanType2
        End Get
        Set(ByVal Value As String)
            _strAsSLoanType2 = Value
        End Set
    End Property

    Public Property AsSuretyPaidAmount1() As Integer
        Get
            Return _intAsBAmount1
        End Get
        Set(ByVal Value As Integer)
            _intAsBAmount1 = Value
        End Set
    End Property

    Public Property AsSuretyPaidAmount2() As Integer
        Get
            Return _intAsBAmount2
        End Get
        Set(ByVal Value As Integer)
            _intAsBAmount2 = Value
        End Set
    End Property

    Public Property Designation() As String
        Get
            Return _strDesignation
        End Get
        Set(ByVal Value As String)
            _strDesignation = Value
        End Set
    End Property

    Public Property OfficeName() As String
        Get
            Return _strOfficeName
        End Get
        Set(ByVal Value As String)
            _strOfficeName = Value
        End Set
    End Property

    Public Property OtherParticulars() As String
        Get
            Return _strOtherParticulars
        End Get
        Set(ByVal Value As String)
            _strOtherParticulars = Value
        End Set
    End Property

    Public Property NoofDependents() As Integer
        Get
            Return _intNoOfDependents
        End Get
        Set(ByVal Value As Integer)
            _intNoOfDependents = Value
        End Set
    End Property

    Public Property NSC() As String
        Get
            Return _strNSC
        End Get
        Set(ByVal Value As String)
            _strNSC = Value
        End Set
    End Property


    Public Property Shares() As String
        Get
            Return _StrShares
        End Get
        Set(ByVal Value As String)
            _StrShares = Value
        End Set
    End Property


    Public Property Policy() As String
        Get
            Return _strJeevanPolicy
        End Get
        Set(ByVal Value As String)
            _strJeevanPolicy = Value
        End Set
    End Property


#End Region

#Region "Functions"

    Public Function fnAddHLAccount(ByVal objTrans As IDbTransaction) As Boolean

        If fnCheckPerson() Then
            If fnUpdatePerson(objTrans) Then
                If fnInsertHLAccount(objTrans) Then
                    Return fnInsertHLDetails(objTrans)
                End If
            End If
        Else
            If fnAddPerson(objTrans) Then
                If fnInsertHLAccount(objTrans) Then
                    If fnInsertHLDetails(objTrans) Then
                        Return True
                    Else
                        fnDeletePerson(objTrans)
                        fnDeleteHomeDet(LoanNo, objTrans)
                        fnDeleteLoanDet(LoanNo, objTrans)
                    End If
                End If
            End If
        End If
    End Function




    Public Function fnChekHLAccount(ByVal strLoanNo As String) As Boolean

        strSQL = "select * from loanDetailstbl where loanNo = '" & strLoanNo & "'"

        _dtHomeLoan = fnExecuteQuery(strSQL, 2)

        If _dtHomeLoan.Rows.Count > 0 Then

            Return True
        Else
            Return False

        End If
    End Function

    Public Function fnInsertHLAccount(ByVal objTrans As IDbTransaction) As Boolean

        'Dim strSql As String

        strSQL = "insert into loanDetailstbl(LoanNo,PersonNo,MemberNo,SBNo,ExpAmount,SancAmount,DisbAmount,ApplDate,SancDate,DueDate,ROI,NOI,InstPrinciple,RepayMode,Purpose,Balance,LastPaidDate,Remarks,Status,ReceiptNo)"
        strSQL = strSQL & " values('" & _strLoanNo & "','" & PersonNo & "','" & _strMemberNo & "','" & _strSBNo & "','" & _intExpectedAmount & "','" & _intSanctionedAmount & "','" & _intDisbAmt & "','" & Format(_datHomeLoanDate, "yyyy-MM-dd") & "','" & Format(_datHomeLoanDate, "yyyy-MM-dd") & "','" & Format(_datDueDate, "yyyy-MM-dd") & "','" & _dblROI & "','" & _intNOI & "','"
        strSQL = strSQL & _intInstPrinciple & "','" & _strModeOfPayment & "','" & _strReason & "','" & _intBalance & "','" & Format(_datLastPaid, "yyyy-MM-dd") & "','" & _strRemarks & "','" & _strStatus & "','" & _strReciptNo & "')"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnInsertHLDetails(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "insert into homeLoanDettbl(Loanno,Designation,OfficeName,NoOfService,LandMeasurment,NorthSide,SouthSide,WestSide,EastSide,Haeriditory,AssetDet1,AssetDet2,JointFamily,AssetHistory,AssetDetIfLady,GTreeProduced,ActuallAmt,AsPerSubRegAmt,"
        strSQL = strSQL & "AsPerPalikaeAmt,ITDetails,CourtDetails,DocumentsProduced,ImmovablePropertyDet,SalariedPerson,BusinessPerson,SSalary,SRent,SOtherIncome,SOtherTotalIncome,STotalSavings,BSalary,BRent,BOtherIncome,BOtherTotalIncome,BTotalSavings,"
        strSQL = strSQL & "NoOfDependents,NSC,ShareDetails,PolicyDetails,AsBorowwer,AsSurety,BTypeOfLoan,BTypeOfLoan1,BAmount1,BAmount2,AsSuretyPerson1,AsSuretyPerson2,AsSuretyType1,AsSuretyType2,AsSuretyAmount1,AsSuretyAmount2,Others,Installment) values ('" & _strLoanNo & "','" & _strDesignation & "','" & _strOfficeName & "',"
        strSQL = strSQL & "'" & _intNoOfService & "','" & _intMeasurment & "','" & _intNorthSide & "','" & _intSouthSide & "','" & _intWestSide & "','" & _intEastSide & "','" & _chrHeariditoryAsset & "','" & _StrAssetDetail1 & "','" & _StrAssetDetail2 & "','" & _chrJointFamily & "','" & _strAssetHistory & "',"
        strSQL = strSQL & "'" & _strLOwner & "','" & _chrGTree & "','" & _intActullAmt & "','" & _intAsPerSubRegAmt & "','" & _intPalikaeAmt & "','" & _strITDetails & "','" & _strAssetCourtDetails & "','" & _chrAllDocProduced & "','" & _strImmovablePropertDet & "','" & _chrSalariedPerson & "','" & _chrBusinessPerson & "',"
        strSQL = strSQL & "'" & _intSSalary & "','" & _intSRent & "','" & _intSTotalIncome & "','" & _intSOtherIncome & "','" & _intSTotalSavings & "','" & _intBSalary & "','" & _intBRent & "','" & _intBOtherIncome & "','" & _intBTotalIncome & "','" & _intBTotalSavings & "','" & _intNoOfDependents & "','" & _strNSC & "',"
        strSQL = strSQL & "'" & _StrShares & "','" & _strJeevanPolicy & "','" & _chrAsBorowwer & "','" & _chrAsSurety & "','" & _strAsBTypeOfLoan1 & "','" & _strAsBTypeOfLoan2 & "','" & _intAsBAmount1 & "','" & _intAsBAmount2 & "','" & _strAsSPerson1 & "','" & _strAsSPerson2 & "','" & _strAsSLoanType1 & "','" & _strAsSLoanType2 & "',"
        strSQL = strSQL & "'" & _intAsSAmount1 & "','" & _intAsSAmount2 & "','" & _strOtherParticulars & "','" & _strInstallment & "')"


        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnDeleteHomeDet(ByVal strLoanNo As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Delete from homeLoanDettbl where loanno = '" & strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnDeleteLoanDet(ByVal strLoanNo As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Delete from loandetailstbl where loanno = '" & strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnUpdateLoanDetails(ByVal strLoanNo As String) As Boolean

        strSQL = "UPDATE loandetailsTbl SET memberNo = '" & _strMemberNo & "',personNo = '" & PersonNo & "', sbno = '" & _strSBNo & "', expAmount='" & _intExpectedAmount & "', sancamount='" & _intSanctionedAmount & "',ApplDate = '" & Format(_datHomeLoanDate, "yyyy-MM-dd") & "',DueDate = '" & Format(_datDueDate, "yyyy-MM-dd") & "', RepayMode  ='" & _strModeOfPayment & "', ROI='" & _dblROI & "', NOI = '" & _intNOI & "',InstPrinciple = '" & _intInstPrinciple & "',Purpose ='" & _strReason & "', Remarks = '" & _strRemarks & "' WHERE  LoanNo='" & strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnUpdateHomeDet(ByVal strLoanNo As String) As Boolean

        strSQL = "update homeloandettbl set Designation = '" & _strDesignation & "',OfficeName = '" & _strOfficeName & "',NoOfService = '" & _intNoOfService & "',LandMeasurment = '" & _intMeasurment & "',NorthSide = '" & _intNorthSide & "',SouthSide = '" & _intSouthSide & "',WestSide ='" & _intWestSide & "',EastSide = '" & _intEastSide & "',Haeriditory = '" & _chrHeariditoryAsset & "',AssetDet1 = '" & _StrAssetDetail1 & "',AssetDet2 ='" & _StrAssetDetail2 & "',JointFamily ='" & _chrJointFamily & "',AssetHistory = '" & _strAssetHistory & "',AssetDetIfLady = '" & _strLOwner & "',"
        strSQL = strSQL & "GTreeProduced = '" & _chrGTree & "',ActuallAmt = '" & _intActullAmt & "',AsPerSubRegAmt = '" & _intAsPerSubRegAmt & "',AsPerPalikaeAmt = '" & _intPalikaeAmt & "',ITDetails = '" & _strITDetails & "',CourtDetails = '" & _strAssetCourtDetails & "',DocumentsProduced = '" & _chrAllDocProduced & "',ImmovablePropertyDet = '" & _strImmovablePropertDet & "',SalariedPerson = '" & _chrSalariedPerson & "',BusinessPerson = '" & _chrBusinessPerson & "',SSalary = '" & _intSSalary & "',SRent = '" & _intSRent & "',SOtherIncome = '" & _intSOtherIncome & "',SOtherTotalIncome = '" & _intSTotalIncome & "',"
        strSQL = strSQL & "STotalSavings = '" & _intSTotalSavings & "',BSalary = '" & _intBSalary & "',BRent = '" & _intBRent & "',BOtherIncome = '" & _intBOtherIncome & "',BOtherTotalIncome = '" & _intBTotalIncome & "',BTotalSavings = '" & _intBTotalSavings & "',NoOfDependents = '" & _intNoOfDependents & "',NSC = '" & _strNSC & "',ShareDetails ='" & _StrShares & "',PolicyDetails = '" & _strJeevanPolicy & "',AsBorowwer = '" & _chrAsBorowwer & "',AsSurety ='" & _chrAsSurety & "',BTypeOfLoan = '" & _strAsBTypeOfLoan1 & "',BTypeOfLoan1 = '" & _strAsBTypeOfLoan2 & "',BAmount1 = '" & _intAsBAmount1 & "',BAmount2 = '" & _intAsBAmount2 & "',"
        strSQL = strSQL & "AsSuretyPerson1 = '" & _strAsSPerson1 & "',AsSuretyPerson2 = '" & _strAsSPerson2 & "',AsSuretyType1 = '" & _strAsSLoanType1 & "',AsSuretyType2 = '" & _strAsSLoanType2 & "',AsSuretyAmount1 = '" & _intAsSAmount1 & "',AsSuretyAmount2 = '" & _intAsSAmount2 & "',Others = '" & _strOtherParticulars & "',Installment = '" & _strInstallment & "' where loanNo = '" & strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function


    Public Function fnGetLoanDetails(ByVal strLoanNo As String) As Boolean

        strSQL = "SELECT P.*, v.* FROM Loandetailstbl v, PersonTbl P WHERE P.PersonNo=v.PersonNo  and v.LoanNo='" & strLoanNo & "' "

        _dtHomeLoanDet = fnExecuteQuery(strSQL, 2)

        If _dtHomeLoanDet.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetHomeLoanCust() As Boolean

        strSQL = "select P.*, S.* FROM loandetailstbl S, PersonTbl P WHERE P.PersonNo=S.PersonNo and loanNo like 'HL%'"

        _dtHomeCust = fnExecuteQuery(strSQL, 2)

        If _dtHomeCust.Rows.Count > 0 Then

            Return True
        Else
            Return False

        End If

    End Function

    Public Function fnGetHomeLoanOthertDet(ByVal strLoanNo As String) As Boolean

        strSQL = "select b.* from homeloandettbl b where b.loanno = '" & strLoanNo & "'"

        _DtHomeOtherDet = fnExecuteQuery(strSQL, 2)

        If _DtHomeOtherDet.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function




#End Region

End Class
