Public Class clsBank

#Region "Variables"
    Private _strBankName As String
    Private _strAddress As String
    Private _strPhoneNo1 As String
    Private _strPhoneNo2 As String
    Private _strKSTNo As String
    Private _strCSTNo As String
    Private _strRegNo As String
    Private _datRegDate As Date
    Private _datStartDate As Date
    Private _strRepHeader As String
    Private _strRepSubHearder As String
    Private _strPresident As String
    Private _strManager As String
    Private _dtBankTable As DataTable
    Private _dtpFinancialStart As DateTime
    Private _dtpFinancialEnd As DateTime
    Private _strEmailId As String
    Private _strWebsite As String

#End Region

#Region "Properties"
    Public Property EmailId() As String
        Get
            Return _strEmailId
        End Get
        Set(ByVal Value As String)
            _strEmailId = Value
        End Set
    End Property

    Public Property Website() As String
        Get
            Return _strWebsite
        End Get
        Set(ByVal Value As String)
            _strWebsite = Value
        End Set
    End Property

    Public Property BankName() As String
        Get
            Return _strBankName
        End Get
        Set(ByVal Value As String)
            _strBankName = Value
        End Set
    End Property

    Public Property Address() As String
        Get
            Return _strAddress
        End Get
        Set(ByVal Value As String)
            _strAddress = Value
        End Set
    End Property

    Public Property PhoneNo1() As String
        Get
            Return _strPhoneNo1
        End Get
        Set(ByVal Value As String)
            _strPhoneNo1 = Value
        End Set
    End Property

    Public Property PhoneNo2() As String
        Get
            Return _strPhoneNo2
        End Get
        Set(ByVal Value As String)
            _strPhoneNo2 = Value
        End Set
    End Property

    Public Property KSTNo() As String
        Get
            Return _strKSTNo
        End Get
        Set(ByVal Value As String)
            _strKSTNo = Value
        End Set
    End Property

    Public Property CSTNo() As String
        Get
            Return _strCSTNo
        End Get
        Set(ByVal Value As String)
            _strCSTNo = Value
        End Set
    End Property

    Public Property RegNo() As String
        Get
            Return _strRegNo
        End Get
        Set(ByVal Value As String)
            _strRegNo = Value
        End Set
    End Property

    Public Property RegDate() As Date
        Get
            Return _datRegDate
        End Get
        Set(ByVal Value As Date)
            _datRegDate = Value
        End Set
    End Property

    Public Property StartDate() As Date
        Get
            Return _datStartDate
        End Get
        Set(ByVal Value As Date)
            _datStartDate = Value
        End Set
    End Property

    Public Property ReportHeader() As String
        Get
            Return _strRepHeader
        End Get
        Set(ByVal Value As String)
            _strRepHeader = Value
        End Set
    End Property

    Public Property ReportSubHeader() As String
        Get
            Return _strRepSubHearder
        End Get
        Set(ByVal Value As String)
            _strRepSubHearder = Value
        End Set
    End Property
    Public Property president() As String
        Get
            Return _strPresident
        End Get
        Set(ByVal Value As String)
            _strPresident = Value
        End Set
    End Property
    Public Property Manager() As String
        Get
            Return _strManager
        End Get
        Set(ByVal Value As String)
            _strManager = Value
        End Set
    End Property
    Public Property BankTable() As DataTable
        Get
            Return _dtBankTable
        End Get
        Set(ByVal Value As DataTable)
            _dtBankTable = Value
        End Set
    End Property


    Public Property FinancialStart() As Date
        Get
            Return _dtpFinancialStart
        End Get
        Set(ByVal Value As Date)
            _dtpFinancialStart = Value
        End Set
    End Property

    Public Property FinancialEnd() As Date
        Get
            Return _dtpFinancialEnd
        End Get
        Set(ByVal Value As Date)
            _dtpFinancialEnd = Value
        End Set
    End Property


#End Region

#Region "Functions"

    Public Function fnGetBankDetails() As Boolean

        strSQL = "SELECT * FROM BankDetailsTbl "

        _dtBankTable = fnExecuteQuery(strSQL, 2)

        If _dtBankTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnUpdateBankDetails() As Boolean

        strSQL = "UPDATE BankDetailsTbl SET BankName='" & _strBankName & "',Address='" & _strAddress & "', "
        strSQL &= "PhoneNo1='" & _strPhoneNo1 & "', PhoneNo2='" & _strPhoneNo2 & "', KSTNo='" & _strKSTNo & "',"
        strSQL &= "CSTNo='" & _strCSTNo & "', RegNo='" & _strRegNo & "', RegDate='" & Format(_datRegDate, "yyyy-MM-dd") & "', "
        strSQL &= "StartDate='" & Format(_datStartDate, "yyyy-MM-dd") & "', RepHeader='" & _strRepHeader & "', RepSubHeader='" & _strRepSubHearder & "',"
        strSQL &= "President='" & _strPresident & "',Manager='" & _strManager & "',FinancialStart='" & Format(_dtpFinancialStart, "yyyy-MM-dd") & "',FinancialEnd='" & Format(_dtpFinancialEnd, "yyyy-MM-dd") & "',EmailId='" & _strEmailId & "',Website='" & _strWebsite & "'"
        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnInsertBankDetails() As Boolean
        strSQL = "INSERT INTO BankDetailsTbl(BanKName,Address,PhoneNo1,PhoneNo2,KSTNo,CSTNo,RegNo,RegDate,StartDate,RepHeader,RepSubHeader,President,Manager,FinancialStart,FinancialEnd,EmailId,Website)"
        strSQL &= "VALUES('" & _strBankName & "','" & _strAddress & "','" & _strPhoneNo1 & "','" & _strPhoneNo2 & "','" & _strKSTNo & "','" & _strCSTNo & "',"
        strSQL &= "'" & _strRegNo & "','" & Format(_datRegDate, "yyyy-MM-dd") & "','" & Format(_datStartDate, "yyyy-MM-dd") & "','" & _strRepHeader & "','" & _strRepSubHearder & "',"
        strSQL &= "'" & _strPresident & "','" & _strManager & "','" & Format(_dtpFinancialStart, "yyyy-MM-dd") & "','" & Format(_dtpFinancialEnd, "yyyy-MM-dd") & "','" & _strEmailId & "','" & _strWebsite & "')"
        Return fnExecuteNonQuery(strSQL)
    End Function

#End Region

End Class
