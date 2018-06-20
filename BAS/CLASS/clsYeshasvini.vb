Public Class clsYeshasvini
    Inherits clsFamilyDetails

#Region "Variables"
    Private _lngNo As Long
    Private _strAccountNo As String
    Private _strYeshasviniNo As String
    Private _intNoOfMembers As Integer
    Private _dblSchemesFee As Double
    Private _dblBankCharges As Double
    Private _dblTotal As Double

    Private _dtYeshasviniTable As DataTable

#End Region

#Region "Property"
    Public Property Yeshno() As String
        Get
            Return _lngNo
        End Get
        Set(ByVal Value As String)
            _lngNo = Value
        End Set
    End Property

    Public Property YeshAccountNo() As String
        Get
            Return _strAccountNo
        End Get
        Set(ByVal Value As String)
            _strAccountNo = Value
        End Set
    End Property

    Public Property YeshasviniNo() As String
        Get
            Return _strYeshasviniNo
        End Get
        Set(ByVal Value As String)
            _strYeshasviniNo = Value
        End Set
    End Property

    Public Property NoOfMembers() As String
        Get
            Return _intNoOfMembers
        End Get
        Set(ByVal Value As String)
            _intNoOfMembers = Value
        End Set
    End Property

    Public Property schemeFee() As Double
        Get
            Return _dblSchemesFee
        End Get
        Set(ByVal Value As Double)
            _dblSchemesFee = Value
        End Set
    End Property
    Public Property BankCharges() As Double
        Get
            Return _dblBankCharges
        End Get
        Set(ByVal Value As Double)
            _dblBankCharges = Value
        End Set
    End Property
    Public Property Total() As Double
        Get
            Return _dblTotal
        End Get
        Set(ByVal Value As Double)
            _dblTotal = Value
        End Set
    End Property

    Public Property YeshasviniTable() As DataTable
        Get
            Return _dtYeshasviniTable
        End Get
        Set(ByVal Value As DataTable)
            _dtYeshasviniTable = Value
        End Set
    End Property

#End Region

#Region "functions"
    Public Function fnGetYeshasvini(ByVal StrAccountNo As String) As Boolean
        strSQL = "SELECT Y.* FROM YeshasviniTbl y Where AccountNo='" & StrAccountNo & "'"
        _dtYeshasviniTable = fnExecuteQuery(strSQL, 2)
        If _dtYeshasviniTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnCheckYeshasvini(ByVal YeshNo As String, ByVal StrAccountNo As String)

        strSQL = "SELECT * FROM yeshasvinitbl where AccountNo='" & StrAccountNo & "' and YeshasviniNo='" & YeshNo & "'"

        _dtYeshasviniTable = fnExecuteQuery(strSQL, 2)

        If _dtYeshasviniTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function fnUpdateYeshasvini() As Boolean

        'strSQL = "UPDATE YeshasviniTbl SET NoOfMembers='" & _intNoOfMembers & _
        '        "',SchemesFee='" & _dblSchemesFee & "',BankCharges='" & _dblBankCharges & "',TotalFee='" & _dblTotal & _
        '        " 'WHERE YeshasviniNo='" & _strYeshasviniNo & "' and AccountNo='" & _strAccountNo & "' "
        'If fnExecuteNonQuery(strSQL) Then
        '    Return fnUpdateImages()
        'Else
        '    Return False
        'End If

    End Function

    Public Function fnAddYeshasvini() As Boolean

        'strSQL = "INSERT INTO FamilydetailTbl(AccountNo,YeshasviniNo,NoOfMembers,SchemesFee,BankCharges,TotalFee) VALUES('" & _
        ' _strAccountNo & "','" & _strYeshasviniNo & "','" & _intNoOfMembers & " ','" & _dblSchemesFee & "','" & _dblBankCharges & "','" & _dblTotal & "')"

        'If fnExecuteNonQuery(strSQL) Then
        '    Return fnUpdateImages()
        'Else
        '    Return False
        'End If

    End Function
#End Region
End Class
