Public Class frm_Siniestro

    Private Sub frm_Siniestro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        HCampos(False)
        HBotones(False)
        LimpiarC()
        btn_Agregar.Enabled = False
        ActiveControl() = Me.cmb_NacionalidadT
        cmb_NacionalidadT.SelectedIndex() = -1

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
        cmb_NacionalidadT.Enabled = Not sn
        cmb_PlacaVeh.Enabled = Not sn
        cmb_Estado.Enabled = sn
        cmb_Ciudad.Enabled = sn
        rtb_Direccion.Enabled = sn
        dtp_FechaSin.Enabled = sn
        dtp_HoraSin.Enabled = sn
        rtb_descripcion.Enabled = sn
        txt_DocumentoTran.Enabled = sn
        ptb_ImagenCarro.Enabled = sn
        btn_CargarArch.Enabled = sn
        btn_CargarImagen.Enabled = sn

    End Sub

    Private Sub HBotones(ByRef sn As Boolean)

        btn_BuscarT.Enabled = Not sn
        btn_Agregar.Enabled = Not sn
        btn_Cancelar.Enabled = Not sn
        btn_Volver.Enabled = Not sn
        btn_Modificar.Enabled = sn

    End Sub

    Private Sub LimpiarC()

        cmb_NacionalidadT.Text = ""
        txt_Cedula.Text = ""
        cmb_PlacaVeh.Text = ""
        cmb_Estado.Text = ""
        cmb_Ciudad.Text = ""
        rtb_Direccion.Text = ""
        rtb_descripcion.Text = ""
        dtp_HoraSin.Value = Today
        'dtp_HoraSin.ResetText()
        dtp_HoraSin.Value = Today
        txt_DocumentoTran.Text = ""

    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Cancelar.Click

        HCampos(False)
        HBotones(False)
        LimpiarC()
        btn_Modificar.Text = "Modificar"
        ActiveControl() = Me.cmb_NacionalidadT

    End Sub

    Private Function Validar() As Boolean

        If (cmb_NacionalidadT.Text = "") Then Return False
        If (txt_Cedula.Text = "") Then Return False
        If (cmb_Estado.Text = "") Then Return False
        If (cmb_Ciudad.Text = "") Then Return False
        If (rtb_Direccion.Text = "") Then Return False
        If (dtp_FechaSin.Text = "") Then Return False
        If (dtp_HoraSin.Text = "") Then Return False
        If (rtb_descripcion.Text = "") Then Return False
        If (txt_DocumentoTran.Text = "") Then Return False
        Return True

    End Function

    Private Sub txt_CedulaT_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_Cedula.KeyPress

        ValidarNumero(e)
        If Asc(e.KeyChar) = 13 Then
            btn_BuscarT.PerformClick()
        End If

    End Sub

    Private Sub LlenarCmbPlacas()

        'Metodo para llenar el combo box de placas de vehiculos asociados al tomador ingresado
        sentencia = "Select po_v_placa from contrato where po_t_cedula='" & txt_Cedula.Text & "' and po_estatus='A'"
        cmb_PlacaVeh.DataSource = Datos(sentencia)
        cmb_PlacaVeh.DisplayMember = "placa"
        cmb_PlacaVeh.ValueMember = "po_v_placa"
        cmb_PlacaVeh.SelectedIndex = -1
        cn.Close()

    End Sub

    Sub txt_Cedula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Cedula.TextChanged

        'Llena el combobox de placas cuando encuentra la cedula del tomador
        LlenarCmbPlacas()
        If (txt_Cedula.Text = "") Then cmb_PlacaVeh.Text = ""

    End Sub

    Private Sub btn_BuscarT_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_BuscarT.Click

        'Busca si hay siniestros registrado que esten asociados a este tomador y vehiculo

        If (cmb_NacionalidadT.SelectedItem = "") Or (Me.txt_Cedula.Text = "") Then
            MsgBox("Debe llenar ambos campos", vbInformation, "Error")
            Return
        End If

        If (cmb_PlacaVeh.Text = "") Then
            MsgBox("Debe escoger la placa del vehículo", vbInformation, "Error")
            Return
        End If

        sentencia = "SELECT * FROM siniestro WHERE s_po_codigo =(SELECT po_codigo FROM contrato WHERE po_t_cedula = '" + txt_Cedula.Text + "' and po_v_placa='" + cmb_PlacaVeh.Text + "' and po_estatus='A')"
        CSelect(sentencia)


        If (sdr.IsClosed) Or Not (sdr.HasRows) Then

            If MsgBox("El vehículo no tiene siniestro asociado ¿Desea agregar uno?", vbYesNo,
                      "Siniestro no registrado") = MsgBoxResult.Yes Then
                HCampos(True)
                HBotones(False)
                btn_BuscarT.Enabled = False
                cmb_Estado.Focus()
            End If

        Else

            'cmb_Estado.Text= sdr("s_estado")
            'cmb_Ciudad.Text= sdr("s_ciudad")
            rtb_Direccion.Text = sdr("s_lugar")
            rtb_descripcion.Text = sdr("s_descripcion")
            dtp_FechaSin.Text = sdr("s_fecha")
            'dtp_HoraSin.Text = sdr("DATE_FORMAT(s_hora,'%H:%i:%s')")
            'date_format( fecha,  '%d-%m-%Y'  )
            'imagen
            'documento
            HBotones(True)
            btn_Cancelar.Enabled = True
        End If

        cn.Close()

    End Sub

    Private Sub btn_AgregarSin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Agregar.Click

        'Incluye un nuevo siniestro
        If (validar()) Then

            sentencia = "INSERT INTO siniestro (s_po_codigo,s_lugar,s_descripcion,s_fecha,s_estatus) VALUES((SELECT po_codigo from contrato where po_v_placa='" +
                cmb_PlacaVeh.Text + "' and po_t_cedula='" + txt_Cedula.Text + "' and po_estatus='A'),'" + rtb_Direccion.Text + "','" + rtb_descripcion.Text + "',str_to_date('" + dtp_FechaSin.Value + "', '%d/%m/%Y'),'A')"

            comando22(sentencia)
            MsgBox("Se ha registrado un nuevo siniestro", vbInformation, "Registro exitoso")
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
            If (validar()) Then
                sentencia = "SELECT * FROM siniestro WHERE s_po_codigo =(SELECT po_codigo FROM contrato WHERE po_t_cedula = '" +
                    txt_Cedula.Text + "' and po_v_placa='" + cmb_PlacaVeh.Text + "' and po_estatus='A')"

                CSelect(sentencia)

                If ((rtb_Direccion.Text = sdr("s_lugar")) And (rtb_descripcion.Text = sdr("s_descripcion")) And (dtp_FechaSin.Text = sdr("s_fecha"))) Then
                    MsgBox("No se han realizado cambios", vbInformation, "Sin cambios")
                    cn.Close()
                    Me.btn_Cancelar.PerformClick()
                    Return

                Else
                    sentencia = "update siniestro set s_lugar='" + rtb_Direccion.Text + "', s_descripcion='" + rtb_descripcion.Text +
                        "', s_fecha= str_to_date('" + dtp_FechaSin.Value + "', '%d/%m/%Y') WHERE s_po_codigo=(SELECT po_codigo FROM contrato WHERE po_t_cedula ='" + txt_Cedula.Text + "' and po_v_placa='" + cmb_PlacaVeh.Text + "')"
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

    Private Sub LoadNewPict()

        ptb_ImagenCarro.Image = Image.FromFile _
        (System.Environment.GetFolderPath _
        (System.Environment.SpecialFolder.Personal) _
        & "\Image.gif")

    End Sub

    Private Sub btn_CargarArch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CargarArch.Click

        Dim ofd_transito As New OpenFileDialog()
        ofd_transito.Filter = "Archvos txt|*.pdf"
        ofd_transito.Title = "Seleccione el documento"

        If ofd_transito.ShowDialog() = DialogResult.OK Then
            txt_DocumentoTran.Text = ofd_transito.FileName
        End If

    End Sub

    Private Sub btn_CargarImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CargarImagen.Click

        Dim ofd_transito As New OpenFileDialog()
        ofd_transito.Filter = "Archvos jpg|*.jpg"
        ofd_transito.Title = "Seleccione el documento"

        If ofd_transito.ShowDialog() = DialogResult.OK Then
            ' lbl_RutaImagen.Text = ofd_transito.FileName
            ptb_ImagenCarro.Image = Image.FromFile(ofd_transito.FileName)
        End If

    End Sub

    Private Sub txt_Documento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_DocumentoTran.TextChanged

    End Sub

    Private Sub lbl_RutaImagen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub rtb_Direccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtb_Direccion.TextChanged

    End Sub

    Private Sub rtb_descripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtb_descripcion.TextChanged

    End Sub

    Private Sub ptb_ImagenCarro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptb_ImagenCarro.Click

    End Sub

    Private Sub txt_CedulaTom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_GuardarSin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ofd_transito_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ofd_transito.FileOk

    End Sub

    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click

    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click

    End Sub

    Private Sub grb_Poliza_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grb_Poliza.Enter

    End Sub

    Private Sub cmb_PlacaVeh_SelectedChangeCommited(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PlacaVeh.SelectedValueChanged

    End Sub

    Private Sub cmb_Ciudad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Ciudad.SelectedIndexChanged

    End Sub

    Private Sub cmb_Estado_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Estado.SelectionChangeCommitted

        sentencia = "select distinct ciudades.* from ciudades,estados where ciudades.id_estado= " + Me.cmb_Estado.SelectedValue.ToString
        Me.cmb_Ciudad.DataSource = Datos(sentencia)
        Me.cmb_Ciudad.DisplayMember = "ciudad"
        Me.cmb_Ciudad.ValueMember = "id_ciudad"
        Me.cmb_Ciudad.SelectedIndex = -1
        Me.cmb_Ciudad.Focus()

    End Sub

    Private Sub cmb_NacionalidadT_KeyPress(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_NacionalidadT.KeyPress

        ValidarNoescritura(e)

    End Sub

    Private Sub cmb_PlacaVeh_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles cmb_PlacaVeh.KeyPress

        ValidarNoescritura(e)
        If Asc(e.KeyChar) = 13 Then
            Me.btn_BuscarT.PerformClick()
        End If

    End Sub

    Private Sub dtp_FechaSin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaSin.ValueChanged

    End Sub

    Private Sub cmb_NacionalidadT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_NacionalidadT.SelectedIndexChanged

    End Sub
End Class