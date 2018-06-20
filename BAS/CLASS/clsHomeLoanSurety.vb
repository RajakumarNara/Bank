
Public Class clsHomeLoanSurety

#Region "Variables"
    Private _lngNo As Long
    Private _StrLoanNo As String
    Private _StrSBNo As String
    Private _strName As String
    Private _strCustomerNo As String
    Private _strFatherName As String
    Private _datDOB As Date
    Private _intAge As Integer
    Private _chrAgeStatus As Char
    Private _chrGender As Char
    Private _strPermAddress As String
    Private _strPhoneNo As String
    Private _strOfficeAddress As String
    Private _chrSalariedPerson As Char
    Private _chrBusinessPerson As Char
    Private _intSSalary As Integer
    Private _intSRent As Integer
    Private _intSOtherIncome As Integer
    Private _intSTotalIncome As Integer
    Private _intSExpenses As Integer
    Private _intSTotalSavings As Integer
    Private _bytPhoto As Byte()
    Private _bytSign As Byte()
    Private _chrType As Char


    Private _intBSalary As Integer
    Private _intBRent As Integer
    Private _intBOtherIncome As Integer
    Private _intBTotalIncome As Integer
    Private _intBExpenses As Integer
    Private _intBTotalSavings As Integer

    Private _StrIncomeTaxDet As String
    Private _StrSalariedPersonDet As String
    Private _StrBusinessPersonDet As String
    Private _strRelationship As String
    Private _strImmovablePropertyDet As String
    Private _StrifBankRespDet As String
    Private _StrifOrgResp As String
    Private _StrifPersonResp As String
    Private _strTotal As String
    Private _strbankName As String
    Private _StrLoanType As String
    Private _intLoanAmount As Integer
    Private _StrOthers As String
    Private _intNoOfService As Integer
    Private _StrDeclaration As String

    Private _dtCheckSurety As DataTable
    Private _dtSBdetailsTable As DataTable

#End Region

#Region "Properties"

    Public Property No() As Long
        Get
            Return _lngNo
        End Get
        Set(ByVal Value As Long)
            _lngNo = Value
        End Set
    End Property

    Public Property LoanNo() As String
        Get
            Return _StrLoanNo
        End Get
        Set(ByVal Value As String)
            _StrLoanNo = Value
        End Set
    End Property
    Public Property SBNo() As String
        Get
            Return _StrSBNo
        End Get
        Set(ByVal Value As String)
            _StrSBNo = Value
        End Set
    End Property
    Public Property CustomerNo() As String
        Get
            Return _strCustomerNo
        End Get
        Set(ByVal Value As String)
            _strCustomerNo = Value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return _strName
        End Get
        Set(ByVal Value As String)
            _strName = Value
        End Set
    End Property

    Public Property FatherName() As String
        Get
            Return _strFatherName
        End Get
        Set(ByVal Value As String)
            _strFatherName = Value
        End Set
    End Property

    Public Property PermAddress() As String
        Get
            Return _strPermAddress
        End Get
        Set(ByVal Value As String)
            _strPermAddress = Value
        End Set
    End Property
    Public Property PhoneNo() As String
        Get
            Return _strPhoneNo
        End Get
        Set(ByVal Value As String)
            _strPhoneNo = Value
        End Set
    End Property

    Public Property Declaration() As String
        Get
            Return _StrDeclaration
        End Get
        Set(ByVal Value As String)
            _StrDeclaration = Value
        End Set
    End Property

    Public Property DOB() As Date
        Get
            Return _datDOB
        End Get
        Set(ByVal Value As Date)
            _datDOB = Value
        End Set
    End Property

    Public Property Age() As Integer
        Get
            Return _intAge
        End Get
        Set(ByVal Value As Integer)
            _intAge = Value
        End Set
    End Property

    Public Property AgeStatus() As Char
        Get
            Return _chrAgeStatus
        End Get
        Set(ByVal Value As Char)
            _chrAgeStatus = Value
        End Set
    End Property

    Public Property Type() As Char
        Get
            Return _chrType
        End Get
        Set(ByVal Value As Char)
            _chrType = Value
        End Set
    End Property

    Public Property Gender() As Char
        Get
            Return _chrGender
        End Get
        Set(ByVal Value As Char)
            _chrGender = Value
        End Set
    End Property

    Public Property OfficeAddress() As String
        Get
            Return _strOfficeAddress
        End Get
        Set(ByVal Value As String)
            _strOfficeAddress = Value
        End Set
    End Property
    Public Property Photo() As Byte()
        Get
            Return _bytPhoto
        End Get
        Set(ByVal Value As Byte())
            _bytPhoto = Value
        End Set
    End Property

    Public Property Sign() As Byte()
        Get
            Return _bytSign
        End Get
        Set(ByVal Value As Byte())
            _bytSign = Value
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
    Public Property SExpenses() As Integer
        Get
            Return _intSExpenses
        End Get
        Set(ByVal Value As Integer)
            _intSExpenses = Value
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
    Public Property BExpenses() As Integer
        Get
            Return _intBExpenses
        End Get
        Set(ByVal Value As Integer)
            _intBExpenses = Value
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
    Public Property IncomeTaxDet() As String
        Get
            Return _StrIncomeTaxDet
        End Get
        Set(ByVal Value As String)
            _StrIncomeTaxDet = Value
        End Set
    End Property

    Public Property SalariedPersonDet() As String
        Get
            Return _StrSalariedPersonDet
        End Get
        Set(ByVal Value As String)
            _StrSalariedPersonDet = Value
        End Set
    End Property

    Public Property BusinessPersonDet() As String
        Get
            Return _StrBusinessPersonDet
        End Get
        Set(ByVal Value As String)
            _StrBusinessPersonDet = Value
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

    Public Property Relationship() As String
        Get
            Return _strRelationship
        End Get
        Set(ByVal Value As String)
            _strRelationship = Value
        End Set
    End Property

    Public Property immovablePeropertyDet() As String
        Get
            Return _strImmovablePropertyDet
        End Get
        Set(ByVal Value As String)
            _strImmovablePropertyDet = Value
        End Set
    End Property

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

    Public Property TotalResp() As String
        Get
            Return _strTotal
        End Get
        Set(ByVal Value As String)
            _strTotal = Value
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

    Public Property OtherParticulars() As String
        Get
            Return _StrOthers
        End Get
        Set(ByVal Value As String)
            _StrOthers = Value
        End Set
    End Property

    Public Property CheckSuretytable() As DataTable
        Get
            Return _dtCheckSurety
        End Get
        Set(ByVal Value As DataTable)
            _dtCheckSurety = Value
        End Set
    End Property


