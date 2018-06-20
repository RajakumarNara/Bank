Public Class frmBnncToBnnd
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
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PnlAdd As System.Windows.Forms.Panel
    Friend WithEvents dtpAccDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtReceiptNo As BankControls.TextControl
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAgentNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAgentName As BankControls.TextControl
    Friend WithEvents btnMemSearch As BankControls.NewButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDeposit As BankControls.NewButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As BankControls.TextControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBnncToBnnd))
        Me.btnCancel = New BankControls.NewButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PnlAdd = New System.Windows.Forms.Panel
        Me.dtpAccDate = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtReceiptNo = New BankControls.TextControl
        Me.Label24 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAgentNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAgentName = New BankControls.TextControl
        Me.btnMemSearch = New BankControls.NewButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnDeposit = New BankControls.NewButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtNarration = New BankControls.TextControl
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.Beige
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(496, 424)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "&Close"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(472, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 24)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Balance"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(272, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 24)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Name"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(152, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 23)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Account No."
        '
        'PnlAdd
        '
        Me.PnlAdd.AutoScroll = True
        Me.PnlAdd.Location = New System.Drawing.Point(128, 208)
        Me.PnlAdd.Name = "PnlAdd"
        Me.PnlAdd.Size = New System.Drawing.Size(468, 208)
        Me.PnlAdd.TabIndex = 6
        '
        'dtpAccDate
        '
        Me.dtpAccDate.CustomFormat = "dd - MMM - yyyy "
        Me.dtpAccDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAccDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAccDate.Location = New System.Drawing.Point(472, 144)
        Me.dtpAccDate.MaxDate = New Date(9998, 12, 28, 0, 0, 0, 0)
        Me.dtpAccDate.MinDate = New Date(1964, 1, 1, 0, 0, 0, 0)
        Me.dtpAccDate.Name = "dtpAccDate"
        Me.dtpAccDate.Size = New System.Drawing.Size(144, 23)
        Me.dtpAccDate.TabIndex = 5
        Me.dtpAccDate.Value = New Date(2005, 8, 29, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(368, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 16)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Date :"
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AlphaNumeric = True
        Me.txtReceiptNo.BlankSpace = False
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(160, 136)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReceiptNo.Mandatory = False
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(136, 23)
        Me.txtReceiptNo.SpecialChar = False
        Me.txtReceiptNo.TabIndex = 4
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(64, 136)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(95, 16)
        Me.Label24.TabIndex = 65
        Me.Label24.Text = "Receipt No. :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtAgentNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAgentName)
        Me.GroupBox1.Controls.Add(Me.btnMemSearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(40, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 64)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agent's information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Agent No. :"
        '
        'txtAgentNo
        '
        Me.txtAgentNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgentNo.Location = New System.Drawing.Point(120, 24)
        Me.txtAgentNo.MaxLength = 10
        Me.txtAgentNo.Name = "txtAgentNo"
        Me.txtAgentNo.Size = New System.Drawing.Size(136, 23)
        Me.txtAgentNo.TabIndex = 1
        Me.txtAgentNo.Text = "AG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(320, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Agent Name : "
        '
        'txtAgentName
        '
        Me.txtAgentName.AlphaNumeric = True
        Me.txtAgentName.BlankSpace = False
        Me.txtAgentName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgentName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAgentName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtAgentName.Location = New System.Drawing.Point(432, 24)
        Me.txtAgentName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAgentName.Mandatory = False
        Me.txtAgentName.MaxLength = 20
        Me.txtAgentName.Name = "txtAgentName"
        Me.txtAgentName.Size = New System.Drawing.Size(168, 23)
        Me.txtAgentName.SpecialChar = True
        Me.txtAgentName.TabIndex = 3
        '
        'btnMemSearch
        '
        Me.btnMemSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMemSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMemSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemSearch.ForeColor = System.Drawing.Color.Black
        Me.btnMemSearch.GotFocusColour = System.Drawing.Color.Beige
        Me.btnMemSearch.Image = CType(resources.GetObject("btnMemSearch.Image"), System.Drawing.Image)
        Me.btnMemSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMemSearch.Location = New System.Drawing.Point(264, 24)
        Me.btnMemSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnMemSearch.Name = "btnMemSearch"
        Me.btnMemSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnMemSearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline)
        Me.Label1.Location = New System.Drawing.Point(56, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 32)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Agent's Pigmy Deposit  collection "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposit.GotFocusColour = System.Drawing.Color.Beige
        Me.btnDeposit.Image = CType(resources.GetObject("btnDeposit.Image"), System.Drawing.Image)
        Me.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeposit.Location = New System.Drawing.Point(392, 424)
        Me.btnDeposit.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(104, 40)
        Me.btnDeposit.TabIndex = 8
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(56, 424)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "Narration :"
        '
        'txtNarration
        '
        Me.txtNarration.AlphaNumeric = True
        Me.txtNarration.BlankSpace = True
        Me.txtNarration.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNarration.Location = New System.Drawing.Point(152, 424)
        Me.txtNarration.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNarration.Mandatory = False
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarration.Size = New System.Drawing.Size(200, 64)
        Me.txtNarration.SpecialChar = False
        Me.txtNarration.TabIndex = 7
        '
        'frmBnncToBnnd
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(688, 501)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNarration)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PnlAdd)
        Me.Controls.Add(Me.dtpAccDate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtReceiptNo)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBnncToBnnd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pigmy Collection To Pigmy Deposit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
