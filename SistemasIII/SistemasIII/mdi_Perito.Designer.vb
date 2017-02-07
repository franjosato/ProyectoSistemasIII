<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdi_Perito
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehículoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiniestroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InspecciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcesarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiniestroToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem, Me.ProcesarToolStripMenuItem, Me.GenerarToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VehículoToolStripMenuItem, Me.SiniestroToolStripMenuItem, Me.InspecciónToolStripMenuItem})
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'VehículoToolStripMenuItem
        '
        Me.VehículoToolStripMenuItem.Name = "VehículoToolStripMenuItem"
        Me.VehículoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VehículoToolStripMenuItem.Text = "Vehículo"
        '
        'SiniestroToolStripMenuItem
        '
        Me.SiniestroToolStripMenuItem.Name = "SiniestroToolStripMenuItem"
        Me.SiniestroToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SiniestroToolStripMenuItem.Text = "Siniestro"
        '
        'InspecciónToolStripMenuItem
        '
        Me.InspecciónToolStripMenuItem.Name = "InspecciónToolStripMenuItem"
        Me.InspecciónToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InspecciónToolStripMenuItem.Text = "Inspección"
        '
        'ProcesarToolStripMenuItem
        '
        Me.ProcesarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SiniestroToolStripMenuItem1})
        Me.ProcesarToolStripMenuItem.Name = "ProcesarToolStripMenuItem"
        Me.ProcesarToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ProcesarToolStripMenuItem.Text = "Procesar"
        '
        'SiniestroToolStripMenuItem1
        '
        Me.SiniestroToolStripMenuItem1.Name = "SiniestroToolStripMenuItem1"
        Me.SiniestroToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.SiniestroToolStripMenuItem1.Text = "Siniestro"
        '
        'GenerarToolStripMenuItem
        '
        Me.GenerarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadosToolStripMenuItem})
        Me.GenerarToolStripMenuItem.Name = "GenerarToolStripMenuItem"
        Me.GenerarToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.GenerarToolStripMenuItem.Text = "Generar"
        '
        'ListadosToolStripMenuItem
        '
        Me.ListadosToolStripMenuItem.Name = "ListadosToolStripMenuItem"
        Me.ListadosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListadosToolStripMenuItem.Text = "Listados"
        '
        'mdi_Perito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "mdi_Perito"
        Me.Text = "mdi_Perito"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VehículoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SiniestroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InspecciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProcesarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SiniestroToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GenerarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadosToolStripMenuItem As ToolStripMenuItem
End Class
