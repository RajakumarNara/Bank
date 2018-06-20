Imports System.Math
Public Class frmCAinterestPosting
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
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnIntrestPayable As BankControls.NewButton
    Friend WithEvents btnExit As BankControls.NewButton
    Friend WithEvents btnPost As BankControls.NewButton
    Friend WithEvents txtRoi As BankControls.NumericControl
    Friend WithEvents NumericControl1 As BankControls.NumericControl
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvInterest As System.Windows.Forms.ListView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpPostDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents NewButton1 As BankControls.NewButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As BankControls.TextControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCAinterestPosting))
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.Label2 = New System.Windows.Forms.Label
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.NewButton1 = New BankControls.NewButton
        Me.btnIntrestPayable = New BankControls.NewButton
        Me.btnExit = New BankControls.NewButton
        Me.btnPost = New BankControls.NewButton
        Me.txtRoi = New BankControls.NumericControl
        Me.NumericControl1 = New BankControls.NumericControl
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.lvInterest = New System.Windows.Forms.ListView
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpPostDate = New System.Windows.Forms.DateTimePicker
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNarration = New BankControls.TextControl
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Current Balance"
        Me.ColumnHeader3.Width = 132
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(224, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 19)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Rate Of Interest :"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Interest Payable"
        Me.ColumnHeader4.Width = 127
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.NewButton1)
        Me.Panel1.Controls.Add(Me.btnIntrestPayable)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnPost)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(408, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(152, 248)
        Me.Panel1.TabIndex = 3
        '
        'NewButton1
        '
        Me.NewButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NewButton1.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.ForeColor = System.Drawing.Color.Black
        Me.NewButton1.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.NewButton1.Image = CType(resources.GetObject("NewButton1.Image"), System.Drawing.Image)
        Me.NewButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton1.Location = New System.Drawing.Point(16, 16)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(120, 48)
        Me.NewButton1.TabIndex = 4
        Me.NewButton1.Text = "&DayEnd"
        Me.NewButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnIntrestPayable
        '
        Me.btnIntrestPayable.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnIntrestPayable.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnIntrestPayable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIntrestPayable.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIntrestPayable.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIntrestPayable.ForeColor = System.Drawing.Color.Black
        Me.btnIntrestPayable.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnIntrestPayable.Image = CType(resources.GetObject("btnIntrestPayable.Image"), System.Drawing.Image)
        Me.btnIntrestPayable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIntrestPayable.Location = New System.Drawing.Point(16, 72)
        Me.btnIntrestPayable.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnIntrestPayable.Name = "btnIntrestPayable"
        Me.btnIntrestPayable.Size = New System.Drawing.Size(120, 48)
        Me.btnIntrestPayable.TabIndex = 5
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
        Me.btnExit.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(16, 184)
        Me.btnExit.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 48)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        '
        'btnPost
        '
        Me.btnPost.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPost.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnPost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPost.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPost.ForeColor = System.Drawing.Color.Black
        Me.btnPost.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnPost.Image = CType(resources.GetObject("btnPost.Image"), System.Drawing.Image)
        Me.btnPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPost.Location = New System.Drawing.Point(16, 128)
        Me.btnPost.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(120, 48)
        Me.btnPost.TabIndex = 8
        Me.btnPost.Text = "&Post Intrest"
        Me.btnPost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRoi
        '
        Me.txtRoi.AfterDecimal = 2
        Me.txtRoi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtRoi.BackColor = System.Drawing.Color.White
        Me.txtRoi.BeforeDecimal = 2
        Me.txtRoi.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoi.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRoi.Location = New System.Drawing.Point(352, 24)
        Me.txtRoi.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRoi.MaxValue = 0
        Me.txtRoi.MinValue = 0
        Me.txtRoi.Name = "txtRoi"
        Me.txtRoi.Size = New System.Drawing.Size(104, 23)
        Me.txtRoi.TabIndex = 2
        Me.txtRoi.Text = ""
        '
        'NumericControl1
        '
        Me.NumericControl1.AfterDecimal = 2
        Me.NumericControl1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NumericControl1.BeforeDecimal = 2
        Me.NumericControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericControl1.GotFocusColour = System.Drawing.SystemColors.Info
        Me.NumericControl1.Location = New System.Drawing.Point(352, 24)
        Me.NumericControl1.LostFocusColour = System.Drawing.Color.Empty
        Me.NumericControl1.MaxValue = 0
        Me.NumericControl1.MinValue = 0
        Me.NumericControl1.Name = "NumericControl1"
        Me.NumericControl1.Size = New System.Drawing.Size(104, 22)
        Me.NumericControl1.TabIndex = 30
        Me.NumericControl1.Text = ""
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "AccountNo"
        Me.ColumnHeader1.Width = 80
        '
        'lvInterest
        '
        Me.lvInterest.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lvInterest.CheckBoxes = True
        Me.lvInterest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvInterest.FullRowSelect = True
        Me.lvInterest.GridLines = True
        Me.lvInterest.Location = New System.Drawing.Point(16, 104)
        Me.lvInterest.MultiSelect = False
        Me.lvInterest.Name = "lvInterest"
        Me.lvInterest.Size = New System.Drawing.Size(372, 256)
        Me.lvInterest.TabIndex = 7
        Me.lvInterest.View = System.Windows.Forms.View.Details
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 19)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Date :"
        '
        'dtpPostDate
        '
        Me.dtpPostDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpPostDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPostDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPostDate.Location = New System.Drawing.Point(88, 24)
        Me.dtpPostDate.Name = "dtpPostDate"
        Me.dtpPostDate.Size = New System.Drawing.Size(120, 23)
        Me.dtpPostDate.TabIndex = 1
        Me.dtpPostDate.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(16, 72)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(88, 24)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Select all"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(16, 368)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 19)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "Narration :"
        '
        'txtNarration
        '
        Me.txtNarration.AlphaNumeric = True
        Me.txtNarration.BlankSpace = True
        Me.txtNarration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtNarration.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNarration.Location = New System.Drawing.Point(104, 368)
        Me.txtNarration.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNarration.Mandatory = False
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarration.Size = New System.Drawing.Size(256, 40)
        Me.txtNarration.SpecialChar = False
        Me.txtNarration.TabIndex = 165
        Me.txtNarration.Text = ""
        '
        'frmCAinterestPosting
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(578, 423)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNarration)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRoi)
        Me.Controls.Add(Me.NumericControl1)
        Me.Controls.Add(Me.dtpPostDate)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lvInterest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCAinterestPosting"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CA Interest Posting"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Form Global Variables"

    Dim objCAccount As New clsCurrentAccount
    Dim objMember As New clsMember
    Dim lngPersonNo As Long = 0
    Dim dvCAccounts As DataView
    Dim strFilter As String = "Name like '%'"
    Friend WithEvents dtp As New DateTimePicker
    Dim intCount As Integer

    Dim bolVisible As Boolean
    Dim objCA As New clsCurrentAccount
    Dim dtDayDtl As DataTable
    Dim objRd As New clsRDAccount

    Dim Today As Date
    Dim AccountNo As String
    Dim Balance As Double

    Dim row As Integer
    Dim AccountNotbl As DataTable
    Dim NoRows As Integer
    Dim BalanceTabel As DataTable
    Dim intLop As Integer = 0
    Dim iv As ListViewItem