#Region "variables"
    Dim objClsPigmyAgent As New clsPigmyAgent
    Dim objCtrl(200) As BnncBnndCtrl
    Dim a As AgentsCustomers
    Dim dttransaction As DataTable
    Dim objClsPigmyAccount As New clsPigmyAccount
    Dim objAgent As New clsPigmyAccount
    Private Shared m_FormDefInstance As fmAgentsCustomers
    Private Shared m_InitializingDefInstance As Boolean
    'Dim dtROI As AgentsCustomers
    Dim dtROII As BnncBnndCtrl
    Dim objPGAccount As New clsPigmyAccount
    Dim objIntrSet As DataTable
    Dim nomoney As Integer = 0
    Dim PanelSizeDeclar As Integer = 0
    Dim intCount As Integer = 0

#End Region

#Region " functions "
    Public Function fnGetData(ByVal str As String) As Boolean

        If objClsPigmyAgent.fnCheckAgent(str) Then

            txtAgentName.Text = objClsPigmyAgent.CheckAgentTable.Rows(0).Item("AgentName")
            If (str <> String.Empty) Then
                fnLoadData(str)
            End If
        End If

    End Function
    Public Function fnLoadIntrCtrl()
        Dim intCount As Integer
        Dim ctrlHt As Integer
        dtpAccDate.Value = Date.Now
        While intCount < PanelSizeDeclar
            objCtrl(intCount) = New BnncBnndCtrl
            ctrlHt = objCtrl(intCount).Height
            objCtrl(intCount).Top = (ctrlHt) * intCount
            PnlAdd.Controls.Add(objCtrl(intCount))
            PnlAdd.Controls.Add(objCtrl(intCount))
            intCount += 1
        End While
    End Function
    Public Function fnLoadData(ByVal str As String) As Boolean

        If objClsPigmyAgent.fnGetList(str) Then
            objIntrSet = objClsPigmyAgent.AgentsCustTable()
            Dim intCount As Integer
            PanelSizeDeclar = objIntrSet.Rows.Count
            fnLoadIntrCtrl()
            While intCount < objIntrSet.Rows.Count
                objCtrl(intCount).txtAccNo.Text = objIntrSet.Rows(intCount).Item("PigmyAccNo")
                objCtrl(intCount).txtName.Text = objIntrSet.Rows(intCount).Item("Name")
                objCtrl(intCount).txtAvailable.Text = objIntrSet.Rows(intCount).Item("AvailCollection")
                intCount += 1
            End While
        End If

    End Function

