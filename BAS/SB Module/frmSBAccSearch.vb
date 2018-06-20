Public Class frmSBAccSearch
    Inherits System.Windows.Forms.Form

#Region "Form Global Variables"
    Dim objSavingsBank As New clsSavingsBank
    Dim dvSBAccs As DataView
    Public strSBAccountNo As String
    Dim strFilter As String = "Name like '%'"
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As BankControls.TextControl
    Friend WithEvents btnSelect As BankControls.NewButton
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lvSBAccs As System.Windows.Forms.ListView
    Friend WithEvents chkShowAll As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSelect = New BankControls.NewButton
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.txtSearch = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnClose = New BankControls.NewButton
        Me.lvSBAccs = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.lblMessage = New System.Windows.Forms.Label
        Me.chkShowAll = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.cmbType)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnSelect
        '
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSelect.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.GotFocusColour = System.Drawing.Color.FromArgb(CType(122, Byte), CType(120, Byte), CType(152, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(288, 16)
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
        Me.cmbType.Items.AddRange(New Object() {"Name", "AccountNo"})
        Me.cmbType.Location = New System.Drawing.Point(112, 24)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(168, 24)
        Me.cmbType.TabIndex = 1
        '
        'txtSearch
        '
        Me.txtSearch.AlphaNumeric = True
        Me.txtSearch.AutoSize = False
        Me.txtSearch.BlankSpace = True
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSearch.Location = New System.Drawing.Point(112, 56)
        Me.txtSearch.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtSearch.Mandatory = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(168, 20)
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
        Me.Label1.Size = New System.Drawing.Size(96, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search Text :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Search By :"
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(122, Byte), CType(120, Byte), CType(152, Byte))
        Me.btnClose.Location = New System.Drawing.Point(288, 48)
        Me.btnClose.LostFocusColour = System.Drawing.Color.Empty
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 32)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close"
        '
        'lvSBAccs
        '
        Me.lvSBAccs.AllowColumnReorder = True
        Me.lvSBAccs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvSBAccs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvSBAccs.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSBAccs.FullRowSelect = True
        Me.lvSBAccs.GridLines = True
        Me.lvSBAccs.HideSelection = False
        Me.lvSBAccs.Location = New System.Drawing.Point(8, 144)
        Me.lvSBAccs.MultiSelect = False
        Me.lvSBAccs.Name = "lvSBAccs"
        Me.lvSBAccs.Size = New System.Drawing.Size(384, 296)
        Me.lvSBAccs.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvSBAccs.TabIndex = 1
        Me.lvSBAccs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Account No."
        Me.ColumnHeader1.Width = 114
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 230
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(8, 120)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(291, 19)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "There are 0 Records found for your search"
        '
        'chkShowAll
        '
        Me.chkShowAll.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowAll.Location = New System.Drawing.Point(8, 88)
        Me.chkShowAll.Name = "chkShowAll"
        Me.chkShowAll.TabIndex = 2
        Me.chkShowAll.Text = "Show All"
        '
        'frmSBAccSearch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(402, 447)
        Me.Controls.Add(Me.chkShowAll)
        Me.Controls.Add(Me.lvSBAccs)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblMessage)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSBAccSearch"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SB Search"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Functions"

    Function fnLoadSBAccounts()
        Dim intCounter As Integer = 0
        Dim lvItem As New ListViewItem
        ' lvItemSI.Font = New System.Drawing.Font("BRH Kannada", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        If Not dvSBAccs Is Nothing Then
            dvSBAccs.RowFilter = strFilter
            lvSBAccs.Items.Clear()
            lblMessage.Text = "There are " & dvSBAccs.Count & " records found for your search"
            While intCounter < dvSBAccs.Count
                lvItem = lvSBAccs.Items.Add(dvSBAccs.Item(intCounter).Item("AccountNo"))
                lvItem.UseItemStyleForSubItems = False
                lvItem.SubItems.Add(dvSBAccs.Item(intCounter).Item("Name"))
                intCounter += 1
                If chkShowAll.Checked = False Then
                    If intCounter > 50 Then
                        Exit While
                    End If
                End If

            End While
        End If
    End Function

#End Region

#Region "Events"

    Private Sub frmMemberSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbType.SelectedIndex = 0
        If objSavingsBank.fnGetSBAccountTable Then
            dvSBAccs = New DataView(objSavingsBank.SBAccTable, strFilter, "Name", DataViewRowState.OriginalRows)
            fnLoadSBAccounts()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If cmbType.SelectedItem = "Name" Then
            strFilter = "Name like '" & txtSearch.Text & "%'"
            fnLoadSBAccounts()
        ElseIf cmbType.SelectedItem = "AccountNo" Then
            strFilter = "AccountNo like '" & txtSearch.Text & "%'"
            fnLoadSBAccounts()
        End If
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click, lvSBAccs.DoubleClick
        If lvSBAccs.Items.Count > 0 Then
            If lvSBAccs.SelectedItems.Count > 0 Then
                strSBAccountNo = lvSBAccs.SelectedItems(0).SubItems(0).Text
                Me.Close()
            Else
                MsgBox("Select the record", MsgBoxStyle.Exclamation)
                lvSBAccs.Focus()
            End If
        End If
    End Sub

    Private Sub lvMembers_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvSBAccs.KeyDown
        If e.KeyData = Keys.Enter Then
            btnSelect_Click(sender, e)
        End If
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyData = Keys.Down Then
            lvSBAccs.Focus()
            lvSBAccs.Items(0).Selected = True
            lvSBAccs.Select()
        End If
      
    End Sub

    Private Sub chkShowAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowAll.CheckedChanged
        fnLoadSBAccounts()
    End Sub

#End Region

End Class
