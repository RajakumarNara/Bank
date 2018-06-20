Public Class frmSBClouser
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpAccDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtAccNo As BankControls.TextControl
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtROI As BankControls.NumericControl
    Friend WithEvents txtIntAmt As BankControls.NumericControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnCloseAcc As BankControls.NewButton
    Friend WithEvents btnWithdraw As BankControls.NewButton
    Friend WithEvents btnNewRDCreation As BankControls.NewButton
    Friend WithEvents btnTransaction As BankControls.NewButton
    Friend WithEvents btnExit As BankControls.NewButton
    Friend WithEvents dtpClosingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAvalBalance As BankControls.NumericControl
    Friend WithEvents txtBookBalance As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSBClouser))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtBookBalance = New BankControls.NumericControl
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpClosingDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpAccDate = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtAvalBalance = New BankControls.NumericControl
        Me.Label18 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtROI = New BankControls.NumericControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtIntAmt = New BankControls.NumericControl
        Me.btnCloseAcc = New BankControls.NewButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtAccNo = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.txtName = New BankControls.TextControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.btnWithdraw = New BankControls.NewButton
        Me.btnNewRDCreation = New BankControls.NewButton
        Me.btnTransaction = New BankControls.NewButton
        Me.btnExit = New BankControls.NewButton
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtBookBalance)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dtpClosingDate)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dtpAccDate)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtAvalBalance)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Location = New System.Drawing.Point(232, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 152)
        Me.Panel1.TabIndex = 4
        '
        'txtBookBalance
        '
        Me.txtBookBalance.AfterDecimal = 2
        Me.txtBookBalance.BeforeDecimal = 10
        Me.txtBookBalance.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookBalance.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBookBalance.Location = New System.Drawing.Point(136, 48)
        Me.txtBookBalance.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBookBalance.MaxValue = 0
        Me.txtBookBalance.MinValue = 0
        Me.txtBookBalance.Name = "txtBookBalance"
        Me.txtBookBalance.Size = New System.Drawing.Size(128, 23)
        Me.txtBookBalance.TabIndex = 6
        Me.txtBookBalance.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 19)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "Book Balance :"
        '
        'dtpClosingDate
        '
        Me.dtpClosingDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpClosingDate.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dtpClosingDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpClosingDate.Enabled = False
        Me.dtpClosingDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpClosingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpClosingDate.Location = New System.Drawing.Point(136, 120)
        Me.dtpClosingDate.MaxDate = New Date(9998, 10, 18, 0, 0, 0, 0)
        Me.dtpClosingDate.MinDate = New Date(1964, 1, 1, 0, 0, 0, 0)
        Me.dtpClosingDate.Name = "dtpClosingDate"
        Me.dtpClosingDate.Size = New System.Drawing.Size(128, 23)
        Me.dtpClosingDate.TabIndex = 8
        Me.dtpClosingDate.Value = New Date(2007, 10, 3, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 19)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Closing Date :"
        '
        'dtpAccDate
        '
        Me.dtpAccDate.CustomFormat = "dd - MMM - yyyy "
        Me.dtpAccDate.Enabled = False
        Me.dtpAccDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAccDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAccDate.Location = New System.Drawing.Point(136, 80)
        Me.dtpAccDate.MaxDate = New Date(9998, 10, 18, 0, 0, 0, 0)
        Me.dtpAccDate.MinDate = New Date(1964, 1, 1, 0, 0, 0, 0)
        Me.dtpAccDate.Name = "dtpAccDate"
        Me.dtpAccDate.Size = New System.Drawing.Size(128, 23)
        Me.dtpAccDate.TabIndex = 7
        Me.dtpAccDate.Value = New Date(2007, 10, 3, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 19)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Opening Date :"
        '
        'txtAvalBalance
        '
        Me.txtAvalBalance.AfterDecimal = 2
        Me.txtAvalBalance.BeforeDecimal = 10
        Me.txtAvalBalance.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvalBalance.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAvalBalance.Location = New System.Drawing.Point(136, 16)
        Me.txtAvalBalance.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAvalBalance.MaxValue = 0
        Me.txtAvalBalance.MinValue = 0
        Me.txtAvalBalance.Name = "txtAvalBalance"
        Me.txtAvalBalance.Size = New System.Drawing.Size(128, 23)
        Me.txtAvalBalance.TabIndex = 5
        Me.txtAvalBalance.Text = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(133, 19)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Available Balance :"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtROI)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtIntAmt)
        Me.Panel2.Location = New System.Drawing.Point(512, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(240, 104)
        Me.Panel2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 19)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Interest Amount :"
        '
        'txtROI
        '
        Me.txtROI.AfterDecimal = 2
        Me.txtROI.BeforeDecimal = 10
        Me.txtROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtROI.Location = New System.Drawing.Point(136, 24)
        Me.txtROI.LostFocusColour = System.Drawing.Color.Empty
        Me.txtROI.MaxValue = 0
        Me.txtROI.MinValue = 0
        Me.txtROI.Name = "txtROI"
        Me.txtROI.Size = New System.Drawing.Size(48, 23)
        Me.txtROI.TabIndex = 10
        Me.txtROI.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 19)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "ROI :"
        '
        'txtIntAmt
        '
        Me.txtIntAmt.AfterDecimal = 2
        Me.txtIntAmt.BeforeDecimal = 10
        Me.txtIntAmt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntAmt.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtIntAmt.Location = New System.Drawing.Point(136, 64)
        Me.txtIntAmt.LostFocusColour = System.Drawing.Color.Empty
        Me.txtIntAmt.MaxValue = 0
        Me.txtIntAmt.MinValue = 0
        Me.txtIntAmt.Name = "txtIntAmt"
        Me.txtIntAmt.ReadOnly = True
        Me.txtIntAmt.Size = New System.Drawing.Size(96, 23)
        Me.txtIntAmt.TabIndex = 11
        Me.txtIntAmt.Text = ""
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
        Me.btnCloseAcc.Location = New System.Drawing.Point(512, 200)
        Me.btnCloseAcc.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCloseAcc.Name = "btnCloseAcc"
        Me.btnCloseAcc.Size = New System.Drawing.Size(120, 40)
        Me.btnCloseAcc.TabIndex = 12
        Me.btnCloseAcc.Text = "C&lose Account"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtAccNo)
        Me.Panel3.Controls.Add(Me.btnSearch)
        Me.Panel3.Controls.Add(Me.txtName)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(232, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(520, 56)
        Me.Panel3.TabIndex = 0
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
        Me.btnSearch.Location = New System.Drawing.Point(232, 17)
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
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtName.Location = New System.Drawing.Point(328, 16)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(184, 24)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 3
        Me.txtName.TabStop = False
        Me.txtName.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 19)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Account No.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(272, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 19)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Name:"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btnWithdraw)
        Me.Panel4.Controls.Add(Me.btnNewRDCreation)
        Me.Panel4.Controls.Add(Me.btnTransaction)
        Me.Panel4.Location = New System.Drawing.Point(8, 16)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(216, 224)
        Me.Panel4.TabIndex = 14
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
        Me.btnWithdraw.TabIndex = 16
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
        Me.btnNewRDCreation.TabIndex = 15
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
        Me.btnTransaction.TabIndex = 17
        Me.btnTransaction.Text = "Transaction"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(640, 200)
        Me.btnExit.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 40)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        '
        'frmSBClouser
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(754, 247)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnCloseAcc)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSBClouser"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SB Closure"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmSBClouser
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmSBClouser
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmSBClouser
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmSBClouser)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Variables"

    Dim objSBAcc As New clsSavingsBank

