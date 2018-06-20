Public Class MediumCtrl
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
    Friend WithEvents txtSlNo As BankControls.NumericControl
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents txtAreaOfLeaving As BankControls.TextControl
    Friend WithEvents txtRelationship As BankControls.TextControl
    Friend WithEvents txtAge As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtName = New BankControls.TextControl
        Me.txtSlNo = New BankControls.NumericControl
        Me.txtAreaOfLeaving = New BankControls.TextControl
        Me.txtRelationship = New BankControls.TextControl
        Me.txtAge = New BankControls.NumericControl
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.BlankSpace = False
        Me.txtName.GotFocusColour = System.Drawing.Color.Empty
        Me.txtName.Location = New System.Drawing.Point(56, 0)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(296, 20)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 2
        Me.txtName.Text = ""
        '
        'txtSlNo
        '
        Me.txtSlNo.AfterDecimal = 2
        Me.txtSlNo.BeforeDecimal = 7
        Me.txtSlNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSlNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSlNo.Location = New System.Drawing.Point(0, 0)
        Me.txtSlNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSlNo.MaxLength = 2
        Me.txtSlNo.MaxValue = 0
        Me.txtSlNo.MinValue = 0
        Me.txtSlNo.Name = "txtSlNo"
        Me.txtSlNo.Size = New System.Drawing.Size(56, 22)
        Me.txtSlNo.TabIndex = 1
        Me.txtSlNo.Text = ""
        '
        'txtAreaOfLeaving
        '
        Me.txtAreaOfLeaving.AlphaNumeric = False
        Me.txtAreaOfLeaving.BlankSpace = False
        Me.txtAreaOfLeaving.GotFocusColour = System.Drawing.Color.Empty
        Me.txtAreaOfLeaving.Location = New System.Drawing.Point(560, 0)
        Me.txtAreaOfLeaving.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAreaOfLeaving.Mandatory = False
        Me.txtAreaOfLeaving.MaxLength = 50
        Me.txtAreaOfLeaving.Name = "txtAreaOfLeaving"
        Me.txtAreaOfLeaving.Size = New System.Drawing.Size(128, 20)
        Me.txtAreaOfLeaving.SpecialChar = True
        Me.txtAreaOfLeaving.TabIndex = 5
        Me.txtAreaOfLeaving.Text = ""
        '
        'txtRelationship
        '
        Me.txtRelationship.AlphaNumeric = False
        Me.txtRelationship.BlankSpace = False
        Me.txtRelationship.GotFocusColour = System.Drawing.Color.Empty
        Me.txtRelationship.Location = New System.Drawing.Point(424, 0)
        Me.txtRelationship.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRelationship.Mandatory = False
        Me.txtRelationship.MaxLength = 50
        Me.txtRelationship.Name = "txtRelationship"
        Me.txtRelationship.Size = New System.Drawing.Size(136, 20)
        Me.txtRelationship.SpecialChar = True
        Me.txtRelationship.TabIndex = 4
        Me.txtRelationship.Text = ""
        '
        'txtAge
        '
        Me.txtAge.AfterDecimal = 2
        Me.txtAge.BeforeDecimal = 7
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAge.Location = New System.Drawing.Point(352, 0)
        Me.txtAge.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAge.MaxLength = 2
        Me.txtAge.MaxValue = 0
        Me.txtAge.MinValue = 0
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(72, 22)
        Me.txtAge.TabIndex = 3
        Me.txtAge.Text = ""
        '
        'MediumCtrl
        '
        Me.Controls.Add(Me.txtSlNo)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtAreaOfLeaving)
        Me.Controls.Add(Me.txtRelationship)
        Me.Controls.Add(Me.txtAge)
        Me.Name = "MediumCtrl"
        Me.Size = New System.Drawing.Size(688, 24)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Properties"

    Public Property slno() As BankControls.NumericControl
        Get
            Return txtSlNo
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            txtSlNo = Value
        End Set
    End Property

    Public Property RelationName() As BankControls.TextControl
        Get
            Return txtName
        End Get
        Set(ByVal Value As BankControls.TextControl)
            txtName = Value
        End Set
    End Property

    Public Property Age() As BankControls.NumericControl
        Get
            Return txtAge
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            txtAge = Value
        End Set
    End Property

    Public Property Relationship() As BankControls.TextControl
        Get
            Return txtRelationship
        End Get
        Set(ByVal Value As BankControls.TextControl)
            txtRelationship = Value
        End Set
    End Property

    Public Property AreaOfLeaving() As BankControls.TextControl
        Get
            Return txtAreaOfLeaving
        End Get
        Set(ByVal Value As BankControls.TextControl)
            txtAreaOfLeaving = Value
        End Set
    End Property

#End Region

End Class
