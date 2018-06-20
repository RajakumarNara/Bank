Imports System.Math
Imports System.Globalization
Public Class IncomeExpinditure
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
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrint As BankControls.NewButton
    Friend WithEvents btnMode As BankControls.NewButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtExpTotal As BankControls.TextControl
    Friend WithEvents txtIncomeTotal As BankControls.TextControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClose As BankControls.NewButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lvExpenditure As System.Windows.Forms.ListView
    Friend WithEvents lvIncome As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtpStartDate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEndDate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IncomeExpinditure))
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPrint = New BankControls.NewButton()
        Me.btnMode = New BankControls.NewButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtExpTotal = New BankControls.TextControl()
        Me.txtIncomeTotal = New BankControls.TextControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClose = New BankControls.NewButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lvExpenditure = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvIncome = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtpStartDate1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpEndDate1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Total"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader12.Width = 101
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "GNo."
        Me.ColumnHeader1.Width = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.dtpEndDate1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpStartDate1)
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.btnMode)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lvExpenditure)
        Me.GroupBox1.Controls.Add(Me.lvIncome)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 616)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
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
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "&Print"
        '
        'btnMode
        '
        Me.btnMode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMode.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMode.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMode.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnMode.Image = CType(resources.GetObject("btnMode.Image"), System.Drawing.Image)
        Me.btnMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMode.Location = New System.Drawing.Point(144, 560)
        Me.btnMode.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnMode.Name = "btnMode"
        Me.btnMode.Size = New System.Drawing.Size(104, 40)
        Me.btnMode.TabIndex = 79
        Me.btnMode.Text = "Compact"
        Me.btnMode.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtExpTotal)
        Me.GroupBox3.Controls.Add(Me.txtIncomeTotal)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 512)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(968, 40)
        Me.GroupBox3.TabIndex = 78
        Me.GroupBox3.TabStop = False
        '
        'txtExpTotal
        '
        Me.txtExpTotal.AlphaNumeric = True
        Me.txtExpTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtExpTotal.BlankSpace = False
        Me.txtExpTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtExpTotal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpTotal.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtExpTotal.Location = New System.Drawing.Point(328, 16)
        Me.txtExpTotal.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtExpTotal.Mandatory = False
        Me.txtExpTotal.MaxLength = 10
        Me.txtExpTotal.Name = "txtExpTotal"
        Me.txtExpTotal.ReadOnly = True
        Me.txtExpTotal.Size = New System.Drawing.Size(128, 16)
        Me.txtExpTotal.SpecialChar = True
        Me.txtExpTotal.TabIndex = 18
        Me.txtExpTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIncomeTotal
        '
        Me.txtIncomeTotal.AlphaNumeric = True
        Me.txtIncomeTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtIncomeTotal.BlankSpace = False
        Me.txtIncomeTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIncomeTotal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncomeTotal.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtIncomeTotal.Location = New System.Drawing.Point(832, 16)
        Me.txtIncomeTotal.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtIncomeTotal.Mandatory = False
        Me.txtIncomeTotal.MaxLength = 10
        Me.txtIncomeTotal.Name = "txtIncomeTotal"
        Me.txtIncomeTotal.ReadOnly = True
        Me.txtIncomeTotal.Size = New System.Drawing.Size(112, 16)
        Me.txtIncomeTotal.SpecialChar = True
        Me.txtIncomeTotal.TabIndex = 17
        Me.txtIncomeTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(272, 15)
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
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(872, 560)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "&Close"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(16, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(480, 32)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Expenditure"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lvExpenditure
        '
        Me.lvExpenditure.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvExpenditure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvExpenditure.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader1, Me.ColumnHeader8, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader9})
        Me.lvExpenditure.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvExpenditure.FullRowSelect = True
        Me.lvExpenditure.GridLines = True
        Me.lvExpenditure.Location = New System.Drawing.Point(16, 96)
        Me.lvExpenditure.Name = "lvExpenditure"
        Me.lvExpenditure.Size = New System.Drawing.Size(480, 408)
        Me.lvExpenditure.TabIndex = 7
        Me.lvExpenditure.UseCompatibleStateImageBehavior = False
        Me.lvExpenditure.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Sl No."
        Me.ColumnHeader7.Width = 37
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "LNo."
        Me.ColumnHeader8.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Particulars"
        Me.ColumnHeader2.Width = 229
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Balance"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 95
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Total"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 103
        '
        'lvIncome
        '
        Me.lvIncome.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvIncome.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader4, Me.ColumnHeader11, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader12})
        Me.lvIncome.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvIncome.FullRowSelect = True
        Me.lvIncome.GridLines = True
        Me.lvIncome.Location = New System.Drawing.Point(504, 96)
        Me.lvIncome.Name = "lvIncome"
        Me.lvIncome.Size = New System.Drawing.Size(480, 408)
        Me.lvIncome.TabIndex = 8
        Me.lvIncome.UseCompatibleStateImageBehavior = False
        Me.lvIncome.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Sl No."
        Me.ColumnHeader10.Width = 34
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "GNo."
        Me.ColumnHeader4.Width = 0
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "LNo."
        Me.ColumnHeader11.Width = 0
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Particulars"
        Me.ColumnHeader5.Width = 228
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Balance"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 101
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(504, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(480, 32)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Income"
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
        Me.Label21.Size = New System.Drawing.Size(220, 23)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "Income and Expenditure"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpStartDate1
        '
        Me.dtpStartDate1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate1.Location = New System.Drawing.Point(388, 25)
        Me.dtpStartDate1.Name = "dtpStartDate1"
        Me.dtpStartDate1.Size = New System.Drawing.Size(128, 23)
        Me.dtpStartDate1.TabIndex = 80
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(298, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "From Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(556, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "To Date"
        '
        'dtpEndDate1
        '
        Me.dtpEndDate1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate1.Location = New System.Drawing.Point(625, 25)
        Me.dtpEndDate1.Name = "dtpEndDate1"
        Me.dtpEndDate1.Size = New System.Drawing.Size(124, 23)
        Me.dtpEndDate1.TabIndex = 83
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(787, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 40)
        Me.Button1.TabIndex = 84
        Me.Button1.Text = "Genarate Income and Expenditure"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IncomeExpienditure
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 16)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1018, 631)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "IncomeExpienditure"
        Me.ShowInTaskbar = False
        Me.Text = "Income Expienditure"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim objGroup As New clsGroups
    Dim objLedger As New clsLedger
    Dim dblIncome As Double = 0
    Dim dblExpenditure As Double = 0
    Public dtpStartDate As Date
    Public dtpEndDate As Date
    Public bolFromBalanceSheet = False
    Dim objBank As New clsBank
    Dim CInfo As CultureInfo = New CultureInfo("HI-IN")



