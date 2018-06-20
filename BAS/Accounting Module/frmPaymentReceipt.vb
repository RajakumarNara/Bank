Imports System.Math
Imports System.Globalization
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmPaymentReceipt
    Inherits System.Windows.Forms.Form


#Region "Global Variables"
    Dim objGroup As New clsGroups
    Dim objLedger As New clsLedger
    Dim obj
    Dim ReceiptBalance As TextObject
    Dim objBank As New clsBank
    Dim Cinfo As CultureInfo = New CultureInfo("HI-IN")
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvPayment As System.Windows.Forms.ListView
    Friend WithEvents lvReceipt As System.Windows.Forms.ListView
    Friend WithEvents btnPrint As BankControls.NewButton
    Friend WithEvents txtReceiptTotal As BankControls.TextControl
    Friend WithEvents txtPaymentTotal As BankControls.TextControl
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NewButton1 As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentReceipt))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NewButton1 = New BankControls.NewButton
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnPrint = New BankControls.NewButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtReceiptTotal = New BankControls.TextControl
        Me.txtPaymentTotal = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lvReceipt = New System.Windows.Forms.ListView
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.lvPayment = New System.Windows.Forms.ListView
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnClose = New BankControls.NewButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NewButton1)
        Me.GroupBox1.Controls.Add(Me.dtpEndDate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpStartDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.lvReceipt)
        Me.GroupBox1.Controls.Add(Me.lvPayment)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Location = New System.Drawing.Point(-8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1016, 616)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'NewButton1
        '
        Me.NewButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.NewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton1.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.NewButton1.Image = CType(resources.GetObject("NewButton1.Image"), System.Drawing.Image)
        Me.NewButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton1.Location = New System.Drawing.Point(797, 16)
        Me.NewButton1.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.NewButton1.Name = "NewButton1"
        Me.NewButton1.Size = New System.Drawing.Size(168, 40)
        Me.NewButton1.TabIndex = 3
        Me.NewButton1.Text = "&Generate "
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpEndDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(623, 24)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(164, 23)
        Me.dtpEndDate.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(551, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "To Date :"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpStartDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(376, 24)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(157, 23)
        Me.dtpStartDate.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(288, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "From Date :"
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(24, 560)
        Me.btnPrint.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(104, 40)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "&Print"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtReceiptTotal)
        Me.GroupBox3.Controls.Add(Me.txtPaymentTotal)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 512)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(968, 40)
        Me.GroupBox3.TabIndex = 83
        Me.GroupBox3.TabStop = False
        '
        'txtReceiptTotal
        '
        Me.txtReceiptTotal.AlphaNumeric = True
        Me.txtReceiptTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtReceiptTotal.BlankSpace = False
        Me.txtReceiptTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtReceiptTotal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptTotal.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtReceiptTotal.Location = New System.Drawing.Point(344, 16)
        Me.txtReceiptTotal.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtReceiptTotal.Mandatory = False
        Me.txtReceiptTotal.MaxLength = 10
        Me.txtReceiptTotal.Name = "txtReceiptTotal"
        Me.txtReceiptTotal.ReadOnly = True
        Me.txtReceiptTotal.Size = New System.Drawing.Size(120, 16)
        Me.txtReceiptTotal.SpecialChar = True
        Me.txtReceiptTotal.TabIndex = 18
        Me.txtReceiptTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPaymentTotal
        '
        Me.txtPaymentTotal.AlphaNumeric = True
        Me.txtPaymentTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtPaymentTotal.BlankSpace = False
        Me.txtPaymentTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPaymentTotal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentTotal.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtPaymentTotal.Location = New System.Drawing.Point(832, 16)
        Me.txtPaymentTotal.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtPaymentTotal.Mandatory = False
        Me.txtPaymentTotal.MaxLength = 10
        Me.txtPaymentTotal.Name = "txtPaymentTotal"
        Me.txtPaymentTotal.ReadOnly = True
        Me.txtPaymentTotal.Size = New System.Drawing.Size(120, 16)
        Me.txtPaymentTotal.SpecialChar = True
        Me.txtPaymentTotal.TabIndex = 17
        Me.txtPaymentTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(280, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Total :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(768, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Total :"
        '
        'lvReceipt
        '
        Me.lvReceipt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvReceipt.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader5, Me.ColumnHeader11, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader7})
        Me.lvReceipt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvReceipt.FullRowSelect = True
        Me.lvReceipt.GridLines = True
        Me.lvReceipt.HideSelection = False
        Me.lvReceipt.Location = New System.Drawing.Point(16, 96)
        Me.lvReceipt.Name = "lvReceipt"
        Me.lvReceipt.Size = New System.Drawing.Size(488, 408)
        Me.lvReceipt.TabIndex = 78
        Me.lvReceipt.UseCompatibleStateImageBehavior = False
        Me.lvReceipt.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Sl No."
        Me.ColumnHeader8.Width = 35
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "GNo."
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "LNo."
        Me.ColumnHeader11.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Particulars"
        Me.ColumnHeader1.Width = 242
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Balance"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 94
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Total"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 92
        '
        'lvPayment
        '
        Me.lvPayment.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvPayment.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader6, Me.ColumnHeader12, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader9})
        Me.lvPayment.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPayment.FullRowSelect = True
        Me.lvPayment.GridLines = True
        Me.lvPayment.HideSelection = False
        Me.lvPayment.Location = New System.Drawing.Point(520, 96)
        Me.lvPayment.Name = "lvPayment"
        Me.lvPayment.Size = New System.Drawing.Size(480, 408)
        Me.lvPayment.TabIndex = 79
        Me.lvPayment.UseCompatibleStateImageBehavior = False
        Me.lvPayment.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Sl No."
        Me.ColumnHeader10.Width = 35
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "GNo."
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "LNo."
        Me.ColumnHeader12.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Particulars"
        Me.ColumnHeader3.Width = 236
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Balance"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 95
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Total"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 97
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(520, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(480, 32)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Payment"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(752, 568)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(488, 32)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Receipt"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Green
        Me.Label21.Location = New System.Drawing.Point(72, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(191, 23)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "Receipt and Payment"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmPaymentReceipt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1018, 631)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPaymentReceipt"
        Me.ShowInTaskbar = False
        Me.Text = "Receipt Payment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmPaymentReceipt
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmPaymentReceipt
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmPaymentReceipt
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmPaymentReceipt)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

    'Private Overloads Sub sbLoadExpanded()
    '    Dim dvGroups As DataView
    '    Dim dvLedgers As DataView
    '    Dim objDT As DataTable
    '    Dim intCounter As Integer = 0
    '    Dim intCountLedgers As Integer = 0
    '    Dim intSlNo As Integer = 0
    '    Dim lvItem As ListViewItem
    '    Dim dblLiabilityTotal As Double = 0S
    '    Dim dblAssetTotal As Double = 0
    '    Dim dblGroupTotal As Double = 0

    '    lvReceipt.Items.Clear()       'clear both ListView Items
    '    lvPayment.Items.Clear()

    '    If objGroup.fnGetGroupsList() Then      'Get Groups List
    '        dvGroups = New DataView(objGroup.GroupsTable, "", "OrderNo", DataViewRowState.OriginalRows)

    '        objLedger.fnGetLedgerList()         'Get Ledgers List
    '        dvLedgers = New DataView(objLedger.LedgerTable, "", "OrderNo", DataViewRowState.OriginalRows)

    '        '********* Load Liability Groups with its Ledgers **********"

    '        While intCounter < dvGroups.Count
    '            dvLedgers.RowFilter = "GroupNo=" & dvGroups.Item(intCounter).Item("GroupNo")    'Get Ledgers within the Group
    '            If dvLedgers.Count > 0 Then         'if the Group has Ledgers then only display the Group 
    '                dblGroupTotal = 0
    '                While intCountLedgers < dvLedgers.Count     'for each Ledger belongs to the Group
    '                    Dim i As Decimal
    '                    dblGroupTotal += Abs(dvLedgers.Item(intCountLedgers).Item("Payment"))
    '                    intCountLedgers += 1
    '                End While

    '                If Not dblGroupTotal = 0 Then
    '                    intSlNo += 1
    '                    lvItem = lvReceipt.Items.Add(intSlNo)
    '                    lvItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '                    lvItem.SubItems.Add(dvGroups.Item(intCounter).Item("GroupNo"))
    '                    lvItem.SubItems.Add("")
    '                    lvItem.SubItems.Add(dvGroups.Item(intCounter).Item("Name"))
    '                    intCountLedgers = 0
    '                    dblGroupTotal = 0
    '                    While intCountLedgers < dvLedgers.Count     'for each Ledger belongs to the Group
    '                        If Not dvLedgers.Item(intCountLedgers).Item("Payment") = 0 Then
    '                            lvItem = lvReceipt.Items.Add("")
    '                            lvItem.SubItems.Add("")
    '                            lvItem.SubItems.Add(dvLedgers.Item(intCountLedgers).Item("LedgerNo"))
    '                            lvItem.SubItems.Add(dvLedgers.Item(intCountLedgers).Item("Name"))
    '                            Dim i As Decimal
    '                            lvItem.SubItems.Add(Abs(dvLedgers.Item(intCountLedgers).Item("Payment")))
    '                            dblLiabilityTotal += Abs(dvLedgers.Item(intCountLedgers).Item("Payment"))
    '                            dblGroupTotal += Abs(dvLedgers.Item(intCountLedgers).Item("Payment"))
    '                        End If
    '                        intCountLedgers += 1
    '                    End While
    '                    lvItem.SubItems.Add(Format(dblGroupTotal, "0.00"))   'display Group Total
    '                End If


    '                '***** a blank line after each GroupName *****
    '                lvItem = lvReceipt.Items.Add("")
    '                lvItem.SubItems.Add("")
    '                lvItem.SubItems.Add("")
    '                lvItem.SubItems.Add("")
    '            End If
    '            intCounter += 1
    '        End While
    '        '***** a blank line after all Groups *****
    '        lvItem = lvReceipt.Items.Add("")
    '        lvItem.SubItems.Add("")
    '        lvItem.SubItems.Add("")
    '        lvItem.SubItems.Add("")
    '        '********* Completed display of Liability Groups and Ledgers***********

    '        '********** Display of Asset Groups with its Ledgers ***********
    '        intSlNo = 1
    '        intCounter = 0
    '        intCountLedgers = 0

    '        While intCounter < dvGroups.Count       'for each Asset group
    '            dvLedgers.RowFilter = "GroupNo=" & dvGroups.Item(intCounter).Item("GroupNo")    'get Ledgers belong to the Group
    '            If dvLedgers.Count > 0 Then     'if the Group has Ledgers then only display the Group 
    '                lvItem = lvPayment.Items.Add(intSlNo)
    '                lvItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '                lvItem.SubItems.Add(dvGroups.Item(intCounter).Item("GroupNo"))
    '                lvItem.SubItems.Add("")
    '                lvItem.SubItems.Add(dvGroups.Item(intCounter).Item("Name"))
    '                intCountLedgers = 0
    '                dblGroupTotal = 0
    '                While intCountLedgers < dvLedgers.Count     'for each Ledger belong to the Group
    '                    lvItem = lvPayment.Items.Add("")
    '                    lvItem.SubItems.Add("")
    '                    lvItem.SubItems.Add(dvLedgers.Item(intCountLedgers).Item("LedgerNo"))
    '                    lvItem.SubItems.Add(dvLedgers.Item(intCountLedgers).Item("Name"))
    '                    Dim d As Decimal = dvLedgers.Item(intCountLedgers).Item("Receipt")
    '                    lvItem.SubItems.Add(Abs(d))
    '                    'd = 0
    '                    dblAssetTotal += Abs(dvLedgers.Item(intCountLedgers).Item("Receipt"))
    '                    dblGroupTotal += Abs(dvLedgers.Item(intCountLedgers).Item("Receipt"))
    '                    intCountLedgers += 1
    '                End While
    '                lvItem.SubItems.Add(Format(dblGroupTotal, "0.00"))     'display Group Total

    '                '******** a blank line after each GroupName
    '                lvItem = lvPayment.Items.Add("")
    '                lvItem.SubItems.Add("")
    '                lvItem.SubItems.Add("")
    '                lvItem.SubItems.Add("")

    '                intSlNo += 1
    '            End If
    '            intCounter += 1
    '        End While
    '        '***** a blank line after all Groups *****
    '        lvItem = lvPayment.Items.Add("")
    '        lvItem.SubItems.Add("")
    '        lvItem.SubItems.Add("")
    '        lvItem.SubItems.Add("")
    '    End If

    '    '******* completed display of Asset Groups and Ledgers ********


    '    '******** Net Profit or Net Loss display *********
    '    If objLedger.fnGetLedgerDetails(42) Then
    '        objDT = objLedger.LedgerTable
    '        If objDT.Rows(0).Item("Payment") > 0 Then
    '            lvItem = lvReceipt.Items.Add("")
    '            lvItem.SubItems.Add("")
    '            lvItem.SubItems.Add("")
    '            ' lvItem.SubItems.Add("Net Profit")
    '            lvItem.SubItems.Add("")
    '            lvItem.SubItems.Add(objDT.Rows(0).Item("Payment"))
    '            dblLiabilityTotal += objDT.Rows(0).Item("Payment")
    '        ElseIf objDT.Rows(0).Item("Receipt") < 0 Then
    '            lvItem = lvPayment.Items.Add("")
    '            lvItem.SubItems.Add("")
    '            lvItem.SubItems.Add("")
    '            ' lvItem.SubItems.Add("Net Loss")
    '            lvItem.SubItems.Add("")
    '            lvItem.SubItems.Add(Abs(objDT.Rows(0).Item("Receipt")))
    '            dblAssetTotal += Abs(objDT.Rows(0).Item("Receipt"))
    '        End If
    '    End If

    '    '******* completed display of Net Profit or Loss *********

    '    '***** display Liability and Asset Totals *******
    '    txtLiabilityTotal.Text = Format(dblLiabilityTotal, "0,00.00")
    '    txtAssetTotal.Text = Format(dblAssetTotal, "0,00.00")

    'End Sub

    Private Overloads Sub sbLoadExpanded()
        Dim dvGroups As DataView
        Dim dvLedgers As DataView
        Dim objDT As DataTable
        Dim intCounter As Integer = 0
        Dim intCountLedgers As Integer = 0
        Dim intSlNo As Integer = 1
        Dim lvItem As ListViewItem
        Dim dblPaymentTotal As Double = 0
        Dim dblReceiptTotal As Double = 0
        Dim dblGroupTotal As Double = 0
        Dim dblOpeningBalanceCash As Double = 0
        Dim dblClosingBalanceCash As Double = 0
        Dim dblOpeningBalanceBank As Double = 0
        Dim dblClosingBalanceBank As Double = 0
        Dim dblClosingBalanceOfLedgerNo177 As Double = 0
        Dim dblClosingBalanceOfLedgerNo178 As Double = 0
        Dim dblOpeningBalanceOfLedgerNo177 As Double = 0
        Dim dblOpeningBalanceOfLedgerNo178 As Double = 0
        lvReceipt.Items.Clear()       'clear both ListView Items
        lvPayment.Items.Clear()

        ' If objGroup.fnGetGroupsList() Then 
        If objGroup.fnGetIEGroupsList() Then 'Get Groups List
            dvGroups = New DataView(objGroup.GroupsTable, "", "GroupNo", DataViewRowState.OriginalRows)

            objLedger.fnGetLedgerList()         'Get Ledgers List
            dvLedgers = New DataView(objLedger.LedgerTable, "LedgerNo <> 110", "LedgerNo", DataViewRowState.OriginalRows)

            '********* Load  Groups  And Ledgers with its Payment **********"

            While intCounter < dvGroups.Count
                If dvGroups.Item(intCounter).Item("GroupNo") <> 1 And dvGroups.Item(intCounter).Item("GroupNo") <> 0 And dvGroups.Item(intCounter).Item("GroupNo") <> 4 And dvGroups.Item(intCounter).Item("GroupNo") <> 10 Then

                    dvLedgers.RowFilter = "GroupNo=" & dvGroups.Item(intCounter).Item("GroupNo")    'Get Ledgers within the Group
                    If dvLedgers.Count > 0 Then         'if the Group has Ledgers then only display the Group 
                        lvItem = lvPayment.Items.Add(intSlNo)
                        lvItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                        lvItem.SubItems.Add(dvGroups.Item(intCounter).Item("GroupNo"))
                        lvItem.SubItems.Add("")
                        lvItem.SubItems.Add(dvGroups.Item(intCounter).Item("Name"))
                        intCountLedgers = 0
                        dblGroupTotal = 0
                        While intCountLedgers < dvLedgers.Count     'for each Ledger belongs to the Group
                            lvItem = lvPayment.Items.Add("")
                            lvItem.SubItems.Add("")
                            lvItem.SubItems.Add(dvLedgers.Item(intCountLedgers).Item("LedgerNo"))
                            lvItem.SubItems.Add(dvLedgers.Item(intCountLedgers).Item("Name"))
                            Dim T As Decimal = dvLedgers.Item(intCountLedgers).Item("Payment")
                            lvItem.SubItems.Add(Abs(T).ToString("N", Cinfo))
                            dblPaymentTotal += Abs(dvLedgers.Item(intCountLedgers).Item("Payment"))
                            dblGroupTotal += Abs(dvLedgers.Item(intCountLedgers).Item("Payment"))
                            intCountLedgers += 1
                        End While
                        lvItem.SubItems.Add(dblGroupTotal.ToString("N", Cinfo))   'display Group Total

                        '***** a blank line after each GroupName *****
                        lvItem = lvPayment.Items.Add("")
                        lvItem.SubItems.Add("")
                        lvItem.SubItems.Add("")
                        lvItem.SubItems.Add("")

                        intSlNo += 1
                    End If
                End If
                intCounter += 1
            End While
            '***** a blank line after all Groups *****
            lvItem = lvPayment.Items.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("")
            '********* Completed display of Payment Groups and Ledgers***********
            '***** Displaying closing balance *****

            lvItem = lvPayment.Items.Add("")
            lvItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("Closing Balance")
            lvItem.SubItems.Add("")
            If (objLedger.fnGetClosingBalanceCash(dtpEndDate.Value) And objLedger.fnGetClosingBalanceBank(dtpEndDate.Value)) Then
                dblClosingBalanceCash = Convert.ToDouble(objLedger.dtClosingBalanceCash.Rows(0).Item("Closing Balance"))



                dblClosingBalanceOfLedgerNo177 = Convert.ToDouble(objLedger.dtClosingBalanceBank.Rows(0).Item("Closing Balance"))
                lvItem = lvPayment.Items.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("Cash Balance")
                lvItem.SubItems.Add(dblClosingBalanceCash.ToString("N", Cinfo))

                objLedger.fnGetClosingBalanceBank(dtpStartDate.Value, dtpEndDate.Value, 177)
                dblClosingBalanceOfLedgerNo177 = Convert.ToDouble(objLedger.dtClosingBalanceBank1.Rows(0).Item("Closing Balance"))
                lvItem = lvPayment.Items.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add(Convert.ToString(objLedger.dtClosingBalanceBank1.Rows(0).Item("Name")))
                lvItem.SubItems.Add(dblClosingBalanceOfLedgerNo177.ToString("N", Cinfo))

                objLedger.fnGetClosingBalanceBank(dtpStartDate.Value, dtpEndDate.Value, 178)
                dblClosingBalanceOfLedgerNo178 = Convert.ToDouble(objLedger.dtClosingBalanceBank1.Rows(0).Item("Closing Balance"))
                lvItem = lvPayment.Items.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add(Convert.ToString(objLedger.dtClosingBalanceBank1.Rows(0).Item("Name")))
                lvItem.SubItems.Add(dblClosingBalanceOfLedgerNo178.ToString("N", Cinfo))

                lvItem = lvPayment.Items.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add((dblClosingBalanceCash + dblClosingBalanceOfLedgerNo177 + dblClosingBalanceOfLedgerNo178).ToString("N", Cinfo))

            End If
            '***** Completed Displaying closing balance *****

            '********** Display of Groups with its Ledgers Receipt ***********
            intSlNo = 1
            intCounter = 0
            intCountLedgers = 0

            '***** Displaying opening balance *****
            'lvItem = lvReceipt.Items.Add("")
            'lvItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            'lvItem.SubItems.Add("")
            'lvItem.SubItems.Add("")
            'lvItem.SubItems.Add("Opening Balance")
            'If (objLedger.fnGetOpeningBalanceCash(dtpStartDate.Value) And objLedger.fnGetOpeningBalanceBank(dtpStartDate.Value)) Then
            '    dblOpeningBalanceCash = Convert.ToDouble(objLedger.dtOpeningBalanceCash.Rows(0).Item("Opening Balance"))
            '    lvItem = lvReceipt.Items.Add("")
            '    lvItem.SubItems.Add("")
            '    lvItem.SubItems.Add("")
            '    lvItem.SubItems.Add("Cash Balance")
            '    lvItem.SubItems.Add(dblOpeningBalanceCash.ToString("N", Cinfo))
            If (objLedger.fnGetOpeningBalanceCash(dtpStartDate.Value)) Then
                lvItem = lvReceipt.Items.Add("")
                lvItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("Opening Cash Balance")
                dblOpeningBalanceCash = Convert.ToDouble(objLedger.dtOpeningBalanceCash.Rows(0).Item("Opening Balance"))
                lvItem.SubItems.Add(dblOpeningBalanceCash.ToString("N", Cinfo))
                lvItem.SubItems.Add(dblOpeningBalanceCash.ToString("N", Cinfo))

            End If 'included 1 brr
            lvItem = lvReceipt.Items.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("")

            If (objLedger.fnGetOpeningBalanceBank(dtpStartDate.Value)) Then
                lvItem = lvReceipt.Items.Add("")
                lvItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("Bank Transactions")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")


                objLedger.fnGetOpeningBalanceBank(dtpStartDate.Value, dtpEndDate.Value, 177)
                dblOpeningBalanceOfLedgerNo177 = Convert.ToDouble(objLedger.dtOpeningBalanceBank1.Rows(0).Item("Opening Balance"))
                lvItem = lvReceipt.Items.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add(Convert.ToString(objLedger.dtOpeningBalanceBank1.Rows(0).Item("Name")))
                lvItem.SubItems.Add(dblOpeningBalanceOfLedgerNo177.ToString("N", Cinfo))

                objLedger.fnGetOpeningBalanceBank(dtpStartDate.Value, dtpEndDate.Value, 178)
                dblOpeningBalanceOfLedgerNo178 = Convert.ToDouble(objLedger.dtOpeningBalanceBank1.Rows(0).Item("Opening Balance"))
                lvItem = lvReceipt.Items.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add(Convert.ToString(objLedger.dtOpeningBalanceBank1.Rows(0).Item("Name")))
                lvItem.SubItems.Add(dblOpeningBalanceOfLedgerNo178.ToString("N", Cinfo))

                lvItem = lvReceipt.Items.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add((dblOpeningBalanceOfLedgerNo177 + dblOpeningBalanceOfLedgerNo178).ToString("N", Cinfo))

            End If
            'till here is end if



            '*****completed Displaying opening balance *****
            While intCounter < dvGroups.Count       'for each  group
                If dvGroups.Item(intCounter).Item("GroupNo") <> 1 And dvGroups.Item(intCounter).Item("GroupNo") <> 0 And dvGroups.Item(intCounter).Item("GroupNo") <> 5 And dvGroups.Item(intCounter).Item("GroupNo") <> 10 Then
                    dvLedgers.RowFilter = "GroupNo=" & dvGroups.Item(intCounter).Item("GroupNo")    'get Ledgers belong to the Group

                    If dvLedgers.Count > 0 Then     'if the Group has Ledgers then only display the Group 
                        lvItem = lvReceipt.Items.Add(intSlNo)
                        lvItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                        lvItem.SubItems.Add(dvGroups.Item(intCounter).Item("GroupNo"))
                        lvItem.SubItems.Add("")
                        lvItem.SubItems.Add(dvGroups.Item(intCounter).Item("Name"))
                        intCountLedgers = 0
                        dblGroupTotal = 0
                        While intCountLedgers < dvLedgers.Count     'for each Ledger belong to the Group
                            lvItem = lvReceipt.Items.Add("")
                            lvItem.SubItems.Add("")
                            lvItem.SubItems.Add(dvLedgers.Item(intCountLedgers).Item("LedgerNo"))
                            lvItem.SubItems.Add(dvLedgers.Item(intCountLedgers).Item("Name"))
                            Dim d As Decimal = dvLedgers.Item(intCountLedgers).Item("Receipt")
                            lvItem.SubItems.Add(Abs(d).ToString("N", Cinfo))
                            dblReceiptTotal += Abs(dvLedgers.Item(intCountLedgers).Item("Receipt"))
                            dblGroupTotal += Abs(dvLedgers.Item(intCountLedgers).Item("Receipt"))
                            intCountLedgers += 1
                        End While
                        lvItem.SubItems.Add(dblGroupTotal.ToString("N", Cinfo))     'display Group Total

                        '******** a blank line after each GroupName
                        lvItem = lvReceipt.Items.Add("")
                        lvItem.SubItems.Add("")
                        lvItem.SubItems.Add("")
                        lvItem.SubItems.Add("")

                        intSlNo += 1
                    End If
                End If
                intCounter += 1
            End While
            '***** a blank line after all Groups *****
            lvItem = lvReceipt.Items.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("")

        End If

        '******* completed display of Groups and Ledgers ********

        '***** display Liability and Asset Totals *******
        txtPaymentTotal.Text = (dblPaymentTotal + dblClosingBalanceCash + dblClosingBalanceOfLedgerNo177 + dblClosingBalanceOfLedgerNo178).ToString("N", Cinfo)
        txtReceiptTotal.Text = (dblReceiptTotal + dblOpeningBalanceCash + dblOpeningBalanceOfLedgerNo177 + dblOpeningBalanceOfLedgerNo178).ToString("N", Cinfo)


    End Sub

    Private Sub frmPaymentReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpEndDate.Value = Convert.ToDateTime(dtpEndDate.Text)   'Date.Now
        dtpStartDate.Value = Convert.ToDateTime(dtpStartDate.Text) '' Date.Now
        Dim objDT As DataTable
        If objBank.fnGetBankDetails Then
            objDT = objBank.BankTable
            If objDT.Rows.Count > 0 Then
                dtpStartDate.Value = CDate(objDT.Rows(0).Item("FinancialStart"))
                dtpEndDate.Value = CDate(objDT.Rows(0).Item("FinancialEnd"))
            End If
        End If
    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If fnDeleteDate() Then
            FromDate = dtpStartDate.Value
            ToDate = dtpEndDate.Value
            fnInsertDate()
        End If
        Dim objReportViewer As New frmReportViewer
        Dim reportdoc As New ReportDocument

        'objReportViewer.CrystalReportViewer1.ReportSource = "C:/Program Files/Coherent/BAS/Reports/ReciptAndPayment2.rpt"
        ' objReportViewer.CrystalReportViewer1.ReportSource = "D:/BAS/Projects/Windows_Projects/BAS/16_apr_13_BAS_vasavi_removal_of_calls_inarrier_wt_Receipt_payment_rpt_change/BAS/Reports/ReciptAndPayment2.rpt"
        reportdoc.Load("C:/Program Files/Coherent/BAS/Reports/ReciptAndPayment2.rpt")
        'ReceiptBalance = CType(reportdoc.ReportDefinition.ReportObjects("ReceiptBalance"), TextObject)
        ' ReceiptBalance = reportdoc.ReportDefinition.ReportObjects.Item("ReceiptBalance")
        Dim objReceiptText As CrystalDecisions.CrystalReports.Engine.TextObject = CType(reportdoc.ReportDefinition.ReportObjects("ReceiptToal"), CrystalDecisions.CrystalReports.Engine.TextObject)
        Dim objPaymentText As CrystalDecisions.CrystalReports.Engine.TextObject = CType(reportdoc.ReportDefinition.ReportObjects("PaymentTotal"), CrystalDecisions.CrystalReports.Engine.TextObject)
        objReceiptText.Text = Convert.ToDecimal(txtReceiptTotal.Text).ToString("N", Cinfo)
        objPaymentText.Text = Convert.ToDecimal(txtReceiptTotal.Text).ToString("N", Cinfo)
        objReportViewer.CrystalReportViewer1.ReportSource = reportdoc
        ' ''Dim cryRpt As New ReportDocument()
        ' ''cryRpt.Load("C:/Program Files/Coherent/BAS/Reports/ReciptAndPayment2.rpt")
        ' ''Dim RptFromDate As New ParameterDiscreteValue()
        ' ''Dim RptToDate As New ParameterDiscreteValue()
        ' ''RptFromDate.Value = FromDate
        ' ''cryRpt.SetParameterValue("FromDate", RptFromDate.Value)
        '' ''cryRpt.SetParameterValue("FromDate1", RptFromDate.Value)
        ' ''RptToDate.Value = ToDate
        ' ''cryRpt.SetParameterValue("ToDate", RptToDate.Value)
        '' '' cryRpt.SetParameterValue("ToDate1", RptToDate.Value)
        objReportViewer.ShowDialog()
        objReportViewer = Nothing
    End Sub


    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click
        If fnDeleteDate() Then
            FromDate = dtpStartDate.Value
            ToDate = dtpEndDate.Value
            fnInsertDate()
        End If
        objLedger.fnUpdateReciptPayment(dtpStartDate.Value, dtpEndDate.Value)
        If (objLedger.fnGetOpeningBalanceCash(dtpStartDate.Value) And objLedger.fnGetOpeningBalanceBank(dtpStartDate.Value) And objLedger.fnGetClosingBalanceCash(dtpEndDate.Value) And objLedger.fnGetClosingBalanceBank(dtpEndDate.Value)) Then
            Dim OpeningBalanceCash As Decimal = Convert.ToDecimal(objLedger.dtOpeningBalanceCash.Rows(0).Item("Opening Balance"))
            Dim ClosingBalanceCash As Decimal = Convert.ToDecimal(objLedger.dtClosingBalanceCash.Rows(0).Item("Closing Balance"))
            Dim OpeningBalanceBank As Decimal = Convert.ToDecimal(objLedger.dtOpeningBalanceBank.Rows(0).Item("Opening Balance"))
            Dim ClosingBalanceBank As Decimal = Convert.ToDecimal(objLedger.dtClosingBalanceBank.Rows(0).Item("Closing Balance"))
            objLedger.fnUpdateOpeningAndClosingBalance(OpeningBalanceCash, ClosingBalanceCash, OpeningBalanceBank, ClosingBalanceBank)
        End If
        sbLoadExpanded()
    End Sub
End Class
