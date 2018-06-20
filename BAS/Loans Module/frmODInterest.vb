Imports System.Math
Public Class frmoddayend
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
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtROI As BankControls.NumericControl
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpODLoanDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents lvLoanList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents NewButton1 As BankControls.NewButton
    Friend WithEvents btnIntrestPayable As BankControls.NewButton
    Friend WithEvents btnExit As BankControls.NewButton
    Friend WithEvents btnPost As BankControls.NewButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmoddayend))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNarration = New BankControls.TextControl
        Me.txtReceiptNo = New BankControls.NumericControl
        Me.Label27 = New System.Windows.Forms.Label
        Me.dtpODLoanDate = New System.Windows.Forms.DateTimePicker
        Me.Label37 = New System.Windows.Forms.Label
        Me.txtROI = New BankControls.NumericControl
        Me.Label15 = New System.Windows.Forms.Label
        Me.lvLoanList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.Label32 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.NewButton1 = New BankControls.NewButton
        Me.btnIntrestPayable = New BankControls.NewButton
        Me.btnExit = New BankControls.NewButton
        Me.btnPost = New BankControls.NewButton
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtNarration)
        Me.Panel1.Controls.Add(Me.txtReceiptNo)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.dtpODLoanDate)
        Me.Panel1.Controls.Add(Me.Label37)
        Me.Panel1.Controls.Add(Me.txtROI)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.lvLoanList)
        Me.Panel1.Location = New System.Drawing.Point(16, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 336)
        Me.Panel1.TabIndex = 1
        '
        'CheckBox1
        '
        Me.CheckBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(16, 88)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(88, 24)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Select all"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(24, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 19)
        Me.Label1.TabIndex = 164
        Me.Label1.Text = "Narration :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(-384, 296)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 19)
        Me.Label3.TabIndex = 163
        Me.Label3.Text = "Narration"
        '
        'txtNarration
        '
        Me.txtNarration.AlphaNumeric = True
        Me.txtNarration.BlankSpace = True
        Me.txtNarration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtNarration.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNarration.Location = New System.Drawing.Point(112, 280)
        Me.txtNarration.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNarration.Mandatory = False
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarration.Size = New System.Drawing.Size(256, 40)
        Me.txtNarration.SpecialChar = False
        Me.txtNarration.TabIndex = 11
        Me.txtNarration.Text = ""
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 0
        Me.txtReceiptNo.BeforeDecimal = 7
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(112, 56)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtReceiptNo.MaxLength = 10
        Me.txtReceiptNo.MaxValue = 0
        Me.txtReceiptNo.MinValue = 0
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(136, 23)
        Me.txtReceiptNo.TabIndex = 4
        Me.txtReceiptNo.Text = ""
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.LightYellow
        Me.Label27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(16, 56)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(93, 19)
        Me.Label27.TabIndex = 161
        Me.Label27.Text = "Receipt No. :"
        '
        'dtpODLoanDate
        '
        Me.dtpODLoanDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpODLoanDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpODLoanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpODLoanDate.Location = New System.Drawing.Point(112, 16)
        Me.dtpODLoanDate.MaxDate = New Date(9998, 11, 18, 0, 0, 0, 0)
        Me.dtpODLoanDate.Name = "dtpODLoanDate"
        Me.dtpODLoanDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpODLoanDate.TabIndex = 2
        Me.dtpODLoanDate.Value = New Date(2010, 5, 25, 0, 0, 0, 0)
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.LightYellow
        Me.Label37.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(16, 16)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(47, 19)
        Me.Label37.TabIndex = 107
        Me.Label37.Text = "Date :"
        '
        'txtROI
        '
        Me.txtROI.AfterDecimal = 2
        Me.txtROI.BackColor = System.Drawing.SystemColors.Window
        Me.txtROI.BeforeDecimal = 8
        Me.txtROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.GotFocusColour = System.Drawing.Color.Empty
        Me.txtROI.Location = New System.Drawing.Point(328, 16)
        Me.txtROI.LostFocusColour = System.Drawing.Color.Empty
        Me.txtROI.MaxLength = 10
        Me.txtROI.MaxValue = 0
        Me.txtROI.MinValue = 0
        Me.txtROI.Name = "txtROI"
        Me.txtROI.Size = New System.Drawing.Size(80, 23)
        Me.txtROI.TabIndex = 3
        Me.txtROI.TabStop = False
        Me.txtROI.Text = ""
        Me.txtROI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(272, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 19)
        Me.Label15.TabIndex = 105
        Me.Label15.Text = " ROI :"
        '
        'lvLoanList
        '
        Me.lvLoanList.CheckBoxes = True
        Me.lvLoanList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader7})
        Me.lvLoanList.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLoanList.FullRowSelect = True
        Me.lvLoanList.GridLines = True
        Me.lvLoanList.Location = New System.Drawing.Point(16, 120)
        Me.lvLoanList.Name = "lvLoanList"
        Me.lvLoanList.Size = New System.Drawing.Size(392, 152)
        Me.lvLoanList.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvLoanList.TabIndex = 10
        Me.lvLoanList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "OD Number"
        Me.ColumnHeader1.Width = 95
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Current Balance"
        Me.ColumnHeader2.Width = 121
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Interest Payable"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 118
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.LightYellow
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Olive
        Me.Label32.Location = New System.Drawing.Point(48, 8)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(109, 25)
        Me.Label32.TabIndex = 69
        Me.Label32.Text = "OD Interest"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.NewButton1)
        Me.Panel2.Controls.Add(Me.btnIntrestPayable)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnPost)
        Me.Panel2.Location = New System.Drawing.Point(464, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(168, 264)
        Me.Panel2.TabIndex = 5
        '
        'NewButton1
        '
        Me.NewButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NewButton1.BackColor = System.Drawing.Color.LightYellow
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.ForeColor = System.Drawing.Color.Black
        Me.NewButton1.GotFocusColour = System.Drawing.Color.LightYellow
        Me.NewButton1.Image = CType(resources.GetObject("NewButton1.Image"), System.Drawing.Image)
        Me.NewButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton1.Location = New System.Drawing.Point(24, 24)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.LightYellow
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(120, 48)
        Me.NewButton1.TabIndex = 6
        Me.NewButton1.Text = "&DayEnd"
        Me.NewButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnIntrestPayable
        '
        Me.btnIntrestPayable.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnIntrestPayable.BackColor = System.Drawing.Color.LightYellow
        Me.btnIntrestPayable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIntrestPayable.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIntrestPayable.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIntrestPayable.ForeColor = System.Drawing.Color.Black
        Me.btnIntrestPayable.GotFocusColour = System.Drawing.Color.LightYellow
        Me.btnIntrestPayable.Image = CType(resources.GetObject("btnIntrestPayable.Image"), System.Drawing.Image)
        Me.btnIntrestPayable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIntrestPayable.Location = New System.Drawing.Point(24, 80)
        Me.btnIntrestPayable.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnIntrestPayable.Name = "btnIntrestPayable"
        Me.btnIntrestPayable.Size = New System.Drawing.Size(120, 48)
        Me.btnIntrestPayable.TabIndex = 7
        Me.btnIntrestPayable.Text = "&Int Earned"
        Me.btnIntrestPayable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.GotFocusColour = System.Drawing.Color.LightYellow
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(24, 195)
        Me.btnExit.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 48)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "E&xit"
        '
        'btnPost
        '
        Me.btnPost.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPost.BackColor = System.Drawing.Color.LightYellow
        Me.btnPost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPost.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPost.ForeColor = System.Drawing.Color.Black
        Me.btnPost.GotFocusColour = System.Drawing.Color.LightYellow
        Me.btnPost.Image = CType(resources.GetObject("btnPost.Image"), System.Drawing.Image)
        Me.btnPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPost.Location = New System.Drawing.Point(24, 136)
        Me.btnPost.LostFocusColour = System.Drawing.Color.LightYellow
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(120, 48)
        Me.btnPost.TabIndex = 8
        Me.btnPost.Text = "&Post Intrest"
        Me.btnPost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmoddayend
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(648, 445)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmoddayend"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OD Interest"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim objRd As New clsRDAccount
    Dim dtDayDtl As New DataTable
    Dim Today As Date
    Dim AccountNo As String
    Dim Balance As Double
    Dim intCount As Integer
    Dim row As Integer
    Dim AccountNotbl As DataTable
    Dim NoRows As Integer
    Dim BalanceTabel As DataTable
    Dim intLop As Integer = 0
    Dim iv As ListViewItem



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      

    End Sub
    Public Function fnCaliculateInt(ByVal NoOfDays As Integer, ByVal balance As Double) As Double
        Return Math.Round(((Abs(balance) * NoOfDays * (txtROI.Text / 100)) / 365), 2)
    End Function
    Public Function InsertIntoLV(ByVal balance As Double, ByVal AccountNo As String, ByVal interest As Double)



        iv = lvLoanList.Items.Add(intLop)
        iv.SubItems.Add(AccountNo)
        iv.SubItems.Add(Format(Math.Round(balance), "0,00.00"))
        iv.SubItems.Add(Format(Math.Round(interest), "0,00.00"))
        

        intLop += 1

    End Function
    Function fnGenerateVoucherInt(ByVal AccountNo As String, ByVal TrDate As Date, ByVal Interest As Double, ByVal intReceiptNo As Integer, ByVal Balance As Double) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(TrDate)
        lngSlNo = fnVoucherGetNewSlNo()

        Dim strNarration As String = "Interest posting by " & AccountNo & txtNarration.Text
        'Transaction Entry
        Dim strsql = "insert into odtransactiontbl (accountno,trdate,narration,deposit,withdraw,postbal,IntAmount,IntTobePaid,IntPaid,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(AccountNo) & "','" & Format(TrDate, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "' ,'0','" & Interest & "',sum(withdraw)-sum(Deposit)+'" & Interest & "','" & Interest & "','" & Interest & "','" & Interest & "','" & intReceiptNo & "','" & lngVoucherNo & "','Cash','0' from odtransactiontbl where accountno='" & AccountNo & "' group by Accountno"
        fnExecuteNonQuery(strsql)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 1, AccountNo, intReceiptNo, TrDate, Interest, "Interest posting by " & AccountNo, lngSlNo, "Y")

        'Credit accounts
        ' fnVoucherEnterSub(lngVoucherNo, 1, "", TrDate, "Interest posting by account " & AccountNo, "To", 1, 0, Interest, 1, "Y")
        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 1, AccountNo, TrDate, "Interest posting by account " & AccountNo, "By", 12, Interest, 0, 2, "Y")

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 2, AccountNo, TrDate, "Interest postingt by account " & AccountNo, "To", 46, 0, Interest, 3, "Y")
        'Debit accounts 
        ' fnVoucherEnterSub(lngVoucherNo, 2, " ", TrDate, "Interest posting by account " & AccountNo, "By", 1, Interest, 0, 4, "Y")

        Return True

    End Function
    Function fnCheck() As Boolean
        If (txtReceiptNo.Text = String.Empty) Then
            MsgBox("Enter Receiptno", MsgBoxStyle.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function
    Function fnCheckROI() As Boolean
        If (txtROI.Text = String.Empty) Then
            MsgBox("Enter rate of interest", MsgBoxStyle.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim NoOfDays As Integer = 0
        Dim CrtBalance As Double = 0
        Dim Count1 As Integer
        Dim AccountNo1 As String
        Dim Interest As Double
        Dim row As Integer = 0
        Dim rowss As Integer
        lvLoanList.Items.Clear()
        objRd.fnGetAccountNos()
        AccountNotbl = objRd.AccountNostbl()
        NoRows = AccountNotbl.Rows.Count
        While (NoRows > 0)
            AccountNo = AccountNotbl.Rows(row).Item("AccountNo")
            objRd.fnGetCrtBalance(AccountNo)
            BalanceTabel = objRd.CrtBalance()
            Count1 = 0
            rowss = BalanceTabel.Rows.Count
            While (rowss > 0)
                If (BalanceTabel.Rows(Count1).Item("ClosingBalance") > 0) Then
                    NoOfDays += 1
                    CrtBalance += BalanceTabel.Rows(Count1).Item("ClosingBalance")

                End If
                Count1 += 1
                rowss -= 1
            End While

            Interest = fnCaliculateInt(NoOfDays, CrtBalance)
            '  InsertIntoLV(CrtBalance, AccountNo, Interest)
            iv = lvLoanList.Items.Add(AccountNo)
            iv.SubItems.Add(Math.Round(CrtBalance))

            iv.SubItems.Add(Math.Round(Interest))

            'iv.SubItems.Add(Format(Math.Round(Interest)))

            CrtBalance = 0
            NoOfDays = 0
            intLop += 1
            NoRows -= 1
            row += 1
        End While

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (objRd.fnGetDayDetails()) Then
            dtDayDtl = objRd.dtIntPost()
            intCount = dtDayDtl.Rows.Count
            row = 0
            While (intCount > 0)


                AccountNo = dtDayDtl.Rows(row).Item("AccountNo")
                Balance = dtDayDtl.Rows(row).Item("Balance")
                Today = Date.Now
                objRd.fnInsertDetails(AccountNo, Balance, Today)


                intCount -= 1
                row += 1
            End While
            MsgBox("Successfuly entered", MsgBoxStyle.Exclamation)


        End If
    End Sub

    Private Sub frmoddayend_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpODLoanDate.Value = Date.Now
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim TrDate As Date
        TrDate = Date.Now
        Dim Balance As Double
        Dim intReceiptNo As Integer
        If fnCheck() Then

            intReceiptNo = txtReceiptNo.Text
            Dim Interest As Double
            For Each lvItems As ListViewItem In lvLoanList.Items
                AccountNo = lvItems.SubItems(0).Text
                Balance = lvItems.SubItems(1).Text
                Interest = lvItems.SubItems(2).Text

                objRd.fnUpdateInterest(AccountNo, TrDate)
                fnGenerateVoucherInt(AccountNo, TrDate, Math.Round(Interest), intReceiptNo, Math.Round(Balance))

            Next
            MsgBox("Successfuly posted", MsgBoxStyle.Exclamation)

        End If

    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click
        If (objRd.fnGetAccountNos()) Then
            dtDayDtl = objRd.AccountNostbl()
            intCount = dtDayDtl.Rows.Count
            row = 0
            While (intCount > 0)


                AccountNo = dtDayDtl.Rows(row).Item("AccountNo")
                Balance = dtDayDtl.Rows(row).Item("Balance")
                Today = Date.Now
                objRd.fnInsertDetails(AccountNo, Balance, Today)


                intCount -= 1
                row += 1
            End While
            MsgBox("Successfuly entered", MsgBoxStyle.Exclamation)


        End If

    End Sub

    Private Sub btnIntrestPayable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntrestPayable.Click
        Dim NoOfDays As Integer = 0
        Dim CrtBalance As Double = 0
        Dim Count1 As Integer
        Dim AccountNo1 As String
        Dim Interest As Double
        Dim row As Integer = 0
        Dim rowss As Integer
        Dim Balance As Double
        lvLoanList.Items.Clear()
        objRd.fnGetAccountNos()
        AccountNotbl = objRd.AccountNostbl()
        NoRows = AccountNotbl.Rows.Count
        If (fnCheckROI()) Then
            While (NoRows > 0)
                AccountNo = AccountNotbl.Rows(row).Item("AccountNo")
                Balance = AccountNotbl.Rows(row).Item("Balance")
                objRd.fnGetCrtBalance(AccountNo)
                BalanceTabel = objRd.CrtBalance()
                Count1 = 0
                rowss = BalanceTabel.Rows.Count
                While (rowss > 0)
                    If (BalanceTabel.Rows(Count1).Item("ClosingBalance") > 0) Then
                        NoOfDays += 1
                        CrtBalance += BalanceTabel.Rows(Count1).Item("ClosingBalance")

                    End If
                    Count1 += 1
                    rowss -= 1
                End While

                Interest = fnCaliculateInt(NoOfDays, CrtBalance)
                '  InsertIntoLV(CrtBalance, AccountNo, Interest)
                iv = lvLoanList.Items.Add(AccountNo)
                iv.SubItems.Add(Math.Round(Balance))

                iv.SubItems.Add(Math.Round(Interest))

                'iv.SubItems.Add(Format(Math.Round(Interest)))

                CrtBalance = 0
                NoOfDays = 0
                intLop += 1
                NoRows -= 1
                row += 1
            End While
        End If
    End Sub

    Private Sub btnPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPost.Click
        Dim TrDate As Date
        TrDate = Date.Now
        Dim Balance As Double
        Dim intReceiptNo As Integer
        If fnCheck() Then

            intReceiptNo = txtReceiptNo.Text
            Dim Interest As Double
            For Each lvItems As ListViewItem In lvLoanList.Items
                AccountNo = lvItems.SubItems(0).Text
                Balance = lvItems.SubItems(1).Text
                Interest = lvItems.SubItems(2).Text

                objRd.fnUpdateInterest(AccountNo, TrDate)
                fnGenerateVoucherInt(AccountNo, TrDate, Math.Round(Interest), intReceiptNo, Math.Round(Balance))

            Next
            MsgBox("Successfuly posted", MsgBoxStyle.Exclamation)

        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            If lvLoanList.Items.Count > 0 Then
                For Each lvItems As ListViewItem In lvLoanList.Items
                    lvItems.Checked = True
                Next
            End If
        Else
            If lvLoanList.Items.Count > 0 Then
                For Each lvItems As ListViewItem In lvLoanList.Items
                    lvItems.Checked = False
                Next
            End If
        End If
    End Sub
End Class