#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As IncomeExpinditure
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As IncomeExpinditure
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New IncomeExpinditure
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As IncomeExpinditure)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

    Sub sbLoadCompact()
        Dim objDV As DataView
        Dim objDT As DataTable
        Dim intCounter As Integer = 0
        Dim lvItem As ListViewItem
        Dim dblExpTotal As Double = 0
        Dim dblIncomeTotal As Double = 0

        lvExpenditure.Items.Clear()
        lvIncome.Items.Clear()

        If objGroup.fnGetSubGroups(0) Then
            objDV = New DataView(objGroup.GroupsTable, "", "GroupNo", DataViewRowState.OriginalRows)

            objDV.RowFilter = "Nature='E'"
            While intCounter < objDV.Count
                lvItem = lvExpenditure.Items.Add(intCounter + 1)
                lvItem.SubItems.Add(objDV.Item(intCounter).Item("GroupNo"))
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add(objDV.Item(intCounter).Item("Name"))
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add(Abs(objDV.Item(intCounter).Item("CurrentBalance")))
                dblExpTotal += Abs(objDV.Item(intCounter).Item("CurrentBalance"))
                intCounter += 1
            End While
            lvItem = lvExpenditure.Items.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("")

            intCounter = 0
            objDV.RowFilter = "Nature='I'"
            While intCounter < objDV.Count
                lvItem = lvIncome.Items.Add(intCounter + 1)
                lvItem.SubItems.Add(objDV.Item(intCounter).Item("GroupNo"))
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add(objDV.Item(intCounter).Item("Name"))
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add(Abs(objDV.Item(intCounter).Item("CurrentBalance")))
                dblIncomeTotal += Abs(objDV.Item(intCounter).Item("CurrentBalance"))
                intCounter += 1
            End While
            lvItem = lvIncome.Items.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("")

        End If

        If objLedger.fnGetLedgerDetails(42) Then
            objDT = objLedger.LedgerTable
            If objDT.Rows(0).Item("CurrentBalance") > 0 Then
                lvItem = lvExpenditure.Items.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("Net Profit")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add(Abs(objDT.Rows(0).Item("CurrentBalance")))
                dblExpTotal += Abs(objDT.Rows(0).Item("CurrentBalance"))
            ElseIf objDT.Rows(0).Item("CurrentBalance") < 0 Then
                lvItem = lvIncome.Items.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("Net Loss")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add(Abs(objDT.Rows(0).Item("CurrentBalance")))
                dblIncomeTotal += Abs(objDT.Rows(0).Item("CurrentBalance"))
            End If
        End If

        txtExpTotal.Text = Format(dblExpTotal, "0,00.00")
        txtIncomeTotal.Text = Format(dblIncomeTotal, "0,00.00")

    End Sub

    Private Overloads Sub sbLoadExpanded()
        Dim dvGroups As DataView
        Dim dvLedgers As DataView
        Dim objDT As DataTable
        Dim intCounter As Integer = 0
        Dim intCountLedgers As Integer = 0
        Dim intSlNo As Integer = 1
        Dim lvItem As ListViewItem
        Dim dblExpTotal As Double = 0
        Dim dblIncomeTotal As Double = 0
        Dim dblGroupTotal As Double = 0

        lvExpenditure.Items.Clear()       'clear both ListView Items
        lvIncome.Items.Clear()

        If objGroup.fnGetIEGroupsList() Then      'Get Groups List
            dvGroups = New DataView(objGroup.GroupsTable, "", "GroupNo", DataViewRowState.OriginalRows)

            objLedger.fnGetLedgerList()         'Get Ledgers List
            dvLedgers = New DataView(objLedger.LedgerTable, "", "LedgerNo", DataViewRowState.OriginalRows)



            '********* Load Expenditure Groups with its Ledgers **********"

            dvGroups.RowFilter = "Nature='E'"       'Get Expenditure Groups
            While intCounter < dvGroups.Count       'for each Expenditure group
                dvLedgers.RowFilter = "GroupNo=" & dvGroups.Item(intCounter).Item("GroupNo")    'Get Ledgers within the Group
                If dvLedgers.Count > 0 Then         'if the Group has Ledgers then only display the Group 
                    lvItem = lvExpenditure.Items.Add(intSlNo)
                    lvItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    lvItem.SubItems.Add(dvGroups.Item(intCounter).Item("GroupNo"))
                    lvItem.SubItems.Add("")
                    lvItem.SubItems.Add(dvGroups.Item(intCounter).Item("Name"))
                    intCountLedgers = 0
                    dblGroupTotal = 0
                    While intCountLedgers < dvLedgers.Count     'for each Ledger belongs to the Group
                        lvItem = lvExpenditure.Items.Add("")
                        lvItem.SubItems.Add("")
                        lvItem.SubItems.Add(dvLedgers.Item(intCountLedgers).Item("LedgerNo"))
                        lvItem.SubItems.Add(dvLedgers.Item(intCountLedgers).Item("Name"))
                        Dim CurrentBalance As Decimal = Format(Abs(dvLedgers.Item(intCountLedgers).Item("CurrentBalance")), "0,00.00")
                        lvItem.SubItems.Add(CurrentBalance.ToString("N", CInfo))
                        dblExpTotal += Abs(dvLedgers.Item(intCountLedgers).Item("CurrentBalance"))
                        dblGroupTotal += Abs(dvLedgers.Item(intCountLedgers).Item("CurrentBalance"))
                        intCountLedgers += 1
                    End While
                    lvItem.SubItems.Add(dblGroupTotal.ToString("N", CInfo))  'display Group Total

                    '***** a blank line after each GroupName *****
                    lvItem = lvExpenditure.Items.Add("")
                    lvItem.SubItems.Add("")
                    lvItem.SubItems.Add("")
                    lvItem.SubItems.Add("")

                    intSlNo += 1
                End If
                intCounter += 1
            End While
            '***** a blank line after all Groups *****
            lvItem = lvExpenditure.Items.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("")
            '********* Completed display of Expenditure Groups and Ledgers***********


            '********** Display of Income Groups with its Ledgers ***********
            intSlNo = 1
            intCounter = 0
            intCountLedgers = 0
            dvGroups.RowFilter = "Nature='I'"       'Get Income Groups
            While intCounter < dvGroups.Count       'for each Income group
                dvLedgers.RowFilter = "GroupNo=" & dvGroups.Item(intCounter).Item("GroupNo")    'get Ledgers belong to the Group
                If dvLedgers.Count > 0 Then     'if the Group has Ledgers then only display the Group 
                    lvItem = lvIncome.Items.Add(intSlNo)
                    lvItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    lvItem.SubItems.Add(dvGroups.Item(intCounter).Item("GroupNo"))
                    lvItem.SubItems.Add("")
                    lvItem.SubItems.Add(dvGroups.Item(intCounter).Item("Name"))
                    intCountLedgers = 0
                    dblGroupTotal = 0
                    While intCountLedgers < dvLedgers.Count     'for each Ledger belong to the Group
                        lvItem = lvIncome.Items.Add("")
                        lvItem.SubItems.Add("")
                        lvItem.SubItems.Add(dvLedgers.Item(intCountLedgers).Item("LedgerNo"))
                        lvItem.SubItems.Add(dvLedgers.Item(intCountLedgers).Item("Name"))
                        Dim CurBal As Decimal = Format(Abs(dvLedgers.Item(intCountLedgers).Item("CurrentBalance")), "0,00.00")
                        lvItem.SubItems.Add(CurBal.ToString("N", CInfo))
                        dblIncomeTotal += Abs(dvLedgers.Item(intCountLedgers).Item("CurrentBalance"))
                        dblGroupTotal += Abs(dvLedgers.Item(intCountLedgers).Item("CurrentBalance"))
                        intCountLedgers += 1
                    End While
                    lvItem.SubItems.Add(dblGroupTotal.ToString("N", CInfo))  'display Group Total

                    '******** a blank line after each GroupName
                    lvItem = lvIncome.Items.Add("")
                    lvItem.SubItems.Add("")
                    lvItem.SubItems.Add("")
                    lvItem.SubItems.Add("")

                    intSlNo += 1
                End If
                intCounter += 1
            End While
            '***** a blank line after all Groups *****
            lvItem = lvIncome.Items.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("")
        End If

        '******* completed display of Income Groups and Ledgers ********


        '******** Net Profit or Net Loss display *********
        'If objLedger.fnGetLedgerDetails(2) Then
        '    objDT = objLedger.LedgerTable
        '    If objDT.Rows(0).Item("CurrentBalance") > 0 Then
        '        lvItem = lvExpenditure.Items.Add("")
        '        lvItem.SubItems.Add("")
        '        lvItem.SubItems.Add("")
        '        lvItem.SubItems.Add("Net Profit")
        '        lvItem.SubItems.Add("")
        '        lvItem.SubItems.Add(Abs(objDT.Rows(0).Item("CurrentBalance")))
        '        dblExpTotal += Abs(objDT.Rows(0).Item("CurrentBalance"))
        '    ElseIf objDT.Rows(0).Item("CurrentBalance") < 0 Then
        '        lvItem = lvIncome.Items.Add("")
        '        lvItem.SubItems.Add("")
        '        lvItem.SubItems.Add("")
        '        lvItem.SubItems.Add("Net Loss")
        '        lvItem.SubItems.Add("")
        '        lvItem.SubItems.Add(Abs(objDT.Rows(0).Item("CurrentBalance")))
        '        dblIncomeTotal += Abs(objDT.Rows(0).Item("CurrentBalance"))
        '    End If
        'End If

        Dim i As Decimal = Abs(dblIncome) - Abs(dblExpenditure)

        If i > 0 Then
            lvItem = lvExpenditure.Items.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("Net Profit")
            lvItem.SubItems.Add("")
            ' lvItem.SubItems.Add(objDT.Rows(0).Item("CurrentBalance"))
            lvItem.SubItems.Add(Abs(i).ToString("N", CInfo))
            dblExpTotal += Abs(i)
        ElseIf i < 0 Then
            lvItem = lvIncome.Items.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("")
            lvItem.SubItems.Add("Net Loss")
            lvItem.SubItems.Add("")
            'lvItem.SubItems.Add(Abs(objDT.Rows(0).Item("CurrentBalance")))
            lvItem.SubItems.Add(Abs(i).ToString("N", CInfo))
            dblIncomeTotal += Abs(i)
        End If


        '******* completed display of Net Profit or Loss *********

        '***** display Expenditure and Income Totals *******
        txtExpTotal.Text = dblExpTotal.ToString("N", CInfo)
        txtIncomeTotal.Text = dblIncomeTotal.ToString("N", CInfo)

    End Sub

    Private Sub frmIncomeExpenditure_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'objLedger.fnUpdateLedgerBalances()

        'If bolFromBalanceSheet <> True Then
        '    Dim objDT As DataTable
        '    If objBank.fnGetBankDetails Then
        '        objDT = objBank.BankTable
        '        If objDT.Rows.Count > 0 Then
        '            dtpStartDate = CDate(objDT.Rows(0).Item("FinancialStart"))
        '            dtpEndDate = Date.Now 'CDate(objDT.Rows(0).Item("FinancialEnd"))
        '        End If
        '    End If
        'End If

        If objLedger.fnGetIncomeExpenditure(dtpStartDate, dtpEndDate) Then
            dblExpenditure = objLedger.VoucherTable.Rows(0).Item("Expenditure")
            dblIncome = objLedger.VoucherTable.Rows(0).Item("Income")
        End If
        sbLoadExpanded()

    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lvExpenditure_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvExpenditure.DoubleClick
        If lvExpenditure.SelectedItems.Count > 0 Then
            If lvExpenditure.SelectedItems(0).SubItems(1).Text <> "" Then
                Dim objfrmGroupSummary As frmGroupSummary
                objfrmGroupSummary = frmGroupSummary.DefInstance
                objfrmGroupSummary.BringToFront()
                objfrmGroupSummary.MdiParent = Me.MdiParent
                objfrmGroupSummary.GroupNo = lvExpenditure.SelectedItems(0).SubItems(1).Text
                objfrmGroupSummary.Show()
                objfrmGroupSummary = Nothing
            ElseIf lvExpenditure.SelectedItems(0).SubItems(2).Text <> "" Then
                If objLedger.fnGetTransactions(lvExpenditure.SelectedItems(0).SubItems(2).Text) Then
                    Dim objfrmLedgerDetails As frmLedgerDetails
                    objfrmLedgerDetails = frmLedgerDetails.DefInstance
                    objfrmLedgerDetails.BringToFront()
                    objfrmLedgerDetails.MdiParent = Me.MdiParent
                    objfrmLedgerDetails.LedgerNo = lvExpenditure.SelectedItems(0).SubItems(2).Text
                    objfrmLedgerDetails.Show()
                    objfrmLedgerDetails = Nothing
                End If
            End If
        Else
            MsgBox("Select Record", MsgBoxStyle.Information, Me.Text)
            lvExpenditure.Focus()
        End If
    End Sub

    Private Sub lvIncome_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvIncome.DoubleClick
        If lvIncome.SelectedItems.Count > 0 Then
            If lvIncome.SelectedItems(0).SubItems(1).Text <> "" Then
                Dim objfrmGroupSummary As frmGroupSummary
                objfrmGroupSummary = frmGroupSummary.DefInstance
                objfrmGroupSummary.BringToFront()
                objfrmGroupSummary.MdiParent = Me.MdiParent
                objfrmGroupSummary.GroupNo = lvIncome.SelectedItems(0).SubItems(1).Text
                objfrmGroupSummary.Show()
                objfrmGroupSummary = Nothing
            ElseIf lvIncome.SelectedItems(0).SubItems(2).Text <> "" Then
                If objLedger.fnGetTransactions(lvIncome.SelectedItems(0).SubItems(2).Text) Then
                    Dim objfrmLedgerDetails As frmLedgerDetails
                    objfrmLedgerDetails = frmLedgerDetails.DefInstance
                    objfrmLedgerDetails.BringToFront()
                    objfrmLedgerDetails.MdiParent = Me.MdiParent
                    objfrmLedgerDetails.LedgerNo = lvIncome.SelectedItems(0).SubItems(2).Text
                    objfrmLedgerDetails.Show()
                    objfrmLedgerDetails = Nothing
                End If
            End If
        Else
            MsgBox("Select Record", MsgBoxStyle.Information, Me.Text)
            lvIncome.Focus()
        End If
    End Sub

    Private Sub lvExpenditure_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvExpenditure.KeyDown
        If e.KeyData = Keys.Enter Then
            lvExpenditure_DoubleClick(sender, e)
        ElseIf e.KeyData = Keys.Right Then
            lvIncome.Focus()
        End If
    End Sub

    Private Sub lvIncome_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvIncome.KeyDown
        If e.KeyData = Keys.Enter Then
            lvIncome_DoubleClick(sender, e)
        ElseIf e.KeyData = Keys.Left Then
            lvExpenditure.Focus()
        End If
    End Sub

    Private Sub btnMode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMode.Click
        If btnMode.Text = "Compact" Then
            btnMode.Text = "Expanded"
            sbLoadCompact()
        Else
            btnMode.Text = "Compact"
            sbLoadExpanded()
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim objReportViewer As New frmReportViewer
        objReportViewer.CrystalReportViewer1.ReportSource = "C:/Program Files/Coherent/BAS/Reports/IncomeExpenditure.rpt"
        'ProfitandLoss.rpt" 'AnilBalanceSheet.rpt" 'BalanceSheet.rpt"
        objReportViewer.ShowDialog()
        objReportViewer = Nothing
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim objfrmIncomeExp As IncomeExpinditure
        objfrmIncomeExp = IncomeExpinditure.DefInstance
        objfrmIncomeExp.dtpStartDate1.Value = dtpStartDate
        objfrmIncomeExp.dtpEndDate1.Value = dtpEndDate
        objfrmIncomeExp.BringToFront()
        objfrmIncomeExp.MdiParent = Me.MdiParent
        objfrmIncomeExp.Show()
        objfrmIncomeExp = Nothing
    End Sub
End Class
