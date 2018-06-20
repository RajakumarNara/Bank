Public Class frmCAMasterSetting
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
    Friend WithEvents btnSaveSettings As BankControls.NewButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkMinAmtForCheque As System.Windows.Forms.CheckBox
    Friend WithEvents txtMinAmtForCheque As BankControls.NumericControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkMinAmount As System.Windows.Forms.CheckBox
    Friend WithEvents txtRoi As BankControls.NumericControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDay As BankControls.NumericControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDurationofSlab As BankControls.NumericControl
    Friend WithEvents txtMinAmount As BankControls.NumericControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents txtMinAmtforIntrest As BankControls.NumericControl
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAmountPerLeaf As BankControls.NumericControl
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNo0fLeafs As BankControls.NumericControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtStartChequeNo As BankControls.NumericControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCAMasterSetting))
        Me.btnSaveSettings = New BankControls.NewButton
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtAmountPerLeaf = New BankControls.NumericControl
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtNo0fLeafs = New BankControls.NumericControl
        Me.txtMinAmtforIntrest = New BankControls.NumericControl
        Me.Label10 = New System.Windows.Forms.Label
        Me.chkMinAmtForCheque = New System.Windows.Forms.CheckBox
        Me.txtMinAmtForCheque = New BankControls.NumericControl
        Me.Label6 = New System.Windows.Forms.Label
        Me.chkMinAmount = New System.Windows.Forms.CheckBox
        Me.txtRoi = New BankControls.NumericControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDay = New BankControls.NumericControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDurationofSlab = New BankControls.NumericControl
        Me.txtMinAmount = New BankControls.NumericControl
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtStartChequeNo = New BankControls.NumericControl
        Me.btnCancel = New BankControls.NewButton
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSaveSettings.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnSaveSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSaveSettings.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveSettings.ForeColor = System.Drawing.Color.Black
        Me.btnSaveSettings.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnSaveSettings.Image = CType(resources.GetObject("btnSaveSettings.Image"), System.Drawing.Image)
        Me.btnSaveSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveSettings.Location = New System.Drawing.Point(294, 376)
        Me.btnSaveSettings.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(152, 40)
        Me.btnSaveSettings.TabIndex = 45
        Me.btnSaveSettings.Text = "&Save Settings"
        Me.btnSaveSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(32, 424)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(385, 18)
        Me.Label4.TabIndex = 43
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtAmountPerLeaf)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtNo0fLeafs)
        Me.Panel1.Controls.Add(Me.txtMinAmtforIntrest)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.chkMinAmtForCheque)
        Me.Panel1.Controls.Add(Me.txtMinAmtForCheque)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.chkMinAmount)
        Me.Panel1.Controls.Add(Me.txtRoi)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtDay)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtDurationofSlab)
        Me.Panel1.Controls.Add(Me.txtMinAmount)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtStartChequeNo)
        Me.Panel1.Location = New System.Drawing.Point(14, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(432, 355)
        Me.Panel1.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(142, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 19)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Amount Per Cheque leaf"
        '
        'txtAmountPerLeaf
        '
        Me.txtAmountPerLeaf.AfterDecimal = 2
        Me.txtAmountPerLeaf.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAmountPerLeaf.BeforeDecimal = 3
        Me.txtAmountPerLeaf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountPerLeaf.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAmountPerLeaf.Location = New System.Drawing.Point(312, 320)
        Me.txtAmountPerLeaf.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAmountPerLeaf.MaxValue = 0
        Me.txtAmountPerLeaf.MinValue = 0
        Me.txtAmountPerLeaf.Name = "txtAmountPerLeaf"
        Me.txtAmountPerLeaf.Size = New System.Drawing.Size(104, 22)
        Me.txtAmountPerLeaf.TabIndex = 56
        Me.txtAmountPerLeaf.Text = ""
        Me.txtAmountPerLeaf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(71, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(239, 19)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Number Of Cheque leafs In a Book"
        '
        'txtNo0fLeafs
        '
        Me.txtNo0fLeafs.AfterDecimal = 2
        Me.txtNo0fLeafs.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNo0fLeafs.BeforeDecimal = 3
        Me.txtNo0fLeafs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNo0fLeafs.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNo0fLeafs.Location = New System.Drawing.Point(312, 288)
        Me.txtNo0fLeafs.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNo0fLeafs.MaxValue = 0
        Me.txtNo0fLeafs.MinValue = 0
        Me.txtNo0fLeafs.Name = "txtNo0fLeafs"
        Me.txtNo0fLeafs.Size = New System.Drawing.Size(104, 22)
        Me.txtNo0fLeafs.TabIndex = 54
        Me.txtNo0fLeafs.Text = "0"
        Me.txtNo0fLeafs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMinAmtforIntrest
        '
        Me.txtMinAmtforIntrest.AfterDecimal = 2
        Me.txtMinAmtforIntrest.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMinAmtforIntrest.BeforeDecimal = 3
        Me.txtMinAmtforIntrest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinAmtforIntrest.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMinAmtforIntrest.Location = New System.Drawing.Point(312, 104)
        Me.txtMinAmtforIntrest.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMinAmtforIntrest.MaxValue = 0
        Me.txtMinAmtforIntrest.MinValue = 0
        Me.txtMinAmtforIntrest.Name = "txtMinAmtforIntrest"
        Me.txtMinAmtforIntrest.Size = New System.Drawing.Size(104, 22)
        Me.txtMinAmtforIntrest.TabIndex = 52
        Me.txtMinAmtforIntrest.Text = ""
        Me.txtMinAmtforIntrest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(32, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(278, 19)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Minimum Amount For Intrest Calculation"
        '
        'chkMinAmtForCheque
        '
        Me.chkMinAmtForCheque.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkMinAmtForCheque.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMinAmtForCheque.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMinAmtForCheque.Location = New System.Drawing.Point(-18, 224)
        Me.chkMinAmtForCheque.Name = "chkMinAmtForCheque"
        Me.chkMinAmtForCheque.Size = New System.Drawing.Size(328, 16)
        Me.chkMinAmtForCheque.TabIndex = 46
        Me.chkMinAmtForCheque.Text = "Is Minimum Amount Should Be Locked For Cheque"
        '
        'txtMinAmtForCheque
        '
        Me.txtMinAmtForCheque.AfterDecimal = 2
        Me.txtMinAmtForCheque.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMinAmtForCheque.BeforeDecimal = 4
        Me.txtMinAmtForCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinAmtForCheque.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMinAmtForCheque.Location = New System.Drawing.Point(315, 192)
        Me.txtMinAmtForCheque.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMinAmtForCheque.MaxValue = 0
        Me.txtMinAmtForCheque.MinValue = 0
        Me.txtMinAmtForCheque.Name = "txtMinAmtForCheque"
        Me.txtMinAmtForCheque.Size = New System.Drawing.Size(104, 22)
        Me.txtMinAmtForCheque.TabIndex = 45
        Me.txtMinAmtForCheque.Text = ""
        Me.txtMinAmtForCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(105, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(205, 19)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Minimum Amount For Cheque"
        '
        'chkMinAmount
        '
        Me.chkMinAmount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkMinAmount.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMinAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMinAmount.Location = New System.Drawing.Point(54, 168)
        Me.chkMinAmount.Name = "chkMinAmount"
        Me.chkMinAmount.Size = New System.Drawing.Size(256, 16)
        Me.chkMinAmount.TabIndex = 41
        Me.chkMinAmount.Text = "Is Minimum Amount Should Be Locked"
        '
        'txtRoi
        '
        Me.txtRoi.AfterDecimal = 2
        Me.txtRoi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtRoi.BeforeDecimal = 2
        Me.txtRoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoi.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRoi.Location = New System.Drawing.Point(312, 8)
        Me.txtRoi.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRoi.MaxValue = 0
        Me.txtRoi.MinValue = 0
        Me.txtRoi.Name = "txtRoi"
        Me.txtRoi.Size = New System.Drawing.Size(104, 22)
        Me.txtRoi.TabIndex = 39
        Me.txtRoi.Text = ""
        Me.txtRoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(197, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 19)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Rate Of Interest"
        '
        'txtDay
        '
        Me.txtDay.AfterDecimal = 2
        Me.txtDay.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDay.BeforeDecimal = 2
        Me.txtDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDay.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtDay.Location = New System.Drawing.Point(312, 40)
        Me.txtDay.LostFocusColour = System.Drawing.Color.Empty
        Me.txtDay.MaxValue = 0
        Me.txtDay.MinValue = 0
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(104, 22)
        Me.txtDay.TabIndex = 35
        Me.txtDay.Text = ""
        Me.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 19)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "After Day of Interest Should Be Calculated"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(193, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 19)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Duration Of Slab"
        '
        'txtDurationofSlab
        '
        Me.txtDurationofSlab.AfterDecimal = 2
        Me.txtDurationofSlab.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDurationofSlab.BeforeDecimal = 2
        Me.txtDurationofSlab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDurationofSlab.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtDurationofSlab.Location = New System.Drawing.Point(312, 72)
        Me.txtDurationofSlab.LostFocusColour = System.Drawing.Color.Empty
        Me.txtDurationofSlab.MaxValue = 0
        Me.txtDurationofSlab.MinValue = 0
        Me.txtDurationofSlab.Name = "txtDurationofSlab"
        Me.txtDurationofSlab.Size = New System.Drawing.Size(104, 22)
        Me.txtDurationofSlab.TabIndex = 36
        Me.txtDurationofSlab.Text = ""
        Me.txtDurationofSlab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMinAmount
        '
        Me.txtMinAmount.AfterDecimal = 2
        Me.txtMinAmount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMinAmount.BeforeDecimal = 4
        Me.txtMinAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtMinAmount.Location = New System.Drawing.Point(312, 136)
        Me.txtMinAmount.LostFocusColour = System.Drawing.Color.Empty
        Me.txtMinAmount.MaxValue = 0
        Me.txtMinAmount.MinValue = 0
        Me.txtMinAmount.Name = "txtMinAmount"
        Me.txtMinAmount.Size = New System.Drawing.Size(104, 22)
        Me.txtMinAmount.TabIndex = 37
        Me.txtMinAmount.Text = ""
        Me.txtMinAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(186, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 19)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Minimum Amount"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(173, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 19)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Starting Cheque No"
        '
        'txtStartChequeNo
        '
        Me.txtStartChequeNo.AfterDecimal = 2
        Me.txtStartChequeNo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtStartChequeNo.BeforeDecimal = 3
        Me.txtStartChequeNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartChequeNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtStartChequeNo.Location = New System.Drawing.Point(312, 256)
        Me.txtStartChequeNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtStartChequeNo.MaxValue = 0
        Me.txtStartChequeNo.MinValue = 0
        Me.txtStartChequeNo.Name = "txtStartChequeNo"
        Me.txtStartChequeNo.Size = New System.Drawing.Size(104, 22)
        Me.txtStartChequeNo.TabIndex = 44
        Me.txtStartChequeNo.Text = "0"
        Me.txtStartChequeNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(16, 376)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 46
        Me.btnCancel.Text = "&Cancel"
        '
        'frmCAMasterSetting
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(251, Byte), CType(249, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(456, 461)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveSettings)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCAMasterSetting"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CA Master Setting"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmCAMasterSetting
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmCAMasterSetting
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmCAMasterSetting
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmCAMasterSetting)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region " Global Variable"
    Dim bolVisible As Boolean
    Dim objCA As New clsCurrentAccount
#End Region

#Region "Functions"
    Function fnCheck() As Boolean
        If Val(txtRoi.Text) = 0 Then
            MsgBox("Please enter the interest rate", MsgBoxStyle.Information)
            txtRoi.Focus()
            Return False
        ElseIf Val(txtDay.Text) = 0 Then
            MsgBox("Please enter the day", MsgBoxStyle.Information)
            txtDay.Focus()
            Return False
        ElseIf Val(txtDurationofSlab.Text) = 0 Then
            MsgBox("Please enter the slab duration", MsgBoxStyle.Information)
            txtDurationofSlab.Focus()
            Return False
        ElseIf txtAmountPerLeaf.Text = "" Then
            MsgBox("Please enter amount per leaf", MsgBoxStyle.Information)
            txtAmountPerLeaf.Focus()
            Return False
        ElseIf txtMinAmount.Text = "" Then
            MsgBox("Please enter minimum amount", MsgBoxStyle.Information)
            txtMinAmount.Focus()
            Return False
        ElseIf txtMinAmtForCheque.Text = "" Then
            MsgBox("Please enter minimum amount for cheque book issue", MsgBoxStyle.Information)
            txtMinAmtForCheque.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Function fnLoadData() As Boolean
        Dim dtSettings As DataTable
        Dim strSQL As String = "SELECT * from CAMasterSettingstbl"
        dtSettings = fnExecuteQuery(strSQL, 2)
        If dtSettings.Rows.Count > 0 Then

            txtRoi.Text = dtSettings.Rows(0).Item("CARoi")
            txtDurationofSlab.Text = dtSettings.Rows(0).Item("CAIntCalDur")
            txtDay.Text = dtSettings.Rows(0).Item("CAIntCalDay")
            txtMinAmount.Text = dtSettings.Rows(0).Item("CAMinAmount")
            chkMinAmount.Checked = dtSettings.Rows(0).Item("CAMinAmountLock")
            txtMinAmtForCheque.Text = dtSettings.Rows(0).Item("CAMinAmountForCheque")
            chkMinAmtForCheque.Checked = dtSettings.Rows(0).Item("CAMinAmountForChequeLock")
            txtMinAmtforIntrest.Text = dtSettings.Rows(0).Item("CAMinAmtforIntrest")
            txtNo0fLeafs.Text = dtSettings.Rows(0).Item("CANoofLeafs")
            txtAmountPerLeaf.Text = dtSettings.Rows(0).Item("CAAmountPerCheque")

        End If
    End Function

    Function fnSaveData() As Boolean
        ' Dim strSQL As String = "SELECT * from CAMasterSettingstbl"
        If objCA.fnGetCAMasterData Then
            strSQL = "UPDATE CAMasterSettingstbl SET CARoi='" & Trim(txtRoi.Text) & "',CAIntCalDur='" & Trim(txtDurationofSlab.Text) & "',CAIntCalDay='" & Trim(txtDay.Text) & "',CAMinAmtforIntrest='" & Trim(txtMinAmtforIntrest.Text) & "',CAMinAmount='" & Trim(txtMinAmount.Text) & "',CAMinAmountLock='" & IIf(chkMinAmount.Checked = True, 1, 0) & "', CAMinAmountForCheque='" & Trim(txtMinAmtForCheque.Text) & "',CAMinAmountforChequeLock='" & IIf(chkMinAmtForCheque.Checked = True, 1, 0) & "',CANoofLeafs='" & Trim(txtNo0fLeafs.Text) & "',CAAmountPerCheque='" & Trim(txtAmountPerLeaf.Text) & "' "
            If fnExecuteNonQuery(strSQL) = True Then
                MsgBox("Data updated sucessFully", MsgBoxStyle.Information)
            End If

        Else
            strSQL = "INSERT INTO CAMasterSettingstbl (CARoi,CAIntCalDur,CAIntCalDay,CANoofLeafs,CAAmountPerCheque,CAMinAmtforIntrest,CAMinAmount,CAMinAmountLock,CAMinAmountForCheque,CAMinAmountforChequeLock) values('" & Trim(txtRoi.Text) & "','" & Trim(txtDurationofSlab.Text) & "','" & Trim(txtDay.Text) & "','" & Trim(txtNo0fLeafs.Text) & "','" & Trim(txtAmountPerLeaf.Text) & "','" & Trim(txtMinAmtforIntrest.Text) & "' ,'" & Trim(txtMinAmount.Text) & "','" & IIf(chkMinAmount.Checked = True, 1, 0) & "', '" & Trim(txtMinAmtForCheque.Text) & "','" & IIf(chkMinAmtForCheque.Checked = True, 1, 0) & "')"
            If fnExecuteNonQuery(strSQL) = True Then
                MsgBox("Data saved sucessFully", MsgBoxStyle.Information)
            End If
        End If

    End Function

#End Region

    Private Sub frmCAMasterSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        fnLoadData()
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


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSaveSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveSettings.Click
        If fnCheck() Then
            If fnSaveData() Then
                Me.Close()
            End If
        End If
    End Sub
End Class
