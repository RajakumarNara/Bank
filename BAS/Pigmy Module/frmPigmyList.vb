Public Class frmPigmyList
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtSearchText As BankControls.TextControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents lvPigmyList As System.Windows.Forms.ListView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnRepayment As BankControls.NewButton
    Friend WithEvents btnLoanDisb As BankControls.NewButton
    Friend WithEvents btnPigmyDeposit As BankControls.NewButton
    Friend WithEvents NewButton1 As BankControls.NewButton
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents NewButton3 As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPigmyList))
        Me.lvPigmyList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtSearchText = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbSearchBy = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClose = New BankControls.NewButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.NewButton3 = New BankControls.NewButton
        Me.btnRepayment = New BankControls.NewButton
        Me.btnLoanDisb = New BankControls.NewButton
        Me.btnPigmyDeposit = New BankControls.NewButton
        Me.NewButton1 = New BankControls.NewButton
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvPigmyList
        '
        Me.lvPigmyList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader5})
        Me.lvPigmyList.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPigmyList.FullRowSelect = True
        Me.lvPigmyList.GridLines = True
        Me.lvPigmyList.Location = New System.Drawing.Point(264, 128)
        Me.lvPigmyList.MultiSelect = False
        Me.lvPigmyList.Name = "lvPigmyList"
        Me.lvPigmyList.Size = New System.Drawing.Size(704, 376)
        Me.lvPigmyList.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvPigmyList.TabIndex = 0
        Me.lvPigmyList.UseCompatibleStateImageBehavior = False
        Me.lvPigmyList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Pigmy AccNo ."
        Me.ColumnHeader1.Width = 101
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 219
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Pigmy Collection"
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Pigmy Deposit"
        Me.ColumnHeader4.Width = 90
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Remarks"
        Me.ColumnHeader6.Width = 199
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Status"
        Me.ColumnHeader5.Width = 50
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtSearchText)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbSearchBy)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(264, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 56)
        Me.Panel1.TabIndex = 1
        '
        'txtSearchText
        '
        Me.txtSearchText.AlphaNumeric = True
        Me.txtSearchText.BlankSpace = True
        Me.txtSearchText.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchText.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSearchText.Location = New System.Drawing.Point(504, 16)
        Me.txtSearchText.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSearchText.Mandatory = False
        Me.txtSearchText.MaxLength = 30
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(160, 24)
        Me.txtSearchText.SpecialChar = True
        Me.txtSearchText.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(400, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Search Text :"
        '
        'cmbSearchBy
        '
        Me.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchBy.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchBy.Items.AddRange(New Object() {"Name", "AccNo"})
        Me.cmbSearchBy.Location = New System.Drawing.Point(104, 16)
        Me.cmbSearchBy.Name = "cmbSearchBy"
        Me.cmbSearchBy.Size = New System.Drawing.Size(169, 24)
        Me.cmbSearchBy.TabIndex = 56
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 16)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Search By :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(264, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(704, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "BNN Customer List"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.Beige
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(864, 512)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 88
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.NewButton3)
        Me.Panel2.Controls.Add(Me.btnRepayment)
        Me.Panel2.Controls.Add(Me.btnLoanDisb)
        Me.Panel2.Controls.Add(Me.btnPigmyDeposit)
        Me.Panel2.Controls.Add(Me.NewButton1)
        Me.Panel2.Location = New System.Drawing.Point(16, 18)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(216, 486)
        Me.Panel2.TabIndex = 89
        '
        'NewButton3
        '
        Me.NewButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.NewButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton3.ForeColor = System.Drawing.Color.Black
        Me.NewButton3.GotFocusColour = System.Drawing.Color.Beige
        Me.NewButton3.Image = CType(resources.GetObject("NewButton3.Image"), System.Drawing.Image)
        Me.NewButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton3.Location = New System.Drawing.Point(16, 304)
        Me.NewButton3.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.NewButton3.Name = "NewButton3"
        Me.NewButton3.Size = New System.Drawing.Size(184, 40)
        Me.NewButton3.TabIndex = 51
        Me.NewButton3.Text = "Pigmy Deposit"
        Me.NewButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton3.UseVisualStyleBackColor = False
        '
        'btnRepayment
        '
        Me.btnRepayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnRepayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRepayment.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRepayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRepayment.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepayment.ForeColor = System.Drawing.Color.Black
        Me.btnRepayment.GotFocusColour = System.Drawing.Color.Beige
        Me.btnRepayment.Image = CType(resources.GetObject("btnRepayment.Image"), System.Drawing.Image)
        Me.btnRepayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRepayment.Location = New System.Drawing.Point(16, 120)
        Me.btnRepayment.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnRepayment.Name = "btnRepayment"
        Me.btnRepayment.Size = New System.Drawing.Size(184, 40)
        Me.btnRepayment.TabIndex = 3
        Me.btnRepayment.Text = "New Pigmy Creation"
        Me.btnRepayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRepayment.UseVisualStyleBackColor = False
        '
        'btnLoanDisb
        '
        Me.btnLoanDisb.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnLoanDisb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoanDisb.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLoanDisb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoanDisb.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoanDisb.ForeColor = System.Drawing.Color.Black
        Me.btnLoanDisb.GotFocusColour = System.Drawing.Color.Beige
        Me.btnLoanDisb.Image = CType(resources.GetObject("btnLoanDisb.Image"), System.Drawing.Image)
        Me.btnLoanDisb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoanDisb.Location = New System.Drawing.Point(16, 184)
        Me.btnLoanDisb.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnLoanDisb.Name = "btnLoanDisb"
        Me.btnLoanDisb.Size = New System.Drawing.Size(184, 40)
        Me.btnLoanDisb.TabIndex = 3
        Me.btnLoanDisb.Text = "Pigmy Transaction"
        Me.btnLoanDisb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLoanDisb.UseVisualStyleBackColor = False
        '
        'btnPigmyDeposit
        '
        Me.btnPigmyDeposit.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnPigmyDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPigmyDeposit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPigmyDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPigmyDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPigmyDeposit.ForeColor = System.Drawing.Color.Black
        Me.btnPigmyDeposit.GotFocusColour = System.Drawing.Color.Beige
        Me.btnPigmyDeposit.Image = CType(resources.GetObject("btnPigmyDeposit.Image"), System.Drawing.Image)
        Me.btnPigmyDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPigmyDeposit.Location = New System.Drawing.Point(16, 248)
        Me.btnPigmyDeposit.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnPigmyDeposit.Name = "btnPigmyDeposit"
        Me.btnPigmyDeposit.Size = New System.Drawing.Size(184, 40)
        Me.btnPigmyDeposit.TabIndex = 3
        Me.btnPigmyDeposit.Text = "Pigmy Collection"
        Me.btnPigmyDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPigmyDeposit.UseVisualStyleBackColor = False
        '
        'NewButton1
        '
        Me.NewButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.ForeColor = System.Drawing.Color.Black
        Me.NewButton1.GotFocusColour = System.Drawing.Color.Beige
        Me.NewButton1.Image = CType(resources.GetObject("NewButton1.Image"), System.Drawing.Image)
        Me.NewButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton1.Location = New System.Drawing.Point(16, 368)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(184, 40)
        Me.NewButton1.TabIndex = 3
        Me.NewButton1.Text = "Pigmy Premature"
        Me.NewButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton1.UseVisualStyleBackColor = False
        '
        'frmPigmyList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(984, 567)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lvPigmyList)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPigmyList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pigmy List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmPigmyList
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmPigmyList
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmPigmyList
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmPigmyList)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Variables"

    Dim objPigmyAcc As New clsPigmyAccount
    Dim objfrmPigmyAcc As New frmPigmyAccCreation
    Dim strFilter As String = "Name like '%'"
    Dim dvItems As New DataView
    Public strAccNo As String
    Public strName As String

