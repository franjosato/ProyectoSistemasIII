Imports MySql.Data.MySqlClient

Public Class frm_Usuario
    Private Sub frm_Usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        lbl_Hora.Text = DateTime.Now.ToShortTimeString()

    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click

        If (txt_Cedula.Text = "") Then
            MsgBox("Debe escribir una cedula", vbInformation, "Advertencia")
            Return
        End If

        sql = "Select * from empleado where em_cedula = '" & txt_Cedula.Text & "' " 'Busca y muestra al empleado con esa cedula
        CSelect(sql)

        txt_PNombre.Text = sdr("em_primer_nombre")
        txt_SNombre.Text = sdr("em_segundo_nombre")
        txt_PApellido.Text = sdr("em_primer_apellido")
        txt_SApellido.Text = sdr("em_segundo_apellido")
        txt_TipodeEmpleado.Text = sdr("em_te_codigo") ' acomodar en BD, no es un codigo.

        If (sdr.IsClosed) Or Not (sdr.HasRows) Then
            MsgBox("La cedula no existe, agregar primero al empleado", vbInformation, "Error") 'Si no lo encuentra mensaje
            btn_Cancelar.PerformClick()
        Else
            btn_Cancelar.Enabled = True
            sentencia = "Select * from usuario where u_em_cedula = '" & txt_Cedula.Text & "' " 'Luego que muestra al empleado muestra los datos del usuaio
            CSelect(sentencia)

            txt_Usuario.Text = sdr("u_usuario")         'Si pongo estas dos lineas como comentario
            txt_Contraseña.Text = sdr("u_contraseña")    'no me tira error cuando encuentra empleado pero no usuario

            If (sdr.IsClosed) Or Not (sdr.HasRows) Then 'Si no encuentra usuario habilita el boton generar
                MsgBox("AYUDA", vbInformation, "ERROR")
                btn_Generar.Enabled = True
            End If

        End If



        cn.Close()
    End Sub

    Private Sub txt_Cedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Cedula.KeyPress
        ValidarNumero(e)
        If Asc(e.KeyChar) = 13 Then
            btn_Buscar.PerformClick()
        End If
    End Sub
End Class
