Imports System.IO
Imports System.Math
Public Class frmDuplicateFD
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtFDAccountNo As BankControls.TextControl
    Friend WithEvents btnSearchFD As BankControls.NewButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFDAmount As BankControls.NumericControl
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtFDROI As BankControls.NumericControl
    Friend WithEvents txtFDDays As BankControls.NumericControl
    Friend WithEvents txtFDMonths As BankControls.NumericControl
    Friend WithEvents txtFDYears As BankControls.NumericControl
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtFDIntAmount As BankControls.NumericControl
    Friend WithEvents dtpFDMatDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFDMatAmount As BankControls.NumericControl
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dtpFDDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents btnSave As BankControls.NewButton
    Friend WithEvents btnClear As BankControls.NewButton
    Friend WithEvents txtFee As BankControls.NumericControl
    Friend WithEvents picSignature As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents cmbDepositType As System.Windows.Forms.ComboBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDuplicateFD))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbDepositType = New System.Windows.Forms.ComboBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtName = New BankControls.TextControl
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtFDAccountNo = New BankControls.TextControl
        Me.btnSearchFD = New BankControls.NewButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtFDDays = New BankControls.NumericControl
        Me.txtFDMonths = New BankControls.NumericControl
        Me.txtFDYears = New BankControls.NumericControl
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtFDIntAmount = New BankControls.NumericControl
        Me.dtpFDMatDate = New System.Windows.Forms.DateTimePicker
        Me.txtFDMatAmount = New BankControls.NumericControl
        Me.txtFDAmount = New BankControls.NumericControl
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtFDROI = New BankControls.NumericControl
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.picSignature = New System.Windows.Forms.PictureBox
        Me.picPhoto = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.dtpFDDate = New System.Windows.Forms.DateTimePicker
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFee = New BankControls.NumericControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtReceiptNo = New BankControls.NumericControl
        Me.btnSave = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.btnClear = New BankControls.NewButton
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmbDepositType)
        Me.Panel1.Controls.Add(Me.Label39)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.txtFDAccountNo)
        Me.Panel1.Controls.Add(Me.btnSearchFD)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 56)
        Me.Panel1.TabIndex = 0
        '
        'cmbDepositType
        '
        Me.cmbDepositType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepositType.DropDownWidth = 120
        Me.cmbDepositType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepositType.Items.AddRange(New Object() {"FD", "ENNVY", "SCC"})
        Me.cmbDepositType.Location = New System.Drawing.Point(104, 15)
        Me.cmbDepositType.Name = "cmbDepositType"
        Me.cmbDepositType.Size = New System.Drawing.Size(104, 24)
        Me.cmbDepositType.TabIndex = 1
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(0, 15)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(99, 19)
        Me.Label39.TabIndex = 135
        Me.Label39.Text = "Deposit Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(472, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 19)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.AutoSize = False
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(528, 16)
        Me.txtName.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(232, 22)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 4
        Me.txtName.TabStop = False
        Me.txtName.Text = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(224, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 19)
        Me.Label18.TabIndex = 130
        Me.Label18.Text = "Acc No. :"
        '
        'txtFDAccountNo
        '
        Me.txtFDAccountNo.AlphaNumeric = True
        Me.txtFDAccountNo.BackColor = System.Drawing.Color.FromArgb(CType(176, Byte), CType(236, Byte), CType(199, Byte))
        Me.txtFDAccountNo.BlankSpace = False
        Me.txtFDAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDAccountNo.GotFocusColour = System.Drawing.Color.FromArgb(CType(176, Byte), CType(236, Byte), CType(199, Byte))
        Me.txtFDAccountNo.Location = New System.Drawing.Point(296, 16)
        Me.txtFDAccountNo.LostFocusColour = System.Drawing.Color.FromArgb(CType(176, Byte), CType(236, Byte), CType(199, Byte))
        Me.txtFDAccountNo.Mandatory = False
        Me.txtFDAccountNo.MaxLength = 10
        Me.txtFDAccountNo.Name = "txtFDAccountNo"
        Me.txtFDAccountNo.ReadOnly = True
        Me.txtFDAccountNo.Size = New System.Drawing.Size(128, 23)
        Me.txtFDAccountNo.SpecialChar = True
        Me.txtFDAccountNo.TabIndex = 2
        Me.txtFDAccountNo.TabStop = False
        Me.txtFDAccountNo.Text = ""
        '
        'btnSearchFD
        '
        Me.btnSearchFD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchFD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchFD.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchFD.ForeColor = System.Drawing.Color.Black
        Me.btnSearchFD.GotFocusColour = System.Drawing.Color.FromArgb(CType(231, Byte), CType(249, Byte), CType(230, Byte))
        Me.btnSearchFD.Image = CType(resources.GetObject("btnSearchFD.Image"), System.Drawing.Image)
        Me.btnSearchFD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchFD.Location = New System.Drawing.Point(432, 16)
        Me.btnSearchFD.LostFocusColour = System.Drawing.Color.FromArgb(CType(176, Byte), CType(236, Byte), CType(199, Byte))
        Me.btnSearchFD.Name = "btnSearchFD"
        Me.btnSearchFD.Size = New System.Drawing.Size(24, 24)
        Me.btnSearchFD.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFDDays)
        Me.GroupBox1.Controls.Add(Me.txtFDMonths)
        Me.GroupBox1.Controls.Add(Me.txtFDYears)
        Me.GroupBox1.Controls.Add(Me.Label38)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtFDIntAmount)
        Me.GroupBox1.Controls.Add(Me.dtpFDMatDate)
        Me.GroupBox1.Controls.Add(Me.txtFDMatAmount)
        Me.GroupBox1.Controls.Add(Me.txtFDAmount)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txtFDROI)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 104)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deposit Details"
        '
        'txtFDDays
        '
        Me.txtFDDays.AfterDecimal = 0
        Me.txtFDDays.BeforeDecimal = 3
        Me.txtFDDays.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDDays.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDDays.Location = New System.Drawing.Point(424, 32)
        Me.txtFDDays.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDDays.MaxLength = 2
        Me.txtFDDays.MaxValue = 0
        Me.txtFDDays.MinValue = 0
        Me.txtFDDays.Name = "txtFDDays"
        Me.txtFDDays.Size = New System.Drawing.Size(40, 23)
        Me.txtFDDays.TabIndex = 9
        Me.txtFDDays.Text = ""
        Me.txtFDDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFDMonths
        '
        Me.txtFDMonths.AfterDecimal = 0
        Me.txtFDMonths.BeforeDecimal = 2
        Me.txtFDMonths.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDMonths.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDMonths.Location = New System.Drawing.Point(384, 32)
        Me.txtFDMonths.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDMonths.MaxLength = 2
        Me.txtFDMonths.MaxValue = 11
        Me.txtFDMonths.MinValue = 0
        Me.txtFDMonths.Name = "txtFDMonths"
        Me.txtFDMonths.Size = New System.Drawing.Size(32, 23)
        Me.txtFDMonths.TabIndex = 8
        Me.txtFDMonths.Text = ""
        Me.txtFDMonths.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFDYears
        '
        Me.txtFDYears.AfterDecimal = 0
        Me.txtFDYears.BeforeDecimal = 2
        Me.txtFDYears.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDYears.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDYears.Location = New System.Drawing.Point(344, 32)
        Me.txtFDYears.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDYears.MaxLength = 1
        Me.txtFDYears.MaxValue = 0
        Me.txtFDYears.MinValue = 0
        Me.txtFDYears.Name = "txtFDYears"
        Me.txtFDYears.Size = New System.Drawing.Size(32, 23)
        Me.txtFDYears.TabIndex = 7
        Me.txtFDYears.Text = ""
        Me.txtFDYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(480, 72)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(104, 16)
        Me.Label38.TabIndex = 117
        Me.Label38.Text = "Maturity Amt: "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(232, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 19)
        Me.Label11.TabIndex = 116
        Me.Label11.Text = "Interest Amt : "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(480, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(117, 19)
        Me.Label16.TabIndex = 115
        Me.Label16.Text = "Maturity Date :  "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label19.Location = New System.Drawing.Point(432, 8)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(15, 19)
        Me.Label19.TabIndex = 114
        Me.Label19.Text = "D"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label20.Location = New System.Drawing.Point(400, 8)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(16, 19)
        Me.Label20.TabIndex = 113
        Me.Label20.Text = "M"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label21.Location = New System.Drawing.Point(360, 8)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(13, 19)
        Me.Label21.TabIndex = 112
        Me.Label21.Text = "Y"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(232, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 19)
        Me.Label22.TabIndex = 111
        Me.Label22.Text = "Period : "
        '
        'txtFDIntAmount
        '
        Me.txtFDIntAmount.AfterDecimal = 2
        Me.txtFDIntAmount.BeforeDecimal = 8
        Me.txtFDIntAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDIntAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDIntAmount.Location = New System.Drawing.Point(344, 72)
        Me.txtFDIntAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDIntAmount.MaxLength = 10
        Me.txtFDIntAmount.MaxValue = 0
        Me.txtFDIntAmount.MinValue = 0
        Me.txtFDIntAmount.Name = "txtFDIntAmount"
        Me.txtFDIntAmount.Size = New System.Drawing.Size(120, 23)
        Me.txtFDIntAmount.TabIndex = 12
        Me.txtFDIntAmount.Text = ""
        Me.txtFDIntAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpFDMatDate
        '
        Me.dtpFDMatDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpFDMatDate.Enabled = False
        Me.dtpFDMatDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFDMatDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFDMatDate.Location = New System.Drawing.Point(600, 32)
        Me.dtpFDMatDate.MaxDate = New Date(9998, 11, 29, 0, 0, 0, 0)
        Me.dtpFDMatDate.Name = "dtpFDMatDate"
        Me.dtpFDMatDate.Size = New System.Drawing.Size(144, 23)
        Me.dtpFDMatDate.TabIndex = 10
        Me.dtpFDMatDate.Value = New Date(2006, 11, 16, 0, 0, 0, 0)
        '
        'txtFDMatAmount
        '
        Me.txtFDMatAmount.AfterDecimal = 2
        Me.txtFDMatAmount.BackColor = System.Drawing.Color.FromArgb(CType(176, Byte), CType(236, Byte), CType(199, Byte))
        Me.txtFDMatAmount.BeforeDecimal = 8
        Me.txtFDMatAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFDMatAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDMatAmount.GotFocusColour = System.Drawing.Color.FromArgb(CType(176, Byte), CType(236, Byte), CType(199, Byte))
        Me.txtFDMatAmount.Location = New System.Drawing.Point(600, 72)
        Me.txtFDMatAmount.LostFocusColour = System.Drawing.Color.FromArgb(CType(176, Byte), CType(236, Byte), CType(199, Byte))
        Me.txtFDMatAmount.MaxLength = 10
        Me.txtFDMatAmount.MaxValue = 0
        Me.txtFDMatAmount.MinValue = 0
        Me.txtFDMatAmount.Name = "txtFDMatAmount"
        Me.txtFDMatAmount.ReadOnly = True
        Me.txtFDMatAmount.Size = New System.Drawing.Size(144, 23)
        Me.txtFDMatAmount.TabIndex = 16
        Me.txtFDMatAmount.TabStop = False
        Me.txtFDMatAmount.Text = ""
        Me.txtFDMatAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFDAmount
        '
        Me.txtFDAmount.AfterDecimal = 2
        Me.txtFDAmount.BeforeDecimal = 8
        Me.txtFDAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDAmount.Location = New System.Drawing.Point(104, 32)
        Me.txtFDAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDAmount.MaxLength = 10
        Me.txtFDAmount.MaxValue = 0
        Me.txtFDAmount.MinValue = 0
        Me.txtFDAmount.Name = "txtFDAmount"
        Me.txtFDAmount.Size = New System.Drawing.Size(120, 23)
        Me.txtFDAmount.TabIndex = 6
        Me.txtFDAmount.Text = ""
        Me.txtFDAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(16, 72)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 19)
        Me.Label17.TabIndex = 98
        Me.Label17.Text = "ROI :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(16, 32)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 19)
        Me.Label23.TabIndex = 97
        Me.Label23.Text = "Amount :"
        '
        'txtFDROI
        '
        Me.txtFDROI.AfterDecimal = 2
        Me.txtFDROI.BeforeDecimal = 8
        Me.txtFDROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDROI.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFDROI.Location = New System.Drawing.Point(104, 72)
        Me.txtFDROI.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFDROI.MaxLength = 10
        Me.txtFDROI.MaxValue = 0
        Me.txtFDROI.MinValue = 0
        Me.txtFDROI.Name = "txtFDROI"
        Me.txtFDROI.Size = New System.Drawing.Size(120, 23)
        Me.txtFDROI.TabIndex = 11
        Me.txtFDROI.Text = ""
        Me.txtFDROI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.picSignature)
        Me.GroupBox2.Controls.Add(Me.picPhoto)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(496, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 168)
        Me.GroupBox2.TabIndex = 132
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Verify"
        '
        'picSignature
        '
        Me.picSignature.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSignature.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSignature.Location = New System.Drawing.Point(32, 113)
        Me.picSignature.Name = "picSignature"
        Me.picSignature.Size = New System.Drawing.Size(192, 48)
        Me.picSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSignature.TabIndex = 51
        Me.picSignature.TabStop = False
        '
        'picPhoto
        '
        Me.picPhoto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picPhoto.Location = New System.Drawing.Point(80, 17)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(96, 88)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 50
        Me.picPhoto.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.dtpFDDate)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtFee)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtReceiptNo)
        Me.Panel2.Location = New System.Drawing.Point(8, 192)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(456, 96)
        Me.Panel2.TabIndex = 13
        '
        'dtpFDDate
        '
        Me.dtpFDDate.CustomFormat = "dd -MMM- yyyy"
        Me.dtpFDDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFDDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFDDate.Location = New System.Drawing.Point(112, 16)
        Me.dtpFDDate.MaxDate = New Date(9998, 11, 24, 0, 0, 0, 0)
        Me.dtpFDDate.Name = "dtpFDDate"
        Me.dtpFDDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpFDDate.TabIndex = 14
        Me.dtpFDDate.Value = New Date(2007, 9, 27, 0, 0, 0, 0)
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(16, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(47, 19)
        Me.Label24.TabIndex = 144
        Me.Label24.Text = "Date :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(280, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 19)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Fee :"
        '
        'txtFee
        '
        Me.txtFee.AfterDecimal = 0
        Me.txtFee.BeforeDecimal = 8
        Me.txtFee.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFee.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtFee.Location = New System.Drawing.Point(328, 16)
        Me.txtFee.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtFee.MaxLength = 10
        Me.txtFee.MaxValue = 0
        Me.txtFee.MinValue = 0
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(72, 23)
        Me.txtFee.TabIndex = 15
        Me.txtFee.Text = ""
        Me.txtFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 19)
        Me.Label3.TabIndex = 141
        Me.Label3.Text = "Receipt No :"
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
        Me.txtReceiptNo.TabIndex = 16
        Me.txtReceiptNo.Text = ""
        Me.txtReceiptNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.GotFocusColour = System.Drawing.Color.FromArgb(CType(231, Byte), CType(249, Byte), CType(230, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(232, 320)
        Me.btnSave.LostFocusColour = System.Drawing.Color.FromArgb(CType(176, Byte), CType(236, Byte), CType(199, Byte))
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 40)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Generate Duplicate"
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(352, 320)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(176, Byte), CType(236, Byte), CType(199, Byte))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 40)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "&Close"
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.GotFocusColour = System.Drawing.Color.FromArgb(CType(231, Byte), CType(249, Byte), CType(230, Byte))
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(8, 320)
        Me.btnClear.LostFocusColour = System.Drawing.Color.FromArgb(CType(176, Byte), CType(236, Byte), CType(199, Byte))
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 40)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "&Reset"
        '
        'frmDuplicateFD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(176, Byte), CType(236, Byte), CType(199, Byte))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(786, 375)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDuplicateFD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Duplicate Deposit"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmDuplicateFD
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmDuplicateFD
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmDuplicateFD
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmDuplicateFD)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Variables"

    Dim objClsFDAcc As New clsFDAccount

