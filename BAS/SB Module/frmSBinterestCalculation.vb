Public Class frmSBinterestCalculation
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
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents DTPFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvInterest As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRoi As BankControls.NumericControl
    Friend WithEvents NumericControl1 As BankControls.NumericControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCalculate As BankControls.NewButton
    Friend WithEvents btnPost As BankControls.NewButton
    Friend WithEvents btnSettings As BankControls.NewButton
    Friend WithEvents btnExit As BankControls.NewButton
    Friend WithEvents btnSave As BankControls.NewButton
    Friend WithEvents btnIntrestPayable As BankControls.NewButton
    Friend WithEvents slNo As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSBinterestCalculation))
        Me.lvInterest = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.slNo = New System.Windows.Forms.ColumnHeader
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.DTPFrom = New System.Windows.Forms.DateTimePicker
        Me.DTPTo = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRoi = New BankControls.NumericControl
        Me.NumericControl1 = New BankControls.NumericControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnIntrestPayable = New BankControls.NewButton
        Me.btnSave = New BankControls.NewButton
        Me.btnExit = New BankControls.NewButton
        Me.btnCalculate = New BankControls.NewButton
        Me.btnPost = New BankControls.NewButton
        Me.btnSettings = New BankControls.NewButton
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvInterest
        '
        Me.lvInterest.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lvInterest.CheckBoxes = True
        Me.lvInterest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.slNo})
        Me.lvInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvInterest.FullRowSelect = True
        Me.lvInterest.GridLines = True
        Me.lvInterest.Location = New System.Drawing.Point(16, 56)
        Me.lvInterest.MultiSelect = False
        Me.lvInterest.Name = "lvInterest"
        Me.lvInterest.Size = New System.Drawing.Size(536, 296)
        Me.lvInterest.TabIndex = 1
        Me.lvInterest.UseCompatibleStateImageBehavior = False
        Me.lvInterest.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "AccountNo."
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 216
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Interest Payable"
        Me.ColumnHeader3.Width = 103
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Balance In Account"
        Me.ColumnHeader4.Width = 107
        '
        'slNo
        '
        Me.slNo.Text = "SlNo."
        Me.slNo.Width = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 360)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(536, 24)
        Me.ProgressBar1.TabIndex = 2
        '
        'DTPFrom
        '
        Me.DTPFrom.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DTPFrom.CalendarMonthBackground = System.Drawing.Color.White
        Me.DTPFrom.CustomFormat = "dd - MMM - yyyy"
        Me.DTPFrom.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFrom.Location = New System.Drawing.Point(16, 16)
        Me.DTPFrom.Name = "DTPFrom"
        Me.DTPFrom.Size = New System.Drawing.Size(160, 23)
        Me.DTPFrom.TabIndex = 5
        Me.DTPFrom.Value = New Date(2009, 4, 1, 0, 0, 0, 0)
        '
        'DTPTo
        '
        Me.DTPTo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DTPTo.CustomFormat = "dd - MMM - yyyy"
        Me.DTPTo.Enabled = False
        Me.DTPTo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTo.Location = New System.Drawing.Point(248, 16)
        Me.DTPTo.Name = "DTPTo"
        Me.DTPTo.Size = New System.Drawing.Size(160, 23)
        Me.DTPTo.TabIndex = 5
        Me.DTPTo.Value = New Date(2008, 10, 31, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(208, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "To"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 400)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Rate Of Interest :"
        '
        'txtRoi
        '
        Me.txtRoi.AfterDecimal = 2
        Me.txtRoi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtRoi.BackColor = System.Drawing.Color.White
        Me.txtRoi.BeforeDecimal = 2
        Me.txtRoi.Enabled = False
        Me.txtRoi.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoi.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtRoi.Location = New System.Drawing.Point(152, 400)
        Me.txtRoi.LostFocusColour = System.Drawing.Color.Empty
        Me.txtRoi.MaxValue = 0
        Me.txtRoi.MinValue = 0
        Me.txtRoi.Name = "txtRoi"
        Me.txtRoi.ReadOnly = True
        Me.txtRoi.Size = New System.Drawing.Size(104, 23)
        Me.txtRoi.TabIndex = 22
        '
        'NumericControl1
        '
        Me.NumericControl1.AfterDecimal = 2
        Me.NumericControl1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NumericControl1.BeforeDecimal = 2
        Me.NumericControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericControl1.GotFocusColour = System.Drawing.SystemColors.Info
        Me.NumericControl1.Location = New System.Drawing.Point(152, 400)
        Me.NumericControl1.LostFocusColour = System.Drawing.Color.Empty
        Me.NumericControl1.MaxValue = 0
        Me.NumericControl1.MinValue = 0
        Me.NumericControl1.Name = "NumericControl1"
        Me.NumericControl1.Size = New System.Drawing.Size(104, 23)
        Me.NumericControl1.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnIntrestPayable)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnCalculate)
        Me.Panel1.Controls.Add(Me.btnPost)
        Me.Panel1.Controls.Add(Me.btnSettings)
        Me.Panel1.Location = New System.Drawing.Point(568, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(152, 344)
        Me.Panel1.TabIndex = 23
        '
        'btnIntrestPayable
        '
        Me.btnIntrestPayable.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnIntrestPayable.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnIntrestPayable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIntrestPayable.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIntrestPayable.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIntrestPayable.ForeColor = System.Drawing.Color.Black
        Me.btnIntrestPayable.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIntrestPayable.Image = CType(resources.GetObject("btnIntrestPayable.Image"), System.Drawing.Image)
        Me.btnIntrestPayable.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnIntrestPayable.Location = New System.Drawing.Point(15, 120)
        Me.btnIntrestPayable.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnIntrestPayable.Name = "btnIntrestPayable"
        Me.btnIntrestPayable.Size = New System.Drawing.Size(120, 48)
        Me.btnIntrestPayable.TabIndex = 3
        Me.btnIntrestPayable.Text = " &Interest Payable"
        Me.btnIntrestPayable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIntrestPayable.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Enabled = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(15, 64)
        Me.btnSave.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 48)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(16, 288)
        Me.btnExit.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 48)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        '
        'btnCalculate
        '
        Me.btnCalculate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Black
        Me.btnCalculate.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCalculate.Image = CType(resources.GetObject("btnCalculate.Image"), System.Drawing.Image)
        Me.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalculate.Location = New System.Drawing.Point(16, 8)
        Me.btnCalculate.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(120, 48)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnPost
        '
        Me.btnPost.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPost.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnPost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPost.Enabled = False
        Me.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPost.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPost.ForeColor = System.Drawing.Color.Black
        Me.btnPost.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPost.Image = CType(resources.GetObject("btnPost.Image"), System.Drawing.Image)
        Me.btnPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPost.Location = New System.Drawing.Point(16, 176)
        Me.btnPost.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(120, 48)
        Me.btnPost.TabIndex = 4
        Me.btnPost.Text = "&Post Interest"
        Me.btnPost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPost.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSettings.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.Black
        Me.btnSettings.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(16, 232)
        Me.btnSettings.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(120, 48)
        Me.btnSettings.TabIndex = 5
        Me.btnSettings.Text = " Se&ttings"
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'frmSBinterestCalculation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(730, 434)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtRoi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericControl1)
        Me.Controls.Add(Me.DTPFrom)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lvInterest)
        Me.Controls.Add(Me.DTPTo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSBinterestCalculation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SB Interest Calculation"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmSBinterestCalculation
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmSBinterestCalculation
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmSBinterestCalculation
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmSBinterestCalculation)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Global Variables"

    Dim SBRoi As Decimal
    Dim IntCalDur As Integer
    Dim dtSBAccounts As New DataTable
    Dim objSBAccount As New clsSavingsBank
    Dim dblMinAmount As Double
    Dim bolLoad As Boolean = False
    Dim dblMinimumInterese As Double

