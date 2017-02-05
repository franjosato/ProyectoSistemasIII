Public Class frm_Contrato_Poliza
    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Limpiar(Me)
    End Sub

    Private Sub btn_Volver_Click(sender As Object, e As EventArgs) Handles btn_Volver.Click
        Limpiar(Me)
    End Sub

    Private Sub txt_CedulaA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_CedulaA.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_CedulaT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_CedulaT.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_Codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Codigo.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_Marca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Marca.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_Modelo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Modelo.KeyPress

    End Sub

    Private Sub txt_MontoBase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_MontoBase.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_MontoCuota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_MontoCuota.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_MontoPagar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_MontoPagar.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_NCuotas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_NCuotas.KeyPress
        ValidarNumero(e)
    End Sub

    Private Sub txt_PApellidoA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PApellidoA.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_PApellidoT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PApellidoT.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_Placa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Placa.KeyPress

    End Sub

    Private Sub txt_PNombreA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PNombreA.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_PNombreT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PNombreT.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_SApellidoA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SApellidoA.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_SApellidoT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SApellidoT.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_SNombreA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SNombreA.KeyPress
        Validarletras(e)
    End Sub

    Private Sub txt_SNombreT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SNombreT.KeyPress
        Validarletras(e)
    End Sub

    Private Sub dtp_Año_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Año.ValueChanged

    End Sub

    Private Sub frm_Contrato_Poliza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dtp_Año.CustomFormat = "yyyy"
    End Sub
End Class