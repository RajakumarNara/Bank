Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmCAStmt
    Inherits System.Windows.Forms.Form
    Private Shared m_FormDefInstance As frmCAStmt
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As frmCAStmt
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmCAStmt
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmCAStmt)
            m_FormDefInstance = Value
        End Set
    End Property


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
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPrint As BankControls.NewButton
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvStmtOfAcc As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DTPFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTPTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAccno As BankControls.TextControl
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCAStmt))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSearch = New BankControls.NewButton
        Me.btnPrint = New BankControls.NewButton
        Me.lvStmtOfAcc = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.txtName = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DTPFrom = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.DTPTo = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAccno = New BankControls.TextControl
        Me.btnCancel = New BankControls.NewButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.lvStmtOfAcc)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.txtAccno)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 424)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
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
        Me.btnSearch.Location = New System.Drawing.Point(264, 12)
        Me.btnSearch.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(388, 376)
        Me.btnPrint.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(120, 40)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "&Print"
        '
        'lvStmtOfAcc
        '
        Me.lvStmtOfAcc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvStmtOfAcc.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader7, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvStmtOfAcc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvStmtOfAcc.FullRowSelect = True
        Me.lvStmtOfAcc.GridLines = True
        Me.lvStmtOfAcc.Location = New System.Drawing.Point(8, 120)
        Me.lvStmtOfAcc.Name = "lvStmtOfAcc"
        Me.lvStmtOfAcc.Size = New System.Drawing.Size(680, 248)
        Me.lvStmtOfAcc.TabIndex = 7
        Me.lvStmtOfAcc.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Date"
        Me.ColumnHeader1.Width = 81
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Particulars"
        Me.ColumnHeader2.Width = 186
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Cheque Number"
        Me.ColumnHeader7.Width = 75
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Deposit"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 81
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Withdraw"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 83
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Balance"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 81
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Intrest"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 74
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.AutoSize = False
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(396, 16)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(212, 20)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 3
        Me.txtName.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(348, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 19)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Name"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DTPFrom)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DTPTo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(8, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 72)
        Me.Panel1.TabIndex = 4
        '
        'DTPFrom
        '
        Me.DTPFrom.CustomFormat = "dd-MMM-yyyy"
        Me.DTPFrom.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFrom.Location = New System.Drawing.Point(80, 41)
        Me.DTPFrom.Name = "DTPFrom"
        Me.DTPFrom.Size = New System.Drawing.Size(152, 22)
        Me.DTPFrom.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(336, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 18)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "To"
        '
        'DTPTo
        '
        Me.DTPTo.CustomFormat = "dd-MMM-yyyy"
        Me.DTPTo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTo.Location = New System.Drawing.Point(368, 41)
        Me.DTPTo.Name = "DTPTo"
        Me.DTPTo.Size = New System.Drawing.Size(168, 23)
        Me.DTPTo.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 18)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "From"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 18)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "Displaying Transactions"
        '
        'txtAccno
        '
        Me.txtAccno.AlphaNumeric = False
        Me.txtAccno.BackColor = System.Drawing.Color.White
        Me.txtAccno.BlankSpace = False
        Me.txtAccno.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccno.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccno.Location = New System.Drawing.Point(104, 12)
        Me.txtAccno.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAccno.Mandatory = False
        Me.txtAccno.Name = "txtAccno"
        Me.txtAccno.ReadOnly = True
        Me.txtAccno.Size = New System.Drawing.Size(152, 23)
        Me.txtAccno.SpecialChar = False
        Me.txtAccno.TabIndex = 1
        Me.txtAccno.Text = ""
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(516, 376)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 40)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "&Cancel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 19)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "Account No."
        '
        'frmCAStmt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(710, 427)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCAStmt"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Current Account Statement"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Form Global Variables"
    Dim objCAccount As New clsCurrentAccount
#End Region


#Region "Sub Routines"

    Sub CALoadTransactions()
        If Trim(txtAccno.Text) <> String.Empty Then
            objCAccount.CurAccountNo = Trim(txtAccno.Text)
            If objCAccount.fnGetTransactionDetails(DTPFrom.Value, DTPTo.Value) = True Then
                lvStmtOfAcc.Items.Clear()
                Dim lvItem As ListViewItem
                For intCnt As Integer = 0 To objCAccount.CATransDetailTable.Rows.Count - 1
                    lvItem = lvStmtOfAcc.Items.Add(Format(objCAccount.CATransDetailTable.Rows(intCnt).Item("TrDate"), "dd-MMM-yyyy"))
                    lvItem.SubItems.Add(objCAccount.CATransDetailTable.Rows(intCnt).Item("Narration"))
                    lvItem.SubItems.Add(objCAccount.CATransDetailTable.Rows(intCnt).Item("ChequeNo"))
                    lvItem.SubItems.Add(objCAccount.CATransDetailTable.Rows(intCnt).Item("Deposit"))
                    lvItem.SubItems.Add(objCAccount.CATransDetailTable.Rows(intCnt).Item("WithDraw"))
                    lvItem.SubItems.Add(IIf(IsDBNull(objCAccount.CATransDetailTable.Rows(intCnt).Item("PostBal")) = True, " ", objCAccount.CATransDetailTable.Rows(intCnt).Item("PostBal")))
                    lvItem.SubItems.Add(objCAccount.CATransDetailTable.Rows(intCnt).Item("Interest"))
                Next
            End If
        End If
    End Sub
#End Region


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim objCASearch As New frmCAccSearch
        objCASearch.strCAccountNo = String.Empty
        objCASearch.ShowDialog(Me)
        If objCASearch.strCAccountNo <> String.Empty Then
            txtAccno.Text = objCASearch.strCAccountNo
            txtName.Text = objCASearch.lvCAAccs.SelectedItems(0).SubItems(1).Text
        End If
        objCASearch.Dispose()
        CALoadTransactions()
    End Sub

    Private Sub frmCAStmt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DTPTo.MaxDate = Date.Today
        ' DTPFrom.Value = Date.Now
        'DTPTo.Value = Date.Now


        DTPFrom.Value = DateAdd(DateInterval.Day, -(Date.Now.Day - 1), Date.Now)

        CALoadTransactions()
    End Sub


    Private Sub DTPFrom_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTPFrom.ValueChanged, DTPTo.ValueChanged
        CALoadTransactions()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Dim objReportViewer As New frmReportViewer

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim objReportViewer As New frmReportViewer
        Dim cryRpt As New ReportDocument
        cryRpt.Load(Application.StartupPath & "../Reports/CAStmt.rpt")
        '-----functionality for Parameter passing---myDiscrete
        Dim CAcctNo As New ParameterDiscreteValue
        Dim FrmDt As New ParameterDiscreteValue
        Dim ToDate As New ParameterDiscreteValue

        CAcctNo.Value = Convert.ToString(txtAccno.Text)
        cryRpt.SetParameterValue("CAccountNo", CAcctNo)

        FrmDt.Value = Convert.ToString(DTPFrom.Text)
        cryRpt.SetParameterValue("FromDt", FrmDt)

        ToDate.Value = Convert.ToString(DTPTo.Text)
        cryRpt.SetParameterValue("ToDt", ToDate)
        objReportViewer.Show()
        objReportViewer.CrystalReportViewer1.ReportSource = cryRpt

    End Sub
End Class
