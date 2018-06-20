Public Class frmLogDetails
    Inherits System.Windows.Forms.Form

    Dim dvLogs As DataView

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents lvLogs As System.Windows.Forms.ListView
    Friend WithEvents btnDelete As BankControls.NewButton
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents dtpLogDate As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLogDetails))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnSearch = New BankControls.NewButton
        Me.dtpLogDate = New System.Windows.Forms.DateTimePicker
        Me.btnClose = New BankControls.NewButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtSearch = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.lblMessage = New System.Windows.Forms.Label
        Me.lvLogs = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.btnDelete = New BankControls.NewButton
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 616)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.dtpLogDate)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.lblMessage)
        Me.GroupBox2.Controls.Add(Me.lvLogs)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Location = New System.Drawing.Point(232, -16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 616)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(288, 72)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(32, 24)
        Me.btnSearch.TabIndex = 112
        Me.btnSearch.Text = "Search"
        '
        'dtpLogDate
        '
        Me.dtpLogDate.CustomFormat = "dd / MMM / yyyy"
        Me.dtpLogDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLogDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLogDate.Location = New System.Drawing.Point(120, 72)
        Me.dtpLogDate.MaxDate = New Date(2331, 11, 17, 0, 0, 0, 0)
        Me.dtpLogDate.Name = "dtpLogDate"
        Me.dtpLogDate.Size = New System.Drawing.Size(168, 22)
        Me.dtpLogDate.TabIndex = 111
        Me.dtpLogDate.Value = New Date(2007, 10, 11, 0, 0, 0, 0)
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(648, 560)
        Me.btnClose.LostFocusColour = System.Drawing.Color.MistyRose
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "&Close"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSearch)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cmbType)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(744, 48)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.AlphaNumeric = True
        Me.txtSearch.BlankSpace = True
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSearch.Location = New System.Drawing.Point(104, 16)
        Me.txtSearch.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtSearch.Mandatory = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 22)
        Me.txtSearch.SpecialChar = True
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Search Text:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Search By:"
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Items.AddRange(New Object() {"UserID", "Description", "DateTime", "Type"})
        Me.cmbType.Location = New System.Drawing.Point(416, 15)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(200, 24)
        Me.cmbType.TabIndex = 1
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(16, 112)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(251, 18)
        Me.lblMessage.TabIndex = 14
        Me.lblMessage.Text = "There are 0 records found for your search"
        '
        'lvLogs
        '
        Me.lvLogs.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(234, Byte), CType(234, Byte))
        Me.lvLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvLogs.CheckBoxes = True
        Me.lvLogs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvLogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLogs.FullRowSelect = True
        Me.lvLogs.GridLines = True
        Me.lvLogs.Location = New System.Drawing.Point(16, 136)
        Me.lvLogs.MultiSelect = False
        Me.lvLogs.Name = "lvLogs"
        Me.lvLogs.Size = New System.Drawing.Size(744, 408)
        Me.lvLogs.TabIndex = 9
        Me.lvLogs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "LogNo"
        Me.ColumnHeader5.Width = 64
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "User ID"
        Me.ColumnHeader1.Width = 84
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Decription"
        Me.ColumnHeader2.Width = 295
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date Time"
        Me.ColumnHeader3.Width = 155
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Operation"
        Me.ColumnHeader4.Width = 112
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.MistyRose
        Me.Label21.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Maroon
        Me.Label21.Location = New System.Drawing.Point(80, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(104, 25)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Log Details"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(164, Byte), CType(164, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(24, 560)
        Me.btnDelete.LostFocusColour = System.Drawing.Color.MistyRose
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(160, 40)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "&Delete Selected"
        Me.btnDelete.Visible = False
        '
        'frmLogDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1018, 631)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmLogDetails"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Log Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmLogDetails
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmLogDetails
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmLogDetails
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmLogDetails)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Global Variables"
    Dim strFilter As String = "userId like '%'"
#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmLogDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim objDT As DataTable
        If pbUserId = "admin" Then
            objDT = fnLogGetLogs()
            btnDelete.Visible = True
        Else
            objDT = fnLogGetLogs(pbUserId)
        End If
        If objDT.Rows.Count > 0 Then
            dvLogs = New DataView(objDT)
            sbLoadLogs()
        End If

        dtpLogDate.Visible = False
        btnSearch.Visible = False

    End Sub

    Sub sbLoadLogs()
        Dim intCounter As Integer = 0
        Dim lvItem As ListViewItem
        lvLogs.Items.Clear()
        dvLogs.RowFilter = strFilter
        lblMessage.Text = "There are " & dvLogs.Count & " records found for your search "

        While intCounter < dvLogs.Count
            lvItem = lvLogs.Items.Add(dvLogs.Item(intCounter).Item("LogNo"))
            lvItem.SubItems.Add(dvLogs.Item(intCounter).Item("UserId"))
            lvItem.SubItems.Add(dvLogs.Item(intCounter).Item("Description"))
            lvItem.SubItems.Add(Format(dvLogs.Item(intCounter).Item("DateTime"), "dd-MMM-yyyy  hh:mm:ss"))
            lvItem.SubItems.Add(dvLogs.Item(intCounter).Item("Type"))
            intCounter += 1
        End While

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim intCounter As Integer = 0
        If lvLogs.CheckedItems.Count > 0 Then
            If MsgBox("Are you sure you want to Delete these records?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                While intCounter < lvLogs.CheckedItems.Count
                    fnLogDeleteLog(lvLogs.CheckedItems(intCounter).SubItems(0).Text)
                    intCounter += 1
                End While

                MsgBox("Records Deleted Successfully", MsgBoxStyle.Information, Me.Text)
                frmLogDetails_Load(sender, e)
            End If
        Else
            MsgBox("No records were selected, please select the records to delete", MsgBoxStyle.Information, Me.Text)
            lvLogs.Focus()
        End If

    End Sub
    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged

        If cmbType.SelectedItem = "DateTime" Then
            'strFilter = " DateTime like '" & Format(dtpLogDate.Value, "yyyy-MM-dd") & "%'"
            'sbLoadLogs()
        Else
            strFilter = cmbType.Text & " like '" & txtSearch.Text & "%'"
            sbLoadLogs()
        End If

    End Sub

    Private Sub cmbType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged

        If cmbType.SelectedItem = "DateTime" Then
            dtpLogDate.Visible = True
            btnSearch.Visible = True
            txtSearch.Visible = False
        Else

            dtpLogDate.Visible = False
            btnSearch.Visible = False
            txtSearch.Visible = True
        End If

    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        strFilter = " DateTime ='" & Format(dtpLogDate.Value, "yyyy-MM-dd") & "'"

        sbLoadLogs()
    End Sub


    'Private Sub dtpLogDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpLogDate.ValueChanged
    '    If cmbType.SelectedItem = "DateTime" Then
    '        strFilter = " DateTime = '" & Format(dtpLogDate.Value, "yyyy-MM-dd") & "'"
    '        sbLoadLogs()
    '    End If
    'End Sub
End Class
