Public Class clsReligion


#Region "Variables"

    Private intReligionCode As Integer
    Private strReligionName As String
    Private strReligionShtName As String
    Private dtReligionTable As DataTable

#End Region


#Region "Properties"

    Public Property ReligionCode() As Integer
        Get
            Return intReligionCode
        End Get
        Set(ByVal Value As Integer)
            intReligionCode = Value
        End Set
    End Property

    Public Property ReligionName() As String
        Get
            Return strReligionName
        End Get
        Set(ByVal Value As String)
            strReligionName = Value
        End Set
    End Property

    Public Property ReligionShtName() As String
        Get
            Return strReligionShtName
        End Get
        Set(ByVal Value As String)
            strReligionShtName = Value
        End Set
    End Property

    Public Property ReligionTable() As DataTable
        Get
            Return dtReligionTable
        End Get
        Set(ByVal Value As DataTable)
            dtReligionTable = Value
        End Set
    End Property

#End Region


#Region "Functions"

    Public Function fnAddReligion() As Boolean

        strSQL = "INSERT into ReligionTbl values ( '" & ReligionCode & "','" & ReligionName & "','" & ReligionShtName & "')"

        Return fnExecuteNonQuery(strSQL)

    End Function


    Public Function fnUpdateReligion() As Boolean

        strSQL = "UPDATE ReligionTbl SET ReligionName='" & ReligionName & "', ReligionShtName='" & _
        ReligionShtName & "' WHERE ReligionCode='" & ReligionCode & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function


    Public Function fnDeleteReligion() As Boolean

        strSQL = "DELETE from ReligionTbl WHERE ReligionCode='" & ReligionCode & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function


    Public Function fnGetReligions() As Boolean

        strSQL = "SELECT * from ReligionTbl "

        ReligionTable = fnExecuteQuery(strSQL, 2)

        If ReligionTable.Rows.Count > 0 Then
            Return True
        End If

        Return False

    End Function
  
    Public Function fnCheckReligion() As Boolean

        strSQL = "Select * from ReligionTbl Where ReligionCode='" & ReligionCode & " '"

        ReligionTable = fnExecuteQuery(strSQL, 2)

        If ReligionTable.Rows.Count > 0 Then
            Return True
        End If

        Return False
    End Function

#End Region



End Class
