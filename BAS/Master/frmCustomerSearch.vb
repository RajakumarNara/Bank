Public Class frmCustomerSearch
    Inherits System.Windows.Forms.Form

#Region " Global Variables"

    Dim objPerson As New clsPerson
    Dim DvCustomer As DataView
    Public strCustomerID As String
    Public strPersonNo As String
    Dim strFilter As String = " Name like '%'"

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
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSelect As BankControls.NewButton
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lvCustomerlist As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSelect = New BankControls.NewButton
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.txtSearch = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnClose = New BankControls.NewButton
        Me.lvCustomerlist = New System.Windows.Forms.ListView
        Me.lblMessage = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 297
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Customer ID"
        Me.ColumnHeader1.Width = 97
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.cmbType)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 88)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'btnSelect
        '
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSelect.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnSelect.Location = New System.Drawing.Point(304, 16)
        Me.btnSelect.LostFocusColour = System.Drawing.Color.Empty
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(88, 32)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "&Select"
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Items.AddRange(New Object() {"Name", "CustomerID"})
        Me.cmbType.Location = New System.Drawing.Point(112, 24)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(176, 24)
        Me.cmbType.TabIndex = 1
        '
        'txtSearch
        '
        Me.txtSearch.AlphaNumeric = True
        Me.txtSearch.BlankSpace = True
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSearch.Location = New System.Drawing.Point(112, 56)
        Me.txtSearch.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtSearch.Mandatory = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(176, 22)
        Me.txtSearch.SpecialChar = True
        Me.txtSearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search Text : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Search By : "
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(304, 48)
        Me.btnClose.LostFocusColour = System.Drawing.Color.Empty
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 32)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        '
        'lvCustomerlist
        '
        Me.lvCustomerlist.AllowColumnReorder = True
        Me.lvCustomerlist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvCustomerlist.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCustomerlist.FullRowSelect = True
        Me.lvCustomerlist.GridLines = True
        Me.lvCustomerlist.HideSelection = False
        Me.lvCustomerlist.Location = New System.Drawing.Point(8, 120)
        Me.lvCustomerlist.MultiSelect = False
        Me.lvCustomerlist.Name = "lvCustomerlist"
        Me.lvCustomerlist.Size = New System.Drawing.Size(400, 360)
        Me.lvCustomerlist.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvCustomerlist.TabIndex = 8
        Me.lvCustomerlist.UseCompatibleStateImageBehavior = False
        Me.lvCustomerlist.View = System.Windows.Forms.View.Details
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(8, 96)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(287, 16)
        Me.lblMessage.TabIndex = 6
        Me.lblMessage.Text = "There are 0 records found for your search"
        '
        'frmCustomerSearch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(418, 487)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lvCustomerlist)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomerSearch"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Search"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Function "
    Private Sub fnLoadCustomer()
        Dim intCounter As Integer = 0
        Dim lvItem As New ListViewItem
        If Not DvCustomer Is Nothing Then
            DvCustomer.RowFilter = strFilter
            lvCustomerlist.Items.Clear()
            lblMessage.Text = "There is " & DvCustomer.Count & " found in your search"
            While intCounter < DvCustomer.Count
                lvItem = lvCustomerlist.Items.Add(DvCustomer.Item(intCounter).Item("CustomerID"))
                lvItem.SubItems.Add(DvCustomer.Item(intCounter).Item("Name"))
                intCounter += 1
            End While

        End If

    End Sub

#End Region


    Private Sub frmCustomerSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbType.SelectedIndex = 0
        If (objPerson.fnGetCustomerList) Then
            DvCustomer = New DataView(objPerson.PersonTable, strFilter, "Name", DataViewRowState.OriginalRows)
            fnLoadCustomer()
        End If

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If cmbType.SelectedItem = "Name" Then
            strFilter = "Name like '" & txtSearch.Text & "%'"
            fnLoadCustomer()
        Else
            strFilter = "CustomerID like '" & txtSearch.Text & "%'"
            fnLoadCustomer()
        End If
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If lvCustomerlist.Items.Count > 0 Then
            If lvCustomerlist.SelectedItems.Count > 0 Then
                strCustomerID = lvCustomerlist.SelectedItems(0).SubItems(0).Text
                Me.Close()
            Else
                MsgBox("Select record", MsgBoxStyle.Exclamation)
                lvCustomerlist.Focus()
            End If
        End If
    End Sub
    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyData = Keys.Down Then
            lvCustomerlist.Focus()
            lvCustomerlist.Items(0).Selected = True
            lvCustomerlist.Select()
        End If
    End Sub

    Private Sub lvCustomerlist_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvCustomerlist.KeyDown
        If e.KeyData = Keys.Enter Then
            btnSelect_Click(sender, e)
        End If
    End Sub

    Private Sub lvCustomerlist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvCustomerlist.DoubleClick
        btnSelect_Click(sender, e)
    End Sub
End Class

