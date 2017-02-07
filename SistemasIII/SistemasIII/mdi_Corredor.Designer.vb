<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdi_Corredor
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
        Me.MaestrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratoDePólizaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TomadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AseguradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PólizasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDePolizaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanDePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CotizaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaestrosToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.CotizaciónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MaestrosToolStripMenuItem
        '
        Me.MaestrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContratoDePólizaToolStripMenuItem, Me.TomadorToolStripMenuItem, Me.AseguradoToolStripMenuItem})
        Me.MaestrosToolStripMenuItem.Name = "MaestrosToolStripMenuItem"
        Me.MaestrosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.MaestrosToolStripMenuItem.Text = "Maestros"
        '
        'ContratoDePólizaToolStripMenuItem
        '
        Me.ContratoDePólizaToolStripMenuItem.Name = "ContratoDePólizaToolStripMenuItem"
        Me.ContratoDePólizaToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ContratoDePólizaToolStripMenuItem.Text = "Contrato de póliza"
        '
        'TomadorToolStripMenuItem
        '
        Me.TomadorToolStripMenuItem.Name = "TomadorToolStripMenuItem"
        Me.TomadorToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.TomadorToolStripMenuItem.Text = "Tomador"
        '
        'AseguradoToolStripMenuItem
        '
        Me.AseguradoToolStripMenuItem.Name = "AseguradoToolStripMenuItem"
        Me.AseguradoToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AseguradoToolStripMenuItem.Text = "Asegurado"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PólizasToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'PólizasToolStripMenuItem
        '
        Me.PólizasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoDePolizaToolStripMenuItem, Me.PlanDePagoToolStripMenuItem})
        Me.PólizasToolStripMenuItem.Name = "PólizasToolStripMenuItem"
        Me.PólizasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PólizasToolStripMenuItem.Text = "Pólizas"
        '
        'TipoDePolizaToolStripMenuItem
        '
        Me.TipoDePolizaToolStripMenuItem.Name = "TipoDePolizaToolStripMenuItem"
        Me.TipoDePolizaToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.TipoDePolizaToolStripMenuItem.Text = "Tipo de poliza"
        '
        'PlanDePagoToolStripMenuItem
        '
        Me.PlanDePagoToolStripMenuItem.Name = "PlanDePagoToolStripMenuItem"
        Me.PlanDePagoToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.PlanDePagoToolStripMenuItem.Text = "Plan de pago"
        '
        'CotizaciónToolStripMenuItem
        '
        Me.CotizaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarToolStripMenuItem, Me.ListadosToolStripMenuItem})
        Me.CotizaciónToolStripMenuItem.Name = "CotizaciónToolStripMenuItem"
        Me.CotizaciónToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.CotizaciónToolStripMenuItem.Text = "Generar"
        '
        'GenerarToolStripMenuItem
        '
        Me.GenerarToolStripMenuItem.Name = "GenerarToolStripMenuItem"
        Me.GenerarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GenerarToolStripMenuItem.Text = "Cotización"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ListadosToolStripMenuItem
        '
        Me.ListadosToolStripMenuItem.Name = "ListadosToolStripMenuItem"
        Me.ListadosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListadosToolStripMenuItem.Text = "Listados"
        '
        'mdi_Corredor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "mdi_Corredor"
        Me.Text = "mdi_Corredor"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MaestrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContratoDePólizaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TomadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AseguradoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PólizasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoDePolizaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlanDePagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CotizaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadosToolStripMenuItem As ToolStripMenuItem
End Class
