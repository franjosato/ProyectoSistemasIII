Public Class frm_InicioSesion

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btn_Ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ingresar.Click

        If (txt_Usuario.Text = "usuario" Or txt_Usuario.Text = "master") Then

            If (txt_Usuario.Text = "usuario") Then
                tipou = "Gerente General"
            ElseIf (txt_Usuario.Text = "master") Then
                tipou = "Cajero"

            End If
            If (txt_Contraseña.Text = "1234") Then

                NombreUsuario = "Ing. Katherine" + " " + "Suárez" 'cadena de texto que mostrara nombre y apellido del usuario
                TipoUsuario = "Cargo: " + tipou 'cadena de texto que mostrara el nivel de permisosdel usuario en el menu principal
                VerificarTipoUsuario = tipou 'variable que activa o desactiva funciones para cada tipo de usuario
                txt_Usuario.Text = ""
                txt_Contraseña.Text = ""
                frm_Portada.Show()
            Else
                MsgBox("Combinacion de usuario y contraseña no válido. Vuelva a intentarlo", , "Inicio de sesión")
                txt_Contraseña.Focus()
                txt_Contraseña.Text = ""

            End If
        Else
            MsgBox(" El usuario introducido no existe. Vuelva a intentarlo", , "Inicio de sesión")
            txt_Usuario.Focus()
            txt_Usuario.Text = ""
            txt_Contraseña.Text = ""
        End If
    End Sub

    Private Sub frm_InicioSesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmr_HoraInicioSesion.Start()


    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        txt_Usuario.Text = ""
        txt_Contraseña.Text = ""
        btn_Ingresar.Enabled = False

    End Sub

    Private Sub lbl_Usuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Usuario.Click

    End Sub

    Private Sub lbl_Contraseña_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Contraseña.Click

    End Sub

    Private Sub txt_Usuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Usuario.TextChanged

    End Sub

    Private Sub txt_Contraseña_KeyPress(ByVal KeyAscii As Integer)
        If KeyAscii = 13 Then
            btn_Ingresar.PerformClick()
        End If

    End Sub
  
    Private Sub txt_Contraseña_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Contraseña.TextChanged
        btn_Ingresar.Enabled = True
    End Sub

    Private Sub tmr_HoraInicioSesion_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_HoraInicioSesion.Tick
        lbl_HoraInicioSesion.Text = DateTime.Now.ToShortTimeString()
    End Sub
End Class