Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Globalization
Class frmSBStmtOfAccount
    Inherits System.Windows.Forms.Form

    Private Shared m_FormDefInstance As frmSBStmtOfAccount
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As frmSBStmtOfAccount
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmSBStmtOfAccount
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmSBStmtOfAccount)
            m_FormDefInstance = Value
        End Set
    End Property

#Region "Form Global Variables"
    Dim objSBAccount As New clsSavingsBank
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As BankControls.NewButton
    Friend WithEvents txtAccno As BankControls.TextControl
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As BankControls.NewButton
    Friend WithEvents btnPrint As BankControls.NewButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTPFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lvStmtOfAcc As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSBStmtOfAccount))
        Me.txtAccno = New BankControls.TextControl
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnPrint = New BankControls.NewButton
        Me.btnCancel = New BankControls.NewButton
        Me.btnSearch = New BankControls.NewButton
        Me.txtName = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.DTPFrom = New System.Windows.Forms.DateTimePicker
        Me.DTPTo = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lvStmtOfAcc = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAccno
        '
        Me.txtAccno.AlphaNumeric = True
        Me.txtAccno.BackColor = System.Drawing.Color.White
        Me.txtAccno.BlankSpace = False
        Me.txtAccno.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccno.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtAccno.Location = New System.Drawing.Point(104, 24)
        Me.txtAccno.LostFocusColour = System.Drawing.Color.Empty
        Me.txtAccno.Mandatory = False
        Me.txtAccno.Name = "txtAccno"
        Me.txtAccno.ReadOnly = True
        Me.txtAccno.Size = New System.Drawing.Size(152, 23)
        Me.txtAccno.SpecialChar = False
        Me.txtAccno.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 16)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Account No. :"
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(12, 407)
        Me.btnPrint.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(120, 40)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "&Print"
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(512, 408)
        Me.btnCancel.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 40)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "&Cancel"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(264, 24)
        Me.btnSearch.LostFocusColour = System.Drawing.SystemColors.Control
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 24)
        Me.btnSearch.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = False
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BlankSpace = False
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(384, 24)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(232, 23)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(328, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Name :"
        '
        'DTPFrom
        '
        Me.DTPFrom.CustomFormat = "dd-MMM-yyyy"
        Me.DTPFrom.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFrom.Location = New System.Drawing.Point(136, 40)
        Me.DTPFrom.Name = "DTPFrom"
        Me.DTPFrom.Size = New System.Drawing.Size(152, 23)
        Me.DTPFrom.TabIndex = 4
        '
        'DTPTo
        '
        Me.DTPTo.CustomFormat = "dd-MMM-yyyy"
        Me.DTPTo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTo.Location = New System.Drawing.Point(360, 41)
        Me.DTPTo.Name = "DTPTo"
        Me.DTPTo.Size = New System.Drawing.Size(168, 23)
        Me.DTPTo.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "From :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(312, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "To :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 16)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "Displaying Transactions"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DTPFrom)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DTPTo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(8, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(712, 72)
        Me.Panel1.TabIndex = 3
        '
        'lvStmtOfAcc
        '
        Me.lvStmtOfAcc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvStmtOfAcc.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader6, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvStmtOfAcc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvStmtOfAcc.FullRowSelect = True
        Me.lvStmtOfAcc.GridLines = True
        Me.lvStmtOfAcc.Location = New System.Drawing.Point(8, 128)
        Me.lvStmtOfAcc.Name = "lvStmtOfAcc"
        Me.lvStmtOfAcc.Size = New System.Drawing.Size(712, 264)
        Me.lvStmtOfAcc.TabIndex = 104
        Me.lvStmtOfAcc.UseCompatibleStateImageBehavior = False
        Me.lvStmtOfAcc.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Date"
        Me.ColumnHeader1.Width = 81
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Particulars"
        Me.ColumnHeader2.Width = 271
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Cheque No."
        Me.ColumnHeader6.Width = 94
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Deposit"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 81
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "WithDraw"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 83
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Balance"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 81
        '
        'frmSBStmtOfAccount
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(726, 459)
        Me.Controls.Add(Me.lvStmtOfAcc)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtAccno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSBStmtOfAccount"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SB Statement Of Account"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Sub Routines"

    Sub sbLoadTransactions()
        If Trim(txtAccno.Text) <> String.Empty Then
            objSBAccount.SBNo = Trim(txtAccno.Text)
            If objSBAccount.fnGetTransactionDetails(DTPFrom.Value, DTPTo.Value) = True Then
                lvStmtOfAcc.Items.Clear()
                Dim lvItem As ListViewItem
                For intCnt As Integer = 0 To objSBAccount.SBTransDetailTable.Rows.Count - 1
                    lvItem = lvStmtOfAcc.Items.Add(Format(objSBAccount.SBTransDetailTable.Rows(intCnt).Item("TrDate"), "dd-MMM-yyyy"))
                    lvItem.SubItems.Add(objSBAccount.SBTransDetailTable.Rows(intCnt).Item("Narration"))
                    lvItem.SubItems.Add(objSBAccount.SBTransDetailTable.Rows(intCnt).Item("ChequeNo"))
                    lvItem.SubItems.Add(objSBAccount.SBTransDetailTable.Rows(intCnt).Item("Deposit"))
                    lvItem.SubItems.Add(objSBAccount.SBTransDetailTable.Rows(intCnt).Item("WithDraw"))
                    lvItem.SubItems.Add(IIf(IsDBNull(objSBAccount.SBTransDetailTable.Rows(intCnt).Item("PostBal")) = True, " ", objSBAccount.SBTransDetailTable.Rows(intCnt).Item("PostBal")))
                Next
            End If
        End If
    End Sub

    Sub sbLoadDetails()
        If objSBAccount.fnGetSBAccountDetails(Trim(txtAccno.Text)) = True Then
            txtAccno.Text = objSBAccount.SBAccTable.Rows(0).Item("AccountNo")
            txtName.Text = objSBAccount.SBAccTable.Rows(0).Item("Name")
        End If
    End Sub

#End Region

#Region "EVENTS"

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim objSBAccSearch As New frmSBAccSearch
        objSBAccSearch.strSBAccountNo = String.Empty
        objSBAccSearch.ShowDialog(Me)
        If objSBAccSearch.strSBAccountNo <> String.Empty Then
            txtAccno.Text = objSBAccSearch.strSBAccountNo
            'txtName.Text = objSBAccSearch.lvSBAccs.SelectedItems(0).SubItems(1).Text
            sbLoadDetails()
        End If
        objSBAccSearch.Dispose()
        sbLoadTransactions()
    End Sub

    Private Sub frmSBStmtOfAccount_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DTPTo.MaxDate = Date.Today
        DTPFrom.Value = DateAdd(DateInterval.Day, -(Date.Now.Day - 1), Date.Now)

        sbLoadTransactions()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

#End Region

    Dim objReportViewer As New frmReportViewer

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If fnDeleteDate() Then
            FromDate = DTPFrom.Value
            ToDate = DTPTo.Value
            fnInsertDate()
        End If


        Dim dateRange As String
        'dateRange = "{sbtransactiontbl.TrDate} in CDate(""" + DTPFrom.Value + """) to CDate(""" + DTPTo.Value + """) and {sbtransactiontbl.AccountNo}= '" & txtAccno.Text & "' "
        dateRange = "{sbstatement.TrDate} in CDate(""" + DTPFrom.Value + """) to CDate(""" + DTPTo.Value + """) and {sbstatement.AccountNo}= '" & txtAccno.Text & "' "
        objReportViewer.CrystalReportViewer1.SelectionFormula = dateRange
        objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/Reports/SBStatement.rpt"
        objReportViewer.ShowDialog()
    End Sub
    Function fnCheck(ByVal m As Integer) As Boolean
        If m = 0 Then
            MsgBox("Their is no transaction to print", MsgBoxStyle.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim AccountNo As String
        AccountNo = "SB00010"
        Dim myReport As New CrystalReport2
        myReport.Load("/Reports/test.rpt")
        myReport.SetParameterValue("AccountNo", "SB00010")
        objReportViewer.CrystalReportViewer1.ReportSource = myReport

        'Dim dateRange As String
        ''dateRange = "{sbtransactiontbl.TrDate} in CDate(""" + DTPFrom.Value + """) to CDate(""" + DTPTo.Value + """) and {sbtransactiontbl.AccountNo}= '" & txtAccno.Text & "' "
        'dateRange = "{sbstatement.TrDate} in CDate(""" + DTPFrom.Value + """) to CDate(""" + DTPTo.Value + """) and {sbstatement.AccountNo}= '" & txtAccno.Text & "' "
        'objReportViewer.CrystalReportViewer1.ParameterField = accNo
        'objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/SBStatement.rpt"


        ''objReportViewer.CrystalReportViewer1.SelectionFormula = "Rajendra prasad V"
        ''objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/BankAnePersonalDetails.rpt"
        ''SBaccountstmnt.rpt("")
        ''Cashroll.rpt(" 'receipt.rpt") 'ReciptAndPayment.rpt"
        objReportViewer.ShowDialog()



    End Sub

    Private Sub DTPTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPTo.ValueChanged, DTPFrom.ValueChanged
        sbLoadTransactions()
    End Sub

    'Sub some()

    '    Dim param1Fileds As New CrystalDecisions.Shared.ParameterFields
    '    Dim param1Field As New CrystalDecisions.Shared.ParameterField
    '    Dim param2Field As New CrystalDecisions.Shared.ParameterField
    '    Dim param1Range As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    Dim param2Range As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    Dim CRYRpt1 As New SBAccountStmt

    '    ' CRYRpt1.ResourceName =
    '    param1Field.ParameterFieldName = "fromDate" ' Parameter Name In Crystal Report
    '    param1Field.ParameterFieldName = "ToDate"
    '    param1Range.Value = DTPFrom.Value
    '    param2Range.Value = DTPTo.Value

    '    ' value For Parameter Field 
    '    param1Field.CurrentValues.Add(param1Range)
    '    param2Field.CurrentValues.Add(param2Range)
    '    param1Fileds.Add(param1Field)                   ' To add parameter in parameterslist
    '    param1Fileds.Add(param2Field)

    '    objReportViewer.CrystalReportViewer1.ParameterFieldInfo = param1Fileds 'to pass parameter inf.to CRV
    '    objReportViewer.CrystalReportViewer1.ReportSource = CRYRpt1            ' Assign Report Source to CRV

    '    'objReportViewer.CrystalReportViewer1.Refresh()


    '    'Dim pfs As New CrystalDecisions.Shared.ParameterFields
    '    'Dim pf As New CrystalDecisions.Shared.ParameterField
    '    'Dim cv As New CrystalDecisions.Shared.ParameterValues
    '    'Dim dv As New CrystalDecisions.Shared.ParameterDiscreteValue
    '    'cv = pf.CurrentValues
    '    'dv.Value = "Fgasdf"
    '    'pf = pfs("sam")

    '    'cv.Add(dv)
    '    'objReportViewer.CrystalReportViewer1.ParameterFieldInfo = pfs

    '    'ParameterFields paramFields = CrystalReportViewer1.ParameterFieldInfo;
    '    'ParameterField paramField = paramFields["WantedDate"];
    '    'ParameterValues curValues = paramField.CurrentValues;
    '    'ParameterDiscreteValue discreteValue = new ParameterDiscreteValue();
    '    'discreteValue.Value = Request.QueryString("wantedDate") Or
    '    '        Session("WantedDate")
    '    'curValues.Add(discreteValue);
    '    'CrystalReportViewer1.ParameterFieldInfo = paramFields;

    'End Sub

End Class

