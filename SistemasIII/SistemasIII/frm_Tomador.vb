Public Class frm_Tomador

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_CorreoT.Click

    End Sub

    Private Sub Label12_Click(sender As System.Object, e As System.EventArgs) 

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub frm_Tomador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Sistemas3DataSet.estados' Puede moverla o quitarla según sea necesario.
        'Me.EstadosTableAdapter.Fill(Me.Sistemas3DataSet.estados)
        Me.tmr_Fecha.Start()



    End Sub

    Private Sub tmr_Fecha_Tick(sender As Object, e As EventArgs) Handles tmr_Fecha.Tick
        Me.lbl_Fecha.Text = DateString
        Me.lbl_Hora.Text = TimeOfDay
    End Sub

    Private Sub txt_PNombre_TextChanged(sender As Object, e As EventArgs) Handles txt_PNombre.TextChanged

    End Sub

    Private Sub txt_PNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PNombre.KeyPress
        Validarletras(e)

    End Sub

    Private Sub txt_PApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PApellido.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_Cargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Cargo.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_Profesion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Profesion.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_SApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SApellido.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_SNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SNombre.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_ActEconomica_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ActEconomica.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_Cedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Cedula.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_IngresoE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_IngresoE.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_TlfFijo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_TlfFijo.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_TlfMovil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_TlfMovil.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_TlfTrabajo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_TlfTrabajo.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click

        Limpiar(Me)

    End Sub

    Private Sub txt_ZonaP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ZonaP.KeyPress
        ValidarNumero(e)
    End Sub
End Class