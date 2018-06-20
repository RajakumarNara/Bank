Public Class clsPerson


#Region "Variables"

    Private _lngPersonNo As Long
    Private _strName As String
    Private _strCustomerID As String
    Private _strFatherName As String
    Private _datDOB As Date
    Private _intAge As Integer
    Private _chrAgeStatus As Char
    Private _chrGender As Char
    Private _strPermAddress As String
    Private _intPermVillageCode As Integer
    Private _strPresAddress As String
    Private _intPresVillageCode As Integer
    Private _strPhoneNo As String
    Private _strMobileNo As String
    Private _intReligionCode As Integer
    Private _intCasteCode As Integer
    Private _intOccupationCode As Integer
    Private _strEducation As String
    Private _strOfficeAddress As String
    Private _strOfficeNo As String
    Private _charCustomerStatus As Char
    Private _bytPhoto As String
    Private _bytSign As String
    Private _strReturn As String
    Private _datCreationDate As Date
    Private _dtPersonsTable As DataTable
    Dim _dtCheckCustomer As New DataTable
    Private _strEmailId As String
    Private _strPANNo As String
#End Region

#Region "Properties"
    Public Property PANNo() As String
        Get
            Return _strPANNo
        End Get
        Set(ByVal Value As String)
            _strPANNo = Value
        End Set
    End Property

    Public Property EmailId() As String
        Get
            Return _strEmailId
        End Get
        Set(ByVal Value As String)
            _strEmailId = Value
        End Set
    End Property

    Public Property PersonNo() As Long
        Get
            Return _lngPersonNo
        End Get
        Set(ByVal Value As Long)
            _lngPersonNo = Value
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

    Public Property CustomerID() As String
        Get
            Return _strCustomerID
        End Get
        Set(ByVal Value As String)
            _strCustomerID = Value
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

    Public Property PermVillageCode() As Integer
        Get
            Return _intPermVillageCode
        End Get
        Set(ByVal Value As Integer)
            _intPermVillageCode = Value
        End Set
    End Property

    Public Property PresAddress() As String
        Get
            Return _strPresAddress
        End Get
        Set(ByVal Value As String)
            _strPresAddress = Value
        End Set
    End Property

    Public Property PresVillageCode() As Integer
        Get
            Return _intPresVillageCode
        End Get
        Set(ByVal Value As Integer)
            _intPresVillageCode = Value
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

    Public Property MobileNo() As String
        Get
            Return _strMobileNo
        End Get
        Set(ByVal Value As String)
            _strMobileNo = Value
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

    Public Property CreationDate() As Date
        Get
            Return _datCreationDate
        End Get
        Set(ByVal Value As Date)
            _datCreationDate = Value
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

    Public Property Gender() As Char
        Get
            Return _chrGender
        End Get
        Set(ByVal Value As Char)
            _chrGender = Value
        End Set
    End Property

    Public Property ReligionCode() As Integer
        Get
            Return _intReligionCode
        End Get
        Set(ByVal Value As Integer)
            _intReligionCode = Value
        End Set
    End Property

    Public Property CasteCode() As Integer
        Get
            Return _intCasteCode
        End Get
        Set(ByVal Value As Integer)
            _intCasteCode = Value
        End Set
    End Property

    Public Property OccupationCode() As Integer
        Get
            Return _intOccupationCode
        End Get
        Set(ByVal Value As Integer)
            _intOccupationCode = Value
        End Set
    End Property

    Public Property Education() As String
        Get
            Return _strEducation
        End Get
        Set(ByVal Value As String)
            _strEducation = Value
        End Set
    End Property
    Public Property OffAddress() As String
        Get
            Return _strOfficeAddress
        End Get
        Set(ByVal Value As String)
            _strOfficeAddress = Value
        End Set
    End Property

    Public Property OfficeNo() As String
        Get
            Return _strOfficeNo
        End Get
        Set(ByVal Value As String)
            _strOfficeNo = Value
        End Set
    End Property

    Public Property CustomerStatus() As Char
        Get
            Return _charCustomerStatus
        End Get
        Set(ByVal Value As Char)
            _charCustomerStatus = Value
        End Set
    End Property

    Public Property Photo As String
        Get
            Return _bytPhoto
        End Get
        Set(ByVal Value As String)
            _bytPhoto = Value
        End Set
    End Property

    Public Property Sign As String
        Get
            Return _bytSign
        End Get
        Set(ByVal Value As String)
            _bytSign = Value
        End Set
    End Property

    Public Property Remarks() As String
        Get
            Return _strReturn
        End Get
        Set(ByVal Value As String)
            _strReturn = Value
        End Set
    End Property

    Public Property PersonTable() As DataTable
        Get
            Return _dtPersonsTable
        End Get
        Set(ByVal Value As DataTable)
            _dtPersonsTable = Value
        End Set
    End Property
    Public Property CheckCustomer() As DataTable
        Get
            Return _dtCheckCustomer
        End Get
        Set(ByVal value As DataTable)
            _dtCheckCustomer = value
        End Set
    End Property
