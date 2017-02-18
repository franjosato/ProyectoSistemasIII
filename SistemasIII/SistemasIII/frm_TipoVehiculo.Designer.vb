<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TipoVehiculo
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
        Me.grb_Datos = New System.Windows.Forms.GroupBox()
        Me.lbl_Codigo = New System.Windows.Forms.Label()
        Me.lbl_CapacidadPasajeros = New System.Windows.Forms.Label()
        Me.lbl_CapacidadCarga = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_CantidadRuedas = New System.Windows.Forms.Label()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.txt_CapacidadPasajeros = New System.Windows.Forms.TextBox()
        Me.txt_CapacidadCarga = New System.Windows.Forms.TextBox()
        Me.txt_CantidadRuedas = New System.Windows.Forms.TextBox()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Volver = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.grb_Datos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_Datos
        '
        Me.grb_Datos.Controls.Add(Me.btn_Buscar)
        Me.grb_Datos.Controls.Add(Me.txt_CantidadRuedas)
        Me.grb_Datos.Controls.Add(Me.txt_CapacidadCarga)
        Me.grb_Datos.Controls.Add(Me.txt_CapacidadPasajeros)
        Me.grb_Datos.Controls.Add(Me.txt_Nombre)
        Me.grb_Datos.Controls.Add(Me.txt_Codigo)
        Me.grb_Datos.Controls.Add(Me.lbl_CantidadRuedas)
        Me.grb_Datos.Controls.Add(Me.lbl_Nombre)
        Me.grb_Datos.Controls.Add(Me.lbl_CapacidadCarga)
        Me.grb_Datos.Controls.Add(Me.lbl_CapacidadPasajeros)
        Me.grb_Datos.Controls.Add(Me.lbl_Codigo)
        Me.grb_Datos.Location = New System.Drawing.Point(12, 162)
        Me.grb_Datos.Name = "grb_Datos"
        Me.grb_Datos.Size = New System.Drawing.Size(689, 126)
        Me.grb_Datos.TabIndex = 0
        Me.grb_Datos.TabStop = False
        '
        'lbl_Codigo
        '
        Me.lbl_Codigo.AutoSize = True
        Me.lbl_Codigo.Location = New System.Drawing.Point(76, 22)
        Me.lbl_Codigo.Name = "lbl_Codigo"
        Me.lbl_Codigo.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Codigo.TabIndex = 0
        Me.lbl_Codigo.Text = "Código:"
        '
        'lbl_CapacidadPasajeros
        '
        Me.lbl_CapacidadPasajeros.AutoSize = True
        Me.lbl_CapacidadPasajeros.Location = New System.Drawing.Point(235, 59)
        Me.lbl_CapacidadPasajeros.Name = "lbl_CapacidadPasajeros"
        Me.lbl_CapacidadPasajeros.Size = New System.Drawing.Size(124, 13)
        Me.lbl_CapacidadPasajeros.TabIndex = 1
        Me.lbl_CapacidadPasajeros.Text = "Capacidad de pasajeros:"
        '
        'lbl_CapacidadCarga
        '
        Me.lbl_CapacidadCarga.AutoSize = True
        Me.lbl_CapacidadCarga.Location = New System.Drawing.Point(471, 59)
        Me.lbl_CapacidadCarga.Name = "lbl_CapacidadCarga"
        Me.lbl_CapacidadCarga.Size = New System.Drawing.Size(106, 13)
        Me.lbl_CapacidadCarga.TabIndex = 2
        Me.lbl_CapacidadCarga.Text = "Capacidad de carga:"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(72, 59)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_Nombre.TabIndex = 3
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'lbl_CantidadRuedas
        '
        Me.lbl_CantidadRuedas.AutoSize = True
        Me.lbl_CantidadRuedas.Location = New System.Drawing.Point(7, 96)
        Me.lbl_CantidadRuedas.Name = "lbl_CantidadRuedas"
        Me.lbl_CantidadRuedas.Size = New System.Drawing.Size(102, 13)
        Me.lbl_CantidadRuedas.TabIndex = 4
        Me.lbl_CantidadRuedas.Text = "Cantidad de ruedas:"
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Location = New System.Drawing.Point(125, 19)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_Codigo.TabIndex = 5
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(125, 56)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_Nombre.TabIndex = 6
        '
        'txt_CapacidadPasajeros
        '
        Me.txt_CapacidadPasajeros.Location = New System.Drawing.Point(365, 56)
        Me.txt_CapacidadPasajeros.Name = "txt_CapacidadPasajeros"
        Me.txt_CapacidadPasajeros.Size = New System.Drawing.Size(100, 20)
        Me.txt_CapacidadPasajeros.TabIndex = 7
        '
        'txt_CapacidadCarga
        '
        Me.txt_CapacidadCarga.Location = New System.Drawing.Point(583, 56)
        Me.txt_CapacidadCarga.Name = "txt_CapacidadCarga"
        Me.txt_CapacidadCarga.Size = New System.Drawing.Size(100, 20)
        Me.txt_CapacidadCarga.TabIndex = 8
        '
        'txt_CantidadRuedas
        '
        Me.txt_CantidadRuedas.Location = New System.Drawing.Point(125, 93)
        Me.txt_CantidadRuedas.Name = "txt_CantidadRuedas"
        Me.txt_CantidadRuedas.Size = New System.Drawing.Size(100, 20)
        Me.txt_CantidadRuedas.TabIndex = 9
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Location = New System.Drawing.Point(240, 17)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 10
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Location = New System.Drawing.Point(320, 294)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 16
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Volver
        '
        Me.btn_Volver.Location = New System.Drawing.Point(509, 294)
        Me.btn_Volver.Name = "btn_Volver"
        Me.btn_Volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_Volver.TabIndex = 15
        Me.btn_Volver.Text = "Vovler"
        Me.btn_Volver.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(417, 294)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 14
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Location = New System.Drawing.Point(222, 294)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Modificar.TabIndex = 13
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Location = New System.Drawing.Point(129, 294)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Agregar.TabIndex = 12
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'frm_TipoVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.SistemasIII.My.Resources.Resources.frm23
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(712, 330)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Volver)
        Me.Controls.Add(Me.grb_Datos)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Name = "frm_TipoVehiculo"
        Me.Text = "frm_TipoVehiculo"
        Me.grb_Datos.ResumeLayout(False)
        Me.grb_Datos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grb_Datos As GroupBox
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents txt_CantidadRuedas As TextBox
    Friend WithEvents txt_CapacidadCarga As TextBox
    Friend WithEvents txt_CapacidadPasajeros As TextBox
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents txt_Codigo As TextBox
    Friend WithEvents lbl_CantidadRuedas As Label
    Friend WithEvents lbl_Nombre As Label
    Friend WithEvents lbl_CapacidadCarga As Label
    Friend WithEvents lbl_CapacidadPasajeros As Label
    Friend WithEvents lbl_Codigo As Label
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btn_Volver As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Modificar As Button
    Friend WithEvents btn_Agregar As Button
End Class
