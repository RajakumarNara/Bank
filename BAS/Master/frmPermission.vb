Imports System.IO
Imports System.Data
Public Class frmPermission
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        If m_FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_FormDefInstance = Me
            End If
        End If
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
    Friend WithEvents btnExit As NewButton.NewButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents roles As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSaveExit As NewButton.NewButton
    Friend WithEvents lvSModule As System.Windows.Forms.ListView
    Friend WithEvents lvRoles As System.Windows.Forms.ListView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvModule As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As TextControl.TextControl
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents RoleId As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPermission))
        Me.btnExit = New NewButton.NewButton
        Me.btnSaveExit = New NewButton.NewButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lvRoles = New System.Windows.Forms.ListView
        Me.RoleId = New System.Windows.Forms.ColumnHeader
        Me.roles = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lvSModule = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lvModule = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtID = New TextControl.TextControl
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.GotFocusColour = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(255, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExit.Location = New System.Drawing.Point(680, 552)
        Me.btnExit.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 32)
        Me.btnExit.TabIndex = 43
        Me.btnExit.Text = "E&xit"
        '
        'btnSaveExit
        '
        Me.btnSaveExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSaveExit.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveExit.GotFocusColour = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(255, Byte))
        Me.btnSaveExit.Image = CType(resources.GetObject("btnSaveExit.Image"), System.Drawing.Image)
        Me.btnSaveExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveExit.Location = New System.Drawing.Point(552, 552)
        Me.btnSaveExit.LostFocusColour = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.btnSaveExit.Name = "btnSaveExit"
        Me.btnSaveExit.Size = New System.Drawing.Size(88, 32)
        Me.btnSaveExit.TabIndex = 46
        Me.btnSaveExit.Text = "&Save "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.GroupBox1.Controls.Add(Me.lvRoles)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 464)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Role"
        '
        'lvRoles
        '
        Me.lvRoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvRoles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.RoleId, Me.roles})
        Me.lvRoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvRoles.FullRowSelect = True
        Me.lvRoles.GridLines = True
        Me.lvRoles.HideSelection = False
        Me.lvRoles.Location = New System.Drawing.Point(24, 40)
        Me.lvRoles.Name = "lvRoles"
        Me.lvRoles.Size = New System.Drawing.Size(224, 352)
        Me.lvRoles.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvRoles.TabIndex = 44
        Me.lvRoles.View = System.Windows.Forms.View.Details
        '
        'RoleId
        '
        Me.RoleId.Text = "RoleId"
        Me.RoleId.Width = 0
        '
        'roles
        '
        Me.roles.Text = "Role"
        Me.roles.Width = 209
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.GroupBox2.Controls.Add(Me.lvSModule)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(624, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 456)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SubModule "
        '
        'lvSModule
        '
        Me.lvSModule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvSModule.CheckBoxes = True
        Me.lvSModule.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader5})
        Me.lvSModule.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSModule.FullRowSelect = True
        Me.lvSModule.GridLines = True
        Me.lvSModule.HideSelection = False
        Me.lvSModule.Location = New System.Drawing.Point(40, 40)
        Me.lvSModule.Name = "lvSModule"
        Me.lvSModule.Size = New System.Drawing.Size(224, 352)
        Me.lvSModule.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvSModule.TabIndex = 44
        Me.lvSModule.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "SubModules"
        Me.ColumnHeader1.Width = 211
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "SMId"
        Me.ColumnHeader5.Width = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.GroupBox3.Controls.Add(Me.lvModule)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(320, 67)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(280, 464)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Module"
        '
        'lvModule
        '
        Me.lvModule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvModule.CheckBoxes = True
        Me.lvModule.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader4})
        Me.lvModule.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvModule.FullRowSelect = True
        Me.lvModule.GridLines = True
        Me.lvModule.HideSelection = False
        Me.lvModule.Location = New System.Drawing.Point(24, 40)
        Me.lvModule.Name = "lvModule"
        Me.lvModule.Size = New System.Drawing.Size(224, 352)
        Me.lvModule.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvModule.TabIndex = 44
        Me.lvModule.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Module"
        Me.ColumnHeader2.Width = 209
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "MMId"
        Me.ColumnHeader4.Width = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(328, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 18)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Role:"
        '
        'txtID
        '
        Me.txtID.AlphaNumeric = False
        Me.txtID.BlankSpace = False
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtID.Location = New System.Drawing.Point(384, 24)
        Me.txtID.LostFocusColour = System.Drawing.Color.Empty
        Me.txtID.Mandatory = False
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(168, 22)
        Me.txtID.SpecialChar = True
        Me.txtID.TabIndex = 51
        Me.txtID.Text = ""
        '
        'frmPermission
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(253, Byte), CType(248, Byte))
        Me.ClientSize = New System.Drawing.Size(946, 599)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSaveExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPermission"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "y"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Single Instance Object Creation"
    Private Shared m_FormDefInstance As frmPermission
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmPermission
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmPermission
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmPermission)
            m_FormDefInstance = Value
        End Set
    End Property
