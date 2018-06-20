Public Class frmSBChequeBookIssue
    Inherits System.Windows.Forms.Form

#Region "Form global variables"
    Dim objSBAccount As New clsSavingsBank
    Dim dblAvailBal As Double
    Dim objDTMaster As New DataTable
    Public strSbno As String
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
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents txtBookName As BankControls.TextControl
    Friend WithEvents txtStartNo As BankControls.NumericControl
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents lvChqBook As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtNoOfleafs As BankControls.NumericControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpIssueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMiscCharges As BankControls.TextControl
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents cmbAccountNo As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSBChequeBookIssue))
        Me.lvChqBook = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbAccountNo = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMiscCharges = New BankControls.TextControl
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpIssueDate = New System.Windows.Forms.DateTimePicker
        Me.txtNoOfleafs = New BankControls.NumericControl
        Me.btnSearch = New BankControls.NewButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtBookName = New BankControls.TextControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtStartNo = New BankControls.NumericControl
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnOk = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.txtReceiptNo = New BankControls.NumericControl
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvChqBook
        '
        Me.lvChqBook.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader6, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7})
        Me.lvChqBook.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvChqBook.FullRowSelect = True
        Me.lvChqBook.GridLines = True
        Me.lvChqBook.Location = New System.Drawing.Point(8, 224)
        Me.lvChqBook.Name = "lvChqBook"
        Me.lvChqBook.Size = New System.Drawing.Size(592, 232)
        Me.lvChqBook.TabIndex = 37
        Me.lvChqBook.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sl No"
        Me.ColumnHeader1.Width = 48
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Book No"
        Me.ColumnHeader2.Width = 89
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Issue Date"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Starting Leaf No"
        Me.ColumnHeader3.Width = 107
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Ending Leaf No"
        Me.ColumnHeader4.Width = 62
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Status"
        Me.ColumnHeader5.Width = 59
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Reference Number"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmbAccountNo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtMiscCharges)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.dtpIssueDate)
        Me.Panel1.Controls.Add(Me.txtNoOfleafs)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtBookName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtStartNo)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(592, 168)
        Me.Panel1.TabIndex = 0
        '
        'cmbAccountNo
        '
        Me.cmbAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccountNo.Location = New System.Drawing.Point(128, 16)
        Me.cmbAccountNo.Name = "cmbAccountNo"
        Me.cmbAccountNo.Size = New System.Drawing.Size(128, 24)
        Me.cmbAccountNo.TabIndex = 0
        Me.cmbAccountNo.Text = "SB"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 19)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "Misc Receipts : "
        '
        'txtMiscCharges
        '
        Me.txtMiscCharges.AlphaNumeric = True
        Me.txtMiscCharges.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.txtMiscCharges.BlankSpace = False
        Me.txtMiscCharges.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiscCharges.GotFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.txtMiscCharges.Location = New System.Drawing.Point(128, 136)
        Me.txtMiscCharges.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMiscCharges.Mandatory = False
        Me.txtMiscCharges.Name = "txtMiscCharges"
        Me.txtMiscCharges.ReadOnly = True
        Me.txtMiscCharges.Size = New System.Drawing.Size(128, 23)
        Me.txtMiscCharges.SpecialChar = False
        Me.txtMiscCharges.TabIndex = 125
        Me.txtMiscCharges.TabStop = False
        Me.txtMiscCharges.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(304, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 19)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "Date :"
        '
        'dtpIssueDate
        '
        Me.dtpIssueDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpIssueDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpIssueDate.Location = New System.Drawing.Point(360, 52)
        Me.dtpIssueDate.Name = "dtpIssueDate"
        Me.dtpIssueDate.Size = New System.Drawing.Size(128, 23)
        Me.dtpIssueDate.TabIndex = 4
        Me.dtpIssueDate.TabStop = False
        '
        'txtNoOfleafs
        '
        Me.txtNoOfleafs.AfterDecimal = 0
        Me.txtNoOfleafs.BackColor = System.Drawing.Color.White
        Me.txtNoOfleafs.BeforeDecimal = 3
        Me.txtNoOfleafs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoOfleafs.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfleafs.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNoOfleafs.Location = New System.Drawing.Point(464, 96)
        Me.txtNoOfleafs.LostFocusColour = System.Drawing.Color.White
        Me.txtNoOfleafs.MaxValue = 100
        Me.txtNoOfleafs.MinValue = 0
        Me.txtNoOfleafs.Name = "txtNoOfleafs"
        Me.txtNoOfleafs.Size = New System.Drawing.Size(56, 23)
        Me.txtNoOfleafs.TabIndex = 6
        Me.txtNoOfleafs.Text = ""
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
        Me.btnSearch.Location = New System.Drawing.Point(264, 14)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 19)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Account No. :"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.AutoSize = False
        Me.txtName.BlankSpace = False
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(360, 16)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 35
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 20)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 2
        Me.txtName.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(304, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Book No. :"
        '
        'txtBookName
        '
        Me.txtBookName.AlphaNumeric = True
        Me.txtBookName.BlankSpace = False
        Me.txtBookName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBookName.Location = New System.Drawing.Point(128, 56)
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
        Me.Label4.Location = New System.Drawing.Point(8, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 19)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Start  Leaf No. :"
        '
        'txtStartNo
        '
        Me.txtStartNo.AfterDecimal = 0
        Me.txtStartNo.BackColor = System.Drawing.Color.White
        Me.txtStartNo.BeforeDecimal = 7
        Me.txtStartNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtStartNo.Location = New System.Drawing.Point(128, 96)
        Me.txtStartNo.LostFocusColour = System.Drawing.Color.White
        Me.txtStartNo.MaxLength = 10
        Me.txtStartNo.MaxValue = 0
        Me.txtStartNo.MinValue = 0
        Me.txtStartNo.Name = "txtStartNo"
        Me.txtStartNo.Size = New System.Drawing.Size(128, 23)
        Me.txtStartNo.TabIndex = 5
        Me.txtStartNo.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(304, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 19)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "No. of  Cheque Leaf's :"
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
        Me.btnOk.Location = New System.Drawing.Point(416, 184)
        Me.btnOk.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(80, 32)
        Me.btnOk.TabIndex = 7
        Me.btnOk.Text = "&OK"
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
        Me.btnCancel.Location = New System.Drawing.Point(496, 184)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 32)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "&Cancel"
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 0
        Me.txtReceiptNo.BeforeDecimal = 7
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(136, 192)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReceiptNo.MaxValue = 0
        Me.txtReceiptNo.MinValue = 0
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(128, 23)
        Me.txtReceiptNo.TabIndex = 6
        Me.txtReceiptNo.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 19)
        Me.Label8.TabIndex = 130
        Me.Label8.Text = "Reference No. :"
        '
        'frmSBChequeBookIssue
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(606, 467)
        Me.Controls.Add(Me.txtReceiptNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lvChqBook)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSBChequeBookIssue"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheque Book Issue"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmSBChequeBookIssue
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmSBChequeBookIssue
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmSBChequeBookIssue
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmSBChequeBookIssue)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Events "

    Private Sub frmChequeBookIssue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpIssueDate.Value = Date.Now
        dtpIssueDate.MaxDate = Date.Now
        LoadAccount()
        If strSbno <> String.Empty Then
            cmbAccountNo.Text = strSbno
            sbLoadSBAccDetails()
            sbLoadChkBookDetails()
        End If
    End Sub

    '
    ' Save Cheque Details Data 
    '

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()

            If fnCheck() Then
                If objSBAccount.fnSBCheckChequeBook(Trim(txtBookName.Text)) Then
                    MsgBox("This chequebook already isuued", MsgBoxStyle.Information, "SB Module")
                Else
                    If fnSetData() Then
                        objSBAccount.fnGetSBAccountDetails(cmbAccountNo.Text)
                        If objSBAccount.SBAccTable.Rows(0).Item("AvailBalance") < Val(objDTMaster.Rows(0).Item("SBMinAmountforCheque")) Then
                            If MsgBox("Available balance is less than minimum amount for cheque issue,still do you want to issue chequ book? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Issue") = MsgBoxResult.Yes Then

                                If fnSaveData(objTrans) Then
                                    fnLogEntry(pbUserId, "Cheque book issue by  " & cmbAccountNo.Text & " Amount " & Val(txtMiscCharges.Text), Date.Now, "Cheque book issue", objTrans)
                                    objTrans.Commit()
                                    sbLoadChkBookDetails()
                                End If
                            Else
                                MsgBox("ChequeBook issue denied due to less balance", MsgBoxStyle.Information, " SB Module")
                            End If
                        Else
                            If fnSaveData(objTrans) Then
                                fnLogEntry(pbUserId, "Cheque book issue by  " & cmbAccountNo.Text & " Amount " & Val(txtMiscCharges.Text), Date.Now, "Cheque book issue", objTrans)
                                objTrans.Commit()
                                sbLoadChkBookDetails()
                            End If
                        End If

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtAccNo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sbLoadSBAccDetails()
        sbLoadChkBookDetails()
    End Sub

    Private Sub txtNoOfleafs_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoOfleafs.TextChanged
        txtMiscCharges.Text = Val(dblAmountPerCheque) * Val(txtNoOfleafs.Text)
    End Sub

