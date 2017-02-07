<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdi_Gerente
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
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MaestrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeVehículoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcaDeVehículoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParteDeVehículoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InspecciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoberturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanDePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehículoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeInspecciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiniestroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDePolizaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticasDeInspeccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuotasPagasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticasDeSiniestroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoPorContratoDePólizaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContrapoPorTipoDePolizaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.MaestrosToolStripMenuItem, Me.GenerarToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MaestrosToolStripMenuItem
        '
        Me.MaestrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadoToolStripMenuItem, Me.VehículoToolStripMenuItem, Me.MarcaDeVehículoToolStripMenuItem, Me.TipoDeVehículoToolStripMenuItem, Me.ParteDeVehículoToolStripMenuItem, Me.SiniestroToolStripMenuItem, Me.InspecciónToolStripMenuItem, Me.TipoDeInspecciónToolStripMenuItem, Me.PagoToolStripMenuItem, Me.PlanDePagoToolStripMenuItem, Me.CoberturaToolStripMenuItem, Me.TipoDePolizaToolStripMenuItem})
        Me.MaestrosToolStripMenuItem.Name = "MaestrosToolStripMenuItem"
        Me.MaestrosToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.MaestrosToolStripMenuItem.Text = "Incluir"
        '
        'GenerarToolStripMenuItem
        '
        Me.GenerarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadosToolStripMenuItem, Me.ReportesToolStripMenuItem})
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
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstadisticasDeInspeccionesToolStripMenuItem, Me.CuotasPagasToolStripMenuItem, Me.EstadisticasDeSiniestroToolStripMenuItem, Me.IngresoPorContratoDePólizaToolStripMenuItem, Me.ContrapoPorTipoDePolizaToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.EmpleadoToolStripMenuItem.Text = "Empleado"
        '
        'TipoDeVehículoToolStripMenuItem
        '
        Me.TipoDeVehículoToolStripMenuItem.Name = "TipoDeVehículoToolStripMenuItem"
        Me.TipoDeVehículoToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.TipoDeVehículoToolStripMenuItem.Text = "Tipo de vehículo"
        '
        'MarcaDeVehículoToolStripMenuItem
        '
        Me.MarcaDeVehículoToolStripMenuItem.Name = "MarcaDeVehículoToolStripMenuItem"
        Me.MarcaDeVehículoToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.MarcaDeVehículoToolStripMenuItem.Text = "Marca de vehículo"
        '
        'ParteDeVehículoToolStripMenuItem
        '
        Me.ParteDeVehículoToolStripMenuItem.Name = "ParteDeVehículoToolStripMenuItem"
        Me.ParteDeVehículoToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ParteDeVehículoToolStripMenuItem.Text = "Parte de vehículo"
        '
        'InspecciónToolStripMenuItem
        '
        Me.InspecciónToolStripMenuItem.Name = "InspecciónToolStripMenuItem"
        Me.InspecciónToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.InspecciónToolStripMenuItem.Text = "Inspección"
        '
        'PagoToolStripMenuItem
        '
        Me.PagoToolStripMenuItem.Name = "PagoToolStripMenuItem"
        Me.PagoToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.PagoToolStripMenuItem.Text = "Pago"
        '
        'CoberturaToolStripMenuItem
        '
        Me.CoberturaToolStripMenuItem.Name = "CoberturaToolStripMenuItem"
        Me.CoberturaToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CoberturaToolStripMenuItem.Text = "Cobertura"
        '
        'PlanDePagoToolStripMenuItem
        '
        Me.PlanDePagoToolStripMenuItem.Name = "PlanDePagoToolStripMenuItem"
        Me.PlanDePagoToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.PlanDePagoToolStripMenuItem.Text = "Plan de pago"
        '
        'VehículoToolStripMenuItem
        '
        Me.VehículoToolStripMenuItem.Name = "VehículoToolStripMenuItem"
        Me.VehículoToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.VehículoToolStripMenuItem.Text = "Vehículo"
        '
        'TipoDeInspecciónToolStripMenuItem
        '
        Me.TipoDeInspecciónToolStripMenuItem.Name = "TipoDeInspecciónToolStripMenuItem"
        Me.TipoDeInspecciónToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.TipoDeInspecciónToolStripMenuItem.Text = "Tipo de inspección"
        '
        'SiniestroToolStripMenuItem
        '
        Me.SiniestroToolStripMenuItem.Name = "SiniestroToolStripMenuItem"
        Me.SiniestroToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.SiniestroToolStripMenuItem.Text = "Siniestro"
        '
        'TipoDePolizaToolStripMenuItem
        '
        Me.TipoDePolizaToolStripMenuItem.Name = "TipoDePolizaToolStripMenuItem"
        Me.TipoDePolizaToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.TipoDePolizaToolStripMenuItem.Text = "Tipo de poliza"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10, Me.ToolStripMenuItem11, Me.ToolStripMenuItem12, Me.ToolStripMenuItem13})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(70, 20)
        Me.ToolStripMenuItem1.Text = "Consultar"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem2.Text = "Empleado"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem3.Text = "Vehículo"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem4.Text = "Marca de vehículo"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem5.Text = "Tipo de vehículo"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem6.Text = "Parte de vehículo"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem7.Text = "Siniestro"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem8.Text = "Inspección"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem9.Text = "Tipo de inspección"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem10.Text = "Pago"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem11.Text = "Plan de pago"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem12.Text = "Cobertura"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem13.Text = "Tipo de poliza"
        '
        'EstadisticasDeInspeccionesToolStripMenuItem
        '
        Me.EstadisticasDeInspeccionesToolStripMenuItem.Name = "EstadisticasDeInspeccionesToolStripMenuItem"
        Me.EstadisticasDeInspeccionesToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.EstadisticasDeInspeccionesToolStripMenuItem.Text = "Estadisticas de Inspecciones"
        '
        'CuotasPagasToolStripMenuItem
        '
        Me.CuotasPagasToolStripMenuItem.Name = "CuotasPagasToolStripMenuItem"
        Me.CuotasPagasToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.CuotasPagasToolStripMenuItem.Text = "Cuotas pagas"
        '
        'EstadisticasDeSiniestroToolStripMenuItem
        '
        Me.EstadisticasDeSiniestroToolStripMenuItem.Name = "EstadisticasDeSiniestroToolStripMenuItem"
        Me.EstadisticasDeSiniestroToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.EstadisticasDeSiniestroToolStripMenuItem.Text = "Estadisticas de siniestro"
        '
        'IngresoPorContratoDePólizaToolStripMenuItem
        '
        Me.IngresoPorContratoDePólizaToolStripMenuItem.Name = "IngresoPorContratoDePólizaToolStripMenuItem"
        Me.IngresoPorContratoDePólizaToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.IngresoPorContratoDePólizaToolStripMenuItem.Text = "Ingreso por contrato de póliza"
        '
        'ContrapoPorTipoDePolizaToolStripMenuItem
        '
        Me.ContrapoPorTipoDePolizaToolStripMenuItem.Name = "ContrapoPorTipoDePolizaToolStripMenuItem"
        Me.ContrapoPorTipoDePolizaToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ContrapoPorTipoDePolizaToolStripMenuItem.Text = "Contrapo por tipo de poliza"
        '
        'mdi_Gerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "mdi_Gerente"
        Me.Text = "mdi_Gerente"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As ToolStripMenuItem
    Friend WithEvents MaestrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VehículoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarcaDeVehículoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoDeVehículoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParteDeVehículoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SiniestroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InspecciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoDeInspecciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlanDePagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CoberturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoDePolizaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadisticasDeInspeccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuotasPagasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadisticasDeSiniestroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresoPorContratoDePólizaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContrapoPorTipoDePolizaToolStripMenuItem As ToolStripMenuItem
End Class
