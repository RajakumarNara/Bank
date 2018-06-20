Public Class VoucherEntryControl
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
    Friend WithEvents chkDelete As System.Windows.Forms.CheckBox
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents cmbLedgerType As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkDelete = New System.Windows.Forms.CheckBox
        Me.txtAmount = New BankControls.NumericControl
        Me.cmbLedgerType = New System.Windows.Forms.ComboBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'chkDelete
        '
        Me.chkDelete.Location = New System.Drawing.Point(8, 4)
        Me.chkDelete.Name = "chkDelete"
        Me.chkDelete.Size = New System.Drawing.Size(16, 16)
        Me.chkDelete.TabIndex = 26
        Me.chkDelete.Text = "CheckBox1"
        '
        'txtAmount
        '
        Me.txtAmount.AfterDecimal = 2
        Me.txtAmount.BackColor = System.Drawing.Color.White
        Me.txtAmount.BeforeDecimal = 7
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmount.Location = New System.Drawing.Point(336, 0)
        Me.txtAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAmount.MaxLength = 6
        Me.txtAmount.MaxValue = 0
        Me.txtAmount.MinValue = 0
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(144, 22)
        Me.txtAmount.TabIndex = 24
        Me.txtAmount.Text = ""
        '
        'cmbLedgerType
        '
        Me.cmbLedgerType.Location = New System.Drawing.Point(24, 0)
        Me.cmbLedgerType.Name = "cmbLedgerType"
        Me.cmbLedgerType.Size = New System.Drawing.Size(312, 21)
        Me.cmbLedgerType.TabIndex = 23
        Me.cmbLedgerType.Text = "ComboBox1"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(480, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(16, 24)
        Me.btnAdd.TabIndex = 25
        Me.btnAdd.Text = "+"
        '
        'VoucherEntryControl
        '
        Me.Controls.Add(Me.chkDelete)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.cmbLedgerType)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "VoucherEntryControl"
        Me.Size = New System.Drawing.Size(496, 24)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim objLedgers As New clsLedger

#Region "property"

    Public Property LedgerType() As ComboBox
        Get
            Return cmbLedgerType
        End Get
        Set(ByVal Value As ComboBox)
            cmbLedgerType = Value
        End Set
    End Property

    Public Property Amount() As BankControls.NumericControl
        Get
            Return txtAmount
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            txtAmount = Value
        End Set
    End Property
    Public Property btnNewControl() As Button
        Get
            Return btnAdd
        End Get
        Set(ByVal Value As Button)
            btnAdd = Value
        End Set
    End Property

    Public Property chkdel() As CheckBox
        Get
            Return chkDelete
        End Get
        Set(ByVal Value As CheckBox)
            chkDelete = Value
        End Set
    End Property
#End Region

    Private Sub VoucherEntryControl_load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objDV As DataView
        If objLedgers.fnGetLedgerList Then
            objDV = New DataView(objLedgers.LedgerTable, "RestrictUser='N'", "OrderNo", DataViewRowState.OriginalRows)
            cmbLedgerType.DataSource = objDV
            cmbLedgerType.DisplayMember = "Name"
            cmbLedgerType.ValueMember = "LedgerNo"
        End If
        'cmbLedgerType.SelectedIndex = 0

    End Sub

#Region "Event "
    Public Event btnNewControlClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event chkDel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Event txt_AmountChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Event cmbledger_SelectedIndexChainged(ByVal sender As System.Object, ByVal e As System.EventArgs)
#End Region

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        RaiseEvent btnNewControlClick(Me, e)
    End Sub

    Private Sub chkDelete_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDelete.CheckedChanged
        RaiseEvent chkDel_CheckedChanged(Me, e)
    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged
        RaiseEvent txt_AmountChanged(Me, e)
    End Sub

    Private Sub cmbLedgerType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbLedgerType.SelectedIndexChanged
        RaiseEvent cmbledger_SelectedIndexChainged(Me, e)
    End Sub


End Class
