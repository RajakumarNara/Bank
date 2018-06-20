Public Class frmFDSearch
    Inherits System.Windows.Forms.Form


#Region "Form Global Variables"

    Dim objFDAccount As New clsFDAccount
    Dim dvFDAccounts As DataView
    Public strFDNo As String
    Public strFDType As String
    Public strForm As String
    Dim strFilter As String = "Status like 'A%'"
    '  Dim strFilter As String = "FDNo like '" & strFDType & "%'"

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSelect As BankControls.NewButton
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lvFDs As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lvFDs = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSelect = New BankControls.NewButton
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.txtSearch = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnClose = New BankControls.NewButton
        Me.lblMessage = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvFDs
        '
        Me.lvFDs.AllowColumnReorder = True
        Me.lvFDs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvFDs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvFDs.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvFDs.FullRowSelect = True
        Me.lvFDs.GridLines = True
        Me.lvFDs.HideSelection = False
        Me.lvFDs.Location = New System.Drawing.Point(8, 136)
        Me.lvFDs.MultiSelect = False
        Me.lvFDs.Name = "lvFDs"
        Me.lvFDs.Size = New System.Drawing.Size(392, 336)
        Me.lvFDs.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvFDs.TabIndex = 10
        Me.lvFDs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Accoount No."
        Me.ColumnHeader1.Width = 106
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 246
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.cmbType)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 96)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnSelect
        '
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSelect.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.GotFocusColour = System.Drawing.Color.FromArgb(CType(122, Byte), CType(120, Byte), CType(152, Byte))
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
        Me.cmbType.Items.AddRange(New Object() {"Name", "FD No"})
        Me.cmbType.Location = New System.Drawing.Point(104, 16)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(184, 24)
        Me.cmbType.TabIndex = 1
        '
        'txtSearch
        '
        Me.txtSearch.AlphaNumeric = True
        Me.txtSearch.BlankSpace = True
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSearch.Location = New System.Drawing.Point(104, 56)
        Me.txtSearch.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtSearch.Mandatory = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(184, 23)
        Me.txtSearch.SpecialChar = True
        Me.txtSearch.TabIndex = 2
        Me.txtSearch.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search Text:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Search By:"
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnClose.Location = New System.Drawing.Point(304, 56)
        Me.btnClose.LostFocusColour = System.Drawing.Color.Empty
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 32)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(16, 112)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(287, 19)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.Text = "There are 0 records found for your search"
        '
        'frmFDSearch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(410, 487)
        Me.Controls.Add(Me.lvFDs)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFDSearch"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Deposit Search"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frmMemberSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbType.SelectedIndex = 0
        If strForm = "FDCreation" Or strForm = "FDRenewal" Or strForm = "FDPayment" Or strForm = "Provision" Then
            If objFDAccount.fnGetFDsTable(strFDType) Then
                dvFDAccounts = New DataView(objFDAccount.FDTable, strFilter, "Name", DataViewRowState.OriginalRows)
                fnLoadFDAccounts()
            End If
        ElseIf strForm = "DoubleThriableLakshadipathi" Then
            If objFDAccount.fnGetDoubleTripleLakpathi(strFDType) Then
                dvFDAccounts = New DataView(objFDAccount.FDTable, strFilter, "Name", DataViewRowState.OriginalRows)
                fnLoadFDAccounts()
            End If
        ElseIf strForm = "FDDoubleThriableLakshadipathi" Then
            If objFDAccount.fnGetFDDoubleTripleLakpathi(strFDType) Then
                dvFDAccounts = New DataView(objFDAccount.FDTable, strFilter, "Name", DataViewRowState.OriginalRows)
                fnLoadFDAccounts()
            End If
        End If
    End Sub

    Function fnLoadFDAccounts()
        Dim intCounter As Integer = 0
        Dim lvItem As New ListViewItem
        If Not dvFDAccounts Is Nothing Then
            dvFDAccounts.RowFilter = strFilter
            lvFDs.Items.Clear()
            lblMessage.Text = "There are " & dvFDAccounts.Count & " records found for your search"
            While intCounter < dvFDAccounts.Count
                lvItem = lvFDs.Items.Add(dvFDAccounts.Item(intCounter).Item("FDNo"))
                lvItem.SubItems.Add(dvFDAccounts.Item(intCounter).Item("Name"))
                intCounter += 1
            End While
        End If
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If cmbType.SelectedItem = "Name" Then
            strFilter = "Name like '" & txtSearch.Text & "%'"
        ElseIf cmbType.SelectedItem = "FD No" Then
            strFilter = "FDNo like '" & txtSearch.Text & "%'"
        Else
            Exit Sub
        End If
        fnLoadFDAccounts()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click, lvFDs.DoubleClick
        If lvFDs.Items.Count > 0 Then
            If lvFDs.SelectedItems.Count > 0 Then
                strFDNo = lvFDs.SelectedItems(0).SubItems(0).Text
                Me.Close()
            Else
                MsgBox("Select the Record", MsgBoxStyle.Information)
                lvFDs.Focus()
            End If
        End If
    End Sub

    Private Sub lvFDs_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvFDs.KeyDown
        If e.KeyData = Keys.Enter Then
            btnSelect_Click(sender, e)
        End If
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyData = Keys.Down Then
            lvFDs.Focus()
            lvFDs.Items(0).Selected = True
            lvFDs.Select()
        End If
    End Sub


End Class
