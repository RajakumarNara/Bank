Public Class frmAGAccSearch
    Inherits System.Windows.Forms.Form

#Region "Form Global Variables"

    Dim objPigmyAgent As New clsPigmyAgent
    Dim dvAGAccs As DataView
    Public strAGAccountNo As String
    Public strAGAccName As String
    Dim lvSItem As New ListViewItem.ListViewSubItem
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Dim strFilter As String = "AgentName like '%'"

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
    Friend WithEvents chkShowAll As System.Windows.Forms.CheckBox
    Friend WithEvents lvAGAccs As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSelect = New BankControls.NewButton
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.txtSearch = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnClose = New BankControls.NewButton
        Me.lvAGAccs = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.lblMessage = New System.Windows.Forms.Label
        Me.chkShowAll = New System.Windows.Forms.CheckBox
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Size = New System.Drawing.Size(440, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnSelect
        '
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSelect.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnSelect.Location = New System.Drawing.Point(328, 16)
        Me.btnSelect.LostFocusColour = System.Drawing.Color.Empty
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(88, 32)
        Me.btnSelect.TabIndex = 5
        Me.btnSelect.Text = "&Select"
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Items.AddRange(New Object() {"Name", "AgentNo"})
        Me.cmbType.Location = New System.Drawing.Point(112, 24)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(200, 24)
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
        Me.txtSearch.Size = New System.Drawing.Size(200, 20)
        Me.txtSearch.SpecialChar = True
        Me.txtSearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search Text:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Search By:"
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(328, 48)
        Me.btnClose.LostFocusColour = System.Drawing.Color.Empty
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 32)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close"
        '
        'lvAGAccs
        '
        Me.lvAGAccs.AllowColumnReorder = True
        Me.lvAGAccs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvAGAccs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvAGAccs.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAGAccs.FullRowSelect = True
        Me.lvAGAccs.GridLines = True
        Me.lvAGAccs.HideSelection = False
        Me.lvAGAccs.Location = New System.Drawing.Point(8, 152)
        Me.lvAGAccs.MultiSelect = False
        Me.lvAGAccs.Name = "lvAGAccs"
        Me.lvAGAccs.Size = New System.Drawing.Size(440, 304)
        Me.lvAGAccs.TabIndex = 4
        Me.lvAGAccs.UseCompatibleStateImageBehavior = False
        Me.lvAGAccs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Agent No"
        Me.ColumnHeader1.Width = 133
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 274
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(8, 120)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(290, 16)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "There are 0 Records found for your search"
        '
        'chkShowAll
        '
        Me.chkShowAll.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowAll.Location = New System.Drawing.Point(16, 96)
        Me.chkShowAll.Name = "chkShowAll"
        Me.chkShowAll.Size = New System.Drawing.Size(104, 24)
        Me.chkShowAll.TabIndex = 3
        Me.chkShowAll.Text = "Show All"
        '
        'frmAGAccSearch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(458, 463)
        Me.Controls.Add(Me.chkShowAll)
        Me.Controls.Add(Me.lvAGAccs)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAGAccSearch"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agent Account Search"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Functions"

    Function fnLoadAGAccounts()
        Dim intCounter As Integer = 0
        Dim lvItem As New ListViewItem
        If Not dvAGAccs Is Nothing Then
            dvAGAccs.RowFilter = strFilter
            lvAGAccs.Items.Clear()
            lblMessage.Text = "There are " & dvAGAccs.Count & " records found for your search"
            While intCounter < dvAGAccs.Count
                lvItem = lvAGAccs.Items.Add(dvAGAccs.Item(intCounter).Item("AgentID"))
                lvItem.SubItems.Add(dvAGAccs.Item(intCounter).Item("AgentName"))
                intCounter += 1
            End While
        End If
    End Function

#End Region

#Region "Events"

    Private Sub frmMemberSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbType.SelectedIndex = 0
        If objPigmyAgent.fnGetAgents Then
            dvAGAccs = New DataView(objPigmyAgent.getAgentsTable, strFilter, "AgentName", DataViewRowState.OriginalRows)
            fnLoadAGAccounts()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If cmbType.SelectedItem = "Name" Then
            strFilter = "AgentName like '" & txtSearch.Text & "%'"
            fnLoadAGAccounts()
        ElseIf cmbType.SelectedItem = "AgentNo" Then
            strFilter = "AgentID like '" & txtSearch.Text & "%'"
            fnLoadAGAccounts()
        End If
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click, lvAGAccs.DoubleClick
        If lvAGAccs.Items.Count > 0 Then
            If lvAGAccs.SelectedItems.Count > 0 Then
                strAGAccountNo = lvAGAccs.SelectedItems(0).SubItems(0).Text
                strAGAccName = lvAGAccs.SelectedItems(0).SubItems(1).Text
                Me.Close()
            Else
                MsgBox("Select the record", MsgBoxStyle.Exclamation)
                lvAGAccs.Focus()
            End If
        End If
    End Sub

    Private Sub lvMembers_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvAGAccs.KeyDown
        If e.KeyData = Keys.Enter Then
            btnSelect_Click(sender, e)
        End If
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyData = Keys.Down Then
            lvAGAccs.Focus()
            If lvAGAccs.Items.Count > 0 Then
                lvAGAccs.Items(0).Selected = True
                lvAGAccs.Select()
            End If
        End If
    End Sub

    Private Sub chkShowAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowAll.CheckedChanged
        fnLoadAGAccounts()
    End Sub

#End Region

End Class
