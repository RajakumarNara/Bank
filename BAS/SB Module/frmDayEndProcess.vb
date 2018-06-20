Public Class frmDayEndProcess
    Inherits System.Windows.Forms.Form
    Dim objRd As New clsRDAccount
    Dim dtDayDtl As New DataTable
    Dim intCount As Integer
    Dim RDNo As String
    Dim Balance As Double
    Dim row As Integer
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
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents dtpODLoanDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As BankControls.TextControl
    Friend WithEvents NewButton1 As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDayEndProcess))
        Me.txtReceiptNo = New BankControls.NumericControl
        Me.Label27 = New System.Windows.Forms.Label
        Me.dtpODLoanDate = New System.Windows.Forms.DateTimePicker
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNarration = New BankControls.TextControl
        Me.NewButton1 = New BankControls.NewButton
        Me.SuspendLayout()
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 0
        Me.txtReceiptNo.BeforeDecimal = 7
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(144, 88)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtReceiptNo.MaxLength = 10
        Me.txtReceiptNo.MaxValue = 0
        Me.txtReceiptNo.MinValue = 0
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(136, 23)
        Me.txtReceiptNo.TabIndex = 163
        Me.txtReceiptNo.Text = ""
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.LightYellow
        Me.Label27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(48, 88)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(93, 19)
        Me.Label27.TabIndex = 165
        Me.Label27.Text = "Receipt No. :"
        '
        'dtpODLoanDate
        '
        Me.dtpODLoanDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpODLoanDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpODLoanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpODLoanDate.Location = New System.Drawing.Point(144, 48)
        Me.dtpODLoanDate.MaxDate = New Date(9998, 11, 18, 0, 0, 0, 0)
        Me.dtpODLoanDate.Name = "dtpODLoanDate"
        Me.dtpODLoanDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpODLoanDate.TabIndex = 162
        Me.dtpODLoanDate.Value = New Date(2010, 5, 25, 0, 0, 0, 0)
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.LightYellow
        Me.Label37.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(48, 48)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(47, 19)
        Me.Label37.TabIndex = 164
        Me.Label37.Text = "Date :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(56, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 19)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "Narration :"
        '
        'txtNarration
        '
        Me.txtNarration.AlphaNumeric = True
        Me.txtNarration.BlankSpace = True
        Me.txtNarration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtNarration.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNarration.Location = New System.Drawing.Point(144, 136)
        Me.txtNarration.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNarration.Mandatory = False
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarration.Size = New System.Drawing.Size(256, 40)
        Me.txtNarration.SpecialChar = False
        Me.txtNarration.TabIndex = 166
        Me.txtNarration.Text = ""
        '
        'NewButton1
        '
        Me.NewButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NewButton1.BackColor = System.Drawing.Color.LightYellow
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.ForeColor = System.Drawing.Color.Black
        Me.NewButton1.GotFocusColour = System.Drawing.Color.LightYellow
        Me.NewButton1.Image = CType(resources.GetObject("NewButton1.Image"), System.Drawing.Image)
        Me.NewButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton1.Location = New System.Drawing.Point(144, 216)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.LightYellow
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(120, 48)
        Me.NewButton1.TabIndex = 168
        Me.NewButton1.Text = "&DayEnd"
        Me.NewButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmDayEndProcess
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 341)
        Me.Controls.Add(Me.NewButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNarration)
        Me.Controls.Add(Me.txtReceiptNo)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.dtpODLoanDate)
        Me.Controls.Add(Me.Label37)
        Me.Name = "frmDayEndProcess"
        Me.Text = "frmDayEndProcess"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click
        'If (objRd.fnGetRDDayDetails()) Then
        '    dtDayDtl = objRd.dtIntPost()
        '    intCount = dtDayDtl.Rows.Count
        '    row = 0
        '    While (intCount > 0)


        '        RDNo = dtDayDtl.Rows(row).Item("RDNo")
        '        Balance = dtDayDtl.Rows(row).Item("Balance")
        '        Today = Date.Now
        '        objRd.fnInsertDetails(RDNo, Balance, Today)


        '        intCount -= 1
        '        row += 1
        '    End While


        'End If
        ''If (objPigmy.fnGetPigmyDayDetails()) Then
        '    dtDayDtl = objPigmy.dtIntPost()
        '    intCount = dtDayDtl.Rows.Count
        '    row = 0
        '    While (intCount > 0)


        '        AccountNo = dtDayDtl.Rows(row).Item("AccountNo")
        '        Balance = dtDayDtl.Rows(row).Item("Balance")
        '        Today = Date.Now
        '        objRd.fnInsertDetails(AccountNo, Balance, Today)


        '        intCount -= 1
        '    End While
        '    row += 1
        '    MsgBox("Successfuly entered", MsgBoxStyle.Exclamation)
        'End If
    End Sub

    Private Sub frmDayEndProcess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpODLoanDate.Value = Date.Now
    End Sub
End Class
