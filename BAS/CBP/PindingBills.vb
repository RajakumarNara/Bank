Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class PindingBills
    Dim objReportViewer As New frmReportViewer

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'dtpPendingBillDate.Text

        Dim cryRpt As New ReportDocument
        cryRpt.Load(Application.StartupPath & "/../Reports/BankAndPersonDetail.rpt")
        'cryRpt.Load("../BAS/Reports/BankAndPersonDetail.rpt")
        '-----functionality for Parameter passing---myDiscrete
        Dim myDiscrete As New ParameterDiscreteValue
        'myDiscrete.Value = Convert.ToString(txtAccno.Text)
        cryRpt.SetParameterValue("AccountNo", myDiscrete)
        objReportViewer.Show()
        objReportViewer.CrystalReportViewer1.ReportSource = cryRpt
    End Sub

End Class