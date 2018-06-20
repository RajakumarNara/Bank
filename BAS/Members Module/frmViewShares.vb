Public Class frmViewShares
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
    Friend WithEvents NewButton10 As BankControls.NewButton
    Friend WithEvents btnSBdetails As BankControls.NewButton
    Friend WithEvents NewButton6 As BankControls.NewButton
    Friend WithEvents NewButton9 As BankControls.NewButton
    Friend WithEvents btnNominees As BankControls.NewButton
    Friend WithEvents btnFamilyDetails As BankControls.NewButton
    Friend WithEvents btnIDCard As BankControls.NewButton
    Friend WithEvents btnMemberDetails As BankControls.NewButton
    Friend WithEvents btnTransactions As BankControls.NewButton
    Friend WithEvents btnRemitShares As BankControls.NewButton
    Friend WithEvents btnRefundShares As BankControls.NewButton
    Friend WithEvents btnTransferShares As BankControls.NewButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents lvShares As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents dtpSearch As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnReceipt As BankControls.NewButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewShares))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NewButton10 = New BankControls.NewButton()
        Me.btnReceipt = New BankControls.NewButton()
        Me.btnSBdetails = New BankControls.NewButton()
        Me.NewButton6 = New BankControls.NewButton()
        Me.NewButton9 = New BankControls.NewButton()
        Me.btnNominees = New BankControls.NewButton()
        Me.btnFamilyDetails = New BankControls.NewButton()
        Me.btnIDCard = New BankControls.NewButton()
        Me.btnMemberDetails = New BankControls.NewButton()
        Me.btnTransactions = New BankControls.NewButton()
        Me.btnRemitShares = New BankControls.NewButton()
        Me.btnRefundShares = New BankControls.NewButton()
        Me.btnTransferShares = New BankControls.NewButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnClose = New BankControls.NewButton()
        Me.lvShares = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New BankControls.TextControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New BankControls.NewButton()
        Me.dtpSearch = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NewButton10)
        Me.GroupBox1.Controls.Add(Me.btnReceipt)
        Me.GroupBox1.Controls.Add(Me.btnSBdetails)
        Me.GroupBox1.Controls.Add(Me.NewButton6)
        Me.GroupBox1.Controls.Add(Me.NewButton9)
        Me.GroupBox1.Controls.Add(Me.btnNominees)
        Me.GroupBox1.Controls.Add(Me.btnFamilyDetails)
        Me.GroupBox1.Controls.Add(Me.btnIDCard)
        Me.GroupBox1.Controls.Add(Me.btnMemberDetails)
        Me.GroupBox1.Controls.Add(Me.btnTransactions)
        Me.GroupBox1.Controls.Add(Me.btnRemitShares)
        Me.GroupBox1.Controls.Add(Me.btnRefundShares)
        Me.GroupBox1.Controls.Add(Me.btnTransferShares)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 616)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'NewButton10
        '
        Me.NewButton10.BackColor = System.Drawing.Color.AntiqueWhite
        Me.NewButton10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NewButton10.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NewButton10.Image = CType(resources.GetObject("NewButton10.Image"), System.Drawing.Image)
        Me.NewButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton10.Location = New System.Drawing.Point(16, 560)
        Me.NewButton10.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.NewButton10.Name = "NewButton10"
        Me.NewButton10.Size = New System.Drawing.Size(168, 40)
        Me.NewButton10.TabIndex = 7
        Me.NewButton10.Text = "De&posit Details"
        Me.NewButton10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton10.UseVisualStyleBackColor = False
        Me.NewButton10.Visible = False
        '
        'btnReceipt
        '
        Me.btnReceipt.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReceipt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceipt.ForeColor = System.Drawing.Color.Black
        Me.btnReceipt.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnReceipt.Image = CType(resources.GetObject("btnReceipt.Image"), System.Drawing.Image)
        Me.btnReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReceipt.Location = New System.Drawing.Point(16, 472)
        Me.btnReceipt.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(168, 40)
        Me.btnReceipt.TabIndex = 3
        Me.btnReceipt.Text = "&Receipt Details"
        Me.btnReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReceipt.UseVisualStyleBackColor = False
        Me.btnReceipt.Visible = False
        '
        'btnSBdetails
        '
        Me.btnSBdetails.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnSBdetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSBdetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSBdetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSBdetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSBdetails.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSBdetails.Image = CType(resources.GetObject("btnSBdetails.Image"), System.Drawing.Image)
        Me.btnSBdetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSBdetails.Location = New System.Drawing.Point(8, 560)
        Me.btnSBdetails.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnSBdetails.Name = "btnSBdetails"
        Me.btnSBdetails.Size = New System.Drawing.Size(168, 40)
        Me.btnSBdetails.TabIndex = 6
        Me.btnSBdetails.Text = "S&B Details..."
        Me.btnSBdetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSBdetails.UseVisualStyleBackColor = False
        Me.btnSBdetails.Visible = False
        '
        'NewButton6
        '
        Me.NewButton6.BackColor = System.Drawing.Color.AntiqueWhite
        Me.NewButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NewButton6.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NewButton6.Image = CType(resources.GetObject("NewButton6.Image"), System.Drawing.Image)
        Me.NewButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton6.Location = New System.Drawing.Point(8, 552)
        Me.NewButton6.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.NewButton6.Name = "NewButton6"
        Me.NewButton6.Size = New System.Drawing.Size(168, 40)
        Me.NewButton6.TabIndex = 5
        Me.NewButton6.Text = "Share &Details..."
        Me.NewButton6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton6.UseVisualStyleBackColor = False
        Me.NewButton6.Visible = False
        '
        'NewButton9
        '
        Me.NewButton9.BackColor = System.Drawing.Color.AntiqueWhite
        Me.NewButton9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NewButton9.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NewButton9.Image = CType(resources.GetObject("NewButton9.Image"), System.Drawing.Image)
        Me.NewButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton9.Location = New System.Drawing.Point(16, 552)
        Me.NewButton9.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.NewButton9.Name = "NewButton9"
        Me.NewButton9.Size = New System.Drawing.Size(168, 40)
        Me.NewButton9.TabIndex = 8
        Me.NewButton9.Text = "&Loan Details..."
        Me.NewButton9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton9.UseVisualStyleBackColor = False
        Me.NewButton9.Visible = False
        '
        'btnNominees
        '
        Me.btnNominees.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnNominees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNominees.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNominees.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNominees.ForeColor = System.Drawing.Color.Black
        Me.btnNominees.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNominees.Image = CType(resources.GetObject("btnNominees.Image"), System.Drawing.Image)
        Me.btnNominees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNominees.Location = New System.Drawing.Point(16, 232)
        Me.btnNominees.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnNominees.Name = "btnNominees"
        Me.btnNominees.Size = New System.Drawing.Size(168, 40)
        Me.btnNominees.TabIndex = 2
        Me.btnNominees.Text = "&Nominee Details"
        Me.btnNominees.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNominees.UseVisualStyleBackColor = False
        '
        'btnFamilyDetails
        '
        Me.btnFamilyDetails.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnFamilyDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFamilyDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFamilyDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFamilyDetails.ForeColor = System.Drawing.Color.Black
        Me.btnFamilyDetails.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnFamilyDetails.Image = CType(resources.GetObject("btnFamilyDetails.Image"), System.Drawing.Image)
        Me.btnFamilyDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFamilyDetails.Location = New System.Drawing.Point(16, 192)
        Me.btnFamilyDetails.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnFamilyDetails.Name = "btnFamilyDetails"
        Me.btnFamilyDetails.Size = New System.Drawing.Size(168, 40)
        Me.btnFamilyDetails.TabIndex = 1
        Me.btnFamilyDetails.Text = "&Family Details"
        Me.btnFamilyDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFamilyDetails.UseVisualStyleBackColor = False
        '
        'btnIDCard
        '
        Me.btnIDCard.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnIDCard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIDCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIDCard.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIDCard.ForeColor = System.Drawing.Color.Black
        Me.btnIDCard.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnIDCard.Image = CType(resources.GetObject("btnIDCard.Image"), System.Drawing.Image)
        Me.btnIDCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIDCard.Location = New System.Drawing.Point(16, 272)
        Me.btnIDCard.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnIDCard.Name = "btnIDCard"
        Me.btnIDCard.Size = New System.Drawing.Size(168, 40)
        Me.btnIDCard.TabIndex = 4
        Me.btnIDCard.Text = "Issue &ID Card"
        Me.btnIDCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIDCard.UseVisualStyleBackColor = False
        Me.btnIDCard.Visible = False
        '
        'btnMemberDetails
        '
        Me.btnMemberDetails.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnMemberDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMemberDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMemberDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemberDetails.ForeColor = System.Drawing.Color.Black
        Me.btnMemberDetails.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMemberDetails.Image = CType(resources.GetObject("btnMemberDetails.Image"), System.Drawing.Image)
        Me.btnMemberDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMemberDetails.Location = New System.Drawing.Point(16, 152)
        Me.btnMemberDetails.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnMemberDetails.Name = "btnMemberDetails"
        Me.btnMemberDetails.Size = New System.Drawing.Size(168, 40)
        Me.btnMemberDetails.TabIndex = 0
        Me.btnMemberDetails.Text = "&Member Details"
        Me.btnMemberDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMemberDetails.UseVisualStyleBackColor = False
        '
        'btnTransactions
        '
        Me.btnTransactions.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnTransactions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransactions.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransactions.ForeColor = System.Drawing.Color.Black
        Me.btnTransactions.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnTransactions.Image = CType(resources.GetObject("btnTransactions.Image"), System.Drawing.Image)
        Me.btnTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransactions.Location = New System.Drawing.Point(16, 96)
        Me.btnTransactions.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnTransactions.Name = "btnTransactions"
        Me.btnTransactions.Size = New System.Drawing.Size(168, 40)
        Me.btnTransactions.TabIndex = 4
        Me.btnTransactions.Text = "&Transactions"
        Me.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTransactions.UseVisualStyleBackColor = False
        Me.btnTransactions.Visible = False
        '
        'btnRemitShares
        '
        Me.btnRemitShares.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnRemitShares.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemitShares.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemitShares.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemitShares.ForeColor = System.Drawing.Color.Black
        Me.btnRemitShares.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRemitShares.Image = CType(resources.GetObject("btnRemitShares.Image"), System.Drawing.Image)
        Me.btnRemitShares.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemitShares.Location = New System.Drawing.Point(16, 312)
        Me.btnRemitShares.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnRemitShares.Name = "btnRemitShares"
        Me.btnRemitShares.Size = New System.Drawing.Size(168, 40)
        Me.btnRemitShares.TabIndex = 4
        Me.btnRemitShares.Text = "&Remit Shares"
        Me.btnRemitShares.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemitShares.UseVisualStyleBackColor = False
        '
        'btnRefundShares
        '
        Me.btnRefundShares.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnRefundShares.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefundShares.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefundShares.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefundShares.ForeColor = System.Drawing.Color.Black
        Me.btnRefundShares.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRefundShares.Image = CType(resources.GetObject("btnRefundShares.Image"), System.Drawing.Image)
        Me.btnRefundShares.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefundShares.Location = New System.Drawing.Point(16, 352)
        Me.btnRefundShares.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnRefundShares.Name = "btnRefundShares"
        Me.btnRefundShares.Size = New System.Drawing.Size(168, 40)
        Me.btnRefundShares.TabIndex = 4
        Me.btnRefundShares.Text = "Refund &Shares"
        Me.btnRefundShares.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefundShares.UseVisualStyleBackColor = False
        '
        'btnTransferShares
        '
        Me.btnTransferShares.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnTransferShares.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransferShares.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransferShares.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransferShares.ForeColor = System.Drawing.Color.Black
        Me.btnTransferShares.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnTransferShares.Image = CType(resources.GetObject("btnTransferShares.Image"), System.Drawing.Image)
        Me.btnTransferShares.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransferShares.Location = New System.Drawing.Point(16, 392)
        Me.btnTransferShares.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnTransferShares.Name = "btnTransferShares"
        Me.btnTransferShares.Size = New System.Drawing.Size(168, 40)
        Me.btnTransferShares.TabIndex = 4
        Me.btnTransferShares.Text = "Tra&nsfer Shares"
        Me.btnTransferShares.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTransferShares.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.lvShares)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(224, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(784, 616)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Image = Global.BAS.Resources.printericon
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(319, 570)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 40)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "     Share " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      Extract Print"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Image = Global.BAS.Resources.printericon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(52, 568)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 42)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "    Share " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Shcedule Print"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label21.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(76, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 23)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "Share List"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(660, 568)
        Me.btnClose.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 26
        Me.btnClose.Text = "&Close"
        '
        'lvShares
        '
        Me.lvShares.AllowColumnReorder = True
        Me.lvShares.BackColor = System.Drawing.Color.OldLace
        Me.lvShares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvShares.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader9, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader6, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lvShares.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvShares.FullRowSelect = True
        Me.lvShares.GridLines = True
        Me.lvShares.HideSelection = False
        Me.lvShares.Location = New System.Drawing.Point(0, 152)
        Me.lvShares.MultiSelect = False
        Me.lvShares.Name = "lvShares"
        Me.lvShares.Size = New System.Drawing.Size(764, 410)
        Me.lvShares.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvShares.TabIndex = 25
        Me.lvShares.UseCompatibleStateImageBehavior = False
        Me.lvShares.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Member No."
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Customer ID"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 206
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Date"
        Me.ColumnHeader5.Width = 99
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Shares"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Share Amount"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 97
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Reciept No ."
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 87
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Status"
        Me.ColumnHeader8.Width = 101
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Remarks"
        Me.ColumnHeader6.Width = 90
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Paid Amount"
        Me.ColumnHeader10.Width = 90
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Calls In Arreir"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSearch)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cmbType)
        Me.GroupBox3.Controls.Add(Me.btnSearch)
        Me.GroupBox3.Controls.Add(Me.dtpSearch)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 72)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(760, 56)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.AlphaNumeric = True
        Me.txtSearch.BlankSpace = True
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSearch.Location = New System.Drawing.Point(448, 24)
        Me.txtSearch.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtSearch.Mandatory = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 23)
        Me.txtSearch.SpecialChar = True
        Me.txtSearch.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(344, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Search Text : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Search By:"
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Items.AddRange(New Object() {"Name", "MemberNo", "CustomerID", "Date", "No of Shares", "Share Amount"})
        Me.cmbType.Location = New System.Drawing.Point(104, 24)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(200, 24)
        Me.cmbType.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.NavajoWhite
        Me.btnSearch.Location = New System.Drawing.Point(656, 24)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(32, 24)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        Me.btnSearch.Visible = False
        '
        'dtpSearch
        '
        Me.dtpSearch.CustomFormat = "dd / MMM / yyyy"
        Me.dtpSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSearch.Location = New System.Drawing.Point(456, 24)
        Me.dtpSearch.MaxDate = New Date(2852, 12, 19, 0, 0, 0, 0)
        Me.dtpSearch.MinDate = New Date(1800, 1, 1, 0, 0, 0, 0)
        Me.dtpSearch.Name = "dtpSearch"
        Me.dtpSearch.Size = New System.Drawing.Size(192, 22)
        Me.dtpSearch.TabIndex = 112
        Me.dtpSearch.Value = New Date(2007, 10, 23, 0, 0, 0, 0)
        '
        'frmViewShares
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1018, 631)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewShares"
        Me.ShowInTaskbar = False
        Me.Text = "Share List "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmViewShares
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmViewShares
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmViewShares
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmViewShares)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Variables"

    Dim dvItems As New DataView
    Dim objClsShares As New clsShares
    Dim strFilter As String = "Name like '%'"
    Public intCount As Integer

