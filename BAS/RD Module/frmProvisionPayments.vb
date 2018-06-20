Public Class frmProvisionPayments
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
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtpTransactionDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnProvision As BankControls.NewButton
    Friend WithEvents btnGetProvision As BankControls.NewButton
    Friend WithEvents lvInterest As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProvisionPayments))
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtReceiptNo = New BankControls.NumericControl
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.dtpTransactionDate = New System.Windows.Forms.DateTimePicker
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnClose = New BankControls.NewButton
        Me.btnProvision = New BankControls.NewButton
        Me.btnGetProvision = New BankControls.NewButton
        Me.lvInterest = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(176, 64)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(88, 24)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Select all"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(384, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 19)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "Date: "
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 0
        Me.txtReceiptNo.BeforeDecimal = 7
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(448, 64)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtReceiptNo.MaxLength = 10
        Me.txtReceiptNo.MaxValue = 0
        Me.txtReceiptNo.MinValue = 0
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(120, 23)
        Me.txtReceiptNo.TabIndex = 5
        Me.txtReceiptNo.Text = ""
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.Label27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(336, 64)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(93, 19)
        Me.Label27.TabIndex = 159
        Me.Label27.Text = "Receipt No. :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(64, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(105, 19)
        Me.Label16.TabIndex = 158
        Me.Label16.Text = "Interest Date: "
        '
        'dtpTransactionDate
        '
        Me.dtpTransactionDate.CalendarFont = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTransactionDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpTransactionDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTransactionDate.Location = New System.Drawing.Point(448, 24)
        Me.dtpTransactionDate.MaxDate = New Date(2754, 11, 15, 0, 0, 0, 0)
        Me.dtpTransactionDate.Name = "dtpTransactionDate"
        Me.dtpTransactionDate.Size = New System.Drawing.Size(120, 23)
        Me.dtpTransactionDate.TabIndex = 2
        Me.dtpTransactionDate.Value = New Date(2010, 5, 11, 0, 0, 0, 0)
        '
        'dtpDate
        '
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(176, 24)
        Me.dtpDate.MaxDate = New Date(2754, 11, 15, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(120, 23)
        Me.dtpDate.TabIndex = 1
        Me.dtpDate.Value = New Date(2010, 5, 11, 0, 0, 0, 0)
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 408)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(592, 24)
        Me.ProgressBar1.TabIndex = 157
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnProvision)
        Me.Panel1.Controls.Add(Me.btnGetProvision)
        Me.Panel1.Location = New System.Drawing.Point(656, 136)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(168, 192)
        Me.Panel1.TabIndex = 156
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(237, Byte), CType(227, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(16, 128)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(144, 40)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "&Close"
        '
        'btnProvision
        '
        Me.btnProvision.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnProvision.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProvision.Enabled = False
        Me.btnProvision.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProvision.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProvision.ForeColor = System.Drawing.Color.Black
        Me.btnProvision.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(237, Byte), CType(227, Byte))
        Me.btnProvision.Image = CType(resources.GetObject("btnProvision.Image"), System.Drawing.Image)
        Me.btnProvision.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProvision.Location = New System.Drawing.Point(8, 72)
        Me.btnProvision.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnProvision.Name = "btnProvision"
        Me.btnProvision.Size = New System.Drawing.Size(152, 40)
        Me.btnProvision.TabIndex = 7
        Me.btnProvision.Text = "Int &Provision"
        Me.btnProvision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnGetProvision
        '
        Me.btnGetProvision.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnGetProvision.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGetProvision.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGetProvision.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetProvision.ForeColor = System.Drawing.Color.Black
        Me.btnGetProvision.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(237, Byte), CType(227, Byte))
        Me.btnGetProvision.Image = CType(resources.GetObject("btnGetProvision.Image"), System.Drawing.Image)
        Me.btnGetProvision.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGetProvision.Location = New System.Drawing.Point(8, 16)
        Me.btnGetProvision.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnGetProvision.Name = "btnGetProvision"
        Me.btnGetProvision.Size = New System.Drawing.Size(150, 40)
        Me.btnGetProvision.TabIndex = 6
        Me.btnGetProvision.Text = "&Get Provision Accounts"
        Me.btnGetProvision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lvInterest
        '
        Me.lvInterest.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lvInterest.CheckBoxes = True
        Me.lvInterest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader7, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvInterest.FullRowSelect = True
        Me.lvInterest.GridLines = True
        Me.lvInterest.Location = New System.Drawing.Point(16, 104)
        Me.lvInterest.MultiSelect = False
        Me.lvInterest.Name = "lvInterest"
        Me.lvInterest.Size = New System.Drawing.Size(628, 296)
        Me.lvInterest.TabIndex = 4
        Me.lvInterest.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Account No."
        Me.ColumnHeader1.Width = 102
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 185
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Int Date"
        Me.ColumnHeader7.Width = 102
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Int Amount"
        Me.ColumnHeader3.Width = 112
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Status"
        Me.ColumnHeader4.Width = 64
        '
        'frmProvisionPayments
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(840, 453)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtReceiptNo)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.dtpTransactionDate)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lvInterest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProvisionPayments"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Provision Payments"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim objRd As New clsRDAccount
    Dim objDT As DataTable
    Dim intCount As Integer
    Dim strRDNo As String
    Dim dblRDAmount As Double
    Dim dtpRDTrDate As Date
    Dim intReceiptNo As String
    Dim dtpRDDate As Date
    Private Function fnValidate() As Boolean
        If txtReceiptNo.Text = "" Then
            MsgBox("Please enter receipt No.", MsgBoxStyle.Exclamation)
            txtReceiptNo.Focus()
            Return False
      
        Else
            Return True
        End If
    End Function
    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()
        lngVoucherNo += intCount
        lngSlNo += intCount

        'Transaction Entry

        
        strSQL = "Update rdcumulativeinttbl set Status='Provision' where RDNo='" & strRDNo & "' and intDate='" & Format(CDate(dtpRDDate), "yyyy-MM-dd") & "'"

        If fnExecuteNonQuery(strSQL, objTrans) Then

            'voucher details
            fnVoucherEnterMain(lngVoucherNo, 2, strRDNo, txtReceiptNo.Text, dtpDate.Value, dblRDAmount, "Interest to account " & strRDNo, lngSlNo, "Y", objTrans)

            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 2, strRDNo, dtpDate.Value, "Interest to account " & strRDNo, "To", 14, 0, dblRDAmount, 2, "Y", objTrans)

            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 2, strRDNo, dtpDate.Value, "Interest by account " & strRDNo, "By", 32, dblRDAmount, 0, 1, "Y", objTrans)

            Return True

        End If

    End Function
    Sub Clear()
        lvInterest.Items.Clear()
        txtReceiptNo.ResetText()

        btnProvision.Enabled = False
        ProgressBar1.Value = 0
    End Sub
    Private Sub fnLoadData()

        Dim dtRow As DataRow
        Dim lvItem As ListViewItem
        lvInterest.Items.Clear()
        For Each dtRow In objDT.Rows
            lvItem = lvInterest.Items.Add(dtRow.Item("RDNo"))
            lvItem.SubItems.Add(dtRow.Item("Name"))
            'lvItem.SubItems.Add(Format(dtRow.Item("FDDate"), "dd-MMM-yyyy"))
            'lvItem.SubItems.Add(dtRow.Item("FDAmount"))
            lvItem.SubItems.Add(Format(dtRow.Item("IntDate"), "dd-MMM-yyyy"))
            lvItem.SubItems.Add(dtRow.Item("IntAmount"))
            lvItem.SubItems.Add(dtRow.Item("Status"))
            ' lvItem.SubItems.Add(dtRow.Item("FDAdditionalDetailID"))
            'lvItem.SubItems.Add(dtRow.Item("TransferAccountNo"))

        Next

    End Sub
    Private Sub frmProvisionPayments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpTransactionDate.Value = Date.Now
        dtpDate.Value = Date.Now
    End Sub

    Private Sub btnGetProvision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetProvision.Click
        If dtpDate.Value <= Date.Now Then
            If objRd.fnGetCumulativeProvision(dtpDate.Value) Then
                objDT = objRd.dtIntPost
                fnLoadData()
                btnProvision.Enabled = True

            Else
                MsgBox("There is no record matching in database", MsgBoxStyle.Exclamation)
                btnGetProvision.Focus()

            End If

        Else
            MsgBox("Interest caliculation date is greater than todays date", MsgBoxStyle.Exclamation)
        End If
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
                            strRDNo = lvItems.SubItems(0).Text
                            'Dim name As String = lvItems.SubItems(1).Text
                            dblRDAmount = lvItems.SubItems(3).Text
                            ' dtpRDTrDate = dtpTransactionDate.Value
                            dtpRDDate = CDate(lvItems.SubItems(2).Text)
                            intReceiptNo = txtReceiptNo.Text
                            'intLedgerNo = 30







                            fnGenerateVoucher(objTrans)
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

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
