Public Class clsDistrict

#Region "Variables"
    Private intDistCode As Integer
    Private strDistName As String
    Private strDistShortName As String
    Private intStateCode As Integer
    Private dtDistTable As DataTable
#End Region

#Region "Properties"

    Public Property DistCode() As Integer
        Get
            Return intDistCode
        End Get
        Set(ByVal Value As Integer)
            intDistCode = Value
        End Set
    End Property

    Public Property DistName() As String
        Get
            Return strDistName
        End Get
        Set(ByVal Value As String)
            strDistName = Value
        End Set
    End Property

    Public Property DistShortName() As String
        Get
            Return strDistShortName
        End Get
        Set(ByVal Value As String)
            strDistShortName = Value
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

    Public Property DistTable() As DataTable
        Get
            Return dtDistTable
        End Get
        Set(ByVal Value As DataTable)
            dtDistTable = Value
        End Set
    End Property

#End Region

#Region "Functions"

    Public Function fnAddDistrict() As Boolean

        strSQL = "INSERT into DistrictTbl values('" & DistCode & "','" & DistName & "','" & DistShortName & "','" & StateCode & "')"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnUpdateDistrict() As Boolean

        strSQL = "UPDATE DistrictTbl SET DistrictName='" & DistName & "', DistrictShtName='" & DistShortName & _
        "', StateCode='" & StateCode & "' WHERE DistrictCode='" & DistCode & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnDeleteDistrict() As Boolean

        strSQL = "DELETE from DistrictTbl WHERE DistrictCode='" & DistCode & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetDistricts() As Boolean

        strSQL = "SELECT * from DistrictTbl"

        DistTable = fnExecuteQuery(strSQL, 2)

        If DistTable.Rows.Count > 0 Then
            Return True
        End If

        Return False

    End Function

    Public Function fnGetNewDistrictNo() As Integer
        strSQL = "SELECT MAX(DistrictCode) as MaxNo FROM districttbl"
        DistTable = fnExecuteQuery(strSQL, 2)
        If IsDBNull(DistTable.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return DistTable.Rows(0).Item("MaxNo") + 1
        End If
    End Function

#End Region

End Class
