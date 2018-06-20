Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Drawing.Printing
Public Class frmMembersList
    Inherits System.Windows.Forms.Form

#Region "Form Global Variables"
    Dim objMember As New clsMember
    Dim dvMembers As DataView
    Public strMemberNo As String
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnShareCertificateBook As BankControls.NewButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCallsInArrier As System.Windows.Forms.Label
    Friend WithEvents lblShareAmount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblPaidAmount As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Dim strFilter As String = "Name like '%'"
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
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpSearch As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lvMembers As System.Windows.Forms.ListView
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents btnAddMember As BankControls.NewButton
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRemitShares As BankControls.NewButton
    Friend WithEvents btnRefundShares As BankControls.NewButton
    Friend WithEvents btnDepositDetails As BankControls.NewButton
    Friend WithEvents btnSBdetails As BankControls.NewButton
    Friend WithEvents btnShareDetails As BankControls.NewButton
    Friend WithEvents btnLoanDetails As BankControls.NewButton
    Friend WithEvents btnNominees As BankControls.NewButton
    Friend WithEvents btnFamilyDetails As BankControls.NewButton
    Friend WithEvents btnIDCard As BankControls.NewButton
    Friend WithEvents btnMemberDetails As BankControls.NewButton
    Friend WithEvents btnTransactions As BankControls.NewButton
    Friend WithEvents BalloonToolTip1 As CustomTooltip.BalloonToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMembersList))
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblPaidAmount = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblCallsInArrier = New System.Windows.Forms.Label
        Me.lblShareAmount = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnShareCertificateBook = New BankControls.NewButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.txtSearch = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpSearch = New System.Windows.Forms.DateTimePicker
        Me.btnSearch = New BankControls.NewButton
        Me.lblMessage = New System.Windows.Forms.Label
        Me.lvMembers = New System.Windows.Forms.ListView
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.btnClose = New BankControls.NewButton
        Me.btnAddMember = New BankControls.NewButton
        Me.Label21 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnRemitShares = New BankControls.NewButton
        Me.btnRefundShares = New BankControls.NewButton
        Me.btnDepositDetails = New BankControls.NewButton
        Me.btnSBdetails = New BankControls.NewButton
        Me.btnShareDetails = New BankControls.NewButton
        Me.btnLoanDetails = New BankControls.NewButton
        Me.btnNominees = New BankControls.NewButton
        Me.btnFamilyDetails = New BankControls.NewButton
        Me.btnIDCard = New BankControls.NewButton
        Me.btnMemberDetails = New BankControls.NewButton
        Me.btnTransactions = New BankControls.NewButton
        Me.BalloonToolTip1 = New CustomTooltip.BalloonToolTip
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Member No"
        Me.ColumnHeader1.Width = 144
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 206
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Date"
        Me.ColumnHeader5.Width = 107
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Shares"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Share Amount"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 97
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Calls in Arrier"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 87
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Receipt No"
        Me.ColumnHeader8.Width = 90
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Status"
        Me.ColumnHeader6.Width = 101
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'GroupBox2
        '
        Me.BalloonToolTip1.SetBalloonText(Me.GroupBox2, Nothing)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblPaidAmount)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblCallsInArrier)
        Me.GroupBox2.Controls.Add(Me.lblShareAmount)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnShareCertificateBook)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.lblMessage)
        Me.GroupBox2.Controls.Add(Me.lvMembers)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnAddMember)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Location = New System.Drawing.Point(216, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(936, 602)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label8, Nothing)
        Me.Label8.Location = New System.Drawing.Point(617, 519)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Total Paid Amount:"
        '
        'lblPaidAmount
        '
        Me.lblPaidAmount.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.lblPaidAmount, Nothing)
        Me.lblPaidAmount.Location = New System.Drawing.Point(755, 519)
        Me.lblPaidAmount.Name = "lblPaidAmount"
        Me.lblPaidAmount.Size = New System.Drawing.Size(107, 16)
        Me.lblPaidAmount.TabIndex = 18
        Me.lblPaidAmount.Text = "Share Amount:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label6, Nothing)
        Me.Label6.Location = New System.Drawing.Point(301, 519)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Total Calls in arrier:"
        '
        'lblCallsInArrier
        '
        Me.lblCallsInArrier.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.lblCallsInArrier, Nothing)
        Me.lblCallsInArrier.Location = New System.Drawing.Point(445, 519)
        Me.lblCallsInArrier.Name = "lblCallsInArrier"
        Me.lblCallsInArrier.Size = New System.Drawing.Size(107, 16)
        Me.lblCallsInArrier.TabIndex = 16
        Me.lblCallsInArrier.Text = "Share Amount:"
        '
        'lblShareAmount
        '
        Me.lblShareAmount.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.lblShareAmount, Nothing)
        Me.lblShareAmount.Location = New System.Drawing.Point(172, 519)
        Me.lblShareAmount.Name = "lblShareAmount"
        Me.lblShareAmount.Size = New System.Drawing.Size(107, 16)
        Me.lblShareAmount.TabIndex = 15
        Me.lblShareAmount.Text = "Share Amount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label3, Nothing)
        Me.Label3.Location = New System.Drawing.Point(21, 519)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Total Share Amount:"
        '
        'btnShareCertificateBook
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnShareCertificateBook, Nothing)
        Me.btnShareCertificateBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShareCertificateBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShareCertificateBook.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShareCertificateBook.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnShareCertificateBook.Image = CType(resources.GetObject("btnShareCertificateBook.Image"), System.Drawing.Image)
        Me.btnShareCertificateBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShareCertificateBook.Location = New System.Drawing.Point(220, 546)
        Me.btnShareCertificateBook.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnShareCertificateBook.Name = "btnShareCertificateBook"
        Me.btnShareCertificateBook.Size = New System.Drawing.Size(163, 40)
        Me.btnShareCertificateBook.TabIndex = 13
        Me.btnShareCertificateBook.Text = "        &Print Certificate"
        '
        'PictureBox1
        '
        Me.BalloonToolTip1.SetBalloonText(Me.PictureBox1, Nothing)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.BalloonToolTip1.SetBalloonText(Me.GroupBox3, Nothing)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cmbType)
        Me.GroupBox3.Controls.Add(Me.txtSearch)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.dtpSearch)
        Me.GroupBox3.Controls.Add(Me.btnSearch)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(197, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(734, 48)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label2, Nothing)
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Search By : "
        '
        'cmbType
        '
        Me.BalloonToolTip1.SetBalloonText(Me.cmbType, Nothing)
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Items.AddRange(New Object() {"Name", "MemberNo", "CustomerID", "Date", "No of Shares", "Share Amount"})
        Me.cmbType.Location = New System.Drawing.Point(96, 16)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(200, 24)
        Me.cmbType.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.AlphaNumeric = True
        Me.BalloonToolTip1.SetBalloonText(Me.txtSearch, Nothing)
        Me.txtSearch.BlankSpace = True
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSearch.Location = New System.Drawing.Point(488, 16)
        Me.txtSearch.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtSearch.Mandatory = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 23)
        Me.txtSearch.SpecialChar = True
        Me.txtSearch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.Label1, Nothing)
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Search Text : "
        '
        'dtpSearch
        '
        Me.BalloonToolTip1.SetBalloonText(Me.dtpSearch, Nothing)
        Me.dtpSearch.CustomFormat = "dd / MMM / yyyy"
        Me.dtpSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSearch.Location = New System.Drawing.Point(488, 16)
        Me.dtpSearch.MaxDate = New Date(2852, 12, 19, 0, 0, 0, 0)
        Me.dtpSearch.MinDate = New Date(1800, 1, 1, 0, 0, 0, 0)
        Me.dtpSearch.Name = "dtpSearch"
        Me.dtpSearch.Size = New System.Drawing.Size(192, 22)
        Me.dtpSearch.TabIndex = 13
        Me.dtpSearch.Value = New Date(2007, 10, 23, 0, 0, 0, 0)
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.btnSearch, Nothing)
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(696, 16)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(32, 24)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        Me.btnSearch.Visible = False
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.BalloonToolTip1.SetBalloonText(Me.lblMessage, Nothing)
        Me.lblMessage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(16, 72)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(287, 16)
        Me.lblMessage.TabIndex = 12
        Me.lblMessage.Text = "There are 0 records found for your search"
        '
        'lvMembers
        '
        Me.lvMembers.AllowColumnReorder = True
        Me.lvMembers.BackColor = System.Drawing.Color.OldLace
        Me.BalloonToolTip1.SetBalloonText(Me.lvMembers, Nothing)
        Me.lvMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvMembers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader9, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader7, Me.ColumnHeader11, Me.ColumnHeader8, Me.ColumnHeader6, Me.ColumnHeader10})
        Me.lvMembers.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMembers.FullRowSelect = True
        Me.lvMembers.GridLines = True
        Me.lvMembers.HideSelection = False
        Me.lvMembers.Location = New System.Drawing.Point(12, 95)
        Me.lvMembers.MultiSelect = False
        Me.lvMembers.Name = "lvMembers"
        Me.lvMembers.Size = New System.Drawing.Size(919, 408)
        Me.lvMembers.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvMembers.TabIndex = 2
        Me.lvMembers.UseCompatibleStateImageBehavior = False
        Me.lvMembers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Customer ID"
        Me.ColumnHeader9.Width = 144
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Paid Amount"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Remarks"
        '
        'btnClose
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnClose, Nothing)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(664, 546)
        Me.btnClose.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        '
        'btnAddMember
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnAddMember, Nothing)
        Me.btnAddMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddMember.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMember.ForeColor = System.Drawing.Color.Black
        Me.btnAddMember.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAddMember.Image = CType(resources.GetObject("btnAddMember.Image"), System.Drawing.Image)
        Me.btnAddMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddMember.Location = New System.Drawing.Point(24, 546)
        Me.btnAddMember.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnAddMember.Name = "btnAddMember"
        Me.btnAddMember.Size = New System.Drawing.Size(168, 40)
        Me.btnAddMember.TabIndex = 3
        Me.btnAddMember.Text = "&Add New Member"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.Label21, Nothing)
        Me.Label21.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(72, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(127, 23)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Members List"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.BalloonToolTip1.SetBalloonText(Me.GroupBox1, Nothing)
        Me.GroupBox1.Controls.Add(Me.btnRemitShares)
        Me.GroupBox1.Controls.Add(Me.btnRefundShares)
        Me.GroupBox1.Controls.Add(Me.btnDepositDetails)
        Me.GroupBox1.Controls.Add(Me.btnSBdetails)
        Me.GroupBox1.Controls.Add(Me.btnShareDetails)
        Me.GroupBox1.Controls.Add(Me.btnLoanDetails)
        Me.GroupBox1.Controls.Add(Me.btnNominees)
        Me.GroupBox1.Controls.Add(Me.btnFamilyDetails)
        Me.GroupBox1.Controls.Add(Me.btnIDCard)
        Me.GroupBox1.Controls.Add(Me.btnMemberDetails)
        Me.GroupBox1.Controls.Add(Me.btnTransactions)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 602)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'btnRemitShares
        '
        Me.btnRemitShares.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.btnRemitShares, Nothing)
        Me.btnRemitShares.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemitShares.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemitShares.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemitShares.ForeColor = System.Drawing.Color.Black
        Me.btnRemitShares.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRemitShares.Image = CType(resources.GetObject("btnRemitShares.Image"), System.Drawing.Image)
        Me.btnRemitShares.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemitShares.Location = New System.Drawing.Point(16, 220)
        Me.btnRemitShares.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnRemitShares.Name = "btnRemitShares"
        Me.btnRemitShares.Size = New System.Drawing.Size(168, 40)
        Me.btnRemitShares.TabIndex = 6
        Me.btnRemitShares.Text = "&Remit Shares"
        Me.btnRemitShares.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemitShares.UseVisualStyleBackColor = False
        '
        'btnRefundShares
        '
        Me.btnRefundShares.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.btnRefundShares, Nothing)
        Me.btnRefundShares.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefundShares.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefundShares.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefundShares.ForeColor = System.Drawing.Color.Black
        Me.btnRefundShares.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRefundShares.Image = CType(resources.GetObject("btnRefundShares.Image"), System.Drawing.Image)
        Me.btnRefundShares.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefundShares.Location = New System.Drawing.Point(16, 260)
        Me.btnRefundShares.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnRefundShares.Name = "btnRefundShares"
        Me.btnRefundShares.Size = New System.Drawing.Size(168, 40)
        Me.btnRefundShares.TabIndex = 7
        Me.btnRefundShares.Text = "Refund &Shares"
        Me.btnRefundShares.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefundShares.UseVisualStyleBackColor = False
        '
        'btnDepositDetails
        '
        Me.btnDepositDetails.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.btnDepositDetails, Nothing)
        Me.btnDepositDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDepositDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDepositDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepositDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDepositDetails.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDepositDetails.Image = CType(resources.GetObject("btnDepositDetails.Image"), System.Drawing.Image)
        Me.btnDepositDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDepositDetails.Location = New System.Drawing.Point(16, 380)
        Me.btnDepositDetails.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnDepositDetails.Name = "btnDepositDetails"
        Me.btnDepositDetails.Size = New System.Drawing.Size(168, 40)
        Me.btnDepositDetails.TabIndex = 10
        Me.btnDepositDetails.Text = "De&posit Details"
        Me.btnDepositDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDepositDetails.UseVisualStyleBackColor = False
        Me.btnDepositDetails.Visible = False
        '
        'btnSBdetails
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnSBdetails, Nothing)
        Me.btnSBdetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSBdetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSBdetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSBdetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSBdetails.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSBdetails.Image = CType(resources.GetObject("btnSBdetails.Image"), System.Drawing.Image)
        Me.btnSBdetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSBdetails.Location = New System.Drawing.Point(16, 340)
        Me.btnSBdetails.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnSBdetails.Name = "btnSBdetails"
        Me.btnSBdetails.Size = New System.Drawing.Size(168, 40)
        Me.btnSBdetails.TabIndex = 9
        Me.btnSBdetails.Text = "S&B Details"
        Me.btnSBdetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSBdetails.Visible = False
        '
        'btnShareDetails
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnShareDetails, Nothing)
        Me.btnShareDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShareDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShareDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShareDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnShareDetails.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnShareDetails.Image = CType(resources.GetObject("btnShareDetails.Image"), System.Drawing.Image)
        Me.btnShareDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShareDetails.Location = New System.Drawing.Point(16, 300)
        Me.btnShareDetails.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnShareDetails.Name = "btnShareDetails"
        Me.btnShareDetails.Size = New System.Drawing.Size(168, 40)
        Me.btnShareDetails.TabIndex = 8
        Me.btnShareDetails.Text = "Share &Details"
        Me.btnShareDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShareDetails.Visible = False
        '
        'btnLoanDetails
        '
        Me.BalloonToolTip1.SetBalloonText(Me.btnLoanDetails, Nothing)
        Me.btnLoanDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoanDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoanDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoanDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLoanDetails.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLoanDetails.Image = CType(resources.GetObject("btnLoanDetails.Image"), System.Drawing.Image)
        Me.btnLoanDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoanDetails.Location = New System.Drawing.Point(16, 420)
        Me.btnLoanDetails.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnLoanDetails.Name = "btnLoanDetails"
        Me.btnLoanDetails.Size = New System.Drawing.Size(168, 40)
        Me.btnLoanDetails.TabIndex = 11
        Me.btnLoanDetails.Text = "&Loan Details"
        Me.btnLoanDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLoanDetails.Visible = False
        '
        'btnNominees
        '
        Me.btnNominees.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BalloonToolTip1.SetBalloonText(Me.btnNominees, "displays the Nominee details for the selected Member")
        Me.btnNominees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNominees.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNominees.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNominees.ForeColor = System.Drawing.Color.Black
        Me.btnNominees.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNominees.Image = CType(resources.GetObject("btnNominees.Image"), System.Drawing.Image)
        Me.btnNominees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNominees.Location = New System.Drawing.Point(16, 100)
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
        Me.BalloonToolTip1.SetBalloonText(Me.btnFamilyDetails, "displays the Family Details for the Selected Member")
        Me.btnFamilyDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFamilyDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFamilyDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFamilyDetails.ForeColor = System.Drawing.Color.Black
        Me.btnFamilyDetails.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnFamilyDetails.Image = CType(resources.GetObject("btnFamilyDetails.Image"), System.Drawing.Image)
        Me.btnFamilyDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFamilyDetails.Location = New System.Drawing.Point(16, 60)
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
        Me.BalloonToolTip1.SetBalloonText(Me.btnIDCard, "displays the ID Card for the selected Member")
        Me.btnIDCard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIDCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIDCard.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIDCard.ForeColor = System.Drawing.Color.Black
        Me.btnIDCard.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnIDCard.Image = CType(resources.GetObject("btnIDCard.Image"), System.Drawing.Image)
        Me.btnIDCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIDCard.Location = New System.Drawing.Point(16, 140)
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
        Me.BalloonToolTip1.SetBalloonText(Me.btnMemberDetails, "displays the Member details for the selected Member")
        Me.btnMemberDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMemberDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMemberDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemberDetails.ForeColor = System.Drawing.Color.Black
        Me.btnMemberDetails.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMemberDetails.Image = CType(resources.GetObject("btnMemberDetails.Image"), System.Drawing.Image)
        Me.btnMemberDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMemberDetails.Location = New System.Drawing.Point(16, 20)
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
        Me.BalloonToolTip1.SetBalloonText(Me.btnTransactions, "displays the Transaction details for the selected Member")
        Me.btnTransactions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransactions.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransactions.ForeColor = System.Drawing.Color.Black
        Me.btnTransactions.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnTransactions.Image = CType(resources.GetObject("btnTransactions.Image"), System.Drawing.Image)
        Me.btnTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransactions.Location = New System.Drawing.Point(16, 180)
        Me.btnTransactions.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnTransactions.Name = "btnTransactions"
        Me.btnTransactions.Size = New System.Drawing.Size(168, 40)
        Me.btnTransactions.TabIndex = 5
        Me.btnTransactions.Text = "&Transactions"
        Me.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTransactions.UseVisualStyleBackColor = False
        '
        'BalloonToolTip1
        '
        Me.BalloonToolTip1.BackColor = System.Drawing.SystemColors.Info
        Me.BalloonToolTip1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BalloonToolTip1.Title = ""
        '
        'frmMembersList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1156, 628)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmMembersList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Members List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmMembersList
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmMembersList
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmMembersList
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmMembersList)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Functions"
    'to load members from database

    Function fnLoadMembers()
        Dim intCounter As Integer = 0
        Dim lvItem As New ListViewItem
        Dim TotalShareAmount As Decimal = 0
        Dim TotalCallsInArrier As Decimal = 0
        Dim TotalPaidAmount As Decimal = 0
        If Not dvMembers Is Nothing Then
            dvMembers.RowFilter = strFilter
            lvMembers.Items.Clear()
            lblMessage.Text = "There are " & dvMembers.Count & " records found for your search"
            While intCounter < dvMembers.Count
                lvItem = lvMembers.Items.Add(dvMembers.Item(intCounter).Item("MemberNo"))
                lvItem.UseItemStyleForSubItems = False
                lvItem.SubItems.Add(dvMembers.Item(intCounter).Item("CustomerID"))
                lvItem.SubItems.Add(dvMembers.Item(intCounter).Item("Name"))
                lvItem.SubItems.Add(Format(dvMembers.Item(intCounter).Item("OpenDate"), "dd-MMM-yyyy"))
                lvItem.SubItems.Add(dvMembers.Item(intCounter).Item("NoofShares"))
                lvItem.SubItems.Add(Format(dvMembers.Item(intCounter).Item("ShareAmount"), "0,00.00")) ''share mount
                lvItem.SubItems.Add(Format(dvMembers.Item(intCounter).Item("CallsInArrier"), "0,00.00")) ''Call arrier
                'lvItem.SubItems.Add(Format(Convert.ToDecimal(dvMembers.Item(intCounter).Item("ShareAmount")) - Convert.ToDecimal(dvMembers.Item(intCounter).Item("CallsInArrier")), "0,00.00")) ''new calls in arrier
                lvItem.SubItems.Add(Format(Convert.ToDecimal(dvMembers.Item(intCounter).Item("ShareAmount")) - Convert.ToDecimal(dvMembers.Item(intCounter).Item("CallsInArrier")), "0,00.00")) ''Paid amount
                'lvItem.SubItems.Add(Format(Convert.ToDecimal(dvMembers.Item(intCounter).Item("ShareAmount")), "0,00.00")) 
                lvItem.SubItems.Add(dvMembers.Item(intCounter).Item("ReceiptNo"))
                lvItem.SubItems.Add(dvMembers.Item(intCounter).Item("Status"))
                lvItem.UseItemStyleForSubItems = False
                lvItem.SubItems.Add(dvMembers.Item(intCounter).Item("Remarks"))
                TotalShareAmount += Convert.ToDecimal(dvMembers.Item(intCounter).Item("ShareAmount"))
                TotalCallsInArrier += Convert.ToDecimal(dvMembers.Item(intCounter).Item("CallsInArrier"))
                intCounter += 1

            End While
            lblShareAmount.Text = Convert.ToString(TotalShareAmount)
            lblCallsInArrier.Text = Convert.ToString(TotalCallsInArrier)
            lblPaidAmount.Text = Convert.ToString(TotalShareAmount - TotalCallsInArrier)
            'lblPaidAmount.Text = Convert.ToString(TotalShareAmount)
        End If
    End Function

