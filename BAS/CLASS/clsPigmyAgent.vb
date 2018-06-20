
Public Class clsPigmyAgent

#Region "Variables"

    Dim strSql As String

    Private _strAgentNo As String
    Private _strAgentName As String
    Private _intAgentAge As Integer
    Private _datAgentDOB As Date
    Private _StrPremAddr As String
    Private _StrPresAddr As String
    Private _intContNo As String
    Private _intMobNo As String
    Private _chrGender As Char
    Private _chrAgentStatue As Char
    Private _dtAgentDetails As DataTable
    Private _dtCheckAgent As DataTable
    Private _dtGetAgents As DataTable
    Private _StrPigmyNo As String
    Private _datPigmy As DataTable
    Private _dtInfo As DataTable
    Private _dtInfo1 As DataTable

#End Region

#Region "Properties"

    Public Property AgentNo() As String
        Get
            Return _strAgentNo
        End Get
        Set(ByVal Value As String)
            _strAgentNo = Value
        End Set
    End Property

    Public Property AgentName() As String
        Get
            Return _strAgentName
        End Get
        Set(ByVal Value As String)
            _strAgentName = Value
        End Set
    End Property

    Public Property AgentPremAddr() As String
        Get
            Return _StrPremAddr
        End Get
        Set(ByVal Value As String)
            _StrPremAddr = Value
        End Set
    End Property

    Public Property AgentPresAddr() As String
        Get
            Return _StrPresAddr
        End Get
        Set(ByVal Value As String)
            _StrPresAddr = Value
        End Set
    End Property

    Public Property AgentAge() As Integer
        Get
            Return _intAgentAge
        End Get
        Set(ByVal Value As Integer)
            _intAgentAge = Value
        End Set
    End Property

    Public Property AgentContNo() As String
        Get
            Return _intContNo
        End Get
        Set(ByVal Value As String)
            _intContNo = Value
        End Set
    End Property

    Public Property AgentMobNo() As String
        Get
            Return _intMobNo
        End Get
        Set(ByVal Value As String)
            _intMobNo = Value
        End Set
    End Property

    Public Property AgentDOB() As Date
        Get
            Return _datAgentDOB
        End Get
        Set(ByVal Value As Date)
            _datAgentDOB = Value
        End Set
    End Property

    Public Property Gender() As Char
        Get
            Return _chrGender
        End Get
        Set(ByVal Value As Char)
            _chrGender = Value
        End Set
    End Property

    Public Property AgeStatus() As Char
        Get
            Return _chrAgentStatue
        End Get
        Set(ByVal Value As Char)
            _chrAgentStatue = Value
        End Set
    End Property

    Public Property CheckAgentTable() As DataTable
        Get
            Return _dtCheckAgent
        End Get
        Set(ByVal Value As DataTable)
            _dtCheckAgent = Value
        End Set
    End Property

    Public Property AgentsCustTable() As DataTable
        Get
            Return _dtInfo
        End Get
        Set(ByVal Value As DataTable)
            _dtInfo = Value
        End Set
    End Property
    Public Property getAgentsTable() As DataTable
        Get
            Return _dtGetAgents
        End Get
        Set(ByVal Value As DataTable)
            _dtGetAgents = Value
        End Set
    End Property

    Public Property PigmyAccount() As String
        Get
            Return _StrPigmyNo
        End Get
        Set(ByVal Value As String)
            _StrPigmyNo = Value
        End Set
    End Property
    Public Property PigmyBalance() As DataTable
        Get
            Return _dtInfo1
        End Get
        Set(ByVal Value As DataTable)
            _dtInfo1 = Value
        End Set
    End Property


#End Region

#Region "Functions"

    Public Function fnInsertData() As Boolean

       
        strSql = "insert into pigmyagenttbl(AgentID,AgentName,Age,DOB,Gender,PresAddress,PremAddress,PhoneNo,MobileNo)"
        strSql = strSql & "values('" & _strAgentNo & "','" & _strAgentName & "','" & _intAgentAge & "','" & Format(_datAgentDOB, "yyyy-MM-dd") & "','" & _chrGender & "','" & _StrPresAddr & "',"
        strSql = strSql & "'" & _StrPremAddr & "','" & _intContNo & "','" & _intMobNo & "')"

        Return fnExecuteNonQuery(strSql)

    End Function

    Public Function fnCheckAgent(ByVal strAgentNo As String) As Boolean

        strSql = "select * from pigmyagenttbl where AgentID = '" & strAgentNo & "'"

        _dtCheckAgent = fnExecuteQuery(strSql, 2)

        If _dtCheckAgent.Rows.Count > 0 Then

            Return True
        Else
            Return False

        End If

    End Function

    Public Function fnUpdateAgent(ByVal strAgentNo As String) As Boolean

        strSql = "Update pigmyagenttbl set AgentName = '" & _strAgentName & "',Age = '" & _intAgentAge & "',"
        strSql = strSql & "DOB = '" & Format(_datAgentDOB, "yyyy-MM-dd") & "',Gender = '" & _chrGender & "',PresAddress = '" & _StrPresAddr & "',PremAddress= '" & _StrPremAddr & "',"
        strSql = strSql & "PhoneNo = '" & _intContNo & "',MobileNo = '" & _intMobNo & "' where AgentID = '" & _strAgentNo & "'"

        fnExecuteNonQuery(strSql)
        Return True

    End Function

    Public Function fnGetAgents() As Boolean

        strSql = "select * from PigmyAgenttbl"

        _dtGetAgents = fnExecuteQuery(strSql, 2)

        If _dtGetAgents.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetAgentNo() As String

        strSQL = "SELECT max(AgentID) as MaxNo FROM pigmyagenttbl "

        _dtAgentDetails = fnExecuteQuery(strSQL, 2)

        If IsDBNull(_dtAgentDetails.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return _dtAgentDetails.Rows(0).Item("MaxNo")
        End If

    End Function

    Public Function fnGetList(ByVal str As String) As Boolean

        strSql = "select * from  persontbl v ,pigmyaccounttbl a, pigmyagenttbl p where a.AgentNo ='" & str & "' and  a.AgentNo=p.AgentID and v.CustomerID = a.CustomerID and a.AccStatus='A' order by a.PigmyAccNo;"
        _dtInfo = fnExecuteQuery(strSql, 2)

        If _dtInfo.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetBalance(ByVal str As String, ByVal FromDate As DateTime, ByVal ToDate As DateTime) As Boolean
        strSql = "select sum(Deposit)as total from pigmytransactiontbl where TrDate between ' " & ToDate & " ' and '" & FromDate & "' and AgentID = '" & str & "'"
        _dtInfo1 = fnExecuteQuery(strSql, 2)

        If _dtInfo1.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

End Class
