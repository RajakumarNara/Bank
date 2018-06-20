Public Class frmChequeDepositDetail
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
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvDepositedCheques As System.Windows.Forms.ListView
    Friend WithEvents cmbSearchItems As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As BankControls.TextControl
    Friend WithEvents dtpChequeDepDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnUpdateStatus As BankControls.NewButton
    Friend WithEvents btnDeposit As BankControls.NewButton
    Friend WithEvents btnViewChqTran As BankControls.NewButton
    Friend WithEvents btnNewSBAcc As BankControls.NewButton
    Friend WithEvents NewButton7 As BankControls.NewButton
    Friend WithEvents btnStpCheque As BankControls.NewButton
    Friend WithEvents btnWithDraw As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmChequeDepositDetail))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblMessage = New System.Windows.Forms.Label
        Me.lvDepositedCheques = New System.Windows.Forms.ListView
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.cmbSearchItems = New System.Windows.Forms.ComboBox
        Me.btnCancel = New BankControls.NewButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSearch = New BankControls.NewButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSearch = New BankControls.TextControl
        Me.dtpChequeDepDate = New System.Windows.Forms.DateTimePicker
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnUpdateStatus = New BankControls.NewButton
        Me.btnDeposit = New BankControls.NewButton
        Me.btnViewChqTran = New BankControls.NewButton
        Me.btnNewSBAcc = New BankControls.NewButton
        Me.NewButton7 = New BankControls.NewButton
        Me.btnStpCheque = New BankControls.NewButton
        Me.btnWithDraw = New BankControls.NewButton
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.lblMessage)
        Me.GroupBox1.Controls.Add(Me.lvDepositedCheques)
        Me.GroupBox1.Controls.Add(Me.cmbSearchItems)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(232, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 608)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Teal
        Me.Label32.Location = New System.Drawing.Point(96, 8)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(200, 25)
        Me.Label32.TabIndex = 116
        Me.Label32.Text = "Cheque Deposit Detail"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(32, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 117
        Me.PictureBox1.TabStop = False
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(24, 104)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(287, 19)
        Me.lblMessage.TabIndex = 112
        Me.lblMessage.Text = "There are 0 records found for your search"
        '
        'lvDepositedCheques
        '
        Me.lvDepositedCheques.BackColor = System.Drawing.Color.FromArgb(CType(243, Byte), CType(254, Byte), CType(254, Byte))
        Me.lvDepositedCheques.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader10, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader11})
        Me.lvDepositedCheques.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDepositedCheques.FullRowSelect = True
        Me.lvDepositedCheques.GridLines = True
        Me.lvDepositedCheques.Location = New System.Drawing.Point(16, 128)
        Me.lvDepositedCheques.MultiSelect = False
        Me.lvDepositedCheques.Name = "lvDepositedCheques"
        Me.lvDepositedCheques.Size = New System.Drawing.Size(744, 416)
        Me.lvDepositedCheques.TabIndex = 111
        Me.lvDepositedCheques.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "SlNo"
        Me.ColumnHeader12.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "AccountNo"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "BankName"
        Me.ColumnHeader2.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "BranchName"
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ChequeDate"
        Me.ColumnHeader4.Width = 90
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ChequeNo"
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "DepositDate"
        Me.ColumnHeader6.Width = 90
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Amount"
        Me.ColumnHeader7.Width = 90
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Status"
        Me.ColumnHeader10.Width = 90
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ClearanceDate"
        Me.ColumnHeader8.Width = 90
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "BankCharges"
        Me.ColumnHeader9.Width = 90
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Remarks"
        Me.ColumnHeader11.Width = 100
        '
        'cmbSearchItems
        '
        Me.cmbSearchItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchItems.Location = New System.Drawing.Point(328, -24)
        Me.cmbSearchItems.Name = "cmbSearchItems"
        Me.cmbSearchItems.Size = New System.Drawing.Size(216, 24)
        Me.cmbSearchItems.TabIndex = 114
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(664, 560)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 40)
        Me.btnCancel.TabIndex = 113
        Me.btnCancel.Text = "&Cancel"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.dtpChequeDepDate)
        Me.Panel1.Controls.Add(Me.cmbType)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(24, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 56)
        Me.Panel1.TabIndex = 110
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(656, 16)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(32, 24)
        Me.btnSearch.TabIndex = 110
        Me.btnSearch.Text = "Search"
        Me.btnSearch.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(408, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "SearchText"
        '
        'txtSearch
        '
        Me.txtSearch.AlphaNumeric = True
        Me.txtSearch.BlankSpace = False
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSearch.Location = New System.Drawing.Point(496, 16)
        Me.txtSearch.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtSearch.Mandatory = False
        Me.txtSearch.MaxLength = 50
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(152, 23)
        Me.txtSearch.SpecialChar = False
        Me.txtSearch.TabIndex = 105
        Me.txtSearch.Text = ""
        '
        'dtpChequeDepDate
        '
        Me.dtpChequeDepDate.CustomFormat = "dd / MMM / yyyy"
        Me.dtpChequeDepDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpChequeDepDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpChequeDepDate.Location = New System.Drawing.Point(496, 16)
        Me.dtpChequeDepDate.MaxDate = New Date(2331, 11, 17, 0, 0, 0, 0)
        Me.dtpChequeDepDate.Name = "dtpChequeDepDate"
        Me.dtpChequeDepDate.Size = New System.Drawing.Size(152, 23)
        Me.dtpChequeDepDate.TabIndex = 109
        Me.dtpChequeDepDate.Value = New Date(2007, 10, 11, 0, 0, 0, 0)
        Me.dtpChequeDepDate.Visible = False
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Items.AddRange(New Object() {"ChequeNo", "AccountNo", "BankName", "BranchName", "ChequeAmount", "ChequeStatus", "DepositDate"})
        Me.cmbType.Location = New System.Drawing.Point(112, 16)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(216, 24)
        Me.cmbType.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(40, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 19)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "SearchBy"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnUpdateStatus)
        Me.Panel2.Controls.Add(Me.btnDeposit)
        Me.Panel2.Controls.Add(Me.btnViewChqTran)
        Me.Panel2.Controls.Add(Me.btnNewSBAcc)
        Me.Panel2.Controls.Add(Me.NewButton7)
        Me.Panel2.Controls.Add(Me.btnStpCheque)
        Me.Panel2.Controls.Add(Me.btnWithDraw)
        Me.Panel2.Location = New System.Drawing.Point(8, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(208, 600)
        Me.Panel2.TabIndex = 116
        '
        'btnUpdateStatus
        '
        Me.btnUpdateStatus.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnUpdateStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdateStatus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateStatus.ForeColor = System.Drawing.Color.Black
        Me.btnUpdateStatus.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnUpdateStatus.Image = CType(resources.GetObject("btnUpdateStatus.Image"), System.Drawing.Image)
        Me.btnUpdateStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateStatus.Location = New System.Drawing.Point(16, 232)
        Me.btnUpdateStatus.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnUpdateStatus.Name = "btnUpdateStatus"
        Me.btnUpdateStatus.Size = New System.Drawing.Size(176, 40)
        Me.btnUpdateStatus.TabIndex = 9
        Me.btnUpdateStatus.Text = "Update Status"
        Me.btnUpdateStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposit.ForeColor = System.Drawing.Color.Black
        Me.btnDeposit.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnDeposit.Image = CType(resources.GetObject("btnDeposit.Image"), System.Drawing.Image)
        Me.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeposit.Location = New System.Drawing.Point(16, 272)
        Me.btnDeposit.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(176, 40)
        Me.btnDeposit.TabIndex = 10
        Me.btnDeposit.Text = "Cheque Deposit"
        Me.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnViewChqTran
        '
        Me.btnViewChqTran.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnViewChqTran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewChqTran.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnViewChqTran.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewChqTran.ForeColor = System.Drawing.Color.Black
        Me.btnViewChqTran.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnViewChqTran.Location = New System.Drawing.Point(16, 440)
        Me.btnViewChqTran.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnViewChqTran.Name = "btnViewChqTran"
        Me.btnViewChqTran.Size = New System.Drawing.Size(176, 40)
        Me.btnViewChqTran.TabIndex = 11
        Me.btnViewChqTran.Text = "View Transaction Log(Cheque)"
        Me.btnViewChqTran.Visible = False
        '
        'btnNewSBAcc
        '
        Me.btnNewSBAcc.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnNewSBAcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewSBAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNewSBAcc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewSBAcc.ForeColor = System.Drawing.Color.Black
        Me.btnNewSBAcc.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnNewSBAcc.Image = CType(resources.GetObject("btnNewSBAcc.Image"), System.Drawing.Image)
        Me.btnNewSBAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewSBAcc.Location = New System.Drawing.Point(16, 120)
        Me.btnNewSBAcc.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnNewSBAcc.Name = "btnNewSBAcc"
        Me.btnNewSBAcc.Size = New System.Drawing.Size(176, 40)
        Me.btnNewSBAcc.TabIndex = 8
        Me.btnNewSBAcc.Text = "New CA Account"
        Me.btnNewSBAcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NewButton7
        '
        Me.NewButton7.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton7.ForeColor = System.Drawing.Color.Black
        Me.NewButton7.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.NewButton7.Location = New System.Drawing.Point(16, 480)
        Me.NewButton7.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton7.Name = "NewButton7"
        Me.NewButton7.Size = New System.Drawing.Size(176, 40)
        Me.NewButton7.TabIndex = 13
        Me.NewButton7.Text = "View Stopped Cheque Details"
        Me.NewButton7.Visible = False
        '
        'btnStpCheque
        '
        Me.btnStpCheque.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnStpCheque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStpCheque.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStpCheque.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStpCheque.ForeColor = System.Drawing.Color.Black
        Me.btnStpCheque.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnStpCheque.Location = New System.Drawing.Point(16, 352)
        Me.btnStpCheque.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnStpCheque.Name = "btnStpCheque"
        Me.btnStpCheque.Size = New System.Drawing.Size(176, 40)
        Me.btnStpCheque.TabIndex = 12
        Me.btnStpCheque.Text = "Cheque Stop Pay"
        Me.btnStpCheque.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnWithDraw
        '
        Me.btnWithDraw.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnWithDraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithDraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWithDraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithDraw.ForeColor = System.Drawing.Color.Black
        Me.btnWithDraw.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnWithDraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWithDraw.Location = New System.Drawing.Point(16, 312)
        Me.btnWithDraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnWithDraw.Name = "btnWithDraw"
        Me.btnWithDraw.Size = New System.Drawing.Size(176, 40)
        Me.btnWithDraw.TabIndex = 10
        Me.btnWithDraw.Text = "Cheque Withdraw"
        Me.btnWithDraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmChequeDepositDetail
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1016, 621)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmChequeDepositDetail"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cheque Deposit Detail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmChequeDepositDetail
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmChequeDepositDetail
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmChequeDepositDetail
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmChequeDepositDetail)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Form Global Variables"
    Dim objCA As New clsCurrentAccount
    Dim dvCACheques As DataView
    Dim strFilter As String = "CAccountNo like '%'"

