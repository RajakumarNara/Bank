Public Class frmRDTransaction
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents lvWithDraw As System.Windows.Forms.ListView
    Friend WithEvents lvDeposit As System.Windows.Forms.ListView
    Friend WithEvents txtRDNo As BankControls.TextControl
    Friend WithEvents btnPrint As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRDTransaction))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSearch = New BankControls.NewButton
        Me.txtName = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRDNo = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lvWithDraw = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lvDeposit = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.btnClose = New BankControls.NewButton
        Me.btnPrint = New BankControls.NewButton
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtRDNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 440)
        Me.Panel1.TabIndex = 74
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.Beige
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(280, 16)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.AutoSize = False
        Me.txtName.BlankSpace = False
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(432, 16)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(160, 24)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 4
        Me.txtName.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(360, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 19)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Name:"
        '
        'txtRDNo
        '
        Me.txtRDNo.AlphaNumeric = True
        Me.txtRDNo.BackColor = System.Drawing.Color.White
        Me.txtRDNo.BlankSpace = True
        Me.txtRDNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRDNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRDNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRDNo.Location = New System.Drawing.Point(112, 16)
        Me.txtRDNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtRDNo.Mandatory = False
        Me.txtRDNo.Name = "txtRDNo"
        Me.txtRDNo.ReadOnly = True
        Me.txtRDNo.Size = New System.Drawing.Size(160, 23)
        Me.txtRDNo.SpecialChar = True
        Me.txtRDNo.TabIndex = 1
        Me.txtRDNo.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "RDAccNo. :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lvWithDraw)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(352, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 376)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "WithDraw Amount Details"
        '
        'lvWithDraw
        '
        Me.lvWithDraw.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvWithDraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvWithDraw.FullRowSelect = True
        Me.lvWithDraw.GridLines = True
        Me.lvWithDraw.Location = New System.Drawing.Point(8, 32)
        Me.lvWithDraw.Name = "lvWithDraw"
        Me.lvWithDraw.Size = New System.Drawing.Size(304, 328)
        Me.lvWithDraw.TabIndex = 6
        Me.lvWithDraw.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "TrDate"
        Me.ColumnHeader4.Width = 91
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "WithDraw"
        Me.ColumnHeader5.Width = 91
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Balance"
        Me.ColumnHeader6.Width = 99
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lvDeposit)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 376)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deposit Amount Details"
        '
        'lvDeposit
        '
        Me.lvDeposit.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader1, Me.ColumnHeader3})
        Me.lvDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDeposit.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lvDeposit.FullRowSelect = True
        Me.lvDeposit.GridLines = True
        Me.lvDeposit.Location = New System.Drawing.Point(8, 32)
        Me.lvDeposit.Name = "lvDeposit"
        Me.lvDeposit.Size = New System.Drawing.Size(288, 328)
        Me.lvDeposit.TabIndex = 5
        Me.lvDeposit.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "TrDate"
        Me.ColumnHeader2.Width = 77
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Deposit Amount"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Balance"
        Me.ColumnHeader3.Width = 100
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.GotFocusColour = System.Drawing.Color.Beige
        Me.btnClose.Location = New System.Drawing.Point(584, 480)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(96, 40)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(24, 480)
        Me.btnPrint.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(120, 40)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "Print"
        '
        'frmRDTransaction
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(712, 525)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRDTransaction"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RD Transaction"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"

    Dim objRDAcc As New clsRDAccount
    Public strAccNo As String
    Public strName As String

#End Region

#Region "Function"

    Public Function fnGetDepTran() As Boolean
        Dim lvItems As ListViewItem
        Dim intCount As Integer

        If objRDAcc.fnGetDepTrans(txtRDNo.Text) Then
            While intCount < objRDAcc.DepositTable.Rows.Count
                lvItems = lvDeposit.Items.Add(Format(objRDAcc.DepositTable.Rows(intCount).Item("TrDate"), "yyyy-MM-dd"))
                lvItems.SubItems.Add(objRDAcc.DepositTable.Rows(intCount).Item("Deposit"))
                lvItems.SubItems.Add(objRDAcc.DepositTable.Rows(intCount).Item("PostBalance"))
                intCount += 1

            End While
            Return True
        End If

    End Function

    Public Function fnGetWitTran() As Boolean
        Dim lvItems As ListViewItem
        Dim intCount As Integer

        If objRDAcc.fnGetWithTrans(txtRDNo.Text) Then
            While intCount < objRDAcc.WithDrawTable.Rows.Count
                lvItems = lvWithDraw.Items.Add(Format(objRDAcc.WithDrawTable.Rows(intCount).Item("TrDate"), "yyyy-MM-dd"))
                lvItems.SubItems.Add(objRDAcc.WithDrawTable.Rows(intCount).Item("WithDraw"))
                lvItems.SubItems.Add(objRDAcc.WithDrawTable.Rows(intCount).Item("PostBalance"))
                intCount += 1
            End While
        End If

    End Function

#End Region

#Region "Events"

    Private Sub frmPigmyTransaction_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtRDNo.Text = strAccNo
        txtName.Text = strName
        If fnGetDepTran() Then
            fnGetWitTran()
        End If

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim objRDCust As New frmRDCust
        objRDCust.ShowDialog()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If fnGetDepTran() Then
            fnGetWitTran()
        End If
    End Sub

#End Region

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Dim objReportViewer As New frmReportViewer
        Dim strAccountNo As String
        strAccountNo = txtRDNo.Text
        objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/RDTransaction.rpt"
        objReportViewer.CrystalReportViewer1.SelectionFormula = "{rdtransactiontbl.AccountNo} = '" & txtRDNo.Text & "'"
        objReportViewer.ShowDialog()
        objReportViewer.Dispose()

    End Sub

End Class
