Public Class frmDefaulters
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
    Friend WithEvents lblDefaulters As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lvDefaulters As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents btnGenerateReport As BankControls.NewButton
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtNameSearch As BankControls.TextControl
    Friend WithEvents txtBalance As BankControls.NumericControl
    Friend WithEvents txtSearchText As BankControls.TextControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDefaulters))
        Me.lblDefaulters = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnGenerateReport = New BankControls.NewButton
        Me.txtSearchText = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbSearchBy = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lvDefaulters = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.btnCancel = New BankControls.NewButton
        Me.txtBalance = New BankControls.NumericControl
        Me.txtNameSearch = New BankControls.TextControl
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDefaulters
        '
        Me.lblDefaulters.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline)
        Me.lblDefaulters.ForeColor = System.Drawing.Color.Black
        Me.lblDefaulters.Location = New System.Drawing.Point(16, 8)
        Me.lblDefaulters.Name = "lblDefaulters"
        Me.lblDefaulters.Size = New System.Drawing.Size(440, 24)
        Me.lblDefaulters.TabIndex = 45
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnGenerateReport)
        Me.Panel1.Controls.Add(Me.txtSearchText)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbSearchBy)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lvDefaulters)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.txtBalance)
        Me.Panel1.Controls.Add(Me.txtNameSearch)
        Me.Panel1.Location = New System.Drawing.Point(8, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 568)
        Me.Panel1.TabIndex = 46
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.BackColor = System.Drawing.Color.Ivory
        Me.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGenerateReport.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateReport.ForeColor = System.Drawing.Color.Black
        Me.btnGenerateReport.GotFocusColour = System.Drawing.Color.RosyBrown
        Me.btnGenerateReport.Image = CType(resources.GetObject("btnGenerateReport.Image"), System.Drawing.Image)
        Me.btnGenerateReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerateReport.Location = New System.Drawing.Point(16, 512)
        Me.btnGenerateReport.LostFocusColour = System.Drawing.Color.Ivory
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(112, 40)
        Me.btnGenerateReport.TabIndex = 75
        Me.btnGenerateReport.Text = "Report"
        '
        'txtSearchText
        '
        Me.txtSearchText.AlphaNumeric = True
        Me.txtSearchText.AutoSize = False
        Me.txtSearchText.BlankSpace = False
        Me.txtSearchText.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchText.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSearchText.Location = New System.Drawing.Point(464, 16)
        Me.txtSearchText.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSearchText.Mandatory = False
        Me.txtSearchText.MaxLength = 30
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(160, 24)
        Me.txtSearchText.SpecialChar = False
        Me.txtSearchText.TabIndex = 54
        Me.txtSearchText.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Ivory
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(360, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Search Text :"
        '
        'cmbSearchBy
        '
        Me.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchBy.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchBy.ItemHeight = 16
        Me.cmbSearchBy.Items.AddRange(New Object() {"Name", "LoanNo", "Balance"})
        Me.cmbSearchBy.Location = New System.Drawing.Point(120, 16)
        Me.cmbSearchBy.Name = "cmbSearchBy"
        Me.cmbSearchBy.Size = New System.Drawing.Size(184, 24)
        Me.cmbSearchBy.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Ivory
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 19)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Search By :"
        '
        'lvDefaulters
        '
        Me.lvDefaulters.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader8, Me.ColumnHeader3, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.lvDefaulters.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDefaulters.ForeColor = System.Drawing.Color.Black
        Me.lvDefaulters.FullRowSelect = True
        Me.lvDefaulters.GridLines = True
        Me.lvDefaulters.Location = New System.Drawing.Point(8, 48)
        Me.lvDefaulters.MultiSelect = False
        Me.lvDefaulters.Name = "lvDefaulters"
        Me.lvDefaulters.Size = New System.Drawing.Size(984, 448)
        Me.lvDefaulters.TabIndex = 1
        Me.lvDefaulters.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "SlNo."
        Me.ColumnHeader4.Width = 50
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "LoanNo"
        Me.ColumnHeader1.Width = 85
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 155
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Sanc Date"
        Me.ColumnHeader8.Width = 95
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Sanctioned Amt"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Inst Amt"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "No of Inst"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 50
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Total Due"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader11.Width = 95
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Balance"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Last Paid Date"
        Me.ColumnHeader6.Width = 95
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Phone No"
        Me.ColumnHeader7.Width = 90
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "SName"
        Me.ColumnHeader12.Width = 155
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "SPhoneNo"
        Me.ColumnHeader13.Width = 90
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Ivory
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.RosyBrown
        Me.btnCancel.Location = New System.Drawing.Point(872, 504)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.Ivory
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Close"
        '
        'txtBalance
        '
        Me.txtBalance.AfterDecimal = 0
        Me.txtBalance.BeforeDecimal = 12
        Me.txtBalance.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBalance.Location = New System.Drawing.Point(464, 16)
        Me.txtBalance.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBalance.MaxLength = 10
        Me.txtBalance.MaxValue = 0
        Me.txtBalance.MinValue = 0
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(160, 23)
        Me.txtBalance.TabIndex = 47
        Me.txtBalance.Text = ""
        '
        'txtNameSearch
        '
        Me.txtNameSearch.AlphaNumeric = True
        Me.txtNameSearch.AutoSize = False
        Me.txtNameSearch.BlankSpace = False
        Me.txtNameSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameSearch.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNameSearch.Location = New System.Drawing.Point(464, 16)
        Me.txtNameSearch.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNameSearch.Mandatory = False
        Me.txtNameSearch.MaxLength = 30
        Me.txtNameSearch.Name = "txtNameSearch"
        Me.txtNameSearch.Size = New System.Drawing.Size(160, 24)
        Me.txtNameSearch.SpecialChar = True
        Me.txtNameSearch.TabIndex = 76
        Me.txtNameSearch.Text = ""
        Me.txtNameSearch.Visible = False
        '
        'frmDefaulters
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Ivory
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1018, 631)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblDefaulters)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmDefaulters"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Defaulters"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"

    Dim objLoanDet As New clsLoanDet
    Dim dvIitems As DataView

    Dim strFilter As String = "LoanNo like '%'"