#End Region

#Region "Code To Create Instance of Oblect"

    Private Shared m_FormDefInstance As frmCAinterestPosting
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmCAinterestPosting
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmCAinterestPosting
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmCAinterestPosting)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Function"

    Sub fnGetROI()
        Dim dtSettings As DataTable
        Dim strSQL As String = "SELECT * from CAMasterSettingstbl"
        dtSettings = fnExecuteQuery(strSQL, 2)
        If dtSettings.Rows.Count > 0 Then
            txtRoi.Text = dtSettings.Rows(0).Item("CARoi")
        End If
    End Sub

    Function fnLoadCAccounts() As Boolean
        Dim intCounter As Integer = 0
        Dim lvItem As New ListViewItem
        Dim intTotalBal As Integer = 0
        If Not dvCAccounts Is Nothing Then
            dvCAccounts.RowFilter = strFilter
            lvInterest.Items.Clear()
            While intCounter < dvCAccounts.Count
                lvItem = lvInterest.Items.Add(dvCAccounts.Item(intCounter).Item("CAccountNo"))
                lvItem.SubItems.Add(dvCAccounts.Item(intCounter).Item("Name"))
                'If dvCAccounts.Item(intCounter).Item("CAType") = "O" Then
                '    lvItem.SubItems.Add("Organization")
                'Else
                '    lvItem.SubItems.Add("Individual")
                'End If
                lvItem.SubItems.Add(Format(dvCAccounts.Item(intCounter).Item("IntAmount"), "0,00.00"))
                lvItem.SubItems.Add(Format(dvCAccounts.Item(intCounter).Item("AvailBalance"), "0,00.00"))
                intCounter += 1
            End While
        End If
    End Function
    Public Function fnCaliculateInt(ByVal NoOfDays As Integer, ByVal balance As Double) As Double
        Return Math.Round(((Abs(balance) * NoOfDays * (txtROI.Text / 100)) / 365), 2)
    End Function
    Public Function fnGenerateIntPostVoucher() As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpPostDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()
        Dim strNarration As String = "Interest Posted to Account = " & objCAccount.CurAccountNo & txtNarration.Text

        Dim strsql = "insert into catransactiontbl (Caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & objCAccount.CurAccountNo & "','" & Format(dtpPostDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','0','" & objCAccount.IntAmt & "','0','" & objCAccount.IntAmt & "',sum(Deposit)-sum(withdraw)-'" & objCAccount.IntAmt & "','0','0','" & lngVoucherNo & "','Cash','0' from catransactiontbl where CAccountNo='" & objCAccount.CurAccountNo & "' group by CAccountNo"
        fnExecuteNonQuery(strsql)

        fnVoucherEnterMain(lngVoucherNo, 2, objCAccount.CurAccountNo, "0", Format(dtpPostDate.Value, "yyyy-MM-dd"), objCAccount.IntAmt, strNarration, lngSlNo, "Y")

        'fnVoucherEnterSub(lngVoucherNo, 2, objCAccount.CurAccountNo, Format(dtpPostDate.Value, "yyyy-MM-dd"), strNarration, "By", 47, 0, objCAccount.IntAmt, 2, "Y")

        If objCAccount.AccBal <= 0 Then
            fnVoucherEnterSub(lngVoucherNo, 2, objCAccount.CurAccountNo, Format(dtpPostDate.Value, "yyyy-MM-dd"), strNarration, "To", 48, objCAccount.IntAmt, 0, 1, "Y")

        Else
            Dim dblTempBal As Double = objCAccount.AccBal - objCAccount.IntAmt
            If dblTempBal < 0 Then

                fnVoucherEnterSub(lngVoucherNo, 2, objCAccount.CurAccountNo, Format(dtpPostDate.Value, "yyyy-MM-dd"), strNarration, "To", 48, Abs(dblTempBal), 0, 3, "Y")

                fnVoucherEnterSub(lngVoucherNo, 2, objCAccount.CurAccountNo, Format(dtpPostDate.Value, "yyyy-MM-dd"), strNarration, "To", 11, objCAccount.AccBal, 0, 1, "Y")

                fnVoucherEnterSub(lngVoucherNo, 2, " ", Format(dtpPostDate.Value, "yyyy-MM-dd"), strNarration, "To", 1, objCAccount.AccBal, 0, 4, "Y")
            Else
                fnVoucherEnterSub(lngVoucherNo, 2, objCAccount.CurAccountNo, Format(dtpPostDate.Value, "yyyy-MM-dd"), strNarration, "To", 11, objCAccount.IntAmt, 0, 1, "Y")

                fnVoucherEnterSub(lngVoucherNo, 2, " ", Format(dtpPostDate.Value, "yyyy-MM-dd"), strNarration, "To", 1, objCAccount.IntAmt, 0, 3, "Y")

            End If

        End If

        Return True

    End Function
