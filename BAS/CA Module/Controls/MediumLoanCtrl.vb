Public Class MediumLoanCtrl
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
    Friend WithEvents txtRemainingAmt As BankControls.NumericControl
    Friend WithEvents txtBankName As BankControls.TextControl
    Friend WithEvents txtMortageDet As BankControls.TextControl
    Friend WithEvents txtAction As BankControls.TextControl
    Friend WithEvents txtSusti As BankControls.NumericControl
    Friend WithEvents dtpSustiDate As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtRemainingAmt = New BankControls.NumericControl
        Me.txtBankName = New BankControls.TextControl
        Me.txtMortageDet = New BankControls.TextControl
        Me.txtSusti = New BankControls.NumericControl
        Me.txtAction = New BankControls.TextControl
        Me.dtpSustiDate = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'txtRemainingAmt
        '
        Me.txtRemainingAmt.AfterDecimal = 0
        Me.txtRemainingAmt.BeforeDecimal = 7
        Me.txtRemainingAmt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemainingAmt.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemainingAmt.Location = New System.Drawing.Point(112, 0)
        Me.txtRemainingAmt.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRemainingAmt.MaxLength = 10
        Me.txtRemainingAmt.MaxValue = 99999999
        Me.txtRemainingAmt.MinValue = 0
        Me.txtRemainingAmt.Multiline = True
        Me.txtRemainingAmt.Name = "txtRemainingAmt"
        Me.txtRemainingAmt.Size = New System.Drawing.Size(120, 24)
        Me.txtRemainingAmt.TabIndex = 2
        Me.txtRemainingAmt.Text = ""
        '
        'txtBankName
        '
        Me.txtBankName.AlphaNumeric = True
        Me.txtBankName.AutoSize = False
        Me.txtBankName.BlankSpace = False
        Me.txtBankName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBankName.Location = New System.Drawing.Point(0, 0)
        Me.txtBankName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBankName.Mandatory = False
        Me.txtBankName.MaxLength = 80
        Me.txtBankName.Multiline = True
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(112, 24)
        Me.txtBankName.SpecialChar = True
        Me.txtBankName.TabIndex = 1
        Me.txtBankName.Text = ""
        '
        'txtMortageDet
        '
        Me.txtMortageDet.AlphaNumeric = True
        Me.txtMortageDet.AutoSize = False
        Me.txtMortageDet.BlankSpace = False
        Me.txtMortageDet.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMortageDet.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMortageDet.Location = New System.Drawing.Point(232, 0)
        Me.txtMortageDet.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMortageDet.Mandatory = False
        Me.txtMortageDet.MaxLength = 100
        Me.txtMortageDet.Multiline = True
        Me.txtMortageDet.Name = "txtMortageDet"
        Me.txtMortageDet.Size = New System.Drawing.Size(112, 24)
        Me.txtMortageDet.SpecialChar = True
        Me.txtMortageDet.TabIndex = 3
        Me.txtMortageDet.Text = ""
        '
        'txtSusti
        '
        Me.txtSusti.AfterDecimal = 0
        Me.txtSusti.BeforeDecimal = 7
        Me.txtSusti.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSusti.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSusti.Location = New System.Drawing.Point(344, 0)
        Me.txtSusti.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSusti.MaxLength = 100
        Me.txtSusti.MaxValue = 100
        Me.txtSusti.MinValue = 0
        Me.txtSusti.Multiline = True
        Me.txtSusti.Name = "txtSusti"
        Me.txtSusti.Size = New System.Drawing.Size(80, 24)
        Me.txtSusti.TabIndex = 4
        Me.txtSusti.Text = ""
        '
        'txtAction
        '
        Me.txtAction.AlphaNumeric = True
        Me.txtAction.AutoSize = False
        Me.txtAction.BlankSpace = False
        Me.txtAction.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAction.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAction.Location = New System.Drawing.Point(536, 0)
        Me.txtAction.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAction.Mandatory = False
        Me.txtAction.MaxLength = 100
        Me.txtAction.Multiline = True
        Me.txtAction.Name = "txtAction"
        Me.txtAction.Size = New System.Drawing.Size(144, 22)
        Me.txtAction.SpecialChar = True
        Me.txtAction.TabIndex = 6
        Me.txtAction.Text = ""
        '
        'dtpSustiDate
        '
        Me.dtpSustiDate.CustomFormat = "dd / MMM / yyyy"
        Me.dtpSustiDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSustiDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSustiDate.Location = New System.Drawing.Point(424, 0)
        Me.dtpSustiDate.MaxDate = New Date(2681, 11, 16, 0, 0, 0, 0)
        Me.dtpSustiDate.Name = "dtpSustiDate"
        Me.dtpSustiDate.Size = New System.Drawing.Size(112, 22)
        Me.dtpSustiDate.TabIndex = 5
        Me.dtpSustiDate.Value = New Date(2007, 10, 1, 0, 0, 0, 0)
        '
        'MediumLoanCtrl
        '
        Me.Controls.Add(Me.dtpSustiDate)
        Me.Controls.Add(Me.txtRemainingAmt)
        Me.Controls.Add(Me.txtBankName)
        Me.Controls.Add(Me.txtMortageDet)
        Me.Controls.Add(Me.txtSusti)
        Me.Controls.Add(Me.txtAction)
        Me.Name = "MediumLoanCtrl"
        Me.Size = New System.Drawing.Size(680, 24)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"


#End Region

#Region "Properties"

    Public Property BankName() As BankControls.TextControl
        Get
            Return txtBankName
        End Get
        Set(ByVal Value As BankControls.TextControl)
            txtBankName = Value
        End Set
    End Property


    Public Property RemainingAmount() As BankControls.NumericControl
        Get
            Return txtRemainingAmt
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            txtRemainingAmt = Value
        End Set
    End Property

    Public Property mortagage() As BankControls.TextControl
        Get
            Return txtMortageDet
        End Get
        Set(ByVal Value As BankControls.TextControl)
            txtMortageDet = Value
        End Set
    End Property


    Public Property Susti() As BankControls.NumericControl
        Get
            Return txtSusti
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            txtSusti = Value
        End Set
    End Property

    Public Property SustiDate() As DateTimePicker 
        Get
            Return dtpSustiDate
        End Get
        Set(ByVal Value As DateTimePicker)
            dtpSustiDate = Value
        End Set
    End Property

    Public Property AnyAction() As BankControls.TextControl
        Get
            Return txtAction
        End Get
        Set(ByVal Value As BankControls.TextControl)
            txtAction = Value
        End Set
    End Property

#End Region

End Class
