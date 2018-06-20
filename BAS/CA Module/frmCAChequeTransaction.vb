Public Class frmCAChequeTransaction
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
    Friend WithEvents DTPFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTPTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAccno As BankControls.TextControl
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents lvDepositedCheques As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCAChequeTransaction))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DTPFrom = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.DTPTo = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAccno = New BankControls.TextControl
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.btnCancel = New BankControls.NewButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnSearch = New BankControls.NewButton
        Me.lvDepositedCheques = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DTPFrom)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DTPTo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(16, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(608, 80)
        Me.Panel1.TabIndex = 120
        '
        'DTPFrom
        '
        Me.DTPFrom.CustomFormat = "dd-MMM-yyyy"
        Me.DTPFrom.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFrom.Location = New System.Drawing.Point(152, 41)
        Me.DTPFrom.Name = "DTPFrom"
        Me.DTPFrom.Size = New System.Drawing.Size(152, 23)
        Me.DTPFrom.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(312, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 19)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "To"
        '
        'DTPTo
        '
        Me.DTPTo.CustomFormat = "dd-MMM-yyyy"
        Me.DTPTo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTo.Location = New System.Drawing.Point(352, 41)
        Me.DTPTo.Name = "DTPTo"
        Me.DTPTo.Size = New System.Drawing.Size(168, 23)
        Me.DTPTo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 19)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "From"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(248, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 19)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "Displaying Transactions"
        '
        'txtAccno
        '
        Me.txtAccno.AlphaNumeric = False
        Me.txtAccno.BackColor = System.Drawing.Color.White
        Me.txtAccno.BlankSpace = False
        Me.txtAccno.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccno.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccno.Location = New System.Drawing.Point(112, 16)
        Me.txtAccno.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAccno.Mandatory = False
        Me.txtAccno.Name = "txtAccno"
        Me.txtAccno.ReadOnly = True
        Me.txtAccno.Size = New System.Drawing.Size(152, 23)
        Me.txtAccno.SpecialChar = False
        Me.txtAccno.TabIndex = 115
        Me.txtAccno.Text = ""
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "ChequeStatus"
        Me.ColumnHeader10.Width = 136
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(528, 424)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 40)
        Me.btnCancel.TabIndex = 118
        Me.btnCancel.Text = "Cancel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 19)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "Account No."
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(120, Byte), CType(128, Byte), CType(171, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(272, 16)
        Me.btnSearch.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 116
        '
        'lvDepositedCheques
        '
        Me.lvDepositedCheques.BackColor = System.Drawing.Color.FromArgb(CType(243, Byte), CType(254, Byte), CType(254, Byte))
        Me.lvDepositedCheques.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader10})
        Me.lvDepositedCheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDepositedCheques.FullRowSelect = True
        Me.lvDepositedCheques.GridLines = True
        Me.lvDepositedCheques.Location = New System.Drawing.Point(8, 152)
        Me.lvDepositedCheques.Name = "lvDepositedCheques"
        Me.lvDepositedCheques.Size = New System.Drawing.Size(612, 258)
        Me.lvDepositedCheques.TabIndex = 117
        Me.lvDepositedCheques.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "TransactionDate"
        Me.ColumnHeader4.Width = 115
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ChequeNo"
        Me.ColumnHeader5.Width = 118
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "DepositDate"
        Me.ColumnHeader6.Width = 93
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ChequeAmount"
        Me.ColumnHeader7.Width = 115
        '
        'frmCAChequeTransaction
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(632, 469)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtAccno)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lvDepositedCheques)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCAChequeTransaction"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Current Account Cheque Transaction"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Form Globle Varibales"

    Dim objclsSBAcc As New clsCurrentAccount
    Dim lvItems As New ListViewItem

#End Region

#Region "Functions"

    Public Function fnLoadChqTranDet() As Boolean

        Dim intCount As Integer
        If objclsSBAcc.fnGetCheqTranDet(txtAccno.Text) Then
            While intCount < objclsSBAcc.ChqTranDetTable.Rows.Count
                lvItems = lvDepositedCheques.Items.Add(Format(objclsSBAcc.ChqTranDetTable.Rows(intCount).Item("TranDate"), "yyyy-MM-dd"))
                lvItems.SubItems.Add(objclsSBAcc.ChqTranDetTable.Rows(intCount).Item("ChequeNo"))
                lvItems.SubItems.Add(Format(objclsSBAcc.ChqTranDetTable.Rows(intCount).Item("DepositDate"), "yyyy-MM-dd"))
                lvItems.SubItems.Add(objclsSBAcc.ChqTranDetTable.Rows(intCount).Item("ChequeAmount"))
                lvItems.SubItems.Add(objclsSBAcc.ChqTranDetTable.Rows(intCount).Item("ChequeStatus"))
                intCount += 1
            End While
        End If

    End Function

    Public Function fnLoadChqDateTran() As Boolean

        Dim intCount As Integer
        objclsSBAcc.fnGetChqDateTran(DTPFrom.Value, DTPTo.Value, txtAccno.Text)
        lvDepositedCheques.Items.Clear()
        While intCount < objclsSBAcc.ChqTranDetTable.Rows.Count
            lvItems = lvDepositedCheques.Items.Add(Format(objclsSBAcc.ChqTranDetTable.Rows(intCount).Item("TrDate"), "yyyy-MM-dd"))
            lvItems.SubItems.Add(objclsSBAcc.ChqTranDetTable.Rows(intCount).Item("ChequeNo"))
            lvItems.SubItems.Add(Format(objclsSBAcc.ChqTranDetTable.Rows(intCount).Item("DepositDate"), "yyyy-MM-dd"))
            lvItems.SubItems.Add(objclsSBAcc.ChqTranDetTable.Rows(intCount).Item("ChequeAmount"))
            lvItems.SubItems.Add(objclsSBAcc.ChqTranDetTable.Rows(intCount).Item("ChequeStatus"))
            intCount += 1
        End While

    End Function

#End Region

    Private Sub frmCAChequeTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'fnLoadChqTranDet()
        DTPFrom.Value = Date.Now
        DTPTo.Value = Date.Now


    End Sub

    Private Sub DTPFrom_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTPFrom.ValueChanged, DTPTo.ValueChanged
        fnLoadChqDateTran()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim objSBAccSearch As New frmCAccSearch
        objSBAccSearch.strCAccountNo = String.Empty
        objSBAccSearch.ShowDialog(Me)
        If objSBAccSearch.strCAccountNo <> String.Empty Then
            txtAccno.Text = objSBAccSearch.strCAccountNo
        End If
        objSBAccSearch.Dispose()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
