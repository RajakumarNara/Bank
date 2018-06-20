Public Class KisanControl
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
    Friend WithEvents txtHobli As BankControls.TextControl
    Friend WithEvents txtServaeNo As BankControls.NumericControl
    Friend WithEvents txtType As BankControls.TextControl
    Friend WithEvents txtArea As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtType = New BankControls.TextControl
        Me.txtHobli = New BankControls.TextControl
        Me.txtServaeNo = New BankControls.NumericControl
        Me.txtSlNo = New BankControls.NumericControl
        Me.txtArea = New BankControls.NumericControl
        Me.SuspendLayout()
        '
        'txtType
        '
        Me.txtType.AlphaNumeric = False
        Me.txtType.BlankSpace = False
        Me.txtType.GotFocusColour = System.Drawing.Color.Empty
        Me.txtType.Location = New System.Drawing.Point(336, 0)
        Me.txtType.LostFocusColour = System.Drawing.Color.Empty
        Me.txtType.Mandatory = False
        Me.txtType.MaxLength = 50
        Me.txtType.Multiline = True
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(152, 24)
        Me.txtType.SpecialChar = True
        Me.txtType.TabIndex = 4
        Me.txtType.Text = ""
        '
        'txtHobli
        '
        Me.txtHobli.AlphaNumeric = False
        Me.txtHobli.BlankSpace = False
        Me.txtHobli.GotFocusColour = System.Drawing.Color.Empty
        Me.txtHobli.Location = New System.Drawing.Point(48, 0)
        Me.txtHobli.LostFocusColour = System.Drawing.Color.Empty
        Me.txtHobli.Mandatory = False
        Me.txtHobli.MaxLength = 100
        Me.txtHobli.Multiline = True
        Me.txtHobli.Name = "txtHobli"
        Me.txtHobli.Size = New System.Drawing.Size(152, 24)
        Me.txtHobli.SpecialChar = True
        Me.txtHobli.TabIndex = 2
        Me.txtHobli.Text = ""
        '
        'txtServaeNo
        '
        Me.txtServaeNo.AfterDecimal = 2
        Me.txtServaeNo.BeforeDecimal = 7
        Me.txtServaeNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServaeNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtServaeNo.Location = New System.Drawing.Point(200, 0)
        Me.txtServaeNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtServaeNo.MaxLength = 6
        Me.txtServaeNo.MaxValue = 0
        Me.txtServaeNo.MinValue = 0
        Me.txtServaeNo.Multiline = True
        Me.txtServaeNo.Name = "txtServaeNo"
        Me.txtServaeNo.Size = New System.Drawing.Size(136, 24)
        Me.txtServaeNo.TabIndex = 3
        Me.txtServaeNo.Text = ""
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
        Me.txtSlNo.Multiline = True
        Me.txtSlNo.Name = "txtSlNo"
        Me.txtSlNo.Size = New System.Drawing.Size(48, 24)
        Me.txtSlNo.TabIndex = 1
        Me.txtSlNo.Text = ""
        '
        'txtArea
        '
        Me.txtArea.AfterDecimal = 2
        Me.txtArea.BeforeDecimal = 7
        Me.txtArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtArea.Location = New System.Drawing.Point(488, 1)
        Me.txtArea.LostFocusColour = System.Drawing.Color.Empty
        Me.txtArea.MaxLength = 6
        Me.txtArea.MaxValue = 0
        Me.txtArea.MinValue = 0
        Me.txtArea.Multiline = True
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(136, 23)
        Me.txtArea.TabIndex = 5
        Me.txtArea.Text = ""
        '
        'KisanControl
        '
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtHobli)
        Me.Controls.Add(Me.txtServaeNo)
        Me.Controls.Add(Me.txtSlNo)
        Me.Name = "KisanControl"
        Me.Size = New System.Drawing.Size(624, 24)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Properties"

    Public Property Hobli() As BankControls.TextControl
        Get
            Return txtHobli
        End Get
        Set(ByVal Value As BankControls.TextControl)
            txtHobli = Value
        End Set
    End Property

    Public Property servae() As BankControls.NumericControl
        Get
            Return txtServaeNo
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            txtServaeNo = Value
        End Set
    End Property

    Public Property type() As BankControls.TextControl
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

#End Region

End Class
