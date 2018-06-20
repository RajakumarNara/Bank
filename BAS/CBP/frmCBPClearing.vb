Public Class frmCBPClearing
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAccountNo As BankControls.TextControl
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents txtRefno As BankControls.NumericControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents dtpDepositDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtChequeNo As BankControls.TextControl
    Friend WithEvents btnTransfer As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents cmbChequeStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCBPClearing))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbChequeStatus = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtChequeNo = New BankControls.TextControl
        Me.txtRefno = New BankControls.NumericControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAmount = New BankControls.NumericControl
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.dtpDepositDate = New System.Windows.Forms.DateTimePicker
        Me.btnSearch = New BankControls.NewButton
        Me.txtAccountNo = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnTransfer = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 111
        Me.PictureBox1.TabStop = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(72, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(153, 23)
        Me.Label32.TabIndex = 110
        Me.Label32.Text = "CBP Transaction"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmbChequeStatus)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtChequeNo)
        Me.Panel1.Controls.Add(Me.txtRefno)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.dtpDepositDate)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtAccountNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(16, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 184)
        Me.Panel1.TabIndex = 0
        '
        'cmbChequeStatus
        '
        Me.cmbChequeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChequeStatus.Enabled = False
        Me.cmbChequeStatus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbChequeStatus.Items.AddRange(New Object() {"Pending", "Cleared"})
        Me.cmbChequeStatus.Location = New System.Drawing.Point(384, 88)
        Me.cmbChequeStatus.Name = "cmbChequeStatus"
        Me.cmbChequeStatus.Size = New System.Drawing.Size(136, 24)
        Me.cmbChequeStatus.TabIndex = 8
        Me.cmbChequeStatus.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(272, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 16)
        Me.Label13.TabIndex = 156
        Me.Label13.Text = "Cheque Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "Cheque No "
        '
        'txtChequeNo
        '
        Me.txtChequeNo.AlphaNumeric = True
        Me.txtChequeNo.BackColor = System.Drawing.Color.White
        Me.txtChequeNo.BlankSpace = False
        Me.txtChequeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeNo.GotFocusColour = System.Drawing.Color.White
        Me.txtChequeNo.Location = New System.Drawing.Point(112, 88)
        Me.txtChequeNo.LostFocusColour = System.Drawing.Color.White
        Me.txtChequeNo.Mandatory = False
        Me.txtChequeNo.MaxLength = 10
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.ReadOnly = True
        Me.txtChequeNo.Size = New System.Drawing.Size(152, 23)
        Me.txtChequeNo.SpecialChar = False
        Me.txtChequeNo.TabIndex = 4
        Me.txtChequeNo.TabStop = False
        '
        'txtRefno
        '
        Me.txtRefno.AfterDecimal = 0
        Me.txtRefno.BeforeDecimal = 7
        Me.txtRefno.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefno.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRefno.Location = New System.Drawing.Point(112, 152)
        Me.txtRefno.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRefno.MaxLength = 7
        Me.txtRefno.MaxValue = 0
        Me.txtRefno.MinValue = 0
        Me.txtRefno.Name = "txtRefno"
        Me.txtRefno.Size = New System.Drawing.Size(152, 23)
        Me.txtRefno.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Reference No"
        '
        'txtAmount
        '
        Me.txtAmount.AfterDecimal = 2
        Me.txtAmount.BackColor = System.Drawing.Color.White
        Me.txtAmount.BeforeDecimal = 7
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.GotFocusColour = System.Drawing.Color.White
        Me.txtAmount.Location = New System.Drawing.Point(112, 120)
        Me.txtAmount.LostFocusColour = System.Drawing.Color.White
        Me.txtAmount.MaxValue = 0
        Me.txtAmount.MinValue = 0
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(152, 23)
        Me.txtAmount.TabIndex = 5
        Me.txtAmount.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 129
        Me.Label6.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "Amount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(320, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 16)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Name"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(384, 24)
        Me.txtName.LostFocusColour = System.Drawing.Color.White
        Me.txtName.Mandatory = False
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(168, 24)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 7
        Me.txtName.TabStop = False
        '
        'dtpDepositDate
        '
        Me.dtpDepositDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDepositDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDepositDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDepositDate.Location = New System.Drawing.Point(112, 56)
        Me.dtpDepositDate.Name = "dtpDepositDate"
        Me.dtpDepositDate.Size = New System.Drawing.Size(152, 23)
        Me.dtpDepositDate.TabIndex = 3
        Me.dtpDepositDate.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.Gray
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(280, 24)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.WhiteSmoke
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'txtAccountNo
        '
        Me.txtAccountNo.AlphaNumeric = True
        Me.txtAccountNo.BackColor = System.Drawing.Color.White
        Me.txtAccountNo.BlankSpace = False
        Me.txtAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccountNo.Location = New System.Drawing.Point(112, 24)
        Me.txtAccountNo.LostFocusColour = System.Drawing.Color.White
        Me.txtAccountNo.Mandatory = False
        Me.txtAccountNo.MaxLength = 9
        Me.txtAccountNo.Name = "txtAccountNo"
        Me.txtAccountNo.Size = New System.Drawing.Size(152, 23)
        Me.txtAccountNo.SpecialChar = False
        Me.txtAccountNo.TabIndex = 1
        Me.txtAccountNo.Text = "CBP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CBP No"
        '
        'btnTransfer
        '
        Me.btnTransfer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransfer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfer.GotFocusColour = System.Drawing.Color.Gray
        Me.btnTransfer.Location = New System.Drawing.Point(304, 256)
        Me.btnTransfer.LostFocusColour = System.Drawing.Color.WhiteSmoke
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(128, 40)
        Me.btnTransfer.TabIndex = 9
        Me.btnTransfer.Text = "Clear"
        Me.btnTransfer.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(456, 256)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(128, 40)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmCBPClearing
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(598, 301)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label32)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCBPClearing"
        Me.ShowInTaskbar = False
        Me.Text = "CBP Clearing"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Global Variable"
    ' Dim objSavingsBank As New clsSavingsBank
    'Dim objSBAccount As New clsSavingsBank1
    Dim objCBP As New clsCBPDet
    'Dim lngPersonNo As Long = 0
