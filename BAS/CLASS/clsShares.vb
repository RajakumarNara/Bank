
Public Class clsShares

#Region "Variables"

    Private _dtSharesList As DataTable
    Private _dtNoOfShares As DataTable
    Private _lngtotalAmt As Long
    Private _dblDivAmt As Double
    Private _datDivApplDate As Date
    Private _intNoOfShares As Integer
    Private _chrType As String

    'TransferDetails

    Private _strFromMember As String
    Private _strToMember As String
    Private _datTransfer As Date
    Private _intTransferAmt As Integer
    Private _strReason As String
    Private _dtTransfer As DataTable

    'Shares Configuration

    Private _intAmtPerShare As Integer
    Private _dblShareFee As Double
    Private _dblApplicationFee As Double
    Private _dblShareEntryFee As Double
    Private _dblBuildingFund As Double
    Private _datConfig As Date
    Private _dtConfig As DataTable

#End Region

#Region "Properties"

    Public Property ShareListTbl() As DataTable
        Get
            Return _dtSharesList
        End Get
        Set(ByVal Value As DataTable)
            _dtSharesList = Value
        End Set
    End Property

    Public Property NoOfSharestbl() As DataTable
        Get
            Return _dtNoOfShares
        End Get
        Set(ByVal Value As DataTable)
            _dtNoOfShares = Value
        End Set
    End Property

    Public Property NoOfShares() As Integer
        Get
            Return _intNoOfShares
        End Get
        Set(ByVal Value As Integer)
            _intNoOfShares = Value
        End Set
    End Property

    Public Property Type() As String
        Get
            Return _chrType
        End Get
        Set(ByVal Value As String)
            _chrType = Value
        End Set
    End Property

    Public Property DivApplDate() As Date
        Get
            Return _datDivApplDate
        End Get
        Set(ByVal Value As Date)
            _datDivApplDate = Value
        End Set
    End Property

    Public Property TotalAmt() As Long
        Get
            Return _lngtotalAmt
        End Get
        Set(ByVal Value As Long)
            _lngtotalAmt = Value
        End Set

    End Property

    Public Property DivAmt() As Double
        Get
            Return _dblDivAmt
        End Get
        Set(ByVal Value As Double)
            _dblDivAmt = Value
        End Set
    End Property

    'Transfer Details

    Public Property FromTransferMember() As String
        Get
            Return _strFromMember
        End Get
        Set(ByVal Value As String)
            _strFromMember = Value
        End Set
    End Property

    Public Property ToTransferMember() As String
        Get
            Return _strToMember
        End Get
        Set(ByVal Value As String)
            _strToMember = Value
        End Set
    End Property

    Public Property TransferDate() As Date
        Get
            Return _datTransfer
        End Get
        Set(ByVal Value As Date)
            _datTransfer = Value
        End Set
    End Property

    Public Property ReasonForTransfer() As String
        Get
            Return _strReason
        End Get
        Set(ByVal Value As String)
            _strReason = Value
        End Set
    End Property

    Public Property TransferAmt() As Integer
        Get
            Return _intTransferAmt
        End Get
        Set(ByVal Value As Integer)
            _intTransferAmt = Value
        End Set
    End Property

    Public Property TransferTable() As DataTable
        Get
            Return _dtTransfer
        End Get
        Set(ByVal Value As DataTable)
            _dtTransfer = Value
        End Set
    End Property

    ' Share Configuration Detail
    Public Property ShareFee() As Double
        Get
            Return _dblShareFee
        End Get
        Set(ByVal Value As Double)
            _dblShareFee = Value
        End Set
    End Property
    Public Property BuildingFund() As Double
        Get
            Return _dblBuildingFund
        End Get
        Set(ByVal Value As Double)
            _dblBuildingFund = Value
        End Set
    End Property
    Public Property ShareEntryFee() As Double
        Get
            Return _dblShareEntryFee
        End Get
        Set(ByVal Value As Double)
            _dblShareEntryFee = Value
        End Set
    End Property
    Public Property ApplicationFee() As Double
        Get
            Return _dblApplicationFee
        End Get
        Set(ByVal Value As Double)
            _dblApplicationFee = Value
        End Set
    End Property
    Public Property AmountPerShare() As Integer
        Get
            Return _intAmtPerShare
        End Get
        Set(ByVal Value As Integer)
            _intAmtPerShare = Value
        End Set
    End Property

    Public Property ShareConfigDate() As Date
        Get
            Return _datConfig
        End Get
        Set(ByVal Value As Date)
            _datConfig = Value
        End Set
    End Property

    Public Property ConfigTbl() As DataTable
        Get
            Return _dtConfig
        End Get
        Set(ByVal Value As DataTable)
            _dtConfig = Value
        End Set
    End Property

#End Region

