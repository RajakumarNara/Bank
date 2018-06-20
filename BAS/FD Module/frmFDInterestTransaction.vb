Public Class frmFDInterestTransaction
    Inherits System.Windows.Forms.Form

    Dim objFd As New clsFDAccount
    Dim objDT As DataTable
    Dim strFDNo As String
    Dim strAccountNo As String
    Dim SchemeType As String
    Dim intReceiptNo As Integer
    Dim dblFDAmount As Double
    Dim intLedgerNo As Integer
    Dim dtpFDTrDate As Date
    Dim dtpFDDate As Date
    Dim intTransactionID As Integer
    Dim intCount As Integer = 0
    Dim chaDepositType As Char
    Dim objTempDt As New DataTable
    Dim AutoIncreRefNo As Integer


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
    Friend WithEvents lvInterest As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents slNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnGetPayment As BankControls.NewButton
    Friend WithEvents btnProvision As BankControls.NewButton
    Friend WithEvents btnPayment As BankControls.NewButton
    Friend WithEvents btnGetProvision As BankControls.NewButton
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpTransactionDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents cmbDepositType As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFDInterestTransaction))
        Me.lvInterest = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.slNo = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnGetPayment = New BankControls.NewButton
        Me.btnProvision = New BankControls.NewButton
        Me.btnPayment = New BankControls.NewButton
        Me.btnClose = New BankControls.NewButton
        Me.btnGetProvision = New BankControls.NewButton
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label16 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.txtReceiptNo = New BankControls.NumericControl
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpTransactionDate = New System.Windows.Forms.DateTimePicker
        Me.Label39 = New System.Windows.Forms.Label
        Me.cmbDepositType = New System.Windows.Forms.ComboBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvInterest
        '
        Me.lvInterest.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lvInterest.CheckBoxes = True
        Me.lvInterest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader7, Me.ColumnHeader3, Me.ColumnHeader4, Me.slNo, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvInterest.FullRowSelect = True
        Me.lvInterest.GridLines = True
        Me.lvInterest.Location = New System.Drawing.Point(16, 88)
        Me.lvInterest.MultiSelect = False
        Me.lvInterest.Name = "lvInterest"
        Me.lvInterest.Size = New System.Drawing.Size(712, 296)
        Me.lvInterest.TabIndex = 6
        Me.lvInterest.UseCompatibleStateImageBehavior = False
        Me.lvInterest.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Account No."
        Me.ColumnHeader1.Width = 101
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 217
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Int Date"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Int Amount"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Status"
        Me.ColumnHeader4.Width = 80
        '
        'slNo
        '
        Me.slNo.Text = "SlNo."
        Me.slNo.Width = 0
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Trans Account No."
        Me.ColumnHeader5.Width = 93
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "DType"
        Me.ColumnHeader6.Width = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnGetPayment)
        Me.Panel1.Controls.Add(Me.btnProvision)
        Me.Panel1.Controls.Add(Me.btnPayment)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnGetProvision)
        Me.Panel1.Location = New System.Drawing.Point(736, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(152, 368)
        Me.Panel1.TabIndex = 6
        '
        'btnGetPayment
        '
        Me.btnGetPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnGetPayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGetPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGetPayment.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetPayment.ForeColor = System.Drawing.Color.Black
        Me.btnGetPayment.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGetPayment.Image = CType(resources.GetObject("btnGetPayment.Image"), System.Drawing.Image)
        Me.btnGetPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGetPayment.Location = New System.Drawing.Point(10, 96)
        Me.btnGetPayment.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnGetPayment.Name = "btnGetPayment"
        Me.btnGetPayment.Size = New System.Drawing.Size(128, 40)
        Me.btnGetPayment.TabIndex = 8
        Me.btnGetPayment.Text = "&Get Payment Accounts"
        Me.btnGetPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGetPayment.UseVisualStyleBackColor = False
        '
        'btnProvision
        '
        Me.btnProvision.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnProvision.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProvision.Enabled = False
        Me.btnProvision.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProvision.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProvision.ForeColor = System.Drawing.Color.Black
        Me.btnProvision.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnProvision.Image = CType(resources.GetObject("btnProvision.Image"), System.Drawing.Image)
        Me.btnProvision.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProvision.Location = New System.Drawing.Point(10, 160)
        Me.btnProvision.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnProvision.Name = "btnProvision"
        Me.btnProvision.Size = New System.Drawing.Size(128, 40)
        Me.btnProvision.TabIndex = 9
        Me.btnProvision.Text = "Int &Provision"
        Me.btnProvision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProvision.UseVisualStyleBackColor = False
        '
        'btnPayment
        '
        Me.btnPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPayment.Enabled = False
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPayment.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.ForeColor = System.Drawing.Color.Black
        Me.btnPayment.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPayment.Image = CType(resources.GetObject("btnPayment.Image"), System.Drawing.Image)
        Me.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayment.Location = New System.Drawing.Point(10, 224)
        Me.btnPayment.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(128, 40)
        Me.btnPayment.TabIndex = 10
        Me.btnPayment.Text = "&Int payment"
        Me.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(10, 288)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(128, 40)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "&Close"
        '
        'btnGetProvision
        '
        Me.btnGetProvision.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnGetProvision.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGetProvision.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGetProvision.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetProvision.ForeColor = System.Drawing.Color.Black
        Me.btnGetProvision.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGetProvision.Image = CType(resources.GetObject("btnGetProvision.Image"), System.Drawing.Image)
        Me.btnGetProvision.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGetProvision.Location = New System.Drawing.Point(10, 32)
        Me.btnGetProvision.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnGetProvision.Name = "btnGetProvision"
        Me.btnGetProvision.Size = New System.Drawing.Size(128, 40)
        Me.btnGetProvision.TabIndex = 7
        Me.btnGetProvision.Text = "&Get Provision Accounts"
        Me.btnGetProvision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGetProvision.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ProgressBar1.Location = New System.Drawing.Point(73, 400)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(592, 24)
        Me.ProgressBar1.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(17, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(108, 16)
        Me.Label16.TabIndex = 120
        Me.Label16.Text = "Interest Date: "
        '
        'dtpDate
        '
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(133, 27)
        Me.dtpDate.MaxDate = New Date(9998, 11, 15, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(120, 23)
        Me.dtpDate.TabIndex = 1
        Me.dtpDate.Value = New Date(2010, 5, 11, 0, 0, 0, 0)
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 0
        Me.txtReceiptNo.BeforeDecimal = 7
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(133, 59)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtReceiptNo.MaxLength = 10
        Me.txtReceiptNo.MaxValue = 0
        Me.txtReceiptNo.MinValue = 0
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(120, 23)
        Me.txtReceiptNo.TabIndex = 3
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(17, 61)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(100, 16)
        Me.Label27.TabIndex = 134
        Me.Label27.Text = "Receipt No.  :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(281, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "Date: "
        '
        'dtpTransactionDate
        '
        Me.dtpTransactionDate.CalendarFont = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTransactionDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpTransactionDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTransactionDate.Location = New System.Drawing.Point(401, 59)
        Me.dtpTransactionDate.MaxDate = New Date(9998, 11, 15, 0, 0, 0, 0)
        Me.dtpTransactionDate.Name = "dtpTransactionDate"
        Me.dtpTransactionDate.Size = New System.Drawing.Size(120, 23)
        Me.dtpTransactionDate.TabIndex = 4
        Me.dtpTransactionDate.Value = New Date(2010, 5, 11, 0, 0, 0, 0)
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(281, 29)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(101, 16)
        Me.Label39.TabIndex = 138
        Me.Label39.Text = "Deposit Type:"
        '
        'cmbDepositType
        '
        Me.cmbDepositType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepositType.DropDownWidth = 120
        Me.cmbDepositType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepositType.Items.AddRange(New Object() {"FD", "ENNVY", "SCC"})
        Me.cmbDepositType.Location = New System.Drawing.Point(401, 26)
        Me.cmbDepositType.Name = "cmbDepositType"
        Me.cmbDepositType.Size = New System.Drawing.Size(120, 24)
        Me.cmbDepositType.TabIndex = 2
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(585, 58)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(88, 24)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Select all"
        '
        'frmFDInterestTransaction
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(912, 447)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.cmbDepositType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpTransactionDate)
        Me.Controls.Add(Me.txtReceiptNo)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lvInterest)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFDInterestTransaction"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FD Interest Transaction"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub fnLoadData()

        Dim dtRow As DataRow
        Dim lvItem As ListViewItem
        lvInterest.Items.Clear()
        For Each dtRow In objDT.Rows
            lvItem = lvInterest.Items.Add(dtRow.Item("FDNo"))
            lvItem.SubItems.Add(dtRow.Item("Name"))
            'lvItem.SubItems.Add(Format(dtRow.Item("FDDate"), "dd-MMM-yyyy"))
            'lvItem.SubItems.Add(dtRow.Item("FDAmount"))
            lvItem.SubItems.Add(Format(dtRow.Item("IntDate"), "dd-MMM-yyyy"))
            lvItem.SubItems.Add(dtRow.Item("IntAmount"))
            lvItem.SubItems.Add(dtRow.Item("Status"))
            lvItem.SubItems.Add(dtRow.Item("FDAdditionalDetailID"))
            lvItem.SubItems.Add(dtRow.Item("TransferAccountNo"))
            lvItem.SubItems.Add(dtRow.Item("SchemeType"))
        Next

    End Sub

    Function fnGenerateCumVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        Dim RefNo As Integer

        lngVoucherNo = fnVoucherGetNewVNo(dtpTransactionDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()
        lngVoucherNo += intCount
        lngSlNo += intCount

        'Transaction Entry
        If chaDepositType = "N" Then
            strSQL = "Update fdintpaymentstbl set status='Provision'  where Fdno='" & Trim(strFDNo) & "' and intDate='" & Format(CDate(dtpFDDate), "yyyy-MM-dd") & "'and FDAdditionalDetailID='" & intTransactionID & "' "
        Else
            strSQL = "Update fdcumulativeinttbl set status='Provision' where Fdno='" & Trim(strFDNo) & "' and intDate='" & Format(CDate(dtpFDDate), "yyyy-MM-dd") & "' and FDAdditionalDetailID='" & intTransactionID & "'"
        End If
        fnExecuteNonQuery(strSQL, objTrans)
        'Receipt no autogeneration
        Dim strsql3 = "select max(voucherNo) as RefNo from fasvouchermaintbl where vdate='" & Format(CDate(dtpTransactionDate.Value), "yyyy-MM-dd") & "'"
        objTempDt = fnExecuteQuery(strsql3, 2)
        If objTempDt.Rows(0).Item("RefNo").ToString = "" Then
            RefNo = 0
        Else
            RefNo = objTempDt.Rows(0).Item("RefNo")
        End If
        AutoIncreRefNo = RefNo + 1

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, Trim(strFDNo), AutoIncreRefNo, dtpTransactionDate.Value, Trim(dblFDAmount), "Interest to account " & Trim(strFDNo), lngSlNo, "Y", objTrans)

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 2, Trim(strFDNo), dtpTransactionDate.Value, "Interest to account " & Trim(strFDNo), "To", 14, 0, Val(dblFDAmount), 1, "Y", objTrans)

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 2, Trim(strFDNo), dtpTransactionDate.Value, "Interest by account " & Trim(strFDNo), "By", intLedgerNo, Val(dblFDAmount), 0, 2, "Y", objTrans)

        Return True

    End Function
    Function fnGenerateNonCumVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        Dim RefNo As Integer

        lngVoucherNo = fnVoucherGetNewVNo(dtpTransactionDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()
        lngVoucherNo += intCount
        lngSlNo += intCount

        'Transaction Entry
        If SchemeType = "N" Then
            strSQL = "Update fdintpaymentstbl set status='Paid',CollectDate='" & Format(dtpTransactionDate.Value, "yyyy-MM-dd") & "',VoucherNo ='" & lngVoucherNo & "',RefNo = '" & txtReceiptNo.Text & "'  where Fdno='" & Trim(strFDNo) & "' and intDate='" & Format(CDate(dtpFDTrDate), "yyyy-MM-dd") & "'"
        ElseIf SchemeType = "C" Then
            strSQL = "Update fdcumulativeinttbl set status='Paid',CollectDate='" & Format(dtpTransactionDate.Value, "yyyy-MM-dd") & "',VoucherNo ='" & lngVoucherNo & "',RefNo = '" & txtReceiptNo.Text & "'  where Fdno='" & Trim(strFDNo) & "' and intDate='" & Format(CDate(dtpFDTrDate), "yyyy-MM-dd") & "'"
            '"Update fdcumulativeinttbl set status='Paid',VoucherNo ='" & lngVoucherNo & "',RefNo = '" & txtReceiptNo.Text & "',CollectDate='" & Format(dtpDate.Value, "yyyy-MM-dd") & "' where Fdno='" & Trim(txtFDAccountNo.Text) & "' and intDate='" & Format(CDate(txtInterestdate.Text), "yyyy-MM-dd") & "'"
        End If
        ' strsql = "Update fdintpaymentstbl set status='Paid',CollectDate='" & Format(dtpTransactionDate.Value, "yyyy-MM-dd") & "',VoucherNo ='" & lngVoucherNo & "',RefNo = '" & txtReceiptNo.Text & "'  where Fdno='" & Trim(strFDNo) & "' and intDate='" & Format(CDate(dtpFDTrDate), "yyyy-MM-dd") & "'"
        fnExecuteNonQuery(strSQL, objTrans)

        'Receipt no autogeneration
        Dim strsql3 = "select max(refno) as RefNo from fdintpostingstbl"
        objTempDt = fnExecuteQuery(strsql3, 2)
        If objTempDt.Rows(0).Item("RefNo").ToString = "" Then
            RefNo = 0
        Else
            RefNo = objTempDt.Rows(0).Item("RefNo")
        End If
        AutoIncreRefNo = RefNo + 1
        ''' AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1

        'Inset into FdPosting Deatils 
        strSQL = "insert into fdintpostingstbl(FDNo,TrDate,Amount,Remarks,Voucherno,RefNo) values('" & Trim(strFDNo) & "','" & Format(dtpTransactionDate.Value, "yyyy-MM-dd") & "','" & Trim(dblFDAmount) & "',' ','" & lngVoucherNo & "','" & AutoIncreRefNo & "')"
        fnExecuteNonQuery(strsql, objTrans)

        Dim strNarration As String = "Transfered to " & Trim(strAccountNo)

        If strAccountNo <> "" Then


            Dim strType As String
            strType = Mid(strAccountNo, 1, 2)

            Select Case strType
                Case "SB"

                    'Transaction Entry
                    ''Receipt no autogeneration
                    strsql3 = "select max(RefNo) as RefNo from sbtransactiontbl"
                    objTempDt = fnExecuteQuery(strsql3, 2)
                    AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1
                    Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
                    strsql = strsql & " select '" & Trim(strAccountNo) & "','" & Format(dtpTransactionDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(dblFDAmount) & "','0','" & Trim(dblFDAmount) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(dblFDAmount) & "','" & AutoIncreRefNo & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(strAccountNo) & "' group by Accountno"
                    fnExecuteNonQuery(strsql, objTrans)

                    ''voucher details
                    fnVoucherEnterMain(lngVoucherNo, 7, strFDNo, AutoIncreRefNo, dtpTransactionDate.Value, dblFDAmount, "Transfered by " & strFDNo, lngSlNo, "Y", objTrans)

                    'Debit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 7, strFDNo, dtpTransactionDate.Value, "Interest by account " & strFDNo, "By", intLedgerNo, Val(dblFDAmount), 0, 1, "Y", objTrans)

                    'Credit accounts
                    fnVoucherEnterSub(lngVoucherNo, 7, strFDNo, dtpTransactionDate.Value, "Interest credited by account " & strFDNo, "To", 10, 0, Val(dblFDAmount), 2, "Y", objTrans)

                Case "CA"
                    ''Receipt no autogeneration
                    strsql3 = "select max(RefNo) as RefNo from catransactiontbl"
                    objTempDt = fnExecuteQuery(strsql3, 2)
                    AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1
                    'Transaction Entry
                    Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
                    strsql = strsql & " select '" & Trim(strAccountNo) & "','" & Format(dtpTransactionDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(dblFDAmount) & "','0','" & Trim(dblFDAmount) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(dblFDAmount) & "','0','" & AutoIncreRefNo & "','" & lngVoucherNo & "','Cash','0' from catransactiontbl where caccountno='" & Trim(strAccountNo) & "' group by CAccountno"
                    fnExecuteNonQuery(strsql, objTrans)

                    ''voucher details
                    fnVoucherEnterMain(lngVoucherNo, 7, strFDNo, AutoIncreRefNo, dtpTransactionDate.Value, strFDNo, "Transfered by " & strFDNo, lngSlNo, "Y", objTrans)

                    'Debit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 7, strFDNo, dtpTransactionDate.Value, "Interest by account " & strFDNo, "By", intLedgerNo, Val(dblFDAmount), 0, 1, "Y", objTrans)

                    'Credit accounts
                    fnVoucherEnterSub(lngVoucherNo, 7, strFDNo, dtpTransactionDate.Value, "Interest credited by account " & strFDNo, "To", 11, 0, Val(dblFDAmount), 2, "Y", objTrans)

            End Select
        Else
            ''Receipt no autogeneration
            strsql3 = "select max(RefNo) as RefNo from fasvouchermaintbl"
            objTempDt = fnExecuteQuery(strsql3, 2)
            AutoIncreRefNo = objTempDt.Rows(0).Item("RefNo") + 1
            'voucher details
            fnVoucherEnterMain(lngVoucherNo, 2, strFDNo, AutoIncreRefNo, dtpTransactionDate.Value, dblFDAmount, "Interest to account " & strFDNo, lngSlNo, "Y", objTrans)

            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 2, "", dtpTransactionDate.Value, "Interest to account " & strFDNo, "To", 1, 0, Val(dblFDAmount), 2, "Y", objTrans)

            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 2, strFDNo, dtpTransactionDate.Value, "Interest by account " & strFDNo, "By", intLedgerNo, Val(dblFDAmount), 0, 1, "Y", objTrans)
        End If

        Return True

    End Function

    Private Sub btnGetProvision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetProvision.Click

        If cmbDepositType.SelectedIndex = -1 Then
            MsgBox("Please select deposit type", MsgBoxStyle.Exclamation)
            cmbDepositType.Focus()
            Return
        End If

        If objFd.fnGetProvision(dtpDate.Value, cmbDepositType.Text) Then
            objDT = objFd.dtIntPost
            fnLoadData()
            btnProvision.Enabled = True
            btnPayment.Enabled = False
        Else
            MsgBox("There is no record matching in database", MsgBoxStyle.Exclamation)
            lvInterest.Items.Clear()
            btnGetProvision.Focus()

        End If

    End Sub

    Private Sub btnGetPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetPayment.Click

        If cmbDepositType.SelectedIndex = -1 Then
            MsgBox("Please select deposit type", MsgBoxStyle.Exclamation)
            cmbDepositType.Focus()
            Return
        End If

        If objFd.fnGetPayment(dtpDate.Value, cmbDepositType.Text) Then
            objDT = objFd.dtIntPost
            fnLoadData()
            btnProvision.Enabled = False
            btnPayment.Enabled = True
        Else
            MsgBox("There is no record matching in database", MsgBoxStyle.Exclamation)
            lvInterest.Items.Clear()
            btnGetProvision.Focus()
        End If

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Function fnValidate() As Boolean
        If txtReceiptNo.Text = "" Then
            MsgBox("Please enter receipt No.", MsgBoxStyle.Exclamation)
            txtReceiptNo.Focus()
            Return False
        ElseIf cmbDepositType.SelectedIndex = -1 Then
            MsgBox("Please select deposit type", MsgBoxStyle.Exclamation)
            cmbDepositType.Focus()
            Return False
        Else
            Return True
        End If
    End Function
    Sub Clear()
        lvInterest.Items.Clear()
        txtReceiptNo.ResetText()
        btnPayment.Enabled = False
        btnProvision.Enabled = False
        ProgressBar1.Value = 0
    End Sub

    Private Sub btnProvision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProvision.Click

        Dim objTrans As IDbTransaction
        ProgressBar1.Value = 0
        intCount = 0

        If fnValidate() Then
            If lvInterest.CheckedItems.Count > 0 Then
                ProgressBar1.Maximum = lvInterest.Items.Count
                Try
                    objTrans = fnGetTransaction()
                    For Each lvItems As ListViewItem In lvInterest.Items
                        If lvItems.Checked = True Then
                            strFDNo = lvItems.SubItems(0).Text
                            dblFDAmount = lvItems.SubItems(3).Text
                            dtpFDTrDate = dtpTransactionDate.Value
                            dtpFDDate = CDate(lvItems.SubItems(2).Text)
                            intReceiptNo = txtReceiptNo.Text
                            'intLedgerNo = 30

                            If lvItems.SubItems(4).Text = "Provision" Then

                                intLedgerNo = 14

                            ElseIf lvItems.SubItems(4).Text = "Due" Then
                                Select Case cmbDepositType.SelectedItem
                                    Case "FD"
                                        intLedgerNo = 30
                                    Case "ENNVY"
                                        intLedgerNo = 55
                                    Case "SCC"
                                        intLedgerNo = 56
                                End Select

                            End If

                            intTransactionID = lvItems.SubItems(5).Text
                            chaDepositType = lvItems.SubItems(7).Text
                            fnGenerateCumVoucher(objTrans)
                            intCount += 1
                        End If
                        ProgressBar1.Value += 1
                    Next

                    objTrans.Commit()
                    Clear()
                    MsgBox("Interest is successfully posted ", MsgBoxStyle.Information, "Deposit Module")
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)

                Finally
                    objTrans.Dispose()
                End Try

            Else
                MsgBox("No records were selected", MsgBoxStyle.Information, Me.Text)
                lvInterest.Focus()
            End If
        End If

    End Sub

    Private Sub frmFDInterestTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpTransactionDate.Value = Date.Now
        dtpDate.Value = Date.Now
    End Sub

    Private Sub btnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayment.Click

        Dim objTrans As IDbTransaction
        ProgressBar1.Value = 0
        intCount = 0

        If fnValidate() Then
            If lvInterest.CheckedItems.Count > 0 Then
                ProgressBar1.Maximum = lvInterest.Items.Count
                Try
                    objTrans = fnGetTransaction()
                    For Each lvItems As ListViewItem In lvInterest.Items
                        If lvItems.Checked = True Then
                            strFDNo = lvItems.SubItems(0).Text
                            dblFDAmount = lvItems.SubItems(3).Text
                            dtpFDTrDate = dtpTransactionDate.Value
                            dtpFDDate = CDate(lvItems.SubItems(2).Text)
                            intReceiptNo = txtReceiptNo.Text
                            'intLedgerNo = 30
                            If lvItems.SubItems(4).Text = "Provision" Then

                                intLedgerNo = 14

                                'ElseIf lvItems.SubItems(4).Text = "Provision" = "Due" Then
                            ElseIf lvItems.SubItems(4).Text = "Due" Then
                                Select Case cmbDepositType.SelectedItem
                                    Case "FD"
                                        intLedgerNo = 30
                                    Case "ENNVY"
                                        intLedgerNo = 55
                                    Case "SCC"
                                        intLedgerNo = 56
                                End Select

                            End If
                            intTransactionID = lvItems.SubItems(5).Text
                            strAccountNo = lvItems.SubItems(6).Text
                            SchemeType = lvItems.SubItems(7).Text
                            fnGenerateNonCumVoucher(objTrans)
                            intCount += 1
                        End If
                        ProgressBar1.Value += 1
                    Next
                    objTrans.Commit()
                    Clear()
                    MsgBox("Interest is successfully paid. ", MsgBoxStyle.Information, "Deposit Module")

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                Finally
                    objTrans.Dispose()
                End Try

            Else
                MsgBox("No records were selected", MsgBoxStyle.Information, Me.Text)
                lvInterest.Focus()
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            If lvInterest.Items.Count > 0 Then
                For Each lvItems As ListViewItem In lvInterest.Items
                    lvItems.Checked = True
                Next
            End If
        Else
            If lvInterest.Items.Count > 0 Then
                For Each lvItems As ListViewItem In lvInterest.Items
                    lvItems.Checked = False
                Next
            End If
        End If
    End Sub

    Private Sub dtpDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDate.ValueChanged
        dtpTransactionDate.Value = dtpDate.Value
    End Sub

    Private Sub cmbDepositType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepositType.SelectedIndexChanged

    End Sub
End Class
