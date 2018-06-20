Public Class frmRDList
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
    Friend WithEvents txtSearchText As BankControls.TextControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvRDList As System.Windows.Forms.ListView
    Friend WithEvents btnRDCreation As BankControls.NewButton
    Friend WithEvents btnTransDisb As BankControls.NewButton
    Friend WithEvents btnDeposit As BankControls.NewButton
    Friend WithEvents btnWithDraw As BankControls.NewButton
    Friend WithEvents btnReport As BankControls.NewButton
    Friend WithEvents btnPreMature As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtSearchText = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbSearchBy = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClose = New BankControls.NewButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnRDCreation = New BankControls.NewButton
        Me.btnTransDisb = New BankControls.NewButton
        Me.btnDeposit = New BankControls.NewButton
        Me.btnWithDraw = New BankControls.NewButton
        Me.btnPreMature = New BankControls.NewButton
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.lvRDList = New System.Windows.Forms.ListView
        Me.btnReport = New BankControls.NewButton
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtSearchText)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbSearchBy)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(264, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(704, 48)
        Me.Panel1.TabIndex = 1
        '
        'txtSearchText
        '
        Me.txtSearchText.AlphaNumeric = True
        Me.txtSearchText.AutoSize = False
        Me.txtSearchText.BlankSpace = True
        Me.txtSearchText.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchText.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSearchText.Location = New System.Drawing.Point(488, 8)
        Me.txtSearchText.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSearchText.Mandatory = False
        Me.txtSearchText.MaxLength = 30
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(184, 24)
        Me.txtSearchText.SpecialChar = True
        Me.txtSearchText.TabIndex = 3
        Me.txtSearchText.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(384, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Search Text :"
        '
        'cmbSearchBy
        '
        Me.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchBy.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchBy.Items.AddRange(New Object() {"Name", "AccNo"})
        Me.cmbSearchBy.Location = New System.Drawing.Point(120, 8)
        Me.cmbSearchBy.Name = "cmbSearchBy"
        Me.cmbSearchBy.Size = New System.Drawing.Size(176, 24)
        Me.cmbSearchBy.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(32, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 19)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Search By"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline)
        Me.Label1.ForeColor = System.Drawing.Color.Beige
        Me.Label1.Location = New System.Drawing.Point(264, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "RD Account's List"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.Beige
        Me.btnClose.Location = New System.Drawing.Point(864, 544)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnRDCreation)
        Me.Panel2.Controls.Add(Me.btnTransDisb)
        Me.Panel2.Controls.Add(Me.btnDeposit)
        Me.Panel2.Controls.Add(Me.btnWithDraw)
        Me.Panel2.Controls.Add(Me.btnPreMature)
        Me.Panel2.Location = New System.Drawing.Point(16, 18)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(216, 504)
        Me.Panel2.TabIndex = 6
        '
        'btnRDCreation
        '
        Me.btnRDCreation.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnRDCreation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRDCreation.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRDCreation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRDCreation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRDCreation.ForeColor = System.Drawing.Color.Black
        Me.btnRDCreation.GotFocusColour = System.Drawing.Color.Beige
        Me.btnRDCreation.Location = New System.Drawing.Point(16, 96)
        Me.btnRDCreation.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnRDCreation.Name = "btnRDCreation"
        Me.btnRDCreation.Size = New System.Drawing.Size(184, 40)
        Me.btnRDCreation.TabIndex = 7
        Me.btnRDCreation.Text = "New RD Creation"
        Me.btnRDCreation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnTransDisb
        '
        Me.btnTransDisb.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnTransDisb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransDisb.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnTransDisb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransDisb.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransDisb.ForeColor = System.Drawing.Color.Black
        Me.btnTransDisb.GotFocusColour = System.Drawing.Color.Beige
        Me.btnTransDisb.Location = New System.Drawing.Point(16, 288)
        Me.btnTransDisb.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnTransDisb.Name = "btnTransDisb"
        Me.btnTransDisb.Size = New System.Drawing.Size(184, 40)
        Me.btnTransDisb.TabIndex = 10
        Me.btnTransDisb.Text = "RD Transaction"
        Me.btnTransDisb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeposit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposit.ForeColor = System.Drawing.Color.Black
        Me.btnDeposit.GotFocusColour = System.Drawing.Color.Beige
        Me.btnDeposit.Location = New System.Drawing.Point(16, 160)
        Me.btnDeposit.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(184, 40)
        Me.btnDeposit.TabIndex = 8
        Me.btnDeposit.Text = "RD Deposit"
        Me.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnWithDraw
        '
        Me.btnWithDraw.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnWithDraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithDraw.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnWithDraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWithDraw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithDraw.ForeColor = System.Drawing.Color.Black
        Me.btnWithDraw.GotFocusColour = System.Drawing.Color.Beige
        Me.btnWithDraw.Location = New System.Drawing.Point(16, 224)
        Me.btnWithDraw.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnWithDraw.Name = "btnWithDraw"
        Me.btnWithDraw.Size = New System.Drawing.Size(184, 40)
        Me.btnWithDraw.TabIndex = 9
        Me.btnWithDraw.Text = "RD WithDrawl"
        Me.btnWithDraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnWithDraw.Visible = False
        '
        'btnPreMature
        '
        Me.btnPreMature.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnPreMature.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPreMature.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPreMature.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPreMature.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreMature.ForeColor = System.Drawing.Color.Black
        Me.btnPreMature.GotFocusColour = System.Drawing.Color.Beige
        Me.btnPreMature.Location = New System.Drawing.Point(16, 352)
        Me.btnPreMature.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnPreMature.Name = "btnPreMature"
        Me.btnPreMature.Size = New System.Drawing.Size(184, 40)
        Me.btnPreMature.TabIndex = 11
        Me.btnPreMature.Text = "RD Premature"
        Me.btnPreMature.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "AccountNo"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 168
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Balance"
        Me.ColumnHeader3.Width = 75
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Remarks"
        Me.ColumnHeader6.Width = 142
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Status"
        Me.ColumnHeader5.Width = 54
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Maturity Date"
        Me.ColumnHeader4.Width = 111
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ROI"
        Me.ColumnHeader7.Width = 58
        '
        'lvRDList
        '
        Me.lvRDList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader6, Me.ColumnHeader5, Me.ColumnHeader4, Me.ColumnHeader7})
        Me.lvRDList.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvRDList.FullRowSelect = True
        Me.lvRDList.GridLines = True
        Me.lvRDList.Location = New System.Drawing.Point(264, 128)
        Me.lvRDList.MultiSelect = False
        Me.lvRDList.Name = "lvRDList"
        Me.lvRDList.Size = New System.Drawing.Size(704, 392)
        Me.lvRDList.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvRDList.TabIndex = 4
        Me.lvRDList.View = System.Windows.Forms.View.Details
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReport.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.GotFocusColour = System.Drawing.Color.Beige
        Me.btnReport.Location = New System.Drawing.Point(264, 544)
        Me.btnReport.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(136, 40)
        Me.btnReport.TabIndex = 3
        Me.btnReport.Text = "Generate Report"
        '
        'frmRDList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(984, 597)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lvRDList)
        Me.Controls.Add(Me.btnReport)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmRDList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RD Account's List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmRDList
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmRDList
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmRDList
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmRDList)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Variables"

    Dim objPigmyAcc As New clsPigmyAccount
    Dim objRDAccount As New clsRDAccount
    Dim objfrmPigmyAcc As New frmPigmyAccCreation
    Dim strFilter As String = "Name like '%'"
    Dim dvItems As New DataView
    Public strAccNo As String
    Public strName As String

