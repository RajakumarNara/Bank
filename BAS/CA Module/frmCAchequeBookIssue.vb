Imports System.Math
Public Class frmCAchequeBookIssue
    Inherits System.Windows.Forms.Form

#Region "Form global variables"
    Dim objCAAccount As New clsCurrentAccount
    Public strCAno As String
    Dim objDTMaster As New DataTable
    Dim dblAvailBal As Double

    Dim dblAvalAmount As Double
    Dim dblCalIntrest As Double
    Dim dblOverDrawLimit As Double
    Dim datLastPaid As Date
    Dim dblAmountPerCheque As Double
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
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents lvChqBook As System.Windows.Forms.ListView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents txtAccNo As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBookName As BankControls.TextControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtStartNo As BankControls.NumericControl
    Friend WithEvents txtNoOfleafs As BankControls.NumericControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpIssueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMiscCharges As BankControls.TextControl
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCAchequeBookIssue))
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.btnOk = New BankControls.NewButton
        Me.lvChqBook = New System.Windows.Forms.ListView
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMiscCharges = New BankControls.TextControl
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpIssueDate = New System.Windows.Forms.DateTimePicker
        Me.btnSearch = New BankControls.NewButton
        Me.txtAccNo = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtBookName = New BankControls.TextControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtStartNo = New BankControls.NumericControl
        Me.txtNoOfleafs = New BankControls.NumericControl
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnCancel = New BankControls.NewButton
        Me.txtReceiptNo = New BankControls.NumericControl
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Ending Leaf No"
        Me.ColumnHeader4.Width = 62
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Starting Leaf No"
        Me.ColumnHeader3.Width = 107
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Status"
        Me.ColumnHeader5.Width = 50
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Issue Date"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Book No"
        Me.ColumnHeader2.Width = 89
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sl No"
        Me.ColumnHeader1.Width = 48
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(400, 160)
        Me.btnOk.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(80, 32)
        Me.btnOk.TabIndex = 8
        Me.btnOk.Text = "&OK"
        '
        'lvChqBook
        '
        Me.lvChqBook.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader6, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7})
        Me.lvChqBook.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvChqBook.FullRowSelect = True
        Me.lvChqBook.GridLines = True
        Me.lvChqBook.Location = New System.Drawing.Point(8, 200)
        Me.lvChqBook.Name = "lvChqBook"
        Me.lvChqBook.Size = New System.Drawing.Size(568, 232)
        Me.lvChqBook.TabIndex = 10
        Me.lvChqBook.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Reference Number"
        Me.ColumnHeader7.Width = 70
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtMiscCharges)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.dtpIssueDate)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtAccNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtBookName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtStartNo)
        Me.Panel1.Controls.Add(Me.txtNoOfleafs)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(8, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 146)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 19)
        Me.Label6.TabIndex = 128
        Me.Label6.Text = "Misc Receipts"
        '
        'txtMiscCharges
        '
        Me.txtMiscCharges.AlphaNumeric = True
        Me.txtMiscCharges.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.txtMiscCharges.BlankSpace = False
        Me.txtMiscCharges.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiscCharges.GotFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.txtMiscCharges.Location = New System.Drawing.Point(168, 112)
        Me.txtMiscCharges.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMiscCharges.Mandatory = False
        Me.txtMiscCharges.Name = "txtMiscCharges"
        Me.txtMiscCharges.ReadOnly = True
        Me.txtMiscCharges.Size = New System.Drawing.Size(128, 23)
        Me.txtMiscCharges.SpecialChar = False
        Me.txtMiscCharges.TabIndex = 127
        Me.txtMiscCharges.TabStop = False
        Me.txtMiscCharges.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(336, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 19)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Date"
        '
        'dtpIssueDate
        '
        Me.dtpIssueDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpIssueDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpIssueDate.Location = New System.Drawing.Point(392, 48)
        Me.dtpIssueDate.Name = "dtpIssueDate"
        Me.dtpIssueDate.Size = New System.Drawing.Size(168, 23)
        Me.dtpIssueDate.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(120, Byte), CType(128, Byte), CType(171, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(304, 16)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 1
        '
        'txtAccNo
        '
        Me.txtAccNo.AlphaNumeric = True
        Me.txtAccNo.BlankSpace = False
        Me.txtAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccNo.Location = New System.Drawing.Point(168, 16)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.MaxLength = 10
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.Size = New System.Drawing.Size(128, 23)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 0
        Me.txtAccNo.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 19)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Current Account No."
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.AutoSize = False
        Me.txtName.BlankSpace = False
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(392, 16)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(168, 20)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 2
        Me.txtName.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(336, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Book No."
        '
        'txtBookName
        '
        Me.txtBookName.AlphaNumeric = True
        Me.txtBookName.BlankSpace = False
        Me.txtBookName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBookName.Location = New System.Drawing.Point(168, 48)
        Me.txtBookName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBookName.Mandatory = False
        Me.txtBookName.MaxLength = 10
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(128, 23)
        Me.txtBookName.SpecialChar = False
        Me.txtBookName.TabIndex = 3
        Me.txtBookName.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 19)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Start Cheque Leaf No."
        '
        'txtStartNo
        '
        Me.txtStartNo.AfterDecimal = 0
        Me.txtStartNo.BackColor = System.Drawing.Color.White
        Me.txtStartNo.BeforeDecimal = 10
        Me.txtStartNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtStartNo.Location = New System.Drawing.Point(168, 80)
        Me.txtStartNo.LostFocusColour = System.Drawing.Color.White
        Me.txtStartNo.MaxLength = 10
        Me.txtStartNo.MaxValue = 0
        Me.txtStartNo.MinValue = 0
        Me.txtStartNo.Name = "txtStartNo"
        Me.txtStartNo.Size = New System.Drawing.Size(128, 23)
        Me.txtStartNo.TabIndex = 5
        Me.txtStartNo.Text = ""
        '
        'txtNoOfleafs
        '
        Me.txtNoOfleafs.AfterDecimal = 0
        Me.txtNoOfleafs.BackColor = System.Drawing.Color.White
        Me.txtNoOfleafs.BeforeDecimal = 3
        Me.txtNoOfleafs.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfleafs.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNoOfleafs.Location = New System.Drawing.Point(488, 80)
        Me.txtNoOfleafs.LostFocusColour = System.Drawing.Color.White
        Me.txtNoOfleafs.MaxLength = 3
        Me.txtNoOfleafs.MaxValue = 100
        Me.txtNoOfleafs.MinValue = 0
        Me.txtNoOfleafs.Name = "txtNoOfleafs"
        Me.txtNoOfleafs.Size = New System.Drawing.Size(72, 23)
        Me.txtNoOfleafs.TabIndex = 6
        Me.txtNoOfleafs.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(336, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 19)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "No of  Cheque Leaf's"
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
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(480, 160)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 32)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "&Cancel"
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 0
        Me.txtReceiptNo.BeforeDecimal = 10
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(176, 160)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReceiptNo.MaxLength = 10
        Me.txtReceiptNo.MaxValue = 0
        Me.txtReceiptNo.MinValue = 0
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(128, 23)
        Me.txtReceiptNo.TabIndex = 7
        Me.txtReceiptNo.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(64, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.TabIndex = 132
        Me.Label8.Text = "Reference No."
        '
        'frmCAchequeBookIssue
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(586, 439)
        Me.Controls.Add(Me.txtReceiptNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lvChqBook)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCAchequeBookIssue"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CA cheque Book Issue"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmCAchequeBookIssue
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmCAchequeBookIssue
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmCAchequeBookIssue
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmCAchequeBookIssue)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Functions"

    '
    ' Validate Controls
    '

    Function fnCheck() As Boolean
        If Trim(txtAccNo.Text) = String.Empty Then
            MsgBox("Enter account no", MsgBoxStyle.Exclamation)
            txtAccNo.Focus()
            Return False
        ElseIf Trim(txtBookName.Text) = String.Empty Then
            MsgBox("Enter book no", MsgBoxStyle.Exclamation)
            txtBookName.Focus()
            Return False
        ElseIf Trim(txtStartNo.Text) = String.Empty Then
            MsgBox("Enter starting leaf no", MsgBoxStyle.Exclamation)
            txtStartNo.Focus()
            Return False
        ElseIf Trim(txtNoOfleafs.Text) = String.Empty Then
            MsgBox("Enter number of leaf's", MsgBoxStyle.Exclamation)
            txtNoOfleafs.Focus()
            Return False
        ElseIf Trim(txtReceiptNo.Text) = String.Empty Then
            MsgBox("Enter receipt number", MsgBoxStyle.Exclamation)
            txtReceiptNo.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    '
    ' Set Data To the property
    '
    Function fnSetData() As Boolean
        objCAAccount.CurAccountNo = Trim(txtAccNo.Text)
        objCAAccount.BookNo = Trim(txtBookName.Text)
        objCAAccount.ChkStartNo = Val(txtStartNo.Text)
        objCAAccount.ChkEndNo = Val(txtStartNo.Text) + Val(txtNoOfleafs.Text) - 1
        objCAAccount.ChkBookDate = Format(dtpIssueDate.Value, "yyyy-MM-dd")
        objCAAccount.Accdate = Format(dtpIssueDate.Value, "yyyy-MM-dd")
        objCAAccount.ChkStatus = "P"
        objCAAccount.Receipts = Trim(txtReceiptNo.Text)
        Return True
    End Function


    Sub fnClear()
        txtBookName.ResetText()
        txtMiscCharges.ResetText()
        txtNoOfleafs.ResetText()
        txtReceiptNo.ResetText()
        txtStartNo.ResetText()
    End Sub

