Public Class LoansOnDepositControl
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
    Friend WithEvents txtFDNo As BankControls.TextControl
    Friend WithEvents dtpFDDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents txtFDAmt As BankControls.NumericControl
    Friend WithEvents txtMatAmt As BankControls.NumericControl
    Friend WithEvents dtpMatDate As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtSlNo = New BankControls.NumericControl
        Me.txtFDNo = New BankControls.TextControl
        Me.dtpFDDate = New System.Windows.Forms.DateTimePicker
        Me.txtName = New BankControls.TextControl
        Me.txtFDAmt = New BankControls.NumericControl
        Me.txtMatAmt = New BankControls.NumericControl
        Me.dtpMatDate = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'txtSlNo
        '
        Me.txtSlNo.AfterDecimal = 0
        Me.txtSlNo.BeforeDecimal = 3
        Me.txtSlNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtSlNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSlNo.Location = New System.Drawing.Point(0, 0)
        Me.txtSlNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSlNo.MaxLength = 2
        Me.txtSlNo.MaxValue = 99999999
        Me.txtSlNo.MinValue = 0
        Me.txtSlNo.Name = "txtSlNo"
        Me.txtSlNo.Size = New System.Drawing.Size(32, 22)
        Me.txtSlNo.TabIndex = 1
        Me.txtSlNo.Text = ""
        '
        'txtFDNo
        '
        Me.txtFDNo.AlphaNumeric = False
        Me.txtFDNo.AutoSize = False
        Me.txtFDNo.BlankSpace = False
        Me.txtFDNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtFDNo.GotFocusColour = System.Drawing.Color.Empty
        Me.txtFDNo.Location = New System.Drawing.Point(32, 0)
        Me.txtFDNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtFDNo.Mandatory = False
        Me.txtFDNo.MaxLength = 10
        Me.txtFDNo.Name = "txtFDNo"
        Me.txtFDNo.Size = New System.Drawing.Size(88, 24)
        Me.txtFDNo.SpecialChar = True
        Me.txtFDNo.TabIndex = 2
        Me.txtFDNo.Text = ""
        '
        'dtpFDDate
        '
        Me.dtpFDDate.CustomFormat = "dd / MMM / yyyy"
        Me.dtpFDDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFDDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFDDate.Location = New System.Drawing.Point(328, 0)
        Me.dtpFDDate.MaxDate = New Date(2681, 11, 16, 0, 0, 0, 0)
        Me.dtpFDDate.Name = "dtpFDDate"
        Me.dtpFDDate.Size = New System.Drawing.Size(112, 22)
        Me.dtpFDDate.TabIndex = 4
        Me.dtpFDDate.Value = New Date(2007, 10, 1, 0, 0, 0, 0)
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.AutoSize = False
        Me.txtName.BlankSpace = False
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtName.GotFocusColour = System.Drawing.Color.Empty
        Me.txtName.Location = New System.Drawing.Point(120, 0)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(208, 24)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 3
        Me.txtName.Text = ""
        '
        'txtFDAmt
        '
        Me.txtFDAmt.AfterDecimal = 2
        Me.txtFDAmt.BeforeDecimal = 7
        Me.txtFDAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtFDAmt.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDAmt.Location = New System.Drawing.Point(440, 0)
        Me.txtFDAmt.LostFocusColour = System.Drawing.Color.Empty
        Me.txtFDAmt.MaxLength = 11
        Me.txtFDAmt.MaxValue = 99999999
        Me.txtFDAmt.MinValue = 0
        Me.txtFDAmt.Name = "txtFDAmt"
        Me.txtFDAmt.Size = New System.Drawing.Size(80, 22)
        Me.txtFDAmt.TabIndex = 5
        Me.txtFDAmt.Text = ""
        '
        'txtMatAmt
        '
        Me.txtMatAmt.AfterDecimal = 2
        Me.txtMatAmt.BeforeDecimal = 7
        Me.txtMatAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtMatAmt.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMatAmt.Location = New System.Drawing.Point(632, 0)
        Me.txtMatAmt.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMatAmt.MaxLength = 11
        Me.txtMatAmt.MaxValue = 99999999
        Me.txtMatAmt.MinValue = 0
        Me.txtMatAmt.Name = "txtMatAmt"
        Me.txtMatAmt.Size = New System.Drawing.Size(80, 22)
        Me.txtMatAmt.TabIndex = 7
        Me.txtMatAmt.Text = ""
        '
        'dtpMatDate
        '
        Me.dtpMatDate.CustomFormat = "dd / MMM / yyyy"
        Me.dtpMatDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMatDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMatDate.Location = New System.Drawing.Point(520, 0)
        Me.dtpMatDate.MaxDate = New Date(2681, 11, 16, 0, 0, 0, 0)
        Me.dtpMatDate.Name = "dtpMatDate"
        Me.dtpMatDate.Size = New System.Drawing.Size(112, 22)
        Me.dtpMatDate.TabIndex = 6
        Me.dtpMatDate.Value = New Date(2007, 10, 1, 0, 0, 0, 0)
        '
        'LoansOnDepositControl
        '
        Me.Controls.Add(Me.txtMatAmt)
        Me.Controls.Add(Me.dtpMatDate)
        Me.Controls.Add(Me.txtFDAmt)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.dtpFDDate)
        Me.Controls.Add(Me.txtFDNo)
        Me.Controls.Add(Me.txtSlNo)
        Me.Name = "LoansOnDepositControl"
        Me.Size = New System.Drawing.Size(712, 24)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Property"

    Public Property FDNumber() As BankControls.TextControl
        Get
            Return txtFDNo
        End Get
        Set(ByVal Value As BankControls.TextControl)
            txtFDNo = Value
        End Set
    End Property

    Public Property FDPName() As BankControls.TextControl
        Get
            Return txtName
        End Get
        Set(ByVal Value As BankControls.TextControl)
            txtName = Value
        End Set
    End Property
    Public Property FDDate() As DateTimePicker
        Get
            Return dtpFDDate
        End Get
        Set(ByVal Value As DateTimePicker)
            dtpFDDate = Value
        End Set
    End Property
    Public Property FDAmount() As BankControls.NumericControl
        Get
            Return txtFDAmt
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            txtFDAmt = Value
        End Set
    End Property

    Public Property FDMatdate() As DateTimePicker
        Get
            Return dtpMatDate
        End Get
        Set(ByVal Value As DateTimePicker)
            dtpMatDate = Value
        End Set
    End Property

    Public Property FDMatAmount() As BankControls.NumericControl
        Get
            Return txtMatAmt
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            txtMatAmt = Value
        End Set
    End Property

#End Region

#Region "Function"

    Function fnCheck() As Boolean
        If txtFDNo.Text = String.Empty Then
            MsgBox("Enter Deposit Number")
            txtFDNo.Focus()
            Return False
        ElseIf txtName.Text = String.Empty Then
            MsgBox("Enter Name")
            txtName.Focus()
            Return False
        ElseIf txtFDAmt.Text = String.Empty Then
            MsgBox("Enter Deposit Amount")
            txtFDAmt.Focus()
            Return False
        ElseIf txtMatAmt.Text = String.Empty Then
            MsgBox("Enter Deposit Maturity Amount")
            txtMatAmt.Focus()
            Return False
        Else
            Return True
        End If
    End Function

#End Region

End Class