#End Region

#Region "Variables"

    Public intCount As Integer

#End Region

#Region " Events"

    Private Sub frmMembersList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.Activated
        cmbType.SelectedIndex = 0

        If objMember.fnGetMembersTable Then
            dvMembers = New DataView(objMember.MemberTable, strFilter, "Name", DataViewRowState.OriginalRows)
            fnLoadMembers()
        End If

        dtpSearch.Visible = False
        btnSearch.Visible = False
        txtSearch.Visible = True

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If cmbType.SelectedItem = "Name" Then
            strFilter = "Name like '" & txtSearch.Text & "%'"
            fnLoadMembers()
        ElseIf cmbType.SelectedItem = "MemberNo" Then
            strFilter = "MemberNo like '" & txtSearch.Text & "%'"
            fnLoadMembers()
        ElseIf cmbType.SelectedItem = "CustomerID" Then
            strFilter = "CustomerID like '" & txtSearch.Text & "%'"
            fnLoadMembers()
        ElseIf cmbType.SelectedItem = "No of Shares" Then
            strFilter = "NoofShares = '" & Val(txtSearch.Text) & "'"
            fnLoadMembers()
        ElseIf cmbType.SelectedItem = "Share Amount" Then
            strFilter = "ShareAmount = '" & Val(txtSearch.Text) & "'"
            fnLoadMembers()
        ElseIf cmbType.SelectedItem = "ReceiptNo" Then
            strFilter = "ReceiptNo like '" & txtSearch.Text & "%'"
            fnLoadMembers()
        ElseIf cmbType.SelectedItem = "Remarks" Then
            strFilter = "Remarks like '" & txtSearch.Text & "%'"
            fnLoadMembers()
        End If
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyData = Keys.Down Then
            lvMembers.Focus()
        End If
    End Sub

    Private Sub btnFamilyDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFamilyDetails.Click
        If lvMembers.SelectedItems.Count > 0 Then
            Dim objFamilyDetails As New frmFamily_Detail
            objFamilyDetails.txtAccountNo.Text = lvMembers.SelectedItems(0).SubItems(0).Text
            objFamilyDetails.chrType = "F"
            objFamilyDetails.ShowDialog(Me)
            objFamilyDetails.Dispose()
        Else
            MsgBox("Select member", MsgBoxStyle.Information, "Members")
            lvMembers.Focus()
        End If
    End Sub

    Private Sub btnNominees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNominees.Click
        If lvMembers.SelectedItems.Count > 0 Then
            Dim objNominees As New frmNominees
            objNominees.txtAccountNo.Text = lvMembers.SelectedItems(0).SubItems(0).Text
            objNominees.txtName.Text = lvMembers.SelectedItems(0).SubItems(1).Text
            objNominees.chrType = "N"
            objNominees.ShowDialog(Me)
            objNominees.Dispose()
        Else
            MsgBox("Select member", MsgBoxStyle.Information, "Members")
            lvMembers.Focus()
        End If
    End Sub

    Private Sub btnIDCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIDCard.Click
        If lvMembers.SelectedItems.Count > 0 Then
            Dim objReportViewer As New frmReportViewer
            objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/MemberIDCardKan.rpt"
            objReportViewer.CrystalReportViewer1.SelectionFormula = "{MemberTbl.MemberNo}= '" & lvMembers.SelectedItems(0).SubItems(0).Text & "'"
            objReportViewer.ShowDialog()
            objReportViewer.Dispose()
        Else
            MsgBox("Select member", MsgBoxStyle.Information, "Members")
            lvMembers.Focus()
        End If
    End Sub

    Private Sub btnAddMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMember.Click
        Dim objfrmMemberCreation As frmMemberCreation
        objfrmMemberCreation = frmMemberCreation.DefInstance
        objfrmMemberCreation.MdiParent = Me.MdiParent
        objfrmMemberCreation.BringToFront()
        objfrmMemberCreation.Show()
        objfrmMemberCreation = Nothing
    End Sub

    Private Sub btnMemberDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMemberDetails.Click
        If lvMembers.SelectedItems.Count > 0 Then
            Dim objfrmMemberCreation As frmMemberCreation
            objfrmMemberCreation = frmMemberCreation.DefInstance
            objfrmMemberCreation.BringToFront()
            objfrmMemberCreation.MdiParent = Me.MdiParent
            objfrmMemberCreation.txtMemberNo.Text = lvMembers.SelectedItems(0).SubItems(0).Text
            objfrmMemberCreation.Show()
            objfrmMemberCreation = Nothing
        Else
            MsgBox("Select member", MsgBoxStyle.Information, "Members")
            lvMembers.Focus()
        End If
    End Sub

    Private Sub lvMembers_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvMembers.KeyDown
        If e.KeyData = Keys.Enter Then
            btnMemberDetails_Click(sender, e)
        End If
    End Sub

    Private Sub btnTransactions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransactions.Click
        If lvMembers.SelectedItems.Count > 0 Then
            Dim objfrmAccTrans As New frmAccountTransactions
            objfrmAccTrans.txtAccountNo.Text = lvMembers.SelectedItems(0).SubItems(0).Text
            objfrmAccTrans.txtName.Text = lvMembers.SelectedItems(0).SubItems(1).Text
            objfrmAccTrans.ShowDialog(Me)
            objfrmAccTrans = Nothing
        Else
            MsgBox("Select member", MsgBoxStyle.Information, Me.Text)
            lvMembers.Focus()
        End If
    End Sub

    Private Sub btnShareDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShareDetails.Click
        If lvMembers.SelectedItems.Count > 0 Then
            Dim objfrmShareTransaction As frmSharesTransaction
            objfrmShareTransaction = frmSharesTransaction.DefInstance
            objfrmShareTransaction.BringToFront()
            objfrmShareTransaction.MdiParent = Me.MdiParent
            objfrmShareTransaction.txtMemberNo.Text = lvMembers.SelectedItems(0).SubItems(0).Text
            objfrmShareTransaction.Show()
            objfrmShareTransaction = Nothing
        Else
            MsgBox("Select member", MsgBoxStyle.Information, Me.Text)
            lvMembers.Focus()
        End If
    End Sub

    Private Sub btnRemitShares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemitShares.Click

        If lvMembers.SelectedItems.Count > 0 Then
            If lvMembers.SelectedItems(intCount).SubItems(6).Text = "Active" Then
                Dim objfrmRemitShares As New frmRemitShares
                objfrmRemitShares.txtMemberNo.Text = lvMembers.SelectedItems(0).SubItems(0).Text
                objfrmRemitShares.ShowDialog(Me)
                objfrmRemitShares = Nothing
                If objMember.fnGetMembersTable Then
                    dvMembers = New DataView(objMember.MemberTable, strFilter, "Name", DataViewRowState.OriginalRows)
                    fnLoadMembers()
                End If
            Else
                MsgBox("Cannot remit amount, account closed", MsgBoxStyle.Information, " Member Module")
            End If
        Else
            MsgBox("Select member", MsgBoxStyle.Information, Me.Text)
            lvMembers.Focus()
        End If

    End Sub

    Private Sub btnRefundShares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefundShares.Click
        If lvMembers.SelectedItems.Count > 0 Then
            If lvMembers.SelectedItems(intCount).SubItems(6).Text = "Active" Then
                Dim objfrmRefundShares As New frmRefundShares
                objfrmRefundShares.txtMemberNo.Text = lvMembers.SelectedItems(0).SubItems(0).Text
                objfrmRefundShares.ShowDialog(Me)
                objfrmRefundShares = Nothing
                If objMember.fnGetMembersTable Then
                    dvMembers = New DataView(objMember.MemberTable, strFilter, "Name", DataViewRowState.OriginalRows)
                    fnLoadMembers()
                End If
            Else
                MsgBox("Cannot refund amount,account closed", MsgBoxStyle.Information, "Member Module")
            End If
        Else
            MsgBox("Please select the tember from the list", MsgBoxStyle.Information, Me.Text)
            lvMembers.Focus()
        End If
    End Sub

    Private Sub cmbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If cmbType.SelectedItem = "Date" Then
            dtpSearch.Visible = True
            btnSearch.Visible = True
            txtSearch.Visible = False
        Else
            btnSearch.Visible = False
            dtpSearch.Visible = False
            txtSearch.Visible = True

        End If

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        If cmbType.SelectedItem = "Date" Then
            strFilter = "OpenDate = '" & dtpSearch.Value & "'"
            fnLoadMembers()
        End If

    End Sub

    Private Sub lvMembers_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvMembers.DoubleClick
        If lvMembers.SelectedItems.Count > 0 Then
            Dim objfrmMemberCreation As frmMemberCreation
            objfrmMemberCreation = frmMemberCreation.DefInstance
            objfrmMemberCreation.BringToFront()
            objfrmMemberCreation.MdiParent = Me.MdiParent
            objfrmMemberCreation.txtMemberNo.Text = lvMembers.SelectedItems(0).SubItems(0).Text
            'objfrmMemberCreation.MdiParent = Me.MdiParent
            'objfrmMemberCreation.BringToFront()
            objfrmMemberCreation.Show()
            objfrmMemberCreation = Nothing
        Else
            MsgBox("Select member", MsgBoxStyle.Information, "Members")
            lvMembers.Focus()
        End If
    End Sub

