﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TipoPoliza
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
        Me.lbl_Codigo = New System.Windows.Forms.Label()
        Me.grb_Tipo_Poliza = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grb_Cobertura = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ltb_Cobertura = New System.Windows.Forms.ListBox()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Volver = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.grb_Tipo_Poliza.SuspendLayout()
        Me.grb_Cobertura.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Codigo
        '
        Me.lbl_Codigo.AutoSize = True
        Me.lbl_Codigo.Location = New System.Drawing.Point(37, 35)
        Me.lbl_Codigo.Name = "lbl_Codigo"
        Me.lbl_Codigo.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Codigo.TabIndex = 0
        Me.lbl_Codigo.Text = "Código:"
        '
        'grb_Tipo_Poliza
        '
        Me.grb_Tipo_Poliza.Controls.Add(Me.Label3)
        Me.grb_Tipo_Poliza.Controls.Add(Me.txt_Nombre)
        Me.grb_Tipo_Poliza.Controls.Add(Me.RichTextBox1)
        Me.grb_Tipo_Poliza.Controls.Add(Me.Label2)
        Me.grb_Tipo_Poliza.Controls.Add(Me.grb_Cobertura)
        Me.grb_Tipo_Poliza.Controls.Add(Me.btn_Buscar)
        Me.grb_Tipo_Poliza.Controls.Add(Me.txt_Codigo)
        Me.grb_Tipo_Poliza.Controls.Add(Me.lbl_Codigo)
        Me.grb_Tipo_Poliza.Location = New System.Drawing.Point(7, 167)
        Me.grb_Tipo_Poliza.Name = "grb_Tipo_Poliza"
        Me.grb_Tipo_Poliza.Size = New System.Drawing.Size(614, 222)
        Me.grb_Tipo_Poliza.TabIndex = 1
        Me.grb_Tipo_Poliza.TabStop = False
        Me.grb_Tipo_Poliza.Text = "Datos del tipo de póliza"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Descripción:"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(86, 69)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(181, 20)
        Me.txt_Nombre.TabIndex = 6
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(86, 105)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(181, 96)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre:"
        '
        'grb_Cobertura
        '
        Me.grb_Cobertura.Controls.Add(Me.Label1)
        Me.grb_Cobertura.Controls.Add(Me.ltb_Cobertura)
        Me.grb_Cobertura.Location = New System.Drawing.Point(304, 17)
        Me.grb_Cobertura.Name = "grb_Cobertura"
        Me.grb_Cobertura.Size = New System.Drawing.Size(282, 194)
        Me.grb_Cobertura.TabIndex = 3
        Me.grb_Cobertura.TabStop = False
        Me.grb_Cobertura.Text = "Datos Cobertura"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione las coberturas asociadas:"
        '
        'ltb_Cobertura
        '
        Me.ltb_Cobertura.FormattingEnabled = True
        Me.ltb_Cobertura.Location = New System.Drawing.Point(23, 41)
        Me.ltb_Cobertura.Name = "ltb_Cobertura"
        Me.ltb_Cobertura.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ltb_Cobertura.Size = New System.Drawing.Size(242, 147)
        Me.ltb_Cobertura.TabIndex = 0
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Location = New System.Drawing.Point(192, 30)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Enabled = False
        Me.txt_Codigo.Location = New System.Drawing.Point(86, 32)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_Codigo.TabIndex = 1
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Location = New System.Drawing.Point(280, 394)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 21
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Volver
        '
        Me.btn_Volver.Location = New System.Drawing.Point(469, 394)
        Me.btn_Volver.Name = "btn_Volver"
        Me.btn_Volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_Volver.TabIndex = 20
        Me.btn_Volver.Text = "Vovler"
        Me.btn_Volver.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(377, 394)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 19
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Location = New System.Drawing.Point(89, 394)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Agregar.TabIndex = 17
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Location = New System.Drawing.Point(182, 394)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Modificar.TabIndex = 18
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'frm_TipoPoliza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.SistemasIII.My.Resources.Resources.frm23
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(633, 428)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Volver)
        Me.Controls.Add(Me.grb_Tipo_Poliza)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Name = "frm_TipoPoliza"
        Me.Text = "Form2"
        Me.grb_Tipo_Poliza.ResumeLayout(False)
        Me.grb_Tipo_Poliza.PerformLayout()
        Me.grb_Cobertura.ResumeLayout(False)
        Me.grb_Cobertura.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_Codigo As Label
    Friend WithEvents grb_Tipo_Poliza As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents grb_Cobertura As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ltb_Cobertura As ListBox
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents txt_Codigo As TextBox
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btn_Volver As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents btn_Modificar As Button
End Class
