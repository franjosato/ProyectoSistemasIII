<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_InicioSesion
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
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.lbl_Contraseña = New System.Windows.Forms.Label()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Ingresar = New System.Windows.Forms.Button()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.txt_Contraseña = New System.Windows.Forms.TextBox()
        Me.ptb_ImgInicio = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tmr_HoraInicioSesion = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_HoraInicioSesion = New System.Windows.Forms.Label()
        CType(Me.ptb_ImgInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Usuario.Location = New System.Drawing.Point(278, 51)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(71, 16)
        Me.lbl_Usuario.TabIndex = 1
        Me.lbl_Usuario.Text = "USUARIO"
        '
        'lbl_Contraseña
        '
        Me.lbl_Contraseña.AutoSize = True
        Me.lbl_Contraseña.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Contraseña.Location = New System.Drawing.Point(255, 98)
        Me.lbl_Contraseña.Name = "lbl_Contraseña"
        Me.lbl_Contraseña.Size = New System.Drawing.Size(102, 16)
        Me.lbl_Contraseña.TabIndex = 2
        Me.lbl_Contraseña.Text = "CONTRASEÑA"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.Location = New System.Drawing.Point(397, 155)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(93, 23)
        Me.btn_Cancelar.TabIndex = 4
        Me.btn_Cancelar.Text = "CANCELAR"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Ingresar
        '
        Me.btn_Ingresar.Enabled = False
        Me.btn_Ingresar.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ingresar.Location = New System.Drawing.Point(291, 155)
        Me.btn_Ingresar.Name = "btn_Ingresar"
        Me.btn_Ingresar.Size = New System.Drawing.Size(89, 23)
        Me.btn_Ingresar.TabIndex = 5
        Me.btn_Ingresar.Text = "INGRESAR"
        Me.btn_Ingresar.UseVisualStyleBackColor = True
        '
        'txt_Usuario
        '
        Me.txt_Usuario.Location = New System.Drawing.Point(373, 51)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(117, 20)
        Me.txt_Usuario.TabIndex = 6
        '
        'txt_Contraseña
        '
        Me.txt_Contraseña.Location = New System.Drawing.Point(373, 98)
        Me.txt_Contraseña.Name = "txt_Contraseña"
        Me.txt_Contraseña.Size = New System.Drawing.Size(117, 20)
        Me.txt_Contraseña.TabIndex = 7
        '
        'ptb_ImgInicio
        '
        Me.ptb_ImgInicio.Image = Global.WindowsApplication1.My.Resources.Resources.Imagen1
        Me.ptb_ImgInicio.Location = New System.Drawing.Point(-22, 0)
        Me.ptb_ImgInicio.Name = "ptb_ImgInicio"
        Me.ptb_ImgInicio.Size = New System.Drawing.Size(258, 251)
        Me.ptb_ImgInicio.TabIndex = 8
        Me.ptb_ImgInicio.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 178)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'tmr_HoraInicioSesion
        '
        '
        'lbl_HoraInicioSesion
        '
        Me.lbl_HoraInicioSesion.AutoSize = True
        Me.lbl_HoraInicioSesion.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HoraInicioSesion.Location = New System.Drawing.Point(438, 19)
        Me.lbl_HoraInicioSesion.Name = "lbl_HoraInicioSesion"
        Me.lbl_HoraInicioSesion.Size = New System.Drawing.Size(52, 15)
        Me.lbl_HoraInicioSesion.TabIndex = 9
        Me.lbl_HoraInicioSesion.Text = "               "
        '
        'frm_InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 243)
        Me.Controls.Add(Me.lbl_HoraInicioSesion)
        Me.Controls.Add(Me.ptb_ImgInicio)
        Me.Controls.Add(Me.txt_Contraseña)
        Me.Controls.Add(Me.txt_Usuario)
        Me.Controls.Add(Me.btn_Ingresar)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.lbl_Contraseña)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_InicioSesion"
        Me.Text = "frm_InicioSesion"
        CType(Me.ptb_ImgInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Usuario As System.Windows.Forms.Label
    Friend WithEvents lbl_Contraseña As System.Windows.Forms.Label
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Ingresar As System.Windows.Forms.Button
    Friend WithEvents txt_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_Contraseña As System.Windows.Forms.TextBox
    Friend WithEvents ptb_ImgInicio As System.Windows.Forms.PictureBox
    Friend WithEvents tmr_HoraInicioSesion As System.Windows.Forms.Timer
    Friend WithEvents lbl_HoraInicioSesion As System.Windows.Forms.Label
End Class
