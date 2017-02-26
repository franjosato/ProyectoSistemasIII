Public Class frm_Tomador

    Private Sub HBotones(ByRef sn As Boolean)
        Me.btn_Agregar.Enabled = sn
        Me.btn_Buscar.Enabled = Not sn
        Me.btn_Cancelar.Enabled = Not sn

        Me.btn_Modificar.Enabled = sn
        Me.btn_Volver.Enabled = Not sn
    End Sub

    Private Sub frm_Tomador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Sistemas3DataSet.estados' Puede moverla o quitarla según sea necesario.
        'Me.EstadosTableAdapter.Fill(Me.Sistemas3DataSet.estados)
        Me.tmr_Fecha.Start()
        sentencia = "select * from estados"
        'se llena el combobox del estado de habitacion
        Me.cmb_Estado.DataSource = Datos(sentencia)
        Me.cmb_Estado.DisplayMember = "estado"
        Me.cmb_Estado.ValueMember = "id_estado"
        Me.cmb_Estado.SelectedIndex = -1
        'se llena el combobox de estado ciudad
        Me.cmb_EdoTrabajo.DataSource = Datos(sentencia)
        Me.cmb_EdoTrabajo.DisplayMember = "estado"
        Me.cmb_EdoTrabajo.ValueMember = "id_estado"
        Me.cmb_EdoTrabajo.SelectedIndex = -1
        'desactivar todos los campos
        btn_Cancelar.PerformClick()
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
        txt_Cedula.Focus()
        ActiveControl() = txt_Cedula
        Limpiar(Me)
        HCampos(Me, False, txt_Cedula)
        HBotones(False)
        cmb_Nacionalidad.Text = "V"
        Me.btn_Modificar.Text = "Modificar"
        rdb_soltero.Checked = True
        rdb_Masculino.Checked = True
    End Sub

    Private Sub txt_ZonaP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ZonaP.KeyPress
        ValidarNumero(e)
    End Sub



    Private Sub cmb_Estado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_Estado.SelectionChangeCommitted
        'sentencia = "select ciudades.* from ciudades left join estados on ciudades.id_estado=estados.id_estado where estados.estado = " + Me.cmb_Estado.SelectedValue.ToString
        sentencia = "select distinct ciudades.* from ciudades,estados where ciudades.id_estado= " + Me.cmb_Estado.SelectedValue.ToString
        'se llena el combobox de ciudad dependiendo del estado seleccionado
        Me.cmb_Ciudad.DataSource = Datos(sentencia)
        Me.cmb_Ciudad.DisplayMember = "ciudad"
        Me.cmb_Ciudad.ValueMember = "id_ciudad"
        Me.cmb_Ciudad.SelectedIndex = -1
        Me.cmb_Ciudad.Focus()
    End Sub

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        If (validar_controles(Me)) Then
            MsgBox("no hay errores")
        Else
            MsgBox("no puede dejar campos vacios")
        End If
    End Sub

    Private Sub cmb_EdoTrabajo_SelectionChangeCommitted(sender As Object, e As EventArgs)
        sentencia = "select distinct ciudades.* from ciudades,estados where ciudades.id_estado= " + Me.cmb_EdoTrabajo.SelectedValue.ToString
        'se llena el combobox de ciudad dependiendo del estado seleccionado
        cmb_CiudadTrabajo.DataSource = Datos(sentencia)
        cmb_CiudadTrabajo.DisplayMember = "ciudad"
        cmb_CiudadTrabajo.ValueMember = "id_ciudad"
        cmb_CiudadTrabajo.SelectedIndex = -1
        cmb_CiudadTrabajo.Focus()
    End Sub

    Private Sub txt_Cedula_TextChanged(sender As Object, e As EventArgs) Handles txt_Cedula.TextChanged
        If txt_Cedula.TextLength <> 0 Then
            cmb_Nacionalidad.Enabled = True
        End If
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        If (cmb_Nacionalidad.SelectedItem = "") Or (txt_Cedula.Text = "") Then
            MsgBox("Debe llenar ambos campos", vbInformation, "Error")
            Return
        End If
        sentencia = "select * from tomador where t_cedula= '" + txt_Cedula.Text + "'and t_nacionalidad= '" + cmb_Nacionalidad.Text + "' and t_status='A'"
        CSelect(sentencia)

        If (sdr.IsClosed) Or Not (sdr.HasRows) Then
            If MsgBox("El empleado no existe ¿Desea agregarlo?", vbYesNo, "Registro no existente") = MsgBoxResult.Yes Then
                HCampos(Me, True, txt_Cedula)
                cmb_Nacionalidad.Enabled = False
                HBotones(False)
                Me.btn_Buscar.Enabled = False
                Me.txt_PNombre.Focus()
            End If
        Else
            Me.txt_PNombre.Text = sdr("t_primer_nombre")
            Me.txt_SNombre.Text = sdr("t_segundo_nombre")
            Me.txt_PApellido.Text = sdr("t_primer_apellido")
            Me.txt_SApellido.Text = sdr("t_segundo_apellido")
            dtp_FNacimiento.Value = sdr("t_fecha_nac")
            If (sdr("t_sexo") = "M") Then
                rdb_Masculino.Checked = True
            Else
                rdb_Femenino.Checked = True
            End If
            If (sdr("t_edo_civil") = "S") Then
                rdb_soltero.Checked = True
            ElseIf (sdr("t_edo_civil") = "C") Then
                rdb_Casado.Checked = True
            ElseIf (sdr("t_edo_civil") = "D") Then
                rdb_Divorciado.Checked = True
            End If
            rtb_DireccionH.Text = sdr("t_direccion_hab")
            txt_ZonaP.Text = sdr("t_zona_post")
            cmb_Estado.SelectedText = sdr("t_estado_hab")
            cmb_Ciudad.SelectedText = sdr("t_ciudad_hab")
            txt_TlfFijo.Text = sdr("t_telf_hab")
            txt_TlfMovil.Text = sdr("t_telf_cel")
            txt_Correo.Text = sdr("t_correo")
            txt_Profesion.Text = sdr("t_profesion")
            txt_ActEconomica.Text = sdr("t_act_economica")
            txt_Cargo.Text = sdr("t_cargo")
            cmb_EdoTrabajo.SelectedText = sdr("t_estado_trab")
            cmb_CiudadTrabajo.SelectedText = sdr("t_ciudad_trab")
            rtb_DireccionT.Text = sdr("t_direccion_trab")
            txt_TlfTrabajo.Text = sdr("t_telf_trab")
            txt_CorreoT.Text = sdr("t_correo_trab")
            txt_IngresoE.Text = sdr("t_ingreso_promedio")
            btn_Modificar.Enabled = True

        End If

            cn.Close()

    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click

        If (Me.btn_Modificar.Text = "Modificar") Then
            HCampos(Me, True, txt_Cedula)
            cmb_Nacionalidad.Enabled = False
            Me.btn_Modificar.Text = "Guardar"
        Else
            If (validar_controles(Me)) Then
                sentencia = "Select * from tomador where t_cedula= '" + Me.txt_Cedula.Text + "' and t_nacionalidad= '" + cmb_Nacionalidad.SelectedText + "' and t_status= 'A' "
                CSelect(sentencia)

                Dim sex As Char
                Dim eciv As Char
                If (rdb_Masculino.Checked = True) Then
                    sex = "M"
                ElseIf rdb_Femenino.Checked = True Then
                    sex = "F"
                End If
                If rdb_Casado.Checked = True Then
                    eciv = "C"
                ElseIf rdb_Divorciado.Checked = True Then
                    eciv = "D"
                ElseIf rdb_soltero.Checked = True Then
                    eciv = "S"
                End If
                ' If ((txt_PNombre.Text = sdr("t_primer_nombre")) And (txt_SNombre.Text = sdr("t_segundo_nombre")) And (txt_PApellido.Text = sdr("t_primer_apellido")) And
                '    (txt_SApellido.Text = sdr("t_segundo_apellido")) And (dtp_FNacimiento.Value.ToString("yyyy-MM-dd") = sdr("t_fecha_nac")) And (sex = sdr("t_sexo")) And (eciv = sdr("t_edo_civil")) And
                '   (rtb_DireccionH.Text = sdr("t_direccion_hab")) And (txt_ZonaP.Text = sdr("t_zona_post")) And (cmb_Estado.Text = sdr("t_estado_hab")) And
                '  (cmb_Ciudad.Text = sdr("t_ciudad_hab")) And (txt_TlfFijo.Text = sdr("t_telf_hab")) And (txt_TlfMovil.Text = sdr("t_telf_cel")) And
                ' (txt_Correo.Text = sdr("t_correo")) And (txt_Profesion.Text = sdr("t_profesion")) And (txt_ActEconomica.Text = sdr("t_act_economica")) And
                '(txt_Cargo.Text = sdr("t_cargo")) And (cmb_EdoTrabajo.Text = sdr("t_estado_trab")) And (cmb_CiudadTrabajo.Text = sdr("t_ciudad_trab")) And
                '(rtb_DireccionT.Text = sdr("t_direccion_trab")) And (txt_TlfTrabajo.Text = sdr("t_telf_trab")) And (txt_CorreoT.Text = sdr("t_correo_trab")) And
                '(txt_IngresoE.Text = sdr("t_ingreso_promedio"))) Then
                'MsgBox("No se han realizado cambios", vbInformation, "Sin cambios")
                'Me.btn_Cancelar.PerformClick()
                cn.Close()
                'Return
                'Else
                sentencia = "update tomador set t_nacionalidad='" & cmb_Nacionalidad.SelectedItem & "', t_primer_nombre='" & txt_PNombre.Text & "',t_segundo_nombre='" & txt_SNombre.Text & "' ,t_primer_apellido='" & txt_PApellido.Text & "',t_segundo_apellido='" & txt_SApellido.Text & "', t_fecha_nac='" & dtp_FNacimiento.Value.ToString("yyyy-MM-dd") & "',
                                t_sexo='" & sex & "', t_edo_civil='" & eciv & "', t_direccion_hab='" & rtb_DireccionH.Text & "',t_zona_post='" & txt_ZonaP.Text & "', t_estado_hab='" & cmb_Estado.Text & "', t_ciudad_hab='" & cmb_Ciudad.Text & "', t_telf_hab='" & txt_TlfFijo.Text & "',
                                t_telf_cel='" & txt_TlfMovil.Text & "', t_correo='" & txt_Correo.Text & "', t_profesion='" & txt_Profesion.Text & "', t_act_economica='" & txt_ActEconomica.Text & "', t_cargo='" & txt_Cargo.Text & "', t_estado_trab='" & cmb_EdoTrabajo.Text & "', t_ciudad_trab='" & cmb_CiudadTrabajo.Text & "',
                                t_direccion_trab='" & rtb_DireccionT.Text & "', t_telf_trab='" & txt_TlfTrabajo.Text & "', t_correo_trab='" & txt_CorreoT.Text & "', t_ingreso_promedio='" & txt_IngresoE.Text & "' where t_cedula='" & txt_Cedula.Text & "' "
                    comando22(sentencia)
                    MsgBox("Los cambios se han realizado con exito", vbInformation, "Cambios")
                    Me.btn_Cancelar.PerformClick()
                ' End If
            Else
                MsgBox("Debe llenar todos los campos", vbInformation, vbOK)
            End If

        End If


    End Sub
End Class