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
        Me.lbl_GestionSiniestro = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_LugarSiniestro = New System.Windows.Forms.Label()
        Me.grb_DatosSiniestro = New System.Windows.Forms.GroupBox()
        Me.dtp_HoraSin = New System.Windows.Forms.DateTimePicker()
        Me.dtp_CitaPerito = New System.Windows.Forms.DateTimePicker()
        Me.lbl_CitaPerito = New System.Windows.Forms.Label()
        Me.lbl_RutaImagen = New System.Windows.Forms.Label()
        Me.btn_CargarArch = New System.Windows.Forms.Button()
        Me.txt_DocumentoTran = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_CargarImagen = New System.Windows.Forms.Button()
        Me.ptb_ImagenCarro = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_FechaSin = New System.Windows.Forms.DateTimePicker()
        Me.lbl_HoraSin = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_LugarSiniestro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_DescSiniestro = New System.Windows.Forms.Label()
        Me.txt_DescripcionSin = New System.Windows.Forms.TextBox()
        Me.grb_DatosOtros = New System.Windows.Forms.GroupBox()
        Me.btn_BuscarCedTom = New System.Windows.Forms.Button()
        Me.cmb_PlacaVeh = New System.Windows.Forms.ComboBox()
        Me.txt_CodPoliza = New System.Windows.Forms.TextBox()
        Me.lbl_PlacaVehiculo = New System.Windows.Forms.Label()
        Me.lbl_CodPoliza = New System.Windows.Forms.Label()
        Me.txt_CedulaTom = New System.Windows.Forms.TextBox()
        Me.cmb_RazonSocial = New System.Windows.Forms.ComboBox()
        Me.lbl_CedulaTomador = New System.Windows.Forms.Label()
        Me.lbl_CargoActual = New System.Windows.Forms.Label()
        Me.lbl_UsuarioActual = New System.Windows.Forms.Label()
        Me.lbl_HorafSiniestro = New System.Windows.Forms.Label()
        Me.tmr_HoraSiniestro = New System.Windows.Forms.Timer(Me.components)
        Me.ofd_transito = New System.Windows.Forms.OpenFileDialog()
        Me.btn_GuardarSin = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_DatosSiniestro.SuspendLayout()
        CType(Me.ptb_ImagenCarro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_DatosOtros.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_GestionSiniestro
        '
        Me.lbl_GestionSiniestro.AutoSize = True
        Me.lbl_GestionSiniestro.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GestionSiniestro.Location = New System.Drawing.Point(244, 69)
        Me.lbl_GestionSiniestro.Name = "lbl_GestionSiniestro"
        Me.lbl_GestionSiniestro.Size = New System.Drawing.Size(252, 23)
        Me.lbl_GestionSiniestro.TabIndex = 9
        Me.lbl_GestionSiniestro.Text = "GESTIÓN DE SINIESTRO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(228, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "SEGUROS MALDONADO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 115)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'lbl_LugarSiniestro
        '
        Me.lbl_LugarSiniestro.AutoSize = True
        Me.lbl_LugarSiniestro.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_LugarSiniestro.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LugarSiniestro.Location = New System.Drawing.Point(581, 343)
        Me.lbl_LugarSiniestro.Name = "lbl_LugarSiniestro"
        Me.lbl_LugarSiniestro.Size = New System.Drawing.Size(0, 16)
        Me.lbl_LugarSiniestro.TabIndex = 13
        '
        'grb_DatosSiniestro
        '
        Me.grb_DatosSiniestro.Controls.Add(Me.btn_GuardarSin)
        Me.grb_DatosSiniestro.Controls.Add(Me.dtp_HoraSin)
        Me.grb_DatosSiniestro.Controls.Add(Me.dtp_CitaPerito)
        Me.grb_DatosSiniestro.Controls.Add(Me.lbl_CitaPerito)
        Me.grb_DatosSiniestro.Controls.Add(Me.lbl_RutaImagen)
        Me.grb_DatosSiniestro.Controls.Add(Me.btn_CargarArch)
        Me.grb_DatosSiniestro.Controls.Add(Me.txt_DocumentoTran)
        Me.grb_DatosSiniestro.Controls.Add(Me.Label7)
        Me.grb_DatosSiniestro.Controls.Add(Me.btn_CargarImagen)
        Me.grb_DatosSiniestro.Controls.Add(Me.ptb_ImagenCarro)
        Me.grb_DatosSiniestro.Controls.Add(Me.Label6)
        Me.grb_DatosSiniestro.Controls.Add(Me.dtp_FechaSin)
        Me.grb_DatosSiniestro.Controls.Add(Me.lbl_HoraSin)
        Me.grb_DatosSiniestro.Controls.Add(Me.Label3)
        Me.grb_DatosSiniestro.Controls.Add(Me.txt_LugarSiniestro)
        Me.grb_DatosSiniestro.Controls.Add(Me.Label2)
        Me.grb_DatosSiniestro.Controls.Add(Me.lbl_DescSiniestro)
        Me.grb_DatosSiniestro.Controls.Add(Me.txt_DescripcionSin)
        Me.grb_DatosSiniestro.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_DatosSiniestro.Location = New System.Drawing.Point(13, 258)
        Me.grb_DatosSiniestro.Name = "grb_DatosSiniestro"
        Me.grb_DatosSiniestro.Size = New System.Drawing.Size(704, 306)
        Me.grb_DatosSiniestro.TabIndex = 19
        Me.grb_DatosSiniestro.TabStop = False
        Me.grb_DatosSiniestro.Text = "DATOS DEL SINIESTRO"
        '
        'dtp_HoraSin
        '
        Me.dtp_HoraSin.Enabled = False
        Me.dtp_HoraSin.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_HoraSin.Location = New System.Drawing.Point(346, 80)
        Me.dtp_HoraSin.Name = "dtp_HoraSin"
        Me.dtp_HoraSin.Size = New System.Drawing.Size(120, 23)
        Me.dtp_HoraSin.TabIndex = 30
        '
        'dtp_CitaPerito
        '
        Me.dtp_CitaPerito.Enabled = False
        Me.dtp_CitaPerito.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_CitaPerito.Location = New System.Drawing.Point(88, 169)
        Me.dtp_CitaPerito.Name = "dtp_CitaPerito"
        Me.dtp_CitaPerito.Size = New System.Drawing.Size(375, 23)
        Me.dtp_CitaPerito.TabIndex = 29
        '
        'lbl_CitaPerito
        '
        Me.lbl_CitaPerito.AutoSize = True
        Me.lbl_CitaPerito.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CitaPerito.Location = New System.Drawing.Point(6, 169)
        Me.lbl_CitaPerito.Name = "lbl_CitaPerito"
        Me.lbl_CitaPerito.Size = New System.Drawing.Size(73, 16)
        Me.lbl_CitaPerito.TabIndex = 28
        Me.lbl_CitaPerito.Text = "Cita Perito"
        '
        'lbl_RutaImagen
        '
        Me.lbl_RutaImagen.AutoSize = True
        Me.lbl_RutaImagen.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RutaImagen.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_RutaImagen.Location = New System.Drawing.Point(501, 277)
        Me.lbl_RutaImagen.Name = "lbl_RutaImagen"
        Me.lbl_RutaImagen.Size = New System.Drawing.Size(187, 15)
        Me.lbl_RutaImagen.TabIndex = 27
        Me.lbl_RutaImagen.Text = "                                                            "
        '
        'btn_CargarArch
        '
        Me.btn_CargarArch.Enabled = False
        Me.btn_CargarArch.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CargarArch.Location = New System.Drawing.Point(137, 241)
        Me.btn_CargarArch.Name = "btn_CargarArch"
        Me.btn_CargarArch.Size = New System.Drawing.Size(149, 24)
        Me.btn_CargarArch.TabIndex = 26
        Me.btn_CargarArch.Text = "Cargar Archivo PDF"
        Me.btn_CargarArch.UseVisualStyleBackColor = True
        '
        'txt_DocumentoTran
        '
        Me.txt_DocumentoTran.Enabled = False
        Me.txt_DocumentoTran.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DocumentoTran.Location = New System.Drawing.Point(137, 214)
        Me.txt_DocumentoTran.Name = "txt_DocumentoTran"
        Me.txt_DocumentoTran.Size = New System.Drawing.Size(326, 21)
        Me.txt_DocumentoTran.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Informe de Transito"
        '
        'btn_CargarImagen
        '
        Me.btn_CargarImagen.Enabled = False
        Me.btn_CargarImagen.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CargarImagen.Location = New System.Drawing.Point(533, 223)
        Me.btn_CargarImagen.Name = "btn_CargarImagen"
        Me.btn_CargarImagen.Size = New System.Drawing.Size(144, 24)
        Me.btn_CargarImagen.TabIndex = 23
        Me.btn_CargarImagen.Text = "Cargar Imagen JPG"
        Me.btn_CargarImagen.UseVisualStyleBackColor = True
        '
        'ptb_ImagenCarro
        '
        Me.ptb_ImagenCarro.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ptb_ImagenCarro.Location = New System.Drawing.Point(500, 54)
        Me.ptb_ImagenCarro.Name = "ptb_ImagenCarro"
        Me.ptb_ImagenCarro.Size = New System.Drawing.Size(198, 163)
        Me.ptb_ImagenCarro.TabIndex = 22
        Me.ptb_ImagenCarro.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(530, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Imagen del Vehiculo:"
        '
        'dtp_FechaSin
        '
        Me.dtp_FechaSin.Enabled = False
        Me.dtp_FechaSin.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FechaSin.Location = New System.Drawing.Point(65, 78)
        Me.dtp_FechaSin.Name = "dtp_FechaSin"
        Me.dtp_FechaSin.Size = New System.Drawing.Size(221, 22)
        Me.dtp_FechaSin.TabIndex = 20
        '
        'lbl_HoraSin
        '
        Me.lbl_HoraSin.AutoSize = True
        Me.lbl_HoraSin.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HoraSin.Location = New System.Drawing.Point(302, 81)
        Me.lbl_HoraSin.Name = "lbl_HoraSin"
        Me.lbl_HoraSin.Size = New System.Drawing.Size(38, 16)
        Me.lbl_HoraSin.TabIndex = 6
        Me.lbl_HoraSin.Text = "Hora"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha"
        '
        'txt_LugarSiniestro
        '
        Me.txt_LugarSiniestro.Enabled = False
        Me.txt_LugarSiniestro.Location = New System.Drawing.Point(65, 30)
        Me.txt_LugarSiniestro.Name = "txt_LugarSiniestro"
        Me.txt_LugarSiniestro.Size = New System.Drawing.Size(401, 23)
        Me.txt_LugarSiniestro.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Lugar"
        '
        'lbl_DescSiniestro
        '
        Me.lbl_DescSiniestro.AutoSize = True
        Me.lbl_DescSiniestro.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DescSiniestro.Location = New System.Drawing.Point(5, 123)
        Me.lbl_DescSiniestro.Name = "lbl_DescSiniestro"
        Me.lbl_DescSiniestro.Size = New System.Drawing.Size(77, 16)
        Me.lbl_DescSiniestro.TabIndex = 1
        Me.lbl_DescSiniestro.Text = "Descripción"
        '
        'txt_DescripcionSin
        '
        Me.txt_DescripcionSin.Enabled = False
        Me.txt_DescripcionSin.Location = New System.Drawing.Point(88, 123)
        Me.txt_DescripcionSin.Name = "txt_DescripcionSin"
        Me.txt_DescripcionSin.Size = New System.Drawing.Size(378, 23)
        Me.txt_DescripcionSin.TabIndex = 0
        '
        'grb_DatosOtros
        '
        Me.grb_DatosOtros.Controls.Add(Me.btn_BuscarCedTom)
        Me.grb_DatosOtros.Controls.Add(Me.cmb_PlacaVeh)
        Me.grb_DatosOtros.Controls.Add(Me.txt_CodPoliza)
        Me.grb_DatosOtros.Controls.Add(Me.lbl_PlacaVehiculo)
        Me.grb_DatosOtros.Controls.Add(Me.lbl_CodPoliza)
        Me.grb_DatosOtros.Controls.Add(Me.txt_CedulaTom)
        Me.grb_DatosOtros.Controls.Add(Me.cmb_RazonSocial)
        Me.grb_DatosOtros.Controls.Add(Me.lbl_CedulaTomador)
        Me.grb_DatosOtros.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_DatosOtros.Location = New System.Drawing.Point(12, 154)
        Me.grb_DatosOtros.Name = "grb_DatosOtros"
        Me.grb_DatosOtros.Size = New System.Drawing.Size(704, 98)
        Me.grb_DatosOtros.TabIndex = 20
        Me.grb_DatosOtros.TabStop = False
        Me.grb_DatosOtros.Text = "DATOS DE LA PÓLIZA"
        '
        'btn_BuscarCedTom
        '
        Me.btn_BuscarCedTom.Location = New System.Drawing.Point(270, 29)
        Me.btn_BuscarCedTom.Name = "btn_BuscarCedTom"
        Me.btn_BuscarCedTom.Size = New System.Drawing.Size(80, 25)
        Me.btn_BuscarCedTom.TabIndex = 9
        Me.btn_BuscarCedTom.Text = "Buscar"
        Me.btn_BuscarCedTom.UseVisualStyleBackColor = True
        '
        'cmb_PlacaVeh
        '
        Me.cmb_PlacaVeh.Enabled = False
        Me.cmb_PlacaVeh.FormattingEnabled = True
        Me.cmb_PlacaVeh.Location = New System.Drawing.Point(112, 68)
        Me.cmb_PlacaVeh.Name = "cmb_PlacaVeh"
        Me.cmb_PlacaVeh.Size = New System.Drawing.Size(92, 24)
        Me.cmb_PlacaVeh.TabIndex = 8
        '
        'txt_CodPoliza
        '
        Me.txt_CodPoliza.Enabled = False
        Me.txt_CodPoliza.Location = New System.Drawing.Point(462, 48)
        Me.txt_CodPoliza.Name = "txt_CodPoliza"
        Me.txt_CodPoliza.Size = New System.Drawing.Size(219, 23)
        Me.txt_CodPoliza.TabIndex = 7
        Me.txt_CodPoliza.Text = "Aparezca luego de la placa"
        '
        'lbl_PlacaVehiculo
        '
        Me.lbl_PlacaVehiculo.AutoSize = True
        Me.lbl_PlacaVehiculo.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PlacaVehiculo.Location = New System.Drawing.Point(7, 71)
        Me.lbl_PlacaVehiculo.Name = "lbl_PlacaVehiculo"
        Me.lbl_PlacaVehiculo.Size = New System.Drawing.Size(96, 16)
        Me.lbl_PlacaVehiculo.TabIndex = 6
        Me.lbl_PlacaVehiculo.Text = "Placa Vehiculo"
        '
        'lbl_CodPoliza
        '
        Me.lbl_CodPoliza.AutoSize = True
        Me.lbl_CodPoliza.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CodPoliza.Location = New System.Drawing.Point(498, 29)
        Me.lbl_CodPoliza.Name = "lbl_CodPoliza"
        Me.lbl_CodPoliza.Size = New System.Drawing.Size(114, 16)
        Me.lbl_CodPoliza.TabIndex = 4
        Me.lbl_CodPoliza.Text = "Número de Póliza"
        '
        'txt_CedulaTom
        '
        Me.txt_CedulaTom.Location = New System.Drawing.Point(138, 30)
        Me.txt_CedulaTom.Name = "txt_CedulaTom"
        Me.txt_CedulaTom.Size = New System.Drawing.Size(125, 23)
        Me.txt_CedulaTom.TabIndex = 2
        '
        'cmb_RazonSocial
        '
        Me.cmb_RazonSocial.FormattingEnabled = True
        Me.cmb_RazonSocial.Location = New System.Drawing.Point(112, 30)
        Me.cmb_RazonSocial.Name = "cmb_RazonSocial"
        Me.cmb_RazonSocial.Size = New System.Drawing.Size(20, 24)
        Me.cmb_RazonSocial.TabIndex = 1
        '
        'lbl_CedulaTomador
        '
        Me.lbl_CedulaTomador.AutoSize = True
        Me.lbl_CedulaTomador.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CedulaTomador.Location = New System.Drawing.Point(6, 33)
        Me.lbl_CedulaTomador.Name = "lbl_CedulaTomador"
        Me.lbl_CedulaTomador.Size = New System.Drawing.Size(106, 16)
        Me.lbl_CedulaTomador.TabIndex = 0
        Me.lbl_CedulaTomador.Text = "Cedula Tomador"
        '
        'lbl_CargoActual
        '
        Me.lbl_CargoActual.AutoSize = True
        Me.lbl_CargoActual.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CargoActual.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CargoActual.Location = New System.Drawing.Point(581, 87)
        Me.lbl_CargoActual.Name = "lbl_CargoActual"
        Me.lbl_CargoActual.Size = New System.Drawing.Size(95, 16)
        Me.lbl_CargoActual.TabIndex = 23
        Me.lbl_CargoActual.Text = "                             "
        '
        'lbl_UsuarioActual
        '
        Me.lbl_UsuarioActual.AutoSize = True
        Me.lbl_UsuarioActual.BackColor = System.Drawing.Color.Transparent
        Me.lbl_UsuarioActual.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_UsuarioActual.Location = New System.Drawing.Point(584, 55)
        Me.lbl_UsuarioActual.Name = "lbl_UsuarioActual"
        Me.lbl_UsuarioActual.Size = New System.Drawing.Size(92, 16)
        Me.lbl_UsuarioActual.TabIndex = 22
        Me.lbl_UsuarioActual.Text = "                            "
        '
        'lbl_HorafSiniestro
        '
        Me.lbl_HorafSiniestro.AutoSize = True
        Me.lbl_HorafSiniestro.BackColor = System.Drawing.Color.Transparent
        Me.lbl_HorafSiniestro.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HorafSiniestro.Location = New System.Drawing.Point(642, 25)
        Me.lbl_HorafSiniestro.Name = "lbl_HorafSiniestro"
        Me.lbl_HorafSiniestro.Size = New System.Drawing.Size(52, 15)
        Me.lbl_HorafSiniestro.TabIndex = 24
        Me.lbl_HorafSiniestro.Text = "               "
        '
        'tmr_HoraSiniestro
        '
        '
        'ofd_transito
        '
        Me.ofd_transito.FileName = "OpenFileDialog1"
        '
        'btn_GuardarSin
        '
        Me.btn_GuardarSin.Location = New System.Drawing.Point(278, 275)
        Me.btn_GuardarSin.Name = "btn_GuardarSin"
        Me.btn_GuardarSin.Size = New System.Drawing.Size(115, 25)
        Me.btn_GuardarSin.TabIndex = 31
        Me.btn_GuardarSin.Text = "Guardar"
        Me.btn_GuardarSin.UseVisualStyleBackColor = True
        '
        'frm_Siniestro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font

        Me.ClientSize = New System.Drawing.Size(734, 576)
        Me.Controls.Add(Me.lbl_HorafSiniestro)
        Me.Controls.Add(Me.lbl_CargoActual)
        Me.Controls.Add(Me.lbl_UsuarioActual)
        Me.Controls.Add(Me.grb_DatosOtros)
        Me.Controls.Add(Me.grb_DatosSiniestro)
        Me.Controls.Add(Me.lbl_LugarSiniestro)
        Me.Controls.Add(Me.lbl_GestionSiniestro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_Siniestro"
        Me.Text = "frm_Siniestro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_DatosSiniestro.ResumeLayout(False)
        Me.grb_DatosSiniestro.PerformLayout()
        CType(Me.ptb_ImagenCarro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_DatosOtros.ResumeLayout(False)
        Me.grb_DatosOtros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_GestionSiniestro As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_LugarSiniestro As System.Windows.Forms.Label
    Friend WithEvents grb_DatosSiniestro As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_LugarSiniestro As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_DescSiniestro As System.Windows.Forms.Label
    Friend WithEvents txt_DescripcionSin As System.Windows.Forms.TextBox
    Friend WithEvents lbl_HoraSin As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaSin As System.Windows.Forms.DateTimePicker
    Friend WithEvents grb_DatosOtros As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_CedulaTomador As System.Windows.Forms.Label
    Friend WithEvents lbl_PlacaVehiculo As System.Windows.Forms.Label
    Friend WithEvents lbl_CodPoliza As System.Windows.Forms.Label
    Friend WithEvents txt_CedulaTom As System.Windows.Forms.TextBox
    Friend WithEvents cmb_RazonSocial As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_CargarImagen As System.Windows.Forms.Button
    Friend WithEvents ptb_ImagenCarro As System.Windows.Forms.PictureBox
    Friend WithEvents cmb_PlacaVeh As System.Windows.Forms.ComboBox
    Friend WithEvents txt_CodPoliza As System.Windows.Forms.TextBox
    Friend WithEvents txt_DocumentoTran As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_CargarArch As System.Windows.Forms.Button
    Friend WithEvents lbl_CargoActual As System.Windows.Forms.Label
    Friend WithEvents lbl_UsuarioActual As System.Windows.Forms.Label
    Friend WithEvents lbl_HorafSiniestro As System.Windows.Forms.Label
    Friend WithEvents tmr_HoraSiniestro As System.Windows.Forms.Timer
    Friend WithEvents ofd_transito As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lbl_RutaImagen As System.Windows.Forms.Label
    Friend WithEvents lbl_CitaPerito As System.Windows.Forms.Label
    Friend WithEvents dtp_CitaPerito As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_HoraSin As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_BuscarCedTom As System.Windows.Forms.Button
    Friend WithEvents btn_GuardarSin As System.Windows.Forms.Button
End Class
