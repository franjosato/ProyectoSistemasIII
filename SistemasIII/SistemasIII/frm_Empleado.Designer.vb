<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Empleado
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
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.cmb_Nacionalidad = New System.Windows.Forms.ComboBox()
        Me.txt_Cedula = New System.Windows.Forms.TextBox()
        Me.lbl_Cedula = New System.Windows.Forms.Label()
        Me.txt_SApellido = New System.Windows.Forms.TextBox()
        Me.txt_SNombre = New System.Windows.Forms.TextBox()
        Me.txt_PApellido = New System.Windows.Forms.TextBox()
        Me.txt_PNombre = New System.Windows.Forms.TextBox()
        Me.lbl_SNombre = New System.Windows.Forms.Label()
        Me.lbl_PNombre = New System.Windows.Forms.Label()
        Me.lbl_SApellido = New System.Windows.Forms.Label()
        Me.lbl_PApellido = New System.Windows.Forms.Label()
        Me.txt_Correro = New System.Windows.Forms.TextBox()
        Me.lbl_Correo = New System.Windows.Forms.Label()
        Me.txt_TlfFijo = New System.Windows.Forms.TextBox()
        Me.lbl_TlfFijo = New System.Windows.Forms.Label()
        Me.grb_personales = New System.Windows.Forms.GroupBox()
        Me.grb_Laboral = New System.Windows.Forms.GroupBox()
        Me.lbl_Tipoempleado = New System.Windows.Forms.Label()
        Me.cmb_Tipoempleado = New System.Windows.Forms.ComboBox()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Volver = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.grb_personales.SuspendLayout()
        Me.grb_Laboral.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Location = New System.Drawing.Point(280, 24)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 105
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'cmb_Nacionalidad
        '
        Me.cmb_Nacionalidad.AutoCompleteCustomSource.AddRange(New String() {"V", "E"})
        Me.cmb_Nacionalidad.BackColor = System.Drawing.Color.GhostWhite
        Me.cmb_Nacionalidad.FormattingEnabled = True
        Me.cmb_Nacionalidad.Location = New System.Drawing.Point(106, 24)
        Me.cmb_Nacionalidad.Name = "cmb_Nacionalidad"
        Me.cmb_Nacionalidad.Size = New System.Drawing.Size(47, 21)
        Me.cmb_Nacionalidad.TabIndex = 102
        '
        'txt_Cedula
        '
        Me.txt_Cedula.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_Cedula.Location = New System.Drawing.Point(159, 26)
        Me.txt_Cedula.MaxLength = 8
        Me.txt_Cedula.Name = "txt_Cedula"
        Me.txt_Cedula.Size = New System.Drawing.Size(112, 20)
        Me.txt_Cedula.TabIndex = 101
        '
        'lbl_Cedula
        '
        Me.lbl_Cedula.AutoSize = True
        Me.lbl_Cedula.Location = New System.Drawing.Point(50, 27)
        Me.lbl_Cedula.Name = "lbl_Cedula"
        Me.lbl_Cedula.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Cedula.TabIndex = 100
        Me.lbl_Cedula.Text = "Cédula:"
        '
        'txt_SApellido
        '
        Me.txt_SApellido.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_SApellido.Location = New System.Drawing.Point(388, 93)
        Me.txt_SApellido.MaxLength = 15
        Me.txt_SApellido.Name = "txt_SApellido"
        Me.txt_SApellido.Size = New System.Drawing.Size(139, 20)
        Me.txt_SApellido.TabIndex = 99
        '
        'txt_SNombre
        '
        Me.txt_SNombre.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_SNombre.Location = New System.Drawing.Point(388, 61)
        Me.txt_SNombre.MaxLength = 15
        Me.txt_SNombre.Name = "txt_SNombre"
        Me.txt_SNombre.Size = New System.Drawing.Size(139, 20)
        Me.txt_SNombre.TabIndex = 98
        '
        'txt_PApellido
        '
        Me.txt_PApellido.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_PApellido.Location = New System.Drawing.Point(106, 94)
        Me.txt_PApellido.MaxLength = 15
        Me.txt_PApellido.Name = "txt_PApellido"
        Me.txt_PApellido.Size = New System.Drawing.Size(165, 20)
        Me.txt_PApellido.TabIndex = 97
        '
        'txt_PNombre
        '
        Me.txt_PNombre.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_PNombre.Location = New System.Drawing.Point(106, 61)
        Me.txt_PNombre.MaxLength = 15
        Me.txt_PNombre.Name = "txt_PNombre"
        Me.txt_PNombre.Size = New System.Drawing.Size(165, 20)
        Me.txt_PNombre.TabIndex = 96
        '
        'lbl_SNombre
        '
        Me.lbl_SNombre.AutoSize = True
        Me.lbl_SNombre.Location = New System.Drawing.Point(277, 61)
        Me.lbl_SNombre.Name = "lbl_SNombre"
        Me.lbl_SNombre.Size = New System.Drawing.Size(91, 13)
        Me.lbl_SNombre.TabIndex = 95
        Me.lbl_SNombre.Text = "Segundo nombre:"
        '
        'lbl_PNombre
        '
        Me.lbl_PNombre.AutoSize = True
        Me.lbl_PNombre.Location = New System.Drawing.Point(16, 64)
        Me.lbl_PNombre.Name = "lbl_PNombre"
        Me.lbl_PNombre.Size = New System.Drawing.Size(77, 13)
        Me.lbl_PNombre.TabIndex = 94
        Me.lbl_PNombre.Text = "Primer nombre:"
        '
        'lbl_SApellido
        '
        Me.lbl_SApellido.AutoSize = True
        Me.lbl_SApellido.Location = New System.Drawing.Point(277, 97)
        Me.lbl_SApellido.Name = "lbl_SApellido"
        Me.lbl_SApellido.Size = New System.Drawing.Size(92, 13)
        Me.lbl_SApellido.TabIndex = 107
        Me.lbl_SApellido.Text = "Segundo apellido:"
        '
        'lbl_PApellido
        '
        Me.lbl_PApellido.AutoSize = True
        Me.lbl_PApellido.Location = New System.Drawing.Point(15, 97)
        Me.lbl_PApellido.Name = "lbl_PApellido"
        Me.lbl_PApellido.Size = New System.Drawing.Size(78, 13)
        Me.lbl_PApellido.TabIndex = 106
        Me.lbl_PApellido.Text = "Primer apellido:"
        '
        'txt_Correro
        '
        Me.txt_Correro.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_Correro.Location = New System.Drawing.Point(581, 94)
        Me.txt_Correro.MaxLength = 20
        Me.txt_Correro.Name = "txt_Correro"
        Me.txt_Correro.Size = New System.Drawing.Size(165, 20)
        Me.txt_Correro.TabIndex = 113
        '
        'lbl_Correo
        '
        Me.lbl_Correo.AutoSize = True
        Me.lbl_Correo.Location = New System.Drawing.Point(533, 97)
        Me.lbl_Correo.Name = "lbl_Correo"
        Me.lbl_Correo.Size = New System.Drawing.Size(41, 13)
        Me.lbl_Correo.TabIndex = 112
        Me.lbl_Correo.Text = "Correo:"
        '
        'txt_TlfFijo
        '
        Me.txt_TlfFijo.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_TlfFijo.Location = New System.Drawing.Point(107, 129)
        Me.txt_TlfFijo.MaxLength = 11
        Me.txt_TlfFijo.Name = "txt_TlfFijo"
        Me.txt_TlfFijo.Size = New System.Drawing.Size(164, 20)
        Me.txt_TlfFijo.TabIndex = 110
        '
        'lbl_TlfFijo
        '
        Me.lbl_TlfFijo.AutoSize = True
        Me.lbl_TlfFijo.Location = New System.Drawing.Point(27, 132)
        Me.lbl_TlfFijo.Name = "lbl_TlfFijo"
        Me.lbl_TlfFijo.Size = New System.Drawing.Size(68, 13)
        Me.lbl_TlfFijo.TabIndex = 109
        Me.lbl_TlfFijo.Text = "Teléfono fijo:"
        '
        'grb_personales
        '
        Me.grb_personales.Controls.Add(Me.grb_Laboral)
        Me.grb_personales.Controls.Add(Me.txt_Correro)
        Me.grb_personales.Controls.Add(Me.lbl_Correo)
        Me.grb_personales.Controls.Add(Me.txt_TlfFijo)
        Me.grb_personales.Controls.Add(Me.lbl_TlfFijo)
        Me.grb_personales.Controls.Add(Me.lbl_SApellido)
        Me.grb_personales.Controls.Add(Me.lbl_PApellido)
        Me.grb_personales.Controls.Add(Me.btn_Buscar)
        Me.grb_personales.Controls.Add(Me.cmb_Nacionalidad)
        Me.grb_personales.Controls.Add(Me.txt_Cedula)
        Me.grb_personales.Controls.Add(Me.lbl_Cedula)
        Me.grb_personales.Controls.Add(Me.txt_SApellido)
        Me.grb_personales.Controls.Add(Me.txt_SNombre)
        Me.grb_personales.Controls.Add(Me.txt_PApellido)
        Me.grb_personales.Controls.Add(Me.txt_PNombre)
        Me.grb_personales.Controls.Add(Me.lbl_SNombre)
        Me.grb_personales.Controls.Add(Me.lbl_PNombre)
        Me.grb_personales.Location = New System.Drawing.Point(8, 150)
        Me.grb_personales.Name = "grb_personales"
        Me.grb_personales.Size = New System.Drawing.Size(755, 218)
        Me.grb_personales.TabIndex = 114
        Me.grb_personales.TabStop = False
        Me.grb_personales.Text = "Datos personales"
        '
        'grb_Laboral
        '
        Me.grb_Laboral.Controls.Add(Me.cmb_Tipoempleado)
        Me.grb_Laboral.Controls.Add(Me.lbl_Tipoempleado)
        Me.grb_Laboral.Location = New System.Drawing.Point(18, 155)
        Me.grb_Laboral.Name = "grb_Laboral"
        Me.grb_Laboral.Size = New System.Drawing.Size(687, 57)
        Me.grb_Laboral.TabIndex = 115
        Me.grb_Laboral.TabStop = False
        Me.grb_Laboral.Text = "Datos laborales"
        '
        'lbl_Tipoempleado
        '
        Me.lbl_Tipoempleado.AutoSize = True
        Me.lbl_Tipoempleado.Location = New System.Drawing.Point(32, 25)
        Me.lbl_Tipoempleado.Name = "lbl_Tipoempleado"
        Me.lbl_Tipoempleado.Size = New System.Drawing.Size(92, 13)
        Me.lbl_Tipoempleado.TabIndex = 0
        Me.lbl_Tipoempleado.Text = "Tipo de empleado"
        '
        'cmb_Tipoempleado
        '
        Me.cmb_Tipoempleado.FormattingEnabled = True
        Me.cmb_Tipoempleado.Location = New System.Drawing.Point(130, 22)
        Me.cmb_Tipoempleado.Name = "cmb_Tipoempleado"
        Me.cmb_Tipoempleado.Size = New System.Drawing.Size(123, 21)
        Me.cmb_Tipoempleado.TabIndex = 1
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Location = New System.Drawing.Point(324, 374)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 119
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Volver
        '
        Me.btn_Volver.Location = New System.Drawing.Point(513, 374)
        Me.btn_Volver.Name = "btn_Volver"
        Me.btn_Volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_Volver.TabIndex = 118
        Me.btn_Volver.Text = "Vovler"
        Me.btn_Volver.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(421, 374)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 117
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Location = New System.Drawing.Point(133, 374)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Agregar.TabIndex = 115
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Location = New System.Drawing.Point(226, 374)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Modificar.TabIndex = 116
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'frm_Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.SistemasIII.My.Resources.Resources.frm23
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(769, 410)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Volver)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.grb_personales)
        Me.Name = "frm_Empleado"
        Me.Text = "frm_Empleado"
        Me.grb_personales.ResumeLayout(False)
        Me.grb_personales.PerformLayout()
        Me.grb_Laboral.ResumeLayout(False)
        Me.grb_Laboral.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Buscar As Button
    Friend WithEvents cmb_Nacionalidad As ComboBox
    Friend WithEvents txt_Cedula As TextBox
    Friend WithEvents lbl_Cedula As Label
    Friend WithEvents txt_SApellido As TextBox
    Friend WithEvents txt_SNombre As TextBox
    Friend WithEvents txt_PApellido As TextBox
    Friend WithEvents txt_PNombre As TextBox
    Friend WithEvents lbl_SNombre As Label
    Friend WithEvents lbl_PNombre As Label
    Friend WithEvents lbl_SApellido As Label
    Friend WithEvents lbl_PApellido As Label
    Friend WithEvents txt_Correro As TextBox
    Friend WithEvents lbl_Correo As Label
    Friend WithEvents txt_TlfFijo As TextBox
    Friend WithEvents lbl_TlfFijo As Label
    Friend WithEvents grb_personales As GroupBox
    Friend WithEvents grb_Laboral As GroupBox
    Friend WithEvents cmb_Tipoempleado As ComboBox
    Friend WithEvents lbl_Tipoempleado As Label
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btn_Volver As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents btn_Modificar As Button
End Class
