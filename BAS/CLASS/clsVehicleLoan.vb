
Public Class clsVehicleLoan
    Inherits clsPerson

#Region "Variables"

    Private _strLoanNo As String
    Private _PersonNo As Long
    Private _strSBNo As String
    Private _strMemberNo As String

    'person Number Comes from clsperson
    Private _datVehcileLoanData As Date
    Private _datAccDate As Date
    Private _dblAccBal As Double
    Private _chrAccType As Char

    Private _strRemarks As String
    Private _strReciptNo As String
    Private _dtVehilceLoan As DataTable
    Private _dtVehilceItemDetails As DataTable
    Private _dtVehicleLoanDet As DataTable
    Private _dtVehicleCust As DataTable
    Private _dtDocumentTable As DataTable

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
    Private _datlastInstDate As Date
    Private _intDisbAmt As Integer
    Private _chrLoanType As Char

    Private _datsancDate As Date
    Private _dblSancNo As String
    Private _strMobileNo2 As String


    '' Vehhicle Loan Var
    Private _strOfficeName As String
    Private _strDesignation As String
    Private _intNoService As Integer
    Private _chrGTree As Char

    Private _strLicenceNo As String
    Private _datValidity As Date
    Private _strVehicleType As String
    Private _strPermitNo As String
    Private _datPValidity As Date
    Private _strModeOfUse As String
    Private _strAreaOfOperation As String
    Private _strParkedAddress As String

    Private _chrOldVehicle As Char
    Private _strVehicleName As String
    Private _datPurchaseDate As Date
    Private _intCostOfVehicle As Integer
    Private _intPreMarketPrice As Integer

    Private _intTax As Integer
    Private _intCostOfFittings As Integer
    Private _intCostOfBBuilding As Integer
    Private _intNetAmount As Integer

    Private _strDealerName As String
    Private _strOtherVehicle As String
    Private _strExpTBusiness As String
    Private _strLoanToRepay As String

    Private _strDirName As String
    Private _strNatRelationShip As String

    Private _intSSalary As Integer
    Private _intSRent As Integer
    Private _intSOtherIncome As Integer
    Private _intSTotalIncome As Integer
    Private _intSTotalSavings As Integer
    Private _intSExpenses As Integer


    Private _intBMonthly As Integer
    Private _intBRent As Integer
    Private _intBOtherIncome As Integer
    Private _intBTotalIncome As Integer
    Private _intBTotalSavings As Integer
    Private _intBExpenses As Integer

    Private _StrIncomeTaxDet As String

    Private _strBorrowedLoanType1 As String
    Private _intBorrowedAmount1 As Integer
    Private _strBorrowedLoanType2 As String
    Private _intBorrowedAmount2 As Integer
    Private _strAsSuretyPerson1 As String
    Private _strAsSuretyPerson2 As String
    Private _strAsSuretyType1 As String
    Private _strAsSuretyType2 As String
    Private _intAsSuretyAmount1 As Integer
    Private _intAsSuretyAmount2 As Integer



    Private _StrifBankRespDet As String
    Private _StrifOrgResp As String
    Private _StrifPersonResp As String

    Private _strbankName As String
    Private _StrLoanType As String
    Private _intLoanAmount As Integer


    Private _StrImmovablePropertyDet As String
    Private _StrMortagagePropertyDet As String
    Private _StrRelationship As String
    Private _strOthers As String
    Private _chrAsBorrower As Char
    Private _chrAsSurety As Char
    Private _chrAsSalaried As Char
    Private _chrAsBusiness As Char


    Private _strVehicleNo As String
    Private _strEngineNo As String
    Private _strChaseNo As String
    Private _strFC As String
    Private _strRegistrationNo As String
    Private _dblRoadTax As Double

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

    'Public Property Remarks() As String
    '    Get
    '        Return _strRemarks
    '    End Get
    '    Set(ByVal Value As String)
    '        _strRemarks = Value
    '    End Set
    'End Property


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

    Public Property ReciptNo() As String
        Get
            Return _strReciptNo
        End Get
        Set(ByVal Value As String)
            _strReciptNo = Value
        End Set
    End Property

    Public Property VehicleLoanTable() As DataTable
        Get
            Return _dtVehilceLoan
        End Get
        Set(ByVal Value As DataTable)
            _dtVehilceLoan = Value
        End Set
    End Property

    Public Property VehicleExpectedAmount() As Integer
        Get
            Return _intExpectedAmount
        End Get
        Set(ByVal Value As Integer)
            _intExpectedAmount = Value
        End Set
    End Property

    Public Property VehicleSanctioned() As Integer
        Get
            Return _intSanctionedAmount
        End Get
        Set(ByVal Value As Integer)
            _intSanctionedAmount = Value
        End Set
    End Property

    Public Property VehicleROI() As Double
        Get
            Return _dblROI
        End Get
        Set(ByVal Value As Double)
            _dblROI = Value
        End Set
    End Property

    Public Property VehicleDisbAmt() As Integer
        Get
            Return _intDisbAmt
        End Get
        Set(ByVal Value As Integer)
            _intDisbAmt = Value
        End Set
    End Property

    Public Property LoanAccType() As Char
        Get
            Return _chrLoanType
        End Get
        Set(ByVal Value As Char)
            _chrLoanType = Value
        End Set
    End Property

    Public Property VehicleInstallments() As String
        Get
            Return _strInstallment
        End Get
        Set(ByVal Value As String)
            _strInstallment = Value
        End Set
    End Property

    Public Property VehicleModeOfPayment() As String
        Get
            Return _strModeOfPayment
        End Get
        Set(ByVal Value As String)
            _strModeOfPayment = Value
        End Set
    End Property

    Public Property VehicleReason() As String
        Get
            Return _strReason
        End Get
        Set(ByVal Value As String)
            _strReason = Value
        End Set
    End Property

    Public Property VehicleWitnessPerson1() As String
        Get
            Return _strWitnessPerson1
        End Get
        Set(ByVal Value As String)
            _strWitnessPerson1 = Value
        End Set
    End Property

    Public Property VehicleWitnessPerson2() As String
        Get
            Return _strWitnessPerson2
        End Get
        Set(ByVal Value As String)
            _strWitnessPerson2 = Value
        End Set
    End Property

    Public Property VehicleWitnessPersonAddress1() As String
        Get
            Return _strWitnessAddress1
        End Get
        Set(ByVal Value As String)
            _strWitnessAddress1 = Value
        End Set
    End Property

    Public Property VehicleWitnessPersonAddress2() As String
        Get
            Return _strWitnessAddress2
        End Get
        Set(ByVal Value As String)
            _strWitnessAddress2 = Value
        End Set
    End Property

    Public Property VehicleDate() As Date
        Get
            Return _datVehcileLoanData
        End Get
        Set(ByVal Value As Date)
            _datVehcileLoanData = Value
        End Set
    End Property


    Public Property VehicleDueDate() As Date
        Get
            Return _datDueDate
        End Get
        Set(ByVal Value As Date)
            _datDueDate = Value
        End Set
    End Property

    Public Property VehicleInstPrinciple() As Integer
        Get
            Return _intInstPrinciple
        End Get
        Set(ByVal Value As Integer)
            _intInstPrinciple = Value
        End Set
    End Property

    Public Property VehicleAmtBalance() As Integer
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

    Public Property VehicleSubsidy() As String
        Get
            Return _strSubsidy
        End Get
        Set(ByVal Value As String)
            _strSubsidy = Value
        End Set
    End Property

    Public Property VehicleSancDate() As Date
        Get
            Return _datsancDate
        End Get
        Set(ByVal Value As Date)
            _datsancDate = Value
        End Set
    End Property

    Public Property VehicleSancNo() As String
        Get
            Return _dblSancNo
        End Get
        Set(ByVal Value As String)
            _dblSancNo = Value
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

    Public Property Status() As String
        Get
            Return _strStatus
        End Get
        Set(ByVal Value As String)
            _strStatus = Value
        End Set
    End Property

    Public Property DocumentTable() As DataTable
        Get
            Return _dtDocumentTable
        End Get
        Set(ByVal Value As DataTable)
            _dtDocumentTable = Value
        End Set
    End Property

    Public Property VehicleLastPaidDate() As Date
        Get
            Return _datLastPaid
        End Get
        Set(ByVal Value As Date)
            _datLastPaid = Value
        End Set
    End Property
    Public Property VehicleLastInstDate() As Date
        Get
            Return _datlastInstDate
        End Get
        Set(ByVal Value As Date)
            _datlastInstDate = Value
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

    Public Property Designation() As String
        Get
            Return _strDesignation
        End Get
        Set(ByVal Value As String)
            _strDesignation = Value
        End Set
    End Property

    Public Property ServiceAvailable() As Integer
        Get
            Return _intNoService
        End Get
        Set(ByVal Value As Integer)
            _intNoService = Value
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

    Public Property LicenceNo() As String
        Get
            Return _strLicenceNo
        End Get
        Set(ByVal Value As String)
            _strLicenceNo = Value
        End Set
    End Property

    Public Property Validity() As String
        Get
            Return _datValidity
        End Get
        Set(ByVal Value As String)
            _datValidity = Value
        End Set
    End Property

    Public Property PermitNo() As String
        Get
            Return _strPermitNo
        End Get
        Set(ByVal Value As String)
            _strPermitNo = Value
        End Set
    End Property
    Public Property PermitValidity() As String
        Get
            Return _datPValidity
        End Get
        Set(ByVal Value As String)
            _datPValidity = Value
        End Set
    End Property

    Public Property AreaOfOperation() As String
        Get
            Return _strAreaOfOperation
        End Get
        Set(ByVal Value As String)
            _strAreaOfOperation = Value
        End Set
    End Property
    Public Property ModeOfUse() As String
        Get
            Return _strModeOfUse
        End Get
        Set(ByVal Value As String)
            _strModeOfUse = Value
        End Set
    End Property
    Public Property OldVehicle() As Char
        Get
            Return _chrOldVehicle
        End Get
        Set(ByVal Value As Char)
            _chrOldVehicle = Value
        End Set
    End Property
    Public Property PurchaseDate() As Date
        Get
            Return _datPurchaseDate
        End Get
        Set(ByVal Value As Date)
            _datPurchaseDate = Value
        End Set
    End Property

    Public Property PreMarketPrice() As Integer
        Get
            Return _intPreMarketPrice
        End Get
        Set(ByVal Value As Integer)
            _intPreMarketPrice = Value
        End Set
    End Property
    Public Property InsuSerTax() As Integer
        Get
            Return _intTax
        End Get
        Set(ByVal Value As Integer)
            _intTax = Value
        End Set
    End Property
    Public Property FittingCost() As Integer
        Get
            Return _intCostOfFittings
        End Get
        Set(ByVal Value As Integer)
            _intCostOfFittings = Value
        End Set
    End Property
    Public Property BBuildingCharges() As Integer
        Get
            Return _intCostOfBBuilding
        End Get
        Set(ByVal Value As Integer)
            _intCostOfBBuilding = Value
        End Set
    End Property
    Public Property Netamount() As Integer
        Get
            Return _intNetAmount
        End Get
        Set(ByVal Value As Integer)
            _intNetAmount = Value
        End Set
    End Property
    Public Property ExpInTBusiness() As String
        Get
            Return _strExpTBusiness
        End Get
        Set(ByVal Value As String)
            _strExpTBusiness = Value
        End Set
    End Property
    Public Property LoanToRepay() As String
        Get
            Return _strLoanToRepay
        End Get
        Set(ByVal Value As String)
            _strLoanToRepay = Value
        End Set
    End Property
    Public Property DirName() As String
        Get
            Return _strDirName
        End Get
        Set(ByVal Value As String)
            _strDirName = Value
        End Set
    End Property

    Public Property DirRelation() As String
        Get
            Return _strNatRelationShip
        End Get
        Set(ByVal Value As String)
            _strNatRelationShip = Value
        End Set
    End Property


    Public Property parkedAddress() As String
        Get
            Return _strParkedAddress
        End Get
        Set(ByVal Value As String)
            _strParkedAddress = Value
        End Set
    End Property

    Public Property VehicleType() As String
        Get
            Return _strVehicleType
        End Get
        Set(ByVal Value As String)
            _strVehicleType = Value
        End Set
    End Property

    Public Property VehicleName() As String
        Get
            Return _strVehicleName
        End Get
        Set(ByVal Value As String)
            _strVehicleName = Value
        End Set
    End Property

    Public Property CostOfVehicle() As Integer
        Get
            Return _intCostOfVehicle
        End Get
        Set(ByVal Value As Integer)
            _intCostOfVehicle = Value
        End Set
    End Property

    Public Property DealerName() As String
        Get
            Return _strDealerName
        End Get
        Set(ByVal Value As String)
            _strDealerName = Value
        End Set
    End Property

    Public Property otherVehicle() As String
        Get
            Return _strOtherVehicle
        End Get
        Set(ByVal Value As String)
            _strOtherVehicle = Value
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

    Public Property SExpenses() As Integer
        Get
            Return _intSExpenses
        End Get
        Set(ByVal Value As Integer)
            _intSExpenses = Value
        End Set
    End Property

    Public Property BMonthlyIncome() As Integer
        Get
            Return _intBMonthly
        End Get
        Set(ByVal Value As Integer)
            _intBMonthly = Value
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

    Public Property BExpenses() As Integer
        Get
            Return _intBExpenses
        End Get
        Set(ByVal Value As Integer)
            _intBExpenses = Value
        End Set
    End Property

    Public Property IncomeTaxDet() As String
        Get
            Return _StrIncomeTaxDet
        End Get
        Set(ByVal Value As String)
            _StrIncomeTaxDet = Value
        End Set
    End Property

    '''This propertyes is used in Previous Version

    Public Property BorrowedLoanType1() As String
        Get
            Return _strBorrowedLoanType1
        End Get
        Set(ByVal Value As String)
            _strBorrowedLoanType1 = Value
        End Set
    End Property

    Public Property BorrowedLoanType2() As String
        Get
            Return _strBorrowedLoanType2
        End Get
        Set(ByVal Value As String)
            _strBorrowedLoanType2 = Value
        End Set
    End Property

    Public Property BorrowedAmount1() As Integer
        Get
            Return _intBorrowedAmount1
        End Get
        Set(ByVal Value As Integer)
            _intBorrowedAmount1 = Value
        End Set
    End Property

    Public Property borrowedAmount2() As Integer
        Get
            Return _intBorrowedAmount2
        End Get
        Set(ByVal Value As Integer)
            _intBorrowedAmount2 = Value
        End Set
    End Property

    Public Property AsSuretyPerson1() As String
        Get
            Return _strAsSuretyPerson1
        End Get
        Set(ByVal Value As String)
            _strAsSuretyPerson1 = Value
        End Set
    End Property

    Public Property AsSuretyPerson2() As String
        Get
            Return _strAsSuretyPerson2
        End Get
        Set(ByVal Value As String)
            _strAsSuretyPerson2 = Value
        End Set
    End Property

    Public Property AsSuretyLoanType1() As String
        Get
            Return _strAsSuretyType1
        End Get
        Set(ByVal Value As String)
            _strAsSuretyType1 = Value
        End Set
    End Property

    Public Property AsAsuretyLoanType2() As String
        Get
            Return _strAsSuretyType2
        End Get
        Set(ByVal Value As String)
            _strAsSuretyType2 = Value
        End Set
    End Property

    Public Property AsSuretyPaidAmount1() As Integer
        Get
            Return _intAsSuretyAmount1
        End Get
        Set(ByVal Value As Integer)
            _intAsSuretyAmount1 = Value
        End Set
    End Property

    Public Property AsSuretyPaidAmount2() As Integer
        Get
            Return _intAsSuretyAmount2
        End Get
        Set(ByVal Value As Integer)
            _intAsSuretyAmount2 = Value
        End Set
    End Property

    Public Property VehicleNo() As String
        Get
            Return _strVehicleNo
        End Get
        Set(ByVal Value As String)
            _strVehicleNo = Value
        End Set
    End Property

    Public Property EngineNo() As String
        Get
            Return _strEngineNo
        End Get
        Set(ByVal Value As String)
            _strEngineNo = Value
        End Set
    End Property

    Public Property ChaseNo() As String
        Get
            Return _strChaseNo
        End Get
        Set(ByVal Value As String)
            _strChaseNo = Value
        End Set
    End Property

    Public Property FC() As String
        Get
            Return _strFC
        End Get
        Set(ByVal Value As String)
            _strFC = Value
        End Set
    End Property

    Public Property RegistrationNo() As String
        Get
            Return _strRegistrationNo
        End Get
        Set(ByVal Value As String)
            _strRegistrationNo = Value
        End Set
    End Property

    Public Property RoadTax() As Double
        Get
            Return _dblRoadTax
        End Get
        Set(ByVal Value As Double)
            _dblRoadTax = Value
        End Set
    End Property
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Property BankResp() As String
        Get
            Return _StrifBankRespDet
        End Get
        Set(ByVal Value As String)
            _StrifBankRespDet = Value
        End Set
    End Property

    Public Property OrgResp() As String
        Get
            Return _StrifOrgResp
        End Get
        Set(ByVal Value As String)
            _StrifOrgResp = Value
        End Set
    End Property

    Public Property PersonResp() As String
        Get
            Return _StrifPersonResp
        End Get
        Set(ByVal Value As String)
            _StrifPersonResp = Value
        End Set
    End Property

    Public Property BankName() As String
        Get
            Return _strbankName
        End Get
        Set(ByVal Value As String)
            _strbankName = Value
        End Set
    End Property

    Public Property LoanType() As String
        Get
            Return _StrLoanType
        End Get
        Set(ByVal Value As String)
            _StrLoanType = Value
        End Set
    End Property

    Public Property LoanAmount() As Integer
        Get
            Return _intLoanAmount
        End Get
        Set(ByVal Value As Integer)
            _intLoanAmount = Value
        End Set
    End Property
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Property ImmovablePropertyDet() As String
        Get
            Return _StrImmovablePropertyDet
        End Get
        Set(ByVal Value As String)
            _StrImmovablePropertyDet = Value
        End Set
    End Property

    Public Property mortagagePropertyDet() As String
        Get
            Return _StrMortagagePropertyDet
        End Get
        Set(ByVal Value As String)
            _StrMortagagePropertyDet = Value
        End Set
    End Property

    Public Property Others() As String
        Get
            Return _strOthers
        End Get
        Set(ByVal Value As String)
            _strOthers = Value
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

    Public Property Relationship() As String
        Get
            Return _StrRelationship
        End Get
        Set(ByVal Value As String)
            _StrRelationship = Value
        End Set
    End Property

    Public Property AsBorrower() As Char
        Get
            Return _chrAsBorrower
        End Get
        Set(ByVal Value As Char)
            _chrAsBorrower = Value
        End Set
    End Property

    Public Property AsSalaried() As Char
        Get
            Return _chrAsSalaried
        End Get
        Set(ByVal Value As Char)
            _chrAsSalaried = Value
        End Set
    End Property


    Public Property AsBusiness() As Char
        Get
            Return _chrAsBusiness
        End Get
        Set(ByVal Value As Char)
            _chrAsBusiness = Value
        End Set
    End Property

    Public Property vehicleLoanDettable() As DataTable
        Get
            Return _dtVehicleLoanDet
        End Get
        Set(ByVal Value As DataTable)
            _dtVehicleLoanDet = Value
        End Set
    End Property

    Public Property vehicleLoanCusttable() As DataTable
        Get
            Return _dtVehicleCust
        End Get
        Set(ByVal Value As DataTable)
            _dtVehicleCust = Value
        End Set
    End Property


#End Region

#Region "Function"

    Public Function fnAddVLAccount(ByVal objTrans As IDbTransaction) As Boolean

        If fnCheckPerson() Then
            If fnUpdatePerson() Then
                If fnInsertVLAccount(objTrans) Then
                    If fnInsertVLDetails(objTrans) Then
                        Return fnInsertLoanDocunentStat(objTrans)
                    End If
                End If

            End If
        Else
            If fnAddPerson() Then
                If fnInsertVLAccount(objTrans) Then
                    If fnInsertVLDetails(objTrans) Then
                        If fnInsertLoanDocunentStat(objTrans) Then
                            Return True
                        Else
                            fnDeletePerson(objTrans)
                            fnDeleteLoanDet(LoanNo, objTrans)
                            fnDeleteVehicleDetails(LoanNo, objTrans)
                            fnDeleteLoanDocunentStat(LoanNo, objTrans)
                        End If
                    End If
                End If
            End If
        End If
    End Function

    Public Function fnInsertVLAccount(ByVal objTrans As IDbTransaction) As Boolean

        'Dim strSql As String

        strSQL = "insert into loanDetailstbl(LoanNo,PersonNo,CustomerID,SBNo,LoanType,ExpAmount,SancAmount,DisbAmount,ApplDate,SancDate,DueDate,SancNo,ROI,NOI,InstPrinciple,RepayMode,Purpose,Type,Balance,LastPaidDate,LastInstDate,Remarks,Status,ReceiptNo)"
        strSQL = strSQL & " values('" & _strLoanNo & "','" & PersonNo & "','" & _strMemberNo & "','" & _strSBNo & "','" & _chrLoanType & "','" & _intExpectedAmount & "','" & _intSanctionedAmount & "','" & _intDisbAmt & "','" & Format(_datVehcileLoanData, "yyyy-MM-dd") & "','" & Format(_datsancDate, "yyyy-MM-dd") & "','" & Format(_datDueDate, "yyyy-MM-dd") & "','" & _dblSancNo & "','" & _dblROI & "','" & _intNOI & "','"
        strSQL = strSQL & _intInstPrinciple & "','" & _strModeOfPayment & "','" & _strReason & "','" & _strInstallment & "','" & _intBalance & "','" & Format(_datLastPaid, "yyyy-MM-dd") & "','" & Format(_datlastInstDate, "yyyy-MM-dd") & "','" & _strRemarks & "','" & _strStatus & "','" & _strReciptNo & "')"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnChekVLAccount(ByVal strLoanNo As String) As Boolean

        strSQL = "select * from loanDetailstbl where loanNo = '" & strLoanNo & "'"

        _dtVehilceLoan = fnExecuteQuery(strSQL, 2)

        If _dtVehilceLoan.Rows.Count > 0 Then

            Return True
        Else
            Return False

        End If
    End Function

    Public Function fnInsertVLDetails(ByVal objTrans As IDbTransaction) As Boolean
        'VehicleNo, ,'" & _strVehicleNo & "'
        strSQL = "insert into VehicleLoanDetailstbl(LoanNo,CustomerID,PersonNo,OfficeName,Designation,ServiceAvailable,GreeProduced,MobileNo2,LicenceNo,Validity,VPermitNo,VPValidity,VmodeofUse,AreaOfOperation,ParkedAddress,VehicleType,VehicleModel,CostOfVehicle,VehicleName,Vpurchasedate,PreMarketrate,VTax,VAdditionalFittingCost,VBBuildingCost,NetAmount,"
        strSQL = strSQL & "DealerName,OtherVehcileDet,ExpTBusiness,ReasonForloan,SalaryPerson,SSalary,SRent,SOtherIncome,STotal,SExpenses,STotalSavings,BusinessPerson,BMonthlyIncome,BRent,BOtherIncome,BTotalIncome,BExpenses,BTotalSavings,IncomeTaxDetails,AsBorrower,ToSahakari,OtherInstitution,Individual,"
        strSQL = strSQL & "AsSurety,SuretyName1,SuretyLoanType1,SuretyAmount1,Relationship,ImmovablePropertyDet,MortagagePropertyDet,Others,DirectorName,RelationWthDirector,Installment,RegistrationNo,EngineNo,ChaseNo,FC,RoadTax) values ('" & _strLoanNo & "','" & _strMemberNo & "','" & PersonNo & "','"
        strSQL = strSQL & _strOfficeName & "','" & _strDesignation & "','" & _intNoService & "','" & _chrGTree & "','" & _strMobileNo2 & "','" & _strLicenceNo & "','" & Format(_datValidity, "yyyy-MM-dd") & "','" & _strPermitNo & "','" & Format(_datPValidity, "yyyy-MM-dd") & "','" & _strModeOfUse & "','" & _strAreaOfOperation & "','" & _strParkedAddress & "','" & _strVehicleType & "','" & _chrOldVehicle & "','" & _intCostOfVehicle & "','" & _strVehicleName & "','"
        strSQL = strSQL & Format(_datPValidity, "yyyy-MM-dd") & "','" & _intPreMarketPrice & "','" & _intTax & "','" & _intCostOfFittings & "','" & _intCostOfBBuilding & "','" & _intNetAmount & "','" & _strDealerName & "','" & _strOtherVehicle & "','" & _strExpTBusiness & "','" & _strLoanToRepay & "','" & _chrAsSalaried & "','" & _intSSalary & "','" & _intSRent & "','" & _intSOtherIncome & "','" & _intSTotalIncome & "','"
        strSQL = strSQL & _intSExpenses & "','" & _intSTotalSavings & "','" & _chrAsBusiness & "','" & _intBMonthly & "','" & _intBRent & "','" & _intBOtherIncome & "','" & _intBTotalIncome & "','" & _intBExpenses & "','" & _intBTotalSavings & "','" & _StrIncomeTaxDet & "','" & _chrAsBorrower & "','" & _StrifBankRespDet & "','" & _StrifOrgResp & "','" & _StrifPersonResp & "','" & _chrAsSurety & "','" & _strbankName & "','" & _StrLoanType & "',' "
        strSQL = strSQL & _intLoanAmount & "', '" & _StrRelationship & "','" & _StrImmovablePropertyDet & "','" & _StrMortagagePropertyDet & "','" & _strOthers & "','" & _strDirName & "','" & _strNatRelationShip & "','" & _strInstallment & "','" & _strRegistrationNo & "','" & _strEngineNo & "','" & _strChaseNo & "','" & _strFC & "','" & _dblRoadTax & "')"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnDeleteLoanDet(ByVal strLoanNo As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "delete from loandetailstbl where loanno = '" & strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnDeleteVehicleDetails(ByVal strLoanNo As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "delete from vehicleloandetailstbl where loanNo = '" & strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnUpdateLoanDetails(ByVal strLoanNo As String) As Boolean

        If fnUpdatePerson() Then
            strSQL = "UPDATE loandetailsTbl SET CustomerID = '" & _strMemberNo & "',personNo = '" & PersonNo & "', sbno = '" & _strSBNo & "',LoanType='" & _chrLoanType & "', expAmount='" & _intExpectedAmount & "', sancamount='" & _intSanctionedAmount & "',ApplDate = '" & Format(_datVehcileLoanData, "yyyy-MM-dd") & "',SancDate='" & Format(_datsancDate, "yyyy-MM-dd") & "',DueDate = '" & Format(_datDueDate, "yyyy-MM-dd") & "',SancNo='" & _dblSancNo & "', RepayMode  ='" & _strModeOfPayment & "', ROI='" & _dblROI & "', NOI = '" & _intNOI & "',InstPrinciple = '" & _intInstPrinciple & "',Purpose ='" & _strReason & "', Type='" & _strInstallment & "', Remarks = '" & _strRemarks & "'   WHERE  LoanNo='" & strLoanNo & "'"

            Return fnExecuteNonQuery(strSQL)
        Else
            Return False
        End If

    End Function

    Public Function fnUpdateVehicleDetails(ByVal strLoanNo As String) As Boolean
        'VehicleNo='" & _strVehicleNo & "',
        strSQL = "update vehicleloandetailstbl set OfficeName = '" & _strOfficeName & "',Designation = '" & _strDesignation & "',ServiceAvailable = '" & _intNoService & "',GreeProduced= '" & _chrGTree & "',MobileNo2='" & _strMobileNo2 & "',LicenceNo = '" & _strLicenceNo & "',Validity = '" & Format(_datValidity, "yyyy-MM-dd") & "',VPermitNo='" & _strPermitNo & "',VPValidity='" & Format(_datPValidity, "yyyy-MM-dd") & "' ,VmodeofUse='" & _strModeOfUse & "',AreaOfOperation = '" & _strAreaOfOperation & "',ParkedAddress = '" & _strParkedAddress & "',VehicleType = '" & _strVehicleType & "',CostOfVehicle = '" & _intCostOfVehicle & "',VehicleModel='" & _chrOldVehicle & "',VehicleName ='" & _strVehicleName & "',Vpurchasedate='" & Format(_datPurchaseDate, "yyyy-MM-dd") & "',PreMarketrate='" & _intPreMarketPrice & "',VTax='" & _intTax & "',"
        strSQL = strSQL & " VAdditionalFittingCost='" & _intCostOfFittings & "',VBBuildingCost='" & _intCostOfBBuilding & "',NetAmount='" & _intNetAmount & "',DealerName= '" & _strDealerName & "',OtherVehcileDet= '" & _strOtherVehicle & "',ExpTBusiness='" & _strExpTBusiness & "',ReasonForloan='" & _strLoanToRepay & "',SSalary = '" & _intSSalary & "',SRent= '" & _intSRent & "',SOtherIncome= '" & _intSOtherIncome & "',STotal= '" & _intSTotalIncome & "',SExpenses ='" & _intSExpenses & "',STotalSavings='" & _intSTotalSavings & "',BMonthlyIncome = '" & _intBMonthly & "',BRent= '" & _intBRent & "',"
        strSQL = strSQL & " BOtherIncome= '" & _intBOtherIncome & "',BTotalIncome= '" & _intBTotalIncome & "',BExpenses ='" & _intBExpenses & "',BTotalSavings='" & _intBTotalSavings & "',IncomeTaxDetails= '" & _StrIncomeTaxDet & "',ToSahakari = '" & _StrifBankRespDet & "',OtherInstitution= '" & _StrifOrgResp & "',Individual = '" & _StrifPersonResp & "',SuretyName1= '" & _strAsSuretyPerson1 & "',SuretyLoanType1 = '" & _strAsSuretyType1 & "',SuretyAmount1= '" & _intAsSuretyAmount1 & "',Relationship= '" & _StrRelationship & "',ImmovablePropertyDet= '" & _StrImmovablePropertyDet & "',MortagagePropertyDet= '" & _StrMortagagePropertyDet & "',"
        strSQL = strSQL & " Others = '" & _strOthers & "',DirectorName='" & _strDirName & "',RelationWthDirector='" & _strNatRelationShip & "',Installment ='" & _strInstallment & "',RegistrationNo='" & _strRegistrationNo & "',EngineNo='" & _strEngineNo & "',ChaseNo='" & _strChaseNo & "',FC='" & _strFC & "',RoadTax='" & _dblRoadTax & "' where loanno = '" & strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetLoanDetails(ByVal strLoanNo As String) As Boolean

        strSQL = "SELECT P.*, v.*, a.* FROM Loandetailstbl v, PersonTbl P, vehicleloandetailstbl a  WHERE P.PersonNo=v.PersonNo  and v.LoanNo='" & strLoanNo & "' AND  v.loanno = a.loanno"

        _dtVehicleLoanDet = fnExecuteQuery(strSQL, 2)

        If _dtVehicleLoanDet.Rows.Count > 0 Then
            Return True

        Else

            Return False
        End If

    End Function

    Public Function fnGetVehicleLoanCust() As Boolean

        strSQL = "select P.*, S.* FROM loandetailstbl S, PersonTbl P WHERE P.PersonNo=S.PersonNo and loanNo like 'LMV%'"

        _dtVehicleCust = fnExecuteQuery(strSQL, 2)

        If _dtVehicleCust.Rows.Count > 0 Then

            Return True
        Else
            Return False

        End If


    End Function


    Public Function fnInsertLoanDocunentStat(ByVal objTrans As IDbTransaction) As Boolean
        Dim dr As DataRow

        For Each dr In DocumentTable.Rows
            strSQL = "Insert into loandocstatustbl(LoanNo,DocId,DocStatus)values('" & dr(0) & "','" & dr(1) & "','" & dr(2) & "')"
            fnExecuteNonQuery(strSQL, objTrans)
        Next
        Return True

    End Function

    Public Function fnDeleteLoanDocunentStat(ByVal _strLoanNo As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Delete from loandocstatustbl where LoanNo = '" & _strLoanNo & "'"
        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function
    Public Function fnGetDocuments() As Boolean
        strSQL = "Select * from documenttbl "
        _dtDocumentTable = fnExecuteQuery(strSQL, 2)
        If _dtDocumentTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnGetDoc(ByVal _strLoanNo As String) As Boolean
        strSQL = "Select * from loandocstatustbl where LoanNo = '" & _strLoanNo & "'"
        _dtDocumentTable = fnExecuteQuery(strSQL, 2)
        If _dtDocumentTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function




#End Region

End Class
