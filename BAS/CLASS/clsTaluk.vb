Public Class clsTaluk

#Region "Variables"
    Private intTalukCode As Integer
    Private strTalukName As String
    Private strTalukShortName As String
    Private intDistCode As Integer
    Private intStateCode As Integer
    Private dtTalukTable As DataTable
#End Region


#Region "Properties"

    Public Property TalukCode() As Integer
        Get
            Return intTalukCode
        End Get
        Set(ByVal Value As Integer)
            intTalukCode = Value
        End Set
    End Property

    Public Property TalukName() As String
        Get
            Return strTalukName
        End Get
        Set(ByVal Value As String)
            strTalukName = Value
        End Set
    End Property

    Public Property TalukShortName() As String
        Get
            Return strTalukShortName
        End Get
        Set(ByVal Value As String)
            strTalukShortName = Value
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

    Public Property TalukTable() As DataTable
        Get
            Return dtTalukTable
        End Get
        Set(ByVal Value As DataTable)
            dtTalukTable = Value
        End Set
    End Property

#End Region


    Public Function fnAddTaluk() As Boolean

        strSQL = "INSERT into TalukTbl values('" & TalukCode & "','" & TalukName & "','" & TalukShortName & "','" & DistCode & "','" & StateCode & "')"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnUpdateTaluk() As Boolean

        strSQL = "UPDATE TalukTbl SET TalukName='" & TalukName & "', TalukShtName='" & _
        TalukShortName & "', DistCode='" & DistCode & "', StateCode='" & StateCode & _
        "' WHERE TalukCode='" & TalukCode & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnDeleteTaluk() As Boolean

        strSQL = "DELETE from TalukTbl WHERE TalukCode='" & TalukCode & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetTaluks() As Boolean

        strSQL = "SELECT * from TalukTbl"

        TalukTable = fnExecuteQuery(strSQL, 2)

        If TalukTable.Rows.Count > 0 Then
            Return True
        End If

        Return False

    End Function

    Public Function fnGetNewTalukNo() As Integer
        strSQL = "SELECT MAX(TalukCode) as MaxNo from taluktbl"
        TalukTable = fnExecuteQuery(strSQL, 2)
        If IsDBNull(TalukTable.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return TalukTable.Rows(0).Item("MaxNo") + 1
        End If
    End Function


End Class
