<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Cuotas
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
        Me.btn_Volver = New System.Windows.Forms.Button()
        Me.grb_cuota = New System.Windows.Forms.GroupBox()
        Me.grb_busqueda = New System.Windows.Forms.GroupBox()
        Me.lbl_Asegurado = New System.Windows.Forms.Label()
        Me.cmb_CedulaA = New System.Windows.Forms.ComboBox()
        Me.txt_CedulaA = New System.Windows.Forms.TextBox()
        Me.txt_Placa = New System.Windows.Forms.TextBox()
        Me.lbl_Placa = New System.Windows.Forms.Label()
        Me.btn_BuscarT = New System.Windows.Forms.Button()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.lbl_Codigo = New System.Windows.Forms.Label()
        Me.cmb_NacionalidadT = New System.Windows.Forms.ComboBox()
        Me.txt_CedulaT = New System.Windows.Forms.TextBox()
        Me.lbl_CedulaT = New System.Windows.Forms.Label()
        Me.dgv_cuotas = New System.Windows.Forms.DataGridView()
        Me.cuotas_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuota_fechacobor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuota_monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoSaludo = New System.Windows.Forms.Label()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoFormuladio = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoModulo = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoEmpresa = New System.Windows.Forms.Label()
        Me.ptb_logo = New System.Windows.Forms.PictureBox()
        Me.grb_cuota.SuspendLayout()
        Me.grb_busqueda.SuspendLayout()
        CType(Me.dgv_cuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Volver
        '
        Me.btn_Volver.Location = New System.Drawing.Point(379, 510)
        Me.btn_Volver.Name = "btn_Volver"
        Me.btn_Volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_Volver.TabIndex = 124
        Me.btn_Volver.Text = "Vovler"
        Me.btn_Volver.UseVisualStyleBackColor = True
        '
        'grb_cuota
        '
        Me.grb_cuota.Controls.Add(Me.grb_busqueda)
        Me.grb_cuota.Controls.Add(Me.dgv_cuotas)
        Me.grb_cuota.Location = New System.Drawing.Point(12, 152)
        Me.grb_cuota.Name = "grb_cuota"
        Me.grb_cuota.Size = New System.Drawing.Size(676, 352)
        Me.grb_cuota.TabIndex = 123
        Me.grb_cuota.TabStop = False
        Me.grb_cuota.Text = "Datos de la cuota"
        '
        'grb_busqueda
        '
        Me.grb_busqueda.Controls.Add(Me.lbl_Asegurado)
        Me.grb_busqueda.Controls.Add(Me.cmb_CedulaA)
        Me.grb_busqueda.Controls.Add(Me.txt_CedulaA)
        Me.grb_busqueda.Controls.Add(Me.txt_Placa)
        Me.grb_busqueda.Controls.Add(Me.lbl_Placa)
        Me.grb_busqueda.Controls.Add(Me.btn_BuscarT)
        Me.grb_busqueda.Controls.Add(Me.txt_Codigo)
        Me.grb_busqueda.Controls.Add(Me.lbl_Codigo)
        Me.grb_busqueda.Controls.Add(Me.cmb_NacionalidadT)
        Me.grb_busqueda.Controls.Add(Me.txt_CedulaT)
        Me.grb_busqueda.Controls.Add(Me.lbl_CedulaT)
        Me.grb_busqueda.Location = New System.Drawing.Point(14, 19)
        Me.grb_busqueda.Name = "grb_busqueda"
        Me.grb_busqueda.Size = New System.Drawing.Size(643, 97)
        Me.grb_busqueda.TabIndex = 121
        Me.grb_busqueda.TabStop = False
        Me.grb_busqueda.Text = "Datos de busqueda"
        '
        'lbl_Asegurado
        '
        Me.lbl_Asegurado.AutoSize = True
        Me.lbl_Asegurado.Location = New System.Drawing.Point(3, 49)
        Me.lbl_Asegurado.Name = "lbl_Asegurado"
        Me.lbl_Asegurado.Size = New System.Drawing.Size(113, 13)
        Me.lbl_Asegurado.TabIndex = 121
        Me.lbl_Asegurado.Text = "Cédula del asegurado:"
        '
        'cmb_CedulaA
        '
        Me.cmb_CedulaA.AutoCompleteCustomSource.AddRange(New String() {"V", "E"})
        Me.cmb_CedulaA.BackColor = System.Drawing.Color.GhostWhite
        Me.cmb_CedulaA.FormattingEnabled = True
        Me.cmb_CedulaA.Location = New System.Drawing.Point(122, 45)
        Me.cmb_CedulaA.Name = "cmb_CedulaA"
        Me.cmb_CedulaA.Size = New System.Drawing.Size(47, 21)
        Me.cmb_CedulaA.TabIndex = 119
        '
        'txt_CedulaA
        '
        Me.txt_CedulaA.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_CedulaA.Location = New System.Drawing.Point(175, 46)
        Me.txt_CedulaA.MaxLength = 8
        Me.txt_CedulaA.Name = "txt_CedulaA"
        Me.txt_CedulaA.Size = New System.Drawing.Size(85, 20)
        Me.txt_CedulaA.TabIndex = 118
        '
        'txt_Placa
        '
        Me.txt_Placa.Location = New System.Drawing.Point(325, 46)
        Me.txt_Placa.Name = "txt_Placa"
        Me.txt_Placa.Size = New System.Drawing.Size(138, 20)
        Me.txt_Placa.TabIndex = 115
        '
        'lbl_Placa
        '
        Me.lbl_Placa.AutoSize = True
        Me.lbl_Placa.Location = New System.Drawing.Point(273, 49)
        Me.lbl_Placa.Name = "lbl_Placa"
        Me.lbl_Placa.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Placa.TabIndex = 114
        Me.lbl_Placa.Text = " Placa:"
        '
        'btn_BuscarT
        '
        Me.btn_BuscarT.Location = New System.Drawing.Point(553, 16)
        Me.btn_BuscarT.Name = "btn_BuscarT"
        Me.btn_BuscarT.Size = New System.Drawing.Size(75, 23)
        Me.btn_BuscarT.TabIndex = 109
        Me.btn_BuscarT.Text = "Buscar"
        Me.btn_BuscarT.UseVisualStyleBackColor = True
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Location = New System.Drawing.Point(377, 16)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(86, 20)
        Me.txt_Codigo.TabIndex = 111
        '
        'lbl_Codigo
        '
        Me.lbl_Codigo.AutoSize = True
        Me.lbl_Codigo.Location = New System.Drawing.Point(266, 19)
        Me.lbl_Codigo.Name = "lbl_Codigo"
        Me.lbl_Codigo.Size = New System.Drawing.Size(99, 13)
        Me.lbl_Codigo.TabIndex = 110
        Me.lbl_Codigo.Text = "Código de la poliza:"
        '
        'cmb_NacionalidadT
        '
        Me.cmb_NacionalidadT.AutoCompleteCustomSource.AddRange(New String() {"V", "E"})
        Me.cmb_NacionalidadT.BackColor = System.Drawing.Color.GhostWhite
        Me.cmb_NacionalidadT.FormattingEnabled = True
        Me.cmb_NacionalidadT.Location = New System.Drawing.Point(123, 15)
        Me.cmb_NacionalidadT.Name = "cmb_NacionalidadT"
        Me.cmb_NacionalidadT.Size = New System.Drawing.Size(47, 21)
        Me.cmb_NacionalidadT.TabIndex = 108
        '
        'txt_CedulaT
        '
        Me.txt_CedulaT.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_CedulaT.Location = New System.Drawing.Point(176, 15)
        Me.txt_CedulaT.MaxLength = 8
        Me.txt_CedulaT.Name = "txt_CedulaT"
        Me.txt_CedulaT.Size = New System.Drawing.Size(85, 20)
        Me.txt_CedulaT.TabIndex = 107
        '
        'lbl_CedulaT
        '
        Me.lbl_CedulaT.AutoSize = True
        Me.lbl_CedulaT.Location = New System.Drawing.Point(15, 19)
        Me.lbl_CedulaT.Name = "lbl_CedulaT"
        Me.lbl_CedulaT.Size = New System.Drawing.Size(101, 13)
        Me.lbl_CedulaT.TabIndex = 106
        Me.lbl_CedulaT.Text = "Cédula del tomador:"
        '
        'dgv_cuotas
        '
        Me.dgv_cuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cuotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cuotas_codigo, Me.cuota_fechacobor, Me.cuota_monto})
        Me.dgv_cuotas.Location = New System.Drawing.Point(14, 122)
        Me.dgv_cuotas.Name = "dgv_cuotas"
        Me.dgv_cuotas.Size = New System.Drawing.Size(643, 224)
        Me.dgv_cuotas.TabIndex = 2
        '
        'cuotas_codigo
        '
        Me.cuotas_codigo.HeaderText = "Código"
        Me.cuotas_codigo.Name = "cuotas_codigo"
        '
        'cuota_fechacobor
        '
        Me.cuota_fechacobor.HeaderText = "Fecha de cobro"
        Me.cuota_fechacobor.Name = "cuota_fechacobor"
        Me.cuota_fechacobor.Width = 200
        '
        'cuota_monto
        '
        Me.cuota_monto.HeaderText = "Monto a cobrar"
        Me.cuota_monto.Name = "cuota_monto"
        Me.cuota_monto.Width = 300
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(285, 510)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 125
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fecha.Location = New System.Drawing.Point(558, 14)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Fecha.TabIndex = 133
        Me.lbl_Fecha.Text = "dd/MM/YY"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Usuario.Location = New System.Drawing.Point(629, 64)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Usuario.TabIndex = 132
        Me.lbl_Usuario.Text = "Usuario"
        '
        'lbl_EncabezadoSaludo
        '
        Me.lbl_EncabezadoSaludo.AutoSize = True
        Me.lbl_EncabezadoSaludo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoSaludo.Location = New System.Drawing.Point(588, 64)
        Me.lbl_EncabezadoSaludo.Name = "lbl_EncabezadoSaludo"
        Me.lbl_EncabezadoSaludo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_EncabezadoSaludo.TabIndex = 131
        Me.lbl_EncabezadoSaludo.Text = "Hola, "
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Hora.Location = New System.Drawing.Point(622, 14)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Hora.TabIndex = 130
        Me.lbl_Hora.Text = "00:00:00"
        '
        'lbl_EncabezadoFormuladio
        '
        Me.lbl_EncabezadoFormuladio.AutoSize = True
        Me.lbl_EncabezadoFormuladio.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoFormuladio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoFormuladio.Location = New System.Drawing.Point(243, 100)
        Me.lbl_EncabezadoFormuladio.Name = "lbl_EncabezadoFormuladio"
        Me.lbl_EncabezadoFormuladio.Size = New System.Drawing.Size(213, 25)
        Me.lbl_EncabezadoFormuladio.TabIndex = 129
        Me.lbl_EncabezadoFormuladio.Text = "Datos del Asegurado"
        '
        'lbl_EncabezadoModulo
        '
        Me.lbl_EncabezadoModulo.AutoSize = True
        Me.lbl_EncabezadoModulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoModulo.Location = New System.Drawing.Point(251, 56)
        Me.lbl_EncabezadoModulo.Name = "lbl_EncabezadoModulo"
        Me.lbl_EncabezadoModulo.Size = New System.Drawing.Size(196, 25)
        Me.lbl_EncabezadoModulo.TabIndex = 128
        Me.lbl_EncabezadoModulo.Text = "Módulo de Servicio"
        '
        'lbl_EncabezadoEmpresa
        '
        Me.lbl_EncabezadoEmpresa.AutoSize = True
        Me.lbl_EncabezadoEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoEmpresa.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_EncabezadoEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoEmpresa.Location = New System.Drawing.Point(209, 11)
        Me.lbl_EncabezadoEmpresa.Name = "lbl_EncabezadoEmpresa"
        Me.lbl_EncabezadoEmpresa.Size = New System.Drawing.Size(291, 29)
        Me.lbl_EncabezadoEmpresa.TabIndex = 127
        Me.lbl_EncabezadoEmpresa.Text = "SEGUROS MALDONADO"
        '
        'ptb_logo
        '
        Me.ptb_logo.BackColor = System.Drawing.Color.Transparent
        Me.ptb_logo.BackgroundImage = Global.SistemasIII.My.Resources.Resources.fondot
        Me.ptb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptb_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptb_logo.Location = New System.Drawing.Point(4, 1)
        Me.ptb_logo.Name = "ptb_logo"
        Me.ptb_logo.Size = New System.Drawing.Size(132, 132)
        Me.ptb_logo.TabIndex = 126
        Me.ptb_logo.TabStop = False
        Me.ptb_logo.UseWaitCursor = True
        '
        'frm_Cuotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.SistemasIII.My.Resources.Resources.frm23
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(697, 540)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.lbl_EncabezadoSaludo)
        Me.Controls.Add(Me.lbl_Hora)
        Me.Controls.Add(Me.lbl_EncabezadoFormuladio)
        Me.Controls.Add(Me.lbl_EncabezadoModulo)
        Me.Controls.Add(Me.lbl_EncabezadoEmpresa)
        Me.Controls.Add(Me.ptb_logo)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Volver)
        Me.Controls.Add(Me.grb_cuota)
        Me.Name = "frm_Cuotas"
        Me.Text = "frm_Cuotas"
        Me.grb_cuota.ResumeLayout(False)
        Me.grb_busqueda.ResumeLayout(False)
        Me.grb_busqueda.PerformLayout()
        CType(Me.dgv_cuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Volver As Button
    Friend WithEvents grb_cuota As GroupBox
    Friend WithEvents grb_busqueda As GroupBox
    Friend WithEvents lbl_Asegurado As Label
    Friend WithEvents cmb_CedulaA As ComboBox
    Friend WithEvents txt_CedulaA As TextBox
    Friend WithEvents txt_Placa As TextBox
    Friend WithEvents lbl_Placa As Label
    Friend WithEvents btn_BuscarT As Button
    Friend WithEvents txt_Codigo As TextBox
    Friend WithEvents lbl_Codigo As Label
    Friend WithEvents cmb_NacionalidadT As ComboBox
    Friend WithEvents txt_CedulaT As TextBox
    Friend WithEvents lbl_CedulaT As Label
    Friend WithEvents dgv_cuotas As DataGridView
    Friend WithEvents cuotas_codigo As DataGridViewTextBoxColumn
    Friend WithEvents cuota_fechacobor As DataGridViewTextBoxColumn
    Friend WithEvents cuota_monto As DataGridViewTextBoxColumn
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents lbl_EncabezadoSaludo As Label
    Friend WithEvents lbl_Hora As Label
    Friend WithEvents lbl_EncabezadoFormuladio As Label
    Friend WithEvents lbl_EncabezadoModulo As Label
    Friend WithEvents lbl_EncabezadoEmpresa As Label
    Friend WithEvents ptb_logo As PictureBox
End Class
