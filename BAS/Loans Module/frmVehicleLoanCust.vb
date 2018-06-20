Public Class frmVehicleLoanCust
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As BankControls.TextControl
    Friend WithEvents btnSelect As BankControls.NewButton
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lvVehicleCust As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSelect = New BankControls.NewButton
        Me.btnClose = New BankControls.NewButton
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.txtSearch = New BankControls.TextControl
        Me.lvVehicleCust = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.lblMessage = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SearchText :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SearchBy"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSelect)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.cmbType)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(432, 100)
        Me.Panel1.TabIndex = 1
        '
        'btnSelect
        '
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.GotFocusColour = System.Drawing.Color.FromArgb(CType(122, Byte), CType(120, Byte), CType(152, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(336, 16)
        Me.btnSelect.LostFocusColour = System.Drawing.Color.Empty
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(88, 30)
        Me.btnSelect.TabIndex = 5
        Me.btnSelect.Text = "&Select"
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(122, Byte), CType(120, Byte), CType(152, Byte))
        Me.btnClose.Location = New System.Drawing.Point(336, 48)
        Me.btnClose.LostFocusColour = System.Drawing.Color.Empty
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 30)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close"
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Items.AddRange(New Object() {"Name", "LoanNo"})
        Me.cmbType.Location = New System.Drawing.Point(120, 24)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(200, 24)
        Me.cmbType.TabIndex = 2
        '
        'txtSearch
        '
        Me.txtSearch.AlphaNumeric = True
        Me.txtSearch.AutoSize = False
        Me.txtSearch.BlankSpace = True
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSearch.Location = New System.Drawing.Point(120, 56)
        Me.txtSearch.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtSearch.Mandatory = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 20)
        Me.txtSearch.SpecialChar = True
        Me.txtSearch.TabIndex = 3
        Me.txtSearch.Text = ""
        '
        'lvVehicleCust
        '
        Me.lvVehicleCust.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvVehicleCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvVehicleCust.FullRowSelect = True
        Me.lvVehicleCust.GridLines = True
        Me.lvVehicleCust.Location = New System.Drawing.Point(8, 144)
        Me.lvVehicleCust.MultiSelect = False
        Me.lvVehicleCust.Name = "lvVehicleCust"
        Me.lvVehicleCust.Size = New System.Drawing.Size(432, 296)
        Me.lvVehicleCust.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvVehicleCust.TabIndex = 4
        Me.lvVehicleCust.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Loan  Number"
        Me.ColumnHeader1.Width = 135
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 263
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(8, 120)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(257, 18)
        Me.lblMessage.TabIndex = 3
        Me.lblMessage.Text = "There are 0 Records found for your search"
        '
        'frmVehicleLoanCust
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(448, 445)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lvVehicleCust)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVehicleLoanCust"
        Me.ShowInTaskbar = False
        Me.Text = "Vehicle Loan Search "
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Varaibles"

    Dim objVehicleLoanCust As New clsVehicleLoan
    Dim dvVehicleLoan As DataView
    Dim strFilter As String = "Name like '%'"
    Public strVehicleLoan As String

#End Region

#Region "Function"

    Public Function fnGetVehicleLoan() As Boolean
        Dim intCount As Integer = 0
        Dim lstvVehicle As ListViewItem
        If Not dvVehicleLoan Is Nothing Then
            dvVehicleLoan.RowFilter = strFilter
            lvVehicleCust.Items.Clear()
            lblMessage.Text = "There are " & dvVehicleLoan.Count & " records found for your search"
            While intCount < dvVehicleLoan.Count
                lstvVehicle = lvVehicleCust.Items.Add(dvVehicleLoan.Item(intCount).Item("LoanNo"))
                lstvVehicle.SubItems.Add(dvVehicleLoan.Item(intCount).Item("Name"))

                intCount += 1
            End While
        End If
    End Function

#End Region

    Private Sub frmGoldLoanCust_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbType.SelectedIndex = 0
        If objVehicleLoanCust.fnGetVehicleLoanCust = True Then
            dvVehicleLoan = New DataView(objVehicleLoanCust.vehicleLoanCusttable, strFilter, "Name", DataViewRowState.OriginalRows)
            fnGetVehicleLoan()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If cmbType.SelectedItem = "Name" Then
            strFilter = "Name like '" & txtSearch.Text & "%'"
            fnGetVehicleLoan()
        ElseIf cmbType.SelectedItem = "LoanNo" Then
            strFilter = "LoanNo like '" & txtSearch.Text & "%'"
            fnGetVehicleLoan()
        End If
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click, lvVehicleCust.DoubleClick
        If lvVehicleCust.Items.Count > 0 Then
            If lvVehicleCust.SelectedItems.Count > 0 Then
                strVehicleLoan = lvVehicleCust.SelectedItems(0).SubItems(0).Text
                Me.Close()
            Else
                MsgBox("Select the Record")
                lvVehicleCust.Focus()
            End If
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub lvVehicleCust_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvVehicleCust.KeyDown
        If e.KeyData = Keys.Enter Then
            btnSelect_Click(sender, e)
        End If
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyData = Keys.Down Then
            lvVehicleCust.Focus()
            If lvVehicleCust.Items.Count > 0 Then
                lvVehicleCust.Items(0).Selected = True
                lvVehicleCust.Select()
            End If
        End If
    End Sub
End Class
