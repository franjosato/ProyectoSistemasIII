<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TipoVehiculo
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
        Me.grb_Datos = New System.Windows.Forms.GroupBox()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.txt_CantidadRuedas = New System.Windows.Forms.TextBox()
        Me.txt_CapacidadCarga = New System.Windows.Forms.TextBox()
        Me.txt_CapacidadPasajeros = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.lbl_CantidadRuedas = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_CapacidadCarga = New System.Windows.Forms.Label()
        Me.lbl_CapacidadPasajeros = New System.Windows.Forms.Label()
        Me.lbl_Codigo = New System.Windows.Forms.Label()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Volver = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoSaludo = New System.Windows.Forms.Label()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoFormuladio = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoModulo = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoEmpresa = New System.Windows.Forms.Label()
        Me.ptb_logo = New System.Windows.Forms.PictureBox()
        Me.grb_Datos.SuspendLayout()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grb_Datos
        '
        Me.grb_Datos.Controls.Add(Me.btn_Buscar)
        Me.grb_Datos.Controls.Add(Me.txt_CantidadRuedas)
        Me.grb_Datos.Controls.Add(Me.txt_CapacidadCarga)
        Me.grb_Datos.Controls.Add(Me.txt_CapacidadPasajeros)
        Me.grb_Datos.Controls.Add(Me.txt_Nombre)
        Me.grb_Datos.Controls.Add(Me.txt_Codigo)
        Me.grb_Datos.Controls.Add(Me.lbl_CantidadRuedas)
        Me.grb_Datos.Controls.Add(Me.lbl_Nombre)
        Me.grb_Datos.Controls.Add(Me.lbl_CapacidadCarga)
        Me.grb_Datos.Controls.Add(Me.lbl_CapacidadPasajeros)
        Me.grb_Datos.Controls.Add(Me.lbl_Codigo)
        Me.grb_Datos.Location = New System.Drawing.Point(12, 162)
        Me.grb_Datos.Name = "grb_Datos"
        Me.grb_Datos.Size = New System.Drawing.Size(689, 126)
        Me.grb_Datos.TabIndex = 0
        Me.grb_Datos.TabStop = False
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Location = New System.Drawing.Point(240, 17)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 10
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'txt_CantidadRuedas
        '
        Me.txt_CantidadRuedas.Location = New System.Drawing.Point(125, 93)
        Me.txt_CantidadRuedas.Name = "txt_CantidadRuedas"
        Me.txt_CantidadRuedas.Size = New System.Drawing.Size(100, 20)
        Me.txt_CantidadRuedas.TabIndex = 9
        '
        'txt_CapacidadCarga
        '
        Me.txt_CapacidadCarga.Location = New System.Drawing.Point(583, 56)
        Me.txt_CapacidadCarga.Name = "txt_CapacidadCarga"
        Me.txt_CapacidadCarga.Size = New System.Drawing.Size(100, 20)
        Me.txt_CapacidadCarga.TabIndex = 8
        '
        'txt_CapacidadPasajeros
        '
        Me.txt_CapacidadPasajeros.Location = New System.Drawing.Point(365, 56)
        Me.txt_CapacidadPasajeros.Name = "txt_CapacidadPasajeros"
        Me.txt_CapacidadPasajeros.Size = New System.Drawing.Size(100, 20)
        Me.txt_CapacidadPasajeros.TabIndex = 7
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(125, 56)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_Nombre.TabIndex = 6
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Location = New System.Drawing.Point(125, 19)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_Codigo.TabIndex = 5
        '
        'lbl_CantidadRuedas
        '
        Me.lbl_CantidadRuedas.AutoSize = True
        Me.lbl_CantidadRuedas.Location = New System.Drawing.Point(7, 96)
        Me.lbl_CantidadRuedas.Name = "lbl_CantidadRuedas"
        Me.lbl_CantidadRuedas.Size = New System.Drawing.Size(102, 13)
        Me.lbl_CantidadRuedas.TabIndex = 4
        Me.lbl_CantidadRuedas.Text = "Cantidad de ruedas:"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(72, 59)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_Nombre.TabIndex = 3
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'lbl_CapacidadCarga
        '
        Me.lbl_CapacidadCarga.AutoSize = True
        Me.lbl_CapacidadCarga.Location = New System.Drawing.Point(471, 59)
        Me.lbl_CapacidadCarga.Name = "lbl_CapacidadCarga"
        Me.lbl_CapacidadCarga.Size = New System.Drawing.Size(106, 13)
        Me.lbl_CapacidadCarga.TabIndex = 2
        Me.lbl_CapacidadCarga.Text = "Capacidad de carga:"
        '
        'lbl_CapacidadPasajeros
        '
        Me.lbl_CapacidadPasajeros.AutoSize = True
        Me.lbl_CapacidadPasajeros.Location = New System.Drawing.Point(235, 59)
        Me.lbl_CapacidadPasajeros.Name = "lbl_CapacidadPasajeros"
        Me.lbl_CapacidadPasajeros.Size = New System.Drawing.Size(124, 13)
        Me.lbl_CapacidadPasajeros.TabIndex = 1
        Me.lbl_CapacidadPasajeros.Text = "Capacidad de pasajeros:"
        '
        'lbl_Codigo
        '
        Me.lbl_Codigo.AutoSize = True
        Me.lbl_Codigo.Location = New System.Drawing.Point(76, 22)
        Me.lbl_Codigo.Name = "lbl_Codigo"
        Me.lbl_Codigo.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Codigo.TabIndex = 0
        Me.lbl_Codigo.Text = "Código:"
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Location = New System.Drawing.Point(320, 294)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 16
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Volver
        '
        Me.btn_Volver.Location = New System.Drawing.Point(509, 294)
        Me.btn_Volver.Name = "btn_Volver"
        Me.btn_Volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_Volver.TabIndex = 15
        Me.btn_Volver.Text = "Vovler"
        Me.btn_Volver.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(417, 294)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 14
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Location = New System.Drawing.Point(222, 294)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Modificar.TabIndex = 13
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Location = New System.Drawing.Point(129, 294)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Agregar.TabIndex = 12
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fecha.Location = New System.Drawing.Point(556, 15)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Fecha.TabIndex = 131
        Me.lbl_Fecha.Text = "dd/MM/YY"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Usuario.Location = New System.Drawing.Point(627, 65)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Usuario.TabIndex = 130
        Me.lbl_Usuario.Text = "Usuario"
        '
        'lbl_EncabezadoSaludo
        '
        Me.lbl_EncabezadoSaludo.AutoSize = True
        Me.lbl_EncabezadoSaludo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoSaludo.Location = New System.Drawing.Point(586, 65)
        Me.lbl_EncabezadoSaludo.Name = "lbl_EncabezadoSaludo"
        Me.lbl_EncabezadoSaludo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_EncabezadoSaludo.TabIndex = 129
        Me.lbl_EncabezadoSaludo.Text = "Hola, "
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Hora.Location = New System.Drawing.Point(620, 15)
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
        Me.lbl_EncabezadoFormuladio.Location = New System.Drawing.Point(241, 101)
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
        Me.lbl_EncabezadoModulo.Location = New System.Drawing.Point(249, 57)
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
        Me.lbl_EncabezadoEmpresa.Location = New System.Drawing.Point(207, 12)
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
        'frm_TipoVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.SistemasIII.My.Resources.Resources.frm23
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(712, 330)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.lbl_EncabezadoSaludo)
        Me.Controls.Add(Me.lbl_Hora)
        Me.Controls.Add(Me.lbl_EncabezadoFormuladio)
        Me.Controls.Add(Me.lbl_EncabezadoModulo)
        Me.Controls.Add(Me.lbl_EncabezadoEmpresa)
        Me.Controls.Add(Me.ptb_logo)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Volver)
        Me.Controls.Add(Me.grb_Datos)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Name = "frm_TipoVehiculo"
        Me.Text = "frm_TipoVehiculo"
        Me.grb_Datos.ResumeLayout(False)
        Me.grb_Datos.PerformLayout()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grb_Datos As GroupBox
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents txt_CantidadRuedas As TextBox
    Friend WithEvents txt_CapacidadCarga As TextBox
    Friend WithEvents txt_CapacidadPasajeros As TextBox
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents txt_Codigo As TextBox
    Friend WithEvents lbl_CantidadRuedas As Label
    Friend WithEvents lbl_Nombre As Label
    Friend WithEvents lbl_CapacidadCarga As Label
    Friend WithEvents lbl_CapacidadPasajeros As Label
    Friend WithEvents lbl_Codigo As Label
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btn_Volver As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Modificar As Button
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents lbl_EncabezadoSaludo As Label
    Friend WithEvents lbl_Hora As Label
    Friend WithEvents lbl_EncabezadoFormuladio As Label
    Friend WithEvents lbl_EncabezadoModulo As Label
    Friend WithEvents lbl_EncabezadoEmpresa As Label
    Friend WithEvents ptb_logo As PictureBox
End Class
