Public Class frmSBChequeStatusDetails
    Inherits System.Windows.Forms.Form

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmSBChequeStatusDetails
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmSBChequeStatusDetails
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmSBChequeStatusDetails
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmSBChequeStatusDetails)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Form Global Variables"
    Dim objSavingsBank As New clsSavingsBank
    Dim dvSBCheques As DataView
    Dim strFilter As String = "AccountNo like '%'"

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
    'Friend WithEvents ctrl As System.Windows.Forms.Control
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvDepositedCheques As System.Windows.Forms.ListView
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents cmbSearchItems As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As BankControls.TextControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents NewButton7 As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents btnUpdateStatus As BankControls.NewButton
    Friend WithEvents dtpChequeDepDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents btnDeposit As BankControls.NewButton
    Friend WithEvents btnNewSBAcc As BankControls.NewButton
    Friend WithEvents btnViewChqTran As BankControls.NewButton
    Friend WithEvents btnStpCheque As BankControls.NewButton
    Friend WithEvents btnWithDraw As BankControls.NewButton
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSBChequeStatusDetails))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSearch = New BankControls.NewButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSearch = New BankControls.TextControl
        Me.dtpChequeDepDate = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbType = New System.Windows.Forms.ComboBox
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
        Me.lblMessage = New System.Windows.Forms.Label
        Me.cmbSearchItems = New System.Windows.Forms.ComboBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnUpdateStatus = New BankControls.NewButton
        Me.btnDeposit = New BankControls.NewButton
        Me.btnViewChqTran = New BankControls.NewButton
        Me.btnNewSBAcc = New BankControls.NewButton
        Me.NewButton7 = New BankControls.NewButton
        Me.btnStpCheque = New BankControls.NewButton
        Me.btnWithDraw = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.dtpChequeDepDate)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cmbType)
        Me.Panel1.Location = New System.Drawing.Point(8, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 48)
        Me.Panel1.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(696, 16)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(32, 24)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(440, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 19)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Search Text :"
        '
        'txtSearch
        '
        Me.txtSearch.AlphaNumeric = True
        Me.txtSearch.BlankSpace = False
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSearch.Location = New System.Drawing.Point(536, 16)
        Me.txtSearch.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtSearch.Mandatory = False
        Me.txtSearch.MaxLength = 50
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(152, 23)
        Me.txtSearch.SpecialChar = False
        Me.txtSearch.TabIndex = 2
        Me.txtSearch.Text = ""
        '
        'dtpChequeDepDate
        '
        Me.dtpChequeDepDate.CustomFormat = "dd / MMM / yyyy"
        Me.dtpChequeDepDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpChequeDepDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpChequeDepDate.Location = New System.Drawing.Point(536, 16)
        Me.dtpChequeDepDate.MaxDate = New Date(2331, 11, 17, 0, 0, 0, 0)
        Me.dtpChequeDepDate.Name = "dtpChequeDepDate"
        Me.dtpChequeDepDate.Size = New System.Drawing.Size(152, 23)
        Me.dtpChequeDepDate.TabIndex = 109
        Me.dtpChequeDepDate.Value = New Date(2007, 10, 11, 0, 0, 0, 0)
        Me.dtpChequeDepDate.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(56, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 19)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "Search By :"
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Items.AddRange(New Object() {"ChequeNo", "AccountNo", "BankName", "BranchName", "ChequeAmount", "ChequeStatus", "DepositDate"})
        Me.cmbType.Location = New System.Drawing.Point(144, 16)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(216, 24)
        Me.cmbType.TabIndex = 1
        '
        'lvDepositedCheques
        '
        Me.lvDepositedCheques.BackColor = System.Drawing.Color.FromArgb(CType(243, Byte), CType(254, Byte), CType(254, Byte))
        Me.lvDepositedCheques.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader10, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader11})
        Me.lvDepositedCheques.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDepositedCheques.FullRowSelect = True
        Me.lvDepositedCheques.GridLines = True
        Me.lvDepositedCheques.Location = New System.Drawing.Point(8, 128)
        Me.lvDepositedCheques.MultiSelect = False
        Me.lvDepositedCheques.Name = "lvDepositedCheques"
        Me.lvDepositedCheques.Size = New System.Drawing.Size(776, 424)
        Me.lvDepositedCheques.TabIndex = 5
        Me.lvDepositedCheques.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "SlNo."
        Me.ColumnHeader12.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "AccountNo."
        Me.ColumnHeader1.Width = 79
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "BankName"
        Me.ColumnHeader2.Width = 96
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "BranchName"
        Me.ColumnHeader3.Width = 96
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ChequeDate"
        Me.ColumnHeader4.Width = 96
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ChequeNo."
        Me.ColumnHeader5.Width = 83
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "DepositDate"
        Me.ColumnHeader6.Width = 101
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Amount"
        Me.ColumnHeader7.Width = 83
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Status"
        Me.ColumnHeader10.Width = 67
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ClearanceDate"
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "BankCharges"
        Me.ColumnHeader9.Width = 78
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Remarks"
        Me.ColumnHeader11.Width = 62
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(240, 80)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(251, 18)
        Me.lblMessage.TabIndex = 107
        Me.lblMessage.Text = "There are 0 records found for your search"
        '
        'cmbSearchItems
        '
        Me.cmbSearchItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchItems.Location = New System.Drawing.Point(240, 8)
        Me.cmbSearchItems.Name = "cmbSearchItems"
        Me.cmbSearchItems.Size = New System.Drawing.Size(216, 24)
        Me.cmbSearchItems.TabIndex = 108
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
        Me.Panel2.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Location = New System.Drawing.Point(8, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 608)
        Me.Panel2.TabIndex = 7
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
        Me.btnUpdateStatus.Location = New System.Drawing.Point(8, 248)
        Me.btnUpdateStatus.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnUpdateStatus.Name = "btnUpdateStatus"
        Me.btnUpdateStatus.Size = New System.Drawing.Size(176, 40)
        Me.btnUpdateStatus.TabIndex = 4
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
        Me.btnDeposit.Location = New System.Drawing.Point(8, 288)
        Me.btnDeposit.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(176, 40)
        Me.btnDeposit.TabIndex = 5
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
        Me.btnViewChqTran.Location = New System.Drawing.Point(8, 448)
        Me.btnViewChqTran.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnViewChqTran.Name = "btnViewChqTran"
        Me.btnViewChqTran.Size = New System.Drawing.Size(176, 40)
        Me.btnViewChqTran.TabIndex = 8
        Me.btnViewChqTran.Text = "View Transaction Log(Cheque)"
        Me.btnViewChqTran.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.btnNewSBAcc.Location = New System.Drawing.Point(8, 160)
        Me.btnNewSBAcc.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnNewSBAcc.Name = "btnNewSBAcc"
        Me.btnNewSBAcc.Size = New System.Drawing.Size(176, 40)
        Me.btnNewSBAcc.TabIndex = 3
        Me.btnNewSBAcc.Text = "New SB Account"
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
        Me.NewButton7.Location = New System.Drawing.Point(8, 488)
        Me.NewButton7.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton7.Name = "NewButton7"
        Me.NewButton7.Size = New System.Drawing.Size(176, 40)
        Me.NewButton7.TabIndex = 9
        Me.NewButton7.Text = "View Stopped Cheque Details"
        Me.NewButton7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.btnStpCheque.Location = New System.Drawing.Point(8, 368)
        Me.btnStpCheque.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnStpCheque.Name = "btnStpCheque"
        Me.btnStpCheque.Size = New System.Drawing.Size(176, 40)
        Me.btnStpCheque.TabIndex = 7
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
        Me.btnWithDraw.Location = New System.Drawing.Point(8, 328)
        Me.btnWithDraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnWithDraw.Name = "btnWithDraw"
        Me.btnWithDraw.Size = New System.Drawing.Size(176, 40)
        Me.btnWithDraw.TabIndex = 6
        Me.btnWithDraw.Text = "Cheque Withdraw"
        Me.btnWithDraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.btnCancel.Location = New System.Drawing.Point(680, 560)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 40)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.lvDepositedCheques)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Location = New System.Drawing.Point(216, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(792, 616)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Teal
        Me.Label32.Location = New System.Drawing.Point(88, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(168, 25)
        Me.Label32.TabIndex = 109
        Me.Label32.Text = "Cheque Status List"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 110
        Me.PictureBox1.TabStop = False
        '
        'frmSBChequeStatusDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1018, 631)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmSBChequeStatusDetails"
        Me.ShowInTaskbar = False
        Me.Text = "Cheque Status Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Functions"

    Function fnLoadSearchItems(ByVal strfield As String)
        cmbSearchItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        cmbSearchItems.Location = New System.Drawing.Point(88, 40)
        cmbSearchItems.Size = New System.Drawing.Size(152, 22)
        Me.Panel1.Controls.Add(cmbSearchItems)
        Dim dt As New DataTable
        'dt = SelectDistinct("sbchequedeposittbl", objSavingsBank.ChequedetailsTable, strfield)
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
        dvSBCheques.RowFilter = strFilter
        lvDepositedCheques.Items.Clear()
        Try
            If dvSBCheques.Count > 0 Then
                lblMessage.Text = "There are " & dvSBCheques.Count & " records found for your search"
                While intCounter < dvSBCheques.Count
                    lvItem = lvDepositedCheques.Items.Add(dvSBCheques.Item(intCounter).Item("SlNo"))
                    lvItem.SubItems.Add(dvSBCheques.Item(intCounter).Item("AccountNo"))
                    lvItem.SubItems.Add(dvSBCheques.Item(intCounter).Item("BankName"))
                    lvItem.SubItems.Add(dvSBCheques.Item(intCounter).Item("BranchName"))
                    lvItem.SubItems.Add(Format(dvSBCheques.Item(intCounter).Item("ChequeDate"), "dd-MMM-yyyy"))
                    lvItem.SubItems.Add(dvSBCheques.Item(intCounter).Item("ChequeNo"))
                    lvItem.SubItems.Add(Format(dvSBCheques.Item(intCounter).Item("DepositDate"), "dd-MMM-yyyy"))
                    lvItem.SubItems.Add(dvSBCheques.Item(intCounter).Item("ChequeAmount"))
                    lvItem.SubItems.Add(dvSBCheques.Item(intCounter).Item("ChequeStatus"))
                    If IsDBNull(dvSBCheques.Item(intCounter).Item("ClearanceDate")) Then
                        lvItem.SubItems.Add("")
                    Else
                        lvItem.SubItems.Add(Format(dvSBCheques.Item(intCounter).Item("ClearanceDate"), "dd-MMM-yyyy"))
                    End If
                    lvItem.SubItems.Add(dvSBCheques.Item(intCounter).Item("BankCharges"))
                    lvItem.SubItems.Add(dvSBCheques.Item(intCounter).Item("Narration"))
                    intCounter += 1
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub

#End Region

#Region " Events"

    Private Sub frmSBChequeStatusDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If objSavingsBank.fnGetDepositedCheque() = True Then
            dvSBCheques = New DataView(objSavingsBank.ChequedetailsTable, strFilter, "AccountNo", DataViewRowState.OriginalRows)
            sbLoadDepositedCheques()
        End If
        dtpChequeDepDate.Visible = False
        btnSearch.Visible = False

    End Sub

    Private Sub lvDepositedCheques_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvDepositedCheques.DoubleClick
        If lvDepositedCheques.SelectedItems.Count > 0 Then
            If lvDepositedCheques.SelectedItems.Item(0).SubItems(8).Text = "Pending" Then
                Dim ObjfrmSBChequeStatusUpdate As New frmSBChequeStatusUpdate
                ObjfrmSBChequeStatusUpdate.slNo = lvDepositedCheques.SelectedItems(0).SubItems(0).Text
                ObjfrmSBChequeStatusUpdate.txtAccNo.Text = lvDepositedCheques.SelectedItems(0).SubItems(1).Text
                ObjfrmSBChequeStatusUpdate.txtBankName.Text = lvDepositedCheques.SelectedItems(0).SubItems(2).Text
                ObjfrmSBChequeStatusUpdate.txtBranchName.Text = lvDepositedCheques.SelectedItems(0).SubItems(3).Text
                ObjfrmSBChequeStatusUpdate.dtpChequeDate.Value = lvDepositedCheques.SelectedItems(0).SubItems(4).Text
                ObjfrmSBChequeStatusUpdate.txtChequeNo.Text = lvDepositedCheques.SelectedItems(0).SubItems(5).Text
                ObjfrmSBChequeStatusUpdate.dtpDepositdate.Value = lvDepositedCheques.SelectedItems(0).SubItems(6).Text
                ObjfrmSBChequeStatusUpdate.txtChequeAmount.Text = lvDepositedCheques.SelectedItems(0).SubItems(7).Text
                ObjfrmSBChequeStatusUpdate.txtRemarks.Text = lvDepositedCheques.SelectedItems(0).SubItems(11).Text
                ObjfrmSBChequeStatusUpdate.txtClearedAmt.Text = lvDepositedCheques.SelectedItems(0).SubItems(7).Text
                ObjfrmSBChequeStatusUpdate.ShowDialog()
                frmSBChequeStatusDetails_Load(sender, e)
            Else
                MsgBox("Cannot change cheque status,cheque already changed", MsgBoxStyle.Exclamation, "SB Module")
            End If
        End If
    End Sub

    Private Sub TextControl1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearchItems.TextChanged, cmbSearchItems.SelectedIndexChanged
        If cmbType.SelectedItem = "DepositDate" Then

        ElseIf cmbType.SelectedItem = "ChequeStatus" Then
            strFilter = "ChequeStatus LIKE '" & cmbSearchItems.SelectedItem & "'"
            sbLoadDepositedCheques()
        ElseIf cmbType.SelectedItem = "ChequeAmount" Then
            strFilter = "ChequeAmount =" & Val(cmbSearchItems.SelectedItem) & ""
            sbLoadDepositedCheques()
        End If
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
                strFilter = "AccountNo like '" & txtSearch.Text & "%'"
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
                    strFilter = "AccountNo like '" & txtSearch.Text & "%'"
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

#End Region

    Private Sub btnUpdateStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateStatus.Click
        Dim objStatusUpdate As New frmSBChequeStatusUpdate
        If lvDepositedCheques.SelectedItems.Count > 0 Then
            If lvDepositedCheques.SelectedItems(0).SubItems(8).Text = "Pending" Then
                objStatusUpdate.txtAccNo.Text = lvDepositedCheques.SelectedItems(0).SubItems(1).Text
                objStatusUpdate.txtBankName.Text = lvDepositedCheques.SelectedItems(0).SubItems(2).Text
                objStatusUpdate.txtBranchName.Text = lvDepositedCheques.SelectedItems(0).SubItems(3).Text
                objStatusUpdate.txtChequeNo.Text = lvDepositedCheques.SelectedItems(0).SubItems(5).Text
                objStatusUpdate.txtChequeAmount.Text = lvDepositedCheques.SelectedItems(0).SubItems(7).Text
                objStatusUpdate.txtBankCharges.Text = lvDepositedCheques.SelectedItems(0).SubItems(10).Text
                objStatusUpdate.dtpChequeDate.Text = lvDepositedCheques.SelectedItems(0).SubItems(4).Text
                objStatusUpdate.dtpClearanceDate.Text = lvDepositedCheques.SelectedItems(0).SubItems(9).Text
                objStatusUpdate.dtpDepositdate.Text = lvDepositedCheques.SelectedItems(0).SubItems(6).Text
                objStatusUpdate.txtClearedAmt.Text = lvDepositedCheques.SelectedItems(0).SubItems(7).Text
                objStatusUpdate.ShowDialog()
                frmSBChequeStatusDetails_Load(sender, e)
            Else
                MsgBox("Account status cannot be changed, since its already " & lvDepositedCheques.SelectedItems(0).SubItems(8).Text, MsgBoxStyle.Exclamation, "SB Module")
            End If
        Else
            MsgBox("Please select cheque from the list", MsgBoxStyle.Exclamation, "SB Module")
        End If
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

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        txtSearch.Visible = False
        dtpChequeDepDate.Visible = True
        strFilter = "DepositDate = '" & dtpChequeDepDate.Value & "'"
        sbLoadDepositedCheques()

    End Sub

    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        Try
            Dim ObjSbChqdeposit As New frmSBChequeDeposit
            ' ObjSbChqdeposit.txtAccNo.Text = Trim(lvDepositedCheques.SelectedItems(0).SubItems(1).Text)
            '' ObjSbdeposit.txtName.Text = Trim(lvDepositedCheques.SelectedItems(0).SubItems(1).Text)
            ObjSbChqdeposit.ShowDialog(Me)
            frmSBChequeStatusDetails_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnViewChqTran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles btnViewChqTran.Click

        If lvDepositedCheques.SelectedItems.Count > 0 Then
            Dim objSBChqTran As New frmSBChequeTransaction
            objSBChqTran.txtAccno.Text = lvDepositedCheques.SelectedItems(0).SubItems(1).Text
            objSBChqTran.Show()
        End If

    End Sub

    Private Sub btnStpCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStpCheque.Click

        If lvDepositedCheques.SelectedItems.Count > 0 Then
            If lvDepositedCheques.SelectedItems(0).SubItems(8).Text = "Pending" Then
                Dim objfrmStpPay As New frmSBChequeStopPay
                objfrmStpPay.txtAccNo.Text = lvDepositedCheques.SelectedItems(0).SubItems(1).Text
                objfrmStpPay.txtSBChequeNo.Text = lvDepositedCheques.SelectedItems(0).SubItems(5).Text
                objfrmStpPay.txtChequeAmount.Text = lvDepositedCheques.SelectedItems(0).SubItems(7).Text
                objfrmStpPay.ShowDialog()
                frmSBChequeStatusDetails_Load(sender, e)
            Else
                MsgBox("Account status cannot be changed, since its already " & lvDepositedCheques.SelectedItems(0).SubItems(8).Text, MsgBoxStyle.Exclamation, "SB Module")
            End If
        Else
            MsgBox("Please select cheque from the list", MsgBoxStyle.Exclamation, "SB Module")
        End If

    End Sub

    Private Sub btnWithDraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithDraw.Click
        Try
            Dim objfrmChqWithdraw As New frmSBChequeWithdraw
            objfrmChqWithdraw.ShowDialog()
            frmSBChequeStatusDetails_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub NewButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) ' Handles NewButton7.Click

        Dim objSBStopDet As New frmSBStopChequeDet
        objSBStopDet.Show()

    End Sub

    Private Sub btnNewSBAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewSBAcc.Click
        Dim objFrmNewSB As frmSBAccCreation
        objFrmNewSB = frmSBAccCreation.DefInstance
        objFrmNewSB.MdiParent = Me.MdiParent
        objFrmNewSB.BringToFront()
        objFrmNewSB.Show()
        objFrmNewSB = Nothing
    End Sub



End Class
