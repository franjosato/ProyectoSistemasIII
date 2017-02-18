Public Class frm_Usuario
    Private Sub frm_Usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txt_CedulaEmp.Focus()
        lbl_UsuarioActual.Text = StrConv(NombreUsuario, vbProperCase)
        lbl_CargoActual.Text = TipoUsuario
        tmr_HoraUsuario.Start()

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_CedulaEmp.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarCed.Click
        If txt_CedulaEmp.Text = "" Then
            btn_BuscarCed.Enabled = False
        End If
        txt_NombreEmp.Text = "XXXXXXX"
        txt_ApellidoEmp.Text = "XXXXXX"
        cmb_Cargo.Text = "XXXX"
        cmb_TipoEmp.Text = "XXXX"
        btn_Cancelar.Enabled = True
        btn_Guardar.Enabled = True
        btn_Eliminar.Enabled = True
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        txt_Usuario.Text = "XXXXXXX"
        txt_Contraseña.Text = "XXXXXX"
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click

    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        txt_CedulaEmp.Text = ""
        txt_NombreEmp.Text = ""
        txt_ApellidoEmp.Text = ""
        txt_Usuario.Text = ""
        txt_Contraseña.Text = ""
        cmb_Cargo.Text = ""
        cmb_TipoEmp.Text = ""
        btn_Guardar.Enabled = False
        btn_Eliminar.Enabled = False
    End Sub

    Private Sub InicioSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_InicioSesion.Show()
    End Sub

    Private Sub lbl_CargoActual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_CargoActual.Click

    End Sub

    Private Sub tmr_HoraUsuario_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_HoraUsuario.Tick
        lbl_HoraUsuario.Text = DateTime.Now.ToShortTimeString()
    End Sub

    Private Sub txt_CedulaEmp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CedulaEmp.TextChanged

    End Sub

    Private Sub ptb_ListoUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptb_ListoUsuario.Click
        txt_CedulaEmp.Text = ""
        txt_NombreEmp.Text = ""
        txt_ApellidoEmp.Text = ""
        txt_Usuario.Text = ""
        txt_Contraseña.Text = ""
        cmb_TipoEmp.Text = ""
        cmb_Cargo.Text = ""
        btn_Cancelar.Enabled = False
        btn_Eliminar.Enabled = False
        btn_Guardar.Enabled = False

    End Sub

    Private Sub txt_Usuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Usuario.TextChanged

    End Sub
End Class
