Public Class frmLoanIntrestSettins
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtApplicableFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPenelInterest As BankControls.NumericControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtApplicableTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pnlIntSettings As System.Windows.Forms.Panel
    Friend WithEvents lvLoanInterest As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents cmbLoanType As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLoanIntrestSettins))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbLoanType = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtApplicableFrom = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPenelInterest = New BankControls.NumericControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtApplicableTo = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.pnlIntSettings = New System.Windows.Forms.Panel
        Me.lvLoanInterest = New System.Windows.Forms.ListView
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cmbLoanType)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dtApplicableFrom)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtPenelInterest)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dtApplicableTo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(272, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 168)
        Me.Panel1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Loan Type :"
        '
        'cmbLoanType
        '
        Me.cmbLoanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoanType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoanType.ForeColor = System.Drawing.Color.Black
        Me.cmbLoanType.ItemHeight = 16
        Me.cmbLoanType.Items.AddRange(New Object() {"Jewel Loan", "Vehicle Loan", "Surety Loan", "Hand Loan", "Over Draft", "Colleteral Hand Loan", "Loans On Term Deposit", "Souharda Daily Recovery Laon", "Clearing Bill Purchase"})
        Me.cmbLoanType.Location = New System.Drawing.Point(120, 8)
        Me.cmbLoanType.Name = "cmbLoanType"
        Me.cmbLoanType.Size = New System.Drawing.Size(200, 24)
        Me.cmbLoanType.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(176, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "To"
        '
        'dtApplicableFrom
        '
        Me.dtApplicableFrom.CustomFormat = "dd-MM-yyyy"
        Me.dtApplicableFrom.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtApplicableFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtApplicableFrom.Location = New System.Drawing.Point(16, 96)
        Me.dtApplicableFrom.Name = "dtApplicableFrom"
        Me.dtApplicableFrom.Size = New System.Drawing.Size(136, 23)
        Me.dtApplicableFrom.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 19)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Penel Interest :"
        '
        'txtPenelInterest
        '
        Me.txtPenelInterest.AfterDecimal = 2
        Me.txtPenelInterest.BeforeDecimal = 2
        Me.txtPenelInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenelInterest.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtPenelInterest.Location = New System.Drawing.Point(136, 128)
        Me.txtPenelInterest.LostFocusColour = System.Drawing.Color.Empty
        Me.txtPenelInterest.MaxLength = 5
        Me.txtPenelInterest.MaxValue = 0
        Me.txtPenelInterest.MinValue = 0
        Me.txtPenelInterest.Name = "txtPenelInterest"
        Me.txtPenelInterest.Size = New System.Drawing.Size(64, 23)
        Me.txtPenelInterest.TabIndex = 5
        Me.txtPenelInterest.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 72)
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
        Me.dtApplicableTo.Location = New System.Drawing.Point(176, 96)
        Me.dtApplicableTo.Name = "dtApplicableTo"
        Me.dtApplicableTo.Size = New System.Drawing.Size(136, 23)
        Me.dtApplicableTo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 19)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Applicable :"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(304, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = "From Amt"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(432, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 143
        Me.Label7.Text = "To Amt"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(560, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 144
        Me.Label8.Text = "ROI"
        '
        'pnlIntSettings
        '
        Me.pnlIntSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlIntSettings.AutoScroll = True
        Me.pnlIntSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlIntSettings.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlIntSettings.Location = New System.Drawing.Point(272, 224)
        Me.pnlIntSettings.Name = "pnlIntSettings"
        Me.pnlIntSettings.Size = New System.Drawing.Size(352, 168)
        Me.pnlIntSettings.TabIndex = 142
        '
        'lvLoanInterest
        '
        Me.lvLoanInterest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader1})
        Me.lvLoanInterest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLoanInterest.FullRowSelect = True
        Me.lvLoanInterest.GridLines = True
        Me.lvLoanInterest.Location = New System.Drawing.Point(20, 64)
        Me.lvLoanInterest.MultiSelect = False
        Me.lvLoanInterest.Name = "lvLoanInterest"
        Me.lvLoanInterest.Size = New System.Drawing.Size(244, 384)
        Me.lvLoanInterest.TabIndex = 146
        Me.lvLoanInterest.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "SLNo"
        Me.ColumnHeader6.Width = 41
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "LoanType"
        Me.ColumnHeader1.Width = 180
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(424, 424)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(72, 32)
        Me.btnSave.TabIndex = 147
        Me.btnSave.Text = "S&ave"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(312, 424)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(72, 32)
        Me.btnClear.TabIndex = 148
        Me.btnClear.Text = "Clear"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(536, 424)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 32)
        Me.btnClose.TabIndex = 149
        Me.btnClose.Text = "C&lose"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 151
        Me.PictureBox1.TabStop = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label32.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(64, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(116, 25)
        Me.Label32.TabIndex = 150
        Me.Label32.Text = "Loan Master"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmLoanIntrestSettins
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(640, 469)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lvLoanInterest)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.pnlIntSettings)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoanIntrestSettins"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Intrest Settins"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmLoanIntrestSettins
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmLoanIntrestSettins
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmLoanIntrestSettins
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmLoanIntrestSettins)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region

