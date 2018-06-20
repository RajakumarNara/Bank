Public Class clsFamilyDetails

#Region "Variables"
    Private _lngNo As Long
    Private _strAccountNo As String
    Private _strName As String
    Private _datDOB As Date
    Private _intAge As Integer
    Private _chrAgeStatus As Char
    Private _chrGender As Char
    Private _intRelationCode As Integer
    Private _strUHIDNo As String
    Private _chrType As Char
    Private _bytPhoto As Byte()

    Private _dtFamilyTable As DataTable

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

    Public Property RelationCode() As Integer
        Get
            Return _intRelationCode
        End Get
        Set(ByVal Value As Integer)
            _intRelationCode = Value
        End Set
    End Property
    Public Property UHIDNo() As String
        Get
            Return _strUHIDNo
        End Get
        Set(ByVal Value As String)
            _strUHIDNo = Value
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

    Public Property FamilyTable() As DataTable
        Get
            Return _dtFamilyTable
        End Get
        Set(ByVal Value As DataTable)
            _dtFamilyTable = Value
        End Set
    End Property


#End Region

#Region "Functions"


    Public Function fnAddFamily(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "INSERT INTO FamilydetailTbl(No,AccountNo,Name,DOB,Age,AgeStatus,Gender,RelationCode,Type) VALUES('" & _
        _lngNo & "','" & _strAccountNo & "','" & _strName & "','" & Format(_datDOB, "yyyy-MM-dd") & "','" & _
        _intAge & "','" & _chrAgeStatus & "','" & _chrGender & "','" & _intRelationCode & "','" & _chrType & "')"

        If fnExecuteNonQuery(strSQL, objTrans) Then
            Return fnUpdateImages(objTrans)
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
                strSQL = "UPDATE FamilydetailTbl SET Photo=? WHERE No='" & _lngNo & "' and AccountNo='" & _strAccountNo & "' and Type='" & _chrType & "'"
                objCmd.CommandText = strSQL
                objCmd.Parameters.Add("@Photo", Odbc.OdbcType.Binary).Value = _bytPhoto
                objCmd.ExecuteNonQuery()
            End If

            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function



    Public Function fnGetNewFamilyNo(ByVal strAccountNo As String, ByVal chrType As Char) As Long

        Dim objDT As New DataTable

        strSQL = "SELECT MAX(No) FROM FamilydetailTbl WHERE AccountNo='" & strAccountNo & "' and Type='" & chrType & "'"

        objDT = fnExecuteQuery(strSQL, 2)

        If objDT.Rows.Count > 0 And IsDBNull(objDT.Rows(0).Item(0)) Then
            Return 1
        Else
            Return objDT.Rows(0).Item(0) + 1
        End If

    End Function



    Public Function fnDeleteAccountFamily(ByVal strAccountNo As String, ByVal chrType As Char) As Boolean

        strSQL = "DELETE  FROM FamilydetailTbl WHERE AccountNo='" & strAccountNo & "' and Type='" & chrType & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function


    Public Function fnDeleteFamily(ByVal strAccountNo As String, ByVal lngNo As Long, ByVal chrType As Char) As Boolean

        strSQL = "DELETE  FROM FamilydetailTbl WHERE AccountNo='" & strAccountNo & "' and No='" & lngNo & "' and Type='" & chrType & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function



    Public Function fnUpdateFamily(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "UPDATE FamilydetailTbl SET Name='" & _strName & "', DOB='" & Format(_datDOB, "yyyy-MM-dd") & "', Age='" & _intAge & _
        "', AgeStatus='" & _chrAgeStatus & "', Gender='" & _chrGender & "', RelationCode='" & _intRelationCode & _
           " 'WHERE No='" & _lngNo & "' and AccountNo='" & _strAccountNo & "' and Type='" & _chrType & "'"
        If fnExecuteNonQuery(strSQL, objTrans) Then
            Return fnUpdateImages(objTrans)
        Else
            Return False
        End If

    End Function


    Public Function fnGetFamilys(ByVal StrAccountNo As String, ByVal chrType As Char) As Boolean

        strSQL = "SELECT * FROM FamilydetailTbl WHERE AccountNo='" & StrAccountNo & "' and Type='" & chrType & "'"

        _dtFamilyTable = fnExecuteQuery(strSQL, 2)

        If _dtFamilyTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnCheckFamily(ByVal SlNo As Integer, ByVal StrAccountNo As String)

        strSQL = "SELECT * FROM familydetailtbl where AccountNo='" & StrAccountNo & "' and No='" & SlNo & "'"

        _dtFamilyTable = fnExecuteQuery(strSQL, 2)

        If _dtFamilyTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetFamily(ByVal StrAccountNo As String) As Boolean

        strSQL = "SELECT * FROM familydetailtbl where AccountNo='" & StrAccountNo & "'"

        _dtFamilyTable = fnExecuteQuery(strSQL, 2)

        If _dtFamilyTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnCheckFamily(ByVal lngNo As Long, ByVal strAccountNo As String, ByVal chrType As Char) As Boolean

        Dim objDT As New DataTable

        strSQL = "SELECT * FROM FamilydetailTbl WHERE No='" & lngNo & "' AND AccountNo='" & strAccountNo & "' and Type='" & chrType & "'"

        objDT = fnExecuteQuery(strSQL, 2)

        If objDT.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

#End Region


End Class
