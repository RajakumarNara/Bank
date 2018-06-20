Public Class frmCustormerList
    Inherits System.Windows.Forms.Form

#Region " Global Variables"

    Dim objPerson As New clsPerson
    Dim DvCustomer As DataView
    Public strCustomerID As String
    Dim strFilter As String = " Name like '%'"

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmCustormerList
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmCustormerList
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmCustormerList
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmCustormerList)
            m_FormDefInstance = Value
        End Set
    End Property

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
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvCustomerlist As System.Windows.Forms.ListView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustormerList))
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.btnClose = New BankControls.NewButton
        Me.lvCustomerlist = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtSearch = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Customer ID"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 200
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.lvCustomerlist)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(64, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(888, 616)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label21.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(76, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(134, 23)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "Customer  List"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(768, 568)
        Me.btnClose.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 26
        Me.btnClose.Text = "&Close"
        '
        'lvCustomerlist
        '
        Me.lvCustomerlist.AllowColumnReorder = True
        Me.lvCustomerlist.BackColor = System.Drawing.Color.OldLace
        Me.lvCustomerlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvCustomerlist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader2, Me.ColumnHeader1, Me.ColumnHeader8, Me.ColumnHeader4, Me.ColumnHeader3, Me.ColumnHeader6})
        Me.lvCustomerlist.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCustomerlist.FullRowSelect = True
        Me.lvCustomerlist.GridLines = True
        Me.lvCustomerlist.HideSelection = False
        Me.lvCustomerlist.Location = New System.Drawing.Point(24, 128)
        Me.lvCustomerlist.MultiSelect = False
        Me.lvCustomerlist.Name = "lvCustomerlist"
        Me.lvCustomerlist.Size = New System.Drawing.Size(840, 435)
        Me.lvCustomerlist.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvCustomerlist.TabIndex = 25
        Me.lvCustomerlist.UseCompatibleStateImageBehavior = False
        Me.lvCustomerlist.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "DBO"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Status"
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Phone No."
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Mobile No."
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Remarks"
        Me.ColumnHeader6.Width = 100
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSearch)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cmbType)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(840, 56)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.AlphaNumeric = True
        Me.txtSearch.BlankSpace = True
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSearch.Location = New System.Drawing.Point(472, 24)
        Me.txtSearch.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtSearch.Mandatory = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 22)
        Me.txtSearch.SpecialChar = True
        Me.txtSearch.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(368, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Search Text : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Search By :"
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Items.AddRange(New Object() {"Name", "CustomerID"})
        Me.cmbType.Location = New System.Drawing.Point(104, 24)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(200, 24)
        Me.cmbType.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(40, 616)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(968, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(40, 616)
        Me.GroupBox4.TabIndex = 31
        Me.GroupBox4.TabStop = False
        '
        'frmCustormerList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1016, 629)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmCustormerList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customer List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Function "

    Private Sub fnLoadCustomer()
        Dim intCounter As Integer = 0
        Dim lvItem As New ListViewItem
        If Not DvCustomer Is Nothing Then
            DvCustomer.RowFilter = strFilter
            lvCustomerlist.Items.Clear()
            While intCounter < DvCustomer.Count
                lvItem = lvCustomerlist.Items.Add(DvCustomer.Item(intCounter).Item("CustomerID"))
                lvItem.SubItems.Add(DvCustomer.Item(intCounter).Item("Name"))
                lvItem.SubItems.Add(Format(DvCustomer.Item(intCounter).Item("DOB"), "yyyy-MM-dd"))
                lvItem.SubItems.Add(DvCustomer.Item(intCounter).Item("Status"))
                lvItem.SubItems.Add(DvCustomer.Item(intCounter).Item("PhoneNo"))
                lvItem.SubItems.Add(DvCustomer.Item(intCounter).Item("MobileNo"))
                lvItem.SubItems.Add(DvCustomer.Item(intCounter).Item("Remarks"))
                intCounter += 1
            End While
        End If
    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmCustormerList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbType.SelectedIndex = 0
        If (objPerson.fnGetCustomerList) Then
            DvCustomer = New DataView(objPerson.PersonTable, strFilter, "Name", DataViewRowState.OriginalRows)
            fnLoadCustomer()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If cmbType.SelectedItem = "Name" Then
            strFilter = "Name like '" & txtSearch.Text & "%'"
            fnLoadCustomer()
        Else
            strFilter = "CustomerID like '" & txtSearch.Text & "%'"
            fnLoadCustomer()
        End If
    End Sub
    Private Sub lvCustomerlist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvCustomerlist.DoubleClick
        If lvCustomerlist.SelectedItems.Count > 0 Then
            Dim objfrmCustomerCreation As frmCustomer
            objfrmCustomerCreation = frmCustomer.DefInstance
            objfrmCustomerCreation.BringToFront()
            objfrmCustomerCreation.MdiParent = Me.MdiParent
            objfrmCustomerCreation.txtCustomerID.Text = lvCustomerlist.SelectedItems(0).SubItems(0).Text
            objfrmCustomerCreation.Show()
            objfrmCustomerCreation = Nothing
        Else
            MsgBox("Select customer", MsgBoxStyle.Information, "Members")
            lvCustomerlist.Focus()
        End If
    End Sub

    
End Class
