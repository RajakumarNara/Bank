Public Class FrmLoanList
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents lvSeachList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtpSearchDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents bntTransaction As BankControls.NewButton
    Friend WithEvents btnDisbursment As BankControls.NewButton
    Friend WithEvents btnLog As BankControls.NewButton
    Friend WithEvents lblLoanNo As System.Windows.Forms.Label
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents btnGenerateReports As BankControls.NewButton
    Friend WithEvents txtNameSearch As BankControls.TextControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmLoanList))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnLog = New BankControls.NewButton
        Me.btnDisbursment = New BankControls.NewButton
        Me.bntTransaction = New BankControls.NewButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblLoanNo = New System.Windows.Forms.Label
        Me.dtpSearchDate = New System.Windows.Forms.DateTimePicker
        Me.btnCancel = New BankControls.NewButton
        Me.lvSeachList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.cmbSearchBy = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAmount = New BankControls.NumericControl
        Me.btnGenerateReports = New BankControls.NewButton
        Me.txtNameSearch = New BankControls.TextControl
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnLog)
        Me.Panel1.Controls.Add(Me.btnDisbursment)
        Me.Panel1.Controls.Add(Me.bntTransaction)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(208, 480)
        Me.Panel1.TabIndex = 40
        '
        'btnLog
        '
        Me.btnLog.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(225, Byte), CType(223, Byte))
        Me.btnLog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLog.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLog.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog.ForeColor = System.Drawing.Color.Black
        Me.btnLog.GotFocusColour = System.Drawing.Color.FromArgb(CType(208, Byte), CType(152, Byte), CType(125, Byte))
        Me.btnLog.Location = New System.Drawing.Point(16, 272)
        Me.btnLog.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(225, Byte), CType(223, Byte))
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(176, 40)
        Me.btnLog.TabIndex = 6
        Me.btnLog.Text = "&View Log "
        Me.btnLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDisbursment
        '
        Me.btnDisbursment.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(225, Byte), CType(223, Byte))
        Me.btnDisbursment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDisbursment.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDisbursment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDisbursment.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisbursment.ForeColor = System.Drawing.Color.Black
        Me.btnDisbursment.GotFocusColour = System.Drawing.Color.FromArgb(CType(208, Byte), CType(152, Byte), CType(125, Byte))
        Me.btnDisbursment.Location = New System.Drawing.Point(16, 144)
        Me.btnDisbursment.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(225, Byte), CType(223, Byte))
        Me.btnDisbursment.Name = "btnDisbursment"
        Me.btnDisbursment.Size = New System.Drawing.Size(176, 40)
        Me.btnDisbursment.TabIndex = 4
        Me.btnDisbursment.Text = "&View Disbursment"
        Me.btnDisbursment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bntTransaction
        '
        Me.bntTransaction.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(225, Byte), CType(223, Byte))
        Me.bntTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntTransaction.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bntTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bntTransaction.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntTransaction.ForeColor = System.Drawing.Color.Black
        Me.bntTransaction.GotFocusColour = System.Drawing.Color.FromArgb(CType(208, Byte), CType(152, Byte), CType(125, Byte))
        Me.bntTransaction.Location = New System.Drawing.Point(16, 208)
        Me.bntTransaction.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(225, Byte), CType(223, Byte))
        Me.bntTransaction.Name = "bntTransaction"
        Me.bntTransaction.Size = New System.Drawing.Size(176, 40)
        Me.bntTransaction.TabIndex = 5
        Me.bntTransaction.Text = "&Transaction"
        Me.bntTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblLoanNo)
        Me.Panel2.Controls.Add(Me.dtpSearchDate)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.lvSeachList)
        Me.Panel2.Controls.Add(Me.cmbSearchBy)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtAmount)
        Me.Panel2.Controls.Add(Me.btnGenerateReports)
        Me.Panel2.Controls.Add(Me.txtNameSearch)
        Me.Panel2.Location = New System.Drawing.Point(224, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(544, 480)
        Me.Panel2.TabIndex = 41
        '
        'lblLoanNo
        '
        Me.lblLoanNo.AutoSize = True
        Me.lblLoanNo.Location = New System.Drawing.Point(32, 448)
        Me.lblLoanNo.Name = "lblLoanNo"
        Me.lblLoanNo.Size = New System.Drawing.Size(0, 16)
        Me.lblLoanNo.TabIndex = 47
        Me.lblLoanNo.Visible = False
        '
        'dtpSearchDate
        '
        Me.dtpSearchDate.CustomFormat = "dd-MM-yyyy"
        Me.dtpSearchDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSearchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSearchDate.Location = New System.Drawing.Point(360, 16)
        Me.dtpSearchDate.Name = "dtpSearchDate"
        Me.dtpSearchDate.Size = New System.Drawing.Size(168, 23)
        Me.dtpSearchDate.TabIndex = 2
        Me.dtpSearchDate.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(225, Byte), CType(223, Byte))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(208, Byte), CType(152, Byte), CType(125, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(440, 432)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(225, Byte), CType(223, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 40)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "&Cancel"
        '
        'lvSeachList
        '
        Me.lvSeachList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader6, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvSeachList.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSeachList.FullRowSelect = True
        Me.lvSeachList.GridLines = True
        Me.lvSeachList.Location = New System.Drawing.Point(16, 56)
        Me.lvSeachList.MultiSelect = False
        Me.lvSeachList.Name = "lvSeachList"
        Me.lvSeachList.Size = New System.Drawing.Size(512, 368)
        Me.lvSeachList.TabIndex = 3
        Me.lvSeachList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "LoanNo"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Name"
        Me.ColumnHeader6.Width = 119
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Member No"
        Me.ColumnHeader2.Width = 83
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = " Amount Sanctioned"
        Me.ColumnHeader3.Width = 70
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Due Date"
        Me.ColumnHeader4.Width = 89
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ROI"
        Me.ColumnHeader5.Width = 51
        '
        'cmbSearchBy
        '
        Me.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchBy.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchBy.Items.AddRange(New Object() {"LoanNo", "Name", "MemberNo", "SancAmount", "DueDate", "ROI"})
        Me.cmbSearchBy.Location = New System.Drawing.Point(96, 16)
        Me.cmbSearchBy.Name = "cmbSearchBy"
        Me.cmbSearchBy.Size = New System.Drawing.Size(168, 24)
        Me.cmbSearchBy.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 19)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Search By"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.AutoSize = False
        Me.txtName.BlankSpace = False
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(360, 16)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(168, 20)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 41
        Me.txtName.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Search Text"
        '
        'txtAmount
        '
        Me.txtAmount.AfterDecimal = 2
        Me.txtAmount.BeforeDecimal = 12
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmount.Location = New System.Drawing.Point(360, 16)
        Me.txtAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.MaxValue = 0
        Me.txtAmount.MinValue = 0
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(168, 23)
        Me.txtAmount.TabIndex = 48
        Me.txtAmount.Text = ""
        '
        'btnGenerateReports
        '
        Me.btnGenerateReports.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(225, Byte), CType(223, Byte))
        Me.btnGenerateReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerateReports.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnGenerateReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGenerateReports.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateReports.ForeColor = System.Drawing.Color.Black
        Me.btnGenerateReports.GotFocusColour = System.Drawing.Color.FromArgb(CType(208, Byte), CType(152, Byte), CType(125, Byte))
        Me.btnGenerateReports.Image = CType(resources.GetObject("btnGenerateReports.Image"), System.Drawing.Image)
        Me.btnGenerateReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerateReports.Location = New System.Drawing.Point(16, 432)
        Me.btnGenerateReports.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(225, Byte), CType(223, Byte))
        Me.btnGenerateReports.Name = "btnGenerateReports"
        Me.btnGenerateReports.Size = New System.Drawing.Size(120, 40)
        Me.btnGenerateReports.TabIndex = 7
        Me.btnGenerateReports.Text = "&Generate Report"
        '
        'txtNameSearch
        '
        Me.txtNameSearch.AlphaNumeric = True
        Me.txtNameSearch.AutoSize = False
        Me.txtNameSearch.BlankSpace = False
        Me.txtNameSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameSearch.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNameSearch.Location = New System.Drawing.Point(360, 16)
        Me.txtNameSearch.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNameSearch.Mandatory = False
        Me.txtNameSearch.MaxLength = 30
        Me.txtNameSearch.Name = "txtNameSearch"
        Me.txtNameSearch.Size = New System.Drawing.Size(168, 20)
        Me.txtNameSearch.SpecialChar = True
        Me.txtNameSearch.TabIndex = 41
        Me.txtNameSearch.Text = ""
        Me.txtNameSearch.Visible = False
        '
        'FrmLoanList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(225, Byte), CType(223, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(776, 493)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLoanList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoanList"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"

    Dim objLoanDet As New clsLoanDet
    Dim strFilter As String = "Name like '%'"
    Dim dvLoan As DataView
    Dim strlno As String

