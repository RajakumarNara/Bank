Public Class frmAgentsPerCaliculation
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
    Friend WithEvents dtpAccDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtReceiptNo As BankControls.TextControl
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAgentNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAgentName As BankControls.TextControl
    Friend WithEvents btnMemSearch As BankControls.NewButton
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents lblAvalBal As System.Windows.Forms.Label
    Friend WithEvents dtpDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnDeposit As BankControls.NewButton
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As BankControls.TextControl
    Friend WithEvents lblCommission As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAccNo As BankControls.TextControl
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents txtRoi As BankControls.NumericControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgentsPerCaliculation))
        Me.dtpAccDate = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtReceiptNo = New BankControls.TextControl
        Me.Label24 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAgentNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAgentName = New BankControls.TextControl
        Me.btnMemSearch = New BankControls.NewButton
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.lblAvalBal = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtAccNo = New BankControls.TextControl
        Me.btnSearch = New BankControls.NewButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblCommission = New System.Windows.Forms.Label
        Me.btnDeposit = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtRoi = New BankControls.NumericControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNarration = New BankControls.TextControl
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpAccDate
        '
        Me.dtpAccDate.CustomFormat = "dd - MMM - yyyy "
        Me.dtpAccDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAccDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAccDate.Location = New System.Drawing.Point(152, 16)
        Me.dtpAccDate.MaxDate = New Date(9998, 12, 28, 0, 0, 0, 0)
        Me.dtpAccDate.MinDate = New Date(1964, 1, 1, 0, 0, 0, 0)
        Me.dtpAccDate.Name = "dtpAccDate"
        Me.dtpAccDate.Size = New System.Drawing.Size(144, 23)
        Me.dtpAccDate.TabIndex = 1
        Me.dtpAccDate.Value = New Date(2005, 8, 29, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(40, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 16)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Date :"
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.AlphaNumeric = True
        Me.txtReceiptNo.BlankSpace = False
        Me.txtReceiptNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtReceiptNo.Location = New System.Drawing.Point(152, 288)
        Me.txtReceiptNo.LostFocusColour = System.Drawing.Color.Empty
        Me.txtReceiptNo.Mandatory = False
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(136, 23)
        Me.txtReceiptNo.SpecialChar = False
        Me.txtReceiptNo.TabIndex = 7
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(40, 288)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(95, 16)
        Me.Label24.TabIndex = 55
        Me.Label24.Text = "Receipt No. :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtAgentNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAgentName)
        Me.GroupBox1.Controls.Add(Me.btnMemSearch)
        Me.GroupBox1.Controls.Add(Me.dtpDueDate)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.lblAvalBal)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 128)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agent's information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Agent No. :"
        '
        'txtAgentNo
        '
        Me.txtAgentNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgentNo.Location = New System.Drawing.Point(144, 24)
        Me.txtAgentNo.MaxLength = 10
        Me.txtAgentNo.Name = "txtAgentNo"
        Me.txtAgentNo.Size = New System.Drawing.Size(136, 23)
        Me.txtAgentNo.TabIndex = 2
        Me.txtAgentNo.Text = "AG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(320, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Agent Name : "
        '
        'txtAgentName
        '
        Me.txtAgentName.AlphaNumeric = True
        Me.txtAgentName.BlankSpace = False
        Me.txtAgentName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgentName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAgentName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtAgentName.Location = New System.Drawing.Point(432, 24)
        Me.txtAgentName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAgentName.Mandatory = False
        Me.txtAgentName.MaxLength = 20
        Me.txtAgentName.Name = "txtAgentName"
        Me.txtAgentName.Size = New System.Drawing.Size(168, 23)
        Me.txtAgentName.SpecialChar = True
        Me.txtAgentName.TabIndex = 8
        '
        'btnMemSearch
        '
        Me.btnMemSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMemSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMemSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemSearch.ForeColor = System.Drawing.Color.Black
        Me.btnMemSearch.GotFocusColour = System.Drawing.Color.Beige
        Me.btnMemSearch.Image = CType(resources.GetObject("btnMemSearch.Image"), System.Drawing.Image)
        Me.btnMemSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMemSearch.Location = New System.Drawing.Point(282, 24)
        Me.btnMemSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnMemSearch.Name = "btnMemSearch"
        Me.btnMemSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnMemSearch.TabIndex = 3
        '
        'dtpDueDate
        '
        Me.dtpDueDate.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpDueDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpDueDate.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.dtpDueDate.CustomFormat = "dd-MMM - yyyy"
        Me.dtpDueDate.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDueDate.Location = New System.Drawing.Point(144, 56)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(136, 23)
        Me.dtpDueDate.TabIndex = 5
        Me.dtpDueDate.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 16)
        Me.Label7.TabIndex = 628
        Me.Label7.Text = "Due Date :"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(24, 88)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(102, 16)
        Me.Label36.TabIndex = 124
        Me.Label36.Text = "Avail Balance : "
        '
        'lblAvalBal
        '
        Me.lblAvalBal.AutoSize = True
        Me.lblAvalBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvalBal.Location = New System.Drawing.Point(144, 88)
        Me.lblAvalBal.Name = "lblAvalBal"
        Me.lblAvalBal.Size = New System.Drawing.Size(28, 16)
        Me.lblAvalBal.TabIndex = 123
        Me.lblAvalBal.Text = "0.0"
        Me.lblAvalBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(312, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 16)
        Me.Label5.TabIndex = 140
        Me.Label5.Text = " Account No .:"
        '
        'txtAccNo
        '
        Me.txtAccNo.AlphaNumeric = True
        Me.txtAccNo.BackColor = System.Drawing.Color.White
        Me.txtAccNo.BlankSpace = False
        Me.txtAccNo.Enabled = False
        Me.txtAccNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccNo.Location = New System.Drawing.Point(432, 24)
        Me.txtAccNo.LostFocusColour = System.Drawing.Color.White
        Me.txtAccNo.Mandatory = False
        Me.txtAccNo.MaxLength = 10
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.Size = New System.Drawing.Size(128, 23)
        Me.txtAccNo.SpecialChar = False
        Me.txtAccNo.TabIndex = 138
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Beige
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.Beige
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(561, 24)
        Me.btnSearch.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 139
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 16)
        Me.Label4.TabIndex = 631
        Me.Label4.Text = "Commission : "
        '
        'lblCommission
        '
        Me.lblCommission.AutoSize = True
        Me.lblCommission.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommission.Location = New System.Drawing.Point(152, 56)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(28, 16)
        Me.lblCommission.TabIndex = 630
        Me.lblCommission.Text = "0.0"
        Me.lblCommission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeposit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposit.GotFocusColour = System.Drawing.Color.Beige
        Me.btnDeposit.Image = CType(resources.GetObject("btnDeposit.Image"), System.Drawing.Image)
        Me.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeposit.Location = New System.Drawing.Point(428, 321)
        Me.btnDeposit.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(96, 40)
        Me.btnDeposit.TabIndex = 8
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.GotFocusColour = System.Drawing.Color.Beige
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(532, 321)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 40)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtRoi)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.lblCommission)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtAccNo)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(632, 96)
        Me.GroupBox2.TabIndex = 634
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Commission Calculation"
        '
        'txtRoi
        '
        Me.txtRoi.AfterDecimal = 2
        Me.txtRoi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtRoi.BackColor = System.Drawing.Color.White
        Me.txtRoi.BeforeDecimal = 2
        Me.txtRoi.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoi.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRoi.Location = New System.Drawing.Point(144, 24)
        Me.txtRoi.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRoi.MaxValue = 0
        Me.txtRoi.MinValue = 0
        Me.txtRoi.Name = "txtRoi"
        Me.txtRoi.Size = New System.Drawing.Size(104, 23)
        Me.txtRoi.TabIndex = 635
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 637
        Me.Label1.Text = "ROI  :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(256, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 23)
        Me.Button1.TabIndex = 636
        Me.Button1.Text = "Calc"
        '
        'Label6
        '
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 18)
        Me.Label6.TabIndex = 636
        Me.Label6.Text = "Narration :"
        '
        'txtNarration
        '
        Me.txtNarration.AlphaNumeric = True
        Me.txtNarration.BlankSpace = True
        Me.txtNarration.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtNarration.Location = New System.Drawing.Point(152, 320)
        Me.txtNarration.LostFocusColour = System.Drawing.Color.Empty
        Me.txtNarration.Mandatory = False
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarration.Size = New System.Drawing.Size(200, 64)
        Me.txtNarration.SpecialChar = False
        Me.txtNarration.TabIndex = 635
        '
        'frmAgentsPerCaliculation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(648, 389)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNarration)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.dtpAccDate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.txtReceiptNo)
        Me.Controls.Add(Me.Label24)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAgentsPerCaliculation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agents Per Caliculation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
