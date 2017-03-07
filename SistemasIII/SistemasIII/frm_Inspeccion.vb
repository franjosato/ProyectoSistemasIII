Public Class frm_Inspeccion
    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click

        sentencia = "SELECT po_estatus, v_placa FROM contrato inner join vehiculo WHERE (v_placa = '" + txt_Placa.Text + "' AND po_v_placa= v_placa AND po_estatus=v_estatus)"
        CSelect(sentencia)

        If ((sdr.IsClosed) Or (sdr.HasRows)) Then
            MsgBox("El vehiculo no tiene ningun contrato asociado, debe registrar un contrato y asociar el vehiculo", vbInformation, "vehiculo sin asociacion")
            btn_cancelar_daño_daños.PerformClick()
        Else

        End If

    End Sub
End Class