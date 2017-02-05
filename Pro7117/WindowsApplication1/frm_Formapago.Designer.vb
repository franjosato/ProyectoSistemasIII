<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Formapago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Formapago))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_Volver = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Procesarpago = New System.Windows.Forms.Button()
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
        CType(Me.dgv_Pagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btn_Volver.Location = New System.Drawing.Point(451, 420)
        Me.btn_Volver.Name = "btn_Volver"
        Me.btn_Volver.Size = New System.Drawing.Size(105, 28)
        Me.btn_Volver.TabIndex = 29
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
        Me.btn_Cancelar.Location = New System.Drawing.Point(322, 420)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(105, 28)
        Me.btn_Cancelar.TabIndex = 28
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
        Me.btn_Procesarpago.Location = New System.Drawing.Point(166, 419)
        Me.btn_Procesarpago.Name = "btn_Procesarpago"
        Me.btn_Procesarpago.Size = New System.Drawing.Size(132, 29)
        Me.btn_Procesarpago.TabIndex = 27
        Me.btn_Procesarpago.Text = "Procesar Pago"
        Me.btn_Procesarpago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Procesarpago.UseVisualStyleBackColor = False
        '
        'txt_Cambio
        '
        Me.txt_Cambio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cambio.Location = New System.Drawing.Point(591, 360)
        Me.txt_Cambio.Name = "txt_Cambio"
        Me.txt_Cambio.Size = New System.Drawing.Size(107, 23)
        Me.txt_Cambio.TabIndex = 26
        '
        'lbl_Cambio
        '
        Me.lbl_Cambio.AutoSize = True
        Me.lbl_Cambio.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Cambio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cambio.Location = New System.Drawing.Point(384, 360)
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Pagos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
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
        Me.dgv_Pagos.Location = New System.Drawing.Point(192, 204)
        Me.dgv_Pagos.Name = "dgv_Pagos"
        Me.dgv_Pagos.ReadOnly = True
        Me.dgv_Pagos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_Pagos.RowHeadersVisible = False
        Me.dgv_Pagos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_Pagos.Size = New System.Drawing.Size(505, 147)
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
        Me.btn_Añadir.Location = New System.Drawing.Point(80, 322)
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
        Me.txt_Montoacancelar.Location = New System.Drawing.Point(80, 283)
        Me.txt_Montoacancelar.Name = "txt_Montoacancelar"
        Me.txt_Montoacancelar.Size = New System.Drawing.Size(106, 23)
        Me.txt_Montoacancelar.TabIndex = 22
        '
        'lbl_Montoacancelar
        '
        Me.lbl_Montoacancelar.AutoSize = True
        Me.lbl_Montoacancelar.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Montoacancelar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Montoacancelar.Location = New System.Drawing.Point(29, 263)
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
        Me.lbl_Formapago.Location = New System.Drawing.Point(77, 207)
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
        Me.cmb_Formapago.Location = New System.Drawing.Point(20, 227)
        Me.cmb_Formapago.Name = "cmb_Formapago"
        Me.cmb_Formapago.Size = New System.Drawing.Size(166, 25)
        Me.cmb_Formapago.TabIndex = 19
        '
        'txt_Totalapagar
        '
        Me.txt_Totalapagar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Totalapagar.Location = New System.Drawing.Point(591, 175)
        Me.txt_Totalapagar.Name = "txt_Totalapagar"
        Me.txt_Totalapagar.Size = New System.Drawing.Size(106, 23)
        Me.txt_Totalapagar.TabIndex = 18
        '
        'lbl_Totalapagar
        '
        Me.lbl_Totalapagar.AutoSize = True
        Me.lbl_Totalapagar.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Totalapagar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Totalapagar.Location = New System.Drawing.Point(460, 175)
        Me.lbl_Totalapagar.Name = "lbl_Totalapagar"
        Me.lbl_Totalapagar.Size = New System.Drawing.Size(125, 17)
        Me.lbl_Totalapagar.TabIndex = 17
        Me.lbl_Totalapagar.Text = "Total a Pagar Bs.F."
        '
        'frm_Formapago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 454)
        Me.Controls.Add(Me.btn_Volver)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Procesarpago)
        Me.Controls.Add(Me.txt_Cambio)
        Me.Controls.Add(Me.lbl_Cambio)
        Me.Controls.Add(Me.dgv_Pagos)
        Me.Controls.Add(Me.btn_Añadir)
        Me.Controls.Add(Me.txt_Montoacancelar)
        Me.Controls.Add(Me.lbl_Montoacancelar)
        Me.Controls.Add(Me.lbl_Formapago)
        Me.Controls.Add(Me.cmb_Formapago)
        Me.Controls.Add(Me.txt_Totalapagar)
        Me.Controls.Add(Me.lbl_Totalapagar)
        Me.Name = "frm_Formapago"
        Me.Text = "Form1"
        CType(Me.dgv_Pagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Volver As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Procesarpago As Button
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
End Class
