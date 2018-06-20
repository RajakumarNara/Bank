Public Class clsCaste


#Region "Variables"

    Private intCasteCode As Integer
    Private strCasteName As String
    Private strCasteShtName As String
    Private dtCasteTable As DataTable

#End Region


#Region "Properties"

    Public Property CasteCode() As Integer
        Get
            Return intCasteCode
        End Get
        Set(ByVal Value As Integer)
            intCasteCode = Value
        End Set
    End Property

    Public Property CasteName() As String
        Get
            Return strCasteName
        End Get
        Set(ByVal Value As String)
            strCasteName = Value
        End Set
    End Property

    Public Property CasteShtName() As String
        Get
            Return strCasteShtName
        End Get
        Set(ByVal Value As String)
            strCasteShtName = Value
        End Set
    End Property

    Public Property CasteTable() As DataTable
        Get
            Return dtCasteTable
        End Get
        Set(ByVal Value As DataTable)
            dtCasteTable = Value
        End Set
    End Property

#End Region


#Region "Functions"

    Public Function fnAddCaste() As Boolean

        strSQL = "INSERT into CasteTbl values ( '" & CasteCode & "','" & CasteName & "','" & CasteShtName & "')"

        Return fnExecuteNonQuery(strSQL)

    End Function


    Public Function fnUpdateCaste() As Boolean

        strSQL = "UPDATE CasteTbl SET CasteName='" & CasteName & "', CasteShtName='" & _
        CasteShtName & "' WHERE CasteCode='" & CasteCode & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function


    Public Function fnDeleteCaste() As Boolean

        strSQL = "DELETE from CasteTbl WHERE CasteCode='" & CasteCode & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function


    Public Function fnGetCastes() As Boolean

        strSQL = "SELECT * from CasteTbl "

        dtCasteTable = fnExecuteQuery(strSQL, 2)

        If dtCasteTable.Rows.Count > 0 Then
            Return True
        End If

        Return False

    End Function

    Public Function fnCheckCaste() As Boolean

        strSQL = "Select * from CasteTbl Where CasteCode='" & intCasteCode & " '"

        dtCasteTable = fnExecuteQuery(strSQL, 2)

        If dtCasteTable.Rows.Count > 0 Then
            Return True
        End If

        Return False
    End Function

#End Region



End Class
