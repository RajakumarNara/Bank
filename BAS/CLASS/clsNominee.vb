Public Class clsNominee


#Region "Variables"
    Private _lngNo As Long
    Private _strAccountNo As String
    Private _strName As String
    Private _datDOB As Date
    Private _intAge As Integer
    Private _chrAgeStatus As Char
    Private _chrGender As Char
    Private _strAddress As String
    Private _strFatherName As String
    Private _intVillageCode As Integer
    Private _intOccupationCode As Integer
    Private _intRelationCode As Integer
    Private _chrType As Char

    Private _bytPhoto As Byte()
    Private _bytSign As Byte()

    Private _dtNomineeTable As DataTable

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

    Public Property AccountNo() As String
        Get
            Return _strAccountNo
        End Get
        Set(ByVal Value As String)
            _strAccountNo = Value
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
    Public Property FatherName() As String
        Get
            Return _strFatherName
        End Get
        Set(ByVal Value As String)
            _strFatherName = Value
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

    Public Property Address() As String
        Get
            Return _strAddress
        End Get
        Set(ByVal Value As String)
            _strAddress = Value
        End Set
    End Property

    Public Property VillageCode() As Integer
        Get
            Return _intVillageCode
        End Get
        Set(ByVal Value As Integer)
            _intVillageCode = Value
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

    Public Property RelationCode() As Integer
        Get
            Return _intRelationCode
        End Get
        Set(ByVal Value As Integer)
            _intRelationCode = Value
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

    Public Property NomineeTable() As DataTable
        Get
            Return _dtNomineeTable
        End Get
        Set(ByVal Value As DataTable)
            _dtNomineeTable = Value
        End Set
    End Property


#End Region