#End Region

#Region "Functions"

    '
    ' Validate Controls
    '

    Function fnCheck() As Boolean
        If Trim(cmbAccountNo.Text) = String.Empty Then
            MsgBox("Enter account no", MsgBoxStyle.Exclamation)
            cmbAccountNo.Focus()
            Return False
        ElseIf Trim(txtBookName.Text) = String.Empty Then
            MsgBox("Enter book number", MsgBoxStyle.Exclamation)
            txtBookName.Focus()
            Return False
        ElseIf Trim(txtStartNo.Text) = String.Empty Then
            MsgBox("Enter starting leaf no", MsgBoxStyle.Exclamation)
            txtStartNo.Focus()
            Return False
        ElseIf Trim(txtNoOfleafs.Text) = String.Empty Then
            MsgBox("Check number of leaf per cheque book in  SB master setting")
            txtNoOfleafs.Focus()
            Return False
            'ElseIf Trim(txtReceiptNo.Text) = String.Empty Then
            '    MsgBox("Enter receipt number")
            '    txtReceiptNo.Focus()
            '    Return False
        Else
            Return True
        End If
    End Function

    '
    ' Set Data To the property
    '

    Function fnSetData() As Boolean
        objSBAccount.SBNo = Trim(cmbAccountNo.Text)
        objSBAccount.BookNo = Trim(txtBookName.Text)
        objSBAccount.ChkStartNo = Val(txtStartNo.Text)
        objSBAccount.ChkEndNo = Val(txtStartNo.Text) + Val(txtNoOfleafs.Text) - 1
        objSBAccount.ChkBookDate = Format(dtpIssueDate.Value, "yyyy-MM-dd")
        objSBAccount.ChkStatus = "P"
        objSBAccount.ReciptNo = Trim(txtReceiptNo.Text)
        Return True
    End Function

    Sub fnClear()
        txtBookName.ResetText()
        txtMiscCharges.ResetText()
        txtNoOfleafs.ResetText()
        txtReceiptNo.ResetText()
        txtStartNo.ResetText()
        cmbAccountNo.Text = ""
        cmbAccountNo.Focus()
    End Sub

    Function fnSaveData(ByVal objTrans As IDbTransaction) As Boolean
        If objSBAccount.fnSBInsertCheckBookDetails(objTrans) Then
            fnGenerateVoucher(objTrans)
            fnClear()
            MsgBox("ChequeBook Isuued SucessFully", MsgBoxStyle.Information, "SB Module")
            Return True
        Else
            fnClear()
            MsgBox("ChequeBook Isuue Failed Due to Internal Error", MsgBoxStyle.Information, "SB Module")
            Return False
        End If
    End Function

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpIssueDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        Dim strNarration As String = "Cheque leaf charges by " & cmbAccountNo.Text

        'Transaction Entry
        Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(cmbAccountNo.Text) & "','" & Format(dtpIssueDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & Trim(txtMiscCharges.Text) & "','0','" & Trim(txtMiscCharges.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtMiscCharges.Text) & "','" & Trim(txtReceiptNo.Text) & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(cmbAccountNo.Text) & "' group by Accountno"
        fnExecuteNonQuery(strsql, objTrans)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, cmbAccountNo.Text, txtReceiptNo.Text, dtpIssueDate.Value, txtMiscCharges.Text, "Cheque leaf charges by " & cmbAccountNo.Text, lngSlNo, "Y", objTrans)

        'Debit accounts
        fnVoucherEnterSub(lngVoucherNo, 2, cmbAccountNo.Text, dtpIssueDate.Value, "Cheque Leaf Charges By Account " & cmbAccountNo.Text, "To", 10, Val(txtMiscCharges.Text), 0, 1, "Y", objTrans)

        'Credit accounts 
        fnVoucherEnterSub(lngVoucherNo, 2, cmbAccountNo.Text, dtpIssueDate.Value, "Cheque Leaf Charges By Account " & cmbAccountNo.Text, "By", 13, 0, Val(txtMiscCharges.Text), 2, "Y", objTrans)
        Return True

    End Function


