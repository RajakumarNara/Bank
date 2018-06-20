Public Class frmLoanReports
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbType)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 88)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Loans"
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Items.AddRange(New Object() {"GoldLoan", "VehicleLoan", "MediumTermLoan", "HomeLoan", "DemandLoan"})
        Me.cmbType.Location = New System.Drawing.Point(120, 32)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(176, 24)
        Me.cmbType.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Select Loan"
        '
        'frmLoanReports
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(344, 141)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoanReports"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoanReports"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"

    Dim objclsLoanDet As New clsLoanDet


#End Region

#Region "Functions"

    Public Function fnGetLoan() As Boolean

        Dim objReportViewer As New frmReportViewer
        Dim strLoan As String
        objReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath & "/../Reports/LoanDetails.rpt"

        If cmbType.SelectedItem = "GoldLoan" Then
            strLoan = "GL"
            objReportViewer.CrystalReportViewer1.SelectionFormula = "{loandetailstbl.LoanNo} Like 'GL*'"
            objReportViewer.ShowDialog()
            objReportViewer.Dispose()

        End If

        If cmbType.SelectedItem = "VehicleLoan" Then
            strLoan = "VL"
            objReportViewer.CrystalReportViewer1.SelectionFormula = "{loandetailstbl.LoanNo} Like 'VL*'"
            objReportViewer.ShowDialog()
            objReportViewer.Dispose()

        End If

        If cmbType.SelectedItem = "DemandLoan" Then
            strLoan = "DL"
            objReportViewer.CrystalReportViewer1.SelectionFormula = "{loandetailstbl.LoanNo} Like 'DL*'"
            objReportViewer.ShowDialog()
            objReportViewer.Dispose()

        End If

        If cmbType.SelectedItem = "MediumTermLoan" Then
            strLoan = "ML"
            objReportViewer.CrystalReportViewer1.SelectionFormula = "{loandetailstbl.LoanNo} Like 'ML*'"
            objReportViewer.ShowDialog()
            objReportViewer.Dispose()

        End If

        If cmbType.SelectedItem = "HomeLoan" Then
            strLoan = "HL"
            objReportViewer.CrystalReportViewer1.SelectionFormula = "{loandetailstbl.LoanNo} Like 'HL*'"
            objReportViewer.ShowDialog()
            objReportViewer.Dispose()

        End If

    End Function

#End Region

    Private Sub cmbType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged
        fnGetLoan()
    End Sub
End Class