#End Region

#Region "Function"

    Public Function fnClear()

        txtName.Text = String.Empty
        txtFDAmount.Text = String.Empty
        txtFDDays.Text = String.Empty
        txtFDMonths.Text = String.Empty
        txtFDYears.Text = String.Empty
        txtFDIntAmount.Text = String.Empty
        txtFDMatAmount.Text = String.Empty
        txtFee.Text = String.Empty
        cmbDepositType.SelectedIndex = -1
        txtFDAccountNo.Text = String.Empty

    End Function

    Public Function fnSetData() As Boolean

        objClsFDAcc.FDNo = txtFDAccountNo.Text
        objClsFDAcc.FDDuplicateDate = dtpFDDate.Value
        objClsFDAcc.FDDuplicateFee = txtFDAmount.Text
        objClsFDAcc.ReceiptNo = txtReceiptNo.Text

        Return True

    End Function

    Public Function fnGenerateReport()

        Dim objReportViewer As New frmReportViewer
        objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/FDBondKan.rpt"
        objReportViewer.CrystalReportViewer1.SelectionFormula = "{FDDetailsTbl.FDNo} = '" & txtFDAccountNo.Text & "'"
        objReportViewer.ShowDialog()
        objReportViewer.Dispose()

    End Function

    'To enter Voucher details
    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(dtpFDDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, txtFDAccountNo.Text, txtReceiptNo.Text, dtpFDDate.Value, txtFDAmount.Text, "Duplicate bond charges by account " & txtFDAccountNo.Text, lngSlNo, "Y", objTrans)

        'Credit accounts - Fixed Deposit account
        fnVoucherEnterSub(lngVoucherNo, 2, txtFDAccountNo.Text, dtpFDDate.Value, "Duplicate bond charges by account " & txtFDAccountNo.Text, "To", 1, Val(txtFee.Text), 0, 1, "Y", objTrans)

        'Debit accounts - Cash account
        fnVoucherEnterSub(lngVoucherNo, 2, "", dtpFDDate.Value, "Duplicate bond charges by account " & txtFDAccountNo.Text, "By", 13, 0, Val(txtFee.Text), 2, "Y", objTrans)

        Return True

    End Function

    Public Function fnCheck() As Boolean
        If cmbDepositType.SelectedIndex = -1 Then
            MsgBox("Select deposit type", MsgBoxStyle.Information)
            cmbDepositType.Focus()
            Return False
        ElseIf txtFDAccountNo.Text = String.Empty Or txtFDAccountNo.Text = "FD" Or txtFDAccountNo.Text = "ENNVY" Or txtFDAccountNo.Text = "SCC" Then
            MsgBox("Enter correct account no.", MsgBoxStyle.Exclamation, " Deposit Module")
            txtFDAccountNo.Focus()
            Return False
        ElseIf Val(txtFDAmount.Text) = 0 Then
            MsgBox("Amount cannot be zero", MsgBoxStyle.Exclamation, "Deposit Module")
            txtFDAmount.Focus()
            Return False
        ElseIf txtFee.Text = String.Empty Then
            MsgBox("Fee field cannot be blank", MsgBoxStyle.Exclamation, " Deposit Module")
            txtFee.Focus()
            Return False
        ElseIf txtReceiptNo.Text = String.Empty Then
            MsgBox("Please enter receipt no.", MsgBoxStyle.Exclamation, "Deposit Module")
            txtReceiptNo.Focus()
            Return False
        Else
            Return True
        End If

    End Function


