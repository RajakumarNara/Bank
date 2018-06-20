Imports System.Math

Public Class frmCBPCreation
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NewButton3 As BankControls.NewButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As BankControls.NewButton
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpDepositdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As BankControls.TextControl
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtChequeAmount As BankControls.NumericControl
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtChequeNo As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpChequeDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As BankControls.NewButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtROI As BankControls.NumericControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOtherCharges As BankControls.NumericControl
    Friend WithEvents txtPostalCharge As BankControls.NumericControl
    Friend WithEvents txtInterest As BankControls.NumericControl
    Friend WithEvents txtCommission As BankControls.NumericControl
    Friend WithEvents txtCPercent As BankControls.NumericControl
    Friend WithEvents txtBankDetail As BankControls.TextControl
    Friend WithEvents cmbChequeType As System.Windows.Forms.ComboBox
    Friend WithEvents txtAmount As BankControls.NumericControl
    Friend WithEvents cmbChequeStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtCBPAccountNo As BankControls.TextControl
    Friend WithEvents btnSearchCBP As BankControls.NewButton
    Friend WithEvents btnSearchSBP As BankControls.NewButton
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents txtSBAccNo As BankControls.TextControl
    Friend WithEvents rdCAbtn As System.Windows.Forms.RadioButton
    Friend WithEvents rdODbtn As System.Windows.Forms.RadioButton
    Friend WithEvents txtNoOfDays As BankControls.NumericControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rdSBbtn As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCBPCreation))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NewButton3 = New BankControls.NewButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.rdODbtn = New System.Windows.Forms.RadioButton
        Me.rdCAbtn = New System.Windows.Forms.RadioButton
        Me.rdSBbtn = New System.Windows.Forms.RadioButton
        Me.txtSBAccNo = New BankControls.TextControl
        Me.btnSearchSBP = New BankControls.NewButton
        Me.lblAccount = New System.Windows.Forms.Label
        Me.txtReceiptNo = New BankControls.NumericControl
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtNoOfDays = New BankControls.NumericControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtOtherCharges = New BankControls.NumericControl
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtPostalCharge = New BankControls.NumericControl
        Me.txtInterest = New BankControls.NumericControl
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtCommission = New BankControls.NumericControl
        Me.btnCalculate = New BankControls.NewButton
        Me.txtCPercent = New BankControls.NumericControl
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtROI = New BankControls.NumericControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtBankDetail = New BankControls.TextControl
        Me.cmbChequeType = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtChequeAmount = New BankControls.NumericControl
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtChequeNo = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpChequeDate = New System.Windows.Forms.DateTimePicker
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtAmount = New BankControls.NumericControl
        Me.cmbChequeStatus = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtCBPAccountNo = New BankControls.TextControl
        Me.btnSearchCBP = New BankControls.NewButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtRemarks = New BankControls.TextControl
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpDepositdate = New System.Windows.Forms.DateTimePicker
        Me.Label32 = New System.Windows.Forms.Label
        Me.btnAdd = New BankControls.NewButton
        Me.btnOk = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NewButton3)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 616)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'NewButton3
        '
        Me.NewButton3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NewButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton3.ForeColor = System.Drawing.Color.Black
        Me.NewButton3.GotFocusColour = System.Drawing.Color.Gray
        Me.NewButton3.Image = CType(resources.GetObject("NewButton3.Image"), System.Drawing.Image)
        Me.NewButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton3.Location = New System.Drawing.Point(16, 304)
        Me.NewButton3.LostFocusColour = System.Drawing.Color.WhiteSmoke
        Me.NewButton3.Name = "NewButton3"
        Me.NewButton3.Size = New System.Drawing.Size(168, 40)
        Me.NewButton3.TabIndex = 27
        Me.NewButton3.Text = "Cheque Clearing"
        Me.NewButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewButton3.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.txtReceiptNo)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtAmount)
        Me.GroupBox2.Controls.Add(Me.cmbChequeStatus)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtRemarks)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.dtpDepositdate)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.btnOk)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(216, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(792, 616)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rdODbtn)
        Me.GroupBox6.Controls.Add(Me.rdCAbtn)
        Me.GroupBox6.Controls.Add(Me.rdSBbtn)
        Me.GroupBox6.Controls.Add(Me.txtSBAccNo)
        Me.GroupBox6.Controls.Add(Me.btnSearchSBP)
        Me.GroupBox6.Controls.Add(Me.lblAccount)
        Me.GroupBox6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(32, 128)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(344, 72)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Transfer to"
        '
        'rdODbtn
        '
        Me.rdODbtn.AutoSize = True
        Me.rdODbtn.Location = New System.Drawing.Point(179, 16)
        Me.rdODbtn.Name = "rdODbtn"
        Me.rdODbtn.Size = New System.Drawing.Size(45, 20)
        Me.rdODbtn.TabIndex = 64
        Me.rdODbtn.TabStop = True
        Me.rdODbtn.Text = "OD"
        Me.rdODbtn.UseVisualStyleBackColor = True
        '
        'rdCAbtn
        '
        Me.rdCAbtn.Location = New System.Drawing.Point(104, 16)
        Me.rdCAbtn.Name = "rdCAbtn"
        Me.rdCAbtn.Size = New System.Drawing.Size(48, 24)
        Me.rdCAbtn.TabIndex = 5
        Me.rdCAbtn.Text = "CA"
        '
        'rdSBbtn
        '
        Me.rdSBbtn.Location = New System.Drawing.Point(32, 16)
        Me.rdSBbtn.Name = "rdSBbtn"
        Me.rdSBbtn.Size = New System.Drawing.Size(48, 24)
        Me.rdSBbtn.TabIndex = 4
        Me.rdSBbtn.Text = "SB"
        '
        'txtSBAccNo
        '
        Me.txtSBAccNo.AlphaNumeric = True
        Me.txtSBAccNo.BackColor = System.Drawing.Color.White
        Me.txtSBAccNo.BlankSpace = False
        Me.txtSBAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSBAccNo.GotFocusColour = System.Drawing.Color.White
        Me.txtSBAccNo.Location = New System.Drawing.Point(120, 40)
        Me.txtSBAccNo.LostFocusColour = System.Drawing.Color.White
        Me.txtSBAccNo.Mandatory = False
        Me.txtSBAccNo.MaxLength = 10
        Me.txtSBAccNo.Name = "txtSBAccNo"
        Me.txtSBAccNo.ReadOnly = True
        Me.txtSBAccNo.Size = New System.Drawing.Size(128, 23)
        Me.txtSBAccNo.SpecialChar = False
        Me.txtSBAccNo.TabIndex = 6
        Me.txtSBAccNo.TabStop = False
        '
        'btnSearchSBP
        '
        Me.btnSearchSBP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchSBP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchSBP.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchSBP.ForeColor = System.Drawing.Color.Black
        Me.btnSearchSBP.GotFocusColour = System.Drawing.Color.Gray
        Me.btnSearchSBP.Image = CType(resources.GetObject("btnSearchSBP.Image"), System.Drawing.Image)
        Me.btnSearchSBP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchSBP.Location = New System.Drawing.Point(264, 40)
        Me.btnSearchSBP.LostFocusColour = System.Drawing.Color.WhiteSmoke
        Me.btnSearchSBP.Name = "btnSearchSBP"
        Me.btnSearchSBP.Size = New System.Drawing.Size(24, 24)
        Me.btnSearchSBP.TabIndex = 7
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccount.Location = New System.Drawing.Point(24, 40)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(81, 15)
        Me.lblAccount.TabIndex = 63
        Me.lblAccount.Text = "Account No: "
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 0
        Me.txtReceiptNo.BeforeDecimal = 7
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(400, 456)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtReceiptNo.MaxLength = 7
        Me.txtReceiptNo.MaxValue = 0
        Me.txtReceiptNo.MinValue = 0
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(120, 23)
        Me.txtReceiptNo.TabIndex = 23
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtNoOfDays)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtOtherCharges)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtPostalCharge)
        Me.GroupBox4.Controls.Add(Me.txtInterest)
        Me.GroupBox4.Controls.Add(Me.Label40)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Controls.Add(Me.txtCommission)
        Me.GroupBox4.Controls.Add(Me.btnCalculate)
        Me.GroupBox4.Controls.Add(Me.txtCPercent)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtROI)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(416, 197)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(344, 243)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Calculation Detail"
        '
        'txtNoOfDays
        '
        Me.txtNoOfDays.AfterDecimal = 2
        Me.txtNoOfDays.BackColor = System.Drawing.Color.White
        Me.txtNoOfDays.BeforeDecimal = 2
        Me.txtNoOfDays.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfDays.GotFocusColour = System.Drawing.Color.Beige
        Me.txtNoOfDays.Location = New System.Drawing.Point(192, 16)
        Me.txtNoOfDays.LostFocusColour = System.Drawing.Color.White
        Me.txtNoOfDays.MaxLength = 5
        Me.txtNoOfDays.MaxValue = 0
        Me.txtNoOfDays.MinValue = 0
        Me.txtNoOfDays.Name = "txtNoOfDays"
        Me.txtNoOfDays.Size = New System.Drawing.Size(56, 23)
        Me.txtNoOfDays.TabIndex = 172
        Me.txtNoOfDays.TabStop = False
        Me.txtNoOfDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 16)
        Me.Label3.TabIndex = 171
        Me.Label3.Text = "No. of Days to Clear:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(24, 209)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 16)
        Me.Label14.TabIndex = 170
        Me.Label14.Text = "Other Charge:"
        '
        'txtOtherCharges
        '
        Me.txtOtherCharges.AfterDecimal = 0
        Me.txtOtherCharges.BeforeDecimal = 7
        Me.txtOtherCharges.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherCharges.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtOtherCharges.Location = New System.Drawing.Point(192, 209)
        Me.txtOtherCharges.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtOtherCharges.MaxLength = 7
        Me.txtOtherCharges.MaxValue = 0
        Me.txtOtherCharges.MinValue = 0
        Me.txtOtherCharges.Name = "txtOtherCharges"
        Me.txtOtherCharges.Size = New System.Drawing.Size(120, 23)
        Me.txtOtherCharges.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(24, 177)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 16)
        Me.Label11.TabIndex = 168
        Me.Label11.Text = "Postal Charge:"
        '
        'txtPostalCharge
        '
        Me.txtPostalCharge.AfterDecimal = 0
        Me.txtPostalCharge.BeforeDecimal = 7
        Me.txtPostalCharge.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostalCharge.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPostalCharge.Location = New System.Drawing.Point(192, 177)
        Me.txtPostalCharge.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtPostalCharge.MaxLength = 7
        Me.txtPostalCharge.MaxValue = 0
        Me.txtPostalCharge.MinValue = 0
        Me.txtPostalCharge.Name = "txtPostalCharge"
        Me.txtPostalCharge.Size = New System.Drawing.Size(120, 23)
        Me.txtPostalCharge.TabIndex = 21
        '
        'txtInterest
        '
        Me.txtInterest.AfterDecimal = 2
        Me.txtInterest.BeforeDecimal = 8
        Me.txtInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterest.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtInterest.Location = New System.Drawing.Point(192, 113)
        Me.txtInterest.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtInterest.MaxLength = 10
        Me.txtInterest.MaxValue = 0
        Me.txtInterest.MinValue = 0
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(120, 23)
        Me.txtInterest.TabIndex = 19
        Me.txtInterest.TabStop = False
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(24, 113)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(67, 16)
        Me.Label40.TabIndex = 166
        Me.Label40.Text = "Interest:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(24, 145)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(89, 16)
        Me.Label33.TabIndex = 165
        Me.Label33.Text = "Commission:"
        '
        'txtCommission
        '
        Me.txtCommission.AfterDecimal = 0
        Me.txtCommission.BeforeDecimal = 8
        Me.txtCommission.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommission.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtCommission.Location = New System.Drawing.Point(192, 145)
        Me.txtCommission.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtCommission.MaxLength = 10
        Me.txtCommission.MaxValue = 0
        Me.txtCommission.MinValue = 0
        Me.txtCommission.Name = "txtCommission"
        Me.txtCommission.Size = New System.Drawing.Size(120, 23)
        Me.txtCommission.TabIndex = 20
        Me.txtCommission.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Black
        Me.btnCalculate.GotFocusColour = System.Drawing.Color.Gray
        Me.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalculate.Location = New System.Drawing.Point(264, 49)
        Me.btnCalculate.LostFocusColour = System.Drawing.Color.WhiteSmoke
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(48, 32)
        Me.btnCalculate.TabIndex = 17
        Me.btnCalculate.Text = "&Calc"
        '
        'txtCPercent
        '
        Me.txtCPercent.AfterDecimal = 2
        Me.txtCPercent.BackColor = System.Drawing.Color.White
        Me.txtCPercent.BeforeDecimal = 2
        Me.txtCPercent.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPercent.GotFocusColour = System.Drawing.Color.Beige
        Me.txtCPercent.Location = New System.Drawing.Point(192, 49)
        Me.txtCPercent.LostFocusColour = System.Drawing.Color.White
        Me.txtCPercent.MaxLength = 5
        Me.txtCPercent.MaxValue = 0
        Me.txtCPercent.MinValue = 0
        Me.txtCPercent.Name = "txtCPercent"
        Me.txtCPercent.Size = New System.Drawing.Size(56, 23)
        Me.txtCPercent.TabIndex = 16
        Me.txtCPercent.TabStop = False
        Me.txtCPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 16)
        Me.Label6.TabIndex = 161
        Me.Label6.Text = "Commission Percent:"
        '
        'txtROI
        '
        Me.txtROI.AfterDecimal = 2
        Me.txtROI.BackColor = System.Drawing.Color.White
        Me.txtROI.BeforeDecimal = 2
        Me.txtROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.GotFocusColour = System.Drawing.Color.Beige
        Me.txtROI.Location = New System.Drawing.Point(192, 81)
        Me.txtROI.LostFocusColour = System.Drawing.Color.White
        Me.txtROI.MaxLength = 5
        Me.txtROI.MaxValue = 0
        Me.txtROI.MinValue = 0
        Me.txtROI.Name = "txtROI"
        Me.txtROI.Size = New System.Drawing.Size(56, 23)
        Me.txtROI.TabIndex = 18
        Me.txtROI.TabStop = False
        Me.txtROI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 159
        Me.Label2.Text = "Rate of Interest:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtBankDetail)
        Me.GroupBox3.Controls.Add(Me.cmbChequeType)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtChequeAmount)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtChequeNo)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.dtpChequeDate)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(32, 208)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(344, 232)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cheque Detail"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(24, 168)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 16)
        Me.Label12.TabIndex = 96
        Me.Label12.Text = "Bank Detail: "
        '
        'txtBankDetail
        '
        Me.txtBankDetail.AlphaNumeric = True
        Me.txtBankDetail.BlankSpace = False
        Me.txtBankDetail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankDetail.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtBankDetail.Location = New System.Drawing.Point(152, 160)
        Me.txtBankDetail.LostFocusColour = System.Drawing.Color.Empty
        Me.txtBankDetail.Mandatory = False
        Me.txtBankDetail.MaxLength = 100
        Me.txtBankDetail.Multiline = True
        Me.txtBankDetail.Name = "txtBankDetail"
        Me.txtBankDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBankDetail.Size = New System.Drawing.Size(160, 64)
        Me.txtBankDetail.SpecialChar = True
        Me.txtBankDetail.TabIndex = 12
        '
        'cmbChequeType
        '
        Me.cmbChequeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChequeType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbChequeType.Items.AddRange(New Object() {"In Station", "Out Station", "Out of State"})
        Me.cmbChequeType.Location = New System.Drawing.Point(152, 128)
        Me.cmbChequeType.Name = "cmbChequeType"
        Me.cmbChequeType.Size = New System.Drawing.Size(160, 24)
        Me.cmbChequeType.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 16)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Cheque Type"
        '
        'txtChequeAmount
        '
        Me.txtChequeAmount.AfterDecimal = 2
        Me.txtChequeAmount.BeforeDecimal = 8
        Me.txtChequeAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtChequeAmount.Location = New System.Drawing.Point(152, 96)
        Me.txtChequeAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtChequeAmount.MaxLength = 10
        Me.txtChequeAmount.MaxValue = 0
        Me.txtChequeAmount.MinValue = 0
        Me.txtChequeAmount.Name = "txtChequeAmount"
        Me.txtChequeAmount.Size = New System.Drawing.Size(160, 23)
        Me.txtChequeAmount.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 16)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Cheque Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Cheque No "
        '
        'txtChequeNo
        '
        Me.txtChequeNo.AlphaNumeric = True
        Me.txtChequeNo.BlankSpace = False
        Me.txtChequeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtChequeNo.Location = New System.Drawing.Point(152, 32)
        Me.txtChequeNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtChequeNo.Mandatory = False
        Me.txtChequeNo.MaxLength = 10
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.Size = New System.Drawing.Size(160, 23)
        Me.txtChequeNo.SpecialChar = False
        Me.txtChequeNo.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Cheque Date"
        '
        'dtpChequeDate
        '
        Me.dtpChequeDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpChequeDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpChequeDate.Location = New System.Drawing.Point(152, 64)
        Me.dtpChequeDate.MaxDate = New Date(9998, 11, 24, 0, 0, 0, 0)
        Me.dtpChequeDate.Name = "dtpChequeDate"
        Me.dtpChequeDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpChequeDate.TabIndex = 9
        Me.dtpChequeDate.Value = New Date(2009, 4, 8, 0, 0, 0, 0)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(528, 456)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 16)
        Me.Label15.TabIndex = 159
        Me.Label15.Text = "Amount:"
        '
        'txtAmount
        '
        Me.txtAmount.AfterDecimal = 0
        Me.txtAmount.BeforeDecimal = 8
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmount.Location = New System.Drawing.Point(600, 456)
        Me.txtAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.MaxValue = 0
        Me.txtAmount.MinValue = 0
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(120, 23)
        Me.txtAmount.TabIndex = 24
        Me.txtAmount.TabStop = False
        '
        'cmbChequeStatus
        '
        Me.cmbChequeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChequeStatus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbChequeStatus.Items.AddRange(New Object() {"Pending", "Cleared"})
        Me.cmbChequeStatus.Location = New System.Drawing.Point(152, 456)
        Me.cmbChequeStatus.Name = "cmbChequeStatus"
        Me.cmbChequeStatus.Size = New System.Drawing.Size(136, 24)
        Me.cmbChequeStatus.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(32, 456)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 16)
        Me.Label13.TabIndex = 154
        Me.Label13.Text = "Cheque Status"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(304, 456)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(85, 16)
        Me.Label27.TabIndex = 149
        Me.Label27.Text = "Receipt No:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.txtCBPAccountNo)
        Me.GroupBox5.Controls.Add(Me.btnSearchCBP)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.txtName)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(32, 64)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(736, 56)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Account Details"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(40, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 15)
        Me.Label18.TabIndex = 111
        Me.Label18.Text = "Account No:"
        '
        'txtCBPAccountNo
        '
        Me.txtCBPAccountNo.AlphaNumeric = True
        Me.txtCBPAccountNo.BackColor = System.Drawing.Color.White
        Me.txtCBPAccountNo.BlankSpace = False
        Me.txtCBPAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCBPAccountNo.GotFocusColour = System.Drawing.Color.Beige
        Me.txtCBPAccountNo.Location = New System.Drawing.Point(152, 24)
        Me.txtCBPAccountNo.LostFocusColour = System.Drawing.Color.White
        Me.txtCBPAccountNo.Mandatory = False
        Me.txtCBPAccountNo.MaxLength = 8
        Me.txtCBPAccountNo.Name = "txtCBPAccountNo"
        Me.txtCBPAccountNo.Size = New System.Drawing.Size(128, 23)
        Me.txtCBPAccountNo.SpecialChar = True
        Me.txtCBPAccountNo.TabIndex = 1
        Me.txtCBPAccountNo.Text = "CBP"
        '
        'btnSearchCBP
        '
        Me.btnSearchCBP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchCBP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchCBP.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchCBP.ForeColor = System.Drawing.Color.Black
        Me.btnSearchCBP.GotFocusColour = System.Drawing.Color.Gray
        Me.btnSearchCBP.Image = CType(resources.GetObject("btnSearchCBP.Image"), System.Drawing.Image)
        Me.btnSearchCBP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchCBP.Location = New System.Drawing.Point(288, 24)
        Me.btnSearchCBP.LostFocusColour = System.Drawing.Color.WhiteSmoke
        Me.btnSearchCBP.Name = "btnSearchCBP"
        Me.btnSearchCBP.Size = New System.Drawing.Size(24, 24)
        Me.btnSearchCBP.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(392, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 16)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.Color.Beige
        Me.txtName.Location = New System.Drawing.Point(456, 24)
        Me.txtName.LostFocusColour = System.Drawing.Color.White
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(232, 23)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(88, 496)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 16)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "Remarks:"
        '
        'txtRemarks
        '
        Me.txtRemarks.AlphaNumeric = False
        Me.txtRemarks.BlankSpace = True
        Me.txtRemarks.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemarks.Location = New System.Drawing.Point(168, 488)
        Me.txtRemarks.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRemarks.Mandatory = False
        Me.txtRemarks.MaxLength = 100
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(496, 64)
        Me.txtRemarks.SpecialChar = True
        Me.txtRemarks.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(448, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 16)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Deposit Date"
        '
        'dtpDepositdate
        '
        Me.dtpDepositdate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDepositdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDepositdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDepositdate.Location = New System.Drawing.Point(584, 152)
        Me.dtpDepositdate.MaxDate = New Date(9998, 11, 24, 0, 0, 0, 0)
        Me.dtpDepositdate.Name = "dtpDepositdate"
        Me.dtpDepositdate.Size = New System.Drawing.Size(144, 23)
        Me.dtpDepositdate.TabIndex = 15
        Me.dtpDepositdate.Value = New Date(2009, 4, 8, 0, 0, 0, 0)
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(88, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(262, 23)
        Me.Label32.TabIndex = 68
        Me.Label32.Text = "Clearing Bill Purchase Master"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.GotFocusColour = System.Drawing.Color.DimGray
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(40, 560)
        Me.btnAdd.LostFocusColour = System.Drawing.Color.WhiteSmoke
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 40)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "&Reset"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.Gray
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(552, 560)
        Me.btnOk.LostFocusColour = System.Drawing.Color.WhiteSmoke
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(96, 40)
        Me.btnOk.TabIndex = 25
        Me.btnOk.Text = "&Save"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(656, 560)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 28
        Me.btnCancel.Text = "&Close"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'frmCBPCreation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1016, 629)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmCBPCreation"
        Me.ShowInTaskbar = False
        Me.Text = "CBP Creation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Global Variable"
    Dim objSavingsBank As New clsSavingsBank
    Dim objSBAccount As New clsSavingsBank1
    Dim objCurrentAccount As New clsCurrentAccount
    Dim objODAccount As New clsODLoanDetails
    Dim objCBP As New clsCBPDet
    Dim lngPersonNo As Long = 0
    Dim dblAvalAmount As Double

    Dim ROI As Double
    Dim dblInterest1 As Double
    Dim dblInterest2 As Double
    Dim dblCalIntrest As Double