#End Region

#Region "global variables"
    Dim objModule As New clsModule
    Dim objPermission As New clsPermissions
    Dim objSubModule As New clsSubModule
    Dim dt As New DataTable
    Dim obj As New permissions
    Dim dtPermission As New DataTable
    Dim dvMModule As DataView
    ' Dim dvrole As DataView
#End Region

#Region "Functions"

    Public Function check() As Boolean
        If txtID.Text = "" Then
            MsgBox("Select Role To Set Permissions", MsgBoxStyle.Information, Me.Text)
            lvRoles.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Public Function SetData() As Boolean

        objPermission.RoleID = lvRoles.SelectedItems(0).SubItems(0).Text
        Dim drRow As DataRow
        dt.Columns.Clear()
        Dim c1 As New DataColumn
        '  c1 = New DataColumn
        c1.DataType = System.Type.GetType("System.String")
        c1.ColumnName = "SubmoduleId"
        dt.Columns.Add(c1)
        Dim c2 As New DataColumn
        '  c2 = New DataColumn
        c2.DataType = System.Type.GetType("System.String")
        c2.ColumnName = "Status"
        dt.Columns.Add(c2)
        Dim intCounter As Integer = 0
        Try
            objPermission.ModuleID = lvModule.SelectedItems(0).SubItems(1).Text
            If lvModule.SelectedItems(0).Checked Then
                dt.Clear()
                If lvSModule.Items.Count <> 0 Then
                    If lvSModule.SelectedItems.Count = 0 Then
                        If MsgBox("Do You Want To Restrict The Whole Module?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Conform Restriction") = MsgBoxResult.Yes Then
                            drRow = dt.NewRow
                            drRow.Item("SubModuleId") = 0
                            drRow.Item("Status") = "Y"
                            dt.Rows.Add(drRow)
                            drRow = Nothing
                        Else
                            While intCounter < lvSModule.Items.Count
                                If lvSModule.Items(intCounter).Checked Then
                                    drRow = dt.NewRow
                                    drRow.Item("SubModuleId") = lvSModule.Items(intCounter).SubItems(1).Text
                                    drRow.Item("Status") = IIf(lvSModule.Items(intCounter).Checked = True, "Y", "N")
                                    dt.Rows.Add(drRow)
                                    drRow = Nothing
                                End If
                                intCounter += 1
                            End While
                            Return True
                        End If
                    End If
                Else
                    drRow = dt.NewRow
                    drRow.Item("SubModuleId") = 0
                    drRow.Item("Status") = "Y"
                    dt.Rows.Add(drRow)
                    drRow = Nothing
                End If
                Return True
            Else
                MsgBox("Select Module For Saving")
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Sub sbClear()
        txtID.ResetText()
        For ctrCount As Integer = 0 To lvSModule.Items.Count - 1
            lvSModule.Items(ctrCount).Checked = False
        Next
    End Sub

    '-------------to load database values to list
    Function fnLoadModuleData()
        If objPermission.fnGetModuleData() = True Then
            Dim intCounter As Integer = 0
            lvModule.Items.Clear()
            dvMModule = New DataView(objPermission.PermissionTable, "", "ModuleNo", DataViewRowState.OriginalRows)
            While intCounter < dvMModule.Count
                Dim lvItem As ListViewItem
                lvItem = lvModule.Items.Add(dvMModule.Item(intCounter).Item("Module"))
                lvItem.SubItems.Add(dvMModule.Item(intCounter).Item("ModuleNo"))
                intCounter += 1
            End While
        End If
    End Function

    Function fnLoadRoleData()
        Dim intcount As Integer = 0
        lvRoles.Items.Clear()
        If objPermission.fnGetRole = True Then
            While intcount < objPermission.PermissionTable.Rows.Count
                Dim lvItem As ListViewItem
                lvItem = lvRoles.Items.Add(objPermission.PermissionTable.Rows(intcount).Item(0))
                lvItem.SubItems.Add(objPermission.PermissionTable.Rows(intcount).Item(1))
                intcount += 1
            End While
        End If
    End Function

    Function fnListViewChainge()
        If Not txtID.Text = "" Then
            lvSModule.Items.Clear()
            If lvModule.SelectedItems.Count > 0 Then
                Dim SelectedModule As String
                SelectedModule = lvModule.SelectedItems(0).SubItems(1).Text
                If objSubModule.fnGetSubModule(SelectedModule) Then
                    Dim intCounter As Integer = 0
                    GroupBox2.Visible = True
                    While intCounter < objSubModule.ModuleTable.Rows.Count
                        Dim lvItem As ListViewItem
                        lvItem = lvSModule.Items.Add(objSubModule.ModuleTable.Rows(intCounter).Item(1))
                        lvItem.SubItems.Add(objSubModule.ModuleTable.Rows(intCounter).Item(0))
                        Dim tempId As String = lvRoles.SelectedItems(0).SubItems(0).Text
                        If objSubModule.fnGetCheckedItem(SelectedModule, tempId) Then
                            Dim rowarray() As DataRow
                            rowarray = objSubModule.MTable.Select("Module='" & lvModule.SelectedItems(0).SubItems(1).Text & "'")
                            If rowarray.Length > 0 Then
                                Dim dr As DataRow
                                For Each dr In rowarray
                                    Dim intCount As Integer = 0
                                    While intCount < intCounter + 1
                                        If lvSModule.Items(intCount).SubItems(1).Text = dr(1) Then
                                            lvSModule.Items(intCount).Checked = True
                                            Exit While
                                        End If
                                        intCount += 1
                                    End While
                                Next
                            End If
                        End If
                        intCounter += 1
                    End While
                Else
                    GroupBox2.Visible = False
                End If
            End If
        Else
            MsgBox("Select Role ")
        End If
    End Function

