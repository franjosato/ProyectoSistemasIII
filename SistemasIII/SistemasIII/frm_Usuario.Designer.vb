<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Usuario
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
        Me.tmr_HoraUsuario = New System.Windows.Forms.Timer(Me.components)
        Me.grb_Empleado = New System.Windows.Forms.GroupBox()
        Me.cmb_Tipoempleado = New System.Windows.Forms.ComboBox()
        Me.lbl_Tipoempleado = New System.Windows.Forms.Label()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.lbl_SApellido = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_PApellido = New System.Windows.Forms.TextBox()
        Me.lbl_PApellido = New System.Windows.Forms.Label()
        Me.txt_SApellido = New System.Windows.Forms.TextBox()
        Me.lbl_SNombre = New System.Windows.Forms.Label()
        Me.lbl_PNombre = New System.Windows.Forms.Label()
        Me.txt_SNombre = New System.Windows.Forms.TextBox()
        Me.txt_PNombre = New System.Windows.Forms.TextBox()
        Me.grb_Usuario = New System.Windows.Forms.GroupBox()
        Me.txt_Contraseña = New System.Windows.Forms.TextBox()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.lbl_Contraseña = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Volver = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoSaludo = New System.Windows.Forms.Label()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoFormuladio = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoModulo = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoEmpresa = New System.Windows.Forms.Label()
        Me.ptb_logo = New System.Windows.Forms.PictureBox()
        Me.grb_Empleado.SuspendLayout()
        Me.grb_Usuario.SuspendLayout()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmr_HoraUsuario
        '
        '
        'grb_Empleado
        '
        Me.grb_Empleado.Controls.Add(Me.cmb_Tipoempleado)
        Me.grb_Empleado.Controls.Add(Me.lbl_Tipoempleado)
        Me.grb_Empleado.Controls.Add(Me.btn_Buscar)
        Me.grb_Empleado.Controls.Add(Me.lbl_SApellido)
        Me.grb_Empleado.Controls.Add(Me.TextBox1)
        Me.grb_Empleado.Controls.Add(Me.Label1)
        Me.grb_Empleado.Controls.Add(Me.txt_PApellido)
        Me.grb_Empleado.Controls.Add(Me.lbl_PApellido)
        Me.grb_Empleado.Controls.Add(Me.txt_SApellido)
        Me.grb_Empleado.Controls.Add(Me.lbl_SNombre)
        Me.grb_Empleado.Controls.Add(Me.lbl_PNombre)
        Me.grb_Empleado.Controls.Add(Me.txt_SNombre)
        Me.grb_Empleado.Controls.Add(Me.txt_PNombre)
        Me.grb_Empleado.Location = New System.Drawing.Point(23, 179)
        Me.grb_Empleado.Name = "grb_Empleado"
        Me.grb_Empleado.Size = New System.Drawing.Size(323, 253)
        Me.grb_Empleado.TabIndex = 1
        Me.grb_Empleado.TabStop = False
        Me.grb_Empleado.Text = "Datos del empleado"
        '
        'cmb_Tipoempleado
        '
        Me.cmb_Tipoempleado.FormattingEnabled = True
        Me.cmb_Tipoempleado.Location = New System.Drawing.Point(101, 192)
        Me.cmb_Tipoempleado.Name = "cmb_Tipoempleado"
        Me.cmb_Tipoempleado.Size = New System.Drawing.Size(139, 21)
        Me.cmb_Tipoempleado.TabIndex = 118
        '
        'lbl_Tipoempleado
        '
        Me.lbl_Tipoempleado.AutoSize = True
        Me.lbl_Tipoempleado.Location = New System.Drawing.Point(3, 195)
        Me.lbl_Tipoempleado.Name = "lbl_Tipoempleado"
        Me.lbl_Tipoempleado.Size = New System.Drawing.Size(92, 13)
        Me.lbl_Tipoempleado.TabIndex = 117
        Me.lbl_Tipoempleado.Text = "Tipo de empleado"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Location = New System.Drawing.Point(207, 40)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 116
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'lbl_SApellido
        '
        Me.lbl_SApellido.AutoSize = True
        Me.lbl_SApellido.Location = New System.Drawing.Point(3, 169)
        Me.lbl_SApellido.Name = "lbl_SApellido"
        Me.lbl_SApellido.Size = New System.Drawing.Size(92, 13)
        Me.lbl_SApellido.TabIndex = 115
        Me.lbl_SApellido.Text = "Segundo apellido:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(101, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cédula:"
        '
        'txt_PApellido
        '
        Me.txt_PApellido.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_PApellido.Location = New System.Drawing.Point(101, 101)
        Me.txt_PApellido.MaxLength = 15
        Me.txt_PApellido.Name = "txt_PApellido"
        Me.txt_PApellido.Size = New System.Drawing.Size(139, 20)
        Me.txt_PApellido.TabIndex = 111
        '
        'lbl_PApellido
        '
        Me.lbl_PApellido.AutoSize = True
        Me.lbl_PApellido.Location = New System.Drawing.Point(17, 104)
        Me.lbl_PApellido.Name = "lbl_PApellido"
        Me.lbl_PApellido.Size = New System.Drawing.Size(78, 13)
        Me.lbl_PApellido.TabIndex = 114
        Me.lbl_PApellido.Text = "Primer apellido:"
        '
        'txt_SApellido
        '
        Me.txt_SApellido.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_SApellido.Location = New System.Drawing.Point(101, 166)
        Me.txt_SApellido.MaxLength = 15
        Me.txt_SApellido.Name = "txt_SApellido"
        Me.txt_SApellido.Size = New System.Drawing.Size(139, 20)
        Me.txt_SApellido.TabIndex = 113
        '
        'lbl_SNombre
        '
        Me.lbl_SNombre.AutoSize = True
        Me.lbl_SNombre.Location = New System.Drawing.Point(4, 137)
        Me.lbl_SNombre.Name = "lbl_SNombre"
        Me.lbl_SNombre.Size = New System.Drawing.Size(91, 13)
        Me.lbl_SNombre.TabIndex = 109
        Me.lbl_SNombre.Text = "Segundo nombre:"
        '
        'lbl_PNombre
        '
        Me.lbl_PNombre.AutoSize = True
        Me.lbl_PNombre.Location = New System.Drawing.Point(18, 71)
        Me.lbl_PNombre.Name = "lbl_PNombre"
        Me.lbl_PNombre.Size = New System.Drawing.Size(77, 13)
        Me.lbl_PNombre.TabIndex = 108
        Me.lbl_PNombre.Text = "Primer nombre:"
        '
        'txt_SNombre
        '
        Me.txt_SNombre.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_SNombre.Location = New System.Drawing.Point(101, 134)
        Me.txt_SNombre.MaxLength = 15
        Me.txt_SNombre.Name = "txt_SNombre"
        Me.txt_SNombre.Size = New System.Drawing.Size(139, 20)
        Me.txt_SNombre.TabIndex = 112
        '
        'txt_PNombre
        '
        Me.txt_PNombre.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_PNombre.Location = New System.Drawing.Point(101, 68)
        Me.txt_PNombre.MaxLength = 15
        Me.txt_PNombre.Name = "txt_PNombre"
        Me.txt_PNombre.Size = New System.Drawing.Size(139, 20)
        Me.txt_PNombre.TabIndex = 110
        '
        'grb_Usuario
        '
        Me.grb_Usuario.Controls.Add(Me.txt_Contraseña)
        Me.grb_Usuario.Controls.Add(Me.txt_Usuario)
        Me.grb_Usuario.Controls.Add(Me.lbl_Contraseña)
        Me.grb_Usuario.Controls.Add(Me.lbl_Usuario)
        Me.grb_Usuario.Location = New System.Drawing.Point(352, 179)
        Me.grb_Usuario.Name = "grb_Usuario"
        Me.grb_Usuario.Size = New System.Drawing.Size(288, 253)
        Me.grb_Usuario.TabIndex = 2
        Me.grb_Usuario.TabStop = False
        Me.grb_Usuario.Text = "Datos del usuario"
        '
        'txt_Contraseña
        '
        Me.txt_Contraseña.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Contraseña.Location = New System.Drawing.Point(118, 128)
        Me.txt_Contraseña.Name = "txt_Contraseña"
        Me.txt_Contraseña.Size = New System.Drawing.Size(117, 21)
        Me.txt_Contraseña.TabIndex = 11
        '
        'txt_Usuario
        '
        Me.txt_Usuario.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Usuario.Location = New System.Drawing.Point(118, 81)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(117, 21)
        Me.txt_Usuario.TabIndex = 10
        '
        'lbl_Contraseña
        '
        Me.lbl_Contraseña.AutoSize = True
        Me.lbl_Contraseña.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Contraseña.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Contraseña.Location = New System.Drawing.Point(37, 131)
        Me.lbl_Contraseña.Name = "lbl_Contraseña"
        Me.lbl_Contraseña.Size = New System.Drawing.Size(75, 16)
        Me.lbl_Contraseña.TabIndex = 9
        Me.lbl_Contraseña.Text = "Contraseña:"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Usuario.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Usuario.Location = New System.Drawing.Point(60, 84)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(50, 16)
        Me.lbl_Usuario.TabIndex = 8
        Me.lbl_Usuario.Text = "Usuario:"
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Location = New System.Drawing.Point(297, 447)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 124
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Volver
        '
        Me.btn_Volver.Location = New System.Drawing.Point(486, 447)
        Me.btn_Volver.Name = "btn_Volver"
        Me.btn_Volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_Volver.TabIndex = 123
        Me.btn_Volver.Text = "Vovler"
        Me.btn_Volver.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(394, 447)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 122
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Location = New System.Drawing.Point(106, 447)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Agregar.TabIndex = 120
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Location = New System.Drawing.Point(199, 447)
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
        Me.lbl_Fecha.Location = New System.Drawing.Point(555, 14)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Fecha.TabIndex = 132
        Me.lbl_Fecha.Text = "dd/MM/YY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(626, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 131
        Me.Label2.Text = "Usuario"
        '
        'lbl_EncabezadoSaludo
        '
        Me.lbl_EncabezadoSaludo.AutoSize = True
        Me.lbl_EncabezadoSaludo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoSaludo.Location = New System.Drawing.Point(585, 64)
        Me.lbl_EncabezadoSaludo.Name = "lbl_EncabezadoSaludo"
        Me.lbl_EncabezadoSaludo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_EncabezadoSaludo.TabIndex = 130
        Me.lbl_EncabezadoSaludo.Text = "Hola, "
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Hora.Location = New System.Drawing.Point(619, 14)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Hora.TabIndex = 129
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
        Me.lbl_EncabezadoFormuladio.TabIndex = 128
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
        Me.lbl_EncabezadoModulo.TabIndex = 127
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
        Me.lbl_EncabezadoEmpresa.TabIndex = 126
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
        Me.ptb_logo.TabIndex = 125
        Me.ptb_logo.TabStop = False
        Me.ptb_logo.UseWaitCursor = True
        '
        'frm_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.SistemasIII.My.Resources.Resources.frm23
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(661, 474)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_EncabezadoSaludo)
        Me.Controls.Add(Me.lbl_Hora)
        Me.Controls.Add(Me.lbl_EncabezadoFormuladio)
        Me.Controls.Add(Me.lbl_EncabezadoModulo)
        Me.Controls.Add(Me.lbl_EncabezadoEmpresa)
        Me.Controls.Add(Me.ptb_logo)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Volver)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.grb_Usuario)
        Me.Controls.Add(Me.grb_Empleado)
        Me.Name = "frm_Usuario"
        Me.Text = "frm_Usuario"
        Me.grb_Empleado.ResumeLayout(False)
        Me.grb_Empleado.PerformLayout()
        Me.grb_Usuario.ResumeLayout(False)
        Me.grb_Usuario.PerformLayout()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmr_HoraUsuario As System.Windows.Forms.Timer
    Friend WithEvents grb_Empleado As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grb_Usuario As GroupBox
    Friend WithEvents lbl_SApellido As Label
    Friend WithEvents txt_PApellido As TextBox
    Friend WithEvents lbl_PApellido As Label
    Friend WithEvents txt_SApellido As TextBox
    Friend WithEvents lbl_SNombre As Label
    Friend WithEvents lbl_PNombre As Label
    Friend WithEvents txt_SNombre As TextBox
    Friend WithEvents txt_PNombre As TextBox
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents cmb_Tipoempleado As ComboBox
    Friend WithEvents lbl_Tipoempleado As Label
    Friend WithEvents txt_Contraseña As TextBox
    Friend WithEvents txt_Usuario As TextBox
    Friend WithEvents lbl_Contraseña As Label
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btn_Volver As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents btn_Modificar As Button
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_EncabezadoSaludo As Label
    Friend WithEvents lbl_Hora As Label
    Friend WithEvents lbl_EncabezadoFormuladio As Label
    Friend WithEvents lbl_EncabezadoModulo As Label
    Friend WithEvents lbl_EncabezadoEmpresa As Label
    Friend WithEvents ptb_logo As PictureBox
End Class
