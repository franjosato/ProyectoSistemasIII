<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Portada
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btn_Siniestro = New System.Windows.Forms.Button()
        Me.btn_RegistrarUsuario = New System.Windows.Forms.Button()
        Me.lbl_CargoActual = New System.Windows.Forms.Label()
        Me.lbl_UsuarioActual = New System.Windows.Forms.Label()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.tmr_HoraPortada = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btn_Siniestro
        '
        Me.btn_Siniestro.Location = New System.Drawing.Point(40, 85)
        Me.btn_Siniestro.Name = "btn_Siniestro"
        Me.btn_Siniestro.Size = New System.Drawing.Size(114, 25)
        Me.btn_Siniestro.TabIndex = 1
        Me.btn_Siniestro.Text = "Registrar Siniestro"
        Me.btn_Siniestro.UseVisualStyleBackColor = True
        '
        'btn_RegistrarUsuario
        '
        Me.btn_RegistrarUsuario.Location = New System.Drawing.Point(40, 116)
        Me.btn_RegistrarUsuario.Name = "btn_RegistrarUsuario"
        Me.btn_RegistrarUsuario.Size = New System.Drawing.Size(114, 25)
        Me.btn_RegistrarUsuario.TabIndex = 2
        Me.btn_RegistrarUsuario.Text = "Registrar Usuario"
        Me.btn_RegistrarUsuario.UseVisualStyleBackColor = True
        '
        'lbl_CargoActual
        '
        Me.lbl_CargoActual.AutoSize = True
        Me.lbl_CargoActual.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CargoActual.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CargoActual.Location = New System.Drawing.Point(403, 51)
        Me.lbl_CargoActual.Name = "lbl_CargoActual"
        Me.lbl_CargoActual.Size = New System.Drawing.Size(95, 16)
        Me.lbl_CargoActual.TabIndex = 21
        Me.lbl_CargoActual.Text = "                             "
        '
        'lbl_UsuarioActual
        '
        Me.lbl_UsuarioActual.AutoSize = True
        Me.lbl_UsuarioActual.BackColor = System.Drawing.Color.Transparent
        Me.lbl_UsuarioActual.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_UsuarioActual.Location = New System.Drawing.Point(421, 23)
        Me.lbl_UsuarioActual.Name = "lbl_UsuarioActual"
        Me.lbl_UsuarioActual.Size = New System.Drawing.Size(92, 16)
        Me.lbl_UsuarioActual.TabIndex = 20
        Me.lbl_UsuarioActual.Text = "                            "
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Hora.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Hora.Location = New System.Drawing.Point(421, 107)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(52, 15)
        Me.lbl_Hora.TabIndex = 22
        Me.lbl_Hora.Text = "               "
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fecha.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(421, 134)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(52, 15)
        Me.lbl_Fecha.TabIndex = 23
        Me.lbl_Fecha.Text = "               "
        '
        'tmr_HoraPortada
        '
        '
        'frm_Portada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font

        Me.ClientSize = New System.Drawing.Size(556, 336)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.lbl_Hora)
        Me.Controls.Add(Me.lbl_CargoActual)
        Me.Controls.Add(Me.lbl_UsuarioActual)
        Me.Controls.Add(Me.btn_RegistrarUsuario)
        Me.Controls.Add(Me.btn_Siniestro)
        Me.Name = "frm_Portada"
        Me.Text = "frm_Portada"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Siniestro As System.Windows.Forms.Button
    Friend WithEvents btn_RegistrarUsuario As System.Windows.Forms.Button
    Friend WithEvents lbl_CargoActual As System.Windows.Forms.Label
    Friend WithEvents lbl_UsuarioActual As System.Windows.Forms.Label
    Friend WithEvents lbl_Hora As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents tmr_HoraPortada As System.Windows.Forms.Timer
End Class
