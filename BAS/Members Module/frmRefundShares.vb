Public Class frmRefundShares
    Inherits System.Windows.Forms.Form

#Region "Global variables"

    Dim objMember As New clsMember
    Dim lngVoucherNo As Long
    Dim dblShareAmount As Double = 0
    Dim objLedger As New clsLedger

#End Region

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
    Friend WithEvents btnOk As BankControls.NewButton
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents grpShares As System.Windows.Forms.GroupBox
    Friend WithEvents dtpApplDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtNewNOS As BankControls.NumericControl
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtNewShareAmt As BankControls.NumericControl
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMemberNo As BankControls.TextControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNoOfShares As BankControls.TextControl
    Friend WithEvents txtShareAmount As BankControls.TextControl
    Friend WithEvents txtVoucherNo As BankControls.NumericControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRefundShares))
        Me.btnOk = New BankControls.NewButton
        Me.btnClose = New BankControls.NewButton
        Me.grpShares = New System.Windows.Forms.GroupBox
        Me.dtpApplDate = New System.Windows.Forms.DateTimePicker
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtVoucherNo = New BankControls.NumericControl
        Me.txtNewNOS = New BankControls.NumericControl
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtNewShareAmt = New BankControls.NumericControl
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtMemberNo = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSearch = New BankControls.NewButton
        Me.txtName = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNoOfShares = New BankControls.TextControl
        Me.txtShareAmount = New BankControls.TextControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.grpShares.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(432, 304)
        Me.btnOk.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(104, 40)
        Me.btnOk.TabIndex = 5
        Me.btnOk.Text = "&Save"
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(536, 304)
        Me.btnClose.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close"
        '
        'grpShares
        '
        Me.grpShares.Controls.Add(Me.dtpApplDate)
        Me.grpShares.Controls.Add(Me.Label18)
        Me.grpShares.Controls.Add(Me.Label17)
        Me.grpShares.Controls.Add(Me.txtVoucherNo)
        Me.grpShares.Controls.Add(Me.txtNewNOS)
        Me.grpShares.Controls.Add(Me.Label11)
        Me.grpShares.Controls.Add(Me.Label23)
        Me.grpShares.Controls.Add(Me.txtNewShareAmt)
        Me.grpShares.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpShares.Location = New System.Drawing.Point(8, 192)
        Me.grpShares.Name = "grpShares"
        Me.grpShares.Size = New System.Drawing.Size(672, 96)
        Me.grpShares.TabIndex = 1
        Me.grpShares.TabStop = False
        '
        'dtpApplDate
        '
        Me.dtpApplDate.CustomFormat = "dd - MMM - yyyy "
        Me.dtpApplDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpApplDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpApplDate.Location = New System.Drawing.Point(424, 24)
        Me.dtpApplDate.MaxDate = New Date(9998, 12, 23, 0, 0, 0, 0)
        Me.dtpApplDate.MinDate = New Date(1976, 1, 1, 0, 0, 0, 0)
        Me.dtpApplDate.Name = "dtpApplDate"
        Me.dtpApplDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpApplDate.TabIndex = 4
        Me.dtpApplDate.Value = New Date(2007, 9, 8, 0, 0, 0, 0)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(288, 27)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 19)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Date :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 27)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 19)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Voucher No :"
        '
        'txtVoucherNo
        '
        Me.txtVoucherNo.AfterDecimal = 2
        Me.txtVoucherNo.BackColor = System.Drawing.Color.White
        Me.txtVoucherNo.BeforeDecimal = 8
        Me.txtVoucherNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucherNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtVoucherNo.Location = New System.Drawing.Point(128, 24)
        Me.txtVoucherNo.LostFocusColour = System.Drawing.Color.White
        Me.txtVoucherNo.MaxLength = 10
        Me.txtVoucherNo.MaxValue = 0
        Me.txtVoucherNo.MinValue = 0
        Me.txtVoucherNo.Name = "txtVoucherNo"
        Me.txtVoucherNo.Size = New System.Drawing.Size(128, 23)
        Me.txtVoucherNo.TabIndex = 2
        Me.txtVoucherNo.Text = ""
        Me.txtVoucherNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNewNOS
        '
        Me.txtNewNOS.AfterDecimal = 0
        Me.txtNewNOS.BeforeDecimal = 5
        Me.txtNewNOS.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewNOS.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNewNOS.Location = New System.Drawing.Point(128, 56)
        Me.txtNewNOS.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtNewNOS.MaxLength = 5
        Me.txtNewNOS.MaxValue = 0
        Me.txtNewNOS.MinValue = 0
        Me.txtNewNOS.Name = "txtNewNOS"
        Me.txtNewNOS.Size = New System.Drawing.Size(128, 23)
        Me.txtNewNOS.TabIndex = 3
        Me.txtNewNOS.Text = ""
        Me.txtNewNOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 19)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "No of Shares :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(288, 56)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(117, 19)
        Me.Label23.TabIndex = 40
        Me.Label23.Text = "Share Amount : "
        '
        'txtNewShareAmt
        '
        Me.txtNewShareAmt.AfterDecimal = 2
        Me.txtNewShareAmt.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtNewShareAmt.BeforeDecimal = 8
        Me.txtNewShareAmt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewShareAmt.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtNewShareAmt.Location = New System.Drawing.Point(424, 56)
        Me.txtNewShareAmt.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtNewShareAmt.MaxLength = 10
        Me.txtNewShareAmt.MaxValue = 0
        Me.txtNewShareAmt.MinValue = 0
        Me.txtNewShareAmt.Name = "txtNewShareAmt"
        Me.txtNewShareAmt.ReadOnly = True
        Me.txtNewShareAmt.Size = New System.Drawing.Size(136, 23)
        Me.txtNewShareAmt.TabIndex = 4
        Me.txtNewShareAmt.TabStop = False
        Me.txtNewShareAmt.Text = ""
        Me.txtNewShareAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMemberNo)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.btnSearch)
        Me.GroupBox3.Controls.Add(Me.txtName)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(672, 64)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'txtMemberNo
        '
        Me.txtMemberNo.AlphaNumeric = True
        Me.txtMemberNo.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtMemberNo.BlankSpace = False
        Me.txtMemberNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMemberNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberNo.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtMemberNo.Location = New System.Drawing.Point(120, 24)
        Me.txtMemberNo.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtMemberNo.Mandatory = False
        Me.txtMemberNo.MaxLength = 10
        Me.txtMemberNo.Name = "txtMemberNo"
        Me.txtMemberNo.ReadOnly = True
        Me.txtMemberNo.Size = New System.Drawing.Size(128, 23)
        Me.txtMemberNo.SpecialChar = True
        Me.txtMemberNo.TabIndex = 1
        Me.txtMemberNo.TabStop = False
        Me.txtMemberNo.Text = "MB"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(336, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Name :"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(120, Byte), CType(128, Byte), CType(171, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(256, 23)
        Me.btnSearch.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.AutoSize = False
        Me.txtName.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtName.BlankSpace = True
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtName.Location = New System.Drawing.Point(424, 24)
        Me.txtName.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(232, 22)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 9
        Me.txtName.TabStop = False
        Me.txtName.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Member No. :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txtNoOfShares)
        Me.GroupBox5.Controls.Add(Me.txtShareAmount)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(8, 120)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(672, 64)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "No of Shares :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(288, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Share Amount : "
        '
        'txtNoOfShares
        '
        Me.txtNoOfShares.AlphaNumeric = True
        Me.txtNoOfShares.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtNoOfShares.BlankSpace = False
        Me.txtNoOfShares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoOfShares.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfShares.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtNoOfShares.Location = New System.Drawing.Point(128, 24)
        Me.txtNoOfShares.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtNoOfShares.Mandatory = False
        Me.txtNoOfShares.MaxLength = 10
        Me.txtNoOfShares.Name = "txtNoOfShares"
        Me.txtNoOfShares.ReadOnly = True
        Me.txtNoOfShares.Size = New System.Drawing.Size(128, 23)
        Me.txtNoOfShares.SpecialChar = True
        Me.txtNoOfShares.TabIndex = 7
        Me.txtNoOfShares.TabStop = False
        Me.txtNoOfShares.Text = ""
        Me.txtNoOfShares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtShareAmount
        '
        Me.txtShareAmount.AlphaNumeric = True
        Me.txtShareAmount.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtShareAmount.BlankSpace = False
        Me.txtShareAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShareAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShareAmount.GotFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtShareAmount.Location = New System.Drawing.Point(424, 24)
        Me.txtShareAmount.LostFocusColour = System.Drawing.Color.AntiqueWhite
        Me.txtShareAmount.Mandatory = False
        Me.txtShareAmount.MaxLength = 10
        Me.txtShareAmount.Name = "txtShareAmount"
        Me.txtShareAmount.ReadOnly = True
        Me.txtShareAmount.Size = New System.Drawing.Size(136, 23)
        Me.txtShareAmount.SpecialChar = True
        Me.txtShareAmount.TabIndex = 7
        Me.txtShareAmount.TabStop = False
        Me.txtShareAmount.Text = ""
        Me.txtShareAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label21.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(72, 8)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(133, 25)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "Refund Shares"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmRefundShares
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(698, 359)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.grpShares)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRefundShares"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Refund Shares"
        Me.grpShares.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Sub Routines and Functions"

    'To load member share details
    Sub sbLoadMember()
        Dim objDT As DataTable
        sbClear()
        If objMember.fnGetMemberDetails(txtMemberNo.Text) Then
            objDT = objMember.MemberTable
            txtMemberNo.Text = objDT.Rows(0).Item("MemberNo")
            txtName.Text = objDT.Rows(0).Item("Name")
            txtNoOfShares.Text = objDT.Rows(0).Item("NoOfShares")
            txtShareAmount.Text = objDT.Rows(0).Item("ShareAmount")
            objMember.Type = objDT.Rows(0).Item("Type")
            sbLoadMaster()
        End If
    End Sub

    Sub sbLoadMaster()
        If objMember.fnGetShareConfig Then
            dblShareAmount = objMember.SharesTable.Rows(0).Item("AmountPerShare")
        End If
    End Sub

    'To clear form control values
    Sub sbClear()
        txtNoOfShares.ResetText()
        txtShareAmount.ResetText()
        txtName.ResetText()
        txtVoucherNo.ResetText()
        txtNewNOS.ResetText()
        txtNewShareAmt.ResetText()
        'txtMemberNo.Text = "MB"
    End Sub


    Function fnCheck() As Boolean
        If txtMemberNo.Text = "MB" Then
            MsgBox("Select member ", MsgBoxStyle.Information, Me.Text)
            btnSearch.Focus()
            Return False
        ElseIf Val(txtNewNOS.Text) > Val(txtNoOfShares.Text) Then
            MsgBox("No of shares can not be greater than available shares", MsgBoxStyle.Exclamation, Me.Text)
            txtNewNOS.Focus()
            Return False
        ElseIf Val(txtNewShareAmt.Text) > Val(txtShareAmount.Text) Then
            MsgBox("Share amount can not be greater than available share amount", MsgBoxStyle.Exclamation, Me.Text)
            txtNewShareAmt.Focus()
            Return False
        ElseIf Trim(txtVoucherNo.Text) = "" Then
            MsgBox("Enter voucher no", MsgBoxStyle.Information, Me.Text)
            txtVoucherNo.Focus()
            Return False
        ElseIf Val(txtNewNOS.Text) = 0 Then
            MsgBox("Enter no of shares", MsgBoxStyle.Information, Me.Text)
            txtNewNOS.Focus()
            Return False
        ElseIf Val(txtNewShareAmt.Text) = 0 Then
            MsgBox("Enter share amount", MsgBoxStyle.Information, Me.Text)
            txtNewShareAmt.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Function fnSetData() As Boolean
        objMember.MemberNo = txtMemberNo.Text
        objMember.ShareAmount = txtNewShareAmt.Text
        objMember.ShareFee = 0
        objMember.NoOfShares = txtNewNOS.Text
        objMember.ShareDate = dtpApplDate.Value
        objMember.RefNo = txtVoucherNo.Text
        lngVoucherNo = fnVoucherGetNewVNo(dtpApplDate.Value)
        objMember.VoucherNo = lngVoucherNo
        Return True
    End Function

    Private Function fnCheckFund() As Boolean
        ''Check availabilities of cash (1 is the ledgerID)
        If (objLedger.fnGetCBalanceWRTLedger(1)) Then
            If (objLedger.LedgerTable.Rows(0).Item("Balance") > Val(txtShareAmount.Text)) Then
                Return True
            Else
                MsgBox("Insufficient fund,please chesk the cash", MsgBoxStyle.Exclamation, Me.Text)
                Return False
            End If
        End If
    End Function

    'To enter Voucher details
    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngSlNo As Long

        lngSlNo = fnVoucherGetNewSlNo()

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 1, txtMemberNo.Text, txtVoucherNo.Text, dtpApplDate.Value, txtNewShareAmt.Text, "Share Remittance by Member " & txtMemberNo.Text, lngSlNo, "Y", objTrans)

        'Credit accounts - account: cash account Ledger
        fnVoucherEnterSub(lngVoucherNo, 1, "", dtpApplDate.Value, "Share refunded to Member " & txtMemberNo.Text, "To", 1, 0, Val(txtNewShareAmt.Text), 1, "Y", objTrans)

        'Debit accounts - account: Shares from Members Ledger
        If objMember.MemberTable.Rows(0).Item("Type") = "SCA" Then
            fnVoucherEnterSub(lngVoucherNo, 1, txtMemberNo.Text, dtpApplDate.Value, "Share refunded to Member " & txtMemberNo.Text, "By", 3, Val(txtNewShareAmt.Text), 0, 2, "Y", objTrans)
        ElseIf objMember.MemberTable.Rows(0).Item("Type") = "SCB" Then
            fnVoucherEnterSub(lngVoucherNo, 1, txtMemberNo.Text, dtpApplDate.Value, "Share refunded to Member " & txtMemberNo.Text, "By", 4, Val(txtNewShareAmt.Text), 0, 2, "Y", objTrans)
        Else
            fnVoucherEnterSub(lngVoucherNo, 1, txtMemberNo.Text, dtpApplDate.Value, "Share refunded to Member " & txtMemberNo.Text, "By", 5, Val(txtNewShareAmt.Text), 0, 2, "Y", objTrans)
        End If

        Return True

    End Function