#End Region


#Region "Functions"

    Public Function fnGetSBDet() As Boolean

        If objSBAcc.fnGetSBDetTable(txtAccNo.Text) Then
            fnClearData()
            txtAccNo.Text = objSBAcc.SBAccTable.Rows(0).Item("AccountNo")
            txtAvalBalance.Text = objSBAcc.SBAccTable.Rows(0).Item("AvailBalance")
            txtBookBalance.Text = objSBAcc.SBAccTable.Rows(0).Item("BookBalance")
            dtpAccDate.Value = Format(objSBAcc.SBAccTable.Rows(0).Item("AccDate"), "yyyy-MM-dd")
            txtName.Text = objSBAcc.SBAccTable.Rows(0).Item("Name")
        End If
    End Function

    Public Function fnGetInterest() As Boolean
        If objSBAcc.fnGetInterest(txtAccNo.Text) Then
            txtIntAmt.Text = objSBAcc.InterestDettable.Rows(0).Item("InterestAmount")
        Else
            txtIntAmt.Text = 0
        End If
    End Function

    Public Function fnCloseSBAcc()

        If MsgBox("Do you want to close this account permanently", MsgBoxStyle.YesNo, "SB Module") = MsgBoxResult.Yes Then
            If objSBAcc.fnCheckSBAccount(txtAccNo.Text) Then
                If objSBAcc.fnCloseSBAccount(dtpClosingDate.Value, txtAccNo.Text) Then
                    MsgBox("SB account no '" & txtAccNo.Text & "' Closed successfully", MsgBoxStyle.Exclamation, "SB Module")
                Else
                    MsgBox("SB account no '" & txtAccNo.Text & "' Cannot be closed due to internal ERROR!", MsgBoxStyle.Exclamation, "SB Module")
                End If
                fnClearData()
            Else
                MsgBox("Please check the account no,account no doesnot exist", MsgBoxStyle.Critical, "SB Module")
            End If
        End If

    End Function

    Public Function fnClearData()

        txtAccNo.Text = String.Empty
        txtAvalBalance.Text = String.Empty
        txtBookBalance.Text = String.Empty
        txtName.Text = String.Empty

    End Function

    Public Function fnCheckData() As Boolean

        If txtAccNo.Text = String.Empty Then
            MsgBox("Account no cannot be blank", MsgBoxStyle.Exclamation, "SB Module")
            txtAccNo.Focus()
            Return False
        ElseIf txtName.Text = String.Empty Then
            MsgBox("Account holder name cannot be blank", MsgBoxStyle.Exclamation, "SB Module")
            txtName.Focus()
            Return False
        ElseIf txtIntAmt.Text <> 0 Then
            MsgBox("Clear the intrest before closing the account", MsgBoxStyle.Exclamation, "SB Module")
            txtROI.Focus()
            Return False
        ElseIf txtAvalBalance.Text <> 0 Then
            MsgBox("Clear the balance befor closing the account", MsgBoxStyle.Exclamation, "SB Module")
            txtAvalBalance.Focus()
            Return False
        Else
            Return True
        End If
    End Function

