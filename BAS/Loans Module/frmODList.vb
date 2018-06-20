Public Class frmODList
    Inherits System.Windows.Forms.Form

#Region "Code to create Instance Object"

    Private Shared m_frmDefInstance As frmODList
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmODList
        Get
            If m_frmDefInstance Is Nothing OrElse m_frmDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_frmDefInstance = New frmODList
                m_InitializingDefInstance = False
            End If
            DefInstance = m_frmDefInstance
        End Get
        Set(ByVal Value As frmODList)
            m_frmDefInstance = Value
        End Set
    End Property
#End Region

#Region "Global Variables"
    Dim dvLoan As New DataView
    Dim objOD As New clsODLoanDetails
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtSearchText As BankControls.TextControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents NewButton6 As BankControls.NewButton
    Friend WithEvents lblLoanList As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvLoanList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnLoanTran As BankControls.NewButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents NewButton1 As BankControls.NewButton
    Friend WithEvents btnAdd As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmODList))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtSearchText = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbSearchBy = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.NewButton6 = New BankControls.NewButton
        Me.lblLoanList = New System.Windows.Forms.Label
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.lvLoanList = New System.Windows.Forms.ListView
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.btnLoanTran = New BankControls.NewButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnAdd = New BankControls.NewButton
        Me.NewButton1 = New BankControls.NewButton
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtSearchText)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbSearchBy)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(220, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 48)
        Me.Panel1.TabIndex = 10
        '
        'txtSearchText
        '
        Me.txtSearchText.AlphaNumeric = True
        Me.txtSearchText.BlankSpace = True
        Me.txtSearchText.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchText.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSearchText.Location = New System.Drawing.Point(512, 8)
        Me.txtSearchText.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSearchText.Mandatory = False
        Me.txtSearchText.MaxLength = 30
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(193, 24)
        Me.txtSearchText.SpecialChar = True
        Me.txtSearchText.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(408, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Search Text :"
        '
        'cmbSearchBy
        '
        Me.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchBy.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchBy.Items.AddRange(New Object() {"Name", "ODNumber", "Status"})
        Me.cmbSearchBy.Location = New System.Drawing.Point(136, 8)
        Me.cmbSearchBy.Name = "cmbSearchBy"
        Me.cmbSearchBy.Size = New System.Drawing.Size(184, 24)
        Me.cmbSearchBy.TabIndex = 56
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(47, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 16)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Search By :"
        '
        'NewButton6
        '
        Me.NewButton6.BackColor = System.Drawing.Color.LightYellow
        Me.NewButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton6.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.NewButton6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton6.ForeColor = System.Drawing.Color.Black
        Me.NewButton6.GotFocusColour = System.Drawing.Color.IndianRed
        Me.NewButton6.Location = New System.Drawing.Point(852, 578)
        Me.NewButton6.LostFocusColour = System.Drawing.Color.LightYellow
        Me.NewButton6.Name = "NewButton6"
        Me.NewButton6.Size = New System.Drawing.Size(112, 40)
        Me.NewButton6.TabIndex = 13
        Me.NewButton6.Text = "&Close"
        Me.NewButton6.UseVisualStyleBackColor = False
        '
        'lblLoanList
        '
        Me.lblLoanList.BackColor = System.Drawing.Color.LightYellow
        Me.lblLoanList.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline)
        Me.lblLoanList.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblLoanList.Location = New System.Drawing.Point(244, 18)
        Me.lblLoanList.Name = "lblLoanList"
        Me.lblLoanList.Size = New System.Drawing.Size(728, 24)
        Me.lblLoanList.TabIndex = 11
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "OD Number"
        Me.ColumnHeader1.Width = 95
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 221
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Status"
        Me.ColumnHeader5.Width = 74
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "ROI"
        Me.ColumnHeader10.Width = 69
        '
        'lvLoanList
        '
        Me.lvLoanList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader7, Me.ColumnHeader4, Me.ColumnHeader16, Me.ColumnHeader5, Me.ColumnHeader10})
        Me.lvLoanList.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLoanList.FullRowSelect = True
        Me.lvLoanList.GridLines = True
        Me.lvLoanList.Location = New System.Drawing.Point(220, 106)
        Me.lvLoanList.Name = "lvLoanList"
        Me.lvLoanList.Size = New System.Drawing.Size(784, 456)
        Me.lvLoanList.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvLoanList.TabIndex = 12
        Me.lvLoanList.UseCompatibleStateImageBehavior = False
        Me.lvLoanList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "OD Limit"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Balance"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 101
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Interest  "
        Me.ColumnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader16.Width = 102
        '
        'btnLoanTran
        '
        Me.btnLoanTran.BackColor = System.Drawing.Color.LightYellow
        Me.btnLoanTran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoanTran.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLoanTran.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoanTran.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoanTran.ForeColor = System.Drawing.Color.Black
        Me.btnLoanTran.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnLoanTran.Location = New System.Drawing.Point(8, 344)
        Me.btnLoanTran.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnLoanTran.Name = "btnLoanTran"
        Me.btnLoanTran.Size = New System.Drawing.Size(178, 40)
        Me.btnLoanTran.TabIndex = 8
        Me.btnLoanTran.Text = " Loan Transaction Details"
        Me.btnLoanTran.UseVisualStyleBackColor = False
        Me.btnLoanTran.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightYellow
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.NewButton1)
        Me.GroupBox2.Controls.Add(Me.btnLoanTran)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 544)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightYellow
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(8, 280)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(184, 40)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "&New OD Account"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'NewButton1
        '
        Me.NewButton1.BackColor = System.Drawing.Color.LightYellow
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.ForeColor = System.Drawing.Color.Black
        Me.NewButton1.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.NewButton1.Image = CType(resources.GetObject("NewButton1.Image"), System.Drawing.Image)
        Me.NewButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton1.Location = New System.Drawing.Point(8, 216)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.LightYellow
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(184, 40)
        Me.NewButton1.TabIndex = 9
        Me.NewButton1.Text = "OD &Transaction"
        Me.NewButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton1.UseVisualStyleBackColor = False
        '
        'frmODList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.CancelButton = Me.NewButton6
        Me.ClientSize = New System.Drawing.Size(1016, 629)
        Me.Controls.Add(Me.lvLoanList)
        Me.Controls.Add(Me.lblLoanList)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.NewButton6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmODList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OD List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "UserDefine Function"

    Public Function fnLoadData() As Boolean
        Dim intCount As Integer = 0
        Dim lstvItems As New ListViewItem

        dvLoan.RowFilter = strFilter
        lvLoanList.Items.Clear()
        While intCount < dvLoan.Count

            lstvItems = lvLoanList.Items.Add(dvLoan.Item(intCount).Item("AccountNo"))
            lstvItems.SubItems.Add(dvLoan.Item(intCount).Item("Name"))
            lstvItems.SubItems.Add(Format(dvLoan.Item(intCount).Item("OdLimit"), "0,00.00"))
            lstvItems.SubItems.Add(Format(dvLoan.Item(intCount).Item("Balance"), "0,00.00"))
            lstvItems.SubItems.Add(Format(dvLoan.Item(intCount).Item("IntAmount"), "0,00.00"))
            lstvItems.SubItems.Add(dvLoan.Item(intCount).Item("AccStatus"))
            lstvItems.SubItems.Add(dvLoan.Item(intCount).Item("ROI") * 100)
            intCount += 1

        End While

    End Function


