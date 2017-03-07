Imports CrystalDecisions.Shared
Public Class frm_RIngreso
    Private Sub frm_RIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = cabeceraEmpresa + " - " + lbl_EncabezadoFormuladio.Text
        lbl_Usuario.Text = NombreUsuario
        dtp_Desde.Value = Now
        dtp_Hasta.Value = Now
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        Me.lbl_Fecha.Text = DateString
        Me.lbl_Hora.Text = TimeOfDay
    End Sub
    Private Sub btn_Generar_Click(sender As Object, e As EventArgs) Handles btn_Generar.Click

        If (Validar()) Then
            Dim frm_Documento_Reporte_Ingresos As New frm_Documento_Reporte_Ingresos()
            frm_Documento_Reporte_Ingresos.Reporte_Ingresos1.SetParameterValue("FechaIni", dtp_Desde.Value)
            frm_Documento_Reporte_Ingresos.Reporte_Ingresos1.SetParameterValue("FechaHasta", dtp_Hasta.Value)

            frm_Documento_Reporte_Ingresos.Show()
        End If
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        dtp_Desde.Value = Now
        dtp_Hasta.Value = Now
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
End Class