#Region "Variables"
    Dim objClsPigmyAgent As New clsPigmyAgent
    Dim BalTable As DataTable
    Dim total As String
#End Region
#Region " functions"
    Public Function fnGetData(ByVal str As String) As Boolean

        If objClsPigmyAgent.fnCheckAgent(str) Then

            txtAgentName.Text = objClsPigmyAgent.CheckAgentTable.Rows(0).Item("AgentName")

        End If

    End Function

    Public Function fnGetBal(ByVal str As String) As Boolean
        Dim FromDate As DateTime
        Dim TempDate As DateTime = dtpDueDate.Value
        Dim ToDate As DateTime
        Dim FrmDt As String
        Dim ToDt As String
        FromDate = TempDate.AddMonths(1)
        FromDate = FromDate.AddDays(-(FromDate.Day))

        ToDate = TempDate.AddDays(-(TempDate.Day) + 1)
        FrmDt = ToDate.ToString("yyyy-MM-dd")
        ToDt = FromDate.ToString("yyyy-MM-dd")
        'If (objClsPigmyAgent.fnGetBalance(str, FromDate, ToDate)) Then
        If (objClsPigmyAgent.fnGetBalance(str, FrmDt, ToDt)) Then
            Dim BalTable = objClsPigmyAgent.PigmyBalance()
            total = BalTable.rows(0).item("total").ToString()
            If total = "" Then
                total = 0.0
            End If
        End If
        lblAvalBal.Text = total

    End Function
    Function fnGetCommission() As Integer
        Dim commision As Double
        Dim roi As String
        If txtRoi.Text = "" Then
            MsgBox("Enter rate of interest ", MsgBoxStyle.Exclamation)
            txtRoi.Focus()
            Return False
        Else
            roi = txtRoi.Text
        End If
        commision = (total * roi) / 100
        lblCommission.Text = Math.Round(commision)
    End Function
    Public Function fnCheck() As Boolean
        If txtReceiptNo.Text = String.Empty Then
            MsgBox("Enter receipt no ", MsgBoxStyle.Exclamation)
            txtReceiptNo.Focus()
            Return False
        ElseIf lblCommission.Text = String.Empty Then
            MsgBox("caliculate the commision first ", MsgBoxStyle.Exclamation)
            lblCommission.Focus()
            Return False
        Else
            Return True
        End If
    End Function
    'Public Function fnCheckRefNo() As Boolean

    '    If objAgent.fnCheckRefNo(txtRefNo.Text) Then
    '        Return True
    '    Else
    '        Return False
    '    End If

    'End Function
    Function fnGenerateVoucher(ByVal objtrans As IDbTransaction) As Boolean
        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        Dim IntType As Integer
        Dim strVoucherType As String
        Dim strTMode As String

        lngVoucherNo = fnVoucherGetNewVNo(dtpAccDate.Value)
        lngSlNo = fnVoucherGetNewSlNo()
        

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 7, txtAccNo.Text, txtReceiptNo.Text, dtpAccDate.Value, lblCommission.Text, "Credited by " & txtAccNo.Text, lngSlNo, "Y", objtrans)

        'Credit accounts
        fnVoucherEnterSub(lngVoucherNo, 7, txtAccNo.Text, dtpAccDate.Value, "Credited by " & txtAccNo.Text, "To", 10, 0, Val(lblCommission.Text), 1, "Y", objtrans)

        'Debit accounts 
        fnVoucherEnterSub(lngVoucherNo, 7, "LNo:" & 81, dtpAccDate.Value, "Debited by  " & 81 & " Narration:" & txtNarration.Text, "By", 81, Val(lblCommission.Text), 0, 2, "Y", objtrans)

        fnLogEntry(pbUserId, strVoucherType & " by " & 10 & " Amount " & lblCommission.Text, Date.Now, "Transaction" & strVoucherType, objtrans)



        'Transaction Entery
        Dim strNarration As String = "Deposit By Cash"
        Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpAccDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & Trim(lblCommission.Text) & "','0','" & Trim(lblCommission.Text) & "','0',sum(Deposit)-sum(withdraw)+'" & Trim(lblCommission.Text) & "','" & Trim(txtReceiptNo.Text) & "','" & lngVoucherNo & "','" & strTMode & "','0' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
        fnExecuteNonQuery(strsql, objtrans)
        Return True
    End Function
    Function fnClear()
        txtAccNo.Text = String.Empty
        txtAgentName.Text = String.Empty
        txtAgentNo.Text = String.Empty
        txtNarration.Text = String.Empty
        txtReceiptNo.Text = String.Empty
        txtRoi.Text = String.Empty
        lblAvalBal.Text = String.Empty
        lblCommission.Text = String.Empty
    End Function
