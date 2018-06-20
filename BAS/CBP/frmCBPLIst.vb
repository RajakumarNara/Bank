Public Class frmCBPLIst
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
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lvSBAccounts As System.Windows.Forms.ListView
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents NewButton3 As BankControls.NewButton
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPrint As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCBPLIst))
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnPrint = New BankControls.NewButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.txtSearch = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblMessage = New System.Windows.Forms.Label
        Me.lvSBAccounts = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.Label32 = New System.Windows.Forms.Label
        Me.btnAdd = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NewButton3 = New BankControls.NewButton
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ClearedDate"
        Me.ColumnHeader8.Width = 95
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "ChequeStatus"
        Me.ColumnHeader10.Width = 95
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Remarks"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "DepositedDate"
        Me.ColumnHeader7.Width = 95
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "ChequeNo"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 95
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ChequeAmt"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 95
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ChequeDate"
        Me.ColumnHeader5.Width = 95
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnPrint)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.lblMessage)
        Me.GroupBox2.Controls.Add(Me.lvSBAccounts)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(66, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(942, 616)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(144, 568)
        Me.btnPrint.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(104, 40)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "&Print"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(376, 552)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Total Balance"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cmbType)
        Me.GroupBox3.Controls.Add(Me.txtSearch)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(764, 48)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Search By:"
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Items.AddRange(New Object() {"Name", "AccountNo", "Transfered AccNo", "Amount", "Type", "Status"})
        Me.cmbType.Location = New System.Drawing.Point(160, 16)
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
        Me.txtSearch.Location = New System.Drawing.Point(472, 16)
        Me.txtSearch.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtSearch.Mandatory = False
        Me.txtSearch.MaxLength = 100
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 23)
        Me.txtSearch.SpecialChar = True
        Me.txtSearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(376, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Search Text:"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(12, 120)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(287, 16)
        Me.lblMessage.TabIndex = 72
        Me.lblMessage.Text = "There are 0 records found for your search"
        '
        'lvSBAccounts
        '
        Me.lvSBAccounts.AllowColumnReorder = True
        Me.lvSBAccounts.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvSBAccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvSBAccounts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader7, Me.ColumnHeader9, Me.ColumnHeader5, Me.ColumnHeader4, Me.ColumnHeader11, Me.ColumnHeader10, Me.ColumnHeader12, Me.ColumnHeader8, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader6})
        Me.lvSBAccounts.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSBAccounts.FullRowSelect = True
        Me.lvSBAccounts.GridLines = True
        Me.lvSBAccounts.HideSelection = False
        Me.lvSBAccounts.Location = New System.Drawing.Point(6, 139)
        Me.lvSBAccounts.MultiSelect = False
        Me.lvSBAccounts.Name = "lvSBAccounts"
        Me.lvSBAccounts.Size = New System.Drawing.Size(920, 384)
        Me.lvSBAccounts.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvSBAccounts.TabIndex = 3
        Me.lvSBAccounts.UseCompatibleStateImageBehavior = False
        Me.lvSBAccounts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CBP No"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Transfered AccNo"
        Me.ColumnHeader3.Width = 135
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "ChequeType"
        Me.ColumnHeader11.Width = 95
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "BankDetail"
        Me.ColumnHeader12.Width = 95
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "PostalCharges"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader13.Width = 95
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Commission"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader14.Width = 95
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Other"
        Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader15.Width = 95
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(72, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(234, 23)
        Me.Label32.TabIndex = 68
        Me.Label32.Text = "Clearing Bill Purchase List"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.Gray
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(24, 568)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.WhiteSmoke
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 40)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(672, 568)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(480, 552)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 24)
        Me.Label4.TabIndex = 73
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NewButton3)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(52, 616)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'NewButton3
        '
        Me.NewButton3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NewButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton3.ForeColor = System.Drawing.Color.Black
        Me.NewButton3.GotFocusColour = System.Drawing.Color.Gray
        Me.NewButton3.Image = CType(resources.GetObject("NewButton3.Image"), System.Drawing.Image)
        Me.NewButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton3.Location = New System.Drawing.Point(6, 50)
        Me.NewButton3.LostFocusColour = System.Drawing.Color.WhiteSmoke
        Me.NewButton3.Name = "NewButton3"
        Me.NewButton3.Size = New System.Drawing.Size(24, 237)
        Me.NewButton3.TabIndex = 6
        Me.NewButton3.Text = "&Cheque Clearing"
        Me.NewButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton3.UseVisualStyleBackColor = False
        '
        'frmCBPLIst
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1016, 744)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmCBPLIst"
        Me.ShowInTaskbar = False
        Me.Text = "CBP List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Form Global Variables"

    Dim dvCBPAccounts As DataView
    Dim strFilter As String = "Name like '%'"
    Friend WithEvents dtp As New DateTimePicker
    Dim intCount As Integer
    Dim objCBP As New clsCBPDet

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmCBPLIst
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmCBPLIst
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmCBPLIst
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmCBPLIst)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Function"

    Function fnLoadCBPAccounts() As Boolean
        Dim intCounter As Integer = 0
        Dim lvItem As New ListViewItem
        Dim intTotalBal As Integer = 0
        If Not dvCBPAccounts Is Nothing Then
            dvCBPAccounts.RowFilter = strFilter
            lvSBAccounts.Items.Clear()
            lblMessage.Text = "There are " & dvCBPAccounts.Count & " records found for your search"
            While intCounter < dvCBPAccounts.Count
                lvItem = lvSBAccounts.Items.Add(dvCBPAccounts.Item(intCounter).Item("AccountNo"))
                lvItem.UseItemStyleForSubItems = False
                lvItem.SubItems.Add(dvCBPAccounts.Item(intCounter).Item("Name"))
                lvItem.SubItems.Add(dvCBPAccounts.Item(intCounter).Item("TrAccNo"))
                lvItem.SubItems.Add(Format(dvCBPAccounts.Item(intCounter).Item("DepositDate"), "dd-MM-yyyy"))
                lvItem.SubItems.Add(dvCBPAccounts.Item(intCounter).Item("ChequeNo"))
                lvItem.SubItems.Add(Format(dvCBPAccounts.Item(intCounter).Item("ChequeDate"), "dd-MM-yyyy"))
                lvItem.SubItems.Add(Format(dvCBPAccounts.Item(intCounter).Item("ChequeAmount"), "0,00.00"))
                If dvCBPAccounts.Item(intCounter).Item("ChequrType") = "I" Then
                    lvItem.SubItems.Add("In Station")
                ElseIf dvCBPAccounts.Item(intCounter).Item("ChequrType") = "O" Then
                    lvItem.SubItems.Add("Out Station")
                End If
                If dvCBPAccounts.Item(intCounter).Item("ChequeStatus") = "P" Then
                    lvItem.SubItems.Add("Pending")
                ElseIf dvCBPAccounts.Item(intCounter).Item("ChequeStatus") = "C" Then
                    lvItem.SubItems.Add("Cleared")
                End If
                lvItem.SubItems.Add(dvCBPAccounts.Item(intCounter).Item("BankDetail"))

                lvItem.SubItems.Add(Format(dvCBPAccounts.Item(intCounter).Item("ClearingDate"), "dd-MM-yyyy"))
                lvItem.SubItems.Add(Format(dvCBPAccounts.Item(intCounter).Item("PostalCharge"), "0,00.00"))
                lvItem.SubItems.Add(Format(dvCBPAccounts.Item(intCounter).Item("Commission"), "0,00.00"))
                lvItem.SubItems.Add(Format(dvCBPAccounts.Item(intCounter).Item("OtherCharge"), "0,00.00"))
                lvItem.SubItems.Add(dvCBPAccounts.Item(intCounter).Item("Remark"))
                intCounter += 1
            End While
        End If
        ' Label4.Text = Format(intTotalBal, "0,00.00")
    End Function

