Public Class clsCBPDet

#Region "Private Variables"
    Private _strCBPNo As String
    Private _strSBNo As String
    Private _lngPersonNo As Long
    Private _datDepositdate As Date
    Private _strChequeNo As String
    Private _dtpChequeDate As Date
    Private _dtpChequeClearedDate As Date
    Private _dblChequeAmount As Double
    Private _chrChequeType As Char
    Private _strBankDetail As String
    Private _dblComPercent As Double
    Private _dblROI As Double
    Private _dblInterest As Double
    Private _dblCommission As Double
    Private _dblPostalCharge As Double
    Private _dblOtherCharges As Double
    Private _dblAmount As Double
    Private _chrStatus As Char
    Private _strRefNo As String
    Private _strRemarks As String
    Private _strAccType As String
    Private _strName As String

    Private _dtCBdetailsTable As DataTable
    Private _dtCBPDetail As DataTable
    Private _dtCBPtable As DataTable

#End Region

#Region "public property "

    Public Property CBPNo() As String
        Get
            Return _strCBPNo
        End Get
        Set(ByVal Value As String)
            _strCBPNo = Value
        End Set
    End Property

    Public Property SBNo() As String
        Get
            Return _strSBNo
        End Get
        Set(ByVal Value As String)
            _strSBNo = Value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return _strName
        End Get
        Set(ByVal Value As String)
            _strName = Value
        End Set
    End Property

    Public Property PersonNo() As Long
        Get
            Return _lngPersonNo
        End Get
        Set(ByVal Value As Long)
            _lngPersonNo = Value
        End Set
    End Property

    Public Property DepositDate() As Date
        Get
            Return _datDepositdate
        End Get
        Set(ByVal Value As Date)
            _datDepositdate = Value
        End Set
    End Property

    Public Property ChequeNo() As String
        Get
            Return _strChequeNo
        End Get
        Set(ByVal Value As String)
            _strChequeNo = Value
        End Set
    End Property

    Public Property ChequeDate() As Date
        Get
            Return _dtpChequeDate
        End Get
        Set(ByVal Value As Date)
            _dtpChequeDate = Value
        End Set
    End Property
    Public Property ChequeClearedDate() As Date
        Get
            Return _dtpChequeClearedDate
        End Get
        Set(ByVal Value As Date)
            _dtpChequeClearedDate = Value
        End Set
    End Property

    Public Property ChequeAmount() As Double
        Get
            Return _dblChequeAmount
        End Get
        Set(ByVal Value As Double)
            _dblChequeAmount = Value
        End Set
    End Property

    Public Property ChequeType() As Char
        Get
            Return _chrChequeType
        End Get
        Set(ByVal Value As Char)
            _chrChequeType = Value
        End Set
    End Property

    Public Property BankDetail() As String
        Get
            Return _strBankDetail
        End Get
        Set(ByVal Value As String)
            _strBankDetail = Value
        End Set
    End Property

    Public Property ComPercent() As Double
        Get
            Return _dblComPercent
        End Get
        Set(ByVal Value As Double)
            _dblComPercent = Value
        End Set
    End Property

    Public Property ROI() As Double
        Get
            Return _dblROI
        End Get
        Set(ByVal Value As Double)
            _dblROI = Value
        End Set
    End Property

    Public Property Interest() As Double
        Get
            Return _dblInterest
        End Get
        Set(ByVal Value As Double)
            _dblInterest = Value
        End Set
    End Property

    Public Property Commission() As Double
        Get
            Return _dblCommission
        End Get
        Set(ByVal Value As Double)
            _dblCommission = Value
        End Set
    End Property

    Public Property PostalCharges() As Double
        Get
            Return _dblPostalCharge
        End Get
        Set(ByVal Value As Double)
            _dblPostalCharge = Value
        End Set
    End Property

    Public Property OtherCharge() As Double
        Get
            Return _dblOtherCharges
        End Get
        Set(ByVal Value As Double)
            _dblOtherCharges = Value
        End Set
    End Property

    Public Property Amount() As Double
        Get
            Return _dblAmount
        End Get
        Set(ByVal Value As Double)
            _dblAmount = Value
        End Set
    End Property

    Public Property Status() As Char
        Get
            Return _chrStatus
        End Get
        Set(ByVal Value As Char)
            _chrStatus = Value
        End Set
    End Property

    Public Property RefNo() As String
        Get
            Return _strRefNo
        End Get
        Set(ByVal Value As String)
            _strRefNo = Value
        End Set
    End Property

    Public Property Remarks() As String
        Get
            Return _strRemarks
        End Get
        Set(ByVal Value As String)
            _strRemarks = Value
        End Set
    End Property

    Public Property AccType() As String
        Get
            Return _strAccType
        End Get
        Set(ByVal Value As String)
            _strAccType = Value
        End Set
    End Property

    Public Property CBPTables() As DataTable
        Get
            Return _dtCBPtable
        End Get
        Set(ByVal Value As DataTable)
            _dtCBPtable = Value
        End Set
    End Property

    Public Property CBPdetail() As DataTable
        Get
            Return _dtCBPDetail
        End Get
        Set(ByVal Value As DataTable)
            _dtCBPDetail = Value
        End Set
    End Property



