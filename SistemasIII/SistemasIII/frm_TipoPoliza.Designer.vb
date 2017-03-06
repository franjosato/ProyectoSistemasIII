<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_TipoPoliza
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lbl_Codigo = New System.Windows.Forms.Label()
        Me.grb_Tipo_Poliza = New System.Windows.Forms.GroupBox()
        Me.txt_monto_base = New System.Windows.Forms.TextBox()
        Me.lbl_montoB = New System.Windows.Forms.Label()
        Me.cmb_nombre_tp = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.rtb_descripcion = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grb_Cobertura = New System.Windows.Forms.GroupBox()
        Me.ltb_Cobertura = New System.Windows.Forms.ListBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Volver = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoSaludo = New System.Windows.Forms.Label()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoFormuladio = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoModulo = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoEmpresa = New System.Windows.Forms.Label()
        Me.ptb_logo = New System.Windows.Forms.PictureBox()
        Me.tmr_Fecha = New System.Windows.Forms.Timer(Me.components)
        Me.grb_Tipo_Poliza.SuspendLayout()
        Me.grb_Cobertura.SuspendLayout()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Codigo
        '
        Me.lbl_Codigo.AutoSize = True
        Me.lbl_Codigo.Location = New System.Drawing.Point(37, 35)
        Me.lbl_Codigo.Name = "lbl_Codigo"
        Me.lbl_Codigo.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Codigo.TabIndex = 0
        Me.lbl_Codigo.Text = "Código:"
        '
        'grb_Tipo_Poliza
        '
        Me.grb_Tipo_Poliza.Controls.Add(Me.txt_monto_base)
        Me.grb_Tipo_Poliza.Controls.Add(Me.lbl_montoB)
        Me.grb_Tipo_Poliza.Controls.Add(Me.cmb_nombre_tp)
        Me.grb_Tipo_Poliza.Controls.Add(Me.Label3)
        Me.grb_Tipo_Poliza.Controls.Add(Me.txt_Nombre)
        Me.grb_Tipo_Poliza.Controls.Add(Me.rtb_descripcion)
        Me.grb_Tipo_Poliza.Controls.Add(Me.Label2)
        Me.grb_Tipo_Poliza.Controls.Add(Me.grb_Cobertura)
        Me.grb_Tipo_Poliza.Controls.Add(Me.btn_Buscar)
        Me.grb_Tipo_Poliza.Controls.Add(Me.txt_Codigo)
        Me.grb_Tipo_Poliza.Controls.Add(Me.lbl_Codigo)
        Me.grb_Tipo_Poliza.Location = New System.Drawing.Point(7, 167)
        Me.grb_Tipo_Poliza.Name = "grb_Tipo_Poliza"
        Me.grb_Tipo_Poliza.Size = New System.Drawing.Size(614, 222)
        Me.grb_Tipo_Poliza.TabIndex = 1
        Me.grb_Tipo_Poliza.TabStop = False
        Me.grb_Tipo_Poliza.Text = "Datos del tipo de póliza"
        '
        'txt_monto_base
        '
        Me.txt_monto_base.Location = New System.Drawing.Point(86, 191)
        Me.txt_monto_base.Name = "txt_monto_base"
        Me.txt_monto_base.Size = New System.Drawing.Size(100, 20)
        Me.txt_monto_base.TabIndex = 4
        '
        'lbl_montoB
        '
        Me.lbl_montoB.AutoSize = True
        Me.lbl_montoB.Location = New System.Drawing.Point(14, 194)
        Me.lbl_montoB.Name = "lbl_montoB"
        Me.lbl_montoB.Size = New System.Drawing.Size(66, 13)
        Me.lbl_montoB.TabIndex = 9
        Me.lbl_montoB.Text = "Monto base:"
        '
        'cmb_nombre_tp
        '
        Me.cmb_nombre_tp.FormattingEnabled = True
        Me.cmb_nombre_tp.Location = New System.Drawing.Point(86, 69)
        Me.cmb_nombre_tp.Name = "cmb_nombre_tp"
        Me.cmb_nombre_tp.Size = New System.Drawing.Size(181, 21)
        Me.cmb_nombre_tp.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Descripción:"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(86, 69)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(181, 20)
        Me.txt_Nombre.TabIndex = 6
        '
        'rtb_descripcion
        '
        Me.rtb_descripcion.Location = New System.Drawing.Point(86, 108)
        Me.rtb_descripcion.Name = "rtb_descripcion"
        Me.rtb_descripcion.Size = New System.Drawing.Size(181, 71)
        Me.rtb_descripcion.TabIndex = 3
        Me.rtb_descripcion.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre:"
        '
        'grb_Cobertura
        '
        Me.grb_Cobertura.Controls.Add(Me.ltb_Cobertura)
        Me.grb_Cobertura.Controls.Add(Me.CheckedListBox1)
        Me.grb_Cobertura.Controls.Add(Me.Label1)
        Me.grb_Cobertura.Location = New System.Drawing.Point(304, 17)
        Me.grb_Cobertura.Name = "grb_Cobertura"
        Me.grb_Cobertura.Size = New System.Drawing.Size(282, 194)
        Me.grb_Cobertura.TabIndex = 3
        Me.grb_Cobertura.TabStop = False
        Me.grb_Cobertura.Text = "Datos Cobertura"
        '
        'ltb_Cobertura
        '
        Me.ltb_Cobertura.FormattingEnabled = True
        Me.ltb_Cobertura.Location = New System.Drawing.Point(23, 41)
        Me.ltb_Cobertura.Name = "ltb_Cobertura"
        Me.ltb_Cobertura.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ltb_Cobertura.Size = New System.Drawing.Size(244, 134)
        Me.ltb_Cobertura.TabIndex = 6
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Enabled = False
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(23, 38)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(242, 139)
        Me.CheckedListBox1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione las coberturas asociadas:"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Location = New System.Drawing.Point(192, 30)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 6
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Enabled = False
        Me.txt_Codigo.Location = New System.Drawing.Point(86, 32)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_Codigo.TabIndex = 1
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Location = New System.Drawing.Point(280, 394)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 9
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Volver
        '
        Me.btn_Volver.Location = New System.Drawing.Point(469, 394)
        Me.btn_Volver.Name = "btn_Volver"
        Me.btn_Volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_Volver.TabIndex = 11
        Me.btn_Volver.Text = "Vovler"
        Me.btn_Volver.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(377, 394)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 10
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Location = New System.Drawing.Point(89, 394)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Agregar.TabIndex = 7
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Location = New System.Drawing.Point(182, 394)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Modificar.TabIndex = 8
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fecha.Location = New System.Drawing.Point(515, 9)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Fecha.TabIndex = 113
        Me.lbl_Fecha.Text = "dd/MM/YY"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Usuario.Location = New System.Drawing.Point(575, 60)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Usuario.TabIndex = 112
        Me.lbl_Usuario.Text = "Usuario"
        '
        'lbl_EncabezadoSaludo
        '
        Me.lbl_EncabezadoSaludo.AutoSize = True
        Me.lbl_EncabezadoSaludo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoSaludo.Location = New System.Drawing.Point(534, 60)
        Me.lbl_EncabezadoSaludo.Name = "lbl_EncabezadoSaludo"
        Me.lbl_EncabezadoSaludo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_EncabezadoSaludo.TabIndex = 111
        Me.lbl_EncabezadoSaludo.Text = "Hola, "
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Hora.Location = New System.Drawing.Point(579, 9)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Hora.TabIndex = 110
        Me.lbl_Hora.Text = "00:00:00"
        '
        'lbl_EncabezadoFormuladio
        '
        Me.lbl_EncabezadoFormuladio.AutoSize = True
        Me.lbl_EncabezadoFormuladio.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoFormuladio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoFormuladio.Location = New System.Drawing.Point(194, 94)
        Me.lbl_EncabezadoFormuladio.Name = "lbl_EncabezadoFormuladio"
        Me.lbl_EncabezadoFormuladio.Size = New System.Drawing.Size(237, 25)
        Me.lbl_EncabezadoFormuladio.TabIndex = 109
        Me.lbl_EncabezadoFormuladio.Text = "Datos del tipo de póliza"
        '
        'lbl_EncabezadoModulo
        '
        Me.lbl_EncabezadoModulo.AutoSize = True
        Me.lbl_EncabezadoModulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoModulo.Location = New System.Drawing.Point(219, 54)
        Me.lbl_EncabezadoModulo.Name = "lbl_EncabezadoModulo"
        Me.lbl_EncabezadoModulo.Size = New System.Drawing.Size(196, 25)
        Me.lbl_EncabezadoModulo.TabIndex = 108
        Me.lbl_EncabezadoModulo.Text = "Módulo de Servicio"
        '
        'lbl_EncabezadoEmpresa
        '
        Me.lbl_EncabezadoEmpresa.AutoSize = True
        Me.lbl_EncabezadoEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoEmpresa.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_EncabezadoEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EncabezadoEmpresa.Location = New System.Drawing.Point(177, 9)
        Me.lbl_EncabezadoEmpresa.Name = "lbl_EncabezadoEmpresa"
        Me.lbl_EncabezadoEmpresa.Size = New System.Drawing.Size(291, 29)
        Me.lbl_EncabezadoEmpresa.TabIndex = 107
        Me.lbl_EncabezadoEmpresa.Text = "SEGUROS MALDONADO"
        '
        'ptb_logo
        '
        Me.ptb_logo.BackColor = System.Drawing.Color.Transparent
        Me.ptb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptb_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptb_logo.Image = Global.SistemasIII.My.Resources.Resources.fondot
        Me.ptb_logo.Location = New System.Drawing.Point(1, -17)
        Me.ptb_logo.Name = "ptb_logo"
        Me.ptb_logo.Size = New System.Drawing.Size(162, 156)
        Me.ptb_logo.TabIndex = 106
        Me.ptb_logo.TabStop = False
        Me.ptb_logo.UseWaitCursor = True
        '
        'tmr_Fecha
        '
        '
        'frm_TipoPoliza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.SistemasIII.My.Resources.Resources.frm23
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(633, 428)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.btn_Volver)
        Me.Controls.Add(Me.lbl_EncabezadoSaludo)
        Me.Controls.Add(Me.grb_Tipo_Poliza)
        Me.Controls.Add(Me.lbl_Hora)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.lbl_EncabezadoFormuladio)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.lbl_EncabezadoModulo)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.lbl_EncabezadoEmpresa)
        Me.Controls.Add(Me.ptb_logo)
        Me.Name = "frm_TipoPoliza"
        Me.Text = "Form2"
        Me.grb_Tipo_Poliza.ResumeLayout(False)
        Me.grb_Tipo_Poliza.PerformLayout()
        Me.grb_Cobertura.ResumeLayout(False)
        Me.grb_Cobertura.PerformLayout()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Codigo As Label
    Friend WithEvents grb_Tipo_Poliza As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents rtb_descripcion As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents grb_Cobertura As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents txt_Codigo As TextBox
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btn_Volver As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents btn_Modificar As Button
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents lbl_EncabezadoSaludo As Label
    Friend WithEvents lbl_Hora As Label
    Friend WithEvents lbl_EncabezadoFormuladio As Label
    Friend WithEvents lbl_EncabezadoModulo As Label
    Friend WithEvents lbl_EncabezadoEmpresa As Label
    Friend WithEvents ptb_logo As PictureBox
    Friend WithEvents tmr_Fecha As Timer
    Friend WithEvents cmb_nombre_tp As ComboBox
    Friend WithEvents txt_monto_base As TextBox
    Friend WithEvents lbl_montoB As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents ltb_Cobertura As ListBox
End Class
