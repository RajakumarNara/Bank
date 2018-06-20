
Imports System.Linq
Public Class frmLedgerDetails

    Inherits System.Windows.Forms.Form



#Region "Global Variables"
    Dim objLedger As New clsLedger
    Public LedgerNo As Integer = 0

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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbLedger As System.Windows.Forms.ComboBox
    Friend WithEvents lvLedgerVouchers As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCreditTotal As BankControls.TextControl
    Friend WithEvents txtDebitTotal As BankControls.TextControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDebitCB As BankControls.TextControl
    Friend WithEvents txtCreditCB As BankControls.TextControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCreditOB As BankControls.TextControl
    Friend WithEvents txtDebitOB As BankControls.TextControl
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnShow As BankControls.NewButton
    Friend WithEvents chkOption As System.Windows.Forms.CheckBox
    Friend WithEvents btnPrint As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLedgerDetails))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnPrint = New BankControls.NewButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtCreditTotal = New BankControls.TextControl()
        Me.txtDebitTotal = New BankControls.TextControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDebitCB = New BankControls.TextControl()
        Me.txtCreditCB = New BankControls.TextControl()
        Me.txtCreditOB = New BankControls.TextControl()
        Me.txtDebitOB = New BankControls.TextControl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClose = New BankControls.NewButton()
        Me.lvLedgerVouchers = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkOption = New System.Windows.Forms.CheckBox()
        Me.btnShow = New BankControls.NewButton()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbLedger = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 616)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnPrint)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.lvLedgerVouchers)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(216, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(910, 631)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(43, 585)
        Me.btnPrint.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(104, 40)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "&Print"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtCreditTotal)
        Me.GroupBox4.Controls.Add(Me.txtDebitTotal)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtDebitCB)
        Me.GroupBox4.Controls.Add(Me.txtCreditCB)
        Me.GroupBox4.Controls.Add(Me.txtCreditOB)
        Me.GroupBox4.Controls.Add(Me.txtDebitOB)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(40, 491)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(744, 88)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        '
        'txtCreditTotal
        '
        Me.txtCreditTotal.AlphaNumeric = True
        Me.txtCreditTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtCreditTotal.BlankSpace = False
        Me.txtCreditTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCreditTotal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditTotal.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtCreditTotal.Location = New System.Drawing.Point(488, 40)
        Me.txtCreditTotal.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtCreditTotal.Mandatory = False
        Me.txtCreditTotal.MaxLength = 10
        Me.txtCreditTotal.Name = "txtCreditTotal"
        Me.txtCreditTotal.ReadOnly = True
        Me.txtCreditTotal.Size = New System.Drawing.Size(112, 16)
        Me.txtCreditTotal.SpecialChar = True
        Me.txtCreditTotal.TabIndex = 15
        Me.txtCreditTotal.TabStop = False
        Me.txtCreditTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDebitTotal
        '
        Me.txtDebitTotal.AlphaNumeric = True
        Me.txtDebitTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtDebitTotal.BlankSpace = False
        Me.txtDebitTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDebitTotal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebitTotal.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtDebitTotal.Location = New System.Drawing.Point(616, 40)
        Me.txtDebitTotal.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtDebitTotal.Mandatory = False
        Me.txtDebitTotal.MaxLength = 10
        Me.txtDebitTotal.Name = "txtDebitTotal"
        Me.txtDebitTotal.ReadOnly = True
        Me.txtDebitTotal.Size = New System.Drawing.Size(112, 16)
        Me.txtDebitTotal.SpecialChar = True
        Me.txtDebitTotal.TabIndex = 14
        Me.txtDebitTotal.TabStop = False
        Me.txtDebitTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(416, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Total :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(336, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Closing Balance :"
        '
        'txtDebitCB
        '
        Me.txtDebitCB.AlphaNumeric = True
        Me.txtDebitCB.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtDebitCB.BlankSpace = False
        Me.txtDebitCB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDebitCB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebitCB.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtDebitCB.Location = New System.Drawing.Point(616, 64)
        Me.txtDebitCB.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtDebitCB.Mandatory = False
        Me.txtDebitCB.MaxLength = 10
        Me.txtDebitCB.Name = "txtDebitCB"
        Me.txtDebitCB.ReadOnly = True
        Me.txtDebitCB.Size = New System.Drawing.Size(112, 16)
        Me.txtDebitCB.SpecialChar = True
        Me.txtDebitCB.TabIndex = 14
        Me.txtDebitCB.TabStop = False
        Me.txtDebitCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCreditCB
        '
        Me.txtCreditCB.AlphaNumeric = True
        Me.txtCreditCB.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtCreditCB.BlankSpace = False
        Me.txtCreditCB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCreditCB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditCB.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtCreditCB.Location = New System.Drawing.Point(488, 64)
        Me.txtCreditCB.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtCreditCB.Mandatory = False
        Me.txtCreditCB.MaxLength = 10
        Me.txtCreditCB.Name = "txtCreditCB"
        Me.txtCreditCB.ReadOnly = True
        Me.txtCreditCB.Size = New System.Drawing.Size(112, 16)
        Me.txtCreditCB.SpecialChar = True
        Me.txtCreditCB.TabIndex = 15
        Me.txtCreditCB.TabStop = False
        Me.txtCreditCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCreditOB
        '
        Me.txtCreditOB.AlphaNumeric = True
        Me.txtCreditOB.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtCreditOB.BlankSpace = False
        Me.txtCreditOB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCreditOB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditOB.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtCreditOB.Location = New System.Drawing.Point(488, 16)
        Me.txtCreditOB.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtCreditOB.Mandatory = False
        Me.txtCreditOB.MaxLength = 10
        Me.txtCreditOB.Name = "txtCreditOB"
        Me.txtCreditOB.ReadOnly = True
        Me.txtCreditOB.Size = New System.Drawing.Size(112, 16)
        Me.txtCreditOB.SpecialChar = True
        Me.txtCreditOB.TabIndex = 15
        Me.txtCreditOB.TabStop = False
        Me.txtCreditOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDebitOB
        '
        Me.txtDebitOB.AlphaNumeric = True
        Me.txtDebitOB.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtDebitOB.BlankSpace = False
        Me.txtDebitOB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDebitOB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebitOB.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtDebitOB.Location = New System.Drawing.Point(616, 16)
        Me.txtDebitOB.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtDebitOB.Mandatory = False
        Me.txtDebitOB.MaxLength = 10
        Me.txtDebitOB.Name = "txtDebitOB"
        Me.txtDebitOB.ReadOnly = True
        Me.txtDebitOB.Size = New System.Drawing.Size(112, 16)
        Me.txtDebitOB.SpecialChar = True
        Me.txtDebitOB.TabIndex = 14
        Me.txtDebitOB.TabStop = False
        Me.txtDebitOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(328, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Opening Balance :"
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
        Me.btnClose.Location = New System.Drawing.Point(656, 585)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        '
        'lvLedgerVouchers
        '
        Me.lvLedgerVouchers.AllowColumnReorder = True
        Me.lvLedgerVouchers.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lvLedgerVouchers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvLedgerVouchers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader8, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader9})
        Me.lvLedgerVouchers.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLedgerVouchers.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvLedgerVouchers.FullRowSelect = True
        Me.lvLedgerVouchers.GridLines = True
        Me.lvLedgerVouchers.HideSelection = False
        Me.lvLedgerVouchers.Location = New System.Drawing.Point(22, 165)
        Me.lvLedgerVouchers.MultiSelect = False
        Me.lvLedgerVouchers.Name = "lvLedgerVouchers"
        Me.lvLedgerVouchers.Size = New System.Drawing.Size(888, 312)
        Me.lvLedgerVouchers.TabIndex = 6
        Me.lvLedgerVouchers.UseCompatibleStateImageBehavior = False
        Me.lvLedgerVouchers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sl No."
        Me.ColumnHeader1.Width = 50
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "VoucherNo."
        Me.ColumnHeader8.Width = 102
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date"
        Me.ColumnHeader2.Width = 94
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Reference No."
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Account No."
        Me.ColumnHeader4.Width = 0
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Narration"
        Me.ColumnHeader5.Width = 270
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Credit"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Debit"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 104
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Balance"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 97
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Green
        Me.Label21.Location = New System.Drawing.Point(72, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(132, 23)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Ledger Details"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkOption)
        Me.GroupBox3.Controls.Add(Me.btnShow)
        Me.GroupBox3.Controls.Add(Me.dtpEndDate)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.dtpStartDate)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cmbLedger)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(744, 80)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'chkOption
        '
        Me.chkOption.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkOption.Location = New System.Drawing.Point(24, 48)
        Me.chkOption.Name = "chkOption"
        Me.chkOption.Size = New System.Drawing.Size(144, 24)
        Me.chkOption.TabIndex = 2
        Me.chkOption.Text = "Search By Date"
        '
        'btnShow
        '
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShow.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnShow.Image = CType(resources.GetObject("btnShow.Image"), System.Drawing.Image)
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow.Location = New System.Drawing.Point(616, 40)
        Me.btnShow.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(104, 24)
        Me.btnShow.TabIndex = 5
        Me.btnShow.Text = "&Show"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpEndDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(464, 48)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpEndDate.TabIndex = 4
        Me.dtpEndDate.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(368, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "End Date :"
        Me.Label6.Visible = False
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpStartDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(464, 16)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpStartDate.TabIndex = 3
        Me.dtpStartDate.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(368, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Start Date :"
        Me.Label5.Visible = False
        '
        'cmbLedger
        '
        Me.cmbLedger.BackColor = System.Drawing.Color.White
        Me.cmbLedger.DropDownWidth = 300
        Me.cmbLedger.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLedger.Location = New System.Drawing.Point(136, 16)
        Me.cmbLedger.MaxDropDownItems = 12
        Me.cmbLedger.Name = "cmbLedger"
        Me.cmbLedger.Size = New System.Drawing.Size(216, 24)
        Me.cmbLedger.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Select Ledger :"
        '
        'frmLedgerDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1157, 643)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmLedgerDetails"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ledger Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmLedgerDetails
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmLedgerDetails
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmLedgerDetails
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmLedgerDetails)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region " Functions "

    Sub sbClear()
        lvLedgerVouchers.Items.Clear()
        txtCreditTotal.ResetText()
        txtCreditCB.ResetText()
        txtDebitTotal.ResetText()
        txtDebitCB.ResetText()
    End Sub

    Public Function fnLoadDetails()
        Dim intCounter As Integer = 0
        Dim objDT As DataTable
        Dim lvItem As ListViewItem
        Dim dblTotalCredit As Double = 0
        Dim dblTotalDebit As Double = 0

        sbClear()
        objDT = objLedger.LedgerTable
        While intCounter < objDT.Rows.Count
            

            lvItem = lvLedgerVouchers.Items.Add(intCounter + 1)
            lvItem.SubItems.Add(objDT.Rows(intCounter).Item("VoucherNo"))
            lvItem.SubItems.Add(Format(objDT.Rows(intCounter).Item("VDate"), "dd-MMM-yyyy"))
            lvItem.SubItems.Add(objDT.Rows(intCounter).Item("RefNo"))
            If Convert.ToString(objDT.Rows(intCounter).Item("AccountNo")) = "" Then
                lvItem.SubItems.Add("")
            Else
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("AccountNo"))
            End If
            lvItem.SubItems.Add(objDT.Rows(intCounter).Item("Narration"))
            lvItem.SubItems.Add(IIf(objDT.Rows(intCounter).Item("Credit") = 0, "", objDT.Rows(intCounter).Item("Credit")))
            dblTotalCredit += objDT.Rows(intCounter).Item("Credit")

            lvItem.SubItems.Add(IIf(objDT.Rows(intCounter).Item("Debit") = 0, "", objDT.Rows(intCounter).Item("Debit")))
            dblTotalDebit += objDT.Rows(intCounter).Item("Debit")

            'added for balance on 
            'if legertype== then 
            lvItem.SubItems.Add(dblTotalCredit - dblTotalDebit)

            'else 
            'lvItem.SubItems.Add(dblTotalDebit - dblTotalCredit)



            '  lvItem.SubItems.Add(objDT.Rows(intCounter).Item("Balance"))



            intCounter += 1
        End While
        lvItem = lvLedgerVouchers.Items.Add("")

        txtCreditTotal.Text = IIf(dblTotalCredit <> 0, Format(dblTotalCredit, "0,0.00"), "")
        txtDebitTotal.Text = IIf(dblTotalDebit <> 0, Format(dblTotalDebit, "0,0.00"), "")

        If dblTotalCredit - dblTotalDebit > 0 Then
            txtCreditCB.Text = Format(dblTotalCredit - dblTotalDebit, "0,0.00")
        Else
            txtDebitCB.Text = Format(dblTotalDebit - dblTotalCredit, "0,0.00")
        End If
    End Function

