Public Class BnncBnndCtrl
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
    Friend WithEvents txtAvailable As BankControls.TextControl
    Friend WithEvents txtAccNo As BankControls.TextControl
    Friend WithEvents txtName As BankControls.TextControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtAvailable = New BankControls.TextControl
        Me.txtAccNo = New BankControls.TextControl
        Me.txtName = New BankControls.TextControl
        Me.SuspendLayout()
        '
        'txtAvailable
        '
        Me.txtAvailable.AlphaNumeric = True
        Me.txtAvailable.BackColor = System.Drawing.Color.White
        Me.txtAvailable.BlankSpace = False
        Me.txtAvailable.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailable.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAvailable.Location = New System.Drawing.Point(320, 0)
        Me.txtAvailable.LostFocusColour = System.Drawing.Color.White
        Me.txtAvailable.Mandatory = False
        Me.txtAvailable.MaxLength = 8
        Me.txtAvailable.Name = "txtAvailable"
        Me.txtAvailable.ReadOnly = True
        Me.txtAvailable.Size = New System.Drawing.Size(160, 23)
        Me.txtAvailable.SpecialChar = False
        Me.txtAvailable.TabIndex = 8
        Me.txtAvailable.Text = ""
        '
        'txtAccNo
        '
        Me.txtAccNo.AlphaNumeric = True
        Me.txtAccNo.BackColor = System.Drawing.Color.White
        Me.txtAccNo.BlankSpace = False
        Me.txtAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccNo.Location = New System.Drawing.Point(0, 0)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.White
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.MaxLength = 8
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.ReadOnly = True
        Me.txtAccNo.Size = New System.Drawing.Size(128, 23)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 7
        Me.txtAccNo.Text = ""
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.AutoSize = False
        Me.txtName.BackColor = System.Drawing.SystemColors.Window
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(128, 0)
        Me.txtName.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(192, 22)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 6
        Me.txtName.Text = ""
        '
        'BnncBnndCtrl
        '
        Me.Controls.Add(Me.txtAvailable)
        Me.Controls.Add(Me.txtAccNo)
        Me.Controls.Add(Me.txtName)
        Me.Name = "BnncBnndCtrl"
        Me.Size = New System.Drawing.Size(480, 24)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
