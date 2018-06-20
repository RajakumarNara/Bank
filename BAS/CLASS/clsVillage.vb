Public Class clsVillage

#Region "Variables"
    Private intVillageCode As Integer
    Private strVillageName As String
    Private strVillageShortName As String
    Private intHobliCode As Integer
    Private intTalukCode As Integer
    Private intDistCode As Integer
    Private intStateCode As Integer
    Private dtVillageTable As DataTable
#End Region


#Region "Properties"

    Public Property VillageCode() As Integer
        Get
            Return intVillageCode
        End Get
        Set(ByVal Value As Integer)
            intVillageCode = Value
        End Set
    End Property

    Public Property VillageName() As String
        Get
            Return strVillageName
        End Get
        Set(ByVal Value As String)
            strVillageName = Value
        End Set
    End Property

    Public Property VillageShortName() As String
        Get
            Return strVillageShortName
        End Get
        Set(ByVal Value As String)
            strVillageShortName = Value
        End Set
    End Property

    Public Property HobliCode() As Integer
        Get
            Return intHobliCode
        End Get
        Set(ByVal Value As Integer)
            intHobliCode = Value
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

    Public Property VillageTable() As DataTable
        Get
            Return dtVillageTable
        End Get
        Set(ByVal Value As DataTable)
            dtVillageTable = Value
        End Set
    End Property

#End Region

    '#Region "Functions"

    '    Public Function fnAddVillage() As Boolean

    '        strSQL = "INSERT into VillageTbl values('" & VillageCode & "','" & VillageName & "','" & VillageShortName & _
    '        "','" & HobliCode & "','" & TalukCode & "','" & DistCode & "','" & StateCode & "')"

    '        Return fnExecuteNonQuery(strSQL)

    '    End Function

    '    Public Function fnUpdateVillage() As Boolean

    '        strSQL = "UPDATE VillageTbl SET VillageName='" & VillageName & "', VillageShtName='" & VillageShortName & _
    '        "', HobliCode='" & HobliCode & "', TalukCode='" & TalukCode & "', DistCode='" & DistCode & _
    '        "', StateCode='" & StateCode & "' WHERE villageCode='" & VillageCode & "'"

    '        Return fnExecuteNonQuery(strSQL)

    '    End Function

    '    Public Function fnDeleteVillage() As Boolean

    '        strSQL = "DELETE from VillageTbl WHERE VillageCode='" & VillageCode & "'"

    '        Return fnExecuteNonQuery(strSQL)

    '    End Function

    '    Public Function fnGetVillages() As Boolean

    '        strSQL = "SELECT * from VillageTbl ORDER BY VillageName ASC"

    '        VillageTable = fnExecuteQuery(strSQL, 2)

    '        If VillageTable.Rows.Count > 0 Then
    '            Return True
    '        End If

    '        Return False

    '    End Function

    '    Public Function fnGetNewVillageNo() As Integer
    '        strSQL = "SELECT MAX(VillageCode) as MaxNo from villagetbl"
    '        VillageTable = fnExecuteQuery(strSQL, 2)
    '        If IsDBNull(VillageTable.Rows(0).Item("MaxNo")) = True Then
    '            Return 1
    '        Else
    '            Return VillageTable.Rows(0).Item("MaxNo") + 1
    '        End If
    '    End Function

    '    Public Function fnCheckCaste() As Boolean

    '        strSQL = "Select * from VillageTbl Where VillageCode='" & intVillageCode & " '"

    '        dtVillageTable = fnExecuteQuery(strSQL, 2)

    '        If dtVillageTable.Rows.Count > 0 Then
    '            Return True
    '        End If

    '        Return False
    '    End Function


    '#End Region


#Region "Functions"

    Public Function fnAddVillage() As Boolean

        strSQL = "INSERT into VillageTbl values('" & VillageCode & "','" & VillageName & "','" & VillageShortName & "')"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnUpdateVillage() As Boolean

        strSQL = "UPDATE VillageTbl SET VillageName='" & VillageName & "', VillageShtName='" & VillageShortName & "' WHERE VillageCode='" & VillageCode & "'"
       
        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnDeleteVillage() As Boolean

        strSQL = "DELETE from VillageTbl WHERE VillageCode='" & VillageCode & "'"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetVillages() As Boolean
        'ORDER BY VillageName ASC
        strSQL = "SELECT * from VillageTbl "

        VillageTable = fnExecuteQuery(strSQL, 2)

        If VillageTable.Rows.Count > 0 Then
            Return True
        End If

        Return False

    End Function

    Public Function fnGetNewVillageNo() As Integer
        strSQL = "SELECT MAX(VillageCode) as MaxNo from villagetbl"
        VillageTable = fnExecuteQuery(strSQL, 2)
        If IsDBNull(VillageTable.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return VillageTable.Rows(0).Item("MaxNo") + 1
        End If
    End Function

    Public Function fnCheckCaste() As Boolean

        strSQL = "Select * from VillageTbl Where VillageCode='" & intVillageCode & " '"

        dtVillageTable = fnExecuteQuery(strSQL, 2)

        If dtVillageTable.Rows.Count > 0 Then
            Return True
        End If

        Return False
    End Function


#End Region



End Class