#End Region

#Region "Functions"

#Region "Commented"

    'Function CaLculateInterest123()

    '    lvInterest.Items.Clear()

    '    Dim dtStartDate As Date

    '    Dim intCount As Integer = 0

    '    Dim strSql As String = "select s.AccountNo,s.Accdate,s.Availbalance,p.Name,s.AccStatus from sbdetailstbl s,persontbl p where s.personNo=p.personNo and s.Accstatus <> 'C'"

    '    dtSBAccounts = fnExecuteQuery(strSql, 2)

    '    Dim drRow As DataRow
    '    Dim intcounter As Integer = 0

    '    ' For Each drRow In dtSBAccounts.Rows

    '    ProgressBar1.Maximum = dtSBAccounts.Rows.Count
    '    While intCount < dtSBAccounts.Rows.Count

    '        'If IsNewAccount(drRow("AccountNo")) Then
    '        If IsNewAccount(dtSBAccounts.Rows(intCount).Item("AccountNo")) Then

    '            'New Account Interest Calculation

    '            Dim NoOfDayS As Integer

    '            'dtStartDate = Format(drRow("Accdate"), "dd-MMM-yyyy")
    '            dtStartDate = CDate(dtSBAccounts.Rows(intCount).Item("AccDate"))

    '            If dtStartDate.Day > 10 Then

    '                dtStartDate = dtStartDate.AddMonths(1)

    '                NoOfDayS = 10 - dtStartDate.Day

    '                dtStartDate = dtStartDate.AddDays(NoOfDayS)

    '                CalCulateInterest(dtSBAccounts.Rows(intCount).Item("AccountNo"), dtSBAccounts.Rows(intCount).Item("Name"), dtStartDate, dtSBAccounts.Rows(intCount).Item("AvailBalance"))

    '            Else

    '                CalCulateInterest(dtSBAccounts.Rows(intCount).Item("AccountNo"), dtSBAccounts.Rows(intCount).Item("Name"), dtStartDate, dtSBAccounts.Rows(intCount).Item("AvailBalance"))

    '                '''dtStartDate = dtStartDate.AddMonths(1)

    '            End If

    '        Else

    '            strSql = "Select IntTo from sbinterestlogtbl where AccountNo='" & dtSBAccounts.Rows(intCount).Item("AccountNo") & "'"

    '            dtStartDate = fnExecuteQuery(strSql, 2).rows(0).item("intTo")

    '            DTPFrom.Value = dtStartDate '.AddMonths(1)
    '            'IntializeSettings()

    '            CalCulateInterest(dtSBAccounts.Rows(intCount).Item("AccountNo"), dtSBAccounts.Rows(intCount).Item("Name"), DTPFrom.Value, dtSBAccounts.Rows(intCount).Item("AvailBalance"))
    '            'Old Account interest Calculation

    '        End If
    '        intCount += 1
    '        ProgressBar1.Value += 1
    '    End While
    '    ProgressBar1.Value = 0
    '    'Next

    'End Function
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


    'Working fine we can use it

    'Function CaLculateInterest123()

    '    lvInterest.Items.Clear()

    '    Dim dtStartDate As Date
    '    Dim intCount As Integer = 0
    '    Dim strSql As String = "select s.AccountNo,s.Accdate,s.Availbalance,p.Name,s.AccStatus from sbdetailstbl s,persontbl p where s.personNo=p.personNo and s.Accstatus <> 'C'"

    '    dtSBAccounts = fnExecuteQuery(strSql, 2)

    '    Dim drRow As DataRow
    '    Dim intcounter As Integer = 0

    '    Dim conn As IDbConnection
    '    ' For Each drRow In dtSBAccounts.Rows
    '    Try
    '        conn = fnGetConnection()

    '        ProgressBar1.Maximum = dtSBAccounts.Rows.Count
    '        While intCount < dtSBAccounts.Rows.Count

    '            'If IsNewAccount(drRow("AccountNo")) Then
    '            If IsNewAccount(dtSBAccounts.Rows(intCount).Item("AccountNo")) Then

    '                'New Account Interest Calculation

    '                Dim NoOfDayS As Integer

    '                'dtStartDate = Format(drRow("Accdate"), "dd-MMM-yyyy")
    '                dtStartDate = CDate(dtSBAccounts.Rows(intCount).Item("AccDate"))

    '                If dtStartDate.Day > 10 Then

    '                    dtStartDate = dtStartDate.AddMonths(1)

    '                    NoOfDayS = 10 - dtStartDate.Day

    '                    dtStartDate = dtStartDate.AddDays(NoOfDayS)

    '                    CalCulateInterest(dtSBAccounts.Rows(intCount).Item("AccountNo"), dtSBAccounts.Rows(intCount).Item("Name"), dtStartDate, dtSBAccounts.Rows(intCount).Item("AvailBalance"), conn)

    '                Else

    '                    CalCulateInterest(dtSBAccounts.Rows(intCount).Item("AccountNo"), dtSBAccounts.Rows(intCount).Item("Name"), dtStartDate, dtSBAccounts.Rows(intCount).Item("AvailBalance"), conn)

    '                    '''dtStartDate = dtStartDate.AddMonths(1)

    '                End If

    '            Else

    '                strSql = "Select IntTo from sbinterestlogtbl where AccountNo='" & dtSBAccounts.Rows(intCount).Item("AccountNo") & "'"

    '                dtStartDate = fnExecuteQuery(strSql, 2, conn).rows(0).item("intTo")

    '                DTPFrom.Value = dtStartDate '.AddMonths(1)
    '                'IntializeSettings()

    '                CalCulateInterest(dtSBAccounts.Rows(intCount).Item("AccountNo"), dtSBAccounts.Rows(intCount).Item("Name"), DTPFrom.Value, dtSBAccounts.Rows(intCount).Item("AvailBalance"), conn)
    '                'Old Account interest Calculation

    '            End If
    '            intCount += 1
    '            ProgressBar1.Value += 1
    '        End While
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Database Error")
    '    Finally
    '        conn.Close()
    '    End Try

    '    ProgressBar1.Value = 0
    '    'Next

    'End Function