#End Region

    Private Sub frmCAinterestPosting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dtpPostDate.Enabled = False
        dtpPostDate.Value = Date.Now
        fnGetROI()

    End Sub

    Private Sub btnIntrestPayable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntrestPayable.Click
        'If objCAccount.fnGetCAccountlist() Then
        '    dvCAccounts = New DataView(objCAccount.CAAccTable, strFilter, "Name", DataViewRowState.OriginalRows)
        '    fnLoadCAccounts()
        'End If
        Dim NoOfDays As Integer = 0
        Dim CrtBalance As Double = 0
        Dim Count1 As Integer
        Dim AccountNo1 As String
        Dim Interest As Double
        Dim row As Integer = 0
        Dim rowss As Integer
        Dim AccountBalance As Double
        lvInterest.Items.Clear()
        objCA.fnGetAccountNos()
        AccountNotbl = objCA.AccountNos()
        NoRows = AccountNotbl.Rows.Count
        While (NoRows > 0)
            AccountNo = AccountNotbl.Rows(row).Item("CAccountNo")
            AccountBalance = AccountNotbl.Rows(row).Item("AvailBalance")
            objCA.fnGetCrtBalance(AccountNo)
            BalanceTabel = objCA.CrtBalance()
            Count1 = 0
            rowss = BalanceTabel.Rows.Count
            While (rowss > 0)
                If (BalanceTabel.Rows(Count1).Item("ClosingBalance") < 0) Then
                    NoOfDays += 1
                    CrtBalance += BalanceTabel.Rows(Count1).Item("ClosingBalance")

                End If
                Count1 += 1
                rowss -= 1
            End While

            Interest = fnCaliculateInt(NoOfDays, CrtBalance)
            '  InsertIntoLV(CrtBalance, AccountNo, Interest)

            iv = lvInterest.Items.Add(AccountNo)


            iv.SubItems.Add(Math.Round(AccountBalance))
            iv.SubItems.Add(Math.Round(Interest))

            'iv.SubItems.Add(Format(Math.Round(Interest)))

            CrtBalance = 0
            NoOfDays = 0
            intLop += 1
            NoRows -= 1
            row += 1
        End While

    End Sub

    Private Sub btnPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPost.Click
        Dim intCounter As Integer = 0
        objCAccount.Accdate = dtpPostDate.Value
        If lvInterest.CheckedItems.Count > 0 Then
            If MsgBox("Are you sure you want to post intrest?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Conforme") = MsgBoxResult.Yes Then
                While intCounter < lvInterest.CheckedItems.Count
                    objCAccount.CurAccountNo = lvInterest.CheckedItems(intCounter).SubItems(0).Text
                    objCAccount.IntAmt = lvInterest.CheckedItems(intCounter).SubItems(1).Text
                    objCAccount.AccBal = lvInterest.CheckedItems(intCounter).SubItems(2).Text
                    fnGenerateIntPostVoucher()
                    objCAccount.fnUpdateIntrest(lvInterest.CheckedItems(intCounter).SubItems(0).Text)
                    intCounter += 1
                End While
                MsgBox("Intrest posted successfully", MsgBoxStyle.Information, Me.Text)
                btnIntrestPayable_Click(sender, e)
            End If
        Else
            MsgBox("No records were selected, please select the records to delete", MsgBoxStyle.Information, Me.Text)
            lvInterest.Focus()
        End If
        ' fnPostInt()
        ' fnGenerateVoucher()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objCAMaster As frmCAMasterSetting
        objCAMaster = frmCAMasterSetting.DefInstance
        objCAMaster.BringToFront()
        'objCAMaster.MdiParent = Me
        objCAMaster.Show()
        objCAMaster = Nothing
    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click
        Dim objCA As New clsCurrentAccount
        Dim dtDayDtl As DataTable
        Dim intCount As Integer
        Dim row As Integer
        Dim AccountNo As String
        Dim Balance As Double
        If (objCA.fnGetDayDetails()) Then
            dtDayDtl = objCA.AccountDetails()
            intCount = dtDayDtl.Rows.Count
            row = 0
            While (intCount > 0)


                AccountNo = dtDayDtl.Rows(row).Item("CAccountNo")
                Balance = dtDayDtl.Rows(row).Item("AvailBalance")
                Today = dtpPostDate.Value
                objCA.fnInsertDetails(AccountNo, Balance, Today)


                intCount -= 1
                row += 1
            End While
            MsgBox("Successfuly entered", MsgBoxStyle.Exclamation)


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
End Class
