Public Class frm_Pago
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grb_DatosPago.Enter

    End Sub

    Private Sub frm_Pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCampos()
        HBotones(True)
        HCampos(True)
        ActiveControl() = cmb_NacionalidadT
        cmb_CedulaT.Visible = False
        cmb_CedulaA.Visible = False
        cmb_Codigo.Visible = False
        txt_CedulaA.Visible = True
        txt_CedulaT.Visible = True
        txt_Codigo.Visible = True
    End Sub

    Private Sub HCampos(ByRef sn As Boolean)
        txt_CedulaA.Enabled = sn
        txt_CedulaT.Enabled = sn
        txt_Codigo.Enabled = sn
        cmb_NacionalidadA.Enabled = sn
        cmb_NacionalidadT.Enabled = sn
        cmb_Placa.Enabled = sn
        txt_NroCuotasPagar.Enabled = Not sn
        cmb_Formapago.Enabled = Not sn
        txt_Montoacancelar.Enabled = Not sn
    End Sub

    Private Sub HBotones(ByRef sn As Boolean)
        btn_Buscar.Enabled = sn
        'btn_Añadir.Enabled = Not sn
    End Sub

    Private Sub cargarCampos()
        'Cargar autocomplete de Asegurado
        sentencia = "Select a_cedula from asegurado where a_estatus='A' order by a_cedula"
        txt_CedulaA.AutoCompleteCustomSource = Autocompletar(sentencia, "a_cedula")
        txt_CedulaA.AutoCompleteMode = AutoCompleteMode.Suggest
        txt_CedulaA.AutoCompleteSource = AutoCompleteSource.CustomSource
        'Cargar autocomplete de tomadores
        sentencia = "Select t_cedula from tomador where t_estatus='A' order by t_cedula"
        txt_CedulaT.AutoCompleteCustomSource = Autocompletar(sentencia, "t_cedula")
        txt_CedulaT.AutoCompleteMode = AutoCompleteMode.Suggest
        txt_CedulaT.AutoCompleteSource = AutoCompleteSource.CustomSource
        'Cargar autocomplete de codigos de poliza
        sentencia = "Select po_codigo from poliza where po_estatus='A' order by po_codigo"
        txt_Codigo.AutoCompleteCustomSource = Autocompletar(sentencia, "po_codigo")
        txt_Codigo.AutoCompleteMode = AutoCompleteMode.Suggest
        txt_Codigo.AutoCompleteSource = AutoCompleteSource.CustomSource
        'Cargar combobox de placas
        sentencia = "Select v_placa from vehiculo where v_estatus='A' order by v_placa"
        cmb_Placa.DataSource = Datos(sentencia)
        cmb_Placa.DisplayMember = "Placa"
        cmb_Placa.ValueMember = "v_placa"
        cmb_Placa.SelectedIndex = -1
        'Cargar autocomplete de placas
        sentencia = "Select v_placa from vehiculo where v_estatus='A' order by v_placa"
        cmb_Placa.AutoCompleteCustomSource = Autocompletar(sentencia, "v_placa")
        cmb_Placa.AutoCompleteMode = AutoCompleteMode.Suggest
        cmb_Placa.AutoCompleteSource = AutoCompleteSource.CustomSource
        'Cargar combobox de formas de pago
        sentencia = "Select fp_nombre from forma_pago where fp_estatus='A' order by fp_nombre"
        cmb_Formapago.DataSource = Datos(sentencia)
        cmb_Formapago.DisplayMember = "Metodo de Pago"
        cmb_Formapago.ValueMember = "fp_nombre"
        cmb_Formapago.SelectedIndex = -1
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        If (validar()) Then
            If Not (txt_Codigo.Text = "") Or Not (cmb_Placa.Text = "") Or Not (cmb_Codigo.Text = "") Then

                Dim strg As String = ""

                If Not (cmb_Codigo.Text = "") Then
                    txt_Codigo.Text = cmb_Codigo.Text
                End If

                If Not (txt_Codigo.Text = "") Then
                    strg = "po.po_codigo='" + txt_Codigo.Text + "'"
                End If

                If Not (txt_Codigo.Text = "") And Not (cmb_Placa.Text = "") Then
                    strg = strg + " and "
                End If

                If Not (cmb_Placa.Text = "") Then
                    strg = strg + "po.po_v_placa='" + cmb_Placa.Text + "'"
                End If

                sentencia = "Select cu_codigo,a_primer_nombre,a_primer_apellido,t_primer_nombre,t_primer_apellido,cu_monto,mv_codigo,
                                v_mv_codigo, mv_modelo,pp_nrocuotas,po_v_placa,po_t_cedula ,po_a_cedula ,po_codigo,a_nacionalidad,t_nacionalidad, sum(cu_monto) as
                               total from poliza po inner join  plan_pago pp on po.po_pp_codigo=pp.pp_codigo inner join cuota cu on 
                                po.po_codigo=cu.cu_po_codigo inner join asegurado a on po.po_a_cedula=a.a_cedula inner join tomador 
                                t on po.po_t_cedula=t.t_cedula inner join vehiculo ve on po.po_v_placa=ve.v_placa inner join marca_vehiculo mv on ve.v_mv_codigo=mv.mv_codigo 
                                where " & strg & "and po.po_estatus='A'"
                polizaobtenida(sentencia, strg)

            ElseIf (Not (txt_CedulaT.Text.Equals("")) And Not (txt_CedulaA.Text.Equals(""))) Or (Not (cmb_CedulaA.Text.Equals("")) And Not (txt_CedulaT.Text.Equals(""))) Or (Not (cmb_CedulaT.Text.Equals("")) And Not (txt_CedulaA.Text.Equals(""))) Then

                If Not (cmb_CedulaA.Text = "") Then
                    txt_CedulaA.Text = cmb_CedulaA.Text
                    sentencia = "Select a_primer_nombre,a_primer_apellido from asegurado where a_cedula='" &
                    txt_CedulaA.Text & "' and a_estatus='A'"
                    CSelect(sentencia)
                    txt_NombreA.Text = sdr("a_primer_nombre") & " " & (sdr("a_primer_apellido"))
                End If

                If Not (cmb_CedulaT.Text = "") Then
                    txt_CedulaT.Text = cmb_CedulaT.Text
                    sentencia = "Select t_primer_nombre,t_primer_apellido from tomador where t_cedula='" &
                    txt_CedulaT.Text & "' and t_estatus='A'"
                    CSelect(sentencia)
                    txt_NombreT.Text = sdr("t_primer_nombre") & " " & (sdr("t_primer_apellido"))
                End If

                llenarcombo("CTA")
                llenarcombo("PTA")
                cmb_NacionalidadA.Enabled = False
                cmb_NacionalidadT.Enabled = False
                txt_CedulaA.Enabled = False
                txt_CedulaT.Enabled = False
                cmb_CedulaA.Enabled = False
                cmb_CedulaT.Enabled = False
                MsgBox("Seleccione otro campo", vbInformation, "Parametros de busqueda")

            ElseIf (Not (txt_CedulaA.Text = "")) Then
                sentencia = "Select a_primer_nombre,a_primer_apellido from asegurado where a_cedula='" &
                    txt_CedulaA.Text & "' and a_estatus='A'"
                txt_NombreA.Text = sdr("a_primer_nombre") & " " & (sdr("a_primer_apellido"))
                llenarcombo("TA")
                llenarcombo("PA")
                llenarcombo("CA")
                txt_CedulaA.Enabled = False
                cmb_NacionalidadA.Enabled = False
                MsgBox("Seleccione otro campo", vbInformation, "Parametros de busqueda")


            ElseIf (Not (txt_CedulaT.Text = "")) Then
                sentencia = "Select t_primer_nombre,t_primer_apellido from tomador where t_cedula='" &
                    txt_CedulaT.Text & "' and t_estatus='A'"
                txt_NombreT.Text = sdr("t_primer_nombre") & " " & (sdr("t_primer_apellido"))
                llenarcombo("AT")
                llenarcombo("PT")
                llenarcombo("CT")
                txt_CedulaT.Enabled = False
                cmb_NacionalidadT.Enabled = False
                MsgBox("Seleccione otro campo", vbInformation, "Parametros de busqueda")
            End If
            'vbOK


        End If
    End Sub

    Private Function validar() As Boolean


        Dim MsgError As String
        validar = True
        MsgError = ""

        'Validar ambos campos de tomador
        If (((cmb_NacionalidadT.Text = "") And Not (txt_CedulaT.Text.Equals(""))) Or (Not (cmb_NacionalidadT.Text = "") And (txt_CedulaT.Text.Equals("")))) And (cmb_CedulaT.Text.Equals("")) Then
            validar = False
            MsgError = MsgError + vbCrLf + " - Debe llenar ambos campos de Tomador."
        End If

        'Validar ambos campos de asegurado
        If (((cmb_NacionalidadA.Text = "") And Not (txt_CedulaA.Text.Equals(""))) Or (Not (cmb_NacionalidadA.Text = "") And (txt_CedulaA.Text.Equals("")))) And (cmb_CedulaA.Text.Equals("")) Then
            validar = False
            MsgError = MsgError + vbCrLf + " - Debe llenar ambos campos de Asegurado."
        End If

        'Validar  que asegurado exista
        If Not (txt_CedulaA.Text = "") And (cmb_CedulaT.Text = "") Then
            sentencia = "Select * from asegurado where a_cedula='" & txt_CedulaA.Text & "' and a_estatus='A'"
            CSelect(sentencia)
            If Not (sdr.HasRows) Then
                MsgError = MsgError + vbCrLf + " - Asegurado no existente."
                validar = False
            ElseIf ((cmb_CedulaT.Visible)) Then
                sentencia = "Select a_nacionalidad from asegurado where a_cedula='" & txt_CedulaA.Text & "' and a_estatus='A'"
                CSelect(sentencia)
                If Not (cmb_NacionalidadA.Text = sdr("a_nacionalidad")) Then
                    MsgError = MsgError + vbCrLf + " - Combinación de asegurado y nacionalidad no valida."
                    validar = False
                End If
            End If
        End If

        'Validar que tomador existe
        If Not (txt_CedulaT.Text = "") And (cmb_CedulaA.Text = "") Then
            sentencia = "Select * from tomador where t_cedula='" & txt_CedulaT.Text & "' and t_estatus='A'"
            CSelect(sentencia)
            If Not (sdr.HasRows) Then
                MsgError = MsgError + vbCrLf + " - Tomador no existente."
                validar = False
            ElseIf ((cmb_CedulaA.Visible)) Then
                sentencia = "Select t_nacionalidad from tomador where t_cedula='" & txt_CedulaT.Text & "' and t_estatus='A'"
                CSelect(sentencia)
                If Not (cmb_NacionalidadT.Text = sdr("t_nacionalidad")) Then
                    MsgError = MsgError + vbCrLf + " - Combinación de tomador y nacionalidad no valida."
                    validar = False
                End If
            End If
        End If

        'Validar que poliza existe
        If Not (txt_Codigo.Text = "") Then
            sentencia = "Select * from poliza where po_codigo='" & txt_Codigo.Text & "' and po_estatus='A'"
            CSelect(sentencia)
            If Not (sdr.HasRows) Then
                MsgError = MsgError + vbCrLf + " - Codigo no existente."
                validar = False
            End If
        End If

        'Validar que placa exista
        If Not (cmb_Placa.Text = "") Then
            sentencia = "Select * from vehiculo where v_placa='" & cmb_Placa.Text & "' and v_estatus='A'"
            CSelect(sentencia)
            If Not (sdr.HasRows) Then
                MsgError = MsgError + vbCrLf + " - Placa no existente."
                validar = False
            Else
                sentencia = "Select * from poliza where po_v_placa='" & cmb_Placa.Text & "' and po_estatus='A' "
                CSelect(sentencia)
                If Not (sdr.HasRows) Then
                    MsgError = MsgError + vbCrLf + " - Placa no asociada a poliza vigente."
                    validar = False
                End If
            End If
        End If


        If Not validar Then
            MsgBox("EEROR - Error en campo:" & vbCrLf & MsgError, vbOK, "Error en campo")
            MsgError = ""
        End If

    End Function

    Private Sub txt_CedulaA_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_CedulaA.KeyDown
        If (e.KeyCode.Equals(Keys.Enter)) Then
            btn_Buscar.PerformClick()
        End If
    End Sub

    Private Sub txt_CedulaT_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_CedulaT.KeyDown
        If (e.KeyCode.Equals(Keys.Enter)) Then
            btn_Buscar.PerformClick()
        End If
    End Sub

    Private Sub txt_Codigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Codigo.KeyDown
        If (e.KeyCode.Equals(Keys.Enter)) Then
            btn_Buscar.PerformClick()
        End If
    End Sub

    Private Sub cmb_Placa_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_Placa.KeyDown
        If (e.KeyCode.Equals(Keys.Enter)) Then
            btn_Buscar.PerformClick()
        End If
    End Sub

    Private Sub cmb_Placa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_Placa.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        HCampos(True)
        HBotones(True)
        LimpiarC()
        cmb_CedulaT.Visible = False
        cmb_CedulaA.Visible = False
        cmb_Codigo.Visible = False
        txt_CedulaA.Visible = True
        txt_CedulaT.Visible = True
        txt_Codigo.Visible = True
        dgv_Pagos.Rows.Clear()
    End Sub
    Private Sub LimpiarC()
        txt_Cambio.Text = ""
        txt_CedulaA.Text = ""
        txt_CedulaT.Text = ""
        txt_Codigo.Text = ""
        txt_CuotasPaga.Text = ""
        txt_Montoacancelar.Text = ""
        txt_MontoCuota.Text = ""
        txt_NroCuotas.Text = ""
        txt_NroCuotasPagar.Text = ""
        txt_Totalapagar.Text = ""
        cmb_Formapago.Text = ""
        cmb_NacionalidadA.Text = ""
        cmb_NacionalidadT.Text = ""
        cmb_Placa.Text = ""
        cmb_CedulaA.Text = ""
        cmb_CedulaT.Text = ""
        cmb_Codigo.Text = ""
        txt_ModeloV.Text = ""
        txt_NombreA.Text = ""
        txt_NombreT.Text = ""
        cmb_Formapago.SelectedIndex = -1
        cmb_NacionalidadA.SelectedIndex = -1
        cmb_NacionalidadT.SelectedIndex = -1
        cmb_Placa.SelectedIndex = -1
    End Sub

    Private Sub txt_NroCuotasPagar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_NroCuotasPagar.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_Montoacancelar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Montoacancelar.KeyPress
        ValidarNumero(e)
        If Asc(e.KeyChar) = 44 Then
            If (txt_Montoacancelar.Text.Contains(",")) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub txt_Codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Codigo.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_CedulaA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_CedulaA.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_CedulaT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_CedulaT.KeyPress
        ValidarNumero(e)
    End Sub
    Private Sub llenarcombo(ByRef orden As String)

        'Cargar combobox de asegurado dado tomador
        If (orden = "AT") Then
            sentencia = "Select po_a_cedula from poliza where po_t_cedula='" & txt_CedulaT.Text & "' and po_estatus='A' 
                            order by po_a_cedula"
            cmb_CedulaA.DataSource = Datos(sentencia)
            cmb_CedulaA.DisplayMember = "Cedula asegurado"
            cmb_CedulaA.ValueMember = "po_a_cedula"
            cmb_CedulaA.SelectedIndex = -1
            cmb_CedulaA.Visible = True
            txt_CedulaA.Visible = False
            txt_CedulaA.Text = ""
            cmb_NacionalidadA.Text = ""
            cmb_NacionalidadA.Enabled = False
        End If

        'Cargar combobox de placa dado tomador
        If (orden = "PT") Then
            sentencia = "Select po_v_placa from poliza where po_t_cedula='" & txt_CedulaT.Text & "' and po_estatus='A'
                        order by po_v_placa"
            cmb_Placa.DataSource = Datos(sentencia)
            cmb_Placa.DisplayMember = "Placa"
            cmb_Placa.ValueMember = "po_v_placa"
            cmb_Placa.SelectedIndex = -1
        End If

        'Cargar combobox de codigo dado tomador
        If (orden = "CT") Then
            sentencia = "Select po_codigo from poliza where po_t_cedula='" & txt_CedulaT.Text & "' and po_estatus='A'
                        order by po_codigo"
            cmb_Codigo.DataSource = Datos(sentencia)
            cmb_Codigo.DisplayMember = "Codigo"
            cmb_Codigo.ValueMember = "po_codigo"
            cmb_Codigo.SelectedIndex = -1
            cmb_Codigo.Visible = True
            txt_Codigo.Visible = False
            txt_Codigo.Text = ""
        End If

        'Cargar combobox de tomador dado asegurado
        If (orden = "TA") Then
            sentencia = "Select po_t_cedula from poliza where po_a_cedula='" & txt_CedulaA.Text & "' and po_estatus='A' 
                            order by po_t_cedula"
            cmb_CedulaT.DataSource = Datos(sentencia)
            cmb_CedulaT.DisplayMember = "Cedula tomador"
            cmb_CedulaT.ValueMember = "po_t_cedula"
            cmb_CedulaT.SelectedIndex = -1
            cmb_CedulaT.Visible = True
            txt_CedulaT.Visible = False
            txt_CedulaT.Text = ""
            cmb_NacionalidadT.Enabled = False
            cmb_NacionalidadT.Text = ""
        End If

        'Cargar combobox de placa dado asegurado
        If (orden = "PA") Then
            sentencia = "Select po_v_placa from poliza where po_a_cedula='" & txt_CedulaA.Text & "' and po_estatus='A'
                        order by po_v_placa"
            cmb_Placa.DataSource = Datos(sentencia)
            cmb_Placa.DisplayMember = "Placa"
            cmb_Placa.ValueMember = "po_v_placa"
            cmb_Placa.SelectedIndex = -1
        End If

        'Cargar combobox de codigo dado asegurado
        If (orden = "CA") Then
            sentencia = "Select po_codigo from poliza where po_a_cedula='" & txt_CedulaA.Text & "' and po_estatus='A'
                        order by po_codigo"
            cmb_Codigo.DataSource = Datos(sentencia)
            cmb_Codigo.DisplayMember = "Codigo"
            cmb_Codigo.ValueMember = "po_codigo"
            cmb_Codigo.SelectedIndex = -1
            cmb_Codigo.Visible = True
            txt_Codigo.Visible = False
        End If

        'Cargar combobox de placa dado tomador y asegurado
        If (orden = "PTA") Then
            sentencia = "Select po_v_placa from poliza where po_t_cedula='" & txt_CedulaT.Text & "' and po_a_cedula='" &
                txt_CedulaA.Text & "' and po_estatus='A' order by po_v_placa"
            cmb_Placa.DataSource = Datos(sentencia)
            cmb_Placa.DisplayMember = "Placa"
            cmb_Placa.ValueMember = "po_v_placa"
            cmb_Placa.SelectedIndex = -1
        End If

        'Cargar combobox de codigo dado tomador y asegurado
        If (orden = "CTA") Then
            sentencia = "Select po_codigo from poliza where po_t_cedula='" & txt_CedulaT.Text & "' and po_a_cedula='" &
                txt_CedulaA.Text & "' and po_estatus='A' order by po_codigo"
            cmb_Codigo.DataSource = Datos(sentencia)
            cmb_Codigo.DisplayMember = "Codigo"
            cmb_Codigo.ValueMember = "po_codigo"
            cmb_Codigo.SelectedIndex = -1
            cmb_Codigo.Visible = True
            txt_Codigo.Visible = False
        End If



    End Sub

    Private Sub polizaobtenida(ByRef sentencia As String, ByRef strg As String)
        CSelect(sentencia)
        cmb_CedulaA.Visible = False
        cmb_CedulaA.Visible = False
        cmb_Codigo.Visible = False
        txt_CedulaA.Visible = True
        txt_CedulaT.Visible = True
        txt_Codigo.Visible = True
        cmb_NacionalidadT.SelectedText() = sdr("t_nacionalidad")
        txt_CedulaT.Text = sdr("po_t_cedula")
        cmb_NacionalidadA.SelectedText() = sdr("a_nacionalidad")
        txt_CedulaA.Text = sdr("po_a_cedula")
        cmb_Placa.Text = sdr("po_v_placa")
        txt_Codigo.Text = sdr("po_codigo")
        txt_NroCuotas.Text = sdr("pp_nrocuotas")
        txt_MontoCuota.Text = sdr("cu_monto")
        txt_ModeloV.Text = sdr("mv_modelo")
        txt_NombreA.Text = sdr("a_primer_nombre") & " " & (sdr("a_primer_apellido"))
        txt_NombreT.Text = sdr("t_primer_nombre") & " " & (sdr("t_primer_apellido"))
        sentencia = "Select count(*) as pagas, cu_codigo from cuota cu inner join poliza po on cu.cu_po_codigo=po.po_codigo where " & strg & "and cu_estatus='A'"
        CSelect(sentencia)
        txt_CuotasPaga.Text = sdr("pagas")
        HCampos(False)
        HBotones(False)
        ActiveControl() = txt_NroCuotasPagar
        txt_Montoacancelar.Enabled = False
        cmb_Formapago.Enabled = False
    End Sub

    Private Sub txt_NroCuotasPagar_TextChanged(sender As Object, e As EventArgs) Handles txt_NroCuotasPagar.TextChanged
        If Not (txt_NroCuotasPagar.Text = "") Then
            cmb_Formapago.Enabled = True
            txt_Montoacancelar.Enabled = True
            txt_Totalapagar.Text = CInt(txt_NroCuotasPagar.Text) * CDbl(txt_MontoCuota.Text)
            FormatCurrency(txt_Totalapagar.Text, 2,,, TriState.True)
            txt_Faltante.Text = CInt(txt_NroCuotasPagar.Text) * CDbl(txt_MontoCuota.Text)
            FormatCurrency(txt_Faltante.Text, 2,,, TriState.True)
        Else
            cmb_Formapago.Enabled = False
            txt_Montoacancelar.Enabled = False
            txt_Totalapagar.Text = 0
            FormatCurrency(txt_Totalapagar.Text, 2)
            txt_Faltante.Text = 0
            FormatCurrency(txt_Faltante.Text, 2)
        End If

        Dim numero As Integer = 0
        Dim numero2 As Integer = 0
        Integer.TryParse(txt_CuotasPaga.Text, numero2)
        If numero2 = 0 Then
            numero = 0
        Else
            numero = Integer.Parse(txt_NroCuotas.Text) - Integer.Parse(txt_CuotasPaga.Text)
        End If

        Dim ctrl As TextBox = DirectCast(sender, TextBox)
        Integer.TryParse(ctrl.Text, numero2)
        If numero2 > numero Then
            ctrl.Text = numero
        End If


    End Sub

    Private Sub txt_Montoacancelar_TextChanged(sender As Object, e As EventArgs) Handles txt_Montoacancelar.TextChanged
        If (txt_Montoacancelar.Text = "0") Then
            btn_Añadir.Enabled = False
        ElseIf Not (txt_Montoacancelar.Text = "") Then
            btn_Añadir.Enabled = True
            'FormatCurrency(txt_Montoacancelar.Text, 2,,, TriState.True)
        Else
            txt_Montoacancelar.Text = 0
            'FormatCurrency(txt_Montoacancelar.Text, 2)
        End If
    End Sub

    Private Sub btn_Añadir_Click(sender As Object, e As EventArgs) Handles btn_Añadir.Click
        If (validarpago()) Then
            If (MsgBox("¿Seguro desea añadir pago", vbYesNo, "Confirmación de pago")) = vbYes Then
                txt_NroCuotasPagar.Enabled = False
                Dim resta As Double
                Dim filas As Integer
                resta = CDbl(txt_Faltante.Text) - CDbl(txt_Montoacancelar.Text)
                If (CDbl(txt_Montoacancelar.Text) >= CDbl(txt_Faltante.Text)) Then
                    txt_Cambio.Text = Math.Abs(resta)
                    txt_Montoacancelar.Enabled = False
                    cmb_Formapago.Enabled = False
                    btn_Procesarpago.Enabled = True
                    resta = 0
                    ActiveControl() = btn_Procesarpago
                End If
                txt_Faltante.Text = resta
                dgv_Pagos.Rows.Add(cmb_Formapago.Text, txt_Montoacancelar.Text, resta)
                txt_Montoacancelar.Text = ""
                cmb_Formapago.SelectedIndex = -1
                'dgv_Pagos.Rows.Add(cmb_Formapago.Text, txt_Montoacancelar.Text, resta)
                ActiveControl() = cmb_Formapago
            End If

        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lbl_Faltante.Click

    End Sub

    Private Sub txt_Totalapagar_TextChanged(sender As Object, e As EventArgs) Handles txt_Totalapagar.TextChanged

    End Sub

    Private Sub txt_Montoacancelar_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Montoacancelar.KeyDown
        If (e.KeyCode.Equals(Keys.Enter)) And (btn_Añadir.Enabled) Then
            btn_Añadir.PerformClick()
        End If
    End Sub

    Private Sub dgv_Pagos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Pagos.CellContentClick

    End Sub

    Private Sub dgv_Pagos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_Pagos.CellFormatting
        'dgv_Pagos.Columns("Monto_Cancelado").DefaultCellStyle.Format = "C2"
        'dgv_Pagos.Columns("Monto_Faltante").DefaultCellStyle.Format = "C2"

    End Sub

    Private Function validarpago() As Boolean

        validarpago = True
        'validar que se seleccione metodo de pago
        If (cmb_Formapago.SelectedIndex = -1) Then
            MsgBox("EEROR - Error en campo:" & vbCrLf & " - Seleccione un método de pago.", vbInformation, "Error en campo")
            validarpago = False
        End If
    End Function

    Private Sub btn_Procesarpago_Click(sender As Object, e As EventArgs) Handles btn_Procesarpago.Click
        If (MsgBox("¿Desaa procesar el pago?", vbYesNo, "Pago")) = vbYes Then

        End If
    End Sub
End Class