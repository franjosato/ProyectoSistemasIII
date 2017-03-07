Public Class frm_RCuotasPorCobrar
    Private Sub frm_RCuotasPorCobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = cabeceraEmpresa + " - " + lbl_EncabezadoFormuladio.Text
        lbl_Usuario.Text = NombreUsuario
        dtp_Desde.Value = Now
        dtp_Hasta.Value = Now
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        Me.lbl_Fecha.Text = DateString
        Me.lbl_Hora.Text = TimeOfDay
    End Sub

    Private Sub btn_Volver_Click(sender As Object, e As EventArgs) Handles btn_Volver.Click
        Me.Close()
    End Sub

    Private Function Validar() As Boolean
        Validar = True
        If (dtp_Desde.Value > dtp_Hasta.Value) Then
            MsgBox("La fecha desde no puede ser mayor que la de hasta", vbCritical, cabeceraEmpresa)
            Validar = False
        End If
    End Function
    Private Sub btn_Generar_Click(sender As Object, e As EventArgs) Handles btn_Generar.Click

        If (Validar()) Then
            Dim frm_Documento_Reporte_CuotasPorCobrar As New frm_Documento_Reporte_CuotasPorCobrar()
            frm_Documento_Reporte_CuotasPorCobrar.Reporte_CuotasPorCobrar1.SetParameterValue("FechaIni", dtp_Desde.Value)
            frm_Documento_Reporte_CuotasPorCobrar.Reporte_CuotasPorCobrar1.SetParameterValue("FechaHasta", dtp_Hasta.Value)

            frm_Documento_Reporte_CuotasPorCobrar.Show()
        End If
    End Sub
End Class