#End Region

#Region "Functions"

    Public Function fnShareHldrList() As Boolean

        Dim intCount As Integer
        Dim lstvItems As New ListViewItem
        Dim TotalPaidAmount As Decimal = 0
        dvItems.RowFilter = strFilter
        lvShares.Items.Clear()
        While intCount < dvItems.Count
            lstvItems = lvShares.Items.Add(dvItems.Item(intCount).Item("MemberNo"))
            lstvItems.UseItemStyleForSubItems = False
            lstvItems.SubItems.Add(dvItems.Item(intCount).Item("CustomerID"))
            lstvItems.SubItems.Add(dvItems.Item(intCount).Item("Name"))
            lstvItems.SubItems.Add(Format(dvItems.Item(intCount).Item("ApplDate"), "yyyy-MM-dd"))
            lstvItems.SubItems.Add(dvItems.Item(intCount).Item("NoOfShares"))
            lstvItems.SubItems.Add(Format(dvItems.Item(intCount).Item("ShareAmount"), "0,00.00"))
            lstvItems.SubItems.Add(dvItems.Item(intCount).Item("ReceiptNo"))
            lstvItems.SubItems.Add(dvItems.Item(intCount).Item("Status"))
            lstvItems.UseItemStyleForSubItems = False
            lstvItems.SubItems.Add(dvItems.Item(intCount).Item("Remarks"))
            lstvItems.SubItems.Add(dvItems.Item(intCount).Item("CallsInArrier"))
            lstvItems.SubItems.Add(Format(Convert.ToDecimal(dvItems.Item(intCount).Item("ShareAmount")) - Convert.ToDecimal(dvItems.Item(intCount).Item("CallsInArrier")), "0,00.00"))
            '1stvItems.subItems.Add(dvItems.Item(intCount ).Item("Due Amount"))
            'TotalShareAmount += Convert.ToDecimal(dvItems.Item(intCount).Item("ShareAmount"))
            'TotalCallsInArrier += Convert.ToDecimal(dvItems.Item(intCount).Item("CallsInArrier"))
            intCount += 1
        End While
    End Function

