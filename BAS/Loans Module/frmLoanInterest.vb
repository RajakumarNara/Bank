
Public Class frmLoanInterest
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
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtROI As BankControls.NumericControl
    Friend WithEvents txtPenelInterest As BankControls.NumericControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkGoldLoan As System.Windows.Forms.CheckBox
    Friend WithEvents chkVehicleLoan As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents dtApplicableFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtApplicableTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents lvLoanInterest As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkOverDraft As System.Windows.Forms.CheckBox
    Friend WithEvents chkSuretyLoan As System.Windows.Forms.CheckBox
    Friend WithEvents chkHandLoan As System.Windows.Forms.CheckBox
    Friend WithEvents chkLoanOnDep As System.Windows.Forms.CheckBox
    Friend WithEvents chkCollHandLoan As System.Windows.Forms.CheckBox
    Friend WithEvents chkDailyRecoveryLoan As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label41 = New System.Windows.Forms.Label
        Me.txtROI = New BankControls.NumericControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPenelInterest = New BankControls.NumericControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtApplicableFrom = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtApplicableTo = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkDailyRecoveryLoan = New System.Windows.Forms.CheckBox
        Me.chkGoldLoan = New System.Windows.Forms.CheckBox
        Me.chkVehicleLoan = New System.Windows.Forms.CheckBox
        Me.chkLoanOnDep = New System.Windows.Forms.CheckBox
        Me.chkSuretyLoan = New System.Windows.Forms.CheckBox
        Me.chkCollHandLoan = New System.Windows.Forms.CheckBox
        Me.chkHandLoan = New System.Windows.Forms.CheckBox
        Me.chkOverDraft = New System.Windows.Forms.CheckBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.lvLoanInterest = New System.Windows.Forms.ListView
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(16, 16)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(124, 19)
        Me.Label41.TabIndex = 34
        Me.Label41.Text = "Rate Of Interest :"
        '
        'txtROI
        '
        Me.txtROI.AfterDecimal = 0
        Me.txtROI.BeforeDecimal = 2
        Me.txtROI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtROI.Location = New System.Drawing.Point(152, 16)
        Me.txtROI.LostFocusColour = System.Drawing.Color.Empty
        Me.txtROI.MaxLength = 3
        Me.txtROI.MaxValue = 0
        Me.txtROI.MinValue = 0
        Me.txtROI.Name = "txtROI"
        Me.txtROI.Size = New System.Drawing.Size(184, 23)
        Me.txtROI.TabIndex = 1
        Me.txtROI.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 19)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Penel Interest :"
        '
        'txtPenelInterest
        '
        Me.txtPenelInterest.AfterDecimal = 0
        Me.txtPenelInterest.BeforeDecimal = 2
        Me.txtPenelInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenelInterest.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPenelInterest.Location = New System.Drawing.Point(152, 56)
        Me.txtPenelInterest.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPenelInterest.MaxLength = 3
        Me.txtPenelInterest.MaxValue = 0
        Me.txtPenelInterest.MinValue = 0
        Me.txtPenelInterest.Name = "txtPenelInterest"
        Me.txtPenelInterest.Size = New System.Drawing.Size(184, 23)
        Me.txtPenelInterest.TabIndex = 2
        Me.txtPenelInterest.Text = ""
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dtApplicableFrom)
        Me.Panel1.Controls.Add(Me.Label41)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtPenelInterest)
        Me.Panel1.Controls.Add(Me.txtROI)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dtApplicableTo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 184)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(152, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 19)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "To"
        '
        'dtApplicableFrom
        '
        Me.dtApplicableFrom.CustomFormat = "dd-MM-yyyy"
        Me.dtApplicableFrom.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtApplicableFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtApplicableFrom.Location = New System.Drawing.Point(200, 104)
        Me.dtApplicableFrom.Name = "dtApplicableFrom"
        Me.dtApplicableFrom.Size = New System.Drawing.Size(136, 23)
        Me.dtApplicableFrom.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(152, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 19)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "From"
        '
        'dtApplicableTo
        '
        Me.dtApplicableTo.CustomFormat = "dd-MM-yyyy"
        Me.dtApplicableTo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtApplicableTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtApplicableTo.Location = New System.Drawing.Point(200, 144)
        Me.dtApplicableTo.Name = "dtApplicableTo"
        Me.dtApplicableTo.Size = New System.Drawing.Size(136, 23)
        Me.dtApplicableTo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 19)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Applicable :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkDailyRecoveryLoan)
        Me.GroupBox1.Controls.Add(Me.chkGoldLoan)
        Me.GroupBox1.Controls.Add(Me.chkVehicleLoan)
        Me.GroupBox1.Controls.Add(Me.chkLoanOnDep)
        Me.GroupBox1.Controls.Add(Me.chkSuretyLoan)
        Me.GroupBox1.Controls.Add(Me.chkCollHandLoan)
        Me.GroupBox1.Controls.Add(Me.chkHandLoan)
        Me.GroupBox1.Controls.Add(Me.chkOverDraft)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(368, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 184)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Applcable To Loans"
        '
        'chkDailyRecoveryLoan
        '
        Me.chkDailyRecoveryLoan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDailyRecoveryLoan.Location = New System.Drawing.Point(168, 144)
        Me.chkDailyRecoveryLoan.Name = "chkDailyRecoveryLoan"
        Me.chkDailyRecoveryLoan.Size = New System.Drawing.Size(128, 32)
        Me.chkDailyRecoveryLoan.TabIndex = 12
        Me.chkDailyRecoveryLoan.Text = "Daily Recovery Loan "
        '
        'chkGoldLoan
        '
        Me.chkGoldLoan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGoldLoan.Location = New System.Drawing.Point(16, 32)
        Me.chkGoldLoan.Name = "chkGoldLoan"
        Me.chkGoldLoan.Size = New System.Drawing.Size(120, 24)
        Me.chkGoldLoan.TabIndex = 5
        Me.chkGoldLoan.Text = "Jewel Loan"
        '
        'chkVehicleLoan
        '
        Me.chkVehicleLoan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVehicleLoan.Location = New System.Drawing.Point(16, 72)
        Me.chkVehicleLoan.Name = "chkVehicleLoan"
        Me.chkVehicleLoan.Size = New System.Drawing.Size(112, 24)
        Me.chkVehicleLoan.TabIndex = 6
        Me.chkVehicleLoan.Text = "Vehicle Loan"
        '
        'chkLoanOnDep
        '
        Me.chkLoanOnDep.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLoanOnDep.Location = New System.Drawing.Point(168, 104)
        Me.chkLoanOnDep.Name = "chkLoanOnDep"
        Me.chkLoanOnDep.Size = New System.Drawing.Size(128, 32)
        Me.chkLoanOnDep.TabIndex = 10
        Me.chkLoanOnDep.Text = "Loans On Term Deposit"
        '
        'chkSuretyLoan
        '
        Me.chkSuretyLoan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSuretyLoan.Location = New System.Drawing.Point(168, 32)
        Me.chkSuretyLoan.Name = "chkSuretyLoan"
        Me.chkSuretyLoan.Size = New System.Drawing.Size(112, 24)
        Me.chkSuretyLoan.TabIndex = 8
        Me.chkSuretyLoan.Text = "Surety Loan"
        '
        'chkCollHandLoan
        '
        Me.chkCollHandLoan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCollHandLoan.Location = New System.Drawing.Point(16, 104)
        Me.chkCollHandLoan.Name = "chkCollHandLoan"
        Me.chkCollHandLoan.Size = New System.Drawing.Size(144, 32)
        Me.chkCollHandLoan.TabIndex = 7
        Me.chkCollHandLoan.Text = "Colleteral Hand Loan"
        '
        'chkHandLoan
        '
        Me.chkHandLoan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHandLoan.Location = New System.Drawing.Point(168, 72)
        Me.chkHandLoan.Name = "chkHandLoan"
        Me.chkHandLoan.Size = New System.Drawing.Size(96, 24)
        Me.chkHandLoan.TabIndex = 9
        Me.chkHandLoan.Text = "Hand Loan"
        '
        'chkOverDraft
        '
        Me.chkOverDraft.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOverDraft.Location = New System.Drawing.Point(16, 144)
        Me.chkOverDraft.Name = "chkOverDraft"
        Me.chkOverDraft.Size = New System.Drawing.Size(120, 24)
        Me.chkOverDraft.TabIndex = 11
        Me.chkOverDraft.Text = "Over Draft "
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(480, 208)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(72, 32)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "S&ave"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(544, 432)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 32)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "C&lose"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(552, 208)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(72, 32)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        '
        'lvLoanInterest
        '
        Me.lvLoanInterest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvLoanInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLoanInterest.FullRowSelect = True
        Me.lvLoanInterest.GridLines = True
        Me.lvLoanInterest.Location = New System.Drawing.Point(24, 248)
        Me.lvLoanInterest.MultiSelect = False
        Me.lvLoanInterest.Name = "lvLoanInterest"
        Me.lvLoanInterest.Size = New System.Drawing.Size(624, 176)
        Me.lvLoanInterest.TabIndex = 14
        Me.lvLoanInterest.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "SLNo"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "LoanType"
        Me.ColumnHeader1.Width = 107
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "RateOfInterest"
        Me.ColumnHeader2.Width = 99
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PenelInterest"
        Me.ColumnHeader3.Width = 98
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ApplicableFrom"
        Me.ColumnHeader4.Width = 117
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ApplicableTo"
        Me.ColumnHeader5.Width = 119
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Firebrick
        Me.Label5.Location = New System.Drawing.Point(16, 440)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(416, 16)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "* *Interset To Be Applied In Presence Of Adminstrator Only."
        '
        'frmLoanInterest
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(680, 469)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lvLoanInterest)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoanInterest"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoanInterest"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmLoanInterest
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmLoanInterest
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmLoanInterest
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmLoanInterest)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Varaibles"

    Dim objLoanInterest As New clsLoanInterest
    Dim lstvItems As ListViewItem

