Public Module Mod_Principal
    Public NombreUsuario As String 'variable que almacena el nombre del usuario
    Public TipoUsuario As String   'variable que almacena el tipo de usuario
    Public VerificarTipoUsuario As String 'variable que verifica el tipo de usuario y establece los permisos correspondientes
    Public tipou As String
    Public cont As Integer
    Public general As Boolean
    Public X As Integer    'variable que se utilizara en la funsion Timer
    Public Sub Validarletras(ByRef e As KeyPressEventArgs)
        If e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub ValidarNumero(ByRef e As KeyPressEventArgs)
        If (Asc(e.KeyChar) >= 48 And (Asc(e.KeyChar) <= 57)) Or Asc(e.KeyChar).Equals(8) Or Asc(e.KeyChar).Equals(13) Or Asc(e.KeyChar).Equals(127) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub Limpiar_Combobox(ByVal f As Form)
        ' recorrer todos los controles del formulario indicado  
        For Each c As Control In f.Controls
            If TypeOf c Is ComboBox Then
                c.Text = “” ' eliminar el texto  
            End If
        Next
    End Sub
    'Public Sub Limpiar_radiobutton(ByVal f As Form)
    ' recorrer todos los controles del formulario indicado  
    'For Each c As Control In f.Controls
    'If TypeOf c Is RadioButton Then

    ' c.Controls.Clear()
    'End If ' eliminar el texto  

    'Next
    'End Sub
    Public Sub Limpiar(ByVal c1 As Control)
        For Each c As Control In c1.Controls
            If TypeOf c Is TextBox Then
                c.Text = “” ' eliminar el texto
            Else
                Limpiar(c)
            End If
            If TypeOf c Is ComboBox Then
                c.Text = “” ' eliminar el texto
            Else
                Limpiar(c)
            End If
            If (TypeOf (c) Is CheckBox) Then
                CType(c, CheckBox).Checked = False
            Else
                Limpiar(c)
            End If
            If TypeOf c Is DateTimePicker Then
                c.Text = Date.Today ' eliminar el texto
            Else
                Limpiar(c)
            End If
            If (TypeOf (c) Is RadioButton) Then
                CType(c, RadioButton).Checked = False
            Else
                Limpiar(c)
            End If
            If TypeOf c Is RichTextBox Then
                c.Text = “” ' eliminar el texto
            Else
                Limpiar(c)
            End If
        Next
    End Sub
End Module



