Imports System.Math

Public Class frmBranchIntCal
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
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lvLiability As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbLedger As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCal As BankControls.NewButton
    Friend WithEvents btnPassVouher As BankControls.NewButton
    Friend WithEvents txtROI As BankControls.NumericControl
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtIR As BankControls.TextControl
    Friend WithEvents txtIP As BankControls.TextControl
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents NewButton1 As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBranchIntCal))
        Me.Label32 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtROI = New BankControls.NumericControl
        Me.Label15 = New System.Windows.Forms.Label
        Me.btnPassVouher = New BankControls.NewButton
        Me.btnCal = New BankControls.NewButton
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbLedger = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtIR = New BankControls.TextControl
        Me.txtIP = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.lvLiability = New System.Windows.Forms.ListView
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.btnCancel = New BankControls.NewButton
        Me.NewButton1 = New BankControls.NewButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(72, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(131, 25)
        Me.Label32.TabIndex = 121
        Me.Label32.Text = "Brach Interest"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 122
        Me.PictureBox1.TabStop = False
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Int Payable"
        Me.ColumnHeader3.Width = 98
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cr Balance"
        Me.ColumnHeader1.Width = 109
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Date"
        Me.ColumnHeader8.Width = 84
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Dr Balance"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 115
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Int Receivable"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 106
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.GroupBox1.Controls.Add(Me.txtROI)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.btnPassVouher)
        Me.GroupBox1.Controls.Add(Me.btnCal)
        Me.GroupBox1.Controls.Add(Me.dtpStartDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbLedger)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.lvLiability)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(592, 488)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtROI
        '
        Me.txtROI.AfterDecimal = 2
        Me.txtROI.BackColor = System.Drawing.SystemColors.Window
        Me.txtROI.BeforeDecimal = 8
        Me.txtROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.GotFocusColour = System.Drawing.Color.Empty
        Me.txtROI.Location = New System.Drawing.Point(128, 80)
        Me.txtROI.LostFocusColour = System.Drawing.Color.Empty
        Me.txtROI.MaxLength = 10
        Me.txtROI.MaxValue = 0
        Me.txtROI.MinValue = 0
        Me.txtROI.Name = "txtROI"
        Me.txtROI.Size = New System.Drawing.Size(144, 23)
        Me.txtROI.TabIndex = 3
        Me.txtROI.TabStop = False
        Me.txtROI.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 19)
        Me.Label15.TabIndex = 103
        Me.Label15.Text = " ROI :"
        '
        'btnPassVouher
        '
        Me.btnPassVouher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPassVouher.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPassVouher.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPassVouher.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPassVouher.GotFocusColour = System.Drawing.Color.FromArgb(CType(152, Byte), CType(220, Byte), CType(166, Byte))
        Me.btnPassVouher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPassVouher.Location = New System.Drawing.Point(400, 64)
        Me.btnPassVouher.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnPassVouher.Name = "btnPassVouher"
        Me.btnPassVouher.Size = New System.Drawing.Size(112, 32)
        Me.btnPassVouher.TabIndex = 5
        Me.btnPassVouher.Text = "&Pass Voucher"
        Me.btnPassVouher.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCal
        '
        Me.btnCal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCal.GotFocusColour = System.Drawing.Color.FromArgb(CType(152, Byte), CType(220, Byte), CType(166, Byte))
        Me.btnCal.Image = CType(resources.GetObject("btnCal.Image"), System.Drawing.Image)
        Me.btnCal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCal.Location = New System.Drawing.Point(400, 16)
        Me.btnCal.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(112, 32)
        Me.btnCal.TabIndex = 4
        Me.btnCal.Text = "&Cal Interest"
        Me.btnCal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "MMM - yyyy"
        Me.dtpStartDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(128, 48)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(144, 23)
        Me.dtpStartDate.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 19)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Date :"
        Me.Label5.Visible = False
        '
        'cmbLedger
        '
        Me.cmbLedger.BackColor = System.Drawing.Color.White
        Me.cmbLedger.DropDownWidth = 300
        Me.cmbLedger.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLedger.Location = New System.Drawing.Point(128, 16)
        Me.cmbLedger.MaxDropDownItems = 12
        Me.cmbLedger.Name = "cmbLedger"
        Me.cmbLedger.Size = New System.Drawing.Size(192, 24)
        Me.cmbLedger.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Select Branch :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtIR)
        Me.GroupBox3.Controls.Add(Me.txtIP)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 440)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(576, 40)
        Me.GroupBox3.TabIndex = 78
        Me.GroupBox3.TabStop = False
        '
        'txtIR
        '
        Me.txtIR.AlphaNumeric = True
        Me.txtIR.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.txtIR.BlankSpace = False
        Me.txtIR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIR.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIR.GotFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.txtIR.Location = New System.Drawing.Point(312, 16)
        Me.txtIR.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.txtIR.Mandatory = False
        Me.txtIR.MaxLength = 10
        Me.txtIR.Name = "txtIR"
        Me.txtIR.ReadOnly = True
        Me.txtIR.Size = New System.Drawing.Size(112, 16)
        Me.txtIR.SpecialChar = True
        Me.txtIR.TabIndex = 18
        Me.txtIR.Text = ""
        Me.txtIR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIP
        '
        Me.txtIP.AlphaNumeric = True
        Me.txtIP.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.txtIP.BlankSpace = False
        Me.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIP.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIP.GotFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.txtIP.Location = New System.Drawing.Point(424, 16)
        Me.txtIP.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.txtIP.Mandatory = False
        Me.txtIP.MaxLength = 10
        Me.txtIP.Name = "txtIP"
        Me.txtIP.ReadOnly = True
        Me.txtIP.Size = New System.Drawing.Size(120, 16)
        Me.txtIP.SpecialChar = True
        Me.txtIP.TabIndex = 17
        Me.txtIP.Text = ""
        Me.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(248, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Total :"
        '
        'lvLiability
        '
        Me.lvLiability.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvLiability.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvLiability.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lvLiability.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLiability.FullRowSelect = True
        Me.lvLiability.GridLines = True
        Me.lvLiability.HideSelection = False
        Me.lvLiability.Location = New System.Drawing.Point(8, 104)
        Me.lvLiability.Name = "lvLiability"
        Me.lvLiability.Size = New System.Drawing.Size(576, 336)
        Me.lvLiability.TabIndex = 6
        Me.lvLiability.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Sl No."
        Me.ColumnHeader11.Width = 39
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date"
        Me.ColumnHeader4.Width = 86
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Dr. Balance"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 93
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Cr. Balance"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Int Recivable"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 106
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Int Payable"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 114
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(504, 536)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 32)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NewButton1
        '
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.GotFocusColour = System.Drawing.Color.FromArgb(CType(152, Byte), CType(220, Byte), CType(166, Byte))
        Me.NewButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton1.Location = New System.Drawing.Point(416, 536)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(80, 32)
        Me.NewButton1.TabIndex = 7
        Me.NewButton1.Text = "&Reset"
        '
        'frmBranchIntCal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(608, 575)
        Me.Controls.Add(Me.NewButton1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBranchIntCal"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Branch Interest Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmBranchIntCal
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmBranchIntCal
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmBranchIntCal
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmBranchIntCal)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Global Variables"
    Dim objLedger As New clsLedger

