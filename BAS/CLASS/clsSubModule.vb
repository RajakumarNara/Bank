Public Class clsSubModule

#Region "Variables"
    Dim _strSubModule As String
    Dim _strSubModuleNo As String
    Dim _dtModTable As DataTable
    Dim _dtMTable As DataTable
    Dim _strMainModuleNo As String
#End Region

#Region "property"
    Public Property SubModule() As String
        Get
            Return _strSubModule
        End Get
        Set(ByVal Value As String)
            _strSubModule = Value
        End Set
    End Property
    Public Property SubModuleNo() As String
        Get
            Return _strSubModuleNo
        End Get
        Set(ByVal Value As String)
            _strSubModuleNo = Value
        End Set
    End Property
    Public Property MainModuleNo() As String
        Get
            Return _strMainModuleNo
        End Get
        Set(ByVal Value As String)
            _strMainModuleNo = Value
        End Set
    End Property

    Public Property ModuleTable() As DataTable
        Get
            Return _dtModTable
        End Get
        Set(ByVal Value As DataTable)
            _dtModTable = Value
        End Set
    End Property
    Public Property MTable() As DataTable
        Get
            Return _dtMTable
        End Get
        Set(ByVal Value As DataTable)
            _dtMTable = Value
        End Set
    End Property
#End Region

#Region "functions"

    Public Function fnGetData() As Boolean

        Dim strSql As String
        strSql = "Select * from  SubModuleTbl"
        _dtModTable = fnExecuteQuery(strSql, 2)
        If _dtModTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetCheckedItem(ByVal SModule As String, ByVal RId As String) As Boolean

        Dim strSql As String
        strSql = "Select Module,SubModule,Status from  RoleTbl Where Module='" & SModule & "' and RoleId='" & RId & "'"
        _dtMTable = fnExecuteQuery(strSql, 2)
        If _dtMTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetSubModule(ByVal MModuleNo As String) As Boolean

        strSQL = "select * from SubModuletbl where MainModuleNo='" & MModuleNo & "'"
        _dtModTable = fnExecuteQuery(strSQL, 2)
        If _dtModTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetSelectedModule(ByVal SModule As String) As Boolean

        strSQL = "SELECT R.SubModule,R.Status FROM SubModuleTbl SM,RoleTbl R, MainModuleTbl MM WHERE MM.ModuleNo=SM.MainModuleNo AND MM.Module='" & SModule & "' AND SM.SubMOdule=R.SubModule"
        _dtModTable = fnExecuteQuery(strSQL, 2)
        If _dtModTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


#End Region

End Class



