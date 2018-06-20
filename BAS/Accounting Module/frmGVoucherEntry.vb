Public Class frmGVoucherEntry
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
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRefno As BankControls.NumericControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As BankControls.TextControl
    Friend WithEvents dtpDepositDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbLedger As System.Windows.Forms.ComboBox
    Friend WithEvents rdPayment As System.Windows.Forms.RadioButton
    Friend WithEvents rdReceipt As System.Windows.Forms.RadioButton
    Friend WithEvents btnReceipt As BankControls.NewButton
    Friend WithEvents btnPayment As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmGVoucherEntry))
        Me.btnReceipt = New BankControls.NewButton
        Me.btnPayment = New BankControls.NewButton
        Me.Label32 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnCancel = New BankControls.NewButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbLedger = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdReceipt = New System.Windows.Forms.RadioButton
        Me.rdPayment = New System.Windows.Forms.RadioButton
        Me.txtRefno = New BankControls.NumericControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAmount = New BankControls.NumericControl
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNarration = New BankControls.TextControl
        Me.dtpDepositDate = New System.Windows.Forms.DateTimePicker
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReceipt
        '
        Me.btnReceipt.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReceipt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceipt.GotFocusColour = System.Drawing.Color.FromArgb(CType(152, Byte), CType(220, Byte), CType(166, Byte))
        Me.btnReceipt.Location = New System.Drawing.Point(224, 312)
        Me.btnReceipt.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(104, 40)
        Me.btnReceipt.TabIndex = 9
        Me.btnReceipt.Text = "&Receipt"
        Me.btnReceipt.Visible = False
        '
        'btnPayment
        '
        Me.btnPayment.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPayment.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.GotFocusColour = System.Drawing.Color.FromArgb(CType(152, Byte), CType(220, Byte), CType(166, Byte))
        Me.btnPayment.Image = CType(resources.GetObject("btnPayment.Image"), System.Drawing.Image)
        Me.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayment.Location = New System.Drawing.Point(344, 312)
        Me.btnPayment.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(120, 40)
        Me.btnPayment.TabIndex = 10
        Me.btnPayment.Text = "&Payment"
        Me.btnPayment.Visible = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(71, 10)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(133, 25)
        Me.Label32.TabIndex = 116
        Me.Label32.Text = "Voucher Entry"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 117
        Me.PictureBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(480, 312)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 40)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "&Cancel"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmbLedger)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtRefno)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNarration)
        Me.Panel1.Controls.Add(Me.dtpDepositDate)
        Me.Panel1.Location = New System.Drawing.Point(7, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 248)
        Me.Panel1.TabIndex = 110
        '
        'cmbLedger
        '
        Me.cmbLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLedger.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLedger.Location = New System.Drawing.Point(144, 64)
        Me.cmbLedger.Name = "cmbLedger"
        Me.cmbLedger.Size = New System.Drawing.Size(328, 24)
        Me.cmbLedger.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(32, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 19)
        Me.Label10.TabIndex = 126
        Me.Label10.Text = " Account :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdReceipt)
        Me.GroupBox1.Controls.Add(Me.rdPayment)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 48)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'rdReceipt
        '
        Me.rdReceipt.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.rdReceipt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdReceipt.Location = New System.Drawing.Point(120, 12)
        Me.rdReceipt.Name = "rdReceipt"
        Me.rdReceipt.Size = New System.Drawing.Size(88, 24)
        Me.rdReceipt.TabIndex = 3
        Me.rdReceipt.TabStop = True
        Me.rdReceipt.Text = "Receipt"
        '
        'rdPayment
        '
        Me.rdPayment.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.rdPayment.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdPayment.Location = New System.Drawing.Point(16, 12)
        Me.rdPayment.Name = "rdPayment"
        Me.rdPayment.Size = New System.Drawing.Size(88, 24)
        Me.rdPayment.TabIndex = 2
        Me.rdPayment.TabStop = True
        Me.rdPayment.Text = "Payment"
        '
        'txtRefno
        '
        Me.txtRefno.AfterDecimal = 0
        Me.txtRefno.BeforeDecimal = 7
        Me.txtRefno.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefno.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRefno.Location = New System.Drawing.Point(144, 208)
        Me.txtRefno.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRefno.MaxValue = 0
        Me.txtRefno.MinValue = 0
        Me.txtRefno.Name = "txtRefno"
        Me.txtRefno.Size = New System.Drawing.Size(160, 23)
        Me.txtRefno.TabIndex = 8
        Me.txtRefno.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 19)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "Reference No. :"
        '
        'txtAmount
        '
        Me.txtAmount.AfterDecimal = 2
        Me.txtAmount.BackColor = System.Drawing.Color.White
        Me.txtAmount.BeforeDecimal = 7
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmount.Location = New System.Drawing.Point(144, 96)
        Me.txtAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAmount.MaxValue = 0
        Me.txtAmount.MinValue = 0
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(160, 23)
        Me.txtAmount.TabIndex = 6
        Me.txtAmount.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(352, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 19)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Narration :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Amount :"
        '
        'txtNarration
        '
        Me.txtNarration.AlphaNumeric = True
        Me.txtNarration.BlankSpace = True
        Me.txtNarration.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNarration.Location = New System.Drawing.Point(144, 128)
        Me.txtNarration.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNarration.Mandatory = False
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarration.Size = New System.Drawing.Size(416, 72)
        Me.txtNarration.SpecialChar = True
        Me.txtNarration.TabIndex = 7
        Me.txtNarration.Text = ""
        '
        'dtpDepositDate
        '
        Me.dtpDepositDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDepositDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDepositDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDepositDate.Location = New System.Drawing.Point(408, 24)
        Me.dtpDepositDate.Name = "dtpDepositDate"
        Me.dtpDepositDate.Size = New System.Drawing.Size(144, 23)
        Me.dtpDepositDate.TabIndex = 4
        Me.dtpDepositDate.TabStop = False
        '
        'frmGVoucherEntry
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(252, Byte), CType(233, Byte))
        Me.ClientSize = New System.Drawing.Size(600, 365)
        Me.Controls.Add(Me.btnReceipt)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGVoucherEntry"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voucher Entry"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Globle Diclaration"
    Dim lngVoucherNo As Long
    Dim dtLedger As New DataTable
    Dim objGroup As New clsGroups
    Dim objLedger As New clsLedger
