Public Class frmPigmyTransaction
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents lvDeposit As System.Windows.Forms.ListView
    Friend WithEvents txtPGNo As BankControls.TextControl
    Friend WithEvents btnPrint As BankControls.NewButton
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPigmyTransaction))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSearch = New BankControls.NewButton
        Me.txtName = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPGNo = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lvDeposit = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.btnClose = New BankControls.NewButton
        Me.btnPrint = New BankControls.NewButton
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtPGNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(644, 422)
        Me.Panel1.TabIndex = 74
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.Beige
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(280, 16)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 86
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.AutoSize = False
        Me.txtName.BlankSpace = False
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(384, 16)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(160, 24)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 76
        Me.txtName.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(320, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Name :"
        '
        'txtPGNo
        '
        Me.txtPGNo.AlphaNumeric = True
        Me.txtPGNo.BackColor = System.Drawing.Color.White
        Me.txtPGNo.BlankSpace = True
        Me.txtPGNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPGNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPGNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPGNo.Location = New System.Drawing.Point(112, 16)
        Me.txtPGNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtPGNo.Mandatory = False
        Me.txtPGNo.Name = "txtPGNo"
        Me.txtPGNo.ReadOnly = True
        Me.txtPGNo.Size = New System.Drawing.Size(160, 23)
        Me.txtPGNo.SpecialChar = True
        Me.txtPGNo.TabIndex = 74
        Me.txtPGNo.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 19)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "BNN AccNo. :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lvDeposit)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 352)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deposit Amount Details"
        '
        'lvDeposit
        '
        Me.lvDeposit.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDeposit.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lvDeposit.FullRowSelect = True
        Me.lvDeposit.GridLines = True
        Me.lvDeposit.Location = New System.Drawing.Point(8, 32)
        Me.lvDeposit.Name = "lvDeposit"
        Me.lvDeposit.Size = New System.Drawing.Size(600, 304)
        Me.lvDeposit.TabIndex = 0
        Me.lvDeposit.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date"
        Me.ColumnHeader2.Width = 65
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "BNNC Deposit"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader1.Width = 86
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "BNNC Withdraw"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 93
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "BNNC Balance"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 87
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "BNND Deposit"
        Me.ColumnHeader5.Width = 85
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "BNND Withdraw"
        Me.ColumnHeader6.Width = 82
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "BNND Balance"
        Me.ColumnHeader7.Width = 78
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.GotFocusColour = System.Drawing.Color.Beige
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(552, 456)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(96, 40)
        Me.btnClose.TabIndex = 75
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
        Me.btnPrint.Location = New System.Drawing.Point(16, 456)
        Me.btnPrint.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(88, 40)
        Me.btnPrint.TabIndex = 101
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmPigmyTransaction
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(224, Byte), CType(182, Byte))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(672, 501)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPigmyTransaction"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BNN Transaction"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"

    Dim objPigmyAcc As New clsPigmyAccount
    Public strAccNo As String
    Public strName As String

#End Region

#Region "Function"

    Public Function fnGetDepTran() As Boolean

        Dim lvItems As ListViewItem
        Dim intCount As Integer
        If objPigmyAcc.fnGetDepTransDet(strAccNo) Then
            While intCount < objPigmyAcc.PigmyDepTransTable.Rows.Count
                lvItems = lvDeposit.Items.Add(Format(objPigmyAcc.PigmyDepTransTable.Rows(intCount).Item("TrDate"), "yyyy-MM-dd"))
                lvItems.SubItems.Add(objPigmyAcc.PigmyDepTransTable.Rows(intCount).Item("Deposit"))
                lvItems.SubItems.Add(objPigmyAcc.PigmyDepTransTable.Rows(intCount).Item("WithDraw"))
                lvItems.SubItems.Add(objPigmyAcc.PigmyDepTransTable.Rows(intCount).Item("Postbalance"))
                lvItems.SubItems.Add(objPigmyAcc.PigmyDepTransTable.Rows(intCount).Item("DDeposit"))
                lvItems.SubItems.Add(objPigmyAcc.PigmyDepTransTable.Rows(intCount).Item("DWithDraw"))
                lvItems.SubItems.Add(objPigmyAcc.PigmyDepTransTable.Rows(intCount).Item("DPostbalance"))

                'If IsDBNull(objPigmyAcc.PigmyDepTransTable.Rows(intCount).Item("Postbalance")) = True Then
                '    lvItems.SubItems.Add(0)
                'Else
                '    lvItems.SubItems.Add(objPigmyAcc.PigmyDepTransTable.Rows(intCount).Item("Postbalance"))
                'End If
                intCount += 1
            End While
        End If

    End Function

    'Public Function fnGetWitTran() As Boolean

    '    Dim lvItems As ListViewItem
    '    Dim intCount As Integer
    '    If objPigmyAcc.fnGetWitTransDet(strAccNo) Then
    '        While intCount < objPigmyAcc.PigmyWithTransTable.Rows.Count
    '            lvItems = lvWithDraw.Items.Add(Format(objPigmyAcc.PigmyWithTransTable.Rows(intCount).Item("TrDate"), "yyyy-MM-dd"))
    '            lvItems.SubItems.Add(objPigmyAcc.PigmyWithTransTable.Rows(intCount).Item("WithDraw"))
    '            If IsDBNull(objPigmyAcc.PigmyWithTransTable.Rows(intCount).Item("PostBalance")) = True Then
    '                lvItems.SubItems.Add(0)
    '            Else
    '                lvItems.SubItems.Add(objPigmyAcc.PigmyWithTransTable.Rows(intCount).Item("PostBalance"))
    '            End If
    '            intCount += 1
    '        End While
    '    End If

    'End Function

#End Region

    Private Sub frmPigmyTransaction_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtPGNo.Text = strAccNo
        txtName.Text = strName
        fnGetDepTran()
        'fnGetWitTran()

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim objfrmCust As New frmPGCust
        txtPGNo.Text = objfrmCust.strPGNo
        txtName.Text = objfrmCust.strPGName
        objfrmCust.ShowDialog()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

   
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Dim objReportView As New frmReportViewer
        objReportView.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/PigmyTransaction.rpt"
        objReportView.CrystalReportViewer1.SelectionFormula = "{pigmytransactiontbl.AccountNo} = '" & txtPGNo.Text & "'"
        objReportView.ShowDialog()
        objReportView.Dispose()

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
