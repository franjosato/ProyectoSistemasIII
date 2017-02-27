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
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub ValidarletrasConEspacio(ByRef e As KeyPressEventArgs)
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
    Public Sub ValidarNoescritura(ByRef e As KeyPressEventArgs)

        e.Handled = True

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
            'colo cada textbox vacios dentro del formulario
            If TypeOf c Is TextBox Then
                c.Text = “” ' eliminar el texto
            Else
                Limpiar(c)
            End If
            'coloca el item seleccionado en vacio
            If TypeOf c Is ComboBox Then
                c.Text = “” ' eliminar el texto
            Else
                Limpiar(c)
            End If
            'anula la seleccion de los checkbox
            If (TypeOf (c) Is CheckBox) Then
                CType(c, CheckBox).Checked = False
            Else
                Limpiar(c)
            End If
            'estable la fecha actual en el datepicker
            If TypeOf c Is DateTimePicker Then
                c.Text = Date.Today ' eliminar el texto
            Else
                Limpiar(c)
            End If
            'anula la seleccion de los radio button
            If (TypeOf (c) Is RadioButton) Then
                CType(c, RadioButton).Checked = False
            Else
                Limpiar(c)
            End If
            ' establece en vacio el texto de los richtextbox
            If TypeOf c Is RichTextBox Then
                c.Text = “” ' eliminar el texto
            Else
                Limpiar(c)
            End If
            'anula las selecciones de un listbox
            If TypeOf c Is ListBox Then
                CType(c, ListBox).ClearSelected()
            Else
                Limpiar(c)
            End If

        Next
    End Sub

    Public Function validar_controles(ByVal con As Control) As Boolean
        For Each c As Control In con.Controls

            If TypeOf c Is GroupBox Then

                For Each co As Control In c.Controls

                    If TypeOf co Is TextBox Then

                        If co.Text.Length = 0 Then

                            co.Focus()
                            Return False
                            ' MsgBox("No puede dejar campos vacios", vbExclamation, "Advertencia")
                        End If
                        'Return False
                    ElseIf TypeOf co Is ComboBox Then

                        Dim aux As ComboBox = co

                        If co.Text.Length = 0 Then
                            co.Focus()
                            Return False
                        End If
                    ElseIf TypeOf co Is RichTextBox Then
                        If co.Text.Length = 0 Then
                            co.Focus()


                            Return False
                        End If
                    End If
                Next
                ' Return False
            End If

        Next
        Return True
    End Function

    Public Sub HCampos(ByVal con As Control, ByRef sn As Boolean, ByVal campoactivo As Control)

        For Each c As Control In con.Controls

            If TypeOf c Is GroupBox Then

                For Each co As Control In c.Controls

                    If TypeOf co Is TextBox Then
                        co.Enabled = sn
                    ElseIf TypeOf co Is RichTextBox Then
                        co.Enabled = sn
                    ElseIf TypeOf co Is ComboBox Then
                        co.Enabled = sn
                    ElseIf TypeOf co Is DateTimePicker Then
                        co.Enabled = sn
                    ElseIf TypeOf co Is RadioButton Then
                        co.Enabled = sn
                    ElseIf TypeOf co Is GroupBox Then
                        For Each cont As Control In co.Controls
                            If TypeOf cont Is TextBox Then
                                cont.Enabled = sn
                            ElseIf TypeOf cont Is RichTextBox Then
                                cont.Enabled = sn
                            ElseIf TypeOf cont Is ComboBox Then
                                cont.Enabled = sn
                            ElseIf TypeOf cont Is DateTimePicker Then
                                co.Enabled = sn
                            ElseIf TypeOf cont Is RadioButton Then
                                cont.Enabled = sn
                            End If
                        Next
                    End If
                Next

            End If
        Next
        campoactivo.Enabled = Not sn
    End Sub
    'falta acomodar
    Private Sub HBotones(ByVal con As Control, ByRef sn As Boolean, ByVal campoactivo As Control)

        For Each c As Control In con.Controls

            If TypeOf c Is GroupBox Then



                For Each co As Control In c.Controls

                    If TypeOf co Is Button Then
                        co.Enabled = sn

                    ElseIf TypeOf co Is GroupBox Then
                        For Each cont As Control In co.Controls
                            If TypeOf cont Is Button Then
                                cont.Enabled = sn
                            End If
                        Next
                    End If
                Next

            Else
                If TypeOf c Is Button Then
                    c.Enabled = sn
                End If
            End If

        Next
        campoactivo.Enabled = Not sn
    End Sub
End Module