#End Region

#Region "Functions"

#Region "Without Transaction"

    Public Overloads Function fnAddPerson() As Boolean

        strSQL = "INSERT INTO PersonTbl VALUES(" & _lngPersonNo & ",'" & _strCustomerID & "','" & _strName & "','" & _strFatherName & "','"
        strSQL = strSQL & Format(_datDOB, "yyyy-MM-dd") & "'," & _intAge & ",'" & _chrAgeStatus & "','" & _chrGender & "','" & _strPresAddress & "','"
        strSQL = strSQL & _strPermAddress & "','" & _strPhoneNo & "','" & _strMobileNo & "',"
        strSQL = strSQL & _intOccupationCode & "," & _intReligionCode & "," & _intCasteCode & ",'" & _strEducation & "','" & _strOfficeAddress & "','" & _strOfficeNo & "','" & _charCustomerStatus & "','" & _strReturn & "','','','" & Format(_datCreationDate, "yyyy-MM-dd") & "' ,'" & _strEmailId & "','" & _strPANNo & "')"

        If fnExecuteNonQuery(strSQL) Then
            fnUpdateImages()
            Return fnUpdateSignatureImages()
        Else
            Return False
        End If

    End Function

    Public Overloads Function fnUpdatePerson() As Boolean

        strSQL = "UPDATE PersonTbl SET Name='" & _strName & "', FatherName='" & _strFatherName & "', DOB='" & Format(_datDOB, "yyyy-MM-dd") & "', "
        strSQL = strSQL & "Age='" & _intAge & "', AgeStatus='" & _chrAgeStatus & "', Gender='" & _chrGender & "', "
        strSQL = strSQL & "PresAddress='" & _strPresAddress & "',PermAddress='" & _strPermAddress & "',"
        strSQL = strSQL & "PhoneNo='" & _strPhoneNo & "', MobileNo='" & _strMobileNo & "', OccupationCode='" & _intOccupationCode & "',"
        strSQL = strSQL & "ReligionCode='" & _intReligionCode & "', CasteCode='" & _intCasteCode & "',"
        strSQL = strSQL & "Education='" & _strEducation & "',OfficeAddress ='" & _strOfficeAddress & "',OfficeNo='" & _strOfficeNo & "' WHERE CustomerID='" & _strCustomerID & "'"
        If fnExecuteNonQuery(strSQL) Then
            fnUpdateImages()
            Return fnUpdateSignatureImages()
        Else
            Return False
        End If
    End Function
    Public Overloads Function fnUpdateImages() As Boolean

        Dim objConn As New Odbc.OdbcConnection(strODBCConnectionString)
        Dim objCmd As New Odbc.OdbcCommand(strSQL, objConn)

        Try
            objConn.Open()

            If Not _bytPhoto Is Nothing Then
                strSQL = "UPDATE PersonTbl SET Photo=? WHERE PersonNo=" & _lngPersonNo
                objCmd.CommandText = strSQL
                objCmd.Parameters.Add("@Photo", Odbc.OdbcType.VarChar).Value = _bytPhoto 'save only image location
                objCmd.ExecuteNonQuery()
            End If

            ''If Not _bytSign Is Nothing Then
            ''    strSQL = "UPDATE PersonTbl SET  Signature=? WHERE PersonNo=" & _lngPersonNo
            ''    objCmd.CommandText = strSQL
            ''    objCmd.Parameters.Add("@Signature", Odbc.OdbcType.Binary).Value = _bytSign
            ''    objCmd.ExecuteNonQuery()
            ''End If
            ''Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Overloads Function fnUpdateSignatureImages() As Boolean

        Dim objConn As New Odbc.OdbcConnection(strODBCConnectionString)
        Dim objCmd As New Odbc.OdbcCommand(strSQL, objConn)

        Try
            objConn.Open()

            ''If Not _bytPhoto Is Nothing Then
            ''    strSQL = "UPDATE PersonTbl SET Photo=? WHERE PersonNo=" & _lngPersonNo
            ''    objCmd.CommandText = strSQL
            ''    objCmd.Parameters.Add("@Photo", Odbc.OdbcType.Binary).Value = _bytPhoto
            ''    objCmd.ExecuteNonQuery()
            ''End If

            If Not _bytSign Is Nothing Then
                strSQL = "UPDATE PersonTbl SET  Signature=? WHERE PersonNo=" & _lngPersonNo
                objCmd.CommandText = strSQL
                objCmd.Parameters.Add("@Signature", Odbc.OdbcType.VarChar).Value = _bytSign
                objCmd.ExecuteNonQuery()
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


