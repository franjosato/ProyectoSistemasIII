<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Asegurado
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
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoSaludo = New System.Windows.Forms.Label()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoFormuladio = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoModulo = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoEmpresa = New System.Windows.Forms.Label()
        Me.grb_Licencia = New System.Windows.Forms.GroupBox()
        Me.grb_Personales = New System.Windows.Forms.GroupBox()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.grb_Edocivil = New System.Windows.Forms.GroupBox()
        Me.rdb_Otro = New System.Windows.Forms.RadioButton()
        Me.rdb_Divorciado = New System.Windows.Forms.RadioButton()
        Me.rdb_Casado = New System.Windows.Forms.RadioButton()
        Me.rdb_soltero = New System.Windows.Forms.RadioButton()
        Me.grb_DireccYContacto = New System.Windows.Forms.GroupBox()
        Me.txt_ZonaP = New System.Windows.Forms.TextBox()
        Me.lbl_ZonaP = New System.Windows.Forms.Label()
        Me.cmb_Estado = New System.Windows.Forms.ComboBox()
        Me.lbl_Estado = New System.Windows.Forms.Label()
        Me.rtb_DireccionH = New System.Windows.Forms.RichTextBox()
        Me.cmb_Ciudad = New System.Windows.Forms.ComboBox()
        Me.txt_Correro = New System.Windows.Forms.TextBox()
        Me.lbl_Correo = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lbl_Ciudad = New System.Windows.Forms.Label()
        Me.txt_TlfMovil = New System.Windows.Forms.TextBox()
        Me.lbl_DireccionH = New System.Windows.Forms.Label()
        Me.txt_TlfFijo = New System.Windows.Forms.TextBox()
        Me.lbl_TlfFijo = New System.Windows.Forms.Label()
        Me.lbl_TlfMovil = New System.Windows.Forms.Label()
        Me.grb_Sexo = New System.Windows.Forms.GroupBox()
        Me.rdb_Femenino = New System.Windows.Forms.RadioButton()
        Me.rdb_Masculino = New System.Windows.Forms.RadioButton()
        Me.dtp_FNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lbl_FNacimiento = New System.Windows.Forms.Label()
        Me.cmb_Nacionalidad = New System.Windows.Forms.ComboBox()
        Me.txt_Cedula = New System.Windows.Forms.TextBox()
        Me.lbl_Cedula = New System.Windows.Forms.Label()
        Me.txt_SApellido = New System.Windows.Forms.TextBox()
        Me.txt_SNombre = New System.Windows.Forms.TextBox()
        Me.txt_PApellido = New System.Windows.Forms.TextBox()
        Me.txt_PNombre = New System.Windows.Forms.TextBox()
        Me.lbl_SApellido = New System.Windows.Forms.Label()
        Me.lbl_PApellido = New System.Windows.Forms.Label()
        Me.lbl_SNombre = New System.Windows.Forms.Label()
        Me.lbl_PNombre = New System.Windows.Forms.Label()
        Me.ptb_logo = New System.Windows.Forms.PictureBox()
        Me.btn_Volver = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.lbl_ActEconomica = New System.Windows.Forms.Label()
        Me.txt_NumeroL = New System.Windows.Forms.TextBox()
        Me.txt_GradoL = New System.Windows.Forms.TextBox()
        Me.lbl_NumeroL = New System.Windows.Forms.Label()
        Me.lbl_GradoL = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.grb_Licencia.SuspendLayout()
        Me.grb_Personales.SuspendLayout()
        Me.grb_Edocivil.SuspendLayout()
        Me.grb_DireccYContacto.SuspendLayout()
        Me.grb_Sexo.SuspendLayout()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fecha.Location = New System.Drawing.Point(554, 12)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Fecha.TabIndex = 115
        Me.lbl_Fecha.Text = "dd/MM/YY"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Usuario.Location = New System.Drawing.Point(625, 62)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Usuario.TabIndex = 114
        Me.lbl_Usuario.Text = "Usuario"
        '
        'lbl_EncabezadoSaludo
        '
        Me.lbl_EncabezadoSaludo.AutoSize = True
        Me.lbl_EncabezadoSaludo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoSaludo.Location = New System.Drawing.Point(584, 62)
        Me.lbl_EncabezadoSaludo.Name = "lbl_EncabezadoSaludo"
        Me.lbl_EncabezadoSaludo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_EncabezadoSaludo.TabIndex = 113
        Me.lbl_EncabezadoSaludo.Text = "Hola, "
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Hora.Location = New System.Drawing.Point(618, 12)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Hora.TabIndex = 112
        Me.lbl_Hora.Text = "00:00:00"
        '
        'lbl_EncabezadoFormuladio
        '
        Me.lbl_EncabezadoFormuladio.AutoSize = True
        Me.lbl_EncabezadoFormuladio.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoFormuladio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoFormuladio.Location = New System.Drawing.Point(239, 98)
        Me.lbl_EncabezadoFormuladio.Name = "lbl_EncabezadoFormuladio"
        Me.lbl_EncabezadoFormuladio.Size = New System.Drawing.Size(213, 25)
        Me.lbl_EncabezadoFormuladio.TabIndex = 111
        Me.lbl_EncabezadoFormuladio.Text = "Datos del Asegurado"
        '
        'lbl_EncabezadoModulo
        '
        Me.lbl_EncabezadoModulo.AutoSize = True
        Me.lbl_EncabezadoModulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoModulo.Location = New System.Drawing.Point(247, 54)
        Me.lbl_EncabezadoModulo.Name = "lbl_EncabezadoModulo"
        Me.lbl_EncabezadoModulo.Size = New System.Drawing.Size(196, 25)
        Me.lbl_EncabezadoModulo.TabIndex = 110
        Me.lbl_EncabezadoModulo.Text = "Módulo de Servicio"
        '
        'lbl_EncabezadoEmpresa
        '
        Me.lbl_EncabezadoEmpresa.AutoSize = True
        Me.lbl_EncabezadoEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoEmpresa.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_EncabezadoEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoEmpresa.Location = New System.Drawing.Point(205, 9)
        Me.lbl_EncabezadoEmpresa.Name = "lbl_EncabezadoEmpresa"
        Me.lbl_EncabezadoEmpresa.Size = New System.Drawing.Size(291, 29)
        Me.lbl_EncabezadoEmpresa.TabIndex = 109
        Me.lbl_EncabezadoEmpresa.Text = "SEGUROS MALDONADO"
        '
        'grb_Licencia
        '
        Me.grb_Licencia.BackColor = System.Drawing.Color.Transparent
        Me.grb_Licencia.Controls.Add(Me.DateTimePicker1)
        Me.grb_Licencia.Controls.Add(Me.lbl_GradoL)
        Me.grb_Licencia.Controls.Add(Me.lbl_NumeroL)
        Me.grb_Licencia.Controls.Add(Me.txt_GradoL)
        Me.grb_Licencia.Controls.Add(Me.txt_NumeroL)
        Me.grb_Licencia.Controls.Add(Me.lbl_ActEconomica)
        Me.grb_Licencia.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Licencia.Location = New System.Drawing.Point(8, 478)
        Me.grb_Licencia.Name = "grb_Licencia"
        Me.grb_Licencia.Size = New System.Drawing.Size(684, 91)
        Me.grb_Licencia.TabIndex = 108
        Me.grb_Licencia.TabStop = False
        Me.grb_Licencia.Text = "Datos de la Licencia"
        '
        'grb_Personales
        '
        Me.grb_Personales.BackColor = System.Drawing.Color.Transparent
        Me.grb_Personales.Controls.Add(Me.btn_Buscar)
        Me.grb_Personales.Controls.Add(Me.grb_Edocivil)
        Me.grb_Personales.Controls.Add(Me.grb_DireccYContacto)
        Me.grb_Personales.Controls.Add(Me.grb_Sexo)
        Me.grb_Personales.Controls.Add(Me.dtp_FNacimiento)
        Me.grb_Personales.Controls.Add(Me.lbl_FNacimiento)
        Me.grb_Personales.Controls.Add(Me.cmb_Nacionalidad)
        Me.grb_Personales.Controls.Add(Me.txt_Cedula)
        Me.grb_Personales.Controls.Add(Me.lbl_Cedula)
        Me.grb_Personales.Controls.Add(Me.txt_SApellido)
        Me.grb_Personales.Controls.Add(Me.txt_SNombre)
        Me.grb_Personales.Controls.Add(Me.txt_PApellido)
        Me.grb_Personales.Controls.Add(Me.txt_PNombre)
        Me.grb_Personales.Controls.Add(Me.lbl_SApellido)
        Me.grb_Personales.Controls.Add(Me.lbl_PApellido)
        Me.grb_Personales.Controls.Add(Me.lbl_SNombre)
        Me.grb_Personales.Controls.Add(Me.lbl_PNombre)
        Me.grb_Personales.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Personales.Location = New System.Drawing.Point(8, 171)
        Me.grb_Personales.Name = "grb_Personales"
        Me.grb_Personales.Size = New System.Drawing.Size(684, 301)
        Me.grb_Personales.TabIndex = 107
        Me.grb_Personales.TabStop = False
        Me.grb_Personales.Text = "Datos personales"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Location = New System.Drawing.Point(275, 19)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 93
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'grb_Edocivil
        '
        Me.grb_Edocivil.Controls.Add(Me.rdb_Otro)
        Me.grb_Edocivil.Controls.Add(Me.rdb_Divorciado)
        Me.grb_Edocivil.Controls.Add(Me.rdb_Casado)
        Me.grb_Edocivil.Controls.Add(Me.rdb_soltero)
        Me.grb_Edocivil.Location = New System.Drawing.Point(588, 50)
        Me.grb_Edocivil.Name = "grb_Edocivil"
        Me.grb_Edocivil.Size = New System.Drawing.Size(83, 59)
        Me.grb_Edocivil.TabIndex = 77
        Me.grb_Edocivil.TabStop = False
        Me.grb_Edocivil.Text = "Estado civil"
        '
        'rdb_Otro
        '
        Me.rdb_Otro.AutoSize = True
        Me.rdb_Otro.Location = New System.Drawing.Point(44, 33)
        Me.rdb_Otro.Name = "rdb_Otro"
        Me.rdb_Otro.Size = New System.Drawing.Size(36, 20)
        Me.rdb_Otro.TabIndex = 3
        Me.rdb_Otro.TabStop = True
        Me.rdb_Otro.Text = "O"
        Me.rdb_Otro.UseVisualStyleBackColor = True
        '
        'rdb_Divorciado
        '
        Me.rdb_Divorciado.AutoSize = True
        Me.rdb_Divorciado.Location = New System.Drawing.Point(44, 13)
        Me.rdb_Divorciado.Name = "rdb_Divorciado"
        Me.rdb_Divorciado.Size = New System.Drawing.Size(34, 20)
        Me.rdb_Divorciado.TabIndex = 2
        Me.rdb_Divorciado.TabStop = True
        Me.rdb_Divorciado.Text = "D"
        Me.rdb_Divorciado.UseVisualStyleBackColor = True
        '
        'rdb_Casado
        '
        Me.rdb_Casado.AutoSize = True
        Me.rdb_Casado.Location = New System.Drawing.Point(6, 33)
        Me.rdb_Casado.Name = "rdb_Casado"
        Me.rdb_Casado.Size = New System.Drawing.Size(35, 20)
        Me.rdb_Casado.TabIndex = 1
        Me.rdb_Casado.TabStop = True
        Me.rdb_Casado.Text = "C"
        Me.rdb_Casado.UseVisualStyleBackColor = True
        '
        'rdb_soltero
        '
        Me.rdb_soltero.AutoSize = True
        Me.rdb_soltero.Location = New System.Drawing.Point(6, 13)
        Me.rdb_soltero.Name = "rdb_soltero"
        Me.rdb_soltero.Size = New System.Drawing.Size(32, 20)
        Me.rdb_soltero.TabIndex = 0
        Me.rdb_soltero.TabStop = True
        Me.rdb_soltero.Text = "S"
        Me.rdb_soltero.UseVisualStyleBackColor = True
        '
        'grb_DireccYContacto
        '
        Me.grb_DireccYContacto.Controls.Add(Me.txt_ZonaP)
        Me.grb_DireccYContacto.Controls.Add(Me.lbl_ZonaP)
        Me.grb_DireccYContacto.Controls.Add(Me.cmb_Estado)
        Me.grb_DireccYContacto.Controls.Add(Me.lbl_Estado)
        Me.grb_DireccYContacto.Controls.Add(Me.rtb_DireccionH)
        Me.grb_DireccYContacto.Controls.Add(Me.cmb_Ciudad)
        Me.grb_DireccYContacto.Controls.Add(Me.txt_Correro)
        Me.grb_DireccYContacto.Controls.Add(Me.lbl_Correo)
        Me.grb_DireccYContacto.Controls.Add(Me.LinkLabel1)
        Me.grb_DireccYContacto.Controls.Add(Me.lbl_Ciudad)
        Me.grb_DireccYContacto.Controls.Add(Me.txt_TlfMovil)
        Me.grb_DireccYContacto.Controls.Add(Me.lbl_DireccionH)
        Me.grb_DireccYContacto.Controls.Add(Me.txt_TlfFijo)
        Me.grb_DireccYContacto.Controls.Add(Me.lbl_TlfFijo)
        Me.grb_DireccYContacto.Controls.Add(Me.lbl_TlfMovil)
        Me.grb_DireccYContacto.Location = New System.Drawing.Point(5, 155)
        Me.grb_DireccYContacto.Name = "grb_DireccYContacto"
        Me.grb_DireccYContacto.Size = New System.Drawing.Size(673, 141)
        Me.grb_DireccYContacto.TabIndex = 92
        Me.grb_DireccYContacto.TabStop = False
        Me.grb_DireccYContacto.Text = "Datos de dirección y contacto"
        '
        'txt_ZonaP
        '
        Me.txt_ZonaP.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_ZonaP.Location = New System.Drawing.Point(103, 83)
        Me.txt_ZonaP.Name = "txt_ZonaP"
        Me.txt_ZonaP.Size = New System.Drawing.Size(85, 21)
        Me.txt_ZonaP.TabIndex = 95
        '
        'lbl_ZonaP
        '
        Me.lbl_ZonaP.AutoSize = True
        Me.lbl_ZonaP.Location = New System.Drawing.Point(23, 86)
        Me.lbl_ZonaP.Name = "lbl_ZonaP"
        Me.lbl_ZonaP.Size = New System.Drawing.Size(77, 16)
        Me.lbl_ZonaP.TabIndex = 94
        Me.lbl_ZonaP.Text = "Zona Postal: "
        '
        'cmb_Estado
        '
        Me.cmb_Estado.BackColor = System.Drawing.Color.GhostWhite
        Me.cmb_Estado.FormattingEnabled = True
        Me.cmb_Estado.Location = New System.Drawing.Point(101, 18)
        Me.cmb_Estado.Name = "cmb_Estado"
        Me.cmb_Estado.Size = New System.Drawing.Size(139, 24)
        Me.cmb_Estado.TabIndex = 93
        '
        'lbl_Estado
        '
        Me.lbl_Estado.AutoSize = True
        Me.lbl_Estado.Location = New System.Drawing.Point(51, 21)
        Me.lbl_Estado.Name = "lbl_Estado"
        Me.lbl_Estado.Size = New System.Drawing.Size(48, 16)
        Me.lbl_Estado.TabIndex = 92
        Me.lbl_Estado.Text = "Estado:"
        '
        'rtb_DireccionH
        '
        Me.rtb_DireccionH.BackColor = System.Drawing.Color.GhostWhite
        Me.rtb_DireccionH.Location = New System.Drawing.Point(394, 19)
        Me.rtb_DireccionH.MaxLength = 40
        Me.rtb_DireccionH.Name = "rtb_DireccionH"
        Me.rtb_DireccionH.Size = New System.Drawing.Size(273, 53)
        Me.rtb_DireccionH.TabIndex = 91
        Me.rtb_DireccionH.Text = ""
        '
        'cmb_Ciudad
        '
        Me.cmb_Ciudad.BackColor = System.Drawing.Color.GhostWhite
        Me.cmb_Ciudad.FormattingEnabled = True
        Me.cmb_Ciudad.Location = New System.Drawing.Point(101, 48)
        Me.cmb_Ciudad.Name = "cmb_Ciudad"
        Me.cmb_Ciudad.Size = New System.Drawing.Size(139, 24)
        Me.cmb_Ciudad.TabIndex = 90
        '
        'txt_Correro
        '
        Me.txt_Correro.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_Correro.Location = New System.Drawing.Point(101, 111)
        Me.txt_Correro.MaxLength = 20
        Me.txt_Correro.Name = "txt_Correro"
        Me.txt_Correro.Size = New System.Drawing.Size(165, 21)
        Me.txt_Correro.TabIndex = 81
        '
        'lbl_Correo
        '
        Me.lbl_Correo.AutoSize = True
        Me.lbl_Correo.Location = New System.Drawing.Point(53, 114)
        Me.lbl_Correo.Name = "lbl_Correo"
        Me.lbl_Correo.Size = New System.Drawing.Size(47, 16)
        Me.lbl_Correo.TabIndex = 80
        Me.lbl_Correo.Text = "Correo:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(247, 14)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(0, 16)
        Me.LinkLabel1.TabIndex = 76
        '
        'lbl_Ciudad
        '
        Me.lbl_Ciudad.AutoSize = True
        Me.lbl_Ciudad.Location = New System.Drawing.Point(51, 51)
        Me.lbl_Ciudad.Name = "lbl_Ciudad"
        Me.lbl_Ciudad.Size = New System.Drawing.Size(53, 16)
        Me.lbl_Ciudad.TabIndex = 67
        Me.lbl_Ciudad.Text = "Ciudad:"
        '
        'txt_TlfMovil
        '
        Me.txt_TlfMovil.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_TlfMovil.Location = New System.Drawing.Point(394, 111)
        Me.txt_TlfMovil.MaxLength = 11
        Me.txt_TlfMovil.Name = "txt_TlfMovil"
        Me.txt_TlfMovil.Size = New System.Drawing.Size(165, 21)
        Me.txt_TlfMovil.TabIndex = 65
        '
        'lbl_DireccionH
        '
        Me.lbl_DireccionH.AutoSize = True
        Me.lbl_DireccionH.Location = New System.Drawing.Point(252, 22)
        Me.lbl_DireccionH.Name = "lbl_DireccionH"
        Me.lbl_DireccionH.Size = New System.Drawing.Size(142, 16)
        Me.lbl_DireccionH.TabIndex = 64
        Me.lbl_DireccionH.Text = "Dirección de habitación:"
        '
        'txt_TlfFijo
        '
        Me.txt_TlfFijo.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_TlfFijo.Location = New System.Drawing.Point(395, 83)
        Me.txt_TlfFijo.MaxLength = 11
        Me.txt_TlfFijo.Name = "txt_TlfFijo"
        Me.txt_TlfFijo.Size = New System.Drawing.Size(164, 21)
        Me.txt_TlfFijo.TabIndex = 63
        '
        'lbl_TlfFijo
        '
        Me.lbl_TlfFijo.AutoSize = True
        Me.lbl_TlfFijo.Location = New System.Drawing.Point(315, 86)
        Me.lbl_TlfFijo.Name = "lbl_TlfFijo"
        Me.lbl_TlfFijo.Size = New System.Drawing.Size(73, 16)
        Me.lbl_TlfFijo.TabIndex = 62
        Me.lbl_TlfFijo.Text = "Teléfono fijo:"
        '
        'lbl_TlfMovil
        '
        Me.lbl_TlfMovil.AutoSize = True
        Me.lbl_TlfMovil.Location = New System.Drawing.Point(301, 114)
        Me.lbl_TlfMovil.Name = "lbl_TlfMovil"
        Me.lbl_TlfMovil.Size = New System.Drawing.Size(88, 16)
        Me.lbl_TlfMovil.TabIndex = 61
        Me.lbl_TlfMovil.Text = "Teléfono móvil:"
        '
        'grb_Sexo
        '
        Me.grb_Sexo.Controls.Add(Me.rdb_Femenino)
        Me.grb_Sexo.Controls.Add(Me.rdb_Masculino)
        Me.grb_Sexo.Location = New System.Drawing.Point(531, 50)
        Me.grb_Sexo.Name = "grb_Sexo"
        Me.grb_Sexo.Size = New System.Drawing.Size(51, 59)
        Me.grb_Sexo.TabIndex = 76
        Me.grb_Sexo.TabStop = False
        Me.grb_Sexo.Text = "Sexo"
        '
        'rdb_Femenino
        '
        Me.rdb_Femenino.AutoSize = True
        Me.rdb_Femenino.Location = New System.Drawing.Point(5, 33)
        Me.rdb_Femenino.Name = "rdb_Femenino"
        Me.rdb_Femenino.Size = New System.Drawing.Size(31, 20)
        Me.rdb_Femenino.TabIndex = 1
        Me.rdb_Femenino.TabStop = True
        Me.rdb_Femenino.Text = "F"
        Me.rdb_Femenino.UseVisualStyleBackColor = True
        '
        'rdb_Masculino
        '
        Me.rdb_Masculino.AutoSize = True
        Me.rdb_Masculino.Location = New System.Drawing.Point(5, 13)
        Me.rdb_Masculino.Name = "rdb_Masculino"
        Me.rdb_Masculino.Size = New System.Drawing.Size(37, 20)
        Me.rdb_Masculino.TabIndex = 0
        Me.rdb_Masculino.TabStop = True
        Me.rdb_Masculino.Text = "M"
        Me.rdb_Masculino.UseVisualStyleBackColor = True
        '
        'dtp_FNacimiento
        '
        Me.dtp_FNacimiento.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.dtp_FNacimiento.Location = New System.Drawing.Point(144, 119)
        Me.dtp_FNacimiento.Name = "dtp_FNacimiento"
        Me.dtp_FNacimiento.Size = New System.Drawing.Size(233, 21)
        Me.dtp_FNacimiento.TabIndex = 75
        '
        'lbl_FNacimiento
        '
        Me.lbl_FNacimiento.AutoSize = True
        Me.lbl_FNacimiento.Location = New System.Drawing.Point(11, 123)
        Me.lbl_FNacimiento.Name = "lbl_FNacimiento"
        Me.lbl_FNacimiento.Size = New System.Drawing.Size(127, 16)
        Me.lbl_FNacimiento.TabIndex = 73
        Me.lbl_FNacimiento.Text = "Fecha de nacimiento:"
        '
        'cmb_Nacionalidad
        '
        Me.cmb_Nacionalidad.AutoCompleteCustomSource.AddRange(New String() {"V", "E"})
        Me.cmb_Nacionalidad.BackColor = System.Drawing.Color.GhostWhite
        Me.cmb_Nacionalidad.FormattingEnabled = True
        Me.cmb_Nacionalidad.Location = New System.Drawing.Point(101, 19)
        Me.cmb_Nacionalidad.Name = "cmb_Nacionalidad"
        Me.cmb_Nacionalidad.Size = New System.Drawing.Size(47, 24)
        Me.cmb_Nacionalidad.TabIndex = 70
        '
        'txt_Cedula
        '
        Me.txt_Cedula.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_Cedula.Location = New System.Drawing.Point(154, 21)
        Me.txt_Cedula.MaxLength = 8
        Me.txt_Cedula.Name = "txt_Cedula"
        Me.txt_Cedula.Size = New System.Drawing.Size(112, 21)
        Me.txt_Cedula.TabIndex = 69
        '
        'lbl_Cedula
        '
        Me.lbl_Cedula.AutoSize = True
        Me.lbl_Cedula.Location = New System.Drawing.Point(45, 22)
        Me.lbl_Cedula.Name = "lbl_Cedula"
        Me.lbl_Cedula.Size = New System.Drawing.Size(52, 16)
        Me.lbl_Cedula.TabIndex = 68
        Me.lbl_Cedula.Text = "Cédula:"
        '
        'txt_SApellido
        '
        Me.txt_SApellido.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_SApellido.Location = New System.Drawing.Point(383, 88)
        Me.txt_SApellido.MaxLength = 15
        Me.txt_SApellido.Name = "txt_SApellido"
        Me.txt_SApellido.Size = New System.Drawing.Size(139, 21)
        Me.txt_SApellido.TabIndex = 60
        '
        'txt_SNombre
        '
        Me.txt_SNombre.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_SNombre.Location = New System.Drawing.Point(383, 56)
        Me.txt_SNombre.MaxLength = 15
        Me.txt_SNombre.Name = "txt_SNombre"
        Me.txt_SNombre.Size = New System.Drawing.Size(139, 21)
        Me.txt_SNombre.TabIndex = 59
        '
        'txt_PApellido
        '
        Me.txt_PApellido.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_PApellido.Location = New System.Drawing.Point(101, 89)
        Me.txt_PApellido.MaxLength = 15
        Me.txt_PApellido.Name = "txt_PApellido"
        Me.txt_PApellido.Size = New System.Drawing.Size(165, 21)
        Me.txt_PApellido.TabIndex = 58
        '
        'txt_PNombre
        '
        Me.txt_PNombre.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_PNombre.Location = New System.Drawing.Point(101, 56)
        Me.txt_PNombre.MaxLength = 15
        Me.txt_PNombre.Name = "txt_PNombre"
        Me.txt_PNombre.Size = New System.Drawing.Size(165, 21)
        Me.txt_PNombre.TabIndex = 57
        '
        'lbl_SApellido
        '
        Me.lbl_SApellido.AutoSize = True
        Me.lbl_SApellido.Location = New System.Drawing.Point(272, 96)
        Me.lbl_SApellido.Name = "lbl_SApellido"
        Me.lbl_SApellido.Size = New System.Drawing.Size(107, 16)
        Me.lbl_SApellido.TabIndex = 56
        Me.lbl_SApellido.Text = "Segundo apellido:"
        '
        'lbl_PApellido
        '
        Me.lbl_PApellido.AutoSize = True
        Me.lbl_PApellido.Location = New System.Drawing.Point(10, 96)
        Me.lbl_PApellido.Name = "lbl_PApellido"
        Me.lbl_PApellido.Size = New System.Drawing.Size(90, 16)
        Me.lbl_PApellido.TabIndex = 55
        Me.lbl_PApellido.Text = "Primer apellido:"
        '
        'lbl_SNombre
        '
        Me.lbl_SNombre.AutoSize = True
        Me.lbl_SNombre.Location = New System.Drawing.Point(272, 56)
        Me.lbl_SNombre.Name = "lbl_SNombre"
        Me.lbl_SNombre.Size = New System.Drawing.Size(105, 16)
        Me.lbl_SNombre.TabIndex = 54
        Me.lbl_SNombre.Text = "Segundo nombre:"
        '
        'lbl_PNombre
        '
        Me.lbl_PNombre.AutoSize = True
        Me.lbl_PNombre.Location = New System.Drawing.Point(11, 59)
        Me.lbl_PNombre.Name = "lbl_PNombre"
        Me.lbl_PNombre.Size = New System.Drawing.Size(88, 16)
        Me.lbl_PNombre.TabIndex = 53
        Me.lbl_PNombre.Text = "Primer nombre:"
        '
        'ptb_logo
        '
        Me.ptb_logo.BackColor = System.Drawing.Color.Transparent
        Me.ptb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptb_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptb_logo.Image = Global.SistemasIII.My.Resources.Resources.fondot
        Me.ptb_logo.Location = New System.Drawing.Point(0, -16)
        Me.ptb_logo.Name = "ptb_logo"
        Me.ptb_logo.Size = New System.Drawing.Size(162, 162)
        Me.ptb_logo.TabIndex = 106
        Me.ptb_logo.TabStop = False
        Me.ptb_logo.UseWaitCursor = True
        '
        'btn_Volver
        '
        Me.btn_Volver.Location = New System.Drawing.Point(474, 575)
        Me.btn_Volver.Name = "btn_Volver"
        Me.btn_Volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_Volver.TabIndex = 119
        Me.btn_Volver.Text = "Volver"
        Me.btn_Volver.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(355, 575)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 118
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Location = New System.Drawing.Point(238, 575)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Modificar.TabIndex = 117
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Location = New System.Drawing.Point(122, 575)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Agregar.TabIndex = 116
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'lbl_ActEconomica
        '
        Me.lbl_ActEconomica.AutoSize = True
        Me.lbl_ActEconomica.Location = New System.Drawing.Point(12, 60)
        Me.lbl_ActEconomica.Name = "lbl_ActEconomica"
        Me.lbl_ActEconomica.Size = New System.Drawing.Size(123, 16)
        Me.lbl_ActEconomica.TabIndex = 86
        Me.lbl_ActEconomica.Text = "Fecha de expiración:"
        '
        'txt_NumeroL
        '
        Me.txt_NumeroL.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_NumeroL.Location = New System.Drawing.Point(144, 19)
        Me.txt_NumeroL.MaxLength = 15
        Me.txt_NumeroL.Name = "txt_NumeroL"
        Me.txt_NumeroL.Size = New System.Drawing.Size(165, 21)
        Me.txt_NumeroL.TabIndex = 94
        '
        'txt_GradoL
        '
        Me.txt_GradoL.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_GradoL.Location = New System.Drawing.Point(416, 19)
        Me.txt_GradoL.MaxLength = 10
        Me.txt_GradoL.Name = "txt_GradoL"
        Me.txt_GradoL.Size = New System.Drawing.Size(165, 21)
        Me.txt_GradoL.TabIndex = 95
        '
        'lbl_NumeroL
        '
        Me.lbl_NumeroL.AutoSize = True
        Me.lbl_NumeroL.Location = New System.Drawing.Point(82, 22)
        Me.lbl_NumeroL.Name = "lbl_NumeroL"
        Me.lbl_NumeroL.Size = New System.Drawing.Size(53, 16)
        Me.lbl_NumeroL.TabIndex = 96
        Me.lbl_NumeroL.Text = "Número:"
        '
        'lbl_GradoL
        '
        Me.lbl_GradoL.AutoSize = True
        Me.lbl_GradoL.Location = New System.Drawing.Point(365, 22)
        Me.lbl_GradoL.Name = "lbl_GradoL"
        Me.lbl_GradoL.Size = New System.Drawing.Size(47, 16)
        Me.lbl_GradoL.TabIndex = 97
        Me.lbl_GradoL.Text = "Grado:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.DateTimePicker1.Location = New System.Drawing.Point(141, 57)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(233, 21)
        Me.DateTimePicker1.TabIndex = 94
        '
        'frm_Asegurado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SistemasIII.My.Resources.Resources.frm23
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(699, 603)
        Me.Controls.Add(Me.btn_Volver)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.lbl_EncabezadoSaludo)
        Me.Controls.Add(Me.lbl_Hora)
        Me.Controls.Add(Me.lbl_EncabezadoFormuladio)
        Me.Controls.Add(Me.lbl_EncabezadoModulo)
        Me.Controls.Add(Me.lbl_EncabezadoEmpresa)
        Me.Controls.Add(Me.grb_Licencia)
        Me.Controls.Add(Me.grb_Personales)
        Me.Controls.Add(Me.ptb_logo)
        Me.Name = "frm_Asegurado"
        Me.Text = "Form4"
        Me.grb_Licencia.ResumeLayout(False)
        Me.grb_Licencia.PerformLayout()
        Me.grb_Personales.ResumeLayout(False)
        Me.grb_Personales.PerformLayout()
        Me.grb_Edocivil.ResumeLayout(False)
        Me.grb_Edocivil.PerformLayout()
        Me.grb_DireccYContacto.ResumeLayout(False)
        Me.grb_DireccYContacto.PerformLayout()
        Me.grb_Sexo.ResumeLayout(False)
        Me.grb_Sexo.PerformLayout()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents grb_Licencia As GroupBox
    Friend WithEvents grb_Personales As GroupBox
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents grb_Edocivil As GroupBox
    Friend WithEvents rdb_Otro As RadioButton
    Friend WithEvents rdb_Divorciado As RadioButton
    Friend WithEvents rdb_Casado As RadioButton
    Friend WithEvents rdb_soltero As RadioButton
    Friend WithEvents grb_DireccYContacto As GroupBox
    Friend WithEvents txt_ZonaP As TextBox
    Friend WithEvents lbl_ZonaP As Label
    Friend WithEvents cmb_Estado As ComboBox
    Friend WithEvents lbl_Estado As Label
    Friend WithEvents rtb_DireccionH As RichTextBox
    Friend WithEvents cmb_Ciudad As ComboBox
    Friend WithEvents txt_Correro As TextBox
    Friend WithEvents lbl_Correo As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lbl_Ciudad As Label
    Friend WithEvents txt_TlfMovil As TextBox
    Friend WithEvents lbl_DireccionH As Label
    Friend WithEvents txt_TlfFijo As TextBox
    Friend WithEvents lbl_TlfFijo As Label
    Friend WithEvents lbl_TlfMovil As Label
    Friend WithEvents grb_Sexo As GroupBox
    Friend WithEvents rdb_Femenino As RadioButton
    Friend WithEvents rdb_Masculino As RadioButton
    Friend WithEvents dtp_FNacimiento As DateTimePicker
    Friend WithEvents lbl_FNacimiento As Label
    Friend WithEvents cmb_Nacionalidad As ComboBox
    Friend WithEvents txt_Cedula As TextBox
    Friend WithEvents lbl_Cedula As Label
    Friend WithEvents txt_SApellido As TextBox
    Friend WithEvents txt_SNombre As TextBox
    Friend WithEvents txt_PApellido As TextBox
    Friend WithEvents txt_PNombre As TextBox
    Friend WithEvents lbl_SApellido As Label
    Friend WithEvents lbl_PApellido As Label
    Friend WithEvents lbl_SNombre As Label
    Friend WithEvents lbl_PNombre As Label
    Friend WithEvents ptb_logo As PictureBox
    Friend WithEvents btn_Volver As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Modificar As Button
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lbl_GradoL As Label
    Friend WithEvents lbl_NumeroL As Label
    Friend WithEvents txt_GradoL As TextBox
    Friend WithEvents txt_NumeroL As TextBox
    Friend WithEvents lbl_ActEconomica As Label
End Class