#Region "Global Variables"
    Dim objCtrl(5) As LoanIntSettingCtrl
    Dim dtIntrSettings As DataTable
    ' Dim objFDAcc As New clsFDAccount

    Dim objLoanInterest As New clsLoanInterest
    Dim lstvItems As ListViewItem

#End Region

#Region "Function"

    Public Function fnLoadIntrCtrl()
        Dim intCount As Integer
        Dim ctrlHt As Integer

        While intCount < 5
            objCtrl(intCount) = New LoanIntSettingCtrl
            ctrlHt = (objCtrl(intCount).Height)
            objCtrl(intCount).Top = ctrlHt * intCount
            pnlIntSettings.Controls.Add(objCtrl(intCount))
            intCount += 1
        End While
    End Function

#End Region


#Region "function"

    Public Function fnSetData() As Boolean

        objLoanInterest.PI = (txtPenelInterest.Text)
        objLoanInterest.ApplFromDate = Format(dtApplicableFrom.Value, "yyyy-MM-dd")
        objLoanInterest.ApplToDate = Format(dtApplicableTo.Value, "yyyy-MM-dd")

        Dim str As String = cmbLoanType.SelectedItem

        Select Case str
            Case "Jewel Loan"
                objLoanInterest.SlNo = 1
                objLoanInterest.LoanType = "Jewel Loan"
            Case "Vehicle Loan"
                objLoanInterest.SlNo = 2
                objLoanInterest.LoanType = "Vehicle Loan"

            Case "Surety Loan"
                objLoanInterest.SlNo = 3
                objLoanInterest.LoanType = "Surety Loan"

            Case "Hand Loan"
                objLoanInterest.SlNo = 4
                objLoanInterest.LoanType = "Hand Loan"

            Case "Colleteral Hand Loan"
                objLoanInterest.SlNo = 5
                objLoanInterest.LoanType = "Colleteral Hand Loan"

            Case "Loans On Term Deposit"
                objLoanInterest.SlNo = 6
                objLoanInterest.LoanType = "Loans On Term Deposit"

            Case "Over Draft"
                objLoanInterest.SlNo = 7
                objLoanInterest.LoanType = "Over Draft"

            Case "Souharda Daily Recovery Laon"
                objLoanInterest.SlNo = 8
                objLoanInterest.LoanType = "Souharda Daily Recovery Laon"

            Case "Clearing Bill Purchase"
                objLoanInterest.SlNo = 9
                objLoanInterest.LoanType = "Clearing Bill Purchase"

        End Select


        Dim dtROI As LoanIntSettingCtrl
        Dim intCount As Integer
        Dim drRow As DataRow
        dtIntrSettings = New DataTable
        dtIntrSettings.Columns.Add("LoanSlNo")
        dtIntrSettings.Columns.Add("FromPeriod")
        dtIntrSettings.Columns.Add("ToPeriod")
        dtIntrSettings.Columns.Add("ROI")

        While intCount < pnlIntSettings.Controls.Count
            drRow = dtIntrSettings.NewRow
            dtROI = pnlIntSettings.Controls(intCount)
            drRow(0) = objLoanInterest.SlNo
            If dtROI.txtFrom.Text <> "" Then
                drRow(1) = dtROI.txtFrom.Text
                drRow(2) = dtROI.txtTo.Text
                drRow(3) = dtROI.txtROI.Text
                dtIntrSettings.Rows.Add(drRow)
            End If
            intCount += 1
        End While
        objLoanInterest.LoanMasterTable = dtIntrSettings


        'If chkGoldLoan.Checked = True Then
        '    objLoanInterest.GoldLoan = "Y"
        'Else
        '    objLoanInterest.GoldLoan = "N"
        'End If

        'If chkVehicleLoan.Checked = True Then
        '    objLoanInterest.VehicleLoan = "Y"
        'Else
        '    objLoanInterest.VehicleLoan = "N"
        'End If

        'If chkHandLoan.Checked = True Then
        '    objLoanInterest.HandLoan = "Y"
        'Else
        '    objLoanInterest.HandLoan = "N"
        'End If

        'If chkSuretyLoan.Checked = True Then
        '    objLoanInterest.SuretyLoan = "Y"
        'Else
        '    objLoanInterest.SuretyLoan = "N"
        'End If

        'If chkCollHandLoan.Checked = True Then
        '    objLoanInterest.ColleteralHandLoan = "Y"
        'Else
        '    objLoanInterest.ColleteralHandLoan = "N"
        'End If

        'If chkLoanOnDep.Checked = True Then
        '    objLoanInterest.LoansOnDeposit = "Y"
        'Else
        '    objLoanInterest.LoansOnDeposit = "N"
        'End If

        'If chkOverDraft.Checked = True Then
        '    objLoanInterest.OverDraftLoan = "Y"
        'Else
        '    objLoanInterest.OverDraftLoan = "N"
        'End If

        'If chkDailyRecoveryLoan.Checked = True Then
        '    objLoanInterest.DailyRecoveryLoan = "Y"
        'Else
        '    objLoanInterest.DailyRecoveryLoan = "N"
        'End If

        Return True

    End Function

    Public Function fnCheck() As Boolean

        If Trim(txtPenelInterest.Text) = String.Empty Then
            MsgBox("Penel interest cannot be null", MsgBoxStyle.Information)
            txtPenelInterest.Focus()
            Return False
            'ElseIf Trim(txtPenelInterest.Text) = 0 Then
            '    MsgBox("Penel Interest Cannot Be Zero", MsgBoxStyle.Information)
            '    txtPenelInterest.Focus()
            '    Return False
        Else

            Return True

        End If

    End Function

    Public Function fnAddROI(ByVal objTrans As IDbTransaction) As Boolean

        If objLoanInterest.fnCheckROI() Then
            objLoanInterest.fnUpdateLoan(objTrans)
            objLoanInterest.fnDeleteIntrSettings(objTrans)
            objLoanInterest.fnInsertROI(objTrans)
        Else
            objLoanInterest.fnInsertLoan(objTrans)
            objLoanInterest.fnInsertROI(objTrans)
        End If


        'If chkGoldLoan.Checked = True Then
        '    If objLoanInterest.fnCheckROI(1) Then
        '        objLoanInterest.fnUpdateLoan(1)
        '        objLoanInterest.fnDeleteIntrSettings(1)
        '        objLoanInterest.fnInsertROI(1)
        '    Else
        '        objLoanInterest.LoanType = "JewelLoan"
        '        objLoanInterest.fnInsertLoan(1)
        '        objLoanInterest.fnInsertROI(1)
        '    End If
        'Else
        'End If

        'If chkVehicleLoan.Checked = True Then
        '    If objLoanInterest.fnCheckROI(2) Then
        '        objLoanInterest.fnUpdateLoan(2)
        '        objLoanInterest.fnDeleteIntrSettings(2)
        '        objLoanInterest.fnInsertROI(2)
        '    Else
        '        objLoanInterest.LoanType = "VehicleLoan"
        '        objLoanInterest.fnInsertLoan(2)
        '        objLoanInterest.fnInsertROI(2)
        '    End If
        'Else

        'End If

        'If chkSuretyLoan.Checked = True Then
        '    If objLoanInterest.fnCheckROI(3) Then
        '        objLoanInterest.fnUpdateLoan(3)
        '        objLoanInterest.fnDeleteIntrSettings(3)
        '        objLoanInterest.fnInsertROI(3)
        '    Else
        '        objLoanInterest.LoanType = "SuretyLoan"
        '        objLoanInterest.fnInsertLoan(3)
        '        objLoanInterest.fnInsertROI(3)
        '    End If
        'Else

        'End If

        'If chkHandLoan.Checked = True Then
        '    If objLoanInterest.fnCheckROI(4) Then
        '        objLoanInterest.fnUpdateLoan(4)
        '        objLoanInterest.fnDeleteIntrSettings(4)
        '        objLoanInterest.fnInsertROI(4)
        '    Else
        '        objLoanInterest.LoanType = "HandLoan"
        '        objLoanInterest.fnInsertLoan(4)
        '        objLoanInterest.fnInsertROI(4)
        '    End If

        'Else

        'End If

        'If chkOverDraft.Checked = True Then
        '    If objLoanInterest.fnCheckROI(7) Then
        '        objLoanInterest.fnUpdateLoan(7)
        '        objLoanInterest.fnDeleteIntrSettings(7)
        '        objLoanInterest.fnInsertROI(7)
        '    Else
        '        objLoanInterest.LoanType = "OverDraft"
        '        objLoanInterest.fnInsertLoan(7)
        '        objLoanInterest.fnInsertROI(7)
        '    End If
        'Else

        'End If

        'If chkCollHandLoan.Checked = True Then
        '    If objLoanInterest.fnCheckROI(5) Then
        '        objLoanInterest.fnUpdateLoan(5)
        '        objLoanInterest.fnDeleteIntrSettings(5)
        '        objLoanInterest.fnInsertROI(5)
        '    Else
        '        objLoanInterest.LoanType = "ColleteralHandLoan"
        '        objLoanInterest.fnInsertLoan(5)
        '        objLoanInterest.fnInsertROI(5)
        '    End If
        'Else
        'End If

        'If chkLoanOnDep.Checked = True Then
        '    If objLoanInterest.fnCheckROI(6) Then
        '        objLoanInterest.fnUpdateLoan(6)
        '        objLoanInterest.fnDeleteIntrSettings(6)
        '        objLoanInterest.fnInsertROI(6)
        '    Else
        '        objLoanInterest.LoanType = "LoansOnTermDeposit"
        '        objLoanInterest.fnInsertLoan(6)
        '        objLoanInterest.fnInsertROI(6)
        '    End If
        'Else
        'End If
        'If chkDailyRecoveryLoan.Checked = True Then
        '    If objLoanInterest.fnCheckROI(8) Then
        '        objLoanInterest.fnUpdateLoan(8)
        '        objLoanInterest.fnDeleteIntrSettings(8)
        '        objLoanInterest.fnInsertROI(8)
        '    Else
        '        objLoanInterest.LoanType = "SouhardaDailyRecoveryLaon"
        '        objLoanInterest.fnInsertLoan(8)
        '        objLoanInterest.fnInsertROI(8)
        '    End If
        'Else
        'End If
        Return True
    End Function

    Public Function fnLoadSettings() As Boolean

    End Function

    Public Function fnClear()

        txtPenelInterest.Text = ""
        cmbLoanType.SelectedIndex = -1

        Dim objIntrSet As DataTable
        Dim intCount As Integer

        While intCount < pnlIntSettings.Controls.Count
            objCtrl(intCount).txtFrom.Text = ""
            objCtrl(intCount).txtTo.Text = ""
            objCtrl(intCount).txtROI.Text = ""
            intCount += 1
        End While
    End Function

    Public Function fnGetData() As Boolean
        Dim intCount As Integer = 0
        lvLoanInterest.Items.Clear()
        If objLoanInterest.fnGetData Then
            While intCount < objLoanInterest.LoanInteresttable.Rows.Count
                lstvItems = lvLoanInterest.Items.Add(objLoanInterest.LoanInteresttable.Rows(intCount).Item("LoanSLNo"))
                lstvItems.SubItems.Add(objLoanInterest.LoanInteresttable.Rows(intCount).Item("LoanType"))
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
        dtApplicableFrom.MaxDate = Date.Now
        dtApplicableFrom.Value = Date.Now
        dtApplicableTo.MaxDate = Date.Now
        dtApplicableTo.Value = Date.Now

        fnLoadIntrCtrl()
        fnGetData()

    End Sub

    Private Sub frmLoanInterest_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        fnGetData()

    End Sub

    Private Sub lvLoanInterest_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLoanInterest.SelectedIndexChanged
        If lvLoanInterest.SelectedIndices.Count > 0 Then
            fnClear()
            Dim LoanSlNo As Integer = lvLoanInterest.SelectedItems(0).SubItems(0).Text
            cmbLoanType.Text = lvLoanInterest.SelectedItems(0).SubItems(1).Text
            If objLoanInterest.fnCheckROI(LoanSlNo) Then
                'LoanInteresttable()
                txtPenelInterest.Text = objLoanInterest.LoanInteresttable.Rows(0).Item("PI")
                dtApplicableFrom.Value = Format(objLoanInterest.LoanInteresttable.Rows(0).Item("ApplicableFrom"), "yyyy-MM-dd")
                dtApplicableTo.Value = Format(objLoanInterest.LoanInteresttable.Rows(0).Item("ApplicableTo"), "yyyy-MM-dd")
            End If

            Dim objIntrSet As DataTable
            Dim intCount As Integer

            If objLoanInterest.fnGetROI(LoanSlNo) Then
                objIntrSet = objLoanInterest.LoanInteresttable

                While intCount < objIntrSet.Rows.Count
                    objCtrl(intCount).txtFrom.Text = objIntrSet.Rows(intCount).Item("FromAmt")
                    objCtrl(intCount).txtTo.Text = objIntrSet.Rows(intCount).Item("ToAmt")
                    objCtrl(intCount).txtROI.Text = objIntrSet.Rows(intCount).Item("ROI")
                    intCount += 1
                End While
            End If

        End If

    End Sub

    Private Sub cmbLoanType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbLoanType.SelectedIndexChanged
        If cmbLoanType.SelectedItem = "Clearing Bill Purchase" Then
            Label1.Text = "Interest:"
        Else
            Label1.Text = "Penel Interest:"
        End If
    End Sub
End Class
