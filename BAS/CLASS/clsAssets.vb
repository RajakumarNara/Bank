Public Class clsAssets

#Region "Variables"

    'Fixed Assets
    Private _strLoanNo As String
    Private _intParticularId As Integer
    Private _strPType As String
    Private _strPTypeStatus As String
    Private _dtpYOP As Date
    Private _strSurveyOrHouseNo As String
    Private _strLocationAndBoundaries As String
    Private _strArea As String
    Private _strAcquiredStatus As String
    Private _dblPresentVal As Double
    Private _dblAmtIfBorrowed As Double
    Private _intSlNo As Integer

    Private _tblFixedAssets As DataTable

    'Movable Assets
    Private _dblAmtPaid As Double
    Private _dtpDueDate As Date

    Private _tblMovableAssets As DataTable

    Private _tblParticulars As DataTable

#End Region

#Region "Property"

    Public Property LoanNo() As String
        Get
            Return _strLoanNo
        End Get
        Set(ByVal Value As String)
            _strLoanNo = Value
        End Set
    End Property

    Public Property ParticularId() As Integer
        Get
            Return _intParticularId
        End Get
        Set(ByVal Value As Integer)
            _intParticularId = Value
        End Set
    End Property
    Public Property SlNo() As Integer
        Get
            Return _intSlNo
        End Get
        Set(ByVal Value As Integer)
            _intSlNo = Value
        End Set
    End Property

    Public Property Ptype() As String
        Get
            Return _strPType
        End Get
        Set(ByVal Value As String)
            _strPType = Value
        End Set
    End Property

    Public Property PTypeStatus() As String
        Get
            Return _strPTypeStatus
        End Get
        Set(ByVal Value As String)
            _strPTypeStatus = Value
        End Set
    End Property

    Public Property YOP() As Date
        Get
            Return _dtpYOP
        End Get
        Set(ByVal Value As Date)
            _dtpYOP = Value
        End Set
    End Property

    Public Property SurveyOrHouseNo() As String
        Get
            Return _strSurveyOrHouseNo
        End Get
        Set(ByVal Value As String)
            _strSurveyOrHouseNo = Value
        End Set
    End Property

    Public Property LocationAndBoundries() As String
        Get
            Return _strLocationAndBoundaries
        End Get
        Set(ByVal Value As String)
            _strLocationAndBoundaries = Value
        End Set
    End Property

    Public Property Area() As String
        Get
            Return _strArea
        End Get
        Set(ByVal Value As String)
            _strArea = Value
        End Set
    End Property

    Public Property AcquiredStatus() As String
        Get
            Return _strAcquiredStatus
        End Get
        Set(ByVal Value As String)
            _strAcquiredStatus = Value
        End Set
    End Property

    Public Property PresentValue() As Double
        Get
            Return _dblPresentVal
        End Get
        Set(ByVal Value As Double)
            _dblPresentVal = Value
        End Set
    End Property

    Public Property AmtIfBarrowed() As Double
        Get
            Return _dblAmtIfBorrowed
        End Get
        Set(ByVal Value As Double)
            _dblAmtIfBorrowed = Value
        End Set
    End Property

    Public Property FixedAssetsTable() As DataTable
        Get
            Return _tblFixedAssets
        End Get
        Set(ByVal Value As DataTable)
            _tblFixedAssets = Value
        End Set
    End Property

    Public Property MovableAssetsTable() As DataTable
        Get
            Return _tblMovableAssets
        End Get
        Set(ByVal Value As DataTable)
            _tblMovableAssets = Value
        End Set
    End Property

    Public Property AmountPaid() As Double
        Get
            Return _dblAmtPaid
        End Get
        Set(ByVal Value As Double)
            _dblAmtPaid = Value
        End Set
    End Property

    Public Property DueDate() As Date
        Get
            Return _dtpDueDate
        End Get
        Set(ByVal Value As Date)
            _dtpDueDate = Value
        End Set
    End Property

    Public Property ParticularsTable() As DataTable
        Get
            Return _tblParticulars
        End Get
        Set(ByVal Value As DataTable)
            _tblParticulars = Value
        End Set
    End Property
#End Region

#Region "Functions"

