Public Class frmSBStopChequeDet
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
    Friend WithEvents lvDepositedCheques As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As BankControls.TextControl
    Friend WithEvents dtpChequeDepDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnCancel As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSBStopChequeDet))
        Me.lvDepositedCheques = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSearch = New BankControls.NewButton
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSearch = New BankControls.TextControl
        Me.dtpChequeDepDate = New System.Windows.Forms.DateTimePicker
        Me.lblMessage = New System.Windows.Forms.Label
        Me.btnCancel = New BankControls.NewButton
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvDepositedCheques
        '
        Me.lvDepositedCheques.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lvDepositedCheques.BackColor = System.Drawing.Color.FromArgb(CType(243, Byte), CType(254, Byte), CType(254, Byte))
        Me.lvDepositedCheques.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lvDepositedCheques.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDepositedCheques.FullRowSelect = True
        Me.lvDepositedCheques.GridLines = True
        Me.lvDepositedCheques.Location = New System.Drawing.Point(8, 112)
        Me.lvDepositedCheques.MultiSelect = False
        Me.lvDepositedCheques.Name = "lvDepositedCheques"
        Me.lvDepositedCheques.Size = New System.Drawing.Size(736, 322)
        Me.lvDepositedCheques.TabIndex = 111
        Me.lvDepositedCheques.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "AccountNo."
        Me.ColumnHeader1.Width = 68
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "BankName"
        Me.ColumnHeader2.Width = 78
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "BranchName"
        Me.ColumnHeader3.Width = 74
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ChequeDate"
        Me.ColumnHeader4.Width = 79
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ChequeNo."
        Me.ColumnHeader5.Width = 84
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "DepositDate"
        Me.ColumnHeader6.Width = 93
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ChequeAmount"
        Me.ColumnHeader7.Width = 87
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ClearanceDate"
        Me.ColumnHeader8.Width = 0
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "BankCharges"
        Me.ColumnHeader9.Width = 77
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "ReferenceNo."
        Me.ColumnHeader10.Width = 0
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Remarks"
        Me.ColumnHeader11.Width = 81
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.cmbType)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.dtpChequeDepDate)
        Me.Panel1.Location = New System.Drawing.Point(8, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 56)
        Me.Panel1.TabIndex = 110
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(256, 16)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(32, 24)
        Me.btnSearch.TabIndex = 110
        Me.btnSearch.Text = "Search"
        Me.btnSearch.Visible = False
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Items.AddRange(New Object() {"ChequeNo", "AccountNo", "BankName", "BranchName", "ChequeAmount", "ReferenceNo", "DepositDate", "BankCharges"})
        Me.cmbType.Location = New System.Drawing.Point(472, 16)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(216, 24)
        Me.cmbType.TabIndex = 108
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(392, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 19)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "SearchBy"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "SearchText"
        '
        'txtSearch
        '
        Me.txtSearch.AlphaNumeric = True
        Me.txtSearch.BlankSpace = False
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSearch.Location = New System.Drawing.Point(96, 16)
        Me.txtSearch.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtSearch.Mandatory = False
        Me.txtSearch.MaxLength = 50
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(152, 23)
        Me.txtSearch.SpecialChar = False
        Me.txtSearch.TabIndex = 105
        Me.txtSearch.Text = ""
        '
        'dtpChequeDepDate
        '
        Me.dtpChequeDepDate.CustomFormat = "dd / MMM / yyyy"
        Me.dtpChequeDepDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpChequeDepDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpChequeDepDate.Location = New System.Drawing.Point(96, 16)
        Me.dtpChequeDepDate.MaxDate = New Date(2331, 11, 17, 0, 0, 0, 0)
        Me.dtpChequeDepDate.Name = "dtpChequeDepDate"
        Me.dtpChequeDepDate.Size = New System.Drawing.Size(152, 23)
        Me.dtpChequeDepDate.TabIndex = 109
        Me.dtpChequeDepDate.Value = New Date(2007, 10, 11, 0, 0, 0, 0)
        Me.dtpChequeDepDate.Visible = False
        '
        'lblMessage
        '
        Me.lblMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(8, 86)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(287, 19)
        Me.lblMessage.TabIndex = 112
        Me.lblMessage.Text = "There are 0 records found for your search"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(648, 448)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 40)
        Me.btnCancel.TabIndex = 114
        Me.btnCancel.Text = "Cancel"
        '
        'frmSBStopChequeDet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(752, 501)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lvDepositedCheques)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblMessage)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSBStopChequeDet"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SBStopChequeDet"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"

    Dim objSBAccount As New clsSavingsBank
    Dim dvItems As New DataView
    Dim strFilter As String = "AccountNo like '%'"

#End Region