#End Region

    Private Sub frmCBPLIst_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbType.SelectedIndex = 0
        If objCBP.fnGetCBPDetail Then
            dvCBPAccounts = New DataView(objCBP.CBPdetail, strFilter, "Name", DataViewRowState.OriginalRows)
            fnLoadCBPAccounts()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged, dtp.ValueChanged
        Select Case cmbType.SelectedItem
            Case "Name"
                strFilter = "Name like '" & txtSearch.Text & "%'"
                fnLoadCBPAccounts()
            Case "AccountNo"
                strFilter = "AccountNo like '" & txtSearch.Text & "%'"
                fnLoadCBPAccounts()
            Case "Transfered AccNo"
                strFilter = "TrAccNo like '" & txtSearch.Text & "%'"
                fnLoadCBPAccounts()
            Case "Status"
                strFilter = "ChequeStatus like '" & txtSearch.Text & "%'"
                fnLoadCBPAccounts()
            Case "Type"
                strFilter = "ChequrType like '" & txtSearch.Text & "%'"
                fnLoadCBPAccounts()
            Case "Amount"
                strFilter = "ChequeAmount =" & Val(txtSearch.Text) & ""
                fnLoadCBPAccounts()
        End Select

    End Sub

    Private Sub lvSBAccounts_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvSBAccounts.DoubleClick
        If lvSBAccounts.SelectedItems.Count > 0 Then
            Dim objfrmSBAccCreation As frmCBPCreation
            objfrmSBAccCreation = frmCBPCreation.DefInstance
            objfrmSBAccCreation.BringToFront()
            objfrmSBAccCreation.MdiParent = Me.MdiParent
            objfrmSBAccCreation.txtCBPAccountNo.Text = lvSBAccounts.SelectedItems(0).SubItems(0).Text
            objfrmSBAccCreation.Show()
            objfrmSBAccCreation = Nothing
        Else
            MsgBox("Select account no", MsgBoxStyle.Information, "CBP Creation")
            lvSBAccounts.Focus()
        End If

    End Sub

    Private Sub lvSBAccounts_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvSBAccounts.KeyUp
        If e.KeyCode = Keys.Enter Then
            lvSBAccounts_DoubleClick(Me, e.Empty)
        End If
    End Sub

    Private Sub txtSearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        If e.KeyCode = Keys.Down Then
            lvSBAccounts.Focus()
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim objfrmFDCreation As frmCBPCreation
        objfrmFDCreation = frmCBPCreation.DefInstance
        objfrmFDCreation.BringToFront()
        objfrmFDCreation.MdiParent = Me.MdiParent
        objfrmFDCreation.Show()
        objfrmFDCreation = Nothing
    End Sub

    Private Sub NewButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton3.Click
        If lvSBAccounts.Items.Count > 0 Then
            If lvSBAccounts.SelectedItems.Count > 0 Then
                If lvSBAccounts.SelectedItems(0).SubItems(8).Text = "Pending" Then
                    Dim ObjfrmFDPayments As New frmCBPClearing
                    ObjfrmFDPayments.txtAccountNo.Text = lvSBAccounts.SelectedItems(0).SubItems(0).Text
                    ObjfrmFDPayments.btnSearch.Enabled = False
                    ObjfrmFDPayments.ShowDialog(Me)
                Else
                    MsgBox("Cheque is already cleared", MsgBoxStyle.Exclamation)
                    lvSBAccounts.Focus()
                End If
            Else
                MsgBox("Select cheque number from the list", MsgBoxStyle.Exclamation)
                lvSBAccounts.Focus()
            End If
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim objReportView As New frmReportViewer
        objReportView.CrystalReportViewer1.ReportSource = Application.StartupPath & "/Reports/CBPList.rpt"
        objReportView.ShowDialog()
        'objReportView.Dispose()
       

    End Sub

End Class
