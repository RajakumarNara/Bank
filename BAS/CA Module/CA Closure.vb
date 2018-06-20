Public Class CA_Closure
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtAccNo As BankControls.TextControl
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCloseAcc As BankControls.NewButton
    Friend WithEvents btnExit As BankControls.NewButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnWithdraw As BankControls.NewButton
    Friend WithEvents btnNewRDCreation As BankControls.NewButton
    Friend WithEvents btnTransaction As BankControls.NewButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtpClosingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpAccDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtBalance As BankControls.NumericControl
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtROI As BankControls.NumericControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtIntAmt As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CA_Closure))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtAccNo = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.txtName = New BankControls.TextControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnCloseAcc = New BankControls.NewButton
        Me.btnExit = New BankControls.NewButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.btnWithdraw = New BankControls.NewButton
        Me.btnNewRDCreation = New BankControls.NewButton
        Me.btnTransaction = New BankControls.NewButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dtpClosingDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpAccDate = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtBalance = New BankControls.NumericControl
        Me.Label18 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtROI = New BankControls.NumericControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtIntAmt = New BankControls.NumericControl
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.btnCloseAcc)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(744, 248)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtAccNo)
        Me.Panel3.Controls.Add(Me.btnSearch)
        Me.Panel3.Controls.Add(Me.txtName)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(232, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(504, 56)
        Me.Panel3.TabIndex = 84
        '
        'txtAccNo
        '
        Me.txtAccNo.AlphaNumeric = True
        Me.txtAccNo.BackColor = System.Drawing.Color.White
        Me.txtAccNo.BlankSpace = False
        Me.txtAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccNo.Location = New System.Drawing.Point(104, 17)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.White
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.MaxLength = 10
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.Size = New System.Drawing.Size(120, 23)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 1
        Me.txtAccNo.Text = "SB"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(224, 17)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.AutoSize = False
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("BRH Kannada", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtName.Location = New System.Drawing.Point(312, 16)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(184, 24)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 3
        Me.txtName.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Account No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Name:"
        '
        'btnCloseAcc
        '
        Me.btnCloseAcc.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCloseAcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCloseAcc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseAcc.ForeColor = System.Drawing.Color.Black
        Me.btnCloseAcc.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnCloseAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCloseAcc.Location = New System.Drawing.Point(512, 196)
        Me.btnCloseAcc.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCloseAcc.Name = "btnCloseAcc"
        Me.btnCloseAcc.Size = New System.Drawing.Size(120, 40)
        Me.btnCloseAcc.TabIndex = 80
        Me.btnCloseAcc.Text = "C&lose Account"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(640, 196)
        Me.btnExit.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 40)
        Me.btnExit.TabIndex = 81
        Me.btnExit.Text = "E&xit"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btnWithdraw)
        Me.Panel4.Controls.Add(Me.btnNewRDCreation)
        Me.Panel4.Controls.Add(Me.btnTransaction)
        Me.Panel4.Location = New System.Drawing.Point(8, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(216, 224)
        Me.Panel4.TabIndex = 85
        '
        'btnWithdraw
        '
        Me.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWithdraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdraw.ForeColor = System.Drawing.Color.Black
        Me.btnWithdraw.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWithdraw.Location = New System.Drawing.Point(16, 88)
        Me.btnWithdraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(184, 40)
        Me.btnWithdraw.TabIndex = 12
        Me.btnWithdraw.Text = "WithDraw"
        '
        'btnNewRDCreation
        '
        Me.btnNewRDCreation.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnNewRDCreation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewRDCreation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNewRDCreation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRDCreation.ForeColor = System.Drawing.Color.Black
        Me.btnNewRDCreation.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnNewRDCreation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewRDCreation.Location = New System.Drawing.Point(16, 24)
        Me.btnNewRDCreation.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnNewRDCreation.Name = "btnNewRDCreation"
        Me.btnNewRDCreation.Size = New System.Drawing.Size(184, 40)
        Me.btnNewRDCreation.TabIndex = 11
        Me.btnNewRDCreation.Text = "New SB Account"
        '
        'btnTransaction
        '
        Me.btnTransaction.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransaction.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.ForeColor = System.Drawing.Color.Black
        Me.btnTransaction.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaction.Location = New System.Drawing.Point(16, 152)
        Me.btnTransaction.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(184, 40)
        Me.btnTransaction.TabIndex = 13
        Me.btnTransaction.Text = "Transaction"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dtpClosingDate)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dtpAccDate)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtBalance)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Location = New System.Drawing.Point(232, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 152)
        Me.Panel1.TabIndex = 82
        '
        'dtpClosingDate
        '
        Me.dtpClosingDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpClosingDate.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dtpClosingDate.CustomFormat = "dd / MMM / yyyy "
        Me.dtpClosingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpClosingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpClosingDate.Location = New System.Drawing.Point(112, 104)
        Me.dtpClosingDate.MaxDate = New Date(2456, 10, 18, 0, 0, 0, 0)
        Me.dtpClosingDate.MinDate = New Date(1964, 1, 1, 0, 0, 0, 0)
        Me.dtpClosingDate.Name = "dtpClosingDate"
        Me.dtpClosingDate.Size = New System.Drawing.Size(120, 22)
        Me.dtpClosingDate.TabIndex = 6
        Me.dtpClosingDate.Value = New Date(2007, 10, 3, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 17)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Closing Date"
        '
        'dtpAccDate
        '
        Me.dtpAccDate.CustomFormat = "dd / MMM / yyyy "
        Me.dtpAccDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAccDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAccDate.Location = New System.Drawing.Point(112, 64)
        Me.dtpAccDate.MaxDate = New Date(2456, 10, 18, 0, 0, 0, 0)
        Me.dtpAccDate.MinDate = New Date(1964, 1, 1, 0, 0, 0, 0)
        Me.dtpAccDate.Name = "dtpAccDate"
        Me.dtpAccDate.Size = New System.Drawing.Size(120, 22)
        Me.dtpAccDate.TabIndex = 5
        Me.dtpAccDate.Value = New Date(2007, 10, 3, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 17)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Opening Date"
        '
        'txtBalance
        '
        Me.txtBalance.AfterDecimal = 2
        Me.txtBalance.BeforeDecimal = 10
        Me.txtBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtBalance.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBalance.Location = New System.Drawing.Point(112, 24)
        Me.txtBalance.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBalance.MaxValue = 0
        Me.txtBalance.MinValue = 0
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(120, 22)
        Me.txtBalance.TabIndex = 4
        Me.txtBalance.Text = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 17)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Amount"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtROI)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtIntAmt)
        Me.Panel2.Location = New System.Drawing.Point(512, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(224, 96)
        Me.Panel2.TabIndex = 83
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Interest Amount"
        '
        'txtROI
        '
        Me.txtROI.AfterDecimal = 2
        Me.txtROI.BeforeDecimal = 10
        Me.txtROI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtROI.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtROI.Location = New System.Drawing.Point(120, 16)
        Me.txtROI.LostFocusColour = System.Drawing.Color.Empty
        Me.txtROI.MaxValue = 0
        Me.txtROI.MinValue = 0
        Me.txtROI.Name = "txtROI"
        Me.txtROI.Size = New System.Drawing.Size(48, 22)
        Me.txtROI.TabIndex = 7
        Me.txtROI.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 17)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "ROI"
        '
        'txtIntAmt
        '
        Me.txtIntAmt.AfterDecimal = 2
        Me.txtIntAmt.BeforeDecimal = 10
        Me.txtIntAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtIntAmt.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtIntAmt.Location = New System.Drawing.Point(120, 56)
        Me.txtIntAmt.LostFocusColour = System.Drawing.Color.Empty
        Me.txtIntAmt.MaxValue = 0
        Me.txtIntAmt.MinValue = 0
        Me.txtIntAmt.Name = "txtIntAmt"
        Me.txtIntAmt.Size = New System.Drawing.Size(96, 22)
        Me.txtIntAmt.TabIndex = 8
        Me.txtIntAmt.Text = ""
        '
        'CA_Closure
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.ClientSize = New System.Drawing.Size(760, 261)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CA_Closure"
        Me.Text = "CA_Closure"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
