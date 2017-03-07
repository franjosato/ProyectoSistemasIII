Public Class frm_Documento_Reporte_CuotasPorCobrar
    Private Sub frm_Documento_Reporte_CuotasPorCobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = cabeceraEmpresa + " - Reporte de cuotas por cobrar"
        CrystalReportViewer1.ReportSource = Reporte_CuotasPorCobrar1
        CrystalReportViewer1.Refresh()
    End Sub
End Class