#End Region

    Private Sub btnShareCertificateBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShareCertificateBook.Click
        If lvMembers.SelectedItems.Count > 0 Then
            Dim objfrmAccTrans As New frmAccountTransactions
            Dim AccountNo As String = lvMembers.SelectedItems(0).SubItems(0).Text
            Dim objReportViewer As New frmReportViewer()
            Dim cryRpt As New ReportDocument()
            Dim doctoprint As New PrintDocument()
            ' cryRpt.Load("E:/BAS_Software/9jun2012_Vasavi Co-operative_fd_int_trans_form/BAS/Reports/ShareCertificate.rpt")
            cryRpt.Load("C:\Program Files\Coherent\BAS\Reports\ShareCertificate.rpt")
            Dim ActNo As New ParameterDiscreteValue()
            ActNo.Value = AccountNo
            cryRpt.SetParameterValue("MemberNo", ActNo.Value)
            objReportViewer.CrystalReportViewer1.ReportSource = cryRpt
            objReportViewer.Show()
            'cryRpt.PrintToPrinter(1, False, 0, 0)
            ''-----functionality for Parameter passing---myDiscrete
            'doctoprint.PrinterSettings.PrinterName = "EPSON PLQ-20 ESC/P2"
            'Dim r As Integer = 0
            'While (r < doctoprint.PrinterSettings.PaperSizes.Count)

            '    Dim rawKind As Integer
            '    Dim st As String = doctoprint.PrinterSettings.PaperSizes.Item(r).PaperName
            '    If Convert.ToString(doctoprint.PrinterSettings.PaperSizes.Item(r).PaperName) = "Sharecertificate" Then

            '        rawKind = Convert.ToInt32(doctoprint.PrinterSettings.PaperSizes.Item(r).GetType().GetField("kind", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance).GetValue(doctoprint.PrinterSettings.PaperSizes.Item(r)))
            '        cryRpt.PrintOptions.PaperSize = DirectCast(rawKind, CrystalDecisions.Shared.PaperSize)




            '        '// cryRpt.PrintOptions.PaperSize  = CrystalDecisions.Shared.PaperSize.passbook2;
            '        '//cryRpt.PrintOptions.PrinterName = "Samsung ML-1610 Series";
            '        '// cryRpt.PrintToPrinter(1, False, 0, 0)
            '        ' objReportViewer.Show()
            '        'objReportViewer.CrystalReportViewer1.ReportSource = cryRpt

            '    End If
            '    r += 1
            'End While
        Else
            MsgBox("Select member", MsgBoxStyle.Information, Me.Text)
            lvMembers.Focus()
        End If




    End Sub
End Class
