<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.TomadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AseguradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDePolizaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoberturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrativoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiniestroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiniestroToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeInspeccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiculoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeVehiculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagoYCobroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ServicioToolStripMenuItem, Me.AdministrativoToolStripMenuItem, Me.SiniestroToolStripMenuItem, Me.VehiculoToolStripMenuItem, Me.PagoYCobroToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(716, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TomadoToolStripMenuItem, Me.AseguradoToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(56, 20)
        Me.FileMenu.Text = "Cliente"
        '
        'TomadoToolStripMenuItem
        '
        Me.TomadoToolStripMenuItem.Name = "TomadoToolStripMenuItem"
        Me.TomadoToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.TomadoToolStripMenuItem.Text = "Tomador"
        '
        'AseguradoToolStripMenuItem
        '
        Me.AseguradoToolStripMenuItem.Name = "AseguradoToolStripMenuItem"
        Me.AseguradoToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AseguradoToolStripMenuItem.Text = "Asegurado"
        '
        'ServicioToolStripMenuItem
        '
        Me.ServicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContratoToolStripMenuItem, Me.TipoDePolizaToolStripMenuItem, Me.CoberturaToolStripMenuItem})
        Me.ServicioToolStripMenuItem.Name = "ServicioToolStripMenuItem"
        Me.ServicioToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ServicioToolStripMenuItem.Text = "Servicio"
        '
        'ContratoToolStripMenuItem
        '
        Me.ContratoToolStripMenuItem.Name = "ContratoToolStripMenuItem"
        Me.ContratoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ContratoToolStripMenuItem.Text = "Contrato"
        '
        'TipoDePolizaToolStripMenuItem
        '
        Me.TipoDePolizaToolStripMenuItem.Name = "TipoDePolizaToolStripMenuItem"
        Me.TipoDePolizaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TipoDePolizaToolStripMenuItem.Text = "Tipo de poliza"
        '
        'CoberturaToolStripMenuItem
        '
        Me.CoberturaToolStripMenuItem.Name = "CoberturaToolStripMenuItem"
        Me.CoberturaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CoberturaToolStripMenuItem.Text = "Cobertura"
        '
        'AdministrativoToolStripMenuItem
        '
        Me.AdministrativoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadoToolStripMenuItem, Me.UsuarioToolStripMenuItem})
        Me.AdministrativoToolStripMenuItem.Name = "AdministrativoToolStripMenuItem"
        Me.AdministrativoToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.AdministrativoToolStripMenuItem.Text = "Administrativo"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.EmpleadoToolStripMenuItem.Text = "Empleado"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'SiniestroToolStripMenuItem
        '
        Me.SiniestroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SiniestroToolStripMenuItem1, Me.TipoDeInspeccionToolStripMenuItem})
        Me.SiniestroToolStripMenuItem.Name = "SiniestroToolStripMenuItem"
        Me.SiniestroToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.SiniestroToolStripMenuItem.Text = "Siniestro"
        '
        'SiniestroToolStripMenuItem1
        '
        Me.SiniestroToolStripMenuItem1.Name = "SiniestroToolStripMenuItem1"
        Me.SiniestroToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.SiniestroToolStripMenuItem1.Text = "Siniestro"
        '
        'TipoDeInspeccionToolStripMenuItem
        '
        Me.TipoDeInspeccionToolStripMenuItem.Name = "TipoDeInspeccionToolStripMenuItem"
        Me.TipoDeInspeccionToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.TipoDeInspeccionToolStripMenuItem.Text = "Tipo de inspeccion"
        '
        'VehiculoToolStripMenuItem
        '
        Me.VehiculoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VehiculoToolStripMenuItem1, Me.TipoDeVehiculoToolStripMenuItem})
        Me.VehiculoToolStripMenuItem.Name = "VehiculoToolStripMenuItem"
        Me.VehiculoToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.VehiculoToolStripMenuItem.Text = "Vehiculo"
        '
        'VehiculoToolStripMenuItem1
        '
        Me.VehiculoToolStripMenuItem1.Name = "VehiculoToolStripMenuItem1"
        Me.VehiculoToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.VehiculoToolStripMenuItem1.Text = "Vehiculo"
        '
        'TipoDeVehiculoToolStripMenuItem
        '
        Me.TipoDeVehiculoToolStripMenuItem.Name = "TipoDeVehiculoToolStripMenuItem"
        Me.TipoDeVehiculoToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.TipoDeVehiculoToolStripMenuItem.Text = "Tipo de vehiculo"
        '
        'PagoYCobroToolStripMenuItem
        '
        Me.PagoYCobroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuotasToolStripMenuItem, Me.PagoToolStripMenuItem})
        Me.PagoYCobroToolStripMenuItem.Name = "PagoYCobroToolStripMenuItem"
        Me.PagoYCobroToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.PagoYCobroToolStripMenuItem.Text = "Pago y cobro"
        '
        'CuotasToolStripMenuItem
        '
        Me.CuotasToolStripMenuItem.Name = "CuotasToolStripMenuItem"
        Me.CuotasToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.CuotasToolStripMenuItem.Text = "Cuotas"
        '
        'PagoToolStripMenuItem
        '
        Me.PagoToolStripMenuItem.Name = "PagoToolStripMenuItem"
        Me.PagoToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.PagoToolStripMenuItem.Text = "Pago"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListasToolStripMenuItem, Me.ReporteToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ListasToolStripMenuItem
        '
        Me.ListasToolStripMenuItem.Name = "ListasToolStripMenuItem"
        Me.ListasToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ListasToolStripMenuItem.Text = "Listas "
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ReporteToolStripMenuItem.Text = "Reporte"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.Text = "MDIParent1"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents TomadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AseguradoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContratoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoDePolizaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CoberturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrativoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SiniestroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SiniestroToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TipoDeInspeccionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VehiculoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VehiculoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TipoDeVehiculoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagoYCobroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As ToolStripMenuItem
End Class
