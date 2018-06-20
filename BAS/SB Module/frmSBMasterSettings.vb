Public Class frmSBMasterSettings
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkMinAmtForCheque As System.Windows.Forms.CheckBox
    Friend WithEvents txtMinAmtForCheque As BankControls.NumericControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkMinAmount As System.Windows.Forms.CheckBox
    Friend WithEvents txtRoi As BankControls.NumericControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMinAmount As BankControls.NumericControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtStartChequeNo As BankControls.NumericControl
    Friend WithEvents btnSaveSettings As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNo0fLeafs As BankControls.NumericControl
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAmountPerLeaf As BankControls.NumericControl
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtMinAmtforIntrest As BankControls.NumericControl
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMinInterestPayable As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSBMasterSettings))
        Me.Label4 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtMinInterestPayable = New BankControls.NumericControl
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker
        Me.txtMinAmtforIntrest = New BankControls.NumericControl
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtAmountPerLeaf = New BankControls.NumericControl
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtNo0fLeafs = New BankControls.NumericControl
        Me.chkMinAmtForCheque = New System.Windows.Forms.CheckBox
        Me.txtMinAmtForCheque = New BankControls.NumericControl
        Me.Label6 = New System.Windows.Forms.Label
        Me.chkMinAmount = New System.Windows.Forms.CheckBox
        Me.txtRoi = New BankControls.NumericControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtMinAmount = New BankControls.NumericControl
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtStartChequeNo = New BankControls.NumericControl
        Me.btnSaveSettings = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(84, 448)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(400, 18)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Warning ! To Be Modified Under The Guidance of Manager Only"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtMinInterestPayable)
        Me.Panel1.Controls.Add(Me.dtpToDate)
        Me.Panel1.Controls.Add(Me.dtpFromDate)
        Me.Panel1.Controls.Add(Me.txtMinAmtforIntrest)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtAmountPerLeaf)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtNo0fLeafs)
        Me.Panel1.Controls.Add(Me.chkMinAmtForCheque)
        Me.Panel1.Controls.Add(Me.txtMinAmtForCheque)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.chkMinAmount)
        Me.Panel1.Controls.Add(Me.txtRoi)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtMinAmount)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtStartChequeNo)
        Me.Panel1.Location = New System.Drawing.Point(32, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 376)
        Me.Panel1.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(36, 348)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(245, 16)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Minimum interest amount to be paid"
        '
        'txtMinInterestPayable
        '
        Me.txtMinInterestPayable.AfterDecimal = 2
        Me.txtMinInterestPayable.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMinInterestPayable.BeforeDecimal = 3
        Me.txtMinInterestPayable.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinInterestPayable.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMinInterestPayable.Location = New System.Drawing.Point(332, 344)
        Me.txtMinInterestPayable.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMinInterestPayable.MaxValue = 0
        Me.txtMinInterestPayable.MinValue = 0
        Me.txtMinInterestPayable.Name = "txtMinInterestPayable"
        Me.txtMinInterestPayable.Size = New System.Drawing.Size(132, 23)
        Me.txtMinInterestPayable.TabIndex = 12
        Me.txtMinInterestPayable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpToDate
        '
        Me.dtpToDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpToDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpToDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToDate.Location = New System.Drawing.Point(332, 72)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(132, 23)
        Me.dtpToDate.TabIndex = 3
        Me.dtpToDate.Value = New Date(2008, 10, 31, 0, 0, 0, 0)
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpFromDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpFromDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromDate.Location = New System.Drawing.Point(332, 40)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(132, 23)
        Me.dtpFromDate.TabIndex = 2
        Me.dtpFromDate.Value = New Date(2008, 10, 31, 0, 0, 0, 0)
        '
        'txtMinAmtforIntrest
        '
        Me.txtMinAmtforIntrest.AfterDecimal = 2
        Me.txtMinAmtforIntrest.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMinAmtforIntrest.BeforeDecimal = 3
        Me.txtMinAmtforIntrest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinAmtforIntrest.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMinAmtforIntrest.Location = New System.Drawing.Point(332, 104)
        Me.txtMinAmtforIntrest.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMinAmtforIntrest.MaxValue = 0
        Me.txtMinAmtforIntrest.MinValue = 0
        Me.txtMinAmtforIntrest.Name = "txtMinAmtforIntrest"
        Me.txtMinAmtforIntrest.Size = New System.Drawing.Size(132, 23)
        Me.txtMinAmtforIntrest.TabIndex = 4
        Me.txtMinAmtforIntrest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(36, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(279, 16)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Minimum Amount For Interest Calculation"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(36, 316)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 16)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Amount Per Cheque leaf"
        '
        'txtAmountPerLeaf
        '
        Me.txtAmountPerLeaf.AfterDecimal = 2
        Me.txtAmountPerLeaf.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAmountPerLeaf.BeforeDecimal = 3
        Me.txtAmountPerLeaf.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountPerLeaf.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmountPerLeaf.Location = New System.Drawing.Point(332, 312)
        Me.txtAmountPerLeaf.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAmountPerLeaf.MaxValue = 0
        Me.txtAmountPerLeaf.MinValue = 0
        Me.txtAmountPerLeaf.Name = "txtAmountPerLeaf"
        Me.txtAmountPerLeaf.Size = New System.Drawing.Size(132, 23)
        Me.txtAmountPerLeaf.TabIndex = 11
        Me.txtAmountPerLeaf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(234, 16)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Number Of Cheque leafs In a Book"
        '
        'txtNo0fLeafs
        '
        Me.txtNo0fLeafs.AfterDecimal = 2
        Me.txtNo0fLeafs.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNo0fLeafs.BeforeDecimal = 3
        Me.txtNo0fLeafs.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNo0fLeafs.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNo0fLeafs.Location = New System.Drawing.Point(332, 280)
        Me.txtNo0fLeafs.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNo0fLeafs.MaxValue = 0
        Me.txtNo0fLeafs.MinValue = 0
        Me.txtNo0fLeafs.Name = "txtNo0fLeafs"
        Me.txtNo0fLeafs.Size = New System.Drawing.Size(132, 23)
        Me.txtNo0fLeafs.TabIndex = 10
        Me.txtNo0fLeafs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkMinAmtForCheque
        '
        Me.chkMinAmtForCheque.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkMinAmtForCheque.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMinAmtForCheque.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMinAmtForCheque.Location = New System.Drawing.Point(36, 222)
        Me.chkMinAmtForCheque.Name = "chkMinAmtForCheque"
        Me.chkMinAmtForCheque.Size = New System.Drawing.Size(368, 23)
        Me.chkMinAmtForCheque.TabIndex = 8
        Me.chkMinAmtForCheque.Text = "Is Minimum Amount Should Be Locked For Cheque"
        '
        'txtMinAmtForCheque
        '
        Me.txtMinAmtForCheque.AfterDecimal = 2
        Me.txtMinAmtForCheque.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMinAmtForCheque.BeforeDecimal = 3
        Me.txtMinAmtForCheque.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinAmtForCheque.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMinAmtForCheque.Location = New System.Drawing.Point(332, 192)
        Me.txtMinAmtForCheque.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMinAmtForCheque.MaxValue = 0
        Me.txtMinAmtForCheque.MinValue = 0
        Me.txtMinAmtForCheque.Name = "txtMinAmtForCheque"
        Me.txtMinAmtForCheque.Size = New System.Drawing.Size(132, 23)
        Me.txtMinAmtForCheque.TabIndex = 7
        Me.txtMinAmtForCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 16)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Minimum Amount For Cheque"
        '
        'chkMinAmount
        '
        Me.chkMinAmount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkMinAmount.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMinAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMinAmount.Location = New System.Drawing.Point(36, 165)
        Me.chkMinAmount.Name = "chkMinAmount"
        Me.chkMinAmount.Size = New System.Drawing.Size(288, 24)
        Me.chkMinAmount.TabIndex = 6
        Me.chkMinAmount.Text = "Is Minimum Amount Should Be Locked"
        '
        'txtRoi
        '
        Me.txtRoi.AfterDecimal = 2
        Me.txtRoi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtRoi.BeforeDecimal = 2
        Me.txtRoi.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoi.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRoi.Location = New System.Drawing.Point(332, 8)
        Me.txtRoi.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRoi.MaxValue = 0
        Me.txtRoi.MinValue = 0
        Me.txtRoi.Name = "txtRoi"
        Me.txtRoi.Size = New System.Drawing.Size(132, 23)
        Me.txtRoi.TabIndex = 1
        Me.txtRoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 16)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Rate Of Interest"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Interest cal from date"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 16)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Interest cal to date"
        '
        'txtMinAmount
        '
        Me.txtMinAmount.AfterDecimal = 2
        Me.txtMinAmount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMinAmount.BeforeDecimal = 3
        Me.txtMinAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMinAmount.Location = New System.Drawing.Point(332, 136)
        Me.txtMinAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMinAmount.MaxValue = 0
        Me.txtMinAmount.MinValue = 0
        Me.txtMinAmount.Name = "txtMinAmount"
        Me.txtMinAmount.Size = New System.Drawing.Size(132, 23)
        Me.txtMinAmount.TabIndex = 5
        Me.txtMinAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 16)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Minimum Amount in account "
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 16)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Starting Cheque No"
        '
        'txtStartChequeNo
        '
        Me.txtStartChequeNo.AfterDecimal = 2
        Me.txtStartChequeNo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtStartChequeNo.BeforeDecimal = 3
        Me.txtStartChequeNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartChequeNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtStartChequeNo.Location = New System.Drawing.Point(332, 248)
        Me.txtStartChequeNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtStartChequeNo.MaxValue = 0
        Me.txtStartChequeNo.MinValue = 0
        Me.txtStartChequeNo.Name = "txtStartChequeNo"
        Me.txtStartChequeNo.Size = New System.Drawing.Size(132, 23)
        Me.txtStartChequeNo.TabIndex = 9
        Me.txtStartChequeNo.Text = "0"
        Me.txtStartChequeNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSaveSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnSaveSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSaveSettings.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveSettings.ForeColor = System.Drawing.Color.Black
        Me.btnSaveSettings.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSaveSettings.Image = CType(resources.GetObject("btnSaveSettings.Image"), System.Drawing.Image)
        Me.btnSaveSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveSettings.Location = New System.Drawing.Point(360, 392)
        Me.btnSaveSettings.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(152, 40)
        Me.btnSaveSettings.TabIndex = 14
        Me.btnSaveSettings.Text = "&Save Settings"
        Me.btnSaveSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveSettings.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(32, 392)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmSBMasterSettings
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(538, 471)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveSettings)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSBMasterSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SB Master Settings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmSBMasterSettings
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmSBMasterSettings
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmSBMasterSettings
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmSBMasterSettings)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Functions"

    Private Function fnGetSettings() As Boolean
        Dim strSql As String = "select SBroi,SBIntCalDur,SBIntCalDay,SBMinAmount,SBMinAmountLock,SBMinAmountForCheque,SBMinAmountForChequeLock,SBStartingChequeNo,SBNoofLeafs,SBAmountPerCheque,SBMinAmtforIntrest,SBMinIntereseAmount from MasterSettingstbl"
        Dim dtSettings As New DataTable
        dtSettings = fnExecuteQuery(strSql, 2)
        If dtSettings.Rows.Count > 0 Then
            txtRoi.Text = dtSettings.Rows(0).Item("SBroi")
            dtpFromDate.Value = CDate(dtSettings.Rows(0).Item("SBIntCalDur"))
            dtpToDate.Value = CDate(dtSettings.Rows(0).Item("SBIntCalDay"))
            txtMinAmount.Text = dtSettings.Rows(0).Item("SBMinAmount")
            chkMinAmount.Checked = dtSettings.Rows(0).Item("SBMinAmountLock")
            txtMinAmtForCheque.Text = dtSettings.Rows(0).Item("SBMinAmountForCheque")
            chkMinAmtForCheque.Checked = dtSettings.Rows(0).Item("SBMinAmountForChequeLock")
            txtStartChequeNo.Text = dtSettings.Rows(0).Item("SBStartingChequeNo")
            txtMinAmtforIntrest.Text = dtSettings.Rows(0).Item("SBMinAmtforIntrest")
            txtNo0fLeafs.Text = dtSettings.Rows(0).Item("SBNoofLeafs")
            txtAmountPerLeaf.Text = dtSettings.Rows(0).Item("SBAmountPerCheque")
            txtMinInterestPayable.Text = dtSettings.Rows(0).Item("SBMinIntereseAmount")
        End If

    End Function

    Private Function fnSaveSettings() As Boolean
        If objSB.fnGetInterest Then
            Dim strSql As String = "Update MasterSettingstbl Set Sbroi='" & Trim(txtRoi.Text) & "',SBIntCalDur='" & Format(dtpFromDate.Value, "yyyy-MM-dd") & "',SBIntCalDay='" & Format(dtpToDate.Value, "yyyy-MM-dd") & "',SBMinAmtforIntrest='" & Trim(txtMinAmtforIntrest.Text) & "',SBMinAmount='" & Trim(txtMinAmount.Text) & "',SBMinAmountLock='" & IIf(chkMinAmount.Checked = True, 1, 0) & "', SBMinAmountForCheque='" & Trim(txtMinAmtForCheque.Text) & "',SBMinAmountforChequeLock='" & IIf(chkMinAmtForCheque.Checked = True, 1, 0) & "',SBStartingChequeNo='" & Trim(txtStartChequeNo.Text) & "',SBNoofLeafs='" & Trim(txtNo0fLeafs.Text) & "',SBAmountPerCheque='" & Trim(txtAmountPerLeaf.Text) & "',SBMinIntereseAmount='" & Trim(txtMinInterestPayable.Text) & "' "
            If fnExecuteNonQuery(strSql) = True Then
                MsgBox("Data updated sucessFully", MsgBoxStyle.Information)
            End If
        Else
            Dim strSQl1 = "insert into MasterSettingstbl(SBRoi,SBIntCalDur,SBIntCalDay,SBMinAmount,SBMinAmountLock,SBMinAmountForCheque,SBMinAmountForChequeLock,SBStartingChequeNo,SBNoofLeafs,SBAmountPerCheque,SBMinAmtforIntrest,SBMinIntereseAmount)Values('" & Trim(txtRoi.Text) & "','" & Format(dtpFromDate.Value, "yyyy-MM-dd") & "','" & Format(dtpToDate.Value, "yyyy-MM-dd") & "','" & Trim(txtMinAmount.Text) & "','" & IIf(chkMinAmount.Checked = True, 1, 0) & "','" & Trim(txtMinAmtForCheque.Text) & "','" & IIf(chkMinAmtForCheque.Checked = True, 1, 0) & "','" & Trim(txtStartChequeNo.Text) & "','" & Trim(txtNo0fLeafs.Text) & "','" & Trim(txtAmountPerLeaf.Text) & "','" & Trim(txtMinAmtforIntrest.Text) & "','" & Trim(txtMinInterestPayable.Text) & "' ) "
            If fnExecuteNonQuery(strSQl1) = True Then
                MsgBox("Data saved sucessFully", MsgBoxStyle.Information)
            End If
        End If
    End Function

    Function fnCheck() As Boolean
        If Val(txtRoi.Text) = 0 Then
            MsgBox("Please enter the interest rate", MsgBoxStyle.Information)
            txtRoi.Focus()
            Return False
            'ElseIf Val(txtDay.Text) = 0 Then
            '    MsgBox("Please Enter The Day", MsgBoxStyle.Information)
            '    txtDay.Focus()
            '    Return False
            'ElseIf Val(txtDurationofSlab.Text) = 0 Then
            '    MsgBox("Please Enter The Slab Duration", MsgBoxStyle.Information)
            '    txtDurationofSlab.Focus()
            '    Return False

        ElseIf txtMinAmtforIntrest.Text = "" Then
            MsgBox("Please enter minimum amount for intrest calculation", MsgBoxStyle.Information)
            txtMinAmtforIntrest.Focus()
            Return False
        ElseIf txtMinAmount.Text = "" Then
            MsgBox("Please enter minimum amount", MsgBoxStyle.Information)
            txtMinAmount.Focus()
            Return False
        ElseIf txtMinAmtForCheque.Text = "" Then
            MsgBox("Please enter minimum amount for cheque book issue", MsgBoxStyle.Information)
            txtMinAmtForCheque.Focus()
            Return False
        ElseIf txtNo0fLeafs.Text = "" Then
            MsgBox("Plese enter number of cheque leaf in a cheque book", MsgBoxStyle.Information)
            txtNo0fLeafs.Focus()
            Return False
        ElseIf txtAmountPerLeaf.Text = "" Then
            MsgBox("Please enter amount per leaf", MsgBoxStyle.Information)
            txtAmountPerLeaf.Focus()
            Return False
        ElseIf txtMinInterestPayable.Text = "" Then
            MsgBox("Please enter minimum interest amount to be paid ", MsgBoxStyle.Information)
            txtMinInterestPayable.Focus()
            Return False
        Else
            Return True
        End If
    End Function

#End Region

#Region "Form Global Variables"
    Dim bolVisible As Boolean
    Dim objSB As New clsSavingsBank
#End Region

#Region " Events"

    Private Sub btnSaveSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveSettings.Click
        If fnCheck() Then
            fnSaveSettings()
        End If
    End Sub

    Private Sub frmSBMasterSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFromDate.Value = Date.Now
        dtpToDate.Value = Date.Now

        Timer1.Start()
        fnGetSettings()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If bolVisible = False Then
            Label4.Text = ""
            bolVisible = True
        Else
            Label4.Text = "Warning ! To Be Modified Under The Guidance of Manager Only"
            bolVisible = False
        End If
    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    
    
End Class
