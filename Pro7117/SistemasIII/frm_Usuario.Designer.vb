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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Usuario))
        Me.pic_Logo = New System.Windows.Forms.PictureBox()
        Me.lbl_Titulo = New System.Windows.Forms.Label()
        Me.lbl_Gestion = New System.Windows.Forms.Label()
        Me.lbl_UsuarioActual = New System.Windows.Forms.Label()
        Me.lbl_CedulaEmp = New System.Windows.Forms.Label()
        Me.lbl_NombreEmp = New System.Windows.Forms.Label()
        Me.cmb_TipoEmp = New System.Windows.Forms.ComboBox()
        Me.txt_CedulaEmp = New System.Windows.Forms.TextBox()
        Me.txt_NombreEmp = New System.Windows.Forms.TextBox()
        Me.lbl_ApellidoEmp = New System.Windows.Forms.Label()
        Me.txt_ApellidoEmp = New System.Windows.Forms.TextBox()
        Me.lbl_Cargo = New System.Windows.Forms.Label()
        Me.cmb_Cargo = New System.Windows.Forms.ComboBox()
        Me.grb_DatosEmpleados = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.btn_BuscarCed = New System.Windows.Forms.Button()
        Me.grb_DatosSistema = New System.Windows.Forms.GroupBox()
        Me.ptb_ListoUsuario = New System.Windows.Forms.PictureBox()
        Me.txt_Contraseña = New System.Windows.Forms.TextBox()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.lbl_Contraseña = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.tmr_HoraUsuario = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_CargoActual = New System.Windows.Forms.Label()
        Me.lbl_HoraUsuario = New System.Windows.Forms.Label()
        CType(Me.pic_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_DatosEmpleados.SuspendLayout()
        Me.grb_DatosSistema.SuspendLayout()
        CType(Me.ptb_ListoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_Logo
        '
        Me.pic_Logo.Location = New System.Drawing.Point(12, 7)
        Me.pic_Logo.Name = "pic_Logo"
        Me.pic_Logo.Size = New System.Drawing.Size(132, 124)
        Me.pic_Logo.TabIndex = 0
        Me.pic_Logo.TabStop = False
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titulo.Location = New System.Drawing.Point(206, 26)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(285, 25)
        Me.lbl_Titulo.TabIndex = 1
        Me.lbl_Titulo.Text = "SEGUROS MALDONADO"
        '
        'lbl_Gestion
        '
        Me.lbl_Gestion.AutoSize = True
        Me.lbl_Gestion.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Gestion.Location = New System.Drawing.Point(229, 64)
        Me.lbl_Gestion.Name = "lbl_Gestion"
        Me.lbl_Gestion.Size = New System.Drawing.Size(234, 23)
        Me.lbl_Gestion.TabIndex = 2
        Me.lbl_Gestion.Text = "GESTIÓN DE USUARIO"
        '
        'lbl_UsuarioActual
        '
        Me.lbl_UsuarioActual.AutoSize = True
        Me.lbl_UsuarioActual.BackColor = System.Drawing.Color.Transparent
        Me.lbl_UsuarioActual.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_UsuarioActual.Location = New System.Drawing.Point(578, 64)
        Me.lbl_UsuarioActual.Name = "lbl_UsuarioActual"
        Me.lbl_UsuarioActual.Size = New System.Drawing.Size(92, 16)
        Me.lbl_UsuarioActual.TabIndex = 5
        Me.lbl_UsuarioActual.Text = "                            "
        '
        'lbl_CedulaEmp
        '
        Me.lbl_CedulaEmp.AutoSize = True
        Me.lbl_CedulaEmp.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CedulaEmp.Location = New System.Drawing.Point(54, 33)
        Me.lbl_CedulaEmp.Name = "lbl_CedulaEmp"
        Me.lbl_CedulaEmp.Size = New System.Drawing.Size(65, 16)
        Me.lbl_CedulaEmp.TabIndex = 7
        Me.lbl_CedulaEmp.Text = "CEDULA"
        '
        'lbl_NombreEmp
        '
        Me.lbl_NombreEmp.AutoSize = True
        Me.lbl_NombreEmp.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NombreEmp.Location = New System.Drawing.Point(54, 70)
        Me.lbl_NombreEmp.Name = "lbl_NombreEmp"
        Me.lbl_NombreEmp.Size = New System.Drawing.Size(72, 16)
        Me.lbl_NombreEmp.TabIndex = 8
        Me.lbl_NombreEmp.Text = "NOMBRE "
        '
        'cmb_TipoEmp
        '
        Me.cmb_TipoEmp.Enabled = False
        Me.cmb_TipoEmp.FormattingEnabled = True
        Me.cmb_TipoEmp.Location = New System.Drawing.Point(133, 143)
        Me.cmb_TipoEmp.Name = "cmb_TipoEmp"
        Me.cmb_TipoEmp.Size = New System.Drawing.Size(100, 24)
        Me.cmb_TipoEmp.TabIndex = 9
        '
        'txt_CedulaEmp
        '
        Me.txt_CedulaEmp.Location = New System.Drawing.Point(133, 26)
        Me.txt_CedulaEmp.Name = "txt_CedulaEmp"
        Me.txt_CedulaEmp.Size = New System.Drawing.Size(100, 23)
        Me.txt_CedulaEmp.TabIndex = 10
        '
        'txt_NombreEmp
        '
        Me.txt_NombreEmp.Enabled = False
        Me.txt_NombreEmp.Location = New System.Drawing.Point(133, 67)
        Me.txt_NombreEmp.Name = "txt_NombreEmp"
        Me.txt_NombreEmp.Size = New System.Drawing.Size(100, 23)
        Me.txt_NombreEmp.TabIndex = 11
        '
        'lbl_ApellidoEmp
        '
        Me.lbl_ApellidoEmp.AutoSize = True
        Me.lbl_ApellidoEmp.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ApellidoEmp.Location = New System.Drawing.Point(48, 113)
        Me.lbl_ApellidoEmp.Name = "lbl_ApellidoEmp"
        Me.lbl_ApellidoEmp.Size = New System.Drawing.Size(78, 16)
        Me.lbl_ApellidoEmp.TabIndex = 12
        Me.lbl_ApellidoEmp.Text = "APELLIDO"
        '
        'txt_ApellidoEmp
        '
        Me.txt_ApellidoEmp.Enabled = False
        Me.txt_ApellidoEmp.Location = New System.Drawing.Point(133, 110)
        Me.txt_ApellidoEmp.Name = "txt_ApellidoEmp"
        Me.txt_ApellidoEmp.Size = New System.Drawing.Size(100, 23)
        Me.txt_ApellidoEmp.TabIndex = 13
        '
        'lbl_Cargo
        '
        Me.lbl_Cargo.AutoSize = True
        Me.lbl_Cargo.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cargo.Location = New System.Drawing.Point(71, 189)
        Me.lbl_Cargo.Name = "lbl_Cargo"
        Me.lbl_Cargo.Size = New System.Drawing.Size(55, 16)
        Me.lbl_Cargo.TabIndex = 15
        Me.lbl_Cargo.Text = "CARGO"
        '
        'cmb_Cargo
        '
        Me.cmb_Cargo.Enabled = False
        Me.cmb_Cargo.FormattingEnabled = True
        Me.cmb_Cargo.Location = New System.Drawing.Point(133, 181)
        Me.cmb_Cargo.Name = "cmb_Cargo"
        Me.cmb_Cargo.Size = New System.Drawing.Size(100, 24)
        Me.cmb_Cargo.TabIndex = 16
        '
        'grb_DatosEmpleados
        '
        Me.grb_DatosEmpleados.Controls.Add(Me.Label1)
        Me.grb_DatosEmpleados.Controls.Add(Me.btn_Cancelar)
        Me.grb_DatosEmpleados.Controls.Add(Me.btn_Eliminar)
        Me.grb_DatosEmpleados.Controls.Add(Me.btn_Guardar)
        Me.grb_DatosEmpleados.Controls.Add(Me.btn_BuscarCed)
        Me.grb_DatosEmpleados.Controls.Add(Me.txt_ApellidoEmp)
        Me.grb_DatosEmpleados.Controls.Add(Me.lbl_Cargo)
        Me.grb_DatosEmpleados.Controls.Add(Me.cmb_Cargo)
        Me.grb_DatosEmpleados.Controls.Add(Me.lbl_ApellidoEmp)
        Me.grb_DatosEmpleados.Controls.Add(Me.txt_NombreEmp)
        Me.grb_DatosEmpleados.Controls.Add(Me.txt_CedulaEmp)
        Me.grb_DatosEmpleados.Controls.Add(Me.cmb_TipoEmp)
        Me.grb_DatosEmpleados.Controls.Add(Me.lbl_NombreEmp)
        Me.grb_DatosEmpleados.Controls.Add(Me.lbl_CedulaEmp)
        Me.grb_DatosEmpleados.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_DatosEmpleados.Location = New System.Drawing.Point(27, 180)
        Me.grb_DatosEmpleados.Name = "grb_DatosEmpleados"
        Me.grb_DatosEmpleados.Size = New System.Drawing.Size(337, 271)
        Me.grb_DatosEmpleados.TabIndex = 17
        Me.grb_DatosEmpleados.TabStop = False
        Me.grb_DatosEmpleados.Text = "DATOS EMPLEADO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "TIPO EMPLEADO"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Enabled = False
        Me.btn_Cancelar.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.Location = New System.Drawing.Point(206, 227)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(91, 23)
        Me.btn_Cancelar.TabIndex = 20
        Me.btn_Cancelar.Text = "CANCELAR"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Eliminar.Location = New System.Drawing.Point(109, 227)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(91, 23)
        Me.btn_Eliminar.TabIndex = 19
        Me.btn_Eliminar.Text = "ELIMINAR"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Guardar.Location = New System.Drawing.Point(18, 227)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(85, 23)
        Me.btn_Guardar.TabIndex = 18
        Me.btn_Guardar.Text = "GUARDAR"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_BuscarCed
        '
        Me.btn_BuscarCed.Location = New System.Drawing.Point(249, 19)
        Me.btn_BuscarCed.Name = "btn_BuscarCed"
        Me.btn_BuscarCed.Size = New System.Drawing.Size(82, 23)
        Me.btn_BuscarCed.TabIndex = 17
        Me.btn_BuscarCed.Text = "BUSCAR"
        Me.btn_BuscarCed.UseVisualStyleBackColor = True
        '
        'grb_DatosSistema
        '
        Me.grb_DatosSistema.Controls.Add(Me.ptb_ListoUsuario)
        Me.grb_DatosSistema.Controls.Add(Me.txt_Contraseña)
        Me.grb_DatosSistema.Controls.Add(Me.txt_Usuario)
        Me.grb_DatosSistema.Controls.Add(Me.lbl_Contraseña)
        Me.grb_DatosSistema.Controls.Add(Me.lbl_Usuario)
        Me.grb_DatosSistema.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_DatosSistema.Location = New System.Drawing.Point(383, 180)
        Me.grb_DatosSistema.Name = "grb_DatosSistema"
        Me.grb_DatosSistema.Size = New System.Drawing.Size(323, 269)
        Me.grb_DatosSistema.TabIndex = 18
        Me.grb_DatosSistema.TabStop = False
        Me.grb_DatosSistema.Text = "DATOS DEL SISTEMA"
        '
        'ptb_ListoUsuario
        '
        Me.ptb_ListoUsuario.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.ic_done_black_48dp
        Me.ptb_ListoUsuario.Location = New System.Drawing.Point(147, 182)
        Me.ptb_ListoUsuario.Name = "ptb_ListoUsuario"
        Me.ptb_ListoUsuario.Size = New System.Drawing.Size(51, 45)
        Me.ptb_ListoUsuario.TabIndex = 4
        Me.ptb_ListoUsuario.TabStop = False
        '
        'txt_Contraseña
        '
        Me.txt_Contraseña.Location = New System.Drawing.Point(144, 116)
        Me.txt_Contraseña.Name = "txt_Contraseña"
        Me.txt_Contraseña.Size = New System.Drawing.Size(124, 23)
        Me.txt_Contraseña.TabIndex = 3
        '
        'txt_Usuario
        '
        Me.txt_Usuario.Location = New System.Drawing.Point(144, 62)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(124, 23)
        Me.txt_Usuario.TabIndex = 2
        '
        'lbl_Contraseña
        '
        Me.lbl_Contraseña.AutoSize = True
        Me.lbl_Contraseña.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Contraseña.Location = New System.Drawing.Point(27, 119)
        Me.lbl_Contraseña.Name = "lbl_Contraseña"
        Me.lbl_Contraseña.Size = New System.Drawing.Size(102, 16)
        Me.lbl_Contraseña.TabIndex = 1
        Me.lbl_Contraseña.Text = "CONTRASEÑA"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Usuario.Location = New System.Drawing.Point(52, 65)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(71, 16)
        Me.lbl_Usuario.TabIndex = 0
        Me.lbl_Usuario.Text = "USUARIO"
        '
        'tmr_HoraUsuario
        '
        '
        'lbl_CargoActual
        '
        Me.lbl_CargoActual.AutoSize = True
        Me.lbl_CargoActual.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CargoActual.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CargoActual.Location = New System.Drawing.Point(575, 90)
        Me.lbl_CargoActual.Name = "lbl_CargoActual"
        Me.lbl_CargoActual.Size = New System.Drawing.Size(95, 16)
        Me.lbl_CargoActual.TabIndex = 19
        Me.lbl_CargoActual.Text = "                             "
        '
        'lbl_HoraUsuario
        '
        Me.lbl_HoraUsuario.AutoSize = True
        Me.lbl_HoraUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_HoraUsuario.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HoraUsuario.Location = New System.Drawing.Point(636, 26)
        Me.lbl_HoraUsuario.Name = "lbl_HoraUsuario"
        Me.lbl_HoraUsuario.Size = New System.Drawing.Size(52, 15)
        Me.lbl_HoraUsuario.TabIndex = 25
        Me.lbl_HoraUsuario.Text = "               "
        '
        'frm_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(729, 501)
        Me.Controls.Add(Me.lbl_HoraUsuario)
        Me.Controls.Add(Me.lbl_CargoActual)
        Me.Controls.Add(Me.grb_DatosSistema)
        Me.Controls.Add(Me.grb_DatosEmpleados)
        Me.Controls.Add(Me.lbl_UsuarioActual)
        Me.Controls.Add(Me.lbl_Gestion)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Controls.Add(Me.pic_Logo)
        Me.Name = "frm_Usuario"
        Me.Text = "frm_Usuario"
        CType(Me.pic_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_DatosEmpleados.ResumeLayout(False)
        Me.grb_DatosEmpleados.PerformLayout()
        Me.grb_DatosSistema.ResumeLayout(False)
        Me.grb_DatosSistema.PerformLayout()
        CType(Me.ptb_ListoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic_Logo As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Titulo As System.Windows.Forms.Label
    Friend WithEvents lbl_Gestion As System.Windows.Forms.Label
    Friend WithEvents lbl_UsuarioActual As System.Windows.Forms.Label
    Friend WithEvents lbl_CedulaEmp As System.Windows.Forms.Label
    Friend WithEvents lbl_NombreEmp As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoEmp As System.Windows.Forms.ComboBox
    Friend WithEvents txt_CedulaEmp As System.Windows.Forms.TextBox
    Friend WithEvents txt_NombreEmp As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ApellidoEmp As System.Windows.Forms.Label
    Friend WithEvents txt_ApellidoEmp As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Cargo As System.Windows.Forms.Label
    Friend WithEvents cmb_Cargo As System.Windows.Forms.ComboBox
    Friend WithEvents grb_DatosEmpleados As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_BuscarCed As System.Windows.Forms.Button
    Friend WithEvents grb_DatosSistema As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Contraseña As System.Windows.Forms.TextBox
    Friend WithEvents txt_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Contraseña As System.Windows.Forms.Label
    Friend WithEvents lbl_Usuario As System.Windows.Forms.Label
    Friend WithEvents tmr_HoraUsuario As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_CargoActual As System.Windows.Forms.Label
    Friend WithEvents lbl_HoraUsuario As System.Windows.Forms.Label
    Friend WithEvents ptb_ListoUsuario As System.Windows.Forms.PictureBox

End Class
