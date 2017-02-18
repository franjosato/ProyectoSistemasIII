Public Class frm_Empleado
    Private Sub frm_Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lbl_EncabezadoFormuladio_Click(sender As Object, e As EventArgs) Handles lbl_EncabezadoFormuladio.Click

    End Sub

    Private Sub lbl_EncabezadoModulo_Click(sender As Object, e As EventArgs) Handles lbl_EncabezadoModulo.Click

    End Sub

    Private Sub txt_Cedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Cedula.KeyPress
        ValidarNumero(txt_Cedula)
        If (e.KeyChar = "\b") Then

        End If
    End Sub

    Private Sub txt_Cedula_TextChanged(sender As Object, e As EventArgs) Handles txt_Cedula.TextChanged
        ValidarNumero(txt_Cedula)
    End Sub
    Private Sub HabilitarCampos(ByRef sn As Boolean)

        Me.cmb_Nacionalidad.Enabled = Not sn
        Me.txt_Cedula.Enabled = Not sn
        Me.txt_PNombre.Enabled = sn
        Me.txt_SNombre.Enabled = sn
        Me.txt_PApellido.Enabled = sn
        Me.txt_SApellido.Enabled = sn
        Me.txt_Correo.Enabled = sn
        Me.txt_TlfFijo.Enabled = sn
        Me.cmb_Tipoempleado.Enabled = sn

    End Sub

    Private Sub HabilitarBotones(ByRef sn As Boolean)

        Me.btn_Agregar.Enabled = Not sn
        Me.btn_Buscar.Enabled = True
        Me.btn_Modificar.Enabled = True
        Me.btn_Cancelar.Enabled = Not True
        Me.btn_Eliminar.Enabled = True
        Me.btn_Volver.Enabled = True

    End Sub

    Private Sub txt_PNombre_TextChanged(sender As Object, e As EventArgs) Handles txt_PNombre.TextChanged
        Validarletras(Me.txt_PNombre)
    End Sub

    Private Sub txt_SNombre_TextChanged(sender As Object, e As EventArgs) Handles txt_SNombre.TextChanged
        Validarletras(Me.txt_SNombre)
    End Sub

    Private Sub txt_PApellido_TextChanged(sender As Object, e As EventArgs) Handles txt_PApellido.TextChanged
        Validarletras(Me.txt_PApellido)
    End Sub

    Private Sub txt_SApellido_TextChanged(sender As Object, e As EventArgs) Handles txt_SApellido.TextChanged
        Validarletras(Me.txt_SApellido)
    End Sub

    Private Sub txt_TlfFijo_TextChanged(sender As Object, e As EventArgs) Handles txt_TlfFijo.TextChanged
        ValidarNumero(Me.txt_TlfFijo)
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        If (Me.cmb_Nacionalidad.Text = "") Or (Me.txt_Cedula.Text = "") Then
            MsgBox("Debe llenar ambos campos", vbInformation, "Error")
            Return
        End If


    End Sub
End Class
