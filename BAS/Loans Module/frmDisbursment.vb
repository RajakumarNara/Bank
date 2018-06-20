Public Class frmDisbursment
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        If m_FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_FormDefInstance = Me
            End If
        End If
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
    Friend WithEvents lvDisbursment As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents rtpBankDetails As System.Windows.Forms.RichTextBox
    Friend WithEvents Cancel As BankControls.NewButton
    Friend WithEvents txtLoanNo As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpDisbDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSanctionedAmt As BankControls.NumericControl
    Friend WithEvents txtReferenceNo As BankControls.NumericControl
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rtpRemarks As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDocFee As BankControls.NumericControl
    Friend WithEvents txtProcCharges As BankControls.NumericControl
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtLAmount As BankControls.NumericControl
    Friend WithEvents txtOtherCharges As BankControls.NumericControl
    Friend WithEvents txtIntrestAmt As BankControls.NumericControl
    Friend WithEvents txtSecurityAmt As BankControls.NumericControl
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSBAccNo As BankControls.TextControl
    Friend WithEvents txtBuildingFund As BankControls.NumericControl
    Friend WithEvents lblBuildingFee As System.Windows.Forms.Label
    Friend WithEvents lblOtherCharges As System.Windows.Forms.Label
    Friend WithEvents lblLoanProcessingCharge As System.Windows.Forms.Label
    Friend WithEvents lblDDOCFee As System.Windows.Forms.Label
    Friend WithEvents lblSecuretyAmount As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lvDisbursment = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.btnClose = New BankControls.NewButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtBuildingFund = New BankControls.NumericControl
        Me.lblBuildingFee = New System.Windows.Forms.Label
        Me.txtSBAccNo = New BankControls.TextControl
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtSecurityAmt = New BankControls.NumericControl
        Me.txtIntrestAmt = New BankControls.NumericControl
        Me.txtLAmount = New BankControls.NumericControl
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblOtherCharges = New System.Windows.Forms.Label
        Me.txtOtherCharges = New BankControls.NumericControl
        Me.lblLoanProcessingCharge = New System.Windows.Forms.Label
        Me.txtProcCharges = New BankControls.NumericControl
        Me.lblDDOCFee = New System.Windows.Forms.Label
        Me.txtDocFee = New BankControls.NumericControl
        Me.lblSecuretyAmount = New System.Windows.Forms.Label
        Me.rtpRemarks = New System.Windows.Forms.RichTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtReferenceNo = New BankControls.NumericControl
        Me.txtAmount = New BankControls.NumericControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSanctionedAmt = New BankControls.NumericControl
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnOk = New BankControls.NewButton
        Me.rtpBankDetails = New System.Windows.Forms.RichTextBox
        Me.Cancel = New BankControls.NewButton
        Me.dtpDisbDate = New System.Windows.Forms.DateTimePicker
        Me.txtLoanNo = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvDisbursment
        '
        Me.lvDisbursment.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader7, Me.ColumnHeader3, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader8})
        Me.lvDisbursment.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.lvDisbursment.ForeColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(64, Byte), CType(0, Byte))
        Me.lvDisbursment.FullRowSelect = True
        Me.lvDisbursment.GridLines = True
        Me.lvDisbursment.Location = New System.Drawing.Point(8, 312)
        Me.lvDisbursment.Name = "lvDisbursment"
        Me.lvDisbursment.Size = New System.Drawing.Size(600, 160)
        Me.lvDisbursment.TabIndex = 17
        Me.lvDisbursment.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "LoanNo"
        Me.ColumnHeader1.Width = 62
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "SlNo"
        Me.ColumnHeader7.Width = 43
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Reference"
        Me.ColumnHeader3.Width = 76
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Disbursed Date"
        Me.ColumnHeader2.Width = 107
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Amount"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 69
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Bank Details"
        Me.ColumnHeader5.Width = 130
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Remaning Amount"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 93
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(239, Byte), CType(227, Byte))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(210, Byte), CType(176, Byte))
        Me.btnClose.Location = New System.Drawing.Point(504, 480)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(239, Byte), CType(227, Byte))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(96, 40)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "&Close"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtBuildingFund)
        Me.Panel1.Controls.Add(Me.lblBuildingFee)
        Me.Panel1.Controls.Add(Me.txtSBAccNo)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtSecurityAmt)
        Me.Panel1.Controls.Add(Me.txtIntrestAmt)
        Me.Panel1.Controls.Add(Me.txtLAmount)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.lblOtherCharges)
        Me.Panel1.Controls.Add(Me.txtOtherCharges)
        Me.Panel1.Controls.Add(Me.lblLoanProcessingCharge)
        Me.Panel1.Controls.Add(Me.txtProcCharges)
        Me.Panel1.Controls.Add(Me.lblDDOCFee)
        Me.Panel1.Controls.Add(Me.txtDocFee)
        Me.Panel1.Controls.Add(Me.lblSecuretyAmount)
        Me.Panel1.Controls.Add(Me.rtpRemarks)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtReferenceNo)
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtSanctionedAmt)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnOk)
        Me.Panel1.Controls.Add(Me.rtpBankDetails)
        Me.Panel1.Controls.Add(Me.Cancel)
        Me.Panel1.Controls.Add(Me.dtpDisbDate)
        Me.Panel1.Controls.Add(Me.txtLoanNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 296)
        Me.Panel1.TabIndex = 0
        '
        'txtBuildingFund
        '
        Me.txtBuildingFund.AfterDecimal = 0
        Me.txtBuildingFund.BeforeDecimal = 10
        Me.txtBuildingFund.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtBuildingFund.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBuildingFund.Location = New System.Drawing.Point(160, 167)
        Me.txtBuildingFund.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBuildingFund.MaxLength = 10
        Me.txtBuildingFund.MaxValue = 9999999999999
        Me.txtBuildingFund.MinValue = 0
        Me.txtBuildingFund.Name = "txtBuildingFund"
        Me.txtBuildingFund.Size = New System.Drawing.Size(160, 23)
        Me.txtBuildingFund.TabIndex = 5
        Me.txtBuildingFund.Text = ""
        '
        'lblBuildingFee
        '
        Me.lblBuildingFee.AutoSize = True
        Me.lblBuildingFee.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.lblBuildingFee.Location = New System.Drawing.Point(8, 169)
        Me.lblBuildingFee.Name = "lblBuildingFee"
        Me.lblBuildingFee.Size = New System.Drawing.Size(96, 19)
        Me.lblBuildingFee.TabIndex = 86
        Me.lblBuildingFee.Text = "Building Fund"
        '
        'txtSBAccNo
        '
        Me.txtSBAccNo.AlphaNumeric = True
        Me.txtSBAccNo.BackColor = System.Drawing.Color.White
        Me.txtSBAccNo.BlankSpace = True
        Me.txtSBAccNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSBAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSBAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSBAccNo.Location = New System.Drawing.Point(424, 40)
        Me.txtSBAccNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtSBAccNo.Mandatory = False
        Me.txtSBAccNo.MaxLength = 10
        Me.txtSBAccNo.Name = "txtSBAccNo"
        Me.txtSBAccNo.ReadOnly = True
        Me.txtSBAccNo.Size = New System.Drawing.Size(168, 23)
        Me.txtSBAccNo.SpecialChar = True
        Me.txtSBAccNo.TabIndex = 9
        Me.txtSBAccNo.TabStop = False
        Me.txtSBAccNo.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label13.Location = New System.Drawing.Point(328, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 19)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "SB No"
        '
        'txtSecurityAmt
        '
        Me.txtSecurityAmt.AfterDecimal = 0
        Me.txtSecurityAmt.BeforeDecimal = 10
        Me.txtSecurityAmt.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtSecurityAmt.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSecurityAmt.Location = New System.Drawing.Point(160, 104)
        Me.txtSecurityAmt.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSecurityAmt.MaxLength = 10
        Me.txtSecurityAmt.MaxValue = 9999999999999
        Me.txtSecurityAmt.MinValue = 0
        Me.txtSecurityAmt.Name = "txtSecurityAmt"
        Me.txtSecurityAmt.Size = New System.Drawing.Size(160, 23)
        Me.txtSecurityAmt.TabIndex = 3
        Me.txtSecurityAmt.Text = ""
        '
        'txtIntrestAmt
        '
        Me.txtIntrestAmt.AfterDecimal = 0
        Me.txtIntrestAmt.BeforeDecimal = 10
        Me.txtIntrestAmt.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtIntrestAmt.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtIntrestAmt.Location = New System.Drawing.Point(160, 104)
        Me.txtIntrestAmt.LostFocusColour = System.Drawing.Color.Empty
        Me.txtIntrestAmt.MaxLength = 10
        Me.txtIntrestAmt.MaxValue = 9999999999999
        Me.txtIntrestAmt.MinValue = 0
        Me.txtIntrestAmt.Name = "txtIntrestAmt"
        Me.txtIntrestAmt.Size = New System.Drawing.Size(160, 23)
        Me.txtIntrestAmt.TabIndex = 4
        Me.txtIntrestAmt.Text = ""
        Me.txtIntrestAmt.Visible = False
        '
        'txtLAmount
        '
        Me.txtLAmount.AfterDecimal = 0
        Me.txtLAmount.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtLAmount.BeforeDecimal = 10
        Me.txtLAmount.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtLAmount.GotFocusColour = System.Drawing.Color.White
        Me.txtLAmount.Location = New System.Drawing.Point(160, 264)
        Me.txtLAmount.LostFocusColour = System.Drawing.Color.White
        Me.txtLAmount.MaxLength = 10
        Me.txtLAmount.MaxValue = 9999999999999
        Me.txtLAmount.MinValue = 0
        Me.txtLAmount.Name = "txtLAmount"
        Me.txtLAmount.ReadOnly = True
        Me.txtLAmount.Size = New System.Drawing.Size(160, 23)
        Me.txtLAmount.TabIndex = 8
        Me.txtLAmount.TabStop = False
        Me.txtLAmount.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label12.Location = New System.Drawing.Point(8, 266)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 19)
        Me.Label12.TabIndex = 82
        Me.Label12.Text = "Amount"
        '
        'lblOtherCharges
        '
        Me.lblOtherCharges.AutoSize = True
        Me.lblOtherCharges.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.lblOtherCharges.Location = New System.Drawing.Point(8, 234)
        Me.lblOtherCharges.Name = "lblOtherCharges"
        Me.lblOtherCharges.Size = New System.Drawing.Size(102, 19)
        Me.lblOtherCharges.TabIndex = 80
        Me.lblOtherCharges.Text = "Other Charges"
        '
        'txtOtherCharges
        '
        Me.txtOtherCharges.AfterDecimal = 0
        Me.txtOtherCharges.BeforeDecimal = 10
        Me.txtOtherCharges.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtOtherCharges.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOtherCharges.Location = New System.Drawing.Point(160, 232)
        Me.txtOtherCharges.LostFocusColour = System.Drawing.Color.Empty
        Me.txtOtherCharges.MaxLength = 10
        Me.txtOtherCharges.MaxValue = 9999999999999
        Me.txtOtherCharges.MinValue = 0
        Me.txtOtherCharges.Name = "txtOtherCharges"
        Me.txtOtherCharges.Size = New System.Drawing.Size(160, 23)
        Me.txtOtherCharges.TabIndex = 7
        Me.txtOtherCharges.Text = ""
        '
        'lblLoanProcessingCharge
        '
        Me.lblLoanProcessingCharge.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.lblLoanProcessingCharge.Location = New System.Drawing.Point(8, 195)
        Me.lblLoanProcessingCharge.Name = "lblLoanProcessingCharge"
        Me.lblLoanProcessingCharge.Size = New System.Drawing.Size(136, 32)
        Me.lblLoanProcessingCharge.TabIndex = 78
        Me.lblLoanProcessingCharge.Text = "Loan Processing Charges"
        '
        'txtProcCharges
        '
        Me.txtProcCharges.AfterDecimal = 0
        Me.txtProcCharges.BeforeDecimal = 10
        Me.txtProcCharges.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtProcCharges.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtProcCharges.Location = New System.Drawing.Point(160, 200)
        Me.txtProcCharges.LostFocusColour = System.Drawing.Color.Empty
        Me.txtProcCharges.MaxLength = 10
        Me.txtProcCharges.MaxValue = 9999999999999
        Me.txtProcCharges.MinValue = 0
        Me.txtProcCharges.Name = "txtProcCharges"
        Me.txtProcCharges.Size = New System.Drawing.Size(160, 23)
        Me.txtProcCharges.TabIndex = 6
        Me.txtProcCharges.Text = ""
        '
        'lblDDOCFee
        '
        Me.lblDDOCFee.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.lblDDOCFee.Location = New System.Drawing.Point(8, 131)
        Me.lblDDOCFee.Name = "lblDDOCFee"
        Me.lblDDOCFee.Size = New System.Drawing.Size(135, 32)
        Me.lblDDOCFee.TabIndex = 76
        Me.lblDDOCFee.Text = "Documentation Fee"
        '
        'txtDocFee
        '
        Me.txtDocFee.AfterDecimal = 0
        Me.txtDocFee.BeforeDecimal = 10
        Me.txtDocFee.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtDocFee.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtDocFee.Location = New System.Drawing.Point(160, 136)
        Me.txtDocFee.LostFocusColour = System.Drawing.Color.Empty
        Me.txtDocFee.MaxLength = 10
        Me.txtDocFee.MaxValue = 9999999999999
        Me.txtDocFee.MinValue = 0
        Me.txtDocFee.Name = "txtDocFee"
        Me.txtDocFee.Size = New System.Drawing.Size(160, 23)
        Me.txtDocFee.TabIndex = 4
        Me.txtDocFee.Text = ""
        '
        'lblSecuretyAmount
        '
        Me.lblSecuretyAmount.AutoSize = True
        Me.lblSecuretyAmount.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.lblSecuretyAmount.Location = New System.Drawing.Point(8, 106)
        Me.lblSecuretyAmount.Name = "lblSecuretyAmount"
        Me.lblSecuretyAmount.Size = New System.Drawing.Size(117, 19)
        Me.lblSecuretyAmount.TabIndex = 74
        Me.lblSecuretyAmount.Text = "Security Amount"
        '
        'rtpRemarks
        '
        Me.rtpRemarks.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.rtpRemarks.Location = New System.Drawing.Point(424, 144)
        Me.rtpRemarks.MaxLength = 100
        Me.rtpRemarks.Name = "rtpRemarks"
        Me.rtpRemarks.Size = New System.Drawing.Size(168, 66)
        Me.rtpRemarks.TabIndex = 11
        Me.rtpRemarks.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(328, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 19)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Remarks"
        '
        'txtReferenceNo
        '
        Me.txtReferenceNo.AfterDecimal = 0
        Me.txtReferenceNo.BeforeDecimal = 10
        Me.txtReferenceNo.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtReferenceNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReferenceNo.Location = New System.Drawing.Point(424, 216)
        Me.txtReferenceNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReferenceNo.MaxLength = 10
        Me.txtReferenceNo.MaxValue = 9999999999999
        Me.txtReferenceNo.MinValue = 0
        Me.txtReferenceNo.Name = "txtReferenceNo"
        Me.txtReferenceNo.Size = New System.Drawing.Size(168, 23)
        Me.txtReferenceNo.TabIndex = 12
        Me.txtReferenceNo.Text = ""
        '
        'txtAmount
        '
        Me.txtAmount.AfterDecimal = 0
        Me.txtAmount.BeforeDecimal = 10
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmount.Location = New System.Drawing.Point(160, 72)
        Me.txtAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.MaxValue = 9999999999999
        Me.txtAmount.MinValue = 0
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(160, 23)
        Me.txtAmount.TabIndex = 2
        Me.txtAmount.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(328, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 19)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Reference No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(8, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 19)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Disbursed Amount"
        '
        'txtSanctionedAmt
        '
        Me.txtSanctionedAmt.AfterDecimal = 0
        Me.txtSanctionedAmt.BackColor = System.Drawing.Color.White
        Me.txtSanctionedAmt.BeforeDecimal = 10
        Me.txtSanctionedAmt.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtSanctionedAmt.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtSanctionedAmt.Location = New System.Drawing.Point(160, 40)
        Me.txtSanctionedAmt.LostFocusColour = System.Drawing.Color.Empty
        Me.txtSanctionedAmt.MaxLength = 10
        Me.txtSanctionedAmt.MaxValue = 9999999999999
        Me.txtSanctionedAmt.MinValue = 0
        Me.txtSanctionedAmt.Name = "txtSanctionedAmt"
        Me.txtSanctionedAmt.Size = New System.Drawing.Size(160, 23)
        Me.txtSanctionedAmt.TabIndex = 2
        Me.txtSanctionedAmt.TabStop = False
        Me.txtSanctionedAmt.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(8, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 19)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Sanctioned Amount"
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(239, Byte), CType(227, Byte))
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(210, Byte), CType(176, Byte))
        Me.btnOk.Location = New System.Drawing.Point(424, 248)
        Me.btnOk.LostFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(239, Byte), CType(227, Byte))
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(80, 40)
        Me.btnOk.TabIndex = 13
        Me.btnOk.Text = "&Save"
        '
        'rtpBankDetails
        '
        Me.rtpBankDetails.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.rtpBankDetails.Location = New System.Drawing.Point(424, 72)
        Me.rtpBankDetails.MaxLength = 100
        Me.rtpBankDetails.Name = "rtpBankDetails"
        Me.rtpBankDetails.Size = New System.Drawing.Size(168, 64)
        Me.rtpBankDetails.TabIndex = 10
        Me.rtpBankDetails.Text = ""
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(239, Byte), CType(227, Byte))
        Me.Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.Color.Black
        Me.Cancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(240, Byte), CType(210, Byte), CType(176, Byte))
        Me.Cancel.Location = New System.Drawing.Point(512, 248)
        Me.Cancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(239, Byte), CType(227, Byte))
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(80, 40)
        Me.Cancel.TabIndex = 14
        Me.Cancel.Text = "&Reset"
        '
        'dtpDisbDate
        '
        Me.dtpDisbDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDisbDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDisbDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDisbDate.Location = New System.Drawing.Point(424, 8)
        Me.dtpDisbDate.Name = "dtpDisbDate"
        Me.dtpDisbDate.Size = New System.Drawing.Size(168, 22)
        Me.dtpDisbDate.TabIndex = 9
        Me.dtpDisbDate.Value = New Date(2010, 9, 30, 0, 0, 0, 0)
        '
        'txtLoanNo
        '
        Me.txtLoanNo.AlphaNumeric = True
        Me.txtLoanNo.BackColor = System.Drawing.Color.White
        Me.txtLoanNo.BlankSpace = True
        Me.txtLoanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoanNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtLoanNo.Location = New System.Drawing.Point(160, 8)
        Me.txtLoanNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtLoanNo.Mandatory = False
        Me.txtLoanNo.MaxLength = 10
        Me.txtLoanNo.Name = "txtLoanNo"
        Me.txtLoanNo.Size = New System.Drawing.Size(160, 23)
        Me.txtLoanNo.SpecialChar = True
        Me.txtLoanNo.TabIndex = 1
        Me.txtLoanNo.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "LoanNo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(328, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 19)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(328, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 19)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "BankDetails"
        '
        'frmDisbursment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(239, Byte), CType(227, Byte))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(616, 527)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lvDisbursment)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDisbursment"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Disbursment"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Shared m_FormDefInstance As frmDisbursment
    Private Shared m_InitializingDefInstance As Boolean

