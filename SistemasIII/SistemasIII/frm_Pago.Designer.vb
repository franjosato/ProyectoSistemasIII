<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Pago
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Pago))
        Me.grb_cuota = New System.Windows.Forms.GroupBox()
        Me.txt_NroCuotas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_CuotasPaga = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grb_busqueda = New System.Windows.Forms.GroupBox()
        Me.txt_ModeloV = New System.Windows.Forms.TextBox()
        Me.lbl_ModeloVehiculo = New System.Windows.Forms.Label()
        Me.txt_NombreA = New System.Windows.Forms.TextBox()
        Me.txt_NombreT = New System.Windows.Forms.TextBox()
        Me.lbl_NombreAsegurado = New System.Windows.Forms.Label()
        Me.lbl_NombreTomador = New System.Windows.Forms.Label()
        Me.cmb_Placa = New System.Windows.Forms.ComboBox()
        Me.lbl_Asegurado = New System.Windows.Forms.Label()
        Me.cmb_NacionalidadA = New System.Windows.Forms.ComboBox()
        Me.txt_CedulaA = New System.Windows.Forms.TextBox()
        Me.lbl_Placa = New System.Windows.Forms.Label()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.lbl_Codigo = New System.Windows.Forms.Label()
        Me.cmb_NacionalidadT = New System.Windows.Forms.ComboBox()
        Me.txt_CedulaT = New System.Windows.Forms.TextBox()
        Me.lbl_CedulaT = New System.Windows.Forms.Label()
        Me.cmb_Codigo = New System.Windows.Forms.ComboBox()
        Me.cmb_CedulaT = New System.Windows.Forms.ComboBox()
        Me.cmb_CedulaA = New System.Windows.Forms.ComboBox()
        Me.lbl_CedulaA = New System.Windows.Forms.Label()
        Me.txt_MontoCuota = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Sistemas3DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sistemas3DataSet = New SistemasIII.sistemas3DataSet()
        Me.grb_DatosPago = New System.Windows.Forms.GroupBox()
        Me.dgv_Pagos = New System.Windows.Forms.DataGridView()
        Me.txt_Faltante = New System.Windows.Forms.TextBox()
        Me.lbl_Faltante = New System.Windows.Forms.Label()
        Me.txt_NroCuotasPagar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Cambio = New System.Windows.Forms.TextBox()
        Me.lbl_Cambio = New System.Windows.Forms.Label()
        Me.btn_Añadir = New System.Windows.Forms.Button()
        Me.txt_Montoacancelar = New System.Windows.Forms.TextBox()
        Me.lbl_Montoacancelar = New System.Windows.Forms.Label()
        Me.lbl_Formapago = New System.Windows.Forms.Label()
        Me.cmb_Formapago = New System.Windows.Forms.ComboBox()
        Me.txt_Totalapagar = New System.Windows.Forms.TextBox()
        Me.lbl_Totalapagar = New System.Windows.Forms.Label()
        Me.btn_Volver = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Procesarpago = New System.Windows.Forms.Button()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoSaludo = New System.Windows.Forms.Label()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoFormuladio = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoModulo = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoEmpresa = New System.Windows.Forms.Label()
        Me.ptb_logo = New System.Windows.Forms.PictureBox()
        Me.Forma_de_Pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto_Cancelado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto_Faltante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grb_cuota.SuspendLayout()
        Me.grb_busqueda.SuspendLayout()
        CType(Me.Sistemas3DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sistemas3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_DatosPago.SuspendLayout()
        CType(Me.dgv_Pagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grb_cuota
        '
        Me.grb_cuota.Controls.Add(Me.txt_NroCuotas)
        Me.grb_cuota.Controls.Add(Me.Label3)
        Me.grb_cuota.Controls.Add(Me.txt_CuotasPaga)
        Me.grb_cuota.Controls.Add(Me.Label2)
        Me.grb_cuota.Controls.Add(Me.grb_busqueda)
        Me.grb_cuota.Controls.Add(Me.lbl_CedulaA)
        Me.grb_cuota.Controls.Add(Me.txt_MontoCuota)
        Me.grb_cuota.Controls.Add(Me.Label1)
        Me.grb_cuota.Location = New System.Drawing.Point(12, 149)
        Me.grb_cuota.Name = "grb_cuota"
        Me.grb_cuota.Size = New System.Drawing.Size(865, 146)
        Me.grb_cuota.TabIndex = 36
        Me.grb_cuota.TabStop = False
        '
        'txt_NroCuotas
        '
        Me.txt_NroCuotas.Enabled = False
        Me.txt_NroCuotas.Location = New System.Drawing.Point(762, 24)
        Me.txt_NroCuotas.Name = "txt_NroCuotas"
        Me.txt_NroCuotas.Size = New System.Drawing.Size(34, 20)
        Me.txt_NroCuotas.TabIndex = 124
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(656, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "Número de cuotas:"
        '
        'txt_CuotasPaga
        '
        Me.txt_CuotasPaga.Enabled = False
        Me.txt_CuotasPaga.Location = New System.Drawing.Point(762, 87)
        Me.txt_CuotasPaga.Name = "txt_CuotasPaga"
        Me.txt_CuotasPaga.Size = New System.Drawing.Size(86, 20)
        Me.txt_CuotasPaga.TabIndex = 122
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(667, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Cuotas pagadas:"
        '
        'grb_busqueda
        '
        Me.grb_busqueda.Controls.Add(Me.txt_ModeloV)
        Me.grb_busqueda.Controls.Add(Me.lbl_ModeloVehiculo)
        Me.grb_busqueda.Controls.Add(Me.txt_NombreA)
        Me.grb_busqueda.Controls.Add(Me.txt_NombreT)
        Me.grb_busqueda.Controls.Add(Me.lbl_NombreAsegurado)
        Me.grb_busqueda.Controls.Add(Me.lbl_NombreTomador)
        Me.grb_busqueda.Controls.Add(Me.cmb_Placa)
        Me.grb_busqueda.Controls.Add(Me.lbl_Asegurado)
        Me.grb_busqueda.Controls.Add(Me.cmb_NacionalidadA)
        Me.grb_busqueda.Controls.Add(Me.txt_CedulaA)
        Me.grb_busqueda.Controls.Add(Me.lbl_Placa)
        Me.grb_busqueda.Controls.Add(Me.btn_Buscar)
        Me.grb_busqueda.Controls.Add(Me.txt_Codigo)
        Me.grb_busqueda.Controls.Add(Me.lbl_Codigo)
        Me.grb_busqueda.Controls.Add(Me.cmb_NacionalidadT)
        Me.grb_busqueda.Controls.Add(Me.txt_CedulaT)
        Me.grb_busqueda.Controls.Add(Me.lbl_CedulaT)
        Me.grb_busqueda.Controls.Add(Me.cmb_Codigo)
        Me.grb_busqueda.Controls.Add(Me.cmb_CedulaT)
        Me.grb_busqueda.Controls.Add(Me.cmb_CedulaA)
        Me.grb_busqueda.Location = New System.Drawing.Point(9, 15)
        Me.grb_busqueda.Name = "grb_busqueda"
        Me.grb_busqueda.Size = New System.Drawing.Size(641, 125)
        Me.grb_busqueda.TabIndex = 120
        Me.grb_busqueda.TabStop = False
        Me.grb_busqueda.Text = "Datos de busqueda"
        '
        'txt_ModeloV
        '
        Me.txt_ModeloV.Enabled = False
        Me.txt_ModeloV.Location = New System.Drawing.Point(511, 34)
        Me.txt_ModeloV.Name = "txt_ModeloV"
        Me.txt_ModeloV.Size = New System.Drawing.Size(105, 20)
        Me.txt_ModeloV.TabIndex = 130
        '
        'lbl_ModeloVehiculo
        '
        Me.lbl_ModeloVehiculo.AutoSize = True
        Me.lbl_ModeloVehiculo.Location = New System.Drawing.Point(460, 38)
        Me.lbl_ModeloVehiculo.Name = "lbl_ModeloVehiculo"
        Me.lbl_ModeloVehiculo.Size = New System.Drawing.Size(45, 13)
        Me.lbl_ModeloVehiculo.TabIndex = 129
        Me.lbl_ModeloVehiculo.Text = "Modelo:"
        '
        'txt_NombreA
        '
        Me.txt_NombreA.Enabled = False
        Me.txt_NombreA.Location = New System.Drawing.Point(125, 99)
        Me.txt_NombreA.Name = "txt_NombreA"
        Me.txt_NombreA.Size = New System.Drawing.Size(159, 20)
        Me.txt_NombreA.TabIndex = 128
        '
        'txt_NombreT
        '
        Me.txt_NombreT.Enabled = False
        Me.txt_NombreT.Location = New System.Drawing.Point(125, 42)
        Me.txt_NombreT.Name = "txt_NombreT"
        Me.txt_NombreT.Size = New System.Drawing.Size(159, 20)
        Me.txt_NombreT.TabIndex = 127
        '
        'lbl_NombreAsegurado
        '
        Me.lbl_NombreAsegurado.AutoSize = True
        Me.lbl_NombreAsegurado.Location = New System.Drawing.Point(6, 102)
        Me.lbl_NombreAsegurado.Name = "lbl_NombreAsegurado"
        Me.lbl_NombreAsegurado.Size = New System.Drawing.Size(117, 13)
        Me.lbl_NombreAsegurado.TabIndex = 126
        Me.lbl_NombreAsegurado.Text = "Nombre del asegurado:"
        '
        'lbl_NombreTomador
        '
        Me.lbl_NombreTomador.AutoSize = True
        Me.lbl_NombreTomador.Location = New System.Drawing.Point(6, 46)
        Me.lbl_NombreTomador.Name = "lbl_NombreTomador"
        Me.lbl_NombreTomador.Size = New System.Drawing.Size(105, 13)
        Me.lbl_NombreTomador.TabIndex = 125
        Me.lbl_NombreTomador.Text = "Nombre del tomador:"
        '
        'cmb_Placa
        '
        Me.cmb_Placa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_Placa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmb_Placa.FormattingEnabled = True
        Me.cmb_Placa.Location = New System.Drawing.Point(347, 34)
        Me.cmb_Placa.Name = "cmb_Placa"
        Me.cmb_Placa.Size = New System.Drawing.Size(107, 21)
        Me.cmb_Placa.TabIndex = 5
        Me.cmb_Placa.Text = "Seleccione placa"
        '
        'lbl_Asegurado
        '
        Me.lbl_Asegurado.AutoSize = True
        Me.lbl_Asegurado.Location = New System.Drawing.Point(6, 72)
        Me.lbl_Asegurado.Name = "lbl_Asegurado"
        Me.lbl_Asegurado.Size = New System.Drawing.Size(113, 13)
        Me.lbl_Asegurado.TabIndex = 120
        Me.lbl_Asegurado.Text = "Cédula del asegurado:"
        '
        'cmb_NacionalidadA
        '
        Me.cmb_NacionalidadA.AutoCompleteCustomSource.AddRange(New String() {"", "V", "E"})
        Me.cmb_NacionalidadA.BackColor = System.Drawing.Color.GhostWhite
        Me.cmb_NacionalidadA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_NacionalidadA.FormattingEnabled = True
        Me.cmb_NacionalidadA.Items.AddRange(New Object() {"V", "E"})
        Me.cmb_NacionalidadA.Location = New System.Drawing.Point(125, 69)
        Me.cmb_NacionalidadA.Name = "cmb_NacionalidadA"
        Me.cmb_NacionalidadA.Size = New System.Drawing.Size(47, 21)
        Me.cmb_NacionalidadA.TabIndex = 3
        '
        'txt_CedulaA
        '
        Me.txt_CedulaA.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_CedulaA.Location = New System.Drawing.Point(178, 70)
        Me.txt_CedulaA.MaxLength = 8
        Me.txt_CedulaA.Name = "txt_CedulaA"
        Me.txt_CedulaA.Size = New System.Drawing.Size(106, 20)
        Me.txt_CedulaA.TabIndex = 4
        '
        'lbl_Placa
        '
        Me.lbl_Placa.AutoSize = True
        Me.lbl_Placa.Location = New System.Drawing.Point(300, 37)
        Me.lbl_Placa.Name = "lbl_Placa"
        Me.lbl_Placa.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Placa.TabIndex = 114
        Me.lbl_Placa.Text = " Placa:"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Location = New System.Drawing.Point(541, 71)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 7
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Location = New System.Drawing.Point(411, 72)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(110, 20)
        Me.txt_Codigo.TabIndex = 6
        '
        'lbl_Codigo
        '
        Me.lbl_Codigo.AutoSize = True
        Me.lbl_Codigo.Location = New System.Drawing.Point(300, 75)
        Me.lbl_Codigo.Name = "lbl_Codigo"
        Me.lbl_Codigo.Size = New System.Drawing.Size(99, 13)
        Me.lbl_Codigo.TabIndex = 110
        Me.lbl_Codigo.Text = "Código de la póliza:"
        '
        'cmb_NacionalidadT
        '
        Me.cmb_NacionalidadT.AutoCompleteCustomSource.AddRange(New String() {"", "V", "E"})
        Me.cmb_NacionalidadT.BackColor = System.Drawing.Color.GhostWhite
        Me.cmb_NacionalidadT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_NacionalidadT.FormattingEnabled = True
        Me.cmb_NacionalidadT.Items.AddRange(New Object() {"V", "E"})
        Me.cmb_NacionalidadT.Location = New System.Drawing.Point(123, 15)
        Me.cmb_NacionalidadT.Name = "cmb_NacionalidadT"
        Me.cmb_NacionalidadT.Size = New System.Drawing.Size(47, 21)
        Me.cmb_NacionalidadT.TabIndex = 1
        '
        'txt_CedulaT
        '
        Me.txt_CedulaT.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_CedulaT.Location = New System.Drawing.Point(176, 15)
        Me.txt_CedulaT.MaxLength = 8
        Me.txt_CedulaT.Name = "txt_CedulaT"
        Me.txt_CedulaT.Size = New System.Drawing.Size(108, 20)
        Me.txt_CedulaT.TabIndex = 2
        '
        'lbl_CedulaT
        '
        Me.lbl_CedulaT.AutoSize = True
        Me.lbl_CedulaT.Location = New System.Drawing.Point(6, 20)
        Me.lbl_CedulaT.Name = "lbl_CedulaT"
        Me.lbl_CedulaT.Size = New System.Drawing.Size(101, 13)
        Me.lbl_CedulaT.TabIndex = 106
        Me.lbl_CedulaT.Text = "Cédula del tomador:"
        '
        'cmb_Codigo
        '
        Me.cmb_Codigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Codigo.FormattingEnabled = True
        Me.cmb_Codigo.Location = New System.Drawing.Point(411, 73)
        Me.cmb_Codigo.Name = "cmb_Codigo"
        Me.cmb_Codigo.Size = New System.Drawing.Size(86, 21)
        Me.cmb_Codigo.TabIndex = 124
        Me.cmb_Codigo.Visible = False
        '
        'cmb_CedulaT
        '
        Me.cmb_CedulaT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CedulaT.FormattingEnabled = True
        Me.cmb_CedulaT.Location = New System.Drawing.Point(175, 15)
        Me.cmb_CedulaT.Name = "cmb_CedulaT"
        Me.cmb_CedulaT.Size = New System.Drawing.Size(86, 21)
        Me.cmb_CedulaT.TabIndex = 122
        Me.cmb_CedulaT.Visible = False
        '
        'cmb_CedulaA
        '
        Me.cmb_CedulaA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CedulaA.FormattingEnabled = True
        Me.cmb_CedulaA.Location = New System.Drawing.Point(179, 71)
        Me.cmb_CedulaA.Name = "cmb_CedulaA"
        Me.cmb_CedulaA.Size = New System.Drawing.Size(85, 21)
        Me.cmb_CedulaA.TabIndex = 121
        Me.cmb_CedulaA.Visible = False
        '
        'lbl_CedulaA
        '
        Me.lbl_CedulaA.AutoSize = True
        Me.lbl_CedulaA.Location = New System.Drawing.Point(6, 52)
        Me.lbl_CedulaA.Name = "lbl_CedulaA"
        Me.lbl_CedulaA.Size = New System.Drawing.Size(114, 13)
        Me.lbl_CedulaA.TabIndex = 117
        Me.lbl_CedulaA.Text = "Cédula del Asegurado:"
        '
        'txt_MontoCuota
        '
        Me.txt_MontoCuota.Enabled = False
        Me.txt_MontoCuota.Location = New System.Drawing.Point(762, 54)
        Me.txt_MontoCuota.Name = "txt_MontoCuota"
        Me.txt_MontoCuota.Size = New System.Drawing.Size(86, 20)
        Me.txt_MontoCuota.TabIndex = 113
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(667, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Monto de cuota:"
        '
        'Sistemas3DataSetBindingSource
        '
        Me.Sistemas3DataSetBindingSource.DataSource = Me.Sistemas3DataSet
        Me.Sistemas3DataSetBindingSource.Position = 0
        '
        'Sistemas3DataSet
        '
        Me.Sistemas3DataSet.DataSetName = "sistemas3DataSet"
        Me.Sistemas3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grb_DatosPago
        '
        Me.grb_DatosPago.Controls.Add(Me.dgv_Pagos)
        Me.grb_DatosPago.Controls.Add(Me.txt_Faltante)
        Me.grb_DatosPago.Controls.Add(Me.lbl_Faltante)
        Me.grb_DatosPago.Controls.Add(Me.txt_NroCuotasPagar)
        Me.grb_DatosPago.Controls.Add(Me.Label4)
        Me.grb_DatosPago.Controls.Add(Me.txt_Cambio)
        Me.grb_DatosPago.Controls.Add(Me.lbl_Cambio)
        Me.grb_DatosPago.Controls.Add(Me.btn_Añadir)
        Me.grb_DatosPago.Controls.Add(Me.txt_Montoacancelar)
        Me.grb_DatosPago.Controls.Add(Me.lbl_Montoacancelar)
        Me.grb_DatosPago.Controls.Add(Me.lbl_Formapago)
        Me.grb_DatosPago.Controls.Add(Me.cmb_Formapago)
        Me.grb_DatosPago.Controls.Add(Me.txt_Totalapagar)
        Me.grb_DatosPago.Controls.Add(Me.lbl_Totalapagar)
        Me.grb_DatosPago.Location = New System.Drawing.Point(12, 301)
        Me.grb_DatosPago.Name = "grb_DatosPago"
        Me.grb_DatosPago.Size = New System.Drawing.Size(865, 210)
        Me.grb_DatosPago.TabIndex = 35
        Me.grb_DatosPago.TabStop = False
        Me.grb_DatosPago.Text = "Datos del pago"
        '
        'dgv_Pagos
        '
        Me.dgv_Pagos.AllowUserToAddRows = False
        Me.dgv_Pagos.AllowUserToDeleteRows = False
        Me.dgv_Pagos.AllowUserToResizeRows = False
        Me.dgv_Pagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Pagos.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Pagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.NullValue = "0"
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Pagos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_Pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Pagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Forma_de_Pago, Me.Monto_Cancelado, Me.Monto_Faltante})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Pagos.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_Pagos.Location = New System.Drawing.Point(343, 42)
        Me.dgv_Pagos.MultiSelect = False
        Me.dgv_Pagos.Name = "dgv_Pagos"
        Me.dgv_Pagos.ReadOnly = True
        Me.dgv_Pagos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_Pagos.RowHeadersVisible = False
        DataGridViewCellStyle12.NullValue = "0"
        Me.dgv_Pagos.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_Pagos.Size = New System.Drawing.Size(442, 112)
        Me.dgv_Pagos.TabIndex = 30
        '
        'txt_Faltante
        '
        Me.txt_Faltante.Enabled = False
        Me.txt_Faltante.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Faltante.Location = New System.Drawing.Point(685, 13)
        Me.txt_Faltante.Name = "txt_Faltante"
        Me.txt_Faltante.Size = New System.Drawing.Size(144, 23)
        Me.txt_Faltante.TabIndex = 29
        Me.txt_Faltante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_Faltante
        '
        Me.lbl_Faltante.AutoSize = True
        Me.lbl_Faltante.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Faltante.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Faltante.Location = New System.Drawing.Point(604, 16)
        Me.lbl_Faltante.Name = "lbl_Faltante"
        Me.lbl_Faltante.Size = New System.Drawing.Size(78, 17)
        Me.lbl_Faltante.TabIndex = 28
        Me.lbl_Faltante.Text = "Faltan Bs.F."
        '
        'txt_NroCuotasPagar
        '
        Me.txt_NroCuotasPagar.Enabled = False
        Me.txt_NroCuotasPagar.Location = New System.Drawing.Point(199, 35)
        Me.txt_NroCuotasPagar.MaxLength = 2
        Me.txt_NroCuotasPagar.Name = "txt_NroCuotasPagar"
        Me.txt_NroCuotasPagar.Size = New System.Drawing.Size(36, 20)
        Me.txt_NroCuotasPagar.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "N° Cuotas a pagar"
        '
        'txt_Cambio
        '
        Me.txt_Cambio.Enabled = False
        Me.txt_Cambio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cambio.Location = New System.Drawing.Point(668, 178)
        Me.txt_Cambio.Name = "txt_Cambio"
        Me.txt_Cambio.Size = New System.Drawing.Size(180, 23)
        Me.txt_Cambio.TabIndex = 26
        Me.txt_Cambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_Cambio
        '
        Me.lbl_Cambio.AutoSize = True
        Me.lbl_Cambio.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Cambio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cambio.Location = New System.Drawing.Point(461, 181)
        Me.lbl_Cambio.Name = "lbl_Cambio"
        Me.lbl_Cambio.Size = New System.Drawing.Size(201, 16)
        Me.lbl_Cambio.TabIndex = 25
        Me.lbl_Cambio.Text = "Cambio en Efectivo al Cliente"
        '
        'btn_Añadir
        '
        Me.btn_Añadir.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Añadir.BackgroundImage = CType(resources.GetObject("btn_Añadir.BackgroundImage"), System.Drawing.Image)
        Me.btn_Añadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_Añadir.Enabled = False
        Me.btn_Añadir.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Añadir.Location = New System.Drawing.Point(79, 160)
        Me.btn_Añadir.Name = "btn_Añadir"
        Me.btn_Añadir.Size = New System.Drawing.Size(106, 29)
        Me.btn_Añadir.TabIndex = 11
        Me.btn_Añadir.Text = "Añadir"
        Me.btn_Añadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Añadir.UseVisualStyleBackColor = False
        '
        'txt_Montoacancelar
        '
        Me.txt_Montoacancelar.Enabled = False
        Me.txt_Montoacancelar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Montoacancelar.Location = New System.Drawing.Point(57, 131)
        Me.txt_Montoacancelar.Name = "txt_Montoacancelar"
        Me.txt_Montoacancelar.Size = New System.Drawing.Size(166, 23)
        Me.txt_Montoacancelar.TabIndex = 10
        Me.txt_Montoacancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_Montoacancelar
        '
        Me.lbl_Montoacancelar.AutoSize = True
        Me.lbl_Montoacancelar.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Montoacancelar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Montoacancelar.Location = New System.Drawing.Point(54, 111)
        Me.lbl_Montoacancelar.Name = "lbl_Montoacancelar"
        Me.lbl_Montoacancelar.Size = New System.Drawing.Size(157, 17)
        Me.lbl_Montoacancelar.TabIndex = 21
        Me.lbl_Montoacancelar.Text = "Monto a Cancelar Bs.F."
        '
        'lbl_Formapago
        '
        Me.lbl_Formapago.AutoSize = True
        Me.lbl_Formapago.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Formapago.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Formapago.Location = New System.Drawing.Point(54, 63)
        Me.lbl_Formapago.Name = "lbl_Formapago"
        Me.lbl_Formapago.Size = New System.Drawing.Size(109, 17)
        Me.lbl_Formapago.TabIndex = 20
        Me.lbl_Formapago.Text = "Forma de Pago"
        '
        'cmb_Formapago
        '
        Me.cmb_Formapago.AutoCompleteCustomSource.AddRange(New String() {"Debito", "Credito", "Efectivo"})
        Me.cmb_Formapago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Formapago.Enabled = False
        Me.cmb_Formapago.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Formapago.FormattingEnabled = True
        Me.cmb_Formapago.Items.AddRange(New Object() {"Debito", "Credito", "Efectivo"})
        Me.cmb_Formapago.Location = New System.Drawing.Point(57, 83)
        Me.cmb_Formapago.Name = "cmb_Formapago"
        Me.cmb_Formapago.Size = New System.Drawing.Size(166, 25)
        Me.cmb_Formapago.TabIndex = 9
        '
        'txt_Totalapagar
        '
        Me.txt_Totalapagar.Enabled = False
        Me.txt_Totalapagar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Totalapagar.Location = New System.Drawing.Point(446, 13)
        Me.txt_Totalapagar.Name = "txt_Totalapagar"
        Me.txt_Totalapagar.Size = New System.Drawing.Size(148, 23)
        Me.txt_Totalapagar.TabIndex = 18
        Me.txt_Totalapagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_Totalapagar
        '
        Me.lbl_Totalapagar.AutoSize = True
        Me.lbl_Totalapagar.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Totalapagar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Totalapagar.Location = New System.Drawing.Point(315, 16)
        Me.lbl_Totalapagar.Name = "lbl_Totalapagar"
        Me.lbl_Totalapagar.Size = New System.Drawing.Size(125, 17)
        Me.lbl_Totalapagar.TabIndex = 17
        Me.lbl_Totalapagar.Text = "Total a Pagar Bs.F."
        '
        'btn_Volver
        '
        Me.btn_Volver.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Volver.CausesValidation = False
        Me.btn_Volver.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Volver.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Volver.Image = CType(resources.GetObject("btn_Volver.Image"), System.Drawing.Image)
        Me.btn_Volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Volver.Location = New System.Drawing.Point(532, 517)
        Me.btn_Volver.Name = "btn_Volver"
        Me.btn_Volver.Size = New System.Drawing.Size(105, 28)
        Me.btn_Volver.TabIndex = 14
        Me.btn_Volver.Text = "Volver"
        Me.btn_Volver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Volver.UseVisualStyleBackColor = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Cancelar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Cancelar.Image = CType(resources.GetObject("btn_Cancelar.Image"), System.Drawing.Image)
        Me.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cancelar.Location = New System.Drawing.Point(403, 517)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(105, 28)
        Me.btn_Cancelar.TabIndex = 13
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.UseVisualStyleBackColor = False
        '
        'btn_Procesarpago
        '
        Me.btn_Procesarpago.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Procesarpago.BackgroundImage = CType(resources.GetObject("btn_Procesarpago.BackgroundImage"), System.Drawing.Image)
        Me.btn_Procesarpago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_Procesarpago.Enabled = False
        Me.btn_Procesarpago.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Procesarpago.Location = New System.Drawing.Point(247, 516)
        Me.btn_Procesarpago.Name = "btn_Procesarpago"
        Me.btn_Procesarpago.Size = New System.Drawing.Size(132, 29)
        Me.btn_Procesarpago.TabIndex = 12
        Me.btn_Procesarpago.Text = "Procesar Pago"
        Me.btn_Procesarpago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Procesarpago.UseVisualStyleBackColor = False
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fecha.Location = New System.Drawing.Point(554, 13)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Fecha.TabIndex = 131
        Me.lbl_Fecha.Text = "dd/MM/YY"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Usuario.Location = New System.Drawing.Point(625, 63)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Usuario.TabIndex = 130
        Me.lbl_Usuario.Text = "Usuario"
        '
        'lbl_EncabezadoSaludo
        '
        Me.lbl_EncabezadoSaludo.AutoSize = True
        Me.lbl_EncabezadoSaludo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoSaludo.Location = New System.Drawing.Point(584, 63)
        Me.lbl_EncabezadoSaludo.Name = "lbl_EncabezadoSaludo"
        Me.lbl_EncabezadoSaludo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_EncabezadoSaludo.TabIndex = 129
        Me.lbl_EncabezadoSaludo.Text = "Hola, "
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Hora.Location = New System.Drawing.Point(618, 13)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Hora.TabIndex = 128
        Me.lbl_Hora.Text = "00:00:00"
        '
        'lbl_EncabezadoFormuladio
        '
        Me.lbl_EncabezadoFormuladio.AutoSize = True
        Me.lbl_EncabezadoFormuladio.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoFormuladio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoFormuladio.Location = New System.Drawing.Point(239, 99)
        Me.lbl_EncabezadoFormuladio.Name = "lbl_EncabezadoFormuladio"
        Me.lbl_EncabezadoFormuladio.Size = New System.Drawing.Size(213, 25)
        Me.lbl_EncabezadoFormuladio.TabIndex = 127
        Me.lbl_EncabezadoFormuladio.Text = "Datos del Asegurado"
        '
        'lbl_EncabezadoModulo
        '
        Me.lbl_EncabezadoModulo.AutoSize = True
        Me.lbl_EncabezadoModulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoModulo.Location = New System.Drawing.Point(247, 55)
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
        Me.lbl_EncabezadoEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoEmpresa.Location = New System.Drawing.Point(208, 1)
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
        Me.ptb_logo.Location = New System.Drawing.Point(0, 0)
        Me.ptb_logo.Name = "ptb_logo"
        Me.ptb_logo.Size = New System.Drawing.Size(132, 132)
        Me.ptb_logo.TabIndex = 124
        Me.ptb_logo.TabStop = False
        Me.ptb_logo.UseWaitCursor = True
        '
        'Forma_de_Pago
        '
        Me.Forma_de_Pago.HeaderText = "Forma de Pago"
        Me.Forma_de_Pago.Name = "Forma_de_Pago"
        Me.Forma_de_Pago.ReadOnly = True
        Me.Forma_de_Pago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Monto_Cancelado
        '
        Me.Monto_Cancelado.HeaderText = "Monto Cancelado(BsF)"
        Me.Monto_Cancelado.Name = "Monto_Cancelado"
        Me.Monto_Cancelado.ReadOnly = True
        Me.Monto_Cancelado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Monto_Faltante
        '
        Me.Monto_Faltante.HeaderText = "Monto Faltante(BsF)"
        Me.Monto_Faltante.Name = "Monto_Faltante"
        Me.Monto_Faltante.ReadOnly = True
        Me.Monto_Faltante.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frm_Pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.SistemasIII.My.Resources.Resources.frm23
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(889, 550)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.lbl_EncabezadoSaludo)
        Me.Controls.Add(Me.lbl_Hora)
        Me.Controls.Add(Me.lbl_EncabezadoFormuladio)
        Me.Controls.Add(Me.lbl_EncabezadoModulo)
        Me.Controls.Add(Me.lbl_EncabezadoEmpresa)
        Me.Controls.Add(Me.ptb_logo)
        Me.Controls.Add(Me.grb_cuota)
        Me.Controls.Add(Me.btn_Volver)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.grb_DatosPago)
        Me.Controls.Add(Me.btn_Procesarpago)
        Me.Name = "frm_Pago"
        Me.Text = "frm_Pago"
        Me.grb_cuota.ResumeLayout(False)
        Me.grb_cuota.PerformLayout()
        Me.grb_busqueda.ResumeLayout(False)
        Me.grb_busqueda.PerformLayout()
        CType(Me.Sistemas3DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sistemas3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_DatosPago.ResumeLayout(False)
        Me.grb_DatosPago.PerformLayout()
        CType(Me.dgv_Pagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grb_cuota As GroupBox
    Friend WithEvents grb_busqueda As GroupBox
    Friend WithEvents lbl_Asegurado As Label
    Friend WithEvents cmb_NacionalidadA As ComboBox
    Friend WithEvents txt_CedulaA As TextBox
    Friend WithEvents lbl_Placa As Label
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents txt_Codigo As TextBox
    Friend WithEvents lbl_Codigo As Label
    Friend WithEvents cmb_NacionalidadT As ComboBox
    Friend WithEvents txt_CedulaT As TextBox
    Friend WithEvents lbl_CedulaT As Label
    Friend WithEvents lbl_CedulaA As Label
    Friend WithEvents txt_MontoCuota As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Volver As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents grb_DatosPago As GroupBox
    Friend WithEvents txt_Cambio As TextBox
    Friend WithEvents lbl_Cambio As Label
    Friend WithEvents btn_Añadir As Button
    Friend WithEvents txt_Montoacancelar As TextBox
    Friend WithEvents lbl_Montoacancelar As Label
    Friend WithEvents lbl_Formapago As Label
    Friend WithEvents cmb_Formapago As ComboBox
    Friend WithEvents txt_Totalapagar As TextBox
    Friend WithEvents lbl_Totalapagar As Label
    Friend WithEvents btn_Procesarpago As Button
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents lbl_EncabezadoSaludo As Label
    Friend WithEvents lbl_Hora As Label
    Friend WithEvents lbl_EncabezadoFormuladio As Label
    Friend WithEvents lbl_EncabezadoModulo As Label
    Friend WithEvents lbl_EncabezadoEmpresa As Label
    Friend WithEvents ptb_logo As PictureBox
    Friend WithEvents txt_CuotasPaga As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_NroCuotas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_NroCuotasPagar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Sistemas3DataSetBindingSource As BindingSource
    Friend WithEvents Sistemas3DataSet As sistemas3DataSet
    Friend WithEvents cmb_Placa As ComboBox
    Friend WithEvents cmb_CedulaA As ComboBox
    Friend WithEvents cmb_CedulaT As ComboBox
    Friend WithEvents cmb_Codigo As ComboBox
    Friend WithEvents lbl_ModeloVehiculo As Label
    Friend WithEvents txt_NombreA As TextBox
    Friend WithEvents txt_NombreT As TextBox
    Friend WithEvents lbl_NombreAsegurado As Label
    Friend WithEvents lbl_NombreTomador As Label
    Friend WithEvents txt_ModeloV As TextBox
    Friend WithEvents txt_Faltante As TextBox
    Friend WithEvents lbl_Faltante As Label
    Friend WithEvents dgv_Pagos As DataGridView
    Friend WithEvents Forma_de_Pago As DataGridViewTextBoxColumn
    Friend WithEvents Monto_Cancelado As DataGridViewTextBoxColumn
    Friend WithEvents Monto_Faltante As DataGridViewTextBoxColumn
End Class
