<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoSaludo = New System.Windows.Forms.Label()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoFormuladio = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoModulo = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoEmpresa = New System.Windows.Forms.Label()
        Me.ptb_logo = New System.Windows.Forms.PictureBox()
        Me.grb_Datos_Vehículo = New System.Windows.Forms.GroupBox()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.txt_Modelo = New System.Windows.Forms.TextBox()
        Me.txt_Año = New System.Windows.Forms.TextBox()
        Me.txt_Marca = New System.Windows.Forms.TextBox()
        Me.txt_Placa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_Modelo = New System.Windows.Forms.Label()
        Me.lbl_Placa = New System.Windows.Forms.Label()
        Me.grb_Datos_Inspección = New System.Windows.Forms.GroupBox()
        Me.txt_Descripcion_inspeccion = New System.Windows.Forms.TextBox()
        Me.txt_Codigo_poliza_inspeccion = New System.Windows.Forms.TextBox()
        Me.lbl_Descripcion_inspeccion = New System.Windows.Forms.Label()
        Me.dtp_Fecha_Inspeccion = New System.Windows.Forms.DateTimePicker()
        Me.cmb_Lugar_inspeccion = New System.Windows.Forms.ComboBox()
        Me.cmb_Tipo_inspeccion = New System.Windows.Forms.ComboBox()
        Me.txt_Codigo_siniestro = New System.Windows.Forms.TextBox()
        Me.lbl_Codigo_siniestro = New System.Windows.Forms.Label()
        Me.lbl_Lugar = New System.Windows.Forms.Label()
        Me.lbl_fecha_inspeccion = New System.Windows.Forms.Label()
        Me.lbl_Codigo_Poliza = New System.Windows.Forms.Label()
        Me.lbl_Tipo_inspeccion = New System.Windows.Forms.Label()
        Me.grb_Datos_Daño = New System.Windows.Forms.GroupBox()
        Me.dgv_tabla_daño_daños = New System.Windows.Forms.DataGridView()
        Me.cl_Daño = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_Parte_Vehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_volver_daño_daños = New System.Windows.Forms.Button()
        Me.btn_guardar_daño_daños = New System.Windows.Forms.Button()
        Me.btn_cancelar_daño_daños = New System.Windows.Forms.Button()
        Me.btn_añadir_daño_daños = New System.Windows.Forms.Button()
        Me.lbl_Parte_vehiculo_daños = New System.Windows.Forms.Label()
        Me.cmb_Parte_vehiculo_daños = New System.Windows.Forms.ComboBox()
        Me.txt_descripcion_daño_daños = New System.Windows.Forms.TextBox()
        Me.lbl_Descripcion_daños = New System.Windows.Forms.Label()
        Me.lbl_daño_daños = New System.Windows.Forms.Label()
        Me.cmb_daño_daños = New System.Windows.Forms.ComboBox()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_Datos_Vehículo.SuspendLayout()
        Me.grb_Datos_Inspección.SuspendLayout()
        Me.grb_Datos_Daño.SuspendLayout()
        CType(Me.dgv_tabla_daño_daños, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fecha.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(660, 13)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(70, 16)
        Me.lbl_Fecha.TabIndex = 147
        Me.lbl_Fecha.Text = "dd/MM/YY"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Usuario.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Usuario.Location = New System.Drawing.Point(739, 42)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(47, 16)
        Me.lbl_Usuario.TabIndex = 146
        Me.lbl_Usuario.Text = "Usuario"
        '
        'lbl_EncabezadoSaludo
        '
        Me.lbl_EncabezadoSaludo.AutoSize = True
        Me.lbl_EncabezadoSaludo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoSaludo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoSaludo.Location = New System.Drawing.Point(698, 42)
        Me.lbl_EncabezadoSaludo.Name = "lbl_EncabezadoSaludo"
        Me.lbl_EncabezadoSaludo.Size = New System.Drawing.Size(39, 16)
        Me.lbl_EncabezadoSaludo.TabIndex = 145
        Me.lbl_EncabezadoSaludo.Text = "Hola, "
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Hora.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Hora.Location = New System.Drawing.Point(736, 14)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(50, 16)
        Me.lbl_Hora.TabIndex = 144
        Me.lbl_Hora.Text = "00:00:00"
        '
        'lbl_EncabezadoFormuladio
        '
        Me.lbl_EncabezadoFormuladio.AutoSize = True
        Me.lbl_EncabezadoFormuladio.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoFormuladio.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoFormuladio.Location = New System.Drawing.Point(287, 92)
        Me.lbl_EncabezadoFormuladio.Name = "lbl_EncabezadoFormuladio"
        Me.lbl_EncabezadoFormuladio.Size = New System.Drawing.Size(226, 24)
        Me.lbl_EncabezadoFormuladio.TabIndex = 143
        Me.lbl_EncabezadoFormuladio.Text = "Datos del Asegurado"
        '
        'lbl_EncabezadoModulo
        '
        Me.lbl_EncabezadoModulo.AutoSize = True
        Me.lbl_EncabezadoModulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoModulo.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoModulo.Location = New System.Drawing.Point(298, 55)
        Me.lbl_EncabezadoModulo.Name = "lbl_EncabezadoModulo"
        Me.lbl_EncabezadoModulo.Size = New System.Drawing.Size(206, 24)
        Me.lbl_EncabezadoModulo.TabIndex = 142
        Me.lbl_EncabezadoModulo.Text = "Módulo de Servicio"
        '
        'lbl_EncabezadoEmpresa
        '
        Me.lbl_EncabezadoEmpresa.AutoSize = True
        Me.lbl_EncabezadoEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoEmpresa.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_EncabezadoEmpresa.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoEmpresa.Location = New System.Drawing.Point(256, 14)
        Me.lbl_EncabezadoEmpresa.Name = "lbl_EncabezadoEmpresa"
        Me.lbl_EncabezadoEmpresa.Size = New System.Drawing.Size(294, 30)
        Me.lbl_EncabezadoEmpresa.TabIndex = 141
        Me.lbl_EncabezadoEmpresa.Text = "SEGUROS MALDONADO"
        '
        'ptb_logo
        '
        Me.ptb_logo.BackColor = System.Drawing.Color.Transparent
        Me.ptb_logo.BackgroundImage = Global.SistemasIII.My.Resources.Resources.fondot
        Me.ptb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptb_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptb_logo.Location = New System.Drawing.Point(12, 1)
        Me.ptb_logo.Name = "ptb_logo"
        Me.ptb_logo.Size = New System.Drawing.Size(132, 132)
        Me.ptb_logo.TabIndex = 140
        Me.ptb_logo.TabStop = False
        Me.ptb_logo.UseWaitCursor = True
        '
        'grb_Datos_Vehículo
        '
        Me.grb_Datos_Vehículo.Controls.Add(Me.btn_Buscar)
        Me.grb_Datos_Vehículo.Controls.Add(Me.txt_Modelo)
        Me.grb_Datos_Vehículo.Controls.Add(Me.txt_Año)
        Me.grb_Datos_Vehículo.Controls.Add(Me.txt_Marca)
        Me.grb_Datos_Vehículo.Controls.Add(Me.txt_Placa)
        Me.grb_Datos_Vehículo.Controls.Add(Me.Label4)
        Me.grb_Datos_Vehículo.Controls.Add(Me.Label3)
        Me.grb_Datos_Vehículo.Controls.Add(Me.lbl_Modelo)
        Me.grb_Datos_Vehículo.Controls.Add(Me.lbl_Placa)
        Me.grb_Datos_Vehículo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Datos_Vehículo.Location = New System.Drawing.Point(12, 159)
        Me.grb_Datos_Vehículo.Name = "grb_Datos_Vehículo"
        Me.grb_Datos_Vehículo.Size = New System.Drawing.Size(773, 82)
        Me.grb_Datos_Vehículo.TabIndex = 149
        Me.grb_Datos_Vehículo.TabStop = False
        Me.grb_Datos_Vehículo.Text = "Datos del vehículo"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Location = New System.Drawing.Point(276, 21)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(99, 23)
        Me.btn_Buscar.TabIndex = 8
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'txt_Modelo
        '
        Me.txt_Modelo.Location = New System.Drawing.Point(450, 52)
        Me.txt_Modelo.Name = "txt_Modelo"
        Me.txt_Modelo.Size = New System.Drawing.Size(317, 21)
        Me.txt_Modelo.TabIndex = 7
        '
        'txt_Año
        '
        Me.txt_Año.Location = New System.Drawing.Point(450, 16)
        Me.txt_Año.Name = "txt_Año"
        Me.txt_Año.Size = New System.Drawing.Size(317, 21)
        Me.txt_Año.TabIndex = 6
        '
        'txt_Marca
        '
        Me.txt_Marca.Location = New System.Drawing.Point(86, 52)
        Me.txt_Marca.Name = "txt_Marca"
        Me.txt_Marca.Size = New System.Drawing.Size(289, 21)
        Me.txt_Marca.TabIndex = 5
        '
        'txt_Placa
        '
        Me.txt_Placa.Location = New System.Drawing.Point(86, 21)
        Me.txt_Placa.Name = "txt_Placa"
        Me.txt_Placa.Size = New System.Drawing.Size(184, 21)
        Me.txt_Placa.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Marca:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(412, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Año:"
        '
        'lbl_Modelo
        '
        Me.lbl_Modelo.AutoSize = True
        Me.lbl_Modelo.Location = New System.Drawing.Point(391, 55)
        Me.lbl_Modelo.Name = "lbl_Modelo"
        Me.lbl_Modelo.Size = New System.Drawing.Size(53, 16)
        Me.lbl_Modelo.TabIndex = 1
        Me.lbl_Modelo.Text = "Modelo:"
        '
        'lbl_Placa
        '
        Me.lbl_Placa.AutoSize = True
        Me.lbl_Placa.Location = New System.Drawing.Point(37, 21)
        Me.lbl_Placa.Name = "lbl_Placa"
        Me.lbl_Placa.Size = New System.Drawing.Size(43, 16)
        Me.lbl_Placa.TabIndex = 0
        Me.lbl_Placa.Text = "Placa:"
        '
        'grb_Datos_Inspección
        '
        Me.grb_Datos_Inspección.Controls.Add(Me.txt_Descripcion_inspeccion)
        Me.grb_Datos_Inspección.Controls.Add(Me.txt_Codigo_poliza_inspeccion)
        Me.grb_Datos_Inspección.Controls.Add(Me.lbl_Descripcion_inspeccion)
        Me.grb_Datos_Inspección.Controls.Add(Me.dtp_Fecha_Inspeccion)
        Me.grb_Datos_Inspección.Controls.Add(Me.cmb_Lugar_inspeccion)
        Me.grb_Datos_Inspección.Controls.Add(Me.cmb_Tipo_inspeccion)
        Me.grb_Datos_Inspección.Controls.Add(Me.txt_Codigo_siniestro)
        Me.grb_Datos_Inspección.Controls.Add(Me.lbl_Codigo_siniestro)
        Me.grb_Datos_Inspección.Controls.Add(Me.lbl_Lugar)
        Me.grb_Datos_Inspección.Controls.Add(Me.lbl_fecha_inspeccion)
        Me.grb_Datos_Inspección.Controls.Add(Me.lbl_Codigo_Poliza)
        Me.grb_Datos_Inspección.Controls.Add(Me.lbl_Tipo_inspeccion)
        Me.grb_Datos_Inspección.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Datos_Inspección.Location = New System.Drawing.Point(12, 243)
        Me.grb_Datos_Inspección.Name = "grb_Datos_Inspección"
        Me.grb_Datos_Inspección.Size = New System.Drawing.Size(773, 139)
        Me.grb_Datos_Inspección.TabIndex = 150
        Me.grb_Datos_Inspección.TabStop = False
        Me.grb_Datos_Inspección.Text = "Datos de inspección"
        '
        'txt_Descripcion_inspeccion
        '
        Me.txt_Descripcion_inspeccion.Location = New System.Drawing.Point(519, 51)
        Me.txt_Descripcion_inspeccion.Multiline = True
        Me.txt_Descripcion_inspeccion.Name = "txt_Descripcion_inspeccion"
        Me.txt_Descripcion_inspeccion.Size = New System.Drawing.Size(248, 77)
        Me.txt_Descripcion_inspeccion.TabIndex = 19
        '
        'txt_Codigo_poliza_inspeccion
        '
        Me.txt_Codigo_poliza_inspeccion.Location = New System.Drawing.Point(519, 22)
        Me.txt_Codigo_poliza_inspeccion.Name = "txt_Codigo_poliza_inspeccion"
        Me.txt_Codigo_poliza_inspeccion.Size = New System.Drawing.Size(248, 21)
        Me.txt_Codigo_poliza_inspeccion.TabIndex = 18
        '
        'lbl_Descripcion_inspeccion
        '
        Me.lbl_Descripcion_inspeccion.AutoSize = True
        Me.lbl_Descripcion_inspeccion.Location = New System.Drawing.Point(440, 48)
        Me.lbl_Descripcion_inspeccion.Name = "lbl_Descripcion_inspeccion"
        Me.lbl_Descripcion_inspeccion.Size = New System.Drawing.Size(73, 16)
        Me.lbl_Descripcion_inspeccion.TabIndex = 17
        Me.lbl_Descripcion_inspeccion.Text = "Descripción:"
        '
        'dtp_Fecha_Inspeccion
        '
        Me.dtp_Fecha_Inspeccion.Location = New System.Drawing.Point(150, 107)
        Me.dtp_Fecha_Inspeccion.Name = "dtp_Fecha_Inspeccion"
        Me.dtp_Fecha_Inspeccion.Size = New System.Drawing.Size(225, 21)
        Me.dtp_Fecha_Inspeccion.TabIndex = 16
        '
        'cmb_Lugar_inspeccion
        '
        Me.cmb_Lugar_inspeccion.FormattingEnabled = True
        Me.cmb_Lugar_inspeccion.Location = New System.Drawing.Point(150, 77)
        Me.cmb_Lugar_inspeccion.Name = "cmb_Lugar_inspeccion"
        Me.cmb_Lugar_inspeccion.Size = New System.Drawing.Size(225, 24)
        Me.cmb_Lugar_inspeccion.TabIndex = 15
        '
        'cmb_Tipo_inspeccion
        '
        Me.cmb_Tipo_inspeccion.FormattingEnabled = True
        Me.cmb_Tipo_inspeccion.Location = New System.Drawing.Point(150, 19)
        Me.cmb_Tipo_inspeccion.Name = "cmb_Tipo_inspeccion"
        Me.cmb_Tipo_inspeccion.Size = New System.Drawing.Size(225, 24)
        Me.cmb_Tipo_inspeccion.TabIndex = 14
        '
        'txt_Codigo_siniestro
        '
        Me.txt_Codigo_siniestro.Location = New System.Drawing.Point(150, 48)
        Me.txt_Codigo_siniestro.Name = "txt_Codigo_siniestro"
        Me.txt_Codigo_siniestro.Size = New System.Drawing.Size(225, 21)
        Me.txt_Codigo_siniestro.TabIndex = 9
        '
        'lbl_Codigo_siniestro
        '
        Me.lbl_Codigo_siniestro.AutoSize = True
        Me.lbl_Codigo_siniestro.Location = New System.Drawing.Point(30, 51)
        Me.lbl_Codigo_siniestro.Name = "lbl_Codigo_siniestro"
        Me.lbl_Codigo_siniestro.Size = New System.Drawing.Size(114, 16)
        Me.lbl_Codigo_siniestro.TabIndex = 13
        Me.lbl_Codigo_siniestro.Text = "Código del siniestro:"
        '
        'lbl_Lugar
        '
        Me.lbl_Lugar.AutoSize = True
        Me.lbl_Lugar.Location = New System.Drawing.Point(103, 77)
        Me.lbl_Lugar.Name = "lbl_Lugar"
        Me.lbl_Lugar.Size = New System.Drawing.Size(41, 16)
        Me.lbl_Lugar.TabIndex = 12
        Me.lbl_Lugar.Text = "Lugar:"
        '
        'lbl_fecha_inspeccion
        '
        Me.lbl_fecha_inspeccion.AutoSize = True
        Me.lbl_fecha_inspeccion.Location = New System.Drawing.Point(99, 107)
        Me.lbl_fecha_inspeccion.Name = "lbl_fecha_inspeccion"
        Me.lbl_fecha_inspeccion.Size = New System.Drawing.Size(45, 16)
        Me.lbl_fecha_inspeccion.TabIndex = 11
        Me.lbl_fecha_inspeccion.Text = "Fecha:"
        '
        'lbl_Codigo_Poliza
        '
        Me.lbl_Codigo_Poliza.AutoSize = True
        Me.lbl_Codigo_Poliza.Location = New System.Drawing.Point(396, 22)
        Me.lbl_Codigo_Poliza.Name = "lbl_Codigo_Poliza"
        Me.lbl_Codigo_Poliza.Size = New System.Drawing.Size(117, 16)
        Me.lbl_Codigo_Poliza.TabIndex = 10
        Me.lbl_Codigo_Poliza.Text = "Código de la póliza:"
        '
        'lbl_Tipo_inspeccion
        '
        Me.lbl_Tipo_inspeccion.AutoSize = True
        Me.lbl_Tipo_inspeccion.Location = New System.Drawing.Point(32, 22)
        Me.lbl_Tipo_inspeccion.Name = "lbl_Tipo_inspeccion"
        Me.lbl_Tipo_inspeccion.Size = New System.Drawing.Size(112, 16)
        Me.lbl_Tipo_inspeccion.TabIndex = 9
        Me.lbl_Tipo_inspeccion.Text = "Tipo de inspección:"
        '
        'grb_Datos_Daño
        '
        Me.grb_Datos_Daño.Controls.Add(Me.dgv_tabla_daño_daños)
        Me.grb_Datos_Daño.Controls.Add(Me.btn_volver_daño_daños)
        Me.grb_Datos_Daño.Controls.Add(Me.btn_guardar_daño_daños)
        Me.grb_Datos_Daño.Controls.Add(Me.btn_cancelar_daño_daños)
        Me.grb_Datos_Daño.Controls.Add(Me.btn_añadir_daño_daños)
        Me.grb_Datos_Daño.Controls.Add(Me.lbl_Parte_vehiculo_daños)
        Me.grb_Datos_Daño.Controls.Add(Me.cmb_Parte_vehiculo_daños)
        Me.grb_Datos_Daño.Controls.Add(Me.txt_descripcion_daño_daños)
        Me.grb_Datos_Daño.Controls.Add(Me.lbl_Descripcion_daños)
        Me.grb_Datos_Daño.Controls.Add(Me.lbl_daño_daños)
        Me.grb_Datos_Daño.Controls.Add(Me.cmb_daño_daños)
        Me.grb_Datos_Daño.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Datos_Daño.Location = New System.Drawing.Point(12, 380)
        Me.grb_Datos_Daño.Name = "grb_Datos_Daño"
        Me.grb_Datos_Daño.Size = New System.Drawing.Size(773, 315)
        Me.grb_Datos_Daño.TabIndex = 151
        Me.grb_Datos_Daño.TabStop = False
        Me.grb_Datos_Daño.Text = "Datos de daños"
        '
        'dgv_tabla_daño_daños
        '
        Me.dgv_tabla_daño_daños.AllowUserToAddRows = False
        Me.dgv_tabla_daño_daños.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_tabla_daño_daños.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_tabla_daño_daños.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv_tabla_daño_daños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tabla_daño_daños.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cl_Daño, Me.cl_Parte_Vehiculo, Me.cl_Descripción})
        Me.dgv_tabla_daño_daños.Location = New System.Drawing.Point(6, 88)
        Me.dgv_tabla_daño_daños.Name = "dgv_tabla_daño_daños"
        Me.dgv_tabla_daño_daños.RowHeadersVisible = False
        Me.dgv_tabla_daño_daños.Size = New System.Drawing.Size(604, 217)
        Me.dgv_tabla_daño_daños.TabIndex = 27
        '
        'cl_Daño
        '
        Me.cl_Daño.HeaderText = "Daño"
        Me.cl_Daño.Name = "cl_Daño"
        Me.cl_Daño.ReadOnly = True
        '
        'cl_Parte_Vehiculo
        '
        Me.cl_Parte_Vehiculo.HeaderText = "Parte de Vehículo"
        Me.cl_Parte_Vehiculo.Name = "cl_Parte_Vehiculo"
        Me.cl_Parte_Vehiculo.ReadOnly = True
        '
        'cl_Descripción
        '
        Me.cl_Descripción.HeaderText = "Descripción"
        Me.cl_Descripción.Name = "cl_Descripción"
        Me.cl_Descripción.ReadOnly = True
        '
        'btn_volver_daño_daños
        '
        Me.btn_volver_daño_daños.Location = New System.Drawing.Point(616, 281)
        Me.btn_volver_daño_daños.Name = "btn_volver_daño_daños"
        Me.btn_volver_daño_daños.Size = New System.Drawing.Size(151, 23)
        Me.btn_volver_daño_daños.TabIndex = 26
        Me.btn_volver_daño_daños.Text = "Volver"
        Me.btn_volver_daño_daños.UseVisualStyleBackColor = True
        '
        'btn_guardar_daño_daños
        '
        Me.btn_guardar_daño_daños.Location = New System.Drawing.Point(616, 150)
        Me.btn_guardar_daño_daños.Name = "btn_guardar_daño_daños"
        Me.btn_guardar_daño_daños.Size = New System.Drawing.Size(151, 23)
        Me.btn_guardar_daño_daños.TabIndex = 25
        Me.btn_guardar_daño_daños.Text = "Guardar"
        Me.btn_guardar_daño_daños.UseVisualStyleBackColor = True
        '
        'btn_cancelar_daño_daños
        '
        Me.btn_cancelar_daño_daños.Location = New System.Drawing.Point(616, 179)
        Me.btn_cancelar_daño_daños.Name = "btn_cancelar_daño_daños"
        Me.btn_cancelar_daño_daños.Size = New System.Drawing.Size(151, 23)
        Me.btn_cancelar_daño_daños.TabIndex = 24
        Me.btn_cancelar_daño_daños.Text = "Cancelar"
        Me.btn_cancelar_daño_daños.UseVisualStyleBackColor = True
        '
        'btn_añadir_daño_daños
        '
        Me.btn_añadir_daño_daños.Location = New System.Drawing.Point(616, 56)
        Me.btn_añadir_daño_daños.Name = "btn_añadir_daño_daños"
        Me.btn_añadir_daño_daños.Size = New System.Drawing.Size(151, 23)
        Me.btn_añadir_daño_daños.TabIndex = 9
        Me.btn_añadir_daño_daños.Text = "Añadir"
        Me.btn_añadir_daño_daños.UseVisualStyleBackColor = True
        '
        'lbl_Parte_vehiculo_daños
        '
        Me.lbl_Parte_vehiculo_daños.AutoSize = True
        Me.lbl_Parte_vehiculo_daños.Location = New System.Drawing.Point(325, 24)
        Me.lbl_Parte_vehiculo_daños.Name = "lbl_Parte_vehiculo_daños"
        Me.lbl_Parte_vehiculo_daños.Size = New System.Drawing.Size(108, 16)
        Me.lbl_Parte_vehiculo_daños.TabIndex = 22
        Me.lbl_Parte_vehiculo_daños.Text = "Parte de vehículo:"
        '
        'cmb_Parte_vehiculo_daños
        '
        Me.cmb_Parte_vehiculo_daños.FormattingEnabled = True
        Me.cmb_Parte_vehiculo_daños.Location = New System.Drawing.Point(439, 21)
        Me.cmb_Parte_vehiculo_daños.Name = "cmb_Parte_vehiculo_daños"
        Me.cmb_Parte_vehiculo_daños.Size = New System.Drawing.Size(328, 24)
        Me.cmb_Parte_vehiculo_daños.TabIndex = 23
        '
        'txt_descripcion_daño_daños
        '
        Me.txt_descripcion_daño_daños.Location = New System.Drawing.Point(89, 56)
        Me.txt_descripcion_daño_daños.Name = "txt_descripcion_daño_daños"
        Me.txt_descripcion_daño_daños.Size = New System.Drawing.Size(521, 21)
        Me.txt_descripcion_daño_daños.TabIndex = 20
        '
        'lbl_Descripcion_daños
        '
        Me.lbl_Descripcion_daños.AutoSize = True
        Me.lbl_Descripcion_daños.Location = New System.Drawing.Point(6, 59)
        Me.lbl_Descripcion_daños.Name = "lbl_Descripcion_daños"
        Me.lbl_Descripcion_daños.Size = New System.Drawing.Size(73, 16)
        Me.lbl_Descripcion_daños.TabIndex = 21
        Me.lbl_Descripcion_daños.Text = "Descripción:"
        '
        'lbl_daño_daños
        '
        Me.lbl_daño_daños.AutoSize = True
        Me.lbl_daño_daños.Location = New System.Drawing.Point(39, 24)
        Me.lbl_daño_daños.Name = "lbl_daño_daños"
        Me.lbl_daño_daños.Size = New System.Drawing.Size(41, 16)
        Me.lbl_daño_daños.TabIndex = 20
        Me.lbl_daño_daños.Text = "Daño:"
        '
        'cmb_daño_daños
        '
        Me.cmb_daño_daños.FormattingEnabled = True
        Me.cmb_daño_daños.Location = New System.Drawing.Point(90, 21)
        Me.cmb_daño_daños.Name = "cmb_daño_daños"
        Me.cmb_daño_daños.Size = New System.Drawing.Size(225, 24)
        Me.cmb_daño_daños.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.SistemasIII.My.Resources.Resources.frm23
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(797, 697)
        Me.Controls.Add(Me.grb_Datos_Daño)
        Me.Controls.Add(Me.grb_Datos_Inspección)
        Me.Controls.Add(Me.grb_Datos_Vehículo)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.lbl_EncabezadoSaludo)
        Me.Controls.Add(Me.lbl_Hora)
        Me.Controls.Add(Me.lbl_EncabezadoFormuladio)
        Me.Controls.Add(Me.lbl_EncabezadoModulo)
        Me.Controls.Add(Me.lbl_EncabezadoEmpresa)
        Me.Controls.Add(Me.ptb_logo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_Datos_Vehículo.ResumeLayout(False)
        Me.grb_Datos_Vehículo.PerformLayout()
        Me.grb_Datos_Inspección.ResumeLayout(False)
        Me.grb_Datos_Inspección.PerformLayout()
        Me.grb_Datos_Daño.ResumeLayout(False)
        Me.grb_Datos_Daño.PerformLayout()
        CType(Me.dgv_tabla_daño_daños, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents lbl_EncabezadoSaludo As Label
    Friend WithEvents lbl_Hora As Label
    Friend WithEvents lbl_EncabezadoFormuladio As Label
    Friend WithEvents lbl_EncabezadoModulo As Label
    Friend WithEvents lbl_EncabezadoEmpresa As Label
    Friend WithEvents ptb_logo As PictureBox
    Friend WithEvents grb_Datos_Vehículo As GroupBox
    Friend WithEvents grb_Datos_Inspección As GroupBox
    Friend WithEvents grb_Datos_Daño As GroupBox
    Friend WithEvents txt_Modelo As TextBox
    Friend WithEvents txt_Año As TextBox
    Friend WithEvents txt_Marca As TextBox
    Friend WithEvents txt_Placa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_Modelo As Label
    Friend WithEvents lbl_Placa As Label
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents dtp_Fecha_Inspeccion As DateTimePicker
    Friend WithEvents cmb_Lugar_inspeccion As ComboBox
    Friend WithEvents cmb_Tipo_inspeccion As ComboBox
    Friend WithEvents txt_Codigo_siniestro As TextBox
    Friend WithEvents lbl_Codigo_siniestro As Label
    Friend WithEvents lbl_Lugar As Label
    Friend WithEvents lbl_fecha_inspeccion As Label
    Friend WithEvents lbl_Codigo_Poliza As Label
    Friend WithEvents lbl_Tipo_inspeccion As Label
    Friend WithEvents txt_Descripcion_inspeccion As TextBox
    Friend WithEvents txt_Codigo_poliza_inspeccion As TextBox
    Friend WithEvents lbl_Descripcion_inspeccion As Label
    Friend WithEvents dgv_tabla_daño_daños As DataGridView
    Friend WithEvents cl_Daño As DataGridViewTextBoxColumn
    Friend WithEvents cl_Parte_Vehiculo As DataGridViewTextBoxColumn
    Friend WithEvents cl_Descripción As DataGridViewTextBoxColumn
    Friend WithEvents btn_volver_daño_daños As Button
    Friend WithEvents btn_guardar_daño_daños As Button
    Friend WithEvents btn_cancelar_daño_daños As Button
    Friend WithEvents btn_añadir_daño_daños As Button
    Friend WithEvents lbl_Parte_vehiculo_daños As Label
    Friend WithEvents cmb_Parte_vehiculo_daños As ComboBox
    Friend WithEvents txt_descripcion_daño_daños As TextBox
    Friend WithEvents lbl_Descripcion_daños As Label
    Friend WithEvents lbl_daño_daños As Label
    Friend WithEvents cmb_daño_daños As ComboBox
End Class
