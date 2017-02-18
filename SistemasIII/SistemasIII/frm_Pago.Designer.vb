<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Pago
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Pago))
        Me.grb_cuota = New System.Windows.Forms.GroupBox()
        Me.grb_busqueda = New System.Windows.Forms.GroupBox()
        Me.lbl_Asegurado = New System.Windows.Forms.Label()
        Me.cmb_CedulaA = New System.Windows.Forms.ComboBox()
        Me.txt_CedulaA = New System.Windows.Forms.TextBox()
        Me.lbl_Placa = New System.Windows.Forms.Label()
        Me.btn_BuscarT = New System.Windows.Forms.Button()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.lbl_Codigo = New System.Windows.Forms.Label()
        Me.cmb_NacionalidadT = New System.Windows.Forms.ComboBox()
        Me.txt_CedulaT = New System.Windows.Forms.TextBox()
        Me.lbl_CedulaT = New System.Windows.Forms.Label()
        Me.lbl_CedulaA = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_Cambio = New System.Windows.Forms.TextBox()
        Me.lbl_Cambio = New System.Windows.Forms.Label()
        Me.dgv_Pagos = New System.Windows.Forms.DataGridView()
        Me.FormadePagoGrid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoCanceladoGrid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoFaltanteGrid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_Añadir = New System.Windows.Forms.Button()
        Me.txt_Montoacancelar = New System.Windows.Forms.TextBox()
        Me.lbl_Montoacancelar = New System.Windows.Forms.Label()
        Me.lbl_Formapago = New System.Windows.Forms.Label()
        Me.cmb_Formapago = New System.Windows.Forms.ComboBox()
        Me.txt_Totalapagar = New System.Windows.Forms.TextBox()
        Me.lbl_Totalapagar = New System.Windows.Forms.Label()
        Me.btn_Volver = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Procesarpago = New System.Windows.Forms.Button()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoSaludo = New System.Windows.Forms.Label()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoFormuladio = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoModulo = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoEmpresa = New System.Windows.Forms.Label()
        Me.ptb_logo = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.grb_cuota.SuspendLayout()
        Me.grb_busqueda.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_Pagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grb_cuota
        '
        Me.grb_cuota.Controls.Add(Me.TextBox3)
        Me.grb_cuota.Controls.Add(Me.Label3)
        Me.grb_cuota.Controls.Add(Me.TextBox2)
        Me.grb_cuota.Controls.Add(Me.Label2)
        Me.grb_cuota.Controls.Add(Me.grb_busqueda)
        Me.grb_cuota.Controls.Add(Me.lbl_CedulaA)
        Me.grb_cuota.Controls.Add(Me.TextBox1)
        Me.grb_cuota.Controls.Add(Me.Label1)
        Me.grb_cuota.Location = New System.Drawing.Point(12, 148)
        Me.grb_cuota.Name = "grb_cuota"
        Me.grb_cuota.Size = New System.Drawing.Size(691, 122)
        Me.grb_cuota.TabIndex = 36
        Me.grb_cuota.TabStop = False
        '
        'grb_busqueda
        '
        Me.grb_busqueda.Controls.Add(Me.ComboBox1)
        Me.grb_busqueda.Controls.Add(Me.lbl_Asegurado)
        Me.grb_busqueda.Controls.Add(Me.cmb_CedulaA)
        Me.grb_busqueda.Controls.Add(Me.txt_CedulaA)
        Me.grb_busqueda.Controls.Add(Me.lbl_Placa)
        Me.grb_busqueda.Controls.Add(Me.btn_BuscarT)
        Me.grb_busqueda.Controls.Add(Me.txt_Codigo)
        Me.grb_busqueda.Controls.Add(Me.lbl_Codigo)
        Me.grb_busqueda.Controls.Add(Me.cmb_NacionalidadT)
        Me.grb_busqueda.Controls.Add(Me.txt_CedulaT)
        Me.grb_busqueda.Controls.Add(Me.lbl_CedulaT)
        Me.grb_busqueda.Location = New System.Drawing.Point(9, 15)
        Me.grb_busqueda.Name = "grb_busqueda"
        Me.grb_busqueda.Size = New System.Drawing.Size(478, 97)
        Me.grb_busqueda.TabIndex = 120
        Me.grb_busqueda.TabStop = False
        Me.grb_busqueda.Text = "Datos de busqueda"
        '
        'lbl_Asegurado
        '
        Me.lbl_Asegurado.AutoSize = True
        Me.lbl_Asegurado.Location = New System.Drawing.Point(3, 48)
        Me.lbl_Asegurado.Name = "lbl_Asegurado"
        Me.lbl_Asegurado.Size = New System.Drawing.Size(113, 13)
        Me.lbl_Asegurado.TabIndex = 120
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
        'lbl_Placa
        '
        Me.lbl_Placa.AutoSize = True
        Me.lbl_Placa.Location = New System.Drawing.Point(76, 75)
        Me.lbl_Placa.Name = "lbl_Placa"
        Me.lbl_Placa.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Placa.TabIndex = 114
        Me.lbl_Placa.Text = " Placa:"
        '
        'btn_BuscarT
        '
        Me.btn_BuscarT.Location = New System.Drawing.Point(377, 48)
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
        Me.lbl_Codigo.Text = "Código de la póliza:"
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
        Me.lbl_CedulaT.Location = New System.Drawing.Point(15, 18)
        Me.lbl_CedulaT.Name = "lbl_CedulaT"
        Me.lbl_CedulaT.Size = New System.Drawing.Size(101, 13)
        Me.lbl_CedulaT.TabIndex = 106
        Me.lbl_CedulaT.Text = "Cédula del tomador:"
        '
        'lbl_CedulaA
        '
        Me.lbl_CedulaA.AutoSize = True
        Me.lbl_CedulaA.Location = New System.Drawing.Point(6, 52)
        Me.lbl_CedulaA.Name = "lbl_CedulaA"
        Me.lbl_CedulaA.Size = New System.Drawing.Size(114, 13)
        Me.lbl_CedulaA.TabIndex = 117
        Me.lbl_CedulaA.Text = "Cédula del Asegurado:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(599, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(86, 20)
        Me.TextBox1.TabIndex = 113
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(504, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Monto de cuota:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_Cambio)
        Me.GroupBox1.Controls.Add(Me.lbl_Cambio)
        Me.GroupBox1.Controls.Add(Me.dgv_Pagos)
        Me.GroupBox1.Controls.Add(Me.btn_Añadir)
        Me.GroupBox1.Controls.Add(Me.txt_Montoacancelar)
        Me.GroupBox1.Controls.Add(Me.lbl_Montoacancelar)
        Me.GroupBox1.Controls.Add(Me.lbl_Formapago)
        Me.GroupBox1.Controls.Add(Me.cmb_Formapago)
        Me.GroupBox1.Controls.Add(Me.txt_Totalapagar)
        Me.GroupBox1.Controls.Add(Me.lbl_Totalapagar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 276)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(691, 235)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txt_Cambio
        '
        Me.txt_Cambio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cambio.Location = New System.Drawing.Point(579, 199)
        Me.txt_Cambio.Name = "txt_Cambio"
        Me.txt_Cambio.Size = New System.Drawing.Size(107, 23)
        Me.txt_Cambio.TabIndex = 26
        '
        'lbl_Cambio
        '
        Me.lbl_Cambio.AutoSize = True
        Me.lbl_Cambio.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Cambio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cambio.Location = New System.Drawing.Point(372, 199)
        Me.lbl_Cambio.Name = "lbl_Cambio"
        Me.lbl_Cambio.Size = New System.Drawing.Size(201, 16)
        Me.lbl_Cambio.TabIndex = 25
        Me.lbl_Cambio.Text = "Cambio en Efectivo al Cliente"
        '
        'dgv_Pagos
        '
        Me.dgv_Pagos.AllowUserToAddRows = False
        Me.dgv_Pagos.AllowUserToDeleteRows = False
        Me.dgv_Pagos.AllowUserToResizeColumns = False
        Me.dgv_Pagos.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Pagos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Pagos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Pagos.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.dgv_Pagos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_Pagos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dgv_Pagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_Pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_Pagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FormadePagoGrid, Me.MontoCanceladoGrid, Me.MontoFaltanteGrid})
        Me.dgv_Pagos.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_Pagos.Location = New System.Drawing.Point(211, 43)
        Me.dgv_Pagos.Name = "dgv_Pagos"
        Me.dgv_Pagos.ReadOnly = True
        Me.dgv_Pagos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_Pagos.RowHeadersVisible = False
        Me.dgv_Pagos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_Pagos.Size = New System.Drawing.Size(474, 147)
        Me.dgv_Pagos.TabIndex = 24
        '
        'FormadePagoGrid
        '
        Me.FormadePagoGrid.HeaderText = "Forma de Pago"
        Me.FormadePagoGrid.Name = "FormadePagoGrid"
        Me.FormadePagoGrid.ReadOnly = True
        '
        'MontoCanceladoGrid
        '
        Me.MontoCanceladoGrid.HeaderText = "Monto Cancelado en BsF."
        Me.MontoCanceladoGrid.Name = "MontoCanceladoGrid"
        Me.MontoCanceladoGrid.ReadOnly = True
        Me.MontoCanceladoGrid.Width = 200
        '
        'MontoFaltanteGrid
        '
        Me.MontoFaltanteGrid.HeaderText = "Monto Faltante (Bs.F.)"
        Me.MontoFaltanteGrid.Name = "MontoFaltanteGrid"
        Me.MontoFaltanteGrid.ReadOnly = True
        Me.MontoFaltanteGrid.Width = 200
        '
        'btn_Añadir
        '
        Me.btn_Añadir.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Añadir.BackgroundImage = CType(resources.GetObject("btn_Añadir.BackgroundImage"), System.Drawing.Image)
        Me.btn_Añadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_Añadir.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Añadir.Location = New System.Drawing.Point(30, 173)
        Me.btn_Añadir.Name = "btn_Añadir"
        Me.btn_Añadir.Size = New System.Drawing.Size(106, 29)
        Me.btn_Añadir.TabIndex = 23
        Me.btn_Añadir.Text = "Añadir"
        Me.btn_Añadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Añadir.UseVisualStyleBackColor = False
        '
        'txt_Montoacancelar
        '
        Me.txt_Montoacancelar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Montoacancelar.Location = New System.Drawing.Point(8, 144)
        Me.txt_Montoacancelar.Name = "txt_Montoacancelar"
        Me.txt_Montoacancelar.Size = New System.Drawing.Size(166, 23)
        Me.txt_Montoacancelar.TabIndex = 22
        '
        'lbl_Montoacancelar
        '
        Me.lbl_Montoacancelar.AutoSize = True
        Me.lbl_Montoacancelar.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Montoacancelar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Montoacancelar.Location = New System.Drawing.Point(6, 124)
        Me.lbl_Montoacancelar.Name = "lbl_Montoacancelar"
        Me.lbl_Montoacancelar.Size = New System.Drawing.Size(157, 17)
        Me.lbl_Montoacancelar.TabIndex = 21
        Me.lbl_Montoacancelar.Text = "Monto a Cancelar Bs.F."
        '
        'lbl_Formapago
        '
        Me.lbl_Formapago.AutoSize = True
        Me.lbl_Formapago.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Formapago.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Formapago.Location = New System.Drawing.Point(6, 60)
        Me.lbl_Formapago.Name = "lbl_Formapago"
        Me.lbl_Formapago.Size = New System.Drawing.Size(109, 17)
        Me.lbl_Formapago.TabIndex = 20
        Me.lbl_Formapago.Text = "Forma de Pago"
        '
        'cmb_Formapago
        '
        Me.cmb_Formapago.AutoCompleteCustomSource.AddRange(New String() {"Debito", "Credito", "Efectivo"})
        Me.cmb_Formapago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_Formapago.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Formapago.FormattingEnabled = True
        Me.cmb_Formapago.Items.AddRange(New Object() {"Debito", "Credito", "Efectivo"})
        Me.cmb_Formapago.Location = New System.Drawing.Point(6, 80)
        Me.cmb_Formapago.Name = "cmb_Formapago"
        Me.cmb_Formapago.Size = New System.Drawing.Size(166, 25)
        Me.cmb_Formapago.TabIndex = 19
        '
        'txt_Totalapagar
        '
        Me.txt_Totalapagar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Totalapagar.Location = New System.Drawing.Point(579, 14)
        Me.txt_Totalapagar.Name = "txt_Totalapagar"
        Me.txt_Totalapagar.Size = New System.Drawing.Size(106, 23)
        Me.txt_Totalapagar.TabIndex = 18
        '
        'lbl_Totalapagar
        '
        Me.lbl_Totalapagar.AutoSize = True
        Me.lbl_Totalapagar.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Totalapagar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Totalapagar.Location = New System.Drawing.Point(448, 14)
        Me.lbl_Totalapagar.Name = "lbl_Totalapagar"
        Me.lbl_Totalapagar.Size = New System.Drawing.Size(125, 17)
        Me.lbl_Totalapagar.TabIndex = 17
        Me.lbl_Totalapagar.Text = "Total a Pagar Bs.F."
        '
        'btn_Volver
        '
        Me.btn_Volver.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Volver.CausesValidation = False
        Me.btn_Volver.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Volver.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Volver.Image = CType(resources.GetObject("btn_Volver.Image"), System.Drawing.Image)
        Me.btn_Volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Volver.Location = New System.Drawing.Point(434, 518)
        Me.btn_Volver.Name = "btn_Volver"
        Me.btn_Volver.Size = New System.Drawing.Size(105, 28)
        Me.btn_Volver.TabIndex = 34
        Me.btn_Volver.Text = "Volver"
        Me.btn_Volver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Volver.UseVisualStyleBackColor = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Cancelar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Cancelar.Image = CType(resources.GetObject("btn_Cancelar.Image"), System.Drawing.Image)
        Me.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cancelar.Location = New System.Drawing.Point(305, 518)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(105, 28)
        Me.btn_Cancelar.TabIndex = 33
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.UseVisualStyleBackColor = False
        '
        'btn_Procesarpago
        '
        Me.btn_Procesarpago.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Procesarpago.BackgroundImage = CType(resources.GetObject("btn_Procesarpago.BackgroundImage"), System.Drawing.Image)
        Me.btn_Procesarpago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_Procesarpago.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Procesarpago.Location = New System.Drawing.Point(149, 517)
        Me.btn_Procesarpago.Name = "btn_Procesarpago"
        Me.btn_Procesarpago.Size = New System.Drawing.Size(132, 29)
        Me.btn_Procesarpago.TabIndex = 32
        Me.btn_Procesarpago.Text = "Procesar Pago"
        Me.btn_Procesarpago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Procesarpago.UseVisualStyleBackColor = False
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fecha.Location = New System.Drawing.Point(554, 13)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Fecha.TabIndex = 131
        Me.lbl_Fecha.Text = "dd/MM/YY"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Usuario.Location = New System.Drawing.Point(625, 63)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Usuario.TabIndex = 130
        Me.lbl_Usuario.Text = "Usuario"
        '
        'lbl_EncabezadoSaludo
        '
        Me.lbl_EncabezadoSaludo.AutoSize = True
        Me.lbl_EncabezadoSaludo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoSaludo.Location = New System.Drawing.Point(584, 63)
        Me.lbl_EncabezadoSaludo.Name = "lbl_EncabezadoSaludo"
        Me.lbl_EncabezadoSaludo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_EncabezadoSaludo.TabIndex = 129
        Me.lbl_EncabezadoSaludo.Text = "Hola, "
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Hora.Location = New System.Drawing.Point(618, 13)
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
        Me.lbl_EncabezadoFormuladio.Location = New System.Drawing.Point(239, 99)
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
        Me.lbl_EncabezadoModulo.Location = New System.Drawing.Point(247, 55)
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
        Me.lbl_EncabezadoEmpresa.Location = New System.Drawing.Point(205, 10)
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
        Me.ptb_logo.Location = New System.Drawing.Point(0, 0)
        Me.ptb_logo.Name = "ptb_logo"
        Me.ptb_logo.Size = New System.Drawing.Size(132, 132)
        Me.ptb_logo.TabIndex = 124
        Me.ptb_logo.TabStop = False
        Me.ptb_logo.UseWaitCursor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(123, 72)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox1.TabIndex = 121
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(599, 89)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(86, 20)
        Me.TextBox2.TabIndex = 122
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(504, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Cuota vencida:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(599, 26)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(86, 20)
        Me.TextBox3.TabIndex = 124
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(493, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "Número de cuotas:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "N° Cuotas a pagar"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(149, 33)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(36, 20)
        Me.TextBox4.TabIndex = 112
        '
        'frm_Pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.SistemasIII.My.Resources.Resources.frm23
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(718, 550)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.lbl_EncabezadoSaludo)
        Me.Controls.Add(Me.lbl_Hora)
        Me.Controls.Add(Me.lbl_EncabezadoFormuladio)
        Me.Controls.Add(Me.lbl_EncabezadoModulo)
        Me.Controls.Add(Me.lbl_EncabezadoEmpresa)
        Me.Controls.Add(Me.ptb_logo)
        Me.Controls.Add(Me.grb_cuota)
        Me.Controls.Add(Me.btn_Volver)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_Procesarpago)
        Me.Name = "frm_Pago"
        Me.Text = "frm_Pago"
        Me.grb_cuota.ResumeLayout(False)
        Me.grb_cuota.PerformLayout()
        Me.grb_busqueda.ResumeLayout(False)
        Me.grb_busqueda.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_Pagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grb_cuota As GroupBox
    Friend WithEvents grb_busqueda As GroupBox
    Friend WithEvents lbl_Asegurado As Label
    Friend WithEvents cmb_CedulaA As ComboBox
    Friend WithEvents txt_CedulaA As TextBox
    Friend WithEvents lbl_Placa As Label
    Friend WithEvents btn_BuscarT As Button
    Friend WithEvents txt_Codigo As TextBox
    Friend WithEvents lbl_Codigo As Label
    Friend WithEvents cmb_NacionalidadT As ComboBox
    Friend WithEvents txt_CedulaT As TextBox
    Friend WithEvents lbl_CedulaT As Label
    Friend WithEvents lbl_CedulaA As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Volver As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_Cambio As TextBox
    Friend WithEvents lbl_Cambio As Label
    Friend WithEvents dgv_Pagos As DataGridView
    Friend WithEvents FormadePagoGrid As DataGridViewTextBoxColumn
    Friend WithEvents MontoCanceladoGrid As DataGridViewTextBoxColumn
    Friend WithEvents MontoFaltanteGrid As DataGridViewTextBoxColumn
    Friend WithEvents btn_Añadir As Button
    Friend WithEvents txt_Montoacancelar As TextBox
    Friend WithEvents lbl_Montoacancelar As Label
    Friend WithEvents lbl_Formapago As Label
    Friend WithEvents cmb_Formapago As ComboBox
    Friend WithEvents txt_Totalapagar As TextBox
    Friend WithEvents lbl_Totalapagar As Label
    Friend WithEvents btn_Procesarpago As Button
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents lbl_EncabezadoSaludo As Label
    Friend WithEvents lbl_Hora As Label
    Friend WithEvents lbl_EncabezadoFormuladio As Label
    Friend WithEvents lbl_EncabezadoModulo As Label
    Friend WithEvents lbl_EncabezadoEmpresa As Label
    Friend WithEvents ptb_logo As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
End Class
