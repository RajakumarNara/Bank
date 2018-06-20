
Public Class clsMediumTermLoan
    Inherits clsPerson

#Region "Variables"

    Private _strLoanNo As String
    Private _PersonNo As Long
    Private _strSBNo As String
    Private _strMemberNo As String

    'person Number Comes from clsperson
    Private _datMediumLoanData As Date
    Private _datAccDate As Date
    Private _dblAccBal As Double
    Private _chrAccType As Char

    Private _strRemarks As String
    Private _chrPhotoID As Char
    Private _chrAddrID As Char
    Private _strReciptNo As String

    Private _dtMediumLoan As DataTable
    Private _dtMediumItemDetails As DataTable
    Private _dtMediumLoanDet As DataTable
    Private _dtMediumCust As DataTable

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
    Private _dtMediumOtherLoanDet As DataTable
    Private _dtMediumAssetDet As DataTable

    'Asset Details
    Private _strBankName As String
    Private _dblRemaningAmt As Double
    Private _strMortagageDet As String
    Private _dblSusti As Double
    Private _datsustiDate As Date
    Private _strActionOnBorrower As String

    'OtherLoanDet 
    Private _strAddress As String
    Private _intServae As Integer
    Private _dblTotalArea As Double
    Private _strType As String
    Private _strIfMortagageDetails As String
    Private _strOthers As String
    Private _DtMediumAssetsDet As DataTable
    Private _DtMediumOtherDet As DataTable

    Public _intPanNo As Integer
    Public _intShares As Integer
    Public _dtMLDet As DataTable


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

    Public Property MediumLoanTable() As DataTable
        Get
            Return _dtMediumLoan
        End Get
        Set(ByVal Value As DataTable)
            _dtMediumLoan = Value
        End Set
    End Property

    Public Property MediumExpectedAmount() As Integer
        Get
            Return _intExpectedAmount
        End Get
        Set(ByVal Value As Integer)
            _intExpectedAmount = Value
        End Set
    End Property

    Public Property MediumSanctioned() As Integer
        Get
            Return _intSanctionedAmount
        End Get
        Set(ByVal Value As Integer)
            _intSanctionedAmount = Value
        End Set
    End Property

    Public Property MediumROI() As Double
        Get
            Return _dblROI
        End Get
        Set(ByVal Value As Double)
            _dblROI = Value
        End Set
    End Property

    Public Property MediumDisbAmt() As Integer
        Get
            Return _intDisbAmt
        End Get
        Set(ByVal Value As Integer)
            _intDisbAmt = Value
        End Set
    End Property

    Public Property MediumInstallments() As String
        Get
            Return _strInstallment
        End Get
        Set(ByVal Value As String)
            _strInstallment = Value
        End Set
    End Property

    Public Property MediumModeOfPayment() As String
        Get
            Return _strModeOfPayment
        End Get
        Set(ByVal Value As String)
            _strModeOfPayment = Value
        End Set
    End Property

    Public Property MediumReason() As String
        Get
            Return _strReason
        End Get
        Set(ByVal Value As String)
            _strReason = Value
        End Set
    End Property

    Public Property MediumWitnessPerson1() As String
        Get
            Return _strWitnessPerson1
        End Get
        Set(ByVal Value As String)
            _strWitnessPerson1 = Value
        End Set
    End Property

    Public Property MediumWitnessPerson2() As String
        Get
            Return _strWitnessPerson2
        End Get
        Set(ByVal Value As String)
            _strWitnessPerson2 = Value
        End Set
    End Property

    Public Property MediumWitnessPersonAddress1() As String
        Get
            Return _strWitnessAddress1
        End Get
        Set(ByVal Value As String)
            _strWitnessAddress1 = Value
        End Set
    End Property

    Public Property MediumWitnessPersonAddress2() As String
        Get
            Return _strWitnessAddress2
        End Get
        Set(ByVal Value As String)
            _strWitnessAddress2 = Value
        End Set
    End Property

    Public Property MediumLoanDate() As Date
        Get
            Return _datMediumLoanData
        End Get
        Set(ByVal Value As Date)
            _datMediumLoanData = Value
        End Set
    End Property


    Public Property MediumLoanDueDate() As Date
        Get
            Return _datDueDate
        End Get
        Set(ByVal Value As Date)
            _datDueDate = Value
        End Set
    End Property

    Public Property MediumLoanInstPrinciple() As Integer
        Get
            Return _intInstPrinciple
        End Get
        Set(ByVal Value As Integer)
            _intInstPrinciple = Value
        End Set
    End Property

    Public Property MediumLoanAmtBalance() As Integer
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

    Public Property MediumLoanLastPaidDate() As Date
        Get
            Return _datLastPaid
        End Get
        Set(ByVal Value As Date)
            _datLastPaid = Value
        End Set
    End Property

    Public Property MediumLoanDettable() As DataTable
        Get
            Return _dtMediumLoanDet
        End Get
        Set(ByVal Value As DataTable)
            _dtMediumLoanDet = Value
        End Set
    End Property

    Public Property MediumLoanCusttable() As DataTable
        Get
            Return _dtMediumCust
        End Get
        Set(ByVal Value As DataTable)
            _dtMediumCust = Value
        End Set
    End Property

    Public Property MediumBankName() As String
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

    Public Property Susti() As Double
        Get
            Return _dblSusti
        End Get
        Set(ByVal Value As Double)
            _dblSusti = Value
        End Set
    End Property

    Public Property SustiDate() As Date
        Get
            Return _datsustiDate
        End Get
        Set(ByVal Value As Date)
            _datsustiDate = Value
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

    Public Property MediumOtherLoanDet() As DataTable
        Get
            Return _dtMediumOtherLoanDet
        End Get
        Set(ByVal Value As DataTable)
            _dtMediumOtherLoanDet = Value
        End Set
    End Property

    Public Property MediumAssetDet() As DataTable
        Get
            Return _dtMediumAssetDet
        End Get
        Set(ByVal Value As DataTable)
            _dtMediumAssetDet = Value
        End Set
    End Property

    Public Property MediumLoanAssetsTable() As DataTable
        Get
            Return _DtMediumAssetsDet
        End Get
        Set(ByVal Value As DataTable)
            _DtMediumAssetsDet = Value
        End Set
    End Property

    Public Property MediumLoanOtherTable() As DataTable
        Get
            Return _DtMediumOtherDet
        End Get
        Set(ByVal Value As DataTable)
            _DtMediumOtherDet = Value
        End Set
    End Property

    Public Property PanNo() As Integer
        Get
            Return _intPanNo
        End Get
        Set(ByVal Value As Integer)
            _intPanNo = Value
        End Set
    End Property

    Public Property Shares() As Integer
        Get
            Return _intShares
        End Get
        Set(ByVal Value As Integer)
            _intShares = Value
        End Set
    End Property

    Public Property MLDetTable() As DataTable
        Get
            Return _dtMLDet
        End Get
        Set(ByVal Value As DataTable)
            _dtMLDet = Value
        End Set
    End Property



