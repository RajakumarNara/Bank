Public Class MediumAssetDetCtrl
    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents txtServaeNo As BankControls.NumericControl
    Friend WithEvents txtAssetDetails As BankControls.TextControl
    Friend WithEvents txtType As BankControls.TextControl
    Friend WithEvents txtArea As BankControls.NumericControl
    Friend WithEvents txtOtheLoanDet As BankControls.TextControl
    Friend WithEvents txtOthers As BankControls.TextControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtServaeNo = New BankControls.NumericControl
        Me.txtAssetDetails = New BankControls.TextControl
        Me.txtType = New BankControls.TextControl
        Me.txtArea = New BankControls.NumericControl
        Me.txtOthers = New BankControls.TextControl
        Me.txtOtheLoanDet = New BankControls.TextControl
        Me.SuspendLayout()
        '
        'txtServaeNo
        '
        Me.txtServaeNo.AfterDecimal = 0
        Me.txtServaeNo.BeforeDecimal = 7
        Me.txtServaeNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServaeNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtServaeNo.Location = New System.Drawing.Point(128, 0)
        Me.txtServaeNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtServaeNo.MaxLength = 7
        Me.txtServaeNo.MaxValue = 100
        Me.txtServaeNo.MinValue = 0
        Me.txtServaeNo.Multiline = True
        Me.txtServaeNo.Name = "txtServaeNo"
        Me.txtServaeNo.Size = New System.Drawing.Size(72, 24)
        Me.txtServaeNo.TabIndex = 2
        Me.txtServaeNo.Text = ""
        '
        'txtAssetDetails
        '
        Me.txtAssetDetails.AlphaNumeric = True
        Me.txtAssetDetails.AutoSize = False
        Me.txtAssetDetails.BlankSpace = False
        Me.txtAssetDetails.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssetDetails.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAssetDetails.Location = New System.Drawing.Point(0, 0)
        Me.txtAssetDetails.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAssetDetails.Mandatory = False
        Me.txtAssetDetails.MaxLength = 80
        Me.txtAssetDetails.Multiline = True
        Me.txtAssetDetails.Name = "txtAssetDetails"
        Me.txtAssetDetails.Size = New System.Drawing.Size(128, 24)
        Me.txtAssetDetails.SpecialChar = True
        Me.txtAssetDetails.TabIndex = 1
        Me.txtAssetDetails.Text = ""
        '
        'txtType
        '
        Me.txtType.AlphaNumeric = True
        Me.txtType.AutoSize = False
        Me.txtType.BlankSpace = False
        Me.txtType.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtType.Location = New System.Drawing.Point(200, 0)
        Me.txtType.LostFocusColour = System.Drawing.Color.Empty
        Me.txtType.Mandatory = False
        Me.txtType.MaxLength = 80
        Me.txtType.Multiline = True
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(112, 24)
        Me.txtType.SpecialChar = True
        Me.txtType.TabIndex = 3
        Me.txtType.Text = ""
        '
        'txtArea
        '
        Me.txtArea.AfterDecimal = 0
        Me.txtArea.BeforeDecimal = 7
        Me.txtArea.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtArea.Location = New System.Drawing.Point(312, 0)
        Me.txtArea.LostFocusColour = System.Drawing.Color.Empty
        Me.txtArea.MaxLength = 7
        Me.txtArea.MaxValue = 100
        Me.txtArea.MinValue = 0
        Me.txtArea.Multiline = True
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(80, 24)
        Me.txtArea.TabIndex = 4
        Me.txtArea.Text = ""
        '
        'txtOthers
        '
        Me.txtOthers.AlphaNumeric = True
        Me.txtOthers.AutoSize = False
        Me.txtOthers.BlankSpace = False
        Me.txtOthers.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOthers.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOthers.Location = New System.Drawing.Point(536, 0)
        Me.txtOthers.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOthers.Mandatory = False
        Me.txtOthers.MaxLength = 100
        Me.txtOthers.Multiline = True
        Me.txtOthers.Name = "txtOthers"
        Me.txtOthers.Size = New System.Drawing.Size(144, 24)
        Me.txtOthers.SpecialChar = True
        Me.txtOthers.TabIndex = 6
        Me.txtOthers.Text = ""
        '
        'txtOtheLoanDet
        '
        Me.txtOtheLoanDet.AlphaNumeric = True
        Me.txtOtheLoanDet.AutoSize = False
        Me.txtOtheLoanDet.BlankSpace = False
        Me.txtOtheLoanDet.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtheLoanDet.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOtheLoanDet.Location = New System.Drawing.Point(392, 0)
        Me.txtOtheLoanDet.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOtheLoanDet.Mandatory = False
        Me.txtOtheLoanDet.MaxLength = 100
        Me.txtOtheLoanDet.Multiline = True
        Me.txtOtheLoanDet.Name = "txtOtheLoanDet"
        Me.txtOtheLoanDet.Size = New System.Drawing.Size(144, 24)
        Me.txtOtheLoanDet.SpecialChar = True
        Me.txtOtheLoanDet.TabIndex = 5
        Me.txtOtheLoanDet.Text = ""
        '
        'MediumAssetDetCtrl
        '
        Me.Controls.Add(Me.txtServaeNo)
        Me.Controls.Add(Me.txtAssetDetails)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.txtOthers)
        Me.Controls.Add(Me.txtOtheLoanDet)
        Me.Name = "MediumAssetDetCtrl"
        Me.Size = New System.Drawing.Size(680, 24)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Properties"

    Public Property AssetDetails() As BankControls.TextControl
        Get
            Return txtAssetDetails
        End Get
        Set(ByVal Value As BankControls.TextControl)
            txtAssetDetails = Value
        End Set
    End Property

    Public Property ServaeNo() As BankControls.NumericControl
        Get
            Return txtServaeNo
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            txtServaeNo = Value
        End Set
    End Property

    Public Property Type() As BankControls.TextControl
        Get
            Return txtType
        End Get
        Set(ByVal Value As BankControls.TextControl)
            txtType = Value
        End Set
    End Property

    Public Property Area() As BankControls.NumericControl
        Get
            Return txtArea
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            txtArea = Value
        End Set
    End Property

    Public Property OtherLoans() As BankControls.TextControl
        Get
            Return txtOtheLoanDet
        End Get
        Set(ByVal Value As BankControls.TextControl)
            txtOtheLoanDet = Value
        End Set
    End Property

    Public Property Others() As BankControls.TextControl
        Get
            Return txtOthers
        End Get
        Set(ByVal Value As BankControls.TextControl)
            txtOthers = Value
        End Set
    End Property

#End Region

End Class
