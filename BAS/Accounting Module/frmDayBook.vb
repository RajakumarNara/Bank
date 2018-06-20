Public Class frmDayBook
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFamilyDetails As BankControls.NewButton
    Friend WithEvents btnIDCard As BankControls.NewButton
    Friend WithEvents btnMemberDetails As BankControls.NewButton
    Friend WithEvents btnTransactions As BankControls.NewButton
    Friend WithEvents NewButton3 As BankControls.NewButton
    Friend WithEvents NewButton4 As BankControls.NewButton
    Friend WithEvents NewButton5 As BankControls.NewButton
    Friend WithEvents NewButton6 As BankControls.NewButton
    Friend WithEvents lvTransactions As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents VNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnShow As BankControls.NewButton
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtReceiptTotal As BankControls.TextControl
    Friend WithEvents txtPaymentTotal As BankControls.TextControl
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtTransferTotal As BankControls.TextControl
    Friend WithEvents btnPrint As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDayBook))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnPrint = New BankControls.NewButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnShow = New BankControls.NewButton
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtTransferTotal = New BankControls.TextControl
        Me.txtReceiptTotal = New BankControls.TextControl
        Me.txtPaymentTotal = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.lvTransactions = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.VNo = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.btnClose = New BankControls.NewButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnFamilyDetails = New BankControls.NewButton
        Me.btnIDCard = New BankControls.NewButton
        Me.btnMemberDetails = New BankControls.NewButton
        Me.btnTransactions = New BankControls.NewButton
        Me.NewButton3 = New BankControls.NewButton
        Me.NewButton4 = New BankControls.NewButton
        Me.NewButton5 = New BankControls.NewButton
        Me.NewButton6 = New BankControls.NewButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.lvTransactions)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Location = New System.Drawing.Point(217, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(792, 616)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.GotFocusColour = System.Drawing.Color.FromArgb(CType(152, Byte), CType(220, Byte), CType(166, Byte))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(24, 560)
        Me.btnPrint.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(104, 40)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "&Print"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dtpStartDate)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.btnShow)
        Me.GroupBox4.Controls.Add(Me.dtpEndDate)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 56)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(760, 48)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpStartDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(144, 16)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpStartDate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Start Date :"
        '
        'btnShow
        '
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShow.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.GotFocusColour = System.Drawing.Color.FromArgb(CType(152, Byte), CType(220, Byte), CType(166, Byte))
        Me.btnShow.Image = CType(resources.GetObject("btnShow.Image"), System.Drawing.Image)
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow.Location = New System.Drawing.Point(544, 16)
        Me.btnShow.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(104, 24)
        Me.btnShow.TabIndex = 3
        Me.btnShow.Text = "&Show"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = "dd -  MMM - yyyy"
        Me.dtpEndDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(384, 16)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(144, 23)
        Me.dtpEndDate.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "End Date :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtTransferTotal)
        Me.GroupBox3.Controls.Add(Me.txtReceiptTotal)
        Me.GroupBox3.Controls.Add(Me.txtPaymentTotal)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 504)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(760, 40)
        Me.GroupBox3.TabIndex = 76
        Me.GroupBox3.TabStop = False
        '
        'txtTransferTotal
        '
        Me.txtTransferTotal.AlphaNumeric = True
        Me.txtTransferTotal.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.txtTransferTotal.BlankSpace = False
        Me.txtTransferTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTransferTotal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransferTotal.GotFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.txtTransferTotal.Location = New System.Drawing.Point(648, 13)
        Me.txtTransferTotal.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.txtTransferTotal.Mandatory = False
        Me.txtTransferTotal.MaxLength = 10
        Me.txtTransferTotal.Name = "txtTransferTotal"
        Me.txtTransferTotal.ReadOnly = True
        Me.txtTransferTotal.Size = New System.Drawing.Size(88, 16)
        Me.txtTransferTotal.SpecialChar = True
        Me.txtTransferTotal.TabIndex = 19
        Me.txtTransferTotal.Text = ""
        Me.txtTransferTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtReceiptTotal
        '
        Me.txtReceiptTotal.AlphaNumeric = True
        Me.txtReceiptTotal.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.txtReceiptTotal.BlankSpace = False
        Me.txtReceiptTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtReceiptTotal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptTotal.GotFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.txtReceiptTotal.Location = New System.Drawing.Point(424, 16)
        Me.txtReceiptTotal.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.txtReceiptTotal.Mandatory = False
        Me.txtReceiptTotal.MaxLength = 10
        Me.txtReceiptTotal.Name = "txtReceiptTotal"
        Me.txtReceiptTotal.ReadOnly = True
        Me.txtReceiptTotal.Size = New System.Drawing.Size(96, 16)
        Me.txtReceiptTotal.SpecialChar = True
        Me.txtReceiptTotal.TabIndex = 18
        Me.txtReceiptTotal.Text = ""
        Me.txtReceiptTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPaymentTotal
        '
        Me.txtPaymentTotal.AlphaNumeric = True
        Me.txtPaymentTotal.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.txtPaymentTotal.BlankSpace = False
        Me.txtPaymentTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPaymentTotal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentTotal.GotFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.txtPaymentTotal.Location = New System.Drawing.Point(536, 16)
        Me.txtPaymentTotal.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.txtPaymentTotal.Mandatory = False
        Me.txtPaymentTotal.MaxLength = 10
        Me.txtPaymentTotal.Name = "txtPaymentTotal"
        Me.txtPaymentTotal.ReadOnly = True
        Me.txtPaymentTotal.Size = New System.Drawing.Size(88, 16)
        Me.txtPaymentTotal.SpecialChar = True
        Me.txtPaymentTotal.TabIndex = 17
        Me.txtPaymentTotal.Text = ""
        Me.txtPaymentTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(352, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Total :"
        '
        'lvTransactions
        '
        Me.lvTransactions.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.lvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvTransactions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.VNo, Me.ColumnHeader4, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader2, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvTransactions.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvTransactions.FullRowSelect = True
        Me.lvTransactions.GridLines = True
        Me.lvTransactions.HideSelection = False
        Me.lvTransactions.Location = New System.Drawing.Point(16, 112)
        Me.lvTransactions.MultiSelect = False
        Me.lvTransactions.Name = "lvTransactions"
        Me.lvTransactions.Size = New System.Drawing.Size(760, 384)
        Me.lvTransactions.TabIndex = 4
        Me.lvTransactions.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sl No."
        Me.ColumnHeader1.Width = 49
        '
        'VNo
        '
        Me.VNo.Text = "VNo"
        Me.VNo.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date"
        Me.ColumnHeader4.Width = 72
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Reference No."
        Me.ColumnHeader3.Width = 96
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Narration"
        Me.ColumnHeader5.Width = 201
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Receipt"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 109
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Payment"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 109
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Transfer"
        Me.ColumnHeader7.Width = 109
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
        Me.btnClose.Location = New System.Drawing.Point(672, 560)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.Label21.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Green
        Me.Label21.Location = New System.Drawing.Point(72, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(90, 25)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "Day Book"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnFamilyDetails)
        Me.GroupBox2.Controls.Add(Me.btnIDCard)
        Me.GroupBox2.Controls.Add(Me.btnMemberDetails)
        Me.GroupBox2.Controls.Add(Me.btnTransactions)
        Me.GroupBox2.Controls.Add(Me.NewButton3)
        Me.GroupBox2.Controls.Add(Me.NewButton4)
        Me.GroupBox2.Controls.Add(Me.NewButton5)
        Me.GroupBox2.Controls.Add(Me.NewButton6)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 616)
        Me.GroupBox2.TabIndex = 20
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
        Me.btnFamilyDetails.TabIndex = 15
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
        Me.btnIDCard.TabIndex = 19
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
        Me.btnMemberDetails.TabIndex = 16
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
        Me.btnTransactions.TabIndex = 20
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
        Me.NewButton3.TabIndex = 19
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
        Me.NewButton4.TabIndex = 19
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
        Me.NewButton5.TabIndex = 20
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
        Me.NewButton6.TabIndex = 20
        Me.NewButton6.Text = "View Reports"
        Me.NewButton6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton6.Visible = False
        '
        'frmDayBook
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1018, 631)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmDayBook"
        Me.ShowInTaskbar = False
        Me.Text = "Day Book"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmDayBook
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmDayBook
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmDayBook
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmDayBook)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

    Sub sbLoadDetails()
        Dim objDT As DataTable
        Dim lvItem As ListViewItem
        Dim dblRecTotal As Double = 0
        Dim dblPayTotal As Double = 0
        Dim dblTranTotal As Double = 0
        Dim intCounter As Integer = 0

        objDT = fnVoucherGetVouchers(dtpStartDate.Value, dtpEndDate.Value)

        lvTransactions.Items.Clear()

        If objDT.Rows.Count > 0 Then
            While intCounter < objDT.Rows.Count
                lvItem = lvTransactions.Items.Add(intCounter + 1)
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("VoucherNo"))
                lvItem.SubItems.Add(Format(objDT.Rows(intCounter).Item("VDate"), "dd-MMM-yyyy"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("RefNo"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("Narration"))
                If objDT.Rows(intCounter).Item("Type") = "Receipt" Then
                    lvItem.SubItems.Add(objDT.Rows(intCounter).Item("Amount"))
                    lvItem.SubItems.Add("")
                    lvItem.SubItems.Add("")
                    dblRecTotal += objDT.Rows(intCounter).Item("Amount")
                ElseIf objDT.Rows(intCounter).Item("Type") = "Paymemnt" Then
                    lvItem.SubItems.Add("")
                    lvItem.SubItems.Add(objDT.Rows(intCounter).Item("Amount"))
                    lvItem.SubItems.Add("")
                    dblPayTotal += objDT.Rows(intCounter).Item("Amount")
                ElseIf objDT.Rows(intCounter).Item("Type") = "Transfer" Then
                    lvItem.SubItems.Add("")
                    lvItem.SubItems.Add("")
                    lvItem.SubItems.Add(objDT.Rows(intCounter).Item("Amount"))
                    dblTranTotal += objDT.Rows(intCounter).Item("Amount")
                End If
                intCounter += 1
            End While
        End If
        txtReceiptTotal.Text = Format(dblRecTotal, "0,0.00")
        txtPaymentTotal.Text = Format(dblPayTotal, "0,0.00")
        txtTransferTotal.Text = Format(dblTranTotal, "0,0.00")
    End Sub

    Private Sub frmDayBook_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpStartDate.MaxDate = Date.Now.Date
        dtpEndDate.MaxDate = Date.Now.Date
        dtpStartDate.Value = Date.Now.Date
        dtpEndDate.Value = Date.Now.Date
        sbLoadDetails()
    End Sub

    Private Sub btnShow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShow.Click
        sbLoadDetails()
    End Sub

    Private Sub lvTransactions_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvTransactions.DoubleClick
        If lvTransactions.SelectedItems.Count > 0 Then
            Dim objfrmVoucherDetails As New frmVoucherDetails
            objfrmVoucherDetails.VoucherNo = lvTransactions.SelectedItems(0).SubItems(1).Text
            objfrmVoucherDetails.VoucherDate = lvTransactions.SelectedItems(0).SubItems(2).Text
            objfrmVoucherDetails.ReferenceNo = lvTransactions.SelectedItems(0).SubItems(3).Text
            objfrmVoucherDetails.ShowDialog(Me)
            objfrmVoucherDetails = Nothing
        Else
            MsgBox("Select Record ", MsgBoxStyle.Information, Me.Text)
        End If

    End Sub

    Private Sub lvTransactions_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvTransactions.KeyDown
        If e.KeyData = Keys.Enter Then
            lvTransactions_DoubleClick(sender, e)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim objReportViewer As New frmReportViewer
        Dim Vdate As Date
        Dim DateRange As String

        If fnDeleteDate() Then
            FromDate = dtpStartDate.Value
            ToDate = dtpEndDate.Value
            fnInsertDate()
        End If

        DateRange = "{fasvouchersubtbl.VDate} in CDate(""" + dtpStartDate.Value + """) to CDate(""" + dtpEndDate.Value + """) and {fasvouchersubtbl.LedgerNo}=1"
        objReportViewer.CrystalReportViewer1.SelectionFormula = DateRange
        ' objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/Reports/DayBook.rpt" 'Cashroll.rpt" 'receipt.rpt" 'ReciptAndPayment.rpt"
        objReportViewer.CrystalReportViewer1.ReportSource = "C:/Program Files/Coherent/BAS/Reports/DayBook.rpt"
        objReportViewer.ShowDialog()
        objReportViewer = Nothing
    End Sub
End Class
