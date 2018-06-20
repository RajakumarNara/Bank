Public Class clsHobli

#Region "Variables"
    Private intHobliCode As Integer
    Private strHobliName As String
    Private strHobliShortName As String
    Private intTalukCode As Integer
    Private intDistCode As Integer
    Private intStateCode As Integer
    Private dtHobliTable As DataTable
#End Region

#Region "Properties"

    Public Property HobliCode() As Integer
        Get
            Return intHobliCode
        End Get
        Set(ByVal Value As Integer)
            intHobliCode = Value
        End Set
    End Property

    Public Property HobliName() As String
        Get
            Return strHobliName
        End Get
        Set(ByVal Value As String)
            strHobliName = Value
        End Set
    End Property

    Public Property HobliShortName() As String
        Get
            Return strHobliShortName
        End Get
        Set(ByVal Value As String)
            strHobliShortName = Value
        End Set
    End Property

    Public Property TalukCode() As Integer
        Get
            Return intTalukCode
        End Get
        Set(ByVal Value As Integer)
            intTalukCode = Value
        End Set
    End Property

    Public Property DistCode() As Integer
        Get
            Return intDistCode
        End Get
        Set(ByVal Value As Integer)
            intDistCode = Value
        End Set
    End Property

    Public Property StateCode() As Integer
        Get
            Return intStateCode
        End Get
        Set(ByVal Value As Integer)
            intStateCode = Value
        End Set
    End Property

    Public Property HobliTable() As DataTable
        Get
            Return dtHobliTable
        End Get
        Set(ByVal Value As DataTable)
            dtHobliTable = Value
        End Set
    End Property

#End Region

    Public Function fnAddHobli() As Boolean

        strSQL = "INSERT into HobliTbl values('" & HobliCode & "','" & HobliName & "','" & HobliShortName & "','" & TalukCode & "','" & DistCode & "','" & StateCode & "')"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnUpdateHobli() As Boolean

        strSQL = "UPDATE HobliTbl SET HobliName='" & HobliName & "', HobliShtName='" & HobliShortName & _
        "', TalukCode='" & TalukCode & "', DistCode='" & DistCode & "', StateCode='" & StateCode & _
        "' WHERE HobliCode='" & HobliCode & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnDeleteHobli() As Boolean

        strSQL = "DELETE from HobliTbl WHERE HobliCode='" & HobliCode & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetHoblis() As Boolean

        strSQL = "SELECT * from HobliTbl"

        HobliTable = fnExecuteQuery(strSQL, 2)

        If HobliTable.Rows.Count > 0 Then
            Return True
        End If

        Return False

    End Function

    Public Function fnGetNewHobliNo() As Integer
        strSQL = "SELECT MAX(HobliCode) as MaxNo from hoblitbl"
        HobliTable = fnExecuteQuery(strSQL, 2)
        If IsDBNull(HobliTable.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return HobliTable.Rows(0).Item("MaxNo") + 1
        End If
    End Function

End Class