#Region "Functions"

    Public Function fnGetShareList() As Boolean

        strSQL = "select P.Name as Name,P.CustomerID,M.MemberNo,M.ApplDate,M.NoOfShares,M.ShareAmount,M.ReceiptNo,M.Status,M.Remarks,M.CallsInArrier from Membertbl M, PersonTbl P Where M.PersonNo = P.PersonNo"

        _dtSharesList = fnExecuteQuery(strSQL, 2)

        If _dtSharesList.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetSharePrintList() As Boolean

        strSQL = "select P.*, M.* from Membertbl M, PersonTbl P Where M.PersonNo = P.PersonNo"""

        _dtSharesList = fnExecuteQuery(strSQL, 2)

        If _dtSharesList.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetNoOfShares() As Boolean

        strSQL = "select sum(NoOfShares) as NoOfShares from membertbl"

        _dtNoOfShares = fnExecuteQuery(strSQL, 2)

        If _dtNoOfShares.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnInsertDiv() As Boolean

        strSQL = "Insert into sharedividendtbl(TotalAmount,NoOfShares,DividendApplDate,DividendAmount) values('" & _lngtotalAmt & "','" & _intNoOfShares & "','" & Format(_datDivApplDate, "yyyy-MM-dd") & "','" & _dblDivAmt & "')"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnExecProcedure() As Boolean

        '''''Dim objConnection As New Odbc.OdbcConnection(strODBCConnectionString)
        '''''Try
        '''''    objConnection.Open()
        '''''Dim sqlCmd As New Odbc.OdbcCommand("SPPostDividend", objConnection)
        '''''sqlCmd.CommandType = CommandType.StoredProcedure
        '''''sqlCmd.Parameters.Add("@dblDivAmt", SqlDbType.Int)
        '''''sqlCmd.Parameters("@dblDivAmt").Direction = ParameterDirection.Input
        '''''sqlCmd.Parameters("@dblDivAmt").Value = ParameterDirection.Input = _dblDivAmt
        '''''sqlCmd.ExecuteNonQuery()
        '''''    objConnection.Close()
        '''''Catch ex As Exception
        '''''    MsgBox(ex.Message)
        '''''End Try

    End Function

    Public Function fnTransferShares(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "INSERT INTO SharesTbl VALUES('" & _strFromMember & "','" & Format(_datTransfer, "yyyy-MM-dd") & "','" & _intNoOfShares & "','" & _intTransferAmt & "','0','0','Transfered','0')"
        If fnExecuteNonQuery(strSQL, objTrans) Then
            strSQL = "INSERT INTO SharesTbl VALUES('" & _strToMember & "','" & Format(_datTransfer, "yyyy-MM-dd") & "','" & _intNoOfShares & "','" & _intTransferAmt & "','0','0','ByTransfer','0')"
            If fnExecuteNonQuery(strSQL, objTrans) Then
                strSQL = "INSERT into sharetransfertbl(FromMemberNo,ToMemberNo,NoOfShares,Date,Amount,Reason) values ( '" & _strFromMember & "','" & _strToMember & "','" & _intNoOfShares & "','" & Format(_datTransfer, "yyyy-MM-dd") & "','" & _intTransferAmt & "','" & _strReason & "')"
                Return fnExecuteNonQuery(strSQL, objTrans)
            End If
        End If

    End Function

    Public Function fnGetMemberDet(ByVal strMemeberNo As String) As Boolean

        strSQL = "select P.PersonNo,P.Name,m.ShareAmount,m.NoOfShares,m.Status from Persontbl p, Membertbl m where p.personNo = m.PersonNo and m.MemberNo = '" & strMemeberNo & "'"

        _dtTransfer = fnExecuteQuery(strSQL, 2)

        If _dtTransfer.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnUpdateShareConfig() As Boolean
        strSQL = "update sharesconfigtbl set ShareType='" & _chrType & "',AmountPerShare ='" & _intAmtPerShare & "',ShareFee='" & _dblShareFee & "',ShareEntryFee='" & _dblShareEntryFee & "',BuildingFund='" & _dblBuildingFund & "',Date = '" & Format(_datConfig, "yyyy-MM-dd") & "',ApplicationFee='" & _dblApplicationFee & "' where ShareType='" & _chrType & "'"
        Return fnExecuteNonQuery(strSQL)
    End Function
    Public Function fnGetConfig() As Boolean
        strSQL = "Select * from sharesconfigtbl "
        _dtConfig = fnExecuteQuery(strSQL, 2)
        If _dtConfig.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fnCheckConfig() As Boolean
        strSQL = "Select * from sharesconfigtbl where ShareType='" & _chrType & "' "
        _dtConfig = fnExecuteQuery(strSQL, 2)
        If _dtConfig.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fnInsertShareConfig() As Boolean
        strSQL = "INSERT INTO sharesconfigtbl(ShareType,AmountPerShare,ShareFee,ShareEntryFee,BuildingFund,Date,ApplicationFee)VALUES('" & _chrType & "','" & _intAmtPerShare & "','" & _dblShareFee & "','" & _dblShareEntryFee & "','" & _dblBuildingFund & "','" & Format(_datConfig, "yyyy-MM-dd") & "','" & _dblApplicationFee & "')"
        If fnExecuteNonQuery(strSQL) Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

End Class
