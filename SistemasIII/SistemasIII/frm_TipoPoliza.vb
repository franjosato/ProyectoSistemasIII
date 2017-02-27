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

        'se llena el checkedlistbox de cobertura
        CheckedListBox1.DataSource = Datos(sentencia)
        CheckedListBox1.DisplayMember = "c_nombre"
        CheckedListBox1.ValueMember = "c_codigo"
        CheckedListBox1.auto
        CheckedListBox1.SelectedIndex = -1
        'se llena el combobox de nombre de tipo_poliza
        sentencia1 = "select * from tipo_poliza"
        cmb_nombre_tp.DataSource = Datos(sentencia1)
        cmb_nombre_tp.DisplayMember = "tp_nombre_poliza"
        cmb_nombre_tp.ValueMember = "tp_codigo"
        cmb_nombre_tp.SelectedIndex = -1
        btn_Cancelar.PerformClick()


        cmb_nombre_tp.Enabled = True

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
        cmb_nombre_tp.Enabled=True

    End Sub

    Private Sub calcularmonto()
        Dim montobase As Double = 0
        Dim auxmonto As Double = 0

        'If ltb_Cobertura.SelectedIndices.Count > 0 Then

        For Each item As DataRowView In CheckedListBox1.CheckedItems
            Dim index As Integer
            For int As Integer = 0 To CheckedListBox1.Items.Count - 1
                If CheckedListBox1.GetItemChecked(int) = True Then
                    sentencia = "select * from cobertura where c_codigo='" & int + 1 & "'"
                    CSelect(sentencia)
                    ' MsgBox("hola")
                    auxmonto = sdr("c_costo")
                    montobase = 0
                    montobase += auxmonto
                    txt_monto_base.Text = montobase
                    Desconectar()
                End If
            Next


        Next


    End Sub



    Private Sub cmb_nombre_tp_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_nombre_tp.SelectionChangeCommitted
        If busquedacombo() Then
            For i As Integer = 0 To CheckedListBox1.Items.Count - 1
                If CheckedListBox1.GetItemChecked(i) = True Then
                    CheckedListBox1.SetItemChecked(i, False)
                End If
            Next
            busquedacoberturas()
            calcularmonto()
        End If

    End Sub

    Private Function busquedacombo() As Boolean
        sentencia = "select * from tipo_poliza where tp_codigo='" + cmb_nombre_tp.SelectedValue.ToString + "'"
        CSelect(sentencia)
        txt_Codigo.Text = sdr("tp_codigo")
        rtb_descripcion.Text = sdr("tp_descripcion")
        ' txt_monto_base.Text = sdr("tp_monto_base")
        Desconectar()
        Return True
    End Function
    Private Sub busquedacoberturas()
        sentencia1 = "select * from cobertura_poliza where cp_tp_codigo='" & txt_Codigo.Text & "'"
        CSelect(sentencia1)

        While sdr.Read()

            Dim i As Integer = 0
            Dim index As Integer = sdr("cp_c_codigo")
            For i = 0 To sdr.FieldCount - 1
                For int As Integer = 0 To CheckedListBox1.Items.Count - 1
                    CheckedListBox1.SetItemChecked(index - 1, True)
                    'MsgBox("hola")
                Next

            Next

        End While
        Desconectar()

    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        sentencia = "select * from tipo_poliza where tp_codigo='" + txt_Codigo.Text + "'"
        CSelect(sentencia)
        txt_Codigo.Text = sdr("tp_codigo")
        cmb_nombre_tp.Text = sdr("tp_nombre_poliza")
        rtb_descripcion.Text = sdr("tp_descripcion")
        'txt_monto_base.Text = sdr("tp_monto_base")
        Desconectar()
        busquedacoberturas()
        calcularmonto()

    End Sub
End Class