Public Class IntSettingsCtrl
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFrom As BankControls.NumericControl
    Friend WithEvents txtROI As BankControls.NumericControl
    Friend WithEvents txtTo As BankControls.TextControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtFrom = New BankControls.NumericControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtROI = New BankControls.NumericControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTo = New BankControls.TextControl
        Me.SuspendLayout()
        '
        'txtFrom
        '
        Me.txtFrom.AfterDecimal = 2
        Me.txtFrom.BeforeDecimal = 7
        Me.txtFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrom.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFrom.Location = New System.Drawing.Point(8, 8)
        Me.txtFrom.LostFocusColour = System.Drawing.Color.Empty
        Me.txtFrom.MaxLength = 10
        Me.txtFrom.MaxValue = 0
        Me.txtFrom.MinValue = 0
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(64, 22)
        Me.txtFrom.TabIndex = 1
        Me.txtFrom.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Days"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(184, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Days"
        '
        'txtROI
        '
        Me.txtROI.AfterDecimal = 2
        Me.txtROI.BeforeDecimal = 7
        Me.txtROI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtROI.Location = New System.Drawing.Point(240, 8)
        Me.txtROI.LostFocusColour = System.Drawing.Color.Empty
        Me.txtROI.MaxLength = 5
        Me.txtROI.MaxValue = 0
        Me.txtROI.MinValue = 0
        Me.txtROI.Name = "txtROI"
        Me.txtROI.Size = New System.Drawing.Size(72, 22)
        Me.txtROI.TabIndex = 3
        Me.txtROI.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(312, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "%"
        '
        'txtTo
        '
        Me.txtTo.AlphaNumeric = True
        Me.txtTo.BackColor = System.Drawing.Color.White
        Me.txtTo.BlankSpace = False
        Me.txtTo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtTo.Location = New System.Drawing.Point(120, 5)
        Me.txtTo.LostFocusColour = System.Drawing.Color.White
        Me.txtTo.Mandatory = False
        Me.txtTo.MaxLength = 10
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(64, 23)
        Me.txtTo.SpecialChar = False
        Me.txtTo.TabIndex = 2
        Me.txtTo.Text = ""
        '
        'IntSettingsCtrl
        '
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtROI)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.Label2)
        Me.Name = "IntSettingsCtrl"
        Me.Size = New System.Drawing.Size(344, 32)
        Me.ResumeLayout(False)

    End Sub

#End Region

 
End Class
