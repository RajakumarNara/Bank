Public Class clsDesignation

#Region "Variables"
    Private _intDesCode As Integer
    Private _strDesName As String
    Private _strDesShtName As String
    Private _dtDesigTable As DataTable
#End Region

#Region "Properties "
    Public Property DesCode() As Integer
        Get
            Return _intDesCode
        End Get
        Set(ByVal Value As Integer)
            _intDesCode = Value
        End Set
    End Property

    Public Property DesName() As String
        Get
            Return _strDesName
        End Get
        Set(ByVal Value As String)
            _strDesName = Value
        End Set
    End Property
    Public Property DesShtName() As String
        Get
            Return _strDesShtName
        End Get
        Set(ByVal Value As String)
            _strDesShtName = Value
        End Set
    End Property
    Public Property DesigTable() As DataTable
        Get
            Return (_dtDesigTable)
        End Get
        Set(ByVal Value As DataTable)
            _dtDesigTable = Value
        End Set
    End Property
#End Region

#Region "function"

    Public Function fnAddDesig() As Boolean
        strSQL = "Insert into DesignationTbl values('" & DesCode & "','" & DesName & "','" & DesShtName & "')"
        Return fnExecuteNonQuery(strSQL)
    End Function

    Public Function fnUpdateDesig() As Boolean
        strSQL = "UPDATE DesignationTbl SET DesignationName='" & DesName & "',DesignationShtName='" & DesShtName & _
        "' WHERE DesignationCode='" & DesCode & "'"
        Return fnExecuteNonQuery(strSQL)
    End Function

    Public Function fnDelete() As Boolean
        strSQL = "DELETE from DesignationTbl WHERE DesignationCode='" & DesCode & "' "
        Return fnExecuteNonQuery(strSQL)
    End Function

    Public Function fnGetDesignation() As Boolean
        strSQL = "SELECT * from DesignationTbl "
        DesigTable = fnExecuteQuery(strSQL, 2)
        If DesigTable.Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function fnCheckDesignation() As Boolean
        strSQL = "Select * from DesignationTbl Where DesignationCode='" & DesCode & " '"
        DesigTable = fnExecuteQuery(strSQL, 2)
        If DesigTable.Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function
#End Region

End Class
