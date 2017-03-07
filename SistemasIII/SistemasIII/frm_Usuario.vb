Imports MySql.Data.MySqlClient

Public Class frm_Usuario
    Dim opcion As Integer = 0
    Private Sub frm_Usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Seguros Maldonado" + " - " + lbl_EncabezadoFormuladio.Text
        cargarCampos()
        ActiveControl = cmb_Cedula
        opcion = 0
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        If Not (validar1()) Then
            Return
        End If


        'Verficamos quee exista el empleado
        sentencia = "Select em_primer_nombre,
                            em_segundo_nombre,
                            em_primer_apellido,
                            em_segundo_apellido,
                            em_te_codigo from empleado where em_cedula = '" & cmb_Cedula.Text & "'"
        CSelect(sentencia)
        If ((sdr.IsClosed) Or Not (sdr.HasRows)) Then
            MsgBox("Empleado no existente", vbInformation, "Seguros Maldonado")
            ActiveControl = cmb_Cedula
            Return
        End If

        If Not (sdr("em_primer_nombre") = Nothing) Then txt_PNombre.Text = sdr("em_primer_nombre")
        If Not (sdr("em_segundo_nombre") = Nothing) Then txt_SNombre.Text = sdr("em_segundo_nombre")
        If Not (sdr("em_primer_apellido") = Nothing) Then txt_PApellido.Text = sdr("em_primer_apellido")
        If Not (sdr("em_segundo_apellido") = Nothing) Then txt_SApellido.Text = sdr("em_segundo_apellido")
        If Not (sdr("em_te_codigo") = Nothing) Then txt_TipodeEmpleado.Text = sdr("em_te_codigo")
        HBotones(True)

        sentencia = "Select * from usuario where u_em_cedula = '" & cmb_Cedula.Text & "' " 'Luego que muestra al empleado muestra los datos del usuaio
        CSelect(sentencia)
        'Si empleado tiene un usaurio asociado se carga
        If Not ((sdr.IsClosed) Or Not (sdr.HasRows)) Then
            txt_Usuario.Text = sdr("u_usuario")
            txt_Contraseña.Text = sdr("u_contraseña")
            opcion = 1 'Se puede modificar
            cmb_Cedula.Enabled = False
            btn_Volver.Enabled = True
            btn_Cancelar.Enabled = True
        Else
            HCampos(True)
            btn_Eliminar.Enabled = False
            btn_Cancelar.Enabled = True
            ActiveControl = txt_Usuario
            btn_Modificar.Text = "Guardar"
            opcion = 0
        End If
    End Sub

    Private Sub HCampos(ByRef sn As Boolean)
        cmb_Cedula.Enabled = Not sn
        txt_Contraseña.Enabled = sn
        txt_Usuario.Enabled = sn
    End Sub

    Private Sub HBotones(ByRef sn As Boolean)
        btn_Buscar.Enabled = Not sn
        btn_Cancelar.Enabled = Not sn
        btn_Eliminar.Enabled = sn
        btn_Modificar.Enabled = sn
        btn_Volver.Enabled = Not sn
    End Sub
    Private Sub LimpiarC()
        cmb_Cedula.Text = ""
        cmb_Cedula.SelectedIndex = -1
        txt_PApellido.Text = ""
        txt_PNombre.Text = ""
        txt_SApellido.Text = ""
        txt_SNombre.Text = ""
        txt_Contraseña.Text = ""
        txt_Usuario.Text = ""
        txt_TipodeEmpleado.Text = ""
    End Sub
    Private Sub cargarCampos()
        'Cargar autocomplete de empleado
        sentencia = "Select em_cedula from empleado where em_estatus='A' order by em_cedula"
        cmb_Cedula.AutoCompleteCustomSource = Autocompletar(sentencia, "em_cedula")
        cmb_Cedula.AutoCompleteMode = AutoCompleteMode.Suggest
        cmb_Cedula.AutoCompleteSource = AutoCompleteSource.CustomSource
        'Cargar combobox de emplead
        sentencia = "Select em_cedula from empleado where em_estatus='A' order by em_cedula"
        cmb_Cedula.DataSource = Datos(sentencia)
        cmb_Cedula.DisplayMember = "Empleado"
        cmb_Cedula.ValueMember = "em_cedula"
        cmb_Cedula.SelectedIndex = -1
    End Sub
    Private Sub txt_Cedula_TextChanged(sender As Object, e As EventArgs)
        'ValidarNumero(e)
    End Sub

    Private Sub txt_Cedula_KeyPress(sender As Object, e As KeyPressEventArgs)
        ValidarNumero(e)
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        HCampos(False)
        HBotones(False)
        LimpiarC()
        btn_Modificar.Text = "Modificar"
        cargarCampos()
        ActiveControl = cmb_Cedula
    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        If (btn_Modificar.Text = "Modificar") Then
            HCampos(True)
            btn_Cancelar.Enabled = True
            btn_Eliminar.Enabled = False
            btn_Modificar.Text = "Guardar"
        Else
            If (validar2()) Then
                If (opcion = 1) Then 'Si se desea modificar
                    sentencia = "Select u_usuario, u_contraseña from usuario where u_em_cedula= '" + cmb_Cedula.Text + "'"
                    CSelect(sentencia)
                    If ((txt_Usuario.Text = sdr("u_usuario")) And (txt_Contraseña.Text = sdr("u_contraseña"))) Then
                        MsgBox("No se han realizado cambios", vbInformation, "Seguros Maldonado")
                        btn_Cancelar.PerformClick()
                        Return
                    Else
                        sentencia = "update usuario set u_usuario='" + txt_Usuario.Text + "',
                                                        u_contraseña ='" + txt_Contraseña.Text + "' where u_em_cedula=" + cmb_Cedula.Text

                        comando22(sentencia)
                        MsgBox("Los cambios se han realizado con exito", vbInformation, "Seguros Maldonado")
                        btn_Cancelar.PerformClick()
                    End If
                Else
                    'Si se desea incluir
                    If MsgBox("¿Desea agregar al usuario?", vbYesNo, "Seguros Maldonado") = MsgBoxResult.Yes Then
                        sentencia = "INSERT INTO usuario(`u_em_cedula`, `u_usuario`, `u_contraseña`) VALUES (" &
                                 cmb_Cedula.Text & ", '" & txt_Usuario.Text & "', '" & txt_Contraseña.Text & "')"

                        comando22(sentencia)
                        MsgBox("Se ha registrado un usuario", vbInformation, "Seguros Maldonado")
                        btn_Cancelar.PerformClick()
                    End If
                End If
                End If
        End If
    End Sub

    Private Function validar1() As Boolean
        validar1 = True
        If (cmb_Cedula.SelectedIndex = -1) Then
            validar1 = False
            MsgBox("Por favor ingrese una cedula", vbInformation, "Seguros Maldonado")
        End If

        Return validar1
    End Function

    Private Function validar2() As Boolean
        validar2 = True
        If (txt_Usuario.Text = "") Then validar2 = False
        If (txt_Contraseña.Text = "") Then validar2 = False
        If validar2 = False Then
            MsgBox("Por llene ambos campos", vbInformation, "Seguros Maldonado")
            ActiveControl = txt_Usuario
        End If
        Return validar2
    End Function

    Private Sub btn_Volver_Click(sender As Object, e As EventArgs) Handles btn_Volver.Click
        Me.Close()
    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        If MsgBox("¿Desea eliminar al usuario?", vbYesNo, "Seguros Maldonado") = MsgBoxResult.Yes Then

            sentencia = "update empleado set em_estatus='I' where em_cedula='" + cmb_Cedula.Text + "'"
            If (comando22(sentencia)) Then
                sentencia = " delete from usuario where u_em_cedula = '" + cmb_Cedula.Text + "' "
                If (comando22(sentencia)) Then
                    MsgBox("usuario eliminado", vbInformation, "Seguros Maldonado")
                    btn_Cancelar.PerformClick()
                Else
                    MsgBox("Error al eliminar usuario", vbCritical, "Seguros Maldonado")
                End If
            End If

        End If

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Me.lbl_Fecha.Text = DateString
        Me.lbl_Hora.Text = TimeOfDay
    End Sub

    Private Sub lbl_EncabezadoFormuladio_Click(sender As Object, e As EventArgs) Handles lbl_EncabezadoFormuladio.Click

    End Sub

    Private Sub txt_Cedula_KeyDown(sender As Object, e As KeyEventArgs)
        If (e.KeyCode.Equals(Keys.Enter)) Then
            btn_Buscar.PerformClick()
        End If
    End Sub

    Private Sub cmb_Cedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_Cedula.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub cmb_Cedula_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_Cedula.KeyDown
        If (e.KeyCode.Equals(Keys.Enter)) Then
            btn_Buscar.PerformClick()
        End If
    End Sub

    Private Sub txt_Usuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Usuario.KeyDown
        If (e.KeyCode.Equals(Keys.Enter)) Then
            btn_Modificar.PerformClick()
        End If
    End Sub

    Private Sub txt_Contraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Contraseña.KeyDown
        If (e.KeyCode.Equals(Keys.Enter)) Then
            btn_Modificar.PerformClick()
        End If
    End Sub
End Class