#Region "Variables"

    Dim objclsDisb As New clsDisbursment
    Dim dvDisb As DataView
    Dim lngVoucher As Long
    Dim dtpToDate As Date
    Dim dblCharges As Double


#End Region

    Dim objclsRepayment As New clsRePayment

#Region "Function"

    Public Function fnCheck() As Boolean

        Dim strLoan = Mid(txtLoanNo.Text, 1, 2)

        If txtLoanNo.Text = String.Empty Then
            MsgBox("Enter the loan number", MsgBoxStyle.Exclamation)
            txtLoanNo.Focus()
            Return False
        End If

        If txtAmount.Text = String.Empty Then
            MsgBox("Enter the amount to be disbursed", MsgBoxStyle.Exclamation)
            txtAmount.Focus()
            Return False
        End If

        If Mid(txtAmount.Text, 1, 1) = 0 Then
            MsgBox("Amount cannot star with 0", MsgBoxStyle.Exclamation)
            txtAmount.Focus()
            Return False
        End If

        If txtAmount.Text = 0 Then
            MsgBox("Amount cannot be zero", MsgBoxStyle.Exclamation)
            txtAmount.Focus()
            Return False
        End If

        If txtAmount.Text < 0 Then
            MsgBox("Amount cannot be lesser than zero", MsgBoxStyle.Exclamation)
            txtAmount.Focus()
            Return False
        End If

        If rtpRemarks.Text = String.Empty Then
            MsgBox("Please enter remarks", MsgBoxStyle.Information)
            rtpRemarks.Focus()
            Return False
        End If

        If txtReferenceNo.Text = String.Empty Then
            MsgBox("Enter the reference no for the amount  to be disbursed", MsgBoxStyle.Exclamation)
            txtReferenceNo.Focus()
            Return False
        End If


        '   '   '   '   Function to check the disbursed amount is greater than sanctioned amount

        '   '   '   '   condition to check weather there is any disnursed amount


        'Has to comment because Loan may be disbursed in any number of disbursement
        'If fnCheckNoOfDisb() Then

        If objclsDisb.fnCheckDis(txtLoanNo.Text) Then

            If objclsDisb.datDisbAmt.Rows(0).Item("DisbAmount") <> objclsDisb.datDisbAmt.Rows(0).Item("SancAmount") Then

                If objclsDisb.datDisbAmt.Rows(0).Item("DisbAmount") = 0 Then

                    If txtAmount.Text > objclsDisb.datDisbAmt.Rows(0).Item("SancAmount") Then
                        MsgBox("The to be paid is more than sanctioned amount", MsgBoxStyle.Exclamation)
                        Return False
                    End If

                    '   '   '   '   function to check weather the disbursed amount and the amount paid is more than sanctioned amount

                ElseIf objclsDisb.datDisbAmt.Rows(0).Item("DisbAmount") + txtAmount.Text > objclsDisb.datDisbAmt.Rows(0).Item("SancAmount") Then
                    MsgBox("The amount to be paid is more than sanctioned amount", MsgBoxStyle.Information)
                    Return False
                Else
                    Return True
                End If
                Return True
            ElseIf objclsDisb.datDisbAmt.Rows(0).Item("DisbAmount") = objclsDisb.datDisbAmt.Rows(0).Item("SancAmount") Then
                MsgBox("Loan is fully disbursed", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If

    End Function

    Public Function fnCheckReceiptNo() As Boolean


    End Function

    Public Function fnSetData() As Boolean

        objclsDisb.BankDetails = rtpBankDetails.Text
        objclsDisb.DisAmount = txtAmount.Text
        objclsDisb.DisDate = dtpDisbDate.Value
        objclsDisb.loanNo = txtLoanNo.Text
        objclsDisb.RefNo = txtReferenceNo.Text
        objclsDisb.Remarks = rtpRemarks.Text
        objclsDisb.SecurityDeposit = Val(txtSecurityAmt.Text)
        objclsDisb.OtherCharge = Val(txtOtherCharges.Text)
        objclsDisb.ProcessingCharge = Val(txtProcCharges.Text)
        objclsDisb.DocFee = Val(txtDocFee.Text)
        objclsDisb.intrestAmount = Val(txtIntrestAmt.Text)
        objclsDisb.TODate = ToDate
        objclsDisb.intrestAmount = Val(txtIntrestAmt.Text)
        objclsDisb.BuildingFund = Val(txtBuildingFund.Text)


        '    '   '**********  function to get  the maximum of slno 

        If objclsDisb.fnGetMaxSlno(txtLoanNo.Text) Then
            objclsDisb.DisSlNo = objclsDisb.datMaxSlnoAmt.Rows(0).Item("slno") + 1
        End If

        If objclsRepayment.fnGetData(txtLoanNo.Text) Then
            If objclsRepayment.fnMaxNo(txtLoanNo.Text) Then
                objclsDisb.RepaySlNo = objclsRepayment.MaxInstNoTable.Rows(0).Item("InstNo") + 1
                objclsDisb.BalanceAmt = objclsRepayment.PaymentTable.Rows(0).Item("Balance") + txtAmount.Text

            End If
        End If

        Return True

        objclsDisb.VoucherNO = 0

        Return True

    End Function

    Public Shared Property DefInstance() As frmDisbursment
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmDisbursment
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmDisbursment)
            m_FormDefInstance = Value
        End Set
    End Property

    Public Function fnLoadData() As Boolean

        '   '   ' ********** function to add data into the listview

        If objclsDisb.fnGetDisb(txtLoanNo.Text) = True Then

            If objclsDisb.datDisbTable.Rows.Count > 1 Then

                fnAddData()

            Else

            End If

        End If

    End Function

    Public Function fnSaveData(ByVal objTrans As IDbTransaction) As Boolean

        'If objclsDisb.fnInsertDisb(objTrans) Then '   '   '   function for insering data in db

        If fnRemAmt() Then

            If fnGenerateVoucher(objTrans) Then

                If objclsDisb.DisSlNo = 1 Then
                    objclsDisb.fnUpdataeSecurityDeposit(objTrans)
                End If
                If txtAmount.Text <> 0 Then
                    fnLogEntry(pbUserId, "Loan disbursmsnt to" & txtLoanNo.Text & " Amount " & txtAmount.Text, Date.Now, "Transaction Disbursmsnt", objTrans)
                End If

                objclsDisb.fnUpdateVouncherNo(lngVoucher, txtLoanNo.Text, objTrans)

                objTrans.Commit()

                fnAddData()

                fnClearData()

                MsgBox("Amount disbursed successfully", MsgBoxStyle.Information, "Disbursment Module")

            Else

                MsgBox("Internal error.amount cannot be added", MsgBoxStyle.Information, "Disbursment")

            End If

        End If

    End Function


    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        ' Loan Disbursment with Two Entry 
        '(Master Loan Account Is Suspence Ledger Maintained To Transfer Loan Amount Ledger Number=60)
        ' Personl Loan Account Dr to Master Loan Account Cr
        ' Master Loan Account Dr to Savings Bank Account Cr

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        Dim strLoan As String
        Dim intLedgerNo As Integer = 0
        Dim intSecLedgerNo As Integer = 0

        Dim strNarration As String
        strNarration = "Deposit by " & txtLoanNo.Text & " Narration:" & rtpRemarks.Text

        lngVoucherNo = fnVoucherGetNewVNo(dtpDisbDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        objclsDisb.fnAddData(lngVoucherNo, objTrans)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 1, txtLoanNo.Text, txtReferenceNo.Text, dtpDisbDate.Value, txtAmount.Text, "Disbursment of loan " & txtLoanNo.Text, lngSlNo, "Y", objTrans)

        strLoan = Mid(txtLoanNo.Text, 1, 2)
        Select Case strLoan
            Case "JL"
                intLedgerNo = "15"
                intSecLedgerNo = "36"
            Case "LM"
                intLedgerNo = "16"
                intSecLedgerNo = "37"
            Case "HL"
                intLedgerNo = "17"
                intSecLedgerNo = "38"
            Case "SL"
                intLedgerNo = "18"
                intSecLedgerNo = "39"
            Case "CH"
                intLedgerNo = "19"
                intSecLedgerNo = "41"
            Case "LT"
                intLedgerNo = "20"
                intSecLedgerNo = "42"
            Case "SD"
                intLedgerNo = "43"
                intSecLedgerNo = "44"
        End Select

        lngVoucher = lngVoucherNo

        If strLoan = "JL" Then


            If Val(txtSecurityAmt.Text) <> 0 Then
                fnVoucherEnterSub(lngVoucherNo, 1, txtLoanNo.Text, dtpDisbDate.Value, " Jewel Insurance on loan " & txtLoanNo.Text, "By", 107, 0, Val(txtSecurityAmt.Text), 4, "Y", objTrans)
            End If

            If Val(txtDocFee.Text) <> 0 Or txtDocFee.Text <> "" Then
                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpDisbDate.Value, "Jewel Processing Charge on loan  " & txtLoanNo.Text, "By", 106, 0, Val(txtDocFee.Text), 5, "Y", objTrans)
            End If

            If Val(txtBuildingFund.Text) <> 0 Or txtBuildingFund.Text <> "" Then
                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpDisbDate.Value, "Appraisal Commission on loan " & txtLoanNo.Text, "By", 121, 0, Val(txtBuildingFund.Text), 6, "Y", objTrans)
            End If

            If Val(txtProcCharges.Text) <> 0 Or txtProcCharges.Text <> "" Then
                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpDisbDate.Value, "SCC on loan " & txtLoanNo.Text, "By", 105, 0, Val(txtProcCharges.Text), 7, "Y", objTrans)
            End If

            If Val(txtOtherCharges.Text) <> 0 Or txtOtherCharges.Text <> "" Then
                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpDisbDate.Value, "Documentation Fee on loan " & txtLoanNo.Text, "By", 33, 0, Val(txtOtherCharges.Text), 8, "Y", objTrans)
            End If

        Else

            'Credit accounts 

            If Val(txtDocFee.Text) <> 0 Or txtDocFee.Text <> "" Then
                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpDisbDate.Value, "Documentation fee of loan " & txtLoanNo.Text, "By", 33, 0, Val(txtDocFee.Text), 4, "Y", objTrans)
            End If

            If Val(txtProcCharges.Text) <> 0 Or txtProcCharges.Text <> "" Then
                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpDisbDate.Value, "Processing charge of loan " & txtLoanNo.Text, "By", 34, 0, Val(txtProcCharges.Text), 5, "Y", objTrans)
            End If

            If Val(txtOtherCharges.Text) <> 0 Or txtOtherCharges.Text <> "" Then
                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpDisbDate.Value, "Misc charge of loan " & txtLoanNo.Text, "By", 13, 0, Val(txtOtherCharges.Text), 6, "Y", objTrans)
            End If

            If Val(txtBuildingFund.Text) <> 0 Or txtBuildingFund.Text <> "" Then
                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpDisbDate.Value, "Building fund on loan " & txtLoanNo.Text, "By", 6, 0, Val(txtBuildingFund.Text), 7, "Y", objTrans)
            End If

            If Val(txtSecurityAmt.Text) <> 0 Then
                fnVoucherEnterSub(lngVoucherNo, 1, txtLoanNo.Text, dtpDisbDate.Value, "Security deposit on loan  " & txtLoanNo.Text, "By", intSecLedgerNo, 0, Val(txtSecurityAmt.Text), 8, "Y", objTrans)
            ElseIf Val(txtIntrestAmt.Text) <> 0 Then
                'Commission for SDRL
                fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpDisbDate.Value, "Intrest on dailyrecovery loan " & txtLoanNo.Text, "To", 44, 0, Val(txtIntrestAmt.Text), 8, "Y", objTrans)
            End If
        End If


        If txtSBAccNo.Text = String.Empty Then

            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 1, txtLoanNo.Text, dtpDisbDate.Value, "Disbursment of loan no " & txtLoanNo.Text, "By", intLedgerNo, Val(txtAmount.Text), 0, 1, "Y", objTrans)

            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDisbDate.Value, "Disbursment of loan no " & txtLoanNo.Text, "To", 1, 0, Val(txtLAmount.Text), 2, "Y", objTrans)

            'If Val(txtSecurityAmt.Text) <> 0 Then
            '    fnVoucherEnterSub(lngVoucherNo, 1, txtLoanNo.Text, dtpDisbDate.Value, "Security deposit of loan no " & txtLoanNo.Text, "By", intSecLedgerNo, 0, Val(txtSecurityAmt.Text), 5, "Y", objTrans)
            'ElseIf Val(txtIntrestAmt.Text) <> 0 Then
            '    'Commission for SDRL
            '    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpDisbDate.Value, "Intrest on dailyrecovery loan " & txtLoanNo.Text, "To", 44, 0, Val(txtIntrestAmt.Text), 5, "Y", objTrans)
            'End If

            Return True

        ElseIf txtSBAccNo.Text <> String.Empty Then

            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 1, txtLoanNo.Text, dtpDisbDate.Value, "Disbursment of loan no " & txtLoanNo.Text, "By", intLedgerNo, Val(txtAmount.Text), 0, 1, "Y", objTrans)

            ''Credit accounts
            'fnVoucherEnterSub(lngVoucherNo, 1, txtLoanNo.Text, dtpDisbDate.Value, "Disbursment of loan no " & txtLoanNo.Text, "To", 60, 0, Val(txtAmount.Text), 1, "Y", objTrans)

            Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
            strsql = strsql & " select '" & Trim(txtSBAccNo.Text) & "','" & Format(dtpDisbDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtLAmount.Text) & "','0','" & Trim(txtLAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtLAmount.Text) & "','" & Trim(txtReferenceNo.Text) & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtSBAccNo.Text) & "' group by Accountno"
            fnExecuteNonQuery(strsql, objTrans)

            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 1, txtLoanNo.Text, dtpDisbDate.Value, "Disbursment of loan no " & txtLoanNo.Text, "To", 10, 0, Val(txtLAmount.Text), 2, "Y", objTrans)

            ''Debit accounts 
            'fnVoucherEnterSub(lngVoucherNo, 1, txtLoanNo.Text, dtpDisbDate.Value, "Disbursment of loan no " & txtLoanNo.Text, "By", 60, Val(txtAmount.Text), 0, 4, "Y", objTrans)

            'If Val(txtSecurityAmt.Text) <> 0 Then
            '    fnVoucherEnterSub(lngVoucherNo, 1, txtLoanNo.Text, dtpDisbDate.Value, "Security deposit of loan no " & txtLoanNo.Text, "By", intSecLedgerNo, 0, Val(txtSecurityAmt.Text), 3, "Y", objTrans)
            'ElseIf Val(txtIntrestAmt.Text) <> 0 Then
            '    'Commission for SDRL
            '    fnVoucherEnterSub(lngVoucherNo, 2, txtLoanNo.Text, dtpDisbDate.Value, "Intrest on dailyrecovery loan " & txtLoanNo.Text, "To", 44, 0, Val(txtIntrestAmt.Text), 5, "Y", objTrans)
            'End If

            Return True

        End If


    End Function

    Public Function fnCheckNoOfDisb() As Boolean

        If objclsDisb.fnCheckNoOfDisb(txtLoanNo.Text) Then

            If objclsDisb.datNoOfDisb.Rows(0).Item("slno") = 1 Then

                objclsDisb.fnCheckDis(txtLoanNo.Text)

                If objclsDisb.datDisbAmt.Rows(0).Item("SancAmount") <> objclsDisb.datDisbAmt.Rows(0).Item("DisbAmount") + txtAmount.Text Then

                    MsgBox("Please Disbursemt the amount Fully, This is last Disbursment", MsgBoxStyle.Exclamation, "Disbursment Module")

                    Return False

                Else
                    Return True

                End If
            Else

                Return True

            End If

        End If



    End Function

    Public Function fnRemAmt() As Boolean

        '   '   ' function to get the remaning amount

        If objclsDisb.fnCheckAmt Then

            If objclsDisb.fnGetDisbAmount(txtLoanNo.Text) Then

                objclsDisb.RemAmount = objclsDisb.datDisbTable.Rows(0).Item("sancamount") - (objclsDisb.DisbAmtTable.Rows(0).Item("total") + Val(txtAmount.Text))

                Return True

            Else

                Return False

            End If

        End If

    End Function

    Public Function fnAddData() As Boolean

        Dim lstvItems As ListViewItem
        Dim intCount As Integer = 0

        lvDisbursment.Items.Clear()


        If objclsDisb.fnCheckDis(txtLoanNo.Text) Then
            txtSanctionedAmt.Text = objclsDisb.datDisbAmt.Rows(0).Item("Sancamount")
            dtpToDate = objclsDisb.datDisbAmt.Rows(0).Item("DueDate")
            txtSBAccNo.Text = objclsDisb.datDisbAmt.Rows(0).Item("SBNo")
        End If

        If objclsDisb.fnGetDisb(txtLoanNo.Text) Then
            While intCount < objclsDisb.datDisbTable.Rows.Count
                lstvItems = lvDisbursment.Items.Add(objclsDisb.datDisbTable.Rows(intCount).Item("LoanNo"))
                lstvItems.SubItems.Add(objclsDisb.datDisbTable.Rows(intCount).Item("slno"))
                lstvItems.SubItems.Add(objclsDisb.datDisbTable.Rows(intCount).Item("RefNo"))
                lstvItems.SubItems.Add(Format(objclsDisb.datDisbTable.Rows(intCount).Item("DisbDate"), "dd-MM-yyyy"))
                lstvItems.SubItems.Add(objclsDisb.datDisbTable.Rows(intCount).Item("Amount"))
                lstvItems.SubItems.Add(objclsDisb.datDisbTable.Rows(intCount).Item("BankDetails"))
                lstvItems.SubItems.Add(objclsDisb.datDisbTable.Rows(intCount).Item("RemAmount"))
                intCount += 1
            End While

            If objclsDisb.datDisbTable.Rows.Count > 0 Then
                txtSecurityAmt.ReadOnly = True
                txtProcCharges.ReadOnly = True
                txtDocFee.ReadOnly = True
                txtOtherCharges.ReadOnly = True
                txtBuildingFund.ReadOnly = True
            Else
                txtSecurityAmt.ReadOnly = False
                txtProcCharges.ReadOnly = False
                txtDocFee.ReadOnly = False
                txtOtherCharges.ReadOnly = False
                txtBuildingFund.ReadOnly = False
            End If
        End If

    End Function

    Public Function fnClearData() As Boolean

        txtAmount.Text = ""
        txtReferenceNo.Text = ""
        rtpBankDetails.Text = ""
        txtSecurityAmt.Text = ""
        txtDocFee.Text = ""
        txtLAmount.Text = ""
        txtOtherCharges.Text = ""
        txtProcCharges.Text = ""
        txtIntrestAmt.Text = ""
        txtBuildingFund.Text = ""
        Return True

    End Function

    Function fncalculateTotal() As Boolean
        dblCharges = Val(txtSecurityAmt.Text) + Val(txtIntrestAmt.Text) + Val(txtDocFee.Text) + Val(txtProcCharges.Text) + Val(txtOtherCharges.Text) + Val(txtBuildingFund.Text)
        txtLAmount.Text = Val(txtAmount.Text) - dblCharges
    End Function

