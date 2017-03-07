Public Class frm_Documento_Reporte_Ingresos
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Me.Text = cabeceraEmpresa + " - Reporte de ingresos"
        CrystalReportViewer1.ReportSource = Reporte_Ingresos1
        CrystalReportViewer1.Refresh()

    End Sub

End Class