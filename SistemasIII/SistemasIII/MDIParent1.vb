Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub




    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub TomadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TomadoToolStripMenuItem.Click
        frm_Tomador.Show()
    End Sub

    Private Sub TipoDeInspeccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeInspeccionToolStripMenuItem.Click
        frm_TipoInspeccion.Show()
    End Sub

    Private Sub AseguradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AseguradoToolStripMenuItem.Click
        frm_Asegurado.Show()
    End Sub



    Private Sub TipoDePolizaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDePolizaToolStripMenuItem.Click
        frm_TipoPoliza.Show()
    End Sub



    Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click
        frm_Empleado.Show()
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        frm_Usuario.Show()

    End Sub

    Private Sub SiniestroToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SiniestroToolStripMenuItem1.Click
        frm_Siniestro.Show()
    End Sub

    Private Sub VehiculoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VehiculoToolStripMenuItem1.Click
        frm_Vehiculo.Show()
    End Sub

    Private Sub TipoDeVehiculoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeVehiculoToolStripMenuItem.Click
        frm_TipoVehiculo.Show()
    End Sub

    Private Sub CuotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuotasToolStripMenuItem.Click
        frm_Cuotas.Show()
    End Sub

    Private Sub PagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagoToolStripMenuItem.Click
        frm_Pago.Show()
    End Sub

    Private Sub ListasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListasToolStripMenuItem.Click
        frm_Listas.Show()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        ModoMenu = "Agregar"
        CedulaEmpleado = "12345678"
        TipoUsuario = "Corredor"
        frm_Contrato_Poliza.Show()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        ModoMenu = "Consultar"
        CedulaEmpleado = "12345678"
        TipoUsuario = "Gerente"
        frm_Contrato_Poliza.Show()
    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-VE")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "yyyy/MM/dd"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
    End Sub
End Class
