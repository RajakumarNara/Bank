Public Class frmReportViewer
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
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.AutoScroll = True
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(738, 535)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'frmReportViewer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(738, 535)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmReportViewer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Report Viewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmReportViewer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CrystalReportViewer1.RefreshReport()
        'CrystalReportViewer1.PrintReport();
    End Sub
    Sub some()
        Dim pfs As New CrystalDecisions.Shared.ParameterFields
        Dim pf As New CrystalDecisions.Shared.ParameterField
        Dim cv As New CrystalDecisions.Shared.ParameterValues
        Dim dv As New CrystalDecisions.Shared.ParameterDiscreteValue
        pf = pfs("sam")
        cv = pf.CurrentValues
        dv.Value = "Fgasdf"
        cv.Add(dv)
        CrystalReportViewer1.ParameterFieldInfo = pfs

        'ParameterFields paramFields = CrystalReportViewer1.ParameterFieldInfo;
        'ParameterField paramField = paramFields["WantedDate"];
        'ParameterValues curValues = paramField.CurrentValues;
        'ParameterDiscreteValue discreteValue = new ParameterDiscreteValue();
        'discreteValue.Value = Request.QueryString("wantedDate") Or
        '        Session("WantedDate")
        'curValues.Add(discreteValue);
        'CrystalReportViewer1.ParameterFieldInfo = paramFields;

    End Sub

End Class