#End Region


#Region "Sub Routines"

    Sub sbLoadSBAccDetails()
        Dim objDT As DataTable
        If objSBAccount.fnGetMasterSetting Then
            objDTMaster = objSBAccount.SBMasterTable
            dblAmountPerCheque = objDTMaster.Rows(0).Item("SBAmountPerCheque")
        Else
            MsgBox("Check SB master setting", MsgBoxStyle.Information)
            Return
        End If
        If objSBAccount.fnGetSBAccountDetails(cmbAccountNo.Text) Then
            objDT = objSBAccount.SBAccTable
            'Sb Details
            ' cmbAccountNo.Text = objDT.Rows(0).Item("AccountNo")
            txtName.Text = objDT.Rows(0).Item("Name")
            dblAvailBal = objDT.Rows(0).Item("AvailBalance")
            txtName.Focus()
        End If
    End Sub

    '
    ' Load Cheque Book Deatils
    '

    Sub sbLoadChkBookDetails()
        If fnSetData() Then
            If objSBAccount.fnGetSBCheckBookDetails() And objSBAccount.SBCheckBookBookTable.Rows.Count > 0 Then
                Dim intCnt As Integer
                Dim lvItem As ListViewItem
                lvChqBook.Items.Clear()
                For intCnt = 0 To objSBAccount.SBCheckBookBookTable.Rows.Count - 1
                    lvItem = lvChqBook.Items.Add(intCnt + 1)
                    lvItem.SubItems.Add(objSBAccount.SBCheckBookBookTable.Rows(intCnt).Item("Book_SNo"))
                    lvItem.SubItems.Add(Format(objSBAccount.SBCheckBookBookTable.Rows(intCnt).Item("IssuedDate"), "dd-MMM-yyyy"))
                    lvItem.SubItems.Add(objSBAccount.SBCheckBookBookTable.Rows(intCnt).Item("StartNo"))
                    lvItem.SubItems.Add(objSBAccount.SBCheckBookBookTable.Rows(intCnt).Item("EndNo"))
                    lvItem.SubItems.Add(objSBAccount.SBCheckBookBookTable.Rows(intCnt).Item("Status"))
                    lvItem.SubItems.Add(objSBAccount.SBCheckBookBookTable.Rows(intCnt).Item("ReciptNo"))
                Next
            End If
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbAccountNo.KeyPress
        cmbAccountNo.DroppedDown = True
        AutoComplete(cmbAccountNo, e)
    End Sub

    Public Sub AutoComplete(ByRef cb As ComboBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim strFindStr As String

        If e.KeyChar = Chr(8) Then 'Backspace
            If cb.SelectionStart <= 1 Then
                cb.Text = ""
                Exit Sub
            End If
            If cb.SelectionLength = 0 Then
                strFindStr = cb.Text.Substring(0, cb.Text.Length - 1)
            Else
                strFindStr = cb.Text.Substring(0, cb.SelectionStart - 1)
            End If
        Else
            If cb.SelectionLength = 0 Then
                strFindStr = cb.Text & e.KeyChar
            Else
                strFindStr = cb.Text.Substring(0, cb.SelectionStart) & e.KeyChar
            End If
        End If

        Dim intIdx As Integer = -1

        ' Search the string in the Combo Box List.
        intIdx = cb.FindString(strFindStr)

        If intIdx <> -1 Then ' String found in the List.
            cb.SelectedIndex = intIdx
            cb.SelectionStart = strFindStr.Length
            cb.SelectionLength = cb.Text.Length
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub ComboBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAccountNo.Leave
        If Trim(cmbAccountNo.Text <> String.Empty) Then
            strSbno = cmbAccountNo.Text
            sbLoadSBAccDetails()
            sbLoadChkBookDetails()
        End If
    End Sub

    Private Sub cmbAccountNo_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAccountNo.GotFocus
        cmbAccountNo.Text = ""
    End Sub

    Sub LoadAccount()
        Dim objDT As DataTable
        If objSBAccount.fnGetSBAccountTable Then
            objDT = objSBAccount.SBAccTable
            cmbAccountNo.DataSource = objSBAccount.SBAccTable
            cmbAccountNo.DisplayMember = "AccountNo"
            cmbAccountNo.ValueMember = "AccountNo"
            cmbAccountNo.SelectedIndex = -1
        End If

    End Sub



#End Region




End Class