#End Region

#Region "Function"



#End Region

    Public Function fnADDCBP() As Boolean


    End Function

    Public Function fnGetCBPDetails(ByVal strCBPNo As String) As Boolean
        strSQL = "SELECT S.* FROM cbpdetailstbl S where S.AccountNo='" & strCBPNo & "'"
        _dtCBPDetail = fnExecuteQuery(strSQL, 2)
        If _dtCBPDetail.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnAddData(ByVal objTrans As IDbTransaction) As Boolean
        strSQL = "INSERT INTO CBPDetailsTbl(AccountNo,TrAccNo,Name,DepositDate,ChequeNo,ChequeDate,ChequeAmount,ChequrType,BankDetail,CommPercent,ROI,IntAmount,Commission,PostalCharge,OtherCharge,ClearingDate,ChequeStatus,DReceiptNo,Remark)"
        strSQL &= "VALUES('" & _strCBPNo & "','" & _strSBNo & "','" & _strName & "','" & Format(_datDepositdate, "yyyy-MM-dd") & "','" & _strChequeNo & "','" & Format(_dtpChequeDate, "yyyy-MM-dd") & "','" & _dblChequeAmount & "','" & _chrChequeType & "',"
        strSQL &= "'" & _strBankDetail & "','" & _dblComPercent & "','" & _dblROI & "','" & _dblInterest & "','" & _dblCommission & "','" & _dblPostalCharge & "','" & _dblOtherCharges & "','" & Format(_dtpChequeClearedDate, "yyyy-MM-dd") & "','" & _chrStatus & "','" & _strRefNo & "','" & _strRemarks & "' )"
        If fnExecuteNonQuery(strSQL, objTrans) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnUpdateDVoucherNo(ByVal lngVoucherNo As Long, ByVal objTrans As IDbTransaction) As Boolean
        strSQL = "UPDATE CBPDetailsTbl SET DVoucherNo='" & lngVoucherNo & "' where AccountNo='" & _strCBPNo & "'"
        If fnExecuteNonQuery(strSQL, objTrans) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnUpdateCVoucherNo(ByVal lngVoucherNo As Long, ByVal objTrans As IDbTransaction) As Boolean
        strSQL = "UPDATE CBPDetailsTbl SET ClearingDate='" & Format(_dtpChequeClearedDate, "yyyy-MM-dd") & "',ChequeStatus='C',CReceiptNo='" & _strRefNo & "',CVoucherNo='" & lngVoucherNo & "' where AccountNo='" & _strCBPNo & "'"
        If fnExecuteNonQuery(strSQL, objTrans) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnGetCBPTable() As Boolean

        strSQL = "SELECT CBP.* FROM CBPDetailsTbl CBP WHERE CBP.ChequeStatus= 'P' "

        _dtCBPDetail = fnExecuteQuery(strSQL, 2)

        If _dtCBPDetail.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnGetCBPDetail() As Boolean

        strSQL = "SELECT CBP.* FROM CBPDetailsTbl CBP  Where ChequeStatus='C'"

        _dtCBPDetail = fnExecuteQuery(strSQL, 2)

        If _dtCBPDetail.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function fnGetCBPPendingDetail() As Boolean

        strSQL = "SELECT AccountNo,Name,TrAccNO,ChequeNo,ChequeAmount,DepositDate,BankDetail FROM CBPDetailsTbl CBP Where ChequeStatus='P' "

        _dtCBPDetail = fnExecuteQuery(strSQL, 2)

        If _dtCBPDetail.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnGetNewLoanNo(ByVal str As String) As String

        strSQL = " SELECT max(AccountNo) as MaxNo FROM cbpdetailstbl where AccountNo like '" & str & "%' "

        _dtCBdetailsTable = fnExecuteQuery(strSQL, 2)

        If IsDBNull(_dtCBdetailsTable.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return _dtCBdetailsTable.Rows(0).Item("MaxNo")
        End If

    End Function


End Class
