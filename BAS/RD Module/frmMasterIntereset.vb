Public Class frmMasterIntereset
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRefNo As BankControls.NumericControl
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents NumericControl1 As BankControls.NumericControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.NumericControl1 = New BankControls.NumericControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.txtRefNo = New BankControls.NumericControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline)
        Me.Label1.Location = New System.Drawing.Point(128, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Master Form For Interest Settings"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.NumericControl1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.txtRefNo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(8, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(512, 256)
        Me.Panel1.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ComboBox1.Location = New System.Drawing.Point(240, 88)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(64, 24)
        Me.ComboBox1.TabIndex = 100
        '
        'NumericControl1
        '
        Me.NumericControl1.AfterDecimal = 2
        Me.NumericControl1.BeforeDecimal = 7
        Me.NumericControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericControl1.GotFocusColour = System.Drawing.SystemColors.Info
        Me.NumericControl1.Location = New System.Drawing.Point(240, 120)
        Me.NumericControl1.LostFocusColour = System.Drawing.Color.Empty
        Me.NumericControl1.MaxValue = 0
        Me.NumericControl1.MinValue = 0
        Me.NumericControl1.Name = "NumericControl1"
        Me.NumericControl1.Size = New System.Drawing.Size(168, 23)
        Me.NumericControl1.TabIndex = 99
        Me.NumericControl1.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 24)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "New Rate Of Interest"
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(240, 64)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(64, 24)
        Me.RadioButton1.TabIndex = 97
        Me.RadioButton1.Text = "Add"
        '
        'txtRefNo
        '
        Me.txtRefNo.AfterDecimal = 2
        Me.txtRefNo.BeforeDecimal = 7
        Me.txtRefNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRefNo.Location = New System.Drawing.Point(240, 32)
        Me.txtRefNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRefNo.MaxValue = 0
        Me.txtRefNo.MinValue = 0
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(168, 23)
        Me.txtRefNo.TabIndex = 96
        Me.txtRefNo.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Current Rate Of Interest"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(336, 64)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(64, 24)
        Me.RadioButton2.TabIndex = 97
        Me.RadioButton2.Text = "Minus"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 24)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Select the Precentage"
        '
        'frmMasterIntereset
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(528, 301)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMasterIntereset"
        Me.ShowInTaskbar = False
        Me.Text = "MasterIntereset"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMasterIntereset_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