#End Region

    Function CaLculateInterest123()

        lvInterest.Items.Clear()

        Dim dtStartDate As Date
        Dim intCount As Integer = 0
        Dim strSql As String = "select s.AccountNo,s.Accdate,s.Availbalance,p.Name,s.AccStatus from sbdetailstbl s,persontbl p where s.personNo=p.personNo and s.Accstatus <> 'C'"

        dtSBAccounts = fnExecuteQuery(strSql, 2)

        Dim drRow As DataRow
        Dim intcounter As Integer = 0

        Dim conn As IDbConnection
        Try
            conn = fnGetConnection()

            ProgressBar1.Maximum = dtSBAccounts.Rows.Count
            While intCount < dtSBAccounts.Rows.Count

                dtStartDate = DTPFrom.Value
                'Dim NoOfDayS As Integer
                'If dtStartDate.Day > 10 Then
                '    dtStartDate = dtStartDate.AddMonths(1)
                '    NoOfDayS = 10 - dtStartDate.Day
                '    dtStartDate = dtStartDate.AddDays(NoOfDayS)
                'End If
              
                Dim ANl As String = dtSBAccounts.Rows(intCount).Item("AccountNo")

                CalCulateInterest(dtSBAccounts.Rows(intCount).Item("AccountNo"), dtSBAccounts.Rows(intCount).Item("Name"), dtStartDate, dtSBAccounts.Rows(intCount).Item("AvailBalance"), conn)

                'If IsNewAccount(dtSBAccounts.Rows(intCount).Item("AccountNo")) Then
                '    'New Account Interest Calculation
                '    Dim NoOfDayS As Integer
                '    dtStartDate = CDate(dtSBAccounts.Rows(intCount).Item("AccDate"))
                '    If dtStartDate.Day > 10 Then
                '        dtStartDate = dtStartDate.AddMonths(1)
                '        NoOfDayS = 10 - dtStartDate.Day
                '        dtStartDate = dtStartDate.AddDays(NoOfDayS)
                '        CalCulateInterest(dtSBAccounts.Rows(intCount).Item("AccountNo"), dtSBAccounts.Rows(intCount).Item("Name"), dtStartDate, dtSBAccounts.Rows(intCount).Item("AvailBalance"), conn)
                '    Else
                '        CalCulateInterest(dtSBAccounts.Rows(intCount).Item("AccountNo"), dtSBAccounts.Rows(intCount).Item("Name"), dtStartDate, dtSBAccounts.Rows(intCount).Item("AvailBalance"), conn)
                '        '''dtStartDate = dtStartDate.AddMonths(1)
                '    End If
                'Else
                '    strSql = "Select IntTo from sbinterestlogtbl where AccountNo='" & dtSBAccounts.Rows(intCount).Item("AccountNo") & "'"
                '    dtStartDate = fnExecuteQuery(strSql, 2, conn).rows(0).item("intTo")
                '    DTPFrom.Value = dtStartDate '.AddMonths(1)
                '    'IntializeSettings()
                '    CalCulateInterest(dtSBAccounts.Rows(intCount).Item("AccountNo"), dtSBAccounts.Rows(intCount).Item("Name"), DTPFrom.Value, dtSBAccounts.Rows(intCount).Item("AvailBalance"), conn)
                '    'Old Account interest Calculation
                'End If

                intCount += 1
                ProgressBar1.Value += 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Database Error")
        Finally
            conn.Close()
        End Try

        ProgressBar1.Value = 0
        'Next

    End Function

    Private Function IsNewAccount(ByVal strAccountNo As String) As Boolean

        Dim Strsql As String = "select Accountno from sbinterestlogtbl where AccountNo='" & strAccountNo & "'"

        Dim dtAccExists As New DataTable

        dtAccExists = fnExecuteQuery(Strsql, 2)

        If dtAccExists.Rows.Count > 0 Then

            Return False

        Else

            Return True

        End If

    End Function

    Public Function fnPostInt()
        Dim objTrans As IDbTransaction
        If lvInterest.Items.Count > 0 Then
            If MsgBox("Do you want to save the interest payable ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SB Module") = MsgBoxResult.Yes Then
                Try

                    objTrans = fnGetTransaction()
                    For Each lvItems As ListViewItem In lvInterest.Items
                        ProgressBar1.Maximum = lvInterest.Items.Count
                        objSBAccount.SBNo = lvItems.SubItems(0).Text
                        objSBAccount.IntAmt = lvItems.SubItems(2).Text
                        objSBAccount.FromPeriod = Format(DTPFrom.Value, "yyyy-MM-dd")
                        objSBAccount.ToPeriod = Format(DTPTo.Value, "yyyy-MM-dd")
                        objSBAccount.Status = "D"
                        objSBAccount.fnPostInterest(objTrans)
                        ProgressBar1.Value += 1
                    Next
                    objTrans.Commit()
                    ProgressBar1.Value = 0
                    lvInterest.Items.Clear()
                    MsgBox("Interest saved successfully", MsgBoxStyle.Information, "SB Module")
                Catch ex As Exception
                    MsgBox("Interest save failed. please try again.", MsgBoxStyle.Exclamation, "SB Module")
                Finally
                    objTrans.Dispose()
                End Try
            End If
        Else
            MsgBox("No items to save", MsgBoxStyle.Information, "SB Module")
        End If

    End Function


    Public Function fnGenerateIntPostVoucher(ByVal objTrans As IDbTransaction) As Boolean

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long

        lngVoucherNo = fnVoucherGetNewVNo(Date.Now)
        lngSlNo = fnVoucherGetNewSlNo()
        Dim strNarration As String = "SB interest posted to account No " & objSBAccount.SBNo & ""

        Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
        strsql = strsql & " select '" & objSBAccount.SBNo & "','" & Format(Date.Now, "yyyy-MM-dd:HH:mm:ss") & "','" & strNarration & "','" & objSBAccount.IntAmt & "','0','" & objSBAccount.IntAmt & "','0',sum(Deposit)-sum(withdraw)+'" & objSBAccount.IntAmt & "','0','" & lngVoucherNo & "','Cash','0' from sbtransactiontbl where accountno='" & objSBAccount.SBNo & "' group by Accountno"
        fnExecuteNonQuery(strsql, objTrans)

        fnVoucherEnterMain(lngVoucherNo, 2, objSBAccount.SBNo, "0", Format(Date.Now, "yyyy-MM-dd"), objSBAccount.IntAmt, strNarration, lngSlNo, "Y", objTrans)

        fnVoucherEnterSub(lngVoucherNo, 2, objSBAccount.SBNo, Format(Date.Now, "yyyy-MM-dd"), strNarration, "By", 125, objSBAccount.IntAmt, 0, 2, "Y", objTrans)

        fnVoucherEnterSub(lngVoucherNo, 2, objSBAccount.SBNo, Format(Date.Now, "yyyy-MM-dd"), strNarration, "To", 10, 0, objSBAccount.IntAmt, 1, "Y", objTrans)

        Return True

    End Function

