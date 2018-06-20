Public Class ItemsControl2
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
    Friend WithEvents TextControl1 As BankControls.TextControl
    Friend WithEvents TextControl0 As BankControls.TextControl
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextControl2 As BankControls.NumericControl
    Friend WithEvents TextControl3 As BankControls.NumericControl
    Friend WithEvents TextControl4 As BankControls.NumericControl
    Friend WithEvents TextControl5 As BankControls.NumericControl
    Friend WithEvents TextControl6 As BankControls.NumericControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkDelete As System.Windows.Forms.CheckBox
    Friend WithEvents TextControl7 As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TextControl0 = New BankControls.TextControl
        Me.TextControl1 = New BankControls.TextControl
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextControl2 = New BankControls.NumericControl
        Me.TextControl3 = New BankControls.NumericControl
        Me.TextControl4 = New BankControls.NumericControl
        Me.TextControl5 = New BankControls.NumericControl
        Me.TextControl6 = New BankControls.NumericControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkDelete = New System.Windows.Forms.CheckBox
        Me.TextControl7 = New BankControls.NumericControl
        Me.SuspendLayout()
        '
        'TextControl0
        '
        Me.TextControl0.AlphaNumeric = False
        Me.TextControl0.AutoSize = False
        Me.TextControl0.BlankSpace = True
        Me.TextControl0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextControl0.GotFocusColour = System.Drawing.SystemColors.Info
        Me.TextControl0.Location = New System.Drawing.Point(24, 0)
        Me.TextControl0.LostFocusColour = System.Drawing.SystemColors.Window
        Me.TextControl0.Mandatory = False
        Me.TextControl0.MaxLength = 30
        Me.TextControl0.Name = "TextControl0"
        Me.TextControl0.Size = New System.Drawing.Size(88, 22)
        Me.TextControl0.SpecialChar = True
        Me.TextControl0.TabIndex = 0
        Me.TextControl0.Text = ""
        '
        'TextControl1
        '
        Me.TextControl1.AlphaNumeric = False
        Me.TextControl1.AutoSize = False
        Me.TextControl1.BackColor = System.Drawing.Color.White
        Me.TextControl1.BlankSpace = True
        Me.TextControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextControl1.GotFocusColour = System.Drawing.SystemColors.Info
        Me.TextControl1.Location = New System.Drawing.Point(112, 0)
        Me.TextControl1.LostFocusColour = System.Drawing.SystemColors.Window
        Me.TextControl1.Mandatory = False
        Me.TextControl1.MaxLength = 30
        Me.TextControl1.Name = "TextControl1"
        Me.TextControl1.Size = New System.Drawing.Size(224, 22)
        Me.TextControl1.SpecialChar = True
        Me.TextControl1.TabIndex = 17
        Me.TextControl1.TabStop = False
        Me.TextControl1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(696, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(16, 24)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "++"
        '
        'TextControl2
        '
        Me.TextControl2.AfterDecimal = 2
        Me.TextControl2.BackColor = System.Drawing.Color.White
        Me.TextControl2.BeforeDecimal = 7
        Me.TextControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextControl2.GotFocusColour = System.Drawing.SystemColors.Info
        Me.TextControl2.Location = New System.Drawing.Point(336, 0)
        Me.TextControl2.LostFocusColour = System.Drawing.Color.Empty
        Me.TextControl2.MaxLength = 6
        Me.TextControl2.MaxValue = 0
        Me.TextControl2.MinValue = 0
        Me.TextControl2.Name = "TextControl2"
        Me.TextControl2.ReadOnly = True
        Me.TextControl2.Size = New System.Drawing.Size(72, 22)
        Me.TextControl2.TabIndex = 19
        Me.TextControl2.TabStop = False
        Me.TextControl2.Text = ""
        '
        'TextControl3
        '
        Me.TextControl3.AfterDecimal = 2
        Me.TextControl3.BeforeDecimal = 7
        Me.TextControl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextControl3.GotFocusColour = System.Drawing.SystemColors.Info
        Me.TextControl3.Location = New System.Drawing.Point(408, 0)
        Me.TextControl3.LostFocusColour = System.Drawing.Color.Empty
        Me.TextControl3.MaxLength = 6
        Me.TextControl3.MaxValue = 0
        Me.TextControl3.MinValue = 0
        Me.TextControl3.Name = "TextControl3"
        Me.TextControl3.Size = New System.Drawing.Size(64, 22)
        Me.TextControl3.TabIndex = 1
        Me.TextControl3.Text = ""
        '
        'TextControl4
        '
        Me.TextControl4.AfterDecimal = 2
        Me.TextControl4.BackColor = System.Drawing.Color.White
        Me.TextControl4.BeforeDecimal = 7
        Me.TextControl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextControl4.GotFocusColour = System.Drawing.SystemColors.Info
        Me.TextControl4.Location = New System.Drawing.Point(472, 0)
        Me.TextControl4.LostFocusColour = System.Drawing.Color.Empty
        Me.TextControl4.MaxLength = 6
        Me.TextControl4.MaxValue = 0
        Me.TextControl4.MinValue = 0
        Me.TextControl4.Name = "TextControl4"
        Me.TextControl4.Size = New System.Drawing.Size(64, 22)
        Me.TextControl4.TabIndex = 12
        Me.TextControl4.TabStop = False
        Me.TextControl4.Text = ""
        '
        'TextControl5
        '
        Me.TextControl5.AfterDecimal = 2
        Me.TextControl5.BeforeDecimal = 7
        Me.TextControl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextControl5.GotFocusColour = System.Drawing.SystemColors.Info
        Me.TextControl5.Location = New System.Drawing.Point(640, 0)
        Me.TextControl5.LostFocusColour = System.Drawing.Color.Empty
        Me.TextControl5.MaxLength = 6
        Me.TextControl5.MaxValue = 0
        Me.TextControl5.MinValue = 0
        Me.TextControl5.Name = "TextControl5"
        Me.TextControl5.Size = New System.Drawing.Size(56, 22)
        Me.TextControl5.TabIndex = 19
        Me.TextControl5.Text = ""
        Me.TextControl5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextControl5.Visible = False
        '
        'TextControl6
        '
        Me.TextControl6.AfterDecimal = 2
        Me.TextControl6.BeforeDecimal = 7
        Me.TextControl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextControl6.GotFocusColour = System.Drawing.SystemColors.Info
        Me.TextControl6.Location = New System.Drawing.Point(640, 0)
        Me.TextControl6.LostFocusColour = System.Drawing.Color.Empty
        Me.TextControl6.MaxLength = 6
        Me.TextControl6.MaxValue = 0
        Me.TextControl6.MinValue = 0
        Me.TextControl6.Name = "TextControl6"
        Me.TextControl6.Size = New System.Drawing.Size(56, 22)
        Me.TextControl6.TabIndex = 19
        Me.TextControl6.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(608, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Rs"
        '
        'chkDelete
        '
        Me.chkDelete.Location = New System.Drawing.Point(8, 3)
        Me.chkDelete.Name = "chkDelete"
        Me.chkDelete.Size = New System.Drawing.Size(16, 16)
        Me.chkDelete.TabIndex = 21
        Me.chkDelete.Text = "CheckBox1"
        '
        'TextControl7
        '
        Me.TextControl7.AfterDecimal = 2
        Me.TextControl7.BackColor = System.Drawing.Color.White
        Me.TextControl7.BeforeDecimal = 7
        Me.TextControl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextControl7.GotFocusColour = System.Drawing.SystemColors.Info
        Me.TextControl7.Location = New System.Drawing.Point(536, 0)
        Me.TextControl7.LostFocusColour = System.Drawing.Color.Empty
        Me.TextControl7.MaxLength = 6
        Me.TextControl7.MaxValue = 0
        Me.TextControl7.MinValue = 0
        Me.TextControl7.Name = "TextControl7"
        Me.TextControl7.Size = New System.Drawing.Size(64, 22)
        Me.TextControl7.TabIndex = 12
        Me.TextControl7.TabStop = False
        Me.TextControl7.Text = ""
        '
        'ItemsControl2
        '
        Me.Controls.Add(Me.chkDelete)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextControl2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextControl0)
        Me.Controls.Add(Me.TextControl1)
        Me.Controls.Add(Me.TextControl3)
        Me.Controls.Add(Me.TextControl4)
        Me.Controls.Add(Me.TextControl5)
        Me.Controls.Add(Me.TextControl6)
        Me.Controls.Add(Me.TextControl7)
        Me.Name = "ItemsControl2"
        Me.Size = New System.Drawing.Size(712, 24)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Properties"
    Public Property txtItemCode() As BankControls.TextControl
        Get
            Return TextControl0
        End Get
        Set(ByVal Value As BankControls.TextControl)
            TextControl0 = Value
        End Set
    End Property

    Public Property txtDescription() As BankControls.TextControl
        Get
            Return TextControl1
        End Get
        Set(ByVal Value As BankControls.TextControl)
            TextControl1 = Value
        End Set
    End Property

    Public Property txtOnhand() As BankControls.NumericControl
        Get
            Return TextControl2
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            TextControl2 = Value
        End Set
    End Property

    Public Property txtQuantity() As BankControls.NumericControl
        Get
            Return TextControl3
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            TextControl3 = Value
        End Set
    End Property

    Public Property txtPrice() As BankControls.NumericControl
        Get
            Return TextControl4
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            TextControl4 = Value
        End Set
    End Property

    Public Property txtDiscount() As BankControls.NumericControl
        Get
            Return TextControl5
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            TextControl5 = Value
        End Set
    End Property

    Public Property txtTotal() As BankControls.NumericControl
        Get
            Return TextControl6
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            TextControl5 = Value
        End Set
    End Property

    Public Property btnNewControl() As Button
        Get
            Return Button1
        End Get
        Set(ByVal Value As Button)
            Button1 = Value
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

    Public Property txtSellingPrice() As BankControls.NumericControl
        Get
            Return TextControl7
        End Get
        Set(ByVal Value As BankControls.NumericControl)
            TextControl7 = Value
        End Set
    End Property

#End Region

#Region "Events"

    Public Event txtItemcodeLeave(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event txtItemcodeKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    Public Event btnNewControlClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event chkDel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Event txt_QuantityChanged(ByVal sender As Object, ByVal e As System.EventArgs)

#End Region

    Private Sub txtItemCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextControl0.TextChanged
        'Dim Objlistview As New ListView
    End Sub

    Private Sub TextControl0_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextControl0.KeyPress

        RaiseEvent txtItemcodeKeyPress(Me, e)

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        RaiseEvent btnNewControlClick(Me, e)

    End Sub
    Private Sub TextControl0_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextControl0.Leave

        RaiseEvent txtItemcodeLeave(Me, e)

    End Sub

    Private Sub chkDelete_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDelete.CheckedChanged

        RaiseEvent chkDel_CheckedChanged(Me, e)

    End Sub
    Private Sub TextControl3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextControl3.TextChanged, TextControl6.TextChanged

        RaiseEvent txt_QuantityChanged(Me, e)

    End Sub
End Class