#End Region

#Region "Funcitions"

    Public Function fnLoadDetails() As Boolean

        Dim intCount As Integer
        '  Dim lstvItems As New ListViewItem
        Dim lvItems As New ListViewItem
        dvLoan.RowFilter = strFilter
        lvSeachList.Items.Clear()

        While intCount < dvLoan.Count

            lvItems = lvSeachList.Items.Add(dvLoan.Item(intCount).Item("LoanNo"))
            lvItems.SubItems.Add(dvLoan.Item(intCount).Item("Name"))
            lvItems.SubItems.Add(dvLoan.Item(intCount).Item("MemberNo"))
            lvItems.SubItems.Add(dvLoan.Item(intCount).Item("SancAmount"))
            lvItems.SubItems.Add(Format(dvLoan.Item(intCount).Item("DueDate"), "yyyy-MM-dd"))
            lvItems.SubItems.Add(dvLoan.Item(intCount).Item("ROI"))
            intCount += 1

        End While

    End Function

    Public Function fnGetLoan() As Boolean


        Dim objReportViewer As New frmReportViewer
        Dim strLoan As String
        objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/LoanDetails.rpt"

        If strlno = "GL" Then

            objReportViewer.CrystalReportViewer1.SelectionFormula = "{loandetailstbl.LoanNo} Like 'GL*'"
            objReportViewer.ShowDialog()
            objReportViewer.Dispose()

        End If

        If strlno = "VL" Then

            objReportViewer.CrystalReportViewer1.SelectionFormula = "{loandetailstbl.LoanNo} Like 'VL*'"
            objReportViewer.ShowDialog()
            objReportViewer.Dispose()

        End If

        If strlno = "KL" Then
            objReportViewer.CrystalReportViewer1.SelectionFormula = "{loandetailstbl.LoanNo} Like 'KL*'"
            objReportViewer.ShowDialog()
            objReportViewer.Dispose()

        End If

        If strlno = "DL" Then
            objReportViewer.CrystalReportViewer1.SelectionFormula = "{loandetailstbl.LoanNo} Like 'DL*'"
            objReportViewer.ShowDialog()
            objReportViewer.Dispose()

        End If

        If strlno = "ML" Then
            objReportViewer.CrystalReportViewer1.SelectionFormula = "{loandetailstbl.LoanNo} Like 'ML*'"
            objReportViewer.ShowDialog()
            objReportViewer.Dispose()

        End If

        If strlno = "HL" Then
            objReportViewer.CrystalReportViewer1.SelectionFormula = "{loandetailstbl.LoanNo} Like 'HL*'"
            objReportViewer.ShowDialog()
            objReportViewer.Dispose()

        End If

        If strlno = "OD" Then
            objReportViewer.CrystalReportViewer1.SelectionFormula = "{loandetailstbl.LoanNo} Like 'OD*'"
            objReportViewer.ShowDialog()
            objReportViewer.Dispose()

        End If

    End Function