#End Region

#Region "Events "

    Private Sub frmLedgerDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If objLedger.fnGetLedgerList Then
            cmbLedger.DataSource = objLedger.LedgerTable
            cmbLedger.DisplayMember = "Name"
            cmbLedger.ValueMember = "LedgerNo"
        End If
        If LedgerNo <> 0 Then
            cmbLedger.SelectedValue = LedgerNo
            btnShow_Click(sender, e)
        End If
        dtpStartDate.MaxDate = Date.Now.Date
        dtpEndDate.MaxDate = Date.Now.Date
        dtpStartDate.Value = Date.Now.Date
        dtpEndDate.Value = Date.Now.Date
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        sbClear()
        If cmbLedger.SelectedIndex <> -1 Then
            If chkOption.Checked = True Then
                If objLedger.fnGetTransactions(cmbLedger.SelectedValue, dtpStartDate.Value, dtpEndDate.Value) Then
                    fnLoadDetails()
                End If
            Else
                If objLedger.fnGetTransactions(cmbLedger.SelectedValue) Then
                    fnLoadDetails()
                End If
            End If
        Else
            MsgBox("Select ledger ", MsgBoxStyle.Information, Me.Text)
            cmbLedger.Focus()

        End If

        If txtCreditTotal.Text = "" And txtDebitTotal.Text = "" Then
            btnPrint.Enabled = False
        Else
            btnPrint.Enabled = True
        End If

    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lvLedgerVouchers_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLedgerVouchers.DoubleClick
        If lvLedgerVouchers.SelectedItems.Count > 0 Then
            If lvLedgerVouchers.SelectedItems(0).SubItems(0).Text <> "" Then
                Dim objfrmVoucherDetails As New frmVoucherDetails
                objfrmVoucherDetails.VoucherNo = lvLedgerVouchers.SelectedItems(0).SubItems(1).Text
                objfrmVoucherDetails.VoucherDate = lvLedgerVouchers.SelectedItems(0).SubItems(2).Text
                objfrmVoucherDetails.ReferenceNo = lvLedgerVouchers.SelectedItems(0).SubItems(3).Text
                objfrmVoucherDetails.ShowDialog(Me)
                objfrmVoucherDetails = Nothing
            End If
        End If
    End Sub

    Private Sub lvLedgerVouchers_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvLedgerVouchers.KeyDown
        If e.KeyData = Keys.Enter Then
            lvLedgerVouchers_DoubleClick(sender, e)
        End If
    End Sub

    Private Sub cmbLedger_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbLedger.SelectedIndexChanged
        sbClear()
        btnPrint.Enabled = False
    End Sub

    Private Sub cmbLedger_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbLedger.KeyDown
        If e.KeyData = Keys.Enter Then
            btnShow_Click(sender, e)
        End If
    End Sub

    Private Sub chkOption_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkOption.CheckedChanged
        If chkOption.Checked = True Then
            Label5.Visible = True
            Label6.Visible = True
            dtpEndDate.Visible = True
            dtpStartDate.Visible = True
        Else
            Label5.Visible = False
            Label6.Visible = False
            dtpEndDate.Visible = False
            dtpStartDate.Visible = False
        End If
    End Sub
