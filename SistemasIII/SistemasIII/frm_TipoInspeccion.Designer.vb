<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TipoInspeccion
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
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.grb_TipoInspeccion = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.lbl_Codigo = New System.Windows.Forms.Label()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoSaludo = New System.Windows.Forms.Label()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoFormuladio = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoModulo = New System.Windows.Forms.Label()
        Me.lbl_EncabezadoEmpresa = New System.Windows.Forms.Label()
        Me.ptb_logo = New System.Windows.Forms.PictureBox()
        Me.grb_TipoInspeccion.SuspendLayout()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Volver
        '
        Me.btn_Volver.Location = New System.Drawing.Point(481, 388)
        Me.btn_Volver.Name = "btn_Volver"
        Me.btn_Volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_Volver.TabIndex = 10
        Me.btn_Volver.Text = "Vovler"
        Me.btn_Volver.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(389, 388)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 9
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Location = New System.Drawing.Point(194, 388)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Modificar.TabIndex = 8
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Location = New System.Drawing.Point(101, 388)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Agregar.TabIndex = 7
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'grb_TipoInspeccion
        '
        Me.grb_TipoInspeccion.Controls.Add(Me.Label3)
        Me.grb_TipoInspeccion.Controls.Add(Me.txt_Nombre)
        Me.grb_TipoInspeccion.Controls.Add(Me.RichTextBox1)
        Me.grb_TipoInspeccion.Controls.Add(Me.Label2)
        Me.grb_TipoInspeccion.Controls.Add(Me.btn_Buscar)
        Me.grb_TipoInspeccion.Controls.Add(Me.txt_Codigo)
        Me.grb_TipoInspeccion.Controls.Add(Me.lbl_Codigo)
        Me.grb_TipoInspeccion.Location = New System.Drawing.Point(171, 160)
        Me.grb_TipoInspeccion.Name = "grb_TipoInspeccion"
        Me.grb_TipoInspeccion.Size = New System.Drawing.Size(286, 219)
        Me.grb_TipoInspeccion.TabIndex = 6
        Me.grb_TipoInspeccion.TabStop = False
        Me.grb_TipoInspeccion.Text = "Datos del tipo de inspección"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Descripción:"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(79, 60)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(181, 20)
        Me.txt_Nombre.TabIndex = 6
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(79, 96)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(181, 96)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre:"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Location = New System.Drawing.Point(185, 21)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Enabled = False
        Me.txt_Codigo.Location = New System.Drawing.Point(79, 23)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_Codigo.TabIndex = 1
        '
        'lbl_Codigo
        '
        Me.lbl_Codigo.AutoSize = True
        Me.lbl_Codigo.Location = New System.Drawing.Point(30, 26)
        Me.lbl_Codigo.Name = "lbl_Codigo"
        Me.lbl_Codigo.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Codigo.TabIndex = 0
        Me.lbl_Codigo.Text = "Código:"
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Location = New System.Drawing.Point(292, 388)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 11
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fecha.Location = New System.Drawing.Point(506, 12)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Fecha.TabIndex = 131
        Me.lbl_Fecha.Text = "dd/MM/YY"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Usuario.Location = New System.Drawing.Point(577, 62)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Usuario.TabIndex = 130
        Me.lbl_Usuario.Text = "Usuario"
        '
        'lbl_EncabezadoSaludo
        '
        Me.lbl_EncabezadoSaludo.AutoSize = True
        Me.lbl_EncabezadoSaludo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EncabezadoSaludo.Location = New System.Drawing.Point(536, 62)
        Me.lbl_EncabezadoSaludo.Name = "lbl_EncabezadoSaludo"
        Me.lbl_EncabezadoSaludo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_EncabezadoSaludo.TabIndex = 129
        Me.lbl_EncabezadoSaludo.Text = "Hola, "
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Hora.Location = New System.Drawing.Point(570, 12)
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
        Me.lbl_EncabezadoFormuladio.Location = New System.Drawing.Point(209, 94)
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
        Me.lbl_EncabezadoModulo.Location = New System.Drawing.Point(217, 50)
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
        Me.lbl_EncabezadoEmpresa.Location = New System.Drawing.Point(175, 5)
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
        Me.ptb_logo.Location = New System.Drawing.Point(0, 2)
        Me.ptb_logo.Name = "ptb_logo"
        Me.ptb_logo.Size = New System.Drawing.Size(132, 132)
        Me.ptb_logo.TabIndex = 124
        Me.ptb_logo.TabStop = False
        Me.ptb_logo.UseWaitCursor = True
        '
        'frm_TipoInspeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.SistemasIII.My.Resources.Resources.frm23
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(637, 423)
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
        Me.Controls.Add(Me.grb_TipoInspeccion)
        Me.Name = "frm_TipoInspeccion"
        Me.Text = "Form1"
        Me.grb_TipoInspeccion.ResumeLayout(False)
        Me.grb_TipoInspeccion.PerformLayout()
        CType(Me.ptb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Volver As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Modificar As Button
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents grb_TipoInspeccion As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents txt_Codigo As TextBox
    Friend WithEvents lbl_Codigo As Label
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents lbl_EncabezadoSaludo As Label
    Friend WithEvents lbl_Hora As Label
    Friend WithEvents lbl_EncabezadoFormuladio As Label
    Friend WithEvents lbl_EncabezadoModulo As Label
    Friend WithEvents lbl_EncabezadoEmpresa As Label
    Friend WithEvents ptb_logo As PictureBox
End Class
