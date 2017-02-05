Public Class frm_Asegurado

    Private Sub txt_PNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PNombre.KeyPress
        Validarletras(e)

    End Sub

    Private Sub txt_PApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PApellido.KeyPress
        Validarletras(e)
    End Sub





    Private Sub txt_SApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SApellido.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_SNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SNombre.KeyPress
        Validarletras(e)
    End Sub



    Private Sub txt_Cedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Cedula.KeyPress
        ValidarNumero(e)
    End Sub


    Private Sub txt_TlfFijo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_TlfFijo.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_TlfMovil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_TlfMovil.KeyPress
        ValidarNumero(e)
    End Sub


    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click

        Limpiar(Me)

    End Sub

    Private Sub txt_ZonaP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ZonaP.KeyPress
        ValidarNumero(e)

    End Sub

    Private Sub txt_GradoL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_GradoL.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_NumeroL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_NumeroL.KeyPress
        Validarletras(e)
    End Sub
End Class