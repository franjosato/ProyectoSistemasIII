Public Class frm_Contrato_Poliza
    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Limpiar(Me)
        todotomador()
        todosplacas()
        todosasegurados()
        todocontratos()
    End Sub

    Private Sub btn_Volver_Click(sender As Object, e As EventArgs) Handles btn_Volver.Click
        Limpiar(Me)
    End Sub

    Private Sub txt_CedulaA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_CedulaA.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_CedulaT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_CedulaT.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_Codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Codigo.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_Marca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Marca.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_MontoBase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_MontoBase.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_MontoCuota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_MontoCuota.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_MontoPagar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_MontoPagar.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_NCuotas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_NCuotas.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_PApellidoA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PApellidoA.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_PApellidoT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PApellidoT.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_PNombreA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PNombreA.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_PNombreT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PNombreT.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_SApellidoA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SApellidoA.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_SApellidoT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SApellidoT.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_SNombreA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SNombreA.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_SNombreT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SNombreT.KeyPress
        Validarletras(e)
    End Sub

    Private Sub frm_Contrato_Poliza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_Cancelar.PerformClick()
        list_planpago()
        list_tipo_poliza()
        llenarcampos()
    End Sub
    '
    'llenar los listbox
    '
    'listbox plan de pago
    Private Sub list_planpago()
        sentencia = "select * from plan_pago where pp_estatus='A'"
        ltb_PlanPago.DataSource = Datos(sentencia)
        ltb_PlanPago.DisplayMember = "pp_nombre"
        ltb_PlanPago.ValueMember = "pp_codigo"
        ltb_PlanPago.SelectedIndex = -1
    End Sub
    Private Sub list_tipo_poliza()
        sentencia = "select * from tipo_poliza where tp_estatus='A'"
        ltb_TipoPoliza.DataSource = Datos(sentencia)
        ltb_TipoPoliza.DisplayMember = "tp_nombre_poliza"
        ltb_TipoPoliza.ValueMember = "tp_codigo"
        ltb_TipoPoliza.SelectedIndex = -1
    End Sub
    Private Sub list_cobertura(ByRef tipo_poliza As Integer)
        sentencia = "select distinct concat( cobertura.c_nombre,' costo: ',cobertura.c_costo) as nombre, 
                    cobertura.c_codigo
                    from cobertura 
                    inner join cobertura_poliza on cobertura.c_codigo=cobertura_poliza.cp_c_codigo
                    where cobertura_poliza.cp_tp_codigo='" & tipo_poliza & "'"
        ltb_cobertura.DataSource = Datos(sentencia)
        ltb_cobertura.DisplayMember = "nombre"
        ltb_cobertura.ValueMember = "c_codigo"


    End Sub
    'carga el tomador dependiendo de las placas
    Private Sub tomadorXplaca()
        sentencia = "select distinct * from poliza where po_estatus='A' and po_v_placa='" & cmb_Placa.SelectedValue.ToString & "'"
        cmb_CedulaT.DataSource = Datos(sentencia)
        cmb_CedulaT.DisplayMember = "po_t_cedula"
        cmb_CedulaT.ValueMember = "po_t_cedula"
        'cmb_CedulaT.SelectedIndex = -1
    End Sub
    'carga el asegurado dependiendo de la placas
    Private Sub aseguradoXplaca()
        sentencia = "select distinct * from poliza where po_estatus='A' and po_v_placa='" & cmb_Placa.SelectedValue.ToString & "'"
        cmb_CedulaA.DataSource = Datos(sentencia)
        cmb_CedulaA.DisplayMember = "po_a_cedula"
        cmb_CedulaA.ValueMember = "po_a_cedula"
        'cmb_CedulaA.SelectedIndex = -1
    End Sub
    'carga los contratos dependiendo de las placas
    Private Sub contratoXplaca()
        sentencia = "select po_codigo from poliza where po_estatus='A' and po_v_placa='" & cmb_Placa.SelectedValue.ToString & "'"
        cmb_CodigoContrato.DataSource = Datos(sentencia1)

        cmb_CodigoContrato.DisplayMember = "po_codigo"
        cmb_CodigoContrato.ValueMember = "po_codigo"
        ' cmb_CodigoContrato.SelectedIndex = -1
    End Sub
    'llena todos los combos con todos los datos de cada tabla
    Private Sub llenarcampos()

        'Cargar autocomplete de placas
        sentencia = "Select v_placa from vehiculo where v_estatus='A' order by v_placa"
        cmb_Placa.AutoCompleteCustomSource = Autocompletar(sentencia, "v_placa")
        cmb_Placa.AutoCompleteMode = AutoCompleteMode.Suggest
        cmb_Placa.AutoCompleteSource = AutoCompleteSource.CustomSource
        'Cargar combobox de cedula de tomador

        'Cargar autocomplete de cedula de tomador
        sentencia = "Select t_cedula from tomador where t_estatus='A' order by t_cedula"
        cmb_CedulaT.AutoCompleteCustomSource = Autocompletar(sentencia, "t_cedula")
        cmb_CedulaT.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmb_CedulaT.AutoCompleteSource = AutoCompleteSource.CustomSource

        'Cargar autocomplete de cedula de asegurado
        sentencia = "Select a_cedula from asegurado where a_estatus='A' order by a_cedula"
        cmb_CedulaA.AutoCompleteCustomSource = Autocompletar(sentencia, "a_cedula")
        cmb_CedulaA.AutoCompleteMode = AutoCompleteMode.Suggest
        cmb_CedulaA.AutoCompleteSource = AutoCompleteSource.CustomSource

        'Cargar autocomplete de codigo de poliza
        sentencia1 = "Select po_codigo from poliza where po_estatus='A' order by po_codigo"
        cmb_CodigoContrato.AutoCompleteCustomSource = Autocompletar(sentencia1, "po_codigo")
        cmb_CodigoContrato.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmb_CodigoContrato.AutoCompleteSource = AutoCompleteSource.CustomSource

    End Sub
    'llena todos los asegurados
    Private Sub todosasegurados()
        'llenar combo de todos los asegurados
        sentencia = "Select a_cedula from asegurado where a_estatus='A' order by a_cedula"
        cmb_CedulaA.DataSource = Datos(sentencia)

        cmb_CedulaA.DisplayMember = "a_cedula"
        cmb_CedulaA.ValueMember = "a_cedula"
        cmb_CedulaA.SelectedIndex = -1
    End Sub
    'carga los asegurados dependiendo del tomador
    Public Sub aseguradoXtomador()
        'llenar combo con los asegurados que se asocian al tomador seleccionado 
        sentencia = "select distinct * from poliza where po_estatus='A' and po_t_cedula='" & cmb_CedulaT.SelectedValue.ToString & "'"
        cmb_CedulaA.DataSource = Datos(sentencia)
        cmb_CedulaA.DisplayMember = "po_a_cedula"
        cmb_CedulaA.ValueMember = "po_a_cedula"
        ' cmb_CedulaA.SelectedIndex = -1

    End Sub
    'carga todas las placas
    Private Sub todosplacas()
        'Cargar combobox de placas
        sentencia = "Select v_placa from vehiculo where v_estatus='A' order by v_placa"
        cmb_Placa.DataSource = Datos(sentencia)

        cmb_Placa.DisplayMember = "Placa"
        cmb_Placa.ValueMember = "v_placa"
        cmb_Placa.SelectedIndex = -1
    End Sub
    'carga las placas dependiedo del tomador
    Private Sub placaXtomador()
        'Cargar combobox de placas
        sentencia = "select distinct * from poliza where po_estatus='A' and po_t_cedula='" & cmb_CedulaT.SelectedValue.ToString & "'"
        cmb_Placa.DataSource = Datos(sentencia)
        cmb_Placa.DisplayMember = "Placa"
        cmb_Placa.ValueMember = "po_v_placa"
        'cmb_Placa.SelectedIndex = -1
    End Sub
    'carga todos los contratos
    Private Sub todocontratos()
        'Cargar combobox de codigo de poliza
        sentencia1 = "Select po_codigo from poliza where po_estatus='A' order by po_codigo"
        cmb_CodigoContrato.DataSource = Datos(sentencia1)

        cmb_CodigoContrato.DisplayMember = "po_codigo"
        cmb_CodigoContrato.ValueMember = "po_codigo"
        cmb_CodigoContrato.SelectedIndex = -1
    End Sub
    'carga los contratos dependiendo del tomador
    Private Sub contratoXtomador()
        'Cargar combobox de codigo de poliza
        sentencia = "select po_codigo from poliza where po_estatus='A' and po_t_cedula='" & cmb_CedulaT.SelectedValue.ToString & "'"
        cmb_CodigoContrato.DataSource = Datos(sentencia1)
        cmb_CodigoContrato.DisplayMember = "po_codigo"
        cmb_CodigoContrato.ValueMember = "po_codigo"
        'cmb_CodigoContrato.SelectedIndex = -1
    End Sub
    'carga todos los tomadores
    Private Sub todotomador()
        sentencia = "Select t_cedula from tomador where t_estatus='A' order by t_cedula"
        cmb_CedulaT.DataSource = Datos(sentencia)

        cmb_CedulaT.DisplayMember = "t_cedula"
        cmb_CedulaT.ValueMember = "t_cedula"
        cmb_CedulaT.SelectedIndex = -1
    End Sub
    'carga los tomadores dependiendo dl asegurado
    Private Sub tomadorXasegurado()
        sentencia = "select distinct * from poliza where po_estatus='A' and po_a_cedula='" & cmb_CedulaA.Text & "'"
        cmb_CedulaT.DataSource = Datos(sentencia)
        cmb_CedulaT.DisplayMember = "po_t_cedula"
        cmb_CedulaT.ValueMember = "po_t_cedula"
        ' cmb_CedulaT.SelectedIndex = -1
    End Sub
    'carga la placa dependiendo del asegurado
    Private Sub placaXasegurado()
        'Cargar combobox de placas
        sentencia = "select distinct * from poliza where po_estatus='A' and po_a_cedula='" & cmb_CedulaA.Text & "'"
        cmb_Placa.DataSource = Datos(sentencia)

        cmb_Placa.DisplayMember = "Placa"
        cmb_Placa.ValueMember = "po_v_placa"
        ' cmb_Placa.SelectedIndex = -1
    End Sub
    'carga el contrato dependiendo del asegurado
    Private Sub contratoXasegurado()
        sentencia = "select po_codigo from poliza where po_estatus='A' and po_a_cedula='" & cmb_CedulaA.Text & "'"
        cmb_CodigoContrato.DataSource = Datos(sentencia1)

        cmb_CodigoContrato.DisplayMember = "po_codigo"
        cmb_CodigoContrato.ValueMember = "po_codigo"
        ' cmb_CodigoContrato.SelectedIndex = -1
    End Sub
    'para generar las busquedas de los datos del tomador segun la cedula 
    Private Sub combotomador()

        sentencia = "select t_cedula,
                      t_nacionalidad, 
                      t_primer_nombre,
                      t_segundo_nombre,
                      t_primer_apellido,
                      t_segundo_apellido 
                      from tomador 
                      where t_cedula='" & cmb_CedulaT.SelectedValue.ToString & "' "
        CSelect(sentencia)

        cmb_NacionalidadT.Text = sdr("t_nacionalidad")
        txt_PNombreT.Text = sdr("t_primer_nombre")
        txt_SNombreT.Text = sdr("t_segundo_nombre")
        txt_PApellidoT.Text = sdr("t_primer_apellido")
        txt_SApellidoT.Text = sdr("t_segundo_apellido")
        If cmb_CedulaT.SelectedValue.ToString.Length <> 0 Then

            contratoXtomador()
            aseguradoXtomador()
            placaXtomador()

        End If


    End Sub
    'llamar la busqueda una vez se halla seleccionado
    Private Sub cmb_CedulaT_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_CedulaT.SelectionChangeCommitted
        If cmb_CedulaT.SelectedIndex <> -1 Then

            combotomador()

        End If
        Desconectar()
    End Sub
    'llamar la busqueda siempre y cuendo el texto escrito corresponda con un elemento precargado y si no perdir agregarlo
    Private Sub cmb_CedulaT_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_CedulaT.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            If cmb_CedulaT.SelectedIndex = -1 Then
                tomadornoencontrado()
            Else
                combotomador()
            End If

        End If
    End Sub
    'validacion que se halla escrito algo para busccar
    Private Sub cmb_CedulaT_Validated(sender As Object, e As EventArgs) Handles cmb_CedulaT.Validated
        If cmb_CedulaT.SelectedIndex = -1 Then
            tomadornoencontrado()

        End If


    End Sub
    'mensaje y metodos aseguir si no se encuentra el tomador
    Public Sub tomadornoencontrado()
        If MsgBox("El tomador " & cmb_CedulaT.Text & " no existe ¿Desea agregarlo?", vbYesNo) = MsgBoxResult.Yes Then
            Dim formu As New frm_Tomador()
            frm_Tomador.Show()
            HCampos(frm_Tomador, True, formu.cmb_CedulaT)
            formu.cmb_CedulaT.SelectedValue = Me.cmb_CedulaT.Text
            formu.HBotones(True)
            formu.btn_Modificar.Enabled = False
            formu.btn_Buscar.Enabled = False
            formu.txt_PNombre.Focus()
        Else
            Limpiar(grb_Tomador)

        End If
    End Sub

    Private Sub comboasegurado()
        sentencia = "select a_cedula,
                      a_nacionalidad, 
                      a_primer_nombre,
                      a_segundo_nombre,
                      a_primer_apellido,
                      a_segundo_apellido 
                      from asegurado 
                      where a_cedula='" & cmb_CedulaA.SelectedValue.ToString & "' "
        CSelect(sentencia)
        cmb_NacionalidadA.Text = sdr("a_nacionalidad")
        txt_PNombreA.Text = sdr("a_primer_nombre")
        txt_SNombreA.Text = sdr("a_segundo_nombre")
        txt_PApellidoA.Text = sdr("a_primer_apellido")
        txt_SApellidoA.Text = sdr("a_segundo_apellido")

        If cmb_CedulaA.Text.Length <> 0 Then

            tomadorXasegurado()
            contratoXasegurado()
            placaXasegurado()
        End If
    End Sub
    Private Sub cmb_CedulaA_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_CedulaA.SelectionChangeCommitted
        If cmb_CedulaA.SelectedIndex <> -1 Then
            comboasegurado()
        End If
        Desconectar()
    End Sub
    Private Sub cmb_CedulaA_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_CedulaA.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            If cmb_CedulaA.SelectedIndex = -1 Then
                aseguradonoencontrado()
            Else
                comboasegurado()
            End If

        End If
    End Sub
    Private Sub cmb_CedulaA_Validated(sender As Object, e As EventArgs) Handles cmb_CedulaA.Validated
        If cmb_CedulaA.SelectedIndex = -1 Then
            aseguradonoencontrado()

        End If
    End Sub
    Public Sub aseguradonoencontrado()
        If MsgBox("El asegurado " & cmb_CedulaA.Text & " no existe ¿Desea agregarlo?", vbYesNo, "Gestión de Asegurado") = MsgBoxResult.Yes Then
            Dim formu As New frm_Asegurado()
            frm_Tomador.Show()
            HCampos(frm_Tomador, True, formu.txt_Cedula)
            formu.txt_Cedula.Text = Me.cmb_CedulaA.Text
            'formu.HBotones(True)
            formu.btn_Modificar.Enabled = False
            formu.btn_Buscar.Enabled = False
            formu.txt_PNombre.Focus()
        Else
            Limpiar(grb_Asegurado)

        End If
    End Sub


    Private Sub comboplacas()
        sentencia = "select vehiculo.v_placa,
                    vehiculo.v_mv_codigo,
                    vehiculo.v_año,
                    marca_vehiculo.mv_codigo,
                    marca_vehiculo.mv_marca,
                    marca_vehiculo.mv_modelo
                    from vehiculo
                    left join marca_vehiculo on vehiculo.v_mv_codigo=marca_vehiculo.mv_codigo
                    where vehiculo.v_placa='" & cmb_Placa.SelectedValue.ToString & "'"
        CSelect(sentencia)
        Dim placa As String = sdr("v_placa")
        txt_Marca.Text = sdr("mv_marca")
        txt_Modelo.Text = sdr("mv_modelo")
        dtp_Año.Value = sdr("v_año")
        sentencia = "select t_nacionalidad,
                    t_cedula,
                    t_primer_nombre,
                    t_segundo_nombre,
                    t_primer_apellido,
                    t_segundo_apellido,
                    a_nacionalidad,
                    a_cedula,
                    a_primer_nombre,
                    a_segundo_nombre,
                    a_primer_apellido,
                    a_segundo_apellido,
                    poliza.po_codigo,
                    poliza.po_tp_codigo,
                    poliza.po_pp_codigo,
                    poliza.po_t_cedula,
                    poliza.po_a_cedula,
                    poliza.po_em_cedula,
                    poliza.po_v_placa,
                    poliza.po_monto_pagar,
                    poliza.po_suma_asegurada,
                    poliza.po_fecha_cobro,
                    poliza.po_fecha_inicio,
                    poliza.po_fecha_vencimiento
                    from poliza  
                    inner join tomador t on poliza.po_t_cedula=t.t_cedula 
                    inner join asegurado a on poliza.po_a_cedula= a.a_cedula
                    where poliza.po_estatus='A' and poliza.po_v_placa='" & cmb_Placa.SelectedValue.ToString & "'"
        CSelect(sentencia)
        cmb_NacionalidadT.Text = sdr("t_nacionalidad")
        txt_PNombreT.Text = sdr("t_primer_nombre")
        txt_SNombreT.Text = sdr("t_segundo_nombre")
        txt_PApellidoT.Text = sdr("t_primer_apellido")
        txt_SApellidoT.Text = sdr("t_segundo_apellido")
        cmb_NacionalidadA.Text = sdr("a_nacionalidad")
        txt_PNombreA.Text = sdr("a_primer_nombre")
        txt_SNombreA.Text = sdr("a_segundo_nombre")
        txt_PApellidoA.Text = sdr("a_primer_apellido")
        txt_SApellidoA.Text = sdr("a_segundo_apellido")
        cmb_CodigoContrato.SelectedValue = sdr("po_codigo")
        ltb_TipoPoliza.SelectedValue = sdr("po_tp_codigo")
        ltb_PlanPago.SelectedValue = sdr("po_pp_codigo")
        cmb_CedulaT.SelectedValue = sdr("po_t_cedula")
        cmb_CedulaA.SelectedValue = sdr("po_a_cedula")
        cmb_Placa.SelectedValue = sdr("po_v_placa")
        txt_MontoPagar.Text = sdr("po_monto_pagar")
        txt_Suma_asegurada.Text = sdr("po_suma_asegurada")
        dtp_FechaCobro.Value = sdr("po_fecha_cobro")
        dtp_FechaI.Value = sdr("po_fecha_inicio")
        dtp_FechaF.Value = sdr("po_fecha_vencimiento")
        list_cobertura(sdr("po_tp_codigo"))
    End Sub
    Private Sub cmb_Placa_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_Placa.SelectionChangeCommitted
        If cmb_Placa.SelectedIndex <> -1 Then
            comboplacas()
        End If
        Desconectar()
    End Sub

    Private Sub cmb_Placa_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_Placa.KeyDown


    End Sub

    Private Sub cmb_Placa_Validated(sender As Object, e As EventArgs) Handles cmb_Placa.Validated
        If (cmb_Placa.SelectedIndex = -1) Then
            placanoencontrado()

        End If
    End Sub
    Private Sub placanoencontrado()
        If MsgBox("La placa " & cmb_Placa.Text & " no existe ¿Desea agregarlo?", vbYesNo, "Gestión de Vehíclo") = MsgBoxResult.Yes Then
            Dim formu As New frm_Vehiculo()
            frm_Vehiculo.Show()
            HCampos(frm_Tomador, True, formu.txt_Placa)
            formu.txt_Placa.Text = Me.cmb_Placa.Text
            'formu.HBotones(True)
            formu.btn_Modificar.Enabled = False
            formu.btn_Buscar.Enabled = False
            'formu.txt_Color.Focus()
        Else
            Limpiar(grb_Tomador)

        End If
    End Sub

    Private Sub combocontrato()

        sentencia = "select t_nacionalidad,
                    t_cedula,
                    t_primer_nombre,
                    t_segundo_nombre,
                    t_primer_apellido,
                    t_segundo_apellido,
                    a_nacionalidad,
                    a_cedula,
                    a_primer_nombre,
                    a_segundo_nombre,
                    a_primer_apellido,
                    a_segundo_apellido,
                    poliza.po_codigo,
                    poliza.po_tp_codigo,
                    poliza.po_pp_codigo,
                    poliza.po_t_cedula,
                    poliza.po_a_cedula,
                    poliza.po_em_cedula,
                    poliza.po_v_placa,
                    poliza.po_monto_pagar,
                    poliza.po_suma_asegurada,
                    poliza.po_fecha_cobro,
                    poliza.po_fecha_inicio,
                    poliza.po_fecha_vencimiento
                    from poliza  
                    inner join tomador t on poliza.po_t_cedula=t.t_cedula 
                    inner join asegurado a on poliza.po_a_cedula= a.a_cedula
                    where poliza.po_estatus='A' and poliza.po_v_placa='" & cmb_Placa.SelectedValue.ToString & "'"
        CSelect(sentencia)
        cmb_NacionalidadT.Text = sdr("t_nacionalidad")
        txt_PNombreT.Text = sdr("t_primer_nombre")
        txt_SNombreT.Text = sdr("t_segundo_nombre")
        txt_PApellidoT.Text = sdr("t_primer_apellido")
        txt_SApellidoT.Text = sdr("t_segundo_apellido")
        cmb_NacionalidadA.Text = sdr("a_nacionalidad")
        txt_PNombreA.Text = sdr("a_primer_nombre")
        txt_SNombreA.Text = sdr("a_segundo_nombre")
        txt_PApellidoA.Text = sdr("a_primer_apellido")
        txt_SApellidoA.Text = sdr("a_segundo_apellido")
        cmb_CodigoContrato.SelectedValue = sdr("po_codigo")
        ltb_TipoPoliza.SelectedValue = sdr("po_tp_codigo")
        ltb_PlanPago.SelectedValue = sdr("po_pp_codigo")
        cmb_CedulaT.SelectedValue = sdr("po_t_cedula")
        cmb_CedulaA.SelectedValue = sdr("po_a_cedula")
        cmb_Placa.SelectedValue = sdr("po_v_placa")
        txt_MontoPagar.Text = sdr("po_monto_pagar")
        txt_Suma_asegurada.Text = sdr("po_suma_asegurada")
        dtp_FechaCobro.Value = sdr("po_fecha_cobro")
        dtp_FechaI.Value = sdr("po_fecha_inicio")
        dtp_FechaF.Value = sdr("po_fecha_vencimiento")
        list_cobertura(sdr("po_tp_codigo"))

    End Sub



    Private Sub ltb_TipoPoliza_Click(sender As Object, e As EventArgs) Handles ltb_TipoPoliza.Click

        Limpiar(grb_Pagos)
        ltb_PlanPago.SelectedIndex = -1
        sentencia = "select tp_monto_base,
                    tp_codigo 
                    from tipo_poliza 
                    where tp_codigo= '" & ltb_TipoPoliza.SelectedValue & "' and 
                    tp_estatus='A'"
        CSelect(sentencia)

        If Not (sdr.IsClosed) Or Not (sdr.HasRows) Then
            txt_MontoBase.Text = sdr("tp_monto_base")
        End If
        'Desconectar()
        list_cobertura(sdr("tp_codigo"))
    End Sub

    Private Sub ltb_PlanPago_Click(sender As Object, e As EventArgs) Handles ltb_PlanPago.Click
        sentencia = "select pp_nrocuotas,
                    pp_porcentaje 
                    from plan_pago
                    where pp_codigo= '" & ltb_PlanPago.SelectedValue & "' and 
                    pp_estatus='A'"
        CSelect(sentencia)
        If Not (sdr.IsClosed) Or Not (sdr.HasRows) Then
            Dim montobase As Integer = txt_MontoBase.Text
            Dim porcentaje As Double = sdr("pp_porcentaje")
            txt_MontoPagar.Text = (montobase + (montobase * porcentaje))
            txt_NCuotas.Text = sdr("pp_nrocuotas")
            txt_MontoCuota.Text = (txt_MontoPagar.Text / txt_NCuotas.Text)
            txt_Suma_asegurada.Text = txt_MontoBase.Text * 5.1415
        End If
        Desconectar()
    End Sub

    Private Sub cmb_CodigoContrato_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_CodigoContrato.SelectionChangeCommitted
        If cmb_CodigoContrato.SelectedIndex <> -1 Then
            combocontrato()

        End If
        Desconectar()
    End Sub
End Class