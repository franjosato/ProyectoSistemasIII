Imports MySql.Data.MySqlClient
Public Class frm_Empleado
    Private Sub frm_Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HCampos(False)
        Me.btn_Agregar.Enabled = False
        HBotones(False)
        LimpiarC()
        Me.ActiveControl() = Me.cmb_Nacionalidad
        Me.cmb_Nacionalidad.SelectedIndex() = 0
    End Sub

    Private Sub HCampos(ByRef sn As Boolean)
        Me.txt_Cedula.Enabled = Not sn
        Me.txt_PNombre.Enabled = sn
        Me.txt_PApellido.Enabled = sn
        Me.txt_SApellido.Enabled = sn
        Me.txt_SNombre.Enabled = sn
        Me.txt_Correo.Enabled = sn
        Me.txt_TlfFijo.Enabled = sn
        Me.cmb_Nacionalidad.Enabled = Not sn
        Me.cmb_tipoE.Enabled = sn
    End Sub

    Private Sub HBotones(ByRef sn As Boolean)
        Me.btn_Agregar.Enabled = Not sn
        Me.btn_Buscar.Enabled = Not sn
        Me.btn_Cancelar.Enabled = Not sn
        Me.btn_Eliminar.Enabled = sn
        Me.btn_Modificar.Enabled = sn
        Me.btn_Volver.Enabled = Not sn
    End Sub
    Private Sub LimpiarC()
        Me.txt_Cedula.Text = ""
        Me.txt_Correo.Text = ""
        Me.txt_PApellido.Text = ""
        Me.txt_PNombre.Text = ""
        Me.txt_SApellido.Text = ""
        Me.txt_SNombre.Text = ""
        Me.txt_TlfFijo.Text = ""
        Me.cmb_Nacionalidad.ResetText()
        Me.cmb_tipoE.ResetText()
    End Sub

    Private Sub txt_Cedula_TextChanged(sender As Object, e As EventArgs) Handles txt_Cedula.TextChanged
        'ValidarNumero(e)
    End Sub

    Private Sub txt_Cedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Cedula.KeyPress
        ValidarNumero(e)
        If Asc(e.KeyChar) = 13 Then
            Me.btn_Buscar.PerformClick()
        End If
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click

        If (Me.cmb_Nacionalidad.SelectedItem = "") Or (Me.txt_Cedula.Text = "") Then
            MsgBox("Debe llenar ambos campos", vbInformation, "Error")
            Return
        End If

        sentencia = "Select * from empleado where em_cedula= '" +
            Me.txt_Cedula.Text + "' and em_estatus= 'A' "
        CSelect(sentencia)

        If (sdr.IsClosed) Or Not (sdr.HasRows) Then
            If MsgBox("El empleado no existe ¿Desea agregarlo?", vbYesNo, "Registro no existente") = MsgBoxResult.Yes Then
                HCampos(True)
                HBotones(False)
                Me.btn_Buscar.Enabled = False
                Me.txt_PNombre.Focus()
            End If
        Else
            Me.txt_PNombre.Text = sdr("em_primer_nombre")
            Me.txt_SNombre.Text = sdr("em_segundo_nombre")
            Me.txt_PApellido.Text = sdr("em_primer_apellido")
            Me.txt_SApellido.Text = sdr("em_segundo_apellido")
            Me.txt_Correo.Text = sdr("em_correo")
            Me.txt_TlfFijo.Text = sdr("em_tlef")
            'Me.cmb_Nacionalidad.Text = sdr("em_ti")
            Me.cmb_tipoE.SelectedText = sdr("em_tipo")
            Me.HBotones(True)
        End If

        cn.Close()

    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        HCampos(False)
        HBotones(False)
        LimpiarC()
        Me.btn_Modificar.Text = "Modificar"
        Me.ActiveControl() = Me.txt_Cedula
    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        If (Me.btn_Modificar.Text = "Modificar") Then
            HCampos(True)
            Me.btn_Eliminar.Enabled = False
            Me.btn_Modificar.Text = "Guardar"
        Else
            If (validar()) Then
                sentencia = "Select * from empleado where em_cedula= '" + Me.txt_Cedula.Text + "' and em_estatus= 'A' "
                CSelect(sentencia)
                If ((Me.txt_PNombre.Text = sdr("em_primer_nombre")) And (Me.txt_SNombre.Text = sdr("em_segundo_nombre")) And
                (Me.txt_PApellido.Text = sdr("em_primer_apellido")) And (Me.txt_SApellido.Text = sdr("em_segundo_apellido")) And (Me.txt_TlfFijo.Text = sdr("em_tlef")) And (Me.txt_Correo.Text = sdr("em_correo"))) Then
                    MsgBox("No se han realizado cambios", vbInformation, "Sin cambios")
                    Me.btn_Cancelar.PerformClick()
                    cn.Close()
                    Return
                Else
                    sentencia = "update empleado set em_correo='" + txt_Correo.Text + "',em_primer_apellido='" + Me.txt_PApellido.Text + "',
                em_segundo_apellido ='" + Me.txt_SApellido.Text + "',em_primer_nombre='" +
                Me.txt_PNombre.Text + "',em_segundo_nombre='" +
                Me.txt_SNombre.Text + "', em_tlef='" + Me.txt_TlfFijo.Text + "' where em_cedula=" + Me.txt_Cedula.Text

                    comando22(sentencia)
                    MsgBox("Los cambios se han realizado con exito", vbInformation, "Cambios")
                    Me.btn_Cancelar.PerformClick()
                End If
            Else
                MsgBox("Debe llenar todos los campos", vbInformation, vbOK)
            End If

        End If
    End Sub
    Private Sub txt_PNombre_KeyPress(sender As Object, e As EventArgs) Handles txt_PNombre.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_SNombre_KeyPress(sender As Object, e As EventArgs) Handles txt_SNombre.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_PApellido_KeyPress(sender As Object, e As EventArgs) Handles txt_PApellido.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_SApellido_KeyPress(sender As Object, e As EventArgs) Handles txt_SApellido.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_TlfFijo_KeyPress(sender As Object, e As EventArgs) Handles txt_TlfFijo.KeyPress
        ValidarNumero(e)
    End Sub

    Private Function validar() As Boolean
        If (Me.cmb_Nacionalidad.Text = "") Then Return False
        If (Me.txt_Cedula.Text = "") Then Return False
        If (Me.txt_PNombre.Text = "") Then Return False
        If (Me.txt_SNombre.Text = "") Then Return False
        If (Me.txt_PApellido.Text = "") Then Return False
        If (Me.txt_SApellido.Text = "") Then Return False
        If (Me.txt_TlfFijo.Text = "") Then Return False
        If (Me.txt_Correo.Text = "") Then Return False
        If (Me.cmb_tipoE.Text = "") Then Return False
        Return True
    End Function

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        If (validar()) Then

            sentencia = "INSERT INTO empleado (`em_cedula`, `em_primer_nombre`, `em_segundo_nombre`,
            `em_primer_apellido`, `em_segundo_apellido`, `em_tipo`, `em_tlef`, `em_correo`, `em_estatus`) VALUES ('" +
            Me.txt_Cedula.Text + "', '" + Me.txt_PNombre.Text + "', '" + Me.txt_SNombre.Text + "', '" + Me.txt_PApellido.Text + "', '" + Me.txt_SApellido.Text +
            "', '" + Me.cmb_tipoE.SelectedItem + "', '" + Me.txt_TlfFijo.Text + "', '" + Me.txt_Correo.Text + "', 'A')"

            comando22(sentencia)
            MsgBox("Se ha registrado un empleado", vbInformation, "Registro exitoso")
            Me.btn_Cancelar.PerformClick()
        Else
            MsgBox("Debe llenar todos los campos", vbInformation, vbOK)
        End If
    End Sub
    Private Sub btn_Volver_Click(sender As Object, e As EventArgs) Handles btn_Volver.Click
        Me.Close()
    End Sub
End Class
