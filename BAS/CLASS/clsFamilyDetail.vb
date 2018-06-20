Public Class clsFamilyDetail
    Inherits clsPerson

#Region "Variables"

    Private _strAccountNo As String
    Private _chrFamilyType As Char
    Private _strGrandfather As String
    Private _strGrandmother As String
    Private _strFather As String
    Private _strMother As String
    Private _strSpouse As String
    Private _strCName As String
    Private _intCAge As Integer
    Private _chrCGender As Char
    Private _strKinName As String
    Private _intKinAge As Integer
    Private _chrKinGender As Char

    Private _tblFamilyTable As DataTable
    Private _FamTable As DataTable

#End Region

#Region "properties"

    Public Property AccountNo() As String
        Get
            Return _strAccountNo
        End Get
        Set(ByVal Value As String)
            _strAccountNo = Value
        End Set
    End Property
    Public Property FamilyType() As Char
        Get
            Return _chrFamilyType
        End Get
        Set(ByVal Value As Char)
            _chrFamilyType = Value
        End Set
    End Property

    Public Property GrandFather() As String
        Get
            Return _strGrandfather
        End Get
        Set(ByVal Value As String)
            _strGrandfather = Value
        End Set
    End Property

    Public Property GrandMother() As String
        Get
            Return _strGrandmother
        End Get
        Set(ByVal Value As String)
            _strGrandmother = Value
        End Set
    End Property

    Public Property Father() As String
        Get
            Return _strFather
        End Get
        Set(ByVal Value As String)
            _strFather = Value
        End Set
    End Property

    Public Property Mother() As String
        Get
            Return _strMother
        End Get
        Set(ByVal Value As String)
            _strMother = Value
        End Set
    End Property

    Public Property Spouse() As String
        Get
            Return _strSpouse
        End Get
        Set(ByVal Value As String)
            _strSpouse = Value
        End Set
    End Property

    Public Property CName() As String
        Get
            Return _strCName
        End Get
        Set(ByVal Value As String)
            _strCName = Value
        End Set
    End Property

    Public Property CAge() As Integer
        Get
            Return _intCAge
        End Get
        Set(ByVal Value As Integer)
            _intCAge = Value
        End Set
    End Property

    Public Property CGender() As Char
        Get
            Return _chrCGender
        End Get
        Set(ByVal Value As Char)
            _chrCGender = Value
        End Set
    End Property


    Public Property KinName() As String
        Get
            Return _strKinName
        End Get
        Set(ByVal Value As String)
            _strKinName = Value
        End Set
    End Property

    Public Property KinAge() As Integer
        Get
            Return _intKinAge
        End Get
        Set(ByVal Value As Integer)
            _intKinAge = Value
        End Set
    End Property

    Public Property KinGender() As Char
        Get
            Return _chrKinGender
        End Get
        Set(ByVal Value As Char)
            _chrKinGender = Value
        End Set
    End Property



    Public Property FamilyTable() As DataTable
        Get
            Return _tblFamilyTable
        End Get
        Set(ByVal Value As DataTable)
            _tblFamilyTable = Value
        End Set
    End Property


    Public Property FamTable() As DataTable
        Get
            Return _FamTable
        End Get
        Set(ByVal Value As DataTable)
            _FamTable = Value
        End Set
    End Property

#End Region

#Region "function"


    Public Function fnGetChildren() As Boolean

        strSQL = "select c.* from childtbl c where  c.AccountNo='" & _strAccountNo & "'"
        _FamTable = fnExecuteQuery(strSQL, 2)
        If _FamTable.Rows.Count > 0 Then
            Return True
        End If
        Return False

    End Function

    Public Function fninsertChildren() As Boolean

        strSQL = "insert into childtbl(AccountNo,Name,Age,gender) values ('" & _strAccountNo & "','" & _strCName & "','" & _intCAge & "','" & _chrCGender & "')"
        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnGetFamily() As Boolean

        strSQL = "select  F.* from familydetailstbl F where F.AccountNo=  '" & _strAccountNo & "'"
        _tblFamilyTable = fnExecuteQuery(strSQL, 2)
        If _tblFamilyTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If


    End Function

    Public Function fnGetKin() As Boolean

        strSQL = "select K.* from KinTbl K where K.AccountNo='" & _strAccountNo & "'"
        _FamTable = fnExecuteQuery(strSQL, 2)
        If _FamTable.Rows.Count > 0 Then
            Return True
        End If
        Return False

    End Function

    Public Function fninsertKin() As Boolean

        strSQL = "insert into Kintbl(AccountNo,Name,Age,gender) values ('" & _strAccountNo & "','" & _strKinName & "','" & _intKinAge & "','" & _chrKinGender & "')"
        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnInsertFamily() As Boolean

        strSQL = "insert into FamilydetailsTbl(AccountNo,FamilyType,GrandFather,GrandMother,Mother,Spouse,Father) values ('" & _strAccountNo & "','" & _chrFamilyType & "','" & _strGrandfather & "','" & _strGrandmother & "','" & _strMother & "','" & _strSpouse & "','" & _strFather & "')"
        Return fnExecuteNonQuery(strSQL)

    End Function

    Public Function fnCheckFamily() As Boolean
        strSQL = "select F.* from FamilydetailsTbl F where F.AccountNo='" & _strAccountNo & "'"
        _tblFamilyTable = fnExecuteQuery(strSQL, 2)
        If _tblFamilyTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fnUpdateFamily() As Boolean
        strSQL = "Update FamilydetailsTbl set AccountNo='" & _strAccountNo & "',FamilyType='" & _chrFamilyType & "',GrandFather='" & _strGrandfather & "',GrandMother='" & _strGrandmother & "',Mother='" & _strMother & "',Spouse='" & _strSpouse & "',Father='" & _strFather & "' "
        Return fnExecuteNonQuery(strSQL)
    End Function
    Public Function fnDel(ByVal person As String)
        strSQL = "delete from childtbl where AccountNo='" & _strAccountNo & "'and Name='" & person & "' "
        Return fnExecuteNonQuery(strSQL)
    End Function

    Public Function fnBroDel(ByVal person As String)
        strSQL = "delete from kintbl where AccountNo='" & _strAccountNo & "'and Name='" & person & "' "
        Return fnExecuteNonQuery(strSQL)
    End Function
#End Region



End Class
