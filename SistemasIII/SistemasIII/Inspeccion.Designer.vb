<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inspeccion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Daño1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Partedevehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.grb_Vehiculo = New System.Windows.Forms.GroupBox()
        Me.dtp_Año = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Marca = New System.Windows.Forms.Label()
        Me.txt_Modelo = New System.Windows.Forms.TextBox()
        Me.btn_BuscarP = New System.Windows.Forms.Button()
        Me.lbl_Año = New System.Windows.Forms.Label()
        Me.txt_Marca = New System.Windows.Forms.TextBox()
        Me.lbl_Modelo = New System.Windows.Forms.Label()
        Me.txt_Placa = New System.Windows.Forms.TextBox()
        Me.lbl_Placa = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_Vehiculo.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 366)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(611, 290)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(450, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 27)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Añadir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Daño1, Me.Partedevehiculo, Me.Descripcion})
        Me.DataGridView1.Location = New System.Drawing.Point(20, 95)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(569, 172)
        Me.DataGridView1.TabIndex = 22
        '
        'Daño1
        '
        Me.Daño1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Daño1.HeaderText = "Daño"
        Me.Daño1.Name = "Daño1"
        Me.Daño1.ReadOnly = True
        Me.Daño1.Width = 130
        '
        'Partedevehiculo
        '
        Me.Partedevehiculo.HeaderText = "Parte de vehículo"
        Me.Partedevehiculo.Name = "Partedevehiculo"
        Me.Partedevehiculo.ReadOnly = True
        Me.Partedevehiculo.Width = 200
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 200
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(122, 49)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(310, 20)
        Me.TextBox3.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Descripción"
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(450, 16)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(139, 21)
        Me.ComboBox4.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(338, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Parte del vehículo"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(122, 16)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(194, 21)
        Me.ComboBox3.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Daño"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(398, 662)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(115, 27)
        Me.Button7.TabIndex = 27
        Me.Button7.Text = "Salir"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(263, 662)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(115, 27)
        Me.Button8.TabIndex = 28
        Me.Button8.Text = "Cancelar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(138, 662)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(115, 27)
        Me.Button9.TabIndex = 29
        Me.Button9.Text = "Guardar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'grb_Vehiculo
        '
        Me.grb_Vehiculo.Controls.Add(Me.dtp_Año)
        Me.grb_Vehiculo.Controls.Add(Me.lbl_Marca)
        Me.grb_Vehiculo.Controls.Add(Me.txt_Modelo)
        Me.grb_Vehiculo.Controls.Add(Me.btn_BuscarP)
        Me.grb_Vehiculo.Controls.Add(Me.lbl_Año)
        Me.grb_Vehiculo.Controls.Add(Me.txt_Marca)
        Me.grb_Vehiculo.Controls.Add(Me.lbl_Modelo)
        Me.grb_Vehiculo.Controls.Add(Me.txt_Placa)
        Me.grb_Vehiculo.Controls.Add(Me.lbl_Placa)
        Me.grb_Vehiculo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Vehiculo.Location = New System.Drawing.Point(16, 189)
        Me.grb_Vehiculo.Name = "grb_Vehiculo"
        Me.grb_Vehiculo.Size = New System.Drawing.Size(623, 82)
        Me.grb_Vehiculo.TabIndex = 110
        Me.grb_Vehiculo.TabStop = False
        Me.grb_Vehiculo.Text = " Datos del vehiculo"
        '
        'dtp_Año
        '
        Me.dtp_Año.CustomFormat = """yyyy"""
        Me.dtp_Año.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtp_Año.Location = New System.Drawing.Point(366, 17)
        Me.dtp_Año.MinDate = New Date(1800, 2, 1, 0, 0, 0, 0)
        Me.dtp_Año.Name = "dtp_Año"
        Me.dtp_Año.Size = New System.Drawing.Size(200, 21)
        Me.dtp_Año.TabIndex = 109
        '
        'lbl_Marca
        '
        Me.lbl_Marca.AutoSize = True
        Me.lbl_Marca.Location = New System.Drawing.Point(38, 52)
        Me.lbl_Marca.Name = "lbl_Marca"
        Me.lbl_Marca.Size = New System.Drawing.Size(48, 16)
        Me.lbl_Marca.TabIndex = 108
        Me.lbl_Marca.Text = "Marca:"
        '
        'txt_Modelo
        '
        Me.txt_Modelo.Location = New System.Drawing.Point(307, 49)
        Me.txt_Modelo.Name = "txt_Modelo"
        Me.txt_Modelo.Size = New System.Drawing.Size(138, 21)
        Me.txt_Modelo.TabIndex = 107
        '
        'btn_BuscarP
        '
        Me.btn_BuscarP.Location = New System.Drawing.Point(236, 19)
        Me.btn_BuscarP.Name = "btn_BuscarP"
        Me.btn_BuscarP.Size = New System.Drawing.Size(75, 23)
        Me.btn_BuscarP.TabIndex = 106
        Me.btn_BuscarP.Text = "Buscar"
        Me.btn_BuscarP.UseVisualStyleBackColor = True
        '
        'lbl_Año
        '
        Me.lbl_Año.AutoSize = True
        Me.lbl_Año.Location = New System.Drawing.Point(331, 20)
        Me.lbl_Año.Name = "lbl_Año"
        Me.lbl_Año.Size = New System.Drawing.Size(29, 16)
        Me.lbl_Año.TabIndex = 13
        Me.lbl_Año.Text = "Año"
        '
        'txt_Marca
        '
        Me.txt_Marca.Location = New System.Drawing.Point(92, 49)
        Me.txt_Marca.Name = "txt_Marca"
        Me.txt_Marca.Size = New System.Drawing.Size(138, 21)
        Me.txt_Marca.TabIndex = 12
        '
        'lbl_Modelo
        '
        Me.lbl_Modelo.AutoSize = True
        Me.lbl_Modelo.Location = New System.Drawing.Point(245, 52)
        Me.lbl_Modelo.Name = "lbl_Modelo"
        Me.lbl_Modelo.Size = New System.Drawing.Size(56, 16)
        Me.lbl_Modelo.TabIndex = 11
        Me.lbl_Modelo.Text = " Modelo:"
        '
        'txt_Placa
        '
        Me.txt_Placa.Location = New System.Drawing.Point(92, 19)
        Me.txt_Placa.Name = "txt_Placa"
        Me.txt_Placa.Size = New System.Drawing.Size(138, 21)
        Me.txt_Placa.TabIndex = 9
        '
        'lbl_Placa
        '
        Me.lbl_Placa.AutoSize = True
        Me.lbl_Placa.Location = New System.Drawing.Point(40, 22)
        Me.lbl_Placa.Name = "lbl_Placa"
        Me.lbl_Placa.Size = New System.Drawing.Size(46, 16)
        Me.lbl_Placa.TabIndex = 8
        Me.lbl_Placa.Text = " Placa:"
        '
        'Inspeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.SistemasIII.My.Resources.Resources.frm23
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(647, 711)
        Me.Controls.Add(Me.grb_Vehiculo)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Inspeccion"
        Me.Text = "Form4"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_Vehiculo.ResumeLayout(False)
        Me.grb_Vehiculo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Daño1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Partedevehiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents grb_Vehiculo As GroupBox
    Friend WithEvents dtp_Año As DateTimePicker
    Friend WithEvents lbl_Marca As Label
    Friend WithEvents txt_Modelo As TextBox
    Friend WithEvents btn_BuscarP As Button
    Friend WithEvents lbl_Año As Label
    Friend WithEvents txt_Marca As TextBox
    Friend WithEvents lbl_Modelo As Label
    Friend WithEvents txt_Placa As TextBox
    Friend WithEvents lbl_Placa As Label
End Class