#End Region

#Region "Procedure"

    Sub sbLoadFD()
        If Trim(txtFDAccountNo.Text) <> "FD" Or txtFDAccountNo.Text <> "ENNVY" Or txtFDAccountNo.Text <> "SCC" Then
            If objClsFDAcc.fnGetFDRenewalDet(txtFDAccountNo.Text) Then

                txtFDROI.Text = objClsFDAcc.FDDetailstbl.Rows(0).Item("FDRoi")
                txtName.Text = objClsFDAcc.FDDetailstbl.Rows(0).Item("Name")
                txtFDAmount.Text = objClsFDAcc.FDDetailstbl.Rows(0).Item("FDAmount")
                txtFDDays.Text = objClsFDAcc.FDDetailstbl.Rows(0).Item("Years")
                txtFDMonths.Text = objClsFDAcc.FDDetailstbl.Rows(0).Item("Months")
                txtFDYears.Text = objClsFDAcc.FDDetailstbl.Rows(0).Item("Years")
                txtFDMatAmount.Text = objClsFDAcc.FDDetailstbl.Rows(0).Item("MatAmount")
                txtFDIntAmount.Text = objClsFDAcc.FDDetailstbl.Rows(0).Item("IntAmount")
                sbloadPhotos()
            End If

        End If
        

    End Sub

    Sub sbloadPhotos()

        Dim objDT As DataTable
        Dim msStream As MemoryStream
        Try
            If objClsFDAcc.fnGetFDRenewalDet(txtFDAccountNo.Text) Then
                objDT = objClsFDAcc.FDDetailstbl
                If Not IsDBNull(objDT.Rows(0).Item("Photo")) Then
                    If objDT.Rows(0).Item("Photo").length > 0 Then
                        msStream = New MemoryStream(objDT.Rows(0).Item("Photo"), True)
                        msStream.Write(objDT.Rows(0).Item("Photo"), 0, objDT.Rows(0).Item("Photo").length)
                        picPhoto.Image = Image.FromStream(msStream)
                        picPhoto.SizeMode = PictureBoxSizeMode.StretchImage
                        msStream.Close()
                    End If
                End If

                If Not IsDBNull(objDT.Rows(0).Item("Signature")) Then
                    If objDT.Rows(0).Item("Signature").length > 0 Then
                        msStream = New MemoryStream(objDT.Rows(0).Item("Signature"), True)
                        msStream.Write(objDT.Rows(0).Item("Signature"), 0, objDT.Rows(0).Item("Signature").length)
                        picSignature.Image = Image.FromStream(msStream)
                        picSignature.SizeMode = PictureBoxSizeMode.StretchImage
                        msStream.Close()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try

    End Sub