#End Region

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Dim objReportViewer As New frmReportViewer
        Dim Vdate As Date
        Dim ledgerDetails As String

        If fnDeleteDate() Then
            FromDate = dtpStartDate.Value
            ToDate = dtpEndDate.Value
            fnInsertDate()
        End If

        If cmbLedger.SelectedIndex <> -1 Then
            If chkOption.Checked = True Then
                If objLedger.fnGetTransactions(cmbLedger.SelectedValue, dtpStartDate.Value, dtpEndDate.Value) Then
                    ledgerDetails = "{fasvouchersubtbl.VDate} in CDate(""" + dtpStartDate.Value + """) to CDate(""" + dtpEndDate.Value + """) and {fasvouchersubtbl.LedgerNo}= " & cmbLedger.SelectedValue & " "
                End If
            Else
                If objLedger.fnGetTransactions(cmbLedger.SelectedValue) Then
                    ledgerDetails = "{fasvouchersubtbl.LedgerNo}= " & cmbLedger.SelectedValue & " "
                End If
            End If
        Else
            MsgBox("Select Ledger ", MsgBoxStyle.Information, Me.Text)
            cmbLedger.Focus()

        End If
        objReportViewer.CrystalReportViewer1.SelectionFormula = ledgerDetails
        'objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/Reports/ledgerdetails.rpt" 'Cashroll.rpt" 'receipt.rpt" 'ReciptAndPayment.rpt"
        objReportViewer.CrystalReportViewer1.ReportSource = "C:/Program Files/Coherent/BAS/Reports/ledgerdetails.rpt"
        objReportViewer.ShowDialog()
        objReportViewer = Nothing
    End Sub

    Private Sub cmbLedger_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbLedger.KeyPress
        cmbLedger.DroppedDown = True

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub


End Class