#End Region

#Region "Event"

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim objCAccSearch As New frmCAccSearch
        objCAccSearch.strCAccountNo = String.Empty
        objCAccSearch.ShowDialog(Me)
        If objCAccSearch.strCAccountNo <> String.Empty Then
            txtAccNo.Text = objCAccSearch.strCAccountNo
            sbLoadSBAccDetails()
            sbLoadChkBookDetails()
        End If
        objCAccSearch.Dispose()

    End Sub

    Private Sub frmCAchequeBookIssue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpIssueDate.Value = Date.Now
        dtpIssueDate.MaxDate = Date.Now
        If strCAno <> String.Empty Then
            txtAccNo.Text = strCAno
            sbLoadSBAccDetails()
            sbLoadChkBookDetails()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Function fnCheakBalance() As Boolean

        If objCAAccount.fnGetCAccountDetails(txtAccNo.Text) Then
            dblAvalAmount = objCAAccount.CAAccTable.Rows(0).Item("AvailBalance")
            dblOverDrawLimit = objCAAccount.CAAccTable.Rows(0).Item("ODLimit")
            If Val(txtMiscCharges.Text) > Val(dblAvalAmount) + Val(dblOverDrawLimit) Then
                MsgBox("Chequebook isuue denaided due to insufficient fund in account", MsgBoxStyle.Information, "CA Module")
                Return False
            Else
                Return True
            End If
        Else
            Return False
        End If

    End Function

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        Dim objTrans As IDbTransaction
        objTrans = fnGetTransaction()
        Try
            If fnCheck() Then
                If objCAAccount.fnCACheckChequeBook(Trim(txtBookName.Text)) Then
                    MsgBox("This chequeBook already isuued", MsgBoxStyle.Information, "CA Module")
                    txtBookName.Focus()
                ElseIf fnCheakBalance() Then
                    If fnSetData() Then
                        objCAAccount.fnGetCAccountDetails(txtAccNo.Text)
                        If objCAAccount.CAAccTable.Rows(0).Item("AvailBalance") < Val(objDTMaster.Rows(0).Item("CAMinAmountforCheque")) Then
                            If MsgBox("Available balance is less than minimum amount for cheque issue,Still Do You Want To Issue Chequ Book? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Issue") = MsgBoxResult.Yes Then
                                If fnSaveData(objTrans) Then
                                    sbLoadChkBookDetails()
                                    objTrans.Commit()
                                End If
                            Else
                                MsgBox("ChequeBook isuue denaided due to insufficient fund in account", MsgBoxStyle.Information, " CA Module")
                            End If
                        Else
                            If fnSaveData(objTrans) Then
                                objTrans.Commit()
                                sbLoadChkBookDetails()
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            objTrans.Dispose()
        End Try
    End Sub
