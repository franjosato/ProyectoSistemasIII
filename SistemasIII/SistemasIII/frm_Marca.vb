Imports MySql.Data.MySqlClient

Public Class frm_Marca
    Private Sub frm_Marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HCampos(False)
        btn_Agregar.Enabled = False
        HBotones(False)
        LimpiarC()
        btn_Agregar.Enabled = False
    End Sub

    Private Function Validar(ByRef tt As Boolean)
        If (txt_Codigo.Text = "") Then Return False
        If (txt_Marca.Text = "") Then Return False
        If (txt_Modelo.Text = "") Then Return False
        Return True
    End Function


    Private Sub HCampos(ByRef sn As Boolean)
        txt_Codigo.Enabled = Not sn
        txt_Marca.Enabled = sn
        txt_Modelo.Enabled = sn
    End Sub

    Private Sub HBotones(ByRef sn As Boolean)
        'btn_Agregar.Enabled = sn
        btn_Buscar.Enabled = Not sn
        btn_Cancelar.Enabled = Not sn
        btn_Eliminar.Enabled = sn
        btn_Modificar.Enabled = sn
        btn_Volver.Enabled = Not sn
    End Sub

    Private Sub LimpiarC()
        txt_Codigo.Text = ""
        txt_Marca.Text = ""
        txt_Modelo.Text = ""
    End Sub

    Private Sub txt_Codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Codigo.KeyPress
        ValidarNumero(e)
        If Asc(e.KeyChar) = 13 Then
            btn_Buscar.PerformClick()
        End If
    End Sub

    Private Sub txt_Marca_KeyPress(sender As Object, e As EventArgs) Handles txt_Marca.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_Modelo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Modelo.KeyPress
        Validarletras(e)
    End Sub

    Private Sub btn_Volver_Click(sender As Object, e As EventArgs) Handles btn_Volver.Click
        Close()
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        HCampos(False)
        HBotones(False)
        LimpiarC()
        btn_Modificar.Text = "Modificar"
        ActiveControl() = txt_Codigo
        btn_Agregar.Text = "Agregar"
    End Sub


    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click


        If (txt_Codigo.Text = "") Then
            MsgBox("Debe llenar el campo de codigo de marca", vbInformation, "Error")
            Return
        End If

        sentencia = "Select * from marca_vehiculo where mv_codigo= 
                    '" + txt_Codigo.Text + "' and mv_estatus= 'I' "
        CSelect(sentencia)
        If Not ((sdr.IsClosed) Or Not (sdr.HasRows)) Then
            MsgBox("Marca de vehiculo desactivado, por favor comuniquese con el administrador", vbInformation, "Marca de vehiculo desactivado")
            btn_Cancelar.PerformClick()
        Else
            cn.Close()
            sentencia = "Select * from marca_vehiculo where mv_codigo=
                        '" + txt_Codigo.Text + "' and mv_estatus= 'A' "
            CSelect(sentencia)
            If ((sdr.IsClosed) Or Not (sdr.HasRows)) Then
                If MsgBox("La marca no existe ¿Desea agregar una nueva marca de vehiculo?", vbYesNo, "Registro no existente") = MsgBoxResult.Yes Then
                    HCampos(True)
                    HBotones(False)
                    btn_Buscar.Enabled = False
                    txt_Codigo.Text = ""
                    btn_Agregar.Enabled = True

                    'acomodar que agarre el ultimo y le sume uno porque crea registros vacios si le doy cancelar
                    sql = "INSERT INTO marca_vehiculo (`mv_marca`, `mv_modelo`, `mv_estatus`) VALUES (' ', ' ', 'A')"
                    comando22(sql)

                    sentencia = "SELECT * FROM marca_vehiculo WHERE mv_marca = ' ' AND mv_modelo = ' ' and mv_estatus= 'A' "
                    CSelect(sentencia)

                    txt_Codigo.Text = sdr("mv_codigo")

                    txt_Codigo.Enabled = False
                    'asignar el ultimo codigo y bloquear txt
                End If
            Else
                txt_Marca.Text = sdr("mv_marca")
                txt_Modelo.Text = sdr("mv_modelo")
                Me.HBotones(True)
                Me.btn_Cancelar.Enabled = True
            End If
        End If


        ' If (txt_Codigo.Text = "") Then
        '        MsgBox("Debe escribir un codigo", vbInformation, "Error")
        'Return
        'End If
        '
        '   sql = "Select * from marca_vehiculo where mv_codigo= '" & txt_Codigo.Text & "' and mv_estatus = 'A' "
        '  CSelect(sql)
        '
        'If (sdr.IsClosed) Or Not (sdr.HasRows) Then
        'If MsgBox("El codigo no existe, ¿Desea agregarlo?", vbInformation, "Error") = vbNo Then
        '           btn_Cancelar.PerformClick()
        'Else


        'Else
        '           txt_Marca.Text = sdr("mv_marca")
        '      txt_Modelo.Text = sdr("mv_modelo")
        '     HBotones(True)
        '     btn_Cancelar.Enabled = True
        'End If

        '   cn.Close()

    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click

        If (btn_Modificar.Text = "Modificar") Then
            HCampos(True)
            btn_Eliminar.Enabled = False
            btn_Modificar.Text = "Guardar"
        Else
            If (Validar(True)) Then
                sql = "SELECT * from marca_vehiculo WHERE mv_codigo = '" + txt_Codigo.Text + "' and mv_estatus = 'A' "
                CSelect(sql)

                If ((txt_Marca.Text = sdr("mv_marca")) And (txt_Modelo.Text = sdr("mv_modelo"))) Then
                    MsgBox("No se realizaron cambios", vbInformation, "Sin cambios")
                    btn_Cancelar.PerformClick()
                    cn.Close()
                    Return
                Else
                    sql = "UPDATE marca_vehiculo SET mv_marca = '" + txt_Marca.Text + "', 
                                                     mv_modelo = '" + txt_Modelo.Text + "' 
                           where mv_codigo = '" + txt_Codigo.Text + "' "
                    comando22(sql)
                    MsgBox("Cambios realizados con exito", vbInformation, "Cambios")
                    btn_Cancelar.PerformClick()
                End If
            Else
                MsgBox("Debe llenar todos los campos", vbInformation, vbOK)

            End If

        End If
    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click

        If MsgBox("¿Esta seguro que desea eliminar?", vbYesNo, "Pregunta de seguridad") = MsgBoxResult.Yes Then
            sql = "UPDATE marca_vehiculo SET mv_estatus = 'I' WHERE mv_codigo = '" + txt_Codigo.Text + "' "
            comando22(sql)
            MsgBox("Eliminado correctamente", vbOK, "Eliminacion")
            btn_Cancelar.PerformClick()
        Else
            MsgBox("No se realizaron cambios", vbInformation, "Sin cambios en la eliminacion")
            btn_Cancelar.PerformClick()
        End If

    End Sub

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click

        If (Validar(True)) Then
            If MsgBox("¿Desea agregar la marca?", vbYesNo, "Registro") = MsgBoxResult.Yes Then

                sql = "UPDATE marca_vehiculo SET mv_marca = '" + txt_Marca.Text + "', mv_modelo = '" + txt_Modelo.Text + "' 
                      WHERE mv_codigo = '" & txt_Codigo.Text & "' "
                comando22(sql)
                MsgBox("Agregado exitosamente", vbInformation, "Incluir marca")
                btn_Cancelar.PerformClick()
                btn_Agregar.Enabled = False
            Else
                btn_Cancelar.PerformClick()
            End If
        Else
            MsgBox("Debe llenar todos los campos", vbInformation, vbOK)
            btn_Cancelar.PerformClick()

        End If
    End Sub


End Class








