Public Class clsSignatories

#Region " Variables"

    Private _DouSigNo As Long
    Private _no As Integer
    Private _StrSigName As String
    Private _datDOB As Date
    Private _StrCurNo As String
    Private _intAge As Integer
    Private _strPosition As String
    Private _strAddr As String
    Private _chaGender As Char
    Private _strPhoneNo As String
    Private _strSignStatus As String
    Private _strMoblieNo As String
    Private _bytPhoto() As Byte
    Private _bytSign() As Byte
    Private _dtSignatoryTable As DataTable

#End Region

#Region "property"
    Public Property SignatoryNo() As Double
        Get
            Return _DouSigNo
        End Get
        Set(ByVal Value As Double)
            _DouSigNo = Value
        End Set
    End Property
    Public Property number() As Integer
        Get
            Return _no
        End Get
        Set(ByVal Value As Integer)
            _no = Value
        End Set
    End Property
    Public Property Curno() As String
        Get
            Return _StrCurNo
        End Get
        Set(ByVal Value As String)
            _StrCurNo = Value
        End Set
    End Property
    Public Property SignatoryName() As String
        Get
            Return _StrSigName
        End Get
        Set(ByVal Value As String)
            _StrSigName = Value
        End Set
    End Property
    Public Property SignatoryDOB() As Date
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
    Public Property Position() As String
        Get
            Return _strPosition
        End Get
        Set(ByVal Value As String)
            _strPosition = Value
        End Set
    End Property
    Public Property Gender() As Char
        Get
            Return _chaGender
        End Get
        Set(ByVal Value As Char)
            _chaGender = Value
        End Set
    End Property
    Public Property Signstatus() As String
        Get
            Return _strSignStatus
        End Get
        Set(ByVal Value As String)
            _strSignStatus = Value
        End Set
    End Property
    Public Property address() As String
        Get
            Return _strAddr
        End Get
        Set(ByVal Value As String)
            _strAddr = Value
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

    Public Property MoblieNo() As String
        Get
            Return _strMoblieNo
        End Get
        Set(ByVal Value As String)
            _strMoblieNo = Value
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
    Public Property SignatoryTable() As DataTable
        Get
            Return _dtSignatoryTable
        End Get
        Set(ByVal Value As DataTable)
            _dtSignatoryTable = Value
        End Set
    End Property

#End Region

#Region "functions"



    Public Function fnGetSignatories(ByVal StrAccountNo As String) As Boolean

        strSQL = "SELECT * FROM SignatoryTbl WHERE CurNo='" & StrAccountNo & "'"

        _dtSignatoryTable = fnExecuteQuery(strSQL, 2)

        If _dtSignatoryTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetSignStatus(ByVal Accno As String) As Boolean
        strSQL = "SELECT SignatoryStatus from SignatoryTbl WHERE CurNo='" & Accno & "'"
        _dtSignatoryTable = fnExecuteQuery(strSQL, 2)
        If _dtSignatoryTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function fnGetNewNo(ByVal strAccountNo As String) As Integer

        Dim objDT As New DataTable

        strSQL = "SELECT MAX(No) FROM SignatoryTbl WHERE CurNo='" & strAccountNo & "'"

        objDT = fnExecuteQuery(strSQL, 2)

        If objDT.Rows.Count > 0 And IsDBNull(objDT.Rows(0).Item(0)) Then
            Return 1
        Else
            Return objDT.Rows(0).Item(0) + 1
        End If

    End Function


    Public Function fnCheckSignatories(ByVal lngNo As Long, ByVal strAccountNo As String) As Boolean

        Dim objDT As New DataTable

        strSQL = "SELECT * FROM SignatoryTbl WHERE No='" & lngNo & "' AND CurNo='" & strAccountNo & "'"

        objDT = fnExecuteQuery(strSQL, 2)

        If objDT.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnUpdateSignatory(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "UPDATE SignatoryTbl SET SignName='" & _StrSigName & "', DOB='" & Format(_datDOB, "yyyy-MM-dd") & "', Age='" & _intAge & _
        "',Gender='" & _chaGender & "', SigAdder='" & _strAddr & "',Position='" & _strPosition & _
        "', PhoneNo='" & _strPhoneNo & "',SignatoryStatus='" & _strSignStatus & "',MobileNo='" & _strMoblieNo & "' WHERE No='" & _no & "' and CurNo='" & _StrCurNo & "'"

        If fnExecuteNonQuery(strSQL, objTrans) Then
            Return fnUpdateImages(objTrans)
        Else
            Return False
        End If

    End Function
    Public Function fnupdatesign(ByVal mandatory As String, ByVal first As String, ByVal second As String, ByVal objTrans As IDbTransaction) As Boolean
        strSQL = "UPDATE cadetailtbl SET MandateSign='" & mandatory & "',FirstSign='" & first & "',SecondSign='" & second & "'WHERE CAccountNo= '" & _StrCurNo & "' "
        If fnExecuteNonQuery(strSQL, objTrans) Then
            Return fnUpdateImages(objTrans)
        Else
            Return False
        End If
    End Function

    Public Function fninsertSign(ByVal mandatory As String, ByVal first As String, ByVal second As String, ByVal objTrans As IDbTransaction) As Boolean
        strSQL = "INSERT INTO cadetailtbl(MandateSign,FirstSign,SecondSign)VALUES('" & mandatory & "','" & first & "','" & second & "')WHERE CAccountNo= '" & _StrCurNo & "' "
        If fnExecuteNonQuery(strSQL, objTrans) Then
            Return fnUpdateImages(objTrans)
        Else
            Return False
        End If
    End Function

    Public Function fnDeleteSignatory(ByVal strAccountNo As String, ByVal lngNo As Long) As Boolean

        strSQL = "DELETE  FROM SignatoryTbl WHERE CurNo='" & strAccountNo & "' and No='" & lngNo & "' "

        Return fnExecuteNonQuery(strSQL)

    End Function


    Public Function fnAddSignatory(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "INSERT INTO SignatoryTbl(No,CurNo,SignName,DOB,Age,Position,Gender,SigAdder,PhoneNo,SignatoryStatus,MobileNo) VALUES('" & _
        _no & "','" & _StrCurNo & "','" & _StrSigName & "','" & Format(_datDOB, "yyyy-MM-dd") & "','" & _
        _intAge & "','" & _strPosition & "','" & _chaGender & "','" & _strAddr & "','" & _strPhoneNo & "','" & _strSignStatus & "','" & _strMoblieNo & "')"

        If fnExecuteNonQuery(strSQL) Then
            Return fnUpdateImages(objTrans)
        Else
            Return False
        End If

    End Function

    Public Function fnUpdateImages(ByVal objTrans As IDbTransaction) As Boolean

        ' Dim objConn As New Odbc.OdbcConnection(strODBCConnectionString)
        Dim objCmd As New Odbc.OdbcCommand(strSQL, objTrans.Connection, objTrans)

        Try
            'objConn.Open()
            If Not _bytPhoto Is Nothing Then
                strSQL = "UPDATE SignatoryTbl SET Photo=? WHERE No='" & _no & "' and CurNo='" & _StrCurNo & "'"
                objCmd.CommandText = strSQL
                objCmd.Parameters.Add("@Photo", Odbc.OdbcType.Binary).Value = _bytPhoto
                objCmd.ExecuteNonQuery()
            End If

            If Not _bytSign Is Nothing Then
                strSQL = "UPDATE SignatoryTbl SET Signature=? WHERE No='" & _no & "' and CurNo='" & _StrCurNo & "'"
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


#End Region

End Class