#End Region

#Region "Functions"

    Function fnLoadSearchItems(ByVal strfield As String)
        cmbSearchItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        cmbSearchItems.Location = New System.Drawing.Point(88, 40)
        cmbSearchItems.Size = New System.Drawing.Size(152, 22)
        Me.Panel1.Controls.Add(cmbSearchItems)
        Dim dt As New DataTable
        cmbSearchItems.Items.Clear()
        For Each drrow As DataRow In dt.Rows
            cmbSearchItems.Items.Add(drrow(strfield))
        Next
        cmbSearchItems.Show()
        cmbSearchItems.DropDownStyle = ComboBoxStyle.DropDown
        cmbSearchItems.BringToFront()
    End Function

#End Region

#Region " Sub Routines"

    Sub sbLoadDepositedCheques()
        Dim intCounter As Integer
        Dim lvItem As ListViewItem
        dvCACheques.RowFilter = strFilter
        lvDepositedCheques.Items.Clear()
        Try
            If dvCACheques.Count > 0 Then
                lblMessage.Text = "There are " & dvCACheques.Count & " records found for your search"
                While intCounter < dvCACheques.Count
                    lvItem = lvDepositedCheques.Items.Add(dvCACheques.Item(intCounter).Item("SlNo"))
                    lvItem.SubItems.Add(dvCACheques.Item(intCounter).Item("CAccountNo"))
                    lvItem.SubItems.Add(dvCACheques.Item(intCounter).Item("BankName"))
                    lvItem.SubItems.Add(dvCACheques.Item(intCounter).Item("BranchName"))
                    lvItem.SubItems.Add(Format(dvCACheques.Item(intCounter).Item("ChequeDate"), "dd-MMM-yyyy"))
                    lvItem.SubItems.Add(dvCACheques.Item(intCounter).Item("ChequeNo"))
                    lvItem.SubItems.Add(Format(dvCACheques.Item(intCounter).Item("DepositDate"), "dd-MMM-yyyy"))
                    lvItem.SubItems.Add(dvCACheques.Item(intCounter).Item("ChequeAmount"))
                    lvItem.SubItems.Add(dvCACheques.Item(intCounter).Item("ChequeStatus"))
                    If IsDBNull(dvCACheques.Item(intCounter).Item("ClearanceDate")) Then
                        lvItem.SubItems.Add("")
                    Else
                        lvItem.SubItems.Add(Format(dvCACheques.Item(intCounter).Item("ClearanceDate"), "dd-MMM-yyyy"))
                    End If

                    lvItem.SubItems.Add(dvCACheques.Item(intCounter).Item("BankCharges"))
                    lvItem.SubItems.Add(dvCACheques.Item(intCounter).Item("Narration"))
                    intCounter += 1
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

