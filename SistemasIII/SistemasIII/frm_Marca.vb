Imports MySql.Data.MySqlClient

Public Class frm_Marca
    Private Sub frm_Marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HCampos(False)
        Me.btn_Agregar.Enabled = False
        HBotones(False)
        LimpiarC()
    End Sub

    Private Function Validar(ByRef tt As Boolean)
        If (Me.txt_Codigo.Text = "") Then Return False
        If (Me.txt_Marca.Text = "") Then Return False
        If (Me.txt_Modelo.Text = "") Then Return False
        Return True
    End Function


    Private Sub HCampos(ByRef sn As Boolean)
        Me.txt_Codigo.Enabled = Not sn
        Me.txt_Marca.Enabled = sn
        Me.txt_Modelo.Enabled = sn
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
        Me.txt_Codigo.Text = ""
        Me.txt_Marca.Text = ""
        Me.txt_Modelo.Text = ""
    End Sub

    Private Sub txt_Codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Codigo.KeyPress
        ValidarNumero(e)
        If Asc(e.KeyChar) = 13 Then
            Me.btn_Buscar.PerformClick()
        End If
    End Sub

    Private Sub txt_Marca_KeyPress(sender As Object, e As EventArgs) Handles txt_Marca.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_Modelo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Modelo.KeyPress
        Validarletras(e)
    End Sub

    Private Sub btn_Volver_Click(sender As Object, e As EventArgs) Handles btn_Volver.Click
        Me.Close()
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        HCampos(False)
        HBotones(False)
        LimpiarC()
        Me.btn_Modificar.Text = "Modificar"
        Me.ActiveControl() = Me.txt_Codigo
    End Sub


    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click

        If (Me.txt_Codigo.Text = "") Then
            MsgBox("Debe escribir un codigo", vbInformation, "Error")
            Return
        End If

        sql = "Select * from marca_vehiculo where mv_codigo= '" & Me.txt_Codigo.Text & "' and mv_estatus = 'A' "
        CSelect(sql)

        If (sdr.IsClosed) Or Not (sdr.HasRows) Then
            MsgBox("El codigo no existe, agregar primero", vbInformation, "Error")
            btn_Cancelar.PerformClick()

        Else
            Me.txt_Marca.Text = sdr("mv_marca")
            Me.txt_Modelo.Text = sdr("mv_modelo")
            HBotones(True)
            btn_Cancelar.Enabled = True
        End If

        cn.Close()

    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click

        If (Me.btn_Modificar.Text = "Modificar") Then
            HCampos(True)
            Me.btn_Eliminar.Enabled = False
            Me.btn_Modificar.Text = "Guardar"
        Else
            If (Validar(True)) Then
                sql = "SELECT * from marca_vehiculo WHERE mv_codigo = '" + Me.txt_Codigo.Text + "' and mv_estatus = 'A' "
                CSelect(sql)

                If ((Me.txt_Marca.Text = sdr("mv_marca")) And (Me.txt_Modelo.Text = sdr("mv_modelo"))) Then
                    MsgBox("No se realizaron cambios", vbInformation, "Sin cambios")
                    Me.btn_Cancelar.PerformClick()
                    cn.Close()
                    Return
                Else
                    sql = "UPDATE marca_vehiculo SET mv_marca = '" + txt_Marca.Text + "', mv_modelo = '" + txt_Modelo.Text + "' "
                    comando22(sql)
                    MsgBox("Cambios realizados con exito", vbInformation, "Cambios")
                    Me.btn_Cancelar.PerformClick()
                End If
            Else
                MsgBox("Debe llenar todos los campos", vbInformation, vbOK)

            End If

        End If
    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click

        If MsgBox("¿Esta seguro que desea eliminar?", vbYesNo, "Pregunta de seguridad") = MsgBoxResult.Yes Then
            sql = "UPDATE marca_vehiculo SET mv_estatus = 'I'"
            comando22(sql)
            MsgBox("Eliminado correctamente", vbOK, "Eliminacion")
            Me.btn_Cancelar.PerformClick()
        Else
            MsgBox("No se realizaron cambios", vbInformation, "Sin cambios en la eliminacion")
            btn_Cancelar.PerformClick()
        End If

    End Sub

End Class