#End Region

#Region "Functions"

    Public Function fnGetPigmyList() As Boolean
        Dim intCount As Integer = 0
        Dim lstvItems As New ListViewItem
        dvItems.RowFilter = strFilter
        lvPigmyList.Items.Clear()

        While intCount < dvItems.Count

            lstvItems = lvPigmyList.Items.Add(dvItems.Item(intCount).Item("PigmyAccNo"))
            lstvItems.SubItems.Add(dvItems.Item(intCount).Item("Name"))
            lstvItems.SubItems.Add(Format(dvItems.Item(intCount).Item("AvailCollection"), "0,00.00"))
            lstvItems.SubItems.Add(Format(dvItems.Item(intCount).Item("AvailDeposit"), "0,00.00"))
            lstvItems.SubItems.Add(dvItems.Item(intCount).Item("Remarks"))

            lstvItems.SubItems.Add(dvItems.Item(intCount).Item("AccStatus"))
            intCount += 1

        End While

    End Function

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Public Sub frmPigmyList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label1.Text = "List of Pigmy Account Holders as on '" & Date.Today & "'"
        Try
            If objPigmyAcc.fnGetPigmyAcc Then
                dvItems = New DataView(objPigmyAcc.PigmyListTable, strFilter, "Name", DataViewRowState.OriginalRows)
                fnGetPigmyList()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnRepayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepayment.Click

        objfrmPigmyAcc = frmPigmyAccCreation.DefInstance
        objfrmPigmyAcc.MdiParent = Me.MdiParent
        objfrmPigmyAcc.BringToFront()
        objfrmPigmyAcc.Show()
        objfrmPigmyAcc = Nothing

    End Sub

    Private Sub btnPigmyDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPigmyDeposit.Click

        Dim intCount As Integer
        Dim chrStatus As Char
        If lvPigmyList.Items.Count > 0 Then
            If lvPigmyList.SelectedItems.Count = 0 Then
                MsgBox("Please select account from the List")
            Else
                If lvPigmyList.SelectedItems(intCount).SubItems(5).Text <> "C" Then
                    Dim objPGDeposit As New frmPigmyDeposit
                    objPGDeposit.strAccNo = lvPigmyList.SelectedItems(intCount).SubItems(0).Text
                    objPGDeposit.strName = lvPigmyList.SelectedItems(intCount).SubItems(1).Text
                    objPGDeposit.ShowDialog(Me)
                Else
                    MsgBox("Account closed,amount cannot be deposited", MsgBoxStyle.Exclamation, "Pigmy Module")
                End If
            End If
            frmPigmyList_Load(sender, e)
        End If


    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click

        Dim intCount As Integer

        If lvPigmyList.Items.Count > 0 Then
            If lvPigmyList.SelectedItems.Count = 0 Then
                MsgBox("Please select the item from the list", MsgBoxStyle.Information, "BNN Module")
                lvPigmyList.Focus()
            Else
                If lvPigmyList.SelectedItems(intCount).SubItems(4).Text <> "C" Then
                    Dim objPigmyWithDrawl As New frmPigmyPreMature
                    objPigmyWithDrawl.strAccNo = lvPigmyList.SelectedItems(intCount).SubItems(0).Text
                    objPigmyWithDrawl.strName = lvPigmyList.SelectedItems(intCount).SubItems(1).Text
                    objPigmyWithDrawl.ShowDialog(Me)

                Else
                    MsgBox("Account closed,amount cannot be deposited", MsgBoxStyle.Exclamation)
                End If
            End If
            frmPigmyList_Load(sender, e)
        End If

    End Sub

    Private Sub btnLoanDisb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoanDisb.Click
        If lvPigmyList.Items.Count > 0 Then
            If lvPigmyList.SelectedItems.Count = 0 Then
                MsgBox("Please select the account from the list", MsgBoxStyle.Exclamation)
                lvPigmyList.Focus()
            Else
                Dim objPigmyTran As New frmPigmyTransaction
                Dim intCount As Integer
                objPigmyTran.strAccNo = lvPigmyList.SelectedItems(intCount).SubItems(0).Text
                objPigmyTran.strName = lvPigmyList.SelectedItems(intCount).SubItems(1).Text
                objPigmyTran.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub txtSearchText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchText.TextChanged

        If cmbSearchBy.SelectedItem = "Name" Then
            strFilter = "Name like'" & txtSearchText.Text & "%'"
            fnGetPigmyList()
        ElseIf cmbSearchBy.SelectedItem = "AccNo" Then
            strFilter = "PigmyAccNo like '" & txtSearchText.Text & "%'"
            fnGetPigmyList()
        End If

    End Sub


    Private Sub lvPigmyList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvPigmyList.DoubleClick
        If lvPigmyList.Items.Count > 0 Then
            If lvPigmyList.SelectedItems.Count > 0 Then
                objfrmPigmyAcc = frmPigmyAccCreation.DefInstance
                objfrmPigmyAcc.txtAccNo.Text = lvPigmyList.SelectedItems(0).SubItems(0).Text
                objfrmPigmyAcc.txtName.Text = lvPigmyList.SelectedItems(0).SubItems(1).Text
                objfrmPigmyAcc.MdiParent = Me.MdiParent

                objfrmPigmyAcc.BringToFront()
                objfrmPigmyAcc.Show()
                objfrmPigmyAcc = Nothing

            Else
                MsgBox("Please select the item from pigmy list", MsgBoxStyle.Exclamation, " BNN Module")
            End If
        End If
    End Sub

    Private Sub NewButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton3.Click

        Dim intCount As Integer
        Dim chrStatus As Char
        If lvPigmyList.Items.Count > 0 Then
            If lvPigmyList.SelectedItems.Count = 0 Then
                MsgBox("Please select account from the List")
            Else
                If lvPigmyList.SelectedItems(intCount).SubItems(5).Text <> "C" Then
                    Dim objPGDeposit As New frmPigmyTransfer
                    objPGDeposit.strAccNo = lvPigmyList.SelectedItems(intCount).SubItems(0).Text
                    objPGDeposit.strName = lvPigmyList.SelectedItems(intCount).SubItems(1).Text
                    objPGDeposit.ShowDialog(Me)
                Else
                    MsgBox("Account closed,amount cannot be deposited", MsgBoxStyle.Exclamation, "Pigmy Module")
                End If
            End If
            frmPigmyList_Load(sender, e)
        End If


    End Sub

End Class