#End Region
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try


            Dim objReportViewer As New frmReportViewer
            objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/ShareListToPrint.rpt"
            ' objReportViewer.CrystalReportViewer1.ReportSource = "C:\Program Files\Coherent\BAS\Reports\ShareListToPrint.rpt"
            objReportViewer.ShowDialog()
            objReportViewer = Nothing
            dtpSearch.Visible = False
            btnSearch.Visible = False

        Catch ex As Exception
            Throw ex

        End Try
    End Sub



#Region "Events"

    Private Sub frmViewShares_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If objClsShares.fnGetShareList() Then
            dvItems = New DataView(objClsShares.ShareListTbl, strFilter, "Name", DataViewRowState.OriginalRows)
            fnShareHldrList()
        End If

        dtpSearch.Visible = False
        btnSearch.Visible = False

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged

        ' If txtSearch.Text <> "" Then
        If cmbType.SelectedItem = "Name" Then
            strFilter = "Name like '" & txtSearch.Text & "%'"
            fnShareHldrList()
        ElseIf cmbType.SelectedItem = "MemberNo" Then
            strFilter = "MemberNo like '" & txtSearch.Text & "%'"
            fnShareHldrList()
        ElseIf cmbType.SelectedItem = "CustomerID" Then
            strFilter = "CustomerID like '" & txtSearch.Text & "%'"
            fnShareHldrList()
        ElseIf cmbType.SelectedItem = "No of Shares" Then
            strFilter = "NoofShares = '" & Val(txtSearch.Text) & "'"
            fnShareHldrList()
        ElseIf cmbType.SelectedItem = "Share Amount" Then
            strFilter = "ShareAmount = '" & Val(txtSearch.Text) & "'"
            fnShareHldrList()
        End If


        ' End If
    End Sub

    Private Sub lvShares_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvShares.DoubleClick

        If lvShares.SelectedItems.Count > 0 Then
            Dim objfrmMemberCreation As New frmMemberCreation
            objfrmMemberCreation.txtMemberNo.Text = lvShares.SelectedItems(0).SubItems(0).Text
            objfrmMemberCreation.MdiParent = Me.MdiParent
            objfrmMemberCreation.BringToFront()
            objfrmMemberCreation.Show()
            objfrmMemberCreation = Nothing
        Else
            MsgBox("Select Member", MsgBoxStyle.Information, "Members")
            lvShares.Focus()
        End If

    End Sub

    Private Sub btnMemberDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMemberDetails.Click

        If lvShares.SelectedItems.Count > 0 Then
            Dim objfrmMemberCreation As New frmMemberCreation
            objfrmMemberCreation = frmMemberCreation.DefInstance
            objfrmMemberCreation.BringToFront()
            objfrmMemberCreation.MdiParent = Me.MdiParent
            objfrmMemberCreation.txtMemberNo.Text = lvShares.SelectedItems(0).SubItems(0).Text
            objfrmMemberCreation.Show()
            objfrmMemberCreation = Nothing
        Else
            MsgBox("Select member", MsgBoxStyle.Information, "Members")
            lvShares.Focus()
        End If

    End Sub

    Private Sub btnNominees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNominees.Click

        If lvShares.SelectedItems.Count > 0 Then
            Dim objNominees As New frmNominees
            objNominees.txtAccountNo.Text = lvShares.SelectedItems(0).SubItems(0).Text
            objNominees.txtName.Text = lvShares.SelectedItems(0).SubItems(1).Text
            objNominees.chrType = "N"
            objNominees.ShowDialog(Me)
            objNominees.Dispose()
        Else
            MsgBox("Select member", MsgBoxStyle.Information, "Members")
            lvShares.Focus()
        End If

    End Sub

    Private Sub btnIDCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIDCard.Click

        If lvShares.SelectedItems.Count > 0 Then
            Dim objReportViewer As New frmReportViewer
            objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/MemberIDCardKan.rpt"
            objReportViewer.CrystalReportViewer1.SelectionFormula = "{MemberTbl.MemberNo}= '" & lvShares.SelectedItems(0).SubItems(0).Text & "'"
            objReportViewer.ShowDialog()
            objReportViewer.Dispose()
        Else
            MsgBox("Select member", MsgBoxStyle.Information, "Members")
            lvShares.Focus()
        End If

    End Sub

    Private Sub btnTransactions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransactions.Click

        If lvShares.SelectedItems.Count > 0 Then
            'Dim objfrmaccTrans As New frmSharesTransaction
            'objfrmaccTrans.txtMemberNo.Text = lvShares.SelectedItems(0).SubItems(0).Text
            'objfrmaccTrans.txtName.Text = lvShares.SelectedItems(0).SubItems(1).Text
            'objfrmaccTrans.ShowDialog(Me)
            'objfrmaccTrans = Nothing

            Dim objfrmaccTrans As New frmSharesTransaction
            objfrmaccTrans = frmSharesTransaction.DefInstance
            objfrmaccTrans.BringToFront()
            objfrmaccTrans.MdiParent = Me.MdiParent
            objfrmaccTrans.txtMemberNo.Text = lvShares.SelectedItems(0).SubItems(0).Text
            objfrmaccTrans.txtName.Text = lvShares.SelectedItems(0).SubItems(1).Text
            objfrmaccTrans.Show()
            objfrmaccTrans = Nothing
        Else
            MsgBox("Select member", MsgBoxStyle.Information, Me.Text)
            lvShares.Focus()
        End If

    End Sub

    Private Sub btnRemitShares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemitShares.Click

        If lvShares.SelectedItems.Count > 0 Then
            If lvShares.SelectedItems(intCount).SubItems(6).Text = "Active" Then
                Dim objfrmRemitShares As New frmRemitShares
                objfrmRemitShares.txtMemberNo.Text = lvShares.SelectedItems(0).SubItems(0).Text
                objfrmRemitShares.ShowDialog(Me)
                objfrmRemitShares = Nothing
            Else
                MsgBox("Account is closed", MsgBoxStyle.Exclamation, "Shares Module")
            End If
        Else
            MsgBox("Select member", MsgBoxStyle.Information, Me.Text)
            lvShares.Focus()
        End If

    End Sub

    Private Sub btnRefundShares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefundShares.Click
        If lvShares.SelectedItems.Count > 0 Then
            If lvShares.SelectedItems(intCount).SubItems(6).Text = "Active" Then
                Dim objfrmRefundShares As New frmRefundShares
                objfrmRefundShares.txtMemberNo.Text = lvShares.SelectedItems(0).SubItems(0).Text
                objfrmRefundShares.ShowDialog(Me)
                objfrmRefundShares = Nothing
            Else
                MsgBox("Account is closed", MsgBoxStyle.Exclamation, " Shares Module")
            End If
        Else
            MsgBox("Select member", MsgBoxStyle.Information, Me.Text)
            lvShares.Focus()
        End If
    End Sub

    Private Sub NewButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton6.Click
        If lvShares.SelectedItems.Count > 0 Then
            Dim objfrmShareTransaction As New frmSharesTransaction
            objfrmShareTransaction = frmSharesTransaction.DefInstance
            objfrmShareTransaction.BringToFront()
            objfrmShareTransaction.MdiParent = Me.MdiParent
            objfrmShareTransaction.txtMemberNo.Text = lvShares.SelectedItems(0).SubItems(0).Text
            objfrmShareTransaction.Show()
            objfrmShareTransaction = Nothing
        Else
            MsgBox("Select member", MsgBoxStyle.Information, Me.Text)
            lvShares.Focus()
        End If

    End Sub

    Private Sub cmbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If cmbType.SelectedItem = "Date" Then
            dtpSearch.Visible = True
            btnSearch.Visible = True
            txtSearch.Visible = False
        Else
            txtSearch.Visible = True
            dtpSearch.Visible = False
            btnSearch.Visible = False
        End If

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If cmbType.SelectedItem = "Date" Then
            strFilter = "ApplDate = '" & dtpSearch.Value & "'"
            fnShareHldrList()
        End If

    End Sub

    Private Sub btnFamilyDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFamilyDetails.Click
        If lvShares.SelectedItems.Count > 0 Then
            Dim objFamilyDetails As New frmFamily_Detail
            objFamilyDetails.txtAccountNo.Text = lvShares.SelectedItems(0).SubItems(0).Text
            objFamilyDetails.chrType = "F"
            objFamilyDetails.ShowDialog(Me)
            objFamilyDetails.Dispose()
        Else
            MsgBox("Select member", MsgBoxStyle.Information, "Members")
            lvShares.Focus()
        End If
    End Sub

    Private Sub btnTransferShares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransferShares.Click
        If lvShares.SelectedItems.Count > 0 Then
            If lvShares.SelectedItems(intCount).SubItems(6).Text = "Active" Then
                Dim objfrmTransferShares As New frmTransferShares
                'objfrmTransferShares.txtMemberNo.Text = lvShares.SelectedItems(0).SubItems(0).Text
                objfrmTransferShares.ShowDialog(Me)
                objfrmTransferShares = Nothing
            Else
                MsgBox("Account is closed", MsgBoxStyle.Exclamation, " Shares Module")
            End If
        Else
            MsgBox("Select member", MsgBoxStyle.Information, Me.Text)
            lvShares.Focus()
        End If
    End Sub

#End Region


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try


            Dim objReportViewer As New frmReportViewer
            'objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/ShareListToExtract.rpt"
            objReportViewer.CrystalReportViewer1.ReportSource = "C:\Program Files\Coherent\BAS\Reports\ShareListToExtract.rpt"
            objReportViewer.ShowDialog()
            objReportViewer = Nothing
            dtpSearch.Visible = False
            btnSearch.Visible = False

        Catch ex As Exception
            Throw ex

        End Try
    End Sub
End Class