#End Region

#Region "Function"

    Public Function fnAddMLAccount(ByVal objTrans As IDbTransaction) As Boolean

        If fnCheckPerson() Then
            If fnUpdatePerson() Then
                If fnInsertMLAccount() Then
                    If fnInsertMLDetails() Then
                        If fnInsertMLAssetDet() Then
                            Return fnInsertMediumLoanDet()
                        End If
                    End If
                End If
            End If
        Else
            If fnAddPerson() Then
                If fnInsertMLAccount() Then
                    If fnInsertMLDetails() Then
                        If fnInsertMLAssetDet() Then
                            If fnInsertMediumLoanDet() Then
                                Return True
                            Else
                                fnDeletePerson(objTrans)
                                fnDeleteLoanDet(LoanNo)
                                fnDeleteMediumLoanDet(LoanNo)
                                fnDeleteMediumAssetDetails(LoanNo)
                                fnDeleteMediumOtherDetails(LoanNo)
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Function

    Public Function fnInsertMLAccount() As Boolean

        strSQL = "insert into loanDetailstbl(LoanNo,PersonNo,MemberNo,SBNo,ExpAmount,SancAmount,DisbAmount,ApplDate,SancDate,DueDate,ROI,NOI,InstPrinciple,RepayMode,Purpose,Type,Balance,LastPaidDate,Remarks,Status,ReceiptNo)"
        strSQL = strSQL & " values('" & _strLoanNo & "','" & PersonNo & "','" & _strMemberNo & "','" & _strSBNo & "','" & _intExpectedAmount & "','" & _intSanctionedAmount & "','" & _intDisbAmt & "','" & Format(_datMediumLoanData, "yyyy-MM-dd") & "','" & Format(_datMediumLoanData, "yyyy-MM-dd") & "','" & Format(_datDueDate, "yyyy-MM-dd") & "','" & _dblROI & "','" & _intNOI & "','"
        strSQL = strSQL & _intInstPrinciple & "','" & _strModeOfPayment & "','" & _strReason & "','" & _strInstallment & "','" & _intBalance & "','" & Format(_datLastPaid, "yyyy-MM-dd") & "','" & _strRemarks & "','" & _strStatus & "','" & _strReciptNo & "')"

        Return fnExecuteNonQuery(strSQL)

    End Function



    Public Function fnChekMLAccount(ByVal strLoanNo As String) As Boolean

        strSQL = "select * from loanDetailstbl where loanNo = '" & strLoanNo & "'"

        _dtMediumLoan = fnExecuteQuery(strSQL, 2)

        If _dtMediumLoan.Rows.Count > 0 Then

            Return True
        Else
            Return False

        End If
    End Function

    Public Function fnInsertMLDetails() As Boolean

        Dim dr As DataRow

        For Each dr In _dtMediumOtherLoanDet.Rows

            strSQL = "insert into mediumotherloandettbl values('" & dr(0) & "','" & dr(1) & "','" & dr(2) & "','" & dr(3) & "','" & dr(4) & "','" & dr(5) & "','" & dr(6) & "')"

            fnExecuteNonQuery(strSQL)

        Next

        Return True

    End Function

    Public Function fnInsertMLAssetDet() As Boolean

        Dim drAsset As DataRow
        For Each drAsset In _dtMediumAssetDet.Rows

            strSQL = "insert into mediumloanassetdettbl(LoanNo,Address,ServaeNo,TotalArea,Type,Details,Others) values('" & drAsset(0) & "','" & drAsset(1) & "','" & drAsset(2) & "','" & drAsset(3) & "','" & drAsset(4) & "','" & drAsset(5) & "','" & drAsset(6) & "')"

            fnExecuteNonQuery(strSQL)

        Next

        Return True

    End Function

    Public Function fnDeleteLoanDet(ByVal strLoanNo As String) As Boolean

        strSQL = "delete from loandetailstbl where loanno = '" & strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnDeleteMediumOtherDetails(ByVal strLoanNo As String) As Boolean

        Dim dr As DataRow

        For Each dr In _dtMediumOtherLoanDet.Rows

            strSQL = "delete from mediumotherloandettbl where loanNo = '" & strLoanNo & "'"

            fnExecuteNonQuery(strSQL)

        Next
        Return True

    End Function

    Public Function fnDeleteMediumAssetDetails(ByVal strLoanNo As String) As Boolean

        Dim drAsset As DataRow

        For Each drAsset In _dtMediumAssetDet.Rows

            strSQL = "delete from mediumloanassetdettbl where loanNo = '" & strLoanNo & "'"

            fnExecuteNonQuery(strSQL)
        Next

        Return True

    End Function

    Public Function fnDeleteMediumLoanDet(ByVal strLoanNo As String) As Boolean

        strSQL = "Delete from MediumLoanDettbl where loanNo = '" & strLoanNo & "'"

        fnExecuteNonQuery(strSQL)

    End Function


    Public Function fnUpdateLoanDetails(ByVal strLoanNo As String) As Boolean

        strSQL = "UPDATE loandetailsTbl SET memberNo = '" & _strMemberNo & "',personNo = '" & PersonNo & "', sbno = '" & _strSBNo & "', expAmount='" & _intExpectedAmount & "', sancamount='" & _intSanctionedAmount & "',ApplDate = '" & Format(_datMediumLoanData, "yyyy-MM-dd") & "',DueDate = '" & Format(_datDueDate, "yyyy-MM-dd") & "', RepayMode  ='" & _strModeOfPayment & "', ROI='" & _dblROI & "', NOI = '" & _intNOI & "',InstPrinciple = '" & _intInstPrinciple & "',Purpose ='" & _strReason & "', Type = '" & _strInstallment & "',Remarks = '" & _strRemarks & "'   WHERE  LoanNo='" & strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetLoanDetails(ByVal strLoanNo As String) As Boolean

        strSQL = "SELECT P.*, v.* FROM Loandetailstbl v, PersonTbl P WHERE P.PersonNo=v.PersonNo  and v.LoanNo='" & strLoanNo & "' "

        _dtMediumLoanDet = fnExecuteQuery(strSQL, 2)

        If _dtMediumLoanDet.Rows.Count > 0 Then
            Return True

        Else
            Return False
        End If

    End Function

    Public Function fnGetMediumLoanCust() As Boolean

        strSQL = "select P.*, S.* FROM loandetailstbl S, PersonTbl P WHERE P.PersonNo=S.PersonNo and loanNo like 'ML%'"

        _dtMediumCust = fnExecuteQuery(strSQL, 2)

        If _dtMediumCust.Rows.Count > 0 Then

            Return True
        Else
            Return False

        End If

    End Function

    Public Function fnGetMediumLoanOthertDet(ByVal strLoanNo As String) As Boolean

        strSQL = "select b.* from mediumotherloandettbl b where b.loanno = '" & strLoanNo & "'"

        _DtMediumOtherDet = fnExecuteQuery(strSQL, 2)

        If _DtMediumOtherDet.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetMediumLoanAssetDetails(ByVal strLoanNo As String) As Boolean

        strSQL = "Select a.* from mediumloanassetdettbl a where a.loanno = '" & strLoanNo & "'"

        _DtMediumOtherDet = fnExecuteQuery(strSQL, 2)

        If _DtMediumOtherDet.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnInsertMediumLoanDet() As Boolean

        strSQL = "insert into MediumLoanDettbl (LoanNo,PanNo,Shares,WitnessPerson1,Address1,WitnessPerson2,Address2,Installment)"
        strSQL = strSQL & " values ('" & _strLoanNo & "','" & _intPanNo & "','" & _intShares & "','" & _strWitnessPerson1 & "','" & _strWitnessAddress1 & "','" & _strWitnessPerson2 & "','" & _strWitnessAddress2 & "','" & _strInstallment & "')"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetMediumLoanDet(ByVal strLoanNo As String) As Boolean

        strSQL = "Select * from MediumLoanDettbl where loanNo = '" & strLoanNo & "'"

        _dtMLDet = fnExecuteQuery(strSQL, 2)

        If _dtMLDet.Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function fnUpdateMediumLoanDet(ByVal strLoanNo As String) As Boolean

        strSQL = "Update mediumloandettbl set PanNo = '" & _intPanNo & "',Shares = '" & _intShares & "',"
        strSQL = strSQL & " WitnessPerson1 ='" & _strWitnessPerson1 & "',WitnessPerson2 = '" & _strWitnessPerson2 & "',"
        strSQL = strSQL & " Address1 = '" & _strWitnessAddress1 & "',address2 = '" & _strWitnessAddress2 & "' where loanno = '" & strLoanNo & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

#End Region

End Class
