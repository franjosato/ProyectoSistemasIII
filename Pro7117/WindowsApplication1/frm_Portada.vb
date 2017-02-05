Public Class frm_Portada

    Private Sub btn_InicioSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_InicioSesion.Show()
    End Sub

    Private Sub btn_Siniestro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Siniestro.Click
        frm_Siniestro.Show()
    End Sub

    Private Sub btn_RegistrarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RegistrarUsuario.Click
        frm_Usuario.Show()
    End Sub

    Private Sub frm_Portada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_UsuarioActual.Text = StrConv(NombreUsuario, vbProperCase)
        lbl_CargoActual.Text = TipoUsuario
        tmr_HoraPortada.Start()

    End Sub

    Private Sub lbl_Hora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Hora.Click

    End Sub

    Private Sub lbl_Fecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Fecha.Click

    End Sub

    Private Sub tmr_HoraPortada_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_HoraPortada.Tick
        lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        lbl_Hora.Text = DateTime.Now.ToShortTimeString()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class