Public Class frm_Pago
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frm_Pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function validarbusqueda() As Boolean
        Return True


    End Function
    Private Sub cargarAsegurados()
        sentencia = "Select a_cedula from asegurado where a_status='A' order by a_cedula"
        Me.txt_CedulaA.AutoCompleteCustomSource = Autocompletar(sentencia, "a_cedula")
        Me.txt_CedulaA.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txt_CedulaA.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub
    Private Sub cargarTomadores()
        sentencia = "Select t_cedula from tomador where t_status='A' order by t_cedula"
        Me.txt_CedulaT.AutoCompleteCustomSource = Autocompletar(sentencia, "t_cedula")
        Me.txt_CedulaT.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txt_CedulaT.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub
    Private Sub cargarCodigos()
        sentencia = "Select po_codigo from poliza where po_estatus='A' order by po_codigo"
        Me.txt_Codigo.AutoCompleteCustomSource = Autocompletar(sentencia, "po_codigo")
        Me.txt_Codigo.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txt_Codigo.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub
    Private Sub cargarcmbPlaca()
        sentencia = "Select v_placa from vehiculo where v_estatus='A' order by v_placa"
        CSelect(sentencia)
        dt.Load(sdr)
        Me.cmb_Placa.DataSource = dt

    End Sub

End Class