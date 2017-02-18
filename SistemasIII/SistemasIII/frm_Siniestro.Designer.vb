<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Siniestro
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
        Me.components = New System.ComponentModel.Container()
        Me.lbl_LugarSiniestro = New System.Windows.Forms.Label()
        Me.grb_Siniestro = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.grb_Lugar = New System.Windows.Forms.GroupBox()
        Me.rtb_Direccion = New System.Windows.Forms.RichTextBox()
        Me.cmb_Ciudad = New System.Windows.Forms.ComboBox()
        Me.cmb_Estado = New System.Windows.Forms.ComboBox()
        Me.lbl_Ciudad = New System.Windows.Forms.Label()
        Me.lbl_Estado = New System.Windows.Forms.Label()
        Me.lbl_Direccion = New System.Windows.Forms.Label()
        Me.dtp_HoraSin = New System.Windows.Forms.DateTimePicker()
        Me.btn_CargarArch = New System.Windows.Forms.Button()
        Me.txt_DocumentoTran = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_CargarImagen = New System.Windows.Forms.Button()
        Me.ptb_ImagenCarro = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_FechaSin = New System.Windows.Forms.DateTimePicker()
        Me.lbl_HoraSin = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_Descripcion = New System.Windows.Forms.Label()
        Me.grb_Poliza = New System.Windows.Forms.GroupBox()
        Me.btn_BuscarT = New System.Windows.Forms.Button()
        Me.cmb_NacionalidadT = New System.Windows.Forms.ComboBox()
        Me.txt_CedulaT = New System.Windows.Forms.TextBox()
        Me.lbl_CedulaT = New System.Windows.Forms.Label()
        Me.cmb_PlacaVeh = New System.Windows.Forms.ComboBox()
        Me.txt_CodPoliza = New System.Windows.Forms.TextBox()
        Me.lbl_PlacaVehiculo = New System.Windows.Forms.Label()
        Me.lbl_CodPoliza = New System.Windows.Forms.Label()
        Me.tmr_HoraSiniestro = New System.Windows.Forms.Timer(Me.components)
        Me.ofd_transito = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Volver = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoSaludo = New System.Windows.Forms.Label()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoFormuladio = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoModulo = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoEmpresa = New System.Windows.Forms.Label()
        Me.ptb_logo = New System.Windows.Forms.PictureBox()
        Me.btn_Consultar = New System.Windows.Forms.Button()
        Me.grb_Siniestro.SuspendLayout()
        Me.grb_Lugar.SuspendLayout()
        CType(Me.ptb_ImagenCarro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_Poliza.SuspendLayout()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_LugarSiniestro
        '
        Me.lbl_LugarSiniestro.AutoSize = True
        Me.lbl_LugarSiniestro.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_LugarSiniestro.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LugarSiniestro.Location = New System.Drawing.Point(581, 343)
        Me.lbl_LugarSiniestro.Name = "lbl_LugarSiniestro"
        Me.lbl_LugarSiniestro.Size = New System.Drawing.Size(0, 16)
        Me.lbl_LugarSiniestro.TabIndex = 13
        '
        'grb_Siniestro
        '
        Me.grb_Siniestro.Controls.Add(Me.RichTextBox1)
        Me.grb_Siniestro.Controls.Add(Me.grb_Lugar)
        Me.grb_Siniestro.Controls.Add(Me.dtp_HoraSin)
        Me.grb_Siniestro.Controls.Add(Me.btn_CargarArch)
        Me.grb_Siniestro.Controls.Add(Me.txt_DocumentoTran)
        Me.grb_Siniestro.Controls.Add(Me.Label7)
        Me.grb_Siniestro.Controls.Add(Me.btn_CargarImagen)
        Me.grb_Siniestro.Controls.Add(Me.ptb_ImagenCarro)
        Me.grb_Siniestro.Controls.Add(Me.Label6)
        Me.grb_Siniestro.Controls.Add(Me.dtp_FechaSin)
        Me.grb_Siniestro.Controls.Add(Me.lbl_HoraSin)
        Me.grb_Siniestro.Controls.Add(Me.Label3)
        Me.grb_Siniestro.Controls.Add(Me.lbl_Descripcion)
        Me.grb_Siniestro.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Siniestro.Location = New System.Drawing.Point(6, 227)
        Me.grb_Siniestro.Name = "grb_Siniestro"
        Me.grb_Siniestro.Size = New System.Drawing.Size(628, 306)
        Me.grb_Siniestro.TabIndex = 19
        Me.grb_Siniestro.TabStop = False
        Me.grb_Siniestro.Text = "DATOS DEL SINIESTRO"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(85, 154)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(312, 58)
        Me.RichTextBox1.TabIndex = 32
        Me.RichTextBox1.Text = ""
        '
        'grb_Lugar
        '
        Me.grb_Lugar.Controls.Add(Me.rtb_Direccion)
        Me.grb_Lugar.Controls.Add(Me.cmb_Ciudad)
        Me.grb_Lugar.Controls.Add(Me.cmb_Estado)
        Me.grb_Lugar.Controls.Add(Me.lbl_Ciudad)
        Me.grb_Lugar.Controls.Add(Me.lbl_Estado)
        Me.grb_Lugar.Controls.Add(Me.lbl_Direccion)
        Me.grb_Lugar.Location = New System.Drawing.Point(10, 20)
        Me.grb_Lugar.Name = "grb_Lugar"
        Me.grb_Lugar.Size = New System.Drawing.Size(390, 98)
        Me.grb_Lugar.TabIndex = 31
        Me.grb_Lugar.TabStop = False
        Me.grb_Lugar.Text = "Lugar"
        '
        'rtb_Direccion
        '
        Me.rtb_Direccion.Location = New System.Drawing.Point(69, 46)
        Me.rtb_Direccion.Name = "rtb_Direccion"
        Me.rtb_Direccion.Size = New System.Drawing.Size(306, 46)
        Me.rtb_Direccion.TabIndex = 8
        Me.rtb_Direccion.Text = ""
        '
        'cmb_Ciudad
        '
        Me.cmb_Ciudad.FormattingEnabled = True
        Me.cmb_Ciudad.Location = New System.Drawing.Point(254, 16)
        Me.cmb_Ciudad.Name = "cmb_Ciudad"
        Me.cmb_Ciudad.Size = New System.Drawing.Size(121, 24)
        Me.cmb_Ciudad.TabIndex = 7
        '
        'cmb_Estado
        '
        Me.cmb_Estado.FormattingEnabled = True
        Me.cmb_Estado.Location = New System.Drawing.Point(69, 16)
        Me.cmb_Estado.Name = "cmb_Estado"
        Me.cmb_Estado.Size = New System.Drawing.Size(121, 24)
        Me.cmb_Estado.TabIndex = 6
        '
        'lbl_Ciudad
        '
        Me.lbl_Ciudad.AutoSize = True
        Me.lbl_Ciudad.Location = New System.Drawing.Point(196, 19)
        Me.lbl_Ciudad.Name = "lbl_Ciudad"
        Me.lbl_Ciudad.Size = New System.Drawing.Size(53, 16)
        Me.lbl_Ciudad.TabIndex = 5
        Me.lbl_Ciudad.Text = "Ciudad:"
        '
        'lbl_Estado
        '
        Me.lbl_Estado.AutoSize = True
        Me.lbl_Estado.Location = New System.Drawing.Point(19, 19)
        Me.lbl_Estado.Name = "lbl_Estado"
        Me.lbl_Estado.Size = New System.Drawing.Size(48, 16)
        Me.lbl_Estado.TabIndex = 4
        Me.lbl_Estado.Text = "Estado:"
        '
        'lbl_Direccion
        '
        Me.lbl_Direccion.AutoSize = True
        Me.lbl_Direccion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Direccion.Location = New System.Drawing.Point(6, 46)
        Me.lbl_Direccion.Name = "lbl_Direccion"
        Me.lbl_Direccion.Size = New System.Drawing.Size(61, 16)
        Me.lbl_Direccion.TabIndex = 2
        Me.lbl_Direccion.Text = "Dirección:"
        '
        'dtp_HoraSin
        '
        Me.dtp_HoraSin.Enabled = False
        Me.dtp_HoraSin.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_HoraSin.Location = New System.Drawing.Point(318, 123)
        Me.dtp_HoraSin.Name = "dtp_HoraSin"
        Me.dtp_HoraSin.Size = New System.Drawing.Size(82, 21)
        Me.dtp_HoraSin.TabIndex = 30
        '
        'btn_CargarArch
        '
        Me.btn_CargarArch.Enabled = False
        Me.btn_CargarArch.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CargarArch.Location = New System.Drawing.Point(138, 271)
        Me.btn_CargarArch.Name = "btn_CargarArch"
        Me.btn_CargarArch.Size = New System.Drawing.Size(149, 24)
        Me.btn_CargarArch.TabIndex = 26
        Me.btn_CargarArch.Text = "Cargar Archivo PDF"
        Me.btn_CargarArch.UseVisualStyleBackColor = True
        '
        'txt_DocumentoTran
        '
        Me.txt_DocumentoTran.Enabled = False
        Me.txt_DocumentoTran.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DocumentoTran.Location = New System.Drawing.Point(11, 244)
        Me.txt_DocumentoTran.Name = "txt_DocumentoTran"
        Me.txt_DocumentoTran.Size = New System.Drawing.Size(386, 21)
        Me.txt_DocumentoTran.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Informe de Transito:"
        '
        'btn_CargarImagen
        '
        Me.btn_CargarImagen.Enabled = False
        Me.btn_CargarImagen.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CargarImagen.Location = New System.Drawing.Point(443, 218)
        Me.btn_CargarImagen.Name = "btn_CargarImagen"
        Me.btn_CargarImagen.Size = New System.Drawing.Size(144, 24)
        Me.btn_CargarImagen.TabIndex = 23
        Me.btn_CargarImagen.Text = "Cargar Imagen JPG"
        Me.btn_CargarImagen.UseVisualStyleBackColor = True
        '
        'ptb_ImagenCarro
        '
        Me.ptb_ImagenCarro.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ptb_ImagenCarro.Location = New System.Drawing.Point(415, 49)
        Me.ptb_ImagenCarro.Name = "ptb_ImagenCarro"
        Me.ptb_ImagenCarro.Size = New System.Drawing.Size(198, 163)
        Me.ptb_ImagenCarro.TabIndex = 22
        Me.ptb_ImagenCarro.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(445, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Imagen del Vehículo:"
        '
        'dtp_FechaSin
        '
        Me.dtp_FechaSin.Enabled = False
        Me.dtp_FechaSin.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FechaSin.Location = New System.Drawing.Point(56, 123)
        Me.dtp_FechaSin.Name = "dtp_FechaSin"
        Me.dtp_FechaSin.Size = New System.Drawing.Size(218, 21)
        Me.dtp_FechaSin.TabIndex = 20
        '
        'lbl_HoraSin
        '
        Me.lbl_HoraSin.AutoSize = True
        Me.lbl_HoraSin.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HoraSin.Location = New System.Drawing.Point(278, 127)
        Me.lbl_HoraSin.Name = "lbl_HoraSin"
        Me.lbl_HoraSin.Size = New System.Drawing.Size(34, 16)
        Me.lbl_HoraSin.TabIndex = 6
        Me.lbl_HoraSin.Text = "Hora"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha:"
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Descripcion.Location = New System.Drawing.Point(6, 157)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(73, 16)
        Me.lbl_Descripcion.TabIndex = 1
        Me.lbl_Descripcion.Text = "Descripción:"
        '
        'grb_Poliza
        '
        Me.grb_Poliza.Controls.Add(Me.btn_Consultar)
        Me.grb_Poliza.Controls.Add(Me.btn_BuscarT)
        Me.grb_Poliza.Controls.Add(Me.cmb_NacionalidadT)
        Me.grb_Poliza.Controls.Add(Me.txt_CedulaT)
        Me.grb_Poliza.Controls.Add(Me.lbl_CedulaT)
        Me.grb_Poliza.Controls.Add(Me.cmb_PlacaVeh)
        Me.grb_Poliza.Controls.Add(Me.txt_CodPoliza)
        Me.grb_Poliza.Controls.Add(Me.lbl_PlacaVehiculo)
        Me.grb_Poliza.Controls.Add(Me.lbl_CodPoliza)
        Me.grb_Poliza.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Poliza.Location = New System.Drawing.Point(6, 151)
        Me.grb_Poliza.Name = "grb_Poliza"
        Me.grb_Poliza.Size = New System.Drawing.Size(628, 76)
        Me.grb_Poliza.TabIndex = 20
        Me.grb_Poliza.TabStop = False
        Me.grb_Poliza.Text = "Datos de la póliza"
        '
        'btn_BuscarT
        '
        Me.btn_BuscarT.Location = New System.Drawing.Point(281, 16)
        Me.btn_BuscarT.Name = "btn_BuscarT"
        Me.btn_BuscarT.Size = New System.Drawing.Size(75, 23)
        Me.btn_BuscarT.TabIndex = 109
        Me.btn_BuscarT.Text = "Buscar"
        Me.btn_BuscarT.UseVisualStyleBackColor = True
        '
        'cmb_NacionalidadT
        '
        Me.cmb_NacionalidadT.AutoCompleteCustomSource.AddRange(New String() {"V", "E"})
        Me.cmb_NacionalidadT.BackColor = System.Drawing.Color.GhostWhite
        Me.cmb_NacionalidadT.FormattingEnabled = True
        Me.cmb_NacionalidadT.Location = New System.Drawing.Point(136, 16)
        Me.cmb_NacionalidadT.Name = "cmb_NacionalidadT"
        Me.cmb_NacionalidadT.Size = New System.Drawing.Size(47, 24)
        Me.cmb_NacionalidadT.TabIndex = 108
        '
        'txt_CedulaT
        '
        Me.txt_CedulaT.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_CedulaT.Location = New System.Drawing.Point(189, 16)
        Me.txt_CedulaT.MaxLength = 8
        Me.txt_CedulaT.Name = "txt_CedulaT"
        Me.txt_CedulaT.Size = New System.Drawing.Size(85, 21)
        Me.txt_CedulaT.TabIndex = 107
        '
        'lbl_CedulaT
        '
        Me.lbl_CedulaT.AutoSize = True
        Me.lbl_CedulaT.Location = New System.Drawing.Point(8, 19)
        Me.lbl_CedulaT.Name = "lbl_CedulaT"
        Me.lbl_CedulaT.Size = New System.Drawing.Size(122, 16)
        Me.lbl_CedulaT.TabIndex = 106
        Me.lbl_CedulaT.Text = "Cédula del tomador:"
        '
        'cmb_PlacaVeh
        '
        Me.cmb_PlacaVeh.Enabled = False
        Me.cmb_PlacaVeh.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_PlacaVeh.FormattingEnabled = True
        Me.cmb_PlacaVeh.Location = New System.Drawing.Point(123, 46)
        Me.cmb_PlacaVeh.Name = "cmb_PlacaVeh"
        Me.cmb_PlacaVeh.Size = New System.Drawing.Size(92, 24)
        Me.cmb_PlacaVeh.TabIndex = 8
        '
        'txt_CodPoliza
        '
        Me.txt_CodPoliza.Enabled = False
        Me.txt_CodPoliza.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CodPoliza.Location = New System.Drawing.Point(376, 38)
        Me.txt_CodPoliza.Name = "txt_CodPoliza"
        Me.txt_CodPoliza.Size = New System.Drawing.Size(136, 21)
        Me.txt_CodPoliza.TabIndex = 7
        Me.txt_CodPoliza.Text = "Aparezca luego de la placa"
        '
        'lbl_PlacaVehiculo
        '
        Me.lbl_PlacaVehiculo.AutoSize = True
        Me.lbl_PlacaVehiculo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PlacaVehiculo.Location = New System.Drawing.Point(17, 49)
        Me.lbl_PlacaVehiculo.Name = "lbl_PlacaVehiculo"
        Me.lbl_PlacaVehiculo.Size = New System.Drawing.Size(113, 16)
        Me.lbl_PlacaVehiculo.TabIndex = 6
        Me.lbl_PlacaVehiculo.Text = "Placa del vehículo:"
        '
        'lbl_CodPoliza
        '
        Me.lbl_CodPoliza.AutoSize = True
        Me.lbl_CodPoliza.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CodPoliza.Location = New System.Drawing.Point(373, 19)
        Me.lbl_CodPoliza.Name = "lbl_CodPoliza"
        Me.lbl_CodPoliza.Size = New System.Drawing.Size(114, 16)
        Me.lbl_CodPoliza.TabIndex = 4
        Me.lbl_CodPoliza.Text = "Código de la póliza"
        '
        'tmr_HoraSiniestro
        '
        '
        'ofd_transito
        '
        Me.ofd_transito.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(122, -123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 117
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"V", "E"})
        Me.ComboBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(-23, -123)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(47, 21)
        Me.ComboBox1.TabIndex = 116
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.TextBox1.Location = New System.Drawing.Point(30, -123)
        Me.TextBox1.MaxLength = 8
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(85, 20)
        Me.TextBox1.TabIndex = 115
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-81, -120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Cédula:"
        '
        'btn_Volver
        '
        Me.btn_Volver.Location = New System.Drawing.Point(400, 552)
        Me.btn_Volver.Name = "btn_Volver"
        Me.btn_Volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_Volver.TabIndex = 119
        Me.btn_Volver.Text = "Volver"
        Me.btn_Volver.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(287, 552)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 118
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Location = New System.Drawing.Point(61, 552)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Agregar.TabIndex = 120
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Location = New System.Drawing.Point(174, 552)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Modificar.TabIndex = 121
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fecha.Location = New System.Drawing.Point(516, 19)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Fecha.TabIndex = 131
        Me.lbl_Fecha.Text = "dd/MM/YY"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Usuario.Location = New System.Drawing.Point(587, 69)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Usuario.TabIndex = 130
        Me.lbl_Usuario.Text = "Usuario"
        '
        'lbl_EncabezadoSaludo
        '
        Me.lbl_EncabezadoSaludo.AutoSize = True
        Me.lbl_EncabezadoSaludo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoSaludo.Location = New System.Drawing.Point(546, 69)
        Me.lbl_EncabezadoSaludo.Name = "lbl_EncabezadoSaludo"
        Me.lbl_EncabezadoSaludo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_EncabezadoSaludo.TabIndex = 129
        Me.lbl_EncabezadoSaludo.Text = "Hola, "
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Hora.Location = New System.Drawing.Point(580, 19)
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
        Me.lbl_EncabezadoFormuladio.Location = New System.Drawing.Point(218, 104)
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
        Me.lbl_EncabezadoModulo.Location = New System.Drawing.Point(226, 60)
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
        Me.lbl_EncabezadoEmpresa.Location = New System.Drawing.Point(184, 15)
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
        Me.ptb_logo.Location = New System.Drawing.Point(2, 2)
        Me.ptb_logo.Name = "ptb_logo"
        Me.ptb_logo.Size = New System.Drawing.Size(132, 132)
        Me.ptb_logo.TabIndex = 124
        Me.ptb_logo.TabStop = False
        Me.ptb_logo.UseWaitCursor = True
        '
        'btn_Consultar
        '
        Me.btn_Consultar.Location = New System.Drawing.Point(527, 38)
        Me.btn_Consultar.Name = "btn_Consultar"
        Me.btn_Consultar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Consultar.TabIndex = 121
        Me.btn_Consultar.Text = "Consultar"
        Me.btn_Consultar.UseVisualStyleBackColor = True
        '
        'frm_Siniestro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.SistemasIII.My.Resources.Resources.frm23
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(646, 587)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.lbl_EncabezadoSaludo)
        Me.Controls.Add(Me.lbl_Hora)
        Me.Controls.Add(Me.lbl_EncabezadoFormuladio)
        Me.Controls.Add(Me.lbl_EncabezadoModulo)
        Me.Controls.Add(Me.lbl_EncabezadoEmpresa)
        Me.Controls.Add(Me.ptb_logo)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Volver)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.grb_Poliza)
        Me.Controls.Add(Me.grb_Siniestro)
        Me.Controls.Add(Me.lbl_LugarSiniestro)
        Me.Name = "frm_Siniestro"
        Me.Text = "frm_Siniestro"
        Me.grb_Siniestro.ResumeLayout(False)
        Me.grb_Siniestro.PerformLayout()
        Me.grb_Lugar.ResumeLayout(False)
        Me.grb_Lugar.PerformLayout()
        CType(Me.ptb_ImagenCarro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_Poliza.ResumeLayout(False)
        Me.grb_Poliza.PerformLayout()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_LugarSiniestro As System.Windows.Forms.Label
    Friend WithEvents grb_Siniestro As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_Direccion As System.Windows.Forms.Label
    Friend WithEvents lbl_Descripcion As System.Windows.Forms.Label
    Friend WithEvents lbl_HoraSin As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaSin As System.Windows.Forms.DateTimePicker
    Friend WithEvents grb_Poliza As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_PlacaVehiculo As System.Windows.Forms.Label
    Friend WithEvents lbl_CodPoliza As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_CargarImagen As System.Windows.Forms.Button
    Friend WithEvents ptb_ImagenCarro As System.Windows.Forms.PictureBox
    Friend WithEvents cmb_PlacaVeh As System.Windows.Forms.ComboBox
    Friend WithEvents txt_CodPoliza As System.Windows.Forms.TextBox
    Friend WithEvents txt_DocumentoTran As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_CargarArch As System.Windows.Forms.Button
    Friend WithEvents tmr_HoraSiniestro As System.Windows.Forms.Timer
    Friend WithEvents ofd_transito As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dtp_HoraSin As System.Windows.Forms.DateTimePicker
    Friend WithEvents grb_Lugar As GroupBox
    Friend WithEvents cmb_Ciudad As ComboBox
    Friend WithEvents cmb_Estado As ComboBox
    Friend WithEvents lbl_Ciudad As Label
    Friend WithEvents lbl_Estado As Label
    Friend WithEvents btn_BuscarT As Button
    Friend WithEvents cmb_NacionalidadT As ComboBox
    Friend WithEvents txt_CedulaT As TextBox
    Friend WithEvents lbl_CedulaT As Label
    Friend WithEvents rtb_Direccion As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Volver As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents btn_Modificar As Button
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents lbl_EncabezadoSaludo As Label
    Friend WithEvents lbl_Hora As Label
    Friend WithEvents lbl_EncabezadoFormuladio As Label
    Friend WithEvents lbl_EncabezadoModulo As Label
    Friend WithEvents lbl_EncabezadoEmpresa As Label
    Friend WithEvents ptb_logo As PictureBox
    Friend WithEvents btn_Consultar As Button
End Class