#End Region

#Region "Code to Create Instance Object"
    Private Shared m_FormDefInstance As frmCBPCreation
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As frmCBPCreation
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmCBPCreation
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmCBPCreation)
            m_FormDefInstance = Value
        End Set
    End Property
#End Region

#Region "Function"

    Function fnCheck() As Boolean

        If txtCBPAccountNo.Text = "CBP" Then
            MsgBox("Enter CBP number", MsgBoxStyle.Exclamation)
            txtCBPAccountNo.Focus()
            Return False
        ElseIf txtName.Text = String.Empty Then
            MsgBox("Enter name", MsgBoxStyle.Exclamation)
            txtName.Focus()
            Return False
        ElseIf txtSBAccNo.Text = String.Empty Then
              MsgBox("CBP Account created without SB or CA or OD", MsgBoxStyle.Exclamation)
            '    btnSearchSBP.Focus()
            '    Return False
        ElseIf txtChequeNo.Text = String.Empty Then
            MsgBox("Enter cheque number", MsgBoxStyle.Exclamation)
            txtChequeNo.Focus()
            Return False
        ElseIf txtChequeAmount.Text.Length = 0 And Val(txtChequeAmount.Text) = 0 Then
            MsgBox("Enter cheque amount", MsgBoxStyle.Exclamation)
            txtChequeAmount.Focus()
            Return False
        ElseIf cmbChequeType.SelectedIndex = -1 Then
            MsgBox("Select type of cheque", MsgBoxStyle.Exclamation)
            cmbChequeType.Focus()
            Return False
        ElseIf txtBankDetail.Text.Length = 0 Then
            MsgBox("Enter bank detail", MsgBoxStyle.Exclamation)
            txtBankDetail.Focus()
            Return False
        ElseIf Val(txtCPercent.Text) = 0 Then
            MsgBox("Enter commission percent", MsgBoxStyle.Exclamation)
            txtCPercent.Focus()
            Return False
        ElseIf Val(txtROI.Text) = 0 Then
            MsgBox("Enter ROI", MsgBoxStyle.Exclamation)
            txtROI.Focus()
            Return False
            'ElseIf txtInterest.Text.Length = 0 Then
            '    MsgBox("Cal Interest")
            '    btnCalculate.Focus()
            '    Return False
        ElseIf txtInterest.Text < 0 Then
            MsgBox("Interest cannot be less than zero", MsgBoxStyle.Exclamation)
            txtInterest.Focus()
            Return False
            'ElseIf txtCommission.Text.Length = 0 Then
            '    MsgBox("Cal Interest")
            '    btnCalculate.Focus()
            '    Return False
        ElseIf txtCommission.Text < 0 Then
            MsgBox("Commission cannot be less than zero", MsgBoxStyle.Exclamation)
            txtCommission.Focus()
            Return False
            'ElseIf txtPostalCharge.Text.Length = 0 Then
            '    MsgBox("Enter Postal Charges")
            '    txtPostalCharge.Focus()
            '    Return False
        ElseIf txtPostalCharge.Text.Length < 0 Then
            MsgBox("Postal Charges cannot be lesser than zero", MsgBoxStyle.Exclamation)
            txtPostalCharge.Focus()
            Return False
        ElseIf txtOtherCharges.Text.Length < 0 Then
            MsgBox("Bank charges cannot be lesser than zero", MsgBoxStyle.Exclamation)
            txtOtherCharges.Focus()
            Return False
        ElseIf cmbChequeStatus.SelectedIndex = -1 Then
            MsgBox("Check the status of the cheque", MsgBoxStyle.Exclamation)
            cmbChequeStatus.Focus()
            Return False
        ElseIf txtReceiptNo.Text.Length = 0 Then
            MsgBox("Enter receipt number", MsgBoxStyle.Exclamation)
            txtReceiptNo.Focus()
            Return False
        ElseIf txtAmount.Text < 0 Then
            MsgBox("Amount cannot be lesser zero", MsgBoxStyle.Exclamation)
            Return False
        ElseIf txtAmount.Text = 0 Then
            MsgBox("Amount cannot be zero", MsgBoxStyle.Exclamation)
            Return False
        Else
            Return True
        End If

    End Function

    Sub clearData()

        txtCBPAccountNo.Text = "CBP"
        txtSBAccNo.ResetText()
        txtNoOfDays.ResetText()
        txtName.ResetText()
        txtChequeNo.ResetText()
        txtChequeAmount.ResetText()
        txtBankDetail.ResetText()
        txtCPercent.ResetText()
        txtROI.ResetText()
        txtCommission.ResetText()
        txtPostalCharge.ResetText()
        txtInterest.ResetText()
        txtPostalCharge.ResetText()
        txtOtherCharges.ResetText()
        txtReceiptNo.ResetText()
        txtRemarks.ResetText()
        txtAmount.ResetText()
        cmbChequeStatus.Enabled = True
        cmbChequeStatus.SelectedIndex = -1
        cmbChequeType.SelectedIndex = -1
        rdCAbtn.Checked = False
        rdSBbtn.Checked = False

    End Sub

    Function fnSetDate() As Boolean

        objCBP.CBPNo = txtCBPAccountNo.Text
        objCBP.SBNo = txtSBAccNo.Text
        objCBP.Name = txtName.Text

        objCBP.DepositDate = dtpDepositdate.Value
        objCBP.ChequeNo = txtChequeNo.Text
        objCBP.ChequeDate = dtpChequeDate.Value
        objCBP.ChequeAmount = txtChequeAmount.Text

        If cmbChequeType.SelectedItem = "In Station" Then
            objCBP.ChequeType = "I"
        ElseIf cmbChequeType.SelectedItem = "Out Station" Then
            objCBP.ChequeType = "O"
        ElseIf cmbChequeType.SelectedItem = "Out of State" Then
            objCBP.ChequeType = "S"

        End If

        objCBP.BankDetail = txtBankDetail.Text
        objCBP.ComPercent = txtCPercent.Text
        objCBP.ROI = txtROI.Text
        objCBP.Interest = Val(txtInterest.Text)
        objCBP.Commission = Val(txtCommission.Text)
        objCBP.PostalCharges = Val(txtPostalCharge.Text)
        objCBP.OtherCharge = Val(txtOtherCharges.Text)

        If cmbChequeStatus.SelectedItem = "Pending" Then
            objCBP.Status = "P"
        ElseIf cmbChequeStatus.SelectedItem = "Cleared" Then
            objCBP.Status = "C"
        End If
        objCBP.RefNo = txtReceiptNo.Text
        objCBP.Amount = Val(txtAmount.Text)
        objCBP.Remarks = txtRemarks.Text
        objCBP.ChequeClearedDate = "9999-9-9"

        Return True
    End Function

    Sub sbloaddetails()
        Dim objDT As DataTable
        If Trim(txtSBAccNo.Text) <> String.Empty Then
            If objSavingsBank.fnGetSBAccountDetails(Trim(txtSBAccNo.Text)) Then
                objDT = objSavingsBank.SBAccTable
                lngPersonNo = objDT.Rows(0).Item("PersonNo")
                txtName.Text = objDT.Rows(0).Item("Name")

            Else
                MsgBox("Account no does not exist!", MsgBoxStyle.Exclamation, Me.Text)
                txtSBAccNo.Focus()

            End If
        End If
    End Sub
    Sub ODloaddetails()
        Dim objDT As DataTable
        If Trim(txtSBAccNo.Text) <> String.Empty Then
            If objODAccount.fnGetLoanDetails(Trim(txtSBAccNo.Text)) Then
                objDT = objODAccount.ODLoanDettable
                lngPersonNo = objDT.Rows(0).Item("PersonNo")
                txtName.Text = objDT.Rows(0).Item("Name")

            Else
                MsgBox("Account no does not exist!", MsgBoxStyle.Exclamation, Me.Text)
                txtSBAccNo.Focus()

            End If
        End If
    End Sub

    Sub caloaddetails()
        If Trim(txtSBAccNo.Text) <> String.Empty Then
            If objCurrentAccount.fnGetCAccountDetails(Trim(txtSBAccNo.Text)) Then
                txtName.Text = objCurrentAccount.CAAccTable.Rows(0).Item("Name")
                lngPersonNo = 0
                If objCurrentAccount.fnGetCAMasterData Then
                    ROI = objCurrentAccount.CAMasterTable.Rows(0).Item("CAROI")
                Else
                    ROI = 0
                End If
            Else
                MsgBox("Account no does not exist!", MsgBoxStyle.Exclamation, Me.Text)
                txtSBAccNo.Focus()

            End If
        End If
    End Sub

    Function fnGenerateVoucherD() As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositdate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entery
        Dim strNarration As String = "Deposit By Cash" & txtSBAccNo.Text & "  Narration:" & txtRemarks.Text
        Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtSBAccNo.Text) & "','" & Format(dtpDepositdate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtAmount.Text) & "','" & dblInterest1 & "','" & Trim(txtReceiptNo.Text) & "','" & lngVoucherNo & "','Cash','0' from catransactiontbl where caccountno='" & Trim(txtSBAccNo.Text) & "' group by CAccountno"
        fnExecuteNonQuery(strsql)

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 7, txtSBAccNo.Text, txtReceiptNo.Text, dtpDepositdate.Value, txtAmount.Text, "Deposit by" & txtSBAccNo.Text, lngSlNo, "Y")
        If Val(dblAvalAmount) < 0 Then
            Dim dblTempBalance As Double = Val(dblAvalAmount) + Val(txtAmount.Text)

            If dblTempBalance < 0 Then

                'Credit accounts 
                fnVoucherEnterSub(lngVoucherNo, 7, txtSBAccNo.Text, dtpDepositdate.Value, "Cash deposit by account " & txtSBAccNo.Text, "to", 12, 0, Val(txtAmount.Text), 1, "Y")

                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 7, " ", dtpDepositdate.Value, "Cash deposit by account " & txtSBAccNo.Text, "By", 50, Val(txtChequeAmount.Text), 0, 2, "Y")
            Else

                If dblTempBalance <> 0 Then
                    'Credit accounts 
                    fnVoucherEnterSub(lngVoucherNo, 7, txtSBAccNo.Text, dtpDepositdate.Value, "Cash deposit by account " & txtSBAccNo.Text, "To", 11, 0, Abs(dblTempBalance), 1, "Y")
                End If

                'Credit accounts 
                fnVoucherEnterSub(lngVoucherNo, 7, txtSBAccNo.Text, dtpDepositdate.Value, "Cash deposit by account " & txtSBAccNo.Text, "To", 12, 0, Abs(dblAvalAmount), 2, "Y")

                'Debit accounts 
                fnVoucherEnterSub(lngVoucherNo, 7, " ", dtpDepositdate.Value, "Cash deposit by account " & txtSBAccNo.Text, "By", 50, Val(txtChequeAmount.Text), 0, 3, "Y")
            End If
        Else
            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 7, txtSBAccNo.Text, dtpDepositdate.Value, "Cash deposit by account " & txtSBAccNo.Text, "To", 11, 0, Val(txtAmount.Text), 1, "Y")

            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 7, " ", dtpDepositdate.Value, "Cash deposit by account " & txtSBAccNo.Text, "By", 50, Val(txtChequeAmount.Text), 0, 2, "Y")
        End If

        'Credit accounts 
        If Val(txtInterest.Text) <> 0 Or txtInterest.Text <> "" Then
            fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "Interest paid by  " & txtCBPAccountNo.Text, "By", 51, 0, Val(txtInterest.Text), 5, "Y")
        End If

        If Val(txtCommission.Text) <> 0 Or txtCommission.Text <> "" Then
            fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "Commission paid by " & txtCBPAccountNo.Text, "By", 45, 0, Val(txtCommission.Text), 6, "Y")
        End If

        If Val(txtPostalCharge.Text) <> 0 Or txtPostalCharge.Text <> "" Then
            fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "Postage charge paid by " & txtCBPAccountNo.Text, "By", 52, 0, Val(txtPostalCharge.Text), 7, "Y")
        End If

        If Val(txtOtherCharges.Text) <> 0 Or txtOtherCharges.Text <> "" Then
            fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "Misc charge paid by " & txtCBPAccountNo.Text, "By", 13, 0, Val(txtOtherCharges.Text), 8, "Y")
        End If

        Return True

    End Function

    Function fnGenerateVoucher(ByVal objTrans) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositdate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        objCBP.fnUpdateDVoucherNo(lngVoucherNo, objTrans)

        Dim strNarration As String
        strNarration = "Deposit By " & txtCBPAccountNo.Text & " Narration:" & txtRemarks.Text

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 7, txtCBPAccountNo.Text, txtReceiptNo.Text, dtpDepositdate.Value, txtChequeAmount.Text, "By New " & txtCBPAccountNo.Text, lngSlNo, "Y", objTrans)

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "CBP amount paid " & txtCBPAccountNo.Text, "By", 50, Val(txtChequeAmount.Text), 0, 2, "Y", objTrans)

        ''Credit accounts
        ' 'fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDepositdate.Value, "CBP Amount Paid " & txtCBPAccountNo.Text, "To", 1, 0, Val(txtAmount.Text), 3, "Y")

        'Credit accounts
        'fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "CBP amount paid " & txtCBPAccountNo.Text, "To", 60, 0, Val(txtChequeAmount.Text), 1, "Y", objTrans)

        Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtSBAccNo.Text) & "','" & Format(dtpDepositdate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtAmount.Text) & "','" & Trim(txtReceiptNo.Text) & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtSBAccNo.Text) & "' group by Accountno"
        fnExecuteNonQuery(strsql)

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "CBP amount paid " & txtCBPAccountNo.Text, "To", 10, 0, Val(txtAmount.Text), 3, "Y", objTrans)

        'Debit accounts 
        '' fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "CBP amount paid " & txtCBPAccountNo.Text, "By", 60, Val(txtChequeAmount.Text), 0, 4, "Y", objTrans)


        'Credit accounts 
        If Val(txtInterest.Text) <> 0 And txtInterest.Text <> "" Then
            fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "Interest paid by  " & txtCBPAccountNo.Text, "By", 51, 0, Val(txtInterest.Text), 5, "Y", objTrans)
        End If

        If Val(txtCommission.Text) <> 0 And txtCommission.Text <> "" Then
            fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "Commission paid by " & txtCBPAccountNo.Text, "By", 45, 0, Val(txtCommission.Text), 6, "Y", objTrans)
        End If

        If Val(txtPostalCharge.Text) <> 0 And txtPostalCharge.Text <> "" Then
            fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "Postage charge paid by " & txtCBPAccountNo.Text, "By", 52, 0, Val(txtPostalCharge.Text), 7, "Y", objTrans)
        End If

        If Val(txtOtherCharges.Text) <> 0 And txtOtherCharges.Text <> "" Then
            fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "Misc charge paid by " & txtCBPAccountNo.Text, "By", 13, 0, Val(txtOtherCharges.Text), 8, "Y", objTrans)
        End If

        Return True

    End Function
    Function fnGenerateODVoucher(ByVal objTrans) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositdate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        objCBP.fnUpdateDVoucherNo(lngVoucherNo, objTrans)

        Dim strNarration As String
        strNarration = "Deposit By " & txtCBPAccountNo.Text & " Narration:" & txtRemarks.Text

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 7, txtCBPAccountNo.Text, txtReceiptNo.Text, dtpDepositdate.Value, txtChequeAmount.Text, "By New " & txtCBPAccountNo.Text, lngSlNo, "Y", objTrans)

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "CBP amount paid " & txtCBPAccountNo.Text, "By", 50, Val(txtChequeAmount.Text), 0, 2, "Y", objTrans)

        ''Credit accounts
        'fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDepositdate.Value, "CBP Amount Paid " & txtCBPAccountNo.Text, "To", 1, 0, Val(txtAmount.Text), 3, "Y")

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "CBP amount paid " & txtCBPAccountNo.Text, "To", 60, 0, Val(txtChequeAmount.Text), 1, "Y", objTrans)

        'Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
        'strsql = strsql & " select '" & Trim(txtSBAccNo.Text) & "','" & Format(dtpDepositdate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtAmount.Text) & "','" & Trim(txtReceiptNo.Text) & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtSBAccNo.Text) & "' group by Accountno"
        'fnExecuteNonQuery(strsql)

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "CBP amount paid " & txtCBPAccountNo.Text, "To", 12, 0, Val(txtAmount.Text), 3, "Y", objTrans)

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "CBP amount paid " & txtCBPAccountNo.Text, "By", 60, Val(txtChequeAmount.Text), 0, 4, "Y", objTrans)


        'Credit accounts 
        If Val(txtInterest.Text) <> 0 And txtInterest.Text <> "" Then
            fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "Interest paid by  " & txtCBPAccountNo.Text, "By", 51, 0, Val(txtInterest.Text), 5, "Y", objTrans)
        End If

        If Val(txtCommission.Text) <> 0 And txtCommission.Text <> "" Then
            fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "Commission paid by " & txtCBPAccountNo.Text, "By", 45, 0, Val(txtCommission.Text), 6, "Y", objTrans)
        End If

        If Val(txtPostalCharge.Text) <> 0 And txtPostalCharge.Text <> "" Then
            fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "Postage charge paid by " & txtCBPAccountNo.Text, "By", 52, 0, Val(txtPostalCharge.Text), 7, "Y", objTrans)
        End If

        If Val(txtOtherCharges.Text) <> 0 And txtOtherCharges.Text <> "" Then
            fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "Misc charge paid by " & txtCBPAccountNo.Text, "By", 13, 0, Val(txtOtherCharges.Text), 8, "Y", objTrans)
        End If

        Return True

    End Function

    Function fnGenerateVoucherWithOutAccNo(ByVal objTrans) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpDepositdate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        objCBP.fnUpdateDVoucherNo(lngVoucherNo, objTrans)

        Dim strNarration As String
        strNarration = "Deposit By " & txtCBPAccountNo.Text & " Narration:" & txtRemarks.Text

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 7, txtCBPAccountNo.Text, txtReceiptNo.Text, dtpDepositdate.Value, txtChequeAmount.Text, "By New " & txtCBPAccountNo.Text, lngSlNo, "Y", objTrans)

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "CBP amount paid " & txtCBPAccountNo.Text, "By", 50, Val(txtChequeAmount.Text), 0, 2, "Y", objTrans)

        ''Credit accounts
        'fnVoucherEnterSub(lngVoucherNo, 1, "", dtpDepositdate.Value, "CBP Amount Paid " & txtCBPAccountNo.Text, "To", 1, 0, Val(txtAmount.Text), 3, "Y")

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "CBP amount paid " & txtCBPAccountNo.Text, "To", 60, 0, Val(txtChequeAmount.Text), 1, "Y", objTrans)

        'Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
        'strsql = strsql & " select '" & Trim(txtSBAccNo.Text) & "','" & Format(dtpDepositdate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(txtAmount.Text) & "','0','" & Trim(txtAmount.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(txtAmount.Text) & "','" & Trim(txtReceiptNo.Text) & "','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtSBAccNo.Text) & "' group by Accountno"
        'fnExecuteNonQuery(strsql)

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "CBP amount paid " & txtCBPAccountNo.Text, "To", 1, 0, Val(txtAmount.Text), 3, "Y", objTrans)

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "CBP amount paid " & txtCBPAccountNo.Text, "By", 60, Val(txtChequeAmount.Text), 0, 4, "Y", objTrans)


        'Credit accounts 
        If Val(txtInterest.Text) <> 0 And txtInterest.Text <> "" Then
            fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "Interest paid by  " & txtCBPAccountNo.Text, "By", 51, 0, Val(txtInterest.Text), 5, "Y", objTrans)
        End If

        If Val(txtCommission.Text) <> 0 And txtCommission.Text <> "" Then
            fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "Commission paid by " & txtCBPAccountNo.Text, "By", 45, 0, Val(txtCommission.Text), 6, "Y", objTrans)
        End If

        If Val(txtPostalCharge.Text) <> 0 And txtPostalCharge.Text <> "" Then
            fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "Postage charge paid by " & txtCBPAccountNo.Text, "By", 52, 0, Val(txtPostalCharge.Text), 7, "Y", objTrans)
        End If

        If Val(txtOtherCharges.Text) <> 0 And txtOtherCharges.Text <> "" Then
            fnVoucherEnterSub(lngVoucherNo, 7, txtCBPAccountNo.Text, dtpDepositdate.Value, "Misc charge paid by " & txtCBPAccountNo.Text, "By", 13, 0, Val(txtOtherCharges.Text), 8, "Y", objTrans)
        End If

        Return True

    End Function
    Sub CBPLoadDetail()
        Dim strAccType As String
        Dim objDT As DataTable
        If Trim(txtCBPAccountNo.Text) <> "CBP" Then
            If objCBP.fnGetCBPDetails(txtCBPAccountNo.Text) Then
                clearData()
                objDT = objCBP.CBPdetail
                txtCBPAccountNo.Text = objDT.Rows(0).Item("AccountNo")


                txtName.Text = objDT.Rows(0).Item("Name")
                txtSBAccNo.Text = objDT.Rows(0).Item("TrAccNo")
                strAccType = Mid(txtSBAccNo.Text, 1, 2)
                Select Case strAccType
                    Case "SB"
                        rdSBbtn.Checked = True
                    Case "CA"
                        rdCAbtn.Checked = True
                End Select
                dtpDepositdate.Value = CDate(objDT.Rows(0).Item("DepositDate"))
                txtChequeNo.Text = objDT.Rows(0).Item("ChequeNo")
                dtpChequeDate.Value = CDate(objDT.Rows(0).Item("ChequeDate"))
                txtChequeAmount.Text = objDT.Rows(0).Item("ChequeAmount")

                If objDT.Rows(0).Item("ChequrType") = "I" Then
                    cmbChequeType.SelectedItem = "In Station"
                ElseIf objDT.Rows(0).Item("ChequrType") = "O" Then
                    cmbChequeType.SelectedItem = "Out Station"
                End If

                txtBankDetail.Text = objDT.Rows(0).Item("BankDetail")
                txtCPercent.Text = objDT.Rows(0).Item("CommPercent")
                txtROI.Text = objDT.Rows(0).Item("ROI")
                txtInterest.Text = objDT.Rows(0).Item("IntAmount")
                txtCommission.Text = objDT.Rows(0).Item("Commission")
                txtPostalCharge.Text = objDT.Rows(0).Item("PostalCharge")
                txtOtherCharges.Text = objDT.Rows(0).Item("OtherCharge")

                If objDT.Rows(0).Item("ChequeStatus") = "P" Then
                    cmbChequeStatus.SelectedItem = "Pending"
                ElseIf objDT.Rows(0).Item("ChequeStatus") = "C" Then
                    cmbChequeStatus.SelectedItem = "Cleared"
                End If
                cmbChequeStatus.Enabled = False
                txtReceiptNo.Text = objDT.Rows(0).Item("DReceiptNo")
                txtRemarks.Text = objDT.Rows(0).Item("Remark")

            End If
        End If
    End Sub

    Function fnCalcInterest(ByVal AccNo As String) As Double

        Dim intNOD As Integer
        dblCalIntrest = 0
        Dim intInterestDiff As Integer
        Dim dblAmount As Double

        If objCurrentAccount.fnGetCAccountDetails(AccNo) Then
            dblAmount = objCurrentAccount.CAAccTable.Rows(0).Item("AvailBalance")
            If dblAmount < 0 Then
                Dim datLastPaid As Date = CDate(objCurrentAccount.CAAccTable.Rows(0).Item("LastPaidDate"))
                intInterestDiff = DateDiff(DateInterval.Day, datLastPaid, dtpDepositdate.Value)
                If intInterestDiff > 0 Then
                    dblCalIntrest = Math.Round(((Abs(dblAmount) * intInterestDiff * (ROI / 100)) / 365), 2)
                    Return dblCalIntrest
                End If
            Else
                Return dblCalIntrest
            End If
        End If

    End Function


    Function fnSaveData(ByVal objTrans) As Boolean
        If objCBP.fnGetCBPDetails(Trim(txtCBPAccountNo.Text)) = False Then
            If objCBP.fnAddData(objTrans) Then

                If rdCAbtn.Checked = True Then
                    dblInterest1 = fnCalcInterest(txtSBAccNo.Text)
                    objCurrentAccount.IntAmt = dblInterest1
                    If objCurrentAccount.fnUpdateLastPaid(txtSBAccNo.Text) Then
                        fnGenerateVoucherD()
                    End If
                ElseIf rdSBbtn.Checked = True Then
                    fnGenerateVoucher(objTrans)
                ElseIf rdODbtn.Checked = True Then
                    fnGenerateODVoucher(objTrans)
                Else
                    fnGenerateVoucherWithOutAccNo(objTrans)
                End If
                objTrans.Commit()
                fnLogEntry(pbUserId, "New CBP account created" & txtCBPAccountNo.Text, Date.Now, "New CBP Account")

                MessageBox.Show("New CBP Account created successfully.", "CBP Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("New CBP account creation failed, because of internal error.", "CBP Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If
        End If
    End Function
    Public Function fnGetROI() As Boolean
        If objSBAccount.fnGetROI(txtCBPAccountNo.Text, Val(txtChequeAmount.Text)) Then
            txtROI.Text = (objSBAccount.Loantypetable.Rows(0).Item("PI"))
            txtCPercent.Text = (objSBAccount.Loantypetable.Rows(0).Item("ROI"))
        End If
    End Function

    Public Function fncalInterest() As Boolean

        Dim datNextDate As Date
        Dim intcalInterest As Double = 0
        Dim intInterestDiff As Integer = 0
        If cmbChequeType.SelectedItem = "In Station" Then
            intcalInterest = Math.Round(((Val(txtChequeAmount.Text) * Val(txtNoOfDays.Text) * (Val(txtROI.Text) / 100)) / 365))
        ElseIf cmbChequeType.SelectedItem = "Out Station" Then
            intcalInterest = Math.Round(((Val(txtChequeAmount.Text) * Val(txtNoOfDays.Text) * (Val(txtROI.Text) / 100)) / 365))
        ElseIf cmbChequeType.SelectedItem = "Out of State" Then
            ''datNextDate = DateAdd(DateInterval.Month, 1, dtpDepositdate.Value)
            ''intInterestDiff = DateDiff(DateInterval.Day, dtpDepositdate.Value, datNextDate)
            intcalInterest = Math.Round(((Val(txtChequeAmount.Text) * Val(txtNoOfDays.Text) * (Val(txtROI.Text) / 100)) / 365))
        End If
        txtInterest.Text = intcalInterest
        Return True

    End Function

    Public Function fncalCommission() As Boolean

        Dim intcalCommission As Double = 0
        intcalCommission = Math.Round((Val(txtChequeAmount.Text) * Val(txtCPercent.Text)) / 100)
        txtCommission.Text = intcalCommission
        Return True
    End Function

#End Region

#Region "Event"


    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim objTrans As IDbTransaction
        objTrans = fnGetTransaction()
        Try
            If fnCheck() Then
                If objCBP.fnGetCBPDetails(Trim(txtCBPAccountNo.Text)) = False Then
                    If fnSetDate() Then
                        If fnSaveData(objTrans) Then

                            If MsgBox("You want to add another CBP account ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Conform Addition") = MsgBoxResult.Yes Then
                                btnAdd_Click(sender, e)
                            Else
                                Me.Close()
                            End If
                        End If
                    End If
                Else
                    MsgBox("Account no already exists ", MsgBoxStyle.Exclamation)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try
    End Sub

    Private Sub btnSearchSBP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchSBP.Click
        If rdCAbtn.Checked = False And rdSBbtn.Checked = False And rdODbtn.Checked = False Then
            MsgBox("Please select either SB or CA or OD", MsgBoxStyle.Exclamation)
        Else
            If rdCAbtn.Checked = True Then
                Dim objCAccSearch As New frmCAccSearch
                objCAccSearch.strCAccountNo = String.Empty
                objCAccSearch.ShowDialog(Me)
                If objCAccSearch.strCAccountNo <> String.Empty Then
                    txtSBAccNo.Text = objCAccSearch.strCAccountNo
                    caloaddetails()
                End If
                objCAccSearch.Dispose()
            ElseIf rdSBbtn.Checked = True Then
                Dim objSBAccSearch As New frmSBAccSearch
                objSBAccSearch.strSBAccountNo = String.Empty
                objSBAccSearch.ShowDialog(Me)
                If objSBAccSearch.strSBAccountNo <> String.Empty Then
                    txtSBAccNo.Text = objSBAccSearch.strSBAccountNo
                    sbloaddetails()
                    objSBAccSearch.Dispose()
                End If

            ElseIf rdODbtn.Checked = True Then
                Dim objODAccSearch As New frmODLoanCust
                objODAccSearch.strODLoan = String.Empty
                objODAccSearch.ShowDialog(Me)
                If objODAccSearch.strODLoan <> String.Empty Then
                    txtSBAccNo.Text = objODAccSearch.strODLoan
                    ODloaddetails()
                    objODAccSearch.Dispose()
                End If
            End If
        End If


    End Sub

    Private Sub txtInterest_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInterest.TextChanged, txtCommission.TextChanged, txtPostalCharge.TextChanged, txtOtherCharges.TextChanged
        txtAmount.Text = Val(txtChequeAmount.Text) - (Val(txtInterest.Text) + Val(txtCommission.Text) + Val(txtPostalCharge.Text) + Val(txtOtherCharges.Text))
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        nMode = CTAdd
        clearData()
        Dim Temp As String
        Dim TempNewNo As String = Mid(objCBP.fnGetNewLoanNo("CBP"), 4, 8)
        If TempNewNo = "" Then
            TempNewNo = 1
        Else
            TempNewNo += 1
        End If
        If TempNewNo < 99999 Then
            Temp = "CBP" & String.Format("{0:00000}", CInt(TempNewNo))
            txtCBPAccountNo.Text = Temp
            txtCBPAccountNo.Focus()
        Else
            MsgBox("CBP number exceeds the maximum alloted number", MsgBoxStyle.Information, "CBP Module")
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtChequeAmount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtChequeAmount.Leave
        fnGetROI()
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        If txtChequeAmount.Text <> String.Empty Then
            If cmbChequeType.SelectedIndex <> -1 Then
                If fncalInterest() Then
                    If fncalCommission() Then
                    End If
                End If
            Else
                MsgBox("Slect type of cheque", MsgBoxStyle.Exclamation)
                cmbChequeType.Focus()
            End If
        Else
            MsgBox("Enter cheque amount")
            txtChequeAmount.Focus()
        End If
    End Sub

    Private Sub btnSearchCBP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchCBP.Click
        Dim objCBPAccSearch As New frmCBPSearch
        objCBPAccSearch.strCBPNo = String.Empty
        objCBPAccSearch.ShowDialog(Me)
        If objCBPAccSearch.strCBPNo <> String.Empty Then
            txtCBPAccountNo.Text = objCBPAccSearch.strCBPNo
            CBPLoadDetail()
        End If
        objCBPAccSearch.Dispose()

    End Sub

    Private Sub frmCBPCreation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpChequeDate.Value = Date.Now
        dtpDepositdate.Value = Date.Now
        If txtCBPAccountNo.Text <> "CBP" Then
            CBPLoadDetail()
        Else
            btnAdd_Click(sender, e)
        End If
    End Sub

    Private Sub txtCBPAccountNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCBPAccountNo.Leave
        If txtCBPAccountNo.Text <> "CBP" Then
            If objCBP.fnGetCBPDetails(Trim(txtCBPAccountNo.Text)) = True Then
                If MsgBox("Account no already exists do you want to load it", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    CBPLoadDetail()
                Else
                    btnAdd_Click(sender, e)
                End If
            End If
        End If
    End Sub

    Private Sub NewButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton3.Click
        Dim objTrans As IDbTransaction
        objTrans = fnGetTransaction()
        Try
            If objCBP.fnGetCBPDetails(Trim(txtCBPAccountNo.Text)) = True Then
                If cmbChequeStatus.SelectedItem = "Pending" Then
                    If objCBP.fnGetCBPDetails(Trim(txtCBPAccountNo.Text)) = True Then
                        Dim ObjfrmFDPayments As New frmCBPClearing
                        ObjfrmFDPayments.txtAccountNo.Text = txtCBPAccountNo.Text
                        ObjfrmFDPayments.btnSearch.Enabled = False
                        ObjfrmFDPayments.ShowDialog(Me)
                    Else
                        MsgBox("Select correct account number", MsgBoxStyle.Exclamation)
                        btnSearchCBP.Focus()
                    End If
                Else
                    MsgBox("Cheque is already cleared", MsgBoxStyle.Exclamation)
                    btnSearchCBP.Focus()
                End If
            Else
                MsgBox("CBP number dosent exist", MsgBoxStyle.Exclamation)
                txtCBPAccountNo.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try
    End Sub
    Private Sub txtCBPAccountNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCBPAccountNo.KeyDown
        If txtCBPAccountNo.Text = "CBP" Then
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.D Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Home Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Delete Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtCBPAccountNo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCBPAccountNo.KeyUp
        If e.KeyCode = Keys.F3 Then
            btnSearchCBP_Click(Me, e.Empty)
        End If
        If txtCBPAccountNo.Text = "CBP" Then
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.D Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Home Or e.KeyCode = Keys.Left Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtCBPAccountNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCBPAccountNo.KeyPress
        If txtCBPAccountNo.Text = "CBP" Then
            If e.KeyChar = Chr(8) Or e.KeyChar = Chr(68) Or e.KeyChar = Chr(37) Or e.KeyChar = Chr(38) Or e.KeyChar = Chr(36) Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtAccNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCBPAccountNo.TextChanged
        If txtCBPAccountNo.Text.StartsWith("CBP") = False Then
            txtCBPAccountNo.Undo()
            txtCBPAccountNo.ClearUndo()
        End If
    End Sub
#End Region

    Private Sub rdCAbtn_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdCAbtn.CheckedChanged
        If rdCAbtn.Checked = True Then
            lblAccount.Text = "CA Account No: "
        End If
    End Sub

    Private Sub rdSBbtn_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdSBbtn.CheckedChanged
        If rdSBbtn.Checked = True Then
            lblAccount.Text = "SB Account No: "
        End If
    End Sub
    Private Sub rdODbtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdODbtn.CheckedChanged
        If rdODbtn.Checked = True Then
            lblAccount.Text = "OD Account No: "
        End If
    End Sub

    Private Sub cmbChequeType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbChequeType.SelectedIndexChanged
        If cmbChequeType.SelectedItem = "In Station" Then
            txtNoOfDays.Text = 5
        ElseIf cmbChequeType.SelectedItem = "Out Station" Then
            txtNoOfDays.Text = 15
        ElseIf cmbChequeType.SelectedItem = "Out of State" Then
            txtNoOfDays.Text = 30
        End If
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class