#Region "Nominee Detail Functions"


    Public Function fnAddNominee(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "INSERT INTO NomineeTbl(No,AccountNo,Name,DOB,Age,AgeStatus,Gender,Address,OccupationCode,RelationCode,FatherName,Type) VALUES('" & _
        _lngNo & "','" & _strAccountNo & "','" & _strName & "','" & Format(_datDOB, "yyyy-MM-dd") & "','" & _
        _intAge & "','" & _chrAgeStatus & "','" & _chrGender & "','" & _strAddress & "','" & _
        _intOccupationCode & "','" & _intRelationCode & "','" & _strFatherName & "','" & _chrType & "')"

        If fnExecuteNonQuery(strSQL) Then
            fnUpdateImages(objTrans)
            Return fnUpdateSignatureImages(objTrans)
        Else
            Return False
        End If

    End Function



    Public Function fnUpdateImages(ByVal objTrans As IDbTransaction) As Boolean

        'Dim objConn As New Odbc.OdbcConnection(strODBCConnectionString)
        Dim objCmd As New Odbc.OdbcCommand(strSQL, objTrans.Connection, objTrans)

        Try
            'objConn.Open()
            If Not _bytPhoto Is Nothing Then
                strSQL = "UPDATE NomineeTbl SET Photo=? WHERE No='" & _lngNo & "' and AccountNo='" & _strAccountNo & "' and Type='" & _chrType & "'"
                objCmd.CommandText = strSQL
                objCmd.Parameters.Add("@Photo", Odbc.OdbcType.Binary).Value = _bytPhoto
                objCmd.ExecuteNonQuery()
            End If

            'If Not _bytSign Is Nothing Then
            '    strSQL = "UPDATE NomineeTbl SET Signature=? WHERE No='" & _lngNo & "' and AccountNo='" & _strAccountNo & "' and Type='" & _chrType & "'"
            '    objCmd.CommandText = strSQL
            '    objCmd.Parameters.Add("@Signnature", Odbc.OdbcType.Binary).Value = _bytSign
            '    objCmd.ExecuteNonQuery()
            'End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function fnUpdateSignatureImages(ByVal objTrans As IDbTransaction) As Boolean

        'Dim objConn As New Odbc.OdbcConnection(strODBCConnectionString)
        Dim objCmd As New Odbc.OdbcCommand(strSQL, objTrans.Connection, objTrans)

        Try
            'objConn.Open()
            'If Not _bytPhoto Is Nothing Then
            '    strSQL = "UPDATE NomineeTbl SET Photo=? WHERE No='" & _lngNo & "' and AccountNo='" & _strAccountNo & "' and Type='" & _chrType & "'"
            '    objCmd.CommandText = strSQL
            '    objCmd.Parameters.Add("@Photo", Odbc.OdbcType.Binary).Value = _bytPhoto
            '    objCmd.ExecuteNonQuery()
            'End If

            If Not _bytSign Is Nothing Then
                strSQL = "UPDATE NomineeTbl SET Signature=? WHERE No='" & _lngNo & "' and AccountNo='" & _strAccountNo & "' and Type='" & _chrType & "'"
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



    Public Function fnGetNewNomineeNo(ByVal strAccountNo As String, ByVal chrType As Char) As Long

        Dim objDT As New DataTable

        strSQL = "SELECT MAX(No) FROM NomineeTbl WHERE AccountNo='" & strAccountNo & "' and Type='" & chrType & "'"

        objDT = fnExecuteQuery(strSQL, 2)

        If objDT.Rows.Count > 0 And IsDBNull(objDT.Rows(0).Item(0)) Then
            Return 1
        Else
            Return objDT.Rows(0).Item(0) + 1
        End If

    End Function



    Public Function fnDeleteAccountNominees(ByVal strAccountNo As String, ByVal chrType As Char) As Boolean

        strSQL = "DELETE  FROM NomineeTbl WHERE AccountNo='" & strAccountNo & "' and Type='" & chrType & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function


    Public Function fnDeleteNominee(ByVal strAccountNo As String, ByVal lngNo As Long, ByVal chrType As Char) As Boolean

        strSQL = "DELETE  FROM NomineeTbl WHERE AccountNo='" & strAccountNo & "' and No='" & lngNo & "' and Type='" & chrType & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function



    Public Function fnUpdateNominee(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "UPDATE NomineeTbl SET Name='" & _strName & "', DOB='" & Format(_datDOB, "yyyy-MM-dd") & "', Age='" & _intAge & _
        "', AgeStatus='" & _chrAgeStatus & "', Gender='" & _chrGender & "', Address='" & _strAddress & _
        "', OccupationCode='" & _intOccupationCode & _
        "', RelationCode='" & _intRelationCode & "',FatherName='" & _strFatherName & "' WHERE No='" & _lngNo & "' and AccountNo='" & _strAccountNo & "' and Type='" & _chrType & "'"

        If fnExecuteNonQuery(strSQL, objTrans) Then
            fnUpdateImages(objTrans)
            Return fnUpdateSignatureImages(objTrans)
        Else
            Return False
        End If

    End Function


    Public Function fnGetNominees(ByVal StrAccountNo As String, ByVal chrType As Char) As Boolean

        strSQL = "SELECT * FROM NomineeTbl WHERE AccountNo='" & StrAccountNo & "' and Type='" & chrType & "'"

        _dtNomineeTable = fnExecuteQuery(strSQL, 2)

        If _dtNomineeTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnCheckNominee(ByVal lngNo As Long, ByVal strAccountNo As String, ByVal chrType As Char) As Boolean

        Dim objDT As New DataTable

        strSQL = "SELECT * FROM NomineeTbl WHERE No='" & lngNo & "' AND AccountNo='" & strAccountNo & "' and Type='" & chrType & "'"

        objDT = fnExecuteQuery(strSQL, 2)

        If objDT.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

#End Region


    '#Region "JointHolder Functions"


    '    Public Function fnAddNominee() As Boolean

    '        strSQL = "INSERT INTO NomineeTbl(No,AccountNo,Name,DOB,Age,AgeStatus,Gender,Address,VillageCode,OccupationCode,RelationCode,Type) VALUES('" & _
    '        _lngNo & "','" & _strAccountNo & "','" & _strName & "','" & Format(_datDOB, "yyyy-MM-dd") & "','" & _
    '        _intAge & "','" & _chrAgeStatus & "','" & _chrGender & "','" & _strAddress & "','" & _intVillageCode & "','" & _
    '        _intOccupationCode & "','" & _intRelationCode & "','" & _chrType & "')"

    '        If fnExecuteNonQuery(strSQL) Then
    '            Return fnUpdateImages()
    '        Else
    '            Return False
    '        End If

    '    End Function



    '    Public Function fnUpdateImages() As Boolean

    '        Dim objConn As New Odbc.OdbcConnection(strODBCConnectionString)
    '        Dim objCmd As New Odbc.OdbcCommand(strSQL, objConn)

    '        Try
    '            objConn.Open()
    '            If Not _bytPhoto Is Nothing Then
    '                strSQL = "UPDATE NomineeTbl SET Photo=? WHERE No='" & _lngNo & "' and AccountNo='" & _strAccountNo & "' and Type='" & _chrType & "'"
    '                objCmd.CommandText = strSQL
    '                objCmd.Parameters.Add("@Photo", Odbc.OdbcType.Binary).Value = _bytPhoto
    '                objCmd.ExecuteNonQuery()
    '            End If

    '            If Not _bytSign Is Nothing Then
    '                strSQL = "UPDATE NomineeTbl SET Signature=? WHERE No='" & _lngNo & "' and AccountNo='" & _strAccountNo & "' and Type='" & _chrType & "'"
    '                objCmd.CommandText = strSQL
    '                objCmd.Parameters.Add("@Signnature", Odbc.OdbcType.Binary).Value = _bytSign
    '                objCmd.ExecuteNonQuery()
    '            End If

    '            Return True

    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '            Return False
    '        End Try
    '    End Function



    '    Public Function fnGetNewNomineeNo(ByVal strAccountNo As String, ByVal chrType As Char) As Long

    '        Dim objDT As New DataTable

    '        strSQL = "SELECT MAX(No) FROM NomineeTbl WHERE AccountNo='" & strAccountNo & "' and Type='" & chrType & "'"

    '        objDT = fnExecuteQuery(strSQL, 2)

    '        If objDT.Rows.Count > 0 And IsDBNull(objDT.Rows(0).Item(0)) Then
    '            Return 1
    '        Else
    '            Return objDT.Rows(0).Item(0) + 1
    '        End If

    '    End Function



    '    Public Function fnDeleteAccountNominees(ByVal strAccountNo As String, ByVal chrType As Char) As Boolean

    '        strSQL = "DELETE  FROM NomineeTbl WHERE AccountNo='" & strAccountNo & "' and Type='" & chrType & "'"

    '        Return fnExecuteNonQuery(strSQL)

    '    End Function


    '    Public Function fnDeleteNominee(ByVal strAccountNo As String, ByVal lngNo As Long, ByVal chrType As Char) As Boolean

    '        strSQL = "DELETE  FROM NomineeTbl WHERE AccountNo='" & strAccountNo & "' and No='" & lngNo & "' and Type='" & chrType & "'"

    '        Return fnExecuteNonQuery(strSQL)

    '    End Function



    '    Public Function fnUpdateNominee() As Boolean

    '        strSQL = "UPDATE NomineeTbl SET Name='" & _strName & "', DOB='" & Format(_datDOB, "yyyy-MM-dd") & "', Age='" & _intAge & _
    '        "', AgeStatus='" & _chrAgeStatus & "', Gender='" & _chrGender & "', Address='" & _strAddress & _
    '        "', VillageCode='" & _intVillageCode & "', OccupationCode='" & _intOccupationCode & _
    '        "', RelationCode='" & _intRelationCode & "' WHERE No='" & _lngNo & "' and AccountNo='" & _strAccountNo & "' and Type='" & _chrType & "'"

    '        If fnExecuteNonQuery(strSQL) Then
    '            Return fnUpdateImages()
    '        Else
    '            Return False
    '        End If

    '    End Function


    '    Public Function fnGetNominees(ByVal StrAccountNo As String, ByVal chrType As Char) As Boolean

    '        strSQL = "SELECT * FROM NomineeTbl WHERE AccountNo='" & StrAccountNo & "' and Type='" & chrType & "'"

    '        _dtNomineeTable = fnExecuteQuery(strSQL, 2)

    '        If _dtNomineeTable.Rows.Count > 0 Then
    '            Return True
    '        Else
    '            Return False
    '        End If

    '    End Function


    '    Public Function fnCheckNominee(ByVal lngNo As Long, ByVal strAccountNo As String, ByVal chrType As Char) As Boolean

    '        Dim objDT As New DataTable

    '        strSQL = "SELECT * FROM NomineeTbl WHERE No='" & lngNo & "' AND AccountNo='" & strAccountNo & "' and Type='" & chrType & "'"

    '        objDT = fnExecuteQuery(strSQL, 2)

    '        If objDT.Rows.Count > 0 Then
    '            Return True
    '        Else
    '            Return False
    '        End If

    '    End Function

    '#End Region


End Class
