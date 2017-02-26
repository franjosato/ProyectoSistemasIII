Imports MySql.Data.MySqlClient
Public Class frm_PlanPago

    Private Sub frm_PlanPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarTxt()
        HCampos(False)
        Me.btn_Agregar.Enabled = False
        HBotones(False)
        LimpiarC()
        Me.ActiveControl() = Me.txt_Nombre

    End Sub

    Private Sub HCampos(ByRef sn As Boolean)
        Me.txt_Nombre.Enabled = Not sn
        Me.txt_Codigo.Enabled = sn
        Me.txt_Cantidadc.Enabled = sn
        Me.rtb_Descripcion.Enabled = sn
        Me.txt_Porcentaje.Enabled = sn
    End Sub

    Private Sub HBotones(ByRef sn As Boolean)
        Me.btn_Agregar.Enabled = Not sn
        Me.btn_Buscar.Enabled = Not sn
        Me.btn_Cancelar.Enabled = Not sn
        Me.btn_Eliminar.Enabled = sn
        Me.btn_Modificar.Enabled = sn
        Me.btn_Salir.Enabled = Not sn
    End Sub

    Private Sub LimpiarC()
        Me.txt_Nombre.Text = ""
        Me.txt_Codigo.Text = ""
        Me.txt_Cantidadc.Text = ""
        Me.rtb_Descripcion.Text = ""
        Me.txt_Porcentaje.Text = ""
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        HCampos(False)
        HBotones(False)
        LimpiarC()
        Me.btn_Modificar.Text = "Modificar"
        Me.ActiveControl() = Me.txt_Nombre
        Me.btn_Agregar.Enabled = False
        cargarTxt()
    End Sub

    Private Sub cargarTxt()
        sentencia = "Select pp_nombre from plan_pago where pp_estatus='A' order by pp_codigo"
        Me.txt_Nombre.AutoCompleteCustomSource = Autocompletar(sentencia, "pp_nombre")
        Me.txt_Nombre.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txt_Nombre.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub

    Private Sub txt_Cantidadc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Cantidadc.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_Porcentaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Porcentaje.KeyPress
        ValidarNumero(e)
    End Sub

    Private Function validar() As Boolean
        If (Me.txt_Nombre.Text = "") Then Return False
        If ((Me.txt_Cantidadc.Text = "") Or (CInt(Me.txt_Cantidadc.Text) = 0) Or (CInt(Me.txt_Cantidadc.Text) > 24)) Then Return False
        If (Me.txt_Codigo.Text = "") Then Return False
        If ((Me.txt_Porcentaje.Text = "") Or (CType(Me.txt_Cantidadc.Text, Integer) > 100)) Then Return False
        If (Me.rtb_Descripcion.Text = "") Then Return False
        Return True
    End Function

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        If Me.txt_Nombre.Text = "" Then
            MsgBox("Debe llenar el campo 'Nombre'", vbInformation, "Error")
            Return
        End If

        cn.Close()
        Dim numero As Integer = Me.txt_Nombre.AutoCompleteCustomSource.IndexOf(Me.txt_Nombre.Text) + 1
        'sentencia = "set @row_num = 0; select * from(select @row_num := @row_num + 1 as row_number,pp_codigo,pp_nombre,pp_descripcion,pp_nrocuotas,pp_porcentaje
        'From plan_pago where pp_estatus='A'ORDER BY pp_codigo)as rows where rows.row_number='" & numero & "'"
        'sentencia = "set @row_num = 0;select @row_num := @row_num + 1 as row_number,pp_codigo,pp_nombre,pp_descripcion,pp_nrocuotas,pp_porcentaje from plan_pago
        'where pp_estatus ='A' ORDER BY pp_codigo"
        sentencia = "select * from plan_pago where pp_nombre='" & Me.txt_Nombre.Text & "' and pp_estatus='A'"

        CSelect(sentencia)

        If Not (sdr.HasRows) Then
            If MsgBox("El plan de pago no existe ¿Desea agregarlo?", vbYesNo, "Registro no existente") = MsgBoxResult.Yes Then
                HCampos(True)
                HBotones(False)
                Me.btn_Buscar.Enabled = False
                Me.rtb_Descripcion.Focus()
                sentencia = "Select count(*) As numero from plan_pago"
                CSelect(sentencia)
                Me.txt_Codigo.Enabled = False
                Me.txt_Codigo.Text = (sdr("numero") + 1)
            End If
        Else
            Me.txt_Nombre.Text = sdr("pp_codigo")
            Me.rtb_Descripcion.Text = sdr("pp_descripcion")
            Me.txt_Cantidadc.Text = sdr("pp_nrocuotas")
            Me.txt_Porcentaje.Text = sdr("pp_porcentaje")
            Me.txt_Codigo.Text = sdr("pp_codigo")
            Me.HBotones(True)
            Me.txt_Nombre.Enabled = False
            Me.btn_Cancelar.Enabled = True
        End If


    End Sub

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        If (validar()) Then
            If MsgBox("¿Desea agregar el plan de pago?", vbYesNo, "Registro") = MsgBoxResult.Yes Then
                sentencia = "Select count(*) As numero from plan_pago"
                CSelect(sentencia)
                Dim numero As Integer = CType(sdr("numero"), Integer) + 1
                sentencia = "INSERT INTO plan_pago (`pp_codigo`, `pp_nombre`, `pp_descripcion`, `pp_nrocuotas`, `pp_porcentaje`, `pp_estatus`)
                            VALUES('" & numero & "', '" & Me.txt_Nombre.Text & "', '" & Me.rtb_Descripcion.Text & "', '" + Me.txt_Cantidadc.Text &
                             "', '" & Me.txt_Porcentaje.Text & "', 'A')"
                comando22(sentencia)
                MsgBox("Se ha registrado un plan de pago", vbInformation, "Registro exitoso")
                Me.btn_Cancelar.PerformClick()
            End If
        Else
            MsgBox("Existe al menos un error en los campos", vbInformation, "Error")
        End If

    End Sub

    Private Sub txt_Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Nombre.KeyPress
        Validarletras(e)
        'If Asc(e.KeyChar) = 13 Then
        'Me.btn_Buscar.PerformClick()
        'End If
    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        If (Me.btn_Modificar.Text = "Modificar") Then
            HCampos(True)
            Me.btn_Eliminar.Enabled = False
            Me.btn_Modificar.Text = "Guardar"
        Else
            If (validar()) Then
                sentencia = "Select * from plan_pago where pp_codigo= '" + Me.txt_Codigo.Text + "' and pp_estatus= 'A' "
                CSelect(sentencia)
                If ((Me.txt_Nombre.Text = sdr("pp_nombre")) And (Me.rtb_Descripcion.Text = sdr("pp_descripcion")) And
                (Me.txt_Porcentaje.Text = sdr("pp_porcentaje")) And (Me.txt_Cantidadc.Text = sdr("pp_nrocuotas"))) Then
                    MsgBox("No se han realizado cambios", vbInformation, "Sin cambios")
                    Me.btn_Cancelar.PerformClick()
                    cn.Close()
                    Return
                Else
                    sentencia = "update plan_pago set pp_descripcion='" + rtb_Descripcion.Text + "',pp_nrocuotas='" + Me.txt_Cantidadc.Text + "',
                pp_porcentaje ='" + Me.txt_Porcentaje.Text + "' where pp_nombre='" + Me.txt_Nombre.Text + "'and pp_estatus='A'"
                    comando22(sentencia)
                    MsgBox("Los cambios se han realizado con exito", vbInformation, "Cambios")
                    Me.btn_Cancelar.PerformClick()
                End If
            Else
                MsgBox("Debe llenar todos los campos", vbInformation, "Error")
            End If

        End If
    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        If MsgBox("¿Desea eliminar al plan de pago?", vbYesNo, "Eliminar plan de pago") = MsgBoxResult.Yes Then
            sentencia = "update plan_pago set pp_estatus='I' where pp_codigo='" + Me.txt_Codigo.Text + "'"
            If (comando22(sentencia)) Then
                MsgBox("Plan de pago eliminado", vbInformation, "Eliminación")
                Me.btn_Cancelar.PerformClick()
            Else
                MsgBox("Error al eliminar el plan de pago", vbInformation, "Error en eliminación")
            End If

        End If
    End Sub

    Private Sub txt_Nombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Nombre.KeyDown
        If (e.KeyCode.Equals(Keys.Enter)) Then
            Me.btn_Buscar.PerformClick()
        End If
    End Sub
End Class