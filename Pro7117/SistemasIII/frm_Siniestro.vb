Public Class frm_Siniestro

    Private Sub txt_CodigoSiniestro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lbl_CedulaTomador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub lbl_LugarSiniestro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_LugarSiniestro.Click

    End Sub

    Private Sub frm_Siniestro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_UsuarioActual.Text = StrConv(NombreUsuario, vbProperCase)
        lbl_CargoActual.Text = TipoUsuario
        tmr_HoraSiniestro.Start()
        dtp_HoraSin.Value = Today
    End Sub

    Private Sub grb_DatosOtros_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grb_DatosOtros.Enter

    End Sub

    Private Sub btn_BuscarCedTom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarCedTom.Click
        txt_LugarSiniestro.Enabled = True
        dtp_HoraSin.Enabled = True
        dtp_FechaSin.Enabled = True
        txt_DescripcionSin.Enabled = True
        dtp_CitaPerito.Enabled = True
        txt_DocumentoTran.Enabled = True
        btn_CargarArch.Enabled = True
        btn_CargarImagen.Enabled = True
        cmb_PlacaVeh.Enabled = True

    End Sub

    Private Sub tmr_HoraSiniestro_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_HoraSiniestro.Tick
        lbl_HorafSiniestro.Text = DateTime.Now.ToShortTimeString()
    End Sub
    Private Sub LoadNewPict()
        ptb_ImagenCarro.Image = Image.FromFile _
        (System.Environment.GetFolderPath _
        (System.Environment.SpecialFolder.Personal) _
        & "\Image.gif")
    End Sub

    Private Sub ptb_ImagenCarro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptb_ImagenCarro.Click

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
            lbl_RutaImagen.Text = ofd_transito.FileName
            ptb_ImagenCarro.Image = Image.FromFile(ofd_transito.FileName)
        End If

    End Sub

    Private Sub txt_Documento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_DocumentoTran.TextChanged

    End Sub

    Private Sub dtp_FechaSin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaSin.ValueChanged

    End Sub

    Private Sub grb_DatosSiniestro_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grb_DatosSiniestro.Enter

    End Sub

    Private Sub lbl_RutaImagen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_RutaImagen.TextChanged

    End Sub

    Private Sub dtp_CitaPerito_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_CitaPerito.ValueChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_HoraSin.ValueChanged
        dtp_HoraSin.Format = DateTimePickerFormat.Time
        dtp_HoraSin.ShowUpDown = True
        dtp_HoraSin.CustomFormat = "hh:mm tt"
    End Sub

    Private Sub txt_CedulaTom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CedulaTom.TextChanged
       
    End Sub

    Private Sub btn_GuardarSin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GuardarSin.Click
        cmb_RazonSocial.Text = ""
        txt_CedulaTom.Text = ""
        txt_CodPoliza.Text = ""
        cmb_PlacaVeh.Text = ""
        cmb_PlacaVeh.Enabled = False
        txt_LugarSiniestro.Text = ""
        txt_LugarSiniestro.Enabled = False
        dtp_FechaSin.Text = Today
        dtp_FechaSin.Enabled = False
        dtp_HoraSin.Text = Today
        dtp_HoraSin.Enabled = False
        txt_DescripcionSin.Enabled = False
        txt_DescripcionSin.Text = ""
        dtp_CitaPerito.Text = Today
        dtp_CitaPerito.Enabled = False
        txt_DocumentoTran.Text = ""
        txt_DocumentoTran.Enabled = False
        btn_CargarArch.Enabled = False
        btn_CargarImagen.Enabled = False
        ptb_ImagenCarro.Image = Nothing
    End Sub
End Class