#End Region

#Region "Events"

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim objMemberSearch As New frmMemberSearch
        objMemberSearch.strMemberNo = "MB"
        objMemberSearch.ShowDialog(Me)
        If objMemberSearch.strMemberNo <> "" Then
            txtMemberNo.Text = objMemberSearch.strMemberNo
            sbLoadMember()
        Else
            txtMemberNo.Text = "MB"
            objMemberSearch.Dispose()
        End If
    End Sub

    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnSetData() Then
                    If fnCheckFund() Then
                        If objMember.fnRefundShares(objTrans) Then
                            fnGenerateVoucher(objTrans)
                            fnLogEntry(pbUserId, "Shares refunded By" & txtMemberNo.Text, Date.Now, "Member Module", objTrans)
                            objTrans.Commit()
                            If MsgBox("Shares refund successfully from the members account" & Chr(13) & Chr(13) & "You want to do another transaction?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then
                                Me.Close()
                            Else
                                sbClear()
                                txtMemberNo.Text = "MB"
                            End If
                        Else
                            MsgBox("Shares refund failed, because of internal error" & Chr(13) & "Retry again after verifying data", MsgBoxStyle.Exclamation, "Error")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            objTrans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try
    End Sub

    Private Sub frmRefundShares_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpApplDate.Value = Date.Now
        If txtMemberNo.Text <> "MB" Then
            sbLoadMember()
        End If
    End Sub

    Private Sub frmRemitShares_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.F3 Then
            btnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub txtNewNOS_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNewNOS.TextChanged
        txtNewShareAmt.Text = (Val(txtNewNOS.Text) * Val(dblShareAmount))
    End Sub

#End Region

End Class
