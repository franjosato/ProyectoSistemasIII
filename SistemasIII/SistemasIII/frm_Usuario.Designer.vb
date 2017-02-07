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
        Me.pic_Logo = New System.Windows.Forms.PictureBox()
        Me.tmr_HoraUsuario = New System.Windows.Forms.Timer(Me.components)
        Me.grb_Empleado = New System.Windows.Forms.GroupBox()
        Me.grb_Usuario = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_SApellido = New System.Windows.Forms.Label()
        Me.lbl_PApellido = New System.Windows.Forms.Label()
        Me.txt_SApellido = New System.Windows.Forms.TextBox()
        Me.txt_SNombre = New System.Windows.Forms.TextBox()
        Me.txt_PApellido = New System.Windows.Forms.TextBox()
        Me.txt_PNombre = New System.Windows.Forms.TextBox()
        Me.lbl_SNombre = New System.Windows.Forms.Label()
        Me.lbl_PNombre = New System.Windows.Forms.Label()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.cmb_Tipoempleado = New System.Windows.Forms.ComboBox()
        Me.lbl_Tipoempleado = New System.Windows.Forms.Label()
        Me.txt_Contraseña = New System.Windows.Forms.TextBox()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.lbl_Contraseña = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Volver = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        CType(Me.pic_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_Empleado.SuspendLayout()
        Me.grb_Usuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'pic_Logo
        '
        Me.pic_Logo.Location = New System.Drawing.Point(0, 0)
        Me.pic_Logo.Name = "pic_Logo"
        Me.pic_Logo.Size = New System.Drawing.Size(132, 132)
        Me.pic_Logo.TabIndex = 0
        Me.pic_Logo.TabStop = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cédula:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(101, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
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
        'txt_SNombre
        '
        Me.txt_SNombre.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_SNombre.Location = New System.Drawing.Point(101, 134)
        Me.txt_SNombre.MaxLength = 15
        Me.txt_SNombre.Name = "txt_SNombre"
        Me.txt_SNombre.Size = New System.Drawing.Size(139, 20)
        Me.txt_SNombre.TabIndex = 112
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
        'txt_PNombre
        '
        Me.txt_PNombre.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_PNombre.Location = New System.Drawing.Point(101, 68)
        Me.txt_PNombre.MaxLength = 15
        Me.txt_PNombre.Name = "txt_PNombre"
        Me.txt_PNombre.Size = New System.Drawing.Size(139, 20)
        Me.txt_PNombre.TabIndex = 110
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
        'btn_Buscar
        '
        Me.btn_Buscar.Location = New System.Drawing.Point(207, 40)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 116
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = True
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
        'frm_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.SistemasIII.My.Resources.Resources.frm23
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(661, 474)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Volver)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.grb_Usuario)
        Me.Controls.Add(Me.grb_Empleado)
        Me.Controls.Add(Me.pic_Logo)
        Me.Name = "frm_Usuario"
        Me.Text = "frm_Usuario"
        CType(Me.pic_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_Empleado.ResumeLayout(False)
        Me.grb_Empleado.PerformLayout()
        Me.grb_Usuario.ResumeLayout(False)
        Me.grb_Usuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pic_Logo As System.Windows.Forms.PictureBox
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
End Class