#End Region

#Region "User defined function"

    Function fnCheck() As Boolean

        If cmbLedger.SelectedIndex = -1 Then
            MsgBox("Please select branch", MsgBoxStyle.Exclamation)
            cmbLedger.Focus()
            Return False
        ElseIf Val(txtROI.Text) = 0 Then
            MsgBox("Please enter Rate of interest", MsgBoxStyle.Exclamation)
            txtROI.Focus()
            Return False
        Else
            Return True
        End If
    End Function

#End Region

    Private Sub frmBranchIntCal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If objLedger.fnGetBranchLedgerList Then
            cmbLedger.DataSource = objLedger.LedgerTable
            cmbLedger.DisplayMember = "Name"
            cmbLedger.ValueMember = "LedgerNo"
            dtpStartDate.Value = Date.Now

        End If

        cmbLedger.SelectedIndex = -1

    End Sub

    Private Sub btnCal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCal.Click

        If fnCheck() Then

            lvLiability.Items.Clear()

            Dim dblDrBalance, dblCrBalance, dblIR, dblIP, dblTotalIR, dblTotalIP, dblInterest, dblBalance As Double
            Dim iv As ListViewItem
            Dim dtDate As Date = dtpStartDate.Value
            Dim dt As New DataTable

            Dim dtStDate As Date = dtDate.AddDays(-(dtDate.Day))
            dtStDate = dtStDate.AddDays(1)
            Dim DtTransDate As Date = dtStDate

            '''''This is considered for the day of calculation
            Dim stLtDate As Date = dtpStartDate.Value
            stLtDate = stLtDate.AddMonths(1)
            stLtDate = stLtDate.AddDays(-(stLtDate.Day))

            If stLtDate > Date.Now Then
                stLtDate = Date.Now
            End If

            '''''This is for the last day of the month
            Dim intCount As Integer = stLtDate.Day

            Dim intLop As Integer = 1

            While intLop <= intCount
                dblDrBalance = 0
                dblCrBalance = 0
                dblIR = 0
                dblIP = 0
                If objLedger.fnGetBranchBalance(cmbLedger.SelectedValue, DtTransDate) Then
                    dt = objLedger.LedgerTable

                    dblBalance = dt.Rows(0).Item("Balance")
                    dblInterest = Math.Round(((Abs(dblBalance) * (txtROI.Text / 100)) / 365), 2)

                    If dt.Rows(0).Item("Balance") > 0 Then
                        dblDrBalance = dblBalance
                        dblIR = dblInterest
                        dblTotalIR += dblInterest
                    Else
                        dblCrBalance = Abs(dblBalance)
                        dblIP = dblInterest
                        dblTotalIP += dblInterest
                    End If

                End If

                iv = lvLiability.Items.Add(intLop)
                iv.SubItems.Add(Format(DtTransDate, "dd-MMM-yyyy"))
                iv.SubItems.Add(Format(Math.Round(dblDrBalance), "0,00.00"))
                iv.SubItems.Add(Format(Math.Round(dblCrBalance), "0,00.00"))
                iv.SubItems.Add(Format(Math.Round(dblIR), "0,00.00"))
                iv.SubItems.Add(Format(Math.Round(dblIP), "0,00.00"))

                DtTransDate = DtTransDate.AddDays(1)
                intLop += 1
            End While

            txtIR.Text = Format(Math.Round(dblTotalIR), "0,00.00")
            txtIP.Text = Format(Math.Round(dblTotalIP), "0,00.00")
        End If

    End Sub

    Private Sub btnPassVouher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPassVouher.Click
        Dim objfrmVocuherEntry As New frmVoucherEntry
        objfrmVocuherEntry.ShowDialog()
        objfrmVocuherEntry = Nothing
    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click
        lvLiability.Items.Clear()
        cmbLedger.SelectedIndex = -1
        txtROI.ResetText()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class