#End Region

#Region "Functions"

    Public Function fnInsertSuretyDet(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "insert into loansuretydettbl(No,LoanNo,Name,CustomerNo,FatherName,Age,DOB,Gender,Address,PhoneNo,OfficeAddress,Type,SalariedPerson,BusinessPerson,NoOfService,BusinessPersonDet,SSalary,SRent,SOtherIncome,STotalIncome,SExpenses,STotalSavings,"
        strSQL = strSQL & "BSalary,BRent,BOtherIncome,BTotalIncome,BExpenses,BTotalSaving,Relation,IncomeTaxDetails,ImmovableProperty,AnyBankResp,OrgResp,PersonResp,Total,BankName,LoanType,Amount,OtherParticulars,Declaration,SBAccountNo) values ('" & _lngNo & "','" & _StrLoanNo & "','" & _strName & "','" & _strCustomerNo & "','" & _strFatherName & "','" & _intAge & "',"
        strSQL = strSQL & "'" & Format(_datDOB, "yyyy-MM-dd") & "','" & _chrGender & "','" & _strPermAddress & "','" & _strPhoneNo & "','" & _StrSalariedPersonDet & "','" & _chrType & "','" & _chrSalariedPerson & "','" & _chrBusinessPerson & "','" & _intNoOfService & "','" & _StrBusinessPersonDet & "',"
        strSQL = strSQL & "'" & _intSSalary & "','" & _intSRent & "','" & _intSOtherIncome & "','" & _intSTotalIncome & "','" & _intSExpenses & "','" & _intSTotalSavings & "','" & _intBSalary & "','" & _intBRent & "','" & _intBOtherIncome & "','" & _intBTotalIncome & "','" & _intBExpenses & "','" & _intBTotalSavings & "',"
        strSQL = strSQL & "'" & _strRelationship & "','" & _StrIncomeTaxDet & "','" & _strImmovablePropertyDet & "','" & _StrifBankRespDet & "','" & _StrifOrgResp & "','" & _StrifPersonResp & "','" & _strTotal & "','" & _strbankName & "','" & _StrLoanType & "','" & _intLoanAmount & "','" & _StrOthers & "','" & _StrDeclaration & "','" & _StrSBNo & "')"

        If fnExecuteNonQuery(strSQL, objTrans) Then
            Return fnUpdateImages()
        Else
            Return False
        End If
    End Function

    Public Function fnGetSurety(ByVal strLoanNo As String, ByVal ChrType As String) As Boolean
        strSQL = "Select * from loansuretydettbl where loanNo = '" & strLoanNo & "' and Type='" & ChrType & "'"
        _dtCheckSurety = fnExecuteQuery(strSQL, 2)
        If _dtCheckSurety.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnCheckData(ByVal strLoanNo As String, ByVal lngNo As Long) As Boolean
        strSQL = "Select * from loansuretydettbl where loanNo = '" & _StrLoanNo & "' and No='" & _lngNo & "' and Type='" & _chrType & "'"
        _dtCheckSurety = fnExecuteQuery(strSQL, 2)
        If _dtCheckSurety.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function fnUpdateSuretyDet(ByVal strLoanNo As String, ByVal lngNo As Long, ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "update loansuretydettbl set Name = '" & _strName & "',CustomerNo='" & _strCustomerNo & "',FatherName = '" & _strFatherName & "',Age = '" & _intAge & "',DOB = '" & Format(_datDOB, "yyyy-MM-dd") & "',"
        strSQL = strSQL & "Gender = '" & _chrGender & "',Address = '" & _strPermAddress & "',PhoneNo='" & _strPhoneNo & "',OfficeAddress = '" & _StrSalariedPersonDet & "',SalariedPerson = '" & _chrSalariedPerson & "', "
        strSQL = strSQL & "BusinessPerson = '" & _chrBusinessPerson & "',NoOfService ='" & _intNoOfService & "',BusinessPersonDet = '" & _StrBusinessPersonDet & "',"
        strSQL = strSQL & "SSalary = '" & _intSSalary & "',SRent = '" & _intSRent & "',SOtherIncome = '" & _intSOtherIncome & "',STotalIncome = '" & _intSTotalIncome & "',SExpenses='" & _intSExpenses & "',"
        strSQL = strSQL & "STotalSavings = '" & _intSTotalSavings & "',BSalary = '" & _intBSalary & "',BRent = '" & _intBRent & "',BOtherIncome = '" & _intBOtherIncome & "',BTotalIncome = '" & _intBTotalIncome & "',BExpenses='" & _intBExpenses & "',BTotalSaving = '" & _intBTotalSavings & "',"
        strSQL = strSQL & "Relation = '" & _strRelationship & "',IncomeTaxDetails='" & _StrIncomeTaxDet & "',ImmovableProperty = '" & _strImmovablePropertyDet & "',AnyBankResp ='" & _StrifBankRespDet & "',OrgResp ='" & _StrifOrgResp & "',PersonResp = '" & _StrifPersonResp & "',Total ='" & _strTotal & "',BankName = '" & _strbankName & "',"
        strSQL = strSQL & "LoanType = '" & _StrLoanType & "',Amount ='" & _intLoanAmount & "',OtherParticulars = '" & _StrOthers & "',Declaration = '" & _StrDeclaration & "',SBAccountNo='" & _StrSBNo & "' where LoanNo = '" & _StrLoanNo & "' and No='" & _lngNo & "'and Type='" & _chrType & "'"
        If fnExecuteNonQuery(strSQL, objTrans) Then
            Return fnUpdateImages()
        Else
            Return False
        End If
    End Function


    Public Function fnUpdateImages() As Boolean

        Dim objConn As New Odbc.OdbcConnection(strODBCConnectionString)
        Dim objCmd As New Odbc.OdbcCommand(strSQL, objConn)

        Try
            objConn.Open()
            If Not _bytPhoto Is Nothing Then
                strSQL = "UPDATE loansuretydettbl SET Photo=? WHERE No='" & _lngNo & "' and loanno='" & _StrLoanNo & "'  and Type='" & _chrType & "'"
                objCmd.CommandText = strSQL
                objCmd.Parameters.Add("@Photo", Odbc.OdbcType.Binary).Value = _bytPhoto
                objCmd.ExecuteNonQuery()
            End If

            If Not _bytSign Is Nothing Then
                strSQL = "UPDATE loansuretydettbl SET Signature=? WHERE No='" & _lngNo & "' and loanno='" & _StrLoanNo & "' and Type='" & _chrType & "'"
                objCmd.CommandText = strSQL
                objCmd.Parameters.Add("@Signnature", Odbc.OdbcType.Binary).Value = _bytSign
                objCmd.ExecuteNonQuery()
            End If

            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function




    Public Function fnGetNewSuretyNo(ByVal strAccountNo As String, ByVal ChrType As Char) As Long

        Dim objDT As New DataTable

        strSQL = "SELECT MAX(No) FROM loansuretydettbl WHERE LoanNo='" & strAccountNo & "'and Type='" & ChrType & "'"

        objDT = fnExecuteQuery(strSQL, 2)

        If objDT.Rows.Count > 0 And IsDBNull(objDT.Rows(0).Item(0)) Then
            Return 1
        Else
            Return objDT.Rows(0).Item(0) + 1
        End If

    End Function

    Public Function fnDeleteNominee(ByVal strAccountNo As String, ByVal lngNo As Long, ByVal chrType As Char) As Boolean

        strSQL = "DELETE  FROM loansuretydettbl WHERE LoanNo='" & strAccountNo & "' and No='" & lngNo & "' and Type='" & chrType & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function
    Public Function fnGetNewSBNo() As String

        strSQL = "SELECT max(GoldLoanNo) as MaxNo FROM goldloandetailstbl "

        _dtSBdetailsTable = fnExecuteQuery(strSQL, 2)

        If IsDBNull(_dtSBdetailsTable.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return _dtSBdetailsTable.Rows(0).Item("MaxNo")
        End If

    End Function


#End Region

End Class
