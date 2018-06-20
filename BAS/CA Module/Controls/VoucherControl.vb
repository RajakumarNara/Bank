
Public Class VoucherControl
    Inherits System.Windows.Forms.UserControl

    Dim objLedgers As New clsLedger

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
    Friend WithEvents cmbByTo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLedger As System.Windows.Forms.ComboBox
    Friend WithEvents txtCredit As BankControls.NumericControl
    Friend WithEvents txtDebit As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbByTo = New System.Windows.Forms.ComboBox
        Me.cmbLedger = New System.Windows.Forms.ComboBox
        Me.txtCredit = New BankControls.NumericControl
        Me.txtDebit = New BankControls.NumericControl
        Me.SuspendLayout()
        '
        'cmbByTo
        '
        Me.cmbByTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbByTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbByTo.Items.AddRange(New Object() {"By", "To"})
        Me.cmbByTo.Location = New System.Drawing.Point(0, 0)
        Me.cmbByTo.Name = "cmbByTo"
        Me.cmbByTo.Size = New System.Drawing.Size(64, 24)
        Me.cmbByTo.TabIndex = 0
        '
        'cmbLedger
        '
        Me.cmbLedger.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLedger.Location = New System.Drawing.Point(64, 0)
        Me.cmbLedger.Name = "cmbLedger"
        Me.cmbLedger.Size = New System.Drawing.Size(416, 24)
        Me.cmbLedger.TabIndex = 1
        '
        'txtCredit
        '
        Me.txtCredit.AfterDecimal = 0
        Me.txtCredit.BeforeDecimal = 8
        Me.txtCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredit.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCredit.Location = New System.Drawing.Point(592, 0)
        Me.txtCredit.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtCredit.MaxLength = 10
        Me.txtCredit.MaxValue = 0
        Me.txtCredit.MinValue = 0
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(112, 22)
        Me.txtCredit.TabIndex = 2
        Me.txtCredit.Text = ""
        Me.txtCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDebit
        '
        Me.txtDebit.AfterDecimal = 0
        Me.txtDebit.BeforeDecimal = 8
        Me.txtDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebit.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtDebit.Location = New System.Drawing.Point(480, 0)
        Me.txtDebit.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtDebit.MaxLength = 10
        Me.txtDebit.MaxValue = 0
        Me.txtDebit.MinValue = 0
        Me.txtDebit.Name = "txtDebit"
        Me.txtDebit.Size = New System.Drawing.Size(112, 22)
        Me.txtDebit.TabIndex = 3
        Me.txtDebit.Text = ""
        Me.txtDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'VoucherControl
        '
        Me.Controls.Add(Me.txtCredit)
        Me.Controls.Add(Me.cmbLedger)
        Me.Controls.Add(Me.cmbByTo)
        Me.Controls.Add(Me.txtDebit)
        Me.Name = "VoucherControl"
        Me.Size = New System.Drawing.Size(704, 24)
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Properties"
    Public Property ByTo() As ComboBox
        Get
            Return cmbByTo
        End Get
        Set(ByVal Value As ComboBox)
            cmbByTo = Value
        End Set
    End Property

    Public Property Ledger() As ComboBox
        Get
            Return cmbLedger
        End Get
        Set(ByVal Value As ComboBox)
            cmbLedger = Value
        End Set
    End Property

    Public Property Credit() As BankControls.NumericControl
        Get
            Return txtCredit
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            txtCredit = Value
        End Set
    End Property

    Public Property Debit() As BankControls.NumericControl
        Get
            Return txtDebit
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            txtDebit = Value
        End Set
    End Property

#End Region

    Private Sub VoucherControl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If objLedgers.fnGetLedgerList Then
            cmbLedger.DataSource = objLedgers.LedgerTable
            cmbLedger.DisplayMember = "Name"
            cmbLedger.ValueMember = "LedgerNo"
        End If
        cmbByTo.SelectedIndex = 0
    End Sub

    Private Sub cmbByTo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbByTo.SelectedIndexChanged
        If cmbByTo.SelectedItem = "By" Then
            txtCredit.ResetText()
            txtCredit.Enabled = False
            txtDebit.Enabled = True
        ElseIf cmbByTo.SelectedItem = "To" Then
            txtDebit.ResetText()
            txtDebit.Enabled = False
            txtCredit.Enabled = True
        End If
    End Sub
End Class
