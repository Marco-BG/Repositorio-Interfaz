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
        Me.entradaLista = New System.Windows.Forms.TextBox()
        Me.btn_borrarLista = New System.Windows.Forms.Button()
        Me.btn_borrarDerecha = New System.Windows.Forms.Button()
        Me.entradaListaDerecha = New System.Windows.Forms.TextBox()
        Me.ltb_listaDerecha = New System.Windows.Forms.ListBox()
        Me.btn_envia = New System.Windows.Forms.Button()
        Me.btn_regresa = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ltb_listaIzquierda
        '
        Me.ltb_listaIzquierda.AllowDrop = True
        Me.ltb_listaIzquierda.FormattingEnabled = True
        Me.ltb_listaIzquierda.ItemHeight = 15
        Me.ltb_listaIzquierda.Items.AddRange(New Object() {"Ford", "Mazda", "Seat", "Audi", "Toyota"})
        Me.ltb_listaIzquierda.Location = New System.Drawing.Point(126, 106)
        Me.ltb_listaIzquierda.Name = "ltb_listaIzquierda"
        Me.ltb_listaIzquierda.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ltb_listaIzquierda.Size = New System.Drawing.Size(120, 139)
        Me.ltb_listaIzquierda.TabIndex = 0
        '
        'entradaLista
        '
        Me.entradaLista.Location = New System.Drawing.Point(126, 264)
        Me.entradaLista.Name = "entradaLista"
        Me.entradaLista.Size = New System.Drawing.Size(120, 23)
        Me.entradaLista.TabIndex = 1
        '
        'btn_borrarLista
        '
        Me.btn_borrarLista.Location = New System.Drawing.Point(126, 65)
        Me.btn_borrarLista.Name = "btn_borrarLista"
        Me.btn_borrarLista.Size = New System.Drawing.Size(120, 23)
        Me.btn_borrarLista.TabIndex = 2
        Me.btn_borrarLista.Text = "Borrar esta lista"
        Me.btn_borrarLista.UseVisualStyleBackColor = True
        '
        'btn_borrarDerecha
        '
        Me.btn_borrarDerecha.Location = New System.Drawing.Point(507, 65)
        Me.btn_borrarDerecha.Name = "btn_borrarDerecha"
        Me.btn_borrarDerecha.Size = New System.Drawing.Size(120, 23)
        Me.btn_borrarDerecha.TabIndex = 5
        Me.btn_borrarDerecha.Text = "Borrar lista derecha"
        Me.btn_borrarDerecha.UseVisualStyleBackColor = True
        '
        'entradaListaDerecha
        '
        Me.entradaListaDerecha.Location = New System.Drawing.Point(507, 264)
        Me.entradaListaDerecha.Name = "entradaListaDerecha"
        Me.entradaListaDerecha.Size = New System.Drawing.Size(120, 23)
        Me.entradaListaDerecha.TabIndex = 4
        '
        'ltb_listaDerecha
        '
        Me.ltb_listaDerecha.AllowDrop = True
        Me.ltb_listaDerecha.FormattingEnabled = True
        Me.ltb_listaDerecha.ItemHeight = 15
        Me.ltb_listaDerecha.Items.AddRange(New Object() {"Pez", "Leon", "Gato", "Perro"})
        Me.ltb_listaDerecha.Location = New System.Drawing.Point(507, 106)
        Me.ltb_listaDerecha.Name = "ltb_listaDerecha"
        Me.ltb_listaDerecha.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ltb_listaDerecha.Size = New System.Drawing.Size(120, 139)
        Me.ltb_listaDerecha.TabIndex = 3
        '
        'btn_envia
        '
        Me.btn_envia.Location = New System.Drawing.Point(352, 131)
        Me.btn_envia.Name = "btn_envia"
        Me.btn_envia.Size = New System.Drawing.Size(75, 23)
        Me.btn_envia.TabIndex = 6
        Me.btn_envia.Text = "Envía ->"
        Me.btn_envia.UseVisualStyleBackColor = True
        '
        'btn_regresa
        '
        Me.btn_regresa.Location = New System.Drawing.Point(352, 181)
        Me.btn_regresa.Name = "btn_regresa"
        Me.btn_regresa.Size = New System.Drawing.Size(75, 23)
        Me.btn_regresa.TabIndex = 7
        Me.btn_regresa.Text = " <-Regresa"
        Me.btn_regresa.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_regresa)
        Me.Controls.Add(Me.btn_envia)
        Me.Controls.Add(Me.btn_borrarDerecha)
        Me.Controls.Add(Me.entradaListaDerecha)
        Me.Controls.Add(Me.ltb_listaDerecha)
        Me.Controls.Add(Me.btn_borrarLista)
        Me.Controls.Add(Me.entradaLista)
        Me.Controls.Add(Me.ltb_listaIzquierda)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ltb_listaIzquierda As ListBox
    Friend WithEvents entradaLista As TextBox
    Friend WithEvents btn_borrarLista As Button
    Friend WithEvents btn_borrarDerecha As Button
    Friend WithEvents entradaListaDerecha As TextBox
    Friend WithEvents ltb_listaDerecha As ListBox
    Friend WithEvents btn_envia As Button
    Friend WithEvents btn_regresa As Button
End Class