#End Region

#Region "Function"

    Function fnCheck() As Boolean

        If txtAmount.Text = "" Then
            MsgBox("Enter amount", MsgBoxStyle.Information, Me.Text)
            txtAmount.Focus()
            Return False
        ElseIf txtNarration.Text = "" Then
            MsgBox("Enter narration", MsgBoxStyle.Information, Me.Text)
            txtNarration.Focus()
            Return False
        ElseIf txtRefno.Text = "" Then
            MsgBox("Enter reference No.", MsgBoxStyle.Information, Me.Text)
            txtRefno.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub sbClear()
        Dim objCtrl As New Object
        txtRefno.Text = ""
        txtNarration.Text = ""
        txtAmount.Text = ""
    End Sub


    Public Sub sbloaddetails()
        Dim objDV As DataView
        If objLedger.fnGetLedgerList Then
            objDV = New DataView(objLedger.LedgerTable, "RestrictUser='N'", "LedgerNo", DataViewRowState.OriginalRows)
            cmbLedger.DataSource = objDV
            cmbLedger.DisplayMember = "Name"
            cmbLedger.ValueMember = "LedgerNo"
        End If
    End Sub

    Function fnGenerateVoucherP(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 1, "LNo.: " & cmbLedger.SelectedValue, txtRefno.Text, dtpDepositDate.Value, txtAmount.Text, "Withdrawed by" & cmbLedger.Text.ToString(), lngSlNo, "Y", objTrans)

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDepositDate.Value, "Withdrawed by account " & cmbLedger.Text.ToString(), "To", 1, 0, Val(txtAmount.Text), 1, "Y", objTrans)

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 1, "LNo.: " & cmbLedger.SelectedValue, dtpDepositDate.Value, "Withdrawed by account " & cmbLedger.Text.ToString(), "By", cmbLedger.SelectedValue, Val(txtAmount.Text), 0, 2, "Y", objTrans)

        Return True

    End Function

    Function fnGenerateVoucherR(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, "LNo.: " & cmbLedger.SelectedValue, txtRefno.Text, dtpDepositDate.Value, txtAmount.Text, "Deposit by" & cmbLedger.Text.ToString(), lngSlNo, "Y", objTrans)

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 2, "LNo.: " & cmbLedger.SelectedValue, dtpDepositDate.Value, "Deposit by account " & cmbLedger.Text.ToString(), "To", cmbLedger.SelectedValue, 0, Val(txtAmount.Text), 1, "Y", objTrans)

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpDepositDate.Value, "Deposit by account " & cmbLedger.Text.ToString(), "By", 1, Val(txtAmount.Text), 0, 2, "Y", objTrans)
        Return True

    End Function




#End Region

    Private Sub frmGVoucherEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sbloaddetails()
        dtpDepositDate.Value = Date.Now
    End Sub

    Private Sub rdPayment_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdPayment.CheckedChanged
        btnReceipt.Visible = False
        btnPayment.Visible = True
        sbClear()
    End Sub

    Private Sub rdReceipt_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdReceipt.CheckedChanged
        btnPayment.Visible = False
        btnReceipt.Visible = True
        sbClear()
    End Sub

    Private Sub btnReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceipt.Click

        Dim objTrans As IDbTransaction

        Try
            If fnCheck() Then
                If MsgBox("Ledger :" & cmbLedger.Text & " " & Chr(13) & " Amount :" & txtAmount.Text & "" & Chr(13) & " Type :  Cash") = MsgBoxResult.OK Then
                    objTrans = fnGetTransaction()
                    fnGenerateVoucherR(objTrans)
                    fnLogEntry(pbUserId, "Receipt by ledger " & cmbLedger.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction receipt", objTrans)
                    objTrans.Commit()
                    If MsgBox("Transaction completed sucessfully," & Chr(13) & " do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                        sbClear()
                    Else
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try
       
    End Sub

    Private Sub btnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayment.Click
        Dim objTrans As IDbTransaction
        Try
            If fnCheck() Then
                If MsgBox("Ledger :" & cmbLedger.Text & " " & Chr(13) & " Amount :" & txtAmount.Text & "" & Chr(13) & " Type :  Cash") = MsgBoxResult.OK Then
                    objTrans = fnGetTransaction()
                    fnGenerateVoucherP(objTrans)
                    fnLogEntry(pbUserId, "Payment by ledger " & cmbLedger.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction payment", objTrans)
                    objTrans.Commit()
                    If MsgBox("Transaction completed sucessfully," & Chr(13) & " do you want to make another transaction", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                        sbClear()
                    Else
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
