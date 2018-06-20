Public Class clsState


#Region "Variables"
    Private intStateCode As Integer
    Private strStateName As String
    Private strStateShtName As String
    Private dtStateTable As DataTable
#End Region


#Region "Properties"

    Public Property StateCode() As Integer
        Get
            Return intStateCode
        End Get
        Set(ByVal Value As Integer)
            intStateCode = Value
        End Set
    End Property

    Public Property StateName() As String
        Get
            Return strStateName
        End Get
        Set(ByVal Value As String)
            strStateName = Value
        End Set
    End Property

    Public Property StateShortName() As String
        Get
            Return strStateShtName
        End Get
        Set(ByVal Value As String)
            strStateShtName = Value
        End Set
    End Property

    Public Property StateTable() As DataTable
        Get
            Return dtStateTable
        End Get
        Set(ByVal Value As DataTable)
            dtStateTable = Value
        End Set
    End Property


#End Region


#Region "Functions"

    Public Function fnAddState() As Boolean
        strSQL = "INSERT into StateTbl values ( '" & StateCode & "','" & StateName & "','" & StateShortName & "')"
        Return fnExecuteNonQuery(strSQL)
    End Function


    Public Function fnUpdateState() As Boolean
        strSQL = "UPDATE StateTbl SET StateName='" & StateName & "', StateShtName='" & StateShortName & "' WHERE StateCode='" & StateCode & "'"
        Return fnExecuteNonQuery(strSQL)
    End Function


    Public Function fnDeleteState() As Boolean
        strSQL = "DELETE from StateTbl WHERE StateCode='" & StateCode & "'"
        Return fnExecuteNonQuery(strSQL)
    End Function


    Public Function fnGetStates() As Boolean
        strSQL = "SELECT * from StateTbl"
        StateTable = fnExecuteQuery(strSQL, 2)
        If StateTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnGetNewStateNo() As Integer
        strSQL = "SELECT MAX(statecode)as MaxNo FROM statetbl"
        dtStateTable = fnExecuteQuery(strSQL, 2)
        If IsDBNull(dtStateTable.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return dtStateTable.Rows(0).Item("MaxNo") + 1
        End If
    End Function

#End Region


End Class
