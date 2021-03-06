﻿Imports MySql.Data.MySqlClient
Public Class frm_TipoInspeccion
    Private Sub frm_TipoInspeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarTxt()
        HCampos(False)
        HBotones(False)
        LimpiarC()
        Me.ActiveControl() = Me.txt_Nombre
        Me.btn_Agregar.Enabled = False

    End Sub

    Private Sub HCampos(ByRef sn As Boolean)
        Me.txt_Nombre.Enabled = Not sn
        Me.txt_Codigo.Enabled = sn
        Me.rtb_Descripcion.Enabled = sn
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
        Me.rtb_Descripcion.Text = ""
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
        sentencia = "Select ti_nombre from tipo_inspeccion where ti_estatus='A' order by ti_codigo"
        Me.txt_Nombre.AutoCompleteCustomSource = Autocompletar(sentencia, "ti_nombre")
        Me.txt_Nombre.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txt_Nombre.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub

    Private Function validar() As Boolean
        If (Me.txt_Nombre.Text = "") Then Return False
        If (Me.txt_Codigo.Text = "") Then Return False
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
        sentencia = "select * from tipo_inspeccion where ti_nombre='" & Me.txt_Nombre.Text & "' and ti_estatus='A'"

        CSelect(sentencia)

        If Not (sdr.HasRows) Then
            If MsgBox("El tipo de inspeccion no existe ¿Desea agregarlo?", vbYesNo, "Registro no existente") = MsgBoxResult.Yes Then
                HCampos(True)
                HBotones(False)
                Me.btn_Buscar.Enabled = False
                Me.rtb_Descripcion.Focus()
                sentencia = "Select count(*) As numero from tipo_inspeccion"
                CSelect(sentencia)
                Me.txt_Codigo.Enabled = False
                Me.txt_Codigo.Text = (sdr("numero") + 1)
            End If
        Else
            Me.txt_Nombre.Text = sdr("ti_codigo")
            Me.rtb_Descripcion.Text = sdr("ti_descripcion")
            Me.txt_Codigo.Text = sdr("ti_codigo")
            Me.HBotones(True)
            Me.txt_Nombre.Enabled = False
            Me.btn_Cancelar.Enabled = True
        End If


    End Sub

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        If (validar()) Then
            If MsgBox("¿Desea agregar el tipo de inspeccion?", vbYesNo, "Registro") = MsgBoxResult.Yes Then
                sentencia = "Select count(*) As numero from tipo_inspeccion"
                CSelect(sentencia)
                Dim numero As Integer = CType(sdr("numero"), Integer) + 1
                sentencia = "INSERT INTO tipo_inspeccion (`ti_codigo`, `ti_nombre`, `ti_descripcion`,`ti_estatus`)
                        VALUES('" & numero & "', '" & Me.txt_Nombre.Text & "', '" & Me.rtb_Descripcion.Text & "', 'A')"
                comando22(sentencia)
                MsgBox("Se ha registrado un tipo de inspeccion", vbInformation, "Registro exitoso")
                Me.btn_Cancelar.PerformClick()
            End If
        Else
            MsgBox("Existe al menos un error en los campos", vbInformation, "Error")
        End If

    End Sub

    Private Sub txt_Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Nombre.KeyPress
        Validarletras(e)
    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        If (Me.btn_Modificar.Text = "Modificar") Then
            HCampos(True)
            Me.btn_Eliminar.Enabled = False
            Me.btn_Modificar.Text = "Guardar"
        Else
            If (validar()) Then
                sentencia = "Select * from tipo_inspeccion where ti_codigo= '" + Me.txt_Codigo.Text + "' and ti_estatus= 'A' "
                CSelect(sentencia)
                If ((Me.txt_Nombre.Text = sdr("ti_nombre")) And (Me.rtb_Descripcion.Text = sdr("ti_descripcion"))) Then
                    MsgBox("No se han realizado cambios", vbInformation, "Sin cambios")
                    Me.btn_Cancelar.PerformClick()
                    cn.Close()
                    Return
                Else
                    sentencia = "update tipo_inspeccion set ti_descripcion='" + rtb_Descripcion.Text + "where ti_nombre='" +
                        Me.txt_Nombre.Text + "'and ti_estatus='A'"
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
        If MsgBox("¿Desea eliminar al tipo de inspeccion?", vbYesNo, "Eliminar tipo de inspeccion") = MsgBoxResult.Yes Then
            sentencia = "update tipo_inspeccion set ti_estatus='I' where ti_codigo='" + Me.txt_Codigo.Text + "'"
            If (comando22(sentencia)) Then
                MsgBox(" Tipo de inspeccion eliminado", vbInformation, "Eliminación")
                Me.btn_Cancelar.PerformClick()
            Else
                MsgBox("Error al eliminar el tipo de inspeccion", vbInformation, "Error en eliminación")
            End If

        End If
    End Sub

    Private Sub txt_Nombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Nombre.KeyDown
        If (e.KeyCode.Equals(Keys.Enter)) Then
            Me.btn_Buscar.PerformClick()
        End If
    End Sub
End Class
