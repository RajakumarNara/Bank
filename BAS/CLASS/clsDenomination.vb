Public Class clsDenomination

#Region "Variables"
    Private _intFiveHundread As Integer
    Private _intThousand As Integer
    Private _intHundread As Integer
    Private _intFifty As Integer
    Private _intTwenty As Integer
    Private _intTen As Integer
    Private _intFive As Integer
    Private _intTwo As Integer
    Private _intOne As Integer
    Private _intfiftyPaisae As Integer

    Private _dtDenomination As DataTable
#End Region

#Region "Property"

    Public Property FiveHundread() As Integer
        Get
            Return _intFiveHundread
        End Get
        Set(ByVal Value As Integer)
            _intFiveHundread = Value
        End Set
    End Property

    Public Property Thousand() As Integer
        Get
            Return _intThousand
        End Get
        Set(ByVal Value As Integer)
            _intThousand = Value
        End Set
    End Property

    Public Property Hundread() As Integer
        Get
            Return _intHundread
        End Get
        Set(ByVal Value As Integer)
            _intHundread = Value
        End Set
    End Property
    Public Property Fifty() As Integer
        Get
            Return _intFifty
        End Get
        Set(ByVal Value As Integer)
            _intFifty = Value
        End Set
    End Property
    Public Property Twenty() As Integer
        Get
            Return _intTwenty
        End Get
        Set(ByVal Value As Integer)
            _intTwenty = Value
        End Set
    End Property
    Public Property Ten() As Integer
        Get
            Return _intTen
        End Get
        Set(ByVal Value As Integer)
            _intTen = Value
        End Set
    End Property
    Public Property Five() As Integer
        Get
            Return _intFive
        End Get
        Set(ByVal Value As Integer)
            _intFive = Value
        End Set
    End Property
    Public Property Two() As Integer
        Get
            Return _intTwo
        End Get
        Set(ByVal Value As Integer)
            _intTwo = Value
        End Set
    End Property
    Public Property One() As Integer
        Get
            Return _intOne
        End Get
        Set(ByVal Value As Integer)
            _intOne = Value
        End Set
    End Property
    Public Property FiftyPai() As Integer
        Get
            Return _intfiftyPaisae
        End Get
        Set(ByVal Value As Integer)
            _intfiftyPaisae = Value
        End Set
    End Property

    Public Property DenominationTable() As DataTable
        Get
            Return _dtDenomination
        End Get
        Set(ByVal Value As DataTable)
            _dtDenomination = Value
        End Set
    End Property

#End Region

End Class