#Region "Fixed Assets Functions"

    Public Function fnGetFixedAsset(ByVal strLoanNo As String) As Boolean
        strSQL = "SELECT P.PName,FA.* FROM FixedAssetsTBL FA,particularstbl P where FA.LoanNo='" & strLoanNo & "' and P.PNo=FA.Particulars"
        _tblFixedAssets = fnExecuteQuery(strSQL, 2)
        If _tblFixedAssets.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnCheckFAsset() As Boolean
        strSQL = "SELECT * FROM FixedAssetsTBL where LoanNo='" & _strLoanNo & "'and slNo='" & _intSlNo & "'"
        _tblFixedAssets = fnExecuteQuery(strSQL, 2)
        If _tblFixedAssets.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnAddFAsset() As Boolean

        strSQL = "INSERT INTO FixedAssetsTBL(SlNo,LoanNo,Particulars,PType,PTypeStatus,YOP,SurveyOrHouseNo,LocationAndBoundaries,Area,AcquiredStatus,PresentVal,AmtIfBorrowed)"
        strSQL = strSQL & " Values('" & _intSlNo & "','" & _strLoanNo & "','" & _intParticularId & "','" & _strPType & "','" & _strPTypeStatus & "','" & Format(_dtpYOP, "yyyy-MM-dd") & "','"
        strSQL = strSQL & _strSurveyOrHouseNo & " ','" & _strLocationAndBoundaries & "','" & _strArea & "','" & _strAcquiredStatus & "','" & _dblPresentVal & "','" & _dblAmtIfBorrowed & "')"
        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnUpdateFAsset() As Boolean

        strSQL = "UPDATE FixedAssetsTBL SET Particulars='" & _intParticularId & "',PType= '" & _strPType & "',PTypeStatus='" & _strPTypeStatus & "',YOP='" & Format(_dtpYOP, "yyyy-MM-dd") & _
        "',SurveyOrHouseNo='" & _strSurveyOrHouseNo & "',LocationAndBoundaries='" & _strLocationAndBoundaries & "',Area='" & _strArea & "',AcquiredStatus='" & _strAcquiredStatus & "',PresentVal='" & _dblPresentVal & "',AmtIfBorrowed='" & _dblAmtIfBorrowed & _
         "' WHERE slNo='" & SlNo & "'AND loanNo='" & LoanNo & "'"
        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetNewFAssetNo(ByVal LoanNo As String) As Long
        Dim objFADT As New DataTable
        strSQL = "SELECt MAX(slNo) FROM FixedAssetsTBL where LoanNo='" & LoanNo & "'"
        objFADT = fnExecuteQuery(strSQL, 2)
        If objFADT.Rows.Count > 0 And IsDBNull(objFADT.Rows(0).Item(0)) Then
            Return 1
        Else
            Return objFADT.Rows(0).Item(0) + 1
        End If
    End Function


#End Region

#Region "Movable Assets Functions"

    Public Function fnGetMovableAsset(ByVal strLoanNo As String) As Boolean
        strSQL = "SELECT P.PName,MA.* FROM MovableAssetsTBL MA,particularstbl P where MA.LoanNo='" & strLoanNo & "' and P.PNo=MA.Particulars"
        _tblMovableAssets = fnExecuteQuery(strSQL, 2)
        If _tblMovableAssets.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnCheckMAsset() As Boolean
        strSQL = "SELECT * FROM MovableAssetsTBL where LoanNo='" & _strLoanNo & "'and slNo='" & _intSlNo & "'"
        _tblMovableAssets = fnExecuteQuery(strSQL, 2)
        If _tblMovableAssets.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnAddMAsset() As Boolean
        strSQL = "INSERT INTO MovableassetsTBL(SlNo,LoanNo,Particulars,YOP,AcquiredStatus,AmtPaid,PresentVal,DueDate,AmtIfBorrowed)"
        strSQL = strSQL & "Values('" & _intSlNo & "','" & _strLoanNo & "','" & _intParticularId & "','" & Format(_dtpYOP, "yyyy-MM-dd") & "','" & _strAcquiredStatus & "','" & _dblAmtPaid & "','" & _dblPresentVal & "','" & Format(_dtpDueDate, "yyyy-MM-dd") & "','" & _dblAmtIfBorrowed & "')"
        Return fnExecuteNonQuery(strSQL)
    End Function

    Public Function fnUpdateMAsset() As Boolean

        strSQL = "UPDATE MovableassetsTBL SET Particulars='" & _intParticularId & "', YOP='" & Format(_dtpYOP, "yyyy-MM-dd") & "',AcquiredStatus='" & _strAcquiredStatus & "',AmtPaid='" & _dblAmtPaid & "',PresentVal='" & _dblPresentVal & "',DueDate='" & Format(_dtpDueDate, "yyyy-MM-dd") & "',AmtIfBorrowed='" & _dblAmtIfBorrowed & "' WHERE slNo='" & SlNo & "'AND loanNo='" & LoanNo & "'"
        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetNewMAssetNo(ByVal loanNo As String) As Long
        Dim objMADT As New DataTable
        strSQL = "SELECT MAX(slNo) FROM MovableAssetsTBL WHERE LoanNo='" & loanNo & "'"
        objMADT = fnExecuteQuery(strSQL, 2)
        If objMADT.Rows.Count > 0 And IsDBNull(objMADT.Rows(0).Item(0)) Then
            Return 1
        Else
            Return objMADT.Rows(0).Item(0) + 1
        End If
    End Function

#End Region



    Public Function fnGetparticulars(ByVal PType As String) As Boolean
        strSQL = "SELECT * FROM ParticularsTBL where Type='" & PType & "' "
        _tblParticulars = fnExecuteQuery(strSQL, 2)
        If _tblParticulars.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

End Class
