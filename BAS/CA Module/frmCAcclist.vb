Public Class frmCAcclist
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
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NewButton3 As BankControls.NewButton
    Friend WithEvents NewButton5 As BankControls.NewButton
    Friend WithEvents NewButton6 As BankControls.NewButton
    Friend WithEvents btnChequeWithdraw As BankControls.NewButton
    Friend WithEvents btnChequeDeposit As BankControls.NewButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSignatoryDetail As BankControls.NewButton
    Friend WithEvents lvCAccounts As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents NewButton1 As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCAcclist))
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NewButton1 = New BankControls.NewButton
        Me.btnSignatoryDetail = New BankControls.NewButton
        Me.NewButton3 = New BankControls.NewButton
        Me.NewButton5 = New BankControls.NewButton
        Me.NewButton6 = New BankControls.NewButton
        Me.btnChequeWithdraw = New BankControls.NewButton
        Me.btnChequeDeposit = New BankControls.NewButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSearch = New BankControls.TextControl
        Me.lblMessage = New System.Windows.Forms.Label
        Me.lvCAccounts = New System.Windows.Forms.ListView
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.Label32 = New System.Windows.Forms.Label
        Me.btnAdd = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "AccountNo"
        Me.ColumnHeader1.Width = 83
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 178
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Type Of Account"
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date"
        Me.ColumnHeader4.Width = 90
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Available Balance"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Status"
        Me.ColumnHeader6.Width = 80
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NewButton1)
        Me.GroupBox1.Controls.Add(Me.btnSignatoryDetail)
        Me.GroupBox1.Controls.Add(Me.NewButton3)
        Me.GroupBox1.Controls.Add(Me.NewButton5)
        Me.GroupBox1.Controls.Add(Me.NewButton6)
        Me.GroupBox1.Controls.Add(Me.btnChequeWithdraw)
        Me.GroupBox1.Controls.Add(Me.btnChequeDeposit)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 616)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'NewButton1
        '
        Me.NewButton1.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.ForeColor = System.Drawing.Color.Black
        Me.NewButton1.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.NewButton1.Image = CType(resources.GetObject("NewButton1.Image"), System.Drawing.Image)
        Me.NewButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton1.Location = New System.Drawing.Point(16, 264)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(168, 40)
        Me.NewButton1.TabIndex = 13
        Me.NewButton1.Text = "Cash Transaction"
        Me.NewButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSignatoryDetail
        '
        Me.btnSignatoryDetail.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnSignatoryDetail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignatoryDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSignatoryDetail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignatoryDetail.ForeColor = System.Drawing.Color.Black
        Me.btnSignatoryDetail.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnSignatoryDetail.Image = CType(resources.GetObject("btnSignatoryDetail.Image"), System.Drawing.Image)
        Me.btnSignatoryDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSignatoryDetail.Location = New System.Drawing.Point(16, 128)
        Me.btnSignatoryDetail.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnSignatoryDetail.Name = "btnSignatoryDetail"
        Me.btnSignatoryDetail.Size = New System.Drawing.Size(168, 40)
        Me.btnSignatoryDetail.TabIndex = 7
        Me.btnSignatoryDetail.Text = "Signatory Detail"
        Me.btnSignatoryDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NewButton3
        '
        Me.NewButton3.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton3.ForeColor = System.Drawing.Color.Black
        Me.NewButton3.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.NewButton3.Image = CType(resources.GetObject("NewButton3.Image"), System.Drawing.Image)
        Me.NewButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton3.Location = New System.Drawing.Point(16, 168)
        Me.NewButton3.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton3.Name = "NewButton3"
        Me.NewButton3.Size = New System.Drawing.Size(168, 40)
        Me.NewButton3.TabIndex = 8
        Me.NewButton3.Text = "Issue Cheque Book"
        Me.NewButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NewButton5
        '
        Me.NewButton5.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton5.ForeColor = System.Drawing.Color.Black
        Me.NewButton5.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.NewButton5.Location = New System.Drawing.Point(16, 424)
        Me.NewButton5.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton5.Name = "NewButton5"
        Me.NewButton5.Size = New System.Drawing.Size(168, 40)
        Me.NewButton5.TabIndex = 11
        Me.NewButton5.Text = "View Transaction Log(All)"
        '
        'NewButton6
        '
        Me.NewButton6.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton6.ForeColor = System.Drawing.Color.Black
        Me.NewButton6.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.NewButton6.Location = New System.Drawing.Point(16, 464)
        Me.NewButton6.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton6.Name = "NewButton6"
        Me.NewButton6.Size = New System.Drawing.Size(168, 40)
        Me.NewButton6.TabIndex = 12
        Me.NewButton6.Text = "Cheque Deposit Details"
        '
        'btnChequeWithdraw
        '
        Me.btnChequeWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnChequeWithdraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChequeWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChequeWithdraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChequeWithdraw.ForeColor = System.Drawing.Color.Black
        Me.btnChequeWithdraw.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnChequeWithdraw.Image = CType(resources.GetObject("btnChequeWithdraw.Image"), System.Drawing.Image)
        Me.btnChequeWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChequeWithdraw.Location = New System.Drawing.Point(16, 344)
        Me.btnChequeWithdraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnChequeWithdraw.Name = "btnChequeWithdraw"
        Me.btnChequeWithdraw.Size = New System.Drawing.Size(168, 40)
        Me.btnChequeWithdraw.TabIndex = 10
        Me.btnChequeWithdraw.Text = "Cheque WithDrawl"
        Me.btnChequeWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnChequeDeposit
        '
        Me.btnChequeDeposit.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnChequeDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChequeDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChequeDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChequeDeposit.ForeColor = System.Drawing.Color.Black
        Me.btnChequeDeposit.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnChequeDeposit.Image = CType(resources.GetObject("btnChequeDeposit.Image"), System.Drawing.Image)
        Me.btnChequeDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChequeDeposit.Location = New System.Drawing.Point(16, 304)
        Me.btnChequeDeposit.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnChequeDeposit.Name = "btnChequeDeposit"
        Me.btnChequeDeposit.Size = New System.Drawing.Size(168, 40)
        Me.btnChequeDeposit.TabIndex = 9
        Me.btnChequeDeposit.Text = "Cheque Deposit"
        Me.btnChequeDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.lblMessage)
        Me.GroupBox2.Controls.Add(Me.lvCAccounts)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(208, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(792, 616)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(328, 552)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Total Balance"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cmbType)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtSearch)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(764, 48)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Search By:"
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Items.AddRange(New Object() {"AccountNo", "Name", "Balance", "Type Of Account", "Status", "Remarks"})
        Me.cmbType.Location = New System.Drawing.Point(152, 16)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(200, 24)
        Me.cmbType.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(408, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Search Text:"
        '
        'txtSearch
        '
        Me.txtSearch.AlphaNumeric = True
        Me.txtSearch.AutoSize = False
        Me.txtSearch.BlankSpace = True
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSearch.Location = New System.Drawing.Point(512, 16)
        Me.txtSearch.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtSearch.Mandatory = False
        Me.txtSearch.MaxLength = 100
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 20)
        Me.txtSearch.SpecialChar = True
        Me.txtSearch.TabIndex = 2
        Me.txtSearch.Text = ""
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(12, 120)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(287, 19)
        Me.lblMessage.TabIndex = 72
        Me.lblMessage.Text = "There are 0 records found for your search"
        '
        'lvCAccounts
        '
        Me.lvCAccounts.AllowColumnReorder = True
        Me.lvCAccounts.BackColor = System.Drawing.Color.LightCyan
        Me.lvCAccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvCAccounts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader4, Me.ColumnHeader8, Me.ColumnHeader7, Me.ColumnHeader10, Me.ColumnHeader9, Me.ColumnHeader6, Me.ColumnHeader3})
        Me.lvCAccounts.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCAccounts.FullRowSelect = True
        Me.lvCAccounts.GridLines = True
        Me.lvCAccounts.HideSelection = False
        Me.lvCAccounts.Location = New System.Drawing.Point(16, 152)
        Me.lvCAccounts.MultiSelect = False
        Me.lvCAccounts.Name = "lvCAccounts"
        Me.lvCAccounts.Size = New System.Drawing.Size(760, 384)
        Me.lvCAccounts.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvCAccounts.TabIndex = 3
        Me.lvCAccounts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Book Balance"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "OD Limit"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 90
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Intrest "
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Remarks"
        Me.ColumnHeader3.Width = 100
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Teal
        Me.Label32.Location = New System.Drawing.Point(72, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(200, 25)
        Me.Label32.TabIndex = 68
        Me.Label32.Text = "Current Account's List"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(24, 568)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 40)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "&Add"
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
        Me.btnCancel.Location = New System.Drawing.Point(672, 568)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Cancel"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(432, 552)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(120, 24)
        Me.Label4.TabIndex = 73
        '
        'frmCAcclist
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1016, 629)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmCAcclist"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Current Account List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Form Global Variables"

    Dim objCAccount As New clsCurrentAccount
    Dim objMember As New clsMember
    Dim lngPersonNo As Long = 0
    Dim dvCAccounts As DataView
    Dim strFilter As String = "Name like '%'"
    Friend WithEvents dtp As New DateTimePicker
    Dim intCount As Integer

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmCAcclist
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmCAcclist
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmCAcclist
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmCAcclist)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Event"

    Private Sub frmCAcclist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbType.SelectedIndex = -1
        If objCAccount.fnGetCAccountlist() Then
            dvCAccounts = New DataView(objCAccount.CAAccTable, strFilter, "Name", DataViewRowState.OriginalRows)
            fnLoadCAccounts()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        SendKeys.Send("{F7}")
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Select Case cmbType.SelectedItem
            Case "AccountNo"
                strFilter = "CAccountNo like '" & txtSearch.Text & "%'"
                fnLoadCAccounts()
            Case "Name"
                strFilter = "Name like '" & txtSearch.Text & "%'"
                fnLoadCAccounts()
            Case "Status"
                strFilter = "Accstatus like '" & txtSearch.Text & "%'"
                fnLoadCAccounts()
            Case "Type Of Account"
                strFilter = "CAType like '" & txtSearch.Text & "%'"
                fnLoadCAccounts()
            Case "Balance"
                If txtSearch.Text = "" Then
                    strFilter = "Name like '" & txtSearch.Text & "%'"
                Else
                    strFilter = "AvailBalance =" & Val(txtSearch.Text) & ""
                End If
                fnLoadCAccounts()
            Case "Remarks"
                strFilter = "Remarks like '" & txtSearch.Text & "%'"
                fnLoadCAccounts()
        End Select
    End Sub

    Private Sub lvCAccounts_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvCAccounts.DoubleClick
        If lvCAccounts.SelectedItems.Count > 0 Then
            Dim objfrmCACreation As New frmCAccCreation
            objfrmCACreation = frmCAccCreation.DefInstance
            objfrmCACreation.BringToFront()
            objfrmCACreation.MdiParent = Me.MdiParent
            objfrmCACreation.txtAccNo.Text = lvCAccounts.SelectedItems(0).SubItems(0).Text
            objfrmCACreation.Show()
            objfrmCACreation = Nothing
        Else
            MsgBox("select accountno", MsgBoxStyle.Information, "Current AccountCreation")
            lvCAccounts.Focus()
        End If
    End Sub

    Private Sub lvCAccounts_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvCAccounts.KeyUp
        If e.KeyCode = Keys.Enter Then
            lvCAccounts_DoubleClick(Me, e.Empty)
        End If
    End Sub

    Private Sub txtSearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        If e.KeyCode = Keys.Down Then
            lvCAccounts.Focus()
        End If
    End Sub