#End Region

#Region "function"

    Public Function fnSetData() As Boolean

        objLoanInterest.ROI = CDbl(txtROI.Text / 100)

        objLoanInterest.PI = (txtPenelInterest.Text / 100)
        objLoanInterest.ApplFromDate = Format(dtApplicableFrom.Value, "yyyy-MM-dd")
        objLoanInterest.ApplToDate = Format(dtApplicableTo.Value, "yyyy-MM-dd")

        If chkGoldLoan.Checked = True Then
            objLoanInterest.GoldLoan = "Y"
        Else
            objLoanInterest.GoldLoan = "N"
        End If

        'If chkHomeLoan.Checked = True Then
        '    objLoanInterest.HomeLoan = "Y"
        'Else
        '    objLoanInterest.HomeLoan = "N"
        'End If

        If chkVehicleLoan.Checked = True Then
            objLoanInterest.VehicleLoan = "Y"
        Else
            objLoanInterest.VehicleLoan = "N"
        End If

        'If chkDemandLoan.Checked = True Then
        '    objLoanInterest.DemandLoan = "Y"
        'Else
        '    objLoanInterest.DemandLoan = "N"
        'End If

        If chkHandLoan.Checked = True Then
            objLoanInterest.HandLoan = "Y"
        Else
            objLoanInterest.HandLoan = "N"
        End If

        If chkSuretyLoan.Checked = True Then
            objLoanInterest.SuretyLoan = "Y"
        Else
            objLoanInterest.SuretyLoan = "N"
        End If

        If chkCollHandLoan.Checked = True Then
            objLoanInterest.ColleteralHandLoan = "Y"
        Else
            objLoanInterest.ColleteralHandLoan = "N"
        End If

        If chkLoanOnDep.Checked = True Then
            objLoanInterest.LoansOnDeposit = "Y"
        Else
            objLoanInterest.LoansOnDeposit = "N"
        End If

        If chkOverDraft.Checked = True Then
            objLoanInterest.OverDraftLoan = "Y"
        Else
            objLoanInterest.OverDraftLoan = "N"
        End If

        If chkDailyRecoveryLoan.Checked = True Then
            objLoanInterest.DailyRecoveryLoan = "Y"
        Else
            objLoanInterest.DailyRecoveryLoan = "N"
        End If

        Return True

    End Function

    Public Function fnCheck() As Boolean

        If Trim(txtROI.Text) = String.Empty Then
            MsgBox("Rate of interest cannot be null", MsgBoxStyle.Information)
            txtROI.Focus()
            Return False

        ElseIf Trim(txtPenelInterest.Text) = String.Empty Then
            MsgBox("Penel interest cannot be null", MsgBoxStyle.Information)
            txtPenelInterest.Focus()
            Return False

        ElseIf Trim(txtROI.Text) = 0 Then
            MsgBox("Rate of interest cannot be zero", MsgBoxStyle.Information)
            txtROI.Focus()
            Return False

        ElseIf Trim(txtPenelInterest.Text) = 0 Then
            MsgBox("Penel interest cannot be zero", MsgBoxStyle.Information)
            txtPenelInterest.Focus()
            Return False

        Else

            Return True

        End If

    End Function

    Public Function fnAddROI(ByVal objTrans As IDbTransaction) As Boolean

        If chkGoldLoan.Checked = True Then
            If objLoanInterest.fnCheckROI(1) Then
                objLoanInterest.fnUpdateGoldROI(objTrans)
            Else
                objLoanInterest.LoanType = "JewelLoan"
                objLoanInterest.fnInsertROI(1, objTrans)
            End If
        Else
        End If

        'If chkHomeLoan.Checked = True Then
        '    If objLoanInterest.fnCheckROI(6) Then
        '        objLoanInterest.fnUpdateHomeROI()
        '    Else
        '        objLoanInterest.LoanType = "HomeLoan"
        '        objLoanInterest.fnInsertROI(6)
        '    End If

        'Else

        'End If

        If chkVehicleLoan.Checked = True Then
            If objLoanInterest.fnCheckROI(2) Then
                objLoanInterest.fnUpdateVehicleROI(objTrans)
            Else
                objLoanInterest.LoanType = "VehicleLoan"
                objLoanInterest.fnInsertROI(2, objTrans)
            End If

        Else

        End If

        If chkSuretyLoan.Checked = True Then
            If objLoanInterest.fnCheckROI(3) Then
                objLoanInterest.fnUpdateSuretyROI(objTrans)
            Else
                objLoanInterest.LoanType = "SuretyLoan"
                objLoanInterest.fnInsertROI(3, objTrans)
            End If
        Else

        End If

        If chkHandLoan.Checked = True Then
            If objLoanInterest.fnCheckROI(4) Then
                objLoanInterest.fnUpdateHandROI(objTrans)
            Else
                objLoanInterest.LoanType = "HandLoan"
                objLoanInterest.fnInsertROI(4, objTrans)
            End If
        Else

        End If

        'If chkDemandLoan.Checked = True Then
        '    If objLoanInterest.fnCheckROI(5) Then
        '        objLoanInterest.fnUpdateDeamandROI()
        '    Else
        '        objLoanInterest.LoanType = "DemandLoan"
        '        objLoanInterest.fnInsertROI(5)
        '    End If

        'Else

        '    End If

        '    If chkMediumLoan.Checked = True Then
        '    If objLoanInterest.fnCheckROI(4) Then
        '        objLoanInterest.fnUpdateMediumROI()
        '    Else
        '        objLoanInterest.LoanType = "MediumLoan"
        '        objLoanInterest.fnInsertROI(4)
        '    End If

        'Else

        '    End If

        'If chkKisanLoan.Checked = True Then
        '    If objLoanInterest.fnCheckROI(3) Then
        '        objLoanInterest.fnUpdateKisanROI()
        '    Else
        '        objLoanInterest.LoanType = "KisanLoan"
        '        objLoanInterest.fnInsertROI(3)
        '    End If

        'Else

        'End If
        If chkOverDraft.Checked = True Then
            If objLoanInterest.fnCheckROI(7) Then
                objLoanInterest.fnUpdateOverDraftROI(objTrans)
            Else
                objLoanInterest.LoanType = "OverDraft"
                objLoanInterest.fnInsertROI(7, objTrans)
            End If

        Else

        End If

        If chkCollHandLoan.Checked = True Then
            If objLoanInterest.fnCheckROI(5) Then
                objLoanInterest.fnUpdateColleteralHandLoanROI(objTrans)
            Else
                objLoanInterest.LoanType = "ColleteralHandLoan"
                objLoanInterest.fnInsertROI(5, objTrans)
            End If
        Else
        End If

        If chkLoanOnDep.Checked = True Then
            If objLoanInterest.fnCheckROI(6) Then
                objLoanInterest.fnUpdateLoansOnDepositROI()
            Else
                objLoanInterest.LoanType = "LoansOnTermDeposit"
                objLoanInterest.fnInsertROI(6, objTrans)
            End If
        Else
        End If
        If chkDailyRecoveryLoan.Checked = True Then
            If objLoanInterest.fnCheckROI(8) Then
                objLoanInterest.fnUpdateDailyRecoveryLoanROI(objTrans)
            Else
                objLoanInterest.LoanType = "SouhardaDailyRecoveryLaon"
                objLoanInterest.fnInsertROI(8, objTrans)
            End If
        Else
        End If

        Return True

    End Function

    Public Function fnClear()

        txtROI.Text = ""
        txtPenelInterest.Text = ""
        'chkDemandLoan.Checked = False
        chkGoldLoan.Checked = False
        'chkHomeLoan.Checked = False
        chkLoanOnDep.Checked = False
        chkCollHandLoan.Checked = False
        chkVehicleLoan.Checked = False
        chkHandLoan.Checked = False
        chkSuretyLoan.Checked = False
        chkOverDraft.Checked = False
        chkDailyRecoveryLoan.Checked = False

    End Function

    Public Function fnGetData() As Boolean
        Dim intCount As Integer = 0
        lvLoanInterest.Items.Clear()

        If objLoanInterest.fnGetData Then

            While intCount < objLoanInterest.LoanInteresttable.Rows.Count

                lstvItems = lvLoanInterest.Items.Add(objLoanInterest.LoanInteresttable.Rows(intCount).Item("LoanSLNo"))
                lstvItems.SubItems.Add(objLoanInterest.LoanInteresttable.Rows(intCount).Item("LoanType"))
                lstvItems.SubItems.Add(objLoanInterest.LoanInteresttable.Rows(intCount).Item("ROI"))
                lstvItems.SubItems.Add(objLoanInterest.LoanInteresttable.Rows(intCount).Item("PI"))
                lstvItems.SubItems.Add(Format(objLoanInterest.LoanInteresttable.Rows(intCount).Item("ApplicableFrom"), "yyyy-MM-dd"))
                lstvItems.SubItems.Add(Format(objLoanInterest.LoanInteresttable.Rows(intCount).Item("ApplicableTo"), "yyyy-MM-dd"))
                intCount += 1

            End While

        End If

    End Function

#End Region

#Region "Events"

#End Region


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then

                If fnSetData() Then

                    If fnAddROI(objTrans) Then
                        objTrans.Commit()

                        MsgBox("New rate of interest configured successfully", MsgBoxStyle.Information, " Master Settings")

                    Else

                        MsgBox("Error! due to internal problem", MsgBoxStyle.Exclamation, "Master Settings")

                    End If

                    fnClear()

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        fnClear()

    End Sub

    Private Sub frmLoanInterest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fnGetData()

    End Sub

    Private Sub frmLoanInterest_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        fnGetData()

    End Sub

End Class
