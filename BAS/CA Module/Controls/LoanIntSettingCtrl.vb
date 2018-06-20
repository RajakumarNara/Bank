Public Class LoanIntSettingCtrl
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
    Friend WithEvents txtTo As BankControls.TextControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtROI As BankControls.NumericControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFrom As BankControls.NumericControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtTo = New BankControls.TextControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtROI = New BankControls.NumericControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFrom = New BankControls.NumericControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtTo
        '
        Me.txtTo.AlphaNumeric = True
        Me.txtTo.BackColor = System.Drawing.Color.White
        Me.txtTo.BlankSpace = False
        Me.txtTo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtTo.Location = New System.Drawing.Point(120, 4)
        Me.txtTo.LostFocusColour = System.Drawing.Color.White
        Me.txtTo.Mandatory = False
        Me.txtTo.MaxLength = 10
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(70, 23)
        Me.txtTo.SpecialChar = False
        Me.txtTo.TabIndex = 11
        Me.txtTo.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(312, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "%"
        '
        'txtROI
        '
        Me.txtROI.AfterDecimal = 2
        Me.txtROI.BeforeDecimal = 7
        Me.txtROI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtROI.Location = New System.Drawing.Point(240, 7)
        Me.txtROI.LostFocusColour = System.Drawing.Color.Empty
        Me.txtROI.MaxLength = 5
        Me.txtROI.MaxValue = 0
        Me.txtROI.MinValue = 0
        Me.txtROI.Name = "txtROI"
        Me.txtROI.Size = New System.Drawing.Size(64, 22)
        Me.txtROI.TabIndex = 12
        Me.txtROI.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Rs"
        '
        'txtFrom
        '
        Me.txtFrom.AfterDecimal = 2
        Me.txtFrom.BeforeDecimal = 7
        Me.txtFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrom.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFrom.Location = New System.Drawing.Point(8, 7)
        Me.txtFrom.LostFocusColour = System.Drawing.Color.Empty
        Me.txtFrom.MaxLength = 10
        Me.txtFrom.MaxValue = 0
        Me.txtFrom.MinValue = 0
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(70, 22)
        Me.txtFrom.TabIndex = 10
        Me.txtFrom.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Rs"
        '
        'LoanIntSettingCtrl
        '
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtROI)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.Label2)
        Me.Name = "LoanIntSettingCtrl"
        Me.Size = New System.Drawing.Size(344, 32)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