#End Region

#Region "Events"

    Private Sub frmSBClouser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpAccDate.Value = Date.Now
        txtAvalBalance.ReadOnly = True
        txtBookBalance.ReadOnly = True
        dtpClosingDate.Value = Date.Now

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim objsbCust As New frmSBAccSearch
        objsbCust.strSBAccountNo = String.Empty
        objsbCust.ShowDialog(Me)
        If objsbCust.strSBAccountNo <> String.Empty Then
            txtAccNo.Text = objsbCust.strSBAccountNo
            fnGetSBDet()
            fnGetInterest()
        End If

    End Sub

    Private Sub btnCloseAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseAcc.Click

        If fnCheckData() Then
            fnCloseSBAcc()
        End If

    End Sub

    Private Sub btnNewRDCreation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRDCreation.Click
        Dim objFrmNewSB As frmSBAccCreation
        objFrmNewSB = frmSBAccCreation.DefInstance
        objFrmNewSB.MdiParent = Me.MdiParent
        objFrmNewSB.Show()
        objFrmNewSB = Nothing
    End Sub

    Private Sub btnWithdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithdraw.Click
        If txtAccNo.Text <> "SB" Then
            Dim objfrmSBWithDraw As New frmCashTransaction
            objfrmSBWithDraw.txtAccNo.Text = txtAccNo.Text
            objfrmSBWithDraw.rdWithdraw.Checked = True
            objfrmSBWithDraw.ShowDialog()
            fnGetSBDet()
        Else
            MsgBox("Enter the account number", MsgBoxStyle.Exclamation)
            txtAccNo.Focus()
        End If

    End Sub

    Private Sub btnTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransaction.Click
        If txtAccNo.Text <> "SB" Then
            Dim objfrmSBTransaction As New frmSBStmtOfAccount
            objfrmSBTransaction.txtAccno.Text = txtAccNo.Text
            objfrmSBTransaction.ShowDialog()
        Else
            MsgBox("Enter the account number", MsgBoxStyle.Exclamation)
            txtAccNo.Focus()
        End If

    End Sub

    Private Sub btnExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub txtAccNo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccNo.KeyUp

        If e.KeyCode = Keys.F3 Then
            btnSearch_Click(Me, e.Empty)
        End If
        If txtAccNo.Text = "SB" Then
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.D Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Home Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtAccNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAccNo.KeyPress

        If txtAccNo.Text = "SB" Then
            If e.KeyChar = Chr(8) Or e.KeyChar = Chr(68) Or e.KeyChar = Chr(37) Or e.KeyChar = Chr(38) Or e.KeyChar = Chr(36) Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtAccNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccNo.KeyDown

        If txtAccNo.Text = "SB" Then
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.D Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Home Or e.KeyCode = Keys.Delete Then
                e.Handled = True
            End If
        End If

    End Sub


#End Region

    'Private Sub txtAccNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccNo.Leave
    '    If Trim(txtAccNo.Text <> String.Empty) Then
    '        AutoLoad()
    '    End If
    'End Sub

    'Public Sub AutoLoad()
    '    Select Case txtAccNo.Text.Length
    '        Case "1"
    '            txtAccNo.Text = "SB0000" & txtAccNo.Text
    '        Case "2"
    '            txtAccNo.Text = "SB000" & txtAccNo.Text
    '        Case "3"
    '            txtAccNo.Text = "SB00" & txtAccNo.Text
    '        Case "4"
    '            txtAccNo.Text = "SB0" & txtAccNo.Text
    '        Case "5"
    '            txtAccNo.Text = "SB" & txtAccNo.Text
    '    End Select
    'End Sub
End Class
