﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Contrato_Poliza
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_Anular = New System.Windows.Forms.Button()
        Me.btn_Volver = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.grb_Vehiculo = New System.Windows.Forms.GroupBox()
        Me.cmb_Placa = New System.Windows.Forms.ComboBox()
        Me.dtp_Año = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Marca = New System.Windows.Forms.Label()
        Me.txt_Modelo = New System.Windows.Forms.TextBox()
        Me.btn_BuscarP = New System.Windows.Forms.Button()
        Me.lbl_Año = New System.Windows.Forms.Label()
        Me.txt_Marca = New System.Windows.Forms.TextBox()
        Me.lbl_Modelo = New System.Windows.Forms.Label()
        Me.lbl_Placa = New System.Windows.Forms.Label()
        Me.grb_Poliza = New System.Windows.Forms.GroupBox()
        Me.ltb_cobertura = New System.Windows.Forms.ListBox()
        Me.cmb_CodigoContrato = New System.Windows.Forms.ComboBox()
        Me.ltb_PlanPago = New System.Windows.Forms.ListBox()
        Me.lbl_PlanPago = New System.Windows.Forms.Label()
        Me.lbl_Coberturas = New System.Windows.Forms.Label()
        Me.ltb_TipoPoliza = New System.Windows.Forms.ListBox()
        Me.lbl_TipoPoliza = New System.Windows.Forms.Label()
        Me.lbl_FechaF = New System.Windows.Forms.Label()
        Me.grb_Pagos = New System.Windows.Forms.GroupBox()
        Me.txt_Suma_asegurada = New System.Windows.Forms.TextBox()
        Me.lbl_SumaAsegurada = New System.Windows.Forms.Label()
        Me.dtp_FechaCobro = New System.Windows.Forms.DateTimePicker()
        Me.lbl_FechaCobro = New System.Windows.Forms.Label()
        Me.txt_MontoCuota = New System.Windows.Forms.TextBox()
        Me.lbl_MontoCuota = New System.Windows.Forms.Label()
        Me.txt_NCuotas = New System.Windows.Forms.TextBox()
        Me.lbl_NCuotas = New System.Windows.Forms.Label()
        Me.txt_MontoPagar = New System.Windows.Forms.TextBox()
        Me.lbl_MontoPagar = New System.Windows.Forms.Label()
        Me.txt_MontoBase = New System.Windows.Forms.TextBox()
        Me.lbl_MontoBase = New System.Windows.Forms.Label()
        Me.dtp_FechaF = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FechaI = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Fechai = New System.Windows.Forms.Label()
        Me.btn_BuscarC = New System.Windows.Forms.Button()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.lbl_Codigo = New System.Windows.Forms.Label()
        Me.grb_Asegurado = New System.Windows.Forms.GroupBox()
        Me.cmb_CedulaA = New System.Windows.Forms.ComboBox()
        Me.btn_BuscarA = New System.Windows.Forms.Button()
        Me.cmb_NacionalidadA = New System.Windows.Forms.ComboBox()
        Me.lbl_PNombreA = New System.Windows.Forms.Label()
        Me.lbl_SNombreA = New System.Windows.Forms.Label()
        Me.lbl_CedulaA = New System.Windows.Forms.Label()
        Me.lbl_PApellidoA = New System.Windows.Forms.Label()
        Me.txt_SApellidoA = New System.Windows.Forms.TextBox()
        Me.lbl_SApellidoA = New System.Windows.Forms.Label()
        Me.txt_SNombreA = New System.Windows.Forms.TextBox()
        Me.txt_PNombreA = New System.Windows.Forms.TextBox()
        Me.txt_PApellidoA = New System.Windows.Forms.TextBox()
        Me.grb_Tomador = New System.Windows.Forms.GroupBox()
        Me.cmb_CedulaT = New System.Windows.Forms.ComboBox()
        Me.btn_BuscarT = New System.Windows.Forms.Button()
        Me.cmb_NacionalidadT = New System.Windows.Forms.ComboBox()
        Me.lbl_PNombreT = New System.Windows.Forms.Label()
        Me.lbl_SNombreT = New System.Windows.Forms.Label()
        Me.lbl_CedulaT = New System.Windows.Forms.Label()
        Me.lbl_PApellidoT = New System.Windows.Forms.Label()
        Me.txt_SApellidoT = New System.Windows.Forms.TextBox()
        Me.lbl_SApellidoT = New System.Windows.Forms.Label()
        Me.txt_SNombreT = New System.Windows.Forms.TextBox()
        Me.txt_PNombreT = New System.Windows.Forms.TextBox()
        Me.txt_PApellidoT = New System.Windows.Forms.TextBox()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoSaludo = New System.Windows.Forms.Label()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoFormuladio = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoModulo = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoEmpresa = New System.Windows.Forms.Label()
        Me.ptb_logo = New System.Windows.Forms.PictureBox()
        Me.grb_Vehiculo.SuspendLayout()
        Me.grb_Poliza.SuspendLayout()
        Me.grb_Pagos.SuspendLayout()
        Me.grb_Asegurado.SuspendLayout()
        Me.grb_Tomador.SuspendLayout()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Anular
        '
        Me.btn_Anular.Location = New System.Drawing.Point(329, 701)
        Me.btn_Anular.Name = "btn_Anular"
        Me.btn_Anular.Size = New System.Drawing.Size(75, 23)
        Me.btn_Anular.TabIndex = 37
        Me.btn_Anular.Text = "Anular"
        Me.btn_Anular.UseVisualStyleBackColor = True
        '
        'btn_Volver
        '
        Me.btn_Volver.Location = New System.Drawing.Point(561, 701)
        Me.btn_Volver.Name = "btn_Volver"
        Me.btn_Volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_Volver.TabIndex = 39
        Me.btn_Volver.Text = "Volver"
        Me.btn_Volver.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(445, 701)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 38
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Location = New System.Drawing.Point(213, 702)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Modificar.TabIndex = 35
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Location = New System.Drawing.Point(97, 702)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Agregar.TabIndex = 34
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'grb_Vehiculo
        '
        Me.grb_Vehiculo.Controls.Add(Me.cmb_Placa)
        Me.grb_Vehiculo.Controls.Add(Me.dtp_Año)
        Me.grb_Vehiculo.Controls.Add(Me.lbl_Marca)
        Me.grb_Vehiculo.Controls.Add(Me.txt_Modelo)
        Me.grb_Vehiculo.Controls.Add(Me.btn_BuscarP)
        Me.grb_Vehiculo.Controls.Add(Me.lbl_Año)
        Me.grb_Vehiculo.Controls.Add(Me.txt_Marca)
        Me.grb_Vehiculo.Controls.Add(Me.lbl_Modelo)
        Me.grb_Vehiculo.Controls.Add(Me.lbl_Placa)
        Me.grb_Vehiculo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Vehiculo.Location = New System.Drawing.Point(8, 339)
        Me.grb_Vehiculo.Name = "grb_Vehiculo"
        Me.grb_Vehiculo.Size = New System.Drawing.Size(716, 82)
        Me.grb_Vehiculo.TabIndex = 17
        Me.grb_Vehiculo.TabStop = False
        Me.grb_Vehiculo.Text = " Datos del vehiculo"
        '
        'cmb_Placa
        '
        Me.cmb_Placa.FormattingEnabled = True
        Me.cmb_Placa.Location = New System.Drawing.Point(91, 19)
        Me.cmb_Placa.Name = "cmb_Placa"
        Me.cmb_Placa.Size = New System.Drawing.Size(97, 24)
        Me.cmb_Placa.TabIndex = 18
        '
        'dtp_Año
        '
        Me.dtp_Año.CustomFormat = "  yyyy"
        Me.dtp_Año.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Año.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtp_Año.Location = New System.Drawing.Point(502, 49)
        Me.dtp_Año.MinDate = New Date(1800, 2, 1, 0, 0, 0, 0)
        Me.dtp_Año.Name = "dtp_Año"
        Me.dtp_Año.Size = New System.Drawing.Size(59, 21)
        Me.dtp_Año.TabIndex = 21
        '
        'lbl_Marca
        '
        Me.lbl_Marca.AutoSize = True
        Me.lbl_Marca.Location = New System.Drawing.Point(38, 52)
        Me.lbl_Marca.Name = "lbl_Marca"
        Me.lbl_Marca.Size = New System.Drawing.Size(48, 16)
        Me.lbl_Marca.TabIndex = 108
        Me.lbl_Marca.Text = "Marca:"
        '
        'txt_Modelo
        '
        Me.txt_Modelo.Location = New System.Drawing.Point(307, 49)
        Me.txt_Modelo.Name = "txt_Modelo"
        Me.txt_Modelo.Size = New System.Drawing.Size(138, 21)
        Me.txt_Modelo.TabIndex = 20
        '
        'btn_BuscarP
        '
        Me.btn_BuscarP.Location = New System.Drawing.Point(194, 19)
        Me.btn_BuscarP.Name = "btn_BuscarP"
        Me.btn_BuscarP.Size = New System.Drawing.Size(75, 23)
        Me.btn_BuscarP.TabIndex = 22
        Me.btn_BuscarP.Text = "Buscar"
        Me.btn_BuscarP.UseVisualStyleBackColor = True
        '
        'lbl_Año
        '
        Me.lbl_Año.AutoSize = True
        Me.lbl_Año.Location = New System.Drawing.Point(467, 52)
        Me.lbl_Año.Name = "lbl_Año"
        Me.lbl_Año.Size = New System.Drawing.Size(29, 16)
        Me.lbl_Año.TabIndex = 13
        Me.lbl_Año.Text = "Año"
        '
        'txt_Marca
        '
        Me.txt_Marca.Location = New System.Drawing.Point(92, 49)
        Me.txt_Marca.Name = "txt_Marca"
        Me.txt_Marca.Size = New System.Drawing.Size(138, 21)
        Me.txt_Marca.TabIndex = 19
        '
        'lbl_Modelo
        '
        Me.lbl_Modelo.AutoSize = True
        Me.lbl_Modelo.Location = New System.Drawing.Point(245, 52)
        Me.lbl_Modelo.Name = "lbl_Modelo"
        Me.lbl_Modelo.Size = New System.Drawing.Size(56, 16)
        Me.lbl_Modelo.TabIndex = 11
        Me.lbl_Modelo.Text = " Modelo:"
        '
        'lbl_Placa
        '
        Me.lbl_Placa.AutoSize = True
        Me.lbl_Placa.Location = New System.Drawing.Point(40, 22)
        Me.lbl_Placa.Name = "lbl_Placa"
        Me.lbl_Placa.Size = New System.Drawing.Size(46, 16)
        Me.lbl_Placa.TabIndex = 8
        Me.lbl_Placa.Text = " Placa:"
        '
        'grb_Poliza
        '
        Me.grb_Poliza.Controls.Add(Me.ltb_cobertura)
        Me.grb_Poliza.Controls.Add(Me.cmb_CodigoContrato)
        Me.grb_Poliza.Controls.Add(Me.ltb_PlanPago)
        Me.grb_Poliza.Controls.Add(Me.lbl_PlanPago)
        Me.grb_Poliza.Controls.Add(Me.lbl_Coberturas)
        Me.grb_Poliza.Controls.Add(Me.ltb_TipoPoliza)
        Me.grb_Poliza.Controls.Add(Me.lbl_TipoPoliza)
        Me.grb_Poliza.Controls.Add(Me.lbl_FechaF)
        Me.grb_Poliza.Controls.Add(Me.grb_Pagos)
        Me.grb_Poliza.Controls.Add(Me.dtp_FechaF)
        Me.grb_Poliza.Controls.Add(Me.dtp_FechaI)
        Me.grb_Poliza.Controls.Add(Me.lbl_Fechai)
        Me.grb_Poliza.Controls.Add(Me.btn_BuscarC)
        Me.grb_Poliza.Controls.Add(Me.txt_Codigo)
        Me.grb_Poliza.Controls.Add(Me.lbl_Codigo)
        Me.grb_Poliza.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Poliza.Location = New System.Drawing.Point(8, 423)
        Me.grb_Poliza.Name = "grb_Poliza"
        Me.grb_Poliza.Size = New System.Drawing.Size(716, 272)
        Me.grb_Poliza.TabIndex = 108
        Me.grb_Poliza.TabStop = False
        Me.grb_Poliza.Text = " Datos de la póliza"
        '
        'ltb_cobertura
        '
        Me.ltb_cobertura.Enabled = False
        Me.ltb_cobertura.FormattingEnabled = True
        Me.ltb_cobertura.ItemHeight = 16
        Me.ltb_cobertura.Location = New System.Drawing.Point(278, 92)
        Me.ltb_cobertura.Name = "ltb_cobertura"
        Me.ltb_cobertura.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ltb_cobertura.Size = New System.Drawing.Size(174, 84)
        Me.ltb_cobertura.TabIndex = 51
        '
        'cmb_CodigoContrato
        '
        Me.cmb_CodigoContrato.FormattingEnabled = True
        Me.cmb_CodigoContrato.Location = New System.Drawing.Point(91, 18)
        Me.cmb_CodigoContrato.Name = "cmb_CodigoContrato"
        Me.cmb_CodigoContrato.Size = New System.Drawing.Size(87, 24)
        Me.cmb_CodigoContrato.TabIndex = 23
        '
        'ltb_PlanPago
        '
        Me.ltb_PlanPago.FormattingEnabled = True
        Me.ltb_PlanPago.ItemHeight = 16
        Me.ltb_PlanPago.Location = New System.Drawing.Point(475, 92)
        Me.ltb_PlanPago.Name = "ltb_PlanPago"
        Me.ltb_PlanPago.Size = New System.Drawing.Size(174, 84)
        Me.ltb_PlanPago.TabIndex = 28
        '
        'lbl_PlanPago
        '
        Me.lbl_PlanPago.AutoSize = True
        Me.lbl_PlanPago.Location = New System.Drawing.Point(563, 73)
        Me.lbl_PlanPago.Name = "lbl_PlanPago"
        Me.lbl_PlanPago.Size = New System.Drawing.Size(86, 16)
        Me.lbl_PlanPago.TabIndex = 50
        Me.lbl_PlanPago.Text = "Plan de pago:"
        '
        'lbl_Coberturas
        '
        Me.lbl_Coberturas.AutoSize = True
        Me.lbl_Coberturas.Location = New System.Drawing.Point(381, 73)
        Me.lbl_Coberturas.Name = "lbl_Coberturas"
        Me.lbl_Coberturas.Size = New System.Drawing.Size(71, 16)
        Me.lbl_Coberturas.TabIndex = 48
        Me.lbl_Coberturas.Text = "Coberturas:"
        '
        'ltb_TipoPoliza
        '
        Me.ltb_TipoPoliza.FormattingEnabled = True
        Me.ltb_TipoPoliza.ItemHeight = 16
        Me.ltb_TipoPoliza.Location = New System.Drawing.Point(83, 92)
        Me.ltb_TipoPoliza.Name = "ltb_TipoPoliza"
        Me.ltb_TipoPoliza.Size = New System.Drawing.Size(172, 84)
        Me.ltb_TipoPoliza.TabIndex = 26
        '
        'lbl_TipoPoliza
        '
        Me.lbl_TipoPoliza.AutoSize = True
        Me.lbl_TipoPoliza.Location = New System.Drawing.Point(169, 73)
        Me.lbl_TipoPoliza.Name = "lbl_TipoPoliza"
        Me.lbl_TipoPoliza.Size = New System.Drawing.Size(86, 16)
        Me.lbl_TipoPoliza.TabIndex = 46
        Me.lbl_TipoPoliza.Text = "Tipo de póliza:"
        '
        'lbl_FechaF
        '
        Me.lbl_FechaF.AutoSize = True
        Me.lbl_FechaF.Location = New System.Drawing.Point(358, 48)
        Me.lbl_FechaF.Name = "lbl_FechaF"
        Me.lbl_FechaF.Size = New System.Drawing.Size(78, 16)
        Me.lbl_FechaF.TabIndex = 39
        Me.lbl_FechaF.Text = "Fecha de fin:"
        '
        'grb_Pagos
        '
        Me.grb_Pagos.Controls.Add(Me.txt_Suma_asegurada)
        Me.grb_Pagos.Controls.Add(Me.lbl_SumaAsegurada)
        Me.grb_Pagos.Controls.Add(Me.dtp_FechaCobro)
        Me.grb_Pagos.Controls.Add(Me.lbl_FechaCobro)
        Me.grb_Pagos.Controls.Add(Me.txt_MontoCuota)
        Me.grb_Pagos.Controls.Add(Me.lbl_MontoCuota)
        Me.grb_Pagos.Controls.Add(Me.txt_NCuotas)
        Me.grb_Pagos.Controls.Add(Me.lbl_NCuotas)
        Me.grb_Pagos.Controls.Add(Me.txt_MontoPagar)
        Me.grb_Pagos.Controls.Add(Me.lbl_MontoPagar)
        Me.grb_Pagos.Controls.Add(Me.txt_MontoBase)
        Me.grb_Pagos.Controls.Add(Me.lbl_MontoBase)
        Me.grb_Pagos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Pagos.Location = New System.Drawing.Point(6, 174)
        Me.grb_Pagos.Name = "grb_Pagos"
        Me.grb_Pagos.Size = New System.Drawing.Size(702, 92)
        Me.grb_Pagos.TabIndex = 37
        Me.grb_Pagos.TabStop = False
        Me.grb_Pagos.Text = "Dato de Pagos"
        '
        'txt_Suma_asegurada
        '
        Me.txt_Suma_asegurada.Location = New System.Drawing.Point(536, 23)
        Me.txt_Suma_asegurada.Name = "txt_Suma_asegurada"
        Me.txt_Suma_asegurada.Size = New System.Drawing.Size(100, 21)
        Me.txt_Suma_asegurada.TabIndex = 33
        '
        'lbl_SumaAsegurada
        '
        Me.lbl_SumaAsegurada.AutoSize = True
        Me.lbl_SumaAsegurada.Location = New System.Drawing.Point(426, 26)
        Me.lbl_SumaAsegurada.Name = "lbl_SumaAsegurada"
        Me.lbl_SumaAsegurada.Size = New System.Drawing.Size(104, 16)
        Me.lbl_SumaAsegurada.TabIndex = 37
        Me.lbl_SumaAsegurada.Text = "Suma Asegurada:"
        '
        'dtp_FechaCobro
        '
        Me.dtp_FechaCobro.CustomFormat = " dd-MM-yyyy"
        Me.dtp_FechaCobro.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_FechaCobro.Location = New System.Drawing.Point(536, 48)
        Me.dtp_FechaCobro.Name = "dtp_FechaCobro"
        Me.dtp_FechaCobro.Size = New System.Drawing.Size(100, 21)
        Me.dtp_FechaCobro.TabIndex = 34
        '
        'lbl_FechaCobro
        '
        Me.lbl_FechaCobro.AutoSize = True
        Me.lbl_FechaCobro.Location = New System.Drawing.Point(432, 52)
        Me.lbl_FechaCobro.Name = "lbl_FechaCobro"
        Me.lbl_FechaCobro.Size = New System.Drawing.Size(98, 16)
        Me.lbl_FechaCobro.TabIndex = 35
        Me.lbl_FechaCobro.Text = "Fecha de cobro:"
        '
        'txt_MontoCuota
        '
        Me.txt_MontoCuota.Location = New System.Drawing.Point(324, 48)
        Me.txt_MontoCuota.Name = "txt_MontoCuota"
        Me.txt_MontoCuota.Size = New System.Drawing.Size(100, 21)
        Me.txt_MontoCuota.TabIndex = 32
        '
        'lbl_MontoCuota
        '
        Me.lbl_MontoCuota.AutoSize = True
        Me.lbl_MontoCuota.Location = New System.Drawing.Point(219, 51)
        Me.lbl_MontoCuota.Name = "lbl_MontoCuota"
        Me.lbl_MontoCuota.Size = New System.Drawing.Size(106, 16)
        Me.lbl_MontoCuota.TabIndex = 32
        Me.lbl_MontoCuota.Text = "Monto por Cuota:"
        '
        'txt_NCuotas
        '
        Me.txt_NCuotas.Location = New System.Drawing.Point(111, 48)
        Me.txt_NCuotas.Name = "txt_NCuotas"
        Me.txt_NCuotas.Size = New System.Drawing.Size(100, 21)
        Me.txt_NCuotas.TabIndex = 30
        '
        'lbl_NCuotas
        '
        Me.lbl_NCuotas.AutoSize = True
        Me.lbl_NCuotas.Location = New System.Drawing.Point(1, 51)
        Me.lbl_NCuotas.Name = "lbl_NCuotas"
        Me.lbl_NCuotas.Size = New System.Drawing.Size(111, 16)
        Me.lbl_NCuotas.TabIndex = 30
        Me.lbl_NCuotas.Text = "Número de cuotas:"
        '
        'txt_MontoPagar
        '
        Me.txt_MontoPagar.Location = New System.Drawing.Point(324, 21)
        Me.txt_MontoPagar.Name = "txt_MontoPagar"
        Me.txt_MontoPagar.Size = New System.Drawing.Size(100, 21)
        Me.txt_MontoPagar.TabIndex = 31
        '
        'lbl_MontoPagar
        '
        Me.lbl_MontoPagar.AutoSize = True
        Me.lbl_MontoPagar.Location = New System.Drawing.Point(229, 22)
        Me.lbl_MontoPagar.Name = "lbl_MontoPagar"
        Me.lbl_MontoPagar.Size = New System.Drawing.Size(94, 16)
        Me.lbl_MontoPagar.TabIndex = 28
        Me.lbl_MontoPagar.Text = "Monto a Pagar:"
        '
        'txt_MontoBase
        '
        Me.txt_MontoBase.Location = New System.Drawing.Point(111, 19)
        Me.txt_MontoBase.Name = "txt_MontoBase"
        Me.txt_MontoBase.Size = New System.Drawing.Size(100, 21)
        Me.txt_MontoBase.TabIndex = 29
        '
        'lbl_MontoBase
        '
        Me.lbl_MontoBase.AutoSize = True
        Me.lbl_MontoBase.Location = New System.Drawing.Point(32, 22)
        Me.lbl_MontoBase.Name = "lbl_MontoBase"
        Me.lbl_MontoBase.Size = New System.Drawing.Size(77, 16)
        Me.lbl_MontoBase.TabIndex = 26
        Me.lbl_MontoBase.Text = "Monto base:"
        '
        'dtp_FechaF
        '
        Me.dtp_FechaF.Location = New System.Drawing.Point(442, 44)
        Me.dtp_FechaF.Name = "dtp_FechaF"
        Me.dtp_FechaF.Size = New System.Drawing.Size(212, 21)
        Me.dtp_FechaF.TabIndex = 25
        '
        'dtp_FechaI
        '
        Me.dtp_FechaI.Location = New System.Drawing.Point(442, 14)
        Me.dtp_FechaI.Name = "dtp_FechaI"
        Me.dtp_FechaI.Size = New System.Drawing.Size(212, 21)
        Me.dtp_FechaI.TabIndex = 24
        '
        'lbl_Fechai
        '
        Me.lbl_Fechai.AutoSize = True
        Me.lbl_Fechai.Location = New System.Drawing.Point(343, 18)
        Me.lbl_Fechai.Name = "lbl_Fechai"
        Me.lbl_Fechai.Size = New System.Drawing.Size(93, 16)
        Me.lbl_Fechai.TabIndex = 34
        Me.lbl_Fechai.Text = "Fecha de inicio:"
        '
        'btn_BuscarC
        '
        Me.btn_BuscarC.Location = New System.Drawing.Point(185, 20)
        Me.btn_BuscarC.Name = "btn_BuscarC"
        Me.btn_BuscarC.Size = New System.Drawing.Size(75, 23)
        Me.btn_BuscarC.TabIndex = 30
        Me.btn_BuscarC.Text = "Buscar"
        Me.btn_BuscarC.UseVisualStyleBackColor = True
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Location = New System.Drawing.Point(92, 19)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(86, 21)
        Me.txt_Codigo.TabIndex = 29
        '
        'lbl_Codigo
        '
        Me.lbl_Codigo.AutoSize = True
        Me.lbl_Codigo.Location = New System.Drawing.Point(35, 23)
        Me.lbl_Codigo.Name = "lbl_Codigo"
        Me.lbl_Codigo.Size = New System.Drawing.Size(51, 16)
        Me.lbl_Codigo.TabIndex = 28
        Me.lbl_Codigo.Text = "Código:"
        '
        'grb_Asegurado
        '
        Me.grb_Asegurado.Controls.Add(Me.cmb_CedulaA)
        Me.grb_Asegurado.Controls.Add(Me.btn_BuscarA)
        Me.grb_Asegurado.Controls.Add(Me.cmb_NacionalidadA)
        Me.grb_Asegurado.Controls.Add(Me.lbl_PNombreA)
        Me.grb_Asegurado.Controls.Add(Me.lbl_SNombreA)
        Me.grb_Asegurado.Controls.Add(Me.lbl_CedulaA)
        Me.grb_Asegurado.Controls.Add(Me.lbl_PApellidoA)
        Me.grb_Asegurado.Controls.Add(Me.txt_SApellidoA)
        Me.grb_Asegurado.Controls.Add(Me.lbl_SApellidoA)
        Me.grb_Asegurado.Controls.Add(Me.txt_SNombreA)
        Me.grb_Asegurado.Controls.Add(Me.txt_PNombreA)
        Me.grb_Asegurado.Controls.Add(Me.txt_PApellidoA)
        Me.grb_Asegurado.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Asegurado.Location = New System.Drawing.Point(369, 151)
        Me.grb_Asegurado.Name = "grb_Asegurado"
        Me.grb_Asegurado.Size = New System.Drawing.Size(355, 187)
        Me.grb_Asegurado.TabIndex = 9
        Me.grb_Asegurado.TabStop = False
        Me.grb_Asegurado.Text = " Datos del asegurado"
        '
        'cmb_CedulaA
        '
        Me.cmb_CedulaA.FormattingEnabled = True
        Me.cmb_CedulaA.Location = New System.Drawing.Point(175, 38)
        Me.cmb_CedulaA.Name = "cmb_CedulaA"
        Me.cmb_CedulaA.Size = New System.Drawing.Size(87, 24)
        Me.cmb_CedulaA.TabIndex = 11
        '
        'btn_BuscarA
        '
        Me.btn_BuscarA.Location = New System.Drawing.Point(272, 40)
        Me.btn_BuscarA.Name = "btn_BuscarA"
        Me.btn_BuscarA.Size = New System.Drawing.Size(75, 23)
        Me.btn_BuscarA.TabIndex = 16
        Me.btn_BuscarA.Text = "Buscar"
        Me.btn_BuscarA.UseVisualStyleBackColor = True
        '
        'cmb_NacionalidadA
        '
        Me.cmb_NacionalidadA.AutoCompleteCustomSource.AddRange(New String() {"V", "E"})
        Me.cmb_NacionalidadA.BackColor = System.Drawing.Color.GhostWhite
        Me.cmb_NacionalidadA.FormattingEnabled = True
        Me.cmb_NacionalidadA.Items.AddRange(New Object() {"V", "E"})
        Me.cmb_NacionalidadA.Location = New System.Drawing.Point(123, 38)
        Me.cmb_NacionalidadA.Name = "cmb_NacionalidadA"
        Me.cmb_NacionalidadA.Size = New System.Drawing.Size(47, 24)
        Me.cmb_NacionalidadA.TabIndex = 10
        '
        'lbl_PNombreA
        '
        Me.lbl_PNombreA.AutoSize = True
        Me.lbl_PNombreA.Location = New System.Drawing.Point(29, 69)
        Me.lbl_PNombreA.Name = "lbl_PNombreA"
        Me.lbl_PNombreA.Size = New System.Drawing.Size(88, 16)
        Me.lbl_PNombreA.TabIndex = 106
        Me.lbl_PNombreA.Text = "Primer nombre:"
        '
        'lbl_SNombreA
        '
        Me.lbl_SNombreA.AutoSize = True
        Me.lbl_SNombreA.Location = New System.Drawing.Point(12, 95)
        Me.lbl_SNombreA.Name = "lbl_SNombreA"
        Me.lbl_SNombreA.Size = New System.Drawing.Size(105, 16)
        Me.lbl_SNombreA.TabIndex = 107
        Me.lbl_SNombreA.Text = "Segundo nombre:"
        '
        'lbl_CedulaA
        '
        Me.lbl_CedulaA.AutoSize = True
        Me.lbl_CedulaA.Location = New System.Drawing.Point(65, 43)
        Me.lbl_CedulaA.Name = "lbl_CedulaA"
        Me.lbl_CedulaA.Size = New System.Drawing.Size(52, 16)
        Me.lbl_CedulaA.TabIndex = 114
        Me.lbl_CedulaA.Text = "Cédula:"
        '
        'lbl_PApellidoA
        '
        Me.lbl_PApellidoA.AutoSize = True
        Me.lbl_PApellidoA.Location = New System.Drawing.Point(27, 121)
        Me.lbl_PApellidoA.Name = "lbl_PApellidoA"
        Me.lbl_PApellidoA.Size = New System.Drawing.Size(90, 16)
        Me.lbl_PApellidoA.TabIndex = 108
        Me.lbl_PApellidoA.Text = "Primer apellido:"
        '
        'txt_SApellidoA
        '
        Me.txt_SApellidoA.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_SApellidoA.Location = New System.Drawing.Point(123, 144)
        Me.txt_SApellidoA.MaxLength = 15
        Me.txt_SApellidoA.Name = "txt_SApellidoA"
        Me.txt_SApellidoA.Size = New System.Drawing.Size(139, 21)
        Me.txt_SApellidoA.TabIndex = 15
        '
        'lbl_SApellidoA
        '
        Me.lbl_SApellidoA.AutoSize = True
        Me.lbl_SApellidoA.Location = New System.Drawing.Point(10, 147)
        Me.lbl_SApellidoA.Name = "lbl_SApellidoA"
        Me.lbl_SApellidoA.Size = New System.Drawing.Size(107, 16)
        Me.lbl_SApellidoA.TabIndex = 109
        Me.lbl_SApellidoA.Text = "Segundo apellido:"
        '
        'txt_SNombreA
        '
        Me.txt_SNombreA.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_SNombreA.Location = New System.Drawing.Point(123, 92)
        Me.txt_SNombreA.MaxLength = 15
        Me.txt_SNombreA.Name = "txt_SNombreA"
        Me.txt_SNombreA.Size = New System.Drawing.Size(139, 21)
        Me.txt_SNombreA.TabIndex = 13
        '
        'txt_PNombreA
        '
        Me.txt_PNombreA.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_PNombreA.Location = New System.Drawing.Point(123, 66)
        Me.txt_PNombreA.MaxLength = 15
        Me.txt_PNombreA.Name = "txt_PNombreA"
        Me.txt_PNombreA.Size = New System.Drawing.Size(139, 21)
        Me.txt_PNombreA.TabIndex = 12
        '
        'txt_PApellidoA
        '
        Me.txt_PApellidoA.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_PApellidoA.Location = New System.Drawing.Point(123, 118)
        Me.txt_PApellidoA.MaxLength = 15
        Me.txt_PApellidoA.Name = "txt_PApellidoA"
        Me.txt_PApellidoA.Size = New System.Drawing.Size(139, 21)
        Me.txt_PApellidoA.TabIndex = 14
        '
        'grb_Tomador
        '
        Me.grb_Tomador.Controls.Add(Me.cmb_CedulaT)
        Me.grb_Tomador.Controls.Add(Me.btn_BuscarT)
        Me.grb_Tomador.Controls.Add(Me.cmb_NacionalidadT)
        Me.grb_Tomador.Controls.Add(Me.lbl_PNombreT)
        Me.grb_Tomador.Controls.Add(Me.lbl_SNombreT)
        Me.grb_Tomador.Controls.Add(Me.lbl_CedulaT)
        Me.grb_Tomador.Controls.Add(Me.lbl_PApellidoT)
        Me.grb_Tomador.Controls.Add(Me.txt_SApellidoT)
        Me.grb_Tomador.Controls.Add(Me.lbl_SApellidoT)
        Me.grb_Tomador.Controls.Add(Me.txt_SNombreT)
        Me.grb_Tomador.Controls.Add(Me.txt_PNombreT)
        Me.grb_Tomador.Controls.Add(Me.txt_PApellidoT)
        Me.grb_Tomador.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Tomador.Location = New System.Drawing.Point(8, 151)
        Me.grb_Tomador.Name = "grb_Tomador"
        Me.grb_Tomador.Size = New System.Drawing.Size(355, 187)
        Me.grb_Tomador.TabIndex = 1
        Me.grb_Tomador.TabStop = False
        Me.grb_Tomador.Text = "Datos del tomador"
        '
        'cmb_CedulaT
        '
        Me.cmb_CedulaT.FormattingEnabled = True
        Me.cmb_CedulaT.Location = New System.Drawing.Point(171, 37)
        Me.cmb_CedulaT.Name = "cmb_CedulaT"
        Me.cmb_CedulaT.Size = New System.Drawing.Size(87, 24)
        Me.cmb_CedulaT.TabIndex = 3
        '
        'btn_BuscarT
        '
        Me.btn_BuscarT.Location = New System.Drawing.Point(265, 38)
        Me.btn_BuscarT.Name = "btn_BuscarT"
        Me.btn_BuscarT.Size = New System.Drawing.Size(75, 23)
        Me.btn_BuscarT.TabIndex = 8
        Me.btn_BuscarT.Text = "Buscar"
        Me.btn_BuscarT.UseVisualStyleBackColor = True
        '
        'cmb_NacionalidadT
        '
        Me.cmb_NacionalidadT.AutoCompleteCustomSource.AddRange(New String() {"V", "E"})
        Me.cmb_NacionalidadT.BackColor = System.Drawing.Color.GhostWhite
        Me.cmb_NacionalidadT.FormattingEnabled = True
        Me.cmb_NacionalidadT.Items.AddRange(New Object() {"V", "E"})
        Me.cmb_NacionalidadT.Location = New System.Drawing.Point(120, 38)
        Me.cmb_NacionalidadT.Name = "cmb_NacionalidadT"
        Me.cmb_NacionalidadT.Size = New System.Drawing.Size(47, 24)
        Me.cmb_NacionalidadT.TabIndex = 2
        '
        'lbl_PNombreT
        '
        Me.lbl_PNombreT.AutoSize = True
        Me.lbl_PNombreT.Location = New System.Drawing.Point(29, 68)
        Me.lbl_PNombreT.Name = "lbl_PNombreT"
        Me.lbl_PNombreT.Size = New System.Drawing.Size(88, 16)
        Me.lbl_PNombreT.TabIndex = 94
        Me.lbl_PNombreT.Text = "Primer nombre:"
        '
        'lbl_SNombreT
        '
        Me.lbl_SNombreT.AutoSize = True
        Me.lbl_SNombreT.Location = New System.Drawing.Point(12, 93)
        Me.lbl_SNombreT.Name = "lbl_SNombreT"
        Me.lbl_SNombreT.Size = New System.Drawing.Size(105, 16)
        Me.lbl_SNombreT.TabIndex = 95
        Me.lbl_SNombreT.Text = "Segundo nombre:"
        '
        'lbl_CedulaT
        '
        Me.lbl_CedulaT.AutoSize = True
        Me.lbl_CedulaT.Location = New System.Drawing.Point(62, 41)
        Me.lbl_CedulaT.Name = "lbl_CedulaT"
        Me.lbl_CedulaT.Size = New System.Drawing.Size(52, 16)
        Me.lbl_CedulaT.TabIndex = 102
        Me.lbl_CedulaT.Text = "Cédula:"
        '
        'lbl_PApellidoT
        '
        Me.lbl_PApellidoT.AutoSize = True
        Me.lbl_PApellidoT.Location = New System.Drawing.Point(27, 120)
        Me.lbl_PApellidoT.Name = "lbl_PApellidoT"
        Me.lbl_PApellidoT.Size = New System.Drawing.Size(90, 16)
        Me.lbl_PApellidoT.TabIndex = 96
        Me.lbl_PApellidoT.Text = "Primer apellido:"
        '
        'txt_SApellidoT
        '
        Me.txt_SApellidoT.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_SApellidoT.Location = New System.Drawing.Point(119, 144)
        Me.txt_SApellidoT.MaxLength = 15
        Me.txt_SApellidoT.Name = "txt_SApellidoT"
        Me.txt_SApellidoT.Size = New System.Drawing.Size(139, 21)
        Me.txt_SApellidoT.TabIndex = 7
        '
        'lbl_SApellidoT
        '
        Me.lbl_SApellidoT.AutoSize = True
        Me.lbl_SApellidoT.Location = New System.Drawing.Point(10, 147)
        Me.lbl_SApellidoT.Name = "lbl_SApellidoT"
        Me.lbl_SApellidoT.Size = New System.Drawing.Size(107, 16)
        Me.lbl_SApellidoT.TabIndex = 97
        Me.lbl_SApellidoT.Text = "Segundo apellido:"
        '
        'txt_SNombreT
        '
        Me.txt_SNombreT.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_SNombreT.Location = New System.Drawing.Point(119, 93)
        Me.txt_SNombreT.MaxLength = 15
        Me.txt_SNombreT.Name = "txt_SNombreT"
        Me.txt_SNombreT.Size = New System.Drawing.Size(139, 21)
        Me.txt_SNombreT.TabIndex = 5
        '
        'txt_PNombreT
        '
        Me.txt_PNombreT.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_PNombreT.Location = New System.Drawing.Point(119, 66)
        Me.txt_PNombreT.MaxLength = 15
        Me.txt_PNombreT.Name = "txt_PNombreT"
        Me.txt_PNombreT.Size = New System.Drawing.Size(139, 21)
        Me.txt_PNombreT.TabIndex = 4
        '
        'txt_PApellidoT
        '
        Me.txt_PApellidoT.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_PApellidoT.Location = New System.Drawing.Point(119, 117)
        Me.txt_PApellidoT.MaxLength = 15
        Me.txt_PApellidoT.Name = "txt_PApellidoT"
        Me.txt_PApellidoT.Size = New System.Drawing.Size(139, 21)
        Me.txt_PApellidoT.TabIndex = 6
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fecha.Location = New System.Drawing.Point(610, 15)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Fecha.TabIndex = 131
        Me.lbl_Fecha.Text = "dd/MM/YY"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Usuario.Location = New System.Drawing.Point(681, 65)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Usuario.TabIndex = 130
        Me.lbl_Usuario.Text = "Usuario"
        '
        'lbl_EncabezadoSaludo
        '
        Me.lbl_EncabezadoSaludo.AutoSize = True
        Me.lbl_EncabezadoSaludo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoSaludo.Location = New System.Drawing.Point(640, 65)
        Me.lbl_EncabezadoSaludo.Name = "lbl_EncabezadoSaludo"
        Me.lbl_EncabezadoSaludo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_EncabezadoSaludo.TabIndex = 129
        Me.lbl_EncabezadoSaludo.Text = "Hola, "
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Hora.Location = New System.Drawing.Point(674, 15)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Hora.TabIndex = 128
        Me.lbl_Hora.Text = "00:00:00"
        '
        'lbl_EncabezadoFormuladio
        '
        Me.lbl_EncabezadoFormuladio.AutoSize = True
        Me.lbl_EncabezadoFormuladio.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoFormuladio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_EncabezadoFormuladio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoFormuladio.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_EncabezadoFormuladio.Location = New System.Drawing.Point(285, 100)
        Me.lbl_EncabezadoFormuladio.Name = "lbl_EncabezadoFormuladio"
        Me.lbl_EncabezadoFormuladio.Size = New System.Drawing.Size(204, 25)
        Me.lbl_EncabezadoFormuladio.TabIndex = 127
        Me.lbl_EncabezadoFormuladio.Text = "Gestión de Contrato"
        '
        'lbl_EncabezadoModulo
        '
        Me.lbl_EncabezadoModulo.AutoSize = True
        Me.lbl_EncabezadoModulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoModulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_EncabezadoModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoModulo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_EncabezadoModulo.Location = New System.Drawing.Point(293, 56)
        Me.lbl_EncabezadoModulo.Name = "lbl_EncabezadoModulo"
        Me.lbl_EncabezadoModulo.Size = New System.Drawing.Size(196, 25)
        Me.lbl_EncabezadoModulo.TabIndex = 126
        Me.lbl_EncabezadoModulo.Text = "Módulo de Servicio"
        '
        'lbl_EncabezadoEmpresa
        '
        Me.lbl_EncabezadoEmpresa.AutoSize = True
        Me.lbl_EncabezadoEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoEmpresa.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_EncabezadoEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_EncabezadoEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoEmpresa.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_EncabezadoEmpresa.Location = New System.Drawing.Point(251, 11)
        Me.lbl_EncabezadoEmpresa.Name = "lbl_EncabezadoEmpresa"
        Me.lbl_EncabezadoEmpresa.Size = New System.Drawing.Size(291, 29)
        Me.lbl_EncabezadoEmpresa.TabIndex = 125
        Me.lbl_EncabezadoEmpresa.Text = "SEGUROS MALDONADO"
        '
        'ptb_logo
        '
        Me.ptb_logo.BackColor = System.Drawing.Color.Transparent
        Me.ptb_logo.BackgroundImage = Global.SistemasIII.My.Resources.Resources.fondot
        Me.ptb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptb_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptb_logo.Location = New System.Drawing.Point(3, 1)
        Me.ptb_logo.Name = "ptb_logo"
        Me.ptb_logo.Size = New System.Drawing.Size(132, 132)
        Me.ptb_logo.TabIndex = 124
        Me.ptb_logo.TabStop = False
        Me.ptb_logo.UseWaitCursor = True
        '
        'frm_Contrato_Poliza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.SistemasIII.My.Resources.Resources.frm23
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(732, 733)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.lbl_EncabezadoSaludo)
        Me.Controls.Add(Me.lbl_Hora)
        Me.Controls.Add(Me.lbl_EncabezadoFormuladio)
        Me.Controls.Add(Me.lbl_EncabezadoModulo)
        Me.Controls.Add(Me.lbl_EncabezadoEmpresa)
        Me.Controls.Add(Me.ptb_logo)
        Me.Controls.Add(Me.btn_Anular)
        Me.Controls.Add(Me.btn_Volver)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.grb_Vehiculo)
        Me.Controls.Add(Me.grb_Poliza)
        Me.Controls.Add(Me.grb_Asegurado)
        Me.Controls.Add(Me.grb_Tomador)
        Me.Name = "frm_Contrato_Poliza"
        Me.Text = "Seguros Maldonado - Contrato de Póliza"
        Me.grb_Vehiculo.ResumeLayout(False)
        Me.grb_Vehiculo.PerformLayout()
        Me.grb_Poliza.ResumeLayout(False)
        Me.grb_Poliza.PerformLayout()
        Me.grb_Pagos.ResumeLayout(False)
        Me.grb_Pagos.PerformLayout()
        Me.grb_Asegurado.ResumeLayout(False)
        Me.grb_Asegurado.PerformLayout()
        Me.grb_Tomador.ResumeLayout(False)
        Me.grb_Tomador.PerformLayout()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Anular As Button
    Friend WithEvents btn_Volver As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Modificar As Button
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents grb_Vehiculo As GroupBox
    Friend WithEvents dtp_Año As DateTimePicker
    Friend WithEvents lbl_Marca As Label
    Friend WithEvents txt_Modelo As TextBox
    Friend WithEvents btn_BuscarP As Button
    Friend WithEvents lbl_Año As Label
    Friend WithEvents txt_Marca As TextBox
    Friend WithEvents lbl_Modelo As Label
    Friend WithEvents lbl_Placa As Label
    Friend WithEvents grb_Poliza As GroupBox
    Friend WithEvents ltb_PlanPago As ListBox
    Friend WithEvents lbl_PlanPago As Label
    Friend WithEvents lbl_Coberturas As Label
    Friend WithEvents ltb_TipoPoliza As ListBox
    Friend WithEvents lbl_TipoPoliza As Label
    Friend WithEvents lbl_FechaF As Label
    Friend WithEvents grb_Pagos As GroupBox
    Friend WithEvents dtp_FechaCobro As DateTimePicker
    Friend WithEvents lbl_FechaCobro As Label
    Friend WithEvents txt_MontoCuota As TextBox
    Friend WithEvents lbl_MontoCuota As Label
    Friend WithEvents txt_NCuotas As TextBox
    Friend WithEvents lbl_NCuotas As Label
    Friend WithEvents txt_MontoPagar As TextBox
    Friend WithEvents lbl_MontoPagar As Label
    Friend WithEvents txt_MontoBase As TextBox
    Friend WithEvents lbl_MontoBase As Label
    Friend WithEvents dtp_FechaF As DateTimePicker
    Friend WithEvents dtp_FechaI As DateTimePicker
    Friend WithEvents lbl_Fechai As Label
    Friend WithEvents btn_BuscarC As Button
    Friend WithEvents lbl_Codigo As Label
    Friend WithEvents grb_Asegurado As GroupBox
    Friend WithEvents btn_BuscarA As Button
    Friend WithEvents cmb_NacionalidadA As ComboBox
    Friend WithEvents lbl_PNombreA As Label
    Friend WithEvents lbl_SNombreA As Label
    Friend WithEvents lbl_CedulaA As Label
    Friend WithEvents lbl_PApellidoA As Label
    Friend WithEvents txt_SApellidoA As TextBox
    Friend WithEvents lbl_SApellidoA As Label
    Friend WithEvents txt_SNombreA As TextBox
    Friend WithEvents txt_PNombreA As TextBox
    Friend WithEvents txt_PApellidoA As TextBox
    Friend WithEvents grb_Tomador As GroupBox
    Friend WithEvents btn_BuscarT As Button
    Friend WithEvents cmb_NacionalidadT As ComboBox
    Friend WithEvents lbl_PNombreT As Label
    Friend WithEvents lbl_SNombreT As Label
    Friend WithEvents lbl_CedulaT As Label
    Friend WithEvents lbl_PApellidoT As Label
    Friend WithEvents txt_SApellidoT As TextBox
    Friend WithEvents lbl_SApellidoT As Label
    Friend WithEvents txt_SNombreT As TextBox
    Friend WithEvents txt_PNombreT As TextBox
    Friend WithEvents txt_PApellidoT As TextBox
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents lbl_EncabezadoSaludo As Label
    Friend WithEvents lbl_Hora As Label
    Friend WithEvents lbl_EncabezadoFormuladio As Label
    Friend WithEvents lbl_EncabezadoModulo As Label
    Friend WithEvents lbl_EncabezadoEmpresa As Label
    Friend WithEvents ptb_logo As PictureBox
    Friend WithEvents txt_Suma_asegurada As TextBox
    Friend WithEvents lbl_SumaAsegurada As Label
    Friend WithEvents cmb_Placa As ComboBox
    Friend WithEvents cmb_CodigoContrato As ComboBox
    Friend WithEvents cmb_CedulaA As ComboBox
    Friend WithEvents cmb_CedulaT As ComboBox
    Friend WithEvents ltb_cobertura As ListBox
    Friend WithEvents txt_Codigo As TextBox
End Class
