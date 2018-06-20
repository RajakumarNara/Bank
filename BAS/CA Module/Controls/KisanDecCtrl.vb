Public Class KisanDecCtrl
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
    Friend WithEvents txtExpected As BankControls.NumericControl
    Friend WithEvents txtArea As BankControls.NumericControl
    Friend WithEvents txtCrop As BankControls.TextControl
    Friend WithEvents txtEstimate As BankControls.NumericControl
    Friend WithEvents txtRemarks As BankControls.TextControl
    Friend WithEvents txtWetDet As BankControls.TextControl
    Friend WithEvents txtServaeNo As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtExpected = New BankControls.NumericControl
        Me.txtCrop = New BankControls.TextControl
        Me.txtArea = New BankControls.NumericControl
        Me.txtEstimate = New BankControls.NumericControl
        Me.txtRemarks = New BankControls.TextControl
        Me.txtWetDet = New BankControls.TextControl
        Me.txtServaeNo = New BankControls.NumericControl
        Me.SuspendLayout()
        '
        'txtExpected
        '
        Me.txtExpected.AfterDecimal = 2
        Me.txtExpected.BeforeDecimal = 7
        Me.txtExpected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpected.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtExpected.Location = New System.Drawing.Point(360, 0)
        Me.txtExpected.LostFocusColour = System.Drawing.Color.Empty
        Me.txtExpected.MaxLength = 6
        Me.txtExpected.MaxValue = 0
        Me.txtExpected.MinValue = 0
        Me.txtExpected.Multiline = True
        Me.txtExpected.Name = "txtExpected"
        Me.txtExpected.Size = New System.Drawing.Size(80, 24)
        Me.txtExpected.TabIndex = 5
        Me.txtExpected.Text = ""
        '
        'txtCrop
        '
        Me.txtCrop.AlphaNumeric = False
        Me.txtCrop.BlankSpace = False
        Me.txtCrop.GotFocusColour = System.Drawing.Color.Empty
        Me.txtCrop.Location = New System.Drawing.Point(144, 0)
        Me.txtCrop.LostFocusColour = System.Drawing.Color.Empty
        Me.txtCrop.Mandatory = False
        Me.txtCrop.MaxLength = 50
        Me.txtCrop.Multiline = True
        Me.txtCrop.Name = "txtCrop"
        Me.txtCrop.Size = New System.Drawing.Size(136, 24)
        Me.txtCrop.SpecialChar = True
        Me.txtCrop.TabIndex = 3
        Me.txtCrop.Text = ""
        '
        'txtArea
        '
        Me.txtArea.AfterDecimal = 2
        Me.txtArea.BeforeDecimal = 7
        Me.txtArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtArea.Location = New System.Drawing.Point(64, 0)
        Me.txtArea.LostFocusColour = System.Drawing.Color.Empty
        Me.txtArea.MaxLength = 6
        Me.txtArea.MaxValue = 0
        Me.txtArea.MinValue = 0
        Me.txtArea.Multiline = True
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(80, 24)
        Me.txtArea.TabIndex = 2
        Me.txtArea.Text = ""
        '
        'txtEstimate
        '
        Me.txtEstimate.AfterDecimal = 2
        Me.txtEstimate.BeforeDecimal = 7
        Me.txtEstimate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstimate.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtEstimate.Location = New System.Drawing.Point(280, 0)
        Me.txtEstimate.LostFocusColour = System.Drawing.Color.Empty
        Me.txtEstimate.MaxLength = 6
        Me.txtEstimate.MaxValue = 0
        Me.txtEstimate.MinValue = 0
        Me.txtEstimate.Multiline = True
        Me.txtEstimate.Name = "txtEstimate"
        Me.txtEstimate.Size = New System.Drawing.Size(80, 24)
        Me.txtEstimate.TabIndex = 4
        Me.txtEstimate.Text = ""
        '
        'txtRemarks
        '
        Me.txtRemarks.AlphaNumeric = False
        Me.txtRemarks.BlankSpace = False
        Me.txtRemarks.GotFocusColour = System.Drawing.Color.Empty
        Me.txtRemarks.Location = New System.Drawing.Point(440, 0)
        Me.txtRemarks.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRemarks.Mandatory = False
        Me.txtRemarks.MaxLength = 50
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(88, 24)
        Me.txtRemarks.SpecialChar = True
        Me.txtRemarks.TabIndex = 6
        Me.txtRemarks.Text = ""
        '
        'txtWetDet
        '
        Me.txtWetDet.AlphaNumeric = False
        Me.txtWetDet.BlankSpace = False
        Me.txtWetDet.GotFocusColour = System.Drawing.Color.Empty
        Me.txtWetDet.Location = New System.Drawing.Point(528, 0)
        Me.txtWetDet.LostFocusColour = System.Drawing.Color.Empty
        Me.txtWetDet.Mandatory = False
        Me.txtWetDet.MaxLength = 50
        Me.txtWetDet.Multiline = True
        Me.txtWetDet.Name = "txtWetDet"
        Me.txtWetDet.Size = New System.Drawing.Size(160, 24)
        Me.txtWetDet.SpecialChar = True
        Me.txtWetDet.TabIndex = 7
        Me.txtWetDet.Text = ""
        '
        'txtServaeNo
        '
        Me.txtServaeNo.AfterDecimal = 2
        Me.txtServaeNo.BeforeDecimal = 7
        Me.txtServaeNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServaeNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtServaeNo.Location = New System.Drawing.Point(0, 0)
        Me.txtServaeNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtServaeNo.MaxLength = 6
        Me.txtServaeNo.MaxValue = 0
        Me.txtServaeNo.MinValue = 0
        Me.txtServaeNo.Multiline = True
        Me.txtServaeNo.Name = "txtServaeNo"
        Me.txtServaeNo.Size = New System.Drawing.Size(64, 24)
        Me.txtServaeNo.TabIndex = 1
        Me.txtServaeNo.Text = ""
        '
        'KisanDecCtrl
        '
        Me.Controls.Add(Me.txtExpected)
        Me.Controls.Add(Me.txtCrop)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.txtEstimate)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtWetDet)
        Me.Controls.Add(Me.txtServaeNo)
        Me.Name = "KisanDecCtrl"
        Me.Size = New System.Drawing.Size(688, 24)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Properties"

    Public Property servae() As BankControls.NumericControl
        Get
            Return txtServaeNo
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            txtServaeNo = Value
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


    Public Property Crop() As BankControls.TextControl
        Get
            Return txtCrop
        End Get
        Set(ByVal Value As BankControls.TextControl)
            txtCrop = Value
        End Set
    End Property
    Public Property Remarks() As BankControls.TextControl
        Get
            Return txtRemarks
        End Get
        Set(ByVal Value As BankControls.TextControl)
            txtRemarks = Value
        End Set
    End Property

    Public Property Estimate() As BankControls.NumericControl
        Get
            Return txtEstimate
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            txtEstimate = Value
        End Set
    End Property

    Public Property Expected() As BankControls.NumericControl
        Get
            Return txtExpected
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            txtExpected = Value
        End Set
    End Property

    Public Property WetLandDet() As BankControls.TextControl
        Get
            Return txtWetDet
        End Get
        Set(ByVal Value As BankControls.TextControl)
            txtWetDet = Value
        End Set
    End Property

#End Region

End Class