#End Region

#Region "Functions"

    Public Function fnGetRDList() As Boolean

        Dim intCount As Integer = 0
        Dim lstvItems As New ListViewItem

        dvItems.RowFilter = strFilter
        lvRDList.Items.Clear()

        While intCount < dvItems.Count

            lstvItems = lvRDList.Items.Add(dvItems.Item(intCount).Item("RDNo"))
            lstvItems.SubItems.Add(dvItems.Item(intCount).Item("Name"))
            If IsDBNull(dvItems.Item(intCount).Item("Balance")) = True Then
                lstvItems.SubItems.Add(0)
            Else
                lstvItems.SubItems.Add(dvItems.Item(intCount).Item("Balance"))
            End If

            lstvItems.SubItems.Add(dvItems.Item(intCount).Item("Remarks"))
            lstvItems.SubItems.Add(dvItems.Item(intCount).Item("Status"))
            lstvItems.SubItems.Add(Format(dvItems.Item(intCount).Item("RDMaturityDate"), "yyyy-MM-dd"))
            lstvItems.SubItems.Add(dvItems.Item(intCount).Item("RDROI"))
            intCount += 1

        End While

    End Function

    Public Function fnGetReport()

        Dim objRepViewer As New frmReportViewer
        objRepViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/RDCustList.rpt"
        objRepViewer.ShowDialog()
        objRepViewer.Dispose()

    End Function

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmPigmyList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "List of RD Account Holders as on '" & Date.Today & "'"
        Try
            If objRDAccount.fnGetRDList() Then
                dvItems = New DataView(objRDAccount.RDListTable, strFilter, "Name", DataViewRowState.OriginalRows)
                fnGetRDList()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRepayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRDCreation.Click
        Dim objfrmRDCreation As frmRDAccCreation
        objfrmRDCreation = frmRDAccCreation.DefInstance
        objfrmRDCreation.MdiParent = Me.MdiParent
        objfrmRDCreation.BringToFront()
        objfrmRDCreation.Show()
        objfrmRDCreation = Nothing
    End Sub

    Private Sub btnPigmyDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        If lvRDList.SelectedItems.Count = 0 Then
            MsgBox("Select account number from the list", MsgBoxStyle.Information, "RD Module")
            lvRDList.Focus()
        ElseIf lvRDList.SelectedItems(0).SubItems(4).Text = "C" Then
            MsgBox("Account is closed", MsgBoxStyle.Information)
            lvRDList.Focus()
        Else
            Dim objRDDeposit As New frmRDDeposit
            objRDDeposit.strAccNo = lvRDList.SelectedItems(0).SubItems(0).Text
            objRDDeposit.strName = lvRDList.SelectedItems(0).SubItems(1).Text
            objRDDeposit.txtRDAccNo.ReadOnly = True
            objRDDeposit.btnSearch.Enabled = False
            objRDDeposit.ShowDialog()
        End If
    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithDraw.Click

        If lvRDList.SelectedItems.Count = 0 Then
            MsgBox("Please select the item from the list", MsgBoxStyle.Information, "RD Withdraw")
        Else
            Dim objRDWithDraw As New frmRDWithDraw
            objRDWithDraw.strAccNo = lvRDList.SelectedItems(0).SubItems(0).Text
            objRDWithDraw.strName = lvRDList.SelectedItems(0).SubItems(1).Text
            objRDWithDraw.ShowDialog()
        End If

    End Sub

    Private Sub btnLoanDisb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransDisb.Click

        If lvRDList.SelectedItems.Count = 0 Then
            MsgBox("Select account number from the list", MsgBoxStyle.Information, "RD Module")
            lvRDList.Focus()
        Else
            Dim objRDTransaction As New frmRDTransaction
            objRDTransaction.strAccNo = lvRDList.SelectedItems(0).SubItems(0).Text
            objRDTransaction.strName = lvRDList.SelectedItems(0).SubItems(1).Text
            objRDTransaction.txtName.ReadOnly = True
            objRDTransaction.btnSearch.Enabled = False
            objRDTransaction.txtRDNo.ReadOnly = True
            objRDTransaction.ShowDialog()
        End If


    End Sub

    Private Sub txtSearchText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchText.TextChanged

        If cmbSearchBy.SelectedItem = "Name" Then
            strFilter = "Name like'" & txtSearchText.Text & "%'"
            fnGetRDList()
        ElseIf cmbSearchBy.SelectedItem = "AccNo" Then
            strFilter = "RDNo like '" & txtSearchText.Text & "%'"
            fnGetRDList()
        End If

    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click

        fnGetReport()

    End Sub

    Private Sub lvRDList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvRDList.DoubleClick

        If lvRDList.SelectedItems.Count > 0 Then
            If lvRDList.SelectedItems.Count > 0 Then
                Dim objfrmRDAccCreation As frmRDAccCreation
                objfrmRDAccCreation = frmRDAccCreation.DefInstance
                objfrmRDAccCreation.BringToFront()
                objfrmRDAccCreation.MdiParent = Me.MdiParent
                objfrmRDAccCreation.txtAccNo.Text = lvRDList.SelectedItems(0).SubItems(0).Text
                objfrmRDAccCreation.Show()
                objfrmRDAccCreation = Nothing
            Else
                MsgBox("Select account no", MsgBoxStyle.Information, "RD Account Creation")
                lvRDList.Focus()
            End If
        End If

    End Sub

    Private Sub btnPreMature_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreMature.Click

        If lvRDList.SelectedItems.Count = 0 Then
            MsgBox("Select account number from the list", MsgBoxStyle.Information, "RD Module")
            lvRDList.Focus()
        ElseIf lvRDList.SelectedItems(0).SubItems(4).Text = "C" Then
            MsgBox("Account is closed", MsgBoxStyle.Information)
            lvRDList.Focus()
        Else
            Dim objRDPreMature As New frmRDPreMature
            objRDPreMature.strAccNo = lvRDList.SelectedItems(0).SubItems(0).Text
            objRDPreMature.strName = lvRDList.SelectedItems(0).SubItems(1).Text
            objRDPreMature.btnSearch.Enabled = False
            objRDPreMature.ShowDialog()
        End If

    End Sub

End Class
