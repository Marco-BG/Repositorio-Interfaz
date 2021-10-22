<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ltb_listaIzquierda = New System.Windows.Forms.ListBox()
        Me.entradaListaIzquierda = New System.Windows.Forms.TextBox()
        Me.btn_borrarListaIzquierda = New System.Windows.Forms.Button()
        Me.btn_borrarListaMedio = New System.Windows.Forms.Button()
        Me.entradaListaMedio = New System.Windows.Forms.TextBox()
        Me.ltb_listaMedio = New System.Windows.Forms.ListBox()
        Me.btn_envia = New System.Windows.Forms.Button()
        Me.btn_regresa = New System.Windows.Forms.Button()
        Me.btn_borrarListaUltima = New System.Windows.Forms.Button()
        Me.entradaListaUltima = New System.Windows.Forms.TextBox()
        Me.ltb_listaUltima = New System.Windows.Forms.ListBox()
        Me.btn_regresa_secundario = New System.Windows.Forms.Button()
        Me.btn_envia_secundario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ltb_listaIzquierda
        '
        Me.ltb_listaIzquierda.AllowDrop = True
        Me.ltb_listaIzquierda.FormattingEnabled = True
        Me.ltb_listaIzquierda.ItemHeight = 15
        Me.ltb_listaIzquierda.Items.AddRange(New Object() {"Audi", "Ford", "Mazda", "Seat", "Toyota"})
        Me.ltb_listaIzquierda.Location = New System.Drawing.Point(59, 106)
        Me.ltb_listaIzquierda.Name = "ltb_listaIzquierda"
        Me.ltb_listaIzquierda.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ltb_listaIzquierda.Size = New System.Drawing.Size(120, 139)
        Me.ltb_listaIzquierda.Sorted = True
        Me.ltb_listaIzquierda.TabIndex = 0
        '
        'entradaListaIzquierda
        '
        Me.entradaListaIzquierda.Location = New System.Drawing.Point(59, 251)
        Me.entradaListaIzquierda.Name = "entradaListaIzquierda"
        Me.entradaListaIzquierda.Size = New System.Drawing.Size(120, 23)
        Me.entradaListaIzquierda.TabIndex = 1
        '
        'btn_borrarListaIzquierda
        '
        Me.btn_borrarListaIzquierda.Location = New System.Drawing.Point(59, 77)
        Me.btn_borrarListaIzquierda.Name = "btn_borrarListaIzquierda"
        Me.btn_borrarListaIzquierda.Size = New System.Drawing.Size(120, 23)
        Me.btn_borrarListaIzquierda.TabIndex = 2
        Me.btn_borrarListaIzquierda.Text = "Borrar primera"
        Me.btn_borrarListaIzquierda.UseVisualStyleBackColor = True
        '
        'btn_borrarListaMedio
        '
        Me.btn_borrarListaMedio.Location = New System.Drawing.Point(319, 77)
        Me.btn_borrarListaMedio.Name = "btn_borrarListaMedio"
        Me.btn_borrarListaMedio.Size = New System.Drawing.Size(120, 23)
        Me.btn_borrarListaMedio.TabIndex = 5
        Me.btn_borrarListaMedio.Text = "Borrar medio"
        Me.btn_borrarListaMedio.UseVisualStyleBackColor = True
        '
        'entradaListaMedio
        '
        Me.entradaListaMedio.Location = New System.Drawing.Point(319, 252)
        Me.entradaListaMedio.Name = "entradaListaMedio"
        Me.entradaListaMedio.Size = New System.Drawing.Size(120, 23)
        Me.entradaListaMedio.TabIndex = 4
        '
        'ltb_listaMedio
        '
        Me.ltb_listaMedio.AllowDrop = True
        Me.ltb_listaMedio.FormattingEnabled = True
        Me.ltb_listaMedio.ItemHeight = 15
        Me.ltb_listaMedio.Items.AddRange(New Object() {"Gato", "Leon", "Perro", "Pez"})
        Me.ltb_listaMedio.Location = New System.Drawing.Point(319, 106)
        Me.ltb_listaMedio.Name = "ltb_listaMedio"
        Me.ltb_listaMedio.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ltb_listaMedio.Size = New System.Drawing.Size(120, 139)
        Me.ltb_listaMedio.Sorted = True
        Me.ltb_listaMedio.TabIndex = 3
        '
        'btn_envia
        '
        Me.btn_envia.Location = New System.Drawing.Point(215, 77)
        Me.btn_envia.Name = "btn_envia"
        Me.btn_envia.Size = New System.Drawing.Size(75, 23)
        Me.btn_envia.TabIndex = 6
        Me.btn_envia.Text = "Envía ->"
        Me.btn_envia.UseVisualStyleBackColor = True
        '
        'btn_regresa
        '
        Me.btn_regresa.Location = New System.Drawing.Point(215, 251)
        Me.btn_regresa.Name = "btn_regresa"
        Me.btn_regresa.Size = New System.Drawing.Size(75, 23)
        Me.btn_regresa.TabIndex = 7
        Me.btn_regresa.Text = " <-Regresa"
        Me.btn_regresa.UseVisualStyleBackColor = True
        '
        'btn_borrarListaUltima
        '
        Me.btn_borrarListaUltima.Location = New System.Drawing.Point(587, 78)
        Me.btn_borrarListaUltima.Name = "btn_borrarListaUltima"
        Me.btn_borrarListaUltima.Size = New System.Drawing.Size(120, 23)
        Me.btn_borrarListaUltima.TabIndex = 10
        Me.btn_borrarListaUltima.Text = "Borrar última"
        Me.btn_borrarListaUltima.UseVisualStyleBackColor = True
        '
        'entradaListaUltima
        '
        Me.entradaListaUltima.Location = New System.Drawing.Point(587, 251)
        Me.entradaListaUltima.Name = "entradaListaUltima"
        Me.entradaListaUltima.Size = New System.Drawing.Size(120, 23)
        Me.entradaListaUltima.TabIndex = 9
        '
        'ltb_listaUltima
        '
        Me.ltb_listaUltima.AllowDrop = True
        Me.ltb_listaUltima.FormattingEnabled = True
        Me.ltb_listaUltima.ItemHeight = 15
        Me.ltb_listaUltima.Items.AddRange(New Object() {"Audi", "Ford", "Mazda", "Seat", "Toyota"})
        Me.ltb_listaUltima.Location = New System.Drawing.Point(587, 107)
        Me.ltb_listaUltima.Name = "ltb_listaUltima"
        Me.ltb_listaUltima.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ltb_listaUltima.Size = New System.Drawing.Size(120, 139)
        Me.ltb_listaUltima.Sorted = True
        Me.ltb_listaUltima.TabIndex = 8
        '
        'btn_regresa_secundario
        '
        Me.btn_regresa_secundario.Location = New System.Drawing.Point(477, 251)
        Me.btn_regresa_secundario.Name = "btn_regresa_secundario"
        Me.btn_regresa_secundario.Size = New System.Drawing.Size(75, 23)
        Me.btn_regresa_secundario.TabIndex = 12
        Me.btn_regresa_secundario.Text = " <-Regresa"
        Me.btn_regresa_secundario.UseVisualStyleBackColor = True
        '
        'btn_envia_secundario
        '
        Me.btn_envia_secundario.Location = New System.Drawing.Point(477, 77)
        Me.btn_envia_secundario.Name = "btn_envia_secundario"
        Me.btn_envia_secundario.Size = New System.Drawing.Size(75, 23)
        Me.btn_envia_secundario.TabIndex = 11
        Me.btn_envia_secundario.Text = "Envía ->"
        Me.btn_envia_secundario.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_regresa_secundario)
        Me.Controls.Add(Me.btn_envia_secundario)
        Me.Controls.Add(Me.btn_borrarListaUltima)
        Me.Controls.Add(Me.entradaListaUltima)
        Me.Controls.Add(Me.ltb_listaUltima)
        Me.Controls.Add(Me.btn_regresa)
        Me.Controls.Add(Me.btn_envia)
        Me.Controls.Add(Me.btn_borrarListaMedio)
        Me.Controls.Add(Me.entradaListaMedio)
        Me.Controls.Add(Me.ltb_listaMedio)
        Me.Controls.Add(Me.btn_borrarListaIzquierda)
        Me.Controls.Add(Me.entradaListaIzquierda)
        Me.Controls.Add(Me.ltb_listaIzquierda)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ltb_listaIzquierda As ListBox
    Friend WithEvents entradaLista As TextBox
    Friend WithEvents btn_borrarListaIzquierda As Button
    Friend WithEvents btn_borrarListaMedio As Button
    Friend WithEvents entradaListaMedio As TextBox
    Friend WithEvents ltb_listaMedio As ListBox
    Friend WithEvents btn_envia As Button
    Friend WithEvents btn_regresa As Button
    Friend WithEvents btn_borrarListaUltima As Button
    Friend WithEvents entradaListaUltima As TextBox
    Friend WithEvents ltb_listaUltima As ListBox
    Friend WithEvents btn_regresa_secundario As Button
    Friend WithEvents btn_envia_secundario As Button
    Friend WithEvents entradaListaIzquierda As TextBox
End Class
