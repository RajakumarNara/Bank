Public Class clsOrganizationDetail
    Inherits clsPerson

#Region "variables"
    Private _lngOrgNo As Long
    Private _strOrgName As String
    Private _strOrgType As String
    Private _datYearOfEst As Date
    Private _intYearOfExistance As Integer
    Private _strNatureOfBusiness As String
    Private _strKSTNo As String
    Private _strCSTNo As String
    Private _strRegNo As String
    Private _datRegDate As Date
    Private _strMobileNo As String
    Private _strAddr As String
    Private _intVillageCode As Integer
    Private _strPhoneNo1 As String
    Private _strPhoneNo2 As String
    Private _datPartnerShipDeedDate As Date
    Private _datResolutationDate As Date
    Private _dtOrgTable As DataTable
#End Region

#Region "Propertys"
    Public Property OrganizationNo() As Long
        Get
            Return _lngOrgNo
        End Get
        Set(ByVal Value As Long)
            _lngOrgNo = Value
        End Set
    End Property
    Public Property YerarOfExistance() As Integer
        Get
            Return _intYearOfExistance
        End Get
        Set(ByVal Value As Integer)
            _intYearOfExistance = Value
        End Set
    End Property
    Public Property OrganizationName() As String
        Get
            Return _strOrgName
        End Get
        Set(ByVal Value As String)
            _strOrgName = Value
        End Set
    End Property
    Public Property OrganizationType() As String
        Get
            Return _strOrgType
        End Get
        Set(ByVal Value As String)
            _strOrgType = Value
        End Set
    End Property
    Public Property YearOfEstablishment() As Date
        Get
            Return _datYearOfEst
        End Get
        Set(ByVal Value As Date)
            _datYearOfEst = Value
        End Set
    End Property
    Public Property NatureOfBusiness() As String
        Get
            Return _strNatureOfBusiness
        End Get
        Set(ByVal Value As String)
            _strNatureOfBusiness = Value
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
    Public Property Address() As String
        Get
            Return _strAddr
        End Get
        Set(ByVal Value As String)
            _strAddr = Value
        End Set
    End Property
    Public Property VillageCode() As Integer
        Get
            Return _intVillageCode
        End Get
        Set(ByVal Value As Integer)
            _intVillageCode = Value
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

    Public Property OrgMobileNo() As String
        Get
            Return _strMobileNo
        End Get
        Set(ByVal Value As String)
            _strMobileNo = Value
        End Set
    End Property
    Public Property PDeedDate() As Date
        Get
            Return _datPartnerShipDeedDate
        End Get
        Set(ByVal Value As Date)
            _datPartnerShipDeedDate = Value
        End Set
    End Property
    Public Property ResolutationDate() As Date
        Get
            Return _datResolutationDate
        End Get
        Set(ByVal Value As Date)
            _datResolutationDate = Value
        End Set
    End Property
    Public Property Organization() As DataTable
        Get
            Return _dtOrgTable
        End Get
        Set(ByVal Value As DataTable)
            _dtOrgTable = Value
        End Set
    End Property


#End Region

#Region "function"

    Public Function fnGetNewOrganizationNo() As Long

        Dim objDT As New DataTable

        strSQL = "SELECT MAX(OrganizationNo) from organizationtbl "

        objDT = fnExecuteQuery(strSQL, 2)

        If objDT.Rows.Count > 0 And IsDBNull(objDT.Rows(0).Item(0)) Then
            Return 1
        Else
            Return objDT.Rows(0).Item(0) + 1
        End If
    End Function

    Public Function fnAddOrganization(ByVal objTrans As IDbTransaction) As Boolean
        strSQL = "INSERT INTO organizationtbl(OrganizationNo,Name,OrgType,YearOfEstab,NatureOfBusiness,KSTNo,CSTNo,RegNo,RegDate,Address,PhoneNo1,PhoneNo2,MobileNo,PDeedDated,ResolutationDated) VALUES(" & _lngOrgNo & ",'" & _strOrgName & "','" & _strOrgType & "','"
        strSQL = strSQL & Format(_datYearOfEst, "yyyy-MM-dd") & "','" & _strNatureOfBusiness & "','" & _strKSTNo & "','" & _strCSTNo & "','" & _strRegNo & "','" & Format(_datRegDate, "yyyy-MM-dd") & "','" & _strAddr & "','"
        strSQL = strSQL & _strPhoneNo1 & "','" & _strPhoneNo2 & "','" & _strMobileNo & "','" & Format(_datPartnerShipDeedDate, "yyyy-MM-dd") & "','" & Format(_datResolutationDate, "yyyy-MM-dd") & "') "
        If fnExecuteNonQuery(strSQL, objTrans) Then
            Return True
            '            Return fnUpdateImages()
        Else
            Return False
        End If
    End Function

    Public Function fnDeleteOrganization() As Boolean
        strSQL = "DELETE  FROM PersonTbl WHERE OrganizationNo='" & _lngOrgNo & "'"
        Return fnExecuteNonQuery(strSQL)
    End Function

    Public Function fnCheckOrganization() As Boolean

        strSQL = "SELECT * FROM OrganizationTbl WHERE OrganizationNo='" & _lngOrgNo & "'"
        _dtOrgTable = fnExecuteQuery(strSQL, 2)
        If _dtOrgTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnUpdateOrganization(ByVal objTrans As IDbTransaction) As Boolean

        strSQL = "UPDATE OrganizationTbl SET Name='" & _strOrgName & "', OrgType='" & _strOrgType & "', YearOfEstab='" & Format(_datYearOfEst, "yyyy-MM-dd") & "', "
        strSQL = strSQL & "NatureOfBusiness='" & _strNatureOfBusiness & "',KSTNo='" & _strKSTNo & "',CSTNo='" & _strCSTNo & "',RegNo='" & _strRegNo & "',RegDate='" & Format(_datRegDate, "yyyy-MM-dd") & "', Address ='" & _strAddr & "', PhoneNo1='" & _strPhoneNo1 & "',PhoneNo2='" & _strPhoneNo2 & "',"
        strSQL = strSQL & "MobileNo='" & _strMobileNo & "',PDeedDated='" & Format(_datPartnerShipDeedDate, "yyyy-MM-dd") & "',ResolutationDated='" & Format(_datResolutationDate, "yyyy-MM-dd") & "' WHERE OrganizationNo='" & _lngOrgNo & "'"
        If fnExecuteNonQuery(strSQL, objTrans) Then
            Return True
        Else
            Return False
        End If

    End Function

#End Region


End Class