#Region "Functions"

    Public Function fnGetStopPayDet() As Boolean
        Dim intCount As Integer
        Dim lstvItems As New ListViewItem
        lvDepositedCheques.Items.Clear()
        Try
            While intCount < dvItems.Count

                lstvItems = lvDepositedCheques.Items.Add(dvItems.Item(intCount).Item("AccountNo"))
                lstvItems.SubItems.Add(dvItems.Item(intCount).Item("BankName"))
                lstvItems.SubItems.Add(dvItems.Item(intCount).Item("BranchName"))
                lstvItems.SubItems.Add(Format(dvItems.Item(intCount).Item("ChequeDate"), "yyyy-MM-dd"))
                lstvItems.SubItems.Add(dvItems.Item(intCount).Item("ChequeNo"))
                lstvItems.SubItems.Add(Format(dvItems.Item(intCount).Item("DepositDate"), "yyyy-MM-dd"))
                lstvItems.SubItems.Add(dvItems.Item(intCount).Item("ChequeAmount"))
                ' lstvItems.SubItems.Add(Format(dvItems.Item(intCount).Item("ClearanceDate"), "yyyy-MM-dd"))
                lstvItems.SubItems.Add("")
                lstvItems.SubItems.Add(dvItems.Item(intCount).Item("BankCharges"))
                lstvItems.SubItems.Add("")
                ' lstvItems.SubItems.Add(dvItems.Item(intCount).Item("RefNo"))
                lstvItems.SubItems.Add(dvItems.Item(intCount).Item("Remarks"))
                intCount += 1

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

#End Region

#Region "Events"

    Private Sub frmSBStopChequeDet_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If objSBAccount.fnSbChqStopPayDet Then
            dvItems = New DataView(objSBAccount.ChqStopDet, strFilter, "AccountNo", DataViewRowState.OriginalRows)
            fnGetStopPayDet()
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

#End Region

    Private Sub cmbType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged

        If cmbType.SelectedItem = "ChequeNo" Then
            dtpChequeDepDate.Visible = False
            btnSearch.Visible = False
            txtSearch.Visible = True
        ElseIf cmbType.SelectedItem = "AccountNo" Then
            dtpChequeDepDate.Visible = False
            btnSearch.Visible = False
            txtSearch.Visible = True
        ElseIf cmbType.SelectedItem = "BankName" Then
            dtpChequeDepDate.Visible = False
            btnSearch.Visible = False
            txtSearch.Visible = True
        ElseIf cmbType.SelectedItem = "BranchName" Then
            dtpChequeDepDate.Visible = False
            btnSearch.Visible = False
            txtSearch.Visible = True
        ElseIf cmbType.SelectedItem = "ChequeAmount" Then
            dtpChequeDepDate.Visible = False
            btnSearch.Visible = False
            txtSearch.Visible = True
        ElseIf cmbType.SelectedItem = "ReferenceNo" Then
            dtpChequeDepDate.Visible = False
            btnSearch.Visible = False
            txtSearch.Visible = True
        ElseIf cmbType.SelectedItem = "BankCharges" Then
            dtpChequeDepDate.Visible = False
            btnSearch.Visible = False
            txtSearch.Visible = True
        ElseIf cmbType.SelectedItem = "DepositDate" Then
            dtpChequeDepDate.Visible = True
            btnSearch.Visible = True
            txtSearch.Visible = False

        End If

    End Sub


    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged

        If cmbType.SelectedItem = "ChequeNo" Then
            strFilter = "ChequeNo like '" & Val(txtSearch.Text) & "%'"
            fnGetStopPayDet()
        ElseIf cmbType.SelectedItem = "AccountNo" Then
            strFilter = "AccountNo like '" & txtSearch.Text & "%'"
            fnGetStopPayDet()
        ElseIf cmbType.SelectedItem = "BankName" Then
            strFilter = "BankName like '" & txtSearch.Text & "%'"
            fnGetStopPayDet()
        ElseIf cmbType.SelectedItem = "BranchName" Then
            strFilter = "BranchName like '" & txtSearch.Text & "%'"
            fnGetStopPayDet()
        ElseIf cmbType.SelectedItem = "ChequeAmount" Then
            strFilter = "ChequeAmount = '" & Val(txtSearch.Text) & "'"
            fnGetStopPayDet()
        ElseIf cmbType.SelectedItem = "ChequeStatus" Then
            strFilter = "ChequeStatus like '" & txtSearch.Text & "%'"
            fnGetStopPayDet()
        ElseIf cmbType.SelectedItem = "ReferenceNo" Then
            strFilter = "ReferenceNo like '" & txtSearch.Text & "%'"
            fnGetStopPayDet()
        ElseIf cmbType.SelectedItem = "BankCharges" Then
            strFilter = "BankCharges = '" & Val(txtSearch.Text) & "'"
            fnGetStopPayDet()
        End If

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        If cmbType.SelectedItem = "DepositDate" Then
            strFilter = "DepositDate = '" & dtpChequeDepDate.Value & "'"
            fnGetStopPayDet()
        End If

    End Sub

    Private Sub lvDepositedCheques_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvDepositedCheques.DoubleClick

        Dim objStopPay As New frmSBChequeStopPay
        objStopPay.txtAccNo.Text = lvDepositedCheques.SelectedItems(0).SubItems(0).Text
        objStopPay.txtSBChequeNo.Text = lvDepositedCheques.SelectedItems(0).SubItems(4).Text
        objStopPay.txtBankCharges.Text = lvDepositedCheques.SelectedItems(0).SubItems(8).Text
        objStopPay.txtNarration.Text = lvDepositedCheques.SelectedItems(0).SubItems(10).Text
        objStopPay.txtChequeAmount.Text = lvDepositedCheques.SelectedItems(0).SubItems(6).Text
        objStopPay.txtRefNo.Text = lvDepositedCheques.SelectedItems(0).SubItems(9).Text
        objStopPay.ShowDialog()

    End Sub

End Class
