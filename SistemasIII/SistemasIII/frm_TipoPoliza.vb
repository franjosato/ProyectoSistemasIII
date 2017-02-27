Public Class frm_TipoPoliza
    Private Sub HBotones(ByRef sn As Boolean)
        Me.btn_Agregar.Enabled = sn
        Me.btn_Buscar.Enabled = Not sn
        'Me.btn_Cancelar.Enabled = Not sn
        btn_Eliminar.Enabled = sn
        Me.btn_Modificar.Enabled = sn
        ' Me.btn_Volver.Enabled = Not sn
    End Sub
    Private Sub llenarnombrepoliza()
        'se llena el combobox de nombre de tipo_poliza
        sentencia1 = "select * from tipo_poliza"
        cmb_nombre_tp.DataSource = Datos(sentencia1)
        cmb_nombre_tp.DisplayMember = "tp_nombre_poliza"
        cmb_nombre_tp.ValueMember = "tp_codigo"
        cmb_nombre_tp.SelectedIndex = -1
    End Sub
    Private Sub llenarcoberturas()
        'se llena el checkedlistbox de cobertura
        sentencia = "select * from cobertura"
        CheckedListBox1.DataSource = Datos(sentencia)
        CheckedListBox1.DisplayMember = "c_nombre"
        CheckedListBox1.ValueMember = "c_codigo"
        CheckedListBox1.SelectedIndex = -1
    End Sub

    Private Sub frm_TipoPoliza_Load(sender As Object, e As EventArgs) Handles Me.Load

        'iniciar el reloj y la fehca
        tmr_Fecha.Start()
        btn_Cancelar.PerformClick()
        cmb_nombre_tp.Enabled = True

    End Sub

    Private Sub tmr_Fecha_Tick(sender As Object, e As EventArgs) Handles tmr_Fecha.Tick
        lbl_Fecha.Text = DateString
        lbl_Hora.Text = TimeOfDay
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        txt_Codigo.Focus()
        ActiveControl() = txt_Codigo
        Limpiar(Me)
        HCampos(Me, False, txt_Codigo)
        HBotones(False)
        btn_Modificar.Text = "Modificar"
        cmb_nombre_tp.Enabled=True
        cmb_nombre_tp.Visible = True
        txt_Nombre.Visible = False
        llenarcoberturas()
        llenarnombrepoliza()
        'acomodar validacion hcampos
        CheckedListBox1.Enabled = False
    End Sub

    Private Sub calcularmonto()
        Dim montobase As Double = 0
        Dim auxmonto As Double = 0

        For Each item As DataRowView In CheckedListBox1.CheckedItems

            For int As Integer = 0 To CheckedListBox1.Items.Count - 1
                If CheckedListBox1.GetItemChecked(int) = True Then
                    sentencia = "select * from cobertura where c_codigo='" & int + 1 & "'"
                    CSelect(sentencia)
                    ' MsgBox("hola")
                    auxmonto = sdr("c_costo")
                    montobase = 0
                    montobase += auxmonto
                    txt_monto_base.Text = montobase
                    cn.Close()
                End If
            Next
        Next

    End Sub

    Private Sub cmb_nombre_tp_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_nombre_tp.SelectionChangeCommitted
        If busquedacombo() Then
            For i As Integer = 0 To CheckedListBox1.Items.Count - 1
                If CheckedListBox1.GetItemChecked(i) = True Then
                    CheckedListBox1.SetItemChecked(i, False)
                End If
            Next
            busquedacoberturas()
            calcularmonto()
        End If

    End Sub

    Private Function busquedacombo() As Boolean
        sentencia = "select * from tipo_poliza where tp_codigo='" & cmb_nombre_tp.SelectedValue.ToString & "'"
        CSelect(sentencia)
        txt_Codigo.Text = sdr("tp_codigo")
        rtb_descripcion.Text = sdr("tp_descripcion")
        ' txt_monto_base.Text = sdr("tp_monto_base")
        cn.Close()
        Return True
    End Function

    Private Sub busquedacoberturas()

        sentencia1 = "select cp_c_codigo from cobertura_poliza where cp_tp_codigo='" & txt_Codigo.Text & "'"

        CSelect(sentencia1)
        ' MsgBox("busquedacobertura")

        While sdr.Read()

            ' Dim i As Integer = 0

            Dim index As Integer = sdr("cp_c_codigo")

            ' For i = 0 To sdr.FieldCount - 1

            For int As Integer = 0 To CheckedListBox1.Items.Count - 1

                    CheckedListBox1.SetItemChecked(index - 1, True)
                    'MsgBox("hola")

                Next

            'Next

        End While
        cn.Close()

    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        If txt_Codigo.Text.Length = 0 Then
            MsgBox("Debe llenar el campo de código", vbInformation, "Gestión de tipo de póliza")
            Return
        End If
        'se hace la busqueda en la BD
        sentencia = "select * from 
                    tipo_poliza 
                    where tp_codigo='" + txt_Codigo.Text + "'
                    and tp_estatus='A'"
        CSelect(sentencia)
        'se verifica que encontro alguna coincidencia
        If (sdr.IsClosed) Or Not (sdr.HasRows) Then
            If MsgBox("El tomador no existe ¿Desea agregarlo?", vbYesNo, "Gestión de Tomador") = MsgBoxResult.Yes Then
                sentencia1 = "select tp_codigo from
                            tipo_poliza"
                Buscarcodigo(txt_Codigo, sentencia1)
                HCampos(Me, True, txt_Codigo)
                HBotones(True)
                btn_Modificar.Enabled = False
                'acomodar validacion hcampos
                CheckedListBox1.Enabled = True
                btn_Buscar.Enabled = False
                cmb_nombre_tp.Visible = False
                cmb_nombre_tp.Text = "1"
                txt_Nombre.Visible = True
                txt_Nombre.Focus()

            End If
        Else

            txt_Codigo.Text = sdr("tp_codigo")
            cmb_nombre_tp.Text = sdr("tp_nombre_poliza")
            rtb_descripcion.Text = sdr("tp_descripcion")
            'txt_monto_base.Text = sdr("tp_monto_base")
            busquedacoberturas()
            calcularmonto()
            btn_Modificar.Enabled = True

        End If
        cn.Close()

    End Sub

    Private Sub cmb_nombre_tp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_nombre_tp.KeyPress
        ValidarNoescritura(e)
    End Sub

    Private Sub cmb_nombre_tp_GotFocus(sender As Object, e As EventArgs) Handles cmb_nombre_tp.GotFocus
        ' cmb_nombre_tp.DroppedDown = True
    End Sub

    Private Sub txt_Codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Codigo.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        If (validar_controles(Me)) Then

            sentencia = "insert into tipo_poliza (
                        `tp_nombre_poliza`,
                        `tp_descripcion`,
                        `tp_monto_base`,                 
                        `tp_estatus`)
                        values (
                        '" & txt_Nombre.Text & "',
                        '" & rtb_descripcion.Text & "',
                        '" & txt_monto_base.Text & "',                     
                        'A')"
            comando22(sentencia)
            For Each item As DataRowView In CheckedListBox1.CheckedItems

                For int As Integer = 0 To CheckedListBox1.Items.Count - 1
                    If CheckedListBox1.GetItemChecked(int) = True Then
                        sentencia1 = "insert into cobertura_poliza (
                        `cp_c_codigo`,
                        `cp_tp_codigo`,                                       
                        `cp_estatus`)
                        values (
                        '" & int + 1 & "',
                        '" & txt_Codigo.Text & "',                     
                        'A')"

                        comando22(sentencia1)
                    End If
                Next
            Next

            MsgBox("Tomador registrado con exito", vbInformation, "Gestion de tomador")
            Me.btn_Cancelar.PerformClick()
        Else
            MsgBox("Debe llenar todos los campos", vbInformation, vbOK)
        End If
    End Sub

    Private Sub CheckedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck
        calcularmonto()
    End Sub
    Private Sub compararcambioselecion()

    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        If (Me.btn_Modificar.Text = "Modificar") Then
            HCampos(Me, True, txt_Codigo)
            cmb_nombre_tp.Enabled = False
            txt_Nombre.Text = cmb_nombre_tp.Text
            cmb_nombre_tp.Visible = False
            CheckedListBox1.Enabled = True
            Me.btn_Modificar.Text = "Guardar"
        Else
            If (validar_controles(Me)) Then
                sentencia = "select * from 
                    tipo_poliza 
                    where tp_codigo='" + txt_Codigo.Text + "'
                    and tp_estatus='A'"
                CSelect(sentencia)


                If ((txt_Nombre.Text = sdr("tp_nombre_poliza")) And
                    (rtb_descripcion.Text = sdr("tp_descripcion")) And
                    (txt_monto_base.Text = sdr("tp_monto_base"))) Then
                    MsgBox("No se han realizado cambios", vbInformation, "Sin cambios")
                    Me.btn_Cancelar.PerformClick()
                    cn.Close()
                    Return
                Else
                    sentencia = "update tipo_poliza set
                                tp_nombre_poliza='" & txt_Nombre.Text & "',
                                tp_descricion='" & rtb_descripcion.Text & "' ,
                                tp_monto_base='" & txt_monto_base.Text & "',                              
                                where tp_codigo='" & txt_Codigo.Text & "' "
                    comando22(sentencia)

                    sentencia = "delete * from cobertura_poliza where cp_tp_codigo='" & txt_Codigo.Text & "'"
                    comando22(sentencia)
                    For Each item As DataRowView In CheckedListBox1.CheckedItems

                        For int As Integer = 0 To CheckedListBox1.Items.Count - 1
                            If CheckedListBox1.GetItemChecked(int) = True Then
                                sentencia1 = "insert into cobertura_poliza (
                        `cp_c_codigo`,
                        `cp_tp_codigo`,                                       
                        `cp_estatus`)
                        values (
                        '" & int + 1 & "',
                        '" & txt_Codigo.Text & "',                     
                        'A')"

                                comando22(sentencia1)
                            End If
                        Next
                    Next
                    MsgBox("Los cambios se han realizado con exito", vbInformation, "Gestion de tomador")
                    Me.btn_Cancelar.PerformClick()
                End If
            Else
                MsgBox("Debe llenar todos los campos", vbInformation, vbOK)
            End If

        End If

    End Sub
End Class