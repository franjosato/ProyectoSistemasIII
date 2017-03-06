Public Class frm_Vehiculo
    Private Sub frm_Vehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HCampos(False)
        btn_Agregar.Enabled = False
        HBotones(False)
        LimpiarC()
        btn_Agregar.Enabled = False
    End Sub

    Private Sub HCampos(ByRef sn As Boolean)
        txt_Placa.Enabled = Not sn
        txt_SerialMotor.Enabled = sn
        txt_SerialCarroceria.Enabled = sn
        txt_Kilometraje.Enabled = sn
        txt_Color.Enabled = sn
        cmb_Marca.Enabled = sn
        cmb_Año.Enabled = sn
        cmb_Tipovehiculo.Enabled = sn
        txt_TituloPropiedad.Enabled = sn
        btn_Cargar.Enabled = sn
        btn_CargarFoto.Enabled = sn
    End Sub
    Private Function Validar() As Boolean
        If (txt_Placa.Text = "") Then Return False
        If (txt_Color.Text = "") Then Return False
        If (txt_Kilometraje.Text = "") Then Return False
        If (txt_SerialCarroceria.Text = "") Then Return False
        If (txt_SerialMotor.Text = "") Then Return False
        If (txt_TituloPropiedad.Text = "") Then Return False
        Return True
    End Function
    Private Sub HBotones(ByRef sn As Boolean)
        btn_Agregar.Enabled = Not sn
        btn_Buscar.Enabled = Not sn
        btn_Cancelar.Enabled = Not sn
        btn_Eliminar.Enabled = sn
        btn_Modificar.Enabled = sn
        btn_Volver.Enabled = Not sn
    End Sub
    Private Sub LimpiarC()
        txt_Placa.Text = ""
        txt_SerialMotor.Text = ""
        txt_SerialCarroceria.Text = ""
        txt_Kilometraje.Text = ""
        txt_Color.Text = ""
        cmb_Marca.SelectedIndex = -1
        cmb_Año.SelectedIndex = -1
        cmb_Tipovehiculo.SelectedIndex = -1


    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click

        If (txt_Placa.Text = "") Then
            MsgBox("Debe llenar el campo de placa", vbInformation, "Error")
            Return
        End If

        sentencia = "Select * from vehiculo where v_placa= '" +
            txt_Placa.Text + "' and v_estatus= 'I' "
        CSelect(sentencia)
        If Not ((sdr.IsClosed) Or Not (sdr.HasRows)) Then
            MsgBox("Vehiculo desactivado, por favor comuniquese con el administrador", vbInformation, "Empleado desactivado")
        Else
            cn.Close()
            sentencia = "Select * from vehiculo where v_placa='" +
            txt_Placa.Text + "' and v_estatus= 'A' "
            CSelect(sentencia)
            If ((sdr.IsClosed) Or Not (sdr.HasRows)) Then
                If MsgBox("El vehiculo no existe ¿Desea agregarlo?", vbYesNo, "Registro no existente") = MsgBoxResult.Yes Then
                    HCampos(True)
                    HBotones(False)
                    btn_Buscar.Enabled = False
                End If
            Else
                cmb_Marca.Text = sdr("v_mv_codigo")
                cmb_Tipovehiculo.Text = sdr("v_tv_codigo")
                txt_SerialMotor.Text = sdr("v_serial_motor")
                cmb_Año.Text = sdr("v_año")
                txt_Color.Text = sdr("v_color")
                txt_SerialCarroceria.Text = sdr("v_serial_carroceria")
                txt_Kilometraje.Text = sdr("v_kilometraje")
                'titulo de propiedad e imagen
                Me.HBotones(True)
                Me.btn_Cancelar.Enabled = True
            End If
        End If
    End Sub


    Private Sub txt_Placa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Placa.KeyPress
        ValidarNumero(e)
        If Asc(e.KeyChar) = 13 Then
            Me.btn_Buscar.PerformClick()
        End If
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        HCampos(False)
        HBotones(False)
        Limpiar(Me)
        btn_Modificar.Text = "Modificar"
        Me.btn_Agregar.Enabled = False
    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        If (Me.btn_Modificar.Text = "Modificar") Then
            txt_Color.Enabled = True
            txt_Kilometraje.Enabled = True
            btn_CargarFoto.Enabled = True
            Me.btn_Eliminar.Enabled = False
            Me.btn_Modificar.Text = "Guardar"
        Else
            If (validar()) Then
                sentencia = "Select * from vehiculo where v_placa= '" + txt_Placa.Text + "' and v_estatus= 'A' "
                CSelect(sentencia)
                If ((txt_Color.Text = sdr("v_color")) And
                txt_Kilometraje.Text = sdr("v_kilometraje")) Then

                    MsgBox("No se han realizado cambios", vbInformation, "Sin cambios")
                    Me.btn_Cancelar.PerformClick()
                    cn.Close()
                    Return
                Else
                    sentencia = "update vehiculo set v_color='" + txt_Color.Text + "', v_kilometraje='" + txt_Kilometraje.Text + "'"

                    comando22(sentencia)
                    MsgBox("Cambios realizados con exito", vbInformation, "Cambios")
                    Me.btn_Cancelar.PerformClick()
                End If
            Else
                MsgBox("Debe llenar todos los campos", vbInformation, vbOK)
            End If

        End If
    End Sub

    Private Sub btn_Volver_Click(sender As Object, e As EventArgs) Handles btn_Volver.Click
        Close()

    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        If MsgBox("¿Desea eliminar el vehiculo?", vbYesNo, "Eliminar vehiculo") = MsgBoxResult.Yes Then
            sentencia = "update vehiculo set v_estado='I' where v_placa='" + txt_Placa.Text + "'"
            If (comando22(sentencia)) Then
                MsgBox("Vehiculo eliminado", vbInformation, "Eliminación")
                Me.btn_Cancelar.PerformClick()
            Else
                MsgBox("No se realizaron cambios", vbInformation, "Eliminacion")
            End If

        End If
    End Sub
    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click

        If (Validar()) Then
            If MsgBox("¿Desea agregar el vehiculo?", vbYesNo, "Registro") = MsgBoxResult.Yes Then
                sentencia = "INSERT INTO vehiculo 
                            (`v_placa`, 
                            `v_tv_codigo`, 
                            `v_mv_codigo`,
                             `v_año`, 
                            `v_color`, 
                            `v_serial_motor`, 
                            `v_serial_carroceria`, 
                            `v_estatus`, 
                            'v_kilometraje') VALUES 
                            ( '" + txt_Placa.Text + "', 
                            '" + cmb_Tipovehiculo.Text + "', 
                            '" + cmb_Marca.Text + "', 
                            '" + cmb_Año.Text + "', 
                            '" + txt_Color.Text + "', 
                            '" + txt_SerialMotor.Text + "', 
                            '" + txt_SerialCarroceria.Text + "', 
                            'A',
                            '" + txt_Kilometraje.Text + "')"
                'falta foto y pdf
                comando22(sentencia)
                MsgBox("Se ha registrado un vehiculo", vbInformation, "Registro exitoso")
                btn_Cancelar.PerformClick()
            Else
                btn_Cancelar.PerformClick()
            End If
        Else
            MsgBox("Debe llenar todos los campos", vbInformation, vbOK)
        End If
    End Sub


End Class

'falta por agregar fotos y pdf