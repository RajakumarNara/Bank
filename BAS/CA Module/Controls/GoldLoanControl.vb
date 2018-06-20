Public Class GoldLoanControl
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
    Friend WithEvents txtPurity As BankControls.NumericControl
    Friend WithEvents txtTotalWeight As BankControls.NumericControl
    Friend WithEvents txtSlNo As BankControls.NumericControl
    Friend WithEvents txtGoldDetails As BankControls.TextControl
    Friend WithEvents txtGoldWeight As BankControls.NumericControl
    Friend WithEvents txtNetWeight As BankControls.NumericControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtGoldDetails = New BankControls.TextControl
        Me.txtGoldWeight = New BankControls.NumericControl
        Me.txtNetWeight = New BankControls.NumericControl
        Me.txtPurity = New BankControls.NumericControl
        Me.txtTotalWeight = New BankControls.NumericControl
        Me.txtSlNo = New BankControls.NumericControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtGoldDetails
        '
        Me.txtGoldDetails.AlphaNumeric = False
        Me.txtGoldDetails.AutoSize = False
        Me.txtGoldDetails.BlankSpace = False
        Me.txtGoldDetails.GotFocusColour = System.Drawing.Color.Empty
        Me.txtGoldDetails.Location = New System.Drawing.Point(48, 0)
        Me.txtGoldDetails.LostFocusColour = System.Drawing.Color.Empty
        Me.txtGoldDetails.Mandatory = False
        Me.txtGoldDetails.MaxLength = 50
        Me.txtGoldDetails.Multiline = True
        Me.txtGoldDetails.Name = "txtGoldDetails"
        Me.txtGoldDetails.Size = New System.Drawing.Size(280, 24)
        Me.txtGoldDetails.SpecialChar = True
        Me.txtGoldDetails.TabIndex = 2
        Me.txtGoldDetails.Text = ""
        '
        'txtGoldWeight
        '
        Me.txtGoldWeight.AfterDecimal = 3
        Me.txtGoldWeight.BeforeDecimal = 4
        Me.txtGoldWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGoldWeight.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtGoldWeight.Location = New System.Drawing.Point(328, 0)
        Me.txtGoldWeight.LostFocusColour = System.Drawing.Color.Empty
        Me.txtGoldWeight.MaxLength = 15
        Me.txtGoldWeight.MaxValue = 0
        Me.txtGoldWeight.MinValue = 0
        Me.txtGoldWeight.Multiline = True
        Me.txtGoldWeight.Name = "txtGoldWeight"
        Me.txtGoldWeight.Size = New System.Drawing.Size(96, 24)
        Me.txtGoldWeight.TabIndex = 3
        Me.txtGoldWeight.Text = ""
        Me.txtGoldWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNetWeight
        '
        Me.txtNetWeight.AfterDecimal = 3
        Me.txtNetWeight.BeforeDecimal = 4
        Me.txtNetWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetWeight.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNetWeight.Location = New System.Drawing.Point(424, 0)
        Me.txtNetWeight.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNetWeight.MaxLength = 15
        Me.txtNetWeight.MaxValue = 0
        Me.txtNetWeight.MinValue = 0
        Me.txtNetWeight.Multiline = True
        Me.txtNetWeight.Name = "txtNetWeight"
        Me.txtNetWeight.Size = New System.Drawing.Size(104, 24)
        Me.txtNetWeight.TabIndex = 4
        Me.txtNetWeight.Text = ""
        Me.txtNetWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPurity
        '
        Me.txtPurity.AfterDecimal = 3
        Me.txtPurity.BeforeDecimal = 4
        Me.txtPurity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurity.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPurity.Location = New System.Drawing.Point(528, 0)
        Me.txtPurity.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPurity.MaxLength = 15
        Me.txtPurity.MaxValue = 0
        Me.txtPurity.MinValue = 0
        Me.txtPurity.Multiline = True
        Me.txtPurity.Name = "txtPurity"
        Me.txtPurity.Size = New System.Drawing.Size(64, 24)
        Me.txtPurity.TabIndex = 5
        Me.txtPurity.Text = ""
        Me.txtPurity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalWeight
        '
        Me.txtTotalWeight.AfterDecimal = 3
        Me.txtTotalWeight.BeforeDecimal = 6
        Me.txtTotalWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalWeight.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtTotalWeight.Location = New System.Drawing.Point(616, 0)
        Me.txtTotalWeight.LostFocusColour = System.Drawing.Color.Empty
        Me.txtTotalWeight.MaxLength = 15
        Me.txtTotalWeight.MaxValue = 0
        Me.txtTotalWeight.MinValue = 0
        Me.txtTotalWeight.Multiline = True
        Me.txtTotalWeight.Name = "txtTotalWeight"
        Me.txtTotalWeight.Size = New System.Drawing.Size(72, 24)
        Me.txtTotalWeight.TabIndex = 6
        Me.txtTotalWeight.Text = ""
        Me.txtTotalWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(597, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "%"
        '
        'GoldLoanControl
        '
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSlNo)
        Me.Controls.Add(Me.txtTotalWeight)
        Me.Controls.Add(Me.txtPurity)
        Me.Controls.Add(Me.txtNetWeight)
        Me.Controls.Add(Me.txtGoldWeight)
        Me.Controls.Add(Me.txtGoldDetails)
        Me.Name = "GoldLoanControl"
        Me.Size = New System.Drawing.Size(688, 24)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Properties"

    Public Property GoldDetails() As BankControls.TextControl
        Get
            Return txtGoldDetails
        End Get
        Set(ByVal Value As BankControls.TextControl)
            txtGoldDetails = Value
        End Set
    End Property

    Public Property GoldWeight() As BankControls.NumericControl
        Get
            Return txtGoldWeight
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            txtGoldWeight = Value
        End Set
    End Property

    Public Property netWeight() As BankControls.NumericControl
        Get
            Return txtNetWeight
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            txtNetWeight = Value
        End Set
    End Property

    Public Property Purity() As BankControls.NumericControl
        Get
            Return txtPurity
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            txtPurity = Value
        End Set
    End Property

    Public Property TotalWeigth() As BankControls.NumericControl
        Get
            Return txtTotalWeight
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            txtTotalWeight = Value
        End Set
    End Property
#End Region

#Region "Function"

    Function fnCheck() As Boolean
        If txtGoldDetails.Text = String.Empty Then
            MsgBox("Enter Gold Items")
            txtGoldDetails.Focus()
            Return False
        ElseIf txtGoldWeight.Text = String.Empty Then
            MsgBox("Enter Gold Weight")
            txtGoldWeight.Focus()
            Return False
        ElseIf txtNetWeight.Text = String.Empty Then
            MsgBox("Enter Net Weight")
            txtNetWeight.Focus()
            Return False
        ElseIf txtPurity.Text = String.Empty Then
            MsgBox("Enter Purity Of Gold")
            txtPurity.Focus()
            Return False
        ElseIf txtTotalWeight.Text = String.Empty Then
            MsgBox("Enter Total Weight of Gold")
            txtGoldWeight.Focus()
            Return False
        Else
            Return True
        End If
    End Function
#End Region


End Class
