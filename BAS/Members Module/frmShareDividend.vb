Public Class frmShareDividend
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgShareApplist As System.Windows.Forms.DataGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnExit As BankControls.NewButton
    Friend WithEvents btnPostDiv As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dtpDivDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As BankControls.TextControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNoOfShares As BankControls.TextControl
    Friend WithEvents txtDivAmount As BankControls.TextControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgShareApplist = New System.Windows.Forms.DataGrid
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnPostDiv = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.btnExit = New BankControls.NewButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.dtpDivDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAmount = New BankControls.TextControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNoOfShares = New BankControls.TextControl
        Me.txtDivAmount = New BankControls.TextControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.dgShareApplist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(400, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form To Post Dividend For The Share Holders"
        '
        'dgShareApplist
        '
        Me.dgShareApplist.AlternatingBackColor = System.Drawing.Color.Beige
        Me.dgShareApplist.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgShareApplist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgShareApplist.CaptionBackColor = System.Drawing.SystemColors.Control
        Me.dgShareApplist.CaptionFont = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgShareApplist.DataMember = ""
        Me.dgShareApplist.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgShareApplist.HeaderBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgShareApplist.HeaderFont = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgShareApplist.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgShareApplist.Location = New System.Drawing.Point(16, 232)
        Me.dgShareApplist.Name = "dgShareApplist"
        Me.dgShareApplist.Size = New System.Drawing.Size(560, 272)
        Me.dgShareApplist.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnPostDiv)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Location = New System.Drawing.Point(432, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(144, 152)
        Me.Panel1.TabIndex = 11
        '
        'btnPostDiv
        '
        Me.btnPostDiv.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnPostDiv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPostDiv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPostDiv.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPostDiv.ForeColor = System.Drawing.Color.Black
        Me.btnPostDiv.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(239, Byte), CType(238, Byte))
        Me.btnPostDiv.Location = New System.Drawing.Point(16, 24)
        Me.btnPostDiv.LostFocusColour = System.Drawing.Color.FromArgb(CType(205, Byte), CType(196, Byte), CType(194, Byte))
        Me.btnPostDiv.Name = "btnPostDiv"
        Me.btnPostDiv.Size = New System.Drawing.Size(112, 40)
        Me.btnPostDiv.TabIndex = 11
        Me.btnPostDiv.Text = "Post Dividend"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(239, Byte), CType(238, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(16, 88)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(205, Byte), CType(196, Byte), CType(194, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 40)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel Dividend"
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(239, Byte), CType(238, Byte))
        Me.btnExit.Location = New System.Drawing.Point(472, 512)
        Me.btnExit.LostFocusColour = System.Drawing.Color.FromArgb(CType(205, Byte), CType(196, Byte), CType(194, Byte))
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 40)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "&Close"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.dtpDivDate)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtAmount)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtNoOfShares)
        Me.Panel2.Controls.Add(Me.txtDivAmount)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(16, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 176)
        Me.Panel2.TabIndex = 13
        '
        'dtpDivDate
        '
        Me.dtpDivDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpDivDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDivDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDivDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDivDate.Location = New System.Drawing.Point(216, 133)
        Me.dtpDivDate.MaxDate = New Date(2500, 11, 16, 0, 0, 0, 0)
        Me.dtpDivDate.Name = "dtpDivDate"
        Me.dtpDivDate.Size = New System.Drawing.Size(144, 23)
        Me.dtpDivDate.TabIndex = 21
        Me.dtpDivDate.Value = New Date(2007, 9, 17, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Total Amount For Dividend : "
        '
        'txtAmount
        '
        Me.txtAmount.AlphaNumeric = True
        Me.txtAmount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAmount.BackColor = System.Drawing.SystemColors.Window
        Me.txtAmount.BlankSpace = True
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmount.Location = New System.Drawing.Point(216, 13)
        Me.txtAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtAmount.Mandatory = False
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(144, 23)
        Me.txtAmount.SpecialChar = True
        Me.txtAmount.TabIndex = 16
        Me.txtAmount.Text = ""
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 19)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Total No Of Shares : "
        '
        'txtNoOfShares
        '
        Me.txtNoOfShares.AlphaNumeric = True
        Me.txtNoOfShares.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNoOfShares.BackColor = System.Drawing.SystemColors.Window
        Me.txtNoOfShares.BlankSpace = True
        Me.txtNoOfShares.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfShares.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNoOfShares.Location = New System.Drawing.Point(216, 53)
        Me.txtNoOfShares.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtNoOfShares.Mandatory = False
        Me.txtNoOfShares.MaxLength = 10
        Me.txtNoOfShares.Name = "txtNoOfShares"
        Me.txtNoOfShares.Size = New System.Drawing.Size(144, 23)
        Me.txtNoOfShares.SpecialChar = True
        Me.txtNoOfShares.TabIndex = 15
        Me.txtNoOfShares.Text = ""
        '
        'txtDivAmount
        '
        Me.txtDivAmount.AlphaNumeric = True
        Me.txtDivAmount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDivAmount.BackColor = System.Drawing.SystemColors.Window
        Me.txtDivAmount.BlankSpace = True
        Me.txtDivAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDivAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtDivAmount.Location = New System.Drawing.Point(216, 93)
        Me.txtDivAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtDivAmount.Mandatory = False
        Me.txtDivAmount.MaxLength = 10
        Me.txtDivAmount.Name = "txtDivAmount"
        Me.txtDivAmount.Size = New System.Drawing.Size(144, 23)
        Me.txtDivAmount.SpecialChar = True
        Me.txtDivAmount.TabIndex = 14
        Me.txtDivAmount.Text = ""
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 19)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Dividend Amount : "
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 19)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Date : "
        '
        'frmShareDividend
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(594, 559)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgShareApplist)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmShareDividend"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Share Dividend"
        CType(Me.dgShareApplist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmShareDividend
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmShareDividend
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmShareDividend
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmShareDividend)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Variables"

    Dim objClsShares As New clsShares

