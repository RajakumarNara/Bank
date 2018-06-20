Public Class clsHandLoan
    Inherits clsPerson

#Region "Variables"
    Private _strLoanNo As String
    Private _PersonNo As Long
    Private _strSBNo As String
    Private _strMemberNo As String
    Private _strFDNo As String
    Private _dblFDAmt As Double

    'person Number Comes from clsperson

    Private _datMediumLoanData As Date
    Private _strReciptNo As String
    Private _dtHandLoan As DataTable
    Private _dtHandLoanDet As DataTable
    Private _dtHandLoanCust As DataTable
    Private _chrLoanType As Char

    Private _strOfficeName As String
    Private _strDesignation As String
    Private _intServiceCompleted As Integer
    Private _intNoofDependant As Integer
    Private _intMonthlyExpenses As Integer
    Private _strMobileNo2 As String
    Private _strDirName As String
    Private _strNatureOfRealtionShip As String
    Private _chrSalaryedPerson As Char
    Private _chrBusiness As Char

    Private _strSurParticularsofMonth As String
    Private _intSalary As Integer
    Private _intDeamessAllowance As Integer
    Private _intHouseRentAllowance As Integer
    Private _intComensatoryAllowance As Integer
    Private _intOtherallowance As Integer
    Private _intTotalAmount As Integer

    Private _intNetSalary As Integer
    Private _intfamilyMonthlyExpenses As Integer

    Private _intIncomeTax As Integer
    Private _intProvidentFund As Integer
    Private _intInsurancePremium As Integer
    Private _intHBA As Integer
    Private _intOtherDeduction As Integer
    Private _intTotalDeduction As Integer

    Private _strNatureOfBusiness As String
    Private _datYearOfEstablishment As Date
    Private _intAnnualTurnOver As Integer
    Private _intAnnualIncome As Integer
    Private _strEvidenceForBusiness As String
    Private _strTaxDetails As String
    Private _strChequeDetail As String
    Private _strOtherDetail As String

    Private _intExpectedAmount As Integer
    Private _intSanctionedAmount As Integer
    Private _dblSanctionedNo As String
    Private _dblROI As Double
    Private _strInstallment As String
    Private _strModeOfPayment As String
    Private _strReason As String
    Private _intReceiptNo As Integer
    Private _intEstimatedAmt As Integer
    Private _datlastInstDate As Date


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''
    ''''''''''''''''
    Private _strDocumentsProduced As String
    Private _strImmoveableProperty As String
    Private _strOtherMemebrShip As String
    Private _intRepaymentCapacity As Integer
    Private _strInsuranceDetail As String
    Private _strSupplementDetail As String
    Private _strRemittedToSahakari As String
    Private _strRepayModeForNonEarning As String
    Private _strOtherSourceOfIncome As String

    Private _strWitnessPerson1 As String
    Private _strWitnessAddress1 As String
    Private _intInstPrinciple As Integer
    Private _datSancDate As Date
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
    Private _StrRepaymentDet As String
    Private _strAssetDetails As String

    Private _chrPersonalIdentification As Char
    Private _dtDLDet As DataTable
    Private _dtDocumentTable As DataTable
    Private _dtFDDetails As DataTable
    Private _dtNSCDetails As DataTable


#End Region

#Region "Properties "

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
    '        Return _StrRemarks
    '    End Get
    '    Set(ByVal Value As String)
    '        _StrRemarks = Value
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
    Public Property HandLoanTable() As DataTable
        Get
            Return _dtHandLoan
        End Get
        Set(ByVal Value As DataTable)
            _dtHandLoan = Value
        End Set
    End Property

    Public Property HandLExpectedAmount() As Integer
        Get
            Return _intExpectedAmount
        End Get
        Set(ByVal Value As Integer)
            _intExpectedAmount = Value
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

    Public Property HandLSanctioned() As Integer
        Get
            Return _intSanctionedAmount
        End Get
        Set(ByVal Value As Integer)
            _intSanctionedAmount = Value
        End Set
    End Property
    Public Property HandLSanctionedNo() As String
        Get
            Return _dblSanctionedNo
        End Get
        Set(ByVal Value As String)
            _dblSanctionedNo = Value
        End Set
    End Property

    Public Property HandLROI() As Double
        Get
            Return _dblROI
        End Get
        Set(ByVal Value As Double)
            _dblROI = Value
        End Set
    End Property

    Public Property HandLDisbAmt() As Integer
        Get
            Return _intDisbAmt
        End Get
        Set(ByVal Value As Integer)
            _intDisbAmt = Value
        End Set
    End Property

    Public Property HandLInstallments() As String
        Get
            Return _strInstallment
        End Get
        Set(ByVal Value As String)
            _strInstallment = Value
        End Set
    End Property

    Public Property HandLModeOfPayment() As String
        Get
            Return _strModeOfPayment
        End Get
        Set(ByVal Value As String)
            _strModeOfPayment = Value
        End Set
    End Property

    Public Property HandLReason() As String
        Get
            Return _strReason
        End Get
        Set(ByVal Value As String)
            _strReason = Value
        End Set
    End Property

    Public Property HandLWitnessPerson1() As String
        Get
            Return _strWitnessPerson1
        End Get
        Set(ByVal Value As String)
            _strWitnessPerson1 = Value
        End Set
    End Property

    Public Property HandLWitnessPersonAddress1() As String
        Get
            Return _strWitnessAddress1
        End Get
        Set(ByVal Value As String)
            _strWitnessAddress1 = Value
        End Set
    End Property

    Public Property HandLoanDate() As Date
        Get
            Return _datMediumLoanData
        End Get
        Set(ByVal Value As Date)
            _datMediumLoanData = Value
        End Set
    End Property

    Public Property HandLoanDueDate() As Date
        Get
            Return _datDueDate
        End Get
        Set(ByVal Value As Date)
            _datDueDate = Value
        End Set
    End Property

    Public Property HandLoanSancDate() As Date
        Get
            Return _datSancDate
        End Get
        Set(ByVal Value As Date)
            _datSancDate = Value
        End Set
    End Property

    Public Property HandLoanInstPrinciple() As Integer
        Get
            Return _intInstPrinciple
        End Get
        Set(ByVal Value As Integer)
            _intInstPrinciple = Value
        End Set
    End Property

    Public Property HandLoanAmtBalance() As Integer
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

    Public Property HandLoanLastPaidDate() As Date
        Get
            Return _datLastPaid
        End Get
        Set(ByVal Value As Date)
            _datLastPaid = Value
        End Set
    End Property

    Public Property HandLoanDettable() As DataTable
        Get
            Return _dtHandLoanDet
        End Get
        Set(ByVal Value As DataTable)
            _dtHandLoanDet = Value
        End Set
    End Property

    Public Property HandLoanCusttable() As DataTable
        Get
            Return _dtHandLoanCust
        End Get
        Set(ByVal Value As DataTable)
            _dtHandLoanCust = Value
        End Set
    End Property

    Public Property HLDetailstable() As DataTable
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

    Public Property ServiceCompleted() As Integer
        Get
            Return _intServiceCompleted
        End Get
        Set(ByVal Value As Integer)
            _intServiceCompleted = Value
        End Set
    End Property

    Public Property NoOfDependants() As Integer
        Get
            Return _intNoofDependant
        End Get
        Set(ByVal Value As Integer)
            _intNoofDependant = Value
        End Set
    End Property

    Public Property MonthlyExpenses() As Integer
        Get
            Return _intMonthlyExpenses
        End Get
        Set(ByVal Value As Integer)
            _intMonthlyExpenses = Value
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

    Public Property DirName() As String
        Get
            Return _strDirName
        End Get
        Set(ByVal Value As String)
            _strDirName = Value
        End Set
    End Property

    Public Property DirNatureOfRelation() As String
        Get
            Return _strNatureOfRealtionShip
        End Get
        Set(ByVal Value As String)
            _strNatureOfRealtionShip = Value
        End Set
    End Property



    Public Property ChequeDetail() As String
        Get
            Return _strChequeDetail
        End Get
        Set(ByVal Value As String)
            _strChequeDetail = Value
        End Set
    End Property

    Public Property OtherDetail() As String
        Get
            Return _strOtherDetail
        End Get
        Set(ByVal Value As String)
            _strOtherDetail = Value
        End Set
    End Property

    Public Property SalaryPerson() As Char
        Get
            Return _chrSalaryedPerson
        End Get
        Set(ByVal Value As Char)
            _chrSalaryedPerson = Value
        End Set
    End Property

    Public Property BusinessPerson() As Char
        Get
            Return _chrBusiness
        End Get
        Set(ByVal Value As Char)
            _chrBusiness = Value
        End Set
    End Property
    Public Property LastInstDate() As Date
        Get
            Return _datlastInstDate
        End Get
        Set(ByVal Value As Date)
            _datlastInstDate = Value
        End Set
    End Property
    Public Property SurParticularsOfMonth() As String
        Get
            Return _strSurParticularsofMonth
        End Get
        Set(ByVal Value As String)
            _strSurParticularsofMonth = Value
        End Set
    End Property

    Public Property Salary() As Integer
        Get
            Return _intSalary
        End Get
        Set(ByVal Value As Integer)
            _intSalary = Value
        End Set
    End Property
    Public Property DeamessAllowance() As Integer
        Get
            Return _intDeamessAllowance
        End Get
        Set(ByVal Value As Integer)
            _intDeamessAllowance = Value
        End Set
    End Property
    Public Property EstimatedAmount() As Integer
        Get
            Return _intEstimatedAmt
        End Get
        Set(ByVal Value As Integer)
            _intEstimatedAmt = Value
        End Set
    End Property

    Public Property HouseRentAllowance() As Integer
        Get
            Return _intHouseRentAllowance
        End Get
        Set(ByVal Value As Integer)
            _intHouseRentAllowance = Value
        End Set
    End Property

    Public Property ComensatoryAllowance() As Integer
        Get
            Return _intComensatoryAllowance
        End Get
        Set(ByVal Value As Integer)
            _intComensatoryAllowance = Value
        End Set
    End Property

    Public Property Otherallowance() As Integer
        Get
            Return _intOtherallowance
        End Get
        Set(ByVal Value As Integer)
            _intOtherallowance = Value
        End Set
    End Property


    Public Property TotalAmount() As Integer
        Get
            Return _intTotalAmount
        End Get
        Set(ByVal Value As Integer)
            _intTotalAmount = Value
        End Set
    End Property
    Public Property NetSalary() As Integer
        Get
            Return _intNetSalary
        End Get
        Set(ByVal Value As Integer)
            _intNetSalary = Value
        End Set
    End Property

    Public Property familyMonthlyExpenses() As Integer
        Get
            Return _intfamilyMonthlyExpenses
        End Get
        Set(ByVal Value As Integer)
            _intfamilyMonthlyExpenses = Value
        End Set
    End Property

    Public Property IncomeTax() As Integer
        Get
            Return _intIncomeTax
        End Get
        Set(ByVal Value As Integer)
            _intIncomeTax = Value
        End Set
    End Property

    Public Property ProvidentFund() As Integer
        Get
            Return _intProvidentFund
        End Get
        Set(ByVal Value As Integer)
            _intProvidentFund = Value
        End Set
    End Property

    Public Property InsurancePremium() As Integer
        Get
            Return _intInsurancePremium
        End Get
        Set(ByVal Value As Integer)
            _intInsurancePremium = Value
        End Set
    End Property

    Public Property HBA() As Integer
        Get
            Return _intHBA
        End Get
        Set(ByVal Value As Integer)
            _intHBA = Value
        End Set
    End Property

    Public Property OtherDeduction() As Integer
        Get
            Return _intOtherDeduction
        End Get
        Set(ByVal Value As Integer)
            _intOtherDeduction = Value
        End Set
    End Property

    Public Property TotalDeduction() As Integer
        Get
            Return _intTotalDeduction
        End Get
        Set(ByVal Value As Integer)
            _intTotalDeduction = Value
        End Set
    End Property
    Public Property AnnualTurnOver() As Integer
        Get
            Return _intAnnualTurnOver
        End Get
        Set(ByVal Value As Integer)
            _intAnnualTurnOver = Value
        End Set
    End Property
    Public Property AnnualIncome() As Integer
        Get
            Return _intAnnualIncome
        End Get
        Set(ByVal Value As Integer)
            _intAnnualIncome = Value
        End Set
    End Property
    Public Property NatureOfBusiness() As String
        Get
            Return _strNatureOfBusiness
        End Get
        Set(ByVal Value As String)
            _strNatureOfBusiness = Value
        End Set
    End Property

    Public Property YearOfEstablishment() As Date
        Get
            Return _datYearOfEstablishment
        End Get
        Set(ByVal Value As Date)
            _datYearOfEstablishment = Value
        End Set
    End Property

    Public Property DocumentsProduced() As String
        Get
            Return _strDocumentsProduced
        End Get
        Set(ByVal Value As String)
            _strDocumentsProduced = Value
        End Set
    End Property
    Public Property ImmoveableProperty() As String
        Get
            Return _strImmoveableProperty
        End Get
        Set(ByVal Value As String)
            _strImmoveableProperty = Value
        End Set
    End Property
    Public Property OtherMemebrShip() As String
        Get
            Return _strOtherMemebrShip
        End Get
        Set(ByVal Value As String)
            _strOtherMemebrShip = Value
        End Set
    End Property
    Public Property TaxDetails() As String
        Get
            Return _strTaxDetails
        End Get
        Set(ByVal Value As String)
            _strTaxDetails = Value
        End Set
    End Property
    Public Property RepaymentCapacity() As Integer
        Get
            Return _intRepaymentCapacity
        End Get
        Set(ByVal Value As Integer)
            _intRepaymentCapacity = Value
        End Set
    End Property
    Public Property InsuranceDetail() As String
        Get
            Return _strInsuranceDetail
        End Get
        Set(ByVal Value As String)
            _strInsuranceDetail = Value
        End Set
    End Property
    Public Property SupplementDetail() As String
        Get
            Return _strSupplementDetail
        End Get
        Set(ByVal Value As String)
            _strSupplementDetail = Value
        End Set
    End Property
    Public Property RemittedToSahakari() As String
        Get
            Return _strRemittedToSahakari
        End Get
        Set(ByVal Value As String)
            _strRemittedToSahakari = Value
        End Set
    End Property
    Public Property RepayModeForNonEarning() As String
        Get
            Return _strRepayModeForNonEarning
        End Get
        Set(ByVal Value As String)
            _strRepayModeForNonEarning = Value
        End Set

    End Property
    Public Property OtherSourceOfIncome() As String
        Get
            Return _strOtherSourceOfIncome
        End Get
        Set(ByVal Value As String)
            _strOtherSourceOfIncome = Value
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
    Public Property Immovable() As String
        Get
            Return Immovable
        End Get
        Set(ByVal Value As String)
            Immovable = Value
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
    Public Property NSCDetailsTable() As DataTable
        Get
            Return _dtNSCDetails
        End Get
        Set(ByVal Value As DataTable)
            _dtNSCDetails = Value
        End Set
    End Property
    Public Property FDDetailsTable() As DataTable
        Get
            Return _dtFDDetails
        End Get
        Set(ByVal Value As DataTable)
            _dtFDDetails = Value
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

    Public Property FDAmt() As Double
        Get
            Return _dblFDAmt
        End Get
        Set(ByVal Value As Double)
            _dblFDAmt = Value
        End Set
    End Property
#End Region

#Region "Function For Hand Loan"

    Public Function fnAddDLAccount(ByVal objTrans As IDbTransaction) As Boolean

        If fnCheckPerson() Then

            If fnUpdatePerson(objTrans) Then

                If fnInsertHLAccount(objTrans) Then

                    If fnInsertHandLoanDet(objTrans) Then

                        Return fnInsertLoanDocunentStat(objTrans)

                    End If

                End If

            End If

        Else

            If fnAddPerson(objTrans) Then

                If fnInsertHLAccount(objTrans) Then

                    If fnInsertHandLoanDet(objTrans) Then

                        Return fnInsertLoanDocunentStat(objTrans)

                    Else

                        fnDeletePerson(objTrans)

                        fnDeleteLoanDet(LoanNo, objTrans)

                        fnDeleteHLDetails(LoanNo, objTrans)

                        fnDeleteLoanDocunentStat(LoanNo, objTrans)

                    End If

                End If

            End If

        End If

    End Function


    Public Function fnAddLAccount(ByVal objTrans As IDbTransaction) As Boolean

        If fnCheckPerson() Then

            If fnUpdatePerson(objTrans) Then

                If fnInsertHLAccount(objTrans) Then

                    If fnInsertHandLoanDet(objTrans) Then

                        If fnInsertLoanDocunentStat(objTrans) Then

                            Return fnInsertSecurityDetailsInfo(objTrans)

                        End If

                    End If

                End If

            End If

        Else

            If fnAddPerson() Then

                If fnInsertHLAccount(objTrans) Then

                    If fnInsertHandLoanDet(objTrans) Then

                        If fnInsertLoanDocunentStat(objTrans) Then

                            Return fnInsertSecurityDetailsInfo(objTrans)

                        Else

                            fnDeletePerson(objTrans)

                            fnDeleteLoanDet(LoanNo, objTrans)

                            fnDeleteHLDetails(LoanNo, objTrans)

                            fnDeleteLoanDocunentStat(LoanNo, objTrans)

                        End If

                    End If

                End If

            End If

        End If

    End Function


    Public Function fnInsertHLAccount(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "insert into loanDetailstbl(LoanNo,PersonNo,CustomerID,SBNo,LoanType,ExpAmount,SancAmount,DisbAmount,ApplDate,SancDate,DueDate,SancNo,ROI,NOI,InstPrinciple,RepayMode,Purpose,Type,Balance,LastPaidDate,LastInstDate,Remarks,Status,FDNo,FDEstAmount,ReceiptNo)"
        strSQL = strSQL & " values('" & _strLoanNo & "','" & PersonNo & "','" & _strMemberNo & "','" & _strSBNo & "','" & _chrLoanType & "','" & _intExpectedAmount & "','" & _intSanctionedAmount & "','" & _intDisbAmt & "','" & Format(_datMediumLoanData, "yyyy-MM-dd") & "','" & Format(_datSancDate, "yyyy-MM-dd") & "','" & Format(_datDueDate, "yyyy-MM-dd") & "','" & _dblSanctionedNo & "','" & _dblROI & "','" & _intNOI & "','"
        strSQL = strSQL & _intInstPrinciple & "','" & _strModeOfPayment & "','" & _strReason & "','" & _strInstallment & "','" & _intBalance & "','" & Format(_datLastPaid, "yyyy-MM-dd") & "','" & Format(_datlastInstDate, "yyyy-MM-dd") & "','" & _StrRemarks & "','" & _strStatus & "','" & _strFDNo & "','" & _intEstimatedAmt & "','" & _strReciptNo & "')"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnChekHLAccount(ByVal strLoanNo As String) As Boolean

        strSQL = "select * from loanDetailstbl where loanNo = '" & strLoanNo & "'"

        _dtHandLoan = fnExecuteQuery(strSQL, 2)

        If _dtHandLoan.Rows.Count > 0 Then

            Return True
        Else
            Return False

        End If
    End Function

    Public Function fnDeleteLoanDet(ByVal strLoanNo As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "delete from loandetailstbl where loanno = '" & strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnUpdateLoanDetails(ByVal strLoanNo As String, ByVal objTrans As IDbTransaction) As Boolean

        If fnUpdatePerson(objTrans) Then

            strSQL = "UPDATE loandetailsTbl SET CustomerID = '" & _strMemberNo & "',personNo = '" & PersonNo & "', sbno = '" & _strSBNo & "',LoanType='" & _chrLoanType & "', expAmount='" & _intExpectedAmount & "', sancamount='" & _intSanctionedAmount & "',ApplDate = '" & Format(_datMediumLoanData, "yyyy-MM-dd") & "',SancDate='" & Format(_datSancDate, "yyyy-MM-dd") & "',DueDate = '" & Format(_datDueDate, "yyyy-MM-dd") & "', SancNo='" & _dblSanctionedNo & "',RepayMode  ='" & _strModeOfPayment & "', ROI='" & _dblROI & "', NOI = '" & _intNOI & "',InstPrinciple = '" & _intInstPrinciple & "',Purpose ='" & _strReason & "',Type = '" & _strInstallment & "', Remarks = '" & _StrRemarks & "' WHERE  LoanNo='" & strLoanNo & "'"

            Return fnExecuteNonQuery(strSQL, objTrans)

        Else
            Return False
        End If

    End Function

    Public Function fnGetLoanDetails(ByVal strLoanNo As String) As Boolean

        strSQL = "SELECT P.*, v.* FROM Loandetailstbl v, PersonTbl P WHERE P.PersonNo=v.PersonNo  and v.LoanNo='" & strLoanNo & "' "

        _dtHandLoanDet = fnExecuteQuery(strSQL, 2)

        If _dtHandLoanDet.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function fnGetHandLoanCust() As Boolean

        strSQL = "select P.*, S.* FROM loandetailstbl S, PersonTbl P WHERE P.PersonNo=S.PersonNo and loanNo like 'HL%'"

        _dtHandLoanCust = fnExecuteQuery(strSQL, 2)

        If _dtHandLoanCust.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function fnInsertHandLoanDet(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Insert into loanadditionaldetailstbl (LoanNo,Designation,OfficeName,NoOfServiceCompleted,NoDependants,MobileNo2,MonthlyExpenses,DirectorName,DirRelationship,SalariedPerson,SuretyParticulars,SBasicPay,"
        strSQL = strSQL & " SDeamessAllowance,SHouseREntAllowance,SCityComensatoryAllowance,SotherIncome,STotalAmount,SincomeTax,SProvidentFund,SInsurancePremium,SHBA,SOtherDeduction,STotalDeduction,SNetSalary,"
        strSQL = strSQL & "FamilyMonDomesticExpn,BusinessPerson,BNatureOfBusiness,BYearofEstablished,BAnnualTurnover,BAnnualIncome,BDocForBusiness,BIncomeSalesTax,AssetDetails,Immovableproperty,memberToAnyOtherCooperative,"
        strSQL = strSQL & "RepayingCapacityPerMonth,InsuranceDetail,SuppleForRepay,SalaryRemitanceToSahakari,RepaymentModeForNonEarning,OtherSourceOfIncome,ChequeDetails,OtherDetails) values ('" & _strLoanNo & "','" & _strDesignation & "','" & _strOfficeName & "','"
        strSQL = strSQL & _intServiceCompleted & "','" & _intNoofDependant & "','" & _strMobileNo2 & "','" & _intMonthlyExpenses & "','" & _strDirName & "','" & _strNatureOfRealtionShip & "','" & _chrSalaryedPerson & "','" & _strSurParticularsofMonth & "','" & _intSalary & "','" & _intDeamessAllowance & "','"
        strSQL = strSQL & _intHouseRentAllowance & "','" & _intComensatoryAllowance & "','" & _intOtherallowance & "','" & _intTotalAmount & "','" & _intIncomeTax & "','" & _intProvidentFund & "','" & _intInsurancePremium & "','" & _intHBA & "','" & _intOtherDeduction & "','" & _intTotalDeduction & "','"
        strSQL = strSQL & _intNetSalary & "','" & _intfamilyMonthlyExpenses & "','" & _chrBusiness & "','" & _strNatureOfBusiness & "','" & Format(_datYearOfEstablishment, "yyyy-MM-dd") & "','" & _intAnnualTurnOver & "','" & _intAnnualIncome & "','" & _strDocumentsProduced & "','" & _strTaxDetails & "','" & _strAssetDetails & "','"
        strSQL = strSQL & _strImmoveableProperty & "','" & _strOtherMemebrShip & "','" & _intRepaymentCapacity & "','" & _strInsuranceDetail & "','" & _strSupplementDetail & "','" & _strRemittedToSahakari & "','" & _strRepayModeForNonEarning & "','" & _strOtherSourceOfIncome & "','" & _strChequeDetail & "','" & _strOtherDetail & "')"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnDeleteHLDetails(ByVal strLoanNo As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Delete from loanadditionaldetailstbl where LoanNo = '" & strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnUpDateHLDet(ByVal strLoanNo As String, ByVal objTrans As IDbTransaction) As Boolean

        '  strSQL = "update demandloandettbl set AssetDetails = '" & _strAssetDetails & "',TypeOfRepayment = '" & _StrRepaymentDet & "',PersonalIdentification = '" & _chrPersonalIdentification & "',OfficeName = '" & _strOfficeName & "',Designation = '" & _strDesignation & "',WitnessPerson1 = '" & _strWitnessPerson1 & "',Address1 = '" & _strWitnessAddress1 & "',Installment = '" & _strInstallment & "' where loanno = '" & strLoanNo & "'"

        strSQL = "Update  loanadditionaldetailstbl  set Designation='" & _strDesignation & "',OfficeName='" & _strOfficeName & "',NoOfServiceCompleted='" & _intServiceCompleted & "',NoDependants='" & _intNoofDependant & "',MobileNo2='" & _strMobileNo2 & "',MonthlyExpenses='" & _intMonthlyExpenses & "',DirectorName='" & _strDirName & "',DirRelationship='" & _strNatureOfRealtionShip & "',SalariedPerson='" & _chrSalaryedPerson & "',SuretyParticulars='" & _strSurParticularsofMonth & "',SBasicPay='" & _intSalary & "',"
        strSQL = strSQL & " SDeamessAllowance='" & _intDeamessAllowance & "',SHouseREntAllowance='" & _intHouseRentAllowance & "',SCityComensatoryAllowance='" & _intComensatoryAllowance & "',SotherIncome='" & _intOtherallowance & "',STotalAmount='" & _intTotalAmount & "',SincomeTax='" & _intIncomeTax & "',SProvidentFund='" & _intProvidentFund & "',SInsurancePremium='" & _intInsurancePremium & "',SHBA='" & _intHBA & "',SOtherDeduction='" & _intOtherDeduction & "',STotalDeduction='" & _intTotalDeduction & "',SNetSalary='" & _intNetSalary & "',"
        strSQL = strSQL & "FamilyMonDomesticExpn='" & _intfamilyMonthlyExpenses & "',BusinessPerson='" & _chrBusiness & "',BNatureOfBusiness='" & _strNatureOfBusiness & "',BYearofEstablished='" & Format(_datYearOfEstablishment, "yyyy-MM-dd") & "',BAnnualTurnover='" & _intAnnualTurnOver & "',BAnnualIncome='" & _intAnnualIncome & "',BDocForBusiness='" & _strDocumentsProduced & "',BIncomeSalesTax='" & _strTaxDetails & "',AssetDetails='" & _strAssetDetails & "',Immovableproperty='" & _strImmoveableProperty & " ',memberToAnyOtherCooperative='" & _strOtherMemebrShip & "',"
        strSQL = strSQL & "RepayingCapacityPerMonth='" & _intRepaymentCapacity & "',InsuranceDetail='" & _strInsuranceDetail & "',SuppleForRepay='" & _strSupplementDetail & "',SalaryRemitanceToSahakari='" & _strRemittedToSahakari & "',RepaymentModeForNonEarning='" & _strRepayModeForNonEarning & "',OtherSourceOfIncome='" & _strOtherSourceOfIncome & "'where loanno = '" & strLoanNo & "'"


        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnGetHandLoanDet(ByVal strLoanNo As String) As Boolean

        strSQL = "Select * from loanadditionaldetailstbl where loanno = '" & strLoanNo & "'"

        _dtDLDet = fnExecuteQuery(strSQL, 2)

        If _dtDLDet.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

#End Region

    Public Function fnGetCHandLoanCust() As Boolean

        strSQL = "select P.*, S.* FROM loandetailstbl S, PersonTbl P WHERE P.PersonNo=S.PersonNo and loanNo like 'CHL%'"

        _dtHandLoanCust = fnExecuteQuery(strSQL, 2)

        If _dtHandLoanCust.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function fnGetCHandLoanCust(ByVal LType As String) As Boolean

        strSQL = "select P.*, S.* FROM loandetailstbl S, PersonTbl P WHERE P.PersonNo=S.PersonNo and loanNo like '" & LType & "'"

        _dtHandLoanCust = fnExecuteQuery(strSQL, 2)

        If _dtHandLoanCust.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function fnGetLoansAgainstDepositCust() As Boolean

        strSQL = "select P.*, S.* FROM loandetailstbl S, PersonTbl P WHERE P.PersonNo=S.PersonNo and loanNo like 'LTD%'"

        _dtHandLoanCust = fnExecuteQuery(strSQL, 2)

        If _dtHandLoanCust.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function fnGetLoanFDDetails(ByVal FDNO As String) As Boolean

        strSQL = "SELECT P.*, M.* FROM fddetailstbl M, PersonTbl P WHERE P.PersonNo=M.PersonNo AND M.FDNo='" & FDNO & "'"

        _dtFDDetails = fnExecuteQuery(strSQL, 2)

        If _dtFDDetails.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If


    End Function


#Region "Function For Surety Loan"


    Public Function fnAddSLAccount(ByVal objTrans As IDbTransaction) As Boolean

        If fnCheckPerson() Then

            If fnUpdatePerson(objTrans) Then

                If fnInsertSLAccount(objTrans) Then

                    If fnInsertSuretyLoanDet(objTrans) Then

                        Return fnInsertLoanDocunentStat(objTrans)

                    End If

                End If

            End If

        Else

            If fnAddPerson() Then

                If fnInsertSLAccount(objTrans) Then

                    If fnInsertSuretyLoanDet(objTrans) Then


                        If fnInsertLoanDocunentStat(objTrans) Then

                            Return True

                        Else

                            fnDeletePerson(objTrans)

                            fnDeleteLoanDet(LoanNo, objTrans)

                            fnDeleteSLDetails(LoanNo, objTrans)

                            fnDeleteLoanDocunentStat(LoanNo, objTrans)

                        End If


                    End If

                End If

            End If

        End If

    End Function

    Public Function fnInsertSLAccount(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "insert into loanDetailstbl(LoanNo,PersonNo,CustomerID,SBNo,LoanType,ExpAmount,SancAmount,DisbAmount,ApplDate,SancDate,DueDate,SancNo,ROI,NOI,InstPrinciple,RepayMode,Purpose,Type,Balance,LastPaidDate,LastInstDate,Remarks,Status,ReceiptNo)"
        strSQL = strSQL & " values('" & _strLoanNo & "','" & PersonNo & "','" & _strMemberNo & "','" & _strSBNo & "','" & _chrLoanType & "','" & _intExpectedAmount & "','" & _intSanctionedAmount & "','" & _intDisbAmt & "','" & Format(_datMediumLoanData, "yyyy-MM-dd") & "','" & Format(_datSancDate, "yyyy-MM-dd") & "','" & Format(_datDueDate, "yyyy-MM-dd") & "','" & _dblSanctionedNo & "','" & _dblROI & "','" & _intNOI & "','"
        strSQL = strSQL & _intInstPrinciple & "','" & _strModeOfPayment & "','" & _strReason & "','" & _strInstallment & "','" & _intBalance & "','" & Format(_datLastPaid, "yyyy-MM-dd") & "','" & Format(_datlastInstDate, "yyyy-MM-dd") & "','" & _StrRemarks & "','" & _strStatus & "','" & _strReciptNo & "')"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function



    Public Function fnChekSLAccount(ByVal strLoanNo As String) As Boolean

        strSQL = "select * from loanDetailstbl where loanNo = '" & strLoanNo & "'"

        _dtHandLoan = fnExecuteQuery(strSQL, 2)

        If _dtHandLoan.Rows.Count > 0 Then

            Return True
        Else
            Return False

        End If
    End Function


    Public Function fnDeleteSuretyLoanDet(ByVal strLoanNo As String) As Boolean

        strSQL = "delete from loandetailstbl where loanno = '" & strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnUpdateSuretyLoanDetails(ByVal strLoanNo As String) As Boolean

        If fnUpdatePerson() Then
            strSQL = "UPDATE loandetailsTbl SET CustomerID = '" & _strMemberNo & "',personNo = '" & PersonNo & "', sbno = '" & _strSBNo & "', LoanType='" & _chrLoanType & "',expAmount='" & _intExpectedAmount & "', sancamount='" & _intSanctionedAmount & "',ApplDate = '" & Format(_datMediumLoanData, "yyyy-MM-dd") & "',SancDate='" & Format(_datSancDate, "yyyy-MM-dd") & "',DueDate = '" & Format(_datDueDate, "yyyy-MM-dd") & "',SancNo='" & _dblSanctionedNo & "', RepayMode  ='" & _strModeOfPayment & "', ROI='" & _dblROI & "', NOI = '" & _intNOI & "',InstPrinciple = '" & _intInstPrinciple & "',Purpose ='" & _strReason & "',Type = '" & _strInstallment & "', Remarks = '" & _StrRemarks & "' WHERE  LoanNo='" & strLoanNo & "'"

            Return fnExecuteNonQuery(strSQL)

        Else
            Return False
        End If

    End Function

    Public Function fnGetSuretyLoanDetails(ByVal strLoanNo As String) As Boolean

        strSQL = "SELECT P.*, v.* FROM Loandetailstbl v, PersonTbl P WHERE P.PersonNo=v.PersonNo  and v.LoanNo='" & strLoanNo & "' "

        _dtHandLoanDet = fnExecuteQuery(strSQL, 2)

        If _dtHandLoanDet.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function fnGetSuretyLoanCust() As Boolean

        strSQL = "select P.*, S.* FROM loandetailstbl S, PersonTbl P WHERE P.PersonNo=S.PersonNo and loanNo like 'SL%'"

        _dtHandLoanCust = fnExecuteQuery(strSQL, 2)

        If _dtHandLoanCust.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function fnInsertSuretyLoanDet(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Insert into loanadditionaldetailstbl (LoanNo,Designation,OfficeName,NoOfServiceCompleted,NoDependants,MobileNo2,MonthlyExpenses,DirectorName,DirRelationship,SalariedPerson,SuretyParticulars,SBasicPay,"
        strSQL = strSQL & " SDeamessAllowance,SHouseREntAllowance,SCityComensatoryAllowance,SotherIncome,STotalAmount,SincomeTax,SProvidentFund,SInsurancePremium,SHBA,SOtherDeduction,STotalDeduction,SNetSalary,"
        strSQL = strSQL & "FamilyMonDomesticExpn,BusinessPerson,BNatureOfBusiness,BYearofEstablished,BAnnualTurnover,BAnnualIncome,BDocForBusiness,BIncomeSalesTax,AssetDetails,Immovableproperty,memberToAnyOtherCooperative,"
        strSQL = strSQL & "RepayingCapacityPerMonth,InsuranceDetail,SuppleForRepay,SalaryRemitanceToSahakari,RepaymentModeForNonEarning,OtherSourceOfIncome,ChequeDetails,OtherDetails) values ('" & _strLoanNo & "','" & _strDesignation & "','" & _strOfficeName & "','"
        strSQL = strSQL & _intServiceCompleted & "','" & _intNoofDependant & "','" & _strMobileNo2 & "','" & _intMonthlyExpenses & "','" & _strDirName & "','" & _strNatureOfRealtionShip & "','" & _chrSalaryedPerson & "','" & _strSurParticularsofMonth & "','" & _intSalary & "','" & _intDeamessAllowance & "','"
        strSQL = strSQL & _intHouseRentAllowance & "','" & _intComensatoryAllowance & "','" & _intOtherallowance & "','" & _intTotalAmount & "','" & _intIncomeTax & "','" & _intProvidentFund & "','" & _intInsurancePremium & "','" & _intHBA & "','" & _intOtherDeduction & "','" & _intTotalDeduction & "','"
        strSQL = strSQL & _intNetSalary & "','" & _intfamilyMonthlyExpenses & "','" & _chrBusiness & "','" & _strNatureOfBusiness & "','" & Format(_datYearOfEstablishment, "yyyy-MM-dd") & "','" & _intAnnualTurnOver & "','" & _intAnnualIncome & "','" & _strDocumentsProduced & "','" & _strTaxDetails & "','" & _strAssetDetails & "','"
        strSQL = strSQL & _strImmoveableProperty & "','" & _strOtherMemebrShip & "','" & _intRepaymentCapacity & "','" & _strInsuranceDetail & "','" & _strSupplementDetail & "','" & _strRemittedToSahakari & "','" & _strRepayModeForNonEarning & "','" & _strOtherSourceOfIncome & "','" & _strChequeDetail & "','" & _strOtherDetail & "')"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnDeleteSLDetails(ByVal strLoanNo As String, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "Delete from loanadditionaldetailstbl where LoanNo = '" & strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnUpDateSLDet(ByVal strLoanNo As String) As Boolean

        '  strSQL = "update demandloandettbl set AssetDetails = '" & _strAssetDetails & "',TypeOfRepayment = '" & _StrRepaymentDet & "',PersonalIdentification = '" & _chrPersonalIdentification & "',OfficeName = '" & _strOfficeName & "',Designation = '" & _strDesignation & "',WitnessPerson1 = '" & _strWitnessPerson1 & "',Address1 = '" & _strWitnessAddress1 & "',Installment = '" & _strInstallment & "' where loanno = '" & strLoanNo & "'"

        strSQL = "Update  loanadditionaldetailstbl  set Designation='" & _strDesignation & "',OfficeName='" & _strOfficeName & "',NoOfServiceCompleted='" & _intServiceCompleted & "',NoDependants='" & _intNoofDependant & "',MobileNo2='" & _strMobileNo2 & "',MonthlyExpenses='" & _intMonthlyExpenses & "',DirectorName='" & _strDirName & "',DirRelationship='" & _strNatureOfRealtionShip & "',SalariedPerson='" & _chrSalaryedPerson & "',SuretyParticulars='" & _strSurParticularsofMonth & "',SBasicPay='" & _intSalary & "',"
        strSQL = strSQL & " SDeamessAllowance='" & _intDeamessAllowance & "',SHouseREntAllowance='" & _intHouseRentAllowance & "',SCityComensatoryAllowance='" & _intComensatoryAllowance & "',SotherIncome='" & _intOtherallowance & "',STotalAmount='" & _intTotalAmount & "',SincomeTax='" & _intIncomeTax & "',SProvidentFund='" & _intProvidentFund & "',SInsurancePremium='" & _intInsurancePremium & "',SHBA='" & _intHBA & "',SOtherDeduction='" & _intOtherDeduction & "',STotalDeduction='" & _intTotalDeduction & "',SNetSalary='" & _intNetSalary & "',"
        strSQL = strSQL & "FamilyMonDomesticExpn='" & _intfamilyMonthlyExpenses & "',BusinessPerson='" & _chrBusiness & "',BNatureOfBusiness='" & _strNatureOfBusiness & "',BYearofEstablished='" & Format(_datYearOfEstablishment, "yyyy-MM-dd") & "',BAnnualTurnover='" & _intAnnualTurnOver & "',BAnnualIncome='" & _intAnnualIncome & "',BDocForBusiness='" & _strDocumentsProduced & "',BIncomeSalesTax='" & _strTaxDetails & "',AssetDetails='" & _strAssetDetails & "',Immovableproperty='" & _strImmoveableProperty & " ',memberToAnyOtherCooperative='" & _strOtherMemebrShip & "',"
        strSQL = strSQL & "RepayingCapacityPerMonth='" & _intRepaymentCapacity & "',InsuranceDetail='" & _strInsuranceDetail & "',SuppleForRepay='" & _strSupplementDetail & "',SalaryRemitanceToSahakari='" & _strRemittedToSahakari & "',RepaymentModeForNonEarning='" & _strRepayModeForNonEarning & "',OtherSourceOfIncome='" & _strOtherSourceOfIncome & "',ChequeDetails='" & _strChequeDetail & "',OtherDetails='" & _strOtherDetail & "'where loanno = '" & strLoanNo & "'"


        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetSuretyLoanDet(ByVal strLoanNo As String) As Boolean

        strSQL = "Select * from loanadditionaldetailstbl where loanno = '" & strLoanNo & "'"

        _dtDLDet = fnExecuteQuery(strSQL, 2)

        If _dtDLDet.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

#End Region



    Public Function fnInsertSecurityDetailsInfo(ByVal objTrans As IDbTransaction) As Boolean

        Dim intCount As Integer
        Dim dr As DataRow

        ' If _dtFDDetails.Rows.Count > 0 Then
        For Each dr In _dtFDDetails.Rows
            strSQL = "Insert into securitydetailstbl (LoanNo,DepositType,DepositTypeNo,NameOfDepositor,DepositDate,DepositAmt,MatDate,MatAmt) "
            strSQL = strSQL & " values ('" & dr(0) & "','" & dr(1) & "','" & dr(2) & "','" & dr(3) & "','" & dr(4) & "','" & dr(5) & "','" & dr(6) & "','" & dr(7) & "')"
            fnExecuteNonQuery(strSQL, objTrans)
        Next

        ' End If
        'For Each dr In _dtNSCDetails.Rows
        '    strSQL = "Insert into securitydetailstbl (LoanNo,DepositType,DepositTypeNo,NameOfDepositor,DepositDate,DepositAmt,MatDate,MatAmt) "
        '    strSQL = strSQL & " values ('" & dr(0) & "','" & dr(1) & "','" & dr(2) & "','" & dr(3) & "','" & dr(4) & "','" & dr(5) & "','" & dr(6) & "','" & dr(7) & "')"
        '    fnExecuteNonQuery(strSQL)
        'Next
        Return True

    End Function


    Public Function fnGetFDSecurityDetails(ByVal strLoanNo As String) As Boolean

        strSQL = "select S.* from securitydetailstbl S , loandetailstbl L where S.LoanNo = L.LoanNo and L.LoanNo = '" & strLoanNo & "' and S.DepositType='FD'"

        _dtFDDetails = fnExecuteQuery(strSQL, 2)

        If _dtFDDetails.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetNSCSecurityDetails(ByVal strLoanNo As String) As Boolean

        strSQL = "select S.* from securitydetailstbl S , loandetailstbl L where S.LoanNo = L.LoanNo and L.LoanNo = '" & strLoanNo & "' and S.DepositType='NSC'"

        _dtNSCDetails = fnExecuteQuery(strSQL, 2)

        If _dtNSCDetails.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

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

    Public Function fnDeleteSecuretyDetail(ByVal _strLoanNo As String) As Boolean

        strSQL = "Delete from securitydetailstbl where LoanNo = '" & _strLoanNo & "'"
        Return fnExecuteNonQuery(strSQL)

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

End Class
