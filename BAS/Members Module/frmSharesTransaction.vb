Public Class frmSharesTransaction
    Inherits System.Windows.Forms.Form

#Region " Global Variables"
    Dim objMember As New clsMember
#End Region

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        If m_FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_FormDefInstance = Me
            End If
        End If
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
    Friend WithEvents btnReceipt As BankControls.NewButton
    Friend WithEvents btnNominees As BankControls.NewButton
    Friend WithEvents btnFamilyDetails As BankControls.NewButton
    Friend WithEvents btnIDCard As BankControls.NewButton
    Friend WithEvents btnMemberDetails As BankControls.NewButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMemberNo As BankControls.TextControl
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnRemitShares As BankControls.NewButton
    Friend WithEvents btnRefundShares As BankControls.NewButton
    Friend WithEvents txtNoOfShares As BankControls.TextControl
    Friend WithEvents txtShareAmount As BankControls.TextControl
    Friend WithEvents lvShareDetails As System.Windows.Forms.ListView
    Friend WithEvents btnTransactions As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSharesTransaction))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnReceipt = New BankControls.NewButton
        Me.btnNominees = New BankControls.NewButton
        Me.btnFamilyDetails = New BankControls.NewButton
        Me.btnIDCard = New BankControls.NewButton
        Me.btnMemberDetails = New BankControls.NewButton
        Me.btnTransactions = New BankControls.NewButton
        Me.btnRemitShares = New BankControls.NewButton
        Me.btnRefundShares = New BankControls.NewButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lvShareDetails = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtMemberNo = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSearch = New BankControls.NewButton
        Me.txtName = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNoOfShares = New BankControls.TextControl
        Me.txtShareAmount = New BankControls.TextControl
        Me.btnClose = New BankControls.NewButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnReceipt)
        Me.GroupBox1.Controls.Add(Me.btnNominees)
        Me.GroupBox1.Controls.Add(Me.btnFamilyDetails)
        Me.GroupBox1.Controls.Add(Me.btnIDCard)
        Me.GroupBox1.Controls.Add(Me.btnMemberDetails)
        Me.GroupBox1.Controls.Add(Me.btnTransactions)
        Me.GroupBox1.Controls.Add(Me.btnRemitShares)
        Me.GroupBox1.Controls.Add(Me.btnRefundShares)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 616)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'btnReceipt
        '
        Me.btnReceipt.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReceipt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceipt.ForeColor = System.Drawing.Color.Black
        Me.btnReceipt.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
        Me.btnReceipt.Image = CType(resources.GetObject("btnReceipt.Image"), System.Drawing.Image)
        Me.btnReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReceipt.Location = New System.Drawing.Point(16, 392)
        Me.btnReceipt.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(168, 40)
        Me.btnReceipt.TabIndex = 3
        Me.btnReceipt.Text = "&Receipt Details"
        Me.btnReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReceipt.Visible = False
        '
        'btnNominees
        '
        Me.btnNominees.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnNominees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNominees.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNominees.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNominees.ForeColor = System.Drawing.Color.Black
        Me.btnNominees.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
        Me.btnNominees.Image = CType(resources.GetObject("btnNominees.Image"), System.Drawing.Image)
        Me.btnNominees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNominees.Location = New System.Drawing.Point(16, 192)
        Me.btnNominees.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnNominees.Name = "btnNominees"
        Me.btnNominees.Size = New System.Drawing.Size(168, 40)
        Me.btnNominees.TabIndex = 2
        Me.btnNominees.Text = "&Nominee Details"
        Me.btnNominees.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnFamilyDetails
        '
        Me.btnFamilyDetails.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnFamilyDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFamilyDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFamilyDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFamilyDetails.ForeColor = System.Drawing.Color.Black
        Me.btnFamilyDetails.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
        Me.btnFamilyDetails.Image = CType(resources.GetObject("btnFamilyDetails.Image"), System.Drawing.Image)
        Me.btnFamilyDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFamilyDetails.Location = New System.Drawing.Point(16, 152)
        Me.btnFamilyDetails.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnFamilyDetails.Name = "btnFamilyDetails"
        Me.btnFamilyDetails.Size = New System.Drawing.Size(168, 40)
        Me.btnFamilyDetails.TabIndex = 1
        Me.btnFamilyDetails.Text = "&Family Details"
        Me.btnFamilyDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnIDCard
        '
        Me.btnIDCard.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnIDCard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIDCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIDCard.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIDCard.ForeColor = System.Drawing.Color.Black
        Me.btnIDCard.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
        Me.btnIDCard.Image = CType(resources.GetObject("btnIDCard.Image"), System.Drawing.Image)
        Me.btnIDCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIDCard.Location = New System.Drawing.Point(16, 232)
        Me.btnIDCard.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnIDCard.Name = "btnIDCard"
        Me.btnIDCard.Size = New System.Drawing.Size(168, 40)
        Me.btnIDCard.TabIndex = 4
        Me.btnIDCard.Text = "Issue &ID Card"
        Me.btnIDCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIDCard.Visible = False
        '
        'btnMemberDetails
        '
        Me.btnMemberDetails.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnMemberDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMemberDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMemberDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemberDetails.ForeColor = System.Drawing.Color.Black
        Me.btnMemberDetails.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
        Me.btnMemberDetails.Image = CType(resources.GetObject("btnMemberDetails.Image"), System.Drawing.Image)
        Me.btnMemberDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMemberDetails.Location = New System.Drawing.Point(16, 112)
        Me.btnMemberDetails.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnMemberDetails.Name = "btnMemberDetails"
        Me.btnMemberDetails.Size = New System.Drawing.Size(168, 40)
        Me.btnMemberDetails.TabIndex = 1
        Me.btnMemberDetails.Text = "&Member Details"
        Me.btnMemberDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnTransactions
        '
        Me.btnTransactions.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnTransactions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransactions.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransactions.ForeColor = System.Drawing.Color.Black
        Me.btnTransactions.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
        Me.btnTransactions.Image = CType(resources.GetObject("btnTransactions.Image"), System.Drawing.Image)
        Me.btnTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransactions.Location = New System.Drawing.Point(16, 352)
        Me.btnTransactions.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnTransactions.Name = "btnTransactions"
        Me.btnTransactions.Size = New System.Drawing.Size(168, 40)
        Me.btnTransactions.TabIndex = 4
        Me.btnTransactions.Text = "&Transactions"
        Me.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTransactions.Visible = False
        '
        'btnRemitShares
        '
        Me.btnRemitShares.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnRemitShares.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemitShares.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemitShares.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemitShares.ForeColor = System.Drawing.Color.Black
        Me.btnRemitShares.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
        Me.btnRemitShares.Image = CType(resources.GetObject("btnRemitShares.Image"), System.Drawing.Image)
        Me.btnRemitShares.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemitShares.Location = New System.Drawing.Point(16, 272)
        Me.btnRemitShares.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnRemitShares.Name = "btnRemitShares"
        Me.btnRemitShares.Size = New System.Drawing.Size(168, 40)
        Me.btnRemitShares.TabIndex = 4
        Me.btnRemitShares.Text = "&Remit Shares"
        Me.btnRemitShares.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRefundShares
        '
        Me.btnRefundShares.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnRefundShares.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefundShares.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefundShares.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefundShares.ForeColor = System.Drawing.Color.Black
        Me.btnRefundShares.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
        Me.btnRefundShares.Image = CType(resources.GetObject("btnRefundShares.Image"), System.Drawing.Image)
        Me.btnRefundShares.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefundShares.Location = New System.Drawing.Point(16, 312)
        Me.btnRefundShares.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnRefundShares.Name = "btnRefundShares"
        Me.btnRefundShares.Size = New System.Drawing.Size(168, 40)
        Me.btnRefundShares.TabIndex = 4
        Me.btnRefundShares.Text = "Refund &Shares"
        Me.btnRefundShares.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Location = New System.Drawing.Point(216, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(792, 616)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lvShareDetails)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 128)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(776, 360)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        '
        'lvShareDetails
        '
        Me.lvShareDetails.AllowColumnReorder = True
        Me.lvShareDetails.BackColor = System.Drawing.Color.OldLace
        Me.lvShareDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvShareDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvShareDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvShareDetails.FullRowSelect = True
        Me.lvShareDetails.GridLines = True
        Me.lvShareDetails.HideSelection = False
        Me.lvShareDetails.Location = New System.Drawing.Point(8, 16)
        Me.lvShareDetails.MultiSelect = False
        Me.lvShareDetails.Name = "lvShareDetails"
        Me.lvShareDetails.Size = New System.Drawing.Size(760, 336)
        Me.lvShareDetails.TabIndex = 0
        Me.lvShareDetails.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sl No."
        Me.ColumnHeader1.Width = 51
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date"
        Me.ColumnHeader2.Width = 106
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "No of Shares"
        Me.ColumnHeader3.Width = 102
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Fee"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 117
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Amount"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 119
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Reference No."
        Me.ColumnHeader6.Width = 122
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Type"
        Me.ColumnHeader7.Width = 119
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMemberNo)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.btnSearch)
        Me.GroupBox3.Controls.Add(Me.txtName)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(776, 72)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'txtMemberNo
        '
        Me.txtMemberNo.AlphaNumeric = True
        Me.txtMemberNo.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtMemberNo.BlankSpace = False
        Me.txtMemberNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMemberNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberNo.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtMemberNo.Location = New System.Drawing.Point(152, 24)
        Me.txtMemberNo.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtMemberNo.Mandatory = False
        Me.txtMemberNo.MaxLength = 10
        Me.txtMemberNo.Name = "txtMemberNo"
        Me.txtMemberNo.Size = New System.Drawing.Size(128, 23)
        Me.txtMemberNo.SpecialChar = True
        Me.txtMemberNo.TabIndex = 1
        Me.txtMemberNo.Text = "MB"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(368, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Name :"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(288, 23)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.AutoSize = False
        Me.txtName.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtName.BlankSpace = True
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtName.Location = New System.Drawing.Point(432, 24)
        Me.txtName.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(232, 22)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 9
        Me.txtName.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Member No. :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txtNoOfShares)
        Me.GroupBox5.Controls.Add(Me.txtShareAmount)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 480)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(776, 64)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "No. of Shares :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(288, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Share Amount : "
        '
        'txtNoOfShares
        '
        Me.txtNoOfShares.AlphaNumeric = True
        Me.txtNoOfShares.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtNoOfShares.BlankSpace = False
        Me.txtNoOfShares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoOfShares.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfShares.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtNoOfShares.Location = New System.Drawing.Point(168, 24)
        Me.txtNoOfShares.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtNoOfShares.Mandatory = False
        Me.txtNoOfShares.MaxLength = 10
        Me.txtNoOfShares.Name = "txtNoOfShares"
        Me.txtNoOfShares.ReadOnly = True
        Me.txtNoOfShares.Size = New System.Drawing.Size(104, 23)
        Me.txtNoOfShares.SpecialChar = True
        Me.txtNoOfShares.TabIndex = 7
        Me.txtNoOfShares.Text = ""
        Me.txtNoOfShares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtShareAmount
        '
        Me.txtShareAmount.AlphaNumeric = True
        Me.txtShareAmount.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtShareAmount.BlankSpace = False
        Me.txtShareAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShareAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShareAmount.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtShareAmount.Location = New System.Drawing.Point(408, 24)
        Me.txtShareAmount.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtShareAmount.Mandatory = False
        Me.txtShareAmount.MaxLength = 10
        Me.txtShareAmount.Name = "txtShareAmount"
        Me.txtShareAmount.ReadOnly = True
        Me.txtShareAmount.Size = New System.Drawing.Size(120, 23)
        Me.txtShareAmount.SpecialChar = True
        Me.txtShareAmount.TabIndex = 7
        Me.txtShareAmount.Text = ""
        Me.txtShareAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(664, 560)
        Me.btnClose.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label21.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(72, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(165, 25)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "Share Transaction"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSharesTransaction
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1018, 631)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmSharesTransaction"
        Me.ShowInTaskbar = False
        Me.Text = "Shares Transaction"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmSharesTransaction
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmSharesTransaction
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmSharesTransaction
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmSharesTransaction)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Sub Routines and Functions"

    'To load member share details
    Sub sbLoadMember()
        Dim objDT As DataTable

        If objMember.fnGetMemberDetails(txtMemberNo.Text) Then
            sbClear()
            objDT = objMember.MemberTable
            txtMemberNo.Text = objDT.Rows(0).Item("MemberNo")
            txtName.Text = objDT.Rows(0).Item("Name")
            txtNoOfShares.Text = objDT.Rows(0).Item("NoOfShares")
            txtShareAmount.Text = objDT.Rows(0).Item("ShareAmount")
            sbLoadShareDetails()
        End If
    End Sub

    Sub sbLoadShareDetails()
        Dim objDT As DataTable
        Dim intCounter As Integer = 0
        Dim lvItem As ListViewItem

        lvShareDetails.Items.Clear()

        If objMember.fnGetShareTransaction(txtMemberNo.Text) Then
            objDT = objMember.SharesTable
            While intCounter < objDT.Rows.Count
                lvItem = lvShareDetails.Items.Add(intCounter + 1)
                lvItem.SubItems.Add(Format(objDT.Rows(intCounter).Item("ShareDate"), "dd-MMM-yyyy"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("NoOfShares"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("ShareFee"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("ShareAmount"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("RefNo"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("Type"))
                intCounter += 1
            End While
        End If

    End Sub

    'To clear form control values
    Sub sbClear()
        txtMemberNo.ResetText()
        txtName.ResetText()
        txtNoOfShares.ResetText()
        txtShareAmount.ResetText()
    End Sub

#End Region

#Region " Events"

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim objMemberSearch As New frmMemberSearch
        objMemberSearch.strMemberNo = ""
        objMemberSearch.ShowDialog(Me)
        If objMemberSearch.strMemberNo <> "" Then
            txtMemberNo.Text = objMemberSearch.strMemberNo
            sbLoadMember()
        End If
        objMemberSearch.Dispose()
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmSharesTransaction_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.Enter

        If txtMemberNo.Text <> "" Then
            sbLoadMember()
        End If

    End Sub

    Private Sub btnRemitShares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemitShares.Click
        Dim objfrmRemitShares As New frmRemitShares
        objfrmRemitShares.txtMemberNo.Text = txtMemberNo.Text
        objfrmRemitShares.ShowDialog(Me)
        objfrmRemitShares = Nothing
    End Sub

    Private Sub btnRefundShares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefundShares.Click
        Dim objfrmRefundShares As New frmRefundShares
        objfrmRefundShares.txtMemberNo.Text = txtMemberNo.Text
        objfrmRefundShares.ShowDialog(Me)
        objfrmRefundShares = Nothing
    End Sub

    Private Sub frmSharesTransaction_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.F3 Then
            btnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub btnTransactions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransactions.Click

        If lvShareDetails.SelectedItems.Count > 0 Then
            Dim objfrmAccTrans As New frmAccountTransactions
            objfrmAccTrans.txtAccountNo.Text = txtMemberNo.Text
            objfrmAccTrans.txtName.Text = txtName.Text
            objfrmAccTrans.ShowDialog(Me)
            objfrmAccTrans = Nothing
        Else
            MsgBox("Select member", MsgBoxStyle.Information, Me.Text)
            lvShareDetails.Focus()
        End If

    End Sub

    Private Sub btnIDCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIDCard.Click
        If lvShareDetails.SelectedItems.Count > 0 Then
            Dim objReportViewer As New frmReportViewer
            objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/MemberIDCardKan.rpt"
            objReportViewer.CrystalReportViewer1.SelectionFormula = "{MemberTbl.MemberNo}= '" & txtMemberNo.Text & "'"
            objReportViewer.ShowDialog()
            objReportViewer.Dispose()
        Else
            MsgBox("Select member", MsgBoxStyle.Information, "Members")
            lvShareDetails.Focus()
        End If
    End Sub

    Private Sub btnNominees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNominees.Click
        If txtMemberNo.Text <> "MB" And txtMemberNo.Text <> "" Then
            Dim objNominees As New frmNominees
            objNominees.txtAccountNo.Text = txtMemberNo.Text
            objNominees.txtName.Text = txtName.Text
            objNominees.chrType = "N"
            objNominees.ShowDialog(Me)
            objNominees.Dispose()
        Else
            MsgBox("Select member", MsgBoxStyle.Information, "Members")
            lvShareDetails.Focus()
        End If

    End Sub

    Private Sub txtMemberNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMemberNo.Leave
        If Trim(txtMemberNo.Text) <> "MB" Then
            objMember.MemberNo = txtMemberNo.Text
            If objMember.fnCheckMember Then
                sbLoadMember()
            Else
                txtMemberNo.Text = "MB"
                txtMemberNo.Focus()
            End If

        Else

            'objMember.MemberNo = txtMemberNo.Text
            'If objMember.fnCheckMember Then
            '    sbLoadMember()
            'Else
            sbClear()
            lvShareDetails.Items.Clear()
            txtMemberNo.Text = "MB"
            MsgBox("No member exist for this membershipnumber", MsgBoxStyle.Information, "Members Module")
            '    txtMemberNo.Focus()
            'End If
        End If
    End Sub

    Private Sub btnMemberDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMemberDetails.Click
        If txtMemberNo.Text <> "MB" And txtMemberNo.Text <> "" Then
            Dim objfrmMemberCreation As frmMemberCreation
            objfrmMemberCreation = frmMemberCreation.DefInstance
            objfrmMemberCreation.BringToFront()
            objfrmMemberCreation.MdiParent = Me.MdiParent
            objfrmMemberCreation.txtMemberNo.Text = txtMemberNo.Text
            objfrmMemberCreation.Show()
            objfrmMemberCreation = Nothing
        Else
            MsgBox("Select member", MsgBoxStyle.Information, "Members")
            lvShareDetails.Focus()
        End If
    End Sub

    Private Sub btnFamilyDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFamilyDetails.Click
        If txtMemberNo.Text <> "MB" And txtMemberNo.Text <> "" Then
            Dim objFamilyDetails As New frmFamily_Detail
            objFamilyDetails.txtAccountNo.Text = txtMemberNo.Text
            objFamilyDetails.chrType = "F"
            objFamilyDetails.ShowDialog(Me)
            objFamilyDetails.Dispose()
        Else
            MsgBox("Select member", MsgBoxStyle.Information, "Members")
            lvShareDetails.Focus()
        End If
    End Sub

#End Region

  
End Class