#End Region

#Region "Genral Subroutines"

    Function fnLoadCAccounts() As Boolean
        Dim intCounter As Integer = 0
        Dim lvItem As New ListViewItem
        Dim intTotalBal As Integer = 0
        If Not dvCAccounts Is Nothing Then
            dvCAccounts.RowFilter = strFilter
            lvCAccounts.Items.Clear()
            lblMessage.Text = "There are " & dvCAccounts.Count & " records found for your search"
            While intCounter < dvCAccounts.Count
                lvItem = lvCAccounts.Items.Add(dvCAccounts.Item(intCounter).Item("CAccountNo"))
                lvItem.UseItemStyleForSubItems = False
                lvItem.SubItems.Add(dvCAccounts.Item(intCounter).Item("Name"))
                If dvCAccounts.Item(intCounter).Item("CAType") = "O" Then
                    lvItem.SubItems.Add("Organization")
                Else
                    lvItem.SubItems.Add("Individual")
                End If
                ' lvItem.SubItems.Add(dvCAccounts.Item(intCounter).Item("AccType"))
                lvItem.SubItems.Add(Format(dvCAccounts.Item(intCounter).Item("AccDate"), "dd-MM-yyyy"))
                lvItem.SubItems.Add(Format(dvCAccounts.Item(intCounter).Item("AvailBalance"), "0,00.00"))
                intTotalBal += dvCAccounts.Item(intCounter).Item("AvailBalance")
                lvItem.SubItems.Add(Format(dvCAccounts.Item(intCounter).Item("BookBalance"), "0,00.00"))
                lvItem.SubItems.Add(Format(dvCAccounts.Item(intCounter).Item("ODLimit"), "0,00.00"))
                lvItem.SubItems.Add(Format(dvCAccounts.Item(intCounter).Item("IntAmount"), "0,00.00"))
                lvItem.SubItems.Add(dvCAccounts.Item(intCounter).Item("AccStatus"))
                lvItem.SubItems.Add(dvCAccounts.Item(intCounter).Item("Remarks"))
                intCounter += 1
            End While
        End If
        Label4.Text = Format(intTotalBal, "0,00.00")
    End Function