#End Region


    Public Overloads Function fnAddPerson(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "INSERT INTO PersonTbl VALUES(" & _lngPersonNo & ",'" & _strCustomerID & "','" & _strName & "','" & _strFatherName & "','"
        strSQL = strSQL & Format(_datDOB, "yyyy-MM-dd") & "'," & _intAge & ",'" & _chrAgeStatus & "','" & _chrGender & "','" & _strPresAddress & "','"
        strSQL = strSQL & _strPermAddress & "','" & _strPhoneNo & "','" & _strMobileNo & "',"
        strSQL = strSQL & _intOccupationCode & "," & _intReligionCode & "," & _intCasteCode & ",'" & _strEducation & "','" & _strOfficeAddress & "','" & _strOfficeNo & "','" & _charCustomerStatus & "','" & _strReturn & "','','')"

        If fnExecuteNonQuery(strSQL, objTrans) Then
            fnUpdateImages(objTrans)
            Return fnUpdateSignatureImages(objTrans)
        Else
            Return False
        End If

    End Function


    Public Function fnUpdatePersonWRTCustomer() As Boolean

        strSQL = "UPDATE PersonTbl SET Name='" & _strName & "', FatherName='" & _strFatherName & "', DOB='" & Format(_datDOB, "yyyy-MM-dd") & "', "
        strSQL = strSQL & "Age='" & _intAge & "', AgeStatus='" & _chrAgeStatus & "', Gender='" & _chrGender & "', "
        strSQL = strSQL & "PresAddress='" & _strPresAddress & "',PermAddress='" & _strPermAddress & "',"
        strSQL = strSQL & "PhoneNo='" & _strPhoneNo & "', MobileNo='" & _strMobileNo & "', OccupationCode='" & _intOccupationCode & "',"
        strSQL = strSQL & "ReligionCode='" & _intReligionCode & "', CasteCode='" & _intCasteCode & "',"
        strSQL = strSQL & "Education='" & _strEducation & "',OfficeAddress ='" & _strOfficeAddress & "',OfficeNo='" & _strOfficeNo & "',Status='" & _charCustomerStatus & "',Remarks='" & _strReturn & "', CreationDate='" & Format(_datCreationDate, "yyyy-MM-dd") & "',EmailId='" & _strEmailId & "',PANNo='" & _strPANNo & "'  WHERE CustomerID='" & _strCustomerID & "'"
        If fnExecuteNonQuery(strSQL) Then
            fnUpdateImages()
            Return fnUpdateSignatureImages()
        Else
            Return False
        End If

    End Function
    Public Overloads Function fnUpdatePerson(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "UPDATE PersonTbl SET Name='" & _strName & "', FatherName='" & _strFatherName & "', DOB='" & Format(_datDOB, "yyyy-MM-dd") & "', "
        strSQL = strSQL & "Age='" & _intAge & "', AgeStatus='" & _chrAgeStatus & "', Gender='" & _chrGender & "', "
        strSQL = strSQL & "PresAddress='" & _strPresAddress & "',PermAddress='" & _strPermAddress & "',"
        strSQL = strSQL & "PhoneNo='" & _strPhoneNo & "', MobileNo='" & _strMobileNo & "', OccupationCode='" & _intOccupationCode & "',"
        strSQL = strSQL & "ReligionCode='" & _intReligionCode & "', CasteCode='" & _intCasteCode & "',"
        strSQL = strSQL & "Education='" & _strEducation & "',OfficeAddress ='" & _strOfficeAddress & "',OfficeNo='" & _strOfficeNo & "' WHERE CustomerID='" & _strCustomerID & "'"
        If fnExecuteNonQuery(strSQL, objTrans) Then
            fnUpdateImages(objTrans)
            Return fnUpdateSignatureImages(objTrans)
        Else
            Return False
        End If

    End Function

    Public Overloads Function fnUpdateImages(ByVal objTrans As IDbTransaction) As Boolean

        'Dim objConn As New Odbc.OdbcConnection(strODBCConnectionString)
        Dim objCmd As New Odbc.OdbcCommand(strSQL, objTrans.Connection, objTrans)

        Try
            ' objConn.Open()

            If Not _bytPhoto Is Nothing Then
                strSQL = "UPDATE PersonTbl SET Photo=? WHERE PersonNo=" & _lngPersonNo
                objCmd.CommandText = strSQL
                objCmd.Parameters.Add("@Photo", Odbc.OdbcType.VarChar).Value = _bytPhoto
                objCmd.ExecuteNonQuery()
            End If

            ''If Not _bytSign Is Nothing Then
            ''    strSQL = "UPDATE PersonTbl SET  Signature=? WHERE PersonNo=" & _lngPersonNo
            ''    objCmd.CommandText = strSQL
            ''    objCmd.Parameters.Add("@Signature", Odbc.OdbcType.Binary).Value = _bytSign
            ''    objCmd.ExecuteNonQuery()
            ''End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Overloads Function fnUpdateSignatureImages(ByVal objTrans As IDbTransaction) As Boolean

        'Dim objConn As New Odbc.OdbcConnection(strODBCConnectionString)
        Dim objCmd As New Odbc.OdbcCommand(strSQL, objTrans.Connection, objTrans)

        Try
            '' objConn.Open()

            ''If Not _bytPhoto Is Nothing Then
            ''    strSQL = "UPDATE PersonTbl SET Photo=? WHERE PersonNo=" & _lngPersonNo
            ''    objCmd.CommandText = strSQL
            ''    objCmd.Parameters.Add("@Photo", Odbc.OdbcType.Binary).Value = _bytPhoto
            ''    objCmd.ExecuteNonQuery()
            ''End If

            If Not _bytSign Is Nothing Then
                strSQL = "UPDATE PersonTbl SET  Signature=? WHERE PersonNo=" & _lngPersonNo
                objCmd.CommandText = strSQL
                objCmd.Parameters.Add("@Signature", Odbc.OdbcType.VarChar).Value = _bytSign
                objCmd.ExecuteNonQuery()
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Public Function fnDeletePerson(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "DELETE  FROM PersonTbl WHERE PersonNo='" & _lngPersonNo & "'"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    Public Function fnGetNewPersonNo() As Long

        Dim objDT As New DataTable

        strSQL = "SELECT MAX(PersonNo) from PersonTbl "

        objDT = fnExecuteQuery(strSQL, 2)

        If objDT.Rows.Count > 0 And IsDBNull(objDT.Rows(0).Item(0)) Then
            Return 1
        Else
            Return objDT.Rows(0).Item(0) + 1
        End If

    End Function
    Public Function fnCheckCustomer(ByVal FatherName As String, ByVal Name As String, ByVal DOB As Date) As Long
        strSQL = "SELECT * from PersonTbl where Name='" & Name & "' and FatherName='" & FatherName & "' and DOB='" & Format(DOB, "yyyy-MM-dd") & "' "
        CheckCustomer = fnExecuteQuery(strSQL, 2)

        If CheckCustomer.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetNewCustomerID() As String

        strSQL = "SELECT max(CustomerID) as MaxNo FROM PersonTbl "

        _dtPersonsTable = fnExecuteQuery(strSQL, 2)

        If IsDBNull(_dtPersonsTable.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return _dtPersonsTable.Rows(0).Item("MaxNo")
        End If

    End Function

    Public Function fnCheckPerson() As Boolean

        strSQL = "SELECT * FROM PersonTbl WHERE PersonNo='" & _lngPersonNo & "'"

        _dtPersonsTable = fnExecuteQuery(strSQL, 2)

        If _dtPersonsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnCheckCustomerID() As Boolean

        strSQL = "SELECT * FROM  PersonTbl WHERE CustomerID='" & _strCustomerID & "'"
        _dtPersonsTable = fnExecuteQuery(strSQL, 2)
        If _dtPersonsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnCheckCustomer() As Boolean

        strSQL = "SELECT * FROM  PersonTbl WHERE Name='" & _strName & "' and FatherName ='" & _strFatherName & "' and DOB='" & Format(DOB, "yyyy-MM-dd") & "'"
        _dtPersonsTable = fnExecuteQuery(strSQL, 2)
        If _dtPersonsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetCustomerID(ByVal CustomerID As String) As Boolean

        strSQL = "SELECT * FROM  PersonTbl WHERE CustomerID='" & CustomerID & "'"
        _dtPersonsTable = fnExecuteQuery(strSQL, 2)
        If _dtPersonsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetCustomerList() As Boolean
        strSQL = "SELECT * FROM  PersonTbl "
        _dtPersonsTable = fnExecuteQuery(strSQL, 2)
        If _dtPersonsTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


#End Region

End Class