#End Region

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmPermission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fnLoadRoleData() ''''''''''To Load Role

        fnLoadModuleData() '''''To  Load ModuleTable

    End Sub

    Private Sub btnSaveExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveExit.Click
        Try
            If check() = True Then
                If SetData() = True Then
                    'objPermission.PermissionTable.Clear()
                    objPermission.PermissionTable = dt
                    Dim int As Integer = objPermission.PermissionTable.Rows.Count
                    If objPermission.fnUserCheck = True Then
                        If objPermission.fnUpdate() = True Then
                            sbClear()
                            ' fnLoadRoleData()
                            MsgBox("Updated Successfully")
                            clear()
                        End If
                    Else
                        If objPermission.fnSave = True Then
                            sbClear()
                            ' fnLoadRoleData()
                            MsgBox("Added Successfully")
                            clear()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub clear()
        lvSModule.Items.Clear()
        GroupBox2.Visible = True
        For ctrCount As Integer = 0 To lvModule.Items.Count - 1
            lvModule.Items(ctrCount).Checked = False
        Next
    End Sub

    Private Sub frmPermission_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub lvModule_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvModule.Click
        fnListViewChainge()
    End Sub

    Private Sub lvModule_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvModule.KeyDown, lvModule.KeyUp
        fnListViewChainge()
    End Sub

    Private Sub lvRoles_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvRoles.Click
        txtID.Text = lvRoles.SelectedItems(0).SubItems(1).Text
        clear()
        If objPermission.fnGetMod() = True Then
            Dim rowarray() As DataRow
            rowarray = objPermission.PTable.Select("RoleId='" & lvRoles.SelectedItems(0).SubItems(0).Text & "'")
            Dim ctrCount As Integer = lvModule.Items.Count
            If rowarray.Length > 0 Then
                Dim dr As DataRow
                For Each dr In rowarray
                    Dim intCounter As Integer = 0
                    While intCounter < ctrCount
                        If lvModule.Items(intCounter).SubItems(1).Text = dr(1) Then
                            lvModule.Items(intCounter).Checked = True
                            Exit While
                        End If
                        intCounter += 1
                    End While
                Next
            End If
        End If
    End Sub

 
End Class