#End Region

#Region "Events"

    Private Sub btnSearchFD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchFD.Click

        If cmbDepositType.SelectedIndex <> -1 Then
            Dim objFDSearch As New frmFDSearch
            objFDSearch.strFDType = Trim(cmbDepositType.SelectedItem)
            objFDSearch.strFDNo = ""
            objFDSearch.ShowDialog(Me)
            If objFDSearch.strFDNo <> "" Then
                txtFDAccountNo.Text = objFDSearch.strFDNo
                sbLoadFD()
                txtFDAccountNo.Focus()
                txtName.Focus()
            End If
            objFDSearch.Dispose()
        Else
            MsgBox("Select deposit type", MsgBoxStyle.Information)
            cmbDepositType.Focus()
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        fnClear()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim objTrans As IDbTransaction

        If fnCheck() Then
            If fnSetData() Then
                Try
                    objTrans = fnGetTransaction()
                    If objClsFDAcc.fnDuplicateFD(objTrans) Then
                        If fnGenerateVoucher(objTrans) Then
                            ' fnGenerateReport()
                            objTrans.Commit()
                            MsgBox("Transaction compleated successfully", MsgBoxStyle.Information, "Deposit Moduel")
                            fnLogEntry(pbUserId, "Duplicate bond issued by " & txtFDAccountNo.Text & " Amount " & txtFee.Text, Date.Now, "Transaction transfer", objTrans)
                            btnClear_Click(sender, e)
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                Finally
                    objTrans.Dispose()
                End Try
              
            End If
        End If

    End Sub

    Private Sub colDepositType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepositType.SelectedIndexChanged
        Select Case cmbDepositType.SelectedItem

            Case "FD"
                txtFDAccountNo.Text = "FD"

            Case "ENNVY"
                txtFDAccountNo.Text = "ENNVY"

            Case "SCC"
                txtFDAccountNo.Text = "SCC"

        End Select
    End Sub
#End Region

    Private Sub frmDuplicateFD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbDepositType.SelectedIndex = -1
        dtpFDDate.MaxDate = Date.Now
        dtpFDDate.Value = Date.Now
    End Sub

    Private Sub txtFDAccountNo_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFDAccountNo.TextChanged
        Select Case cmbDepositType.SelectedItem
            Case "FD"
                If txtFDAccountNo.Text.StartsWith("FD") = False Then
                    txtFDAccountNo.Undo()
                    txtFDAccountNo.ClearUndo()
                End If
            Case "ENNVY"
                If txtFDAccountNo.Text.StartsWith("ENNVY") = False Then
                    txtFDAccountNo.Undo()
                    txtFDAccountNo.ClearUndo()
                End If
            Case "SCC"
                If txtFDAccountNo.Text.StartsWith("SCC") = False Then
                    txtFDAccountNo.Undo()
                    txtFDAccountNo.ClearUndo()
                End If
        End Select
    End Sub

End Class
