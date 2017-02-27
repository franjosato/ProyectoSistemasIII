<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PlanPago
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
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rtb_Descripcion = New System.Windows.Forms.RichTextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.lbl_Cantidadc = New System.Windows.Forms.Label()
        Me.txt_Cantidadc = New System.Windows.Forms.TextBox()
        Me.lbl_Porcentaje = New System.Windows.Forms.Label()
        Me.txt_Porcentaje = New System.Windows.Forms.TextBox()
        Me.grb_datosbasicos = New System.Windows.Forms.GroupBox()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.grb_Modificadores = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoSaludo = New System.Windows.Forms.Label()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoFormuladio = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoModulo = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoEmpresa = New System.Windows.Forms.Label()
        Me.ptb_logo = New System.Windows.Forms.PictureBox()
        Me.grb_datosbasicos.SuspendLayout()
        Me.grb_Modificadores.SuspendLayout()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Location = New System.Drawing.Point(276, 31)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(43, 13)
        Me.lbl_codigo.TabIndex = 0
        Me.lbl_codigo.Text = "Codigo:"
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Enabled = False
        Me.txt_Codigo.Location = New System.Drawing.Point(325, 28)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(39, 20)
        Me.txt_Codigo.TabIndex = 1
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(19, 33)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_Nombre.TabIndex = 2
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Descripción:"
        '
        'rtb_Descripcion
        '
        Me.rtb_Descripcion.Enabled = False
        Me.rtb_Descripcion.Location = New System.Drawing.Point(87, 75)
        Me.rtb_Descripcion.Name = "rtb_Descripcion"
        Me.rtb_Descripcion.Size = New System.Drawing.Size(288, 81)
        Me.rtb_Descripcion.TabIndex = 4
        Me.rtb_Descripcion.Text = ""
        '
        'txt_Nombre
        '
        Me.txt_Nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_Nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_Nombre.Location = New System.Drawing.Point(71, 29)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_Nombre.TabIndex = 5
        '
        'lbl_Cantidadc
        '
        Me.lbl_Cantidadc.AutoSize = True
        Me.lbl_Cantidadc.Location = New System.Drawing.Point(40, 67)
        Me.lbl_Cantidadc.Name = "lbl_Cantidadc"
        Me.lbl_Cantidadc.Size = New System.Drawing.Size(127, 13)
        Me.lbl_Cantidadc.TabIndex = 6
        Me.lbl_Cantidadc.Text = "Cantidad de Cuotas(1-24)"
        '
        'txt_Cantidadc
        '
        Me.txt_Cantidadc.Enabled = False
        Me.txt_Cantidadc.Location = New System.Drawing.Point(186, 60)
        Me.txt_Cantidadc.Name = "txt_Cantidadc"
        Me.txt_Cantidadc.Size = New System.Drawing.Size(35, 20)
        Me.txt_Cantidadc.TabIndex = 7
        '
        'lbl_Porcentaje
        '
        Me.lbl_Porcentaje.AutoSize = True
        Me.lbl_Porcentaje.Location = New System.Drawing.Point(16, 104)
        Me.lbl_Porcentaje.Name = "lbl_Porcentaje"
        Me.lbl_Porcentaje.Size = New System.Drawing.Size(166, 13)
        Me.lbl_Porcentaje.TabIndex = 8
        Me.lbl_Porcentaje.Text = "Porcentaje sobre el monto(0-100):"
        '
        'txt_Porcentaje
        '
        Me.txt_Porcentaje.Enabled = False
        Me.txt_Porcentaje.Location = New System.Drawing.Point(188, 101)
        Me.txt_Porcentaje.Name = "txt_Porcentaje"
        Me.txt_Porcentaje.Size = New System.Drawing.Size(33, 20)
        Me.txt_Porcentaje.TabIndex = 9
        '
        'grb_datosbasicos
        '
        Me.grb_datosbasicos.Controls.Add(Me.btn_Buscar)
        Me.grb_datosbasicos.Controls.Add(Me.txt_Nombre)
        Me.grb_datosbasicos.Controls.Add(Me.rtb_Descripcion)
        Me.grb_datosbasicos.Controls.Add(Me.Label1)
        Me.grb_datosbasicos.Controls.Add(Me.lbl_Nombre)
        Me.grb_datosbasicos.Controls.Add(Me.txt_Codigo)
        Me.grb_datosbasicos.Controls.Add(Me.lbl_codigo)
        Me.grb_datosbasicos.Location = New System.Drawing.Point(11, 157)
        Me.grb_datosbasicos.Name = "grb_datosbasicos"
        Me.grb_datosbasicos.Size = New System.Drawing.Size(390, 182)
        Me.grb_datosbasicos.TabIndex = 10
        Me.grb_datosbasicos.TabStop = False
        Me.grb_datosbasicos.Text = "Datos básicos"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Location = New System.Drawing.Point(177, 26)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 17
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'grb_Modificadores
        '
        Me.grb_Modificadores.Controls.Add(Me.Label2)
        Me.grb_Modificadores.Controls.Add(Me.txt_Porcentaje)
        Me.grb_Modificadores.Controls.Add(Me.lbl_Porcentaje)
        Me.grb_Modificadores.Controls.Add(Me.txt_Cantidadc)
        Me.grb_Modificadores.Controls.Add(Me.lbl_Cantidadc)
        Me.grb_Modificadores.Location = New System.Drawing.Point(407, 157)
        Me.grb_Modificadores.Name = "grb_Modificadores"
        Me.grb_Modificadores.Size = New System.Drawing.Size(315, 182)
        Me.grb_Modificadores.TabIndex = 11
        Me.grb_Modificadores.TabStop = False
        Me.grb_Modificadores.Text = "Modificadores de cuotas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(227, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = " %"
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Enabled = False
        Me.btn_Agregar.Location = New System.Drawing.Point(107, 352)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Agregar.TabIndex = 12
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'btn_Salir
        '
        Me.btn_Salir.Location = New System.Drawing.Point(535, 352)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_Salir.TabIndex = 13
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(429, 352)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 14
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.Location = New System.Drawing.Point(326, 352)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 15
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Location = New System.Drawing.Point(220, 352)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Modificar.TabIndex = 16
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fecha.Location = New System.Drawing.Point(580, 12)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Fecha.TabIndex = 139
        Me.lbl_Fecha.Text = "dd/MM/YY"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Usuario.Location = New System.Drawing.Point(651, 62)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Usuario.TabIndex = 138
        Me.lbl_Usuario.Text = "Usuario"
        '
        'lbl_EncabezadoSaludo
        '
        Me.lbl_EncabezadoSaludo.AutoSize = True
        Me.lbl_EncabezadoSaludo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoSaludo.Location = New System.Drawing.Point(610, 62)
        Me.lbl_EncabezadoSaludo.Name = "lbl_EncabezadoSaludo"
        Me.lbl_EncabezadoSaludo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_EncabezadoSaludo.TabIndex = 137
        Me.lbl_EncabezadoSaludo.Text = "Hola, "
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Hora.Location = New System.Drawing.Point(644, 12)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Hora.TabIndex = 136
        Me.lbl_Hora.Text = "00:00:00"
        '
        'lbl_EncabezadoFormuladio
        '
        Me.lbl_EncabezadoFormuladio.AutoSize = True
        Me.lbl_EncabezadoFormuladio.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoFormuladio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoFormuladio.Location = New System.Drawing.Point(308, 88)
        Me.lbl_EncabezadoFormuladio.Name = "lbl_EncabezadoFormuladio"
        Me.lbl_EncabezadoFormuladio.Size = New System.Drawing.Size(141, 25)
        Me.lbl_EncabezadoFormuladio.TabIndex = 135
        Me.lbl_EncabezadoFormuladio.Text = "Plan de Pago"
        '
        'lbl_EncabezadoModulo
        '
        Me.lbl_EncabezadoModulo.AutoSize = True
        Me.lbl_EncabezadoModulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoModulo.Location = New System.Drawing.Point(281, 50)
        Me.lbl_EncabezadoModulo.Name = "lbl_EncabezadoModulo"
        Me.lbl_EncabezadoModulo.Size = New System.Drawing.Size(196, 25)
        Me.lbl_EncabezadoModulo.TabIndex = 134
        Me.lbl_EncabezadoModulo.Text = "Módulo de Servicio"
        '
        'lbl_EncabezadoEmpresa
        '
        Me.lbl_EncabezadoEmpresa.AutoSize = True
        Me.lbl_EncabezadoEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoEmpresa.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_EncabezadoEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoEmpresa.Location = New System.Drawing.Point(231, 9)
        Me.lbl_EncabezadoEmpresa.Name = "lbl_EncabezadoEmpresa"
        Me.lbl_EncabezadoEmpresa.Size = New System.Drawing.Size(291, 29)
        Me.lbl_EncabezadoEmpresa.TabIndex = 133
        Me.lbl_EncabezadoEmpresa.Text = "SEGUROS MALDONADO"
        '
        'ptb_logo
        '
        Me.ptb_logo.BackColor = System.Drawing.Color.Transparent
        Me.ptb_logo.BackgroundImage = Global.SistemasIII.My.Resources.Resources.fondot
        Me.ptb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptb_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptb_logo.Location = New System.Drawing.Point(26, -1)
        Me.ptb_logo.Name = "ptb_logo"
        Me.ptb_logo.Size = New System.Drawing.Size(132, 132)
        Me.ptb_logo.TabIndex = 132
        Me.ptb_logo.TabStop = False
        Me.ptb_logo.UseWaitCursor = True
        '
        'frm_PlanPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SistemasIII.My.Resources.Resources.frm23
        Me.CancelButton = Me.btn_Salir
        Me.ClientSize = New System.Drawing.Size(735, 390)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.lbl_EncabezadoSaludo)
        Me.Controls.Add(Me.lbl_Hora)
        Me.Controls.Add(Me.lbl_EncabezadoFormuladio)
        Me.Controls.Add(Me.lbl_EncabezadoModulo)
        Me.Controls.Add(Me.lbl_EncabezadoEmpresa)
        Me.Controls.Add(Me.ptb_logo)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.grb_Modificadores)
        Me.Controls.Add(Me.grb_datosbasicos)
        Me.Name = "frm_PlanPago"
        Me.Text = "Tipo de cuota"
        Me.grb_datosbasicos.ResumeLayout(False)
        Me.grb_datosbasicos.PerformLayout()
        Me.grb_Modificadores.ResumeLayout(False)
        Me.grb_Modificadores.PerformLayout()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_codigo As Label
    Friend WithEvents txt_Codigo As TextBox
    Friend WithEvents lbl_Nombre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rtb_Descripcion As RichTextBox
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents lbl_Cantidadc As Label
    Friend WithEvents txt_Cantidadc As TextBox
    Friend WithEvents lbl_Porcentaje As Label
    Friend WithEvents txt_Porcentaje As TextBox
    Friend WithEvents grb_datosbasicos As GroupBox
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents grb_Modificadores As GroupBox
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents btn_Salir As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btn_Modificar As Button
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents lbl_EncabezadoSaludo As Label
    Friend WithEvents lbl_Hora As Label
    Friend WithEvents lbl_EncabezadoFormuladio As Label
    Friend WithEvents lbl_EncabezadoModulo As Label
    Friend WithEvents lbl_EncabezadoEmpresa As Label
    Friend WithEvents ptb_logo As PictureBox
    Friend WithEvents Label2 As Label
End Class