#End Region

    Private Sub FrmLoanList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtAmount.Visible = False
        strlno = Mid(lblLoanNo.Text, 1, 2)
        If objLoanDet.fnGetData(strlno) = True Then
            dvLoan = New DataView(objLoanDet.LoanTable, strFilter, "Name", DataViewRowState.OriginalRows)
            fnLoadDetails()
        End If
        'sbChangeFont(lvSeachList)

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub txtName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

        Select Case cmbSearchBy.SelectedItem
            Case "Name"
                strFilter = "Name like '" & txtName.Text & "%'"
                fnLoadDetails()
            Case "MemberNo"
                strFilter = "MemberNo"
                strFilter = "MemberNo like '" & txtName.Text & "%'"
                fnLoadDetails()
            Case "LoanNo"
                strFilter = "LoanNo"
                strFilter = "LoanNo like'" & txtName.Text & "%'"
                fnLoadDetails()
            Case "SancAmount"
                strFilter = "SancAmount like '" & txtName.Text & "'"
                fnLoadDetails()
            Case "ROI"
                strFilter = "ROI like '" & txtName.Text & "'"
                fnLoadDetails()
            Case "DueDate"
                strFilter = "DueDate like '" & dtpSearchDate.Value & "'"
                fnLoadDetails()
        End Select

    End Sub

    Private Sub cmbSearchBy_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSearchBy.SelectedIndexChanged

        If cmbSearchBy.SelectedItem = "DueDate" Then
            dtpSearchDate.Visible = True
            txtAmount.Visible = False
            txtName.Visible = False
            txtNameSearch.Visible = False

        ElseIf cmbSearchBy.SelectedItem = "SancAmount" Then
            dtpSearchDate.Visible = False
            txtAmount.Visible = True
            txtName.Visible = False
            txtNameSearch.Visible = False

        ElseIf cmbSearchBy.SelectedItem = "ROI" Then
            dtpSearchDate.Visible = False
            txtAmount.Visible = True
            txtName.Visible = False
            txtNameSearch.Visible = False

        ElseIf cmbSearchBy.SelectedItem = "Name" Then
            dtpSearchDate.Visible = False
            txtAmount.Visible = False
            txtName.Visible = False
            txtNameSearch.Visible = True

        ElseIf cmbSearchBy.SelectedItem = "LoanNo" Then
            dtpSearchDate.Visible = False
            txtAmount.Visible = False
            txtName.Visible = True
            txtNameSearch.Visible = False

        End If
    End Sub

    Private Sub dtpSearchDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpSearchDate.TextChanged

        Select Case cmbSearchBy.SelectedItem
            Case "DueDate"
                strFilter = "DueDate = '" & Format(dtpSearchDate.Value, "yyyy-MM-dd") & "'"
                fnLoadDetails()
        End Select

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '    Dim col As DataColumn
        '    For Each col In dvLoan.Table.Columns
        '        If col.DataType.ToString = "system.Datetime" Then
        '            If txtName.Text = col.ColumnName Then
        '                strFilter = col.ColumnName & "'" & dtpSearchDate.Value & "'"
        '                dvLoan.RowFilter = strFilter
        '                fnLoadDetails()
        '            End If
        '        End If
        '    Next

    End Sub

    Private Sub btnDisbursment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisbursment.Click

        If lvSeachList.SelectedItems.Count > 0 Then
            Dim objFrmDisbment As New frmDisbursment
            objFrmDisbment.txtLoanNo.Text = Trim(lvSeachList.SelectedItems(0).SubItems(1).Text)
            objFrmDisbment.BringToFront()
            objFrmDisbment.ShowDialog(Me)
            objFrmDisbment.Dispose()
        Else
            MsgBox("Select the LoanNo to be disbursed", MsgBoxStyle.Information, "LoanModule")
        End If


        'If txtLoanNo.Text <> "VL" Then
        '    Dim ObjfrmDisb As New frmDisbursment
        '    ObjfrmDisb.txtLoanNo.Text = txtLoanNo.Text
        '    ObjfrmDisb.ShowDialog(Me)
        'End If

    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged

        If txtAmount.Text <> "" Then

            If cmbSearchBy.SelectedItem = "SancAmount" Then
                strFilter = "SancAmount = '" & txtAmount.Text & "'"
                fnLoadDetails()
            ElseIf cmbSearchBy.SelectedItem = "ROI" Then
                strFilter = "ROI = '" & txtAmount.Text & "'"
                fnLoadDetails()

            End If

        End If

    End Sub

    Private Sub btnGenerateReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateReports.Click

        fnGetLoan()

    End Sub

    Private Sub txtNameSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNameSearch.TextChanged

        If txtNameSearch.Text <> "" Then

            strFilter = "Name like '" & txtNameSearch.Text & "%'"
            fnLoadDetails()

        End If

    End Sub

    Private Sub bntTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntTransaction.Click

    End Sub

    Private Sub btnLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLog.Click

    End Sub
End Class
