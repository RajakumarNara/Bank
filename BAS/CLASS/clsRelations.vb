Public Class clsRelations

#Region "Variables"
    Private intRelationCode As Integer
    Private strRelationName As String
    Private dtRelationTable As DataTable
#End Region

#Region "Properties"

    Public Property RelationCode() As Integer
        Get
            Return intRelationCode
        End Get
        Set(ByVal Value As Integer)
            intRelationCode = Value
        End Set
    End Property

    Public Property RelationName() As String
        Get
            Return strRelationName
        End Get
        Set(ByVal Value As String)
            strRelationName = Value
        End Set
    End Property

    Public Property RelationTable() As DataTable
        Get
            Return dtRelationTable
        End Get
        Set(ByVal Value As DataTable)
            dtRelationTable = Value
        End Set
    End Property


#End Region

#Region "Functions"

    Public Function fnAddRelation() As Boolean
        strSQL = "INSERT into RelationTbl values ( '" & RelationCode & "','" & RelationName & "','Y')"
        Return fnExecuteNonQuery(strSQL)
    End Function


    Public Function fnUpdateRelation() As Boolean
        strSQL = "UPDATE RelationTbl SET RelationName='" & RelationName & "' WHERE RelationCode='" & RelationCode & "'"
        Return fnExecuteNonQuery(strSQL)
    End Function


    Public Function fnDeleteRelation() As Boolean
        strSQL = "DELETE from RelationTbl WHERE RelationCode='" & RelationCode & "'"
        Return fnExecuteNonQuery(strSQL)
    End Function


    Public Function fnGetRelations() As Boolean
        strSQL = "SELECT * from RelationTbl"
        RelationTable = fnExecuteQuery(strSQL, 2)
        If RelationTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function fnCheckRelation() As Boolean

        strSQL = "Select * from RelationTbl Where RelationCode='" & RelationCode & " '"

        dtRelationTable = fnExecuteQuery(strSQL, 2)

        If dtRelationTable.Rows.Count > 0 Then
            Return True
        End If

        Return False
    End Function


#End Region

End Class