#End Region

    Private Sub btnOk_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then

                If fnSetData() Then

                    If fnSaveData(objTrans) Then

                    End If

                End If

        End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try

    End Sub

    Private Sub frmDisbursment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpDisbDate.MaxDate = Date.Now
        dtpDisbDate.Value = Date.Now

        Dim strLoan As String = Mid(txtLoanNo.Text, 1, 2)
        Select Case strLoan
            Case "JL"
                lblSecuretyAmount.Text = "Jewel Insurance"
                lblDDOCFee.Text = "Jewel Processing Charge"
                lblBuildingFee.Text = "Appraisal Commission"
                lblLoanProcessingCharge.Text = "Society Service Charges"
                lblOtherCharges.Text = "Documentation Fee"
            Case "SD"
                lblSecuretyAmount.Text = "Interest Amount"
                txtIntrestAmt.Visible = True
                txtSecurityAmt.Visible = False
                txtProcCharges.Enabled = False
            Case Else
                lblSecuretyAmount.Text = "Securety Amount"
                lblDDOCFee.Text = "Documentation Fee"
                lblBuildingFee.Text = "Building Fee"
                lblLoanProcessingCharge.Text = "Loan Processing Charge"
                lblOtherCharges.Text = "Other Charges"
        End Select

        txtLoanNo.ReadOnly = True
        fnAddData()
        txtSanctionedAmt.ReadOnly = True
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        fnClearData()
    End Sub

#Region "Navigation"

    Private Sub dtpDisbDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDisbDate.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub lvDisbursment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvDisbursment.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub rtpBankDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rtpBankDetails.KeyDown

        '    If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub rtpRemarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rtpRemarks.KeyDown

        '   If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAmount.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtLoanNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLoanNo.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtReferenceNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtReferenceNo.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub

    Private Sub txtSanctionedAmt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSanctionedAmt.KeyDown

        If e.KeyCode = Keys.Enter Then SendKeys.Send("(TAB)")

    End Sub


#End Region

    Private Sub txtSecurityAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDocFee.TextChanged, txtProcCharges.TextChanged, txtOtherCharges.TextChanged, txtAmount.TextChanged, txtIntrestAmt.TextChanged, txtSecurityAmt.TextChanged, txtBuildingFund.TextChanged
        fncalculateTotal()
    End Sub
End Class
