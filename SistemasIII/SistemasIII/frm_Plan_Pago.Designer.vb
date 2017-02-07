<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Plan_Pago
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
        Me.grb_Planpago = New System.Windows.Forms.GroupBox()
        Me.grb_Basicos = New System.Windows.Forms.GroupBox()
        Me.rtb_Descripcion = New System.Windows.Forms.RichTextBox()
        Me.lbl_Descripcion = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.lbl_Codigo = New System.Windows.Forms.Label()
        Me.txt_Porcentaje = New System.Windows.Forms.TextBox()
        Me.lbl_Porcentaje = New System.Windows.Forms.Label()
        Me.txt_Ncuotas = New System.Windows.Forms.TextBox()
        Me.lbl_Ncuotas = New System.Windows.Forms.Label()
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
        Me.grb_Planpago.SuspendLayout()
        Me.grb_Basicos.SuspendLayout()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grb_Planpago
        '
        Me.grb_Planpago.Controls.Add(Me.grb_Basicos)
        Me.grb_Planpago.Controls.Add(Me.txt_Porcentaje)
        Me.grb_Planpago.Controls.Add(Me.lbl_Porcentaje)
        Me.grb_Planpago.Controls.Add(Me.txt_Ncuotas)
        Me.grb_Planpago.Controls.Add(Me.lbl_Ncuotas)
        Me.grb_Planpago.Location = New System.Drawing.Point(10, 150)
        Me.grb_Planpago.Name = "grb_Planpago"
        Me.grb_Planpago.Size = New System.Drawing.Size(648, 289)
        Me.grb_Planpago.TabIndex = 0
        Me.grb_Planpago.TabStop = False
        Me.grb_Planpago.Text = "Datos del plan de pago"
        '
        'grb_Basicos
        '
        Me.grb_Basicos.Controls.Add(Me.rtb_Descripcion)
        Me.grb_Basicos.Controls.Add(Me.lbl_Descripcion)
        Me.grb_Basicos.Controls.Add(Me.txt_Nombre)
        Me.grb_Basicos.Controls.Add(Me.lbl_Nombre)
        Me.grb_Basicos.Controls.Add(Me.btn_Buscar)
        Me.grb_Basicos.Controls.Add(Me.txt_Codigo)
        Me.grb_Basicos.Controls.Add(Me.lbl_Codigo)
        Me.grb_Basicos.Location = New System.Drawing.Point(21, 32)
        Me.grb_Basicos.Name = "grb_Basicos"
        Me.grb_Basicos.Size = New System.Drawing.Size(382, 224)
        Me.grb_Basicos.TabIndex = 11
        Me.grb_Basicos.TabStop = False
        Me.grb_Basicos.Text = "Datos básicos"
        '
        'rtb_Descripcion
        '
        Me.rtb_Descripcion.Location = New System.Drawing.Point(110, 128)
        Me.rtb_Descripcion.Name = "rtb_Descripcion"
        Me.rtb_Descripcion.Size = New System.Drawing.Size(240, 78)
        Me.rtb_Descripcion.TabIndex = 6
        Me.rtb_Descripcion.Text = ""
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Location = New System.Drawing.Point(38, 131)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(66, 13)
        Me.lbl_Descripcion.TabIndex = 5
        Me.lbl_Descripcion.Text = "Descripción:"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(110, 74)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_Nombre.TabIndex = 4
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(57, 77)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_Nombre.TabIndex = 3
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Location = New System.Drawing.Point(216, 18)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Location = New System.Drawing.Point(110, 20)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_Codigo.TabIndex = 1
        '
        'lbl_Codigo
        '
        Me.lbl_Codigo.AutoSize = True
        Me.lbl_Codigo.Location = New System.Drawing.Point(61, 23)
        Me.lbl_Codigo.Name = "lbl_Codigo"
        Me.lbl_Codigo.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Codigo.TabIndex = 0
        Me.lbl_Codigo.Text = "Código:"
        '
        'txt_Porcentaje
        '
        Me.txt_Porcentaje.Location = New System.Drawing.Point(526, 153)
        Me.txt_Porcentaje.Name = "txt_Porcentaje"
        Me.txt_Porcentaje.Size = New System.Drawing.Size(100, 20)
        Me.txt_Porcentaje.TabIndex = 10
        '
        'lbl_Porcentaje
        '
        Me.lbl_Porcentaje.AutoSize = True
        Me.lbl_Porcentaje.Location = New System.Drawing.Point(459, 156)
        Me.lbl_Porcentaje.Name = "lbl_Porcentaje"
        Me.lbl_Porcentaje.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Porcentaje.TabIndex = 9
        Me.lbl_Porcentaje.Text = "Porcentaje:"
        '
        'txt_Ncuotas
        '
        Me.txt_Ncuotas.Location = New System.Drawing.Point(526, 91)
        Me.txt_Ncuotas.Name = "txt_Ncuotas"
        Me.txt_Ncuotas.Size = New System.Drawing.Size(100, 20)
        Me.txt_Ncuotas.TabIndex = 8
        '
        'lbl_Ncuotas
        '
        Me.lbl_Ncuotas.AutoSize = True
        Me.lbl_Ncuotas.Location = New System.Drawing.Point(423, 94)
        Me.lbl_Ncuotas.Name = "lbl_Ncuotas"
        Me.lbl_Ncuotas.Size = New System.Drawing.Size(97, 13)
        Me.lbl_Ncuotas.TabIndex = 7
        Me.lbl_Ncuotas.Text = "Número de cuotas:"
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Location = New System.Drawing.Point(286, 445)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 16
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Volver
        '
        Me.btn_Volver.Location = New System.Drawing.Point(475, 445)
        Me.btn_Volver.Name = "btn_Volver"
        Me.btn_Volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_Volver.TabIndex = 15
        Me.btn_Volver.Text = "Vovler"
        Me.btn_Volver.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(383, 445)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 14
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Location = New System.Drawing.Point(188, 445)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Modificar.TabIndex = 13
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Location = New System.Drawing.Point(95, 445)
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
        Me.lbl_Fecha.Location = New System.Drawing.Point(555, 13)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Fecha.TabIndex = 131
        Me.lbl_Fecha.Text = "dd/MM/YY"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Usuario.Location = New System.Drawing.Point(626, 63)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Usuario.TabIndex = 130
        Me.lbl_Usuario.Text = "Usuario"
        '
        'lbl_EncabezadoSaludo
        '
        Me.lbl_EncabezadoSaludo.AutoSize = True
        Me.lbl_EncabezadoSaludo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoSaludo.Location = New System.Drawing.Point(585, 63)
        Me.lbl_EncabezadoSaludo.Name = "lbl_EncabezadoSaludo"
        Me.lbl_EncabezadoSaludo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_EncabezadoSaludo.TabIndex = 129
        Me.lbl_EncabezadoSaludo.Text = "Hola, "
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Hora.Location = New System.Drawing.Point(619, 13)
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
        Me.lbl_EncabezadoFormuladio.Location = New System.Drawing.Point(240, 99)
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
        Me.lbl_EncabezadoModulo.Location = New System.Drawing.Point(248, 55)
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
        Me.lbl_EncabezadoEmpresa.Location = New System.Drawing.Point(206, 10)
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
        Me.ptb_logo.Location = New System.Drawing.Point(1, 0)
        Me.ptb_logo.Name = "ptb_logo"
        Me.ptb_logo.Size = New System.Drawing.Size(132, 132)
        Me.ptb_logo.TabIndex = 124
        Me.ptb_logo.TabStop = False
        Me.ptb_logo.UseWaitCursor = True
        '
        'frm_Plan_Pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.SistemasIII.My.Resources.Resources.frm23
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(669, 482)
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
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.grb_Planpago)
        Me.Name = "frm_Plan_Pago"
        Me.Text = "frm_Plan_Pago"
        Me.grb_Planpago.ResumeLayout(False)
        Me.grb_Planpago.PerformLayout()
        Me.grb_Basicos.ResumeLayout(False)
        Me.grb_Basicos.PerformLayout()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grb_Planpago As GroupBox
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents lbl_Nombre As Label
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents txt_Codigo As TextBox
    Friend WithEvents lbl_Codigo As Label
    Friend WithEvents grb_Basicos As GroupBox
    Friend WithEvents rtb_Descripcion As RichTextBox
    Friend WithEvents lbl_Descripcion As Label
    Friend WithEvents txt_Porcentaje As TextBox
    Friend WithEvents lbl_Porcentaje As Label
    Friend WithEvents txt_Ncuotas As TextBox
    Friend WithEvents lbl_Ncuotas As Label
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
