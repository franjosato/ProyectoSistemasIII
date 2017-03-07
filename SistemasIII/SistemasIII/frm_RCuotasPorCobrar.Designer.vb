<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RCuotasPorCobrar
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
        Me.btn_Volver = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.grb_busqueda = New System.Windows.Forms.GroupBox()
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Hasta = New System.Windows.Forms.Label()
        Me.lbl_Desde = New System.Windows.Forms.Label()
        Me.btn_Generar = New System.Windows.Forms.Button()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoSaludo = New System.Windows.Forms.Label()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoFormuladio = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoModulo = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoEmpresa = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ptb_logo = New System.Windows.Forms.PictureBox()
        Me.grb_busqueda.SuspendLayout()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Volver
        '
        Me.btn_Volver.Location = New System.Drawing.Point(348, 258)
        Me.btn_Volver.Name = "btn_Volver"
        Me.btn_Volver.Size = New System.Drawing.Size(81, 26)
        Me.btn_Volver.TabIndex = 145
        Me.btn_Volver.Text = "Volver"
        Me.btn_Volver.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(253, 258)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(81, 26)
        Me.btn_Cancelar.TabIndex = 144
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'grb_busqueda
        '
        Me.grb_busqueda.BackColor = System.Drawing.Color.White
        Me.grb_busqueda.Controls.Add(Me.dtp_Desde)
        Me.grb_busqueda.Controls.Add(Me.dtp_Hasta)
        Me.grb_busqueda.Controls.Add(Me.lbl_Hasta)
        Me.grb_busqueda.Controls.Add(Me.lbl_Desde)
        Me.grb_busqueda.Controls.Add(Me.btn_Generar)
        Me.grb_busqueda.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.grb_busqueda.Location = New System.Drawing.Point(23, 166)
        Me.grb_busqueda.Name = "grb_busqueda"
        Me.grb_busqueda.Size = New System.Drawing.Size(673, 79)
        Me.grb_busqueda.TabIndex = 143
        Me.grb_busqueda.TabStop = False
        Me.grb_busqueda.Text = "Datos de busqueda"
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Location = New System.Drawing.Point(88, 35)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(174, 22)
        Me.dtp_Desde.TabIndex = 133
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Location = New System.Drawing.Point(325, 36)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(171, 22)
        Me.dtp_Hasta.TabIndex = 10
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(271, 38)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(48, 17)
        Me.lbl_Hasta.TabIndex = 9
        Me.lbl_Hasta.Text = "Hasta: "
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(30, 38)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(52, 17)
        Me.lbl_Desde.TabIndex = 8
        Me.lbl_Desde.Text = "Desde: "
        '
        'btn_Generar
        '
        Me.btn_Generar.Location = New System.Drawing.Point(546, 35)
        Me.btn_Generar.Name = "btn_Generar"
        Me.btn_Generar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Generar.TabIndex = 7
        Me.btn_Generar.Text = " Generar"
        Me.btn_Generar.UseVisualStyleBackColor = True
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fecha.Location = New System.Drawing.Point(536, 34)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Fecha.TabIndex = 142
        Me.lbl_Fecha.Text = "dd/MM/YY"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Usuario.Location = New System.Drawing.Point(607, 84)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Usuario.TabIndex = 141
        Me.lbl_Usuario.Text = "Usuario"
        '
        'lbl_EncabezadoSaludo
        '
        Me.lbl_EncabezadoSaludo.AutoSize = True
        Me.lbl_EncabezadoSaludo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoSaludo.Location = New System.Drawing.Point(566, 84)
        Me.lbl_EncabezadoSaludo.Name = "lbl_EncabezadoSaludo"
        Me.lbl_EncabezadoSaludo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_EncabezadoSaludo.TabIndex = 140
        Me.lbl_EncabezadoSaludo.Text = "Hola, "
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Hora.Location = New System.Drawing.Point(600, 34)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Hora.TabIndex = 139
        Me.lbl_Hora.Text = "00:00:00"
        '
        'lbl_EncabezadoFormuladio
        '
        Me.lbl_EncabezadoFormuladio.AutoSize = True
        Me.lbl_EncabezadoFormuladio.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoFormuladio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoFormuladio.Location = New System.Drawing.Point(228, 117)
        Me.lbl_EncabezadoFormuladio.Name = "lbl_EncabezadoFormuladio"
        Me.lbl_EncabezadoFormuladio.Size = New System.Drawing.Size(292, 25)
        Me.lbl_EncabezadoFormuladio.TabIndex = 138
        Me.lbl_EncabezadoFormuladio.Text = "Reporte de cuotas por cobrar"
        '
        'lbl_EncabezadoModulo
        '
        Me.lbl_EncabezadoModulo.AutoSize = True
        Me.lbl_EncabezadoModulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoModulo.Location = New System.Drawing.Point(248, 75)
        Me.lbl_EncabezadoModulo.Name = "lbl_EncabezadoModulo"
        Me.lbl_EncabezadoModulo.Size = New System.Drawing.Size(230, 25)
        Me.lbl_EncabezadoModulo.TabIndex = 137
        Me.lbl_EncabezadoModulo.Text = " Modulo Administrativo"
        '
        'lbl_EncabezadoEmpresa
        '
        Me.lbl_EncabezadoEmpresa.AutoSize = True
        Me.lbl_EncabezadoEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoEmpresa.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_EncabezadoEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoEmpresa.Location = New System.Drawing.Point(228, 34)
        Me.lbl_EncabezadoEmpresa.Name = "lbl_EncabezadoEmpresa"
        Me.lbl_EncabezadoEmpresa.Size = New System.Drawing.Size(281, 29)
        Me.lbl_EncabezadoEmpresa.TabIndex = 136
        Me.lbl_EncabezadoEmpresa.Text = "Seguros Maldonado C.A."
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'ptb_logo
        '
        Me.ptb_logo.BackColor = System.Drawing.Color.Transparent
        Me.ptb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptb_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptb_logo.Image = Global.SistemasIII.My.Resources.Resources.fondot
        Me.ptb_logo.Location = New System.Drawing.Point(23, -2)
        Me.ptb_logo.Name = "ptb_logo"
        Me.ptb_logo.Size = New System.Drawing.Size(162, 162)
        Me.ptb_logo.TabIndex = 135
        Me.ptb_logo.TabStop = False
        Me.ptb_logo.UseWaitCursor = True
        '
        'frm_RCuotasPorCobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 216)
        Me.Controls.Add(Me.btn_Volver)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.grb_busqueda)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.lbl_EncabezadoSaludo)
        Me.Controls.Add(Me.lbl_Hora)
        Me.Controls.Add(Me.lbl_EncabezadoFormuladio)
        Me.Controls.Add(Me.lbl_EncabezadoModulo)
        Me.Controls.Add(Me.lbl_EncabezadoEmpresa)
        Me.Controls.Add(Me.ptb_logo)
        Me.Name = "frm_RCuotasPorCobrar"
        Me.Text = "Reporte de Ingresos"
        Me.grb_busqueda.ResumeLayout(False)
        Me.grb_busqueda.PerformLayout()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Volver As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents grb_busqueda As GroupBox
    Friend WithEvents dtp_Desde As DateTimePicker
    Friend WithEvents dtp_Hasta As DateTimePicker
    Friend WithEvents lbl_Hasta As Label
    Friend WithEvents lbl_Desde As Label
    Friend WithEvents btn_Generar As Button
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents lbl_EncabezadoSaludo As Label
    Friend WithEvents lbl_Hora As Label
    Friend WithEvents lbl_EncabezadoFormuladio As Label
    Friend WithEvents lbl_EncabezadoModulo As Label
    Friend WithEvents lbl_EncabezadoEmpresa As Label
    Friend WithEvents ptb_logo As PictureBox
    Friend WithEvents Timer As Timer
End Class
