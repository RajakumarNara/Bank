'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared
Public Class frmTransaction
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
    Friend WithEvents lvDisbursment As System.Windows.Forms.ListView
    Friend WithEvents lvRepayment As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtName As BankControls.TextControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLoanNo As BankControls.TextControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As BankControls.NewButton
    Friend WithEvents btnClose As BankControls.NewButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransaction))
        Me.lvDisbursment = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.lvRepayment = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtName = New BankControls.TextControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLoanNo = New BankControls.TextControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClose = New BankControls.NewButton
        Me.btnPrint = New BankControls.NewButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvDisbursment
        '
        Me.lvDisbursment.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader1, Me.ColumnHeader3})
        Me.lvDisbursment.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDisbursment.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lvDisbursment.FullRowSelect = True
        Me.lvDisbursment.GridLines = True
        Me.lvDisbursment.Location = New System.Drawing.Point(8, 32)
        Me.lvDisbursment.Name = "lvDisbursment"
        Me.lvDisbursment.Size = New System.Drawing.Size(288, 328)
        Me.lvDisbursment.TabIndex = 0
        Me.lvDisbursment.UseCompatibleStateImageBehavior = False
        Me.lvDisbursment.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Disb Date"
        Me.ColumnHeader2.Width = 77
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Disb Amount"
        Me.ColumnHeader1.Width = 84
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Remaning Amount"
        Me.ColumnHeader3.Width = 123
        '
        'lvRepayment
        '
        Me.lvRepayment.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader8, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvRepayment.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvRepayment.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lvRepayment.FullRowSelect = True
        Me.lvRepayment.GridLines = True
        Me.lvRepayment.Location = New System.Drawing.Point(8, 32)
        Me.lvRepayment.Name = "lvRepayment"
        Me.lvRepayment.Size = New System.Drawing.Size(328, 328)
        Me.lvRepayment.TabIndex = 0
        Me.lvRepayment.UseCompatibleStateImageBehavior = False
        Me.lvRepayment.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date"
        Me.ColumnHeader4.Width = 77
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Principle"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Interest"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "PenelInterest"
        Me.ColumnHeader6.Width = 57
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Balance"
        Me.ColumnHeader7.Width = 69
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lvDisbursment)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 376)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Disbursed Amount Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lvRepayment)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(352, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 376)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Repayment Details"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtLoanNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(704, 440)
        Me.Panel1.TabIndex = 73
        '
        'txtName
        '
        Me.txtName.AlphaNumeric = True
        Me.txtName.BlankSpace = False
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtName.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(424, 16)
        Me.txtName.LostFocusColour = System.Drawing.Color.Empty
        Me.txtName.Mandatory = False
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(160, 23)
        Me.txtName.SpecialChar = False
        Me.txtName.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(360, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Name :"
        '
        'txtLoanNo
        '
        Me.txtLoanNo.AlphaNumeric = True
        Me.txtLoanNo.BackColor = System.Drawing.Color.White
        Me.txtLoanNo.BlankSpace = True
        Me.txtLoanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoanNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanNo.GotFocusColour = System.Drawing.SystemColors.Info
        Me.txtLoanNo.Location = New System.Drawing.Point(96, 16)
        Me.txtLoanNo.LostFocusColour = System.Drawing.SystemColors.Window
        Me.txtLoanNo.Mandatory = False
        Me.txtLoanNo.Name = "txtLoanNo"
        Me.txtLoanNo.ReadOnly = True
        Me.txtLoanNo.Size = New System.Drawing.Size(160, 23)
        Me.txtLoanNo.SpecialChar = True
        Me.txtLoanNo.TabIndex = 74
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "LoanNo. :"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(608, 456)
        Me.btnClose.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(96, 48)
        Me.btnClose.TabIndex = 74
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.GotFocusColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(16, 460)
        Me.btnPrint.LostFocusColour = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(120, 40)
        Me.btnPrint.TabIndex = 75
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.Visible = False
        '
        'frmTransaction
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(720, 509)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransaction"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoanTransaction"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"

    Dim objclsTransaction As New clsTransactionDet

#End Region

#Region "Function"

    Public Function fnGetDisbDet() As Boolean
        Dim intCount As Integer = 0
        Dim lstvDisb As ListViewItem

        If objclsTransaction.fnGetDisbDet(txtLoanNo.Text) Then

            While intCount < objclsTransaction.disbTable.Rows.Count
                lstvDisb = lvDisbursment.Items.Add(Format(objclsTransaction.disbTable.Rows(intCount).Item("DisbDate"), "yyyy-MM-dd"))
                lstvDisb.SubItems.Add(objclsTransaction.disbTable.Rows(intCount).Item("Amount"))
                lstvDisb.SubItems.Add(objclsTransaction.disbTable.Rows(intCount).Item("RemAmount"))
                intCount += 1

            End While

        End If

    End Function

    Public Function fnGetRepayDet() As Boolean

        Dim intCount As Integer = 0
        Dim lstvRepay As ListViewItem

        If objclsTransaction.fnGetRepayDet(txtLoanNo.Text) Then

            While intCount < objclsTransaction.RepayTable.Rows.Count
                lstvRepay = lvRepayment.Items.Add(Format(objclsTransaction.RepayTable.Rows(intCount).Item("RepayDate"), "yyyy-MM-dd"))
                'lstvRepay.SubItems.Add(objclsTransaction.RepayTable.Rows(intCount).Item("Principle"))
                lstvRepay.SubItems.Add(objclsTransaction.RepayTable.Rows(intCount).Item("Credit"))
                lstvRepay.SubItems.Add(objclsTransaction.RepayTable.Rows(intCount).Item("InterestPaid"))
                lstvRepay.SubItems.Add(objclsTransaction.RepayTable.Rows(intCount).Item("PenelInterest"))
                lstvRepay.SubItems.Add(objclsTransaction.RepayTable.Rows(intCount).Item("Balance"))
                intCount += 1
            End While

        End If

    End Function

#End Region

    Private Sub frmTransaction_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fnGetDisbDet()
        fnGetRepayDet()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnGenerateReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    ' Dim objReportViewer As New frmReportViewer

    'Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
    '    Dim cryRpt As New ReportDocument
    '    cryRpt.Load(Application.StartupPath & "/Reports/LoanStatementNew.rpt")
    '    'cryRpt.Load("/../Reports/LoanStatementNew.rpt")
    '    '-----functionality for Parameter passing---myDiscrete
    '    Dim myDiscrete As New ParameterDiscreteValue
    '    myDiscrete.Value = Convert.ToString(txtLoanNo.Text)
    '    cryRpt.SetParameterValue("LoanNo", myDiscrete)
    '    objReportViewer.Show()
    '    objReportViewer.CrystalReportViewer1.ReportSource = cryRpt
    'End Sub

   
End Class
