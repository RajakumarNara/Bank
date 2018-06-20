Public Class clsOccupation

#Region "Variables"

    Private intOccupationCode As Integer
    Private strOccupationName As String
    Private strOccupationShtName As String
    Private dtOccupationTable As DataTable

#End Region

#Region "Properties"

    Public Property OccupationCode() As Integer
        Get
            Return intOccupationCode
        End Get
        Set(ByVal Value As Integer)
            intOccupationCode = Value
        End Set
    End Property

    Public Property OccupationName() As String
        Get
            Return strOccupationName
        End Get
        Set(ByVal Value As String)
            strOccupationName = Value
        End Set
    End Property

    Public Property OccupationShtName() As String
        Get
            Return strOccupationShtName
        End Get
        Set(ByVal Value As String)
            strOccupationShtName = Value
        End Set
    End Property

    Public Property OccupationTable() As DataTable
        Get
            Return dtOccupationTable
        End Get
        Set(ByVal Value As DataTable)
            dtOccupationTable = Value
        End Set
    End Property

#End Region

#Region "Functions"

    Public Function fnAddOccupation() As Boolean

        strSQL = "INSERT into OccupationTbl values ( '" & OccupationCode & "','" & OccupationName & "','" & OccupationShtName & "')"

        Return fnExecuteNonQuery(strSQL)

    End Function


    Public Function fnUpdateOccupation() As Boolean

        strSQL = "UPDATE OccupationTbl SET OccupationName='" & OccupationName & "', OccupationShtName='" & _
        OccupationShtName & "' WHERE OccupationCode='" & OccupationCode & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function


    Public Function fnDeleteOccupation() As Boolean

        strSQL = "DELETE from OccupationTbl WHERE OccupationCode='" & OccupationCode & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function


    Public Function fnGetOccupations() As Boolean

        strSQL = "SELECT * from OccupationTbl "

        OccupationTable = fnExecuteQuery(strSQL, 2)

        If OccupationTable.Rows.Count > 0 Then
            Return True
        End If

        Return False

    End Function

    Public Function fnCheckOccupation() As Boolean
        strSQL = "Select * from OccupationTbl Where OccupationCode='" & intOccupationCode & " '"

        dtOccupationTable = fnExecuteQuery(strSQL, 2)

        If dtOccupationTable.Rows.Count > 0 Then
            Return True
        End If

        Return False
    End Function

#End Region

End Class