#End Region


    Private Sub btnSignatoryDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignatoryDetail.Click
        If lvCAccounts.SelectedItems.Count > 0 Then
            Dim objsignatories As New frmSignatoryDetails
            objsignatories.txtAccountNo.Text = Trim(lvCAccounts.SelectedItems(0).SubItems(0).Text)
            objsignatories.Text = "Current Account Signatories for Account No  " & Trim(lvCAccounts.SelectedItems(0).SubItems(0).Text)
            objsignatories.txtName.Text = Trim(lvCAccounts.SelectedItems(0).SubItems(1).Text)
            objsignatories.ShowDialog(Me)
            objsignatories.Dispose()
        Else
            MsgBox("Please select account number from the list ", MsgBoxStyle.Information, "CA Module")
        End If
    End Sub

    Private Sub NewButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton3.Click
        If lvCAccounts.SelectedItems.Count > 0 Then
            If lvCAccounts.SelectedItems(0).SubItems(8).Text = "A" Then
                Dim objChequeBookIsue As New frmCAchequeBookIssue
                objChequeBookIsue.strCAno = Trim(lvCAccounts.SelectedItems(0).SubItems(0).Text)
                objChequeBookIsue.txtName.Text = Trim(lvCAccounts.SelectedItems(0).SubItems(1).Text)
                objChequeBookIsue.ShowDialog(Me)
            Else
                MsgBox("Cheque cannot be issued, account is closed", MsgBoxStyle.Exclamation, "CA Module")
            End If
        Else
            MsgBox("Please select account number from the list ", MsgBoxStyle.Information, "CA Module")
        End If
    End Sub

    Private Sub btnChequeDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChequeDeposit.Click
        If lvCAccounts.SelectedItems.Count > 0 Then
            If lvCAccounts.SelectedItems(0).SubItems(8).Text = "A" Then
                Dim objfrmChequeDeposit As New frmCAChequeDeposit
                objfrmChequeDeposit.txtAccNo.Text = lvCAccounts.SelectedItems(0).SubItems(0).Text
                'objfrmChequeDeposit.txtName.Text = lvCAccounts.SelectedItems(0).SubItems(1).Text
                objfrmChequeDeposit.txtAccNo.ReadOnly = True
                objfrmChequeDeposit.btnSearch.Enabled = False
                objfrmChequeDeposit.ShowDialog(Me)
                objfrmChequeDeposit = Nothing
                frmCAcclist_Load(sender, e)
            Else
                MsgBox("Transaction cannot be done, account is closed", MsgBoxStyle.Exclamation, "CA Module")
            End If
        Else
            MsgBox("Please select account number from the list", MsgBoxStyle.Exclamation, "CA Module")
        End If
    End Sub

    Private Sub NewButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton5.Click
        If lvCAccounts.SelectedItems.Count > 0 Then
            Dim objCAStatement As New frmCAStmt
            objCAStatement.txtAccno.Text = lvCAccounts.SelectedItems(0).SubItems(0).Text
            objCAStatement.txtName.Text = lvCAccounts.SelectedItems(0).SubItems(1).Text
            objCAStatement.ShowDialog(Me)
            objCAStatement = Nothing
        Else
            MsgBox("Please select account number from the list ", MsgBoxStyle.Exclamation, "CA Module")
        End If
    End Sub

    Private Sub btnChequeWithdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChequeWithdraw.Click
        Dim objChequeWithdraw As New frmCAChequeWithdraw
        objChequeWithdraw.txtAccNo.ReadOnly = True
        objChequeWithdraw.btnSearch.Enabled = False
        objChequeWithdraw.ShowDialog(Me)
        frmCAcclist_Load(sender, e)
    End Sub

    Private Sub NewButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton6.Click
        Dim objfrmChequeDepositDetails As New frmChequeDepositDetail
        objfrmChequeDepositDetails.MdiParent = Me.MdiParent
        objfrmChequeDepositDetails.Show()
        objfrmChequeDepositDetails = Nothing
    End Sub

    Private Sub cmbType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged
        txtSearch.ResetText()
    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click
        Dim objCACashTran As New frmCACashTransaction
        objCACashTran.ShowDialog(Me)
        frmCAcclist_Load(sender, e)
    End Sub

    Private Sub frmCAcclist_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.F2 Then
            NewButton1_Click(sender, e)
        End If
    End Sub
End Class