#End Region

#Region "Sub Routines"

    Sub IntializeSettings()

        Dim strSql As String = "Select * from mastersettingstbl"

        Dim dtSettings As New DataTable

        dtSettings = fnExecuteQuery(strSql, 2)

        If dtSettings.Rows.Count > 0 Then

            txtRoi.Text = dtSettings.Rows(0).Item("SBRoi")

            'DTPTo.Value = DTPFrom.Value.AddMonths(dtSettings.Rows(0).Item("SBIntCalDur"))

            DTPFrom.Value = CDate(dtSettings.Rows(0).Item("SBIntCalDur"))

            DTPTo.Value = CDate(dtSettings.Rows(0).Item("SBIntCalDay"))

            dblMinAmount = dtSettings.Rows(0).Item("SBMinAmtforIntrest")

            dblMinimumInterese = dtSettings.Rows(0).Item("SBMinIntereseAmount")

        End If



    End Sub

#End Region

#Region "Events"

    'Interest calculation  in terms of month_Implemant This

    'Private Function CalCulateInterest(ByVal strAccountNo As String, ByVal strAccName As String, ByVal dtstartDate As Date, ByVal dblBalance As Double, ByVal conn As IDbConnection)

    '    Dim intStartMonth As Integer = Month(dtstartDate)
    '    Dim lngIntAmount As Decimal = 0
    '    Dim LvItem As ListViewItem
    '    Dim dblAMount As Double = 0
    '    'This is to loop Till duration of month
    '    Try

    '        While Month(dtstartDate) <> Month(DTPTo.Value) ' + 1
    '            Dim min1, min2 As Double
    '            Dim Strsql As String = "select ifNull((select Min(Postbal) from sbtransactionTbl where AccountNo ='" & strAccountNo & "' and Trdate Between'" & Format(dtstartDate, "yyyy-MM-10") & "' and '" & Format(dtstartDate, "yyyy-MM-31") & "'),0)"
    '            Dim strSql1 As String = "select ifNull((select Min(Postbal) from sbtransactiontbl where AccountNo ='" & strAccountNo & "' and trdate < '" & Format(dtstartDate, "yyyy-MM-10") & "'  order by trdate Desc limit 1),0)"
    '            Dim dtTemp As New DataTable
    '            Dim dtTemp1 As New DataTable

    '            dtTemp = fnExecuteQuery(strSql1, 2, conn)
    '            dtTemp1 = fnExecuteQuery(Strsql, 2, conn)

    '            'min1 = fnExecuteQuery(Strsql, 2).rows(0).Item(0)
    '            min1 = dtTemp1.Rows(0).Item(0)
    '            If dtTemp.Rows.Count = 0 Then
    '                If min1 > dblMinAmount Then
    '                    lngIntAmount = lngIntAmount + min1
    '                End If
    '            ElseIf min1 = 0 Then
    '                min2 = dtTemp.Rows(0).Item(0)
    '                If min2 > dblMinAmount Then
    '                    lngIntAmount = lngIntAmount + min2
    '                End If
    '            Else
    '                min2 = dtTemp.Rows(0).Item(0)
    '                If min1 > dblMinAmount And min2 > dblMinAmount Then
    '                    lngIntAmount = lngIntAmount + IIf(min1 > min2, min2, min1)
    '                ElseIf min1 > dblMinAmount Then
    '                    lngIntAmount = lngIntAmount + min1
    '                ElseIf min2 > dblMinAmount Then
    '                    lngIntAmount = lngIntAmount + min2
    '                End If
    '            End If
    '            dtstartDate = dtstartDate.AddMonths(1)
    '            dtTemp.Dispose()
    '            dtTemp1.Dispose()
    '        End While
    '        dblAMount = Math.Round((lngIntAmount * Val(txtRoi.Text)) / (12 * 100), 2)
    '        'dblAMount = Math.Round((lngIntAmount * 30 * Val(txtRoi.Text)) / (365 * 100), 2)

    '        If (dblAMount >= dblMinimumInterese) Then
    '            LvItem = lvInterest.Items.Add(strAccountNo)
    '            LvItem.SubItems.Add(strAccName)
    '            LvItem.SubItems.Add(Format(Math.Round(dblAMount), "0,00.00"))
    '            LvItem.SubItems.Add(Format(dblBalance, "0,00.00"))
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Database Error")
    '    End Try


    'End Function

    '''''''''''''''''''''''''''''''''''''''''''''''''''
    'Interest calculation in terms of days
    'Private Function CalCulateInterest(ByVal strAccountNo As String, ByVal strAccName As String, ByVal dtstartDate As Date, ByVal dblBalance As Double, ByVal conn As IDbConnection)

    '    Dim intStartMonth As Integer = Month(dtstartDate)
    '    Dim lngIntAmount As Decimal = 0
    '    Dim LvItem As ListViewItem
    '    Dim dblAMount As Double = 0
    '    'This is to loop Till duration of month
    '    Try

    '        While Month(dtstartDate) <> Month(DTPTo.Value) ' + 1
    '            Dim min1, min2 As Double
    '            Dim Strsql As String = "select ifNull((select Min(Postbal) from sbtransactionTbl where AccountNo ='" & strAccountNo & "' and Trdate Between'" & Format(dtstartDate, "yyyy-MM-10") & "' and '" & Format(dtstartDate, "yyyy-MM-31") & "'),0)"
    '            Dim strSql1 As String = "select ifNull((select Postbal from sbtransactiontbl where AccountNo ='" & strAccountNo & "' and trdate < '" & Format(dtstartDate, "yyyy-MM-10") & "'  order by trdate Desc limit 1),0)"
    '            Dim dtTemp As New DataTable
    '            Dim dtTemp1 As New DataTable
    '            Dim dblMinBal As Double = 0

    '            dtTemp = fnExecuteQuery(strSql1, 2, conn)
    '            dtTemp1 = fnExecuteQuery(Strsql, 2, conn)

    '            'min1 = fnExecuteQuery(Strsql, 2).rows(0).Item(0)
    '            min1 = dtTemp1.Rows(0).Item(0)
    '            If dtTemp.Rows.Count = 0 Then
    '                If min1 > dblMinAmount Then
    '                    dblMinBal = min1
    '                    'lngIntAmount = lngIntAmount + min1
    '                End If
    '            ElseIf min1 = 0 Then
    '                min2 = dtTemp.Rows(0).Item(0)
    '                If min2 > dblMinAmount Then
    '                    dblMinBal = min2
    '                    'lngIntAmount = lngIntAmount + min2
    '                End If
    '            Else
    '                min2 = dtTemp.Rows(0).Item(0)
    '                If min1 > dblMinAmount And min2 > dblMinAmount Then
    '                    dblMinBal = IIf(min1 > min2, min2, min1)
    '                    'lngIntAmount = lngIntAmount + IIf(min1 > min2, min2, min1)
    '                ElseIf min1 > dblMinAmount Then
    '                    'lngIntAmount = lngIntAmount + min1
    '                    dblMinBal = min1
    '                ElseIf min2 > dblMinAmount Then
    '                    'lngIntAmount = lngIntAmount + min2
    '                    dblMinBal = min2
    '                End If
    '            End If
    '            lngIntAmount = Math.Round((dblMinBal * 30 * Val(txtRoi.Text)) / (365 * 100), 2)

    '            dblAMount += lngIntAmount

    '            dtstartDate = dtstartDate.AddMonths(1)
    '            dtTemp.Dispose()
    '            dtTemp1.Dispose()
    '        End While
    '        'dblAMount = Math.Round((lngIntAmount * Val(txtRoi.Text)) / (12 * 100), 2)
    '        If (dblAMount >= dblMinimumInterese) Then
    '            LvItem = lvInterest.Items.Add(strAccountNo)
    '            LvItem.SubItems.Add(strAccName)
    '            LvItem.SubItems.Add(Format(Math.Round(dblAMount), "0,00.00"))
    '            LvItem.SubItems.Add(Format(dblBalance, "0,00.00"))
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Database Error")
    '    End Try


    'End Function


    Private Function CalCulateInterest(ByVal strAccountNo As String, ByVal strAccName As String, ByVal dtstartDate As Date, ByVal dblBalance As Double, ByVal conn As IDbConnection)

        Dim intStartMonth As Integer = Month(dtstartDate)
        Dim lngIntAmount As Decimal = 0
        Dim LvItem As ListViewItem
        Dim dblAMount As Double = 0
        'This is to loop Till duration of month
        Try

            While Month(dtstartDate) <> Month(DTPTo.Value) ' + 1
                Dim min1, min2 As Double
                Dim Strsql As String = "select ifNull((select Min(Postbal) from sbtransactionTbl where AccountNo ='" & strAccountNo & "' and Trdate Between'" & Format(dtstartDate, "yyyy-MM-10") & "' and '" & Format(dtstartDate, "yyyy-MM-31") & "'),0)"
                Dim strSql1 As String = "select ifNull((select Min(Postbal) from sbtransactiontbl where AccountNo ='" & strAccountNo & "' and trdate < '" & Format(dtstartDate, "yyyy-MM-10") & "'  order by trdate Desc limit 1),0)"
                Dim dtTemp As New DataTable
                Dim dtTemp1 As New DataTable

                dtTemp = fnExecuteQuery(strSql1, 2, conn)
                dtTemp1 = fnExecuteQuery(Strsql, 2, conn)

                'min1 = fnExecuteQuery(Strsql, 2).rows(0).Item(0)
                min1 = dtTemp1.Rows(0).Item(0)
                If dtTemp.Rows.Count = 0 Then
                    If min1 > dblMinAmount Then
                        lngIntAmount = lngIntAmount + min1
                    End If
                ElseIf min1 = 0 Then
                    min2 = dtTemp.Rows(0).Item(0)
                    If min2 > dblMinAmount Then
                        lngIntAmount = lngIntAmount + min2
                    End If
                Else
                    min2 = dtTemp.Rows(0).Item(0)
                    If min1 > dblMinAmount And min2 > dblMinAmount Then
                        lngIntAmount = lngIntAmount + IIf(min1 > min2, min2, min1)
                    ElseIf min1 > dblMinAmount Then
                        lngIntAmount = lngIntAmount + min1
                    ElseIf min2 > dblMinAmount Then
                        lngIntAmount = lngIntAmount + min2
                    End If
                End If
                dtstartDate = dtstartDate.AddMonths(1)
                dtTemp.Dispose()
                dtTemp1.Dispose()
            End While
            dblAMount = Math.Round((lngIntAmount * Val(txtRoi.Text)) / (12 * 100), 2)
            'dblAMount = Math.Round((lngIntAmount * 30 * Val(txtRoi.Text)) / (365 * 100), 2)

            If (dblAMount >= dblMinimumInterese) Then
                LvItem = lvInterest.Items.Add(strAccountNo)
                LvItem.SubItems.Add(strAccName)
                LvItem.SubItems.Add(Format(Math.Round(dblAMount), "0,00.00"))
                LvItem.SubItems.Add(Format(dblBalance, "0,00.00"))
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Database Error")
        End Try


    End Function


    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        MsgBox("You are about to calculate the interest for the duration of " & DateDiff(DateInterval.Month, DTPFrom.Value, DTPTo.Value) & " Months " & Chr(13) & "ie From " & Format(DTPFrom.Value, "MMMM-yyyy") & " To " & Format(DTPTo.Value, "MMMM-yyyy") & " " & Chr(13) & "  Are you Sure?", MsgBoxStyle.Exclamation)
        'If Date.Now.Day >= 28 And Date.Now.Month >= DTPTo.Value.Month Then
        'If Date.Now.Day >= 28 And Date.Now.Month >= DTPTo.Value.Month Then
        If Date.Now >= DTPTo.Value Then
            CaLculateInterest123()
            btnSave.Enabled = True
            btnPost.Enabled = False
            bolLoad = False
        Else
            MsgBox("Interest can be calculated only after month end" & MonthName(Month(DTPTo.Value)) & " Month", MsgBoxStyle.Information)
        End If
    End Sub

    Public Function fnReset()

        btnSave.Enabled = False
        btnPost.Enabled = False

    End Function

    Private Sub frmSBinterestCalculation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DTPFrom.Enabled = False
        DTPFrom.Enabled = False
        DTPFrom.Value = Date.Now
        DTPFrom.Value = Date.Now

        IntializeSettings()
        DTPFrom.BackColor = Color.White

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        fnPostInt()

    End Sub

    Private Sub btnIntrestPayable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntrestPayable.Click
        If objSBAccount.fnGetIntrestDet Then
            Dim dtRow As DataRow
            Dim lvItem As ListViewItem
            lvInterest.Items.Clear()
            For Each dtRow In objSBAccount.InterestDettable.Rows
                lvItem = lvInterest.Items.Add(dtRow.Item("AccountNo"))
                lvItem.SubItems.Add(dtRow.Item("Name"))
                lvItem.SubItems.Add(dtRow.Item("InterestAmount"))
                lvItem.SubItems.Add(dtRow.Item("AvailBalance"))
                lvItem.SubItems.Add(dtRow.Item("slNo"))
            Next
            bolLoad = True
            btnSave.Enabled = False
            btnPost.Enabled = True
        Else
            MsgBox("No items to load from database", MsgBoxStyle.Exclamation, "SB Module")
        End If
    End Sub

    Private Sub btnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettings.Click

        Dim objSBMasterSettings As New frmSBMasterSettings
        objSBMasterSettings.ShowDialog()

    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub
    Private Sub btnPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPost.Click

        Dim intCounter As Integer = 0
        Dim objTrans As IDbTransaction

        If lvInterest.CheckedItems.Count > 0 Then
            If MsgBox("Are you sure you want to post intrest?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Conforme") = MsgBoxResult.Yes Then
                Try


                    ProgressBar1.Maximum = lvInterest.Items.Count
                    objTrans = fnGetTransaction()
                    If bolLoad = True Then
                        For Each lvItems As ListViewItem In lvInterest.Items
                            If lvItems.Checked = True Then
                                objSBAccount.SBNo = lvItems.SubItems(0).Text
                                objSBAccount.IntAmt = lvItems.SubItems(2).Text
                                objSBAccount.FromPeriod = Format(DTPFrom.Value, "yyyy-MM-dd")
                                objSBAccount.ToPeriod = Format(DTPTo.Value, "yyyy-MM-dd")
                                objSBAccount.Status = "P"
                                fnGenerateIntPostVoucher(objTrans)
                                objSBAccount.fnUpdateInterest(lvItems.SubItems(4).Text, objTrans)
                            End If
                            ProgressBar1.Value += 1
                        Next
                    ElseIf bolLoad = False Then
                        For Each lvItems As ListViewItem In lvInterest.Items
                            objSBAccount.SBNo = lvItems.SubItems(0).Text
                            objSBAccount.IntAmt = lvItems.SubItems(2).Text
                            objSBAccount.FromPeriod = Format(DTPFrom.Value, "yyyy-MM-dd")
                            objSBAccount.ToPeriod = Format(DTPTo.Value, "yyyy-MM-dd")
                            If lvItems.Checked = True Then
                                objSBAccount.Status = "P"
                                fnGenerateIntPostVoucher(objTrans)
                            Else
                                objSBAccount.Status = "D"
                            End If
                            objSBAccount.fnPostInterest(objTrans)
                            ProgressBar1.Value += 1
                        Next
                    End If
                    objTrans.Commit()
                    ProgressBar1.Value = 0
                    MsgBox("Intrest posted successfully", MsgBoxStyle.Information, Me.Text)
                Catch ex As Exception
                    MsgBox("Interest posting failed. please try again.", MsgBoxStyle.Exclamation, Me.Text)
                Finally
                    objTrans.Dispose()
                End Try
                btnIntrestPayable_Click(sender, e)
                'btnSave.Enabled = True
            End If
        Else
            MsgBox("No records were selected, please select the records to delete", MsgBoxStyle.Information, Me.Text)
            lvInterest.Focus()
        End If
    End Sub

    'Public Function fnExecuteQuery123(ByVal strSQL As String, ByVal intReturnType As Integer) As Object

    '    'function used to execute any data retrieval queries against database
    '    'strSQL    ----- represents the query to be executed
    '    'intReturnType    ----- represents the return type required 
    '    'intReturnType = 1    ----dataset
    '    'intReturnType = 2    ----datatable

    '    Dim objConn As New Odbc.OdbcConnection(strODBCConnectionString)
    '    Dim cmd As New Odbc.OdbcCommand(strSQL, objConn)
    '    cmd.CommandTimeout = 150
    '    Dim objDA As New Odbc.OdbcDataAdapter(cmd)
    '    Dim objDT As New Data.DataTable
    '    Dim objDS As New Data.DataSet
    '    Try
    '        objConn.Open()
    '        If intReturnType = 1 Then
    '            objDA.Fill(objDS)
    '            Return objDS
    '        ElseIf intReturnType = 2 Then
    '            objDA.Fill(objDT)
    '            Return objDT
    '        End If
    '        Return Nothing
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Database Error")
    '        Return Nothing
    '    Finally
    '        objConn.Close()
    '    End Try

    'End Function

    'Private Function CalCulateInterest(ByVal strAccountNo As String, ByVal strAccName As String, ByVal dtstartDate As Date, ByVal dblBalance As Double)

    '    Dim objConn As New Odbc.OdbcConnection(strODBCConnectionString)
    '    Dim intStartMonth As Integer = Month(dtstartDate)
    '    Dim lngIntAmount As Decimal = 0
    '    Dim LvItem As ListViewItem
    '    'This is to loop Till duration of month
    '    While Month(dtstartDate) <> Month(DTPTo.Value) ' + 1
    '        Dim dtTemp As New DataTable
    '        Dim dtTemp1 As New DataTable
    '        Dim DTAnil As New DataTable
    '        Dim min1, min2 As Double

    '        Dim Anil As String = "Select * from sbtransactionTbl where AccountNo ='" & strAccountNo & "'"
    '        Dim objDAnil As New Odbc.OdbcDataAdapter(Anil, objConn)
    '        objConn.Open()
    '        objDAnil.Fill(DTAnil)
    '        objConn.Close()

    '        Dim foundRows() As DataRow
    '        Dim strDate As String = "Trdate >= '" & Format(dtstartDate, "yyyy-MM-10") & "' and Trdate <= '" & Format(dtstartDate, "yyyy-MM-31") & "'"
    '        foundRows = DTAnil.Select(strDate)
    '        Dim i As Integer
    '        For i = 0 To foundRows.GetUpperBound(0)
    '            ' Console.WriteLine(foundRows(i)(0))
    '            min1 = foundRows(i)(0)
    '        Next i

    '        Dim foundRows1() As DataRow
    '        Dim strDate1 As String = "Trdate < '" & Format(dtstartDate, "yyyy-MM-10") & "' "
    '        Dim strSort As String = "order by trdate Desc limit 1"
    '        foundRows1 = DTAnil.Select(strDate1)
    '        Dim i1 As Integer
    '        For i1 = 0 To foundRows1.GetUpperBound(0)
    '            ' Console.WriteLine(foundRows(i)(0))
    '            min2 = foundRows1(i1)("PostBal")
    '        Next i1

    '        'Dim Strsql As String = "select ifNull((select Min(Postbal) from sbtransactionTbl where AccountNo ='" & strAccountNo & "' and Trdate Between'" & Format(dtstartDate, "yyyy-MM-10") & "' and '" & Format(dtstartDate, "yyyy-MM-31") & "'),0)"

    '        'Dim objDA As New Odbc.OdbcDataAdapter(Strsql, objConn)
    '        'objConn.Open()
    '        'objDA.Fill(dtTemp1)
    '        'objConn.Close()

    '        'objConn.Open()
    '        'Dim strSql1 As String = "select postbal from sbtransactiontbl where AccountNo ='" & strAccountNo & "' and trdate < '" & Format(dtstartDate, "yyyy-MM-10") & "'  order by trdate Desc limit 1"
    '        'Dim objDA2 As New Odbc.OdbcDataAdapter(strSql1, objConn)
    '        'objDA2.Fill(dtTemp)
    '        'objConn.Close()
    '        ''dtTemp = fnExecuteQuery(strSql1, 2)
    '        ''dtTemp1 = fnExecuteQuery(Strsql, 2)
    '        ''min1 = fnExecuteQuery(Strsql, 2).rows(0).Item(0)
    '        'min1 = dtTemp1.Rows(0).Item(0)


    '        If dtTemp.Rows.Count = 0 Then
    '            If min1 > dblMinAmount Then
    '                lngIntAmount = lngIntAmount + min1
    '            End If
    '        ElseIf min1 = 0 Then
    '            'min2 = dtTemp.Rows(0).Item(0)
    '            If min2 > dblMinAmount Then
    '                lngIntAmount = lngIntAmount + min2
    '            End If
    '        Else
    '            'min2 = dtTemp.Rows(0).Item(0)
    '            If min1 > dblMinAmount And min2 > dblMinAmount Then
    '                lngIntAmount = lngIntAmount + IIf(min1 > min2, min2, min1)
    '            ElseIf min1 > dblMinAmount Then
    '                lngIntAmount = lngIntAmount + min1
    '            ElseIf min2 > dblMinAmount Then
    '                lngIntAmount = lngIntAmount + min2
    '            End If
    '        End If
    '        dtstartDate = dtstartDate.AddMonths(1)
    '    End While
    '    LvItem = lvInterest.Items.Add(strAccountNo)
    '    LvItem.SubItems.Add(strAccName)
    '    LvItem.SubItems.Add(Math.Round((lngIntAmount * Val(txtRoi.Text)) / (12 * 100), 2))
    '    LvItem.SubItems.Add(dblBalance)

    '    '        objConn.Close()
    'End Function

#End Region


End Class
