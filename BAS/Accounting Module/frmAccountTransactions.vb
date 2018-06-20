Public Class frmAccountTransactions
    Inherits System.Windows.Forms.Form

#Region " Form Global Variables"
    Dim objAccount As New clsAccount
    Dim objMember As New clsMember
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents lblAccountNo As System.Windows.Forms.Label
    Friend WithEvents txtAccountNo As BankControls.TextControl
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents lvTransactions As System.Windows.Forms.ListView
    Friend WithEvents VNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPrint As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAccountTransactions))
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.lblAccountNo = New System.Windows.Forms.Label
        Me.txtAccountNo = New BankControls.TextControl
        Me.lvTransactions = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.VNo = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.btnClose = New BankControls.NewButton
        Me.btnPrint = New BankControls.NewButton
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(296, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 19)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Name :"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtName.BlankSpace = False
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtName.Location = New System.Drawing.Point(352, 24)
        Me.txtName.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtName.Mandatory = False
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(248, 23)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 73
        Me.txtName.TabStop = False
        Me.txtName.Text = ""
        '
        'lblAccountNo
        '
        Me.lblAccountNo.AutoSize = True
        Me.lblAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountNo.Location = New System.Drawing.Point(48, 27)
        Me.lblAccountNo.Name = "lblAccountNo"
        Me.lblAccountNo.Size = New System.Drawing.Size(106, 19)
        Me.lblAccountNo.TabIndex = 70
        Me.lblAccountNo.Text = "Account  No. : "
        '
        'txtAccountNo
        '
        Me.txtAccountNo.AlphaNumeric = False
        Me.txtAccountNo.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtAccountNo.BlankSpace = False
        Me.txtAccountNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountNo.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtAccountNo.Location = New System.Drawing.Point(160, 24)
        Me.txtAccountNo.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtAccountNo.Mandatory = False
        Me.txtAccountNo.Name = "txtAccountNo"
        Me.txtAccountNo.ReadOnly = True
        Me.txtAccountNo.Size = New System.Drawing.Size(104, 23)
        Me.txtAccountNo.SpecialChar = False
        Me.txtAccountNo.TabIndex = 72
        Me.txtAccountNo.TabStop = False
        Me.txtAccountNo.Text = ""
        '
        'lvTransactions
        '
        Me.lvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvTransactions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.VNo, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvTransactions.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvTransactions.FullRowSelect = True
        Me.lvTransactions.GridLines = True
        Me.lvTransactions.HideSelection = False
        Me.lvTransactions.Location = New System.Drawing.Point(16, 64)
        Me.lvTransactions.MultiSelect = False
        Me.lvTransactions.Name = "lvTransactions"
        Me.lvTransactions.Size = New System.Drawing.Size(672, 232)
        Me.lvTransactions.TabIndex = 74
        Me.lvTransactions.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sl No."
        Me.ColumnHeader1.Width = 42
        '
        'VNo
        '
        Me.VNo.Text = "VNo"
        Me.VNo.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Type"
        Me.ColumnHeader2.Width = 75
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Reference No."
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date"
        Me.ColumnHeader4.Width = 85
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Narration"
        Me.ColumnHeader5.Width = 281
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Amount"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 84
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
        Me.btnClose.Location = New System.Drawing.Point(584, 312)
        Me.btnClose.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "&Close"
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.GotFocusColour = System.Drawing.Color.Gray
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(16, 312)
        Me.btnPrint.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(120, 40)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "&Print"
        '
        'frmAccountTransactions
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(690, 359)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lvTransactions)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblAccountNo)
        Me.Controls.Add(Me.txtAccountNo)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccountTransactions"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Transactions"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Sub Routines"

    Sub sbLoadMember()
        Dim objDT As DataTable
        If objMember.fnGetMemberDetails(txtAccountNo.Text) Then
            objDT = objMember.MemberTable
            txtAccountNo.Text = objDT.Rows(0).Item("MemberNo")
            txtName.Text = objDT.Rows(0).Item("Name")
        End If

    End Sub

    Sub sbLoadTransactions()
        Dim objDT As New DataTable
        Dim intCounter As Integer = 0
        Dim lvItem As ListViewItem

        lvTransactions.Items.Clear()
        If objAccount.fnGetTransactions(txtAccountNo.Text) Then
            objDT = objAccount.TransactionTable
            While intCounter < objDT.Rows.Count
                lvItem = lvTransactions.Items.Add(intCounter + 1)
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("VoucherNo"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("Type"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("RefNo"))
                lvItem.SubItems.Add(Format(objDT.Rows(intCounter).Item("VDate"), "dd-MMM-yyyy"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("Narration"))
                lvItem.SubItems.Add(objDT.Rows(intCounter).Item("Amount"))
                intCounter += 1
            End While
        End If
    End Sub
#End Region

#Region "Events "

    Private Sub frmAccountTransactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If txtAccountNo.Text <> "" Then
            sbLoadMember()
            sbLoadTransactions()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub lvTransactions_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvTransactions.DoubleClick

        If lvTransactions.SelectedItems.Count > 0 Then
            Dim objfrmVoucherDetails As New frmVoucherDetails
            objfrmVoucherDetails.VoucherNo = lvTransactions.SelectedItems(0).SubItems(1).Text
            objfrmVoucherDetails.VoucherDate = lvTransactions.SelectedItems(0).SubItems(4).Text
            objfrmVoucherDetails.ReferenceNo = lvTransactions.SelectedItems(0).SubItems(3).Text
            objfrmVoucherDetails.ShowDialog(Me)
            objfrmVoucherDetails = Nothing
        Else
            MsgBox("Select Record ", MsgBoxStyle.Information, Me.Text)
        End If

    End Sub

    Private Sub lvTransactions_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvTransactions.KeyDown
        If e.KeyData = Keys.Enter Then
            lvTransactions_DoubleClick(sender, e)
        End If
    End Sub


#End Region

End Class