#End Region

    Private Sub frmODList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If objOD.fnGetODData() Then
            dvLoan = New DataView(objOD.ODLoan, strFilter, "Name", DataViewRowState.OriginalRows)
            fnLoadData()
        End If
    End Sub

    Private Sub txtSearchText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchText.TextChanged

        If cmbSearchBy.SelectedItem = "ODNumber" Then
            strFilter = "AccountNo"
            strFilter = "AccountNo like '" & txtSearchText.Text & "%'"
            fnLoadData()

        ElseIf cmbSearchBy.SelectedItem = "Name" Then
            strFilter = "Name"
            strFilter = "Name like '" & txtSearchText.Text & "%'"
            fnLoadData()
        ElseIf cmbSearchBy.SelectedItem = "Status" Then
            strFilter = "AccStatus"
            strFilter = "AccStatus like '" & txtSearchText.Text & "%'"
            fnLoadData()
        End If

    End Sub

    Private Sub NewButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton6.Click
        Me.Close()
    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click

        If lvLoanList.SelectedItems.Count > 0 Then
            If objOD.fnChekODLAccount(lvLoanList.SelectedItems(0).SubItems(0).Text) Then
                Dim ObjWithDraw As New frmODTransaction
                If lvLoanList.SelectedItems(0).SubItems(5).Text <> "A" Then
                    ObjWithDraw.Panel1.Enabled = False
                Else
                    ObjWithDraw.Panel1.Enabled = True
                End If

                ObjWithDraw.txtAccNo.Text = lvLoanList.SelectedItems(0).SubItems(0).Text
                ObjWithDraw.txtName.Text = lvLoanList.SelectedItems(0).SubItems(1).Text
                ObjWithDraw.ShowDialog(Me)
            End If
        Else
            MsgBox("Please select the item from the OD list", MsgBoxStyle.Information)
        End If

        'If objOverDraftLoan.fnChekODLAccount(Trim(txtLoanNo.Text)) = True Then
        '    Dim ObjWithDraw As New frmODTransaction
        '    ObjWithDraw.txtAccNo.Text = txtLoanNo.Text
        '    ObjWithDraw.txtName.Text = txtName.Text
        '    ObjWithDraw.ShowDialog(Me)
        'Else
        '    MsgBox("Please Enter Valid OD Number", MsgBoxStyle.Information)
        'End If

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim objfrmODCreation As frmODLoanDetails
        objfrmODCreation = frmODLoanDetails.DefInstance
        objfrmODCreation.BringToFront()
        objfrmODCreation.MdiParent = Me.MdiParent
        objfrmODCreation.Show()
        objfrmODCreation = Nothing
    End Sub

    Private Sub lvLoanList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvLoanList.SelectedIndexChanged

    End Sub
End Class