#End Region


#Region "Function"


    Sub clearData()
        txtAccountNo.Text = "CBP"
        txtName.ResetText()
        txtAmount.ResetText()
        txtRefno.ResetText()
        txtChequeNo.ResetText()
    End Sub

    Function fnCheck() As Boolean
        If txtAccountNo.Text = "CBP" Then
            MsgBox("Select account", MsgBoxStyle.Exclamation)
            btnSearch.Focus()
            Return False
        ElseIf cmbChequeStatus.SelectedItem = "Cleared" Then
            MsgBox("Cheque is already cleared", MsgBoxStyle.Exclamation)
            Return False
            'ElseIf txtRefno.Text = "" Then
            '    MsgBox("Enter reference number", MsgBoxStyle.Exclamation)
            '    txtRefno.Focus()
            '    Return False
        Else
            Return True
        End If
    End Function

    Function fnSetData() As Boolean
        objCBP.CBPNo = txtAccountNo.Text
        objCBP.Amount = txtAmount.Text
        objCBP.RefNo = txtRefno.Text
        objCBP.ChequeClearedDate = dtpDepositDate.Value
        Return True
    End Function
    Function fnSetClearingData() As Boolean
        objCBP.CBPNo = txtAccountNo.Text
        objCBP.Amount = txtAmount.Text
        objCBP.RefNo = txtRefno.Text
        objCBP.ChequeClearedDate = dtpDepositDate.Value
        Return True
    End Function

    Sub CBPLoadDetail()
        Dim objDT As DataTable
        If objCBP.fnGetCBPDetails(txtAccountNo.Text) Then
            clearData()
            objDT = objCBP.CBPdetail
            txtAccountNo.Text = objDT.Rows(0).Item("AccountNo")
            txtName.Text = objDT.Rows(0).Item("Name")
            txtAmount.Text = objDT.Rows(0).Item("ChequeAmount")
            txtChequeNo.Text = objDT.Rows(0).Item("ChequeNo")
            If objDT.Rows(0).Item("ChequeStatus") = "P" Then
                cmbChequeStatus.SelectedItem = "Pending"
            ElseIf objDT.Rows(0).Item("ChequeStatus") = "C" Then
                cmbChequeStatus.SelectedItem = "Cleared"
            End If
        Else
            MsgBox("CBP numer dosent exist", MsgBoxStyle.Information)
            txtAccountNo.Focus()
        End If
    End Sub

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        'Loan Repayment With Securety Deposit Dr to repay Loan 

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        Dim strLoan As String
        Dim dblRemPrinciple As Double

        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        objCBP.fnUpdateCVoucherNo(lngVoucherNo, objTrans)

        Dim strNarration As String = "Cheque Clearing BY " & txtAccountNo.Text & " "

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtAccountNo.Text, txtRefno.Text, dtpDepositDate.Value, txtAmount.Text, "Cheque clearing by" & txtAmount.Text, lngSlNo, "Y", objTrans)

        'Credit accounts 
        fnVoucherEnterSub(lngVoucherNo, 2, txtAccountNo.Text, dtpDepositDate.Value, "Cheque clearing by account " & txtAccountNo.Text, "To", 50, 0, txtAmount.Text, 1, "Y", objTrans)

        'Debit Account
        fnVoucherEnterSub(lngVoucherNo, 2, " ", dtpDepositDate.Value, "Cheque clearing by account " & txtAccountNo.Text, "By", 1, txtAmount.Text, 0, 2, "Y", objTrans)

        Return True

    End Function

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim objCBPAccSearch As New frmCBPSearch
        objCBPAccSearch.strCBPNo = String.Empty
        objCBPAccSearch.ShowDialog(Me)
        If objCBPAccSearch.strCBPNo <> String.Empty Then
            txtAccountNo.Text = objCBPAccSearch.strCBPNo
            CBPLoadDetail()
        End If
        objCBPAccSearch.Dispose()
    End Sub

    Private Sub btnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransfer.Click
        Dim objTrans As IDbTransaction
        objTrans = fnGetTransaction()
        If fnCheck() Then
            If fnSetData() Then
                If MsgBox("CBP accountno  :  " & txtAccountNo.Text & " " & Chr(13) & "Cheque clearing amount  :  " & txtAmount.Text & " " & Chr(13) & " Type  :  Cash", MsgBoxStyle.OKCancel) = MsgBoxResult.OK Then
                    fnGenerateVoucher(objTrans)
                    fnLogEntry(pbUserId, "Cheque clearing by " & txtAccountNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction Cheque Clearing ")
                    objTrans.Commit()
                    If MsgBox("You want to make another transaction?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Conform Transaction") = MsgBoxResult.Yes Then
                        clearData()
                    Else
                        Me.Close()
                    End If
                End If

            End If
        End If
    End Sub

    Private Sub frmCBPClearing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpDepositDate.Value = Date.Now
        If txtAccountNo.Text <> "CBP" Then
            CBPLoadDetail()
        Else
            clearData()
        End If
    End Sub

    Private Sub txtAccountNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccountNo.Leave
        If txtAccountNo.Text <> "CBP" Then
            CBPLoadDetail()
        End If
    End Sub


    Private Sub txtAccountNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccountNo.TextChanged
        If txtAccountNo.Text.StartsWith("CBP") = False Then
            txtAccountNo.Undo()
            txtAccountNo.ClearUndo()
        End If
    End Sub
End Class