Function fnCheck() As Boolean

        If txtAgentNo.Text = String.Empty Then
            MsgBox("Please select the agent ID", MsgBoxStyle.Information)
            txtAgentNo.Focus()
            Return False
        ElseIf txtReceiptNo.Text = String.Empty Then

            MsgBox("Please enter the recipt no", MsgBoxStyle.Information)
            txtReceiptNo.Focus()
            Return False
            'ElseIf Value(dtpAccDate) = "" Then
            '    MsgBox("please enter deposit date", MsgBoxStyle.Information)
            '    Return False
        Else
            Return True
        End If

    End Function
    Public Function fnSetData() As Boolean



        objAgent.AgnetNo = txtAgentNo.Text
        If dtROII.txtAvailable.Text = 0 Then
            'dtROII.txtAvailable.Text = 0
            nomoney += 1
            Return False
        End If
        objAgent.Amount = dtROII.txtAvailable.Text
        objAgent.Reference = txtReceiptNo.Text
        objAgent.TransDate = dtpAccDate.Value
        objAgent.PGNo = dtROII.txtAccNo.Text
        objAgent.Narration = "By new account " & "dtROII.txtAccNo.Text"
        'objAgent.PGName = txtPGName.Text
        objAgent.TransDate = dtpAccDate.Value
        Return True

        Return True

    End Function
    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpAccDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entery
        objPGAccount.frnPGCollectionWithdraw(Trim(dtROII.txtAccNo.Text), dtpAccDate.Value, "BNND by account  " & dtROII.txtAccNo.Text & txtNarration.Text, 0, Trim(dtROII.txtAvailable.Text), Trim(dtROII.txtAvailable.Text), txtReceiptNo.Text, lngVoucherNo, "Cash", 0, txtAgentNo.Text, objTrans)


        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 7, dtROII.txtAccNo.Text, txtReceiptNo.Text, dtpAccDate.Value, dtROII.txtAvailable.Text, "BNND by account " & dtROII.txtAccNo.Text & txtNarration.Text, lngSlNo, "Y", objTrans)

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 7, dtROII.txtAccNo.Text, dtpAccDate.Value, "BNND by account " & dtROII.txtAccNo.Text & txtNarration.Text, "To", 123, 0, Val(dtROII.txtAvailable.Text), 1, "Y", objTrans)

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 7, dtROII.txtAccNo.Text, dtpAccDate.Value, "BNND by account " & dtROII.txtAccNo.Text & txtNarration.Text, "By", 28, Val(dtROII.txtAvailable.Text), 0, 2, "Y", objTrans)

        Return True

    End Function
    Function clear(ByVal NoOfBNNCustomer As Integer)
        Dim Count = 0
        txtAgentNo.Text = ""

        txtReceiptNo.Text = ""
        txtAgentName.Text = ""
        dtpAccDate.Value = Date.Now

        While Count < NoOfBNNCustomer
            objCtrl(Count).txtAccNo.Text = ""
            objCtrl(Count).txtAvailable.Text = ""
            objCtrl(Count).txtName.Text = ""
            objCtrl(Count).txtAvailable.Text = ""
            Count += 1
        End While


    End Function

#End Region
    Private Sub btnMemSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMemSearch.Click
        Dim objAGSearch As New frmAGAccSearch
        objAGSearch.ShowDialog()
        If objAGSearch.strAGAccountNo <> String.Empty Then
            txtAgentNo.Text = objAGSearch.strAGAccountNo
            fnGetData(txtAgentNo.Text)
        End If
        objAGSearch.Dispose()
    End Sub

    Private Sub frmBnncToBnnd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpAccDate.Value = Date.Now

        fnLoadIntrCtrl()
    End Sub

    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click


        Dim objTrans As IDbTransaction
        objClsPigmyAgent.fnGetList(txtAgentNo.Text)
        objIntrSet = objClsPigmyAgent.AgentsCustTable()


        objClsPigmyAgent.AgentNo = txtAgentNo.Text
        objClsPigmyAccount.Reference = txtReceiptNo.Text
        objClsPigmyAccount.TransDate = dtpAccDate.Value
        Try

            While intCount < objIntrSet.Rows.Count

                objTrans = fnGetTransaction()
                dtROII = PnlAdd.Controls(intCount)
                If fnCheck() Then

                    If fnSetData() Then
                        fnGenerateVoucher(objTrans)
                        fnLogEntry(pbUserId, "Deposit by " & dtROII.txtAccNo.Text & " Amount " & dtROII.txtAvailable.Text, Date.Now, "Transaction Deposit", objTrans)
                        objTrans.Commit()
                    End If

                Else
                    GoTo label
                End If
                intCount += 1
            End While

            If intCount = objIntrSet.Rows.Count Then
                MsgBox("Transaction of " & intCount - nomoney & " member  done successfully", MsgBoxStyle.Information)
                clear(intCount)

            Else
                MsgBox("Transaction coudn't done due to internal errors", MsgBoxStyle.Information)
            End If

label:
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        Finally
            objTrans.Dispose()
        End Try
        Me.Close()
    End Sub

   
End Class
