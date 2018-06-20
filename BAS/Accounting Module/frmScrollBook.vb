
Imports System.Math
Public Class frmScrollBook
    Inherits System.Windows.Forms.Form

#Region "Global Variables"
    Dim objLedger As New clsLedger
    Dim dvLedger As DataView
    Public strMemberNo As String
    Dim strFilter As String = "Name like '%'"
#End Region

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
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFamilyDetails As BankControls.NewButton
    Friend WithEvents btnIDCard As BankControls.NewButton
    Friend WithEvents btnMemberDetails As BankControls.NewButton
    Friend WithEvents btnTransactions As BankControls.NewButton
    Friend WithEvents NewButton3 As BankControls.NewButton
    Friend WithEvents NewButton4 As BankControls.NewButton
    Friend WithEvents NewButton5 As BankControls.NewButton
    Friend WithEvents NewButton6 As BankControls.NewButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvScrollBook As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtSearch As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmScrollBook))
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnFamilyDetails = New BankControls.NewButton
        Me.btnIDCard = New BankControls.NewButton
        Me.btnMemberDetails = New BankControls.NewButton
        Me.btnTransactions = New BankControls.NewButton
        Me.NewButton3 = New BankControls.NewButton
        Me.NewButton4 = New BankControls.NewButton
        Me.NewButton5 = New BankControls.NewButton
        Me.NewButton6 = New BankControls.NewButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtSearch = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lvScrollBook = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.btnClose = New BankControls.NewButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "GNo"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 120
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnFamilyDetails)
        Me.GroupBox2.Controls.Add(Me.btnIDCard)
        Me.GroupBox2.Controls.Add(Me.btnMemberDetails)
        Me.GroupBox2.Controls.Add(Me.btnTransactions)
        Me.GroupBox2.Controls.Add(Me.NewButton3)
        Me.GroupBox2.Controls.Add(Me.NewButton4)
        Me.GroupBox2.Controls.Add(Me.NewButton5)
        Me.GroupBox2.Controls.Add(Me.NewButton6)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 616)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'btnFamilyDetails
        '
        Me.btnFamilyDetails.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnFamilyDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFamilyDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFamilyDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFamilyDetails.ForeColor = System.Drawing.Color.Black
        Me.btnFamilyDetails.GotFocusColour = System.Drawing.Color.FromArgb(CType(152, Byte), CType(220, Byte), CType(166, Byte))
        Me.btnFamilyDetails.Image = CType(resources.GetObject("btnFamilyDetails.Image"), System.Drawing.Image)
        Me.btnFamilyDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFamilyDetails.Location = New System.Drawing.Point(16, 104)
        Me.btnFamilyDetails.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnFamilyDetails.Name = "btnFamilyDetails"
        Me.btnFamilyDetails.Size = New System.Drawing.Size(168, 40)
        Me.btnFamilyDetails.TabIndex = 11
        Me.btnFamilyDetails.Text = "Cash &Receipt"
        Me.btnFamilyDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFamilyDetails.Visible = False
        '
        'btnIDCard
        '
        Me.btnIDCard.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnIDCard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIDCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIDCard.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIDCard.ForeColor = System.Drawing.Color.Black
        Me.btnIDCard.GotFocusColour = System.Drawing.Color.FromArgb(CType(152, Byte), CType(220, Byte), CType(166, Byte))
        Me.btnIDCard.Image = CType(resources.GetObject("btnIDCard.Image"), System.Drawing.Image)
        Me.btnIDCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIDCard.Location = New System.Drawing.Point(16, 144)
        Me.btnIDCard.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnIDCard.Name = "btnIDCard"
        Me.btnIDCard.Size = New System.Drawing.Size(168, 40)
        Me.btnIDCard.TabIndex = 12
        Me.btnIDCard.Text = "&Contra "
        Me.btnIDCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIDCard.Visible = False
        '
        'btnMemberDetails
        '
        Me.btnMemberDetails.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnMemberDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMemberDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMemberDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemberDetails.ForeColor = System.Drawing.Color.Black
        Me.btnMemberDetails.GotFocusColour = System.Drawing.Color.FromArgb(CType(152, Byte), CType(220, Byte), CType(166, Byte))
        Me.btnMemberDetails.Image = CType(resources.GetObject("btnMemberDetails.Image"), System.Drawing.Image)
        Me.btnMemberDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMemberDetails.Location = New System.Drawing.Point(16, 64)
        Me.btnMemberDetails.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnMemberDetails.Name = "btnMemberDetails"
        Me.btnMemberDetails.Size = New System.Drawing.Size(168, 40)
        Me.btnMemberDetails.TabIndex = 10
        Me.btnMemberDetails.Text = "Cash &Payment"
        Me.btnMemberDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMemberDetails.Visible = False
        '
        'btnTransactions
        '
        Me.btnTransactions.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnTransactions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransactions.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransactions.ForeColor = System.Drawing.Color.Black
        Me.btnTransactions.GotFocusColour = System.Drawing.Color.FromArgb(CType(152, Byte), CType(220, Byte), CType(166, Byte))
        Me.btnTransactions.Image = CType(resources.GetObject("btnTransactions.Image"), System.Drawing.Image)
        Me.btnTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransactions.Location = New System.Drawing.Point(16, 184)
        Me.btnTransactions.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnTransactions.Name = "btnTransactions"
        Me.btnTransactions.Size = New System.Drawing.Size(168, 40)
        Me.btnTransactions.TabIndex = 13
        Me.btnTransactions.Text = "&Journal"
        Me.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTransactions.Visible = False
        '
        'NewButton3
        '
        Me.NewButton3.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.NewButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton3.ForeColor = System.Drawing.Color.Black
        Me.NewButton3.GotFocusColour = System.Drawing.Color.FromArgb(CType(152, Byte), CType(220, Byte), CType(166, Byte))
        Me.NewButton3.Image = CType(resources.GetObject("NewButton3.Image"), System.Drawing.Image)
        Me.NewButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton3.Location = New System.Drawing.Point(16, 464)
        Me.NewButton3.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.NewButton3.Name = "NewButton3"
        Me.NewButton3.Size = New System.Drawing.Size(168, 40)
        Me.NewButton3.TabIndex = 18
        Me.NewButton3.Text = "View Books"
        Me.NewButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton3.Visible = False
        '
        'NewButton4
        '
        Me.NewButton4.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.NewButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton4.ForeColor = System.Drawing.Color.Black
        Me.NewButton4.GotFocusColour = System.Drawing.Color.FromArgb(CType(152, Byte), CType(220, Byte), CType(166, Byte))
        Me.NewButton4.Image = CType(resources.GetObject("NewButton4.Image"), System.Drawing.Image)
        Me.NewButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton4.Location = New System.Drawing.Point(16, 384)
        Me.NewButton4.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.NewButton4.Name = "NewButton4"
        Me.NewButton4.Size = New System.Drawing.Size(168, 40)
        Me.NewButton4.TabIndex = 16
        Me.NewButton4.Text = "View Vouchers"
        Me.NewButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton4.Visible = False
        '
        'NewButton5
        '
        Me.NewButton5.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.NewButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton5.ForeColor = System.Drawing.Color.Black
        Me.NewButton5.GotFocusColour = System.Drawing.Color.FromArgb(CType(152, Byte), CType(220, Byte), CType(166, Byte))
        Me.NewButton5.Image = CType(resources.GetObject("NewButton5.Image"), System.Drawing.Image)
        Me.NewButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton5.Location = New System.Drawing.Point(16, 424)
        Me.NewButton5.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.NewButton5.Name = "NewButton5"
        Me.NewButton5.Size = New System.Drawing.Size(168, 40)
        Me.NewButton5.TabIndex = 17
        Me.NewButton5.Text = "View Ledgers"
        Me.NewButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton5.Visible = False
        '
        'NewButton6
        '
        Me.NewButton6.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.NewButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton6.ForeColor = System.Drawing.Color.Black
        Me.NewButton6.GotFocusColour = System.Drawing.Color.FromArgb(CType(152, Byte), CType(220, Byte), CType(166, Byte))
        Me.NewButton6.Image = CType(resources.GetObject("NewButton6.Image"), System.Drawing.Image)
        Me.NewButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton6.Location = New System.Drawing.Point(16, 504)
        Me.NewButton6.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.NewButton6.Name = "NewButton6"
        Me.NewButton6.Size = New System.Drawing.Size(168, 40)
        Me.NewButton6.TabIndex = 19
        Me.NewButton6.Text = "View Reports"
        Me.NewButton6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton6.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lvScrollBook)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(216, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(792, 616)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(223, Byte), CType(184, Byte))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(392, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 24)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Credit"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(223, Byte), CType(184, Byte))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 24)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "SlNo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.GroupBox4.Controls.Add(Me.txtSearch)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(776, 64)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.AlphaNumeric = True
        Me.txtSearch.AutoSize = False
        Me.txtSearch.BlankSpace = True
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSearch.Location = New System.Drawing.Point(136, 20)
        Me.txtSearch.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtSearch.Mandatory = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 20)
        Me.txtSearch.SpecialChar = True
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SearchText :"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(223, Byte), CType(184, Byte))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(64, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(336, 24)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "AccountType"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lvScrollBook
        '
        Me.lvScrollBook.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.lvScrollBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvScrollBook.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader8, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvScrollBook.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvScrollBook.FullRowSelect = True
        Me.lvScrollBook.GridLines = True
        Me.lvScrollBook.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvScrollBook.Location = New System.Drawing.Point(8, 152)
        Me.lvScrollBook.Name = "lvScrollBook"
        Me.lvScrollBook.Size = New System.Drawing.Size(776, 400)
        Me.lvScrollBook.TabIndex = 2
        Me.lvScrollBook.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "SlNo"
        Me.ColumnHeader2.Width = 50
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "LNo"
        Me.ColumnHeader8.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "AccountType"
        Me.ColumnHeader3.Width = 332
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "recipt"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Payment"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 130
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Balance"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 120
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.Label21.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Green
        Me.Label21.Location = New System.Drawing.Point(64, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(106, 25)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Scroll Book"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(672, 560)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(223, Byte), CType(184, Byte))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(512, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 24)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Debit"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(172, Byte), CType(223, Byte), CType(184, Byte))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(640, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 24)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Balance"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmScrollBook
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1018, 629)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmScrollBook"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Scroll Book"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmScrollBook
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmScrollBook
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmScrollBook
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmScrollBook)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

    Function ScrolBookLoad()
        Dim objDT As DataTable
        Dim objDT1 As DataTable
        Dim lvItem As ListViewItem
        Dim intCounter As Integer = 0
        Dim intSlNo As Integer = 1
        Dim dblTotalCredit As Double = 0
        Dim dblTotalDebit As Double = 0

        If Not dvLedger Is Nothing Then
            dvLedger.RowFilter = strFilter
            lvScrollBook.Items.Clear()
            While intCounter < dvLedger.Count
                If dvLedger.Item(intCounter).Item("LedgerNo") <> 2 Then
                    lvItem = lvScrollBook.Items.Add(intSlNo)
                    lvItem.SubItems.Add(dvLedger.Item(intCounter).Item("LedgerNo"))
                    lvItem.SubItems.Add(dvLedger.Item(intCounter).Item("Name"))
                    Dim inte As Integer = dvLedger.Item(intCounter).Item("LedgerNo")
                    If objLedger.fnGetTransactions(inte) Then
                        objDT1 = objLedger.LedgerTable
                        Dim intCount As Integer = 0
                        While intCount < objDT1.Rows.Count
                            dblTotalCredit += objDT1.Rows(intCount).Item("Credit")
                            dblTotalDebit += objDT1.Rows(intCount).Item("Debit")
                            intCount += 1
                        End While
                    End If
                    lvItem.SubItems.Add(Format(dblTotalCredit, "0.00"))
                    dblTotalCredit = 0
                    lvItem.SubItems.Add(Format(dblTotalDebit, "0.00"))
                    dblTotalDebit = 0
                    lvItem.SubItems.Add(Abs(dvLedger.Item(intCounter).Item("CurrentBalance")))
                End If
                intCounter += 1
                intSlNo += 1
            End While
        End If
    End Function

    Private Sub frmScrollBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If objLedger.fnGetLedgerList Then
            dvLedger = New DataView(objLedger.LedgerTable, strFilter, "LEdgerNo", DataViewRowState.OriginalRows)
            ScrolBookLoad()
        End If
    End Sub

    Private Sub lvScrollBook_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvScrollBook.SelectedIndexChanged
        If lvScrollBook.SelectedItems.Count > 0 Then
            Dim objVoucherDetail As New frmVoucherDetails
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        strFilter = "Name like '" & txtSearch.Text & "%'"
        ScrolBookLoad()
    End Sub

    Private Sub lvScrollBook_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvScrollBook.DoubleClick
        If lvScrollBook.SelectedItems(0).SubItems(1).Text <> "" Then
            Dim objfrmLedgerDetails As frmLedgerDetails
            objfrmLedgerDetails = frmLedgerDetails.DefInstance
            objfrmLedgerDetails.BringToFront()
            objfrmLedgerDetails.MdiParent = Me.MdiParent
            objfrmLedgerDetails.LedgerNo = lvScrollBook.SelectedItems(0).SubItems(1).Text
            objfrmLedgerDetails.Show()
            objfrmLedgerDetails = Nothing
        Else
            MsgBox("Select Record", MsgBoxStyle.Information, Me.Text)
            lvScrollBook.Focus()
        End If
    End Sub

    Private Sub lvScrollBook_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvScrollBook.KeyDown
        If e.KeyData = Keys.Enter Then
            lvScrollBook_DoubleClick(sender, e)
        End If
    End Sub
End Class
