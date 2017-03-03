Public Class frm_Asegurado

    Private Sub frm_Siniestro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        HCampos(False)
        HBotones(False)
        LimpiarC()
        btn_Agregar.Enabled = False
        ActiveControl() = Me.cmb_Nacionalidad
        cmb_Nacionalidad.SelectedIndex() = -1

        sentencia = "select * from estados"
        Me.cmb_Estado.DataSource = Datos(sentencia)
        Me.cmb_Estado.DisplayMember = "estado"
        Me.cmb_Estado.ValueMember = "id_estado"
        Me.cmb_Estado.SelectedIndex = -1

        Me.cmb_Estado.DataSource = Datos(sentencia)
        Me.cmb_Estado.DisplayMember = "estado"
        cmb_Estado.ValueMember = "id_estado"
        cmb_Estado.SelectedIndex = -1

    End Sub

    Private Sub HCampos(ByRef sn As Boolean)

        txt_Cedula.Enabled = Not sn
        cmb_Nacionalidad.Enabled = Not sn
        txt_PNombre.Enabled = sn
        txt_SNombre.Enabled = sn
        txt_PApellido.Enabled = sn
        txt_SApellido.Enabled = sn
        dtp_FNacimiento.Enabled = sn
        grb_Sexo.Enabled = sn
        grb_Edocivil.Enabled = sn
        cmb_Estado.Enabled = sn
        cmb_Ciudad.Enabled = sn
        txt_ZonaP.Enabled = sn
        txt_Correo.Enabled = sn
        txt_TlfFijo.Enabled = sn
        txt_TlfMovil.Enabled = sn
        txt_NumeroL.Enabled = sn
        txt_GradoL.Enabled = sn
        dtp_FechaL.Enabled = sn

    End Sub

    Private Sub HBotones(ByRef sn As Boolean)

        btn_Buscar.Enabled = Not sn
        btn_Cancelar.Enabled = Not sn
        btn_Volver.Enabled = Not sn
        btn_Agregar.Enabled = Not sn
        btn_Modificar.Enabled = sn

    End Sub

    Private Sub LimpiarC()

        txt_Cedula.Text = ""
        cmb_Nacionalidad.Text = ""
        txt_PNombre.Text = ""
        txt_SNombre.Text = ""
        txt_PApellido.Text = ""
        txt_SApellido.Text = ""
        dtp_FNacimiento.Value = Today
        rdb_Masculino.Checked = False
        rdb_Femenino.Checked = False
        rdb_Casado.Checked = False
        rdb_Divorciado.Checked = False
        rdb_soltero.Checked = False
        cmb_Estado.Text = ""
        cmb_Ciudad.Text = ""
        txt_ZonaP.Text = ""
        txt_Correo.Text = ""
        txt_TlfFijo.Text = ""
        txt_TlfMovil.Text = ""
        txt_NumeroL.Text = ""
        txt_GradoL.Text = ""
        dtp_FechaL.Value = Today

    End Sub

    Private Sub btn_CancelarA_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Cancelar.Click

        HCampos(False)
        HBotones(False)
        LimpiarC()
        Me.btn_Modificar.Text = "Modificar"
        Me.ActiveControl() = Me.cmb_Nacionalidad

    End Sub

    Private Function Validar() As Boolean

        If (txt_Cedula.Text = "") Then Return False
        If (cmb_Nacionalidad.Text = "") Then Return False
        If (txt_PNombre.Text = "") Then Return False
        If (txt_SNombre.Text = "") Then Return False
        If (txt_PApellido.Text = "") Then Return False
        If (txt_SApellido.Text = "") Then Return False
        If (dtp_FNacimiento.Text = "") Then Return False
        If ((rdb_Masculino.Checked = False) And (rdb_Femenino.Checked = False)) Then Return False
        If ((rdb_Casado.Checked = False) And (rdb_Divorciado.Checked = False) And (rdb_soltero.Checked = False)) Then Return False
        If (cmb_Estado.Text = "") Then Return False
        If (cmb_Ciudad.Text = "") Then Return False
        If (txt_ZonaP.Text = "") Then Return False
        If (txt_Correo.Text = "") Then Return False
        If (txt_TlfFijo.Text = "") Then Return False
        If (txt_TlfMovil.Text = "") Then Return False
        If (txt_NumeroL.Text = "") Then Return False
        If (txt_GradoL.Text = "") Then Return False
        If (dtp_FechaL.Text = "") Then Return False

        Return True

    End Function

    Function DetSexo() As String

        Dim Sex As String
        If (rdb_Masculino.Checked = True) Then
            Sex = "M"
        Else
            Sex = "F"
        End If

        Return Sex

    End Function

    Function DetEdoCivil() As String

        Dim Edo As String
        If (rdb_Casado.Checked = True) Then
            Edo = "C"
        ElseIf (rdb_soltero.Checked = True) Then
            Edo = "S"
        Else
            Edo = "D"
        End If
        Return Edo

    End Function

    Private Sub txt_CedulaA_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_Cedula.KeyPress

        ValidarNumero(e)
        If Asc(e.KeyChar) = 13 Then
            Me.btn_Buscar.PerformClick()
        End If

    End Sub

    Private Sub btn_BuscarA_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Buscar.Click

        'Busca si el asegurado esta registrado

        If (cmb_Nacionalidad.SelectedItem = "") Or (Me.txt_Cedula.Text = "") Then
            MsgBox("Debe llenar ambos campos", vbInformation, "Error")
            Return
        End If

        sentencia = "SELECT * FROM asegurado WHERE a_nacionalidad= '" + cmb_Nacionalidad.Text + "' and a_cedula ='" + txt_Cedula.Text + "' and t_status='A'"
        CSelect(sentencia)


        If (sdr.IsClosed) Or Not (sdr.HasRows) Then

            If MsgBox("El asegurado no se encuentra registrado ¿Desea agregarlo?", vbYesNo,
                      "Asegurado no registrado") = MsgBoxResult.Yes Then
                HCampos(True)
                HBotones(False)
                btn_Buscar.Enabled = False
                cmb_Estado.Focus()
            End If

        Else

            txt_PNombre.Text = sdr("a_primer_nombre")
            txt_SNombre.Text = sdr("a_segundo_nombre")
            txt_PApellido.Text = sdr("a_primer_apellido")
            txt_SApellido.Text = sdr("a_segundo_apellido")
            dtp_FNacimiento.Text = sdr("a_fecha_nac")

            If (sdr("a_sexo") = "F") Then
                rdb_Femenino.Checked = True
            Else
                rdb_Masculino.Checked = True
            End If

            If (sdr("a_edo_civil") = "S") Then
                rdb_soltero.Checked = True
            Else
                If (sdr("a_edo_civil") = "C") Then
                    rdb_Casado.Checked = True
                Else
                    rdb_Divorciado.Checked = True
                End If
            End If
            rtb_DireccionH.Text = sdr("a_direccion_hab")
            cmb_Estado.Text = sdr("a_estado_hab")
            cmb_Ciudad.Text = sdr("a_ciudad_hab")
            txt_ZonaP.Text = sdr("a_zona_post")
            txt_Correo.Text = sdr("a_correo")
            txt_TlfFijo.Text = sdr("a_telf_hab")
            txt_TlfMovil.Text = sdr("a_telf_cel")
            'txt_NumeroL.Text = sdr("a_nro_licencia")
            txt_GradoL.Text = sdr("a_grado_licencia")
            dtp_FechaL.Text = sdr("a_vencimiento_licencia")
            HBotones(True)
            btn_Cancelar.Enabled = True

        End If

        cn.Close()

    End Sub

    Private Sub btn_AgregarSin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Agregar.Click

        'Incluye un nuevo asegurado
        If (Validar()) Then

            sentencia = "INSERT INTO asegurado (a_nacionalidad,a_cedula,a_primer_nombre,a_segundo_nombre, a_primer_apellido, a_segundo_apellido,a_fecha_nac, a_sexo,a_edo_civil, a_direccion_hab,a_zona_post,a_estado_hab,a_ciudad_hab,a_telf_hab,a_telf_cel,a_correo,a_grado_licencia,a_vencimiento_licencia) VALUES('" +
                cmb_Nacionalidad.Text() + "','" + txt_Cedula.Text() + "', '" + txt_PNombre.Text() + "','" + txt_SNombre.Text + "','" + txt_PApellido.Text + "','" + txt_SApellido.Text + "',str_to_date('" + dtp_FNacimiento.Value + "','%d/%m/%Y'),'" + DetSexo() + "','" + DetEdoCivil() + "','" + rtb_DireccionH.Text + "','" + txt_ZonaP.Text + "','" +
                cmb_Estado.Text + "','" + cmb_Ciudad.Text + "','" + txt_TlfFijo.Text + "','" + txt_TlfMovil.Text + "','" + txt_Correo.Text + "','" + txt_GradoL.Text + "',str_to_date('" + dtp_FechaL.Value + "', '%d/%m/%Y'))"

            comando22(sentencia)
            MsgBox("Se ha registrado un nuevo asegurado", vbInformation, "Registro exitoso")
            cn.Close()
            Me.btn_Cancelar.PerformClick()

        Else

            MsgBox("Debe llenar todos los campos", vbInformation, vbOK)

        End If

    End Sub

    Private Sub btn_ModificarSin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Modificar.Click


        If (btn_Modificar.Text = "Modificar") Then
            HCampos(True)
            Me.btn_Modificar.Text = "Guardar"

        Else
            If (Validar()) Then
                sentencia = "SELECT * FROM asegurado WHERE a_cedula ='" + txt_Cedula.Text + "' and a_nacionalidad='" + cmb_Nacionalidad.Text + "'"

                CSelect(sentencia)

                If ((txt_PNombre.Text = sdr("a_primer_nombre") And (txt_SNombre.Text = sdr("a_segundo_nombre")) And (txt_PApellido.Text = sdr("a_primer_apellido")) And
                      (txt_SApellido.Text = sdr("a_segundo_apellido")) And (dtp_FNacimiento.Value = sdr("a_fecha_nac")) And (rtb_DireccionH.Text = sdr("a_direccion_hab")) And
                      (txt_ZonaP.Text = sdr("a_zona_post")) And (cmb_Estado.Text = sdr("a_estado_hab")) And (cmb_Ciudad.Text = sdr("a_ciudad_hab")) And (txt_TlfFijo.Text = sdr("a_telf_hab")) And
                      (txt_TlfMovil.Text = sdr("a_telf_cel")) And (txt_Correo.Text = sdr("a_correo")) And (txt_GradoL.Text = sdr("a_grado_licencia")) And
                      (dtp_FechaL.Value = sdr("a_vencimiento_licencia")))) Then


                    MsgBox("No se han realizado cambios", vbInformation, "Sin cambios")
                    cn.Close()
                    Me.btn_Cancelar.PerformClick()
                    Return


                Else

                    sentencia = "update asegurado set a_primer_nombre='" + txt_PNombre.Text + "', a_segundo_nombre='" + txt_SNombre.Text + "', a_primer_apellido='" + txt_PApellido.Text + "', a_segundo_apellido='" +
                    txt_SApellido.Text + "', a_fecha_nac= str_to_date('" + dtp_FNacimiento.Value + "', '%d/%m/%Y'), a_direccion_hab='" + rtb_DireccionH.Text + "', a_zona_post='" + txt_ZonaP.Text + "', a_estado_hab='" + cmb_Estado.Text + "', a_ciudad_hab='" +
                    cmb_Ciudad.Text + "', a_telf_hab='" + txt_TlfFijo.Text + "', a_telf_cel='" + txt_TlfMovil.Text + "', a_correo='" + txt_Correo.Text + "', a_grado_licencia='" + txt_GradoL.Text + "', a_vencimiento_licencia= str_to_date('" + dtp_FechaL.Value + "', '%d/%m/%Y')"

                    comando22(sentencia)
                    MsgBox("Los cambios se han realizado con exito", vbInformation, "Cambios")
                    cn.Close()
                    Me.btn_Cancelar.PerformClick()

                End If

            Else
                MsgBox("Debe llenar todos los campos", vbInformation, vbOK)
            End If

        End If

    End Sub

    Private Sub btn_Volver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Volver.Click

        Me.Close()

    End Sub

    Private Sub txt_PNombre_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_PNombre.KeyPress
        Validarletras(e)

    End Sub

    Private Sub txt_PApellido_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_PApellido.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_SApellido_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_SApellido.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_SNombre_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_SNombre.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_Cedula_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_Cedula.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_TlfFijo_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_TlfFijo.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_TlfMovil_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_TlfMovil.KeyPress
        ValidarNumero(e)
    End Sub


    Private Sub btn_Cancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Cancelar.Click

        Limpiar(Me)

    End Sub

    Private Sub txt_ZonaP_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_ZonaP.KeyPress
        ValidarNumero(e)

    End Sub

    Private Sub txt_GradoL_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_GradoL.KeyPress

    End Sub

    Private Sub txt_NumeroL_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_NumeroL.KeyPress

    End Sub

    Private Sub cmb_Estado_SelectionChangeCommitted(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_Estado.SelectionChangeCommitted
        sentencia = "select distinct ciudades.* from ciudades,estados where ciudades.id_estado= " + Me.cmb_Estado.SelectedValue.ToString
        Me.cmb_Ciudad.DataSource = Datos(sentencia)
        Me.cmb_Ciudad.DisplayMember = "ciudad"
        Me.cmb_Ciudad.ValueMember = "id_ciudad"
        Me.cmb_Ciudad.SelectedIndex = -1
        Me.cmb_Ciudad.Focus()
    End Sub

    Private Sub grb_DireccYContacto_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles grb_DireccYContacto.Enter

    End Sub

    Private Sub txt_NumeroL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_NumeroL.TextChanged

    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click

    End Sub

    Private Sub txt_Cedula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Cedula.TextChanged

    End Sub

    Private Sub cmb_Nacionalidad_KeyPress(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Nacionalidad.KeyPress
        ValidarNoescritura(e)
    End Sub

    Private Sub DeterminarSexo()
        Dim Sexo As String
        If (rdb_Masculino.Checked = True) Then
            Sexo = "M"
        ElseIf rdb_Femenino.Checked = True Then
            Sexo = "F"
        End If
        Return
    End Sub

    Private Sub ptb_logo_Click(sender As Object, e As EventArgs) Handles ptb_logo.Click

    End Sub

    Private Sub rdb_soltero_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_soltero.CheckedChanged

    End Sub
End Class