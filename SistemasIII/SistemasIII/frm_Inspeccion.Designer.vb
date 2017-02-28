<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Inspeccion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grb_Daño = New System.Windows.Forms.GroupBox()
        Me.btn_Añadir = New System.Windows.Forms.Button()
        Me.dgv_Daños = New System.Windows.Forms.DataGridView()
        Me.Daño1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Partedevehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_DescripcionDaños = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_ParteVehiculo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_Daño = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.grb_Vehiculo = New System.Windows.Forms.GroupBox()
        Me.txt_Año = New System.Windows.Forms.TextBox()
        Me.lbl_Marca = New System.Windows.Forms.Label()
        Me.txt_Modelo = New System.Windows.Forms.TextBox()
        Me.btn_BuscarP = New System.Windows.Forms.Button()
        Me.lbl_Año = New System.Windows.Forms.Label()
        Me.txt_Marca = New System.Windows.Forms.TextBox()
        Me.lbl_Modelo = New System.Windows.Forms.Label()
        Me.txt_Placa = New System.Windows.Forms.TextBox()
        Me.lbl_Placa = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoSaludo = New System.Windows.Forms.Label()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoFormuladio = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoModulo = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoEmpresa = New System.Windows.Forms.Label()
        Me.ptb_logo = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_Lugar = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Codigosiniestro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Codigopoliza = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_Tipoinspeccion = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grb_Inspeccion = New System.Windows.Forms.GroupBox()
        Me.txt_DescripcionInspeccion = New System.Windows.Forms.TextBox()
        Me.grb_Daño.SuspendLayout()
        CType(Me.dgv_Daños, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_Vehiculo.SuspendLayout()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_Inspeccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_Daño
        '
        Me.grb_Daño.Controls.Add(Me.btn_Añadir)
        Me.grb_Daño.Controls.Add(Me.dgv_Daños)
        Me.grb_Daño.Controls.Add(Me.txt_DescripcionDaños)
        Me.grb_Daño.Controls.Add(Me.Label11)
        Me.grb_Daño.Controls.Add(Me.cmb_ParteVehiculo)
        Me.grb_Daño.Controls.Add(Me.Label10)
        Me.grb_Daño.Controls.Add(Me.cmb_Daño)
        Me.grb_Daño.Controls.Add(Me.Label6)
        Me.grb_Daño.Controls.Add(Me.btn_Guardar)
        Me.grb_Daño.Controls.Add(Me.btn_Cancelar)
        Me.grb_Daño.Controls.Add(Me.btn_Salir)
        Me.grb_Daño.Location = New System.Drawing.Point(16, 441)
        Me.grb_Daño.Name = "grb_Daño"
        Me.grb_Daño.Size = New System.Drawing.Size(766, 265)
        Me.grb_Daño.TabIndex = 18
        Me.grb_Daño.TabStop = False
        Me.grb_Daño.Text = "Datos de daños"
        '
        'btn_Añadir
        '
        Me.btn_Añadir.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Añadir.Location = New System.Drawing.Point(645, 49)
        Me.btn_Añadir.Name = "btn_Añadir"
        Me.btn_Añadir.Size = New System.Drawing.Size(115, 23)
        Me.btn_Añadir.TabIndex = 19
        Me.btn_Añadir.Text = "Añadir"
        Me.btn_Añadir.UseVisualStyleBackColor = True
        '
        'dgv_Daños
        '
        Me.dgv_Daños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Daños.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Daño1, Me.Partedevehiculo, Me.Descripcion})
        Me.dgv_Daños.Location = New System.Drawing.Point(20, 82)
        Me.dgv_Daños.Name = "dgv_Daños"
        Me.dgv_Daños.Size = New System.Drawing.Size(608, 172)
        Me.dgv_Daños.TabIndex = 22
        '
        'Daño1
        '
        Me.Daño1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Daño1.HeaderText = "Daño"
        Me.Daño1.Name = "Daño1"
        Me.Daño1.ReadOnly = True
        Me.Daño1.Width = 130
        '
        'Partedevehiculo
        '
        Me.Partedevehiculo.HeaderText = "Parte de vehículo"
        Me.Partedevehiculo.Name = "Partedevehiculo"
        Me.Partedevehiculo.ReadOnly = True
        Me.Partedevehiculo.Width = 200
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 200
        '
        'txt_DescripcionDaños
        '
        Me.txt_DescripcionDaños.Location = New System.Drawing.Point(122, 49)
        Me.txt_DescripcionDaños.Name = "txt_DescripcionDaños"
        Me.txt_DescripcionDaños.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_DescripcionDaños.Size = New System.Drawing.Size(506, 20)
        Me.txt_DescripcionDaños.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 16)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Descripción:"
        '
        'cmb_ParteVehiculo
        '
        Me.cmb_ParteVehiculo.FormattingEnabled = True
        Me.cmb_ParteVehiculo.Location = New System.Drawing.Point(521, 14)
        Me.cmb_ParteVehiculo.Name = "cmb_ParteVehiculo"
        Me.cmb_ParteVehiculo.Size = New System.Drawing.Size(239, 21)
        Me.cmb_ParteVehiculo.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(408, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Parte del vehículo:"
        '
        'cmb_Daño
        '
        Me.cmb_Daño.FormattingEnabled = True
        Me.cmb_Daño.Location = New System.Drawing.Point(122, 14)
        Me.cmb_Daño.Name = "cmb_Daño"
        Me.cmb_Daño.Size = New System.Drawing.Size(269, 21)
        Me.cmb_Daño.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Daño:"
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Location = New System.Drawing.Point(645, 131)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(115, 27)
        Me.btn_Guardar.TabIndex = 29
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(645, 164)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(115, 27)
        Me.btn_Cancelar.TabIndex = 28
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Salir
        '
        Me.btn_Salir.Location = New System.Drawing.Point(645, 226)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(115, 27)
        Me.btn_Salir.TabIndex = 27
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.UseVisualStyleBackColor = True
        '
        'grb_Vehiculo
        '
        Me.grb_Vehiculo.Controls.Add(Me.txt_Año)
        Me.grb_Vehiculo.Controls.Add(Me.lbl_Marca)
        Me.grb_Vehiculo.Controls.Add(Me.txt_Modelo)
        Me.grb_Vehiculo.Controls.Add(Me.btn_BuscarP)
        Me.grb_Vehiculo.Controls.Add(Me.lbl_Año)
        Me.grb_Vehiculo.Controls.Add(Me.txt_Marca)
        Me.grb_Vehiculo.Controls.Add(Me.lbl_Modelo)
        Me.grb_Vehiculo.Controls.Add(Me.txt_Placa)
        Me.grb_Vehiculo.Controls.Add(Me.lbl_Placa)
        Me.grb_Vehiculo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Vehiculo.Location = New System.Drawing.Point(16, 178)
        Me.grb_Vehiculo.Name = "grb_Vehiculo"
        Me.grb_Vehiculo.Size = New System.Drawing.Size(766, 82)
        Me.grb_Vehiculo.TabIndex = 110
        Me.grb_Vehiculo.TabStop = False
        Me.grb_Vehiculo.Text = " Datos del vehículo"
        '
        'txt_Año
        '
        Me.txt_Año.Location = New System.Drawing.Point(468, 19)
        Me.txt_Año.Name = "txt_Año"
        Me.txt_Año.Size = New System.Drawing.Size(292, 21)
        Me.txt_Año.TabIndex = 109
        '
        'lbl_Marca
        '
        Me.lbl_Marca.AutoSize = True
        Me.lbl_Marca.Location = New System.Drawing.Point(34, 52)
        Me.lbl_Marca.Name = "lbl_Marca"
        Me.lbl_Marca.Size = New System.Drawing.Size(48, 16)
        Me.lbl_Marca.TabIndex = 108
        Me.lbl_Marca.Text = "Marca:"
        '
        'txt_Modelo
        '
        Me.txt_Modelo.Location = New System.Drawing.Point(468, 49)
        Me.txt_Modelo.Name = "txt_Modelo"
        Me.txt_Modelo.Size = New System.Drawing.Size(292, 21)
        Me.txt_Modelo.TabIndex = 107
        '
        'btn_BuscarP
        '
        Me.btn_BuscarP.Location = New System.Drawing.Point(287, 19)
        Me.btn_BuscarP.Name = "btn_BuscarP"
        Me.btn_BuscarP.Size = New System.Drawing.Size(75, 23)
        Me.btn_BuscarP.TabIndex = 106
        Me.btn_BuscarP.Text = "Buscar"
        Me.btn_BuscarP.UseVisualStyleBackColor = True
        '
        'lbl_Año
        '
        Me.lbl_Año.AutoSize = True
        Me.lbl_Año.Location = New System.Drawing.Point(430, 22)
        Me.lbl_Año.Name = "lbl_Año"
        Me.lbl_Año.Size = New System.Drawing.Size(32, 16)
        Me.lbl_Año.TabIndex = 13
        Me.lbl_Año.Text = "Año:"
        '
        'txt_Marca
        '
        Me.txt_Marca.Location = New System.Drawing.Point(92, 49)
        Me.txt_Marca.Name = "txt_Marca"
        Me.txt_Marca.Size = New System.Drawing.Size(270, 21)
        Me.txt_Marca.TabIndex = 12
        '
        'lbl_Modelo
        '
        Me.lbl_Modelo.AutoSize = True
        Me.lbl_Modelo.Location = New System.Drawing.Point(406, 49)
        Me.lbl_Modelo.Name = "lbl_Modelo"
        Me.lbl_Modelo.Size = New System.Drawing.Size(56, 16)
        Me.lbl_Modelo.TabIndex = 11
        Me.lbl_Modelo.Text = " Modelo:"
        '
        'txt_Placa
        '
        Me.txt_Placa.Location = New System.Drawing.Point(92, 19)
        Me.txt_Placa.Name = "txt_Placa"
        Me.txt_Placa.Size = New System.Drawing.Size(189, 21)
        Me.txt_Placa.TabIndex = 9
        '
        'lbl_Placa
        '
        Me.lbl_Placa.AutoSize = True
        Me.lbl_Placa.Location = New System.Drawing.Point(34, 22)
        Me.lbl_Placa.Name = "lbl_Placa"
        Me.lbl_Placa.Size = New System.Drawing.Size(46, 16)
        Me.lbl_Placa.TabIndex = 8
        Me.lbl_Placa.Text = " Placa:"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fecha.Location = New System.Drawing.Point(672, 20)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Fecha.TabIndex = 131
        Me.lbl_Fecha.Text = "dd/MM/YY"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Usuario.Location = New System.Drawing.Point(739, 53)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Usuario.TabIndex = 130
        Me.lbl_Usuario.Text = "Usuario"
        '
        'lbl_EncabezadoSaludo
        '
        Me.lbl_EncabezadoSaludo.AutoSize = True
        Me.lbl_EncabezadoSaludo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoSaludo.Location = New System.Drawing.Point(698, 53)
        Me.lbl_EncabezadoSaludo.Name = "lbl_EncabezadoSaludo"
        Me.lbl_EncabezadoSaludo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_EncabezadoSaludo.TabIndex = 129
        Me.lbl_EncabezadoSaludo.Text = "Hola, "
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Hora.Location = New System.Drawing.Point(736, 20)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Hora.TabIndex = 128
        Me.lbl_Hora.Text = "00:00:00"
        '
        'lbl_EncabezadoFormuladio
        '
        Me.lbl_EncabezadoFormuladio.AutoSize = True
        Me.lbl_EncabezadoFormuladio.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoFormuladio.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoFormuladio.Location = New System.Drawing.Point(311, 93)
        Me.lbl_EncabezadoFormuladio.Name = "lbl_EncabezadoFormuladio"
        Me.lbl_EncabezadoFormuladio.Size = New System.Drawing.Size(226, 24)
        Me.lbl_EncabezadoFormuladio.TabIndex = 127
        Me.lbl_EncabezadoFormuladio.Text = "Datos del Asegurado"
        '
        'lbl_EncabezadoModulo
        '
        Me.lbl_EncabezadoModulo.AutoSize = True
        Me.lbl_EncabezadoModulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoModulo.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoModulo.Location = New System.Drawing.Point(318, 53)
        Me.lbl_EncabezadoModulo.Name = "lbl_EncabezadoModulo"
        Me.lbl_EncabezadoModulo.Size = New System.Drawing.Size(206, 24)
        Me.lbl_EncabezadoModulo.TabIndex = 126
        Me.lbl_EncabezadoModulo.Text = "Módulo de Servicio"
        '
        'lbl_EncabezadoEmpresa
        '
        Me.lbl_EncabezadoEmpresa.AutoSize = True
        Me.lbl_EncabezadoEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoEmpresa.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_EncabezadoEmpresa.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoEmpresa.Location = New System.Drawing.Point(277, 12)
        Me.lbl_EncabezadoEmpresa.Name = "lbl_EncabezadoEmpresa"
        Me.lbl_EncabezadoEmpresa.Size = New System.Drawing.Size(294, 30)
        Me.lbl_EncabezadoEmpresa.TabIndex = 125
        Me.lbl_EncabezadoEmpresa.Text = "SEGUROS MALDONADO"
        '
        'ptb_logo
        '
        Me.ptb_logo.BackColor = System.Drawing.Color.Transparent
        Me.ptb_logo.BackgroundImage = Global.SistemasIII.My.Resources.Resources.fondot
        Me.ptb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptb_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptb_logo.Location = New System.Drawing.Point(23, -1)
        Me.ptb_logo.Name = "ptb_logo"
        Me.ptb_logo.Size = New System.Drawing.Size(132, 132)
        Me.ptb_logo.TabIndex = 124
        Me.ptb_logo.TabStop = False
        Me.ptb_logo.UseWaitCursor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(442, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 136
        Me.Label7.Text = "Descripción:"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.CustomFormat = """yyyy"""
        Me.dtp_Fecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtp_Fecha.Location = New System.Drawing.Point(144, 136)
        Me.dtp_Fecha.MinDate = New Date(1800, 2, 1, 0, 0, 0, 0)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(218, 20)
        Me.dtp_Fecha.TabIndex = 136
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 135
        Me.Label5.Text = "Fecha:"
        '
        'cmb_Lugar
        '
        Me.cmb_Lugar.FormattingEnabled = True
        Me.cmb_Lugar.Location = New System.Drawing.Point(144, 98)
        Me.cmb_Lugar.Name = "cmb_Lugar"
        Me.cmb_Lugar.Size = New System.Drawing.Size(218, 21)
        Me.cmb_Lugar.TabIndex = 142
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(98, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 141
        Me.Label4.Text = "Lugar:"
        '
        'txt_Codigosiniestro
        '
        Me.txt_Codigosiniestro.Location = New System.Drawing.Point(144, 65)
        Me.txt_Codigosiniestro.Name = "txt_Codigosiniestro"
        Me.txt_Codigosiniestro.Size = New System.Drawing.Size(218, 20)
        Me.txt_Codigosiniestro.TabIndex = 140
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "Código del Siniestro:"
        '
        'txt_Codigopoliza
        '
        Me.txt_Codigopoliza.Location = New System.Drawing.Point(514, 32)
        Me.txt_Codigopoliza.Name = "txt_Codigopoliza"
        Me.txt_Codigopoliza.Size = New System.Drawing.Size(246, 20)
        Me.txt_Codigopoliza.TabIndex = 138
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(408, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Código de la Póliza:"
        '
        'cmb_Tipoinspeccion
        '
        Me.cmb_Tipoinspeccion.FormattingEnabled = True
        Me.cmb_Tipoinspeccion.Location = New System.Drawing.Point(144, 31)
        Me.cmb_Tipoinspeccion.Name = "cmb_Tipoinspeccion"
        Me.cmb_Tipoinspeccion.Size = New System.Drawing.Size(218, 21)
        Me.cmb_Tipoinspeccion.TabIndex = 136
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Tipo de Inspección:"
        '
        'grb_Inspeccion
        '
        Me.grb_Inspeccion.Controls.Add(Me.txt_DescripcionInspeccion)
        Me.grb_Inspeccion.Controls.Add(Me.Label4)
        Me.grb_Inspeccion.Controls.Add(Me.Label7)
        Me.grb_Inspeccion.Controls.Add(Me.Label1)
        Me.grb_Inspeccion.Controls.Add(Me.dtp_Fecha)
        Me.grb_Inspeccion.Controls.Add(Me.cmb_Tipoinspeccion)
        Me.grb_Inspeccion.Controls.Add(Me.Label5)
        Me.grb_Inspeccion.Controls.Add(Me.Label2)
        Me.grb_Inspeccion.Controls.Add(Me.cmb_Lugar)
        Me.grb_Inspeccion.Controls.Add(Me.txt_Codigopoliza)
        Me.grb_Inspeccion.Controls.Add(Me.Label3)
        Me.grb_Inspeccion.Controls.Add(Me.txt_Codigosiniestro)
        Me.grb_Inspeccion.Location = New System.Drawing.Point(16, 268)
        Me.grb_Inspeccion.Name = "grb_Inspeccion"
        Me.grb_Inspeccion.Size = New System.Drawing.Size(766, 167)
        Me.grb_Inspeccion.TabIndex = 135
        Me.grb_Inspeccion.TabStop = False
        Me.grb_Inspeccion.Text = "Datos de Inspección"
        '
        'txt_DescripcionInspeccion
        '
        Me.txt_DescripcionInspeccion.Location = New System.Drawing.Point(514, 65)
        Me.txt_DescripcionInspeccion.Multiline = True
        Me.txt_DescripcionInspeccion.Name = "txt_DescripcionInspeccion"
        Me.txt_DescripcionInspeccion.Size = New System.Drawing.Size(246, 91)
        Me.txt_DescripcionInspeccion.TabIndex = 143
        '
        'frm_Inspeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.SistemasIII.My.Resources.Resources.frm23
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 711)
        Me.Controls.Add(Me.grb_Inspeccion)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.lbl_EncabezadoSaludo)
        Me.Controls.Add(Me.lbl_Hora)
        Me.Controls.Add(Me.lbl_EncabezadoFormuladio)
        Me.Controls.Add(Me.lbl_EncabezadoModulo)
        Me.Controls.Add(Me.lbl_EncabezadoEmpresa)
        Me.Controls.Add(Me.ptb_logo)
        Me.Controls.Add(Me.grb_Vehiculo)
        Me.Controls.Add(Me.grb_Daño)
        Me.Name = "frm_Inspeccion"
        Me.Text = "Seguros Maldonado-Inspección"
        Me.grb_Daño.ResumeLayout(False)
        Me.grb_Daño.PerformLayout()
        CType(Me.dgv_Daños, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_Vehiculo.ResumeLayout(False)
        Me.grb_Vehiculo.PerformLayout()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_Inspeccion.ResumeLayout(False)
        Me.grb_Inspeccion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grb_Daño As System.Windows.Forms.GroupBox
    Friend WithEvents txt_DescripcionDaños As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmb_ParteVehiculo As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmb_Daño As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgv_Daños As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Añadir As System.Windows.Forms.Button
    Friend WithEvents Daño1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Partedevehiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents grb_Vehiculo As GroupBox
    Friend WithEvents lbl_Marca As Label
    Friend WithEvents txt_Modelo As TextBox
    Friend WithEvents btn_BuscarP As Button
    Friend WithEvents lbl_Año As Label
    Friend WithEvents txt_Marca As TextBox
    Friend WithEvents lbl_Modelo As Label
    Friend WithEvents txt_Placa As TextBox
    Friend WithEvents lbl_Placa As Label
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents lbl_EncabezadoSaludo As Label
    Friend WithEvents lbl_Hora As Label
    Friend WithEvents lbl_EncabezadoFormuladio As Label
    Friend WithEvents lbl_EncabezadoModulo As Label
    Friend WithEvents lbl_EncabezadoEmpresa As Label
    Friend WithEvents ptb_logo As PictureBox
    Friend WithEvents txt_Codigosiniestro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Codigopoliza As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_Tipoinspeccion As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_Lugar As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtp_Fecha As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents grb_Inspeccion As GroupBox
    Friend WithEvents txt_Año As TextBox
    Friend WithEvents txt_DescripcionInspeccion As TextBox
End Class