#End Region

#Region "Event"
    Private Sub btnNewSBAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewSBAcc.Click
        Dim objCANew As New frmCAccCreation
        objCANew = frmCAccCreation.DefInstance
        objCANew.MdiParent = Me.MdiParent
        objCANew.BringToFront()
        objCANew.Show()
        objCANew = Nothing
    End Sub

    Private Sub btnUpdateStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateStatus.Click
        Dim objStatusUpdate As New frmCAChequeStatusUpdate
        If lvDepositedCheques.SelectedItems.Count > 0 Then
            If lvDepositedCheques.SelectedItems(0).SubItems(8).Text = "Pending" Then
                objStatusUpdate.txtAccNo.Text = lvDepositedCheques.SelectedItems(0).SubItems(1).Text
                objStatusUpdate.txtBankName.Text = lvDepositedCheques.SelectedItems(0).SubItems(2).Text
                objStatusUpdate.txtBranchName.Text = lvDepositedCheques.SelectedItems(0).SubItems(3).Text
                objStatusUpdate.txtChequeNo.Text = lvDepositedCheques.SelectedItems(0).SubItems(5).Text
                objStatusUpdate.txtChequeAmount.Text = lvDepositedCheques.SelectedItems(0).SubItems(7).Text
                objStatusUpdate.txtBankCharges.Text = lvDepositedCheques.SelectedItems(0).SubItems(9).Text
                objStatusUpdate.dtpChequeDate.Text = lvDepositedCheques.SelectedItems(0).SubItems(4).Text
                'objStatusUpdate.dtpClearanceDate.Text = lvDepositedCheques.SelectedItems(0).SubItems(10).Text
                objStatusUpdate.dtpDepositdate.Text = lvDepositedCheques.SelectedItems(0).SubItems(6).Text
                objStatusUpdate.txtClearedAmt.Text = lvDepositedCheques.SelectedItems(0).SubItems(7).Text
                objStatusUpdate.ShowDialog()
                frmChequeDepositDetail_Load(sender, e)
            Else
                MsgBox("Account status cannot be changed, since its already " & lvDepositedCheques.SelectedItems(0).SubItems(8).Text, MsgBoxStyle.Exclamation, "CA Module")
            End If
        Else
            MsgBox("Please select the item from the list", MsgBoxStyle.Exclamation, "CA Module")
        End If
    End Sub

    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        Try
            Dim ObjChqdeposit As New frmCAChequeDeposit
            ObjChqdeposit.ShowDialog(Me)
            frmChequeDepositDetail_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnWithDraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithDraw.Click
        Try
            Dim objfrmChqWithdraw As New frmCAChequeWithdraw
            objfrmChqWithdraw.ShowDialog(Me)
            frmChequeDepositDetail_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnViewChqTran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If lvDepositedCheques.SelectedItems.Count > 0 Then
            Dim objChqTran As New frmCAChequeTransaction
            objChqTran.txtAccno.Text = lvDepositedCheques.SelectedItems(0).SubItems(1).Text
            objChqTran.Show()
        End If
    End Sub

    Private Sub btnStpCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStpCheque.Click

        If lvDepositedCheques.SelectedItems.Count > 0 Then
            If lvDepositedCheques.SelectedItems(0).SubItems(8).Text = "Pending" Then
                Dim objfrmStpPay As New frmCAChequeStopPay
                objfrmStpPay.txtAccNo.Text = lvDepositedCheques.SelectedItems(0).SubItems(1).Text
                objfrmStpPay.txtSBChequeNo.Text = lvDepositedCheques.SelectedItems(0).SubItems(5).Text
                objfrmStpPay.txtChequeAmount.Text = lvDepositedCheques.SelectedItems(0).SubItems(7).Text
                objfrmStpPay.ShowDialog()
                frmChequeDepositDetail_Load(sender, e)
            Else
                MsgBox("Account status cannot be changed, since its already" & lvDepositedCheques.SelectedItems(0).SubItems(10).Text, MsgBoxStyle.Exclamation, "CA Module")
            End If
        Else
            MsgBox("Please select the item from the list", MsgBoxStyle.Exclamation, "CA Module")
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub frmChequeDepositDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If objCA.fnGetDepositedCheque() = True Then
            dvCACheques = New DataView(objCA.ChequedetailsTable, strFilter, "", DataViewRowState.OriginalRows)
            sbLoadDepositedCheques()
        End If
        dtpChequeDepDate.Visible = False
        btnSearch.Visible = False

    End Sub

    Private Sub cmbType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged
        txtSearch.ResetText()
        Select Case cmbType.SelectedItem

            Case "ChequeStatus"
                dtpChequeDepDate.Visible = False
                btnSearch.Visible = False
                txtSearch.Visible = True

            Case "ChequeNo"
                dtpChequeDepDate.Visible = False
                btnSearch.Visible = False
                txtSearch.Visible = True

            Case "AccountNo"
                dtpChequeDepDate.Visible = False
                btnSearch.Visible = False
                txtSearch.Visible = True

            Case "BankName"
                dtpChequeDepDate.Visible = False
                btnSearch.Visible = False
                txtSearch.Visible = True

            Case "BranchName"
                dtpChequeDepDate.Visible = False
                btnSearch.Visible = False
                txtSearch.Visible = True

            Case "ChequeAmount"
                dtpChequeDepDate.Visible = False
                btnSearch.Visible = False
                txtSearch.Visible = True

            Case "DepositDate"
                txtSearch.Visible = False
                dtpChequeDepDate.Visible = True
                btnSearch.Visible = True

        End Select

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged

        Select Case cmbType.SelectedItem

            Case "ChequeStatus"
                dtpChequeDepDate.Visible = False
                btnSearch.Visible = False
                txtSearch.Visible = True
                strFilter = "ChequeStatus like '" & txtSearch.Text & "%'"
                sbLoadDepositedCheques()

            Case "ChequeNo"
                dtpChequeDepDate.Visible = False
                btnSearch.Visible = False
                txtSearch.Visible = True
                strFilter = "ChequeNo like '" & txtSearch.Text & "%'"
                sbLoadDepositedCheques()

            Case "AccountNo"
                dtpChequeDepDate.Visible = False
                btnSearch.Visible = False
                txtSearch.Visible = True
                strFilter = "CAccountNo like '" & txtSearch.Text & "%'"
                sbLoadDepositedCheques()

            Case "BankName"
                dtpChequeDepDate.Visible = False
                btnSearch.Visible = False
                txtSearch.Visible = True
                strFilter = "BankName like '" & txtSearch.Text & "%'"
                sbLoadDepositedCheques()

            Case "BranchName"
                dtpChequeDepDate.Visible = False
                btnSearch.Visible = False
                txtSearch.Visible = True
                strFilter = "BranchName like '" & txtSearch.Text & "%'"
                sbLoadDepositedCheques()

            Case "ChequeAmount"
                dtpChequeDepDate.Visible = False
                btnSearch.Visible = False
                txtSearch.Visible = True
                If Trim(txtSearch.Text) = String.Empty Then
                    strFilter = "CAccountNo like '" & txtSearch.Text & "%'"
                    sbLoadDepositedCheques()
                Else
                    strFilter = "ChequeAmount = '" & Val(txtSearch.Text) & "'"
                    sbLoadDepositedCheques()
                End If

            Case "DepositDate"
                txtSearch.Visible = False
                dtpChequeDepDate.Visible = True
                strFilter = "Deposit = '" & dtpChequeDepDate.Value & "'"
                sbLoadDepositedCheques()

        End Select

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        txtSearch.Visible = False
        dtpChequeDepDate.Visible = True
        strFilter = "DepositDate = '" & dtpChequeDepDate.Value & "'"
        sbLoadDepositedCheques()

    End Sub


#End Region

    Private Sub lvDepositedCheques_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvDepositedCheques.DoubleClick
        btnUpdateStatus_Click(sender, e)
    End Sub

    Private Sub lvDepositedCheques_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvDepositedCheques.KeyDown
        If e.KeyData = Keys.Enter Then
            btnUpdateStatus_Click(sender, e)
        End If
    End Sub

    
End Class
