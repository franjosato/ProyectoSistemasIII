﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Vehiculo
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_Kilometraje = New System.Windows.Forms.TextBox()
        Me.lbl_Kilometraje = New System.Windows.Forms.Label()
        Me.cmb_Uso = New System.Windows.Forms.ComboBox()
        Me.lbl_Uso = New System.Windows.Forms.Label()
        Me.txt_SerialCarroceria = New System.Windows.Forms.TextBox()
        Me.lbl_SerialCarroceria = New System.Windows.Forms.Label()
        Me.txt_SerialMotor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Color = New System.Windows.Forms.TextBox()
        Me.lbl_Color = New System.Windows.Forms.Label()
        Me.lbl_Año = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btn_Cargar = New System.Windows.Forms.Button()
        Me.txt_TituloPropiedad = New System.Windows.Forms.TextBox()
        Me.lbl_Tituloproiedad = New System.Windows.Forms.Label()
        Me.btn_CargarFoto = New System.Windows.Forms.Button()
        Me.ptb_Foto = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmb_Marca = New System.Windows.Forms.ComboBox()
        Me.lbl_Marca = New System.Windows.Forms.Label()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.txt_Placa = New System.Windows.Forms.TextBox()
        Me.lbl_CodTipoVe = New System.Windows.Forms.Label()
        Me.lbl_Placa = New System.Windows.Forms.Label()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.btn_Volver = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Anular = New System.Windows.Forms.Button()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoSaludo = New System.Windows.Forms.Label()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoFormuladio = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoModulo = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoEmpresa = New System.Windows.Forms.Label()
        Me.ptb_logo = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_Transporte = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ptb_Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_Transporte)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_Kilometraje)
        Me.GroupBox1.Controls.Add(Me.lbl_Kilometraje)
        Me.GroupBox1.Controls.Add(Me.cmb_Uso)
        Me.GroupBox1.Controls.Add(Me.lbl_Uso)
        Me.GroupBox1.Controls.Add(Me.txt_SerialCarroceria)
        Me.GroupBox1.Controls.Add(Me.lbl_SerialCarroceria)
        Me.GroupBox1.Controls.Add(Me.txt_SerialMotor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_Color)
        Me.GroupBox1.Controls.Add(Me.lbl_Color)
        Me.GroupBox1.Controls.Add(Me.lbl_Año)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.btn_Cargar)
        Me.GroupBox1.Controls.Add(Me.txt_TituloPropiedad)
        Me.GroupBox1.Controls.Add(Me.lbl_Tituloproiedad)
        Me.GroupBox1.Controls.Add(Me.btn_CargarFoto)
        Me.GroupBox1.Controls.Add(Me.ptb_Foto)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.cmb_Marca)
        Me.GroupBox1.Controls.Add(Me.lbl_Marca)
        Me.GroupBox1.Controls.Add(Me.btn_Buscar)
        Me.GroupBox1.Controls.Add(Me.txt_Placa)
        Me.GroupBox1.Controls.Add(Me.lbl_CodTipoVe)
        Me.GroupBox1.Controls.Add(Me.lbl_Placa)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(737, 239)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txt_Kilometraje
        '
        Me.txt_Kilometraje.Location = New System.Drawing.Point(609, 161)
        Me.txt_Kilometraje.Name = "txt_Kilometraje"
        Me.txt_Kilometraje.Size = New System.Drawing.Size(100, 20)
        Me.txt_Kilometraje.TabIndex = 23
        '
        'lbl_Kilometraje
        '
        Me.lbl_Kilometraje.AutoSize = True
        Me.lbl_Kilometraje.Location = New System.Drawing.Point(542, 164)
        Me.lbl_Kilometraje.Name = "lbl_Kilometraje"
        Me.lbl_Kilometraje.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Kilometraje.TabIndex = 22
        Me.lbl_Kilometraje.Text = "Kilometraje:"
        '
        'cmb_Uso
        '
        Me.cmb_Uso.FormattingEnabled = True
        Me.cmb_Uso.Location = New System.Drawing.Point(209, 161)
        Me.cmb_Uso.Name = "cmb_Uso"
        Me.cmb_Uso.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Uso.TabIndex = 21
        '
        'lbl_Uso
        '
        Me.lbl_Uso.AutoSize = True
        Me.lbl_Uso.Location = New System.Drawing.Point(174, 164)
        Me.lbl_Uso.Name = "lbl_Uso"
        Me.lbl_Uso.Size = New System.Drawing.Size(29, 13)
        Me.lbl_Uso.TabIndex = 20
        Me.lbl_Uso.Text = "Uso:"
        '
        'txt_SerialCarroceria
        '
        Me.txt_SerialCarroceria.Location = New System.Drawing.Point(559, 116)
        Me.txt_SerialCarroceria.Name = "txt_SerialCarroceria"
        Me.txt_SerialCarroceria.Size = New System.Drawing.Size(150, 20)
        Me.txt_SerialCarroceria.TabIndex = 19
        '
        'lbl_SerialCarroceria
        '
        Me.lbl_SerialCarroceria.AutoSize = True
        Me.lbl_SerialCarroceria.Location = New System.Drawing.Point(441, 119)
        Me.lbl_SerialCarroceria.Name = "lbl_SerialCarroceria"
        Me.lbl_SerialCarroceria.Size = New System.Drawing.Size(112, 13)
        Me.lbl_SerialCarroceria.TabIndex = 18
        Me.lbl_SerialCarroceria.Text = "Serial de la carroceria:"
        '
        'txt_SerialMotor
        '
        Me.txt_SerialMotor.Location = New System.Drawing.Point(559, 77)
        Me.txt_SerialMotor.Name = "txt_SerialMotor"
        Me.txt_SerialMotor.Size = New System.Drawing.Size(150, 20)
        Me.txt_SerialMotor.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(471, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Serial del motor:"
        '
        'txt_Color
        '
        Me.txt_Color.Location = New System.Drawing.Point(332, 117)
        Me.txt_Color.Name = "txt_Color"
        Me.txt_Color.Size = New System.Drawing.Size(100, 20)
        Me.txt_Color.TabIndex = 15
        '
        'lbl_Color
        '
        Me.lbl_Color.AutoSize = True
        Me.lbl_Color.Location = New System.Drawing.Point(296, 123)
        Me.lbl_Color.Name = "lbl_Color"
        Me.lbl_Color.Size = New System.Drawing.Size(34, 13)
        Me.lbl_Color.TabIndex = 14
        Me.lbl_Color.Text = "Color:"
        '
        'lbl_Año
        '
        Me.lbl_Año.AutoSize = True
        Me.lbl_Año.Location = New System.Drawing.Point(174, 123)
        Me.lbl_Año.Name = "lbl_Año"
        Me.lbl_Año.Size = New System.Drawing.Size(29, 13)
        Me.lbl_Año.TabIndex = 13
        Me.lbl_Año.Text = "Año:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(209, 117)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(72, 20)
        Me.DateTimePicker1.TabIndex = 12
        '
        'btn_Cargar
        '
        Me.btn_Cargar.Location = New System.Drawing.Point(357, 77)
        Me.btn_Cargar.Name = "btn_Cargar"
        Me.btn_Cargar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cargar.TabIndex = 11
        Me.btn_Cargar.Text = "Cargar"
        Me.btn_Cargar.UseVisualStyleBackColor = True
        '
        'txt_TituloPropiedad
        '
        Me.txt_TituloPropiedad.Location = New System.Drawing.Point(170, 80)
        Me.txt_TituloPropiedad.Name = "txt_TituloPropiedad"
        Me.txt_TituloPropiedad.Size = New System.Drawing.Size(181, 20)
        Me.txt_TituloPropiedad.TabIndex = 10
        '
        'lbl_Tituloproiedad
        '
        Me.lbl_Tituloproiedad.AutoSize = True
        Me.lbl_Tituloproiedad.Location = New System.Drawing.Point(169, 60)
        Me.lbl_Tituloproiedad.Name = "lbl_Tituloproiedad"
        Me.lbl_Tituloproiedad.Size = New System.Drawing.Size(101, 13)
        Me.lbl_Tituloproiedad.TabIndex = 9
        Me.lbl_Tituloproiedad.Text = "Titulo de propiedad:"
        '
        'btn_CargarFoto
        '
        Me.btn_CargarFoto.Location = New System.Drawing.Point(45, 201)
        Me.btn_CargarFoto.Name = "btn_CargarFoto"
        Me.btn_CargarFoto.Size = New System.Drawing.Size(75, 23)
        Me.btn_CargarFoto.TabIndex = 8
        Me.btn_CargarFoto.Text = "Cargar Foto"
        Me.btn_CargarFoto.UseVisualStyleBackColor = True
        '
        'ptb_Foto
        '
        Me.ptb_Foto.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ptb_Foto.Location = New System.Drawing.Point(17, 60)
        Me.ptb_Foto.Name = "ptb_Foto"
        Me.ptb_Foto.Size = New System.Drawing.Size(135, 135)
        Me.ptb_Foto.TabIndex = 7
        Me.ptb_Foto.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(566, 23)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(143, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'cmb_Marca
        '
        Me.cmb_Marca.FormattingEnabled = True
        Me.cmb_Marca.Location = New System.Drawing.Point(299, 23)
        Me.cmb_Marca.Name = "cmb_Marca"
        Me.cmb_Marca.Size = New System.Drawing.Size(179, 21)
        Me.cmb_Marca.TabIndex = 5
        '
        'lbl_Marca
        '
        Me.lbl_Marca.AutoSize = True
        Me.lbl_Marca.Location = New System.Drawing.Point(253, 27)
        Me.lbl_Marca.Name = "lbl_Marca"
        Me.lbl_Marca.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Marca.TabIndex = 4
        Me.lbl_Marca.Text = "Marca:"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Location = New System.Drawing.Point(172, 22)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 3
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'txt_Placa
        '
        Me.txt_Placa.Location = New System.Drawing.Point(66, 24)
        Me.txt_Placa.Name = "txt_Placa"
        Me.txt_Placa.Size = New System.Drawing.Size(100, 20)
        Me.txt_Placa.TabIndex = 2
        '
        'lbl_CodTipoVe
        '
        Me.lbl_CodTipoVe.AutoSize = True
        Me.lbl_CodTipoVe.Location = New System.Drawing.Point(484, 27)
        Me.lbl_CodTipoVe.Name = "lbl_CodTipoVe"
        Me.lbl_CodTipoVe.Size = New System.Drawing.Size(76, 13)
        Me.lbl_CodTipoVe.TabIndex = 1
        Me.lbl_CodTipoVe.Text = "Tipo vehículo:"
        '
        'lbl_Placa
        '
        Me.lbl_Placa.AutoSize = True
        Me.lbl_Placa.Location = New System.Drawing.Point(23, 27)
        Me.lbl_Placa.Name = "lbl_Placa"
        Me.lbl_Placa.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Placa.TabIndex = 0
        Me.lbl_Placa.Text = "Placa:"
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Location = New System.Drawing.Point(214, 406)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Modificar.TabIndex = 125
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Location = New System.Drawing.Point(101, 406)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Agregar.TabIndex = 124
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'btn_Volver
        '
        Me.btn_Volver.Location = New System.Drawing.Point(549, 406)
        Me.btn_Volver.Name = "btn_Volver"
        Me.btn_Volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_Volver.TabIndex = 123
        Me.btn_Volver.Text = "Volver"
        Me.btn_Volver.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(436, 406)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 122
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Anular
        '
        Me.btn_Anular.Location = New System.Drawing.Point(324, 406)
        Me.btn_Anular.Name = "btn_Anular"
        Me.btn_Anular.Size = New System.Drawing.Size(75, 23)
        Me.btn_Anular.TabIndex = 126
        Me.btn_Anular.Text = "Anular"
        Me.btn_Anular.UseVisualStyleBackColor = True
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fecha.Location = New System.Drawing.Point(555, 14)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Fecha.TabIndex = 134
        Me.lbl_Fecha.Text = "dd/MM/YY"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Usuario.Location = New System.Drawing.Point(626, 64)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Usuario.TabIndex = 133
        Me.lbl_Usuario.Text = "Usuario"
        '
        'lbl_EncabezadoSaludo
        '
        Me.lbl_EncabezadoSaludo.AutoSize = True
        Me.lbl_EncabezadoSaludo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoSaludo.Location = New System.Drawing.Point(585, 64)
        Me.lbl_EncabezadoSaludo.Name = "lbl_EncabezadoSaludo"
        Me.lbl_EncabezadoSaludo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_EncabezadoSaludo.TabIndex = 132
        Me.lbl_EncabezadoSaludo.Text = "Hola, "
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Hora.Location = New System.Drawing.Point(619, 14)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Hora.TabIndex = 131
        Me.lbl_Hora.Text = "00:00:00"
        '
        'lbl_EncabezadoFormuladio
        '
        Me.lbl_EncabezadoFormuladio.AutoSize = True
        Me.lbl_EncabezadoFormuladio.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoFormuladio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoFormuladio.Location = New System.Drawing.Point(240, 100)
        Me.lbl_EncabezadoFormuladio.Name = "lbl_EncabezadoFormuladio"
        Me.lbl_EncabezadoFormuladio.Size = New System.Drawing.Size(213, 25)
        Me.lbl_EncabezadoFormuladio.TabIndex = 130
        Me.lbl_EncabezadoFormuladio.Text = "Datos del Asegurado"
        '
        'lbl_EncabezadoModulo
        '
        Me.lbl_EncabezadoModulo.AutoSize = True
        Me.lbl_EncabezadoModulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoModulo.Location = New System.Drawing.Point(248, 56)
        Me.lbl_EncabezadoModulo.Name = "lbl_EncabezadoModulo"
        Me.lbl_EncabezadoModulo.Size = New System.Drawing.Size(196, 25)
        Me.lbl_EncabezadoModulo.TabIndex = 129
        Me.lbl_EncabezadoModulo.Text = "Módulo de Servicio"
        '
        'lbl_EncabezadoEmpresa
        '
        Me.lbl_EncabezadoEmpresa.AutoSize = True
        Me.lbl_EncabezadoEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoEmpresa.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_EncabezadoEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoEmpresa.Location = New System.Drawing.Point(206, 11)
        Me.lbl_EncabezadoEmpresa.Name = "lbl_EncabezadoEmpresa"
        Me.lbl_EncabezadoEmpresa.Size = New System.Drawing.Size(291, 29)
        Me.lbl_EncabezadoEmpresa.TabIndex = 128
        Me.lbl_EncabezadoEmpresa.Text = "SEGUROS MALDONADO"
        '
        'ptb_logo
        '
        Me.ptb_logo.BackColor = System.Drawing.Color.Transparent
        Me.ptb_logo.BackgroundImage = Global.SistemasIII.My.Resources.Resources.fondot
        Me.ptb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptb_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptb_logo.Location = New System.Drawing.Point(1, 1)
        Me.ptb_logo.Name = "ptb_logo"
        Me.ptb_logo.Size = New System.Drawing.Size(132, 132)
        Me.ptb_logo.TabIndex = 127
        Me.ptb_logo.TabStop = False
        Me.ptb_logo.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(338, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Lugar de uso:"
        '
        'cmb_Transporte
        '
        Me.cmb_Transporte.FormattingEnabled = True
        Me.cmb_Transporte.Location = New System.Drawing.Point(415, 160)
        Me.cmb_Transporte.Name = "cmb_Transporte"
        Me.cmb_Transporte.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Transporte.TabIndex = 25
        '
        'frm_Vehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.SistemasIII.My.Resources.Resources.frm23
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(759, 447)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.lbl_EncabezadoSaludo)
        Me.Controls.Add(Me.lbl_Hora)
        Me.Controls.Add(Me.lbl_EncabezadoFormuladio)
        Me.Controls.Add(Me.lbl_EncabezadoModulo)
        Me.Controls.Add(Me.lbl_EncabezadoEmpresa)
        Me.Controls.Add(Me.ptb_logo)
        Me.Controls.Add(Me.btn_Anular)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.btn_Volver)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_Vehiculo"
        Me.Text = "frm_Vehiculo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ptb_Foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_CargarFoto As Button
    Friend WithEvents ptb_Foto As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cmb_Marca As ComboBox
    Friend WithEvents lbl_Marca As Label
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents txt_Placa As TextBox
    Friend WithEvents lbl_CodTipoVe As Label
    Friend WithEvents lbl_Placa As Label
    Friend WithEvents txt_Kilometraje As TextBox
    Friend WithEvents lbl_Kilometraje As Label
    Friend WithEvents cmb_Uso As ComboBox
    Friend WithEvents lbl_Uso As Label
    Friend WithEvents txt_SerialCarroceria As TextBox
    Friend WithEvents lbl_SerialCarroceria As Label
    Friend WithEvents txt_SerialMotor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Color As TextBox
    Friend WithEvents lbl_Color As Label
    Friend WithEvents lbl_Año As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btn_Cargar As Button
    Friend WithEvents txt_TituloPropiedad As TextBox
    Friend WithEvents lbl_Tituloproiedad As Label
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents btn_Modificar As Button
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents btn_Volver As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Anular As Button
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents lbl_EncabezadoSaludo As Label
    Friend WithEvents lbl_Hora As Label
    Friend WithEvents lbl_EncabezadoFormuladio As Label
    Friend WithEvents lbl_EncabezadoModulo As Label
    Friend WithEvents lbl_EncabezadoEmpresa As Label
    Friend WithEvents ptb_logo As PictureBox
    Friend WithEvents cmb_Transporte As ComboBox
    Friend WithEvents Label2 As Label
End Class
