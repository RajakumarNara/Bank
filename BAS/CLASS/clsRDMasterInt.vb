
Public Class clsRDMasterInt

#Region "Variables"

    Private _intFromPeriod As Integer
    Private _intToPeriod As Integer
    Private _lngROI As Long
    Private _dtIntrSetting As DataTable
    Private _dtLoadIntrSet As DataTable

#End Region

#Region "Properties"

    Public Property FromPeriod() As Integer
        Get
            Return _intFromPeriod
        End Get
        Set(ByVal Value As Integer)
            _intFromPeriod = Value
        End Set
    End Property

    Public Property ToPeriod() As Integer
        Get
            Return _intToPeriod
        End Get
        Set(ByVal Value As Integer)
            _intToPeriod = Value
        End Set
    End Property

    Public Property RateOfinterest() As Long
        Get
            Return _lngROI
        End Get
        Set(ByVal Value As Long)
            _lngROI = Value
        End Set
    End Property

    Public Property RDIntrSettingtbl() As DataTable
        Get
            Return _dtIntrSetting
        End Get
        Set(ByVal Value As DataTable)
            _dtIntrSetting = Value
        End Set
    End Property

    Public Property LoadIntrSet() As DataTable
        Get
            Return _dtLoadIntrSet
        End Get
        Set(ByVal Value As DataTable)
            _dtLoadIntrSet = Value
        End Set
    End Property

#End Region

#Region "Functions"

    Public Function fnInsertMasterROI() As Boolean

        Dim drRow As DataRow

        For Each drRow In _dtIntrSetting.Rows
            strSQL = "Insert into RdMasterSettingstbl(FromPeriod,ToPeriod,RateOfInterest) values( '" & drRow(0) & "','" & drRow(1) & "','" & drRow(2) & "') "
            fnExecuteNonQuery(strSQL)
        Next
        Return True
    End Function

    Public Function fnDeleteMasterROI() As Boolean

        strSQL = "delete from RdMasterSettingstbl"

        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnLoadData() As Boolean

        strSQL = "select * from RdMasterSettingstbl"

        _dtLoadIntrSet = fnExecuteQuery(strSQL, 2)

        Return True

    End Function

#End Region

End Class
