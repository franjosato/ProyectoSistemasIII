Public Class frm_Pago
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frm_Pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCampos()
        HBotones(True)
        HCampos(True)
        Me.ActiveControl() = Me.cmb_NacionalidadT
        Me.cmb_CedulaT.Visible = False
        Me.cmb_CedulaA.Visible = False
        Me.cmb_Codigo.Visible = False
        Me.txt_CedulaA.Visible = True
        Me.txt_CedulaT.Visible = True
        Me.txt_Codigo.Visible = True
    End Sub

    Private Sub HCampos(ByRef sn As Boolean)
        Me.txt_CedulaA.Enabled = sn
        Me.txt_CedulaT.Enabled = sn
        Me.txt_Codigo.Enabled = sn
        Me.cmb_NacionalidadA.Enabled = sn
        Me.cmb_NacionalidadT.Enabled = sn
        Me.cmb_Placa.Enabled = sn
        Me.txt_NroCuotasPagar.Enabled = Not sn
        Me.cmb_Formapago.Enabled = Not sn
        Me.txt_Montoacancelar.Enabled = Not sn
    End Sub

    Private Sub HBotones(ByRef sn As Boolean)
        Me.btn_Buscar.Enabled = sn
        Me.btn_Añadir.Enabled = Not sn
    End Sub

    Private Sub cargarCampos()
        'Cargar autocomplete de Asegurado
        sentencia = "Select a_cedula from asegurado where a_estatus='A' order by a_cedula"
        Me.txt_CedulaA.AutoCompleteCustomSource = Autocompletar(sentencia, "a_cedula")
        Me.txt_CedulaA.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txt_CedulaA.AutoCompleteSource = AutoCompleteSource.CustomSource
        'Cargar autocomplete de tomadores
        sentencia = "Select t_cedula from tomador where t_estatus='A' order by t_cedula"
        Me.txt_CedulaT.AutoCompleteCustomSource = Autocompletar(sentencia, "t_cedula")
        Me.txt_CedulaT.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txt_CedulaT.AutoCompleteSource = AutoCompleteSource.CustomSource
        'Cargar autocomplete de codigos de poliza
        sentencia = "Select po_codigo from poliza where po_estatus='A' order by po_codigo"
        Me.txt_Codigo.AutoCompleteCustomSource = Autocompletar(sentencia, "po_codigo")
        Me.txt_Codigo.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txt_Codigo.AutoCompleteSource = AutoCompleteSource.CustomSource
        'Cargar combobox de placas
        sentencia = "Select v_placa from vehiculo where v_estatus='A' order by v_placa"
        Me.cmb_Placa.DataSource = Datos(sentencia)
        Me.cmb_Placa.DisplayMember = "Placa"
        Me.cmb_Placa.ValueMember = "v_placa"
        Me.cmb_Placa.SelectedIndex = -1
        'Cargar autocomplete de placas
        sentencia = "Select v_placa from vehiculo where v_estatus='A' order by v_placa"
        Me.cmb_Placa.AutoCompleteCustomSource = Autocompletar(sentencia, "v_placa")
        Me.cmb_Placa.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.cmb_Placa.AutoCompleteSource = AutoCompleteSource.CustomSource
        'Cargar combobox de formas de pago
        sentencia = "Select fp_nombre from forma_pago where fp_estatus='A' order by fp_nombre"
        Me.cmb_Formapago.DataSource = Datos(sentencia)
        Me.cmb_Formapago.DisplayMember = "Metodo de Pago"
        Me.cmb_Formapago.ValueMember = "fp_nombre"
        Me.cmb_Formapago.SelectedIndex = -1
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        If (validar()) Then
            If Not (Me.txt_Codigo.Text = "") Or Not (Me.cmb_Placa.Text = "") Or Not (Me.cmb_Codigo.Text = "") Then

                Dim strg As String = ""

                If Not (Me.cmb_Codigo.Text = "") Then
                    Me.txt_Codigo.Text = Me.cmb_Codigo.Text
                End If

                If Not (Me.txt_Codigo.Text = "") Then
                    strg = "po.po_codigo='" + Me.txt_Codigo.Text + "'"
                End If

                If Not (Me.txt_Codigo.Text = "") And Not (Me.cmb_Placa.Text = "") Then
                    strg = strg + " and "
                End If

                If Not (Me.cmb_Placa.Text = "") Then
                    strg = strg + "po.po_v_placa='" + Me.cmb_Placa.Text + "'"
                End If

                sentencia = "Select cu_codigo,cu_monto ,pp_nrocuotas,po_v_placa,po_t_cedula ,po_a_cedula ,po_codigo,a_nacionalidad,t_nacionalidad, sum(cu_monto) as
                               total from poliza po inner join  plan_pago pp on po.po_pp_codigo=pp.pp_codigo inner join cuota cu on 
                                po.po_codigo=cu.cu_po_codigo inner join asegurado a on po.po_a_cedula=a.a_cedula inner join tomador 
                                t on po.po_t_cedula=t.t_cedula where " & strg & "and po.po_estatus='A'"
                polizaobtenida(sentencia, strg)

            ElseIf Not (Me.txt_CedulaT.Text = "") Then




            End If


        End If
    End Sub

    Private Function validar() As Boolean


        Dim MsgError As String
        validar = True
        MsgError = ""

        'Validar ambos campos de tomador
        If ((Me.cmb_NacionalidadT.Text = "") And Not (Me.txt_CedulaT.Text.Equals(""))) Or (Not (Me.cmb_NacionalidadT.Text = "") And (Me.txt_CedulaT.Text.Equals(""))) Then
            validar = False
            MsgError = MsgError + vbCrLf + " - Debe llenar ambos campos de Tomador."
        End If

        'Validar ambos campos de asegurado
        If ((Me.cmb_NacionalidadA.Text = "") And Not (Me.txt_CedulaA.Text.Equals(""))) Or (Not (Me.cmb_NacionalidadA.Text = "") And (Me.txt_CedulaA.Text.Equals(""))) Then
            validar = False
            MsgError = MsgError + vbCrLf + " - Debe llenar ambos campos de Asegurado."
        End If

        'Validar  que asegurado exista
        If Not (Me.txt_CedulaA.Text = "") Then
            sentencia = "Select * from asegurado where a_cedula='" & Me.txt_CedulaA.Text & "' and a_estatus='A'"
            CSelect(sentencia)
            If Not (sdr.HasRows) Then
                MsgError = MsgError + vbCrLf + " - Asegurado no existente."
                validar = False
            Else
                sentencia = "Select a_nacionalidad from asegurado where a_cedula='" & Me.txt_CedulaA.Text & "' and a_estatus='A'"
                CSelect(sentencia)
                If Not (Me.cmb_NacionalidadA.Text = sdr("a_nacionalidad")) Then
                    MsgError = MsgError + vbCrLf + " - Combinación de asegurado y nacionalidad no valida."
                    validar = False
                End If
            End If
        End If

        'Validar que tomador existe
        If Not (Me.txt_CedulaT.Text = "") Then
            sentencia = "Select * from tomador where t_cedula='" & Me.txt_CedulaT.Text & "' and t_estatus='A'"
            CSelect(sentencia)
            If Not (sdr.HasRows) Then
                MsgError = MsgError + vbCrLf + " - Tomador no existente."
                validar = False
            Else
                sentencia = "Select t_nacionalidad from tomador where t_cedula='" & Me.txt_CedulaT.Text & "' and t_estatus='A'"
                CSelect(sentencia)
                If Not (Me.cmb_NacionalidadT.Text = sdr("T_nacionalidad")) Then
                    MsgError = MsgError + vbCrLf + " - Combinación de tomador y nacionalidad no valida."
                    validar = False
                End If
            End If
        End If

        'Validar que poliza existe
        If Not (Me.txt_Codigo.Text = "") Then
            sentencia = "Select * from poliza where po_codigo='" & Me.txt_Codigo.Text & "' and po_estatus='A'"
            CSelect(sentencia)
            If Not (sdr.HasRows) Then
                MsgError = MsgError + vbCrLf + " - Codigo no existente."
                validar = False
            End If
        End If

        'Validar que placa exista
        If Not (Me.cmb_Placa.Text = "") Then
            sentencia = "Select * from vehiculo where v_placa='" & Me.cmb_Placa.Text & "' and v_estatus='A'"
            CSelect(sentencia)
            If Not (sdr.HasRows) Then
                MsgError = MsgError + vbCrLf + " - Placa no existente."
                validar = False
            End If
        End If


        If Not validar Then
            MsgBox("EEROR - Error en campo:" & vbCrLf & MsgError, vbOK, "Error en campo")
            MsgError = ""
        End If

    End Function

    Private Sub txt_CedulaA_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_CedulaA.KeyDown
        If (e.KeyCode.Equals(Keys.Enter)) Then
            Me.btn_Buscar.PerformClick()
        End If
    End Sub

    Private Sub txt_CedulaT_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_CedulaT.KeyDown
        If (e.KeyCode.Equals(Keys.Enter)) Then
            Me.btn_Buscar.PerformClick()
        End If
    End Sub

    Private Sub txt_Codigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Codigo.KeyDown
        If (e.KeyCode.Equals(Keys.Enter)) Then
            Me.btn_Buscar.PerformClick()
        End If
    End Sub

    Private Sub cmb_Placa_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_Placa.KeyDown
        If (e.KeyCode.Equals(Keys.Enter)) Then
            Me.btn_Buscar.PerformClick()
        End If
    End Sub

    Private Sub cmb_Placa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_Placa.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        HCampos(True)
        HBotones(True)
        LimpiarC()
        Me.cmb_CedulaT.Visible = False
        Me.cmb_CedulaA.Visible = False
        Me.cmb_Codigo.Visible = False
        Me.txt_CedulaA.Visible = True
        Me.txt_CedulaT.Visible = True
        Me.txt_Codigo.Visible = True
    End Sub
    Private Sub LimpiarC()
        Me.txt_Cambio.Text = ""
        Me.txt_CedulaA.Text = ""
        Me.txt_CedulaT.Text = ""
        Me.txt_Codigo.Text = ""
        Me.txt_CuotasPaga.Text = ""
        Me.txt_Montoacancelar.Text = ""
        Me.txt_MontoCuota.Text = ""
        Me.txt_NroCuotas.Text = ""
        Me.txt_NroCuotasPagar.Text = ""
        Me.txt_Totalapagar.Text = ""
        Me.cmb_Formapago.Text = ""
        Me.cmb_NacionalidadA.Text = ""
        Me.cmb_NacionalidadT.Text = ""
        Me.cmb_Placa.Text = ""
        Me.cmb_Formapago.SelectedIndex = -1
        Me.cmb_NacionalidadA.SelectedIndex = -1
        Me.cmb_NacionalidadT.SelectedIndex = -1
        Me.cmb_Placa.SelectedIndex = -1
    End Sub

    Private Sub txt_NroCuotasPagar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_NroCuotasPagar.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_Montoacancelar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Montoacancelar.KeyPress
        ValidarNumero(e)
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
            sentencia = "Select po_a_cedula from poliza where po_t_cedula='" & Me.txt_CedulaT.Text & "' where po_estatus='A' 
                            order by po_a_cedula"
            Me.cmb_CedulaA.DataSource = Datos(sentencia)
            Me.cmb_CedulaA.DisplayMember = "Cedula asegurado"
            Me.cmb_CedulaA.ValueMember = "po_a_cedula"
            Me.cmb_CedulaA.SelectedIndex = -1
            Me.cmb_CedulaA.Visible = True
            Me.txt_CedulaA.Visible = False
            Me.txt_CedulaA.Text = ""
            Me.cmb_NacionalidadA.Text = ""
            Me.cmb_NacionalidadA.Enabled = False
        End If

        'Cargar combobox de placa dado tomador
        If (orden = "PT") Then
            sentencia = "Select po_v_placa from poliza where po_t_cedula='" & Me.txt_CedulaT.Text & "' where po_estatus='A'
                        order by po_v_placa"
            Me.cmb_Placa.DataSource = Datos(sentencia)
            Me.cmb_Placa.DisplayMember = "Placa"
            Me.cmb_Placa.ValueMember = "po_v_placa"
            Me.cmb_Placa.SelectedIndex = -1
        End If

        'Cargar combobox de codigo dado tomador
        If (orden = "CT") Then
            sentencia = "Select po_codigo from poliza where po_t_cedula='" & Me.txt_CedulaT.Text & "' where po_estatus='A'
                        order by po_codigo"
            Me.cmb_Codigo.DataSource = Datos(sentencia)
            Me.cmb_Codigo.DisplayMember = "Codigo"
            Me.cmb_Codigo.ValueMember = "po_codigo"
            Me.cmb_Codigo.SelectedIndex = -1
            Me.cmb_Codigo.Visible = True
            Me.txt_Codigo.Visible = False
            Me.txt_Codigo.Text = ""
        End If

        'Cargar combobox de tomador dado asegurado
        If (orden = "TA") Then
            sentencia = "Select po_t_cedula from poliza where po_a_cedula='" & Me.txt_CedulaA.Text & "' where po_estatus='A' 
                            order by po_t_cedula"
            Me.cmb_CedulaT.DataSource = Datos(sentencia)
            Me.cmb_CedulaT.DisplayMember = "Cedula tomador"
            Me.cmb_CedulaT.ValueMember = "po_t_cedula"
            Me.cmb_CedulaT.SelectedIndex = -1
            Me.cmb_CedulaT.Visible = True
            Me.txt_CedulaT.Visible = False
            Me.txt_CedulaT.Text = ""
            Me.cmb_NacionalidadT.Enabled = False
            Me.cmb_NacionalidadT.Text = ""
        End If

        'Cargar combobox de placa dado asegurado
        If (orden = "PA") Then
            sentencia = "Select po_v_placa from poliza where po_a_cedula='" & Me.txt_CedulaA.Text & "' where po_estatus='A'
                        order by po_v_placa"
            Me.cmb_Placa.DataSource = Datos(sentencia)
            Me.cmb_Placa.DisplayMember = "Placa"
            Me.cmb_Placa.ValueMember = "po_v_placa"
            Me.cmb_Placa.SelectedIndex = -1
        End If

        'Cargar combobox de codigo dado asegurado
        If (orden = "CA") Then
            sentencia = "Select po_codigo from poliza where po_a_cedula='" & Me.txt_CedulaA.Text & "' where po_estatus='A'
                        order by po_codigo"
            Me.cmb_Codigo.DataSource = Datos(sentencia)
            Me.cmb_Codigo.DisplayMember = "Codigo"
            Me.cmb_Codigo.ValueMember = "po_codigo"
            Me.cmb_Codigo.SelectedIndex = -1
            Me.cmb_Codigo.Visible = True
            Me.txt_Codigo.Visible = False
        End If

        'Cargar combobox de placa dado tomador y asegurado
        If (orden = "PTA") Then
            sentencia = "Select po_v_placa from poliza where po_t_cedula='" & Me.txt_CedulaT.Text & " and po_a_cedula='" &
                Me.txt_CedulaA.Text & "' where po_estatus='A' order by po_v_placa"
            Me.cmb_Placa.DataSource = Datos(sentencia)
            Me.cmb_Placa.DisplayMember = "Placa"
            Me.cmb_Placa.ValueMember = "po_v_placa"
            Me.cmb_Placa.SelectedIndex = -1
        End If



    End Sub

    Private Sub polizaobtenida(ByRef sentencia As String, ByRef strg As String)
        CSelect(sentencia)
        Me.cmb_NacionalidadT.SelectedText() = sdr("t_nacionalidad")
        Me.txt_CedulaT.Text = sdr("po_t_cedula")
        Me.cmb_NacionalidadA.SelectedText() = sdr("a_nacionalidad")
        Me.txt_CedulaA.Text = sdr("po_a_cedula")
        Me.cmb_Placa.SelectedText() = sdr("po_v_placa")
        Me.txt_Codigo.Text = sdr("po_codigo")
        Me.txt_NroCuotas.Text = sdr("pp_nrocuotas")
        Me.txt_MontoCuota.Text = sdr("cu_monto")
        sentencia = "Select count(*) as pagas, cu_codigo from cuota cu inner join poliza po on cu.cu_po_codigo=po.po_codigo where " & strg & "and cu_estatus='A'"
        CSelect(sentencia)
        Me.txt_CuotasPaga.Text = sdr("pagas")
        HCampos(False)
        HBotones(False)
        Me.ActiveControl() = Me.txt_NroCuotasPagar
    End Sub



End Class