#End Region

#Region "Functions"

    Public Function fnGetDefaluters() As Boolean

        Dim lstvItems As ListViewItem

        Dim intC As Integer
        Dim intCount As Integer = 0

        lvDefaulters.Items.Clear()

        Dim intNOM As Integer = 0
        Dim dblDueAmt As Double = 0
        Dim intDueMonth As Integer = 0

        While intCount < dvIitems.Count
            intNOM = 0
            intNOM = DateDiff(DateInterval.Month, dvIitems.Item(intCount).Item("SancDate"), dvIitems.Item(intCount).Item("LastPaidDate"))
            intNOM += 1
            dblDueAmt = (intNOM * dvIitems.Item(intCount).Item("InstPrinciple")) - dvIitems.Item(intCount).Item("Credit")
            If dblDueAmt > dvIitems.Item(intCount).Item("InstPrinciple") * 3 Then
                intDueMonth = (dblDueAmt / (dvIitems.Item(intCount).Item("InstPrinciple")))

                lstvItems = lvDefaulters.Items.Add(dvIitems.Item(intCount).Item("LoanNo"))
                lstvItems.SubItems.Add(dvIitems.Item(intCount).Item("Name"))
                lstvItems.SubItems.Add(Format(dvIitems.Item(intCount).Item("SancDate"), "yyyy-MM-dd"))
                lstvItems.SubItems.Add(dvIitems.Item(intCount).Item("SancAmount"))
                lstvItems.SubItems.Add(dvIitems.Item(intCount).Item("InstPrinciple"))
                lstvItems.SubItems.Add(intDueMonth)
                lstvItems.SubItems.Add(dblDueAmt)
                lstvItems.SubItems.Add(dvIitems.Item(intCount).Item("Balance"))
                lstvItems.SubItems.Add(Format(dvIitems.Item(intCount).Item("LastPaidDate"), "yyyy-MM-dd"))
                lstvItems.SubItems.Add(dvIitems.Item(intCount).Item("MobileNo"))
            End If

            intCount += 1

        End While
    End Function

    Public Function fnDisplayDefaluters() As Boolean

        Dim lstvItems As ListViewItem
        Dim IntCounter As Integer = 1

        Dim intCount As Integer = 0
        lvDefaulters.Items.Clear()
        dvIitems.RowFilter = strFilter

        While intCount < dvIitems.Count
            lstvItems = lvDefaulters.Items.Add(IntCounter)
            lstvItems.SubItems.Add(dvIitems.Item(intCount).Item("LoanNo"))
            lstvItems.SubItems.Add(dvIitems.Item(intCount).Item("Name"))
            lstvItems.SubItems.Add(Format(dvIitems.Item(intCount).Item("SancDate"), "dd-MM-yyyy"))
            lstvItems.SubItems.Add(dvIitems.Item(intCount).Item("SancAmount"))
            lstvItems.SubItems.Add(dvIitems.Item(intCount).Item("InstPrinciple"))
            lstvItems.SubItems.Add(dvIitems.Item(intCount).Item("DueMonth"))
            lstvItems.SubItems.Add(dvIitems.Item(intCount).Item("DueAmount"))
            lstvItems.SubItems.Add(dvIitems.Item(intCount).Item("Balance"))
            lstvItems.SubItems.Add(Format(dvIitems.Item(intCount).Item("LastPaidDate"), "dd-MM-yyyy"))
            lstvItems.SubItems.Add(dvIitems.Item(intCount).Item("MobileNo"))
            lstvItems.SubItems.Add(dvIitems.Item(intCount).Item("SName"))
            lstvItems.SubItems.Add(dvIitems.Item(intCount).Item("SPhoneNo"))
            intCount += 1
            IntCounter += 1
        End While
    End Function

    Public Function fnFindDefaluterd() As Boolean
        Dim intNOM As Integer = 0
        Dim dblDueAmt As Double = 0
        Dim intDueMonth As Integer = 0
        Dim intCount As Integer = 0
        Dim dtDataTable As New DataTable

        objLoanDet.fnDeleteDefaulters()

        If objLoanDet.fnGetLaonDetails() Then
            dtDataTable = objLoanDet.LoanDefaulters
            While intCount < dtDataTable.Rows.Count
                intNOM = 0
                intNOM = DateDiff(DateInterval.Month, dtDataTable.Rows(intCount).Item("SancDate"), dtDataTable.Rows(intCount).Item("LastPaidDate"))
                intNOM += 1
                dblDueAmt = (intNOM * dtDataTable.Rows(intCount).Item("InstPrinciple")) - dtDataTable.Rows(intCount).Item("Credit")
                If dblDueAmt > dtDataTable.Rows(intCount).Item("InstPrinciple") * 3 Then
                    intDueMonth = (dblDueAmt / (dtDataTable.Rows(intCount).Item("InstPrinciple")))
                    objLoanDet.fnInsertDefaulters(dtDataTable.Rows(intCount).Item("LoanNo"), intDueMonth, dblDueAmt)
                End If
                intCount += 1
            End While
        Else

            Return False
        End If
        Return True

    End Function

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmDefaulters
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmDefaulters
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmDefaulters
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmDefaulters)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

    Private Sub frmDefaulters_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblDefaulters.Text = "Defaulters  List  As  on " & Format(Date.Today, "dd-MM-yyyy")

        txtBalance.Visible = False
        txtNameSearch.Visible = False

        If fnFindDefaluterd() Then
            If objLoanDet.fnGetDefaultersList() Then
                dvIitems = New DataView(objLoanDet.LoanDefaulters, strFilter, "LoanNo", DataViewRowState.OriginalRows)
                fnDisplayDefaluters()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub txtSearchText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchText.TextChanged, txtNameSearch.TextChanged

        Select Case cmbSearchBy.SelectedItem

            Case "Name"
                strFilter = "Name like '" & txtNameSearch.Text & "%'"
                fnDisplayDefaluters()
            Case "LoanNo"
                strFilter = "LoanNo"
                strFilter = "LoanNo like '" & txtSearchText.Text & "%'"
                fnDisplayDefaluters()
            Case "Balance"
                strFilter = "Balance"
                strFilter = "Balance = '" & txtSearchText.Text & "%'"
                fnDisplayDefaluters()
        End Select

    End Sub

    Private Sub cmbSearchBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearchBy.SelectedIndexChanged

        If cmbSearchBy.SelectedItem = "Balance" Then

            txtSearchText.Visible = False
            txtBalance.Visible = True
            txtNameSearch.Visible = False

        ElseIf cmbSearchBy.SelectedItem = "Name" Then

            txtNameSearch.Visible = True
            txtBalance.Visible = False
            txtSearchText.Visible = False

        ElseIf cmbSearchBy.SelectedItem = "LoanNo" Then

            txtSearchText.Visible = True
            txtNameSearch.Visible = False
            txtBalance.Visible = False

        End If

    End Sub

    Private Sub txtBalance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBalance.TextChanged

        If txtBalance.Text <> "" Then
            strFilter = "Balance = '" & txtBalance.Text & "'"
            fnDisplayDefaluters()
        End If

    End Sub

    Private Sub btnGenerateReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateReport.Click

        Dim objReportViewer As New frmReportViewer
        objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/Reports/DefaulterList.rpt"

        objReportViewer.ShowDialog()
        objReportViewer.Dispose()

    End Sub

    Private Sub txtNameSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNameSearch.TextChanged

        If txtNameSearch.Text <> "" Then
            strFilter = "Name like '" & txtNameSearch.Text & "%'"
            fnDisplayDefaluters()
        End If

    End Sub

End Class
