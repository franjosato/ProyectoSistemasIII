Public Class frm_TipoPoliza
    Private Sub HBotones(ByRef sn As Boolean)
        Me.btn_Agregar.Enabled = sn
        Me.btn_Buscar.Enabled = Not sn
        'Me.btn_Cancelar.Enabled = Not sn
        btn_Eliminar.Enabled = sn
        Me.btn_Modificar.Enabled = sn
        ' Me.btn_Volver.Enabled = Not sn
    End Sub
    Private Sub frm_TipoPoliza_Load(sender As Object, e As EventArgs) Handles Me.Load
        'iniciar el reloj y la fehca
        tmr_Fecha.Start()
        sentencia = "select * from cobertura"
        'se llena el listbox de cobertura
        ltb_Cobertura.DataSource = Datos(sentencia)
        ltb_Cobertura.DisplayMember = "c_nombre"
        ltb_Cobertura.ValueMember = "c_codigo"
        ltb_Cobertura.SelectedIndex = -1
        btn_Cancelar.PerformClick()

    End Sub

    Private Sub tmr_Fecha_Tick(sender As Object, e As EventArgs) Handles tmr_Fecha.Tick
        lbl_Fecha.Text = DateString
        lbl_Hora.Text = TimeOfDay
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        txt_Codigo.Focus()
        ActiveControl() = txt_Codigo
        Limpiar(Me)
        HCampos(Me, False, txt_Codigo)
        HBotones(False)
        btn_Modificar.Text = "Modificar"

    End Sub

    Private Sub calcularmonto()
        Dim montobase As Double
        Dim auxmonto As Double

        'If ltb_Cobertura.SelectedIndices.Count > 0 Then

        For Each item As DataRowView In ltb_Cobertura.SelectedItems
            Dim row As DataRow = item.Row
            sentencia = "select * from cobertura where c_codigo='" & row(ltb_Cobertura.SelectedIndex) & "'"
            CSelect(sentencia)

            auxmonto = sdr("c_costo")
            montobase += auxmonto
            txt_monto_base.Text = montobase
            Desconectar()
        Next


    End Sub

    Private Sub ltb_Cobertura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltb_Cobertura.SelectedIndexChanged
        calcularmonto()
    End Sub
End Class