#End Region

#Region "Sub Routines"

    Sub sbLoadSBAccDetails()
        Dim objDT As DataTable

        If objCAAccount.fnGetCAMasterData Then
            objDTMaster = objCAAccount.CAMasterTable
            dblAmountPerCheque = objDTMaster.Rows(0).Item("CAAmountPerCheque")
        Else
            MsgBox("Check CA master setting", MsgBoxStyle.Information)
            ' txtAccNo.Focus()
            Return
        End If

        If objCAAccount.fnGetCAccountDetails(txtAccNo.Text) Then
            objDT = objCAAccount.CAAccTable
            'CA Details
            txtAccNo.Text = objDT.Rows(0).Item("CAccountNo")
            txtName.Text = objDT.Rows(0).Item("Name")
            dblAvalAmount = objDT.Rows(0).Item("AvailBalance")
            dblOverDrawLimit = objDT.Rows(0).Item("ODLimit")
            datLastPaid = CDate(objDT.Rows(0).Item("LastPaidDate"))
            txtName.Focus()
        End If
    End Sub

    '
    ' Load Cheque Book Deatils
    '

    Sub sbLoadChkBookDetails()
        If fnSetData() Then
            If objCAAccount.fnGetCACheckBookDetails() And objCAAccount.CACheckBookBookTable.Rows.Count > 0 Then
                Dim intCnt As Integer
                Dim lvItem As ListViewItem
                lvChqBook.Items.Clear()
                For intCnt = 0 To objCAAccount.CACheckBookBookTable.Rows.Count - 1
                    lvItem = lvChqBook.Items.Add(intCnt + 1)
                    lvItem.SubItems.Add(objCAAccount.CACheckBookBookTable.Rows(intCnt).Item("Book_SNo"))
                    lvItem.SubItems.Add(Format(objCAAccount.CACheckBookBookTable.Rows(intCnt).Item("IssuedDate"), "dd-MMM-yyyy"))
                    lvItem.SubItems.Add(objCAAccount.CACheckBookBookTable.Rows(intCnt).Item("StartNo"))
                    lvItem.SubItems.Add(objCAAccount.CACheckBookBookTable.Rows(intCnt).Item("EndNo"))
                    lvItem.SubItems.Add(objCAAccount.CACheckBookBookTable.Rows(intCnt).Item("Status"))
                    lvItem.SubItems.Add(objCAAccount.CACheckBookBookTable.Rows(intCnt).Item("RefNo"))
                Next
            End If
        End If
    End Sub


    Function fnSaveData(ByVal objTrans As IDbTransaction) As Boolean
        If objCAAccount.fnCAInsertCheckBookDetails() Then
            fnGenerateVoucher(objTrans)
            fnLogEntry(pbUserId, "Withdrawed for Cheque Leaf Charges By " & txtAccNo.Text & " Amount " & txtMiscCharges.Text, Date.Now, "Transaction Withdraw", objTrans)
            fnClear()
            MsgBox("Chequebook isuued sucessfully", MsgBoxStyle.Information, "SB Module")
            Return True
        Else
            fnClear()
            MsgBox("ChequeBook isuue failed due to internal error", MsgBoxStyle.Information, "SB Module")
            Return False
        End If

    End Function

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpIssueDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entry

        Dim strNarration As String = "Cheque Leaf Charges By " & txtAccNo.Text & " "

        Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpIssueDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtMiscCharges.Text) & "','0','" & Trim(txtMiscCharges.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtMiscCharges.Text) & "','" & dblCalIntrest & "','" & Trim(txtReceiptNo.Text) & "','" & lngVoucherNo & "','Cash','0' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
        fnExecuteNonQuery(strsql, objTrans)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 1, txtAccNo.Text, txtReceiptNo.Text, dtpIssueDate.Value, txtMiscCharges.Text, "Cheque leaf charges by " & txtAccNo.Text, lngSlNo, "Y", objTrans)

        If dblAvalAmount <= 0 Then
            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 1, "", dtpIssueDate.Value, "Cheque leaf charges by account " & txtAccNo.Text, "To", 13, 0, Val(txtMiscCharges.Text), 1, "Y", objTrans)
            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpIssueDate.Value, "Cheque leaf charges by account " & txtAccNo.Text, "By", 12, Val(txtMiscCharges.Text), 0, 2, "Y", objTrans)
        Else
            Dim dblTempBalance As Double = Val(dblAvalAmount) - Val(txtMiscCharges.Text)
            If dblTempBalance < 0 Then
                'Credit accounts
                fnVoucherEnterSub(lngVoucherNo, 1, "", dtpIssueDate.Value, "Cheque leaf charges by account " & txtAccNo.Text, "To", 13, 0, Val(txtMiscCharges.Text), 1, "Y", objTrans)

                'Debit accounts
                fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpIssueDate.Value, "Cheque leaf charges by account " & txtAccNo.Text, "By", 11, Abs(dblAvalAmount), 0, 2, "Y", objTrans)

                ' If dblTempBalance <> 0 Then
                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpIssueDate.Value, "Cheque leaf charges by account " & txtAccNo.Text, "To", 12, Abs(dblTempBalance), 0, 3, "Y", objTrans)
                'End If
            Else
                'Credit accounts
                fnVoucherEnterSub(lngVoucherNo, 1, "", dtpIssueDate.Value, "Cheque leaf charges by account " & txtAccNo.Text, "To", 13, 0, Val(txtMiscCharges.Text), 1, "Y", objTrans)
                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpIssueDate.Value, "Cheque leaf charges by account " & txtAccNo.Text, "By", 11, Val(txtMiscCharges.Text), 0, 2, "Y", objTrans)
            End If
        End If

        Return True
    End Function

    Function fnCalcInterest() As Boolean
        Dim ROI As Double
        Dim intNOD As Integer
        dblCalIntrest = 0
        Dim intInterestDiff As Integer
        Dim dblAmount As Double = dblAvailBal

        If dblAvailBal < 0 Then
            ROI = objCAAccount.CAMasterTable.Rows(0).Item("CAROI")
            intInterestDiff = DateDiff(DateInterval.Day, datLastPaid, dtpIssueDate.Value)
            If intInterestDiff > 0 Then
                dblCalIntrest = Math.Round(((Abs(dblAmount) * intInterestDiff * (ROI / 100)) / 365), 2)
                objCAAccount.IntAmt = dblCalIntrest
            End If
        End If
        Return True
    End Function

    Private Sub txtNoOfleafs_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoOfleafs.Leave
        txtMiscCharges.Text = dblAmountPerCheque * Val(txtNoOfleafs.Text)
    End Sub

    Private Sub txtAccNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccNo.Leave
        AutoLoad()
        sbLoadSBAccDetails()
        sbLoadChkBookDetails()
    End Sub
    Public Sub AutoLoad()
        Select Case txtAccNo.Text.Length
            Case "1"
                txtAccNo.Text = "CA0000" & txtAccNo.Text
            Case "2"
                txtAccNo.Text = "CA000" & txtAccNo.Text
            Case "3"
                txtAccNo.Text = "CA00" & txtAccNo.Text
            Case "4"
                txtAccNo.Text = "CA0" & txtAccNo.Text
            Case "5"
                txtAccNo.Text = "CA" & txtAccNo.Text
        End Select
    End Sub

#End Region

End Class