#End Region

    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        Dim objTrans As IDbTransaction

        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then



                If (fnGenerateVoucher(objTrans)) Then
                    fnLogEntry(pbUserId, "Deposit by " & txtAccNo.Text & " Amount " & lblCommission.Text, Date.Now, "Transaction Deposit", objTrans)
                    objTrans.Commit()
                    MsgBox("transaction done ", MsgBoxStyle.Exclamation)
                    fnClear()
                    Me.Close()
                Else
                    MsgBox("Transaction cannot be completed,due to internal error", MsgBoxStyle.Exclamation)


                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try
    End Sub

    Private Sub btnMemSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMemSearch.Click
        fnClear()
        Dim objAGSearch As New frmAGAccSearch
        objAGSearch.ShowDialog()
        If objAGSearch.strAGAccountNo <> String.Empty Then
            txtAgentNo.Text = objAGSearch.strAGAccountNo
            fnGetData(txtAgentNo.Text)

        End If
        objAGSearch.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim objSBAccSearch As New frmSBAccSearch
        objSBAccSearch.strSBAccountNo = String.Empty
        objSBAccSearch.ShowDialog(Me)
        If objSBAccSearch.strSBAccountNo <> String.Empty Then
            txtAccNo.Text = objSBAccSearch.strSBAccountNo
        End If
        objSBAccSearch.Dispose()
    End Sub

    Private Sub dtpDueDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDueDate.ValueChanged
        fnGetBal(txtAgentNo.Text)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        fnGetCommission()
    End Sub

    Private Sub frmAgentsPerCaliculation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpAccDate.Value = Date.Now
        dtpDueDate.Value = Date.Now
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
