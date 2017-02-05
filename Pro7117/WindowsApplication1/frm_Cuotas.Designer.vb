<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpago
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpago))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grb_DTomador = New System.Windows.Forms.GroupBox()
        Me.txt_Apellido = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.btn_BuscarCedula = New System.Windows.Forms.Button()
        Me.txt_Cedula = New System.Windows.Forms.TextBox()
        Me.lbl_Apellido = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_Cedula = New System.Windows.Forms.Label()
        Me.grb_DCuotas = New System.Windows.Forms.GroupBox()
        Me.grb_DDeuda = New System.Windows.Forms.GroupBox()
        Me.txt_MontoTxPagar = New System.Windows.Forms.TextBox()
        Me.txt_CuotasxPagar = New System.Windows.Forms.TextBox()
        Me.lbl_FechaUPago = New System.Windows.Forms.Label()
        Me.dtp_FechaUpago = New System.Windows.Forms.DateTimePicker()
        Me.lbl_MontoTxPagar = New System.Windows.Forms.Label()
        Me.lbl_CuotasxPagar = New System.Windows.Forms.Label()
        Me.grb_DCobro = New System.Windows.Forms.GroupBox()
        Me.txt_MontoTCobrado = New System.Windows.Forms.TextBox()
        Me.txt_NCuotasCobradas = New System.Windows.Forms.TextBox()
        Me.lbl_MontoTCobrado = New System.Windows.Forms.Label()
        Me.lbl_CuotasCobradas = New System.Windows.Forms.Label()
        Me.lbl_Fechacobro = New System.Windows.Forms.Label()
        Me.dtp_Fechacobro = New System.Windows.Forms.DateTimePicker()
        Me.txt_MontoxCuota = New System.Windows.Forms.TextBox()
        Me.txt_NCuotas = New System.Windows.Forms.TextBox()
        Me.lbl_MontoxCuota = New System.Windows.Forms.Label()
        Me.lbl_NCuotas = New System.Windows.Forms.Label()
        Me.lbl_CodPoliza = New System.Windows.Forms.Label()
        Me.btn_BuscarCP = New System.Windows.Forms.Button()
        Me.cmb_CodPoliza = New System.Windows.Forms.ComboBox()
        Me.btn_Añadir = New System.Windows.Forms.Button()
        Me.dgv_Listapagos = New System.Windows.Forms.DataGridView()
        Me.grb_Pagos = New System.Windows.Forms.GroupBox()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.grb_DTomador.SuspendLayout()
        Me.grb_DCuotas.SuspendLayout()
        Me.grb_DDeuda.SuspendLayout()
        Me.grb_DCobro.SuspendLayout()
        CType(Me.dgv_Listapagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_Pagos.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(493, 99)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(72, 20)
        Me.TextBox1.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(469, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "uSUARIOACTUAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(527, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "HORA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(238, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Gestión de usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(203, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Mantenimiento del sistema"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(193, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SEGUROS MALDONADO"
        '
        'grb_DTomador
        '
        Me.grb_DTomador.Controls.Add(Me.txt_Apellido)
        Me.grb_DTomador.Controls.Add(Me.txt_Nombre)
        Me.grb_DTomador.Controls.Add(Me.btn_BuscarCedula)
        Me.grb_DTomador.Controls.Add(Me.txt_Cedula)
        Me.grb_DTomador.Controls.Add(Me.lbl_Apellido)
        Me.grb_DTomador.Controls.Add(Me.lbl_Nombre)
        Me.grb_DTomador.Controls.Add(Me.lbl_Cedula)
        Me.grb_DTomador.Location = New System.Drawing.Point(12, 223)
        Me.grb_DTomador.Name = "grb_DTomador"
        Me.grb_DTomador.Size = New System.Drawing.Size(670, 70)
        Me.grb_DTomador.TabIndex = 13
        Me.grb_DTomador.TabStop = False
        Me.grb_DTomador.Text = "Datos Tomador"
        '
        'txt_Apellido
        '
        Me.txt_Apellido.Location = New System.Drawing.Point(443, 38)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.Size = New System.Drawing.Size(172, 20)
        Me.txt_Apellido.TabIndex = 6
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(234, 38)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(172, 20)
        Me.txt_Nombre.TabIndex = 5
        '
        'btn_BuscarCedula
        '
        Me.btn_BuscarCedula.Location = New System.Drawing.Point(124, 36)
        Me.btn_BuscarCedula.Name = "btn_BuscarCedula"
        Me.btn_BuscarCedula.Size = New System.Drawing.Size(75, 23)
        Me.btn_BuscarCedula.TabIndex = 4
        Me.btn_BuscarCedula.Text = "Buscar"
        Me.btn_BuscarCedula.UseVisualStyleBackColor = True
        '
        'txt_Cedula
        '
        Me.txt_Cedula.Location = New System.Drawing.Point(18, 38)
        Me.txt_Cedula.Name = "txt_Cedula"
        Me.txt_Cedula.Size = New System.Drawing.Size(100, 20)
        Me.txt_Cedula.TabIndex = 3
        '
        'lbl_Apellido
        '
        Me.lbl_Apellido.AutoSize = True
        Me.lbl_Apellido.Location = New System.Drawing.Point(568, 22)
        Me.lbl_Apellido.Name = "lbl_Apellido"
        Me.lbl_Apellido.Size = New System.Drawing.Size(47, 13)
        Me.lbl_Apellido.TabIndex = 2
        Me.lbl_Apellido.Text = "Apellido:"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(359, 23)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_Nombre.TabIndex = 1
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'lbl_Cedula
        '
        Me.lbl_Cedula.AutoSize = True
        Me.lbl_Cedula.Location = New System.Drawing.Point(75, 22)
        Me.lbl_Cedula.Name = "lbl_Cedula"
        Me.lbl_Cedula.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Cedula.TabIndex = 0
        Me.lbl_Cedula.Text = "Cédula:"
        '
        'grb_DCuotas
        '
        Me.grb_DCuotas.Controls.Add(Me.grb_DDeuda)
        Me.grb_DCuotas.Controls.Add(Me.grb_DCobro)
        Me.grb_DCuotas.Controls.Add(Me.txt_MontoxCuota)
        Me.grb_DCuotas.Controls.Add(Me.txt_NCuotas)
        Me.grb_DCuotas.Controls.Add(Me.lbl_MontoxCuota)
        Me.grb_DCuotas.Controls.Add(Me.lbl_NCuotas)
        Me.grb_DCuotas.Controls.Add(Me.lbl_CodPoliza)
        Me.grb_DCuotas.Controls.Add(Me.btn_BuscarCP)
        Me.grb_DCuotas.Controls.Add(Me.cmb_CodPoliza)
        Me.grb_DCuotas.Location = New System.Drawing.Point(13, 299)
        Me.grb_DCuotas.Name = "grb_DCuotas"
        Me.grb_DCuotas.Size = New System.Drawing.Size(669, 233)
        Me.grb_DCuotas.TabIndex = 14
        Me.grb_DCuotas.TabStop = False
        Me.grb_DCuotas.Text = "Datos de cuotas"
        '
        'grb_DDeuda
        '
        Me.grb_DDeuda.Controls.Add(Me.txt_MontoTxPagar)
        Me.grb_DDeuda.Controls.Add(Me.txt_CuotasxPagar)
        Me.grb_DDeuda.Controls.Add(Me.lbl_FechaUPago)
        Me.grb_DDeuda.Controls.Add(Me.dtp_FechaUpago)
        Me.grb_DDeuda.Controls.Add(Me.lbl_MontoTxPagar)
        Me.grb_DDeuda.Controls.Add(Me.lbl_CuotasxPagar)
        Me.grb_DDeuda.Location = New System.Drawing.Point(11, 142)
        Me.grb_DDeuda.Name = "grb_DDeuda"
        Me.grb_DDeuda.Size = New System.Drawing.Size(648, 81)
        Me.grb_DDeuda.TabIndex = 28
        Me.grb_DDeuda.TabStop = False
        Me.grb_DDeuda.Text = "Datos de pagos"
        '
        'txt_MontoTxPagar
        '
        Me.txt_MontoTxPagar.Location = New System.Drawing.Point(550, 39)
        Me.txt_MontoTxPagar.Name = "txt_MontoTxPagar"
        Me.txt_MontoTxPagar.Size = New System.Drawing.Size(90, 20)
        Me.txt_MontoTxPagar.TabIndex = 20
        '
        'txt_CuotasxPagar
        '
        Me.txt_CuotasxPagar.Location = New System.Drawing.Point(380, 39)
        Me.txt_CuotasxPagar.Name = "txt_CuotasxPagar"
        Me.txt_CuotasxPagar.Size = New System.Drawing.Size(41, 20)
        Me.txt_CuotasxPagar.TabIndex = 19
        '
        'lbl_FechaUPago
        '
        Me.lbl_FechaUPago.AutoSize = True
        Me.lbl_FechaUPago.Location = New System.Drawing.Point(3, 23)
        Me.lbl_FechaUPago.Name = "lbl_FechaUPago"
        Me.lbl_FechaUPago.Size = New System.Drawing.Size(114, 13)
        Me.lbl_FechaUPago.TabIndex = 26
        Me.lbl_FechaUPago.Text = "Fecha del ultimo pago:"
        '
        'dtp_FechaUpago
        '
        Me.dtp_FechaUpago.Location = New System.Drawing.Point(6, 39)
        Me.dtp_FechaUpago.Name = "dtp_FechaUpago"
        Me.dtp_FechaUpago.Size = New System.Drawing.Size(200, 20)
        Me.dtp_FechaUpago.TabIndex = 25
        '
        'lbl_MontoTxPagar
        '
        Me.lbl_MontoTxPagar.AutoSize = True
        Me.lbl_MontoTxPagar.Location = New System.Drawing.Point(430, 39)
        Me.lbl_MontoTxPagar.Name = "lbl_MontoTxPagar"
        Me.lbl_MontoTxPagar.Size = New System.Drawing.Size(111, 13)
        Me.lbl_MontoTxPagar.TabIndex = 18
        Me.lbl_MontoTxPagar.Text = "Monto total por pagar:"
        '
        'lbl_CuotasxPagar
        '
        Me.lbl_CuotasxPagar.AutoSize = True
        Me.lbl_CuotasxPagar.Location = New System.Drawing.Point(226, 39)
        Me.lbl_CuotasxPagar.Name = "lbl_CuotasxPagar"
        Me.lbl_CuotasxPagar.Size = New System.Drawing.Size(145, 13)
        Me.lbl_CuotasxPagar.TabIndex = 17
        Me.lbl_CuotasxPagar.Text = "Número de cuotas por pagar:"
        '
        'grb_DCobro
        '
        Me.grb_DCobro.Controls.Add(Me.txt_MontoTCobrado)
        Me.grb_DCobro.Controls.Add(Me.txt_NCuotasCobradas)
        Me.grb_DCobro.Controls.Add(Me.lbl_MontoTCobrado)
        Me.grb_DCobro.Controls.Add(Me.lbl_CuotasCobradas)
        Me.grb_DCobro.Controls.Add(Me.lbl_Fechacobro)
        Me.grb_DCobro.Controls.Add(Me.dtp_Fechacobro)
        Me.grb_DCobro.Location = New System.Drawing.Point(11, 69)
        Me.grb_DCobro.Name = "grb_DCobro"
        Me.grb_DCobro.Size = New System.Drawing.Size(648, 73)
        Me.grb_DCobro.TabIndex = 27
        Me.grb_DCobro.TabStop = False
        Me.grb_DCobro.Text = "Datos de cobro"
        '
        'txt_MontoTCobrado
        '
        Me.txt_MontoTCobrado.Location = New System.Drawing.Point(540, 38)
        Me.txt_MontoTCobrado.Name = "txt_MontoTCobrado"
        Me.txt_MontoTCobrado.Size = New System.Drawing.Size(100, 20)
        Me.txt_MontoTCobrado.TabIndex = 24
        '
        'txt_NCuotasCobradas
        '
        Me.txt_NCuotasCobradas.Location = New System.Drawing.Point(380, 35)
        Me.txt_NCuotasCobradas.Name = "txt_NCuotasCobradas"
        Me.txt_NCuotasCobradas.Size = New System.Drawing.Size(41, 20)
        Me.txt_NCuotasCobradas.TabIndex = 23
        '
        'lbl_MontoTCobrado
        '
        Me.lbl_MontoTCobrado.AutoSize = True
        Me.lbl_MontoTCobrado.Location = New System.Drawing.Point(430, 35)
        Me.lbl_MontoTCobrado.Name = "lbl_MontoTCobrado"
        Me.lbl_MontoTCobrado.Size = New System.Drawing.Size(105, 13)
        Me.lbl_MontoTCobrado.TabIndex = 22
        Me.lbl_MontoTCobrado.Text = "Monto total cobrado:"
        '
        'lbl_CuotasCobradas
        '
        Me.lbl_CuotasCobradas.AutoSize = True
        Me.lbl_CuotasCobradas.Location = New System.Drawing.Point(230, 35)
        Me.lbl_CuotasCobradas.Name = "lbl_CuotasCobradas"
        Me.lbl_CuotasCobradas.Size = New System.Drawing.Size(144, 13)
        Me.lbl_CuotasCobradas.TabIndex = 21
        Me.lbl_CuotasCobradas.Text = "Número de cuotas cobradas:"
        '
        'lbl_Fechacobro
        '
        Me.lbl_Fechacobro.AutoSize = True
        Me.lbl_Fechacobro.Location = New System.Drawing.Point(3, 19)
        Me.lbl_Fechacobro.Name = "lbl_Fechacobro"
        Me.lbl_Fechacobro.Size = New System.Drawing.Size(85, 13)
        Me.lbl_Fechacobro.TabIndex = 11
        Me.lbl_Fechacobro.Text = "Fecha de cobro:"
        '
        'dtp_Fechacobro
        '
        Me.dtp_Fechacobro.Location = New System.Drawing.Point(6, 35)
        Me.dtp_Fechacobro.Name = "dtp_Fechacobro"
        Me.dtp_Fechacobro.Size = New System.Drawing.Size(200, 20)
        Me.dtp_Fechacobro.TabIndex = 9
        '
        'txt_MontoxCuota
        '
        Me.txt_MontoxCuota.Location = New System.Drawing.Point(538, 35)
        Me.txt_MontoxCuota.Name = "txt_MontoxCuota"
        Me.txt_MontoxCuota.Size = New System.Drawing.Size(100, 20)
        Me.txt_MontoxCuota.TabIndex = 16
        '
        'txt_NCuotas
        '
        Me.txt_NCuotas.Location = New System.Drawing.Point(340, 34)
        Me.txt_NCuotas.Name = "txt_NCuotas"
        Me.txt_NCuotas.Size = New System.Drawing.Size(41, 20)
        Me.txt_NCuotas.TabIndex = 15
        '
        'lbl_MontoxCuota
        '
        Me.lbl_MontoxCuota.AutoSize = True
        Me.lbl_MontoxCuota.Location = New System.Drawing.Point(403, 34)
        Me.lbl_MontoxCuota.Name = "lbl_MontoxCuota"
        Me.lbl_MontoxCuota.Size = New System.Drawing.Size(130, 13)
        Me.lbl_MontoxCuota.TabIndex = 14
        Me.lbl_MontoxCuota.Text = "Monto a cobrar por cuota:"
        '
        'lbl_NCuotas
        '
        Me.lbl_NCuotas.AutoSize = True
        Me.lbl_NCuotas.Location = New System.Drawing.Point(237, 34)
        Me.lbl_NCuotas.Name = "lbl_NCuotas"
        Me.lbl_NCuotas.Size = New System.Drawing.Size(97, 13)
        Me.lbl_NCuotas.TabIndex = 13
        Me.lbl_NCuotas.Text = "Número de cuotas:"
        '
        'lbl_CodPoliza
        '
        Me.lbl_CodPoliza.AutoSize = True
        Me.lbl_CodPoliza.Location = New System.Drawing.Point(18, 19)
        Me.lbl_CodPoliza.Name = "lbl_CodPoliza"
        Me.lbl_CodPoliza.Size = New System.Drawing.Size(99, 13)
        Me.lbl_CodPoliza.TabIndex = 8
        Me.lbl_CodPoliza.Text = "Código de la poliza:"
        '
        'btn_BuscarCP
        '
        Me.btn_BuscarCP.Location = New System.Drawing.Point(123, 34)
        Me.btn_BuscarCP.Name = "btn_BuscarCP"
        Me.btn_BuscarCP.Size = New System.Drawing.Size(75, 23)
        Me.btn_BuscarCP.TabIndex = 7
        Me.btn_BuscarCP.Text = "Buscar"
        Me.btn_BuscarCP.UseVisualStyleBackColor = True
        '
        'cmb_CodPoliza
        '
        Me.cmb_CodPoliza.FormattingEnabled = True
        Me.cmb_CodPoliza.Location = New System.Drawing.Point(17, 35)
        Me.cmb_CodPoliza.Name = "cmb_CodPoliza"
        Me.cmb_CodPoliza.Size = New System.Drawing.Size(100, 21)
        Me.cmb_CodPoliza.TabIndex = 0
        '
        'btn_Añadir
        '
        Me.btn_Añadir.Location = New System.Drawing.Point(588, 22)
        Me.btn_Añadir.Name = "btn_Añadir"
        Me.btn_Añadir.Size = New System.Drawing.Size(75, 23)
        Me.btn_Añadir.TabIndex = 29
        Me.btn_Añadir.Text = "Añadir"
        Me.btn_Añadir.UseVisualStyleBackColor = True
        '
        'dgv_Listapagos
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Listapagos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Listapagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Listapagos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Listapagos.Location = New System.Drawing.Point(12, 22)
        Me.dgv_Listapagos.Name = "dgv_Listapagos"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Listapagos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Listapagos.Size = New System.Drawing.Size(573, 127)
        Me.dgv_Listapagos.TabIndex = 30
        '
        'grb_Pagos
        '
        Me.grb_Pagos.Controls.Add(Me.btn_Añadir)
        Me.grb_Pagos.Controls.Add(Me.dgv_Listapagos)
        Me.grb_Pagos.Location = New System.Drawing.Point(12, 538)
        Me.grb_Pagos.Name = "grb_Pagos"
        Me.grb_Pagos.Size = New System.Drawing.Size(669, 155)
        Me.grb_Pagos.TabIndex = 31
        Me.grb_Pagos.TabStop = False
        Me.grb_Pagos.Text = "Lista de pagos"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(268, 699)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 33
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Salir
        '
        Me.btn_Salir.Location = New System.Drawing.Point(356, 699)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_Salir.TabIndex = 34
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.UseVisualStyleBackColor = True
        '
        'frmpago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(692, 733)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.grb_Pagos)
        Me.Controls.Add(Me.grb_DCuotas)
        Me.Controls.Add(Me.grb_DTomador)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmpago"
        Me.Text = "Form3"
        Me.grb_DTomador.ResumeLayout(False)
        Me.grb_DTomador.PerformLayout()
        Me.grb_DCuotas.ResumeLayout(False)
        Me.grb_DCuotas.PerformLayout()
        Me.grb_DDeuda.ResumeLayout(False)
        Me.grb_DDeuda.PerformLayout()
        Me.grb_DCobro.ResumeLayout(False)
        Me.grb_DCobro.PerformLayout()
        CType(Me.dgv_Listapagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_Pagos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grb_DTomador As GroupBox
    Friend WithEvents lbl_Nombre As Label
    Friend WithEvents lbl_Cedula As Label
    Friend WithEvents txt_Apellido As TextBox
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents btn_BuscarCedula As Button
    Friend WithEvents txt_Cedula As TextBox
    Friend WithEvents lbl_Apellido As Label
    Friend WithEvents grb_DCuotas As GroupBox
    Friend WithEvents grb_DDeuda As GroupBox
    Friend WithEvents txt_MontoTxPagar As TextBox
    Friend WithEvents txt_CuotasxPagar As TextBox
    Friend WithEvents lbl_FechaUPago As Label
    Friend WithEvents dtp_FechaUpago As DateTimePicker
    Friend WithEvents lbl_MontoTxPagar As Label
    Friend WithEvents lbl_CuotasxPagar As Label
    Friend WithEvents grb_DCobro As GroupBox
    Friend WithEvents txt_MontoTCobrado As TextBox
    Friend WithEvents txt_NCuotasCobradas As TextBox
    Friend WithEvents lbl_MontoTCobrado As Label
    Friend WithEvents lbl_CuotasCobradas As Label
    Friend WithEvents lbl_Fechacobro As Label
    Friend WithEvents dtp_Fechacobro As DateTimePicker
    Friend WithEvents txt_MontoxCuota As TextBox
    Friend WithEvents txt_NCuotas As TextBox
    Friend WithEvents lbl_MontoxCuota As Label
    Friend WithEvents lbl_NCuotas As Label
    Friend WithEvents lbl_CodPoliza As Label
    Friend WithEvents btn_BuscarCP As Button
    Friend WithEvents cmb_CodPoliza As ComboBox
    Friend WithEvents btn_Añadir As Button
    Friend WithEvents dgv_Listapagos As DataGridView
    Friend WithEvents grb_Pagos As GroupBox
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Salir As Button
End Class
