Public Class frmProvision
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
    Friend WithEvents Total_Amt As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtInterestdate As BankControls.TextControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnSearchFD As BankControls.NewButton
    Friend WithEvents txtRemarks As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtReceiptNo As BankControls.NumericControl
    Friend WithEvents Sl_No As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPayInterest As BankControls.NewButton
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents Int_Amt As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvInterest As System.Windows.Forms.ListView
    Friend WithEvents Int_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbSchemeType As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRDAmount As BankControls.NumericControl
    Friend WithEvents txtRDAccountNo As BankControls.TextControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProvision))
        Me.Total_Amt = New System.Windows.Forms.ColumnHeader
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtInterestdate = New BankControls.TextControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtp = New System.Windows.Forms.DateTimePicker
        Me.txtName = New BankControls.TextControl
        Me.txtRDAmount = New BankControls.NumericControl
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtRDAccountNo = New BankControls.TextControl
        Me.btnSearchFD = New BankControls.NewButton
        Me.txtRemarks = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtReceiptNo = New BankControls.NumericControl
        Me.Sl_No = New System.Windows.Forms.ColumnHeader
        Me.btnPayInterest = New BankControls.NewButton
        Me.btnClose = New BankControls.NewButton
        Me.Int_Amt = New System.Windows.Forms.ColumnHeader
        Me.lvInterest = New System.Windows.Forms.ListView
        Me.Int_Date = New System.Windows.Forms.ColumnHeader
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbSchemeType = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Total_Amt
        '
        Me.Total_Amt.Text = "Total Amount"
        Me.Total_Amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Total_Amt.Width = 146
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtInterestdate)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dtp)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.txtRDAmount)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.txtRDAccountNo)
        Me.Panel1.Controls.Add(Me.btnSearchFD)
        Me.Panel1.Controls.Add(Me.txtRemarks)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtReceiptNo)
        Me.Panel1.Location = New System.Drawing.Point(8, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(608, 176)
        Me.Panel1.TabIndex = 23
        '
        'txtInterestdate
        '
        Me.txtInterestdate.AlphaNumeric = True
        Me.txtInterestdate.BlankSpace = False
        Me.txtInterestdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterestdate.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtInterestdate.Location = New System.Drawing.Point(112, 48)
        Me.txtInterestdate.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtInterestdate.Mandatory = False
        Me.txtInterestdate.MaxLength = 10
        Me.txtInterestdate.Name = "txtInterestdate"
        Me.txtInterestdate.Size = New System.Drawing.Size(160, 23)
        Me.txtInterestdate.SpecialChar = True
        Me.txtInterestdate.TabIndex = 6
        Me.txtInterestdate.TabStop = False
        Me.txtInterestdate.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(304, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 19)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Name:"
        '
        'dtp
        '
        Me.dtp.CustomFormat = "dd / MMM / yyyy"
        Me.dtp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp.Location = New System.Drawing.Point(120, 48)
        Me.dtp.MaxDate = New Date(2754, 11, 15, 0, 0, 0, 0)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(120, 23)
        Me.dtp.TabIndex = 126
        Me.dtp.Value = New Date(2007, 10, 5, 0, 0, 0, 0)
        Me.dtp.Visible = False
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.AutoSize = False
        Me.txtName.BlankSpace = True
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(400, 16)
        Me.txtName.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(192, 24)
        Me.txtName.SpecialChar = True
        Me.txtName.TabIndex = 5
        Me.txtName.Text = ""
        '
        'txtRDAmount
        '
        Me.txtRDAmount.AfterDecimal = 2
        Me.txtRDAmount.BeforeDecimal = 8
        Me.txtRDAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRDAmount.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRDAmount.Location = New System.Drawing.Point(112, 80)
        Me.txtRDAmount.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtRDAmount.MaxLength = 10
        Me.txtRDAmount.MaxValue = 0
        Me.txtRDAmount.MinValue = 0
        Me.txtRDAmount.Name = "txtRDAmount"
        Me.txtRDAmount.Size = New System.Drawing.Size(160, 23)
        Me.txtRDAmount.TabIndex = 8
        Me.txtRDAmount.TabStop = False
        Me.txtRDAmount.Text = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(8, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 19)
        Me.Label18.TabIndex = 122
        Me.Label18.Text = "Account No. :"
        '
        'txtRDAccountNo
        '
        Me.txtRDAccountNo.AlphaNumeric = True
        Me.txtRDAccountNo.BlankSpace = False
        Me.txtRDAccountNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRDAccountNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRDAccountNo.Location = New System.Drawing.Point(112, 16)
        Me.txtRDAccountNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtRDAccountNo.Mandatory = False
        Me.txtRDAccountNo.MaxLength = 10
        Me.txtRDAccountNo.Name = "txtRDAccountNo"
        Me.txtRDAccountNo.Size = New System.Drawing.Size(128, 23)
        Me.txtRDAccountNo.SpecialChar = True
        Me.txtRDAccountNo.TabIndex = 3
        Me.txtRDAccountNo.Text = ""
        '
        'btnSearchFD
        '
        Me.btnSearchFD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchFD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchFD.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchFD.ForeColor = System.Drawing.Color.Black
        Me.btnSearchFD.GotFocusColour = System.Drawing.Color.FromArgb(CType(123, Byte), CType(202, Byte), CType(141, Byte))
        Me.btnSearchFD.Image = CType(resources.GetObject("btnSearchFD.Image"), System.Drawing.Image)
        Me.btnSearchFD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchFD.Location = New System.Drawing.Point(248, 16)
        Me.btnSearchFD.LostFocusColour = System.Drawing.Color.FromArgb(CType(176, Byte), CType(236, Byte), CType(199, Byte))
        Me.btnSearchFD.Name = "btnSearchFD"
        Me.btnSearchFD.Size = New System.Drawing.Size(24, 24)
        Me.btnSearchFD.TabIndex = 4
        '
        'txtRemarks
        '
        Me.txtRemarks.AlphaNumeric = True
        Me.txtRemarks.BlankSpace = False
        Me.txtRemarks.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRemarks.Location = New System.Drawing.Point(112, 112)
        Me.txtRemarks.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtRemarks.Mandatory = False
        Me.txtRemarks.MaxLength = 50
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(480, 48)
        Me.txtRemarks.SpecialChar = True
        Me.txtRemarks.TabIndex = 9
        Me.txtRemarks.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 19)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Remarks:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 19)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Amount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 19)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "Interest Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(304, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 19)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "Receipt No. :"
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AfterDecimal = 0
        Me.txtReceiptNo.BeforeDecimal = 7
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(400, 48)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtReceiptNo.MaxLength = 10
        Me.txtReceiptNo.MaxValue = 0
        Me.txtReceiptNo.MinValue = 0
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(136, 23)
        Me.txtReceiptNo.TabIndex = 7
        Me.txtReceiptNo.Text = ""
        Me.txtReceiptNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Sl_No
        '
        Me.Sl_No.Text = "Sl. No."
        Me.Sl_No.Width = 74
        '
        'btnPayInterest
        '
        Me.btnPayInterest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPayInterest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPayInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayInterest.ForeColor = System.Drawing.Color.Black
        Me.btnPayInterest.GotFocusColour = System.Drawing.Color.DarkSeaGreen
        Me.btnPayInterest.Image = CType(resources.GetObject("btnPayInterest.Image"), System.Drawing.Image)
        Me.btnPayInterest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayInterest.Location = New System.Drawing.Point(336, 264)
        Me.btnPayInterest.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnPayInterest.Name = "btnPayInterest"
        Me.btnPayInterest.Size = New System.Drawing.Size(128, 40)
        Me.btnPayInterest.TabIndex = 10
        Me.btnPayInterest.Text = "Make provision"
        Me.btnPayInterest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.btnClose.Location = New System.Drawing.Point(472, 264)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(144, 40)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "&Close"
        '
        'Int_Amt
        '
        Me.Int_Amt.Text = "Interest Amount"
        Me.Int_Amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Int_Amt.Width = 131
        '
        'lvInterest
        '
        Me.lvInterest.BackColor = System.Drawing.Color.White
        Me.lvInterest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvInterest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Sl_No, Me.Int_Amt, Me.Int_Date, Me.Total_Amt})
        Me.lvInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvInterest.FullRowSelect = True
        Me.lvInterest.GridLines = True
        Me.lvInterest.HideSelection = False
        Me.lvInterest.Location = New System.Drawing.Point(8, 312)
        Me.lvInterest.MultiSelect = False
        Me.lvInterest.Name = "lvInterest"
        Me.lvInterest.Size = New System.Drawing.Size(608, 200)
        Me.lvInterest.TabIndex = 12
        Me.lvInterest.View = System.Windows.Forms.View.Details
        '
        'Int_Date
        '
        Me.Int_Date.Text = "Interest Date"
        Me.Int_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Int_Date.Width = 135
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.dtpDate)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.cmbSchemeType)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Location = New System.Drawing.Point(8, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(608, 56)
        Me.Panel2.TabIndex = 27
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(400, 16)
        Me.dtpDate.MaxDate = New Date(9998, 11, 15, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpDate.TabIndex = 2
        Me.dtpDate.Value = New Date(2007, 10, 5, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(304, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 19)
        Me.Label6.TabIndex = 118
        Me.Label6.Text = "Date: "
        '
        'cmbSchemeType
        '
        Me.cmbSchemeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSchemeType.Enabled = False
        Me.cmbSchemeType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSchemeType.Location = New System.Drawing.Point(112, 16)
        Me.cmbSchemeType.Name = "cmbSchemeType"
        Me.cmbSchemeType.Size = New System.Drawing.Size(160, 24)
        Me.cmbSchemeType.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(8, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 19)
        Me.Label13.TabIndex = 122
        Me.Label13.Text = "Scheme Type:"
        '
        'frmProvision
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(206, Byte), CType(176, Byte))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(624, 519)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnPayInterest)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lvInterest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProvision"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RD Provision"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmProvision
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmProvision
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmProvision
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmProvision)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Form Global Variables"

    Dim objRDAccount As New clsRDAccount
    ' Dim objFDAccount As New clsFDAccount
    Dim objMember As New clsMember
    Dim dtInterest As New DataTable
    Public strAccNo As String
    Dim bolCumulative As Boolean = False