#End Region

#Region "Functions"

    Public Function fnGetShareDetails() As Boolean

        If objClsShares.fnGetShareList Then

            If objClsShares.ShareListTbl.Rows.Count > 0 Then
                dgShareApplist.DataSource = objClsShares.ShareListTbl.DefaultView

                ''''dgShareApplist.DataSource = objClsShares.ShareListTbl.Rows(0).Item("Name")
                ''''dgShareApplist.DataSource = objClsShares.ShareListTbl.Rows(0).Item("NoOfShares")

            End If

        End If

    End Function

    Public Function fnCheck() As Boolean

        If txtAmount.Text = String.Empty Then
            MsgBox("Please enter total amount for dividend", MsgBoxStyle.Critical, "Members Module")
            txtAmount.Focus()
            Return False

        ElseIf Val(txtDivAmount.Text) < 0.5 Then
            MsgBox("Amount is to low to apply dividend", MsgBoxStyle.Exclamation, "Members Module")
            txtAmount.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Public Function fnGetNoOfShares() As Boolean

        If objClsShares.fnGetNoOfShares Then
            txtNoOfShares.Text = objClsShares.NoOfSharestbl.Rows(0).Item("NoOfShares")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function fnSetData() As Boolean

        objClsShares.NoOfShares = txtNoOfShares.Text
        objClsShares.TotalAmt = txtAmount.Text
        objClsShares.DivAmt = txtDivAmount.Text
        objClsShares.DivApplDate = Format(dtpDivDate.Value, "yyyy-MM-dd")

        Return True

    End Function

    Public Function fnSaveData() As Boolean

        If objClsShares.fnInsertDiv Then
            objClsShares.fnExecProcedure()
            ''fnGe12nerateVoucher()
            Return True
        Else
            Return False
        End If

    End Function

    Function fnGenerateVoucher() As Boolean


        '''Dim lngVoucherNo As Long
        '''Dim lngSlNo As Long

        '''lngVoucherNo = fnVoucherGetNewVNo(dtpDivDate.Value)
        '''lngSlNo = fnVoucherGetNewSlNo()

        '''Dim strNarration As String = "Withdrawal By " & txtAccNo.Text & " By Cheque No " & txtSBChequeNo.Text & " & Narration:  " & txtNarration.Text

        ''''Transaction Entery
        ''''objSBAccount.fnSbtransactionEnter(Trim(txtAccNo.Text), dtpDepositDate.Value, "By New SB Account  " & txtAccNo.Text, Trim(txtAvailBal.Text), 0, Trim(txtAvailBal.Text), txtReceiptNo.Text, lngVoucherNo, "Cash", 0)
        '''Dim strsql As String = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,postbal,refno,voucherno,type,chequeno) "
        '''strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpDivDate.Value, "yyyy-MM-dd") & "','" & strNarration & "','0','" & Trim(txtAmount.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtAmount.Text) & "','" & Trim(txtRefNo.Text) & "','" & lngVoucherNo & "','Cheque','0' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
        '''fnExecuteNonQuery(strsql)

        ''''voucher details
        '''fnVoucherEnterMain(lngVoucherNo, 1, txtAccNo.Text, 0, dtpDivDate.Value, txtAmount.Text, "Withdraw By " & txtAccNo.Text, lngSlNo, "Y")
        ''''Credit accounts
        '''fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDivDate.Value, "Withdraw By SB Account " & txtAccNo.Text, "To", 1, 0, Val(txtAmount.Text), 1, "Y")
        ''''Debit accounts 
        '''fnVoucherEnterSub(lngVoucherNo, 1, txtAccNo.Text, dtpDivDate.Value, "Withdraw By SB Account " & txtAccNo.Text, "By", 22, Val(txtAmount.Text), 0, 2, "Y")
        '''Return True


    End Function

#End Region

#Region "Events"

    Private Sub frmShareDividend_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtNoOfShares.ReadOnly = True
        txtDivAmount.ReadOnly = True

        fnGetShareDetails()
        fnGetNoOfShares()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged

        txtDivAmount.Text = Math.Round(Val(txtAmount.Text) / Val(txtNoOfShares.Text), 2)

    End Sub

    Private Sub btnPostDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPostDiv.Click

        If fnCheck() Then
            If fnSetData() Then
                If fnSaveData() Then
                    MsgBox("Dividend posted successfully", MsgBoxStyle.Information, "Dividend Postion")
                Else
                    MsgBox("Dividend cannot be posted due to internal error", MsgBoxStyle.Exclamation, "Dividend Posting")
                End If
            End If
        End If

    End Sub

#End Region

End Class