#End Region

#Region "Function"

    Sub sbLoadScheme()
        Dim objScheme As New clsRDAccount
        If objScheme.fnGetScheme Then
            cmbSchemeType.DataSource = objScheme.RdMasterTbl
            cmbSchemeType.DisplayMember = "SchemeName"
            cmbSchemeType.ValueMember = "SchemeCode"
            cmbSchemeType.SelectedIndex = -1
        End If
    End Sub

    Sub sbSetSchemeMaster()
        If cmbSchemeType.SelectedValue <> 0 Then
            objRDAccount.SchemeCode = cmbSchemeType.SelectedValue
            If objRDAccount.fnCheckScheme() Then
                Dim dtMasterData As DataTable = objRDAccount.RDMasterDetailTbl
                If dtMasterData.Rows(0).Item("SchemeType") = "C" Then
                    bolCumulative = True
                    objRDAccount.RDType = "C"
                Else
                    objRDAccount.RDType = "N"
                End If
            Else
                MsgBox("Load failed due to internal error", MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub

    Sub sbClear()

        txtRDAmount.ResetText()
        lvInterest.Items.Clear()
        txtInterestdate.ResetText()
        txtReceiptNo.ResetText()
        txtRemarks.ResetText()
        txtRDAmount.ReadOnly = False
        txtInterestdate.ReadOnly = False

    End Sub

    Function fnCheck() As Boolean

        If Trim(txtRDAccountNo.Text) = "" Then
            MsgBox("Please select the account no", MsgBoxStyle.Exclamation)
            txtRDAccountNo.Focus()
            Return False
        ElseIf Trim(txtRDAmount.Text) = "" Then
            MsgBox("Amount cannot be null", MsgBoxStyle.Exclamation)
            txtRDAmount.Focus()
            Return False
        ElseIf Trim(txtReceiptNo.Text) = "" Then
            MsgBox("Receiptno cannot be null", MsgBoxStyle.Exclamation)
            txtReceiptNo.Focus()
            Return False
        Else
            Return True
        End If

    End Function

    Sub LoadRDAccDetails()
        Try

            Dim objDT As DataTable
            Dim objIntTable As DataTable

            If objRDAccount.fnGetRDAccountDetails(txtRDAccountNo.Text) Then
                sbClear()
                objDT = objRDAccount.RDDetails

                txtName.Text = objDT.Rows(0).Item("Name")
                txtRDAccountNo.Text = objDT.Rows(0).Item("RDNo")
                'txtRDAccountNo.ReadOnly = True

                cmbSchemeType.SelectedValue = objDT.Rows(0).Item("RDScheme")

                If Not objRDAccount.InterestTable Is Nothing Then
                    objIntTable = objRDAccount.InterestTable
                    Dim intCounter As Integer = 0
                    Dim lvItem As ListViewItem

                    lvInterest.Columns.Add("Status", 60, HorizontalAlignment.Left)
                    lvInterest.Items.Clear()
                    If lvInterest.Columns.Count > 5 Then
                        lvInterest.Columns.RemoveAt(5)
                    End If

                    While intCounter < objIntTable.Rows.Count
                        lvItem = lvInterest.Items.Add(intCounter + 1)
                        lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("IntAmount"))
                        Dim dt As Date = Format(objIntTable.Rows(intCounter).Item("IntDate"), "dd-MMM-yyyy")
                        If DateDiff(DateInterval.Day, dt, Date.Today) > 0 Then
                            lvItem.ForeColor = Color.Blue
                        End If
                        lvItem.SubItems.Add(Format(objIntTable.Rows(intCounter).Item("IntDate"), "dd-MMM-yyyy"))
                        lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("CumuAmount"))
                        lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("Status"))
                        intCounter += 1
                    End While
                End If
                sbSetSchemeMaster()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        lngVoucherNo = fnVoucherGetNewVNo(dtpDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()

        'Transaction Entry
        If bolCumulative = False Then
            strSQL = "Update rdnoncumulativetbl set Status='Provision'  where RDNo='" & Trim(txtRDAccountNo.Text) & "' and intDate='" & Format(CDate(txtInterestdate.Text), "yyyy-MM-dd") & "'"
        Else
            strSQL = "Update rdcumulativeinttbl set Status='Provision' where RDNo='" & Trim(txtRDAccountNo.Text) & "' and intDate='" & Format(CDate(txtInterestdate.Text), "yyyy-MM-dd") & "'"
        End If
        If fnExecuteNonQuery(strSQL, objTrans) Then

            'voucher details
            fnVoucherEnterMain(lngVoucherNo, 2, txtRDAccountNo.Text, txtReceiptNo.Text, dtpDate.Value, txtRDAmount.Text, "Interest to account " & txtRDAccountNo.Text, lngSlNo, "Y", objTrans)

            'Credit accounts
            fnVoucherEnterSub(lngVoucherNo, 2, txtRDAccountNo.Text, dtpDate.Value, "Interest to account " & txtRDAccountNo.Text, "To", 14, 0, Val(txtRDAmount.Text), 2, "Y", objTrans)

            'Debit accounts 
            fnVoucherEnterSub(lngVoucherNo, 2, txtRDAccountNo.Text, dtpDate.Value, "Interest by account " & txtRDAccountNo.Text, "By", 32, Val(txtRDAmount.Text), 0, 1, "Y", objTrans)

            Return True

        End If

    End Function

#End Region

    Private Sub frmProvision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sbLoadScheme()
        dtpDate.Value = Date.Today
        LoadRDAccDetails()
    End Sub

    Private Sub btnSearchFD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchFD.Click

        If cmbSchemeType.SelectedIndex <> 0 Then
            Dim objRDAccCust As New frmRDCust
            objRDAccCust.strRDNo = String.Empty
            objRDAccCust.ShowDialog(Me)
            If objRDAccCust.strRDNo <> String.Empty Then
                txtRDAccountNo.Text = objRDAccCust.strRDNo
                LoadRDAccDetails()
            End If
            objRDAccCust.Dispose()
        Else
            MsgBox("Sccheme is not selected", MsgBoxStyle.Exclamation)
            cmbSchemeType.Focus()
        End If

    End Sub

    Private Sub lvInterest_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvInterest.DoubleClick

        If lvInterest.SelectedItems.Count > 0 Then
            If lvInterest.SelectedItems(0).SubItems(4).Text = "Due" Then

                dtp.Value = lvInterest.SelectedItems(0).SubItems(2).Text
                If DateDiff(DateInterval.DayOfYear, dtp.Value, Date.Today, FirstDayOfWeek.System) < 0 Then
                    MsgBox("Maturity date is not yet over,intrest cannot be posted", MsgBoxStyle.Exclamation, "Deposit Module")
                Else
                    txtRDAmount.Text = lvInterest.SelectedItems(0).SubItems(1).Text
                    txtInterestdate.Text = lvInterest.SelectedItems(0).SubItems(2).Text
                End If

            End If
        End If
    End Sub

    Private Sub btnPayInterest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayInterest.Click
        Dim objTrans As IDbTransaction
        Try
            If fnCheck() Then

                objTrans = fnGetTransaction()
                If fnGenerateVoucher(objTrans) Then
                    objTrans.Commit()
                    MsgBox("Interest is successfully posted to the account '" & txtRDAccountNo.Text & "'", MsgBoxStyle.Information, "Deposit Module")
                    LoadRDAccDetails()
                Else
                    MsgBox("Interest cannot be posted to the account '" & txtRDAccountNo.Text & "'", MsgBoxStyle.Information, "Deposit Module")
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try

    End Sub



End Class
